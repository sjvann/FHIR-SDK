// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Signature Type: A signature along with supporting context. The signature may be a digital signature
/// that is cryptographic in nature, or some other signature acceptable to the domain. This other
/// signature may be as simple as a graphical image representing a hand-written signature, or a
/// signature ceremony Different signature approaches have different utilities.
/// </summary>
public class Signature : DataType
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
    /// An indication of the reason that the entity signed this document. This may be explicitly included as
    /// part of the signature information and can be used when determining accountability for various
    /// actions concerning the document.
    /// </summary>
    [FhirElement("type", Order = 12)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("type")]
    public List<Coding>? Type { get; set; }

    /// <summary>
    /// When the digital signature was signed.
    /// </summary>
    [FhirElement("when", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("when")]
    public FhirInstant? When { get; set; }

    /// <summary>
    /// A reference to an application-usable description of the identity that signed (e.g. the signature
    /// used their private key).
    /// </summary>
    [FhirElement("who", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("who")]
    public Reference<Practitioner> Who { get; set; }

    /// <summary>
    /// A reference to an application-usable description of the identity that is represented by the
    /// signature.
    /// </summary>
    [FhirElement("onBehalfOf", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("onBehalfOf")]
    public Reference<Practitioner> OnBehalfOf { get; set; }

    /// <summary>
    /// A mime type that indicates the technical format of the target resources signed by the signature.
    /// </summary>
    [FhirElement("targetFormat", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("targetFormat")]
    public FhirCode? TargetFormat { get; set; }

    /// <summary>
    /// A mime type that indicates the technical format of the signature. Important mime types are
    /// application/signature+xml for X ML DigSig, application/jose for JWS, and image/* for a graphical
    /// image of a signature, etc.
    /// </summary>
    [FhirElement("sigFormat", Order = 17)]
    [Cardinality(0, 1)]
    [JsonPropertyName("sigFormat")]
    public FhirCode? SigFormat { get; set; }

    /// <summary>
    /// The base64 encoding of the Signature content. When signature is not recorded electronically this
    /// element would be empty.
    /// </summary>
    [FhirElement("data", Order = 18)]
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
        // Validate Signature cardinality
        var signatureCount = Signature?.Count ?? 0;
        if (signatureCount < 0)
        {
            yield return new ValidationResult("Element 'Signature' cardinality must be 0..*", new[] { nameof(Signature) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Signature.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate Type cardinality
        var typeCount = Type?.Count ?? 0;
        if (typeCount < 0)
        {
            yield return new ValidationResult("Element 'Signature.type' cardinality must be 0..*", new[] { nameof(Type) });
        }

        // ValueSet binding validation
        // Validate TargetFormat ValueSet binding
        if (TargetFormat != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/mimetypes|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate SigFormat ValueSet binding
        if (SigFormat != null)
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Signature) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(When) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Who) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(OnBehalfOf) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(TargetFormat) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SigFormat) });
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
