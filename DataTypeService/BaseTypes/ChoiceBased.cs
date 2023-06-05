using System.Text.Json.Nodes;

namespace DataTypeService.BaseTypes
{
    public class ChoiceBased
    {
        private readonly string? _keyName;
        private readonly JsonNode? _value;
        private readonly string? _typeName;

        public string? TypeName => _typeName;
        public ChoiceBased() { }
        public ChoiceBased(KeyValuePair<string, JsonNode?> current)
        {
            _keyName = current.Key;
            _value = current.Value;
        }
        public ChoiceBased(string? keyName, JsonNode? value)
        {
            _keyName = keyName;
            if (value != null)
            {
                _value = JsonNode.Parse(value.ToJsonString());
            }

        }
        public ChoiceBased(string prefix, IComplexType? value)
        {
            if (value != null)
            {
                _typeName = value.GetTypeName();
                _keyName = $"{prefix}{_typeName}";
                _value = value.GetJsonNode();

            }
        }
        public ChoiceBased(string prefix, IPrimitiveType? value)
        {
            if (value != null)
            {
                _typeName = value.GetTypeName();
                _keyName = $"{prefix}{_typeName}";
                _value = value.GetJsonValue();
            }
        }
        public JsonNode? GetJsonNode()
        {
            JsonObject result = new();
            result.Add(GetProperty());
            return result;
        }
        public KeyValuePair<string, JsonNode?> GetProperty()
        {
            if (string.IsNullOrEmpty(_keyName))
            {
                return new KeyValuePair<string, JsonNode?>("value", _value);
            }
            else
            {
                return new KeyValuePair<string, JsonNode?>(_keyName, _value);
            }
        }

    }
}
