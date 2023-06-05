using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.CdsHooks.Request
{
    public class FhirAuthorizationModel
    {
        [Required]
        [JsonPropertyName("access_token")]
        public string? Access_token { get; set; }
        [Required]
        [JsonPropertyName("token_type")]
        public string? Token_type { get; set; }
        [JsonPropertyName("expires_in")]
        public int? Expires_in { get; set; }
        [JsonPropertyName("scope")]
        public string? Scope { get; set; }
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }
    }
}