// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A formally or informally recognized grouping of people or organizations formed for the purpose of achieving some form of collective action
/// </summary>
public class Organization : SimpleDomainResource
{
    /// <summary>
    /// Identifies this organization across multiple systems
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Whether the organization's record is still in active use
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Kind of organization
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// Name used for the organization
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A list of alternate names that the organization is known as, or was known as in the past
    /// </summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>
    /// A contact detail for the organization
    /// </summary>
    [JsonPropertyName("telecom")]
    public SimpleContactPoint? Telecom { get; set; }

    /// <summary>
    /// An address for the organization
    /// </summary>
    [JsonPropertyName("address")]
    public SimpleAddress? Address { get; set; }

    /// <summary>
    /// The organization of which this organization forms a part
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// Contact for the organization for a certain purpose
    /// </summary>
    [JsonPropertyName("contact")]
    public SimpleBackboneElement? Contact { get; set; }

    /// <summary>
    /// Technical endpoints providing access to services operated for the organization
    /// </summary>
    [JsonPropertyName("endpoint")]
    public SimpleReference? Endpoint { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Organization";

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
