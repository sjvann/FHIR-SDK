using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace Core.CdsHooks.Cards
{
    public class ActionModel
    {
        [Required]
        [JsonPropertyName("type")]
        public string? ActionType { get; set; }
        [Required]
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("resource")]
        public object? Resource { get; set; }
        [JsonPropertyName("resourceId")]
        public string? ResourceId { get; set; }
    }
}