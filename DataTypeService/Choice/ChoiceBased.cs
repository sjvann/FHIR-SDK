using DataTypeService.Based;
using System.Text.Json.Nodes;

namespace DataTypeService.Choice
{
    public class ChoiceBased : DataType, IChoiceType
    {
        private readonly string? _keyName;
        private readonly JsonNode? _value;

        public ChoiceBased() { }
        public ChoiceBased(KeyValuePair<string, JsonNode?> current)
        {
            _keyName = current.Key;
            _value = current.Value;
        }
        public ChoiceBased(string? keyName, JsonNode? value)
        {
            _keyName = keyName;
            _value = value;
        }
        public ChoiceBased(string prefix, IComplexType? value)
        {
            if (value != null)
            {
                _keyName = $"{prefix}{value.GetTypeName()}";
                _value = value.GetJsonNode();
            }
        }
        public ChoiceBased(string prefix, IPrimitiveType? value)
        {
            if (value != null)
            {
                _keyName = $"{prefix}{value.GetTypeName()}";
                _value = value.GetJsonValue();
            }
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
        public IEnumerable<KeyValuePair<string, JsonNode?>>? GetProperties()
        {
            if(_Properties == null)
            {  
                 List<KeyValuePair<string, JsonNode?>> _p = new()
                 {
                     GetProperty()
                 };
                _Properties = _p;
            }
            return _Properties;
        }

        public void SetProperties()
        {
            // Method intentionally left empty.
        }
    }
}
