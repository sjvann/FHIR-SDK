using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.CdsHooks.Cards
{
    public class SourceModel
    {
        [Required]
        [JsonPropertyName("label")]
        public string? Label { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("icon")]
        public string? Icon { get; set; }

        [JsonPropertyName("topic")]
        public CdsCoding? Topic { get; set; }
    }
}