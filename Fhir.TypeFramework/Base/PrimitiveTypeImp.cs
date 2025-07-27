
namespace Fhir.TypeFramework.Base;

public class PrimitiveTypeImp<T1, T2> : PrimitiveType 
    where T1: DataType 
    where T2: IConvertible
{
    protected string? _stringValue;
        protected Element? _elementValue = null;
        protected object? _value;
        #region Constructors
        protected PrimitiveType() { }
        protected PrimitiveType(JsonNode? value, string? elementName)
        {
            if(value is JsonValue jsonValue)
            {
                _stringValue = Convert.ToString(jsonValue);
            }
            else
            {
                if (value != null && !string.IsNullOrEmpty(elementName))
                {
                    InitElementObject((JsonObject)value, elementName);
                }
            }
        }
        protected PrimitiveType(JsonNode? value, Element? element) : this(Convert.ToString(value), element) { }
        protected PrimitiveType(string? value, Element? element)
        {
            _stringValue = value;
            _elementValue = element;
            Id = element?.Id;
            Extension = element?.Extension;
        }
        #endregion
        #region Ovvveride Methods
        public override string GetFhirTypeName(bool withCapital = true) => typeof(T2).Name.ToTitleCase(withCapital);
        public override bool IsChoiceType() => false;
        public override bool IsPrimitive() => true;
        public override bool IsComplex() => false;
        public override string ToJsonString()
        {
            string typeName = typeof(T2).Name;
            return typeName switch
            {
                "String" or "DateTime" => $"\"{_stringValue}\"",
                _ => $"{_stringValue}",
            };
        }
        #endregion
        #region Implement Interface
        public abstract object? GetValue();
        public bool ValueEquals(object? other)
        {
            if (other is PrimitiveType<T1, T2> primitiveType)
            {
                return _stringValue == primitiveType._stringValue;
            }
            else if (other is T2 value1 && GetValue() is T2 value2)
            {
                return value1.Equals(value2);
            }
            else if(other is string value3)
            {
                return _stringValue == value3;
            }
            else
            {
                return false;
            }
        }
        public virtual bool HasElement()
        {
            return Id != null || (Extension != null && Extension.Count > 0);
        }
        public JsonObject? GetElementJsonObject() => _elementValue?.GetJsonNode() as JsonObject;
        public string GetElementJsonString() => _elementValue?.GetElementString() ?? string.Empty;
        public virtual JsonValue? GetJsonValue() => JsonValue.Create(_stringValue);
        public override JsonNode? GetJsonObject() => GetJsonValue();
        public abstract bool IsValidValue();
        public static T1? Init(object value)
        {
            return (T1?)Activator.CreateInstance(typeof(T1), (T2)value);
        }
        protected static bool CheckValidate(string regex, string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;
            return Regex.IsMatch(value, regex);
        }
        public void SetElementObject(JsonNode? element)
        {
            if (element is JsonObject jObject)
            {
                Element elementTemp = new ElementImp();

                if (jObject.ContainsKey("id"))
                {
                    elementTemp.Id = jObject["id"]?.GetValue<FhirString>();
                }
                if (jObject.ContainsKey("extension") && jObject["extension"] is JsonArray jArrary)
                {
                    List<Extension> extensions = [];
                    foreach (JsonNode? item in jArrary)
                    {
                        extensions.Add(new Extension(item as JsonObject));
                    }
                }
                _elementValue = elementTemp;
                Id = _elementValue.Id;
                Extension = _elementValue.Extension;
            }
        }
        #endregion
        #region Private Methods
        private void InitElementObject(JsonObject value, string elementName)
        {
            string _elementName = $"_{elementName}";
            if (value.ContainsKey(elementName) && string.IsNullOrEmpty( _stringValue))
            {
                _stringValue = value[elementName]?.GetValue<string>();
            }
            if (value.ContainsKey(_elementName) && value[_elementName] is JsonObject jObject)
            {
                Element elementTemp = new ElementImp();
                if (jObject.ContainsKey("id"))
                {
                    elementTemp.Id = jObject["id"]?.GetValue<FhirString>();

                }
                if (jObject.ContainsKey("extension") && jObject["extension"] is JsonArray jArrary)
                {
                    List<Extension> extensions = [];
                    foreach (JsonNode? item in jArrary)
                    {
                        extensions.Add(new Extension(item as JsonObject));
                    }
                    elementTemp.Extension = extensions;
                }
                _elementValue = elementTemp;
                Id = elementTemp.Id;
                Extension = elementTemp.Extension;
            }
        }
        #endregion
}