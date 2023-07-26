using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cnblogs.OpenAPI.Client.SampleWebApp.Models;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.WebUtilities;
using System.IO;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using IdentityModel;
using System.Text.Json;
using Microsoft.Extensions.Caching.Memory;
using System.Net.Http.Headers;
using Cnblogs.OpenAPI.Client.SampleWebApp.Options;

namespace Cnblogs.OpenAPI.Client.SampleWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly OpenApiOptions _apiOptions;
        private readonly IMemoryCache _memoryCache;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            IOptions<OpenApiOptions> apiOptions,
            IMemoryCache memoryCache,
            IHttpClientFactory httpClientFactory,
            ILogger<HomeController> logger)
        {
            _memoryCache = memoryCache;
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _apiOptions = apiOptions.Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        // 第一步 - 用户授权
        [Route("authorize")]
        public IActionResult Authorize()
        {
            // See http://docs.identityserver.io/en/latest/endpoints/authorize.html
            var url = QueryHelpers.AddQueryString(
                $"{_apiOptions.OauthUrl}/connect/authorize",
                new Dictionary<string, string>
                {
                    ["client_id"] = _apiOptions.ClientId,
                    ["scope"] = "openid profile CnBlogsApi offline_access",
                    ["response_type"] = "code id_token",
                    ["redirect_uri"] = _apiOptions.RedirectUri,
                    ["state"] = "cnblogs open api",
                    ["nonce"] = Guid.NewGuid().ToString(),
                    ["response_mode"] = "form_post"
                });

            return Redirect(url);
        }

        // 第二步 - 授权成功：拿到 code 与 id token
        [Route("callback")]
        public async Task<IActionResult> Callback(string code, string id_token, string scope, string state, string session_state)
        {
            // using var sr = new StreamReader(Request.Body);
            // _logger.LogInformation("Request.Body:\n{RequestBody}", await sr.ReadToEndAsync());

            _memoryCache.Set("code", code);

            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(id_token);

            var sb = new StringBuilder();
            foreach (var claim in token.Claims)
            {
                sb.Append($"{claim.Type}: {claim.Value}" + Environment.NewLine);
            }

            _logger.LogInformation("Claims: \n{Claims}\n", sb.ToString());

            (string DisplayName, string Blog) model = (
                token.Claims.FirstOrDefault(c => c.Type == JwtClaimTypes.Name)?.Value,
                token.Claims.FirstOrDefault(c => c.Type == JwtClaimTypes.WebSite)?.Value);

            return View(model);
        }

        // 第三步 - 通过 code 拿到 access token 与 refresh token
        [Route("accesstoken")]
        public async Task<IActionResult> AccessToken()
        {
            var httpClient = _httpClientFactory.CreateClient();

            var parameters = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["client_id"] = _apiOptions.ClientId,
                ["client_secret"] = _apiOptions.ClientSecret,
                ["grant_type"] = "authorization_code",
                ["code"] = _memoryCache.Get<string>("code"),
                ["redirect_uri"] = _apiOptions.RedirectUri
            });

            var response = await httpClient.PostAsync($"{_apiOptions.OauthUrl}/connect/token", parameters);

            _logger.LogInformation("Response status code {status}", response.StatusCode);
            var responseText = await response.Content.ReadAsStringAsync();
            _logger.LogInformation("Response text: \n{ResponseText}", responseText);

            if (!response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Error), new { message = responseText });
            }

            var tokenResponse = await response.Content.ReadFromJsonAsync<TokenResponse>();

            _memoryCache.Set(nameof(TokenResponse.AccessToken), tokenResponse.AccessToken);
            _memoryCache.Set(nameof(TokenResponse.RefreshToken), tokenResponse.RefreshToken);

            return View(tokenResponse);
        }

        // 第四步 - 通过 access token 获取当前用户的博文列表
        [Route("blogposts")]
        public async Task<IActionResult> BlogPosts()
        {
            var accessToken = _memoryCache.Get<string>(nameof(TokenResponse.AccessToken));

            var httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri(_apiOptions.ApiUrl);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var response = await httpClient.GetAsync("/api/blog/v2/blogposts");
            if (!response.IsSuccessStatusCode)
            {
                var responseText = await response.Content.ReadAsStringAsync();
                _logger.LogError("Failed to request {Uri}. Status code is {StatusCode}.\nResponse text:\n{ResponseText}",
                    response.RequestMessage.RequestUri,
                    (int)response.StatusCode,
                    responseText);
                return Content(responseText);
            }
            var blogPosts = await response.Content.ReadFromJsonAsync<List<BlogPost>>();
            return View(blogPosts);
        }

        // 第五步 - 用 refresh token 刷新 access token
        [Route("refreshtoken")]
        public async Task<IActionResult> RefreshToken()
        {
            var httpClient = _httpClientFactory.CreateClient();

            var parameters = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["client_id"] = _apiOptions.ClientId,
                ["client_secret"] = _apiOptions.ClientSecret,
                ["grant_type"] = "refresh_token",
                ["refresh_token"] = _memoryCache.Get<string>(nameof(TokenResponse.RefreshToken))
            });

            var response = await httpClient.PostAsync($"{_apiOptions.OauthUrl}/connect/token", parameters);

            _logger.LogInformation("Response status code {status}", response.StatusCode);

            var responseText = await response.Content.ReadAsStringAsync();
            _logger.LogInformation("Response text: \n{ResponseText}", responseText);

            if (!response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Error), new { message = responseText });
            }

            var tokenResponse = await response.Content.ReadFromJsonAsync<TokenResponse>();

            _memoryCache.Set(nameof(TokenResponse.AccessToken), tokenResponse.AccessToken);
            _memoryCache.Set(nameof(TokenResponse.RefreshToken), tokenResponse.RefreshToken);

            return View(tokenResponse);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string message)
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                ErrorMessage = message
            });
        }
    }
}
