// <auto-generated />
// FHIR R4 Resource: DocumentReference
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// A reference to a document of any kind for any purpose. Provides metadata about the document so that the document can be discovered and managed. The scope of a document is any seralized object with a mime-type, so includes formal patient centric documents (CDA), cliical notes, scanned paper, and non-patient specific documents like policy text.
/// </summary>
public class DocumentReference : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "DocumentReference";

    /// <summary>
    /// Master Version Specific Identifier
    /// </summary>
    [JsonPropertyName("masterIdentifier")]
    public Identifier MasterIdentifier { get; set; }

    /// <summary>
    /// Other identifiers for the document
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// current | superseded | entered-in-error
    /// </summary>
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// preliminary | final | amended | entered-in-error
    /// </summary>
    [JsonPropertyName("docStatus")]
    public FhirCode DocStatus { get; set; }

    /// <summary>
    /// Kind of document (LOINC if possible)
    /// </summary>
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// Categorization of document
    /// </summary>
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// Who/what is the subject of the document
    /// </summary>
    [JsonPropertyName("subject")]
    public Reference Subject { get; set; }

    /// <summary>
    /// When this document reference was created
    /// </summary>
    [JsonPropertyName("date")]
    public FhirInstant Date { get; set; }

    /// <summary>
    /// Who and/or what authored the document
    /// </summary>
    [JsonPropertyName("author")]
    public List<Reference>? Author { get; set; }

    /// <summary>
    /// Who/what authenticated the document
    /// </summary>
    [JsonPropertyName("authenticator")]
    public Reference Authenticator { get; set; }

    /// <summary>
    /// Organization which maintains the document
    /// </summary>
    [JsonPropertyName("custodian")]
    public Reference Custodian { get; set; }

    /// <summary>
    /// Relationships to other documents
    /// </summary>
    [JsonPropertyName("relatesTo")]
    public List<BackboneElement>? RelatesTo { get; set; }

    /// <summary>
    /// replaces | transforms | signs | appends
    /// </summary>
    [Required]
    [JsonPropertyName("code")]
    public FhirCode CodeValue { get; set; }

    /// <summary>
    /// Target of the relationship
    /// </summary>
    [Required]
    [JsonPropertyName("target")]
    public Reference Target { get; set; }

    /// <summary>
    /// Human-readable description
    /// </summary>
    [JsonPropertyName("description")]
    public FhirString Description { get; set; }

    /// <summary>
    /// Document security-tags
    /// </summary>
    [JsonPropertyName("securityLabel")]
    public List<CodeableConcept>? SecurityLabel { get; set; }

    /// <summary>
    /// Document referenced
    /// </summary>
    [Required]
    [JsonPropertyName("content")]
    public List<BackboneElement> Content { get; set; }

    /// <summary>
    /// Where to access the document
    /// </summary>
    [Required]
    [JsonPropertyName("attachment")]
    public Attachment AttachmentValue { get; set; }

    /// <summary>
    /// Format/content rules for the document
    /// </summary>
    [JsonPropertyName("format")]
    public Coding Format { get; set; }

    /// <summary>
    /// Clinical context of document
    /// </summary>
    [JsonPropertyName("context")]
    public BackboneElement Context { get; set; }

    /// <summary>
    /// Context of the document  content
    /// </summary>
    [JsonPropertyName("encounter")]
    public List<Reference>? Encounter { get; set; }

    /// <summary>
    /// Main clinical acts documented
    /// </summary>
    [JsonPropertyName("event")]
    public List<CodeableConcept>? Event { get; set; }

    /// <summary>
    /// Time of service that is being documented
    /// </summary>
    [JsonPropertyName("period")]
    public Period PeriodValue { get; set; }

    /// <summary>
    /// Kind of facility where patient was seen
    /// </summary>
    [JsonPropertyName("facilityType")]
    public CodeableConcept FacilityType { get; set; }

    /// <summary>
    /// Additional details about where the content was created (e.g. clinical specialty)
    /// </summary>
    [JsonPropertyName("practiceSetting")]
    public CodeableConcept PracticeSetting { get; set; }

    /// <summary>
    /// Patient demographics from source
    /// </summary>
    [JsonPropertyName("sourcePatientInfo")]
    public Reference SourcePatientInfo { get; set; }

    /// <summary>
    /// Related identifiers or resources
    /// </summary>
    [JsonPropertyName("related")]
    public List<Reference>? Related { get; set; }

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
