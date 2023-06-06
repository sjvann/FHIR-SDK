using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;


namespace DataTypeService.Primitive
{
    public class FhirInstant : PrimitiveType, IDateTimeValue, IPrimitiveType
    {
        public FhirInstant() { }
        public FhirInstant(JsonNode? source) : base(source) { }
        public FhirInstant(DateTimeOffset value) : base(value.ToString("yyyy-MM-ddTHH:mm:ss.ss+zz:zz")) { }

        public FhirInstant(string? value) : base(Convert.ToDateTime(value).ToString("yyyy-MM-ddTHH:mm:ss.ss+zz:zz")) { }

        public DateTimeOffset Value => Convert.ToDateTime(_valueString);

        public string? StringValue => _valueString;

        protected override string _TypeName => "Instant";
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
            string pattern = @"([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])
T([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\.[0-9]{1,9}})?(Z|(\+|-)((0[0-9]|1[0-3]):[0-5][0-9]|14:00))";

            return RegexValidate(pattern, target);
        }
    }
}
