using DataTypeServices.Attributes;
using System;
using System.Collections.Generic;
using Xunit;

namespace DataTypeServices.Tests.Attributes
{
    public class CardinalityAttributeTests
    {
        [Fact]
        public void CardinalityAttribute_Constructor_ValidParameters_SetsProperties()
        {
            // Arrange & Act
            var attr = new CardinalityAttribute(1, 5);

            // Assert
            Assert.Equal(1, attr.Min);
            Assert.Equal(5, attr.Max);
            Assert.True(attr.IsRequired);
            Assert.True(attr.AllowsMultiple);
        }

        [Fact]
        public void CardinalityAttribute_Constructor_UnlimitedMax_SetsCorrectly()
        {
            // Arrange & Act
            var attr = new CardinalityAttribute(0, -1);

            // Assert
            Assert.Equal(0, attr.Min);
            Assert.Equal(-1, attr.Max);
            Assert.False(attr.IsRequired);
            Assert.True(attr.AllowsMultiple);
        }

        [Fact]
        public void CardinalityAttribute_Constructor_InvalidMin_ThrowsException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new CardinalityAttribute(-1, 1));
        }

        [Fact]
        public void CardinalityAttribute_Constructor_InvalidMax_ThrowsException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new CardinalityAttribute(2, 1));
        }

        [Theory]
        [InlineData(null, 0)]
        [InlineData("single value", 1)]
        [InlineData(new string[] { }, 0)]
        [InlineData(new string[] { "one" }, 1)]
        [InlineData(new string[] { "one", "two", "three" }, 3)]
        public void CardinalityAttribute_IsValid_VariousValues_ReturnsExpected(object? value, int expectedCount)
        {
            // Arrange
            var attr = new CardinalityAttribute(0, 5);

            // Act
            var isValid = attr.IsValid(value);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void CardinalityAttribute_IsValid_TooFewValues_ReturnsFalse()
        {
            // Arrange
            var attr = new CardinalityAttribute(2, 5);
            var value = new string[] { "one" };

            // Act
            var isValid = attr.IsValid(value);

            // Assert
            Assert.False(isValid);
        }

        [Fact]
        public void CardinalityAttribute_IsValid_TooManyValues_ReturnsFalse()
        {
            // Arrange
            var attr = new CardinalityAttribute(0, 2);
            var value = new string[] { "one", "two", "three" };

            // Act
            var isValid = attr.IsValid(value);

            // Assert
            Assert.False(isValid);
        }

        [Fact]
        public void CardinalityAttribute_IsValid_UnlimitedMax_AlwaysValidForCount()
        {
            // Arrange
            var attr = new CardinalityAttribute(0, -1);
            var value = new string[100]; // 大量值

            // Act
            var isValid = attr.IsValid(value);

            // Assert
            Assert.True(isValid);
        }

        [Theory]
        [InlineData(0, 1, "0..1")]
        [InlineData(1, 1, "1..1")]
        [InlineData(0, -1, "0..*")]
        [InlineData(1, -1, "1..*")]
        [InlineData(2, 5, "2..5")]
        public void CardinalityAttribute_GetCardinalityString_ReturnsCorrectFormat(int min, int max, string expected)
        {
            // Arrange
            var attr = new CardinalityAttribute(min, max);

            // Act
            var result = attr.GetCardinalityString();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RequiredAttribute_Constructor_SetsCorrectCardinality()
        {
            // Arrange & Act
            var attr = new RequiredAttribute();

            // Assert
            Assert.Equal(1, attr.Min);
            Assert.Equal(1, attr.Max);
            Assert.True(attr.IsRequired);
            Assert.False(attr.AllowsMultiple);
        }

        [Fact]
        public void OptionalAttribute_Constructor_SetsCorrectCardinality()
        {
            // Arrange & Act
            var attr = new OptionalAttribute();

            // Assert
            Assert.Equal(0, attr.Min);
            Assert.Equal(1, attr.Max);
            Assert.False(attr.IsRequired);
            Assert.False(attr.AllowsMultiple);
        }

        [Fact]
        public void RequiredMultipleAttribute_Constructor_SetsCorrectCardinality()
        {
            // Arrange & Act
            var attr = new RequiredMultipleAttribute();

            // Assert
            Assert.Equal(1, attr.Min);
            Assert.Equal(-1, attr.Max);
            Assert.True(attr.IsRequired);
            Assert.True(attr.AllowsMultiple);
        }

        [Fact]
        public void OptionalMultipleAttribute_Constructor_SetsCorrectCardinality()
        {
            // Arrange & Act
            var attr = new OptionalMultipleAttribute();

            // Assert
            Assert.Equal(0, attr.Min);
            Assert.Equal(-1, attr.Max);
            Assert.False(attr.IsRequired);
            Assert.True(attr.AllowsMultiple);
        }

        [Fact]
        public void MultipleAttribute_Constructor_SetsCorrectCardinality()
        {
            // Arrange & Act
            var attr = new MultipleAttribute(2, 10);

            // Assert
            Assert.Equal(2, attr.Min);
            Assert.Equal(10, attr.Max);
            Assert.True(attr.IsRequired);
            Assert.True(attr.AllowsMultiple);
        }

        [Fact]
        public void CardinalityAttribute_FormatErrorMessage_ReturnsCorrectMessage()
        {
            // Arrange
            var attr = new CardinalityAttribute(1, 3);
            var fieldName = "TestField";

            // Act
            var message = attr.FormatErrorMessage(fieldName);

            // Assert
            Assert.Contains(fieldName, message);
            Assert.Contains("1", message);
            Assert.Contains("3", message);
        }

        [Fact]
        public void RequiredAttribute_FormatErrorMessage_ReturnsRequiredMessage()
        {
            // Arrange
            var attr = new RequiredAttribute();
            var fieldName = "TestField";

            // Act
            var message = attr.FormatErrorMessage(fieldName);

            // Assert
            Assert.Contains(fieldName, message);
            Assert.Contains("required", message);
            Assert.Contains("1..1", message);
        }
    }

    public class CardinalityValidatorTests
    {
        // 測試用的簡單類型
        public class TestClass
        {
            [Required]
            public string? RequiredField { get; set; }

            [Optional]
            public string? OptionalField { get; set; }

            [RequiredMultiple]
            public List<string>? RequiredMultipleField { get; set; }

            [OptionalMultiple]
            public List<string>? OptionalMultipleField { get; set; }

            [Cardinality(2, 5)]
            public List<string>? CustomCardinalityField { get; set; }
        }

        [Fact]
        public void CardinalityValidator_ValidateCardinality_ValidObject_ReturnsSuccess()
        {
            // Arrange
            var obj = new TestClass
            {
                RequiredField = "required value",
                RequiredMultipleField = new List<string> { "value1", "value2" },
                CustomCardinalityField = new List<string> { "a", "b", "c" }
            };

            // Act
            var results = DataTypeServices.Validation.CardinalityValidator.ValidateCardinality(obj);

            // Assert
            Assert.True(results.IsValid);
            Assert.Equal(0, results.ErrorCount);
        }

        [Fact]
        public void CardinalityValidator_ValidateCardinality_MissingRequired_ReturnsError()
        {
            // Arrange
            var obj = new TestClass
            {
                RequiredField = null, // 缺少必填欄位
                RequiredMultipleField = new List<string> { "value1" }
            };

            // Act
            var results = DataTypeServices.Validation.CardinalityValidator.ValidateCardinality(obj);

            // Assert
            Assert.False(results.IsValid);
            Assert.True(results.ErrorCount > 0);
            Assert.Contains(results.GetErrorMessages(), msg => msg.Contains("RequiredField"));
        }

        [Fact]
        public void CardinalityValidator_ValidateCardinality_TooManyValues_ReturnsError()
        {
            // Arrange
            var obj = new TestClass
            {
                RequiredField = "required value",
                RequiredMultipleField = new List<string> { "value1" },
                CustomCardinalityField = new List<string> { "a", "b", "c", "d", "e", "f" } // 超過最大值 5
            };

            // Act
            var results = DataTypeServices.Validation.CardinalityValidator.ValidateCardinality(obj);

            // Assert
            Assert.False(results.IsValid);
            Assert.True(results.ErrorCount > 0);
            Assert.Contains(results.GetErrorMessages(), msg => msg.Contains("CustomCardinalityField"));
        }

        [Fact]
        public void CardinalityValidator_GetCardinalityInfo_ReturnsCorrectInfo()
        {
            // Act
            var info = DataTypeServices.Validation.CardinalityValidator.GetCardinalityInfo(typeof(TestClass));

            // Assert
            Assert.Equal(5, info.Count);
            Assert.True(info["RequiredField"].IsRequired);
            Assert.False(info["OptionalField"].IsRequired);
            Assert.True(info["RequiredMultipleField"].AllowsMultiple);
            Assert.False(info["RequiredField"].AllowsMultiple);
        }

        [Fact]
        public void CardinalityValidator_HasCardinalityConstraints_ReturnsTrue()
        {
            // Act
            var hasConstraints = DataTypeServices.Validation.CardinalityValidator.HasCardinalityConstraints(typeof(TestClass));

            // Assert
            Assert.True(hasConstraints);
        }

        [Fact]
        public void CardinalityValidator_GetRequiredProperties_ReturnsCorrectProperties()
        {
            // Act
            var requiredProps = DataTypeServices.Validation.CardinalityValidator.GetRequiredProperties(typeof(TestClass));

            // Assert
            Assert.Equal(3, requiredProps.Count); // RequiredField, RequiredMultipleField 和 CustomCardinalityField
            Assert.Contains(requiredProps, p => p.Name == "RequiredField");
            Assert.Contains(requiredProps, p => p.Name == "RequiredMultipleField");
            Assert.Contains(requiredProps, p => p.Name == "CustomCardinalityField");
        }
    }

    public class CustomValidationTests
    {
        // 測試用的簡單類型
        public class TestValidatedClass
        {
            [EmailValidation]
            public string? Email { get; set; }

            [UrlValidation]
            public string? Website { get; set; }

            [RegexValidation(@"^\d{3}-\d{2}-\d{4}$", ErrorMessage = "SSN must be in format XXX-XX-XXXX")]
            public string? SSN { get; set; }

            [NumericRangeValidation(MinValue = 18, MaxValue = 120)]
            public int? Age { get; set; }

            [FhirValidation("ValidateCustomField")]
            public string? CustomField { get; set; }

            public DataTypeServices.TypeFramework.ValidationResult ValidateCustomField(string? value)
            {
                if (value == "invalid")
                {
                    return DataTypeServices.TypeFramework.ValidationResult.Error("Custom validation failed", "CustomField");
                }
                return DataTypeServices.TypeFramework.ValidationResult.Success();
            }
        }

        [Fact]
        public void CustomValidationEngine_ValidEmail_ReturnsSuccess()
        {
            // Arrange
            var obj = new TestValidatedClass { Email = "test@example.com" };

            // Act
            var results = DataTypeServices.Validation.CustomValidationEngine.ValidateCustomAttributes(obj);

            // Assert
            Assert.True(results.IsValid);
        }

        [Fact]
        public void CustomValidationEngine_InvalidEmail_ReturnsError()
        {
            // Arrange
            var obj = new TestValidatedClass { Email = "invalid-email" };

            // Act
            var results = DataTypeServices.Validation.CustomValidationEngine.ValidateCustomAttributes(obj);

            // Assert
            Assert.False(results.IsValid);
            Assert.Contains(results.GetErrorMessages(), msg => msg.Contains("Invalid email format"));
        }

        [Fact]
        public void CustomValidationEngine_ValidUrl_ReturnsSuccess()
        {
            // Arrange
            var obj = new TestValidatedClass { Website = "https://example.com" };

            // Act
            var results = DataTypeServices.Validation.CustomValidationEngine.ValidateCustomAttributes(obj);

            // Assert
            Assert.True(results.IsValid);
        }

        [Fact]
        public void CustomValidationEngine_InvalidUrl_ReturnsError()
        {
            // Arrange
            var obj = new TestValidatedClass { Website = "not-a-url" };

            // Act
            var results = DataTypeServices.Validation.CustomValidationEngine.ValidateCustomAttributes(obj);

            // Assert
            Assert.False(results.IsValid);
            Assert.Contains(results.GetErrorMessages(), msg => msg.Contains("Invalid URL format"));
        }

        [Fact]
        public void CustomValidationEngine_ValidRegex_ReturnsSuccess()
        {
            // Arrange
            var obj = new TestValidatedClass { SSN = "123-45-6789" };

            // Act
            var results = DataTypeServices.Validation.CustomValidationEngine.ValidateCustomAttributes(obj);

            // Assert
            Assert.True(results.IsValid);
        }

        [Fact]
        public void CustomValidationEngine_InvalidRegex_ReturnsError()
        {
            // Arrange
            var obj = new TestValidatedClass { SSN = "123456789" };

            // Act
            var results = DataTypeServices.Validation.CustomValidationEngine.ValidateCustomAttributes(obj);

            // Assert
            Assert.False(results.IsValid);
            Assert.Contains(results.GetErrorMessages(), msg => msg.Contains("SSN must be in format XXX-XX-XXXX"));
        }

        [Fact]
        public void CustomValidationEngine_ValidNumericRange_ReturnsSuccess()
        {
            // Arrange
            var obj = new TestValidatedClass { Age = 25 };

            // Act
            var results = DataTypeServices.Validation.CustomValidationEngine.ValidateCustomAttributes(obj);

            // Assert
            Assert.True(results.IsValid);
        }

        [Fact]
        public void CustomValidationEngine_InvalidNumericRange_ReturnsError()
        {
            // Arrange
            var obj = new TestValidatedClass { Age = 150 };

            // Act
            var results = DataTypeServices.Validation.CustomValidationEngine.ValidateCustomAttributes(obj);

            // Assert
            Assert.False(results.IsValid);
            Assert.Contains(results.GetErrorMessages(), msg => msg.Contains("above maximum allowed value"));
        }

        [Fact]
        public void CustomValidationEngine_CustomMethod_ReturnsCorrectResult()
        {
            // Arrange
            var validObj = new TestValidatedClass { CustomField = "valid" };
            var invalidObj = new TestValidatedClass { CustomField = "invalid" };

            // Act
            var validResults = DataTypeServices.Validation.CustomValidationEngine.ValidateCustomAttributes(validObj);
            var invalidResults = DataTypeServices.Validation.CustomValidationEngine.ValidateCustomAttributes(invalidObj);

            // Assert
            Assert.True(validResults.IsValid);
            Assert.False(invalidResults.IsValid);
            Assert.Contains(invalidResults.GetErrorMessages(), msg => msg.Contains("Custom validation failed"));
        }

        [Fact]
        public void CustomValidationEngine_MultipleValidations_ReturnsAllErrors()
        {
            // Arrange
            var obj = new TestValidatedClass
            {
                Email = "invalid-email",
                Website = "not-a-url",
                Age = 200
            };

            // Act
            var results = DataTypeServices.Validation.CustomValidationEngine.ValidateCustomAttributes(obj);

            // Assert
            Assert.False(results.IsValid);
            Assert.True(results.ErrorCount >= 3);
        }
    }
}
