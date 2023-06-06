using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public class FhirUnsignedInt : PrimitiveType, IStringValue, IPrimitiveType
    {
        public FhirUnsignedInt() { }
        public FhirUnsignedInt(JsonNode? source) : base(source) { }
        public FhirUnsignedInt(uint value) : base(value.ToString()) { }
        public FhirUnsignedInt(string? value) : base(value) { }

        public string? Value => _valueString;

        protected override string _TypeName => "UnsignedInt";
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
            string pattern = @"[0]|([1-9][0-9]*)";
            return RegexValidate(pattern, target);
        }
    }
}
