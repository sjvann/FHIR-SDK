// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Attachment Type: For referring to data content defined in other formats.
/// </summary>
public class Attachment : DataType
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
    /// Identifies the type of the data in the attachment and allows a method to be chosen to interpret or
    /// render the data. Includes mime type parameters such as charset where appropriate.
    /// </summary>
    [FhirElement("contentType", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("contentType")]
    public FhirCode? ContentType { get; set; }

    /// <summary>
    /// The human language of the content. The value can be any valid value according to BCP 47.
    /// </summary>
    [FhirElement("language", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("language")]
    public FhirCode? Language { get; set; }

    /// <summary>
    /// The actual data of the attachment - a sequence of bytes, base64 encoded.
    /// </summary>
    [FhirElement("data", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("data")]
    public FhirBase64Binary? Data { get; set; }

    /// <summary>
    /// A location where the data can be accessed.
    /// </summary>
    [FhirElement("url", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("url")]
    public FhirUrl? Url { get; set; }

    /// <summary>
    /// The number of bytes of data that make up this attachment (before base64 encoding, if that is done).
    /// </summary>
    [FhirElement("size", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("size")]
    public FhirInteger64? Size { get; set; }

    /// <summary>
    /// The calculated hash of the data using SHA-1. Represented using base64.
    /// </summary>
    [FhirElement("hash", Order = 17)]
    [Cardinality(0, 1)]
    [JsonPropertyName("hash")]
    public FhirBase64Binary? Hash { get; set; }

    /// <summary>
    /// A label or set of text to display in place of the data.
    /// </summary>
    [FhirElement("title", Order = 18)]
    [Cardinality(0, 1)]
    [JsonPropertyName("title")]
    public FhirString? Title { get; set; }

    /// <summary>
    /// The date that the attachment was first created.
    /// </summary>
    [FhirElement("creation", Order = 19)]
    [Cardinality(0, 1)]
    [JsonPropertyName("creation")]
    public FhirDateTime? Creation { get; set; }

    /// <summary>
    /// Height of the image in pixels (photo/video).
    /// </summary>
    [FhirElement("height", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("height")]
    public FhirPositiveInt? Height { get; set; }

    /// <summary>
    /// Width of the image in pixels (photo/video).
    /// </summary>
    [FhirElement("width", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("width")]
    public FhirPositiveInt? Width { get; set; }

    /// <summary>
    /// The number of frames in a photo. This is used with a multi-page fax, or an imaging acquisition
    /// context that takes multiple slices in a single image, or an animated gif. If there is more than one
    /// frame, this SHALL have a value in order to alert interface software that a multi-frame capable
    /// rendering widget is required.
    /// </summary>
    [FhirElement("frames", Order = 22)]
    [Cardinality(0, 1)]
    [JsonPropertyName("frames")]
    public FhirPositiveInt? Frames { get; set; }

    /// <summary>
    /// The duration of the recording in seconds - for audio and video.
    /// </summary>
    [FhirElement("duration", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("duration")]
    public FhirDecimal? Duration { get; set; }

    /// <summary>
    /// The number of pages when printed.
    /// </summary>
    [FhirElement("pages", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("pages")]
    public FhirPositiveInt? Pages { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Attachment cardinality
        var attachmentCount = Attachment?.Count ?? 0;
        if (attachmentCount < 0)
        {
            yield return new ValidationResult("Element 'Attachment' cardinality must be 0..*", new[] { nameof(Attachment) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Attachment.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }

        // ValueSet binding validation
        // Validate ContentType ValueSet binding
        if (ContentType != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/mimetypes|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: att-1
        // Expression: data.empty() or contentType.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("data.empty() or contentType.exists()"))
        // {
        //     yield return new ValidationResult("If the Attachment has data, it SHALL have a contentType", new[] { nameof(Attachment) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Attachment) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ContentType) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Data) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Url) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Size) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Hash) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Title) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Creation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Height) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Width) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Frames) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Duration) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Pages) });
        // }
    }

}
