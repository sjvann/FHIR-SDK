using DataTypeServices.DataTypes.PrimitiveTypes;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// FhirInteger 測試類別
    /// 繼承自 PrimitiveTypeTestBase，使用泛型架構
    /// </summary>
    public class FhirIntegerTests : PrimitiveTypeTestBase<FhirInteger>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "0",
                "123",
                "-456",
                "2147483647",
                "-2147483648"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "abc",
                "3.14",
                "2147483648",
                "-2147483649"
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Integer";
        }

        public override FhirInteger CreateInstance(string value)
        {
            return new FhirInteger(value);
        }

        public override FhirInteger CreateNullInstance()
        {
            return new FhirInteger((int?)null);
        }

        #endregion

        #region 覆寫 GetValueFromInstance 方法

        protected override object? GetValueFromInstance(FhirInteger instance)
        {
            // 使用 HasValue 來檢查是否有有效值，避免異常
            return instance.HasValue ? instance.Value : null;
        }

        #endregion

        #region FhirInteger 特定測試

        [Theory]
        [InlineData("123", 123)]
        [InlineData("-456", -456)]
        [InlineData("0", 0)]
        public void FhirInteger_Specific_ValidInteger_ReturnsCorrectValue(string input, int expected)
        {
            // Arrange
            var fhirInteger = new FhirInteger(input);

            // Act
            var result = fhirInteger.Value;

            // Assert
            Assert.Equal(expected, result);
            Assert.True(fhirInteger.IsValidValue());
        }

        [Theory]
        [InlineData("abc")]
        [InlineData("3.14")]
        public void FhirInteger_Specific_InvalidInteger_ThrowsException(string input)
        {
            // Arrange
            var fhirInteger = new FhirInteger(input);

            // Act & Assert
            Assert.False(fhirInteger.IsValidValue());
            Assert.Throws<System.FormatException>(() => fhirInteger.Value);
        }

        [Theory]
        [InlineData(" 123")]
        [InlineData("123 ")]
        [InlineData("01")]
        public void FhirInteger_Specific_InvalidFormat_IsValidButNotValidValue(string input)
        {
            // Arrange
            var fhirInteger = new FhirInteger(input);

            // Act & Assert
            Assert.False(fhirInteger.IsValidValue()); // 格式無效
            Assert.True(fhirInteger.HasValue); // 但可以被解析
            Assert.NotNull(fhirInteger.Value); // 有值
        }

        [Fact]
        public void FhirInteger_Specific_BoundaryValues()
        {
            // Test maximum value
            var maxInteger = new FhirInteger("2147483647");
            Assert.True(maxInteger.IsValidValue());
            Assert.Equal(2147483647, maxInteger.Value);

            // Test minimum value
            var minInteger = new FhirInteger("-2147483648");
            Assert.True(minInteger.IsValidValue());
            Assert.Equal(-2147483648, minInteger.Value);

            // Test overflow
            var overflowInteger = new FhirInteger("2147483648");
            Assert.False(overflowInteger.IsValidValue());
            Assert.Throws<System.OverflowException>(() => overflowInteger.Value);
        }

        [Fact]
        public void FhirInteger_Specific_EmptyStringIsInvalid()
        {
            // Arrange
            var fhirInteger = new FhirInteger("");

            // Act
            var result = fhirInteger.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirInteger_Specific_HasValue_ValidInteger_ReturnsTrue()
        {
            // Arrange
            var fhirInteger = new FhirInteger("123");

            // Act
            var result = fhirInteger.HasValue;

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void FhirInteger_Specific_HasValue_InvalidInteger_ReturnsFalse()
        {
            // Arrange
            var fhirInteger = new FhirInteger("abc");

            // Act
            var result = fhirInteger.HasValue;

            // Assert
            Assert.False(result);
        }

        #endregion
    }
}
