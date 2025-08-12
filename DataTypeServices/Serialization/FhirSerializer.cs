using FhirCore.Interfaces;
using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;

namespace DataTypeServices.Serialization
{
    /// <summary>
    /// FHIR 序列化格式
    /// </summary>
    public enum FhirSerializationFormat
    {
        Json,
        Xml,
        JsonCompact,
        JsonPretty
    }

    /// <summary>
    /// 統一的 FHIR 序列化器，支援多種格式
    /// </summary>
    public static class FhirSerializer
    {
        /// <summary>
        /// 序列化 FHIR 資料類型
        /// </summary>
        /// <typeparam name="T">FHIR 資料類型</typeparam>
        /// <param name="value">要序列化的值</param>
        /// <param name="format">序列化格式</param>
        /// <returns>序列化後的字符串</returns>
        public static string Serialize<T>(T value, FhirSerializationFormat format = FhirSerializationFormat.Json) 
            where T : IDataType
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return format switch
            {
                FhirSerializationFormat.Json => FhirJsonSerializer.Serialize(value, false),
                FhirSerializationFormat.JsonCompact => FhirJsonSerializer.Serialize(value, false),
                FhirSerializationFormat.JsonPretty => FhirJsonSerializer.Serialize(value, true),
                FhirSerializationFormat.Xml => SerializeToXml(value),
                _ => throw new ArgumentException($"Unsupported format: {format}", nameof(format))
            };
        }

        /// <summary>
        /// 反序列化 FHIR 資料類型
        /// </summary>
        /// <typeparam name="T">FHIR 資料類型</typeparam>
        /// <param name="data">序列化的資料</param>
        /// <param name="format">序列化格式</param>
        /// <returns>反序列化的對象</returns>
        public static T? Deserialize<T>(string data, FhirSerializationFormat format = FhirSerializationFormat.Json) 
            where T : IDataType
        {
            if (string.IsNullOrEmpty(data))
                return default;

            return format switch
            {
                FhirSerializationFormat.Json or 
                FhirSerializationFormat.JsonCompact or 
                FhirSerializationFormat.JsonPretty => FhirJsonSerializer.Deserialize<T>(data),
                FhirSerializationFormat.Xml => DeserializeFromXml<T>(data),
                _ => throw new ArgumentException($"Unsupported format: {format}", nameof(format))
            };
        }

        /// <summary>
        /// 自動檢測格式並反序列化
        /// </summary>
        /// <typeparam name="T">FHIR 資料類型</typeparam>
        /// <param name="data">序列化的資料</param>
        /// <returns>反序列化的對象</returns>
        public static T? DeserializeAuto<T>(string data) where T : IDataType
        {
            if (string.IsNullOrEmpty(data))
                return default;

            var format = DetectFormat(data);
            return Deserialize<T>(data, format);
        }

        /// <summary>
        /// 檢測序列化格式
        /// </summary>
        /// <param name="data">序列化的資料</param>
        /// <returns>檢測到的格式</returns>
        public static FhirSerializationFormat DetectFormat(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
                throw new ArgumentException("Data cannot be null or empty", nameof(data));

            var trimmed = data.TrimStart();
            
            if (trimmed.StartsWith("{") || trimmed.StartsWith("["))
            {
                return FhirSerializationFormat.Json;
            }
            else if (trimmed.StartsWith("<"))
            {
                return FhirSerializationFormat.Xml;
            }
            else
            {
                throw new ArgumentException("Unable to detect format from data", nameof(data));
            }
        }

        /// <summary>
        /// 序列化到檔案
        /// </summary>
        /// <typeparam name="T">FHIR 資料類型</typeparam>
        /// <param name="value">要序列化的值</param>
        /// <param name="filePath">檔案路徑</param>
        /// <param name="format">序列化格式</param>
        public static void SerializeToFile<T>(T value, string filePath, FhirSerializationFormat format = FhirSerializationFormat.JsonPretty) 
            where T : IDataType
        {
            var data = Serialize(value, format);
            File.WriteAllText(filePath, data, Encoding.UTF8);
        }

