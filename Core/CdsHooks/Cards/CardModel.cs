using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.CdsHooks.Cards
{
    public class CardModel
    {
        [JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        [Required]
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        [JsonPropertyName("detail")]
        public string? Detail { get; set; }

        [Required]
        [JsonPropertyName("indicator")]
        public string? Indicator { get; set; }

        [Required]
        [JsonPropertyName("source")]
        public SourceModel? Source { get; set; }


        [JsonPropertyName("suggestions")]
        public List<SuggestionModel>? Suggestions { get; set; }


        [JsonPropertyName("selectionBehavior")]
        public string? SelectionBehavior { get; set; }

        [JsonPropertyName("overrideReasons")]
        public List<CdsCoding>? OverrideReasons { get; set; }


        [JsonPropertyName("links")]
        public List<LinkModel>? Links { get; set; }
    }
}
