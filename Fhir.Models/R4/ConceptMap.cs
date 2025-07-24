// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A statement of relationships from one set of concepts to one or more other concepts
/// </summary>
public class ConceptMap : SimpleDomainResource
{
    /// <summary>
    /// Canonical identifier for this concept map
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Additional identifier for the concept map
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Business version of the concept map
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// Name for this concept map (computer friendly)
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name for this concept map (human friendly)
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

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
    /// Natural language description of the concept map
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The context that the content is intended to support
    /// </summary>
    [JsonPropertyName("useContext")]
    public string? UseContext { get; set; }

    /// <summary>
    /// Intended jurisdiction for concept map (if applicable)
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public SimpleCodeableConcept? Jurisdiction { get; set; }

    /// <summary>
    /// Why this concept map is defined
    /// </summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>
    /// Use and/or publishing restrictions
    /// </summary>
    [JsonPropertyName("copyright")]
    public string? Copyright { get; set; }

    /// <summary>
    /// Identifies the source of the concepts which are being mapped
    /// </summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary>
    /// Identifies the source of the concepts which are being mapped
    /// </summary>
    [JsonPropertyName("sourceCanonical")]
    public string? SourceCanonical { get; set; }

    /// <summary>
    /// Provides context to the mappings
    /// </summary>
    [JsonPropertyName("targetUri")]
    public string? TargetUri { get; set; }

    /// <summary>
    /// Provides context to the mappings
    /// </summary>
    [JsonPropertyName("targetCanonical")]
    public string? TargetCanonical { get; set; }

    /// <summary>
    /// Same source and target systems
    /// </summary>
    [JsonPropertyName("group")]
    public SimpleBackboneElement? Group { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "ConceptMap";

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
