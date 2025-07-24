// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Describes the intended objective(s) for a patient, group or organization care, for example, weight loss, restoring an activity of daily living, obtaining herd immunity via immunization, meeting a process improvement objective
/// </summary>
public class Goal : SimpleDomainResource
{
    /// <summary>
    /// External Ids for this goal
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// proposed | planned | active | on-hold | completed | cancelled | entered-in-error | rejected
    /// </summary>
    [JsonPropertyName("lifecycleStatus")]
    public string? LifecycleStatus { get; set; }

    /// <summary>
    /// in-progress | improving | worsening | no-change | achieved | sustaining | not-achieved | no-progress | not-attainable
    /// </summary>
    [JsonPropertyName("achievementStatus")]
    public SimpleCodeableConcept? AchievementStatus { get; set; }

    /// <summary>
    /// E.g. Treatment, dietary, behavioral, etc.
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// high-priority | medium-priority | low-priority
    /// </summary>
    [JsonPropertyName("priority")]
    public SimpleCodeableConcept? Priority { get; set; }

    /// <summary>
    /// Code or text describing the goal
    /// </summary>
    [JsonPropertyName("description")]
    public SimpleCodeableConcept? Description { get; set; }

    /// <summary>
    /// Who this goal is intended for
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// When goal pursuit begins
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// When goal pursuit begins
    /// </summary>
    [JsonPropertyName("startCodeableConcept")]
    public SimpleCodeableConcept? StartCodeableConcept { get; set; }

    /// <summary>
    /// Target outcome for the goal
    /// </summary>
    [JsonPropertyName("target")]
    public SimpleBackboneElement? Target { get; set; }

    /// <summary>
    /// When goal status took effect
    /// </summary>
    [JsonPropertyName("statusDate")]
    public DateTime? StatusDate { get; set; }

    /// <summary>
    /// Reason for current status
    /// </summary>
    [JsonPropertyName("statusReason")]
    public string? StatusReason { get; set; }

    /// <summary>
    /// Who's responsible for creating Goal?
    /// </summary>
    [JsonPropertyName("expressedBy")]
    public SimpleReference? ExpressedBy { get; set; }

    /// <summary>
    /// Issues addressed by this goal
    /// </summary>
    [JsonPropertyName("addresses")]
    public SimpleReference? Addresses { get; set; }

    /// <summary>
    /// Comments about the goal
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// What result was achieved regarding the goal?
    /// </summary>
    [JsonPropertyName("outcomeCode")]
    public SimpleCodeableConcept? OutcomeCode { get; set; }

    /// <summary>
    /// Observation that resulted from goal
    /// </summary>
    [JsonPropertyName("outcomeReference")]
    public SimpleReference? OutcomeReference { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Goal";

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
