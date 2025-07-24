// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Information about a person that is involved in the care for a patient, but who is not the target of healthcare services nor has a formal responsibility in the care process
/// </summary>
public class RelatedPerson : SimpleDomainResource
{
    /// <summary>
    /// Identifier for a person within a particular scope
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Whether this related person record is in active use
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// The patient this person is related to
    /// </summary>
    [JsonPropertyName("patient")]
    public SimpleReference? Patient { get; set; }

    /// <summary>
    /// The nature of the relationship
    /// </summary>
    [JsonPropertyName("relationship")]
    public SimpleCodeableConcept? Relationship { get; set; }

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
    /// The date on which the related person was born
    /// </summary>
    [JsonPropertyName("birthDate")]
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Address where the related person can be contacted or visited
    /// </summary>
    [JsonPropertyName("address")]
    public SimpleAddress? Address { get; set; }

    /// <summary>
    /// Image of the person
    /// </summary>
    [JsonPropertyName("photo")]
    public SimpleAttachment? Photo { get; set; }

    /// <summary>
    /// Period of time that this relationship is considered valid
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// A language which may be used to communicate with the related person about the patient's health
    /// </summary>
    [JsonPropertyName("communication")]
    public SimpleBackboneElement? Communication { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "RelatedPerson";

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
