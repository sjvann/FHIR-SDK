using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.Resources;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A text note which also contains information about who made the statement and when.
/// </summary>
/// <remarks>
/// FHIR R4 Annotation DataType
/// A text note which also contains information about who made the statement and when.
/// </remarks>
public class Annotation : ComplexType<Annotation>
{
    /// <summary>
    /// Individual responsible for the annotation.
    /// Choice Type: author[x]
    /// This is a choice element - only one of the following types may be present:
    ///   - Reference (Practitioner, Patient, RelatedPerson, Organization)
    ///   - string
    /// </summary>
    [JsonPropertyName("authorReference")]
    public Reference<Resource>? AuthorReference { get; set; }

    [JsonPropertyName("authorString")]
    public FhirString? AuthorString { get; set; }
    
    /// <summary>
    /// When the annotation was made.
    /// FHIR Path: Annotation.time
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("time")]
    public FhirDateTime? Time { get; set; }
    
    /// <summary>
    /// The annotation - text content (as markdown).
    /// FHIR Path: Annotation.text
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("text")]
    public FhirMarkdown Text { get; set; } = null!;

    /// <summary>
    /// Initializes a new instance of the Annotation class.
    /// </summary>
    public Annotation() { }

    /// <summary>
    /// Initializes a new instance of the Annotation class with text.
    /// </summary>
    /// <param name="text">The annotation text.</param>
    public Annotation(string text)
    {
        Text = new FhirMarkdown(text);
    }

    /// <summary>
    /// Initializes a new instance of the Annotation class with text and author.
    /// </summary>
    /// <param name="text">The annotation text.</param>
    /// <param name="authorString">The author as string.</param>
    public Annotation(string text, string authorString) : this(text)
    {
        AuthorString = new FhirString(authorString);
    }

    /// <summary>
    /// Initializes a new instance of the Annotation class with text and author reference.
    /// </summary>
    /// <param name="text">The annotation text.</param>
    /// <param name="authorReference">The author reference.</param>
    public Annotation(string text, Reference<Resource> authorReference) : this(text)
    {
        AuthorReference = authorReference;
    }

    /// <summary>
    /// Creates an annotation with the specified text.
    /// </summary>
    /// <param name="text">The annotation text.</param>
    /// <returns>A new Annotation instance.</returns>
    public static Annotation Create(string text)
    {
        return new Annotation(text);
    }

    /// <summary>
    /// Creates an annotation with text and author string.
    /// </summary>
    /// <param name="text">The annotation text.</param>
    /// <param name="author">The author name.</param>
    /// <returns>A new Annotation instance.</returns>
    public static Annotation ByAuthor(string text, string author)
    {
        return new Annotation(text, author);
    }

    /// <summary>
    /// Creates an annotation with text and author reference.
    /// </summary>
    /// <param name="text">The annotation text.</param>
    /// <param name="authorReference">The author reference.</param>
    /// <returns>A new Annotation instance.</returns>
    public static Annotation ByAuthor(string text, Reference<Resource> authorReference)
    {
        return new Annotation(text, authorReference);
    }

    /// <summary>
    /// Sets the time when the annotation was made.
    /// </summary>
    /// <param name="time">The annotation time.</param>
    /// <returns>This Annotation instance for method chaining.</returns>
    public Annotation AtTime(FhirDateTime time)
    {
        Time = time;
        return this;
    }

    /// <summary>
    /// Sets the time when the annotation was made.
    /// </summary>
    /// <param name="time">The annotation time as string.</param>
    /// <returns>This Annotation instance for method chaining.</returns>
    public Annotation AtTime(string time)
    {
        Time = new FhirDateTime(time);
        return this;
    }

    /// <summary>
    /// Validates the Annotation according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // Text is required
        if (Text == null || string.IsNullOrEmpty(Text.Value))
        {
            yield return new ValidationResult(
                "Annotation.text is required",
                new[] { nameof(Text) });
        }
    }

    protected override string? GetComplexTypeString()
    {
        var author = AuthorString?.Value ?? AuthorReference?.Display?.Value ?? "unknown";
        var timeStr = Time?.Value ?? "unknown time";
        return $"Annotation by {author} at {timeStr}: {Text?.Value}";
    }
}
