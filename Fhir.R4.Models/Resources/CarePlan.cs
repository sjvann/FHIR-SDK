// <auto-generated />
// FHIR R4 Resource: CarePlan
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// Describes the intention of how one or more practitioners intend to deliver care for a particular patient, group or community for a period of time, possibly limited to care for a specific condition or set of conditions.
/// </summary>
public class CarePlan : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "CarePlan";

    /// <summary>
    /// External Ids for this plan
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// Instantiates FHIR protocol or definition
    /// </summary>
    [JsonPropertyName("instantiatesCanonical")]
    public List<FhirCanonical>? InstantiatesCanonical { get; set; }

    /// <summary>
    /// Instantiates external protocol or definition
    /// </summary>
    [JsonPropertyName("instantiatesUri")]
    public List<FhirUri>? InstantiatesUri { get; set; }

    /// <summary>
    /// Fulfills CarePlan
    /// </summary>
    [JsonPropertyName("basedOn")]
    public List<Reference>? BasedOn { get; set; }

    /// <summary>
    /// CarePlan replaced by this CarePlan
    /// </summary>
    [JsonPropertyName("replaces")]
    public List<Reference>? Replaces { get; set; }

    /// <summary>
    /// Part of referenced CarePlan
    /// </summary>
    [JsonPropertyName("partOf")]
    public List<Reference>? PartOf { get; set; }

    /// <summary>
    /// draft | active | on-hold | revoked | completed | entered-in-error | unknown
    /// </summary>
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// proposal | plan | order | option
    /// </summary>
    [Required]
    [JsonPropertyName("intent")]
    public FhirCode Intent { get; set; }

    /// <summary>
    /// Type of plan
    /// </summary>
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// Human-friendly name for the care plan
    /// </summary>
    [JsonPropertyName("title")]
    public FhirString Title { get; set; }

    /// <summary>
    /// Summary of nature of plan
    /// </summary>
    [JsonPropertyName("description")]
    public FhirString Description { get; set; }

    /// <summary>
    /// Who the care plan is for
    /// </summary>
    [Required]
    [JsonPropertyName("subject")]
    public Reference Subject { get; set; }

    /// <summary>
    /// Encounter created as part of
    /// </summary>
    [JsonPropertyName("encounter")]
    public Reference Encounter { get; set; }

    /// <summary>
    /// Time period plan covers
    /// </summary>
    [JsonPropertyName("period")]
    public Period PeriodValue { get; set; }

    /// <summary>
    /// Date record was first recorded
    /// </summary>
    [JsonPropertyName("created")]
    public FhirDateTime Created { get; set; }

    /// <summary>
    /// Who is the designated responsible party
    /// </summary>
    [JsonPropertyName("author")]
    public Reference Author { get; set; }

    /// <summary>
    /// Who provided the content of the care plan
    /// </summary>
    [JsonPropertyName("contributor")]
    public List<Reference>? Contributor { get; set; }

    /// <summary>
    /// Who&apos;s involved in plan?
    /// </summary>
    [JsonPropertyName("careTeam")]
    public List<Reference>? CareTeam { get; set; }

    /// <summary>
    /// Health issues this plan addresses
    /// </summary>
    [JsonPropertyName("addresses")]
    public List<Reference>? Addresses { get; set; }

    /// <summary>
    /// Information considered as part of plan
    /// </summary>
    [JsonPropertyName("supportingInfo")]
    public List<Reference>? SupportingInfo { get; set; }

    /// <summary>
    /// Desired outcome of plan
    /// </summary>
    [JsonPropertyName("goal")]
    public List<Reference>? Goal { get; set; }

    /// <summary>
    /// Action to occur as part of plan
    /// </summary>
    [JsonPropertyName("activity")]
    public List<BackboneElement>? Activity { get; set; }

    /// <summary>
    /// Results of the activity
    /// </summary>
    [JsonPropertyName("outcomeCodeableConcept")]
    public List<CodeableConcept>? OutcomeCodeableConcept { get; set; }

    /// <summary>
    /// Appointment, Encounter, Procedure, etc.
    /// </summary>
    [JsonPropertyName("outcomeReference")]
    public List<Reference>? OutcomeReference { get; set; }

    /// <summary>
    /// Comments about the activity status/progress
    /// </summary>
    [JsonPropertyName("progress")]
    public List<Annotation>? Progress { get; set; }

    /// <summary>
    /// Activity details defined in specific resource
    /// </summary>
    [JsonPropertyName("reference")]
    public Reference ReferenceValue { get; set; }

    /// <summary>
    /// In-line definition of activity
    /// </summary>
    [JsonPropertyName("detail")]
    public BackboneElement Detail { get; set; }

    /// <summary>
    /// Comments about the plan
    /// </summary>
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

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
