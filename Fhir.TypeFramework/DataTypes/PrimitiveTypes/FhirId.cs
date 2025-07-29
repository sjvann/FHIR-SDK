using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR id primitive type.
/// Any combination of letters, numerals, "-" and ".", with a length limit of 64 characters.
/// </summary>
/// <remarks>
/// FHIR R5 id PrimitiveType
/// Any combination of letters, numerals, "-" and ".", with a length limit of 64 characters.
/// 
/// JSON Representation:
/// - Simple: "id" : "example-id"
/// - Full: "id" : "example-id", "_id" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirId : UnifiedPrimitiveTypeBase<string>
{
    /// <summary>
    /// Gets or sets the id value.
    /// </summary>
    [JsonIgnore]
    public string? IdValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirId class.
    /// </summary>
    public FhirId() { }

    /// <summary>
    /// Initializes a new instance of the FhirId class with the specified value.
    /// </summary>
    /// <param name="value">The id value.</param>
    public FhirId(string? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a string to a FhirId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirId instance, or null if the value is null.</returns>
    public static implicit operator FhirId?(string? value)
    {
        return CreateFromString<FhirId>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirId to a string.
    /// </summary>
    /// <param name="fhirId">The FhirId to convert.</param>
    /// <returns>The string value, or null if the FhirId is null.</returns>
    public static implicit operator string?(FhirId? fhirId)
    {
        return GetStringValue<FhirId>(fhirId);
    }

    /// <summary>
    /// Parses an id value from string.
    /// </summary>
    /// <param name="value">The string to parse.</param>
    /// <returns>The parsed id value.</returns>
    protected override string? ParseValueFromString(string value)
    {
        return value;
    }

    /// <summary>
    /// Converts an id value to string.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The string representation.</returns>
    protected override string? ValueToString(string? value)
    {
        return value;
    }

    /// <summary>
    /// Validates the id value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The id value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateValue(string value)
    {
        // 使用 ValidationFramework 中的 FHIR 特定驗證規則
        return ValidationFramework.ValidateFhirId(value);
    }
}
