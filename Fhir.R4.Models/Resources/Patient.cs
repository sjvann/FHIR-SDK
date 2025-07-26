using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Abstractions.Resources;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// Demographics and other administrative information about an individual or animal receiving care or other health-related services.
/// </summary>
/// <remarks>
/// FHIR R4 Patient DomainResource
/// Demographics and other administrative information about an individual or animal receiving care or other health-related services.
/// </remarks>
public class Patient : DomainResource
{
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
    public bool? Active { get; set; }
    
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
    /// Administrative Gender - the gender that the patient is considered to have for administration and record keeping purposes.
    /// FHIR Path: Patient.gender
    /// Cardinality: 0..1
    /// Allowed values: male, female, other, unknown
    /// </summary>
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }
    
    /// <summary>
    /// The date of birth for the individual.
    /// FHIR Path: Patient.birthDate
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("birthDate")]
    public string? BirthDate { get; set; }
    
    /// <summary>
    /// Indicates if the individual is deceased or not.
    /// 
    /// Choice Type: deceased[x]
    /// This is a choice element - only one of the following types may be present:
    ///   - boolean
    ///   - dateTime
    /// </summary>
    [JsonIgnore]
    public ChoiceType<FhirBoolean, FhirDateTime>? DeceasedChoice { get; set; }
    
    // JSON 序列化屬性 for deceased[x]
    [JsonPropertyName("deceasedBoolean")]
    public bool? DeceasedBoolean 
    { 
        get => DeceasedChoice?.AsT1()?.Value;
        set => DeceasedChoice = value != null ? new FhirBoolean(value) : null;
    }
    
    [JsonPropertyName("deceasedDateTime")]
    public string? DeceasedDateTime 
    { 
        get => DeceasedChoice?.AsT2()?.Value;
        set => DeceasedChoice = value != null ? new FhirDateTime(value) : null;
    }
    
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
    /// 
    /// Choice Type: multipleBirth[x]
    /// This is a choice element - only one of the following types may be present:
    ///   - boolean
    ///   - integer
    /// </summary>
    [JsonIgnore]
    public ChoiceType<FhirBoolean, FhirInteger>? MultipleBirthChoice { get; set; }
    
    // JSON 序列化屬性 for multipleBirth[x]
    [JsonPropertyName("multipleBirthBoolean")]
    public bool? MultipleBirthBoolean 
    { 
        get => MultipleBirthChoice?.AsT1()?.Value;
        set => MultipleBirthChoice = value != null ? new FhirBoolean(value) : null;
    }
    
    [JsonPropertyName("multipleBirthInteger")]
    public int? MultipleBirthInteger 
    { 
        get => MultipleBirthChoice?.AsT2()?.Value;
        set => MultipleBirthChoice = value != null ? new FhirInteger(value) : null;
    }
    
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
    /// Reference to: Organization, Practitioner, PractitionerRole
    /// </summary>
    [JsonPropertyName("generalPractitioner")]
    public List<Reference<Organization, Practitioner, PractitionerRole>>? GeneralPractitioner { get; set; }
    
    /// <summary>
    /// Organization that is the custodian of the patient record.
    /// FHIR Path: Patient.managingOrganization
    /// Cardinality: 0..1
    /// Reference to: Organization
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
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // 驗證 gender 值
        if (!string.IsNullOrEmpty(Gender))
        {
            var validGenders = new[] { "male", "female", "other", "unknown" };
            if (!validGenders.Contains(Gender))
            {
                yield return new ValidationResult($"Patient.gender '{Gender}' is not valid. Must be one of: {string.Join(", ", validGenders)}");
            }
        }
        
        // 驗證 birthDate 格式
        if (!string.IsNullOrEmpty(BirthDate) && !IsValidDate(BirthDate))
        {
            yield return new ValidationResult($"Patient.birthDate '{BirthDate}' is not valid. Must be YYYY, YYYY-MM, or YYYY-MM-DD format");
        }
        
        // 驗證 Choice Types
        if (DeceasedChoice != null)
        {
            var deceasedValidationContext = new ValidationContext(DeceasedChoice);
            foreach (var result in DeceasedChoice.Validate(deceasedValidationContext))
                yield return result;
        }
        
        if (MultipleBirthChoice != null)
        {
            var multipleBirthValidationContext = new ValidationContext(MultipleBirthChoice);
            foreach (var result in MultipleBirthChoice.Validate(multipleBirthValidationContext))
                yield return result;
        }
        
        // 驗證子組件
        if (Identifier != null)
        {
            foreach (var identifier in Identifier)
            {
                var identifierValidationContext = new ValidationContext(identifier);
                foreach (var result in identifier.Validate(identifierValidationContext))
                    yield return result;
            }
        }
        
        if (Name != null)
        {
            foreach (var name in Name)
            {
                var nameValidationContext = new ValidationContext(name);
                foreach (var result in name.Validate(nameValidationContext))
                    yield return result;
            }
        }
        
        if (Telecom != null)
        {
            foreach (var telecom in Telecom)
            {
                var telecomValidationContext = new ValidationContext(telecom);
                foreach (var result in telecom.Validate(telecomValidationContext))
                    yield return result;
            }
        }
        
        if (Address != null)
        {
            foreach (var address in Address)
            {
                var addressValidationContext = new ValidationContext(address);
                foreach (var result in address.Validate(addressValidationContext))
                    yield return result;
            }
        }
        
        if (MaritalStatus != null)
        {
            var maritalStatusValidationContext = new ValidationContext(MaritalStatus);
            foreach (var result in MaritalStatus.Validate(maritalStatusValidationContext))
                yield return result;
        }
        
        if (Contact != null)
        {
            foreach (var contact in Contact)
            {
                var contactValidationContext = new ValidationContext(contact);
                foreach (var result in contact.Validate(contactValidationContext))
                    yield return result;
            }
        }
        
        if (Communication != null)
        {
            foreach (var communication in Communication)
            {
                var communicationValidationContext = new ValidationContext(communication);
                foreach (var result in communication.Validate(communicationValidationContext))
                    yield return result;
            }
        }
        
        if (GeneralPractitioner != null)
        {
            foreach (var gp in GeneralPractitioner)
            {
                var gpValidationContext = new ValidationContext(gp);
                foreach (var result in gp.Validate(gpValidationContext))
                    yield return result;
            }
        }
        
        if (ManagingOrganization != null)
        {
            var managingOrgValidationContext = new ValidationContext(ManagingOrganization);
            foreach (var result in ManagingOrganization.Validate(managingOrgValidationContext))
                yield return result;
        }
        
        if (Link != null)
        {
            foreach (var link in Link)
            {
                var linkValidationContext = new ValidationContext(link);
                foreach (var result in link.Validate(linkValidationContext))
                    yield return result;
            }
        }
    }
    
    /// <summary>
    /// 驗證日期格式
    /// </summary>
    private bool IsValidDate(string value)
    {
        // YYYY format
        if (value.Length == 4 && int.TryParse(value, out var year) && year >= 1 && year <= 9999)
            return true;
            
        // YYYY-MM format
        if (value.Length == 7 && value[4] == '-' && 
            int.TryParse(value.Substring(0, 4), out year) && year >= 1 && year <= 9999 &&
            int.TryParse(value.Substring(5, 2), out var month) && month >= 1 && month <= 12)
            return true;
            
        // YYYY-MM-DD format
        if (value.Length == 10 && DateTime.TryParseExact(value, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out _))
            return true;
            
        return false;
    }
}

