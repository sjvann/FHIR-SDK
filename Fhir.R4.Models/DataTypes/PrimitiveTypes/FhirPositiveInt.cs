using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR positiveInt primitive type.
/// An integer with a value that is positive (e.g. >0).
/// </summary>
/// <remarks>
/// FHIR R4 positiveInt PrimitiveType
/// An integer with a value that is positive (e.g. >0).
/// </remarks>
public class FhirPositiveInt : Element
{
    private int? _value;

    /// <summary>
    /// The actual positiveInt value.
    /// </summary>
    [JsonPropertyName("value")]
    public int? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirPositiveInt class.
    /// </summary>
    public FhirPositiveInt() { }

    /// <summary>
    /// Initializes a new instance of the FhirPositiveInt class with the specified value.
    /// </summary>
    /// <param name="value">The positiveInt value.</param>
    public FhirPositiveInt(int? value)
    {
        Value = value;
    }

    /// <summary>
    /// Implicitly converts an integer to a FhirPositiveInt.
    /// </summary>
    /// <param name="value">The integer value to convert.</param>
    /// <returns>A FhirPositiveInt instance, or null if the value is null.</returns>
    public static implicit operator FhirPositiveInt?(int? value)
    {
        return value == null ? null : new FhirPositiveInt(value);
    }

    /// <summary>
    /// Implicitly converts a FhirPositiveInt to an integer.
    /// </summary>
    /// <param name="fhirPositiveInt">The FhirPositiveInt to convert.</param>
    /// <returns>The integer value, or null if the FhirPositiveInt is null.</returns>
    public static implicit operator int?(FhirPositiveInt? fhirPositiveInt)
    {
        return fhirPositiveInt?.Value;
    }

    /// <summary>
    /// Validates the FhirPositiveInt according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        if (Value.HasValue && Value.Value <= 0)
        {
            yield return new ValidationResult($"positiveInt value '{Value}' must be greater than 0");
        }
    }

    /// <summary>
    /// Returns a string representation of the FhirPositiveInt.
    /// </summary>
    /// <returns>The string representation of the positiveInt value.</returns>
    public override string? ToString() => Value?.ToString();
}
