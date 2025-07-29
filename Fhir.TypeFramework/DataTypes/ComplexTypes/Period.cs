using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR Period complex type.
/// A time period defined by a start and end date and/or time.
/// </summary>
/// <remarks>
/// FHIR R5 Period (Complex Type)
/// A time period defined by a start and end date and/or time.
/// 
/// Structure:
/// - start: dateTime (0..1) - Starting time with inclusive boundary
/// - end: dateTime (0..1) - End time with inclusive boundary, if not ongoing
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Period : UnifiedComplexTypeBase<Period>
{
    /// <summary>
    /// Gets or sets the start.
    /// Starting time with inclusive boundary.
    /// </summary>
    [JsonPropertyName("start")]
    public FhirDateTime? Start { get; set; }

    /// <summary>
    /// Gets or sets the end.
    /// End time with inclusive boundary, if not ongoing.
    /// </summary>
    [JsonPropertyName("end")]
    public FhirDateTime? End { get; set; }

    /// <summary>
    /// Gets whether the period is ongoing.
    /// </summary>
    /// <returns>True if the period is ongoing; otherwise, false.</returns>
    [JsonIgnore]
    public bool IsOngoing => Start != null && End == null;

    /// <summary>
    /// Gets the duration of the period.
    /// </summary>
    /// <returns>The duration of the period.</returns>
    [JsonIgnore]
    public TimeSpan? Duration
    {
        get
        {
            if (Start?.Value == null || End?.Value == null)
                return null;
            
            return End.Value - Start.Value;
        }
    }

    /// <summary>
    /// Checks if a date time is within this period.
    /// </summary>
    /// <param name="dateTime">The date time to check.</param>
    /// <returns>True if the date time is within this period; otherwise, false.</returns>
    public bool Contains(DateTime dateTime)
    {
        if (Start?.Value == null)
            return false;
        
        if (End?.Value == null)
            return dateTime >= Start.Value;
        
        return dateTime >= Start.Value && dateTime <= End.Value;
    }

    /// <summary>
    /// Copies fields to target.
    /// </summary>
    /// <param name="target">The target object.</param>
    protected override void CopyFieldsTo(Period target)
    {
        target.Start = (FhirDateTime?)Start?.DeepCopy();
        target.End = (FhirDateTime?)End?.DeepCopy();
    }

    /// <summary>
    /// Compares if fields are exactly equal.
    /// </summary>
    /// <param name="other">The other object to compare.</param>
    /// <returns>True if fields are exactly equal; otherwise, false.</returns>
    protected override bool FieldsAreExactly(Period other)
    {
        return Equals(Start, other.Start)
            && Equals(End, other.End);
    }

    /// <summary>
    /// Validates fields.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>Validation result collection.</returns>
    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        if (Start != null)
        {
            foreach (var v in Start.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (End != null)
        {
            foreach (var v in End.Validate(validationContext))
            {
                yield return v;
            }
        }
        
        // 驗證開始時間不能晚於結束時間
        if (Start?.Value != null && End?.Value != null && Start.Value > End.Value)
        {
            yield return new ValidationResult("Period start time cannot be later than end time");
        }
    }
} 