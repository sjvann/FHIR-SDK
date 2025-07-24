// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A financial tool for tracking value accrued for a particular purpose
/// </summary>
public class Account : SimpleDomainResource
{
    /// <summary>
    /// Unique identifier used to reference the account
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | inactive | entered-in-error | on-hold | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Indicates the purpose of this account
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// Human-readable label
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The entity that caused the expenses
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// The date range of services associated with this account
    /// </summary>
    [JsonPropertyName("servicePeriod")]
    public SimplePeriod? ServicePeriod { get; set; }

    /// <summary>
    /// The party(s) that are responsible for covering the payment of this account
    /// </summary>
    [JsonPropertyName("coverage")]
    public SimpleBackboneElement? Coverage { get; set; }

    /// <summary>
    /// Entity managing the account
    /// </summary>
    [JsonPropertyName("owner")]
    public SimpleReference? Owner { get; set; }

    /// <summary>
    /// Explanation of purpose/use
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The parties ultimately responsible for balancing the account
    /// </summary>
    [JsonPropertyName("guarantor")]
    public SimpleBackboneElement? Guarantor { get; set; }

    /// <summary>
    /// Reference to a parent account
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Account";

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
