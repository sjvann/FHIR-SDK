using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Fhir.TypeFramework.Tests.ComplexTypes;

/// <summary>
/// Tests for FHIR Extension with Choice Type
/// </summary>
public class ExtensionTests
{
    #region Basic Extension Tests

    [Fact]
    public void Extension_WithValidUrl_ShouldWork()
    {
        // Arrange & Act
        var extension = new Extension
        {
            Url = "http://example.com/extension"
        };

        // Assert
        Assert.Equal("http://example.com/extension", extension.Url);
        Assert.False(extension.HasValue);
        Assert.False(extension.HasExtensions);
    }

    [Fact]
    public void Extension_WithStringValue_ShouldWork()
    {
        // Arrange & Act
        var extension = new Extension
        {
            Url = "http://example.com/extension",
            Value = new FhirString("Test Value")
        };

        // Assert
        Assert.Equal("http://example.com/extension", extension.Url);
        Assert.True(extension.HasValue);
        Assert.False(extension.HasExtensions);
        
        var stringValue = extension.GetValue<FhirString>();
        Assert.NotNull(stringValue);
        Assert.Equal("Test Value", stringValue.Value);
    }

    [Fact]
    public void Extension_WithIntegerValue_ShouldWork()
    {
        // Arrange & Act
        var extension = new Extension
        {
            Url = "http://example.com/extension",
            Value = new FhirInteger(42)
        };

        // Assert
        Assert.True(extension.HasValue);
        
        var intValue = extension.GetValue<FhirInteger>();
        Assert.NotNull(intValue);
        Assert.Equal(42, intValue.Value);
    }

    [Fact]
    public void Extension_WithBooleanValue_ShouldWork()
    {
        // Arrange & Act
        var extension = new Extension
        {
            Url = "http://example.com/extension",
            Value = new FhirBoolean(true)
        };

        // Assert
        Assert.True(extension.HasValue);
        
        var boolValue = extension.GetValue<FhirBoolean>();
        Assert.NotNull(boolValue);
        Assert.True(boolValue.Value);
    }

    #endregion

    #region Choice Type Tests

    [Fact]
    public void ExtensionValueChoice_WithFhirString_ShouldWork()
    {
        // Arrange & Act
        ExtensionValueChoice choice = new FhirString("Test Choice");

        // Assert
        Assert.NotNull(choice);
        
        var stringValue = choice.Match(
            t0 => t0,
            t1 => null as FhirString,
            t2 => null as FhirString,
            t3 => null as FhirString,
            t4 => null as FhirString,
            t5 => null as FhirString,
            t6 => null as FhirString,
            t7 => null as FhirString,
            t8 => null as FhirString,
            t9 => null as FhirString,
            t10 => null as FhirString,
            t11 => null as FhirString,
            t12 => null as FhirString,
            t13 => null as FhirString,
            t14 => null as FhirString,
            t15 => null as FhirString,
            t16 => null as FhirString,
            t17 => null as FhirString,
            t18 => null as FhirString,
            t19 => null as FhirString,
            t20 => null as FhirString,
            t21 => null as FhirString,
            t22 => null as FhirString,
            t23 => null as FhirString,
            t24 => null as FhirString,
            t25 => null as FhirString,
            t26 => null as FhirString,
            t27 => null as FhirString,
            t28 => null as FhirString,
            t29 => null as FhirString
        );
        
        Assert.NotNull(stringValue);
        Assert.Equal("Test Choice", stringValue.Value);
    }

    [Fact]
    public void ExtensionValueChoice_WithFhirInteger_ShouldWork()
    {
        // Arrange & Act
        ExtensionValueChoice choice = new FhirInteger(123);

        // Assert
        Assert.NotNull(choice);
        
        var intValue = choice.Match(
            t0 => null as FhirInteger,
            t1 => t1,
            t2 => null as FhirInteger,
            t3 => null as FhirInteger,
            t4 => null as FhirInteger,
            t5 => null as FhirInteger,
            t6 => null as FhirInteger,
            t7 => null as FhirInteger,
            t8 => null as FhirInteger,
            t9 => null as FhirInteger,
            t10 => null as FhirInteger,
            t11 => null as FhirInteger,
            t12 => null as FhirInteger,
            t13 => null as FhirInteger,
            t14 => null as FhirInteger,
            t15 => null as FhirInteger,
            t16 => null as FhirInteger,
            t17 => null as FhirInteger,
            t18 => null as FhirInteger,
            t19 => null as FhirInteger,
            t20 => null as FhirInteger,
            t21 => null as FhirInteger,
            t22 => null as FhirInteger,
            t23 => null as FhirInteger,
            t24 => null as FhirInteger,
            t25 => null as FhirInteger,
            t26 => null as FhirInteger,
            t27 => null as FhirInteger,
            t28 => null as FhirInteger,
            t29 => null as FhirInteger
        );
        
        Assert.NotNull(intValue);
        Assert.Equal(123, intValue.Value);
    }

    #endregion

    #region Extension Methods Tests

