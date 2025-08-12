using FhirCore.ExtensionMethods;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;

namespace DataTypeServices.TypeFramework
{
    public abstract class ChoiceType: DataType, IChoiceType
    {
        private readonly string? _keyName;
        private readonly JsonNode? _value;
        protected ChoiceType(JsonNode? value)
        {
            if (value is JsonObject jsonObject)
            {
                var key = jsonObject.FirstOrDefault().Key;
                if (key != null)
                {
                    _keyName = key;
                    _value = jsonObject[key];
                }
            }
        }
        protected ChoiceType(string dataType, JsonNode? value)
        {
            _keyName = $"{dataType.ToTitleCase(true)}";
            _value = value;
        }
        protected ChoiceType(string prefix, JsonNode? value, List<string>? supportType)
        {
            supportType ??= GetSupportDataType();
            if (supportType != null && supportType.Any())
            {
                foreach (var type in supportType)
                {
                    string targetType = $"{prefix}{type.ToTitleCase(true)}";
                   
                    if (value is JsonObject jValue && jValue.ContainsKey(targetType))
                    {
                        _keyName = $"{targetType}";
                        _value = jValue[_keyName];
                        break;
                    }
                }
            }
        }
        protected ChoiceType(string prefix, IComplexType? value)
        {
            if (value != null)
            {
                _keyName = $"{prefix}{value .GetFhirTypeName(true)}";
                _value = value.GetJsonObject();
            }
        }
        protected ChoiceType(string prefix, IPrimitiveType? value)
        {
            if (value != null)
            {
                _keyName = $"{prefix}{value.GetFhirTypeName(true)}";
                _value = value.GetJsonValue();
            }
        }
        public KeyValuePair<string, JsonNode?> GetProperty()
        {
            if (string.IsNullOrEmpty(_keyName))
            {
                return new KeyValuePair<string, JsonNode?>("value", _value?.DeepClone());
            }
            else
            {
                return new KeyValuePair<string, JsonNode?>(_keyName, _value?.DeepClone());
            }
        }
        public override bool IsPrimitive() => false;
        public override bool IsChoiceType() => true;
        public override bool IsComplex() => false;
        public abstract string GetPrefixName(bool withCapital = true);
        public override string GetFhirTypeName(bool withCapital = true)
        {
            return withCapital ? "ChoiceType" : "choiceType";
        }
        public string? GetCurrentKeyName() => _keyName;
        public JsonNode? GetCurrentValueNode() => _value;
        public string GetDataTypeName() => _keyName ?? "value";
        public string? GetValue() 
        { 
            return  (_value != null)? _value.GetValue<string>(): default;
        }
        public List<string>? GetSupportDataType() => SetSupportDataType();
        public abstract List<string> SetSupportDataType();
    }
}