// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A record of a request for service such as diagnostic investigations, treatments, or operations to be
/// performed.
/// </summary>
public class ServiceRequest : DomainResource
{
    public override string ResourceType => "ServiceRequest";

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
    /// Identifiers assigned to this order instance by the orderer and/or the receiver and/or order
    /// fulfiller.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The URL pointing to a FHIR-defined protocol, guideline, orderset or other definition that is adhered
    /// to in whole or in part by this ServiceRequest.
    /// </summary>
    [FhirElement("instantiatesCanonical", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("instantiatesCanonical")]
    public List<FhirCanonical>? InstantiatesCanonical { get; set; }

    /// <summary>
    /// The URL pointing to an externally maintained protocol, guideline, orderset or other definition that
    /// is adhered to in whole or in part by this ServiceRequest.
    /// </summary>
    [FhirElement("instantiatesUri", Order = 20)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("instantiatesUri")]
    public List<FhirUri>? InstantiatesUri { get; set; }

    /// <summary>
    /// Plan/proposal/order fulfilled by this request.
    /// </summary>
    [FhirElement("basedOn", Order = 21)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("basedOn")]
    public List<Reference<CarePlan>>? BasedOn { get; set; }

    /// <summary>
    /// The request takes the place of the referenced completed or terminated request(s).
    /// </summary>
    [FhirElement("replaces", Order = 22)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("replaces")]
    public List<Reference<ServiceRequest>>? Replaces { get; set; }

    /// <summary>
    /// A shared identifier common to all service requests that were authorized more or less simultaneously
    /// by a single author, representing the composite or group identifier.
    /// </summary>
    [FhirElement("requisition", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("requisition")]
    public Identifier Requisition { get; set; }

    /// <summary>
    /// The status of the order.
    /// </summary>
    [FhirElement("status", Order = 24)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Whether the request is a proposal, plan, an original order or a reflex order.
    /// </summary>
    [FhirElement("intent", Order = 25)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("intent")]
    public FhirCode Intent { get; set; }

    /// <summary>
    /// A code that classifies the service for searching, sorting and display purposes (e.g. &quot;Surgical
    /// Procedure&quot;).
    /// </summary>
    [FhirElement("category", Order = 26)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// Indicates how quickly the ServiceRequest should be addressed with respect to other requests.
    /// </summary>
    [FhirElement("priority", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("priority")]
    public FhirCode? Priority { get; set; }

    /// <summary>
    /// Set this to true if the record is saying that the service/procedure should NOT be performed.
    /// </summary>
    [FhirElement("doNotPerform", Order = 28)]
    [Cardinality(0, 1)]
    [JsonPropertyName("doNotPerform")]
    public FhirBoolean? DoNotPerform { get; set; }

    /// <summary>
    /// A code or reference that identifies a particular service (i.e., procedure, diagnostic investigation,
    /// or panel of investigations) that have been requested.
    /// </summary>
    [FhirElement("code", Order = 29)]
    [Cardinality(0, 1)]
    [JsonPropertyName("code")]
    public CodeableReference Code { get; set; }

    /// <summary>
    /// Additional details and instructions about the how the services are to be delivered. For example, and
    /// order for a urinary catheter may have an order detail for an external or indwelling catheter, or an
    /// order for a bandage may require additional instructions specifying how the bandage should be
    /// applied.
    /// </summary>
    [FhirElement("orderDetail", Order = 30)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("orderDetail")]
    public List<BackboneElement>? OrderDetail { get; set; }

    /// <summary>
    /// An amount of service being requested which can be a quantity ( for example $1,500 home
    /// modification), a ratio ( for example, 20 half day visits per month), or a range (2.0 to 1.8 Gy per
    /// fraction). (as Quantity)
    /// </summary>
    [FhirElement("quantityQuantity", Order = 31)]
    [Cardinality(0, 1)]
    [ChoiceType("quantity", "quantity")]
    [JsonPropertyName("quantityQuantity")]
    public Quantity QuantityQuantity { get; set; }

    /// <summary>
    /// An amount of service being requested which can be a quantity ( for example $1,500 home
    /// modification), a ratio ( for example, 20 half day visits per month), or a range (2.0 to 1.8 Gy per
    /// fraction). (as Ratio)
    /// </summary>
    [FhirElement("quantityRatio", Order = 32)]
    [Cardinality(0, 1)]
    [ChoiceType("quantity", "ratio")]
    [JsonPropertyName("quantityRatio")]
    public Ratio QuantityRatio { get; set; }

    /// <summary>
    /// An amount of service being requested which can be a quantity ( for example $1,500 home
    /// modification), a ratio ( for example, 20 half day visits per month), or a range (2.0 to 1.8 Gy per
    /// fraction). (as Range)
    /// </summary>
    [FhirElement("quantityRange", Order = 33)]
    [Cardinality(0, 1)]
    [ChoiceType("quantity", "range")]
    [JsonPropertyName("quantityRange")]
    public Range QuantityRange { get; set; }

    /// <summary>
    /// On whom or what the service is to be performed. This is usually a human patient, but can also be
    /// requested on animals, groups of humans or animals, devices such as dialysis machines, or even
    /// locations (typically for environmental scans).
    /// </summary>
    [FhirElement("subject", Order = 34)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("subject")]
    public Reference<Patient> Subject { get; set; }

    /// <summary>
    /// The actual focus of a service request when it is not the subject of record representing something or
    /// someone associated with the subject such as a spouse, parent, fetus, or donor. The focus of a
    /// service request could also be an existing condition, an intervention, the subject&apos;s diet,
    /// another service request on the subject, or a body structure such as tumor or implanted device.
    /// </summary>
    [FhirElement("focus", Order = 35)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("focus")]
    public List<Reference<Resource>>? Focus { get; set; }

    /// <summary>
    /// An encounter that provides additional information about the healthcare context in which this request
    /// is made.
    /// </summary>
    [FhirElement("encounter", Order = 36)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// The date/time at which the requested service should occur. (as dateTime)
    /// </summary>
    [FhirElement("occurrenceDateTime", Order = 37)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "dateTime")]
    [JsonPropertyName("occurrenceDateTime")]
    public FhirDateTime? OccurrenceDateTime { get; set; }

    /// <summary>
    /// The date/time at which the requested service should occur. (as Period)
    /// </summary>
    [FhirElement("occurrencePeriod", Order = 38)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "period")]
    [JsonPropertyName("occurrencePeriod")]
    public Period OccurrencePeriod { get; set; }

    /// <summary>
    /// The date/time at which the requested service should occur. (as Timing)
    /// </summary>
    [FhirElement("occurrenceTiming", Order = 39)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "timing")]
    [JsonPropertyName("occurrenceTiming")]
    public Timing OccurrenceTiming { get; set; }

    /// <summary>
    /// If a CodeableConcept is present, it indicates the pre-condition for performing the service. For
    /// example &quot;pain&quot;, &quot;on flare-up&quot;, etc. (as boolean)
    /// </summary>
    [FhirElement("asNeededBoolean", Order = 40)]
    [Cardinality(0, 1)]
    [ChoiceType("asNeeded", "boolean")]
    [JsonPropertyName("asNeededBoolean")]
    public FhirBoolean? AsNeededBoolean { get; set; }

    /// <summary>
    /// If a CodeableConcept is present, it indicates the pre-condition for performing the service. For
    /// example &quot;pain&quot;, &quot;on flare-up&quot;, etc. (as CodeableConcept)
    /// </summary>
    [FhirElement("asNeededCodeableConcept", Order = 41)]
    [Cardinality(0, 1)]
    [ChoiceType("asNeeded", "codeableConcept")]
    [JsonPropertyName("asNeededCodeableConcept")]
    public CodeableConcept AsNeededCodeableConcept { get; set; }

    /// <summary>
    /// When the request transitioned to being actionable.
    /// </summary>
    [FhirElement("authoredOn", Order = 42)]
    [Cardinality(0, 1)]
    [JsonPropertyName("authoredOn")]
    public FhirDateTime? AuthoredOn { get; set; }

    /// <summary>
    /// The individual who initiated the request and has responsibility for its activation.
    /// </summary>
    [FhirElement("requester", Order = 43)]
    [Cardinality(0, 1)]
    [JsonPropertyName("requester")]
    public Reference<Practitioner> Requester { get; set; }

    /// <summary>
    /// Desired type of performer for doing the requested service.
    /// </summary>
    [FhirElement("performerType", Order = 44)]
    [Cardinality(0, 1)]
    [JsonPropertyName("performerType")]
    public CodeableConcept PerformerType { get; set; }

    /// <summary>
    /// The desired performer for doing the requested service. For example, the surgeon, dermatopathologist,
    /// endoscopist, etc.
    /// </summary>
    [FhirElement("performer", Order = 45)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("performer")]
    public List<Reference<Practitioner>>? Performer { get; set; }

    /// <summary>
    /// The preferred location(s) where the procedure should actually happen in coded or free text form.
    /// E.g. at home or nursing day care center.
    /// </summary>
    [FhirElement("location", Order = 46)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("location")]
    public List<CodeableReference>? Location { get; set; }

    /// <summary>
    /// An explanation or justification for why this service is being requested in coded or textual form.
    /// This is often for billing purposes. May relate to the resources referred to in `supportingInfo`.
    /// </summary>
    [FhirElement("reason", Order = 47)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("reason")]
    public List<CodeableReference>? Reason { get; set; }

    /// <summary>
    /// Insurance plans, coverage extensions, pre-authorizations and/or pre-determinations that may be
    /// needed for delivering the requested service.
    /// </summary>
    [FhirElement("insurance", Order = 48)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("insurance")]
    public List<Reference<Coverage>>? Insurance { get; set; }

    /// <summary>
    /// Additional clinical information about the patient or specimen that may influence the services or
    /// their interpretations. This information includes diagnosis, clinical findings and other
    /// observations. In laboratory ordering these are typically referred to as &quot;ask at order entry
    /// questions (AOEs)&quot;. This includes observations explicitly requested by the producer (filler) to
    /// provide context or supporting information needed to complete the order. For example, reporting the
    /// amount of inspired oxygen for blood gas measurements.
    /// </summary>
    [FhirElement("supportingInfo", Order = 49)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("supportingInfo")]
    public List<CodeableReference>? SupportingInfo { get; set; }

    /// <summary>
    /// One or more specimens that the laboratory procedure will use.
    /// </summary>
    [FhirElement("specimen", Order = 50)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("specimen")]
    public List<Reference<Specimen>>? Specimen { get; set; }

    /// <summary>
    /// Anatomic location where the procedure should be performed. This is the target site.
    /// </summary>
    [FhirElement("bodySite", Order = 51)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("bodySite")]
    public List<CodeableConcept>? BodySite { get; set; }

    /// <summary>
    /// Anatomic location where the procedure should be performed. This is the target site.
    /// </summary>
    [FhirElement("bodyStructure", Order = 52)]
    [Cardinality(0, 1)]
    [JsonPropertyName("bodyStructure")]
    public Reference<BodyStructure> BodyStructure { get; set; }

    /// <summary>
    /// Any other notes and comments made about the service request. For example, internal billing notes.
    /// </summary>
    [FhirElement("note", Order = 53)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// Instructions in terms that are understood by the patient or consumer.
    /// </summary>
    [FhirElement("patientInstruction", Order = 54)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("patientInstruction")]
    public List<BackboneElement>? PatientInstruction { get; set; }

    /// <summary>
    /// Key events in the history of the request.
    /// </summary>
    [FhirElement("relevantHistory", Order = 55)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("relevantHistory")]
    public List<Reference<Provenance>>? RelevantHistory { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for quantity[x]
        var quantityProperties = new[] { nameof(QuantityQuantity), nameof(QuantityRatio), nameof(QuantityRange) };
        var quantitySetCount = quantityProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (quantitySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of QuantityQuantity, QuantityRatio, QuantityRange may be specified",
                new[] { nameof(QuantityQuantity), nameof(QuantityRatio), nameof(QuantityRange) });
        }

        // Choice Type validation for occurrence[x]
        var occurrenceProperties = new[] { nameof(OccurrenceDateTime), nameof(OccurrencePeriod), nameof(OccurrenceTiming) };
        var occurrenceSetCount = occurrenceProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (occurrenceSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of OccurrenceDateTime, OccurrencePeriod, OccurrenceTiming may be specified",
                new[] { nameof(OccurrenceDateTime), nameof(OccurrencePeriod), nameof(OccurrenceTiming) });
        }

        // Choice Type validation for asNeeded[x]
        var asNeededProperties = new[] { nameof(AsNeededBoolean), nameof(AsNeededCodeableConcept) };
        var asNeededSetCount = asNeededProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (asNeededSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of AsNeededBoolean, AsNeededCodeableConcept may be specified",
                new[] { nameof(AsNeededBoolean), nameof(AsNeededCodeableConcept) });
        }

    }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate ServiceRequest cardinality
        var servicerequestCount = ServiceRequest?.Count ?? 0;
        if (servicerequestCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest' cardinality must be 0..*", new[] { nameof(ServiceRequest) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate InstantiatesCanonical cardinality
        var instantiatescanonicalCount = InstantiatesCanonical?.Count ?? 0;
        if (instantiatescanonicalCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.instantiatesCanonical' cardinality must be 0..*", new[] { nameof(InstantiatesCanonical) });
        }
        // Validate InstantiatesUri cardinality
        var instantiatesuriCount = InstantiatesUri?.Count ?? 0;
        if (instantiatesuriCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.instantiatesUri' cardinality must be 0..*", new[] { nameof(InstantiatesUri) });
        }
        // Validate BasedOn cardinality
        var basedonCount = BasedOn?.Count ?? 0;
        if (basedonCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.basedOn' cardinality must be 0..*", new[] { nameof(BasedOn) });
        }
        // Validate Replaces cardinality
        var replacesCount = Replaces?.Count ?? 0;
        if (replacesCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.replaces' cardinality must be 0..*", new[] { nameof(Replaces) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'ServiceRequest.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        if (Intent == null)
        {
            yield return new ValidationResult("Element 'ServiceRequest.intent' cardinality must be 1..1", new[] { nameof(Intent) });
        }
        // Validate Category cardinality
        var categoryCount = Category?.Count ?? 0;
        if (categoryCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.category' cardinality must be 0..*", new[] { nameof(Category) });
        }
        // Validate OrderDetail cardinality
        var orderdetailCount = OrderDetail?.Count ?? 0;
        if (orderdetailCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.orderDetail' cardinality must be 0..*", new[] { nameof(OrderDetail) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.orderDetail.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.orderDetail.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Parameter cardinality
        var parameterCount = Parameter?.Count ?? 0;
        if (parameterCount < 1)
        {
            yield return new ValidationResult("Element 'ServiceRequest.orderDetail.parameter' cardinality must be 1..*", new[] { nameof(Parameter) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.orderDetail.parameter.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.orderDetail.parameter.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Code == null)
        {
            yield return new ValidationResult("Element 'ServiceRequest.orderDetail.parameter.code' cardinality must be 1..1", new[] { nameof(Code) });
        }
        if (Value == null)
        {
            yield return new ValidationResult("Element 'ServiceRequest.orderDetail.parameter.value[x]' cardinality must be 1..1", new[] { nameof(Value) });
        }
        if (Subject == null)
        {
            yield return new ValidationResult("Element 'ServiceRequest.subject' cardinality must be 1..1", new[] { nameof(Subject) });
        }
        // Validate Focus cardinality
        var focusCount = Focus?.Count ?? 0;
        if (focusCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.focus' cardinality must be 0..*", new[] { nameof(Focus) });
        }
        // Validate Performer cardinality
        var performerCount = Performer?.Count ?? 0;
        if (performerCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.performer' cardinality must be 0..*", new[] { nameof(Performer) });
        }
        // Validate Location cardinality
        var locationCount = Location?.Count ?? 0;
        if (locationCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.location' cardinality must be 0..*", new[] { nameof(Location) });
        }
        // Validate Reason cardinality
        var reasonCount = Reason?.Count ?? 0;
        if (reasonCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.reason' cardinality must be 0..*", new[] { nameof(Reason) });
        }
        // Validate Insurance cardinality
        var insuranceCount = Insurance?.Count ?? 0;
        if (insuranceCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.insurance' cardinality must be 0..*", new[] { nameof(Insurance) });
        }
        // Validate SupportingInfo cardinality
        var supportinginfoCount = SupportingInfo?.Count ?? 0;
        if (supportinginfoCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.supportingInfo' cardinality must be 0..*", new[] { nameof(SupportingInfo) });
        }
        // Validate Specimen cardinality
        var specimenCount = Specimen?.Count ?? 0;
        if (specimenCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.specimen' cardinality must be 0..*", new[] { nameof(Specimen) });
        }
        // Validate BodySite cardinality
        var bodysiteCount = BodySite?.Count ?? 0;
        if (bodysiteCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.bodySite' cardinality must be 0..*", new[] { nameof(BodySite) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.note' cardinality must be 0..*", new[] { nameof(Note) });
        }
        // Validate PatientInstruction cardinality
        var patientinstructionCount = PatientInstruction?.Count ?? 0;
        if (patientinstructionCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.patientInstruction' cardinality must be 0..*", new[] { nameof(PatientInstruction) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.patientInstruction.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.patientInstruction.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate RelevantHistory cardinality
        var relevanthistoryCount = RelevantHistory?.Count ?? 0;
        if (relevanthistoryCount < 0)
        {
            yield return new ValidationResult("Element 'ServiceRequest.relevantHistory' cardinality must be 0..*", new[] { nameof(RelevantHistory) });
        }

        // ValueSet binding validation
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Status ValueSet binding
        if (Status != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/request-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Intent ValueSet binding
        if (Intent != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/request-intent|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Priority ValueSet binding
        if (Priority != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/request-priority|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: bdystr-1
        // Expression: bodySite.exists() implies bodyStructure.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("bodySite.exists() implies bodyStructure.empty()"))
        // {
        //     yield return new ValidationResult("bodyStructure SHALL only be present if bodySite is not present", new[] { nameof(ServiceRequest) });
        // }
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(ServiceRequest) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(ServiceRequest) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(ServiceRequest) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(ServiceRequest) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(ServiceRequest) });
        // }
        // Constraint: prr-1
        // Expression: orderDetail.empty() or code.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("orderDetail.empty() or code.exists()"))
        // {
        //     yield return new ValidationResult("orderDetail SHALL only be present if code is present", new[] { nameof(ServiceRequest) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(InstantiatesCanonical) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(InstantiatesUri) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BasedOn) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Replaces) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Requisition) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Status) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Intent) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Priority) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DoNotPerform) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(OrderDetail) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ParameterFocus) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Parameter) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Value) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Quantity) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Subject) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Focus) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Encounter) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Occurrence) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(AsNeeded) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(AuthoredOn) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Requester) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PerformerType) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Performer) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Reason) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Insurance) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SupportingInfo) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Specimen) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BodySite) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BodyStructure) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Note) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PatientInstruction) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Instruction) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RelevantHistory) });
        // }
    }

}
