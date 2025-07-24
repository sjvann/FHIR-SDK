// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A structured set of questions and their answers
/// </summary>
public class QuestionnaireResponse : SimpleDomainResource
{
    /// <summary>
    /// Unique id for this set of answers
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Request fulfilled by this QuestionnaireResponse
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// Part of this action
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// Form being answered
    /// </summary>
    [JsonPropertyName("questionnaire")]
    public string? Questionnaire { get; set; }

    /// <summary>
    /// in-progress | completed | amended | entered-in-error | stopped
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The subject of the questions
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Encounter created as part of
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// Date the answers were gathered
    /// </summary>
    [JsonPropertyName("authored")]
    public DateTime? Authored { get; set; }

    /// <summary>
    /// Person who received and recorded the answers
    /// </summary>
    [JsonPropertyName("author")]
    public SimpleReference? Author { get; set; }

    /// <summary>
    /// The person who answered the questions
    /// </summary>
    [JsonPropertyName("source")]
    public SimpleReference? Source { get; set; }

    /// <summary>
    /// Groups and questions
    /// </summary>
    [JsonPropertyName("item")]
    public SimpleBackboneElement? Item { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "QuestionnaireResponse";

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
