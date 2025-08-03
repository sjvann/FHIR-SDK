using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// FhirId 測試類別
    /// 繼承自 PrimitiveTypeTestBase，使用泛型架構
    /// </summary>
    public class FhirIdTests : PrimitiveTypeTestBase<FhirId>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "patient123",
                "obs-456",
                "med.789",
                "a",
                "1234567890123456789012345678901234567890123456789012345678901234", // 64 characters
                "test-id",
                "test.id"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "test id", // 包含空格
                "test@id", // 包含無效字符
                "test#id", // 包含無效字符
                "12345678901234567890123456789012345678901234567890123456789012345", // 65 characters
                " test", // 前導空格
                "test " // 尾隨空格
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Id";
        }

        public override FhirId CreateInstance(string value)
        {
            return new FhirId(value);
        }

        public override FhirId CreateNullInstance()
        {
            return new FhirId((string?)null);
        }

        #endregion

        #region 覆寫 GetValueFromInstance 方法

        protected override object? GetValueFromInstance(FhirId instance)
        {
            return instance.Value;
        }

        #endregion

        #region FhirId 特定測試

        [Fact]
        public void FhirId_Specific_ValidIdIsValid()
        {
            // Arrange
            var fhirId = new FhirId("patient123");

            // Act
            var result = fhirId.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.Equal("patient123", fhirId.Value);
        }

        [Fact]
        public void FhirId_Specific_EmptyStringIsInvalid()
        {
            // Arrange
            var fhirId = new FhirId("");

            // Act
            var result = fhirId.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirId_Specific_TooLongIdIsInvalid()
        {
            // Arrange
            var longId = new string('a', 65); // 65 characters
            var fhirId = new FhirId(longId);

            // Act
            var result = fhirId.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirId_Specific_IdWithSpacesIsInvalid()
        {
            // Arrange
            var fhirId = new FhirId("test id");

            // Act
            var result = fhirId.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirId_Specific_IdWithSpecialCharsIsInvalid()
        {
            // Arrange
            var fhirId = new FhirId("test@id");

            // Act
            var result = fhirId.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("patient123", "patient123")]
        [InlineData("obs-456", "obs-456")]
        [InlineData("med.789", "med.789")]
        [InlineData("a", "a")]
        public void FhirId_Specific_ValidIdsAreParsedCorrectly(string input, string expected)
        {
            // Arrange
            var fhirId = new FhirId(input);

            // Act
            var result = fhirId.Value;

            // Assert
            Assert.Equal(expected, result);
            Assert.True(fhirId.IsValidValue());
        }

        #endregion
    }
} 