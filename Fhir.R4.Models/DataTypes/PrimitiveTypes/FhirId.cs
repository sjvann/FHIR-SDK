using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR id primitive type.
/// Any combination of letters, numerals, "-" and ".", with a length limit of 64 characters.
/// </summary>
/// <remarks>
/// FHIR R4 id PrimitiveType
/// Used for logical identifiers.
/// </remarks>
public class FhirId : Element
{
    private string? _value;

    /// <summary>
    /// The actual id value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirId class.
    /// </summary>
    public FhirId() { }

    /// <summary>
    /// Initializes a new instance of the FhirId class with the specified value.
    /// </summary>
    /// <param name="value">The id value.</param>
    public FhirId(string? value)
    {
        Value = value;
    }

    /// <summary>
    /// Implicitly converts a string to a FhirId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirId instance, or null if the value is null.</returns>
    public static implicit operator FhirId?(string? value)
    {
        return value == null ? null : new FhirId(value);
    }

    /// <summary>
    /// Implicitly converts a FhirId to a string.
    /// </summary>
    /// <param name="fhirId">The FhirId to convert.</param>
    /// <returns>The string value, or null if the FhirId is null.</returns>
    public static implicit operator string?(FhirId? fhirId)
    {
        return fhirId?.Value;
    }

    /// <summary>
    /// Validates the FhirId according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        if (!string.IsNullOrEmpty(Value))
        {
            if (Value.Length > 64)
            {
                yield return new ValidationResult("Id value cannot exceed 64 characters");
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(Value, @"^[A-Za-z0-9\-\.]+$"))
            {
                yield return new ValidationResult("Id value can only contain letters, numbers, hyphens, and periods");
            }
        }
    }

    /// <summary>
    /// Returns a string representation of the FhirId.
    /// </summary>
    /// <returns>The id value.</returns>
    public override string? ToString() => Value;
}
