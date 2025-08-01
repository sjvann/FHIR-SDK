// <auto-generated />
// FHIR R4 Resource: Library
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// The Library resource is a general-purpose container for knowledge asset definitions. It can be used to describe and expose existing knowledge assets such as logic libraries and information model descriptions, as well as to describe a collection of knowledge assets.
/// </summary>
public class Library : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "Library";

    /// <summary>
    /// Canonical identifier for this library, represented as a URI (globally unique)
    /// </summary>
    [JsonPropertyName("url")]
    public FhirUri Url { get; set; }

    /// <summary>
    /// Additional identifier for the library
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// Business version of the library
    /// </summary>
    [JsonPropertyName("version")]
    public FhirString Version { get; set; }

    /// <summary>
    /// Name for this library (computer friendly)
    /// </summary>
    [JsonPropertyName("name")]
    public FhirString Name { get; set; }

    /// <summary>
    /// Name for this library (human friendly)
    /// </summary>
    [JsonPropertyName("title")]
    public FhirString Title { get; set; }

    /// <summary>
    /// Subordinate title of the library
    /// </summary>
    [JsonPropertyName("subtitle")]
    public FhirString Subtitle { get; set; }

    /// <summary>
    /// draft | active | retired | unknown
    /// </summary>
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// For testing purposes, not real usage
    /// </summary>
    [JsonPropertyName("experimental")]
    public FhirBoolean Experimental { get; set; }

    /// <summary>
    /// logic-library | model-definition | asset-collection | module-definition
    /// </summary>
    [Required]
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// Date last changed
    /// </summary>
    [JsonPropertyName("date")]
    public FhirDateTime Date { get; set; }

    /// <summary>
    /// Name of the publisher (organization or individual)
    /// </summary>
    [JsonPropertyName("publisher")]
    public FhirString Publisher { get; set; }

    /// <summary>
    /// Contact details for the publisher
    /// </summary>
    [JsonPropertyName("contact")]
    public List<ContactDetail>? Contact { get; set; }

    /// <summary>
    /// Natural language description of the library
    /// </summary>
    [JsonPropertyName("description")]
    public FhirMarkdown Description { get; set; }

    /// <summary>
    /// The context that the content is intended to support
    /// </summary>
    [JsonPropertyName("useContext")]
    public List<UsageContext>? UseContext { get; set; }

    /// <summary>
    /// Intended jurisdiction for library (if applicable)
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public List<CodeableConcept>? Jurisdiction { get; set; }

    /// <summary>
    /// Why this library is defined
    /// </summary>
    [JsonPropertyName("purpose")]
    public FhirMarkdown Purpose { get; set; }

    /// <summary>
    /// Describes the clinical usage of the library
    /// </summary>
    [JsonPropertyName("usage")]
    public FhirString Usage { get; set; }

    /// <summary>
    /// Use and/or publishing restrictions
    /// </summary>
    [JsonPropertyName("copyright")]
    public FhirMarkdown Copyright { get; set; }

    /// <summary>
    /// When the library was approved by publisher
    /// </summary>
    [JsonPropertyName("approvalDate")]
    public FhirDate ApprovalDate { get; set; }

    /// <summary>
    /// When the library was last reviewed
    /// </summary>
    [JsonPropertyName("lastReviewDate")]
    public FhirDate LastReviewDate { get; set; }

    /// <summary>
    /// When the library is expected to be used
    /// </summary>
    [JsonPropertyName("effectivePeriod")]
    public Period EffectivePeriod { get; set; }

    /// <summary>
    /// E.g. Education, Treatment, Assessment, etc.
    /// </summary>
    [JsonPropertyName("topic")]
    public List<CodeableConcept>? Topic { get; set; }

    /// <summary>
    /// Who authored the content
    /// </summary>
    [JsonPropertyName("author")]
    public List<ContactDetail>? Author { get; set; }

    /// <summary>
    /// Who edited the content
    /// </summary>
    [JsonPropertyName("editor")]
    public List<ContactDetail>? Editor { get; set; }

    /// <summary>
    /// Who reviewed the content
    /// </summary>
    [JsonPropertyName("reviewer")]
    public List<ContactDetail>? Reviewer { get; set; }

    /// <summary>
    /// Who endorsed the content
    /// </summary>
    [JsonPropertyName("endorser")]
    public List<ContactDetail>? Endorser { get; set; }

    /// <summary>
    /// Additional documentation, citations, etc.
    /// </summary>
    [JsonPropertyName("relatedArtifact")]
    public List<RelatedArtifact>? RelatedArtifactValue { get; set; }

    /// <summary>
    /// Parameters defined by the library
    /// </summary>
    [JsonPropertyName("parameter")]
    public List<ParameterDefinition>? Parameter { get; set; }

    /// <summary>
    /// What data is referenced by this library
    /// </summary>
    [JsonPropertyName("dataRequirement")]
    public List<DataRequirement>? DataRequirementValue { get; set; }

    /// <summary>
    /// Contents of the library, either embedded or referenced
    /// </summary>
    [JsonPropertyName("content")]
    public List<Attachment>? Content { get; set; }

    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // TODO: Add specific validation rules
    }

}
