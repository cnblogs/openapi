using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Cnblogs.OpenAPI.Client.SampleWebApp.Options
{
    public class OpenApiOptions
    {
        public string ApiUrl { get; set; }
        public string OauthUrl { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string RedirectUri { get; set; }
    }
}
