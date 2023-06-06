using Core.ExtensionImp;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace DataTypeService.Primitive
{
    public class FhirCode : PrimitiveType, IPrimitiveType
    {
        public FhirCode() { }
        public FhirCode(JsonNode? source) : base(source) { }
        public FhirCode(string? value) : base(value) { }

        public string? Value => _valueString;

        protected override string _TypeName => "Code";

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

            string pattern = @"[^\s]+( [^\s]+)*";
            return RegexValidate(pattern, target);


        }
    }


    public class FhirCode<T> : FhirCode where T : Enum
    {
        public FhirCode() { }
        public FhirCode(T source) : base(source.GetEnumMemberValue()) { }
        public FhirCode(string? value) : base(value) { }

    }


}

