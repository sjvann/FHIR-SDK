// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A specific set of Roles/Locations/specialties/services that a practitioner may perform at an organization for a period of time
/// </summary>
public class PractitionerRole : SimpleDomainResource
{
    /// <summary>
    /// Business Identifiers that are specific to a role/location
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Whether this practitioner role record is in active use
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// The period during which the practitioner is authorized to perform in these role(s)
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// Practitioner that is able to provide the defined services for the organization
    /// </summary>
    [JsonPropertyName("practitioner")]
    public SimpleReference? Practitioner { get; set; }

    /// <summary>
    /// The organization where the Roles are available
    /// </summary>
    [JsonPropertyName("organization")]
    public SimpleReference? Organization { get; set; }

    /// <summary>
    /// Roles which this practitioner is authorized to perform for the organization
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// Specific specialty of the practitioner
    /// </summary>
    [JsonPropertyName("specialty")]
    public SimpleCodeableConcept? Specialty { get; set; }

    /// <summary>
    /// The location(s) at which this practitioner provides care
    /// </summary>
    [JsonPropertyName("location")]
    public SimpleReference? Location { get; set; }

    /// <summary>
    /// The list of healthcare services that this worker provides for this role's Organization/Location(s)
    /// </summary>
    [JsonPropertyName("healthcareService")]
    public SimpleReference? HealthcareService { get; set; }

    /// <summary>
    /// Contact details that are specific to the role/location/service
    /// </summary>
    [JsonPropertyName("telecom")]
    public SimpleContactPoint? Telecom { get; set; }

    /// <summary>
    /// A collection of times the practitioner is available or performing this role at the location and/or healthcareservice
    /// </summary>
    [JsonPropertyName("availableTime")]
    public SimpleBackboneElement? AvailableTime { get; set; }

    /// <summary>
    /// The practitioner is not available or performing this role during this period of time due to the provided reason
    /// </summary>
    [JsonPropertyName("notAvailable")]
    public SimpleBackboneElement? NotAvailable { get; set; }

    /// <summary>
    /// A description of site availability exceptions, e.g. public holiday availability
    /// </summary>
    [JsonPropertyName("availabilityExceptions")]
    public string? AvailabilityExceptions { get; set; }

    /// <summary>
    /// Technical endpoints providing access to services operated for the practitioner with this role
    /// </summary>
    [JsonPropertyName("endpoint")]
    public SimpleReference? Endpoint { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "PractitionerRole";

    /// <summary>
    /// 驗證此實例
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 自訂驗證邏輯
        // 子類別可以覆寫此方法來添加特定的驗證邏輯
    }
}
