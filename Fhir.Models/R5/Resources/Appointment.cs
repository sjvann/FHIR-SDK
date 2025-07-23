// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A booking of a healthcare event among patient(s), practitioner(s), related person(s) and/or
/// device(s) for a specific date/time. This may result in one or more Encounter(s).
/// </summary>
public class Appointment : DomainResource
{
    public override string ResourceType => "Appointment";

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
    /// This records identifiers associated with this appointment concern that are defined by business
    /// processes and/or used to refer to it when a direct URL reference to the resource itself is not
    /// appropriate (e.g. in CDA documents, or in written / printed documentation).
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The overall status of the Appointment. Each of the participants has their own participation status
    /// which indicates their involvement in the process, however this status indicates the shared status.
    /// </summary>
    [FhirElement("status", Order = 19)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// The coded reason for the appointment being cancelled. This is often used in reporting/billing/futher
    /// processing to determine if further actions are required, or specific fees apply.
    /// </summary>
    [FhirElement("cancellationReason", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("cancellationReason")]
    public CodeableConcept CancellationReason { get; set; }

    /// <summary>
    /// Concepts representing classification of patient encounter such as ambulatory (outpatient),
    /// inpatient, emergency, home health or others due to local variations.
    /// </summary>
    [FhirElement("class", Order = 21)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("class")]
    public List<CodeableConcept>? Class { get; set; }

    /// <summary>
    /// A broad categorization of the service that is to be performed during this appointment.
    /// </summary>
    [FhirElement("serviceCategory", Order = 22)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("serviceCategory")]
    public List<CodeableConcept>? ServiceCategory { get; set; }

    /// <summary>
    /// The specific service that is to be performed during this appointment.
    /// </summary>
    [FhirElement("serviceType", Order = 23)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("serviceType")]
    public List<CodeableReference>? ServiceType { get; set; }

    /// <summary>
    /// The specialty of a practitioner that would be required to perform the service requested in this
    /// appointment.
    /// </summary>
    [FhirElement("specialty", Order = 24)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("specialty")]
    public List<CodeableConcept>? Specialty { get; set; }

    /// <summary>
    /// The style of appointment or patient that has been booked in the slot (not service type).
    /// </summary>
    [FhirElement("appointmentType", Order = 25)]
    [Cardinality(0, 1)]
    [JsonPropertyName("appointmentType")]
    public CodeableConcept AppointmentType { get; set; }

    /// <summary>
    /// The reason that this appointment is being scheduled. This is more clinical than administrative. This
    /// can be coded, or as specified using information from another resource. When the patient arrives and
    /// the encounter begins it may be used as the admission diagnosis. The indication will typically be a
    /// Condition (with other resources referenced in the evidence.detail), or a Procedure.
    /// </summary>
    [FhirElement("reason", Order = 26)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("reason")]
    public List<CodeableReference>? Reason { get; set; }

    /// <summary>
    /// The priority of the appointment. Can be used to make informed decisions if needing to re-prioritize
    /// appointments. (The iCal Standard specifies 0 as undefined, 1 as highest, 9 as lowest priority).
    /// </summary>
    [FhirElement("priority", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("priority")]
    public CodeableConcept Priority { get; set; }

    /// <summary>
    /// The brief description of the appointment as would be shown on a subject line in a meeting request,
    /// or appointment list. Detailed or expanded information should be put in the note field.
    /// </summary>
    [FhirElement("description", Order = 28)]
    [Cardinality(0, 1)]
    [JsonPropertyName("description")]
    public FhirString? Description { get; set; }

    /// <summary>
    /// Appointment replaced by this Appointment in cases where there is a cancellation, the details of the
    /// cancellation can be found in the cancellationReason property (on the referenced resource).
    /// </summary>
    [FhirElement("replaces", Order = 29)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("replaces")]
    public List<Reference<Appointment>>? Replaces { get; set; }

    /// <summary>
    /// Connection details of a virtual service (e.g. conference call).
    /// </summary>
    [FhirElement("virtualService", Order = 30)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("virtualService")]
    public List<VirtualServiceDetail>? VirtualService { get; set; }

    /// <summary>
    /// Additional information to support the appointment provided when making the appointment.
    /// </summary>
    [FhirElement("supportingInformation", Order = 31)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("supportingInformation")]
    public List<Reference<Resource>>? SupportingInformation { get; set; }

    /// <summary>
    /// The previous appointment in a series of related appointments.
    /// </summary>
    [FhirElement("previousAppointment", Order = 32)]
    [Cardinality(0, 1)]
    [JsonPropertyName("previousAppointment")]
    public Reference<Appointment> PreviousAppointment { get; set; }

    /// <summary>
    /// The originating appointment in a recurring set of related appointments.
    /// </summary>
    [FhirElement("originatingAppointment", Order = 33)]
    [Cardinality(0, 1)]
    [JsonPropertyName("originatingAppointment")]
    public Reference<Appointment> OriginatingAppointment { get; set; }

    /// <summary>
    /// Date/Time that the appointment is to take place.
    /// </summary>
    [FhirElement("start", Order = 34)]
    [Cardinality(0, 1)]
    [JsonPropertyName("start")]
    public FhirInstant? Start { get; set; }

    /// <summary>
    /// Date/Time that the appointment is to conclude.
    /// </summary>
    [FhirElement("end", Order = 35)]
    [Cardinality(0, 1)]
    [JsonPropertyName("end")]
    public FhirInstant? End { get; set; }

    /// <summary>
    /// Number of minutes that the appointment is to take. This can be less than the duration between the
    /// start and end times. For example, where the actual time of appointment is only an estimate or if a
    /// 30 minute appointment is being requested, but any time would work. Also, if there is, for example, a
    /// planned 15 minute break in the middle of a long appointment, the duration may be 15 minutes less
    /// than the difference between the start and end.
    /// </summary>
    [FhirElement("minutesDuration", Order = 36)]
    [Cardinality(0, 1)]
    [JsonPropertyName("minutesDuration")]
    public FhirPositiveInt? MinutesDuration { get; set; }

    /// <summary>
    /// A set of date ranges (potentially including times) that the appointment is preferred to be scheduled
    /// within. The duration (usually in minutes) could also be provided to indicate the length of the
    /// appointment to fill and populate the start/end times for the actual allocated time. However, in
    /// other situations the duration may be calculated by the scheduling system.
    /// </summary>
    [FhirElement("requestedPeriod", Order = 37)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("requestedPeriod")]
    public List<Period>? RequestedPeriod { get; set; }

    /// <summary>
    /// The slots from the participants&apos; schedules that will be filled by the appointment.
    /// </summary>
    [FhirElement("slot", Order = 38)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("slot")]
    public List<Reference<Slot>>? Slot { get; set; }

    /// <summary>
    /// The set of accounts that is expected to be used for billing the activities that result from this
    /// Appointment.
    /// </summary>
    [FhirElement("account", Order = 39)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("account")]
    public List<Reference<Account>>? Account { get; set; }

    /// <summary>
    /// The date that this appointment was initially created. This could be different to the
    /// meta.lastModified value on the initial entry, as this could have been before the resource was
    /// created on the FHIR server, and should remain unchanged over the lifespan of the appointment.
    /// </summary>
    [FhirElement("created", Order = 40)]
    [Cardinality(0, 1)]
    [JsonPropertyName("created")]
    public FhirDateTime? Created { get; set; }

    /// <summary>
    /// The date/time describing when the appointment was cancelled.
    /// </summary>
    [FhirElement("cancellationDate", Order = 41)]
    [Cardinality(0, 1)]
    [JsonPropertyName("cancellationDate")]
    public FhirDateTime? CancellationDate { get; set; }

    /// <summary>
    /// Additional notes/comments about the appointment.
    /// </summary>
    [FhirElement("note", Order = 42)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// While Appointment.note contains information for internal use, Appointment.patientInstructions is
    /// used to capture patient facing information about the Appointment (e.g. please bring your referral or
    /// fast from 8pm night before).
    /// </summary>
    [FhirElement("patientInstruction", Order = 43)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("patientInstruction")]
    public List<CodeableReference>? PatientInstruction { get; set; }

    /// <summary>
    /// The request this appointment is allocated to assess (e.g. incoming referral or procedure request).
    /// </summary>
    [FhirElement("basedOn", Order = 44)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("basedOn")]
    public List<Reference<CarePlan>>? BasedOn { get; set; }

    /// <summary>
    /// The patient or group associated with the appointment, if they are to be present (usually) then they
    /// should also be included in the participant backbone element.
    /// </summary>
    [FhirElement("subject", Order = 45)]
    [Cardinality(0, 1)]
    [JsonPropertyName("subject")]
    public Reference<Patient> Subject { get; set; }

    /// <summary>
    /// List of participants involved in the appointment.
    /// </summary>
    [FhirElement("participant", Order = 46)]
    [Cardinality(1, int.MaxValue)]
    [Required]
    [JsonPropertyName("participant")]
    public List<BackboneElement> Participant { get; set; }

    /// <summary>
    /// The sequence number that identifies a specific appointment in a recurring pattern.
    /// </summary>
    [FhirElement("recurrenceId", Order = 47)]
    [Cardinality(0, 1)]
    [JsonPropertyName("recurrenceId")]
    public FhirPositiveInt? RecurrenceId { get; set; }

    /// <summary>
    /// This appointment varies from the recurring pattern.
    /// </summary>
    [FhirElement("occurrenceChanged", Order = 48)]
    [Cardinality(0, 1)]
    [JsonPropertyName("occurrenceChanged")]
    public FhirBoolean? OccurrenceChanged { get; set; }

    /// <summary>
    /// The details of the recurrence pattern or template that is used to generate recurring appointments.
    /// </summary>
    [FhirElement("recurrenceTemplate", Order = 49)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("recurrenceTemplate")]
    public List<BackboneElement>? RecurrenceTemplate { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Appointment cardinality
        var appointmentCount = Appointment?.Count ?? 0;
        if (appointmentCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment' cardinality must be 0..*", new[] { nameof(Appointment) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'Appointment.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        // Validate Class cardinality
        var classCount = Class?.Count ?? 0;
        if (classCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.class' cardinality must be 0..*", new[] { nameof(Class) });
        }
        // Validate ServiceCategory cardinality
        var servicecategoryCount = ServiceCategory?.Count ?? 0;
        if (servicecategoryCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.serviceCategory' cardinality must be 0..*", new[] { nameof(ServiceCategory) });
        }
        // Validate ServiceType cardinality
        var servicetypeCount = ServiceType?.Count ?? 0;
        if (servicetypeCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.serviceType' cardinality must be 0..*", new[] { nameof(ServiceType) });
        }
        // Validate Specialty cardinality
        var specialtyCount = Specialty?.Count ?? 0;
        if (specialtyCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.specialty' cardinality must be 0..*", new[] { nameof(Specialty) });
        }
        // Validate Reason cardinality
        var reasonCount = Reason?.Count ?? 0;
        if (reasonCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.reason' cardinality must be 0..*", new[] { nameof(Reason) });
        }
        // Validate Replaces cardinality
        var replacesCount = Replaces?.Count ?? 0;
        if (replacesCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.replaces' cardinality must be 0..*", new[] { nameof(Replaces) });
        }
        // Validate VirtualService cardinality
        var virtualserviceCount = VirtualService?.Count ?? 0;
        if (virtualserviceCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.virtualService' cardinality must be 0..*", new[] { nameof(VirtualService) });
        }
        // Validate SupportingInformation cardinality
        var supportinginformationCount = SupportingInformation?.Count ?? 0;
        if (supportinginformationCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.supportingInformation' cardinality must be 0..*", new[] { nameof(SupportingInformation) });
        }
        // Validate RequestedPeriod cardinality
        var requestedperiodCount = RequestedPeriod?.Count ?? 0;
        if (requestedperiodCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.requestedPeriod' cardinality must be 0..*", new[] { nameof(RequestedPeriod) });
        }
        // Validate Slot cardinality
        var slotCount = Slot?.Count ?? 0;
        if (slotCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.slot' cardinality must be 0..*", new[] { nameof(Slot) });
        }
        // Validate Account cardinality
        var accountCount = Account?.Count ?? 0;
        if (accountCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.account' cardinality must be 0..*", new[] { nameof(Account) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.note' cardinality must be 0..*", new[] { nameof(Note) });
        }
        // Validate PatientInstruction cardinality
        var patientinstructionCount = PatientInstruction?.Count ?? 0;
        if (patientinstructionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.patientInstruction' cardinality must be 0..*", new[] { nameof(PatientInstruction) });
        }
        // Validate BasedOn cardinality
        var basedonCount = BasedOn?.Count ?? 0;
        if (basedonCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.basedOn' cardinality must be 0..*", new[] { nameof(BasedOn) });
        }
        // Validate Participant cardinality
        var participantCount = Participant?.Count ?? 0;
        if (participantCount < 1)
        {
            yield return new ValidationResult("Element 'Appointment.participant' cardinality must be 1..*", new[] { nameof(Participant) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.participant.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.participant.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Type cardinality
        var typeCount = Type?.Count ?? 0;
        if (typeCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.participant.type' cardinality must be 0..*", new[] { nameof(Type) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'Appointment.participant.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        // Validate RecurrenceTemplate cardinality
        var recurrencetemplateCount = RecurrenceTemplate?.Count ?? 0;
        if (recurrencetemplateCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate' cardinality must be 0..*", new[] { nameof(RecurrenceTemplate) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (RecurrenceType == null)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.recurrenceType' cardinality must be 1..1", new[] { nameof(RecurrenceType) });
        }
        // Validate OccurrenceDate cardinality
        var occurrencedateCount = OccurrenceDate?.Count ?? 0;
        if (occurrencedateCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.occurrenceDate' cardinality must be 0..*", new[] { nameof(OccurrenceDate) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.weeklyTemplate.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.weeklyTemplate.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.monthlyTemplate.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.monthlyTemplate.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (MonthInterval == null)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.monthlyTemplate.monthInterval' cardinality must be 1..1", new[] { nameof(MonthInterval) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.yearlyTemplate.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.yearlyTemplate.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (YearInterval == null)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.yearlyTemplate.yearInterval' cardinality must be 1..1", new[] { nameof(YearInterval) });
        }
        // Validate ExcludingDate cardinality
        var excludingdateCount = ExcludingDate?.Count ?? 0;
        if (excludingdateCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.excludingDate' cardinality must be 0..*", new[] { nameof(ExcludingDate) });
        }
        // Validate ExcludingRecurrenceId cardinality
        var excludingrecurrenceidCount = ExcludingRecurrenceId?.Count ?? 0;
        if (excludingrecurrenceidCount < 0)
        {
            yield return new ValidationResult("Element 'Appointment.recurrenceTemplate.excludingRecurrenceId' cardinality must be 0..*", new[] { nameof(ExcludingRecurrenceId) });
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
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/appointmentstatus|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/encounter-participant-type
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Status ValueSet binding
        if (Status != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/participationstatus|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Timezone ValueSet binding
        if (Timezone != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/timezones|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate NthWeekOfMonth ValueSet binding
        if (NthWeekOfMonth != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/week-of-month|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate DayOfWeek ValueSet binding
        if (DayOfWeek != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/days-of-week|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: app-2
        // Expression: start.exists() = end.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("start.exists() = end.exists()"))
        // {
        //     yield return new ValidationResult("Either start and end are specified, or neither", new[] { nameof(Appointment) });
        // }
        // Constraint: app-3
        // Expression: (start.exists() and end.exists()) or (status in ('proposed' | 'cancelled' | 'waitlist'))
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(start.exists() and end.exists()) or (status in ('proposed' | 'cancelled' | 'waitlist'))"))
        // {
        //     yield return new ValidationResult("Only proposed or cancelled appointments can be missing start/end dates", new[] { nameof(Appointment) });
        // }
        // Constraint: app-4
        // Expression: cancellationReason.exists() implies (status='noshow' or status='cancelled')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("cancellationReason.exists() implies (status='noshow' or status='cancelled')"))
        // {
        //     yield return new ValidationResult("Cancellation reason is only used for appointments that have been cancelled, or noshow", new[] { nameof(Appointment) });
        // }
        // Constraint: app-5
        // Expression: start.exists() implies start <= end
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("start.exists() implies start <= end"))
        // {
        //     yield return new ValidationResult("The start must be less than or equal to the end", new[] { nameof(Appointment) });
        // }
        // Constraint: app-6
        // Expression: originatingAppointment.exists().not() or recurrenceTemplate.exists().not()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("originatingAppointment.exists().not() or recurrenceTemplate.exists().not()"))
        // {
        //     yield return new ValidationResult("An appointment may have an originatingAppointment or recurrenceTemplate, but not both", new[] { nameof(Appointment) });
        // }
        // Constraint: app-7
        // Expression: cancellationDate.exists() implies (status='noshow' or status='cancelled')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("cancellationDate.exists() implies (status='noshow' or status='cancelled')"))
        // {
        //     yield return new ValidationResult("Cancellation date is only used for appointments that have been cancelled, or noshow", new[] { nameof(Appointment) });
        // }
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(Appointment) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(Appointment) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(Appointment) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(Appointment) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(Appointment) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Status) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CancellationReason) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Class) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ServiceCategory) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ServiceType) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(AppointmentType) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Priority) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Description) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(VirtualService) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PreviousAppointment) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(OriginatingAppointment) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Start) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(End) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MinutesDuration) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RequestedPeriod) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Slot) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Account) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Created) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CancellationDate) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BasedOn) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Subject) });
        // }
        // Constraint: app-1
        // Expression: type.exists() or actor.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type.exists() or actor.exists()"))
        // {
        //     yield return new ValidationResult("Either the type or actor on the participant SHALL be specified", new[] { nameof(Participant) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Participant) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Actor) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Required) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RecurrenceId) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(OccurrenceChanged) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RecurrenceTemplate) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Timezone) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RecurrenceType) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(LastOccurrenceDate) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(OccurrenceCount) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(OccurrenceDate) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(WeeklyTemplate) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Monday) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Tuesday) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Wednesday) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Thursday) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Friday) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Saturday) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Sunday) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(WeekInterval) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MonthlyTemplate) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DayOfMonth) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(NthWeekOfMonth) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DayOfWeek) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MonthInterval) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(YearlyTemplate) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(YearInterval) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ExcludingDate) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ExcludingRecurrenceId) });
        // }
    }

}
