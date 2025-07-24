// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A definition of a FHIR structure
/// </summary>
public class StructureDefinition : SimpleDomainResource
{
    /// <summary>
    /// Canonical identifier for this structure definition
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Additional identifier for the structure definition
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Business version of the structure definition
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// Name for this structure definition (computer friendly)
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name for this structure definition (human friendly)
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
    /// Natural language description of the structure definition
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The context that the content is intended to support
    /// </summary>
    [JsonPropertyName("useContext")]
    public string? UseContext { get; set; }

    /// <summary>
    /// Intended jurisdiction for structure definition (if applicable)
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public SimpleCodeableConcept? Jurisdiction { get; set; }

    /// <summary>
    /// Why this structure definition is defined
    /// </summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>
    /// Use and/or publishing restrictions
    /// </summary>
    [JsonPropertyName("copyright")]
    public string? Copyright { get; set; }

    /// <summary>
    /// Assist with indexing and finding
    /// </summary>
    [JsonPropertyName("keyword")]
    public SimpleCoding? Keyword { get; set; }

    /// <summary>
    /// FHIR Version this StructureDefinition targets
    /// </summary>
    [JsonPropertyName("fhirVersion")]
    public string? FhirVersion { get; set; }

    /// <summary>
    /// External specification that the content is mapped to
    /// </summary>
    [JsonPropertyName("mapping")]
    public SimpleBackboneElement? Mapping { get; set; }

    /// <summary>
    /// primitive-type | complex-type | resource | logical
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Whether the structure is abstract
    /// </summary>
    [JsonPropertyName("abstract")]
    public bool? Abstract { get; set; }

    /// <summary>
    /// If an extension, where it can be used in instances
    /// </summary>
    [JsonPropertyName("context")]
    public SimpleBackboneElement? Context { get; set; }

    /// <summary>
    /// FHIRPath invariants - when the extension can be used
    /// </summary>
    [JsonPropertyName("contextInvariant")]
    public string? ContextInvariant { get; set; }

    /// <summary>
    /// Type that this structure describes
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Definition that this type is constrained/specialized from
    /// </summary>
    [JsonPropertyName("baseDefinition")]
    public string? BaseDefinition { get; set; }

    /// <summary>
    /// specialization | constraint - How relates to base definition
    /// </summary>
    [JsonPropertyName("derivation")]
    public string? Derivation { get; set; }

    /// <summary>
    /// Snapshot view of the structure
    /// </summary>
    [JsonPropertyName("snapshot")]
    public SimpleBackboneElement? Snapshot { get; set; }

    /// <summary>
    /// Differential view of the structure
    /// </summary>
    [JsonPropertyName("differential")]
    public SimpleBackboneElement? Differential { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "StructureDefinition";

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
