using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;
using Fhir.R4.Models.DataTypes.ComplexTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// Patient Resource Data - 純粹的資料定義
/// 繼承自 GenericDomainResource，專注於欄位定義
/// </summary>
/// <remarks>
/// FHIR R4 Patient Resource
/// Demographics and other administrative information about an individual or animal receiving care or other health-related services.
/// </remarks>
public class PatientData : GenericDomainResource<PatientData>
{
    /// <summary>
    /// 資源類型
    /// </summary>
    public override FhirCode ResourceType => new FhirCode("Patient");

    /// <summary>
    /// An identifier for this patient.
    /// FHIR Path: Patient.identifier
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// Whether this patient record is in active use.
    /// FHIR Path: Patient.active
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("active")]
    public FhirBoolean? Active { get; set; }

    /// <summary>
    /// A name associated with the patient.
    /// FHIR Path: Patient.name
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("name")]
    public List<HumanName>? Name { get; set; }

    /// <summary>
    /// A contact detail for the individual.
    /// FHIR Path: Patient.telecom
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("telecom")]
    public List<ContactPoint>? Telecom { get; set; }

    /// <summary>
    /// Administrative Gender.
    /// FHIR Path: Patient.gender
    /// Cardinality: 0..1
    /// Allowed values: male, female, other, unknown
    /// </summary>
    [JsonPropertyName("gender")]
    public FhirCode? Gender { get; set; }

    /// <summary>
    /// The date of birth for the individual.
    /// FHIR Path: Patient.birthDate
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("birthDate")]
    public FhirDate? BirthDate { get; set; }

    /// <summary>
    /// Indicates if the individual is deceased or not.
    /// FHIR Path: Patient.deceased[x]
    /// Cardinality: 0..1
    /// Choice of: boolean | dateTime
    /// </summary>
    [JsonPropertyName("deceasedBoolean")]
    public FhirBoolean? DeceasedBoolean { get; set; }

    /// <summary>
    /// Indicates if the individual is deceased or not.
    /// FHIR Path: Patient.deceased[x]
    /// Cardinality: 0..1
    /// Choice of: boolean | dateTime
    /// </summary>
    [JsonPropertyName("deceasedDateTime")]
    public FhirDateTime? DeceasedDateTime { get; set; }

    /// <summary>
    /// An address for the individual.
    /// FHIR Path: Patient.address
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("address")]
    public List<Address>? Address { get; set; }

    /// <summary>
    /// This field contains a patient's most recent marital (civil) status.
    /// FHIR Path: Patient.maritalStatus
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("maritalStatus")]
    public CodeableConcept? MaritalStatus { get; set; }

    /// <summary>
    /// Indicates whether the patient is part of a multiple (boolean) or indicates the actual birth order (integer).
    /// FHIR Path: Patient.multipleBirth[x]
    /// Cardinality: 0..1
    /// Choice of: boolean | integer
    /// </summary>
    [JsonPropertyName("multipleBirthBoolean")]
    public FhirBoolean? MultipleBirthBoolean { get; set; }

    /// <summary>
    /// Indicates whether the patient is part of a multiple (boolean) or indicates the actual birth order (integer).
    /// FHIR Path: Patient.multipleBirth[x]
    /// Cardinality: 0..1
    /// Choice of: boolean | integer
    /// </summary>
    [JsonPropertyName("multipleBirthInteger")]
    public FhirInteger? MultipleBirthInteger { get; set; }

    /// <summary>
    /// Image of the patient.
    /// FHIR Path: Patient.photo
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("photo")]
    public List<Attachment>? Photo { get; set; }

    /// <summary>
    /// A contact party (e.g. guardian, partner, friend) for the patient.
    /// FHIR Path: Patient.contact
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("contact")]
    public List<PatientContact>? Contact { get; set; }

    /// <summary>
    /// A language which may be used to communicate with the patient about his or her health.
    /// FHIR Path: Patient.communication
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("communication")]
    public List<PatientCommunication>? Communication { get; set; }

    /// <summary>
    /// Patient's nominated care provider.
    /// FHIR Path: Patient.generalPractitioner
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("generalPractitioner")]
    public List<Reference<Organization, Practitioner, PractitionerRole>>? GeneralPractitioner { get; set; }

    /// <summary>
    /// Organization that is the custodian of the patient record.
    /// FHIR Path: Patient.managingOrganization
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("managingOrganization")]
    public Reference<Organization>? ManagingOrganization { get; set; }

    /// <summary>
    /// Link to another patient resource that concerns the same actual patient.
    /// FHIR Path: Patient.link
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("link")]
    public List<PatientLink>? Link { get; set; }

    /// <summary>
    /// 預設建構函式
    /// </summary>
    public PatientData() : base() { }

    /// <summary>
    /// 建構函式，設定基本屬性
    /// </summary>
    /// <param name="id">Patient ID</param>
    /// <param name="active">是否啟用</param>
    public PatientData(FhirId? id = null, FhirBoolean? active = null) : base()
    {
        if (id != null)
            Id = id;

        if (active != null)
            Active = active;
    }

    /// <summary>
    /// 添加姓名
    /// </summary>
    /// <param name="family">姓氏</param>
    /// <param name="given">名字</param>
    /// <param name="use">使用方式</param>
    public void AddName(FhirString? family = null, List<FhirString>? given = null, FhirCode? use = null)
    {
        Name ??= new List<HumanName>();
        
        var humanName = new HumanName();

        if (family != null)
            humanName.Family = family;

        if (given != null && given.Count > 0)
            humanName.Given = given;

        if (use != null)
            humanName.Use = use;
            
        Name.Add(humanName);
    }

    /// <summary>
    /// 添加聯絡方式
    /// </summary>
    /// <param name="system">系統</param>
    /// <param name="value">值</param>
    /// <param name="use">使用方式</param>
    public void AddTelecom(FhirCode system, FhirString value, FhirCode? use = null)
    {
        Telecom ??= new List<ContactPoint>();
        
        var contactPoint = new ContactPoint
        {
            System = system,
            Value = value
        };

        if (use != null)
            contactPoint.Use = use;
            
        Telecom.Add(contactPoint);
    }

    /// <summary>
    /// 添加地址
    /// </summary>
    /// <param name="line">地址行</param>
    /// <param name="city">城市</param>
    /// <param name="state">州/省</param>
    /// <param name="postalCode">郵遞區號</param>
    /// <param name="country">國家</param>
    /// <param name="use">使用方式</param>
    public void AddAddress(List<FhirString>? line = null, FhirString? city = null, FhirString? state = null,
                          FhirString? postalCode = null, FhirString? country = null, FhirCode? use = null)
    {
        Address ??= new List<Address>();
        
        var address = new Address();

        if (line != null && line.Count > 0)
            address.Line = line;

        if (city != null)
            address.City = city;

        if (state != null)
            address.State = state;

        if (postalCode != null)
            address.PostalCode = postalCode;

        if (country != null)
            address.Country = country;

        if (use != null)
            address.Use = use;
            
        Address.Add(address);
    }
}
