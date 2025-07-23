// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A specific set of Roles/Locations/specialties/services that a practitioner may perform, or has
/// performed at an organization during a period of time.
/// </summary>
public class PractitionerRole : DomainResource
{
    public override string ResourceType => "PractitionerRole";

    /// <summary>
    /// The logical id of the resource, as used in the URL for the resource. Once assigned, this value never
    /// changes.
    /// </summary>
    [FhirElement("id", Order = 10)]
    [Cardinality(0, 1)]
    [JsonPropertyName("id")]
    public FhirString? Id { get; set; }

    /// <summary>
    /// The metadata about the resource. This is content that is maintained by the infrastructure. Changes
    /// to the content might not always be associated with version changes to the resource.
    /// </summary>
    [FhirElement("meta", Order = 11)]
    [Cardinality(0, 1)]
    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }

    /// <summary>
    /// A reference to a set of rules that were followed when the resource was constructed, and which must
    /// be understood when processing the content. Often, this is a reference to an implementation guide
    /// that defines the special rules along with other profiles etc.
    /// </summary>
    [FhirElement("implicitRules", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("implicitRules")]
    public FhirUri? ImplicitRules { get; set; }

    /// <summary>
    /// The base language in which the resource is written.
    /// </summary>
    [FhirElement("language", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("language")]
    public FhirCode? Language { get; set; }

    /// <summary>
    /// A human-readable narrative that contains a summary of the resource and can be used to represent the
    /// content of the resource to a human. The narrative need not encode all the structured data, but is
    /// required to contain sufficient detail to make it &quot;clinically safe&quot; for a human to just
    /// read the narrative. Resource definitions may define what content should be represented in the
    /// narrative to ensure clinical safety.
    /// </summary>
    [FhirElement("text", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("text")]
    public Narrative Text { get; set; }

    /// <summary>
    /// These resources do not have an independent existence apart from the resource that contains them -
    /// they cannot be identified independently, nor can they have their own independent transaction scope.
    /// This is allowed to be a Parameters resource if and only if it is referenced by a resource that
    /// provides context/meaning.
    /// </summary>
    [FhirElement("contained", Order = 15)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("contained")]
    public List<Resource>? Contained { get; set; }

    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the
    /// resource. To make the use of extensions safe and managable, there is a strict set of governance
    /// applied to the definition and use of extensions. Though any implementer can define an extension,
    /// there is a set of requirements that SHALL be met as part of the definition of the extension.
    /// </summary>
    [FhirElement("extension", Order = 16)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }

    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the
    /// resource and that modifies the understanding of the element that contains it and/or the
    /// understanding of the containing element&apos;s descendants. Usually modifier elements provide
    /// negation or qualification. To make the use of extensions safe and managable, there is a strict set
    /// of governance applied to the definition and use of extensions. Though any implementer is allowed to
    /// define an extension, there is a set of requirements that SHALL be met as part of the definition of
    /// the extension. Applications processing a resource are required to check for modifier extensions.
    /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource
    /// (including cannot change the meaning of modifierExtension itself).
    /// </summary>
    [FhirElement("modifierExtension", Order = 17)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("modifierExtension")]
    public List<Extension>? ModifierExtension { get; set; }

    /// <summary>
    /// Business Identifiers that are specific to a role/location.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// Whether this practitioner role record is in active use. Some systems may use this property to mark
    /// non-active practitioners, such as those that are not currently employed.
    /// </summary>
    [FhirElement("active", Order = 19)]
    [Cardinality(0, 1)]
    [JsonPropertyName("active")]
    public FhirBoolean? Active { get; set; }

    /// <summary>
    /// The period during which the person is authorized to act as a practitioner in these role(s) for the
    /// organization.
    /// </summary>
    [FhirElement("period", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("period")]
    public Period Period { get; set; }

    /// <summary>
    /// Practitioner that is able to provide the defined services for the organization.
    /// </summary>
    [FhirElement("practitioner", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("practitioner")]
    public Reference<Practitioner> Practitioner { get; set; }

    /// <summary>
    /// The organization where the Practitioner performs the roles associated.
    /// </summary>
    [FhirElement("organization", Order = 22)]
    [Cardinality(0, 1)]
    [JsonPropertyName("organization")]
    public Reference<Organization> Organization { get; set; }

    /// <summary>
    /// Roles which this practitioner is authorized to perform for the organization.
    /// </summary>
    [FhirElement("code", Order = 23)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("code")]
    public List<CodeableConcept>? Code { get; set; }

    /// <summary>
    /// The specialty of a practitioner that describes the functional role they are practicing at a given
    /// organization or location.
    /// </summary>
    [FhirElement("specialty", Order = 24)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("specialty")]
    public List<CodeableConcept>? Specialty { get; set; }

    /// <summary>
    /// The location(s) at which this practitioner provides care.
    /// </summary>
    [FhirElement("location", Order = 25)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("location")]
    public List<Reference<Location>>? Location { get; set; }

    /// <summary>
    /// The list of healthcare services that this worker provides for this role&apos;s
    /// Organization/Location(s).
    /// </summary>
    [FhirElement("healthcareService", Order = 26)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("healthcareService")]
    public List<Reference<HealthcareService>>? HealthcareService { get; set; }

    /// <summary>
    /// The contact details of communication devices available relevant to the specific PractitionerRole.
    /// This can include addresses, phone numbers, fax numbers, mobile numbers, email addresses and web
    /// sites.
    /// </summary>
    [FhirElement("contact", Order = 27)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("contact")]
    public List<ExtendedContactDetail>? Contact { get; set; }

    /// <summary>
    /// Collection of characteristics (attributes).
    /// </summary>
    [FhirElement("characteristic", Order = 28)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("characteristic")]
    public List<CodeableConcept>? Characteristic { get; set; }

    /// <summary>
    /// A language the practitioner can use in patient communication. The practitioner may know several
    /// languages (listed in practitioner.communication), however these are the languages that could be
    /// advertised in a directory for a patient to search.
    /// </summary>
    [FhirElement("communication", Order = 29)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("communication")]
    public List<CodeableConcept>? Communication { get; set; }

    /// <summary>
    /// A collection of times the practitioner is available or performing this role at the location and/or
    /// healthcareservice.
    /// </summary>
    [FhirElement("availability", Order = 30)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("availability")]
    public List<Availability>? Availability { get; set; }

    /// <summary>
    /// Technical endpoints providing access to services operated for the practitioner with this role.
    /// Commonly used for locating scheduling services, or identifying where to send referrals
    /// electronically.
    /// </summary>
    [FhirElement("endpoint", Order = 31)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("endpoint")]
    public List<Reference<Endpoint>>? Endpoint { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate PractitionerRole cardinality
        var practitionerroleCount = PractitionerRole?.Count ?? 0;
        if (practitionerroleCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole' cardinality must be 0..*", new[] { nameof(PractitionerRole) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate Code cardinality
        var codeCount = Code?.Count ?? 0;
        if (codeCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.code' cardinality must be 0..*", new[] { nameof(Code) });
        }
        // Validate Specialty cardinality
        var specialtyCount = Specialty?.Count ?? 0;
        if (specialtyCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.specialty' cardinality must be 0..*", new[] { nameof(Specialty) });
        }
        // Validate Location cardinality
        var locationCount = Location?.Count ?? 0;
        if (locationCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.location' cardinality must be 0..*", new[] { nameof(Location) });
        }
        // Validate HealthcareService cardinality
        var healthcareserviceCount = HealthcareService?.Count ?? 0;
        if (healthcareserviceCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.healthcareService' cardinality must be 0..*", new[] { nameof(HealthcareService) });
        }
        // Validate Contact cardinality
        var contactCount = Contact?.Count ?? 0;
        if (contactCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.contact' cardinality must be 0..*", new[] { nameof(Contact) });
        }
        // Validate Characteristic cardinality
        var characteristicCount = Characteristic?.Count ?? 0;
        if (characteristicCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.characteristic' cardinality must be 0..*", new[] { nameof(Characteristic) });
        }
        // Validate Communication cardinality
        var communicationCount = Communication?.Count ?? 0;
        if (communicationCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.communication' cardinality must be 0..*", new[] { nameof(Communication) });
        }
        // Validate Availability cardinality
        var availabilityCount = Availability?.Count ?? 0;
        if (availabilityCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.availability' cardinality must be 0..*", new[] { nameof(Availability) });
        }
        // Validate Endpoint cardinality
        var endpointCount = Endpoint?.Count ?? 0;
        if (endpointCount < 0)
        {
            yield return new ValidationResult("Element 'PractitionerRole.endpoint' cardinality must be 0..*", new[] { nameof(Endpoint) });
        }

        // ValueSet binding validation
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Communication ValueSet binding
        if (Communication != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(PractitionerRole) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(PractitionerRole) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(PractitionerRole) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(PractitionerRole) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(PractitionerRole) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Meta) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ImplicitRules) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Language) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Text) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Extension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(Extension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Identifier) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Active) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Period) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Practitioner) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Organization) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Specialty) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Location) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(HealthcareService) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Contact) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Characteristic) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Communication) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Availability) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Endpoint) });
        // }
    }

}
