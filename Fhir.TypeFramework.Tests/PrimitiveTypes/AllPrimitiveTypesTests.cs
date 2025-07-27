using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.Serialization;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Fhir.TypeFramework.Tests.PrimitiveTypes;

/// <summary>
/// Tests for all FHIR Primitive Types
/// </summary>
public class AllPrimitiveTypesTests
{
    #region All Primitive Types Creation Tests

    [Fact]
    public void AllPrimitiveTypes_ShouldBeCreatedSuccessfully()
    {
        // Arrange & Act
        var fhirString = new FhirString("Test String");
        var fhirInteger = new FhirInteger(42);
        var fhirBoolean = new FhirBoolean(true);
        var fhirDecimal = new FhirDecimal(123.45m);
        var fhirDateTime = new FhirDateTime(DateTime.UtcNow);
        var fhirUri = new FhirUri("http://example.com");

        // Assert
        Assert.NotNull(fhirString);
        Assert.NotNull(fhirInteger);
        Assert.NotNull(fhirBoolean);
        Assert.NotNull(fhirDecimal);
        Assert.NotNull(fhirDateTime);
        Assert.NotNull(fhirUri);
    }

    [Fact]
    public void AllPrimitiveTypes_ShouldHaveCorrectTypeNames()
    {
        // Arrange & Act
        var fhirString = new FhirString("Test");
        var fhirInteger = new FhirInteger(42);
        var fhirBoolean = new FhirBoolean(true);
        var fhirDecimal = new FhirDecimal(123.45m);
        var fhirDateTime = new FhirDateTime(DateTime.UtcNow);
        var fhirUri = new FhirUri("http://example.com");

        // Assert
        Assert.Equal("String", fhirString.TypeName);
        Assert.Equal("Int32", fhirInteger.TypeName);
        Assert.Equal("Boolean", fhirBoolean.TypeName);
        Assert.Equal("Decimal", fhirDecimal.TypeName);
        Assert.Equal("DateTime", fhirDateTime.TypeName);
        Assert.Equal("String", fhirUri.TypeName);
    }

    #endregion

    #region All Primitive Types Implicit Conversion Tests

    [Fact]
    public void AllPrimitiveTypes_ImplicitConversions_ShouldWork()
    {
        // Arrange & Act
        FhirString fhirString = "Test String";
        FhirInteger fhirInteger = 100;
        FhirBoolean fhirBoolean = true;
        FhirDecimal fhirDecimal = 456.78m;
        FhirDateTime fhirDateTime = DateTime.UtcNow;
        FhirUri fhirUri = "http://example.com";

        // Assert
        Assert.Equal("Test String", fhirString.Value);
        Assert.Equal(100, fhirInteger.Value);
        Assert.True(fhirBoolean.Value);
        Assert.Equal(456.78m, fhirDecimal.Value);
        Assert.NotNull(fhirDateTime.Value);
        Assert.Equal("http://example.com", fhirUri.Value);
    }

    [Fact]
    public void AllPrimitiveTypes_ReverseImplicitConversions_ShouldWork()
    {
        // Arrange
        var fhirString = new FhirString("Test String");
        var fhirInteger = new FhirInteger(100);
        var fhirBoolean = new FhirBoolean(true);
        var fhirDecimal = new FhirDecimal(456.78m);
        var fhirDateTime = new FhirDateTime(DateTime.UtcNow);
        var fhirUri = new FhirUri("http://example.com");

        // Act
        string stringValue = fhirString;
        int intValue = fhirInteger;
        bool boolValue = fhirBoolean;
        decimal decimalValue = fhirDecimal;
        DateTime dateTimeValue = fhirDateTime;
        string uriValue = fhirUri;

        // Assert
        Assert.Equal("Test String", stringValue);
        Assert.Equal(100, intValue);
        Assert.True(boolValue);
        Assert.Equal(456.78m, decimalValue);
        Assert.NotNull(dateTimeValue);
        Assert.Equal("http://example.com", uriValue);
    }

    #endregion

    #region All Primitive Types Validation Tests

