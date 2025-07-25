using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// A person who is directly or indirectly involved in the provisioning of healthcare.
/// </summary>
/// <remarks>
/// FHIR R4 Practitioner DomainResource
/// A person who is directly or indirectly involved in the provisioning of healthcare.
/// </remarks>
public class Practitioner : DomainResource
{
    /// <summary>
    /// An identifier that applies to this person in this role.
    /// FHIR Path: Practitioner.identifier
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }
    
    /// <summary>
    /// Whether this practitioner's record is in active use.
    /// FHIR Path: Practitioner.active
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
    
    /// <summary>
    /// The name(s) associated with the practitioner.
    /// FHIR Path: Practitioner.name
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("name")]
    public List<HumanName>? Name { get; set; }
    
    /// <summary>
    /// A contact detail for the practitioner.
    /// FHIR Path: Practitioner.telecom
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("telecom")]
    public List<ContactPoint>? Telecom { get; set; }
    
    /// <summary>
    /// Address(es) of the practitioner that are not role specific.
    /// FHIR Path: Practitioner.address
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("address")]
    public List<Address>? Address { get; set; }
    
    /// <summary>
    /// Administrative Gender - the gender that the person is considered to have for administration and record keeping purposes.
    /// FHIR Path: Practitioner.gender
    /// Cardinality: 0..1
    /// Allowed values: male, female, other, unknown
    /// </summary>
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }
    
    /// <summary>
    /// The date of birth for the practitioner.
    /// FHIR Path: Practitioner.birthDate
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("birthDate")]
    public string? BirthDate { get; set; }
    
    /// <summary>
    /// Image of the person.
    /// FHIR Path: Practitioner.photo
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("photo")]
    public List<Attachment>? Photo { get; set; }
    
    /// <summary>
    /// The official certifications, training, and licenses that authorize or otherwise pertain to the provision of care by the practitioner.
    /// FHIR Path: Practitioner.qualification
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("qualification")]
    public List<PractitionerQualification>? Qualification { get; set; }
    
    /// <summary>
    /// A language the practitioner can use in patient communication.
    /// FHIR Path: Practitioner.communication
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("communication")]
    public List<CodeableConcept>? Communication { get; set; }
    
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
                yield return new ValidationResult($"Practitioner.gender '{Gender}' is not valid. Must be one of: {string.Join(", ", validGenders)}");
            }
        }
        
        // 驗證 birthDate 格式
        if (!string.IsNullOrEmpty(BirthDate) && !IsValidDate(BirthDate))
        {
            yield return new ValidationResult($"Practitioner.birthDate '{BirthDate}' is not valid. Must be YYYY, YYYY-MM, or YYYY-MM-DD format");
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
        
        if (Photo != null)
        {
            foreach (var photo in Photo)
            {
                var photoValidationContext = new ValidationContext(photo);
                foreach (var result in photo.Validate(photoValidationContext))
                    yield return result;
            }
        }
        
        if (Qualification != null)
        {
            foreach (var qualification in Qualification)
            {
                var qualificationValidationContext = new ValidationContext(qualification);
                foreach (var result in qualification.Validate(qualificationValidationContext))
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
    }
    
    /// <summary>
    /// Validates the date format according to FHIR date specifications.
    /// Supports YYYY, YYYY-MM, and YYYY-MM-DD formats.
    /// </summary>
    /// <param name="value">The date string to validate.</param>
    /// <returns>True if the date format is valid; otherwise, false.</returns>
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
/// The official certifications, training, and licenses that authorize or otherwise pertain to the provision of care by the practitioner.
/// 
/// BackboneElement for Practitioner.Qualification
/// This element is defined within the resource and contains additional
/// structured information that is part of the resource definition.
/// </summary>
public class PractitionerQualification : BackboneElement
{
    /// <summary>
    /// An identifier that applies to this person's qualification in this role.
    /// FHIR Path: Practitioner.qualification.identifier
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }
    
    /// <summary>
    /// Coded representation of the qualification.
    /// FHIR Path: Practitioner.qualification.code
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; } = new CodeableConcept();
    
    /// <summary>
    /// Period during which the qualification is valid.
    /// FHIR Path: Practitioner.qualification.period
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }
    
    /// <summary>
    /// Organization that regulates and issues the qualification.
    /// FHIR Path: Practitioner.qualification.issuer
    /// Cardinality: 0..1
    /// Reference to: Organization
    /// </summary>
    [JsonPropertyName("issuer")]
    public Reference<Organization>? Issuer { get; set; }
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // Code 是必要的
        if (Code == null)
        {
            yield return new ValidationResult("Practitioner.qualification.code is required");
        }
        else
        {
            var codeValidationContext = new ValidationContext(Code);
            foreach (var result in Code.Validate(codeValidationContext))
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
        
        if (Period != null)
        {
            var periodValidationContext = new ValidationContext(Period);
            foreach (var result in Period.Validate(periodValidationContext))
                yield return result;
        }
        
        if (Issuer != null)
        {
            var issuerValidationContext = new ValidationContext(Issuer);
            foreach (var result in Issuer.Validate(issuerValidationContext))
                yield return result;
        }
    }
}
