// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Details and position information for a physical place where services are provided and resources and participants may be stored, found, contained, or accommodated
/// </summary>
public class Location : SimpleDomainResource
{
    /// <summary>
    /// Unique code or number identifying the location
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | suspended | inactive
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The operational status of the location
    /// </summary>
    [JsonPropertyName("operationalStatus")]
    public SimpleCoding? OperationalStatus { get; set; }

    /// <summary>
    /// Name of the location as used by humans
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A list of alternate names that the location is known as
    /// </summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>
    /// Additional details about the location
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// instance | kind
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Type of function performed
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// Contact details of the location
    /// </summary>
    [JsonPropertyName("telecom")]
    public SimpleContactPoint? Telecom { get; set; }

    /// <summary>
    /// Physical location
    /// </summary>
    [JsonPropertyName("address")]
    public SimpleAddress? Address { get; set; }

    /// <summary>
    /// Physical form of the location
    /// </summary>
    [JsonPropertyName("physicalType")]
    public SimpleCodeableConcept? PhysicalType { get; set; }

    /// <summary>
    /// The absolute geographic location
    /// </summary>
    [JsonPropertyName("position")]
    public SimpleBackboneElement? Position { get; set; }

    /// <summary>
    /// Organization responsible for provisioning and upkeep
    /// </summary>
    [JsonPropertyName("managingOrganization")]
    public SimpleReference? ManagingOrganization { get; set; }

    /// <summary>
    /// Another Location this one is physically part of
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// What days/times during a week is this location usually open
    /// </summary>
    [JsonPropertyName("hoursOfOperation")]
    public SimpleBackboneElement? HoursOfOperation { get; set; }

    /// <summary>
    /// Description of availability exceptions
    /// </summary>
    [JsonPropertyName("availabilityExceptions")]
    public string? AvailabilityExceptions { get; set; }

    /// <summary>
    /// Technical endpoints providing access to services operated for the location
    /// </summary>
    [JsonPropertyName("endpoint")]
    public SimpleReference? Endpoint { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Location";

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
