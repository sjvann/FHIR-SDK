using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR code primitive type.
/// A string which has at least one character and no leading or trailing whitespace.
/// </summary>
/// <remarks>
/// FHIR R4 code PrimitiveType
/// Used for codes that are defined by FHIR itself.
/// </remarks>
public class FhirCode : Element
{
    private string? _value;

    /// <summary>
    /// The actual code value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirCode class.
    /// </summary>
    public FhirCode() { }

    /// <summary>
    /// Initializes a new instance of the FhirCode class with the specified value.
    /// </summary>
    /// <param name="value">The code value.</param>
    public FhirCode(string? value)
    {
        Value = value;
    }

    /// <summary>
    /// Implicitly converts a string to a FhirCode.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirCode instance, or null if the value is null.</returns>
    public static implicit operator FhirCode?(string? value)
    {
        return value == null ? null : new FhirCode(value);
    }

    /// <summary>
    /// Implicitly converts a FhirCode to a string.
    /// </summary>
    /// <param name="fhirCode">The FhirCode to convert.</param>
    /// <returns>The string value, or null if the FhirCode is null.</returns>
    public static implicit operator string?(FhirCode? fhirCode)
    {
        return fhirCode?.Value;
    }

    /// <summary>
    /// Validates the FhirCode according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        if (!string.IsNullOrEmpty(Value))
        {
            if (Value != Value.Trim())
            {
                yield return new ValidationResult("Code value cannot have leading or trailing whitespace");
            }

            if (Value.Length == 0)
            {
                yield return new ValidationResult("Code value must have at least one character");
            }
        }
    }

    /// <summary>
    /// Returns a string representation of the FhirCode.
    /// </summary>
    /// <returns>The code value.</returns>
    public override string? ToString() => Value;
}
