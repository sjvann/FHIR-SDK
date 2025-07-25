using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// A formally or informally recognized grouping of people or organizations formed for the purpose of achieving some form of collective action.
/// </summary>
/// <remarks>
/// FHIR R4 Organization DomainResource
/// A formally or informally recognized grouping of people or organizations formed for the purpose of achieving some form of collective action.
/// </remarks>
public class Organization : DomainResource
{
    /// <summary>
    /// Identifies this organization across multiple systems.
    /// FHIR Path: Organization.identifier
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }
    
    /// <summary>
    /// Whether the organization's record is still in active use.
    /// FHIR Path: Organization.active
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
    
    /// <summary>
    /// Kind of organization.
    /// FHIR Path: Organization.type
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("type")]
    public List<CodeableConcept>? Type { get; set; }
    
    /// <summary>
    /// Name used for the organization.
    /// FHIR Path: Organization.name
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    /// <summary>
    /// A list of alternate names that the organization is known as, or was known as in the past.
    /// FHIR Path: Organization.alias
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("alias")]
    public List<string>? Alias { get; set; }
    
    /// <summary>
    /// A contact detail for the organization.
    /// FHIR Path: Organization.telecom
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("telecom")]
    public List<ContactPoint>? Telecom { get; set; }
    
    /// <summary>
    /// An address for the organization.
    /// FHIR Path: Organization.address
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("address")]
    public List<Address>? Address { get; set; }
    
    /// <summary>
    /// The organization of which this organization forms a part.
    /// FHIR Path: Organization.partOf
    /// Cardinality: 0..1
    /// Reference to: Organization
    /// </summary>
    [JsonPropertyName("partOf")]
    public Reference<Organization>? PartOf { get; set; }
    
    /// <summary>
    /// Contact for the organization for a certain purpose.
    /// FHIR Path: Organization.contact
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("contact")]
    public List<OrganizationContact>? Contact { get; set; }
    
    /// <summary>
    /// Technical endpoints providing access to services operated for the organization.
    /// FHIR Path: Organization.endpoint
    /// Cardinality: 0..*
    /// Reference to: Endpoint
    /// </summary>
    [JsonPropertyName("endpoint")]
    public List<Reference<Endpoint>>? Endpoint { get; set; }
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
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
        
        if (Type != null)
        {
            foreach (var type in Type)
            {
                var typeValidationContext = new ValidationContext(type);
                foreach (var result in type.Validate(typeValidationContext))
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
        
        if (PartOf != null)
        {
            var partOfValidationContext = new ValidationContext(PartOf);
            foreach (var result in PartOf.Validate(partOfValidationContext))
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
        
        if (Endpoint != null)
        {
            foreach (var endpoint in Endpoint)
            {
                var endpointValidationContext = new ValidationContext(endpoint);
                foreach (var result in endpoint.Validate(endpointValidationContext))
                    yield return result;
            }
        }
    }
}

/// <summary>
/// Contact for the organization for a certain purpose.
/// 
/// BackboneElement for Organization.Contact
/// This element is defined within the resource and contains additional
/// structured information that is part of the resource definition.
/// </summary>
public class OrganizationContact : BackboneElement
{
    /// <summary>
    /// The type of contact.
    /// FHIR Path: Organization.contact.purpose
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("purpose")]
    public CodeableConcept? Purpose { get; set; }
    
    /// <summary>
    /// A name associated with the contact.
    /// FHIR Path: Organization.contact.name
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("name")]
    public HumanName? Name { get; set; }
    
    /// <summary>
    /// Contact details (telephone, email, etc.) for a contact.
    /// FHIR Path: Organization.contact.telecom
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("telecom")]
    public List<ContactPoint>? Telecom { get; set; }
    
    /// <summary>
    /// Visiting or postal addresses for the contact.
    /// FHIR Path: Organization.contact.address
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("address")]
    public Address? Address { get; set; }
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // 驗證子組件
        if (Purpose != null)
        {
            var purposeValidationContext = new ValidationContext(Purpose);
            foreach (var result in Purpose.Validate(purposeValidationContext))
                yield return result;
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
    }
}
