// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A patient's point-in-time set of recommendations (i.e. forecasting, immunization plan) according to a published schedule
/// </summary>
public class ImmunizationRecommendation : SimpleDomainResource
{
    /// <summary>
    /// Business identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Who this profile is for
    /// </summary>
    [JsonPropertyName("patient")]
    public SimpleReference? Patient { get; set; }

    /// <summary>
    /// Date recommendation(s) created
    /// </summary>
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Who is responsible for publishing the recommendations
    /// </summary>
    [JsonPropertyName("authority")]
    public SimpleReference? Authority { get; set; }

    /// <summary>
    /// Vaccine administration recommendations
    /// </summary>
    [JsonPropertyName("recommendation")]
    public SimpleBackboneElement? Recommendation { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "ImmunizationRecommendation";

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
