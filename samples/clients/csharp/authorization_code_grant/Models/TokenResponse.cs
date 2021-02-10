using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cnblogs.OpenAPI.Client.Samples.Models
{
    public class TokenResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }
        [JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }
        [JsonPropertyName("error")]
        public string Error { get; set; }
        [JsonPropertyName("error_description")]
        public string ErrorDescription { get; set; }
    }
}
