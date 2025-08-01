// <auto-generated />
// FHIR R4 Resource: Contract
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// Legally enforceable, formally recorded unilateral or bilateral directive i.e., a policy or agreement.
/// </summary>
public class Contract : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "Contract";

    /// <summary>
    /// Contract number
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// Basal definition
    /// </summary>
    [JsonPropertyName("url")]
    public FhirUri Url { get; set; }

    /// <summary>
    /// Business edition
    /// </summary>
    [JsonPropertyName("version")]
    public FhirString Version { get; set; }

    /// <summary>
    /// amended | appended | cancelled | disputed | entered-in-error | executable | executed | negotiable | offered | policy | rejected | renewed | revoked | resolved | terminated
    /// </summary>
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Negotiation status
    /// </summary>
    [JsonPropertyName("legalState")]
    public CodeableConcept LegalState { get; set; }

    /// <summary>
    /// Source Contract Definition
    /// </summary>
    [JsonPropertyName("instantiatesCanonical")]
    public Reference InstantiatesCanonical { get; set; }

    /// <summary>
    /// External Contract Definition
    /// </summary>
    [JsonPropertyName("instantiatesUri")]
    public FhirUri InstantiatesUri { get; set; }

    /// <summary>
    /// Content derived from the basal information
    /// </summary>
    [JsonPropertyName("contentDerivative")]
    public CodeableConcept ContentDerivative { get; set; }

    /// <summary>
    /// When this Contract was issued
    /// </summary>
    [JsonPropertyName("issued")]
    public FhirDateTime Issued { get; set; }

    /// <summary>
    /// Effective time
    /// </summary>
    [JsonPropertyName("applies")]
    public Period Applies { get; set; }

    /// <summary>
    /// Contract cessation cause
    /// </summary>
    [JsonPropertyName("expirationType")]
    public CodeableConcept ExpirationType { get; set; }

    /// <summary>
    /// Contract Target Entity
    /// </summary>
    [JsonPropertyName("subject")]
    public List<Reference>? Subject { get; set; }

    /// <summary>
    /// Authority under which this Contract has standing
    /// </summary>
    [JsonPropertyName("authority")]
    public List<Reference>? Authority { get; set; }

    /// <summary>
    /// A sphere of control governed by an authoritative jurisdiction, organization, or person
    /// </summary>
    [JsonPropertyName("domain")]
    public List<Reference>? Domain { get; set; }

    /// <summary>
    /// Specific Location
    /// </summary>
    [JsonPropertyName("site")]
    public List<Reference>? Site { get; set; }

    /// <summary>
    /// Computer friendly designation
    /// </summary>
    [JsonPropertyName("name")]
    public FhirString Name { get; set; }

    /// <summary>
    /// Human Friendly name
    /// </summary>
    [JsonPropertyName("title")]
    public FhirString Title { get; set; }

    /// <summary>
    /// Subordinate Friendly name
    /// </summary>
    [JsonPropertyName("subtitle")]
    public FhirString Subtitle { get; set; }

    /// <summary>
    /// Acronym or short name
    /// </summary>
    [JsonPropertyName("alias")]
    public List<FhirString>? Alias { get; set; }

    /// <summary>
    /// Source of Contract
    /// </summary>
    [JsonPropertyName("author")]
    public Reference Author { get; set; }

    /// <summary>
    /// Range of Legal Concerns
    /// </summary>
    [JsonPropertyName("scope")]
    public CodeableConcept Scope { get; set; }

    /// <summary>
    /// Legal instrument category
    /// </summary>
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// Subtype within the context of type
    /// </summary>
    [JsonPropertyName("subType")]
    public List<CodeableConcept>? SubType { get; set; }

    /// <summary>
    /// Contract precursor content
    /// </summary>
    [JsonPropertyName("contentDefinition")]
    public BackboneElement ContentDefinition { get; set; }

    /// <summary>
    /// Content structure and use
    /// </summary>
    [Required]
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// Detailed Content Type Definition
    /// </summary>
    [JsonPropertyName("subType")]
    public CodeableConcept SubType { get; set; }

    /// <summary>
    /// Publisher Entity
    /// </summary>
    [JsonPropertyName("publisher")]
    public Reference Publisher { get; set; }

    /// <summary>
    /// When published
    /// </summary>
    [JsonPropertyName("publicationDate")]
    public FhirDateTime PublicationDate { get; set; }

    /// <summary>
    /// amended | appended | cancelled | disputed | entered-in-error | executable | executed | negotiable | offered | policy | rejected | renewed | revoked | resolved | terminated
    /// </summary>
    [Required]
    [JsonPropertyName("publicationStatus")]
    public FhirCode PublicationStatus { get; set; }

    /// <summary>
    /// Publication Ownership
    /// </summary>
    [JsonPropertyName("copyright")]
    public FhirMarkdown Copyright { get; set; }

    /// <summary>
    /// Contract Term List
    /// </summary>
    [JsonPropertyName("term")]
    public List<BackboneElement>? Term { get; set; }

    /// <summary>
    /// Contract Term Number
    /// </summary>
    [JsonPropertyName("identifier")]
    public Identifier IdentifierValue { get; set; }

    /// <summary>
    /// Contract Term Issue Date Time
    /// </summary>
    [JsonPropertyName("issued")]
    public FhirDateTime Issued { get; set; }

    /// <summary>
    /// Contract Term Effective Time
    /// </summary>
    [JsonPropertyName("applies")]
    public Period Applies { get; set; }

    /// <summary>
    /// Contract Term Type or Form
    /// </summary>
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// Contract Term Type specific classification
    /// </summary>
    [JsonPropertyName("subType")]
    public CodeableConcept SubType { get; set; }

    /// <summary>
    /// Protection for the Term
    /// </summary>
    [JsonPropertyName("securityLabel")]
    public List<BackboneElement>? SecurityLabel { get; set; }

    /// <summary>
    /// Context of the Contract term
    /// </summary>
    [Required]
    [JsonPropertyName("offer")]
    public BackboneElement Offer { get; set; }

    /// <summary>
    /// Contract Term Asset List
    /// </summary>
    [JsonPropertyName("asset")]
    public List<BackboneElement>? Asset { get; set; }

    /// <summary>
    /// Entity being ascribed responsibility
    /// </summary>
    [JsonPropertyName("action")]
    public List<BackboneElement>? Action { get; set; }

    /// <summary>
    /// Nested Contract Term Group
    /// </summary>
    [JsonPropertyName("group")]
    public List<>? Group { get; set; }

    /// <summary>
    /// Extra Information
    /// </summary>
    [JsonPropertyName("supportingInfo")]
    public List<Reference>? SupportingInfo { get; set; }

    /// <summary>
    /// Key event in Contract History
    /// </summary>
    [JsonPropertyName("relevantHistory")]
    public List<Reference>? RelevantHistory { get; set; }

    /// <summary>
    /// Contract Signatory
    /// </summary>
    [JsonPropertyName("signer")]
    public List<BackboneElement>? Signer { get; set; }

    /// <summary>
    /// Contract Signatory Role
    /// </summary>
    [Required]
    [JsonPropertyName("type")]
    public Coding Type { get; set; }

    /// <summary>
    /// Contract Signatory Party
    /// </summary>
    [Required]
    [JsonPropertyName("party")]
    public Reference Party { get; set; }

    /// <summary>
    /// Contract Documentation Signature
    /// </summary>
    [Required]
    [JsonPropertyName("signature")]
    public List<Signature> SignatureValue { get; set; }

    /// <summary>
    /// Contract Friendly Language
    /// </summary>
    [JsonPropertyName("friendly")]
    public List<BackboneElement>? Friendly { get; set; }

    /// <summary>
    /// Contract Legal Language
    /// </summary>
    [JsonPropertyName("legal")]
    public List<BackboneElement>? Legal { get; set; }

    /// <summary>
    /// Computable Contract Language
    /// </summary>
    [JsonPropertyName("rule")]
    public List<BackboneElement>? Rule { get; set; }

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