/// <summary>
/// A contact party (e.g. guardian, partner, friend) for the patient.
///
/// BackboneElement for Patient.Contact
/// This element is defined within the resource and contains additional
/// structured information that is part of the resource definition.
/// </summary>
public class PatientContact : BackboneElement
{
    /// <summary>
    /// The kind of relationship.
    /// FHIR Path: Patient.contact.relationship
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("relationship")]
    public List<CodeableConcept>? Relationship { get; set; }

    /// <summary>
    /// A name associated with the contact person.
    /// FHIR Path: Patient.contact.name
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("name")]
    public HumanName? Name { get; set; }

    /// <summary>
    /// A contact detail for the person.
    /// FHIR Path: Patient.contact.telecom
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("telecom")]
    public List<ContactPoint>? Telecom { get; set; }

    /// <summary>
    /// Address for the contact person.
    /// FHIR Path: Patient.contact.address
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("address")]
    public Address? Address { get; set; }

    /// <summary>
    /// Administrative Gender - the gender that the contact person is considered to have for administration and record keeping purposes.
    /// FHIR Path: Patient.contact.gender
    /// Cardinality: 0..1
    /// Allowed values: male, female, other, unknown
    /// </summary>
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    /// <summary>
    /// Organization on behalf of which the contact is acting or for which the contact is working.
    /// FHIR Path: Patient.contact.organization
    /// Cardinality: 0..1
    /// Reference to: Organization
    /// </summary>
    [JsonPropertyName("organization")]
    public Reference<Organization>? Organization { get; set; }

    /// <summary>
    /// The period during which this contact person or organization is valid to be contacted relating to this patient.
    /// FHIR Path: Patient.contact.period
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 驗證 gender 值
        if (!string.IsNullOrEmpty(Gender))
        {
            var validGenders = new[] { "male", "female", "other", "unknown" };
            if (!validGenders.Contains(Gender))
            {
                yield return new ValidationResult($"Patient.contact.gender '{Gender}' is not valid. Must be one of: {string.Join(", ", validGenders)}");
            }
        }

        // 驗證子組件
        if (Relationship != null)
        {
            foreach (var relationship in Relationship)
            {
                var relationshipValidationContext = new ValidationContext(relationship);
                foreach (var result in relationship.Validate(relationshipValidationContext))
                    yield return result;
            }
        }

        if (Name != null)
        {
            var nameValidationContext = new ValidationContext(Name);
            foreach (var result in Name.Validate(nameValidationContext))
                yield return result;
        }

        if (Telecom != null)
        {
            foreach (var telecom in Telecom)
            {
                var telecomValidationContext = new ValidationContext(telecom);
                foreach (var result in telecom.Validate(telecomValidationContext))
                    yield return result;
            }
        }

        if (Address != null)
        {
            var addressValidationContext = new ValidationContext(Address);
            foreach (var result in Address.Validate(addressValidationContext))
                yield return result;
        }

        if (Organization != null)
        {
            var organizationValidationContext = new ValidationContext(Organization);
            foreach (var result in Organization.Validate(organizationValidationContext))
                yield return result;
        }

        if (Period != null)
        {
            var periodValidationContext = new ValidationContext(Period);
            foreach (var result in Period.Validate(periodValidationContext))
                yield return result;
        }
    }
}

