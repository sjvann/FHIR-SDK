// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A record of a healthcare consumer's choices or choices made on their behalf by a third party
/// </summary>
public class Consent : SimpleDomainResource
{
    /// <summary>
    /// Identifier for this record (external references)
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// draft | proposed | active | rejected | inactive | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Which of the four areas this resource covers (extensive/international/regional/national)
    /// </summary>
    [JsonPropertyName("scope")]
    public SimpleCodeableConcept? Scope { get; set; }

    /// <summary>
    /// Classification of the consent statement
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// Who the consent applies to
    /// </summary>
    [JsonPropertyName("patient")]
    public SimpleReference? Patient { get; set; }

    /// <summary>
    /// When this Consent was created or indexed
    /// </summary>
    [JsonPropertyName("dateTime")]
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// Consent Verified by
    /// </summary>
    [JsonPropertyName("performer")]
    public SimpleReference? Performer { get; set; }

    /// <summary>
    /// Custodian of the consent
    /// </summary>
    [JsonPropertyName("organization")]
    public SimpleReference? Organization { get; set; }

    /// <summary>
    /// Source from which this consent is taken
    /// </summary>
    [JsonPropertyName("sourceAttachment")]
    public SimpleAttachment? SourceAttachment { get; set; }

    /// <summary>
    /// Source from which this consent is taken
    /// </summary>
    [JsonPropertyName("sourceReference")]
    public SimpleReference? SourceReference { get; set; }

    /// <summary>
    /// Policies covered by this consent
    /// </summary>
    [JsonPropertyName("policy")]
    public SimpleBackboneElement? Policy { get; set; }

    /// <summary>
    /// Regulation that this consents to
    /// </summary>
    [JsonPropertyName("policyRule")]
    public SimpleCodeableConcept? PolicyRule { get; set; }

    /// <summary>
    /// Consent Verified by patient or family
    /// </summary>
    [JsonPropertyName("verification")]
    public SimpleBackboneElement? Verification { get; set; }

    /// <summary>
    /// Constraints to the base Consent.policyRule
    /// </summary>
    [JsonPropertyName("provision")]
    public SimpleBackboneElement? Provision { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Consent";

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
