using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR unsignedInt primitive type.
/// An integer with a value that is not negative (e.g. >= 0).
/// </summary>
/// <remarks>
/// FHIR R4 unsignedInt PrimitiveType
/// An integer with a value that is not negative (e.g. >= 0).
/// </remarks>
public class FhirUnsignedInt : Element
{
    private int? _value;

    /// <summary>
    /// The actual unsignedInt value.
    /// </summary>
    [JsonPropertyName("value")]
    public int? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirUnsignedInt class.
    /// </summary>
    public FhirUnsignedInt() { }

    /// <summary>
    /// Initializes a new instance of the FhirUnsignedInt class with the specified value.
    /// </summary>
    /// <param name="value">The unsignedInt value.</param>
    public FhirUnsignedInt(int? value)
    {
        Value = value;
    }

    /// <summary>
    /// Implicitly converts an integer to a FhirUnsignedInt.
    /// </summary>
    /// <param name="value">The integer value to convert.</param>
    /// <returns>A FhirUnsignedInt instance, or null if the value is null.</returns>
    public static implicit operator FhirUnsignedInt?(int? value)
    {
        return value == null ? null : new FhirUnsignedInt(value);
    }

    /// <summary>
    /// Implicitly converts a FhirUnsignedInt to an integer.
    /// </summary>
    /// <param name="fhirUnsignedInt">The FhirUnsignedInt to convert.</param>
    /// <returns>The integer value, or null if the FhirUnsignedInt is null.</returns>
    public static implicit operator int?(FhirUnsignedInt? fhirUnsignedInt)
    {
        return fhirUnsignedInt?.Value;
    }

    /// <summary>
    /// Validates the FhirUnsignedInt according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        if (Value.HasValue && Value.Value < 0)
        {
            yield return new ValidationResult($"unsignedInt value '{Value}' must be greater than or equal to 0");
        }
    }

    /// <summary>
    /// Returns a string representation of the FhirUnsignedInt.
    /// </summary>
    /// <returns>The string representation of the unsignedInt value.</returns>
    public override string? ToString() => Value?.ToString();
}
