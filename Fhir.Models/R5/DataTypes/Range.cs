// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Range Type: A set of ordered Quantities defined by a low and high limit.
/// </summary>
public class Range : DataType
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
    /// The low limit. The boundary is inclusive.
    /// </summary>
    [FhirElement("low", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("low")]
    public Quantity Low { get; set; }

    /// <summary>
    /// The high limit. The boundary is inclusive.
    /// </summary>
    [FhirElement("high", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("high")]
    public Quantity High { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Range cardinality
        var rangeCount = Range?.Count ?? 0;
        if (rangeCount < 0)
        {
            yield return new ValidationResult("Element 'Range' cardinality must be 0..*", new[] { nameof(Range) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Range.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Range) });
        // }
        // Constraint: rng-2
        // Expression: low.value.empty() or high.value.empty() or low.lowBoundary().comparable(high.highBoundary()).not() or (low.lowBoundary() <= high.highBoundary())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("low.value.empty() or high.value.empty() or low.lowBoundary().comparable(high.highBoundary()).not() or (low.lowBoundary() <= high.highBoundary())"))
        // {
        //     yield return new ValidationResult("If present, low SHALL have a lower value than high", new[] { nameof(Range) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Low) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(High) });
        // }
    }

}
