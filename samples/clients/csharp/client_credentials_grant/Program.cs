using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cnblogs.OpenAPI.Client.SampleConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Please follow ClientId and ClientSecret");
                return;
            }

            var clientId = args[0];
            var clientSecret = args[1];

            var host = new HostBuilder()
               .ConfigureServices((context, services) =>
               {
                   services.AddHttpClient();
               })
               .Build();

            using (var scope = host.Services.CreateScope())
            {
                var httpClient = scope.ServiceProvider.GetRequiredService<IHttpClientFactory>().CreateClient();
                httpClient.BaseAddress = new Uri("https://api.cnblogs.com");

                var request = new TokenRequest
                {
                    Address = "https://api.cnblogs.com/token",
                    ClientId = clientId,
                    ClientSecret = clientSecret,
                    GrantType = "client_credentials"
                };

                var responseToken = await httpClient.RequestTokenAsync(request);
                Console.WriteLine("Access token: ");
                Console.WriteLine(responseToken.AccessToken);

                httpClient.SetBearerToken(responseToken.AccessToken);

                await GetBlogPosts(httpClient, "sitehome", "网站首页博文:");
                await GetBlogPosts(httpClient, "sitehome", "编辑推荐博文:");
                await GetBlogPosts(httpClient, "mostliked", "博文推荐排行:");
                await GetBlogPosts(httpClient, "mostread", "博文阅读排行:");
            }
        }

        private static async Task GetBlogPosts(HttpClient httpClient, string aggSiteName, string listTitle)
        {
            var urlPath = $"/api/blog/v2/blogposts/aggsites/{aggSiteName}?pageIndex=1&pageSize=1";
            Console.WriteLine();
            Console.WriteLine(listTitle);
            Console.WriteLine(await httpClient.GetStringAsync(urlPath));
        }
    }
}
