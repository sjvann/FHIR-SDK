using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// When the event is to occur.
/// BackboneElement for Timing.Repeat
/// This element is defined within the resource and contains additional
/// structured information that is part of the resource definition.
/// </summary>
/// <remarks>
/// FHIR R4 TimingRepeat BackboneElement
/// Defines when the event is to occur.
/// </remarks>
public class TimingRepeat : ComplexType<TimingRepeat>
{
    /// <summary>
    /// Length/Range of lengths, or (Start and/or end) limits.
    /// Choice Type: bounds[x]
    /// This is a choice element - only one of the following types may be present:
    ///   - Duration
    ///   - Range
    ///   - Period
    /// </summary>
    [JsonPropertyName("boundsDuration")]
    public Duration? BoundsDuration { get; set; }

    [JsonPropertyName("boundsRange")]
    public Range? BoundsRange { get; set; }

    [JsonPropertyName("boundsPeriod")]
    public Period? BoundsPeriod { get; set; }
    
    /// <summary>
    /// Number of times to repeat.
    /// FHIR Path: Timing.repeat.count
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("count")]
    public FhirPositiveInt? Count { get; set; }
    
    /// <summary>
    /// Maximum number of times to repeat.
    /// FHIR Path: Timing.repeat.countMax
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("countMax")]
    public FhirPositiveInt? CountMax { get; set; }
    
    /// <summary>
    /// How long when it happens.
    /// FHIR Path: Timing.repeat.duration
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("duration")]
    public FhirDecimal? Duration { get; set; }
    
    /// <summary>
    /// How long when it happens (Max).
    /// FHIR Path: Timing.repeat.durationMax
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("durationMax")]
    public FhirDecimal? DurationMax { get; set; }
    
    /// <summary>
    /// s | min | h | d | wk | mo | a - unit of time (UCUM).
    /// FHIR Path: Timing.repeat.durationUnit
    /// Cardinality: 0..1
    /// Allowed values: s, min, h, d, wk, mo, a
    /// </summary>
    [JsonPropertyName("durationUnit")]
    public FhirCode? DurationUnit { get; set; }
    
    /// <summary>
    /// Event occurs frequency times per period.
    /// FHIR Path: Timing.repeat.frequency
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("frequency")]
    public FhirPositiveInt? Frequency { get; set; }
    
    /// <summary>
    /// Event occurs up to frequencyMax times per period.
    /// FHIR Path: Timing.repeat.frequencyMax
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("frequencyMax")]
    public FhirPositiveInt? FrequencyMax { get; set; }
    
    /// <summary>
    /// Event occurs frequency times per period.
    /// FHIR Path: Timing.repeat.period
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("period")]
    public FhirDecimal? Period { get; set; }
    
    /// <summary>
    /// Upper limit of period (3-4 hours).
    /// FHIR Path: Timing.repeat.periodMax
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("periodMax")]
    public FhirDecimal? PeriodMax { get; set; }
    
    /// <summary>
    /// s | min | h | d | wk | mo | a - unit of time (UCUM).
    /// FHIR Path: Timing.repeat.periodUnit
    /// Cardinality: 0..1
    /// Allowed values: s, min, h, d, wk, mo, a
    /// </summary>
    [JsonPropertyName("periodUnit")]
    public FhirCode? PeriodUnit { get; set; }
    
    /// <summary>
    /// mon | tue | wed | thu | fri | sat | sun.
    /// FHIR Path: Timing.repeat.dayOfWeek
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("dayOfWeek")]
    public List<FhirCode>? DayOfWeek { get; set; }
    
    /// <summary>
    /// Time of day for action.
    /// FHIR Path: Timing.repeat.timeOfDay
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("timeOfDay")]
    public List<FhirTime>? TimeOfDay { get; set; }
    
    /// <summary>
    /// Code for time period of occurrence.
    /// FHIR Path: Timing.repeat.when
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("when")]
    public List<FhirCode>? When { get; set; }
    
    /// <summary>
    /// Minutes from event (before or after).
    /// FHIR Path: Timing.repeat.offset
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("offset")]
    public FhirUnsignedInt? Offset { get; set; }

    /// <summary>
    /// Initializes a new instance of the TimingRepeat class.
    /// </summary>
    public TimingRepeat() { }

    /// <summary>
    /// Creates a repeat pattern with frequency and period.
    /// </summary>
    /// <param name="frequency">How many times per period.</param>
    /// <param name="period">The period value.</param>
    /// <param name="periodUnit">The period unit (d, h, min, etc.).</param>
    /// <returns>A new TimingRepeat instance.</returns>
    public static TimingRepeat Every(int frequency, decimal period, string periodUnit)
    {
        return new TimingRepeat
        {
            Frequency = new FhirPositiveInt(frequency),
            Period = new FhirDecimal(period),
            PeriodUnit = new FhirCode(periodUnit)
        };
    }

    /// <summary>
    /// Creates a daily repeat pattern.
    /// </summary>
    /// <param name="frequency">How many times per day.</param>
    /// <returns>A new TimingRepeat instance.</returns>
    public static TimingRepeat Daily(int frequency = 1)
    {
        return Every(frequency, 1, "d");
    }

    /// <summary>
    /// Creates an hourly repeat pattern.
    /// </summary>
    /// <param name="frequency">How many times per hour.</param>
    /// <returns>A new TimingRepeat instance.</returns>
    public static TimingRepeat Hourly(int frequency = 1)
    {
        return Every(frequency, 1, "h");
    }

    /// <summary>
    /// Creates a weekly repeat pattern.
    /// </summary>
    /// <param name="frequency">How many times per week.</param>
    /// <returns>A new TimingRepeat instance.</returns>
    public static TimingRepeat Weekly(int frequency = 1)
    {
        return Every(frequency, 1, "wk");
    }

    /// <summary>
    /// Validates the TimingRepeat according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // Validate duration unit values
        if (DurationUnit?.Value != null)
        {
            var validUnits = new[] { "s", "min", "h", "d", "wk", "mo", "a" };
            if (!validUnits.Contains(DurationUnit.Value))
            {
                yield return new ValidationResult(
                    $"TimingRepeat.durationUnit '{DurationUnit.Value}' is not valid. Must be one of: {string.Join(", ", validUnits)}",
                    new[] { nameof(DurationUnit) });
            }
        }
        
        // Validate period unit values
        if (PeriodUnit?.Value != null)
        {
            var validUnits = new[] { "s", "min", "h", "d", "wk", "mo", "a" };
            if (!validUnits.Contains(PeriodUnit.Value))
            {
                yield return new ValidationResult(
                    $"TimingRepeat.periodUnit '{PeriodUnit.Value}' is not valid. Must be one of: {string.Join(", ", validUnits)}",
                    new[] { nameof(PeriodUnit) });
            }
        }
        
        // Validate day of week values
        if (DayOfWeek?.Any() == true)
        {
            var validDays = new[] { "mon", "tue", "wed", "thu", "fri", "sat", "sun" };
            foreach (var day in DayOfWeek)
            {
                if (day?.Value != null && !validDays.Contains(day.Value))
                {
                    yield return new ValidationResult(
                        $"TimingRepeat.dayOfWeek '{day.Value}' is not valid. Must be one of: {string.Join(", ", validDays)}",
                        new[] { nameof(DayOfWeek) });
                }
            }
        }
    }

    protected override string? GetComplexTypeString()
    {
        if (Frequency?.Value != null && Period?.Value != null && PeriodUnit?.Value != null)
        {
            return $"TimingRepeat: {Frequency.Value} times per {Period.Value} {PeriodUnit.Value}";
        }
        
        return "TimingRepeat: custom pattern";
    }
}
