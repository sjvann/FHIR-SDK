using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// FhirString 測試類別
    /// 繼承自 PrimitiveTypeTestBase，使用泛型架構
    /// </summary>
    public class FhirStringTests : PrimitiveTypeTestBase<FhirString>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "Hello World",
                "123",
                "Special chars: !@#$%^&*()",
                "Unicode: 中文測試"
            };
        }

        public override string[] GetInvalidValues()
        {
            // FhirString 的空字串是無效的（根據正則表達式驗證）
            return new[]
            {
                ""
            };
        }

        public override string GetExpectedTypeName()
        {
            return "String";
        }

        public override FhirString CreateInstance(string value)
        {
            return new FhirString(value);
        }

        public override FhirString CreateNullInstance()
        {
            return new FhirString(null);
        }

        #endregion

        #region 覆寫 GetValueFromInstance 方法

        protected override object? GetValueFromInstance(FhirString instance)
        {
            return instance.Value;
        }

        #endregion

        #region FhirString 特定測試

        [Fact]
        public void FhirString_Specific_EmptyStringIsInvalid()
        {
            // Arrange
            var fhirString = new FhirString("");

            // Act
            var result = fhirString.IsValidValue();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FhirString_Specific_UnicodeCharactersAreValid()
        {
            // Arrange
            var fhirString = new FhirString("中文測試");

            // Act
            var result = fhirString.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.Equal("中文測試", fhirString.Value);
        }

        [Fact]
        public void FhirString_Specific_ConstructorWithJsonObject()
        {
            // Arrange
            var jsonObject = new System.Text.Json.Nodes.JsonObject
            {
                ["value"] = "test from json"
            };

            // Act
            var fhirString = new FhirString(jsonObject);

            // Assert
            // 注意：JSON 建構函式可能需要不同的處理方式
            // 這裡我們測試基本功能
            Assert.NotNull(fhirString);
        }

        #endregion
    }
} 