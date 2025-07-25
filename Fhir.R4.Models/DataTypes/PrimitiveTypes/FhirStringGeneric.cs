using System.ComponentModel.DataAnnotations;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR string primitive type using generic base class.
/// A sequence of Unicode characters.
/// </summary>
/// <remarks>
/// FHIR R4 string PrimitiveType
/// Note that strings SHALL NOT exceed 1MB in size.
/// This implementation demonstrates the use of the generic PrimitiveType base class.
/// </remarks>
public class FhirStringGeneric : PrimitiveType<string, FhirStringGeneric>
{
    /// <summary>
    /// Initializes a new instance of the FhirStringGeneric class.
    /// </summary>
    public FhirStringGeneric() { }

    /// <summary>
    /// Initializes a new instance of the FhirStringGeneric class with the specified value.
    /// </summary>
    /// <param name="value">The string value.</param>
    public FhirStringGeneric(string? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a string to a FhirStringGeneric.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirStringGeneric instance, or null if the value is null.</returns>
    public static implicit operator FhirStringGeneric?(string? value)
    {
        return value == null ? null : new FhirStringGeneric(value);
    }

    /// <summary>
    /// Implicitly converts a FhirStringGeneric to a string.
    /// </summary>
    /// <param name="fhirString">The FhirStringGeneric to convert.</param>
    /// <returns>The string value, or null if the FhirStringGeneric is null.</returns>
    public static implicit operator string?(FhirStringGeneric? fhirString)
    {
        return fhirString?.Value;
    }

    /// <summary>
    /// Validates the string value according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateValue(ValidationContext validationContext)
    {
        // FHIR string cannot exceed 1MB
        if (Value != null && System.Text.Encoding.UTF8.GetByteCount(Value) > 1024 * 1024)
        {
            yield return new ValidationResult("String value cannot exceed 1MB in size");
        }
    }
}

/// <summary>
/// FHIR integer primitive type using generic base class.
/// A signed integer in the range −2,147,483,648..2,147,483,647 (32-bit).
/// </summary>
/// <remarks>
/// FHIR R4 integer PrimitiveType
/// This implementation demonstrates the use of the generic PrimitiveType base class.
/// </remarks>
public class FhirIntegerGeneric : PrimitiveType<int?, FhirIntegerGeneric>
{
    /// <summary>
    /// Initializes a new instance of the FhirIntegerGeneric class.
    /// </summary>
    public FhirIntegerGeneric() { }

    /// <summary>
    /// Initializes a new instance of the FhirIntegerGeneric class with the specified value.
    /// </summary>
    /// <param name="value">The integer value.</param>
    public FhirIntegerGeneric(int? value) : base(value) { }

    /// <summary>
    /// Implicitly converts an integer to a FhirIntegerGeneric.
    /// </summary>
    /// <param name="value">The integer value to convert.</param>
    /// <returns>A FhirIntegerGeneric instance, or null if the value is null.</returns>
    public static implicit operator FhirIntegerGeneric?(int? value)
    {
        return value == null ? null : new FhirIntegerGeneric(value);
    }

    /// <summary>
    /// Implicitly converts a FhirIntegerGeneric to an integer.
    /// </summary>
    /// <param name="fhirInteger">The FhirIntegerGeneric to convert.</param>
    /// <returns>The integer value, or null if the FhirIntegerGeneric is null.</returns>
    public static implicit operator int?(FhirIntegerGeneric? fhirInteger)
    {
        return fhirInteger?.Value;
    }
}

/// <summary>
/// FHIR positiveInt primitive type using generic base class.
/// An integer with a value that is positive (e.g. >0).
/// </summary>
/// <remarks>
/// FHIR R4 positiveInt PrimitiveType
/// This implementation demonstrates validation in the generic base class.
/// </remarks>
public class FhirPositiveIntGeneric : PrimitiveType<int?, FhirPositiveIntGeneric>
{
    /// <summary>
    /// Initializes a new instance of the FhirPositiveIntGeneric class.
    /// </summary>
    public FhirPositiveIntGeneric() { }

    /// <summary>
    /// Initializes a new instance of the FhirPositiveIntGeneric class with the specified value.
    /// </summary>
    /// <param name="value">The positive integer value.</param>
    public FhirPositiveIntGeneric(int? value) : base(value) { }

    /// <summary>
    /// Validates the positive integer value according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateValue(ValidationContext validationContext)
    {
        if (Value.HasValue && Value.Value <= 0)
        {
            yield return new ValidationResult($"positiveInt value '{Value}' must be greater than 0");
        }
    }
}
