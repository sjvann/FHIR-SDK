using System.Security.Cryptography;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeService.Based
{
    public abstract class PrimitiveType : DataType, IPrimitiveType
    {
        protected string? _valueString;
       
        protected PrimitiveType() { }
        protected PrimitiveType(JsonNode? source)
        {
            _JsonNode = source;
            if (source is JsonValue s1)
            {
                _valueString = Convert.ToString(s1);
            }
            else if (source is JsonObject s2)
            {
                _valueString = Convert.ToString(s2["valueString"]);
            }
        }
        protected PrimitiveType(string? value)
        {
            _valueString = value;
        }
        public string? ValueString => _valueString;

        protected override string _TypeName => "PrimitiveType";

        public abstract bool IsValidValue(string? value);

        public static bool RegexValidate(string? pattern, string? value)
        {
            if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(value)) return false;

            Regex regex = new(pattern);
            return regex.IsMatch(value);
        }

        public abstract JsonNode? GetJsonValue();

    }
}
