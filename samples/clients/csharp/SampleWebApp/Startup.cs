using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cnblogs.OpenAPI.Client.SampleWebApp.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Cnblogs.OpenAPI.Client.SampleWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<OpenApiOptions>(Configuration.GetSection("OpenApi"));
            services.AddControllersWithViews();
            services.AddMemoryCache();
            services.AddHttpClient();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IOptions<OpenApiOptions> options)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            var apiOptions = options.Value;
            Console.WriteLine("Started sample web app for authorization code grant type");
            Console.WriteLine($"API url: {apiOptions.ApiUrl}");
            Console.WriteLine($"Client id: {apiOptions.ClientId}");
        }
    }
}
