// <auto-generated />
// FHIR R4 Resource: CareTeam
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// The Care Team includes all the people and organizations who plan to participate in the coordination and delivery of care for a patient.
/// </summary>
public class CareTeam : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "CareTeam";

    /// <summary>
    /// External Ids for this team
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// proposed | active | suspended | inactive | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Type of team
    /// </summary>
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// Name of the team, such as crisis assessment team
    /// </summary>
    [JsonPropertyName("name")]
    public FhirString Name { get; set; }

    /// <summary>
    /// Who care team is for
    /// </summary>
    [JsonPropertyName("subject")]
    public Reference Subject { get; set; }

    /// <summary>
    /// Encounter created as part of
    /// </summary>
    [JsonPropertyName("encounter")]
    public Reference Encounter { get; set; }

    /// <summary>
    /// Time period team covers
    /// </summary>
    [JsonPropertyName("period")]
    public Period PeriodValue { get; set; }

    /// <summary>
    /// Members of the team
    /// </summary>
    [JsonPropertyName("participant")]
    public List<BackboneElement>? Participant { get; set; }

    /// <summary>
    /// Why the care team exists
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public List<CodeableConcept>? ReasonCode { get; set; }

    /// <summary>
    /// Why the care team exists
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public List<Reference>? ReasonReference { get; set; }

    /// <summary>
    /// Organization responsible for the care team
    /// </summary>
    [JsonPropertyName("managingOrganization")]
    public List<Reference>? ManagingOrganization { get; set; }

    /// <summary>
    /// A contact detail for the care team (that applies to all members)
    /// </summary>
    [JsonPropertyName("telecom")]
    public List<ContactPoint>? Telecom { get; set; }

    /// <summary>
    /// Comments made about the CareTeam
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
