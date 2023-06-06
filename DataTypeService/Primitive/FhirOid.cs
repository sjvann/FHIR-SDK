using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public class FhirOid : PrimitiveType, IStringValue, IPrimitiveType
    {
        public FhirOid() { }
        public FhirOid(JsonNode? source) : base(source) { }
        public FhirOid(string value) : base(value) { }

        public string? Value => _valueString;

        protected override string _TypeName => "Oid";
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
            string pattern = @"urn:oid:[0-2](\.(0|[1-9][0-9]*))+";
            return RegexValidate(pattern, target);
        }
    }
}
