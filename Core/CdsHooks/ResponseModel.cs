


using Core.CdsHooks.Cards;
using System.Text.Json.Serialization;
namespace Core.CdsHooks
{
    public class ResponseModel
    {
        [JsonPropertyName("cards")]
        public List<CardModel>? Cards { get; set; }

        [JsonPropertyName("systemActions")]
        public List<SystemActionsModel>? SystemActions { get; set; }
    }
}
