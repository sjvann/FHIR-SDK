// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// The details of a healthcare service available at a location or in a catalog. In the case where there
/// is a hierarchy of services (for example, Lab -&gt; Pathology -&gt; Wound Cultures), this can be
/// represented using a set of linked HealthcareServices.
/// </summary>
public class HealthcareService : DomainResource
{
    public override string ResourceType => "HealthcareService";

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
    /// External identifiers for this item.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// This flag is used to mark the record to not be used. This is not used when a center is closed for
    /// maintenance, or for holidays, the notAvailable period is to be used for this.
    /// </summary>
    [FhirElement("active", Order = 19)]
    [Cardinality(0, 1)]
    [JsonPropertyName("active")]
    public FhirBoolean? Active { get; set; }

    /// <summary>
    /// The organization that provides this healthcare service.
    /// </summary>
    [FhirElement("providedBy", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("providedBy")]
    public Reference<Organization> ProvidedBy { get; set; }

    /// <summary>
    /// When the HealthcareService is representing a specific, schedulable service, the availableIn property
    /// can refer to a generic service.
    /// </summary>
    [FhirElement("offeredIn", Order = 21)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("offeredIn")]
    public List<Reference<HealthcareService>>? OfferedIn { get; set; }

    /// <summary>
    /// Identifies the broad category of service being performed or delivered.
    /// </summary>
    [FhirElement("category", Order = 22)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// The specific type of service that may be delivered or performed.
    /// </summary>
    [FhirElement("type", Order = 23)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("type")]
    public List<CodeableConcept>? Type { get; set; }

    /// <summary>
    /// Collection of specialties handled by the Healthcare service. This is more of a medical term.
    /// </summary>
    [FhirElement("specialty", Order = 24)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("specialty")]
    public List<CodeableConcept>? Specialty { get; set; }

    /// <summary>
    /// The location(s) where this healthcare service may be provided.
    /// </summary>
    [FhirElement("location", Order = 25)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("location")]
    public List<Reference<Location>>? Location { get; set; }

    /// <summary>
    /// Further description of the service as it would be presented to a consumer while searching.
    /// </summary>
    [FhirElement("name", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("name")]
    public FhirString? Name { get; set; }

    /// <summary>
    /// Any additional description of the service and/or any specific issues not covered by the other
    /// attributes, which can be displayed as further detail under the serviceName.
    /// </summary>
    [FhirElement("comment", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("comment")]
    public FhirMarkdown? Comment { get; set; }

    /// <summary>
    /// Extra details about the service that can&apos;t be placed in the other fields.
    /// </summary>
    [FhirElement("extraDetails", Order = 28)]
    [Cardinality(0, 1)]
    [JsonPropertyName("extraDetails")]
    public FhirMarkdown? ExtraDetails { get; set; }

    /// <summary>
    /// If there is a photo/symbol associated with this HealthcareService, it may be included here to
    /// facilitate quick identification of the service in a list.
    /// </summary>
    [FhirElement("photo", Order = 29)]
    [Cardinality(0, 1)]
    [JsonPropertyName("photo")]
    public Attachment Photo { get; set; }

    /// <summary>
    /// The contact details of communication devices available relevant to the specific HealthcareService.
    /// This can include addresses, phone numbers, fax numbers, mobile numbers, email addresses and web
    /// sites.
    /// </summary>
    [FhirElement("contact", Order = 30)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("contact")]
    public List<ExtendedContactDetail>? Contact { get; set; }

    /// <summary>
    /// The location(s) that this service is available to (not where the service is provided).
    /// </summary>
    [FhirElement("coverageArea", Order = 31)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("coverageArea")]
    public List<Reference<Location>>? CoverageArea { get; set; }

    /// <summary>
    /// The code(s) that detail the conditions under which the healthcare service is available/offered.
    /// </summary>
    [FhirElement("serviceProvisionCode", Order = 32)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("serviceProvisionCode")]
    public List<CodeableConcept>? ServiceProvisionCode { get; set; }

    /// <summary>
    /// Does this service have specific eligibility requirements that need to be met in order to use the
    /// service?
    /// </summary>
    [FhirElement("eligibility", Order = 33)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("eligibility")]
    public List<BackboneElement>? Eligibility { get; set; }

    /// <summary>
    /// Programs that this service is applicable to.
    /// </summary>
    [FhirElement("program", Order = 34)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("program")]
    public List<CodeableConcept>? Program { get; set; }

    /// <summary>
    /// Collection of characteristics (attributes).
    /// </summary>
    [FhirElement("characteristic", Order = 35)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("characteristic")]
    public List<CodeableConcept>? Characteristic { get; set; }

    /// <summary>
    /// Some services are specifically made available in multiple languages, this property permits a
    /// directory to declare the languages this is offered in. Typically this is only provided where a
    /// service operates in communities with mixed languages used.
    /// </summary>
    [FhirElement("communication", Order = 36)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("communication")]
    public List<CodeableConcept>? Communication { get; set; }

    /// <summary>
    /// Ways that the service accepts referrals, if this is not provided then it is implied that no referral
    /// is required.
    /// </summary>
    [FhirElement("referralMethod", Order = 37)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("referralMethod")]
    public List<CodeableConcept>? ReferralMethod { get; set; }

    /// <summary>
    /// Indicates whether or not a prospective consumer will require an appointment for a particular service
    /// at a site to be provided by the Organization. Indicates if an appointment is required for access to
    /// this service.
    /// </summary>
    [FhirElement("appointmentRequired", Order = 38)]
    [Cardinality(0, 1)]
    [JsonPropertyName("appointmentRequired")]
    public FhirBoolean? AppointmentRequired { get; set; }

    /// <summary>
    /// A collection of times that the healthcare service is available.
    /// </summary>
    [FhirElement("availability", Order = 39)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("availability")]
    public List<Availability>? Availability { get; set; }

    /// <summary>
    /// Technical endpoints providing access to services operated for the specific healthcare services
    /// defined at this resource.
    /// </summary>
    [FhirElement("endpoint", Order = 40)]
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
        // Validate HealthcareService cardinality
        var healthcareserviceCount = HealthcareService?.Count ?? 0;
        if (healthcareserviceCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService' cardinality must be 0..*", new[] { nameof(HealthcareService) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate OfferedIn cardinality
        var offeredinCount = OfferedIn?.Count ?? 0;
        if (offeredinCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.offeredIn' cardinality must be 0..*", new[] { nameof(OfferedIn) });
        }
        // Validate Category cardinality
        var categoryCount = Category?.Count ?? 0;
        if (categoryCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.category' cardinality must be 0..*", new[] { nameof(Category) });
        }
        // Validate Type cardinality
        var typeCount = Type?.Count ?? 0;
        if (typeCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.type' cardinality must be 0..*", new[] { nameof(Type) });
        }
        // Validate Specialty cardinality
        var specialtyCount = Specialty?.Count ?? 0;
        if (specialtyCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.specialty' cardinality must be 0..*", new[] { nameof(Specialty) });
        }
        // Validate Location cardinality
        var locationCount = Location?.Count ?? 0;
        if (locationCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.location' cardinality must be 0..*", new[] { nameof(Location) });
        }
        // Validate Contact cardinality
        var contactCount = Contact?.Count ?? 0;
        if (contactCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.contact' cardinality must be 0..*", new[] { nameof(Contact) });
        }
        // Validate CoverageArea cardinality
        var coverageareaCount = CoverageArea?.Count ?? 0;
        if (coverageareaCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.coverageArea' cardinality must be 0..*", new[] { nameof(CoverageArea) });
        }
        // Validate ServiceProvisionCode cardinality
        var serviceprovisioncodeCount = ServiceProvisionCode?.Count ?? 0;
        if (serviceprovisioncodeCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.serviceProvisionCode' cardinality must be 0..*", new[] { nameof(ServiceProvisionCode) });
        }
        // Validate Eligibility cardinality
        var eligibilityCount = Eligibility?.Count ?? 0;
        if (eligibilityCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.eligibility' cardinality must be 0..*", new[] { nameof(Eligibility) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.eligibility.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.eligibility.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Program cardinality
        var programCount = Program?.Count ?? 0;
        if (programCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.program' cardinality must be 0..*", new[] { nameof(Program) });
        }
        // Validate Characteristic cardinality
        var characteristicCount = Characteristic?.Count ?? 0;
        if (characteristicCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.characteristic' cardinality must be 0..*", new[] { nameof(Characteristic) });
        }
        // Validate Communication cardinality
        var communicationCount = Communication?.Count ?? 0;
        if (communicationCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.communication' cardinality must be 0..*", new[] { nameof(Communication) });
        }
        // Validate ReferralMethod cardinality
        var referralmethodCount = ReferralMethod?.Count ?? 0;
        if (referralmethodCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.referralMethod' cardinality must be 0..*", new[] { nameof(ReferralMethod) });
        }
        // Validate Availability cardinality
        var availabilityCount = Availability?.Count ?? 0;
        if (availabilityCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.availability' cardinality must be 0..*", new[] { nameof(Availability) });
        }
        // Validate Endpoint cardinality
        var endpointCount = Endpoint?.Count ?? 0;
        if (endpointCount < 0)
        {
            yield return new ValidationResult("Element 'HealthcareService.endpoint' cardinality must be 0..*", new[] { nameof(Endpoint) });
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
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(HealthcareService) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(HealthcareService) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(HealthcareService) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(HealthcareService) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(HealthcareService) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ProvidedBy) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(OfferedIn) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Category) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Name) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Comment) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ExtraDetails) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Photo) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CoverageArea) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ServiceProvisionCode) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Eligibility) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Comment) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Program) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ReferralMethod) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(AppointmentRequired) });
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
