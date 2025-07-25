using Fhir.R4.Models.DataTypes;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Fhir.R4.Models.Tests.ComplexTypes;

/// <summary>
/// Tests for the generic ComplexType base class and new complex types.
/// </summary>
public class ComplexTypeGenericTests
{
    #region Generic ComplexType Tests

    [Fact]
    public void ComplexType_Create_ShouldWork()
    {
        // Arrange & Act
        var complexType = ComplexType.Create();

        // Assert
        Assert.NotNull(complexType);
        Assert.IsType<ComplexType>(complexType);
    }

    [Fact]
    public void ComplexType_CreateWithConfiguration_ShouldWork()
    {
        // Arrange & Act
        var complexType = ComplexType.Create(ct => 
        {
            ct.SetProperty("test", "value");
        });

        // Assert
        Assert.NotNull(complexType);
        Assert.Equal("value", complexType.GetProperty<string>("test"));
    }

    [Fact]
    public void ComplexType_Configure_ShouldWork()
    {
        // Arrange
        var complexType = new ComplexType();

        // Act
        var result = complexType.Configure(ct => 
        {
            ct.SetProperty("configured", true);
        });

        // Assert
        Assert.Same(complexType, result);
        Assert.True(complexType.GetProperty<bool>("configured"));
    }

    [Fact]
    public void ComplexType_SetAndGetProperty_ShouldWork()
    {
        // Arrange
        var complexType = new ComplexType();

        // Act
        complexType.SetProperty("string", "test");
        complexType.SetProperty("number", 42);
        complexType.SetProperty("boolean", true);

        // Assert
        Assert.Equal("test", complexType.GetProperty<string>("string"));
        Assert.Equal(42, complexType.GetProperty<int>("number"));
        Assert.True(complexType.GetProperty<bool>("boolean"));
        Assert.Null(complexType.GetProperty<string>("nonexistent"));
    }

    #endregion

    #region SimpleQuantity Tests

    [Fact]
    public void SimpleQuantity_Constructor_ShouldWork()
    {
        // Arrange & Act
        var quantity = new SimpleQuantity(10m, "kg");

        // Assert
        Assert.Equal(10m, quantity.Value?.Value);
        Assert.Equal("kg", quantity.Unit?.Value);
    }

    [Fact]
    public void SimpleQuantity_Validation_WithComparator_ShouldFail()
    {
        // Arrange
        var quantity = new SimpleQuantity
        {
            Value = new FhirDecimal(10m),
            Comparator = new FhirCode(">")
        };

        // Act
        var validationResults = quantity.Validate(new ValidationContext(quantity));

        // Assert
        Assert.NotEmpty(validationResults);
        Assert.Contains("cannot have a comparator", validationResults.First().ErrorMessage);
    }

    #endregion

    #region Age Tests

    [Fact]
    public void Age_Constructor_ShouldWork()
    {
        // Arrange & Act
        var age = new Age(25m, "a");

        // Assert
        Assert.Equal(25m, age.Value?.Value);
        Assert.Equal("a", age.Unit?.Value);
        Assert.Equal("http://unitsofmeasure.org", age.System?.Value);
    }

    [Fact]
    public void Age_StaticMethods_ShouldWork()
    {
        // Arrange & Act
        var years = Age.Years(30);
        var months = Age.Months(6);
        var days = Age.Days(15);

        // Assert
        Assert.Equal(30m, years.Value?.Value);
        Assert.Equal("a", years.Unit?.Value);

        Assert.Equal(6m, months.Value?.Value);
        Assert.Equal("mo", months.Unit?.Value);

        Assert.Equal(15m, days.Value?.Value);
        Assert.Equal("d", days.Unit?.Value);
    }

    [Fact]
    public void Age_Validation_NegativeValue_ShouldFail()
    {
        // Arrange
        var age = new Age(-5m, "a");

        // Act
        var validationResults = age.Validate(new ValidationContext(age));

        // Assert
        Assert.NotEmpty(validationResults);
        Assert.Contains("cannot be negative", validationResults.First().ErrorMessage);
    }

    #endregion

    #region SampledData Tests

    [Fact]
    public void SampledData_Constructor_ShouldWork()
    {
        // Arrange & Act
        var origin = new SimpleQuantity(0m, "mV");
        var sampledData = new SampledData
        {
            Origin = origin,
            Period = new FhirDecimal(1000m), // 1 second
            Dimensions = new FhirPositiveInt(1),
            Data = new FhirString("1.0 2.0 3.0 4.0 5.0")
        };

        // Assert
        Assert.Equal(origin, sampledData.Origin);
        Assert.Equal(1000m, sampledData.Period?.Value);
        Assert.Equal(1, sampledData.Dimensions?.Value);
        Assert.Equal("1.0 2.0 3.0 4.0 5.0", sampledData.Data?.Value);
    }

    [Fact]
    public void SampledData_GetDataPoints_ShouldWork()
    {
        // Arrange
        var sampledData = new SampledData
        {
            Origin = new SimpleQuantity(0m, "mV"),
            Period = new FhirDecimal(1000m),
            Dimensions = new FhirPositiveInt(1),
            Data = new FhirString("1.0 2.0 E L U")
        };

        // Act
        var dataPoints = sampledData.GetDataPoints();
        var numericPoints = sampledData.GetNumericDataPoints();

        // Assert
        Assert.Equal(5, dataPoints.Length);
        Assert.Equal(new[] { "1.0", "2.0", "E", "L", "U" }, dataPoints);

        Assert.Equal(5, numericPoints.Length);
        Assert.Equal(1.0m, numericPoints[0]);
        Assert.Equal(2.0m, numericPoints[1]);
        Assert.Null(numericPoints[2]); // E
        Assert.Null(numericPoints[3]); // L
        Assert.Null(numericPoints[4]); // U
    }

    #endregion
}
