// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A person with a formal responsibility in the provisioning of healthcare or related services
/// </summary>
public class Practitioner : SimpleDomainResource
{
    /// <summary>
    /// A identifier for the person as this agent
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Whether this practitioner's record is in active use
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// The name(s) associated with the practitioner
    /// </summary>
    [JsonPropertyName("name")]
    public SimpleHumanName? Name { get; set; }

    /// <summary>
    /// A contact detail for the practitioner
    /// </summary>
    [JsonPropertyName("telecom")]
    public SimpleContactPoint? Telecom { get; set; }

    /// <summary>
    /// Address(es) of the practitioner that are not role specific
    /// </summary>
    [JsonPropertyName("address")]
    public SimpleAddress? Address { get; set; }

    /// <summary>
    /// male | female | other | unknown
    /// </summary>
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    /// <summary>
    /// The date of birth for the practitioner
    /// </summary>
    [JsonPropertyName("birthDate")]
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Image of the practitioner
    /// </summary>
    [JsonPropertyName("photo")]
    public SimpleAttachment? Photo { get; set; }

    /// <summary>
    /// Qualifications obtained by training and certification
    /// </summary>
    [JsonPropertyName("qualification")]
    public SimpleBackboneElement? Qualification { get; set; }

    /// <summary>
    /// A language the practitioner can use in patient communication
    /// </summary>
    [JsonPropertyName("communication")]
    public SimpleCodeableConcept? Communication { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Practitioner";

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
