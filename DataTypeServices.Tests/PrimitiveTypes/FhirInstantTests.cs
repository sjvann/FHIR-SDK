using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// FhirInstant 測試類別
    /// 繼承自 PrimitiveTypeTestBase，使用泛型架構
    /// </summary>
    public class FhirInstantTests : PrimitiveTypeTestBase<FhirInstant>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "2023-01-01T12:00:00Z",
                "2023-12-31T23:59:59Z",
                "2020-02-29T12:00:00Z",
                "2023-06-15T12:30:45Z",
                "2023-03-01T00:00:00Z",
                "2023-01-01T12:00:00+05:00",
                "2023-01-01T12:00:00-05:00"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "2023-01-01", // 缺少時間部分
                "12:00:00Z", // 缺少日期部分
                "2023-13-01T12:00:00Z", // 無效月份
                "2023-04-31T12:00:00Z", // 無效日期
                "2023-01-01T24:00:00Z", // 無效小時
                "2023-01-01T12:60:00Z", // 無效分鐘
                "2023-01-01T12:00:60Z", // 無效秒數
                "2023/01/01T12:00:00Z", // 錯誤日期格式
                "2023-01-01 12:00:00Z" // 錯誤分隔符
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Instant";
        }

        public override FhirInstant CreateInstance(string value)
        {
            return new FhirInstant(value);
        }

        public override FhirInstant CreateNullInstance()
        {
            return new FhirInstant((DateTimeOffset?)null);
        }

        #endregion

        #region 覆寫 GetValueFromInstance 方法

        protected override object? GetValueFromInstance(FhirInstant instance)
        {
            return instance.Value;
        }

        #endregion

        #region FhirInstant 特定測試

        [Fact]
        public void FhirInstant_Specific_ValidInstantIsValid()
        {
            // Arrange
            var fhirInstant = new FhirInstant("2023-01-01T12:00:00Z");

            // Act
            var result = fhirInstant.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.NotNull(fhirInstant.Value);
        }

        [Fact]
        public void FhirInstant_Specific_LeapYearInstantIsValid()
        {
            // Arrange
            var fhirInstant = new FhirInstant("2020-02-29T12:00:00Z");

            // Act
            var result = fhirInstant.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.NotNull(fhirInstant.Value);
        }

        [Fact]
        public void FhirInstant_Specific_InstantWithTimezoneIsValid()
        {
            // Arrange
            var fhirInstant = new FhirInstant("2023-01-01T12:00:00+05:00");

            // Act
            var result = fhirInstant.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.NotNull(fhirInstant.Value);
        }

        [Fact]
        public void FhirInstant_Specific_EmptyStringIsInvalid()
        {
            // Arrange
            var fhirInstant = new FhirInstant("");

            // Act
            var result = fhirInstant.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirInstant_Specific_DateOnlyIsInvalid()
        {
            // Arrange
            var fhirInstant = new FhirInstant("2023-01-01");

            // Act
            var result = fhirInstant.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirInstant_Specific_TimeOnlyIsInvalid()
        {
            // Arrange
            var fhirInstant = new FhirInstant("12:00:00Z");

            // Act
            var result = fhirInstant.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("2023-01-01T12:00:00Z")]
        [InlineData("2023-12-31T23:59:59Z")]
        [InlineData("2020-02-29T12:00:00Z")]
        [InlineData("2023-06-15T12:30:45Z")]
        public void FhirInstant_Specific_ValidInstantsAreParsedCorrectly(string input)
        {
            // Arrange
            var fhirInstant = new FhirInstant(input);

            // Act
            var result = fhirInstant.Value;

            // Assert
            Assert.NotNull(result);
            Assert.True(fhirInstant.IsValidValue());
        }

        #endregion
    }
} 