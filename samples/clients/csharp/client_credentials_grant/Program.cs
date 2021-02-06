using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace client_credentials_grant
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

                var parameters = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    ["client_id"] = clientId,
                    ["client_secret"] = clientSecret,
                    ["grant_type"] = "client_credentials"
                });

                var response = await httpClient.PostAsync("https://api.cnblogs.com/token", parameters);
                Console.WriteLine(response.StatusCode);
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
        }
    }
}
