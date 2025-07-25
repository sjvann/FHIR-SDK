using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A duration of time during which an organism (or a process) has existed.
/// </summary>
/// <remarks>
/// FHIR R4 Age DataType
/// A duration of time during which an organism (or a process) has existed.
/// Age is a specialization of Quantity.
/// </remarks>
public class Age : ComplexType<Age>
{
    /// <summary>
    /// Numerical value (with implicit precision).
    /// FHIR Path: Age.value
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("value")]
    public FhirDecimal? Value { get; set; }

    /// <summary>
    /// How the value should be understood and represented.
    /// FHIR Path: Age.comparator
    /// Cardinality: 0..1
    /// Allowed values: &lt;, &lt;=, &gt;=, &gt;
    /// </summary>
    [JsonPropertyName("comparator")]
    public FhirCode? Comparator { get; set; }

    /// <summary>
    /// A human-readable form of the unit.
    /// FHIR Path: Age.unit
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("unit")]
    public FhirString? Unit { get; set; }

    /// <summary>
    /// The identification of the system that provides the coded form of the unit.
    /// FHIR Path: Age.system
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// A computer processable form of the unit in some unit representation system.
    /// FHIR Path: Age.code
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("code")]
    public FhirCode? Code { get; set; }

    /// <summary>
    /// Initializes a new instance of the Age class.
    /// </summary>
    public Age() { }

    /// <summary>
    /// Initializes a new instance of the Age class with a value and unit.
    /// </summary>
    /// <param name="value">The age value.</param>
    /// <param name="unit">The unit.</param>
    public Age(decimal? value, string unit)
    {
        Value = value != null ? new FhirDecimal(value) : null;
        Unit = new FhirString(unit);
        System = new FhirUri("http://unitsofmeasure.org");
        Code = new FhirCode(unit);
    }

    /// <summary>
    /// Creates an Age in years.
    /// </summary>
    /// <param name="years">The age in years.</param>
    /// <returns>A new Age instance.</returns>
    public static Age Years(decimal years)
    {
        return new Age(years, "a");
    }

    /// <summary>
    /// Creates an Age in months.
    /// </summary>
    /// <param name="months">The age in months.</param>
    /// <returns>A new Age instance.</returns>
    public static Age Months(decimal months)
    {
        return new Age(months, "mo");
    }

    /// <summary>
    /// Creates an Age in weeks.
    /// </summary>
    /// <param name="weeks">The age in weeks.</param>
    /// <returns>A new Age instance.</returns>
    public static Age Weeks(decimal weeks)
    {
        return new Age(weeks, "wk");
    }

    /// <summary>
    /// Creates an Age in days.
    /// </summary>
    /// <param name="days">The age in days.</param>
    /// <returns>A new Age instance.</returns>
    public static Age Days(decimal days)
    {
        return new Age(days, "d");
    }

    /// <summary>
    /// Creates an Age in hours.
    /// </summary>
    /// <param name="hours">The age in hours.</param>
    /// <returns>A new Age instance.</returns>
    public static Age Hours(decimal hours)
    {
        return new Age(hours, "h");
    }

    /// <summary>
    /// Creates an Age in minutes.
    /// </summary>
    /// <param name="minutes">The age in minutes.</param>
    /// <returns>A new Age instance.</returns>
    public static Age Minutes(decimal minutes)
    {
        return new Age(minutes, "min");
    }

    /// <summary>
    /// Validates the Age according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // Age should not be negative
        if (Value?.Value < 0)
        {
            yield return new ValidationResult(
                "Age cannot be negative",
                new[] { nameof(Value) });
        }

        // Age should have appropriate units
        if (Code?.Value != null)
        {
            var validUnits = new[] { "a", "mo", "wk", "d", "h", "min", "s" };
            if (!validUnits.Contains(Code.Value))
            {
                yield return new ValidationResult(
                    $"Age unit '{Code.Value}' is not a valid time unit",
                    new[] { nameof(Code) });
            }
        }
    }

    protected override string? GetComplexTypeString()
    {
        return $"Age: {Value?.Value} {Unit?.Value}";
    }
}
