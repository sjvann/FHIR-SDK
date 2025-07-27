using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Xunit;

namespace Fhir.TypeFramework.Tests.PrimitiveTypes;

/// <summary>
/// Tests for FHIR Primitive Types
/// </summary>
public class PrimitiveTypeTests
{
    #region Basic Primitive Type Tests

    [Fact]
    public void FhirString_WithValidValue_ShouldWork()
    {
        // Arrange & Act
        var fhirString = new FhirString("Hello World");

        // Assert
        Assert.Equal("Hello World", fhirString.Value);
        Assert.Equal("Hello World", fhirString.ToString());
        Assert.False(fhirString.IsNull);
    }

    [Fact]
    public void FhirString_WithNullValue_ShouldWork()
    {
        // Arrange & Act
        var fhirString = new FhirString(null);

        // Assert
        Assert.Null(fhirString.Value);
        Assert.Null(fhirString.ToString());
        Assert.True(fhirString.IsNull);
    }

    [Fact]
    public void FhirInteger_WithValidValue_ShouldWork()
    {
        // Arrange & Act
        var fhirInteger = new FhirInteger(42);

        // Assert
        Assert.Equal(42, fhirInteger.Value);
        Assert.Equal("42", fhirInteger.ToString());
        Assert.False(fhirInteger.IsNull);
    }

    [Fact]
    public void FhirBoolean_WithValidValue_ShouldWork()
    {
        // Arrange & Act
        var fhirBoolean = new FhirBoolean(true);

        // Assert
        Assert.True(fhirBoolean.Value);
        Assert.Equal("true", fhirBoolean.ToString());
        Assert.False(fhirBoolean.IsNull);
    }

    [Fact]
    public void FhirDecimal_WithValidValue_ShouldWork()
    {
        // Arrange & Act
        var fhirDecimal = new FhirDecimal(123.45m);

        // Assert
        Assert.Equal(123.45m, fhirDecimal.Value);
        Assert.Equal("123.45", fhirDecimal.ToString());
        Assert.False(fhirDecimal.IsNull);
    }

    [Fact]
    public void FhirDateTime_WithValidValue_ShouldWork()
    {
        // Arrange
        var dateTime = new DateTime(2023, 12, 25, 10, 30, 0, DateTimeKind.Utc);

        // Act
        var fhirDateTime = new FhirDateTime(dateTime);

        // Assert
        Assert.Equal(dateTime, fhirDateTime.Value);
        Assert.Equal("2023-12-25T10:30:00.000Z", fhirDateTime.ToString());
        Assert.False(fhirDateTime.IsNull);
    }

    [Fact]
    public void FhirUri_WithValidValue_ShouldWork()
    {
        // Arrange & Act
        var fhirUri = new FhirUri("http://example.com/resource");

        // Assert
        Assert.Equal("http://example.com/resource", fhirUri.Value);
        Assert.Equal("http://example.com/resource", fhirUri.ToString());
        Assert.False(fhirUri.IsNull);
    }

    #endregion

    #region Implicit Conversion Tests

    [Fact]
    public void FhirString_ImplicitConversion_FromString_ShouldWork()
    {
        // Arrange & Act
        FhirString fhirString = "Implicit Conversion";

        // Assert
        Assert.Equal("Implicit Conversion", fhirString.Value);
    }

    [Fact]
    public void FhirString_ImplicitConversion_ToString_ShouldWork()
    {
        // Arrange
        var fhirString = new FhirString("Test Value");

        // Act
        string? value = fhirString;

        // Assert
        Assert.Equal("Test Value", value);
    }

    [Fact]
    public void FhirInteger_ImplicitConversion_FromInt_ShouldWork()
    {
        // Arrange & Act
        FhirInteger fhirInteger = 100;

        // Assert
        Assert.Equal(100, fhirInteger.Value);
    }

    [Fact]
    public void FhirInteger_ImplicitConversion_ToInt_ShouldWork()
    {
        // Arrange
        var fhirInteger = new FhirInteger(200);

        // Act
        int value = fhirInteger;

        // Assert
        Assert.Equal(200, value);
    }

    [Fact]
    public void FhirBoolean_ImplicitConversion_FromBool_ShouldWork()
    {
        // Arrange & Act
        FhirBoolean fhirBoolean = true;

        // Assert
        Assert.True(fhirBoolean.Value);
    }

    [Fact]
    public void FhirBoolean_ImplicitConversion_ToBool_ShouldWork()
    {
        // Arrange
        var fhirBoolean = new FhirBoolean(false);

        // Act
        bool value = fhirBoolean;

        // Assert
        Assert.False(value);
    }

    [Fact]
    public void FhirDecimal_ImplicitConversion_FromDecimal_ShouldWork()
    {
        // Arrange & Act
        FhirDecimal fhirDecimal = 456.78m;

        // Assert
        Assert.Equal(456.78m, fhirDecimal.Value);
    }

