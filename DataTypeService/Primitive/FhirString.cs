using DataTypeService.BaseTypes;

using System.Text.Json.Nodes;

namespace DataTypeService.Primitive
{
    public class FhirString : PrimitiveType, IStringValue, IPrimitiveType
    {
        public FhirString() { }
        public FhirString(JsonNode? source) : base(source) { }
        public FhirString(string? value) : base(value) { }
        protected override string _TypeName => "String";

        public string? Value => _valueString;
        public JsonNode? GetJsonValue()
        {
            return JsonValue.Create<string>(Value);
        }

        public bool IsValidValue(string? value)
        {
            string? target = value ?? _valueString;
            return target?.Length <= 1024 * 1024;
        }

        public JsonNode? GetJsonNode()
        {
            return GetJsonValue();
        }
    }
}
