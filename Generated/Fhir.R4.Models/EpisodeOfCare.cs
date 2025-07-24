// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// An association between a patient and an organization / healthcare provider(s) during which time encounters may occur
/// </summary>
public class EpisodeOfCare : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier(s) relevant for this EpisodeOfCare
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// planned | waitlist | active | onhold | finished | cancelled | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The history of statuses for the episode of care
    /// </summary>
    [JsonPropertyName("statusHistory")]
    public SimpleBackboneElement? StatusHistory { get; set; }

    /// <summary>
    /// A classification of the type of episode of care
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// The list of diagnosis relevant to this episode of care
    /// </summary>
    [JsonPropertyName("diagnosis")]
    public SimpleBackboneElement? Diagnosis { get; set; }

    /// <summary>
    /// The patient who is the focus of this episode of care
    /// </summary>
    [JsonPropertyName("patient")]
    public SimpleReference? Patient { get; set; }

    /// <summary>
    /// The organization that has assumed the specific responsibilities for the specified duration
    /// </summary>
    [JsonPropertyName("managingOrganization")]
    public SimpleReference? ManagingOrganization { get; set; }

    /// <summary>
    /// The interval during which the managing organization assumes the defined responsibility
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// Referral Request(s) that are fulfilled by this EpisodeOfCare
    /// </summary>
    [JsonPropertyName("referralRequest")]
    public SimpleReference? ReferralRequest { get; set; }

    /// <summary>
    /// The practitioner that is the care manager/care coordinator for this patient
    /// </summary>
    [JsonPropertyName("careManager")]
    public SimpleReference? CareManager { get; set; }

    /// <summary>
    /// The list of practitioners that may be facilitating this episode of care for the patient
    /// </summary>
    [JsonPropertyName("team")]
    public SimpleReference? Team { get; set; }

    /// <summary>
    /// The set of accounts that may be used for billing for this EpisodeOfCare
    /// </summary>
    [JsonPropertyName("account")]
    public SimpleReference? Account { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "EpisodeOfCare";

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
