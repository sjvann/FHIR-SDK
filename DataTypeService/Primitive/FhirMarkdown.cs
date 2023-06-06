using DataTypeService.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.Primitive
{
    public class FhirMarkdown : PrimitiveType, IStringValue, IPrimitiveType
    {

        public FhirMarkdown() { }
        public FhirMarkdown(JsonNode? source) : base(source) { }
        public FhirMarkdown(string? value) : base(value) { }
        public string? Value => _valueString;

        protected override string _TypeName => "Markdown";
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
            string pattern = @"\s*(\S|\s)*";
            return RegexValidate(pattern, target);
        }
    }
}
