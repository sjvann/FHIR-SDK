using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.CdsHooks.Cards
{
    public class LinkModel
    {
        [Required]
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        [Required]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        [Required]
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("appContext")]
        public string? AppContext { get; set; }
    }
}