    [Fact]
    public void AllPrimitiveTypes_WithValidValues_ShouldPassValidation()
    {
        // Arrange
        var fhirString = new FhirString("Valid String");
        var fhirInteger = new FhirInteger(42);
        var fhirBoolean = new FhirBoolean(true);
        var fhirDecimal = new FhirDecimal(123.45m);
        var fhirDateTime = new FhirDateTime(DateTime.UtcNow);
        var fhirUri = new FhirUri("http://example.com");

        // Act & Assert
        Assert.Empty(fhirString.Validate(new ValidationContext(fhirString)));
        Assert.Empty(fhirInteger.Validate(new ValidationContext(fhirInteger)));
        Assert.Empty(fhirBoolean.Validate(new ValidationContext(fhirBoolean)));
        Assert.Empty(fhirDecimal.Validate(new ValidationContext(fhirDecimal)));
        Assert.Empty(fhirDateTime.Validate(new ValidationContext(fhirDateTime)));
        Assert.Empty(fhirUri.Validate(new ValidationContext(fhirUri)));
    }

    [Fact]
    public void AllPrimitiveTypes_WithNullValues_ShouldPassValidation()
    {
        // Arrange
        var fhirString = new FhirString(null);
        var fhirInteger = new FhirInteger();
        var fhirBoolean = new FhirBoolean();
        var fhirDecimal = new FhirDecimal();
        var fhirDateTime = new FhirDateTime();
        var fhirUri = new FhirUri(null);

        // Act & Assert
        Assert.Empty(fhirString.Validate(new ValidationContext(fhirString)));
        Assert.Empty(fhirInteger.Validate(new ValidationContext(fhirInteger)));
        Assert.Empty(fhirBoolean.Validate(new ValidationContext(fhirBoolean)));
        Assert.Empty(fhirDecimal.Validate(new ValidationContext(fhirDecimal)));
        Assert.Empty(fhirDateTime.Validate(new ValidationContext(fhirDateTime)));
        Assert.Empty(fhirUri.Validate(new ValidationContext(fhirUri)));
    }

    #endregion

    #region All Primitive Types JSON Serialization Tests

    [Fact]
    public void AllPrimitiveTypes_ToJsonValue_ShouldWork()
    {
        // Arrange
        var fhirString = new FhirString("Test JSON");
        var fhirInteger = new FhirInteger(42);
        var fhirBoolean = new FhirBoolean(true);
        var fhirDecimal = new FhirDecimal(123.45m);
        var fhirDateTime = new FhirDateTime(new DateTime(2023, 12, 25, 10, 30, 0, DateTimeKind.Utc));
        var fhirUri = new FhirUri("http://example.com");

        // Act
        var stringJson = fhirString.ToJsonValue();
        var integerJson = fhirInteger.ToJsonValue();
        var booleanJson = fhirBoolean.ToJsonValue();
        var decimalJson = fhirDecimal.ToJsonValue();
        var dateTimeJson = fhirDateTime.ToJsonValue();
        var uriJson = fhirUri.ToJsonValue();

        // Assert
        Assert.NotNull(stringJson);
        Assert.NotNull(integerJson);
        Assert.NotNull(booleanJson);
        Assert.NotNull(decimalJson);
        Assert.NotNull(dateTimeJson);
        Assert.NotNull(uriJson);
    }

    [Fact]
    public void AllPrimitiveTypes_FromJsonValue_ShouldWork()
    {
        // Arrange
        var fhirString = new FhirString();
        var fhirInteger = new FhirInteger();
        var fhirBoolean = new FhirBoolean();
        var fhirDecimal = new FhirDecimal();
        var fhirDateTime = new FhirDateTime();
        var fhirUri = new FhirUri();

        // Act
        fhirString.FromJsonValue(System.Text.Json.JsonValue.Create("Test From JSON"));
        fhirInteger.FromJsonValue(System.Text.Json.JsonValue.Create(123));
        fhirBoolean.FromJsonValue(System.Text.Json.JsonValue.Create(true));
        fhirDecimal.FromJsonValue(System.Text.Json.JsonValue.Create(456.78m));
        fhirDateTime.FromJsonValue(System.Text.Json.JsonValue.Create("2023-12-25T10:30:00Z"));
        fhirUri.FromJsonValue(System.Text.Json.JsonValue.Create("http://example.com"));

        // Assert
        Assert.Equal("Test From JSON", fhirString.Value);
        Assert.Equal(123, fhirInteger.Value);
        Assert.True(fhirBoolean.Value);
        Assert.Equal(456.78m, fhirDecimal.Value);
        Assert.NotNull(fhirDateTime.Value);
        Assert.Equal("http://example.com", fhirUri.Value);
    }

