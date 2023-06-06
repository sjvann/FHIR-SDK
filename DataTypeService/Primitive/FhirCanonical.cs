using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public class FhirCanonical : PrimitiveType, IStringValue, IPrimitiveType
    {
        public FhirCanonical() { }
        public FhirCanonical(JsonNode? source) : base(source) { }
        public FhirCanonical(string? value) : base(value) { }

        public string? Value => _valueString;

        protected override string _TypeName => "Canonical";
        public JsonNode? GetJsonValue()
        {
            return JsonValue.Create<string>(Value);
        }
        public JsonNode? GetJsonNode()
        {
            return GetJsonValue();
        }
        public bool IsValidValue(string? value)
        {
            string? target = value ?? _valueString;
            string pattern = @"\S*";
            return RegexValidate(pattern, target);
        }
    }
}
