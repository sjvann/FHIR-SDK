using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A length of time.
/// </summary>
/// <remarks>
/// FHIR R4 Duration DataType
/// A length of time.
/// Duration is a specialization of Quantity.
/// </remarks>
public class Duration : ComplexType<Duration>
{
    /// <summary>
    /// Numerical value (with implicit precision).
    /// FHIR Path: Duration.value
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("value")]
    public FhirDecimal? Value { get; set; }

    /// <summary>
    /// How the value should be understood and represented.
    /// FHIR Path: Duration.comparator
    /// Cardinality: 0..1
    /// Allowed values: &lt;, &lt;=, &gt;=, &gt;
    /// </summary>
    [JsonPropertyName("comparator")]
    public FhirCode? Comparator { get; set; }

    /// <summary>
    /// A human-readable form of the unit.
    /// FHIR Path: Duration.unit
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("unit")]
    public FhirString? Unit { get; set; }

    /// <summary>
    /// The identification of the system that provides the coded form of the unit.
    /// FHIR Path: Duration.system
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// A computer processable form of the unit in some unit representation system.
    /// FHIR Path: Duration.code
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("code")]
    public FhirCode? Code { get; set; }

    /// <summary>
    /// Initializes a new instance of the Duration class.
    /// </summary>
    public Duration() { }

    /// <summary>
    /// Initializes a new instance of the Duration class with a value and unit.
    /// </summary>
    /// <param name="value">The duration value.</param>
    /// <param name="unit">The unit.</param>
    public Duration(decimal? value, string unit)
    {
        Value = value != null ? new FhirDecimal(value) : null;
        Unit = new FhirString(unit);
        System = new FhirUri("http://unitsofmeasure.org");
        Code = new FhirCode(unit);
    }

    /// <summary>
    /// Creates a Duration in seconds.
    /// </summary>
    /// <param name="seconds">The duration in seconds.</param>
    /// <returns>A new Duration instance.</returns>
    public static Duration Seconds(decimal seconds)
    {
        return new Duration(seconds, "s");
    }

    /// <summary>
    /// Creates a Duration in minutes.
    /// </summary>
    /// <param name="minutes">The duration in minutes.</param>
    /// <returns>A new Duration instance.</returns>
    public static Duration Minutes(decimal minutes)
    {
        return new Duration(minutes, "min");
    }

    /// <summary>
    /// Creates a Duration in hours.
    /// </summary>
    /// <param name="hours">The duration in hours.</param>
    /// <returns>A new Duration instance.</returns>
    public static Duration Hours(decimal hours)
    {
        return new Duration(hours, "h");
    }

    /// <summary>
    /// Creates a Duration in days.
    /// </summary>
    /// <param name="days">The duration in days.</param>
    /// <returns>A new Duration instance.</returns>
    public static Duration Days(decimal days)
    {
        return new Duration(days, "d");
    }

    /// <summary>
    /// Creates a Duration in weeks.
    /// </summary>
    /// <param name="weeks">The duration in weeks.</param>
    /// <returns>A new Duration instance.</returns>
    public static Duration Weeks(decimal weeks)
    {
        return new Duration(weeks, "wk");
    }

    /// <summary>
    /// Creates a Duration in months.
    /// </summary>
    /// <param name="months">The duration in months.</param>
    /// <returns>A new Duration instance.</returns>
    public static Duration Months(decimal months)
    {
        return new Duration(months, "mo");
    }

    /// <summary>
    /// Creates a Duration in years.
    /// </summary>
    /// <param name="years">The duration in years.</param>
    /// <returns>A new Duration instance.</returns>
    public static Duration Years(decimal years)
    {
        return new Duration(years, "a");
    }

    /// <summary>
    /// Validates the Duration according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // Duration should not be negative
        if (Value?.Value < 0)
        {
            yield return new ValidationResult(
                "Duration cannot be negative",
                new[] { nameof(Value) });
        }

        // Duration should have appropriate time units
        if (Code?.Value != null)
        {
            var validUnits = new[] { "s", "min", "h", "d", "wk", "mo", "a" };
            if (!validUnits.Contains(Code.Value))
            {
                yield return new ValidationResult(
                    $"Duration unit '{Code.Value}' is not a valid time unit",
                    new[] { nameof(Code) });
            }
        }
    }

    protected override string? GetComplexTypeString()
    {
        return $"Duration: {Value?.Value} {Unit?.Value}";
    }
}
