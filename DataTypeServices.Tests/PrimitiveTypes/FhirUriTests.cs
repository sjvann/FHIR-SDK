using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// FhirUri 測試類別
    /// 繼承自 PrimitiveTypeTestBase，使用泛型架構
    /// </summary>
    public class FhirUriTests : PrimitiveTypeTestBase<FhirUri>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "http://example.com",
                "https://fhir.hl7.org/",
                "urn:uuid:12345678-1234-1234-1234-123456789abc",
                "urn:oid:2.16.840.1.113883.2.4.6.1",
                "ftp://example.com/file.txt",
                "mailto:test@example.com",
                "tel:+1-555-123-4567"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "http://example.com with spaces"
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Uri";
        }

        public override FhirUri CreateInstance(string value)
        {
            return new FhirUri(value);
        }

        public override FhirUri CreateNullInstance()
        {
            return new FhirUri((string?)null);
        }

        #endregion

        #region 覆寫 GetValueFromInstance 方法

        protected override object? GetValueFromInstance(FhirUri instance)
        {
            return instance.Value;
        }

        #endregion

        #region FhirUri 特定測試

        [Fact]
        public void FhirUri_Specific_ValidHttpUriIsValid()
        {
            // Arrange
            var fhirUri = new FhirUri("http://example.com");

            // Act
            var result = fhirUri.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.Equal("http://example.com", fhirUri.Value);
        }

        [Fact]
        public void FhirUri_Specific_ValidHttpsUriIsValid()
        {
            // Arrange
            var fhirUri = new FhirUri("https://fhir.hl7.org/");

            // Act
            var result = fhirUri.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.Equal("https://fhir.hl7.org/", fhirUri.Value);
        }

        [Fact]
        public void FhirUri_Specific_ValidUuidUriIsValid()
        {
            // Arrange
            var fhirUri = new FhirUri("urn:uuid:12345678-1234-1234-1234-123456789abc");

            // Act
            var result = fhirUri.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.Equal("urn:uuid:12345678-1234-1234-1234-123456789abc", fhirUri.Value);
        }

        [Fact]
        public void FhirUri_Specific_EmptyStringIsInvalid()
        {
            // Arrange
            var fhirUri = new FhirUri("");

            // Act
            var result = fhirUri.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirUri_Specific_InvalidUriFormatIsValid()
        {
            // Arrange
            var fhirUri = new FhirUri("not-a-uri");

            // Act
            var result = fhirUri.IsValidValue();

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("http://example.com", "http://example.com")]
        [InlineData("https://fhir.hl7.org/", "https://fhir.hl7.org/")]
        [InlineData("urn:oid:2.16.840.1.113883.2.4.6.1", "urn:oid:2.16.840.1.113883.2.4.6.1")]
        public void FhirUri_Specific_ValidUrisAreParsedCorrectly(string input, string expected)
        {
            // Arrange
            var fhirUri = new FhirUri(input);

            // Act
            var result = fhirUri.Value;

            // Assert
            Assert.Equal(expected, result);
            Assert.True(fhirUri.IsValidValue());
        }

        #endregion
    }
} 