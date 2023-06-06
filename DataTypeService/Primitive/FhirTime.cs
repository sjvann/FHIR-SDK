using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeService.Primitive
{
    public class FhirTime : PrimitiveType, IDateTimeValue, IPrimitiveType
    {
        public FhirTime() { }
        public FhirTime(JsonNode? source) : base(source) { }
        public FhirTime(DateTimeOffset value) : base(value.ToString("HH:mm:ss")) { }
        public FhirTime(string? value) : base(Convert.ToDateTime(value).ToString("HH:mm:ss")) { }

        public DateTimeOffset Value => Convert.ToDateTime(_valueString);
        public string? StringValue => _valueString;

        protected override string _TypeName => "Time";
        public JsonNode? GetJsonNode()
        {
            return GetJsonValue();
        }

        public JsonNode? GetJsonValue()
        {
            return JsonValue.Create<string>(StringValue);
        }
        public bool IsValidValue(string? value)
        {
            string? target = value ?? _valueString;
            string pattern = @"([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\.[0-9]{1,9})?";

            return RegexValidate(pattern, target);
        }
    }
}
