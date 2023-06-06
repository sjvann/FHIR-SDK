using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public class FhirUrl : PrimitiveType, IStringValue, IPrimitiveType
    {
        public FhirUrl() { }
        public FhirUrl(JsonNode? source) : base(source) { }
        public FhirUrl(string? value) : base(value) { }
        public string? Value => _valueString;
        public JsonNode? GetJsonNode()
        {
            return GetJsonValue();
        }
        public JsonNode? GetJsonValue()
        {
            return JsonValue.Create<string>(Value);
        }
        protected override string _TypeName => "Url";
        public bool IsValidValue(string? value)
        {
            string? target = value ?? _valueString;
            string pattern = @"\S*";
            return RegexValidate(pattern, target);
        }
    }
}
