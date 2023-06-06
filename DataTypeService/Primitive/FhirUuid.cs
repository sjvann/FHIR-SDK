using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public class FhirUuid : PrimitiveType, IStringValue, IPrimitiveType
    {
        public FhirUuid() { }
        public FhirUuid(JsonNode? source) : base(source) { }
        public FhirUuid(string value) : base(value) { }
        public string? Value => _valueString;
        protected override string _TypeName => "Uuid";
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
            string pattern = @"urn:uuid:[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}";
            return RegexValidate(pattern, target);
        }
    }
}
