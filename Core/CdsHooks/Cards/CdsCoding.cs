using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.CdsHooks.Cards
{
    public class CdsCoding
    {
        [Required]
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("system")]
        public string? System { get; set; }

        [JsonPropertyName("display")]
        public string? Display { get; set; }
    }
}