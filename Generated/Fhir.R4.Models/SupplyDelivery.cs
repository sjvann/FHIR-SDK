// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Record of delivery of what is supplied
/// </summary>
public class SupplyDelivery : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// in-progress | completed | abandoned | entered-in-error | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Patient for whom the item is supplied
    /// </summary>
    [JsonPropertyName("patient")]
    public SimpleReference? Patient { get; set; }

    /// <summary>
    /// Category of dispense event
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// The item that is delivered or supplied
    /// </summary>
    [JsonPropertyName("suppliedItem")]
    public SimpleBackboneElement? SuppliedItem { get; set; }

    /// <summary>
    /// When event occurred
    /// </summary>
    [JsonPropertyName("occurrenceDateTime")]
    public DateTime? OccurrenceDateTime { get; set; }

    /// <summary>
    /// Who performed event
    /// </summary>
    [JsonPropertyName("performer")]
    public SimpleBackboneElement? Performer { get; set; }

    /// <summary>
    /// Where the Supply was sent
    /// </summary>
    [JsonPropertyName("destination")]
    public SimpleReference? Destination { get; set; }

    /// <summary>
    /// Comments about the delivery
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "SupplyDelivery";

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
