// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A medication in the context of the FHIR specification
/// </summary>
public class Medication : SimpleDomainResource
{
    /// <summary>
    /// Business identifier for this medication
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Codes that identify this medication
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// active | inactive | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Manufacturer of the item
    /// </summary>
    [JsonPropertyName("manufacturer")]
    public SimpleReference? Manufacturer { get; set; }

    /// <summary>
    /// powder | tablets | capsule +
    /// </summary>
    [JsonPropertyName("form")]
    public SimpleCodeableConcept? Form { get; set; }

    /// <summary>
    /// Amount of drug in package
    /// </summary>
    [JsonPropertyName("amount")]
    public SimpleRatio? Amount { get; set; }

    /// <summary>
    /// Active or inactive ingredient
    /// </summary>
    [JsonPropertyName("ingredient")]
    public SimpleBackboneElement? Ingredient { get; set; }

    /// <summary>
    /// Details about packaged medications
    /// </summary>
    [JsonPropertyName("batch")]
    public SimpleBackboneElement? Batch { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Medication";

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
