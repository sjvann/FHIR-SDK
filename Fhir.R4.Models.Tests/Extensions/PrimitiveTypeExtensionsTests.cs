using Fhir.R4.Models.DataTypes;
using Fhir.R4.Models.Extensions;
using Xunit;

namespace Fhir.R4.Models.Tests.Extensions;

/// <summary>
/// Tests for PrimitiveTypeExtensions.
/// </summary>
public class PrimitiveTypeExtensionsTests
{
    #region String Extensions Tests

    [Fact]
    public void ToFhirString_WithValidString_ShouldCreateFhirString()
    {
        // Arrange
        var value = "Hello World";

        // Act
        var result = value.ToFhirString();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void ToFhirString_WithNull_ShouldReturnNull()
    {
        // Arrange
        string? value = null;

        // Act
        var result = value.ToFhirString();

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void ToFhirCode_WithValidCode_ShouldCreateFhirCode()
    {
        // Arrange
        var value = "active";

        // Act
        var result = value.ToFhirCode();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void ToFhirUri_WithValidUri_ShouldCreateFhirUri()
    {
        // Arrange
        var value = "http://example.com";

        // Act
        var result = value.ToFhirUri();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void ToFhirDate_WithValidDate_ShouldCreateFhirDate()
    {
        // Arrange
        var value = "2023-12-25";

        // Act
        var result = value.ToFhirDate();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(value, result.Value);
    }

    #endregion

    #region Numeric Extensions Tests

    [Fact]
    public void ToFhirInteger_WithValidInteger_ShouldCreateFhirInteger()
    {
        // Arrange
        var value = 42;

        // Act
        var result = value.ToFhirInteger();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void ToFhirInteger_WithNull_ShouldReturnNull()
    {
        // Arrange
        int? value = null;

        // Act
        var result = value.ToFhirInteger();

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void ToFhirPositiveInt_WithValidPositiveInteger_ShouldCreateFhirPositiveInt()
    {
        // Arrange
        var value = 10;

        // Act
        var result = value.ToFhirPositiveInt();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void ToFhirDecimal_WithValidDecimal_ShouldCreateFhirDecimal()
    {
        // Arrange
        var value = 123.45m;

        // Act
        var result = value.ToFhirDecimal();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(value, result.Value);
    }

    #endregion

    #region Boolean Extensions Tests

    [Fact]
    public void ToFhirBoolean_WithTrue_ShouldCreateFhirBooleanTrue()
    {
        // Arrange
        var value = true;

        // Act
        var result = value.ToFhirBoolean();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void ToFhirBoolean_WithFalse_ShouldCreateFhirBooleanFalse()
    {
        // Arrange
        var value = false;

        // Act
        var result = value.ToFhirBoolean();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void ToFhirBoolean_WithNull_ShouldReturnNull()
    {
        // Arrange
        bool? value = null;

        // Act
        var result = value.ToFhirBoolean();

        // Assert
        Assert.Null(result);
    }

    #endregion

    #region Binary Extensions Tests

    [Fact]
    public void ToFhirBase64Binary_WithValidBytes_ShouldCreateFhirBase64Binary()
    {
        // Arrange
        var bytes = new byte[] { 1, 2, 3, 4, 5 };
        var expectedBase64 = Convert.ToBase64String(bytes);

        // Act
        var result = bytes.ToFhirBase64Binary();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedBase64, result.Value);
        
        // Test round-trip conversion
        var roundTripBytes = result.ToByteArray();
        Assert.Equal(bytes, roundTripBytes);
    }

    [Fact]
    public void ToFhirBase64Binary_WithNull_ShouldReturnNull()
    {
        // Arrange
        byte[]? bytes = null;

        // Act
        var result = bytes.ToFhirBase64Binary();

        // Assert
        Assert.Null(result);
    }

    #endregion

    #region DateTime Extensions Tests

    [Fact]
    public void ToFhirTime_WithValidTimeSpan_ShouldCreateFhirTime()
    {
        // Arrange
        var timeSpan = new TimeSpan(14, 30, 45); // 14:30:45

        // Act
        var result = timeSpan.ToFhirTime();

        // Assert
        Assert.NotNull(result);
        Assert.Equal("14:30:45", result.Value);
        
        // Test round-trip conversion
        var roundTripTimeSpan = result.ToTimeSpan();
        Assert.Equal(timeSpan, roundTripTimeSpan);
    }

    [Fact]
    public void ToFhirTime_WithNull_ShouldReturnNull()
    {
        // Arrange
        TimeSpan? timeSpan = null;

        // Act
        var result = timeSpan.ToFhirTime();

        // Assert
        Assert.Null(result);
    }

    #endregion

    #region Guid Extensions Tests

    [Fact]
    public void ToFhirUuid_WithValidGuid_ShouldCreateFhirUuid()
    {
        // Arrange
        var guid = Guid.NewGuid();
        var expectedUuid = $"urn:uuid:{guid}";

        // Act
        var result = guid.ToFhirUuid();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedUuid, result.Value);
        
        // Test round-trip conversion
        var roundTripGuid = result.ToGuid();
        Assert.Equal(guid, roundTripGuid);
    }

    [Fact]
    public void ToFhirUuid_WithNull_ShouldReturnNull()
    {
        // Arrange
        Guid? guid = null;

        // Act
        var result = guid.ToFhirUuid();

        // Assert
        Assert.Null(result);
    }

    #endregion

    #region Fluent API Tests

    [Fact]
    public void FluentAPI_ShouldWorkSeamlessly()
    {
        // Arrange & Act - Demonstrate fluent API usage
        var name = "John Doe".ToFhirString();
        var age = 30.ToFhirInteger();
        var isActive = true.ToFhirBoolean();
        var birthDate = "1993-01-01".ToFhirDate();
        var website = "https://example.com".ToFhirUrl();
        var id = Guid.NewGuid().ToFhirUuid();
        var data = new byte[] { 1, 2, 3 }.ToFhirBase64Binary();
        var time = TimeSpan.FromHours(9).ToFhirTime();

        // Assert
        Assert.NotNull(name);
        Assert.NotNull(age);
        Assert.NotNull(isActive);
        Assert.NotNull(birthDate);
        Assert.NotNull(website);
        Assert.NotNull(id);
        Assert.NotNull(data);
        Assert.NotNull(time);

        Assert.Equal("John Doe", name.Value);
        Assert.Equal(30, age.Value);
        Assert.True(isActive.Value);
        Assert.Equal("1993-01-01", birthDate.Value);
        Assert.Equal("https://example.com", website.Value);
        Assert.Contains("urn:uuid:", id.Value);
        Assert.Equal("AQID", data.Value); // Base64 for [1,2,3]
        Assert.Equal("09:00:00", time.Value);
    }

    #endregion
}
