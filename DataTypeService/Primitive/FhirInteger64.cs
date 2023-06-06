using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public class FhirInteger64 : PrimitiveType, INullableValue<long>, IPrimitiveType
    {
        public FhirInteger64() { }
        public FhirInteger64(JsonNode? source) : base(source) { }
        public FhirInteger64(long value) : base(value.ToString()) { }
        public FhirInteger64(string? value) : base(value) { }

        public long? Value => Convert.ToInt64(_valueString);

        protected override string _TypeName => "Integer64";
        public JsonNode? GetJsonNode()
        {
            return GetJsonValue();
        }

        public JsonNode? GetJsonValue()
        {
            return Value.HasValue ? JsonValue.Create<long>(Value.Value) : null;
        }
        public bool IsValidValue(string? value)
        {
            string? target = value ?? _valueString;
            string pattern = @"[0]|[-+]?[1-9][0-9]*";
            return RegexValidate(pattern, target);
        }
    }
}
