// <auto-generated />
// FHIR R4 Resource: PractitionerRole
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// A specific set of Roles/Locations/specialties/services that a practitioner may perform at an organization for a period of time.
/// </summary>
public class PractitionerRole : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "PractitionerRole";

    /// <summary>
    /// Business Identifiers that are specific to a role/location
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// Whether this practitioner role record is in active use
    /// </summary>
    [JsonPropertyName("active")]
    public FhirBoolean Active { get; set; }

    /// <summary>
    /// The period during which the practitioner is authorized to perform in these role(s)
    /// </summary>
    [JsonPropertyName("period")]
    public Period PeriodValue { get; set; }

    /// <summary>
    /// Practitioner that is able to provide the defined services for the organization
    /// </summary>
    [JsonPropertyName("practitioner")]
    public Reference Practitioner { get; set; }

    /// <summary>
    /// Organization where the roles are available
    /// </summary>
    [JsonPropertyName("organization")]
    public Reference Organization { get; set; }

    /// <summary>
    /// Roles which this practitioner may perform
    /// </summary>
    [JsonPropertyName("code")]
    public List<CodeableConcept>? Code { get; set; }

    /// <summary>
    /// Specific specialty of the practitioner
    /// </summary>
    [JsonPropertyName("specialty")]
    public List<CodeableConcept>? Specialty { get; set; }

    /// <summary>
    /// The location(s) at which this practitioner provides care
    /// </summary>
    [JsonPropertyName("location")]
    public List<Reference>? Location { get; set; }

    /// <summary>
    /// The list of healthcare services that this worker provides for this role&apos;s Organization/Location(s)
    /// </summary>
    [JsonPropertyName("healthcareService")]
    public List<Reference>? HealthcareService { get; set; }

    /// <summary>
    /// Contact details that are specific to the role/location/service
    /// </summary>
    [JsonPropertyName("telecom")]
    public List<ContactPoint>? Telecom { get; set; }

    /// <summary>
    /// Times the Service Site is available
    /// </summary>
    [JsonPropertyName("availableTime")]
    public List<BackboneElement>? AvailableTime { get; set; }

    /// <summary>
    /// mon | tue | wed | thu | fri | sat | sun
    /// </summary>
    [JsonPropertyName("daysOfWeek")]
    public List<FhirCode>? DaysOfWeek { get; set; }

    /// <summary>
    /// Always available? e.g. 24 hour service
    /// </summary>
    [JsonPropertyName("allDay")]
    public FhirBoolean AllDay { get; set; }

    /// <summary>
    /// Opening time of day (ignored if allDay = true)
    /// </summary>
    [JsonPropertyName("availableStartTime")]
    public FhirTime AvailableStartTime { get; set; }

    /// <summary>
    /// Closing time of day (ignored if allDay = true)
    /// </summary>
    [JsonPropertyName("availableEndTime")]
    public FhirTime AvailableEndTime { get; set; }

    /// <summary>
    /// Not available during this time due to provided reason
    /// </summary>
    [JsonPropertyName("notAvailable")]
    public List<BackboneElement>? NotAvailable { get; set; }

    /// <summary>
    /// Reason presented to the user explaining why time not available
    /// </summary>
    [Required]
    [JsonPropertyName("description")]
    public FhirString Description { get; set; }

    /// <summary>
    /// Service not available from this date
    /// </summary>
    [JsonPropertyName("during")]
    public Period During { get; set; }

    /// <summary>
    /// Description of availability exceptions
    /// </summary>
    [JsonPropertyName("availabilityExceptions")]
    public FhirString AvailabilityExceptions { get; set; }

    /// <summary>
    /// Technical endpoints providing access to services operated for the practitioner with this role
    /// </summary>
    [JsonPropertyName("endpoint")]
    public List<Reference>? Endpoint { get; set; }

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
