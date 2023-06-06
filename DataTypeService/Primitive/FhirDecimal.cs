using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public class FhirDecimal : PrimitiveType, INullableValue<decimal>, IPrimitiveType
    {
        public FhirDecimal() { }
        public FhirDecimal(JsonNode? source) : base(source) { }
        public FhirDecimal(decimal value) : base(value.ToString()) { }
        public FhirDecimal(string? value) : base(value) { }
        protected override string _TypeName => "Decimal";
        public decimal? Value => Convert.ToDecimal(_valueString);
        public JsonNode? GetJsonNode()
        {
            return GetJsonValue();
        }
        public JsonNode? GetJsonValue()
        {
            return Value.HasValue ? JsonValue.Create<decimal>(Value.Value) : null;
        }
        public bool IsValidValue(string? value)
        {
            string? target = value ?? _valueString;
            string pattern = @"-?(0|[1-9][0-9]*)(\.[0-9]+)?([eE][+-]?[0-9]+)?";
            return RegexValidate(pattern, target);
        }
    }
}
