// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Risk of harmful or undesirable, physiological response which is specific to the individual and associated with exposure to a substance
/// </summary>
public class AllergyIntolerance : SimpleDomainResource
{
    /// <summary>
    /// External ids for this item
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | inactive | resolved
    /// </summary>
    [JsonPropertyName("clinicalStatus")]
    public SimpleCodeableConcept? ClinicalStatus { get; set; }

    /// <summary>
    /// unconfirmed | confirmed | refuted | error
    /// </summary>
    [JsonPropertyName("verificationStatus")]
    public SimpleCodeableConcept? VerificationStatus { get; set; }

    /// <summary>
    /// allergy | intolerance - Underlying mechanism (if known)
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// food | medication | environment | biologic
    /// </summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// low | high | unable-to-assess
    /// </summary>
    [JsonPropertyName("criticality")]
    public string? Criticality { get; set; }

    /// <summary>
    /// Code that identifies the allergy or intolerance
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// Who the sensitivity is for
    /// </summary>
    [JsonPropertyName("patient")]
    public SimpleReference? Patient { get; set; }

    /// <summary>
    /// Encounter when the allergy or intolerance was asserted
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// When allergy or intolerance was identified
    /// </summary>
    [JsonPropertyName("onsetDateTime")]
    public DateTime? OnsetDateTime { get; set; }

    /// <summary>
    /// When allergy or intolerance was identified
    /// </summary>
    [JsonPropertyName("onsetAge")]
    public string? OnsetAge { get; set; }

    /// <summary>
    /// When allergy or intolerance was identified
    /// </summary>
    [JsonPropertyName("onsetPeriod")]
    public SimplePeriod? OnsetPeriod { get; set; }

    /// <summary>
    /// When allergy or intolerance was identified
    /// </summary>
    [JsonPropertyName("onsetRange")]
    public SimpleRange? OnsetRange { get; set; }

    /// <summary>
    /// When allergy or intolerance was identified
    /// </summary>
    [JsonPropertyName("onsetString")]
    public string? OnsetString { get; set; }

    /// <summary>
    /// Date record was believed accurate
    /// </summary>
    [JsonPropertyName("recordedDate")]
    public DateTime? RecordedDate { get; set; }

    /// <summary>
    /// Who recorded the sensitivity
    /// </summary>
    [JsonPropertyName("recorder")]
    public SimpleReference? Recorder { get; set; }

    /// <summary>
    /// Source of the information about the allergy
    /// </summary>
    [JsonPropertyName("asserter")]
    public SimpleReference? Asserter { get; set; }

    /// <summary>
    /// Date(/time) of last known occurrence of a reaction
    /// </summary>
    [JsonPropertyName("lastOccurrence")]
    public DateTime? LastOccurrence { get; set; }

    /// <summary>
    /// Additional text not captured in other fields
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// Adverse Reaction Events linked to exposure to substance
    /// </summary>
    [JsonPropertyName("reaction")]
    public SimpleBackboneElement? Reaction { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "AllergyIntolerance";

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
