using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// Specifies an event that may occur multiple times.
/// </summary>
/// <remarks>
/// FHIR R4 Timing DataType
/// Specifies an event that may occur multiple times.
/// </remarks>
public class Timing : ComplexType<Timing>
{
    /// <summary>
    /// When the event occurs.
    /// FHIR Path: Timing.event
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("event")]
    public List<FhirDateTime>? Event { get; set; }
    
    /// <summary>
    /// When the event is to occur.
    /// FHIR Path: Timing.repeat
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("repeat")]
    public TimingRepeat? Repeat { get; set; }
    
    /// <summary>
    /// BID | TID | QID | AM | PM | QD | QOD | +.
    /// FHIR Path: Timing.code
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("code")]
    public CodeableConcept? Code { get; set; }

    /// <summary>
    /// Initializes a new instance of the Timing class.
    /// </summary>
    public Timing() { }

    /// <summary>
    /// Creates a timing with specific events.
    /// </summary>
    /// <param name="events">The event times.</param>
    /// <returns>A new Timing instance.</returns>
    public static Timing WithEvents(params string[] events)
    {
        return new Timing
        {
            Event = events.Select(e => new FhirDateTime(e)).ToList()
        };
    }

    /// <summary>
    /// Creates a timing with a repeat pattern.
    /// </summary>
    /// <param name="repeat">The repeat pattern.</param>
    /// <returns>A new Timing instance.</returns>
    public static Timing WithRepeat(TimingRepeat repeat)
    {
        return new Timing
        {
            Repeat = repeat
        };
    }

    /// <summary>
    /// Creates a timing with a code (e.g., BID, TID).
    /// </summary>
    /// <param name="code">The timing code.</param>
    /// <returns>A new Timing instance.</returns>
    public static Timing WithCode(CodeableConcept code)
    {
        return new Timing
        {
            Code = code
        };
    }

    /// <summary>
    /// Creates a daily timing.
    /// </summary>
    /// <returns>A new Timing instance for daily dosing.</returns>
    public static Timing Daily()
    {
        return WithCode(new CodeableConcept
        {
            Coding = new List<Coding>
            {
                new Coding
                {
                    System = "http://terminology.hl7.org/CodeSystem/v3-GTSAbbreviation",
                    Code = "QD",
                    Display = "QD"
                }
            }
        });
    }

    /// <summary>
    /// Creates a twice daily timing.
    /// </summary>
    /// <returns>A new Timing instance for twice daily dosing.</returns>
    public static Timing TwiceDaily()
    {
        return WithCode(new CodeableConcept
        {
            Coding = new List<Coding>
            {
                new Coding
                {
                    System = "http://terminology.hl7.org/CodeSystem/v3-GTSAbbreviation",
                    Code = "BID",
                    Display = "BID"
                }
            }
        });
    }

    /// <summary>
    /// Creates a three times daily timing.
    /// </summary>
    /// <returns>A new Timing instance for three times daily dosing.</returns>
    public static Timing ThreeTimesDaily()
    {
        return WithCode(new CodeableConcept
        {
            Coding = new List<Coding>
            {
                new Coding
                {
                    System = "http://terminology.hl7.org/CodeSystem/v3-GTSAbbreviation",
                    Code = "TID",
                    Display = "TID"
                }
            }
        });
    }

    /// <summary>
    /// Validates the Timing according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // tim-1: if there's a duration, there needs to be duration units
        if (Repeat?.Duration != null && Repeat.DurationUnit == null)
        {
            yield return new ValidationResult(
                "Timing.repeat.duration requires durationUnit",
                new[] { "Repeat.Duration", "Repeat.DurationUnit" });
        }

        // tim-2: if there's a period, there needs to be period units
        if (Repeat?.Period != null && Repeat.PeriodUnit == null)
        {
            yield return new ValidationResult(
                "Timing.repeat.period requires periodUnit",
                new[] { "Repeat.Period", "Repeat.PeriodUnit" });
        }
    }

    protected override string? GetComplexTypeString()
    {
        if (Code?.Text != null)
            return $"Timing: {Code.Text}";

        if (Event?.Any() == true)
            return $"Timing: {Event.Count} events";
        
        if (Repeat != null)
            return "Timing: with repeat pattern";
        
        return "Timing: unspecified";
    }
}
