// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// An action that is or was performed on or for a patient. This can be a physical intervention like an operation, or less invasive like long term services, counseling, or hypnotherapy
/// </summary>
public class Procedure : SimpleDomainResource
{
    /// <summary>
    /// External Identifiers for this procedure
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Instantiates FHIR protocol or definition
    /// </summary>
    [JsonPropertyName("instantiatesCanonical")]
    public string? InstantiatesCanonical { get; set; }

    /// <summary>
    /// Instantiates external protocol or definition
    /// </summary>
    [JsonPropertyName("instantiatesUri")]
    public string? InstantiatesUri { get; set; }

    /// <summary>
    /// A request for this procedure
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// Part of referenced event
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// preparation | in-progress | not-done | on-hold | stopped | completed | entered-in-error | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Reason for current status
    /// </summary>
    [JsonPropertyName("statusReason")]
    public SimpleCodeableConcept? StatusReason { get; set; }

    /// <summary>
    /// Classification of the procedure
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// Identification of the procedure
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// Who the procedure was performed on
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Encounter created as part of
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// When the procedure was performed
    /// </summary>
    [JsonPropertyName("performedDateTime")]
    public DateTime? PerformedDateTime { get; set; }

    /// <summary>
    /// When the procedure was performed
    /// </summary>
    [JsonPropertyName("performedPeriod")]
    public SimplePeriod? PerformedPeriod { get; set; }

    /// <summary>
    /// When the procedure was performed
    /// </summary>
    [JsonPropertyName("performedString")]
    public string? PerformedString { get; set; }

    /// <summary>
    /// When the procedure was performed
    /// </summary>
    [JsonPropertyName("performedAge")]
    public string? PerformedAge { get; set; }

    /// <summary>
    /// When the procedure was performed
    /// </summary>
    [JsonPropertyName("performedRange")]
    public SimpleRange? PerformedRange { get; set; }

    /// <summary>
    /// Who recorded the procedure
    /// </summary>
    [JsonPropertyName("recorder")]
    public SimpleReference? Recorder { get; set; }

    /// <summary>
    /// Person who asserts this procedure
    /// </summary>
    [JsonPropertyName("asserter")]
    public SimpleReference? Asserter { get; set; }

    /// <summary>
    /// The people who performed the procedure
    /// </summary>
    [JsonPropertyName("performer")]
    public SimpleBackboneElement? Performer { get; set; }

    /// <summary>
    /// Where the procedure happened
    /// </summary>
    [JsonPropertyName("location")]
    public SimpleReference? Location { get; set; }

    /// <summary>
    /// Coded reason procedure performed
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// The justification that the procedure was performed
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public SimpleReference? ReasonReference { get; set; }

    /// <summary>
    /// Target body sites
    /// </summary>
    [JsonPropertyName("bodySite")]
    public SimpleCodeableConcept? BodySite { get; set; }

    /// <summary>
    /// The result of procedure
    /// </summary>
    [JsonPropertyName("outcome")]
    public SimpleCodeableConcept? Outcome { get; set; }

    /// <summary>
    /// Any report resulting from, or relevant to, this procedure
    /// </summary>
    [JsonPropertyName("report")]
    public SimpleReference? Report { get; set; }

    /// <summary>
    /// Complication following the procedure
    /// </summary>
    [JsonPropertyName("complication")]
    public SimpleCodeableConcept? Complication { get; set; }

    /// <summary>
    /// A condition that is a result of the procedure
    /// </summary>
    [JsonPropertyName("complicationDetail")]
    public SimpleReference? ComplicationDetail { get; set; }

    /// <summary>
    /// Instructions for follow up
    /// </summary>
    [JsonPropertyName("followUp")]
    public SimpleCodeableConcept? FollowUp { get; set; }

    /// <summary>
    /// Additional information about the procedure
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// Manipulated, implanted, or extracted device
    /// </summary>
    [JsonPropertyName("focalDevice")]
    public SimpleBackboneElement? FocalDevice { get; set; }

    /// <summary>
    /// Items used during procedure
    /// </summary>
    [JsonPropertyName("usedReference")]
    public SimpleReference? UsedReference { get; set; }

    /// <summary>
    /// Coded items used during the procedure
    /// </summary>
    [JsonPropertyName("usedCode")]
    public SimpleCodeableConcept? UsedCode { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Procedure";

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
