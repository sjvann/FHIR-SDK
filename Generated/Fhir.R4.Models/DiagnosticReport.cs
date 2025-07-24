// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// The findings and interpretation of diagnostic tests performed on patients, groups of patients, devices, and locations, and/or specimens derived from these
/// </summary>
public class DiagnosticReport : SimpleDomainResource
{
    /// <summary>
    /// Business identifier for report
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// What was requested
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// registered | partial | preliminary | final +
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Service category
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// Name/Code for this diagnostic report
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// The subject of the report - usually, but not always, this is a patient
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Health care event when test ordered
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// Clinically relevant time/time-period for report
    /// </summary>
    [JsonPropertyName("effectiveDateTime")]
    public DateTime? EffectiveDateTime { get; set; }

    /// <summary>
    /// Clinically relevant time/time-period for report
    /// </summary>
    [JsonPropertyName("effectivePeriod")]
    public SimplePeriod? EffectivePeriod { get; set; }

    /// <summary>
    /// DateTime this version was made
    /// </summary>
    [JsonPropertyName("issued")]
    public DateTime? Issued { get; set; }

    /// <summary>
    /// Responsible Diagnostic Service
    /// </summary>
    [JsonPropertyName("performer")]
    public SimpleReference? Performer { get; set; }

    /// <summary>
    /// Primary result interpreter
    /// </summary>
    [JsonPropertyName("resultsInterpreter")]
    public SimpleReference? ResultsInterpreter { get; set; }

    /// <summary>
    /// Specimens this report is based on
    /// </summary>
    [JsonPropertyName("specimen")]
    public SimpleReference? Specimen { get; set; }

    /// <summary>
    /// Observations
    /// </summary>
    [JsonPropertyName("result")]
    public SimpleReference? Result { get; set; }

    /// <summary>
    /// Reference to full details of imaging associated with the diagnostic report
    /// </summary>
    [JsonPropertyName("imagingStudy")]
    public SimpleReference? ImagingStudy { get; set; }

    /// <summary>
    /// Key images associated with this report
    /// </summary>
    [JsonPropertyName("media")]
    public SimpleBackboneElement? Media { get; set; }

    /// <summary>
    /// Clinical conclusion (interpretation) of test results
    /// </summary>
    [JsonPropertyName("conclusion")]
    public string? Conclusion { get; set; }

    /// <summary>
    /// Codes for the conclusion
    /// </summary>
    [JsonPropertyName("conclusionCode")]
    public SimpleCodeableConcept? ConclusionCode { get; set; }

    /// <summary>
    /// Entire report as issued
    /// </summary>
    [JsonPropertyName("presentedForm")]
    public SimpleAttachment? PresentedForm { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "DiagnosticReport";

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
