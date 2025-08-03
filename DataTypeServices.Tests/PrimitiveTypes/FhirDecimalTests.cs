using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// FhirDecimal 測試類別
    /// 繼承自 PrimitiveTypeTestBase，使用泛型架構
    /// </summary>
    public class FhirDecimalTests : PrimitiveTypeTestBase<FhirDecimal>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "123.45",
                "0.123",
                "123",
                "-123.45",
                "0",
                "0.0"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "abc",
                "123e",
                "e123",
                "123e+",
                "123e-",
                ""
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Decimal";
        }

        public override FhirDecimal CreateInstance(string value)
        {
            return new FhirDecimal(value);
        }

        public override FhirDecimal CreateNullInstance()
        {
            return new FhirDecimal((decimal?)null);
        }

        #endregion

        #region 覆寫 GetValueFromInstance 方法

        protected override object? GetValueFromInstance(FhirDecimal instance)
        {
            return instance.Value;
        }

        #endregion

        #region FhirDecimal 特定測試

        [Fact]
        public void FhirDecimal_Specific_DecimalValueIsValid()
        {
            // Arrange
            var fhirDecimal = new FhirDecimal(123.45m);

            // Act
            var result = fhirDecimal.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.Equal(123.45m, fhirDecimal.Value);
        }

        [Fact]
        public void FhirDecimal_Specific_ScientificNotationIsNotSupported()
        {
            // Arrange
            var fhirDecimal = new FhirDecimal("1.23e-4");

            // Act
            var result = fhirDecimal.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirDecimal_Specific_NegativeValueIsValid()
        {
            // Arrange
            var fhirDecimal = new FhirDecimal(-123.45m);

            // Act
            var result = fhirDecimal.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.Equal(-123.45m, fhirDecimal.Value);
        }

        [Fact]
        public void FhirDecimal_Specific_ZeroValueIsValid()
        {
            // Arrange
            var fhirDecimal = new FhirDecimal(0m);

            // Act
            var result = fhirDecimal.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.Equal(0m, fhirDecimal.Value);
        }

        [Fact]
        public void FhirDecimal_Specific_InvalidStringReturnsFalse()
        {
            // Arrange
            var fhirDecimal = new FhirDecimal("abc");

            // Act
            var result = fhirDecimal.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirDecimal_Specific_NullValueIsInvalid()
        {
            // Arrange
            var fhirDecimal = new FhirDecimal((decimal?)null);

            // Act
            var result = fhirDecimal.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("123.45", 123.45)]
        [InlineData("0.123", 0.123)]
        [InlineData("123", 123)]
        public void FhirDecimal_Specific_StringValuesAreParsedCorrectly(string input, decimal expected)
        {
            // Arrange
            var fhirDecimal = new FhirDecimal(input);

            // Act
            var result = fhirDecimal.Value;

            // Assert
            Assert.Equal(expected, result);
            Assert.True(fhirDecimal.IsValidValue());
        }

        #endregion
    }
} 