    #endregion

    #region All Primitive Types Extension Tests

    [Fact]
    public void AllPrimitiveTypes_AddExtension_ShouldWork()
    {
        // Arrange
        var fhirString = new FhirString("Test");
        var fhirInteger = new FhirInteger(42);
        var fhirBoolean = new FhirBoolean(true);
        var fhirDecimal = new FhirDecimal(123.45m);
        var fhirDateTime = new FhirDateTime(DateTime.UtcNow);
        var fhirUri = new FhirUri("http://example.com");

        // Act
        fhirString.AddExtension("http://example.com/string-ext", "string-value");
        fhirInteger.AddExtension("http://example.com/int-ext", "int-value");
        fhirBoolean.AddExtension("http://example.com/bool-ext", "bool-value");
        fhirDecimal.AddExtension("http://example.com/decimal-ext", "decimal-value");
        fhirDateTime.AddExtension("http://example.com/datetime-ext", "datetime-value");
        fhirUri.AddExtension("http://example.com/uri-ext", "uri-value");

        // Assert
        Assert.NotNull(fhirString.Extension);
        Assert.NotNull(fhirInteger.Extension);
        Assert.NotNull(fhirBoolean.Extension);
        Assert.NotNull(fhirDecimal.Extension);
        Assert.NotNull(fhirDateTime.Extension);
        Assert.NotNull(fhirUri.Extension);
        Assert.Single(fhirString.Extension);
        Assert.Single(fhirInteger.Extension);
        Assert.Single(fhirBoolean.Extension);
        Assert.Single(fhirDecimal.Extension);
        Assert.Single(fhirDateTime.Extension);
        Assert.Single(fhirUri.Extension);
    }

    [Fact]
    public void AllPrimitiveTypes_GetExtension_ShouldWork()
    {
        // Arrange
        var fhirString = new FhirString("Test");
        fhirString.AddExtension("http://example.com/extension", "value");

        // Act
        var extension = fhirString.GetExtension("http://example.com/extension");

        // Assert
        Assert.NotNull(extension);
        Assert.Equal("http://example.com/extension", extension.Url);
    }

    #endregion

    #region All Primitive Types Deep Copy Tests

    [Fact]
    public void AllPrimitiveTypes_DeepCopy_ShouldWork()
    {
        // Arrange
        var originalString = new FhirString("Original");
        var originalInteger = new FhirInteger(42);
        var originalBoolean = new FhirBoolean(true);
        var originalDecimal = new FhirDecimal(123.45m);
        var originalDateTime = new FhirDateTime(DateTime.UtcNow);
        var originalUri = new FhirUri("http://example.com");

        // Act
        var copyString = (FhirString)originalString.DeepCopy();
        var copyInteger = (FhirInteger)originalInteger.DeepCopy();
        var copyBoolean = (FhirBoolean)originalBoolean.DeepCopy();
        var copyDecimal = (FhirDecimal)originalDecimal.DeepCopy();
        var copyDateTime = (FhirDateTime)originalDateTime.DeepCopy();
        var copyUri = (FhirUri)originalUri.DeepCopy();

        // Assert
        Assert.Equal(originalString.Value, copyString.Value);
        Assert.Equal(originalInteger.Value, copyInteger.Value);
        Assert.Equal(originalBoolean.Value, copyBoolean.Value);
        Assert.Equal(originalDecimal.Value, copyDecimal.Value);
        Assert.Equal(originalDateTime.Value, copyDateTime.Value);
        Assert.Equal(originalUri.Value, copyUri.Value);
        Assert.NotSame(originalString, copyString);
        Assert.NotSame(originalInteger, copyInteger);
        Assert.NotSame(originalBoolean, copyBoolean);
        Assert.NotSame(originalDecimal, copyDecimal);
        Assert.NotSame(originalDateTime, copyDateTime);
        Assert.NotSame(originalUri, copyUri);
    }

