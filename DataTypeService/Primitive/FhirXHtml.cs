using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace DataTypeService.Primitive
{
    public class FhirXHtml : PrimitiveType, IStringValue, IPrimitiveType
    {
        public FhirXHtml() { }
        public FhirXHtml(JsonNode? source) : base(source) { }
        public FhirXHtml(string? value) : base(value) { }

        public string? Value => _valueString;
        protected override string _TypeName => "XHtml";
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

            return true;
        }
    }
}
