using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public partial class FhirBoolean : PrimitiveType, INullableValue<bool>, IPrimitiveType
    {
        public FhirBoolean() { }
        public FhirBoolean(JsonNode? source) : base(source) { }
        public FhirBoolean(bool value) : base(value ? "true" : "false") { }
        public FhirBoolean(string? value) : base(value) { }


        public bool? Value => _valueString == "true";
        protected override string _TypeName => "Boolean";

        public JsonNode? GetJsonNode()
        {
            return GetJsonValue();
        }

        public JsonNode? GetJsonValue()
        {
            return Value.HasValue ? JsonValue.Create<bool>(Value.Value) : null;
        }
        public bool IsValidValue(string? value)
        {
            string? target = value ?? _valueString;
            string pattern = "true|false";
            return RegexValidate(pattern, target);
        }


    }
}