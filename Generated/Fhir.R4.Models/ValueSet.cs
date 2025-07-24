// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A ValueSet resource instance specifies a set of codes drawn from one or more code systems
/// </summary>
public class ValueSet : SimpleDomainResource
{
    /// <summary>
    /// Canonical identifier for this value set
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Additional identifier for the value set
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Business version of the value set
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// Name for this value set (computer friendly)
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name for this value set (human friendly)
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
    /// Natural language description of the value set
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The context that the content is intended to support
    /// </summary>
    [JsonPropertyName("useContext")]
    public string? UseContext { get; set; }

    /// <summary>
    /// Intended jurisdiction for value set (if applicable)
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public SimpleCodeableConcept? Jurisdiction { get; set; }

    /// <summary>
    /// Indicates whether or not any change to the content logical definition may occur
    /// </summary>
    [JsonPropertyName("immutable")]
    public bool? Immutable { get; set; }

    /// <summary>
    /// Why this value set is defined
    /// </summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>
    /// Use and/or publishing restrictions
    /// </summary>
    [JsonPropertyName("copyright")]
    public string? Copyright { get; set; }

    /// <summary>
    /// Content logical definition of the value set
    /// </summary>
    [JsonPropertyName("compose")]
    public SimpleBackboneElement? Compose { get; set; }

    /// <summary>
    /// Used when the value set is "expanded"
    /// </summary>
    [JsonPropertyName("expansion")]
    public SimpleBackboneElement? Expansion { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "ValueSet";

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
