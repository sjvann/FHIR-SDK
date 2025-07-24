// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// The Care Team includes all the people and organizations who plan to participate in the coordination and delivery of care for a patient
/// </summary>
public class CareTeam : SimpleDomainResource
{
    /// <summary>
    /// External Ids for this care team
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// proposed | active | suspended | inactive | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Type of team
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// Name of the team, such as crisis assessment team
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Who care team is for
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Encounter created as part of
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// Time period team covers
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// Members of the team
    /// </summary>
    [JsonPropertyName("participant")]
    public SimpleBackboneElement? Participant { get; set; }

    /// <summary>
    /// Why the care team exists
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Why the care team exists
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public SimpleReference? ReasonReference { get; set; }

    /// <summary>
    /// Organization responsible for the care team
    /// </summary>
    [JsonPropertyName("managingOrganization")]
    public SimpleReference? ManagingOrganization { get; set; }

    /// <summary>
    /// A contact detail for the care team
    /// </summary>
    [JsonPropertyName("telecom")]
    public SimpleContactPoint? Telecom { get; set; }

    /// <summary>
    /// Comments made about the CareTeam
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "CareTeam";

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
