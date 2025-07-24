// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A structured set of questions intended to guide the collection of answers from end-users
/// </summary>
public class Questionnaire : SimpleDomainResource
{
    /// <summary>
    /// Canonical identifier for this questionnaire
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Additional identifier for the questionnaire
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Business version of the questionnaire
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// Name for this questionnaire (computer friendly)
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name for this questionnaire (human friendly)
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Subordinate title of the questionnaire
    /// </summary>
    [JsonPropertyName("subtitle")]
    public string? Subtitle { get; set; }

    /// <summary>
    /// draft | active | retired | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// For testing purposes, not real usage
    /// </summary>
    [JsonPropertyName("experimental")]
    public bool? Experimental { get; set; }

    /// <summary>
    /// Resource that can be subject of QuestionnaireResponse
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }

    /// <summary>
    /// Date last changed
    /// </summary>
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Name of the publisher (organization or individual)
    /// </summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>
    /// Contact details for the publisher
    /// </summary>
    [JsonPropertyName("contact")]
    public string? Contact { get; set; }

    /// <summary>
    /// Natural language description of the questionnaire
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The context that the content is intended to support
    /// </summary>
    [JsonPropertyName("useContext")]
    public string? UseContext { get; set; }

    /// <summary>
    /// Intended jurisdiction for questionnaire (if applicable)
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public SimpleCodeableConcept? Jurisdiction { get; set; }

    /// <summary>
    /// Why this questionnaire is defined
    /// </summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>
    /// Use and/or publishing restrictions
    /// </summary>
    [JsonPropertyName("copyright")]
    public string? Copyright { get; set; }

    /// <summary>
    /// When the questionnaire was approved by publisher
    /// </summary>
    [JsonPropertyName("approvalDate")]
    public DateTime? ApprovalDate { get; set; }

    /// <summary>
    /// When the questionnaire was last reviewed
    /// </summary>
    [JsonPropertyName("lastReviewDate")]
    public DateTime? LastReviewDate { get; set; }

    /// <summary>
    /// When the questionnaire is expected to be used
    /// </summary>
    [JsonPropertyName("effectivePeriod")]
    public SimplePeriod? EffectivePeriod { get; set; }

    /// <summary>
    /// Concept that represents the overall questionnaire
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCoding? Code { get; set; }

    /// <summary>
    /// Questions and sections within the questionnaire
    /// </summary>
    [JsonPropertyName("item")]
    public SimpleBackboneElement? Item { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Questionnaire";

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
