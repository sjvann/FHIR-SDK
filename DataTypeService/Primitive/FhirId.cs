using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public class FhirId : PrimitiveType, IStringValue, IPrimitiveType
    {
        public FhirId() { }
        public FhirId(JsonNode? source) : base(source) { }
        public FhirId(string? value) : base(value) { }

        public string? Value => _valueString;
        protected override string _TypeName => "Id";
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
            string pattern = @"[A-Za-z0-9\-\.]{1,64}";
            return RegexValidate(pattern, target);
        }
    }
}
