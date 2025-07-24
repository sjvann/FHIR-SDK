// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Dispensing a medication to a patient
/// </summary>
public class MedicationDispense : SimpleDomainResource
{
    /// <summary>
    /// External identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// preparation | in-progress | cancelled | on-hold | completed | entered-in-error | stopped | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// What medication was supplied
    /// </summary>
    [JsonPropertyName("medicationCodeableConcept")]
    public SimpleCodeableConcept? MedicationCodeableConcept { get; set; }

    /// <summary>
    /// Who the dispense is for
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Who performed the dispense
    /// </summary>
    [JsonPropertyName("performer")]
    public SimpleBackboneElement? Performer { get; set; }

    /// <summary>
    /// When product was given out
    /// </summary>
    [JsonPropertyName("whenHandedOver")]
    public DateTime? WhenHandedOver { get; set; }

    /// <summary>
    /// Notes about the dispense
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "MedicationDispense";

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
