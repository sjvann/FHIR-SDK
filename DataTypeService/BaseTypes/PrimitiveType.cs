
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeService.BaseTypes
{
    public abstract class PrimitiveType : DataType
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
                Id = new FhirString(s2["id"]);
                var extensions = s2["extension"]?.AsArray();
                if (extensions != null)
                {
                    List<Extension> result = new();
                    foreach (var item in extensions)
                    {
                        if (item != null)
                        {
                            result.Add(new Extension(item));
                        }
                    }
                    Extension = result;
                }
                _valueString = Convert.ToString(s2["valueString"]);
            }
        }
        protected PrimitiveType(string? value)
        {
            _valueString = value;
        }

        public string? ValueString => _valueString;

        protected override string _TypeName => "PrimitiveType";



        public static bool RegexValidate(string? pattern, string? value)
        {
            if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(value)) return false;

            Regex regex = new(pattern);
            return regex.IsMatch(value);
        }

        public override string? ToJsonString()
        {
            return $"\"{_valueString}\"";
        }


    }
}
