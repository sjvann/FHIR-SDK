// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Set of definitional characteristics for a kind of observation or measurement produced or consumed by an orderable health care service
/// </summary>
public class ObservationDefinition : SimpleDomainResource
{
    /// <summary>
    /// Business identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Category of observation
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// Type of observation
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// Permitted data type for observation
    /// </summary>
    [JsonPropertyName("permittedDataType")]
    public string? PermittedDataType { get; set; }

    /// <summary>
    /// Multiple results allowed
    /// </summary>
    [JsonPropertyName("multipleResultsAllowed")]
    public bool? MultipleResultsAllowed { get; set; }

    /// <summary>
    /// Method used to produce observation
    /// </summary>
    [JsonPropertyName("method")]
    public SimpleCodeableConcept? Method { get; set; }

    /// <summary>
    /// Preferred report name
    /// </summary>
    [JsonPropertyName("preferredReportName")]
    public string? PreferredReportName { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "ObservationDefinition";

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
