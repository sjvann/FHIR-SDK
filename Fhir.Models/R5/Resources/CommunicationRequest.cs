// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A request to convey information; e.g. the CDS system proposes that an alert be sent to a responsible
/// provider, the CDS system proposes that the public health agency be notified about a reportable
/// condition.
/// </summary>
public class CommunicationRequest : DomainResource
{
    public override string ResourceType => "CommunicationRequest";

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
    /// Business identifiers assigned to this communication request by the performer or other systems which
    /// remain constant as the resource is updated and propagates from server to server.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// A plan or proposal that is fulfilled in whole or in part by this request.
    /// </summary>
    [FhirElement("basedOn", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("basedOn")]
    public List<Reference<Resource>>? BasedOn { get; set; }

    /// <summary>
    /// Completed or terminated request(s) whose function is taken by this new request.
    /// </summary>
    [FhirElement("replaces", Order = 20)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("replaces")]
    public List<Reference<CommunicationRequest>>? Replaces { get; set; }

    /// <summary>
    /// A shared identifier common to multiple independent Request instances that were activated/authorized
    /// more or less simultaneously by a single author. The presence of the same identifier on each request
    /// ties those requests together and may have business ramifications in terms of reporting of results,
    /// billing, etc. E.g. a requisition number shared by a set of lab tests ordered together, or a
    /// prescription number shared by all meds ordered at one time.
    /// </summary>
    [FhirElement("groupIdentifier", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("groupIdentifier")]
    public Identifier GroupIdentifier { get; set; }

    /// <summary>
    /// The status of the proposal or order.
    /// </summary>
    [FhirElement("status", Order = 22)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Captures the reason for the current state of the CommunicationRequest.
    /// </summary>
    [FhirElement("statusReason", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("statusReason")]
    public CodeableConcept StatusReason { get; set; }

    /// <summary>
    /// Indicates the level of authority/intentionality associated with the CommunicationRequest and where
    /// the request fits into the workflow chain.
    /// </summary>
    [FhirElement("intent", Order = 24)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("intent")]
    public FhirCode Intent { get; set; }

    /// <summary>
    /// The type of message to be sent such as alert, notification, reminder, instruction, etc.
    /// </summary>
    [FhirElement("category", Order = 25)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// Characterizes how quickly the proposed act must be initiated. Includes concepts such as stat,
    /// urgent, routine.
    /// </summary>
    [FhirElement("priority", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("priority")]
    public FhirCode? Priority { get; set; }

    /// <summary>
    /// If true indicates that the CommunicationRequest is asking for the specified action to *not* occur.
    /// </summary>
    [FhirElement("doNotPerform", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("doNotPerform")]
    public FhirBoolean? DoNotPerform { get; set; }

    /// <summary>
    /// A channel that was used for this communication (e.g. email, fax).
    /// </summary>
    [FhirElement("medium", Order = 28)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("medium")]
    public List<CodeableConcept>? Medium { get; set; }

    /// <summary>
    /// The patient or group that is the focus of this communication request.
    /// </summary>
    [FhirElement("subject", Order = 29)]
    [Cardinality(0, 1)]
    [JsonPropertyName("subject")]
    public Reference<Patient> Subject { get; set; }

    /// <summary>
    /// Other resources that pertain to this communication request and to which this communication request
    /// should be associated.
    /// </summary>
    [FhirElement("about", Order = 30)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("about")]
    public List<Reference<Resource>>? About { get; set; }

    /// <summary>
    /// The Encounter during which this CommunicationRequest was created or to which the creation of this
    /// record is tightly associated.
    /// </summary>
    [FhirElement("encounter", Order = 31)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// Text, attachment(s), or resource(s) to be communicated to the recipient.
    /// </summary>
    [FhirElement("payload", Order = 32)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("payload")]
    public List<BackboneElement>? Payload { get; set; }

    /// <summary>
    /// The time when this communication is to occur. (as dateTime)
    /// </summary>
    [FhirElement("occurrenceDateTime", Order = 33)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "dateTime")]
    [JsonPropertyName("occurrenceDateTime")]
    public FhirDateTime? OccurrenceDateTime { get; set; }

    /// <summary>
    /// The time when this communication is to occur. (as Period)
    /// </summary>
    [FhirElement("occurrencePeriod", Order = 34)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "period")]
    [JsonPropertyName("occurrencePeriod")]
    public Period OccurrencePeriod { get; set; }

    /// <summary>
    /// For draft requests, indicates the date of initial creation. For requests with other statuses,
    /// indicates the date of activation.
    /// </summary>
    [FhirElement("authoredOn", Order = 35)]
    [Cardinality(0, 1)]
    [JsonPropertyName("authoredOn")]
    public FhirDateTime? AuthoredOn { get; set; }

    /// <summary>
    /// The device, individual, or organization who asks for the information to be shared.
    /// </summary>
    [FhirElement("requester", Order = 36)]
    [Cardinality(0, 1)]
    [JsonPropertyName("requester")]
    public Reference<Practitioner> Requester { get; set; }

    /// <summary>
    /// The entity (e.g. person, organization, clinical information system, device, group, or care team)
    /// which is the intended target of the communication.
    /// </summary>
    [FhirElement("recipient", Order = 37)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("recipient")]
    public List<Reference<Device>>? Recipient { get; set; }

    /// <summary>
    /// The entity (e.g. person, organization, clinical information system, or device) which is to be the
    /// source of the communication.
    /// </summary>
    [FhirElement("informationProvider", Order = 38)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("informationProvider")]
    public List<Reference<Device>>? InformationProvider { get; set; }

    /// <summary>
    /// Describes why the request is being made in coded or textual form.
    /// </summary>
    [FhirElement("reason", Order = 39)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("reason")]
    public List<CodeableReference>? Reason { get; set; }

    /// <summary>
    /// Comments made about the request by the requester, sender, recipient, subject or other participants.
    /// </summary>
    [FhirElement("note", Order = 40)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for occurrence[x]
        var occurrenceProperties = new[] { nameof(OccurrenceDateTime), nameof(OccurrencePeriod) };
        var occurrenceSetCount = occurrenceProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (occurrenceSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of OccurrenceDateTime, OccurrencePeriod may be specified",
                new[] { nameof(OccurrenceDateTime), nameof(OccurrencePeriod) });
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
        // Validate CommunicationRequest cardinality
        var communicationrequestCount = CommunicationRequest?.Count ?? 0;
        if (communicationrequestCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest' cardinality must be 0..*", new[] { nameof(CommunicationRequest) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate BasedOn cardinality
        var basedonCount = BasedOn?.Count ?? 0;
        if (basedonCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.basedOn' cardinality must be 0..*", new[] { nameof(BasedOn) });
        }
        // Validate Replaces cardinality
        var replacesCount = Replaces?.Count ?? 0;
        if (replacesCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.replaces' cardinality must be 0..*", new[] { nameof(Replaces) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        if (Intent == null)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.intent' cardinality must be 1..1", new[] { nameof(Intent) });
        }
        // Validate Category cardinality
        var categoryCount = Category?.Count ?? 0;
        if (categoryCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.category' cardinality must be 0..*", new[] { nameof(Category) });
        }
        // Validate Medium cardinality
        var mediumCount = Medium?.Count ?? 0;
        if (mediumCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.medium' cardinality must be 0..*", new[] { nameof(Medium) });
        }
        // Validate About cardinality
        var aboutCount = About?.Count ?? 0;
        if (aboutCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.about' cardinality must be 0..*", new[] { nameof(About) });
        }
        // Validate Payload cardinality
        var payloadCount = Payload?.Count ?? 0;
        if (payloadCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.payload' cardinality must be 0..*", new[] { nameof(Payload) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.payload.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.payload.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Content == null)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.payload.content[x]' cardinality must be 1..1", new[] { nameof(Content) });
        }
        // Validate Recipient cardinality
        var recipientCount = Recipient?.Count ?? 0;
        if (recipientCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.recipient' cardinality must be 0..*", new[] { nameof(Recipient) });
        }
        // Validate InformationProvider cardinality
        var informationproviderCount = InformationProvider?.Count ?? 0;
        if (informationproviderCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.informationProvider' cardinality must be 0..*", new[] { nameof(InformationProvider) });
        }
        // Validate Reason cardinality
        var reasonCount = Reason?.Count ?? 0;
        if (reasonCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.reason' cardinality must be 0..*", new[] { nameof(Reason) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'CommunicationRequest.note' cardinality must be 0..*", new[] { nameof(Note) });
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
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(CommunicationRequest) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(CommunicationRequest) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(CommunicationRequest) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(CommunicationRequest) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(CommunicationRequest) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Replaces) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(GroupIdentifier) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Medium) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(About) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Payload) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Content) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Recipient) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(InformationProvider) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Note) });
        // }
    }

}