    [Fact]
    public void FhirDecimal_ImplicitConversion_ToDecimal_ShouldWork()
    {
        // Arrange
        var fhirDecimal = new FhirDecimal(789.12m);

        // Act
        decimal value = fhirDecimal;

        // Assert
        Assert.Equal(789.12m, value);
    }

    #endregion

    #region Validation Tests

    [Fact]
    public void FhirString_WithValidValue_ShouldPassValidation()
    {
        // Arrange
        var fhirString = new FhirString("Valid String");

        // Act
        var validationResults = fhirString.Validate(new ValidationContext(fhirString));

        // Assert
        Assert.Empty(validationResults);
    }

    [Fact]
    public void FhirString_WithLargeValue_ShouldFailValidation()
    {
        // Arrange
        var largeString = new string('A', 1024 * 1024 + 1); // 超過 1MB
        var fhirString = new FhirString(largeString);

        // Act
        var validationResults = fhirString.Validate(new ValidationContext(fhirString));

        // Assert
        Assert.NotEmpty(validationResults);
        Assert.Contains("cannot exceed 1MB", validationResults.First().ErrorMessage);
    }

    [Fact]
    public void FhirUri_WithValidUri_ShouldPassValidation()
    {
        // Arrange
        var fhirUri = new FhirUri("http://example.com/resource");

        // Act
        var validationResults = fhirUri.Validate(new ValidationContext(fhirUri));

        // Assert
        Assert.Empty(validationResults);
    }

    [Fact]
    public void FhirUri_WithInvalidUri_ShouldFailValidation()
    {
        // Arrange
        var fhirUri = new FhirUri("not-a-valid-uri");

        // Act
        var validationResults = fhirUri.Validate(new ValidationContext(fhirUri));

        // Assert
        Assert.NotEmpty(validationResults);
        Assert.Contains("not a valid URI format", validationResults.First().ErrorMessage);
    }

    #endregion

    #region JSON Serialization Tests

    [Fact]
    public void FhirString_ToJsonValue_ShouldWork()
    {
        // Arrange
        var fhirString = new FhirString("Test JSON");

        // Act
        var jsonValue = fhirString.ToJsonValue();

        // Assert
        Assert.NotNull(jsonValue);
        Assert.Equal("\"Test JSON\"", jsonValue.ToString());
    }

    [Fact]
    public void FhirInteger_ToJsonValue_ShouldWork()
    {
        // Arrange
        var fhirInteger = new FhirInteger(42);

        // Act
        var jsonValue = fhirInteger.ToJsonValue();

        // Assert
        Assert.NotNull(jsonValue);
        Assert.Equal("42", jsonValue.ToString());
    }

    [Fact]
    public void FhirBoolean_ToJsonValue_ShouldWork()
    {
        // Arrange
        var fhirBoolean = new FhirBoolean(true);

        // Act
        var jsonValue = fhirBoolean.ToJsonValue();

        // Assert
        Assert.NotNull(jsonValue);
        Assert.Equal("true", jsonValue.ToString());
    }

    [Fact]
    public void FhirString_FromJsonValue_ShouldWork()
    {
        // Arrange
        var jsonValue = JsonValue.Create("Test From JSON");
        var fhirString = new FhirString();

        // Act
        fhirString.FromJsonValue(jsonValue);

        // Assert
        Assert.Equal("Test From JSON", fhirString.Value);
    }

    [Fact]
    public void FhirInteger_FromJsonValue_ShouldWork()
    {
        // Arrange
        var jsonValue = JsonValue.Create(123);
        var fhirInteger = new FhirInteger();

        // Act
        fhirInteger.FromJsonValue(jsonValue);

        // Assert
        Assert.Equal(123, fhirInteger.Value);
    }

    #endregion

    #region Full JSON Object Tests

    [Fact]
    public void FhirString_ToFullJsonObject_ShouldWork()
    {
        // Arrange
        var fhirString = new FhirString("Test Full JSON");
        fhirString.Id = "test-id";
        fhirString.AddExtension("http://example.com/extension", "extension-value");

        // Act
        var jsonObject = fhirString.ToFullJsonObject();

        // Assert
        Assert.NotNull(jsonObject);
        Assert.True(jsonObject.ContainsKey("value"));
        Assert.True(jsonObject.ContainsKey("id"));
        Assert.True(jsonObject.ContainsKey("extension"));
        Assert.Equal("\"Test Full JSON\"", jsonObject["value"]?.ToString());
        Assert.Equal("test-id", jsonObject["id"]?.ToString());
    }

    [Fact]
    public void FhirString_FromFullJsonObject_ShouldWork()
    {
        // Arrange
        var jsonObject = new JsonObject
        {
            ["value"] = JsonValue.Create("Test From Full JSON"),
            ["id"] = JsonValue.Create("test-id"),
            ["extension"] = new JsonArray
            {
                new JsonObject
                {
                    ["url"] = JsonValue.Create("http://example.com/extension"),
                    ["value"] = JsonValue.Create("extension-value")
                }
            }
        };
        var fhirString = new FhirString();

        // Act
        fhirString.FromFullJsonObject(jsonObject);

        // Assert
        Assert.Equal("Test From Full JSON", fhirString.Value);
        Assert.Equal("test-id", fhirString.Id);
        Assert.NotNull(fhirString.Extension);
        Assert.Single(fhirString.Extension);
    }

