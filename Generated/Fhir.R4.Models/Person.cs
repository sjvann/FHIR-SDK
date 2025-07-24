// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Demographics and administrative information about a person independent of a specific health-related context
/// </summary>
public class Person : SimpleDomainResource
{
    /// <summary>
    /// A human identifier for this person
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Whether this person's record is in active use
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// A name associated with the person
    /// </summary>
    [JsonPropertyName("name")]
    public SimpleHumanName? Name { get; set; }

    /// <summary>
    /// A contact detail for the person
    /// </summary>
    [JsonPropertyName("telecom")]
    public SimpleContactPoint? Telecom { get; set; }

    /// <summary>
    /// male | female | other | unknown
    /// </summary>
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    /// <summary>
    /// The date on which the person was born
    /// </summary>
    [JsonPropertyName("birthDate")]
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Indicates if the individual is deceased or not
    /// </summary>
    [JsonPropertyName("deceasedBoolean")]
    public bool? DeceasedBoolean { get; set; }

    /// <summary>
    /// Indicates if the individual is deceased or not
    /// </summary>
    [JsonPropertyName("deceasedDateTime")]
    public DateTime? DeceasedDateTime { get; set; }

    /// <summary>
    /// One or more addresses for the person
    /// </summary>
    [JsonPropertyName("address")]
    public SimpleAddress? Address { get; set; }

    /// <summary>
    /// Marital (civil) status of a person
    /// </summary>
    [JsonPropertyName("maritalStatus")]
    public SimpleCodeableConcept? MaritalStatus { get; set; }

    /// <summary>
    /// Image of the person
    /// </summary>
    [JsonPropertyName("photo")]
    public SimpleAttachment? Photo { get; set; }

    /// <summary>
    /// The organization that is the custodian of the person record
    /// </summary>
    [JsonPropertyName("managingOrganization")]
    public SimpleReference? ManagingOrganization { get; set; }

    /// <summary>
    /// Link to a resource that concerns the same actual person
    /// </summary>
    [JsonPropertyName("link")]
    public SimpleBackboneElement? Link { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Person";

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
