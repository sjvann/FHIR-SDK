// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A clinical condition, problem, diagnosis, or other event, situation, issue, or clinical concept that has risen to a level of concern
/// </summary>
public class Condition : SimpleDomainResource
{
    /// <summary>
    /// External Ids for this condition
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | recurrence | relapse | inactive | remission | resolved
    /// </summary>
    [JsonPropertyName("clinicalStatus")]
    public SimpleCodeableConcept? ClinicalStatus { get; set; }

    /// <summary>
    /// unconfirmed | provisional | differential | confirmed | refuted | entered-in-error
    /// </summary>
    [JsonPropertyName("verificationStatus")]
    public SimpleCodeableConcept? VerificationStatus { get; set; }

    /// <summary>
    /// problem-list-item | encounter-diagnosis
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// Subjective severity of condition
    /// </summary>
    [JsonPropertyName("severity")]
    public SimpleCodeableConcept? Severity { get; set; }

    /// <summary>
    /// Identification of the condition, problem or diagnosis
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// Anatomical location, if relevant
    /// </summary>
    [JsonPropertyName("bodySite")]
    public SimpleCodeableConcept? BodySite { get; set; }

    /// <summary>
    /// Who has the condition?
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Encounter when condition first asserted
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, or age
    /// </summary>
    [JsonPropertyName("onsetDateTime")]
    public DateTime? OnsetDateTime { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, or age
    /// </summary>
    [JsonPropertyName("onsetAge")]
    public string? OnsetAge { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, or age
    /// </summary>
    [JsonPropertyName("onsetPeriod")]
    public SimplePeriod? OnsetPeriod { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, or age
    /// </summary>
    [JsonPropertyName("onsetRange")]
    public SimpleRange? OnsetRange { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, or age
    /// </summary>
    [JsonPropertyName("onsetString")]
    public string? OnsetString { get; set; }

    /// <summary>
    /// When in resolution/remission
    /// </summary>
    [JsonPropertyName("abatementDateTime")]
    public DateTime? AbatementDateTime { get; set; }

    /// <summary>
    /// When in resolution/remission
    /// </summary>
    [JsonPropertyName("abatementAge")]
    public string? AbatementAge { get; set; }

    /// <summary>
    /// When in resolution/remission
    /// </summary>
    [JsonPropertyName("abatementPeriod")]
    public SimplePeriod? AbatementPeriod { get; set; }

    /// <summary>
    /// When in resolution/remission
    /// </summary>
    [JsonPropertyName("abatementRange")]
    public SimpleRange? AbatementRange { get; set; }

    /// <summary>
    /// When in resolution/remission
    /// </summary>
    [JsonPropertyName("abatementString")]
    public string? AbatementString { get; set; }

    /// <summary>
    /// Date record was first recorded
    /// </summary>
    [JsonPropertyName("recordedDate")]
    public DateTime? RecordedDate { get; set; }

    /// <summary>
    /// Who recorded the condition
    /// </summary>
    [JsonPropertyName("recorder")]
    public SimpleReference? Recorder { get; set; }

    /// <summary>
    /// Person who asserts this condition
    /// </summary>
    [JsonPropertyName("asserter")]
    public SimpleReference? Asserter { get; set; }

    /// <summary>
    /// Stage/grade, usually assessed formally
    /// </summary>
    [JsonPropertyName("stage")]
    public SimpleBackboneElement? Stage { get; set; }

    /// <summary>
    /// Supporting evidence
    /// </summary>
    [JsonPropertyName("evidence")]
    public SimpleBackboneElement? Evidence { get; set; }

    /// <summary>
    /// Additional information about the Condition
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Condition";

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
