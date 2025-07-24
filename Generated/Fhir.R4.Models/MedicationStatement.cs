// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Record of medication being taken by a patient
/// </summary>
public class MedicationStatement : SimpleDomainResource
{
    /// <summary>
    /// External identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | completed | entered-in-error | intended | stopped | on-hold | unknown | not-taken
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// What medication was taken
    /// </summary>
    [JsonPropertyName("medicationCodeableConcept")]
    public SimpleCodeableConcept? MedicationCodeableConcept { get; set; }

    /// <summary>
    /// Who is/was taking the medication
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// The date/time or interval when the medication is/was/will be taken
    /// </summary>
    [JsonPropertyName("effectiveDateTime")]
    public DateTime? EffectiveDateTime { get; set; }

    /// <summary>
    /// Notes about the statement
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "MedicationStatement";

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
