using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR uri primitive type.
/// A Uniform Resource Identifier Reference.
/// </summary>
/// <remarks>
/// FHIR R5 uri PrimitiveType
/// A Uniform Resource Identifier Reference.
/// 
/// JSON Representation:
/// - Simple: "url" : "http://example.com/resource"
/// - Full: "url" : "http://example.com/resource", "_url" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirUri : UnifiedPrimitiveTypeBase<string>
{
    /// <summary>
    /// Gets or sets the uri value.
    /// </summary>
    [JsonIgnore]
    public string? UriValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirUri class.
    /// </summary>
    public FhirUri() { }

    /// <summary>
    /// Initializes a new instance of the FhirUri class with the specified value.
    /// </summary>
    /// <param name="value">The uri value.</param>
    public FhirUri(string? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a string to a FhirUri.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirUri instance, or null if the value is null.</returns>
    public static implicit operator FhirUri?(string? value)
    {
        return CreateFromString<FhirUri>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirUri to a string.
    /// </summary>
    /// <param name="fhirUri">The FhirUri to convert.</param>
    /// <returns>The string value, or null if the FhirUri is null.</returns>
    public static implicit operator string?(FhirUri? fhirUri)
    {
        return GetStringValue<FhirUri>(fhirUri);
    }

    /// <summary>
    /// Parses a uri value from string.
    /// </summary>
    /// <param name="value">The string to parse.</param>
    /// <returns>The parsed uri value.</returns>
    protected override string? ParseValueFromString(string value)
    {
        return value;
    }

    /// <summary>
    /// Converts a uri value to string.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The string representation.</returns>
    protected override string? ValueToString(string? value)
    {
        return value;
    }

    /// <summary>
    /// Validates the uri value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The uri value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateValue(string value)
    {
        // 使用 ValidationFramework 中的 FHIR 特定驗證規則
        return ValidationFramework.ValidateFhirUri(value);
    }
}
