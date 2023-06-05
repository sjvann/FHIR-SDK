using System.Text.Json.Serialization;

namespace Core.CdsHooks.Cards
{
    public class SuggestionModel
    {
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        [JsonPropertyName("uuid")]
        public string? Uuid { get; set; }
        [JsonPropertyName("actions")]
        public List<ActionModel>? Actions { get; set; }

    }
}