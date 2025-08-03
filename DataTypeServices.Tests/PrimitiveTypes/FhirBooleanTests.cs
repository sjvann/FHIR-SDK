using DataTypeServices.DataTypes.PrimitiveTypes;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    /// <summary>
    /// FhirBoolean 測試類別
    /// 繼承自 PrimitiveTypeTestBase，使用泛型架構
    /// </summary>
    public class FhirBooleanTests : PrimitiveTypeTestBase<FhirBoolean>
    {
        #region 抽象方法實作

        public override string[] GetValidValues()
        {
            return new[]
            {
                "true",
                "false",
                "True",
                "False"
            };
        }

        public override string[] GetInvalidValues()
        {
            // FhirBoolean 沒有無效值，所有有效的布林值都是有效的
            return new string[0];
        }

        public override string GetExpectedTypeName()
        {
            return "Boolean";
        }

        public override FhirBoolean CreateInstance(string value)
        {
            return new FhirBoolean(value);
        }

        public override FhirBoolean CreateNullInstance()
        {
            return new FhirBoolean((bool?)null);
        }

        #endregion

        #region 覆寫 GetValueFromInstance 方法

        protected override object? GetValueFromInstance(FhirBoolean instance)
        {
            return instance.Value;
        }

        #endregion

        #region FhirBoolean 特定測試

        [Fact]
        public void FhirBoolean_Specific_TrueValueIsValid()
        {
            // Arrange
            var fhirBoolean = new FhirBoolean(true);

            // Act
            var result = fhirBoolean.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.True(fhirBoolean.Value);
        }

        [Fact]
        public void FhirBoolean_Specific_FalseValueIsValid()
        {
            // Arrange
            var fhirBoolean = new FhirBoolean(false);

            // Act
            var result = fhirBoolean.IsValidValue();

            // Assert
            Assert.True(result);
            Assert.False(fhirBoolean.Value);
        }

        [Theory]
        [InlineData("true", true)]
        [InlineData("false", false)]
        [InlineData("True", true)]
        [InlineData("False", false)]
        public void FhirBoolean_Specific_StringValuesAreParsedCorrectly(string input, bool expected)
        {
            // Arrange
            var fhirBoolean = new FhirBoolean(input);

            // Act
            var result = fhirBoolean.Value;

            // Assert
            Assert.Equal(expected, result);
            Assert.True(fhirBoolean.IsValidValue());
        }

        [Fact]
        public void FhirBoolean_Specific_NullValueIsInvalid()
        {
            // Arrange
            var fhirBoolean = new FhirBoolean((bool?)null);

            // Act
            var result = fhirBoolean.IsValidValue();

            // Assert
            Assert.False(result);
        }

        #endregion
    }
} 