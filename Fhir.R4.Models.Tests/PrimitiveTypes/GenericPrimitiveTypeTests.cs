using Fhir.R4.Models.DataTypes;
using Xunit;

namespace Fhir.R4.Models.Tests.PrimitiveTypes;

/// <summary>
/// Tests for the generic PrimitiveType base class and its implementations.
/// </summary>
public class GenericPrimitiveTypeTests
{
    #region Basic Generic PrimitiveType Tests

    [Fact]
    public void PrimitiveType_WithString_ShouldWork()
    {
        // Arrange & Act
        var primitive = new PrimitiveType<string>("Hello World");

        // Assert
        Assert.Equal("Hello World", primitive.Value);
        Assert.Equal("Hello World", primitive.ToString());
    }

    [Fact]
    public void PrimitiveType_WithInteger_ShouldWork()
    {
        // Arrange & Act
        var primitive = new PrimitiveType<int>(42);

        // Assert
        Assert.Equal(42, primitive.Value);
        Assert.Equal("42", primitive.ToString());
    }

    [Fact]
    public void PrimitiveType_WithBoolean_ShouldWork()
    {
        // Arrange & Act
        var primitive = new PrimitiveType<bool>(true);

        // Assert
        Assert.True(primitive.Value);
        Assert.Equal("True", primitive.ToString());
    }

    [Fact]
    public void PrimitiveType_ImplicitConversion_FromValue_ShouldWork()
    {
        // Arrange & Act
        PrimitiveType<string> primitive = "Test Value";

        // Assert
        Assert.Equal("Test Value", primitive.Value);
    }

    [Fact]
    public void PrimitiveType_ImplicitConversion_ToValue_ShouldWork()
    {
        // Arrange
        var primitive = new PrimitiveType<string>("Test Value");

        // Act
        string? value = primitive;

        // Assert
        Assert.Equal("Test Value", value);
    }

    [Fact]
    public void PrimitiveType_CreateMethod_ShouldWork()
    {
        // Arrange & Act
        var primitive = PrimitiveType<decimal>.Create(123.45m);

        // Assert
        Assert.Equal(123.45m, primitive.Value);
    }

    #endregion

    #region Specific Generic Implementations Tests

    [Fact]
    public void FhirStringGeneric_ShouldWork()
    {
        // Arrange & Act
        var fhirString = new FhirStringGeneric("Hello FHIR");

        // Assert
        Assert.Equal("Hello FHIR", fhirString.Value);
        Assert.Equal("Hello FHIR", fhirString.ToString());
    }

    [Fact]
    public void FhirStringGeneric_ImplicitConversion_ShouldWork()
    {
        // Arrange & Act
        FhirStringGeneric fhirString = "Implicit Conversion";

        // Assert
        Assert.Equal("Implicit Conversion", fhirString.Value);
    }

    [Fact]
    public void FhirIntegerGeneric_ShouldWork()
    {
        // Arrange & Act
        var fhirInteger = new FhirIntegerGeneric(100);

        // Assert
        Assert.Equal(100, fhirInteger.Value);
        Assert.Equal("100", fhirInteger.ToString());
    }

    [Fact]
    public void FhirPositiveIntGeneric_WithValidValue_ShouldPass()
    {
        // Arrange
        var fhirPositiveInt = new FhirPositiveIntGeneric(10);

        // Act
        var validationResults = fhirPositiveInt.Validate(new System.ComponentModel.DataAnnotations.ValidationContext(fhirPositiveInt));

        // Assert
        Assert.Empty(validationResults);
    }

    [Fact]
    public void FhirPositiveIntGeneric_WithInvalidValue_ShouldFail()
    {
        // Arrange
        var fhirPositiveInt = new FhirPositiveIntGeneric(-5);

        // Act
        var validationResults = fhirPositiveInt.Validate(new System.ComponentModel.DataAnnotations.ValidationContext(fhirPositiveInt));

        // Assert
        Assert.NotEmpty(validationResults);
        Assert.Contains("must be greater than 0", validationResults.First().ErrorMessage);
    }

    #endregion

    #region Comparison and Equality Tests

    [Fact]
    public void PrimitiveType_Equality_ShouldWork()
    {
        // Arrange
        var primitive1 = new PrimitiveType<string>("Same Value");
        var primitive2 = new PrimitiveType<string>("Same Value");
        var primitive3 = new PrimitiveType<string>("Different Value");

        // Act & Assert
        Assert.True(primitive1.Equals(primitive2));
        Assert.False(primitive1.Equals(primitive3));
        Assert.Equal(primitive1.GetHashCode(), primitive2.GetHashCode());
    }

    [Fact]
    public void PrimitiveType_WithNull_ShouldWork()
    {
        // Arrange & Act
        var primitive = new PrimitiveType<string>(null);

        // Assert
        Assert.Null(primitive.Value);
        Assert.Null(primitive.ToString());
    }

    #endregion

    #region Usage Scenarios Tests

    [Fact]
    public void UsageScenario_YourProposedSyntax_ShouldWork()
    {
        // 您提議的語法測試
        // Arrange & Act
        var fs = new PrimitiveType<string>("AAA");

        // Assert
        Assert.Equal("AAA", fs.Value);
        Assert.Equal("AAA", fs.ToString());
    }

    [Fact]
    public void UsageScenario_FluentAPI_ShouldWork()
    {
        // Arrange & Act
        var stringPrimitive = PrimitiveType<string>.Create("Hello");
        var intPrimitive = PrimitiveType<int>.Create(42);
        var boolPrimitive = PrimitiveType<bool>.Create(true);

        // Assert
        Assert.Equal("Hello", stringPrimitive.Value);
        Assert.Equal(42, intPrimitive.Value);
        Assert.True(boolPrimitive.Value);
    }

    [Fact]
    public void UsageScenario_MixedWithExistingTypes_ShouldWork()
    {
        // 測試與現有型別的相容性
        // Arrange
        var existingFhirString = new FhirString("Existing");
        var genericFhirString = new FhirStringGeneric("Generic");

        // Act & Assert
        Assert.Equal("Existing", existingFhirString.Value);
        Assert.Equal("Generic", genericFhirString.Value);
        
        // 兩者都應該能正常工作
        Assert.IsType<FhirString>(existingFhirString);
        Assert.IsType<FhirStringGeneric>(genericFhirString);
    }

    #endregion

    #region Performance and Memory Tests

    [Fact]
    public void PrimitiveType_MemoryUsage_ShouldBeEfficient()
    {
        // 測試記憶體使用效率
        // Arrange & Act
        var primitives = new List<PrimitiveType<int>>();
        for (int i = 0; i < 1000; i++)
        {
            primitives.Add(new PrimitiveType<int>(i));
        }

        // Assert
        Assert.Equal(1000, primitives.Count);
        Assert.All(primitives, p => Assert.NotNull(p.Value));
    }

    #endregion
}
