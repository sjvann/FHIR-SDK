// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Narrative Type: A human-readable summary of the resource conveying the essential clinical and
/// business information for the resource.
/// </summary>
public class Narrative : DataType
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
    /// The status of the narrative - whether it&apos;s entirely generated (from just the defined data or
    /// the extensions too), or whether a human authored it and it may contain additional data.
    /// </summary>
    [FhirElement("status", Order = 12)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// The actual narrative content, a stripped down version of XHTML.
    /// </summary>
    [FhirElement("div", Order = 13)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("div")]
    public FhirXhtml Div { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Narrative cardinality
        var narrativeCount = Narrative?.Count ?? 0;
        if (narrativeCount < 0)
        {
            yield return new ValidationResult("Element 'Narrative' cardinality must be 0..*", new[] { nameof(Narrative) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Narrative.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'Narrative.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        if (Div == null)
        {
            yield return new ValidationResult("Element 'Narrative.div' cardinality must be 1..1", new[] { nameof(Div) });
        }

        // ValueSet binding validation
        // Validate Status ValueSet binding
        if (Status != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/narrative-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Narrative) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Status) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Div) });
        // }
        // Constraint: txt-1
        // Expression: htmlChecks()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("htmlChecks()"))
        // {
        //     yield return new ValidationResult("The narrative SHALL contain only the basic html formatting elements and attributes described in chapters 7-11 (except section 4 of chapter 9) and 15 of the HTML 4.0 standard, <a> elements (either name or href), images and internally contained style attributes", new[] { nameof(Div) });
        // }
        // Constraint: txt-2
        // Expression: htmlChecks()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("htmlChecks()"))
        // {
        //     yield return new ValidationResult("The narrative SHALL have some non-whitespace content", new[] { nameof(Div) });
        // }
    }

}
