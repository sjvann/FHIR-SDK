using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using Xunit;

namespace DataTypeServices.Tests.PrimitiveTypes
{
    public class FhirXhtmlTests : PrimitiveTypeTestBase<FhirXhtml>
    {
        public override string[] GetValidValues()
        {
            return new[]
            {
                "<div xmlns=\"http://www.w3.org/1999/xhtml\">Content</div>",
                "<p xmlns=\"http://www.w3.org/1999/xhtml\">Paragraph</p>",
                "<span xmlns=\"http://www.w3.org/1999/xhtml\">Text</span>"
            };
        }

        public override string[] GetInvalidValues()
        {
            return new[]
            {
                "",
                "Plain text without tags"
            };
        }

        public override string GetExpectedTypeName()
        {
            return "XHTML";
        }

        public override FhirXhtml CreateInstance(string value)
        {
            return new FhirXhtml(value);
        }

        public override FhirXhtml CreateNullInstance()
        {
            return new FhirXhtml((string?)null);
        }

        protected override object? GetValueFromInstance(FhirXhtml instance)
        {
            return instance.Value;
        }

        // 跳過基底的測試，因為FhirXhtml是特殊情況
        [Fact(Skip = "FhirXhtml 使用特殊測試")]
        public override void TestGetFhirTypeName_WithCapital_ReturnsTypeName()
        {
            // 跳過基底測試
        }

        [Fact(Skip = "FhirXhtml 使用特殊測試")]
        public override void TestGetFhirTypeName_WithoutCapital_ReturnsLowercase()
        {
            // 跳過基底測試
        }

        [Fact]
        public void TestGetFhirTypeName_WithoutCapital_ReturnsLowercase_Xhtml()
        {
            // Arrange
            var validValue = GetValidValues()[0];
            var instance = CreateInstance(validValue);

            // Act
            var result = instance.GetFhirTypeName(false);

            // Assert
            // FhirXhtml 特殊情況：返回全小寫 "xhtml"
            Assert.Equal("xhtml", result);
        }

        [Fact]
        public void TestGetFhirTypeName_WithCapital_ReturnsTypeName_Xhtml()
        {
            // Arrange
            var validValue = GetValidValues()[0];
            var instance = CreateInstance(validValue);

            // Act
            var result = instance.GetFhirTypeName(true);

            // Assert
            // FhirXhtml 特殊情況：返回全大寫 "XHTML"
            Assert.Equal("XHTML", result);
        }
    }
} 