    [Fact]
    public void Extension_SetValue_ShouldWork()
    {
        // Arrange
        var extension = new Extension
        {
            Url = "http://example.com/extension"
        };

        // Act
        extension.SetValue(new FhirString("Set Value"));

        // Assert
        Assert.True(extension.HasValue);
        var value = extension.GetValue<FhirString>();
        Assert.NotNull(value);
        Assert.Equal("Set Value", value.Value);
    }

    [Fact]
    public void Extension_SetValueGeneric_ShouldWork()
    {
        // Arrange
        var extension = new Extension
        {
            Url = "http://example.com/extension"
        };

        // Act
        extension.SetValue(new FhirInteger(456));

        // Assert
        Assert.True(extension.HasValue);
        var value = extension.GetValue<FhirInteger>();
        Assert.NotNull(value);
        Assert.Equal(456, value.Value);
    }

    [Fact]
    public void Extension_AddExtension_ShouldWork()
    {
        // Arrange
        var extension = new Extension
        {
            Url = "http://example.com/parent"
        };

        // Act
        extension.AddExtension("http://example.com/child", new FhirString("Child Value"));

        // Assert
        Assert.True(extension.HasExtensions);
        Assert.Single(extension.Extension);
        
        var childExtension = extension.GetExtension("http://example.com/child");
        Assert.NotNull(childExtension);
        Assert.Equal("http://example.com/child", childExtension.Url);
    }

    [Fact]
    public void Extension_RemoveExtension_ShouldWork()
    {
        // Arrange
        var extension = new Extension
        {
            Url = "http://example.com/parent"
        };
        extension.AddExtension("http://example.com/child", new FhirString("Child Value"));

        // Act
        var removed = extension.RemoveExtension("http://example.com/child");

        // Assert
        Assert.True(removed);
        Assert.False(extension.HasExtensions);
        Assert.Null(extension.GetExtension("http://example.com/child"));
    }

    #endregion

    #region Validation Tests

    [Fact]
    public void Extension_WithValidData_ShouldPassValidation()
    {
        // Arrange
        var extension = new Extension
        {
            Url = "http://example.com/extension",
            Value = new FhirString("Valid Value")
        };

        // Act
        var validationResults = extension.Validate(new ValidationContext(extension));

        // Assert
        Assert.Empty(validationResults);
    }

    [Fact]
    public void Extension_WithoutUrl_ShouldFailValidation()
    {
        // Arrange
        var extension = new Extension
        {
            Value = new FhirString("Value without URL")
        };

        // Act
        var validationResults = extension.Validate(new ValidationContext(extension));

        // Assert
        Assert.NotEmpty(validationResults);
        Assert.Contains("Extension URL is required", validationResults.First().ErrorMessage);
    }

    [Fact]
    public void Extension_WithInvalidUrl_ShouldFailValidation()
    {
        // Arrange
        var extension = new Extension
        {
            Url = "not-a-valid-url",
            Value = new FhirString("Value with invalid URL")
        };

        // Act
        var validationResults = extension.Validate(new ValidationContext(extension));

        // Assert
        Assert.NotEmpty(validationResults);
        Assert.Contains("not a valid absolute URI", validationResults.First().ErrorMessage);
    }

    [Fact]
    public void Extension_WithBothValueAndExtensions_ShouldFailValidation()
    {
        // Arrange
        var extension = new Extension
        {
            Url = "http://example.com/extension",
            Value = new FhirString("Value"),
            Extension = new List<IExtension>
            {
                new Extension { Url = "http://example.com/nested", Value = new FhirInteger(1) }
            }
        };

        // Act
        var validationResults = extension.Validate(new ValidationContext(extension));

        // Assert
        Assert.NotEmpty(validationResults);
        Assert.Contains("cannot have both value and nested extensions", validationResults.First().ErrorMessage);
    }

    #endregion

    #region Deep Copy Tests

    [Fact]
    public void Extension_DeepCopy_ShouldWork()
    {
        // Arrange
        var original = new Extension
        {
            Url = "http://example.com/extension",
            Value = new FhirString("Original Value")
        };
        original.AddExtension("http://example.com/nested", new FhirInteger(42));

        // Act
        var copy = (Extension)original.DeepCopy();

        // Assert
        Assert.Equal(original.Url, copy.Url);
        Assert.NotNull(copy.Value);
        Assert.NotNull(copy.Extension);
        Assert.Single(copy.Extension);
        Assert.NotSame(original, copy);
    }

    #endregion

    #region Equality Tests

    [Fact]
    public void Extension_IsExactly_ShouldWork()
    {
        // Arrange
        var extension1 = new Extension
        {
            Url = "http://example.com/extension",
            Value = new FhirString("Same Value")
        };
        var extension2 = new Extension
        {
            Url = "http://example.com/extension",
            Value = new FhirString("Same Value")
        };
        var extension3 = new Extension
        {
            Url = "http://example.com/extension",
            Value = new FhirString("Different Value")
        };

        // Act & Assert
        Assert.True(extension1.IsExactly(extension2));
        Assert.False(extension1.IsExactly(extension3));
    }

    #endregion
} 