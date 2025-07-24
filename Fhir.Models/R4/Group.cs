// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Represents a defined collection of entities that may be discussed or acted upon collectively but which are not expected to act collectively and are not formally or legally recognized
/// </summary>
public class Group : SimpleDomainResource
{
    /// <summary>
    /// Unique identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Whether this group record is in active use
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// person | animal | practitioner | device | medication | substance
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// If true, indicates that the resource refers to a specific group of real individuals
    /// </summary>
    [JsonPropertyName("actual")]
    public bool? Actual { get; set; }

    /// <summary>
    /// Kind of Group members
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// Label for Group
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Number of members
    /// </summary>
    [JsonPropertyName("quantity")]
    public uint? Quantity { get; set; }

    /// <summary>
    /// Entity that is the custodian of the Group's definition
    /// </summary>
    [JsonPropertyName("managingEntity")]
    public SimpleReference? ManagingEntity { get; set; }

    /// <summary>
    /// Trait of group members
    /// </summary>
    [JsonPropertyName("characteristic")]
    public SimpleBackboneElement? Characteristic { get; set; }

    /// <summary>
    /// Who or what is in group
    /// </summary>
    [JsonPropertyName("member")]
    public SimpleBackboneElement? Member { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Group";

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
