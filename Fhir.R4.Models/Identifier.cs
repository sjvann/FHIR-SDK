// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.R4.Models;

/// <summary>
/// An identifier for this resource
/// </summary>
public class Identifier : SimpleComplexType
{
    /// <summary>
    /// usual | official | temp | secondary | old (If known)
    /// </summary>
    [JsonPropertyName("use")]
    public string? Use { get; set; }

    /// <summary>
    /// Description of identifier
    /// </summary>
    [JsonPropertyName("type")]
    public Fhir.R4.Models.CodeableConcept Type { get; set; }

    /// <summary>
    /// The namespace for the identifier value
    /// </summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }

    /// <summary>
    /// The value that is unique
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// Time period when id is/was valid for use
    /// </summary>
    [JsonPropertyName("period")]
    public Fhir.R4.Models.Period Period { get; set; }

    /// <summary>
    /// Organization that issued id (may be just text)
    /// </summary>
    [JsonPropertyName("assigner")]
    public Fhir.R4.Models.Reference Assigner { get; set; }

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