/// <summary>
/// A language which may be used to communicate with the patient about his or her health.
///
/// BackboneElement for Patient.Communication
/// This element is defined within the resource and contains additional
/// structured information that is part of the resource definition.
/// </summary>
public class PatientCommunication : BackboneElement
{
    /// <summary>
    /// The language which can be used to communicate with the patient about his or her health.
    /// FHIR Path: Patient.communication.language
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("language")]
    public CodeableConcept Language { get; set; } = new CodeableConcept();

    /// <summary>
    /// Language preference indicator.
    /// FHIR Path: Patient.communication.preferred
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("preferred")]
    public bool? Preferred { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Language 是必要的
        if (Language == null)
        {
            yield return new ValidationResult("Patient.communication.language is required");
        }
        else
        {
            var languageValidationContext = new ValidationContext(Language);
            foreach (var result in Language.Validate(languageValidationContext))
                yield return result;
        }
    }
}

/// <summary>
/// Link to another patient resource that concerns the same actual patient.
///
/// BackboneElement for Patient.Link
/// This element is defined within the resource and contains additional
/// structured information that is part of the resource definition.
/// </summary>
public class PatientLink : BackboneElement
{
    /// <summary>
    /// The other patient resource that the link refers to.
    /// FHIR Path: Patient.link.other
    /// Cardinality: 1..1
    /// Required: Yes
    /// Reference to: Patient, RelatedPerson
    /// </summary>
    [JsonPropertyName("other")]
    public Reference<Patient, RelatedPerson> Other { get; set; } = new Reference<Patient, RelatedPerson>();

    /// <summary>
    /// The type of link between this patient resource and another patient resource.
    /// FHIR Path: Patient.link.type
    /// Cardinality: 1..1
    /// Required: Yes
    /// Allowed values: replaced-by, replaces, refer, seealso
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Other 是必要的
        if (Other == null)
        {
            yield return new ValidationResult("Patient.link.other is required");
        }
        else
        {
            var otherValidationContext = new ValidationContext(Other);
            foreach (var result in Other.Validate(otherValidationContext))
                yield return result;
        }

        // Type 是必要的
        if (string.IsNullOrEmpty(Type))
        {
            yield return new ValidationResult("Patient.link.type is required");
        }
        else
        {
            var validTypes = new[] { "replaced-by", "replaces", "refer", "seealso" };
            if (!validTypes.Contains(Type))
            {
                yield return new ValidationResult($"Patient.link.type '{Type}' is not valid. Must be one of: {string.Join(", ", validTypes)}");
            }
        }
    }
}
