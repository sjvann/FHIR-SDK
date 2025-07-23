// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Meta Type: The metadata about a resource. This is content in the resource that is maintained by the
/// infrastructure. Changes to the content might not always be associated with version changes to the
/// resource.
/// </summary>
public class Meta : DataType
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
    /// The version specific identifier, as it appears in the version portion of the URL. This value changes
    /// when the resource is created, updated, or deleted.
    /// </summary>
    [FhirElement("versionId", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("versionId")]
    public FhirId? VersionId { get; set; }

    /// <summary>
    /// When the resource last changed - e.g. when the version changed.
    /// </summary>
    [FhirElement("lastUpdated", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("lastUpdated")]
    public FhirInstant? LastUpdated { get; set; }

    /// <summary>
    /// A uri that identifies the source system of the resource. This provides a minimal amount of
    /// [Provenance](provenance.html#) information that can be used to track or differentiate the source of
    /// information in the resource. The source may identify another FHIR server, document, message,
    /// database, etc.
    /// </summary>
    [FhirElement("source", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("source")]
    public FhirUri? Source { get; set; }

    /// <summary>
    /// A list of profiles (references to [StructureDefinition](structuredefinition.html#) resources) that
    /// this resource claims to conform to. The URL is a reference to
    /// [StructureDefinition.url](structuredefinition-definitions.html#StructureDefinition.url).
    /// </summary>
    [FhirElement("profile", Order = 15)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("profile")]
    public List<FhirCanonical>? Profile { get; set; }

    /// <summary>
    /// Security labels applied to this resource. These tags connect specific resources to the overall
    /// security policy and infrastructure.
    /// </summary>
    [FhirElement("security", Order = 16)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("security")]
    public List<Coding>? Security { get; set; }

    /// <summary>
    /// Tags applied to this resource. Tags are intended to be used to identify and relate resources to
    /// process and workflow, and applications are not required to consider the tags when interpreting the
    /// meaning of a resource.
    /// </summary>
    [FhirElement("tag", Order = 17)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("tag")]
    public List<Coding>? Tag { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Meta cardinality
        var metaCount = Meta?.Count ?? 0;
        if (metaCount < 0)
        {
            yield return new ValidationResult("Element 'Meta' cardinality must be 0..*", new[] { nameof(Meta) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Meta.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate Profile cardinality
        var profileCount = Profile?.Count ?? 0;
        if (profileCount < 0)
        {
            yield return new ValidationResult("Element 'Meta.profile' cardinality must be 0..*", new[] { nameof(Profile) });
        }
        // Validate Security cardinality
        var securityCount = Security?.Count ?? 0;
        if (securityCount < 0)
        {
            yield return new ValidationResult("Element 'Meta.security' cardinality must be 0..*", new[] { nameof(Security) });
        }
        // Validate Tag cardinality
        var tagCount = Tag?.Count ?? 0;
        if (tagCount < 0)
        {
            yield return new ValidationResult("Element 'Meta.tag' cardinality must be 0..*", new[] { nameof(Tag) });
        }

        // ValueSet binding validation
        // Validate Security ValueSet binding
        if (Security != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/security-labels
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(VersionId) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(LastUpdated) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Source) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Profile) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Security) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Tag) });
        // }
    }

}
