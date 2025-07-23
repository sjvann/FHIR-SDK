// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Indicates that a device is to be or has been dispensed for a named person/patient. This includes a
/// description of the product (supply) provided and the instructions for using the device.
/// </summary>
public class DeviceDispense : DomainResource
{
    public override string ResourceType => "DeviceDispense";

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
    /// Business identifier for this dispensation.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The order or request that this dispense is fulfilling.
    /// </summary>
    [FhirElement("basedOn", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("basedOn")]
    public List<Reference<CarePlan>>? BasedOn { get; set; }

    /// <summary>
    /// The bigger event that this dispense is a part of.
    /// </summary>
    [FhirElement("partOf", Order = 20)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("partOf")]
    public List<Reference<Procedure>>? PartOf { get; set; }

    /// <summary>
    /// A code specifying the state of the set of dispense events.
    /// </summary>
    [FhirElement("status", Order = 21)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Indicates the reason why a dispense was or was not performed.
    /// </summary>
    [FhirElement("statusReason", Order = 22)]
    [Cardinality(0, 1)]
    [JsonPropertyName("statusReason")]
    public CodeableReference StatusReason { get; set; }

    /// <summary>
    /// Indicates the type of device dispense.
    /// </summary>
    [FhirElement("category", Order = 23)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// Identifies the device being dispensed. This is either a link to a resource representing the details
    /// of the device or a simple attribute carrying a code that identifies the device from a known list of
    /// devices.
    /// </summary>
    [FhirElement("device", Order = 24)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("device")]
    public CodeableReference Device { get; set; }

    /// <summary>
    /// A link to a resource representing the person to whom the device is intended.
    /// </summary>
    [FhirElement("subject", Order = 25)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("subject")]
    public Reference<Patient> Subject { get; set; }

    /// <summary>
    /// Identifies the person who picked up the device or the person or location where the device was
    /// delivered. This may be a patient or their caregiver, but some cases exist where it can be a
    /// healthcare professional or a location.
    /// </summary>
    [FhirElement("receiver", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("receiver")]
    public Reference<Patient> Receiver { get; set; }

    /// <summary>
    /// The encounter that establishes the context for this event.
    /// </summary>
    [FhirElement("encounter", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// Additional information that supports the device being dispensed.
    /// </summary>
    [FhirElement("supportingInformation", Order = 28)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("supportingInformation")]
    public List<Reference<Resource>>? SupportingInformation { get; set; }

    /// <summary>
    /// Indicates who or what performed the event.
    /// </summary>
    [FhirElement("performer", Order = 29)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("performer")]
    public List<BackboneElement>? Performer { get; set; }

    /// <summary>
    /// The principal physical location where the dispense was performed.
    /// </summary>
    [FhirElement("location", Order = 30)]
    [Cardinality(0, 1)]
    [JsonPropertyName("location")]
    public Reference<Location> Location { get; set; }

    /// <summary>
    /// Indicates the type of dispensing event that is performed.
    /// </summary>
    [FhirElement("type", Order = 31)]
    [Cardinality(0, 1)]
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// The number of devices that have been dispensed.
    /// </summary>
    [FhirElement("quantity", Order = 32)]
    [Cardinality(0, 1)]
    [JsonPropertyName("quantity")]
    public Quantity Quantity { get; set; }

    /// <summary>
    /// The time when the dispensed product was packaged and reviewed.
    /// </summary>
    [FhirElement("preparedDate", Order = 33)]
    [Cardinality(0, 1)]
    [JsonPropertyName("preparedDate")]
    public FhirDateTime? PreparedDate { get; set; }

    /// <summary>
    /// The time the dispensed product was made available to the patient or their representative.
    /// </summary>
    [FhirElement("whenHandedOver", Order = 34)]
    [Cardinality(0, 1)]
    [JsonPropertyName("whenHandedOver")]
    public FhirDateTime? WhenHandedOver { get; set; }

    /// <summary>
    /// Identification of the facility/location where the device was /should be shipped to, as part of the
    /// dispense process.
    /// </summary>
    [FhirElement("destination", Order = 35)]
    [Cardinality(0, 1)]
    [JsonPropertyName("destination")]
    public Reference<Location> Destination { get; set; }

    /// <summary>
    /// Extra information about the dispense that could not be conveyed in the other attributes.
    /// </summary>
    [FhirElement("note", Order = 36)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// The full representation of the instructions.
    /// </summary>
    [FhirElement("usageInstruction", Order = 37)]
    [Cardinality(0, 1)]
    [JsonPropertyName("usageInstruction")]
    public FhirMarkdown? UsageInstruction { get; set; }

    /// <summary>
    /// A summary of the events of interest that have occurred, such as when the dispense was verified.
    /// </summary>
    [FhirElement("eventHistory", Order = 38)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("eventHistory")]
    public List<Reference<Provenance>>? EventHistory { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate DeviceDispense cardinality
        var devicedispenseCount = DeviceDispense?.Count ?? 0;
        if (devicedispenseCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense' cardinality must be 0..*", new[] { nameof(DeviceDispense) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate BasedOn cardinality
        var basedonCount = BasedOn?.Count ?? 0;
        if (basedonCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.basedOn' cardinality must be 0..*", new[] { nameof(BasedOn) });
        }
        // Validate PartOf cardinality
        var partofCount = PartOf?.Count ?? 0;
        if (partofCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.partOf' cardinality must be 0..*", new[] { nameof(PartOf) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'DeviceDispense.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        // Validate Category cardinality
        var categoryCount = Category?.Count ?? 0;
        if (categoryCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.category' cardinality must be 0..*", new[] { nameof(Category) });
        }
        if (Device == null)
        {
            yield return new ValidationResult("Element 'DeviceDispense.device' cardinality must be 1..1", new[] { nameof(Device) });
        }
        if (Subject == null)
        {
            yield return new ValidationResult("Element 'DeviceDispense.subject' cardinality must be 1..1", new[] { nameof(Subject) });
        }
        // Validate SupportingInformation cardinality
        var supportinginformationCount = SupportingInformation?.Count ?? 0;
        if (supportinginformationCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.supportingInformation' cardinality must be 0..*", new[] { nameof(SupportingInformation) });
        }
        // Validate Performer cardinality
        var performerCount = Performer?.Count ?? 0;
        if (performerCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.performer' cardinality must be 0..*", new[] { nameof(Performer) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.performer.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.performer.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Actor == null)
        {
            yield return new ValidationResult("Element 'DeviceDispense.performer.actor' cardinality must be 1..1", new[] { nameof(Actor) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.note' cardinality must be 0..*", new[] { nameof(Note) });
        }
        // Validate EventHistory cardinality
        var eventhistoryCount = EventHistory?.Count ?? 0;
        if (eventhistoryCount < 0)
        {
            yield return new ValidationResult("Element 'DeviceDispense.eventHistory' cardinality must be 0..*", new[] { nameof(EventHistory) });
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
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/devicedispense-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(DeviceDispense) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(DeviceDispense) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(DeviceDispense) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(DeviceDispense) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(DeviceDispense) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BasedOn) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PartOf) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(StatusReason) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Device) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Receiver) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SupportingInformation) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Function) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Actor) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PreparedDate) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(WhenHandedOver) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Destination) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(UsageInstruction) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(EventHistory) });
        // }
    }

}
