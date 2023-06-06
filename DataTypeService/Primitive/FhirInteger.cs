using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public class FhirInteger : PrimitiveType, INullableValue<int>, IPrimitiveType
    {
        public FhirInteger() { }
        public FhirInteger(JsonNode? source) : base(source) { }
        public FhirInteger(int value) : base(value.ToString()) { }
        public FhirInteger(string value) : base(value) { }

        public int? Value => Convert.ToInt32(_valueString);

        protected override string _TypeName => "Integer";
        public JsonNode? GetJsonNode()
        {
            return GetJsonValue();
        }
        public JsonNode? GetJsonValue()
        {
            return Value.HasValue ? JsonValue.Create<int>(Value.Value) : null;
        }
        public bool IsValidValue(string? value)
        {
            string? target = value ?? _valueString;
            string pattern = @"-?([0]|([1-9][0-9]*))";
            return RegexValidate(pattern, target);
        }
    }
}
