using System.Text.Json.Nodes;

namespace FhirCore.Interfaces
{
    public interface IPrimitiveType : IDataType
    {
        public bool IsValidValue();
        public JsonValue? GetJsonValue();
        public JsonObject? GetElementJsonObject();
        public string GetElementJsonString();
        public new string GetFhirTypeName(bool withCapital = true);
        public void SetElementObject(JsonNode? element);
        public bool HasElement();
        public bool ValueEquals(object? other);
        public object? GetValue();
    }
}