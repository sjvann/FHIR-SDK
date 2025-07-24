// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.R4.Models;

/// <summary>
/// A human's name with the ability to identify parts and usage
/// </summary>
public class HumanName : SimpleComplexType
{
    /// <summary>
    /// usual | official | temp | nickname | anonymous | old | maiden
    /// </summary>
    [JsonPropertyName("use")]
    public string? Use { get; set; }

    /// <summary>
    /// Text representation of the full name
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// Family name (often called 'Surname')
    /// </summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>
    /// Given names (not always 'first'). Includes middle names
    /// </summary>
    [JsonPropertyName("given")]
    public List<string>? Given { get; set; }

    /// <summary>
    /// Parts that come before the name
    /// </summary>
    [JsonPropertyName("prefix")]
    public List<string>? Prefix { get; set; }

    /// <summary>
    /// Parts that come after the name
    /// </summary>
    [JsonPropertyName("suffix")]
    public List<string>? Suffix { get; set; }

    /// <summary>
    /// Time period when name was/is in use
    /// </summary>
    [JsonPropertyName("period")]
    public Fhir.R4.Models.Period Period { get; set; }

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
