// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// RelatedArtifact Type: Related artifacts such as additional documentation, justification, or
/// bibliographic references.
/// </summary>
public class RelatedArtifact : DataType
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
    /// The type of relationship to the related artifact.
    /// </summary>
    [FhirElement("type", Order = 12)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("type")]
    public FhirCode Type { get; set; }

    /// <summary>
    /// Provides additional classifiers of the related artifact.
    /// </summary>
    [FhirElement("classifier", Order = 13)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("classifier")]
    public List<CodeableConcept>? Classifier { get; set; }

    /// <summary>
    /// A short label that can be used to reference the citation from elsewhere in the containing artifact,
    /// such as a footnote index.
    /// </summary>
    [FhirElement("label", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("label")]
    public FhirString? Label { get; set; }

    /// <summary>
    /// A brief description of the document or knowledge resource being referenced, suitable for display to
    /// a consumer.
    /// </summary>
    [FhirElement("display", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("display")]
    public FhirString? Display { get; set; }

    /// <summary>
    /// A bibliographic citation for the related artifact. This text SHOULD be formatted according to an
    /// accepted citation format.
    /// </summary>
    [FhirElement("citation", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("citation")]
    public FhirMarkdown? Citation { get; set; }

    /// <summary>
    /// The document being referenced, represented as an attachment. This is exclusive with the resource
    /// element.
    /// </summary>
    [FhirElement("document", Order = 17)]
    [Cardinality(0, 1)]
    [JsonPropertyName("document")]
    public Attachment Document { get; set; }

    /// <summary>
    /// The related artifact, such as a library, value set, profile, or other knowledge resource.
    /// </summary>
    [FhirElement("resource", Order = 18)]
    [Cardinality(0, 1)]
    [JsonPropertyName("resource")]
    public FhirCanonical? Resource { get; set; }

    /// <summary>
    /// The related artifact, if the artifact is not a canonical resource, or a resource reference to a
    /// canonical resource.
    /// </summary>
    [FhirElement("resourceReference", Order = 19)]
    [Cardinality(0, 1)]
    [JsonPropertyName("resourceReference")]
    public Reference<Resource> ResourceReference { get; set; }

    /// <summary>
    /// The publication status of the artifact being referred to.
    /// </summary>
    [FhirElement("publicationStatus", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("publicationStatus")]
    public FhirCode? PublicationStatus { get; set; }

    /// <summary>
    /// The date of publication of the artifact being referred to.
    /// </summary>
    [FhirElement("publicationDate", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("publicationDate")]
    public FhirDate? PublicationDate { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate RelatedArtifact cardinality
        var relatedartifactCount = RelatedArtifact?.Count ?? 0;
        if (relatedartifactCount < 0)
        {
            yield return new ValidationResult("Element 'RelatedArtifact' cardinality must be 0..*", new[] { nameof(RelatedArtifact) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'RelatedArtifact.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'RelatedArtifact.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        // Validate Classifier cardinality
        var classifierCount = Classifier?.Count ?? 0;
        if (classifierCount < 0)
        {
            yield return new ValidationResult("Element 'RelatedArtifact.classifier' cardinality must be 0..*", new[] { nameof(Classifier) });
        }

        // ValueSet binding validation
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/related-artifact-type|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate PublicationStatus ValueSet binding
        if (PublicationStatus != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/publication-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RelatedArtifact) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Classifier) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Label) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Display) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Citation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Document) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Resource) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ResourceReference) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PublicationStatus) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PublicationDate) });
        // }
    }

}
