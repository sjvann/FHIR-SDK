// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A Capability Statement documents a set of capabilities (behaviors) of a FHIR Server for a particular version of FHIR that may be used as a statement of actual server functionality or a statement of required or desired server implementation
/// </summary>
public class CapabilityStatement : SimpleDomainResource
{
    /// <summary>
    /// Canonical identifier for this capability statement
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Business version of the capability statement
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// Name for this capability statement (computer friendly)
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name for this capability statement (human friendly)
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
    /// Natural language description of the capability statement
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The context that the content is intended to support
    /// </summary>
    [JsonPropertyName("useContext")]
    public string? UseContext { get; set; }

    /// <summary>
    /// Intended jurisdiction for capability statement (if applicable)
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public SimpleCodeableConcept? Jurisdiction { get; set; }

    /// <summary>
    /// Why this capability statement is defined
    /// </summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>
    /// Use and/or publishing restrictions
    /// </summary>
    [JsonPropertyName("copyright")]
    public string? Copyright { get; set; }

    /// <summary>
    /// instance | capability | requirements
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Canonical URL of another capability statement this implements
    /// </summary>
    [JsonPropertyName("instantiates")]
    public string? Instantiates { get; set; }

    /// <summary>
    /// Canonical URL of another capability statement this adds to
    /// </summary>
    [JsonPropertyName("imports")]
    public string? Imports { get; set; }

    /// <summary>
    /// Software that is covered by this capability statement
    /// </summary>
    [JsonPropertyName("software")]
    public SimpleBackboneElement? Software { get; set; }

    /// <summary>
    /// Identifies a specific implementation instance that is described by the capability statement
    /// </summary>
    [JsonPropertyName("implementation")]
    public SimpleBackboneElement? Implementation { get; set; }

    /// <summary>
    /// FHIR Version the system supports
    /// </summary>
    [JsonPropertyName("fhirVersion")]
    public string? FhirVersion { get; set; }

    /// <summary>
    /// formats supported (xml | json | ttl | mime type)
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// Patch formats supported
    /// </summary>
    [JsonPropertyName("patchFormat")]
    public string? PatchFormat { get; set; }

    /// <summary>
    /// Implementation guides supported
    /// </summary>
    [JsonPropertyName("implementationGuide")]
    public string? ImplementationGuide { get; set; }

    /// <summary>
    /// If the endpoint is a RESTful one
    /// </summary>
    [JsonPropertyName("rest")]
    public SimpleBackboneElement? Rest { get; set; }

    /// <summary>
    /// Messaging interface supported
    /// </summary>
    [JsonPropertyName("messaging")]
    public SimpleBackboneElement? Messaging { get; set; }

    /// <summary>
    /// Document definition
    /// </summary>
    [JsonPropertyName("document")]
    public SimpleBackboneElement? Document { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "CapabilityStatement";

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
