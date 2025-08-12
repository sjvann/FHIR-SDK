using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataTypeServices.Serialization
{
    /// <summary>
    /// FHIR 資料類型的現代化 JSON 轉換器
    /// </summary>
    /// <typeparam name="T">FHIR 資料類型</typeparam>
    public class FhirJsonConverter<T> : JsonConverter<T> where T : IDataType
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(IDataType).IsAssignableFrom(typeToConvert);
        }

        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            try
            {
                // 讀取 JSON 元素
                using var document = JsonDocument.ParseValue(ref reader);
                var element = document.RootElement;

                // 根據類型創建實例
                return CreateInstanceFromJson<T>(element);
            }
            catch (Exception ex)
            {
                throw new JsonException($"Error deserializing {typeof(T).Name}: {ex.Message}", ex);
            }
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            try
            {
                if (value == null)
                {
                    writer.WriteNullValue();
                    return;
                }

                WriteDataType(writer, value, options);
            }
            catch (Exception ex)
            {
                throw new JsonException($"Error serializing {typeof(T).Name}: {ex.Message}", ex);
            }
        }

        private static TResult? CreateInstanceFromJson<TResult>(JsonElement element) where TResult : IDataType
        {
            try
            {
                // 嘗試使用不同的構造函數
                var constructors = typeof(TResult).GetConstructors();

                // 優先使用 JsonElement 構造函數
                var jsonElementConstructor = Array.Find(constructors, c =>
                    c.GetParameters().Length == 1 &&
                    c.GetParameters()[0].ParameterType == typeof(JsonElement));

                if (jsonElementConstructor != null)
                {
                    return (TResult?)jsonElementConstructor.Invoke(new object[] { element });
                }

                // 嘗試使用字符串構造函數
                var stringConstructor = Array.Find(constructors, c =>
                    c.GetParameters().Length == 1 &&
                    c.GetParameters()[0].ParameterType == typeof(string));

                if (stringConstructor != null)
                {
                    // 如果是 JSON 對象，嘗試提取值
                    if (element.ValueKind == JsonValueKind.Object && element.TryGetProperty("value", out var valueElement))
                    {
                        var value = valueElement.ValueKind == JsonValueKind.String ? valueElement.GetString() ?? string.Empty : valueElement.GetRawText();
                        return (TResult?)stringConstructor.Invoke(new object[] { value });
                    }
                    else
                    {
                        var jsonString = element.GetRawText();
                        return (TResult?)stringConstructor.Invoke(new object[] { jsonString });
                    }
                }

                // 使用預設構造函數
                var defaultConstructor = Array.Find(constructors, c => c.GetParameters().Length == 0);
                if (defaultConstructor != null)
                {
                    var instance = (TResult?)defaultConstructor.Invoke(null);
                    if (instance != null)
                    {
                        PopulateFromJsonElement(instance, element);
                    }
                    return instance;
                }

                return default;
            }
            catch
            {
                return default;
            }
        }

        private static void PopulateFromJsonElement(IDataType instance, JsonElement element)
        {
            var type = instance.GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                if (!property.CanWrite) continue;

                var jsonPropertyName = GetJsonPropertyName(property);
                if (element.TryGetProperty(jsonPropertyName, out var jsonProperty))
                {
                    try
                    {
                        var value = ConvertJsonElementToPropertyValue(jsonProperty, property.PropertyType);
                        property.SetValue(instance, value);
                    }
                    catch
                    {
                        // 忽略轉換錯誤，繼續處理其他屬性
                    }
                }
            }
        }

        private static string GetJsonPropertyName(PropertyInfo property)
        {
            // 檢查是否有 JsonPropertyName 屬性
            var jsonPropertyAttr = property.GetCustomAttribute<JsonPropertyNameAttribute>();
            if (jsonPropertyAttr != null)
            {
                return jsonPropertyAttr.Name;
            }

            // 使用 camelCase 命名
            var name = property.Name;
            return char.ToLowerInvariant(name[0]) + name[1..];
        }

        private static object? ConvertJsonElementToPropertyValue(JsonElement element, Type targetType)
        {
            if (element.ValueKind == JsonValueKind.Null)
                return null;

            // 處理基本類型
            if (targetType == typeof(string))
                return element.GetString() ?? string.Empty;
            if (targetType == typeof(int) || targetType == typeof(int?))
                return element.GetInt32();
            if (targetType == typeof(long) || targetType == typeof(long?))
                return element.GetInt64();
            if (targetType == typeof(bool) || targetType == typeof(bool?))
                return element.GetBoolean();
            if (targetType == typeof(DateTime) || targetType == typeof(DateTime?))
                return element.GetDateTime();
            if (targetType == typeof(decimal) || targetType == typeof(decimal?))
                return element.GetDecimal();

            // 處理 FHIR 資料類型
            if (typeof(IDataType).IsAssignableFrom(targetType))
            {
                return CreateInstanceFromJson(element, targetType);
            }

            // 處理集合類型
            if (targetType.IsGenericType && targetType.GetGenericTypeDefinition() == typeof(List<>))
            {
                var elementType = targetType.GetGenericArguments()[0];
                var listType = typeof(List<>).MakeGenericType(elementType);
                var list = (IList?)Activator.CreateInstance(listType);

                if (list != null && element.ValueKind == JsonValueKind.Array)
                {
                    foreach (var arrayElement in element.EnumerateArray())
                    {
                        var item = ConvertJsonElementToPropertyValue(arrayElement, elementType);
                        if (item != null)
                        {
                            list.Add(item);
                        }
                    }
                }

                return list;
            }

            return null;
        }

        private static object? CreateInstanceFromJson(JsonElement element, Type targetType)
        {
            var constructors = targetType.GetConstructors();

            // 嘗試使用字符串構造函數
            var stringConstructor = Array.Find(constructors, c =>
                c.GetParameters().Length == 1 &&
                c.GetParameters()[0].ParameterType == typeof(string));

            if (stringConstructor != null)
            {
                string value;
                if (element.ValueKind == JsonValueKind.String)
                {
                    value = element.GetString() ?? string.Empty;
                }
                else
                {
                    value = element.GetRawText();
                }
                return stringConstructor.Invoke(new object[] { value });
            }

            return null;
        }

        private static void WriteDataType(Utf8JsonWriter writer, IDataType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case IPrimitiveType primitive:
                    WritePrimitiveType(writer, primitive, options);
                    break;
                case IComplexType complex:
                    WriteComplexType(writer, complex, options);
                    break;
                default:
                    WriteGenericDataType(writer, value, options);
                    break;
            }
        }

        private static void WritePrimitiveType(Utf8JsonWriter writer, IPrimitiveType primitive, JsonSerializerOptions options)
        {
            // 將 PrimitiveType 序列化為 JSON 對象
            writer.WriteStartObject();
            
            // 寫入值
            var jsonValue = primitive.GetJsonValue();
            if (jsonValue != null)
            {
                writer.WritePropertyName("value");
                jsonValue.WriteTo(writer);
            }
            else
            {
                writer.WritePropertyName("value");
                writer.WriteNullValue();
            }
            
            writer.WriteEndObject();
        }

        private static void WriteComplexType(Utf8JsonWriter writer, IComplexType complex, JsonSerializerOptions options)
        {
            var jsonObject = complex.GetJsonObject();
            if (jsonObject != null)
            {
                JsonSerializer.Serialize(writer, jsonObject, options);
            }
            else
            {
                writer.WriteNullValue();
            }
        }

        private static void WriteGenericDataType(Utf8JsonWriter writer, IDataType value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            var type = value.GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                if (!property.CanRead) continue;

                var propertyValue = property.GetValue(value);
                if (propertyValue == null) continue;

                var jsonPropertyName = GetJsonPropertyName(property);
                writer.WritePropertyName(jsonPropertyName);

                WritePropertyValue(writer, propertyValue, options);
            }

            writer.WriteEndObject();
        }

        private static void WritePropertyValue(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case IDataType dataType:
                    WriteDataType(writer, dataType, options);
                    break;
                case IList list:
                    writer.WriteStartArray();
                    foreach (var item in list)
                    {
                        if (item != null)
                        {
                            WritePropertyValue(writer, item, options);
                        }
                    }
                    writer.WriteEndArray();
                    break;
                default:
                    JsonSerializer.Serialize(writer, value, options);
                    break;
            }
        }
    }

    /// <summary>
    /// FHIR 專用的 JSON 序列化器
    /// </summary>
    public static class FhirJsonSerializer
    {
        private static readonly JsonSerializerOptions DefaultOptions = CreateDefaultOptions();
        private static readonly JsonSerializerOptions PrettyOptions = CreatePrettyOptions();

        /// <summary>
        /// 創建預設的序列化選項
        /// </summary>
        private static JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                WriteIndented = false,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            // 添加 FHIR 轉換器
            options.Converters.Add(new FhirDataTypeConverterFactory());

            return options;
        }

        /// <summary>
        /// 創建格式化的序列化選項
        /// </summary>
        private static JsonSerializerOptions CreatePrettyOptions()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            // 添加 FHIR 轉換器
            options.Converters.Add(new FhirDataTypeConverterFactory());

            return options;
        }

        /// <summary>
        /// 序列化 FHIR 資料類型為 JSON 字符串
        /// </summary>
        public static string Serialize<T>(T value, bool writeIndented = false) where T : IDataType
        {
            var options = writeIndented ? PrettyOptions : DefaultOptions;
            return JsonSerializer.Serialize(value, options);
        }

        /// <summary>
        /// 從 JSON 字符串反序列化 FHIR 資料類型
        /// </summary>
        public static T? Deserialize<T>(string json) where T : IDataType
        {
            return JsonSerializer.Deserialize<T>(json, DefaultOptions);
        }

        /// <summary>
        /// 從 JsonElement 反序列化 FHIR 資料類型
        /// </summary>
        public static T? Deserialize<T>(JsonElement element) where T : IDataType
        {
            var json = element.GetRawText();
            return Deserialize<T>(json);
        }

        /// <summary>
        /// 序列化為 JsonElement
        /// </summary>
        public static JsonElement SerializeToElement<T>(T value) where T : IDataType
        {
            var json = Serialize(value);
            using var document = JsonDocument.Parse(json);
            return document.RootElement.Clone();
        }

        /// <summary>
        /// 取得預設的序列化選項
        /// </summary>
        public static JsonSerializerOptions GetDefaultOptions() => DefaultOptions;

        /// <summary>
        /// 取得格式化的序列化選項
        /// </summary>
        public static JsonSerializerOptions GetPrettyOptions() => PrettyOptions;
    }

    /// <summary>
    /// FHIR 資料類型轉換器工廠
    /// </summary>
    public class FhirDataTypeConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(IDataType).IsAssignableFrom(typeToConvert);
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var converterType = typeof(FhirJsonConverter<>).MakeGenericType(typeToConvert);
            return (JsonConverter?)Activator.CreateInstance(converterType);
        }
    }
}
