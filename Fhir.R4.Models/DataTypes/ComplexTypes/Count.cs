using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A measured amount (or an amount that can potentially be measured).
/// </summary>
/// <remarks>
/// FHIR R4 Count DataType
/// A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units.
/// Count is a specialization of Quantity.
/// </remarks>
public class Count : ComplexType<Count>
{
    /// <summary>
    /// Numerical value (with implicit precision).
    /// FHIR Path: Count.value
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("value")]
    public FhirDecimal? Value { get; set; }

    /// <summary>
    /// How the value should be understood and represented.
    /// FHIR Path: Count.comparator
    /// Cardinality: 0..1
    /// Allowed values: &lt;, &lt;=, &gt;=, &gt;
    /// </summary>
    [JsonPropertyName("comparator")]
    public FhirCode? Comparator { get; set; }

    /// <summary>
    /// A human-readable form of the unit.
    /// FHIR Path: Count.unit
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("unit")]
    public FhirString? Unit { get; set; }

    /// <summary>
    /// The identification of the system that provides the coded form of the unit.
    /// FHIR Path: Count.system
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// A computer processable form of the unit in some unit representation system.
    /// FHIR Path: Count.code
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("code")]
    public FhirCode? Code { get; set; }

    /// <summary>
    /// Initializes a new instance of the Count class.
    /// </summary>
    public Count() { }

    /// <summary>
    /// Initializes a new instance of the Count class with a value.
    /// </summary>
    /// <param name="value">The count value.</param>
    public Count(decimal? value)
    {
        Value = value != null ? new FhirDecimal(value) : null;
        Unit = new FhirString("1");
        System = new FhirUri("http://unitsofmeasure.org");
        Code = new FhirCode("1");
    }

    /// <summary>
    /// Initializes a new instance of the Count class with a value and unit.
    /// </summary>
    /// <param name="value">The count value.</param>
    /// <param name="unit">The unit.</param>
    public Count(decimal? value, string unit)
    {
        Value = value != null ? new FhirDecimal(value) : null;
        Unit = new FhirString(unit);
        System = new FhirUri("http://unitsofmeasure.org");
        Code = new FhirCode(unit);
    }

    /// <summary>
    /// Creates a Count with the specified value.
    /// </summary>
    /// <param name="count">The count value.</param>
    /// <returns>A new Count instance.</returns>
    public static Count Of(decimal count)
    {
        return new Count(count);
    }

    /// <summary>
    /// Creates a Count with the specified integer value.
    /// </summary>
    /// <param name="count">The count value.</param>
    /// <returns>A new Count instance.</returns>
    public static Count Of(int count)
    {
        return new Count(count);
    }

    /// <summary>
    /// Creates a Count with the specified value and unit.
    /// </summary>
    /// <param name="count">The count value.</param>
    /// <param name="unit">The unit.</param>
    /// <returns>A new Count instance.</returns>
    public static Count Of(decimal count, string unit)
    {
        return new Count(count, unit);
    }

    /// <summary>
    /// Creates a Count representing zero.
    /// </summary>
    /// <returns>A new Count instance with value 0.</returns>
    public static Count Zero()
    {
        return new Count(0);
    }

    /// <summary>
    /// Creates a Count representing one.
    /// </summary>
    /// <returns>A new Count instance with value 1.</returns>
    public static Count One()
    {
        return new Count(1);
    }

    /// <summary>
    /// Validates the Count according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // Count should not be negative
        if (Value?.Value < 0)
        {
            yield return new ValidationResult(
                "Count cannot be negative",
                new[] { nameof(Value) });
        }

        // Count should be a whole number
        if (Value?.Value != null && Value.Value != Math.Floor((decimal)Value.Value))
        {
            yield return new ValidationResult(
                "Count should be a whole number",
                new[] { nameof(Value) });
        }
    }

    protected override string? GetComplexTypeString()
    {
        return $"Count: {Value?.Value} {Unit?.Value}".Trim();
    }
}
