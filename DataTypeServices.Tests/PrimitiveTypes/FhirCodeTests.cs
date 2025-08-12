using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// FhirCode 測試類別
    /// 繼承自 PrimitiveTypeTestBase，使用泛型架構
    /// </summary>
    public class FhirCodeTests : PrimitiveTypeTestBase<FhirCode>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "active",
                "inactive",
                "male",
                "female",
                "unknown",
                "completed",
                "pending",
                "cancelled"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                ""
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Code";
        }

        public override FhirCode CreateInstance(string value)
        {
            return new FhirCode(value);
        }

        public override FhirCode CreateNullInstance()
        {
            return new FhirCode((string?)null);
        }

        #endregion

        #region 覆寫 GetValueFromInstance 方法

        protected override object? GetValueFromInstance(FhirCode instance)
        {
            return instance.Value;
        }

        #endregion

        #region FhirCode 特定測試

        [Fact]
        public void FhirCode_Specific_ValidCodeIsValid()
        {
            // Arrange
            var fhirCode = new FhirCode("active");

            // Act
            var result = fhirCode.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.Equal("active", fhirCode.Value);
        }

        [Fact]
        public void FhirCode_Specific_EmptyStringIsInvalid()
        {
            // Arrange
            var fhirCode = new FhirCode("");

            // Act
            var result = fhirCode.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirCode_Specific_CodeWithSpacesIsValid()
        {
            // Arrange
            var fhirCode = new FhirCode("code with spaces");

            // Act
            var result = fhirCode.IsValidValue();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void FhirCode_Specific_CodeWithHyphensIsValid()
        {
            // Arrange
            var fhirCode = new FhirCode("code-with-hyphens");

            // Act
            var result = fhirCode.IsValidValue();

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("active", "active")]
        [InlineData("inactive", "inactive")]
        [InlineData("male", "male")]
        [InlineData("female", "female")]
        public void FhirCode_Specific_ValidCodesAreParsedCorrectly(string input, string expected)
        {
            // Arrange
            var fhirCode = new FhirCode(input);

            // Act
            var result = fhirCode.Value;

            // Assert
            Assert.Equal(expected, result);
            Assert.True(fhirCode.IsValidValue());
        }

        #endregion
    }
} 