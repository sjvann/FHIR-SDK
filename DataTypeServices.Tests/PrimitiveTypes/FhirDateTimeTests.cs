using DataTypeServices.DataTypes.PrimitiveTypes;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// FhirDateTime 測試類別
    /// 繼承自 PrimitiveTypeTestBase，使用泛型架構
    /// </summary>
    public class FhirDateTimeTests : PrimitiveTypeTestBase<FhirDateTime>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "2023",
                "2023-12",
                "2023-12-25",
                "2023-12-25T14:30:00",
                "2023-12-25T14:30:00Z",
                "2023-12-25T14:30:00+08:00"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "23",
                "2023-13",
                "2023-12-32",
                "invalid-date",
                "2023-12-25T25:00:00"
            };
        }

        public override string GetExpectedTypeName()
        {
            return "DateTime";
        }

        public override FhirDateTime CreateInstance(string value)
        {
            return new FhirDateTime(value);
        }

        public override FhirDateTime CreateNullInstance()
        {
            return new FhirDateTime((DateTime?)null);
        }

        #endregion

        #region 覆寫 GetValueFromInstance 方法

        protected override object? GetValueFromInstance(FhirDateTime instance)
        {
            return instance.Value;
        }

        #endregion

        #region FhirDateTime 特定測試

        [Theory]
        [InlineData("2023-12-25")]
        [InlineData("2023-12-25T14:30:00")]
        [InlineData("2023-12-25T14:30:00Z")]
        public void FhirDateTime_Specific_ValidDateTime_ReturnsCorrectValue(string input)
        {
            // Arrange
            var fhirDateTime = new FhirDateTime(input);

            // Act
            var result = fhirDateTime.Value;

            // Assert
            Assert.NotNull(result);
            Assert.True(fhirDateTime.IsValidValue());
        }

        [Theory]
        [InlineData("invalid-date")]
        [InlineData("2023-13")]
        [InlineData("2023-12-32")]
        public void FhirDateTime_Specific_InvalidDateTime_ReturnsNull(string input)
        {
            // Arrange
            var fhirDateTime = new FhirDateTime(input);

            // Act
            var result = fhirDateTime.Value;

            // Assert
            Assert.Null(result);
            Assert.False(fhirDateTime.IsValidValue());
        }

        [Fact]
        public void FhirDateTime_Specific_EmptyStringIsInvalid()
        {
            // Arrange
            var fhirDateTime = new FhirDateTime("");

            // Act
            var result = fhirDateTime.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirDateTime_Specific_TooShortValueIsInvalid()
        {
            // Arrange
            var fhirDateTime = new FhirDateTime("23");

            // Act
            var result = fhirDateTime.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirDateTime_Specific_InvalidTimeIsInvalid()
        {
            // Arrange
            var fhirDateTime = new FhirDateTime("2023-12-25T25:00:00");

            // Act
            var result = fhirDateTime.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("2023")]
        [InlineData("2023-12")]
        [InlineData("2023-12-25")]
        public void FhirDateTime_Specific_PartialDatesAreValid(string input)
        {
            // Arrange
            var fhirDateTime = new FhirDateTime(input);

            // Act
            var result = fhirDateTime.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.NotNull(fhirDateTime.Value);
        }

        #endregion
    }
}
