using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A time period defined by a start and end date and optionally time.
/// </summary>
/// <remarks>
/// FHIR R4 Period DataType
/// A time period defined by a start and end date and optionally time.
/// </remarks>
public class Period : ComplexType<Period>
{
    /// <summary>
    /// Starting time with inclusive boundary.
    /// FHIR Path: Period.start
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("start")]
    public FhirDateTime? Start { get; set; }

    /// <summary>
    /// End time with inclusive boundary, if not ongoing.
    /// FHIR Path: Period.end
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("end")]
    public FhirDateTime? End { get; set; }

    /// <summary>
    /// Initializes a new instance of the Period class.
    /// </summary>
    public Period() { }

    /// <summary>
    /// Initializes a new instance of the Period class with start and end dates.
    /// </summary>
    /// <param name="start">The start date/time.</param>
    /// <param name="end">The end date/time.</param>
    public Period(FhirDateTime? start, FhirDateTime? end)
    {
        Start = start;
        End = end;
    }

    /// <summary>
    /// Initializes a new instance of the Period class with string dates.
    /// </summary>
    /// <param name="start">The start date/time as string.</param>
    /// <param name="end">The end date/time as string.</param>
    public Period(string? start, string? end)
    {
        Start = start != null ? new FhirDateTime(start) : null;
        End = end != null ? new FhirDateTime(end) : null;
    }

    /// <summary>
    /// Creates a Period starting at the specified date/time.
    /// </summary>
    /// <param name="start">The start date/time.</param>
    /// <returns>A new Period instance.</returns>
    public static Period StartingAt(FhirDateTime start)
    {
        return new Period(start, null);
    }

    /// <summary>
    /// Creates a Period ending at the specified date/time.
    /// </summary>
    /// <param name="end">The end date/time.</param>
    /// <returns>A new Period instance.</returns>
    public static Period EndingAt(FhirDateTime end)
    {
        return new Period(null, end);
    }

    /// <summary>
    /// Creates a Period between two date/times.
    /// </summary>
    /// <param name="start">The start date/time.</param>
    /// <param name="end">The end date/time.</param>
    /// <returns>A new Period instance.</returns>
    public static Period Between(FhirDateTime start, FhirDateTime end)
    {
        return new Period(start, end);
    }

    /// <summary>
    /// Creates a Period between two string dates.
    /// </summary>
    /// <param name="start">The start date/time as string.</param>
    /// <param name="end">The end date/time as string.</param>
    /// <returns>A new Period instance.</returns>
    public static Period Between(string start, string end)
    {
        return new Period(start, end);
    }

    /// <summary>
    /// Checks if a DateTime is within this period.
    /// </summary>
    /// <param name="dateTime">The DateTime to check.</param>
    /// <returns>True if the DateTime is within the period, false otherwise.</returns>
    public bool Contains(DateTime dateTime)
    {
        // Check start boundary
        if (Start?.Value != null && DateTime.TryParse(Start.Value, out var startDate) && dateTime < startDate)
            return false;

        // Check end boundary
        if (End?.Value != null && DateTime.TryParse(End.Value, out var endDate) && dateTime > endDate)
            return false;

        return true;
    }

    /// <summary>
    /// Checks if this period overlaps with another period.
    /// </summary>
    /// <param name="other">The other period to check.</param>
    /// <returns>True if the periods overlap, false otherwise.</returns>
    public bool OverlapsWith(Period other)
    {
        if (other == null) return false;

        // Parse dates
        if (!DateTime.TryParse(Start?.Value, out var thisStart) ||
            !DateTime.TryParse(End?.Value, out var thisEnd) ||
            !DateTime.TryParse(other.Start?.Value, out var otherStart) ||
            !DateTime.TryParse(other.End?.Value, out var otherEnd))
            return false;

        // Check for overlap: periods overlap if one starts before the other ends
        return thisStart <= otherEnd && otherStart <= thisEnd;
    }

    /// <summary>
    /// Gets the duration of this period.
    /// </summary>
    /// <returns>The duration as TimeSpan, or null if start or end is missing.</returns>
    public TimeSpan? GetDuration()
    {
        if (!DateTime.TryParse(Start?.Value, out var startDate) ||
            !DateTime.TryParse(End?.Value, out var endDate))
            return null;

        return endDate - startDate;
    }

    /// <summary>
    /// Validates the Period according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // per-1: If present, start SHALL have a lower value than end
        if (DateTime.TryParse(Start?.Value, out var startDate) &&
            DateTime.TryParse(End?.Value, out var endDate))
        {
            if (startDate > endDate)
            {
                yield return new ValidationResult(
                    "Period start must be before or equal to end",
                    new[] { nameof(Start), nameof(End) });
            }
        }
    }

    protected override string? GetComplexTypeString()
    {
        var startStr = Start?.Value ?? "?";
        var endStr = End?.Value ?? "ongoing";
        return $"Period: {startStr} to {endStr}";
    }
}
