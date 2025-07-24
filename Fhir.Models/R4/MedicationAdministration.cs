// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Administration of medication to a patient
/// </summary>
public class MedicationAdministration : SimpleDomainResource
{
    /// <summary>
    /// External identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// in-progress | not-done | on-hold | completed | entered-in-error | stopped | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// What was administered
    /// </summary>
    [JsonPropertyName("medicationCodeableConcept")]
    public SimpleCodeableConcept? MedicationCodeableConcept { get; set; }

    /// <summary>
    /// Who received medication
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Start and end time of administration
    /// </summary>
    [JsonPropertyName("effectiveDateTime")]
    public DateTime? EffectiveDateTime { get; set; }

    /// <summary>
    /// Who performed the administration
    /// </summary>
    [JsonPropertyName("performer")]
    public SimpleBackboneElement? Performer { get; set; }

    /// <summary>
    /// Notes about the administration
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "MedicationAdministration";

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
