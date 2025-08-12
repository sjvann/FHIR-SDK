using System.Text.Json.Nodes;

namespace FhirCore.Interfaces
{
    public interface IChoiceType
    {
        public string GetPrefixName(bool withCapital = true);
        JsonNode? GetJsonNode();
        KeyValuePair<string, JsonNode?> GetProperty();

        List<string>? GetSupportDataType();
        List<string> SetSupportDataType();
        string GetDataTypeName();
        string? GetValue();
    }
}
