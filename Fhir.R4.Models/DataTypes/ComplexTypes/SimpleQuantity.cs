using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A measured amount (or an amount that can potentially be measured) - simplified version for Range.
/// </summary>
/// <remarks>
/// FHIR R4 SimpleQuantity DataType
/// A measured amount (or an amount that can potentially be measured).
/// SimpleQuantity is used in Range and does not allow comparators.
/// </remarks>
public class SimpleQuantity : ComplexType<SimpleQuantity>
{
    /// <summary>
    /// Numerical value (with implicit precision).
    /// FHIR Path: SimpleQuantity.value
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("value")]
    public FhirDecimal? Value { get; set; }

    /// <summary>
    /// A human-readable form of the unit.
    /// FHIR Path: SimpleQuantity.unit
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("unit")]
    public FhirString? Unit { get; set; }

    /// <summary>
    /// The identification of the system that provides the coded form of the unit.
    /// FHIR Path: SimpleQuantity.system
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// A computer processable form of the unit in some unit representation system.
    /// FHIR Path: SimpleQuantity.code
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("code")]
    public FhirCode? Code { get; set; }

    /// <summary>
    /// Comparator (not allowed in SimpleQuantity).
    /// FHIR Path: SimpleQuantity.comparator
    /// Cardinality: 0..1
    /// Note: This property exists for structural compatibility but should not be used.
    /// </summary>
    [JsonPropertyName("comparator")]
    public FhirCode? Comparator { get; set; }

    /// <summary>
    /// Initializes a new instance of the SimpleQuantity class.
    /// </summary>
    public SimpleQuantity() { }

    /// <summary>
    /// Initializes a new instance of the SimpleQuantity class with a value.
    /// </summary>
    /// <param name="value">The numerical value.</param>
    /// <param name="unit">The unit of measurement.</param>
    /// <param name="system">The system that defines the coded unit form.</param>
    /// <param name="code">The coded form of the unit.</param>
    public SimpleQuantity(decimal? value, string? unit = null, string? system = null, string? code = null)
    {
        Value = value != null ? new FhirDecimal(value) : null;
        Unit = unit != null ? new FhirString(unit) : null;
        System = system != null ? new FhirUri(system) : null;
        Code = code != null ? new FhirCode(code) : null;
    }

    /// <summary>
    /// Creates a SimpleQuantity with the specified value and unit.
    /// </summary>
    /// <param name="value">The numerical value.</param>
    /// <param name="unit">The unit of measurement.</param>
    /// <returns>A new SimpleQuantity instance.</returns>
    public static SimpleQuantity Create(decimal value, string unit)
    {
        return new SimpleQuantity(value, unit);
    }

    /// <summary>
    /// Creates a SimpleQuantity with the specified value, unit, system, and code.
    /// </summary>
    /// <param name="value">The numerical value.</param>
    /// <param name="unit">The unit of measurement.</param>
    /// <param name="system">The system that defines the coded unit form.</param>
    /// <param name="code">The coded form of the unit.</param>
    /// <returns>A new SimpleQuantity instance.</returns>
    public static SimpleQuantity CreateWithCode(decimal value, string unit, string system, string code)
    {
        return new SimpleQuantity(value, unit, system, code);
    }

    /// <summary>
    /// Validates the SimpleQuantity according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // sqty-1: The comparator is not used on a SimpleQuantity
        if (Comparator != null)
        {
            yield return new ValidationResult(
                "SimpleQuantity cannot have a comparator",
                new[] { nameof(Comparator) });
        }
    }

    protected override string? GetComplexTypeString()
    {
        return $"SimpleQuantity: {Value?.Value} {Unit?.Value}";
    }
}
