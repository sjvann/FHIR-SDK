// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Information about an individual receiving health care services
/// </summary>
public class Patient : SimpleDomainResource
{
    /// <summary>
    /// An identifier for this patient
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Whether this patient's record is in active use
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// A name associated with the individual
    /// </summary>
    [JsonPropertyName("name")]
    public SimpleHumanName? Name { get; set; }

    /// <summary>
    /// A contact detail for the individual
    /// </summary>
    [JsonPropertyName("telecom")]
    public SimpleContactPoint? Telecom { get; set; }

    /// <summary>
    /// male | female | other | unknown
    /// </summary>
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    /// <summary>
    /// The date of birth for the individual
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
    /// An address for the individual
    /// </summary>
    [JsonPropertyName("address")]
    public SimpleAddress? Address { get; set; }

    /// <summary>
    /// Marital (civil) status of a patient
    /// </summary>
    [JsonPropertyName("maritalStatus")]
    public SimpleCodeableConcept? MaritalStatus { get; set; }

    /// <summary>
    /// Whether patient is part of a multiple birth
    /// </summary>
    [JsonPropertyName("multipleBirthBoolean")]
    public bool? MultipleBirthBoolean { get; set; }

    /// <summary>
    /// Whether patient is part of a multiple birth
    /// </summary>
    [JsonPropertyName("multipleBirthInteger")]
    public int? MultipleBirthInteger { get; set; }

    /// <summary>
    /// Image of the patient
    /// </summary>
    [JsonPropertyName("photo")]
    public SimpleAttachment? Photo { get; set; }

    /// <summary>
    /// A contact party (e.g. guardian, partner, friend) for the patient
    /// </summary>
    [JsonPropertyName("contact")]
    public SimpleBackboneElement? Contact { get; set; }

    /// <summary>
    /// A list of Languages which may be used to communicate with the patient about his or her health
    /// </summary>
    [JsonPropertyName("communication")]
    public SimpleBackboneElement? Communication { get; set; }

    /// <summary>
    /// Patient's nominated care provider
    /// </summary>
    [JsonPropertyName("generalPractitioner")]
    public SimpleReference? GeneralPractitioner { get; set; }

    /// <summary>
    /// Organization that is the custodian of the patient record
    /// </summary>
    [JsonPropertyName("managingOrganization")]
    public SimpleReference? ManagingOrganization { get; set; }

    /// <summary>
    /// Link to another patient resource that concerns the same actual person
    /// </summary>
    [JsonPropertyName("link")]
    public SimpleBackboneElement? Link { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Patient";

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
