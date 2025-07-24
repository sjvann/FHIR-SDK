// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A process where a researcher or organization plans and then executes a series of steps intended to increase the field of healthcare-related knowledge
/// </summary>
public class ResearchStudy : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier for study
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Name for this study
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Steps followed in executing study
    /// </summary>
    [JsonPropertyName("protocol")]
    public SimpleReference? Protocol { get; set; }

    /// <summary>
    /// Part of larger study
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// active | administratively-completed | approved | closed-to-accrual | closed-to-accrual-and-intervention | completed | disapproved | in-review | temporarily-closed-to-accrual | temporarily-closed-to...
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// treatment | prevention | diagnostic | supportive-care | screening | health-services-research | basic-science | device-feasibility
    /// </summary>
    [JsonPropertyName("primaryPurposeType")]
    public SimpleCodeableConcept? PrimaryPurposeType { get; set; }

    /// <summary>
    /// n-a | early-phase-1 | phase-1 | phase-1-phase-2 | phase-2 | phase-2-phase-3 | phase-3 | phase-4
    /// </summary>
    [JsonPropertyName("phase")]
    public SimpleCodeableConcept? Phase { get; set; }

    /// <summary>
    /// Classifications for the study
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// Drugs, devices, etc. under study
    /// </summary>
    [JsonPropertyName("focus")]
    public SimpleCodeableConcept? Focus { get; set; }

    /// <summary>
    /// Condition being studied
    /// </summary>
    [JsonPropertyName("condition")]
    public SimpleCodeableConcept? Condition { get; set; }

    /// <summary>
    /// Contact details for the study
    /// </summary>
    [JsonPropertyName("contact")]
    public string? Contact { get; set; }

    /// <summary>
    /// References and dependencies
    /// </summary>
    [JsonPropertyName("relatedArtifact")]
    public string? RelatedArtifact { get; set; }

    /// <summary>
    /// Used to search for the study
    /// </summary>
    [JsonPropertyName("keyword")]
    public SimpleCodeableConcept? Keyword { get; set; }

    /// <summary>
    /// Geographic region(s) for study
    /// </summary>
    [JsonPropertyName("location")]
    public SimpleCodeableConcept? Location { get; set; }

    /// <summary>
    /// What this is study doing
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Inclusion & exclusion criteria
    /// </summary>
    [JsonPropertyName("enrollment")]
    public SimpleReference? Enrollment { get; set; }

    /// <summary>
    /// When the study began and ended
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// Organization that initiates and is legally responsible for the study
    /// </summary>
    [JsonPropertyName("sponsor")]
    public SimpleReference? Sponsor { get; set; }

    /// <summary>
    /// Researcher who oversees the execution of the study
    /// </summary>
    [JsonPropertyName("principalInvestigator")]
    public SimpleReference? PrincipalInvestigator { get; set; }

    /// <summary>
    /// Facility where study activities are conducted
    /// </summary>
    [JsonPropertyName("site")]
    public SimpleReference? Site { get; set; }

    /// <summary>
    /// Accrual goal met
    /// </summary>
    [JsonPropertyName("reasonStopped")]
    public SimpleCodeableConcept? ReasonStopped { get; set; }

    /// <summary>
    /// Comments made about the study
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// Defined path through the study for a subject
    /// </summary>
    [JsonPropertyName("arm")]
    public SimpleBackboneElement? Arm { get; set; }

    /// <summary>
    /// A goal for the study
    /// </summary>
    [JsonPropertyName("objective")]
    public SimpleBackboneElement? Objective { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "ResearchStudy";

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
