using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR canonical primitive type.
/// A URI that is a reference to a canonical URL on a FHIR resource.
/// </summary>
/// <remarks>
/// FHIR R4 canonical PrimitiveType
/// A URI that is a reference to a canonical URL on a FHIR resource.
/// </remarks>
public class FhirCanonical : Element
{
    private string? _value;

    /// <summary>
    /// The actual canonical value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirCanonical class.
    /// </summary>
    public FhirCanonical() { }

    /// <summary>
    /// Initializes a new instance of the FhirCanonical class with the specified value.
    /// </summary>
    /// <param name="value">The canonical value.</param>
    public FhirCanonical(string? value)
    {
        Value = value;
    }

    /// <summary>
    /// Implicitly converts a string to a FhirCanonical.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirCanonical instance, or null if the value is null.</returns>
    public static implicit operator FhirCanonical?(string? value)
    {
        return value == null ? null : new FhirCanonical(value);
    }

    /// <summary>
    /// Implicitly converts a FhirCanonical to a string.
    /// </summary>
    /// <param name="fhirCanonical">The FhirCanonical to convert.</param>
    /// <returns>The string value, or null if the FhirCanonical is null.</returns>
    public static implicit operator string?(FhirCanonical? fhirCanonical)
    {
        return fhirCanonical?.Value;
    }

    /// <summary>
    /// Validates the FhirCanonical according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        if (!string.IsNullOrEmpty(Value))
        {
            // Canonical must be a valid URI
            if (!Uri.IsWellFormedUriString(Value, UriKind.RelativeOrAbsolute))
            {
                yield return new ValidationResult($"Canonical value '{Value}' is not a well-formed URI");
            }
        }
    }

    /// <summary>
    /// Returns a string representation of the FhirCanonical.
    /// </summary>
    /// <returns>The canonical value.</returns>
    public override string? ToString() => Value;
}
