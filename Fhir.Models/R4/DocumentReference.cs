// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A reference to a document of any kind for any purpose
/// </summary>
public class DocumentReference : SimpleDomainResource
{
    /// <summary>
    /// Other identifiers for the document
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// current | superseded | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// preliminary | final | amended | entered-in-error
    /// </summary>
    [JsonPropertyName("docStatus")]
    public string? DocStatus { get; set; }

    /// <summary>
    /// Kind of document
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// Categorization of document
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// Who/what is the subject of the document
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// When this document reference was created
    /// </summary>
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Who and/or what authored the document
    /// </summary>
    [JsonPropertyName("author")]
    public SimpleReference? Author { get; set; }

    /// <summary>
    /// Who/what authenticated the document
    /// </summary>
    [JsonPropertyName("authenticator")]
    public SimpleReference? Authenticator { get; set; }

    /// <summary>
    /// Organization which maintains the document
    /// </summary>
    [JsonPropertyName("custodian")]
    public SimpleReference? Custodian { get; set; }

    /// <summary>
    /// Relationships to other documents
    /// </summary>
    [JsonPropertyName("relatesTo")]
    public SimpleBackboneElement? RelatesTo { get; set; }

    /// <summary>
    /// Human-readable description
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Document security-tags
    /// </summary>
    [JsonPropertyName("securityLabel")]
    public SimpleCodeableConcept? SecurityLabel { get; set; }

    /// <summary>
    /// Document referenced
    /// </summary>
    [JsonPropertyName("content")]
    public SimpleBackboneElement? Content { get; set; }

    /// <summary>
    /// Clinical context of document
    /// </summary>
    [JsonPropertyName("context")]
    public SimpleBackboneElement? Context { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "DocumentReference";

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
