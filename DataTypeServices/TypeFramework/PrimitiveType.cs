using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.FhirParser.ExtensionMethods;
using FhirCore.ExtensionMethods;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.TypeFramework
{
    /// <summary>
    /// Abstract base class for all FHIR primitive data types.
    /// Primitive types are the basic building blocks of FHIR data structures, representing simple values like strings, numbers, dates, etc.
    /// </summary>
    /// <typeparam name="T1">The concrete FHIR primitive type that inherits from this base class</typeparam>
    /// <typeparam name="T2">The underlying .NET type that represents the primitive value (e.g., string, int, DateTime)</typeparam>
    /// <remarks>
    /// This class provides the foundation for all FHIR primitive data types such as FhirString, FhirInteger, FhirDateTime, etc.
    /// It handles JSON serialization/deserialization, value conversion, and element metadata management.
    /// All primitive types in FHIR can have extensions and an id, which are managed through the Element property.
    /// </remarks>
    /// <example>
    /// <code>
    /// public class FhirString : PrimitiveType&lt;FhirString, string&gt;
    /// {
    ///     public FhirString(string value) : base(value, null) { }
    ///     public string? Value => _stringValue;
    /// }
    /// </code>
    /// </example>
    public abstract class PrimitiveType<T1, T2> : DataType, IPrimitiveType
        where T1 : DataType
        where T2 : IConvertible
    {
        #region Protected Fields

        /// <summary>
        /// The string representation of the primitive value.
        /// </summary>
        protected string? _stringValue;

        /// <summary>
        /// The element metadata (id, extensions) associated with this primitive.
        /// </summary>
        protected Element? _elementValue = null;

        /// <summary>
        /// The strongly-typed value object.
        /// </summary>
        protected object? _value;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the PrimitiveType class.
        /// </summary>
        protected PrimitiveType() { }

        /// <summary>
        /// Initializes a new instance of the PrimitiveType class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the primitive value</param>
        /// <param name="elementName">The name of the element for metadata lookup</param>
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

        /// <summary>
        /// Initializes a new instance of the PrimitiveType class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the primitive value</param>
        /// <param name="element">The element metadata</param>
        protected PrimitiveType(JsonNode? value, Element? element) : this(Convert.ToString(value), element) { }

        /// <summary>
        /// Initializes a new instance of the PrimitiveType class from a string value and element.
        /// </summary>
        /// <param name="value">The string representation of the primitive value</param>
        /// <param name="element">The element metadata (id, extensions)</param>
        protected PrimitiveType(string? value, Element? element)
        {
            _stringValue = value;
            _elementValue = element;
            Id = element?.Id;
            Extension = element?.Extension;
        }
        #endregion
        #region Ovvveride Methods
        public override string GetFhirTypeName(bool withCapital = true)
        {
            var typeName = this.GetType().Name;
            if (typeName.StartsWith("Fhir"))
                typeName = typeName.Substring(4);
            return typeName.ToTitleCase(withCapital);
        }
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

        /// <summary>
        /// 執行詳細驗證並返回驗證結果
        /// </summary>
        public virtual ValidationResult ValidateDetailed()
        {
            if (IsValidValue())
            {
                return ValidationResult.Success();
            }

            return ValidationResult.Error(
                GetValidationErrorMessage(),
                GetFhirTypeName(false)
            );
        }

        /// <summary>
        /// 取得驗證錯誤訊息，子類別可以覆寫以提供更詳細的錯誤訊息
        /// </summary>
        protected virtual string GetValidationErrorMessage()
        {
            return $"Invalid {GetFhirTypeName(false)} value: '{_stringValue}'. Expected format: {GetExpectedFormat()}";
        }

        /// <summary>
        /// 取得期望的格式說明，子類別應該覆寫此方法
        /// </summary>
        protected virtual string GetExpectedFormat()
        {
            return "Valid FHIR format";
        }

        public static T1? Init(object value)
        {
            return (T1?)Activator.CreateInstance(typeof(T1), (T2)value);
        }
        protected static bool CheckValidate(string regex, string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;
            return Regex.IsMatch(value, regex);
        }

        /// <summary>
        /// 檢查驗證並提供詳細錯誤訊息
        /// </summary>
        protected static ValidationResult CheckValidateDetailed(string regex, string? value, string expectedFormat, string typeName)
        {
            if (string.IsNullOrEmpty(value))
            {
                return ValidationResult.Error($"{typeName} cannot be null or empty", typeName);
            }

            if (Regex.IsMatch(value, regex))
            {
                return ValidationResult.Success();
            }

            return ValidationResult.Error(
                $"Invalid {typeName} value: '{value}'. Expected format: {expectedFormat}",
                typeName
            );
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
                    List<DataTypeServices.DataTypes.SpecialTypes.Extension> extensions = [];
                    foreach (JsonNode? item in jArrary)
                    {
                        extensions.Add(new DataTypeServices.DataTypes.SpecialTypes.Extension(item as JsonObject));
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
                    List<DataTypeServices.DataTypes.SpecialTypes.Extension> extensions = [];
                    foreach (JsonNode? item in jArrary)
                    {
                        extensions.Add(new DataTypeServices.DataTypes.SpecialTypes.Extension(item as JsonObject));
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
}
