// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// An actual or potential clinical issue with or between one or more active or proposed clinical actions for a patient
/// </summary>
public class DetectedIssue : SimpleDomainResource
{
    /// <summary>
    /// Business identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// registered | preliminary | final | amended | corrected | cancelled | entered-in-error | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Associated patient
    /// </summary>
    [JsonPropertyName("patient")]
    public SimpleReference? Patient { get; set; }

    /// <summary>
    /// When identified
    /// </summary>
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// The provider or device that identified the issue
    /// </summary>
    [JsonPropertyName("author")]
    public SimpleReference? Author { get; set; }

    /// <summary>
    /// Problem resource
    /// </summary>
    [JsonPropertyName("implicated")]
    public SimpleReference? Implicated { get; set; }

    /// <summary>
    /// Description and context
    /// </summary>
    [JsonPropertyName("detail")]
    public string? Detail { get; set; }

    /// <summary>
    /// Step taken to address
    /// </summary>
    [JsonPropertyName("mitigation")]
    public SimpleBackboneElement? Mitigation { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "DetectedIssue";

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
