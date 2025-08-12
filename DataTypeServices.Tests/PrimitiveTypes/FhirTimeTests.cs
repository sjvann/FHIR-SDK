using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// FhirTime 測試類別
    /// 繼承自 PrimitiveTypeTestBase，使用泛型架構
    /// </summary>
    public class FhirTimeTests : PrimitiveTypeTestBase<FhirTime>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "12:00:00",
                "00:00:00",
                "23:59:59",
                "12:30:45",
                "09:15:30",
                "16:45:12"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "24:00:00", // 無效小時
                "12:60:00", // 無效分鐘
                "12:00:60", // 無效秒數
                "12:00", // 缺少秒數
                "12", // 只包含小時
                "12:00:00Z", // 包含時區（不支援）
                "12:00:00+05:00" // 包含時區（不支援）
            };
        }

        public override string GetExpectedTypeName()
        {
            return "Time";
        }

        public override FhirTime CreateInstance(string value)
        {
            return new FhirTime(value);
        }

        public override FhirTime CreateNullInstance()
        {
            return new FhirTime((string?)null);
        }

        #endregion

        #region 覆寫 GetValueFromInstance 方法

        protected override object? GetValueFromInstance(FhirTime instance)
        {
            return instance.Value;
        }

        #endregion

        #region FhirTime 特定測試

        [Fact]
        public void FhirTime_Specific_ValidTimeIsValid()
        {
            // Arrange
            var fhirTime = new FhirTime("12:00:00");

            // Act
            var result = fhirTime.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.NotNull(fhirTime.Value);
        }

        [Fact]
        public void FhirTime_Specific_MidnightTimeIsValid()
        {
            // Arrange
            var fhirTime = new FhirTime("00:00:00");

            // Act
            var result = fhirTime.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.NotNull(fhirTime.Value);
        }

        [Fact]
        public void FhirTime_Specific_EndOfDayTimeIsValid()
        {
            // Arrange
            var fhirTime = new FhirTime("23:59:59");

            // Act
            var result = fhirTime.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.NotNull(fhirTime.Value);
        }

        [Fact]
        public void FhirTime_Specific_EmptyStringIsInvalid()
        {
            // Arrange
            var fhirTime = new FhirTime("");

            // Act
            var result = fhirTime.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirTime_Specific_InvalidHourIsInvalid()
        {
            // Arrange
            var fhirTime = new FhirTime("24:00:00");

            // Act
            var result = fhirTime.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirTime_Specific_InvalidMinuteIsInvalid()
        {
            // Arrange
            var fhirTime = new FhirTime("12:60:00");

            // Act
            var result = fhirTime.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirTime_Specific_InvalidSecondIsInvalid()
        {
            // Arrange
            var fhirTime = new FhirTime("12:00:60");

            // Act
            var result = fhirTime.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("12:00:00")]
        [InlineData("00:00:00")]
        [InlineData("23:59:59")]
        [InlineData("12:30:45")]
        public void FhirTime_Specific_ValidTimesAreParsedCorrectly(string input)
        {
            // Arrange
            var fhirTime = new FhirTime(input);

            // Act
            var result = fhirTime.Value;

            // Assert
            Assert.NotNull(result);
            Assert.True(fhirTime.IsValidValue());
        }

        #endregion
    }
} 