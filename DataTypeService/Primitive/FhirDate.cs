using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace DataTypeService.Primitive
{
    public class FhirDate : PrimitiveType, IDateTimeValue, IPrimitiveType
    {
        public FhirDate() { }
        public FhirDate(JsonNode? source) : base(source) { }
        public FhirDate(DateTimeOffset value) : base(value.ToString("yyyy-MM-dd")) { }

        public FhirDate(string? value) : base(Convert.ToDateTime(value).ToString("yyyy-MM-dd")) { }

        public DateTimeOffset Value => Convert.ToDateTime(_valueString);
        public string? StringValue => _valueString;
        protected override string _TypeName => "Date";
        public JsonNode? GetJsonValue()
        {
            return JsonValue.Create<string>(StringValue);
        }
        public JsonNode? GetJsonNode()
        {
            return GetJsonValue();
        }
        public bool IsValidValue(string? value)
        {
            string? target = value ?? _valueString;
            string pattern = @"([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)(-(0[1-9]|1[0-2])(-(0[1-9]|[1-2][0-9]|3[0-1]))?)?";

            return RegexValidate(pattern, target);
        }
    }
}
