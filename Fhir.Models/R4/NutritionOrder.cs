// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A request to supply a diet, formula feeding, or oral nutritional supplement to a patient/resident
/// </summary>
public class NutritionOrder : SimpleDomainResource
{
    /// <summary>
    /// Identifiers assigned to this order
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// draft | active | on-hold | revoked | completed | entered-in-error | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The person who requires the diet, formula or supplement
    /// </summary>
    [JsonPropertyName("patient")]
    public SimpleReference? Patient { get; set; }

    /// <summary>
    /// Date and time the nutrition order was requested
    /// </summary>
    [JsonPropertyName("dateTime")]
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// Who ordered the diet, formula or supplement
    /// </summary>
    [JsonPropertyName("orderer")]
    public SimpleReference? Orderer { get; set; }

    /// <summary>
    /// Comments
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "NutritionOrder";

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
