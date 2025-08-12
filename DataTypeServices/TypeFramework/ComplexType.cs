using DataTypeServices.Validation;
using FhirCore.ExtensionMethods;
using FhirCore.Interfaces;
using System.Collections;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DataTypeServices.TypeFramework
{
    /// <summary>
    /// Abstract base class for all FHIR complex data types.
    /// Complex types are data types that contain multiple elements and can be used to build more complex structures.
    /// </summary>
    /// <typeparam name="T">The concrete type that inherits from this base class</typeparam>
    /// <remarks>
    /// This class provides the foundation for all FHIR complex data types such as Address, HumanName, Period, etc.
    /// It implements common functionality for JSON serialization/deserialization, property management, and validation.
    /// </remarks>
    /// <example>
    /// <code>
    /// public class Address : ComplexType&lt;Address&gt;
    /// {
    ///     public FhirString? Line { get; set; }
    ///     public FhirString? City { get; set; }
    ///     // ... other properties
    /// }
    /// </code>
    /// </example>
    public abstract class ComplexType<T> : DataType, IComplexType where T : DataType, new()
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the ComplexType class.
        /// </summary>
        protected ComplexType() { }

        /// <summary>
        /// Initializes a new instance of the ComplexType class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the data to initialize this instance</param>
        /// <exception cref="ArgumentException">Thrown when the JSON node is not a valid JSON object</exception>
        protected ComplexType(JsonNode? value)
        {
            if (value is JsonObject jObject)
            {
                SetupPropertyValue(jObject);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ComplexType class from a JSON string.
        /// </summary>
        /// <param name="value">The JSON string containing the data to initialize this instance</param>
        /// <exception cref="System.Text.Json.JsonException">Thrown when the JSON string is not valid</exception>
        protected ComplexType(string value) : this(JsonNode.Parse(value)) { }
        #endregion

        #region Override Methods

        /// <summary>
        /// Gets the FHIR type name for this complex type.
        /// </summary>
        /// <param name="withCapital">Whether to capitalize the first letter of the type name</param>
        /// <returns>The FHIR type name (e.g., "Address", "HumanName")</returns>
        public override string GetFhirTypeName(bool withCapital = true) => typeof(T).Name.ToTitleCase(withCapital);

        /// <summary>
        /// Determines whether this data type is a choice type.
        /// </summary>
        /// <returns>Always returns false for complex types</returns>
        public override bool IsChoiceType() => false;

        /// <summary>
        /// Determines whether this data type is a primitive type.
        /// </summary>
        /// <returns>Always returns false for complex types</returns>
        public override bool IsPrimitive() => false;

        /// <summary>
        /// Determines whether this data type is a complex type.
        /// </summary>
        /// <returns>Always returns true for complex types</returns>
        public override bool IsComplex() => true;

        /// <summary>
        /// Converts this complex type to its JSON string representation.
        /// </summary>
        /// <returns>A JSON string representing this complex type, or an empty string if serialization fails</returns>
        public override string ToJsonString()
        {
            return GetJsonObject()?.SerializeCustom() ?? string.Empty;
        }
        #endregion
        #region Implement Interface
        public override JsonObject? GetJsonObject()
        {
            if (_Properties != null && _Properties.Count > 0)
            {
                JsonObject jObject = new();
                foreach (var item in _Properties)
                {
                    jObject.Add(item.Key, item.Value?.DeepClone());
                }
                return jObject;
            }
            else
            {
                return SetupJsonObject(this);
            }
        }
        #endregion
        #region Private Methods
        private void SetupPropertyValue(JsonObject dataSource)
        {
            if (dataSource == null) return;
            Type sourceType = typeof(T);
            PropertyInfo[] propertyInfos = sourceType.GetProperties();
            foreach (PropertyInfo property in propertyInfos)
            {
                var propertyName = property.Name.ToTitleCase(false);
                var propertyType = property.PropertyType;
                var propertyValue = dataSource[propertyName] ?? dataSource.FirstOrDefault(x => x.Key.StartsWith(propertyName)).Value;
                if (propertyValue is JsonNode node)
                {
                    var elementValue = dataSource["_" + propertyName];
                    if (propertyType.IsGenericType && propertyType.Name == "List`1")
                    {
                        var listType = propertyType.GetGenericArguments()[0];

                        if (listType == null) continue;
                        if (listType.IsSubclassOf(typeof(ChoiceType)))
                        {
                            var listValue = new List<ChoiceType>();
                            if (node is JsonArray jArray)
                            {
                                foreach (var item in jArray)
                                {
                                    var instance = (ChoiceType?)Activator.CreateInstance(listType, item);
                                    if (instance != null)
                                    {
                                        listValue.Add(instance);
                                    }
                                }
                            }
                            property.SetValue(this, listValue);
                        }
                        else if (listType.IsSubclassOf(typeof(DataType)))
                        {
                            var listValueType = typeof(List<>);
                            var listValue = listValueType.MakeGenericType(listType);
                            var listTypeValue = Activator.CreateInstance(listValue);
                            if (node is JsonArray jArray)
                            {
                                foreach (var item in jArray)
                                {
                                    var instance = Activator.CreateInstance(listType, item);
                                    if (instance != null)
                                    {
                                        listValue.GetMethod("Add")?.Invoke(listTypeValue, [instance]);
                                    }
                                }
                            }
                            property.SetValue(this, listTypeValue);
                        }
                    }
                    else
                    {
                        if (propertyType.IsSubclassOf(typeof(ChoiceType)))
                        {
                            string prefix = property.Name.ToTitleCase(true);
                            if (node is JsonValue jValue)
                            {
                                string dataType = dataSource.FirstOrDefault(x => x.Key.StartsWith(propertyName)).Key;
                                var choice = Activator.CreateInstance(propertyType, dataType, jValue);
                                property.SetValue(this, choice);
                            }
                            else
                            {
                                var choice = Activator.CreateInstance(propertyType, prefix, node);
                                property.SetValue(this, choice);
                            }

                        }
                        else if (propertyType.GetInterface("IPrimitive") != null)
                        {
                            if (elementValue != null)
                            {
                                Element? element = new ElementImp(elementValue as JsonObject);
                                var primitive = Activator.CreateInstance(propertyType, node, element);
                                property.SetValue(this, primitive);
                            }
                            else
                            {
                                var primitive = Activator.CreateInstance(propertyType, node);
                                property.SetValue(this, primitive);
                            }
                        }
                        else
                        {
                            var complex = Activator.CreateInstance(propertyType, node);
                            property.SetValue(this, complex);
                        }
                    }
                }
            }
        }
        private static JsonObject? SetupJsonObject(DataType source)
        {
            var propertyInfos = SetupPropertyValue((T)source);
            if (propertyInfos == null || propertyInfos.Count == 0) return null;
            JsonObject jObject = new JsonObject(propertyInfos);
            return jObject;
        }
        private static List<KeyValuePair<string, JsonNode?>>? SetupPropertyValue(T source)
        {
            if (source == null) return null;
            List<KeyValuePair<string, JsonNode?>> target = [];
            var propertyInfos = typeof(T).GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {
                var propertyType = propertyInfo.PropertyType;
                var propertyValue = propertyInfo.GetValue(source);
                bool isMulti = propertyType.IsGenericType;
                if (propertyValue != null)
                {
                    bool? isPrimitive = propertyType.GetMethod("IsPrimitive")?.Invoke(propertyValue, null) as bool?;
                    bool? isChoice = propertyType.GetMethod("IsChoiceType")?.Invoke(propertyValue, null) as bool?;

                    if (isMulti && propertyValue is IList)
                    {
                        JsonArray jArray = [];
                        foreach (var item in (IEnumerable)propertyValue)
                        {
                            if (item is IPrimitiveType primitiveValue)
                            {
                                jArray.Add(primitiveValue.GetJsonValue());
                                if (primitiveValue.HasElement())
                                {
                                    jArray.Add(primitiveValue.GetElementJsonObject());
                                }
                            }
                            else if (item is IComplexType complexValue)
                            {
                                jArray.Add(complexValue.GetJsonObject());
                            }
                            else if (item is ChoiceType choiceValue)
                            {
                                jArray.Add(choiceValue.GetProperty());
                            }
                        }
                        target.Add(new KeyValuePair<string, JsonNode?>(propertyInfo.Name.ToTitleCase(false), jArray));
                    }
                    else if (isPrimitive == true)
                    {
                        IPrimitiveType? primitiveValue = propertyValue as IPrimitiveType;
                        target.Add(new KeyValuePair<string, JsonNode?>(propertyInfo.Name.ToTitleCase(false), primitiveValue?.GetJsonValue()));
                        if (primitiveValue?.HasElement() == true)
                        {
                            var coneElement = primitiveValue.GetElementJsonString();
                            target.Add(new KeyValuePair<string, JsonNode?>($"_{propertyInfo.Name.ToTitleCase(false)}", JsonNode.Parse(coneElement)));
                        }
                    }
                    else if (isChoice == true && propertyValue is ChoiceType pv)
                    {
                        var key = pv.GetCurrentKeyName();
                        var value = pv.GetCurrentValueNode()?.DeepClone();
                        if (key != null && value != null)
                        {
                            target.Add(new KeyValuePair<string, JsonNode?>(key, value));
                        }
                    }
                    else
                    {
                        IComplexType? complexValue = propertyValue as IComplexType;
                        var newJsonNode = complexValue?.GetJsonObject()?.DeepClone();
                        target.Add(new KeyValuePair<string, JsonNode?>(propertyInfo.Name.ToTitleCase(false), newJsonNode));
                    }
                }
            }
            return target;
        }

        /// <summary>
        /// 驗證此對象的 cardinality 約束
        /// </summary>
        /// <returns>驗證結果</returns>
        public virtual ValidationResults ValidateCardinality()
        {
            return CardinalityValidator.ValidateCardinality(this);
        }

        /// <summary>
        /// 驗證此對象的自定義驗證屬性
        /// </summary>
        /// <returns>驗證結果</returns>
        public virtual ValidationResults ValidateCustomAttributes()
        {
            return CustomValidationEngine.ValidateCustomAttributes(this);
        }

        /// <summary>
        /// 驗證此對象的所有約束（包括 cardinality 和自定義驗證）
        /// </summary>
        /// <returns>驗證結果</returns>
        public virtual ValidationResults ValidateAll()
        {
            var results = new ValidationResults();

            // 添加 cardinality 驗證
            var cardinalityResults = ValidateCardinality();
            results.AddRange(cardinalityResults.Results);

            // 添加自定義驗證
            var customResults = ValidateCustomAttributes();
            results.AddRange(customResults.Results);

            return results;
        }
        #endregion
    }
}