    #endregion

    #region FhirJsonSerializer Tests

    [Fact]
    public void FhirJsonSerializer_SerializeSimple_ShouldWork()
    {
        // Arrange
        var serializer = new FhirJsonSerializer();
        var fhirString = new FhirString("Test Serialization");

        // Act
        var json = serializer.SerializeSimple(fhirString);

        // Assert
        Assert.Equal("\"Test Serialization\"", json);
    }

    [Fact]
    public void FhirJsonSerializer_SerializeFull_ShouldWork()
    {
        // Arrange
        var serializer = new FhirJsonSerializer();
        var fhirString = new FhirString("Test Full Serialization");
        fhirString.Id = "test-id";

        // Act
        var json = serializer.SerializeFull(fhirString);

        // Assert
        Assert.Contains("\"value\"", json);
        Assert.Contains("\"id\"", json);
        Assert.Contains("Test Full Serialization", json);
        Assert.Contains("test-id", json);
    }

    [Fact]
    public void FhirJsonSerializer_SerializeFhirFormat_ShouldWork()
    {
        // Arrange
        var serializer = new FhirJsonSerializer();
        var fhirString = new FhirString("Test FHIR Format");
        fhirString.Id = "test-id";

        // Act
        var json = serializer.SerializeFhirFormat("name", fhirString);

        // Assert
        Assert.Contains("\"name\"", json);
        Assert.Contains("\"_name\"", json);
        Assert.Contains("Test FHIR Format", json);
        Assert.Contains("test-id", json);
    }

    [Fact]
    public void FhirJsonSerializer_DeserializeSimple_ShouldWork()
    {
        // Arrange
        var serializer = new FhirJsonSerializer();
        var json = "\"Test Deserialization\"";

        // Act
        var fhirString = serializer.DeserializeSimple<FhirString>(json);

        // Assert
        Assert.NotNull(fhirString);
        Assert.Equal("Test Deserialization", fhirString.Value);
    }

    [Fact]
    public void FhirJsonSerializer_DeserializeFull_ShouldWork()
    {
        // Arrange
        var serializer = new FhirJsonSerializer();
        var json = "{\"value\":\"Test Full Deserialization\",\"id\":\"test-id\"}";

        // Act
        var fhirString = serializer.DeserializeFull<FhirString>(json);

        // Assert
        Assert.NotNull(fhirString);
        Assert.Equal("Test Full Deserialization", fhirString.Value);
        Assert.Equal("test-id", fhirString.Id);
    }

    #endregion

    #region Extension Tests

    [Fact]
    public void FhirString_AddExtension_ShouldWork()
    {
        // Arrange
        var fhirString = new FhirString("Test Extension");

        // Act
        fhirString.AddExtension("http://example.com/extension", "extension-value");

        // Assert
        Assert.NotNull(fhirString.Extension);
        Assert.Single(fhirString.Extension);
        Assert.Equal("http://example.com/extension", fhirString.Extension[0].Url);
    }

    [Fact]
    public void FhirString_GetExtension_ShouldWork()
    {
        // Arrange
        var fhirString = new FhirString("Test Get Extension");
        fhirString.AddExtension("http://example.com/extension", "extension-value");

        // Act
        var extension = fhirString.GetExtension("http://example.com/extension");

        // Assert
        Assert.NotNull(extension);
        Assert.Equal("http://example.com/extension", extension.Url);
    }

    [Fact]
    public void FhirString_RemoveExtension_ShouldWork()
    {
        // Arrange
        var fhirString = new FhirString("Test Remove Extension");
        fhirString.AddExtension("http://example.com/extension", "extension-value");

        // Act
        var removed = fhirString.RemoveExtension("http://example.com/extension");

        // Assert
        Assert.True(removed);
        Assert.Null(fhirString.Extension);
    }

    #endregion

    #region Deep Copy Tests

    [Fact]
    public void FhirString_DeepCopy_ShouldWork()
    {
        // Arrange
        var original = new FhirString("Original Value");
        original.Id = "original-id";
        original.AddExtension("http://example.com/extension", "extension-value");

        // Act
        var copy = (FhirString)original.DeepCopy();

        // Assert
        Assert.Equal(original.Value, copy.Value);
        Assert.Equal(original.Id, copy.Id);
        Assert.NotNull(copy.Extension);
        Assert.Single(copy.Extension);
        Assert.NotSame(original, copy);
    }

    #endregion

    #region Equality Tests

    [Fact]
    public void FhirString_IsExactly_ShouldWork()
    {
        // Arrange
        var fhirString1 = new FhirString("Same Value");
        var fhirString2 = new FhirString("Same Value");
        var fhirString3 = new FhirString("Different Value");

        // Act & Assert
        Assert.True(fhirString1.IsExactly(fhirString2));
        Assert.False(fhirString1.IsExactly(fhirString3));
    }

    #endregion
} 