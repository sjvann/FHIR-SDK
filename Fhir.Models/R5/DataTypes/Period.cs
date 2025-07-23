// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Period Type: A time period defined by a start and end date and optionally time.
/// </summary>
public class Period : DataType
{
    /// <summary>
    /// Unique id for the element within a resource (for internal references). This may be any string value
    /// that does not contain spaces.
    /// </summary>
    [FhirElement("id", Order = 10)]
    [Cardinality(0, 1)]
    [JsonPropertyName("id")]
    public FhirString? Id { get; set; }

    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the
    /// element. To make the use of extensions safe and managable, there is a strict set of governance
    /// applied to the definition and use of extensions. Though any implementer can define an extension,
    /// there is a set of requirements that SHALL be met as part of the definition of the extension.
    /// </summary>
    [FhirElement("extension", Order = 11)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }

    /// <summary>
    /// The start of the period. The boundary is inclusive.
    /// </summary>
    [FhirElement("start", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("start")]
    public FhirDateTime? Start { get; set; }

    /// <summary>
    /// The end of the period. If the end of the period is missing, it means no end was known or planned at
    /// the time the instance was created. The start may be in the past, and the end date in the future,
    /// which means that period is expected/planned to end at that time.
    /// </summary>
    [FhirElement("end", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("end")]
    public FhirDateTime? End { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Period cardinality
        var periodCount = Period?.Count ?? 0;
        if (periodCount < 0)
        {
            yield return new ValidationResult("Element 'Period' cardinality must be 0..*", new[] { nameof(Period) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Period.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Period) });
        // }
        // Constraint: per-1
        // Expression: start.hasValue().not() or end.hasValue().not() or (start.lowBoundary() <= end.highBoundary())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("start.hasValue().not() or end.hasValue().not() or (start.lowBoundary() <= end.highBoundary())"))
        // {
        //     yield return new ValidationResult("If present, start SHALL have a lower or equal value than end", new[] { nameof(Period) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Extension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(Extension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Start) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(End) });
        // }
    }

}
