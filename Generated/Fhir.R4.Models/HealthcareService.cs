// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// The details of a healthcare service available at a location
/// </summary>
public class HealthcareService : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Whether this HealthcareService record is in active use
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Organization that provides this service
    /// </summary>
    [JsonPropertyName("providedBy")]
    public SimpleReference? ProvidedBy { get; set; }

    /// <summary>
    /// Type of service that may be delivered or performed
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// Description of service as presented to a consumer
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "HealthcareService";

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