    #endregion

    #region All Primitive Types Equality Tests

    [Fact]
    public void AllPrimitiveTypes_IsExactly_ShouldWork()
    {
        // Arrange
        var fhirString1 = new FhirString("Same Value");
        var fhirString2 = new FhirString("Same Value");
        var fhirInteger1 = new FhirInteger(42);
        var fhirInteger2 = new FhirInteger(42);
        var fhirBoolean1 = new FhirBoolean(true);
        var fhirBoolean2 = new FhirBoolean(true);

        // Act & Assert
        Assert.True(fhirString1.IsExactly(fhirString2));
        Assert.True(fhirInteger1.IsExactly(fhirInteger2));
        Assert.True(fhirBoolean1.IsExactly(fhirBoolean2));
    }

    #endregion

    #region All Primitive Types FhirJsonSerializer Tests

    [Fact]
    public void AllPrimitiveTypes_FhirJsonSerializer_ShouldWork()
    {
        // Arrange
        var serializer = new FhirJsonSerializer();
        var fhirString = new FhirString("Test Serialization");
        var fhirInteger = new FhirInteger(42);
        var fhirBoolean = new FhirBoolean(true);

        // Act
        var stringJson = serializer.SerializeSimple(fhirString);
        var integerJson = serializer.SerializeSimple(fhirInteger);
        var booleanJson = serializer.SerializeSimple(fhirBoolean);

        // Assert
        Assert.NotNull(stringJson);
        Assert.NotNull(integerJson);
        Assert.NotNull(booleanJson);
        Assert.Contains("Test Serialization", stringJson);
        Assert.Contains("42", integerJson);
        Assert.Contains("true", booleanJson);
    }

    [Fact]
    public void AllPrimitiveTypes_FhirJsonSerializer_FullFormat_ShouldWork()
    {
        // Arrange
        var serializer = new FhirJsonSerializer();
        var fhirString = new FhirString("Test Full Format");
        fhirString.Id = "test-id";
        fhirString.AddExtension("http://example.com/extension", "extension-value");

        // Act
        var json = serializer.SerializeFhirFormat("name", fhirString);

        // Assert
        Assert.NotNull(json);
        Assert.Contains("\"name\"", json);
        Assert.Contains("\"_name\"", json);
        Assert.Contains("Test Full Format", json);
        Assert.Contains("test-id", json);
    }

    #endregion

    #region All Primitive Types Null Handling Tests

    [Fact]
    public void AllPrimitiveTypes_NullHandling_ShouldWork()
    {
        // Arrange & Act
        var fhirString = new FhirString(null);
        var fhirInteger = new FhirInteger();
        var fhirBoolean = new FhirBoolean();
        var fhirDecimal = new FhirDecimal();
        var fhirDateTime = new FhirDateTime();
        var fhirUri = new FhirUri(null);

        // Assert
        Assert.True(fhirString.IsNull);
        Assert.True(fhirInteger.IsNull);
        Assert.True(fhirBoolean.IsNull);
        Assert.True(fhirDecimal.IsNull);
        Assert.True(fhirDateTime.IsNull);
        Assert.True(fhirUri.IsNull);
    }

    #endregion

    #region All Primitive Types ToString Tests

    [Fact]
    public void AllPrimitiveTypes_ToString_ShouldWork()
    {
        // Arrange
        var fhirString = new FhirString("Test String");
        var fhirInteger = new FhirInteger(42);
        var fhirBoolean = new FhirBoolean(true);
        var fhirDecimal = new FhirDecimal(123.45m);
        var fhirDateTime = new FhirDateTime(new DateTime(2023, 12, 25, 10, 30, 0, DateTimeKind.Utc));
        var fhirUri = new FhirUri("http://example.com");

        // Act & Assert
        Assert.Equal("Test String", fhirString.ToString());
        Assert.Equal("42", fhirInteger.ToString());
        Assert.Equal("true", fhirBoolean.ToString());
        Assert.Equal("123.45", fhirDecimal.ToString());
        Assert.Equal("2023-12-25T10:30:00.000Z", fhirDateTime.ToString());
        Assert.Equal("http://example.com", fhirUri.ToString());
    }

    #endregion
} 