        /// <summary>
        /// 從檔案反序列化
        /// </summary>
        /// <typeparam name="T">FHIR 資料類型</typeparam>
        /// <param name="filePath">檔案路徑</param>
        /// <param name="format">序列化格式，如果為 null 則自動檢測</param>
        /// <returns>反序列化的對象</returns>
        public static T? DeserializeFromFile<T>(string filePath, FhirSerializationFormat? format = null) 
            where T : IDataType
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File not found: {filePath}");

            var data = File.ReadAllText(filePath, Encoding.UTF8);
            
            if (format.HasValue)
            {
                return Deserialize<T>(data, format.Value);
            }
            else
            {
                return DeserializeAuto<T>(data);
            }
        }

        /// <summary>
        /// 轉換格式
        /// </summary>
        /// <typeparam name="T">FHIR 資料類型</typeparam>
        /// <param name="data">原始資料</param>
        /// <param name="fromFormat">原始格式</param>
        /// <param name="toFormat">目標格式</param>
        /// <returns>轉換後的資料</returns>
        public static string ConvertFormat<T>(string data, FhirSerializationFormat fromFormat, FhirSerializationFormat toFormat) 
            where T : IDataType
        {
            if (fromFormat == toFormat)
                return data;

            var obj = Deserialize<T>(data, fromFormat);
            if (obj == null)
                throw new InvalidOperationException("Failed to deserialize data");

            return Serialize(obj, toFormat);
        }

        /// <summary>
        /// 驗證序列化資料的格式
        /// </summary>
        /// <param name="data">序列化的資料</param>
        /// <param name="format">期望的格式</param>
        /// <returns>是否為有效格式</returns>
        public static bool IsValidFormat(string data, FhirSerializationFormat format)
        {
            try
            {
                var detectedFormat = DetectFormat(data);
                return detectedFormat == format || 
                       (IsJsonFormat(detectedFormat) && IsJsonFormat(format));
            }
            catch
            {
                return false;
            }
        }

        private static bool IsJsonFormat(FhirSerializationFormat format)
        {
            return format == FhirSerializationFormat.Json ||
                   format == FhirSerializationFormat.JsonCompact ||
                   format == FhirSerializationFormat.JsonPretty;
        }

        #region XML Support (Basic Implementation)

        private static string SerializeToXml<T>(T value) where T : IDataType
        {
            // 基本的 XML 序列化實現
            // 在實際應用中，這裡應該實現完整的 FHIR XML 序列化
            var json = FhirJsonSerializer.Serialize(value);
            
            // 簡化的 JSON 到 XML 轉換
            var doc = JsonDocument.Parse(json);
            var xml = new XElement(value.GetFhirTypeName(false));
            
            ConvertJsonElementToXml(doc.RootElement, xml);
            
            return xml.ToString();
        }

        private static T? DeserializeFromXml<T>(string xmlData) where T : IDataType
        {
            // 基本的 XML 反序列化實現
            // 在實際應用中，這裡應該實現完整的 FHIR XML 反序列化
            try
            {
                var xml = XElement.Parse(xmlData);
                var json = ConvertXmlToJson(xml);
                return FhirJsonSerializer.Deserialize<T>(json);
            }
            catch
            {
                return default;
            }
        }

        private static void ConvertJsonElementToXml(JsonElement element, XElement xml)
        {
            // 簡化的 JSON 到 XML 轉換邏輯
            // 實際實現應該遵循 FHIR XML 規範
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    foreach (var property in element.EnumerateObject())
                    {
                        var childElement = new XElement(property.Name);
                        ConvertJsonElementToXml(property.Value, childElement);
                        xml.Add(childElement);
                    }
                    break;
                case JsonValueKind.Array:
                    foreach (var item in element.EnumerateArray())
                    {
                        var itemElement = new XElement("item");
                        ConvertJsonElementToXml(item, itemElement);
                        xml.Add(itemElement);
                    }
                    break;
                default:
                    xml.Value = element.ToString();
                    break;
            }
        }

        private static string ConvertXmlToJson(XElement xml)
        {
            // 簡化的 XML 到 JSON 轉換邏輯
            // 實際實現應該遵循 FHIR XML 規範

            // 這裡應該實現完整的 XML 到 JSON 轉換
            // 目前返回空的 JSON 對象
            return "{}";
        }

        #endregion
    }
}
