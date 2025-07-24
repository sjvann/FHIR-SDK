// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A clinical assessment performed when planning treatments and management strategies for a patient
/// </summary>
public class ClinicalImpression : SimpleDomainResource
{
    /// <summary>
    /// Business identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// in-progress | completed | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Patient or group assessed
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// When the assessment was made
    /// </summary>
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Who did assessment
    /// </summary>
    [JsonPropertyName("assessor")]
    public SimpleReference? Assessor { get; set; }

    /// <summary>
    /// Summary of the assessment
    /// </summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// Possible or likely findings
    /// </summary>
    [JsonPropertyName("finding")]
    public SimpleBackboneElement? Finding { get; set; }

    /// <summary>
    /// Comments about the assessment
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "ClinicalImpression";

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
