using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// FhirUrl 測試類別
    /// 繼承自 PrimitiveTypeTestBase，使用泛型架構
    /// </summary>
    public class FhirUrlTests : PrimitiveTypeTestBase<FhirUrl>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "http://example.com",
                "https://fhir.hl7.org/",
                "https://www.hl7.org/fhir/",
                "http://localhost:8080/fhir",
                "https://api.example.com/fhir/Patient/123"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "not-a-url",
                "mailto:test@example.com",
                "tel:+1-555-123-4567",
                "urn:uuid:12345678-1234-1234-1234-123456789abc",
                "http://",
                "https://"
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Url";
        }

        public override FhirUrl CreateInstance(string value)
        {
            return new FhirUrl(value);
        }

        public override FhirUrl CreateNullInstance()
        {
            return new FhirUrl((string?)null);
        }

        #endregion

        #region 覆寫 GetValueFromInstance 方法

        protected override object? GetValueFromInstance(FhirUrl instance)
        {
            return instance.Value;
        }

        #endregion

        #region FhirUrl 特定測試

        [Fact]
        public void FhirUrl_Specific_ValidHttpUrlIsValid()
        {
            // Arrange
            var fhirUrl = new FhirUrl("http://example.com");

            // Act
            var result = fhirUrl.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.Equal("http://example.com", fhirUrl.Value);
        }

        [Fact]
        public void FhirUrl_Specific_ValidHttpsUrlIsValid()
        {
            // Arrange
            var fhirUrl = new FhirUrl("https://fhir.hl7.org/");

            // Act
            var result = fhirUrl.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.Equal("https://fhir.hl7.org/", fhirUrl.Value);
        }

        [Fact]
        public void FhirUrl_Specific_EmptyStringIsInvalid()
        {
            // Arrange
            var fhirUrl = new FhirUrl("");

            // Act
            var result = fhirUrl.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirUrl_Specific_NonHttpUrlIsInvalid()
        {
            // Arrange
            var fhirUrl = new FhirUrl("ftp://example.com");

            // Act
            var result = fhirUrl.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("http://example.com", "http://example.com")]
        [InlineData("https://fhir.hl7.org/", "https://fhir.hl7.org/")]
        [InlineData("https://api.example.com/fhir/Patient/123", "https://api.example.com/fhir/Patient/123")]
        public void FhirUrl_Specific_ValidUrlsAreParsedCorrectly(string input, string expected)
        {
            // Arrange
            var fhirUrl = new FhirUrl(input);

            // Act
            var result = fhirUrl.Value;

            // Assert
            Assert.Equal(expected, result);
            Assert.True(fhirUrl.IsValidValue());
        }

        #endregion
    }
} 