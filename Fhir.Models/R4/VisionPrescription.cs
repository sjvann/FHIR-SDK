// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// An authorization for the supply of glasses and/or contact lenses to a patient
/// </summary>
public class VisionPrescription : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | cancelled | draft | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Creation date
    /// </summary>
    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Who prescription is for
    /// </summary>
    [JsonPropertyName("patient")]
    public SimpleReference? Patient { get; set; }

    /// <summary>
    /// Encounter during which prescription was created
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// When prescription was authorized
    /// </summary>
    [JsonPropertyName("dateWritten")]
    public DateTime? DateWritten { get; set; }

    /// <summary>
    /// Who authorized the prescription
    /// </summary>
    [JsonPropertyName("prescriber")]
    public SimpleReference? Prescriber { get; set; }

    /// <summary>
    /// Vision lens authorization
    /// </summary>
    [JsonPropertyName("lensSpecification")]
    public SimpleBackboneElement? LensSpecification { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "VisionPrescription";

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
