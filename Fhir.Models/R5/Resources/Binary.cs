// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A resource that represents the data of a single raw artifact as digital content accessible in its
/// native format. A Binary resource can contain any content, whether text, image, pdf, zip archive,
/// etc.
/// </summary>
public class Binary : Resource
{
    public override string ResourceType => "Binary";

    /// <summary>
    /// The logical id of the resource, as used in the URL for the resource. Once assigned, this value never
    /// changes.
    /// </summary>
    [FhirElement("id", Order = 10)]
    [Cardinality(0, 1)]
    [JsonPropertyName("id")]
    public FhirString? Id { get; set; }

    /// <summary>
    /// The metadata about the resource. This is content that is maintained by the infrastructure. Changes
    /// to the content might not always be associated with version changes to the resource.
    /// </summary>
    [FhirElement("meta", Order = 11)]
    [Cardinality(0, 1)]
    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }

    /// <summary>
    /// A reference to a set of rules that were followed when the resource was constructed, and which must
    /// be understood when processing the content. Often, this is a reference to an implementation guide
    /// that defines the special rules along with other profiles etc.
    /// </summary>
    [FhirElement("implicitRules", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("implicitRules")]
    public FhirUri? ImplicitRules { get; set; }

    /// <summary>
    /// The base language in which the resource is written.
    /// </summary>
    [FhirElement("language", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("language")]
    public FhirCode? Language { get; set; }

    /// <summary>
    /// MimeType of the binary content represented as a standard MimeType (BCP 13).
    /// </summary>
    [FhirElement("contentType", Order = 14)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("contentType")]
    public FhirCode ContentType { get; set; }

    /// <summary>
    /// This element identifies another resource that can be used as a proxy of the security sensitivity to
    /// use when deciding and enforcing access control rules for the Binary resource. Given that the Binary
    /// resource contains very few elements that can be used to determine the sensitivity of the data and
    /// relationships to individuals, the referenced resource stands in as a proxy equivalent for this
    /// purpose. This referenced resource may be related to the Binary (e.g. DocumentReference), or may be
    /// some non-related Resource purely as a security proxy. E.g. to identify that the binary resource
    /// relates to a patient, and access should only be granted to applications that have access to the
    /// patient.
    /// </summary>
    [FhirElement("securityContext", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("securityContext")]
    public Reference<Resource> SecurityContext { get; set; }

    /// <summary>
    /// The actual content, base64 encoded.
    /// </summary>
    [FhirElement("data", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("data")]
    public FhirBase64Binary? Data { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Binary cardinality
        var binaryCount = Binary?.Count ?? 0;
        if (binaryCount < 0)
        {
            yield return new ValidationResult("Element 'Binary' cardinality must be 0..*", new[] { nameof(Binary) });
        }
        if (ContentType == null)
        {
            yield return new ValidationResult("Element 'Binary.contentType' cardinality must be 1..1", new[] { nameof(ContentType) });
        }

        // ValueSet binding validation
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate ContentType ValueSet binding
        if (ContentType != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/mimetypes|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Meta) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ImplicitRules) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Language) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ContentType) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SecurityContext) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Data) });
        // }
    }

}
