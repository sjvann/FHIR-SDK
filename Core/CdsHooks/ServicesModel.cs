using System.Text.Json.Serialization;

namespace Core.CdsHooks
{
    public class ServicesModel
    {
        [JsonPropertyName("services")]
        public IEnumerable<HookServiceModel>? Services { get; set; }
    }
}