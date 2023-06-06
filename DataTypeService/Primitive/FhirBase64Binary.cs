using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace DataTypeService.Primitive
{
    public class FhirBase64Binary : PrimitiveType, IStringValue, IPrimitiveType
    {
        public FhirBase64Binary() { }
        public FhirBase64Binary(JsonNode? source) : base(source) { }
        public FhirBase64Binary(string? value) : base(value) { }

        public string? Value => _valueString;

        public JsonNode? GetJsonNode()
        {
            return GetJsonValue();
        }

        public JsonNode? GetJsonValue()
        {
            return JsonValue.Create<string>(Value);
        }

        public bool IsValidValue(string? value)
        {
            string? target = value ?? _valueString;
            string pattern = @"(\s*([0-9a-zA-Z\+\=]){4}\s*)+";
            return RegexValidate(pattern, target);
        }


    }
}
