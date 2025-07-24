// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// The CodeSystem resource is used to declare the existence of and describe a code system or code system supplement and its key properties
/// </summary>
public class CodeSystem : SimpleDomainResource
{
    /// <summary>
    /// Canonical identifier for this code system
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Additional identifier for the code system
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Business version of the code system
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// Name for this code system (computer friendly)
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name for this code system (human friendly)
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
    /// Natural language description of the code system
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The context that the content is intended to support
    /// </summary>
    [JsonPropertyName("useContext")]
    public string? UseContext { get; set; }

    /// <summary>
    /// Intended jurisdiction for code system (if applicable)
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public SimpleCodeableConcept? Jurisdiction { get; set; }

    /// <summary>
    /// Why this code system is defined
    /// </summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>
    /// Use and/or publishing restrictions
    /// </summary>
    [JsonPropertyName("copyright")]
    public string? Copyright { get; set; }

    /// <summary>
    /// If code comparison is case sensitive
    /// </summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>
    /// Canonical reference to the value set with entire code system
    /// </summary>
    [JsonPropertyName("valueSet")]
    public string? ValueSet { get; set; }

    /// <summary>
    /// grouped-by | is-a | part-of | classified-with
    /// </summary>
    [JsonPropertyName("hierarchyMeaning")]
    public string? HierarchyMeaning { get; set; }

    /// <summary>
    /// If code system defines a post-composition grammar
    /// </summary>
    [JsonPropertyName("compositional")]
    public bool? Compositional { get; set; }

    /// <summary>
    /// If definitions are not stable
    /// </summary>
    [JsonPropertyName("versionNeeded")]
    public bool? VersionNeeded { get; set; }

    /// <summary>
    /// not-present | example | fragment | complete | supplement
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// Canonical URL of Code System this adds to
    /// </summary>
    [JsonPropertyName("supplements")]
    public string? Supplements { get; set; }

    /// <summary>
    /// Total concepts in the code system
    /// </summary>
    [JsonPropertyName("count")]
    public uint? Count { get; set; }

    /// <summary>
    /// Filter that can be used in a value set
    /// </summary>
    [JsonPropertyName("filter")]
    public SimpleBackboneElement? Filter { get; set; }

    /// <summary>
    /// Additional information supplied about each concept
    /// </summary>
    [JsonPropertyName("property")]
    public SimpleBackboneElement? Property { get; set; }

    /// <summary>
    /// Concepts in the code system
    /// </summary>
    [JsonPropertyName("concept")]
    public SimpleBackboneElement? Concept { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "CodeSystem";

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
