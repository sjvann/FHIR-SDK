// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A formal computable definition of an operation (on the RESTful interface) or a named query (using the search interaction)
/// </summary>
public class OperationDefinition : SimpleDomainResource
{
    /// <summary>
    /// Canonical identifier for this operation definition
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Business version of the operation definition
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// Name for this operation definition (computer friendly)
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name for this operation definition (human friendly)
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// draft | active | retired | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// operation | query
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

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
    /// Natural language description of the operation definition
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The context that the content is intended to support
    /// </summary>
    [JsonPropertyName("useContext")]
    public string? UseContext { get; set; }

    /// <summary>
    /// Intended jurisdiction for operation definition (if applicable)
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public SimpleCodeableConcept? Jurisdiction { get; set; }

    /// <summary>
    /// Why this operation definition is defined
    /// </summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>
    /// Whether content is changed by the operation
    /// </summary>
    [JsonPropertyName("affectsState")]
    public bool? AffectsState { get; set; }

    /// <summary>
    /// Name used to invoke the operation
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// Additional information about use
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// Marks this as a profile of the base
    /// </summary>
    [JsonPropertyName("base")]
    public string? Base { get; set; }

    /// <summary>
    /// Types this operation applies to
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>
    /// Invoke at the system level?
    /// </summary>
    [JsonPropertyName("system")]
    public bool? System { get; set; }

    /// <summary>
    /// Invoke at the type level?
    /// </summary>
    [JsonPropertyName("type")]
    public bool? Type { get; set; }

    /// <summary>
    /// Invoke on an instance?
    /// </summary>
    [JsonPropertyName("instance")]
    public bool? Instance { get; set; }

    /// <summary>
    /// Parameters for the input
    /// </summary>
    [JsonPropertyName("inputProfile")]
    public string? InputProfile { get; set; }

    /// <summary>
    /// Parameters for the output
    /// </summary>
    [JsonPropertyName("outputProfile")]
    public string? OutputProfile { get; set; }

    /// <summary>
    /// Parameters for the operation/query
    /// </summary>
    [JsonPropertyName("parameter")]
    public SimpleBackboneElement? Parameter { get; set; }

    /// <summary>
    /// Define overloaded variants for when generating code
    /// </summary>
    [JsonPropertyName("overload")]
    public SimpleBackboneElement? Overload { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "OperationDefinition";

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
