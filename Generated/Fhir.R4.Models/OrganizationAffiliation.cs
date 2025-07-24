// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Defines an affiliation/assotiation/relationship between 2 distinct organizations
/// </summary>
public class OrganizationAffiliation : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Whether this OrganizationAffiliation record is in active use
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Organization where the role is available
    /// </summary>
    [JsonPropertyName("organization")]
    public SimpleReference? Organization { get; set; }

    /// <summary>
    /// Organization that provides the services
    /// </summary>
    [JsonPropertyName("participatingOrganization")]
    public SimpleReference? ParticipatingOrganization { get; set; }

    /// <summary>
    /// Role code(s) that define the relationship
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// The period during which the participatingOrganization is affiliated with the primary organization
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "OrganizationAffiliation";

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
