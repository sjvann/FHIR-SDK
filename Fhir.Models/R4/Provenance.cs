// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Provenance of a resource
/// </summary>
public class Provenance : SimpleDomainResource
{
    /// <summary>
    /// Target Reference(s)
    /// </summary>
    [JsonPropertyName("target")]
    public SimpleReference? Target { get; set; }

    /// <summary>
    /// When the activity occurred
    /// </summary>
    [JsonPropertyName("occurredPeriod")]
    public SimplePeriod? OccurredPeriod { get; set; }

    /// <summary>
    /// When the activity was recorded/updated
    /// </summary>
    [JsonPropertyName("recorded")]
    public DateTime? Recorded { get; set; }

    /// <summary>
    /// Policy or plan the activity was defined by
    /// </summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>
    /// Where the activity occurred, if relevant
    /// </summary>
    [JsonPropertyName("location")]
    public SimpleReference? Location { get; set; }

    /// <summary>
    /// Reason the activity was performed
    /// </summary>
    [JsonPropertyName("reason")]
    public SimpleCodeableConcept? Reason { get; set; }

    /// <summary>
    /// Activity that took place
    /// </summary>
    [JsonPropertyName("activity")]
    public SimpleCodeableConcept? Activity { get; set; }

    /// <summary>
    /// Actor involved
    /// </summary>
    [JsonPropertyName("agent")]
    public SimpleBackboneElement? Agent { get; set; }

    /// <summary>
    /// An entity used in this activity
    /// </summary>
    [JsonPropertyName("entity")]
    public SimpleBackboneElement? Entity { get; set; }

    /// <summary>
    /// Signature on target
    /// </summary>
    [JsonPropertyName("signature")]
    public string? Signature { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Provenance";

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
