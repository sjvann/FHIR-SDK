using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.Serialization;
using DataTypeServices.TypeFramework;
using System;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace DataTypeServices.Tests.Serialization
{
    public class FhirSerializationTests
    {
        [Fact]
        public void FhirJsonSerializer_Serialize_PrimitiveType_ReturnsValidJson()
        {
            // Arrange
            var fhirString = new FhirString("Hello World");

            // Act
            var json = FhirJsonSerializer.Serialize(fhirString);

            // Assert
            Assert.NotNull(json);
            Assert.NotEmpty(json);
            
            // 驗證可以解析為有效的 JSON
            var document = JsonDocument.Parse(json);
            Assert.NotNull(document);
        }

        [Fact]
        public void FhirJsonSerializer_SerializeWithIndentation_ReturnsFormattedJson()
        {
            // Arrange
            var fhirString = new FhirString("Test");

            // Act
            var compactJson = FhirJsonSerializer.Serialize(fhirString, false);
            var prettyJson = FhirJsonSerializer.Serialize(fhirString, true);

            // Assert
            Assert.NotEqual(compactJson, prettyJson);
            Assert.Contains("\n", prettyJson); // 格式化的 JSON 應該包含換行符
            Assert.DoesNotContain("\n", compactJson); // 緊湊的 JSON 不應該包含換行符
        }

        [Fact]
        public void FhirJsonSerializer_Deserialize_ValidJson_ReturnsObject()
        {
            // Arrange
            var originalString = new FhirString("Test Value");
            var json = FhirJsonSerializer.Serialize(originalString);

            // Act
            var deserializedString = FhirJsonSerializer.Deserialize<FhirString>(json);

            // Assert
            Assert.NotNull(deserializedString);
            Assert.Equal(originalString.Value, deserializedString.Value);
        }

        [Fact]
        public void FhirJsonSerializer_RoundTrip_PreservesData()
        {
            // Arrange
            var originalString = new FhirString("Test Value");

            // Act
            var json = FhirJsonSerializer.Serialize(originalString);
            var deserializedString = FhirJsonSerializer.Deserialize<FhirString>(json);

            // Assert
            Assert.NotNull(deserializedString);
            Assert.Equal(originalString.Value, deserializedString.Value);
        }

        [Fact]
        public void FhirSerializer_SerializeToJson_ReturnsValidJson()
        {
            // Arrange
            var fhirInteger = new FhirInteger(123);

            // Act
            var json = FhirSerializer.Serialize(fhirInteger, FhirSerializationFormat.Json);

            // Assert
            Assert.NotNull(json);
            Assert.NotEmpty(json);
            
            // 驗證可以解析為有效的 JSON
            var document = JsonDocument.Parse(json);
            Assert.NotNull(document);
        }

        [Fact]
        public void FhirSerializer_SerializeToJsonPretty_ReturnsFormattedJson()
        {
            // Arrange
            var fhirInteger = new FhirInteger(123);

            // Act
            var compactJson = FhirSerializer.Serialize(fhirInteger, FhirSerializationFormat.JsonCompact);
            var prettyJson = FhirSerializer.Serialize(fhirInteger, FhirSerializationFormat.JsonPretty);

            // Assert
            Assert.NotEqual(compactJson, prettyJson);
            Assert.Contains("\n", prettyJson);
        }

        [Fact]
        public void FhirSerializer_DetectFormat_Json_ReturnsJsonFormat()
        {
            // Arrange
            var jsonData = """{"value": 123}""";

            // Act
            var format = FhirSerializer.DetectFormat(jsonData);

            // Assert
            Assert.Equal(FhirSerializationFormat.Json, format);
        }

        [Fact]
        public void FhirSerializer_DetectFormat_Xml_ReturnsXmlFormat()
        {
            // Arrange
            var xmlData = "<root><value>123</value></root>";

            // Act
            var format = FhirSerializer.DetectFormat(xmlData);

            // Assert
            Assert.Equal(FhirSerializationFormat.Xml, format);
        }

        [Fact]
        public void FhirSerializer_DetectFormat_InvalidData_ThrowsException()
        {
            // Arrange
            var invalidData = "not json or xml";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => FhirSerializer.DetectFormat(invalidData));
        }

        [Fact]
        public void FhirSerializer_DeserializeAuto_JsonData_ReturnsObject()
        {
            // Arrange
            var originalBoolean = new FhirBoolean(true);
            var json = FhirSerializer.Serialize(originalBoolean, FhirSerializationFormat.Json);

            // Act
            var deserializedBoolean = FhirSerializer.DeserializeAuto<FhirBoolean>(json);

            // Assert
            Assert.NotNull(deserializedBoolean);
            Assert.Equal(originalBoolean.Value, deserializedBoolean.Value);
        }

        [Fact]
        public void FhirSerializer_ConvertFormat_JsonToJsonPretty_ReturnsFormattedJson()
        {
            // Arrange
            var originalDate = new FhirDate(DateTime.Today);
            var compactJson = FhirSerializer.Serialize(originalDate, FhirSerializationFormat.JsonCompact);

            // Act
            var prettyJson = FhirSerializer.ConvertFormat<FhirDate>(
                compactJson, 
                FhirSerializationFormat.JsonCompact, 
                FhirSerializationFormat.JsonPretty);

            // Assert
            Assert.NotEqual(compactJson, prettyJson);
            Assert.Contains("\n", prettyJson);
            
            // 驗證資料完整性
            var deserializedDate = FhirSerializer.Deserialize<FhirDate>(prettyJson);
            Assert.NotNull(deserializedDate);
            Assert.Equal(originalDate.Value, deserializedDate.Value);
        }

        [Fact]
        public void FhirSerializer_IsValidFormat_ValidJson_ReturnsTrue()
        {
            // Arrange
            var jsonData = """{"test": "value"}""";

            // Act
            var isValid = FhirSerializer.IsValidFormat(jsonData, FhirSerializationFormat.Json);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void FhirSerializer_IsValidFormat_InvalidFormat_ReturnsFalse()
        {
            // Arrange
            var jsonData = """{"test": "value"}""";

            // Act
            var isValid = FhirSerializer.IsValidFormat(jsonData, FhirSerializationFormat.Xml);

            // Assert
            Assert.False(isValid);
        }

        [Fact]
        public void DataType_ToJson_ReturnsValidJson()
        {
            // Arrange
            var fhirUri = new FhirUri("https://example.com/fhir");

            // Act
            var json = fhirUri.ToJson();

            // Assert
            Assert.NotNull(json);
            Assert.NotEmpty(json);
            
            // 驗證可以解析為有效的 JSON
            var document = JsonDocument.Parse(json);
            Assert.NotNull(document);
        }

        [Fact]
        public void DataType_ToJsonPretty_ReturnsFormattedJson()
        {
            // Arrange
            var fhirUri = new FhirUri("https://example.com/fhir");

            // Act
            var compactJson = fhirUri.ToJson(false);
            var prettyJson = fhirUri.ToJson(true);

            // Assert
            Assert.NotEqual(compactJson, prettyJson);
            Assert.Contains("\n", prettyJson);
        }

        [Fact]
        public void DataType_FromJson_ReturnsValidObject()
        {
            // Arrange
            var originalCode = new FhirCode("active");
            var json = originalCode.ToJson();

            // Act
            var deserializedCode = DataType.FromJson<FhirCode>(json);

            // Assert
            Assert.NotNull(deserializedCode);
            Assert.Equal(originalCode.Value, deserializedCode.Value);
        }

        [Fact]
        public void DataType_Serialize_DifferentFormats_ReturnsCorrectFormat()
        {
            // Arrange
            var fhirId = new FhirId("patient-123");

            // Act
            var jsonResult = fhirId.Serialize(FhirSerializationFormat.Json);
            var prettyJsonResult = fhirId.Serialize(FhirSerializationFormat.JsonPretty);

            // Assert
            Assert.NotNull(jsonResult);
            Assert.NotNull(prettyJsonResult);
            Assert.NotEqual(jsonResult, prettyJsonResult);
            Assert.Contains("\n", prettyJsonResult);
        }

        [Fact]
        public void DataType_DeserializeAuto_ValidData_ReturnsObject()
        {
            // Arrange
            var originalInstant = new FhirInstant(DateTimeOffset.Now);
            var json = originalInstant.ToJson();

            // Act
            var deserializedInstant = DataType.DeserializeAuto<FhirInstant>(json);

            // Assert
            Assert.NotNull(deserializedInstant);
            // 注意：由於時間精度問題，我們只比較到秒
            Assert.Equal(
                originalInstant.Value?.ToString("yyyy-MM-ddTHH:mm:ss"), 
                deserializedInstant.Value?.ToString("yyyy-MM-ddTHH:mm:ss"));
        }

        [Fact]
        public void FhirJsonSerializer_Quantity_SerializationFormat()
        {
            // Arrange
            var fhirString = new FhirString("Test Value");

            // Act
            var json = FhirJsonSerializer.Serialize(fhirString);

            // Assert
            Assert.NotNull(json);
            Assert.Contains("value", json);
        }
    }
}
