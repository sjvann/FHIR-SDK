// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Describes a measurement, calculation or setting capability of a medical device
/// </summary>
public class DeviceMetric : SimpleDomainResource
{
    /// <summary>
    /// Unique identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Describes the type of the metric
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// Unit of Measure for the Metric
    /// </summary>
    [JsonPropertyName("unit")]
    public SimpleCodeableConcept? Unit { get; set; }

    /// <summary>
    /// Describes the link to the source Device
    /// </summary>
    [JsonPropertyName("source")]
    public SimpleReference? Source { get; set; }

    /// <summary>
    /// Describes the link to the parent Device
    /// </summary>
    [JsonPropertyName("parent")]
    public SimpleReference? Parent { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "DeviceMetric";

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
