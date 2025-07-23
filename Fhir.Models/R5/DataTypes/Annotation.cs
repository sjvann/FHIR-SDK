// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Annotation Type: A text note which also contains information about who made the statement and when.
/// </summary>
public class Annotation : DataType
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
    /// The individual responsible for making the annotation. (as Reference)
    /// </summary>
    [FhirElement("authorReference", Order = 12)]
    [Cardinality(0, 1)]
    [ChoiceType("author", "reference")]
    [JsonPropertyName("authorReference")]
    public Reference<Practitioner> AuthorReference { get; set; }

    /// <summary>
    /// The individual responsible for making the annotation. (as string)
    /// </summary>
    [FhirElement("authorString", Order = 13)]
    [Cardinality(0, 1)]
    [ChoiceType("author", "string")]
    [JsonPropertyName("authorString")]
    public FhirString? AuthorString { get; set; }

    /// <summary>
    /// Indicates when this particular annotation was made.
    /// </summary>
    [FhirElement("time", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("time")]
    public FhirDateTime? Time { get; set; }

    /// <summary>
    /// The text of the annotation in markdown format.
    /// </summary>
    [FhirElement("text", Order = 15)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("text")]
    public FhirMarkdown Text { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for author[x]
        var authorProperties = new[] { nameof(AuthorReference), nameof(AuthorString) };
        var authorSetCount = authorProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (authorSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of AuthorReference, AuthorString may be specified",
                new[] { nameof(AuthorReference), nameof(AuthorString) });
        }

    }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Annotation cardinality
        var annotationCount = Annotation?.Count ?? 0;
        if (annotationCount < 0)
        {
            yield return new ValidationResult("Element 'Annotation' cardinality must be 0..*", new[] { nameof(Annotation) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Annotation.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Text == null)
        {
            yield return new ValidationResult("Element 'Annotation.text' cardinality must be 1..1", new[] { nameof(Text) });
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Annotation) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Author) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Time) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Text) });
        // }
    }

}
