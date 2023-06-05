
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.CdsHooks.Request
{
    public class RequestModel
    {
        [Required]
        [JsonPropertyName("hook")]

        public string? Hook { get; set; }
        [Required]
        [JsonPropertyName("hookInstance")]
        public string? HookInstance { get; set; }
        [JsonPropertyName("fhirServer")]
        public string? FhirServer { get; set; }
        [JsonPropertyName("fhirAuthorization")]
        public FhirAuthorizationModel? FhirAuthorization { get; set; }
        [Required]
        [JsonPropertyName("context")]
        public object? Context { get; set; }
        [JsonPropertyName("prefetch")]
        public object? Prefetch { get; set; }
    }
}
