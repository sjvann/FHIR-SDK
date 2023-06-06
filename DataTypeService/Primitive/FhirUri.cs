using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public class FhirUri : PrimitiveType, IStringValue, IPrimitiveType
    {
        public FhirUri() { }
        public FhirUri(JsonNode? source) : base(source) { }

        public FhirUri(string? value) : base(value) { }
        public string? Value => _valueString;

        protected override string _TypeName => "Uri";
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
            string pattern = @"\S*";
            return RegexValidate(pattern, target);
        }
    }
}
