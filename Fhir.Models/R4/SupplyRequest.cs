// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A record of a request for a medication, substance or device used in the healthcare setting
/// </summary>
public class SupplyRequest : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// draft | active | suspended | cancelled | completed | entered-in-error | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Category of supply request
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// routine | urgent | asap | stat
    /// </summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>
    /// Medication, Substance, or Device requested
    /// </summary>
    [JsonPropertyName("itemCodeableConcept")]
    public SimpleCodeableConcept? ItemCodeableConcept { get; set; }

    /// <summary>
    /// When request should be fulfilled
    /// </summary>
    [JsonPropertyName("occurrenceDateTime")]
    public DateTime? OccurrenceDateTime { get; set; }

    /// <summary>
    /// Individual making the request
    /// </summary>
    [JsonPropertyName("requester")]
    public SimpleReference? Requester { get; set; }

    /// <summary>
    /// Why the supply item was requested
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Comments about the request
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "SupplyRequest";

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
