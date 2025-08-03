using System.Text.Json.Nodes;

namespace FhirCore.Interfaces
{
    public interface IElement
    {
        void SetElementValue(JsonNode? value);
        JsonNode? GetElementValue();

    }
}