using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public class FhirPositiveInt : PrimitiveType, IStringValue, IPrimitiveType
    {
        public FhirPositiveInt() { }
        public FhirPositiveInt(JsonNode? source) : base(source) { }
        public FhirPositiveInt(uint value) : base(value.ToString()) { }
        public FhirPositiveInt(string? value) : base(value) { }

        public string? Value => _valueString;

        protected override string _TypeName => "PositiveInt";
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
            string pattern = @"[1-9][0-9]*";
            return RegexValidate(pattern, target);
        }
    }
}
