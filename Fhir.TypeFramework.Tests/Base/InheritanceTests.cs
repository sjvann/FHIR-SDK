using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Xunit;

namespace Fhir.TypeFramework.Tests.Base;

/// <summary>
/// Tests for FHIR Type Framework Inheritance Hierarchy
/// </summary>
public class InheritanceTests
{
    [Fact]
    public void InheritanceHierarchy_ShouldBeCorrect()
    {
        // Arrange & Act
        var fhirString = new FhirString("Test");

        // Assert - 檢查繼承關係
        Assert.True(fhirString is PrimitiveType);
        Assert.True(fhirString is DataType);
        Assert.True(fhirString is Element);
        Assert.True(fhirString is Base);
    }

    [Fact]
    public void Element_ShouldHaveIdAndExtension()
    {
        // Arrange
        var element = new TestElement
        {
            Id = "test-id",
            Extension = new List<IExtension>
            {
                new Extension { Url = "http://example.com/ext", Value = new FhirString("value") }
            }
        };

        // Assert
        Assert.Equal("test-id", element.Id);
        Assert.NotNull(element.Extension);
        Assert.Single(element.Extension);
        Assert.True(element.HasExtensions);
    }

    [Fact]
    public void DataType_ShouldInheritIdAndExtensionFromElement()
    {
        // Arrange
        var dataType = new TestDataType
        {
            Id = "data-type-id",
            Extension = new List<IExtension>
            {
                new Extension { Url = "http://example.com/ext", Value = new FhirInteger(42) }
            }
        };

        // Assert
        Assert.Equal("data-type-id", dataType.Id);
        Assert.NotNull(dataType.Extension);
        Assert.Single(dataType.Extension);
        Assert.True(dataType.HasExtensions);
    }

    [Fact]
    public void PrimitiveType_ShouldInheritIdAndExtensionFromDataType()
    {
        // Arrange
        var primitiveType = new FhirString("Test Value")
        {
            Id = "primitive-id",
            Extension = new List<IExtension>
            {
                new Extension { Url = "http://example.com/ext", Value = new FhirBoolean(true) }
            }
        };

        // Assert
        Assert.Equal("primitive-id", primitiveType.Id);
        Assert.NotNull(primitiveType.Extension);
        Assert.Single(primitiveType.Extension);
        Assert.True(primitiveType.HasExtensions);
        Assert.Equal("Test Value", primitiveType.Value);
    }

    [Fact]
    public void Element_AddExtension_ShouldWork()
    {
        // Arrange
        var element = new TestElement();

        // Act
        element.AddExtension("http://example.com/ext", new FhirString("test value"));

        // Assert
        Assert.True(element.HasExtensions);
        Assert.Single(element.Extension);
        
        var extension = element.GetExtension("http://example.com/ext");
        Assert.NotNull(extension);
        Assert.Equal("http://example.com/ext", extension.Url);
    }

    [Fact]
    public void Element_RemoveExtension_ShouldWork()
    {
        // Arrange
        var element = new TestElement();
        element.AddExtension("http://example.com/ext", new FhirString("test value"));

        // Act
        var removed = element.RemoveExtension("http://example.com/ext");

        // Assert
        Assert.True(removed);
        Assert.False(element.HasExtensions);
        Assert.Null(element.GetExtension("http://example.com/ext"));
    }

    [Fact]
    public void PrimitiveType_DeepCopy_ShouldIncludeIdAndExtension()
    {
        // Arrange
        var original = new FhirString("Original Value")
        {
            Id = "original-id",
            Extension = new List<IExtension>
            {
                new Extension { Url = "http://example.com/ext", Value = new FhirInteger(42) }
            }
        };

        // Act
        var copy = (FhirString)original.DeepCopy();

        // Assert
        Assert.Equal(original.Value, copy.Value);
        Assert.Equal(original.Id, copy.Id);
        Assert.NotNull(copy.Extension);
        Assert.Single(copy.Extension);
        Assert.NotSame(original, copy);
    }

    [Fact]
    public void PrimitiveType_IsExactly_ShouldCompareIdAndExtension()
    {
        // Arrange
        var primitive1 = new FhirString("Same Value")
        {
            Id = "same-id",
            Extension = new List<IExtension>
            {
                new Extension { Url = "http://example.com/ext", Value = new FhirInteger(42) }
            }
        };

        var primitive2 = new FhirString("Same Value")
        {
            Id = "same-id",
            Extension = new List<IExtension>
            {
                new Extension { Url = "http://example.com/ext", Value = new FhirInteger(42) }
            }
        };

        var primitive3 = new FhirString("Different Value")
        {
            Id = "different-id"
        };

        // Act & Assert
        Assert.True(primitive1.IsExactly(primitive2));
        Assert.False(primitive1.IsExactly(primitive3));
    }

    // 測試用的具體實作類別
    private class TestElement : Element
    {
        public override Base DeepCopy()
        {
            var copy = new TestElement
            {
                Id = Id
            };

            if (Extension != null)
            {
                copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
            }

            return copy;
        }
    }

    private class TestDataType : DataType
    {
        public override Base DeepCopy()
        {
            var copy = new TestDataType
            {
                Id = Id
            };

            if (Extension != null)
            {
                copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
            }

            return copy;
        }
    }
} 