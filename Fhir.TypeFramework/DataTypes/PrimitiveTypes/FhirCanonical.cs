using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR canonical primitive type.
/// A URI that is a reference to a canonical resource.
/// </summary>
/// <remarks>
/// FHIR R5 canonical PrimitiveType
/// A URI that is a reference to a canonical resource.
/// </remarks>
public class FhirCanonical : UnifiedPrimitiveTypeBase<string>
{
    /// <summary>
    /// Gets or sets the canonical value.
    /// </summary>
    [JsonIgnore]
    public string? CanonicalValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirCanonical class.
    /// </summary>
    public FhirCanonical() { }

    /// <summary>
    /// Initializes a new instance of the FhirCanonical class with the specified value.
    /// </summary>
    /// <param name="value">The canonical value.</param>
    public FhirCanonical(string? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a string to a FhirCanonical.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirCanonical instance, or null if the value is null.</returns>
    public static implicit operator FhirCanonical?(string? value) => CreateFromString<FhirCanonical>(value);

    /// <summary>
    /// Implicitly converts a FhirCanonical to a string.
    /// </summary>
    /// <param name="fhirCanonical">The FhirCanonical to convert.</param>
    /// <returns>The string value, or null if the FhirCanonical is null.</returns>
    public static implicit operator string?(FhirCanonical? fhirCanonical) => GetStringValue<FhirCanonical>(fhirCanonical);

    /// <summary>
    /// Parses a string value into the primitive type.
    /// </summary>
    /// <param name="value">The string value to parse.</param>
    /// <returns>The parsed value, or null if the parsing fails.</returns>
    protected override string? ParseValueFromString(string value) => value;

    /// <summary>
    /// Converts the primitive type value to a string.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The string representation of the value, or null if the value is null.</returns>
    protected override string? ValueToString(string? value) => value;

    /// <summary>
    /// Validates the canonical value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The canonical value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateValue(string value) => ValidationFramework.ValidateCanonical(value);
}

