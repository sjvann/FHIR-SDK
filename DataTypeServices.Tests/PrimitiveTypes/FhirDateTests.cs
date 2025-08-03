using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// FhirDate 測試類別
    /// 繼承自 PrimitiveTypeTestBase，使用泛型架構
    /// </summary>
    public class FhirDateTests : PrimitiveTypeTestBase<FhirDate>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "2023-01-01",
                "2023-12-31",
                "2020-02-29", // 閏年
                "2023-06-15",
                "2023-03-01"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "2023-13-01", // 無效月份
                "2023-04-31", // 無效日期
                "2023-02-30", // 2月沒有30日
                "2021-02-29", // 非閏年2月29日
                "2023/01/01", // 錯誤格式
                "01-01-2023", // 錯誤格式
                "2023-1-1", // 缺少前導零
                "2023-01-1", // 缺少前導零
                "2023-1-01" // 缺少前導零
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Date";
        }

        public override FhirDate CreateInstance(string value)
        {
            return new FhirDate(value);
        }

        public override FhirDate CreateNullInstance()
        {
            return new FhirDate((DateTime?)null);
        }

        #endregion

        #region 覆寫 GetValueFromInstance 方法

        protected override object? GetValueFromInstance(FhirDate instance)
        {
            return instance.Value;
        }

        #endregion

        #region FhirDate 特定測試

        [Fact]
        public void FhirDate_Specific_ValidDateIsValid()
        {
            // Arrange
            var fhirDate = new FhirDate("2023-01-01");

            // Act
            var result = fhirDate.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.NotNull(fhirDate.Value);
        }

        [Fact]
        public void FhirDate_Specific_LeapYearDateIsValid()
        {
            // Arrange
            var fhirDate = new FhirDate("2020-02-29");

            // Act
            var result = fhirDate.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.NotNull(fhirDate.Value);
        }

        [Fact]
        public void FhirDate_Specific_EmptyStringIsInvalid()
        {
            // Arrange
            var fhirDate = new FhirDate("");

            // Act
            var result = fhirDate.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirDate_Specific_InvalidMonthIsInvalid()
        {
            // Arrange
            var fhirDate = new FhirDate("2023-13-01");

            // Act
            var result = fhirDate.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirDate_Specific_InvalidDayIsInvalid()
        {
            // Arrange
            var fhirDate = new FhirDate("2023-04-31");

            // Act
            var result = fhirDate.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirDate_Specific_NonLeapYearFebruary29IsInvalid()
        {
            // Arrange
            var fhirDate = new FhirDate("2021-02-29");

            // Act
            var result = fhirDate.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("2023-01-01")]
        [InlineData("2023-12-31")]
        [InlineData("2020-02-29")]
        [InlineData("2023-06-15")]
        public void FhirDate_Specific_ValidDatesAreParsedCorrectly(string input)
        {
            // Arrange
            var fhirDate = new FhirDate(input);

            // Act
            var result = fhirDate.Value;

            // Assert
            Assert.NotNull(result);
            Assert.True(fhirDate.IsValidValue());
        }

        #endregion
    }
} 