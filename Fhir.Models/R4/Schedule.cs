// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A container for slots of time that may be available for booking appointments
/// </summary>
public class Schedule : SimpleDomainResource
{
    /// <summary>
    /// External Ids for this item
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Whether this schedule is in active use
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// A broad categorization of the service
    /// </summary>
    [JsonPropertyName("serviceCategory")]
    public SimpleCodeableConcept? ServiceCategory { get; set; }

    /// <summary>
    /// The specific service that is to be performed
    /// </summary>
    [JsonPropertyName("serviceType")]
    public SimpleCodeableConcept? ServiceType { get; set; }

    /// <summary>
    /// The specialty of a practitioner
    /// </summary>
    [JsonPropertyName("specialty")]
    public SimpleCodeableConcept? Specialty { get; set; }

    /// <summary>
    /// The resource this Schedule resource is providing availability information for
    /// </summary>
    [JsonPropertyName("actor")]
    public SimpleReference? Actor { get; set; }

    /// <summary>
    /// The period of time that the slots that are attached to this Schedule resource cover
    /// </summary>
    [JsonPropertyName("planningHorizon")]
    public SimplePeriod? PlanningHorizon { get; set; }

    /// <summary>
    /// Comments on the availability
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Schedule";

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
