// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A search parameter that defines a named search item that can be used to search/filter on a resource
/// </summary>
public class SearchParameter : SimpleDomainResource
{
    /// <summary>
    /// Canonical identifier for this search parameter
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Business version of the search parameter
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// Name for this search parameter (computer friendly)
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Original definition for the search parameter
    /// </summary>
    [JsonPropertyName("derivedFrom")]
    public string? DerivedFrom { get; set; }

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
    /// Natural language description of the search parameter
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The context that the content is intended to support
    /// </summary>
    [JsonPropertyName("useContext")]
    public string? UseContext { get; set; }

    /// <summary>
    /// Intended jurisdiction for search parameter (if applicable)
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public SimpleCodeableConcept? Jurisdiction { get; set; }

    /// <summary>
    /// Why this search parameter is defined
    /// </summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>
    /// Code used in URL
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// The resource type(s) this search parameter applies to
    /// </summary>
    [JsonPropertyName("base")]
    public string? Base { get; set; }

    /// <summary>
    /// number | date | string | token | reference | composite | quantity | uri | special
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// FHIRPath expression that extracts the values
    /// </summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>
    /// XPath that extracts the values
    /// </summary>
    [JsonPropertyName("xpath")]
    public string? Xpath { get; set; }

    /// <summary>
    /// normal | phonetic | nearby | distance | other
    /// </summary>
    [JsonPropertyName("xpathUsage")]
    public string? XpathUsage { get; set; }

    /// <summary>
    /// Types of resource (if a resource reference)
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>
    /// Allow multiple values
    /// </summary>
    [JsonPropertyName("multipleOr")]
    public bool? MultipleOr { get; set; }

    /// <summary>
    /// Allow multiple parameters
    /// </summary>
    [JsonPropertyName("multipleAnd")]
    public bool? MultipleAnd { get; set; }

    /// <summary>
    /// eq | ne | gt | lt | ge | le | sa | eb | ap
    /// </summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>
    /// missing | exact | contains | not | text | in | not-in | below | above | type | identifier | of-type
    /// </summary>
    [JsonPropertyName("modifier")]
    public string? Modifier { get; set; }

    /// <summary>
    /// Chained names supported
    /// </summary>
    [JsonPropertyName("chain")]
    public string? Chain { get; set; }

    /// <summary>
    /// For Composite search parameters
    /// </summary>
    [JsonPropertyName("component")]
    public SimpleBackboneElement? Component { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "SearchParameter";

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
