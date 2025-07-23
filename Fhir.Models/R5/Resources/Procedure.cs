// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// An action that is or was performed on or for a patient, practitioner, device, organization, or
/// location. For example, this can be a physical intervention on a patient like an operation, or less
/// invasive like long term services, counseling, or hypnotherapy. This can be a quality or safety
/// inspection for a location, organization, or device. This can be an accreditation procedure on a
/// practitioner for licensing.
/// </summary>
public class Procedure : DomainResource
{
    public override string ResourceType => "Procedure";

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
    /// Business identifiers assigned to this procedure by the performer or other systems which remain
    /// constant as the resource is updated and is propagated from server to server.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The URL pointing to a FHIR-defined protocol, guideline, order set or other definition that is
    /// adhered to in whole or in part by this Procedure.
    /// </summary>
    [FhirElement("instantiatesCanonical", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("instantiatesCanonical")]
    public List<FhirCanonical>? InstantiatesCanonical { get; set; }

    /// <summary>
    /// The URL pointing to an externally maintained protocol, guideline, order set or other definition that
    /// is adhered to in whole or in part by this Procedure.
    /// </summary>
    [FhirElement("instantiatesUri", Order = 20)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("instantiatesUri")]
    public List<FhirUri>? InstantiatesUri { get; set; }

    /// <summary>
    /// A reference to a resource that contains details of the request for this procedure.
    /// </summary>
    [FhirElement("basedOn", Order = 21)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("basedOn")]
    public List<Reference<CarePlan>>? BasedOn { get; set; }

    /// <summary>
    /// A larger event of which this particular procedure is a component or step.
    /// </summary>
    [FhirElement("partOf", Order = 22)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("partOf")]
    public List<Reference<Procedure>>? PartOf { get; set; }

    /// <summary>
    /// A code specifying the state of the procedure. Generally, this will be the in-progress or completed
    /// state.
    /// </summary>
    [FhirElement("status", Order = 23)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Captures the reason for the current state of the procedure.
    /// </summary>
    [FhirElement("statusReason", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("statusReason")]
    public CodeableConcept StatusReason { get; set; }

    /// <summary>
    /// A code that classifies the procedure for searching, sorting and display purposes (e.g.
    /// &quot;Surgical Procedure&quot;).
    /// </summary>
    [FhirElement("category", Order = 25)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// The specific procedure that is performed. Use text if the exact nature of the procedure cannot be
    /// coded (e.g. &quot;Laparoscopic Appendectomy&quot;).
    /// </summary>
    [FhirElement("code", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; }

    /// <summary>
    /// On whom or on what the procedure was performed. This is usually an individual human, but can also be
    /// performed on animals, groups of humans or animals, organizations or practitioners (for licensing),
    /// locations or devices (for safety inspections or regulatory authorizations). If the actual focus of
    /// the procedure is different from the subject, the focus element specifies the actual focus of the
    /// procedure.
    /// </summary>
    [FhirElement("subject", Order = 27)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("subject")]
    public Reference<Patient> Subject { get; set; }

    /// <summary>
    /// Who is the target of the procedure when it is not the subject of record only. If focus is not
    /// present, then subject is the focus. If focus is present and the subject is one of the targets of the
    /// procedure, include subject as a focus as well. If focus is present and the subject is not included
    /// in focus, it implies that the procedure was only targeted on the focus. For example, when a
    /// caregiver is given education for a patient, the caregiver would be the focus and the procedure
    /// record is associated with the subject (e.g. patient). For example, use focus when recording the
    /// target of the education, training, or counseling is the parent or relative of a patient.
    /// </summary>
    [FhirElement("focus", Order = 28)]
    [Cardinality(0, 1)]
    [JsonPropertyName("focus")]
    public Reference<Patient> Focus { get; set; }

    /// <summary>
    /// The Encounter during which this Procedure was created or performed or to which the creation of this
    /// record is tightly associated.
    /// </summary>
    [FhirElement("encounter", Order = 29)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, period, or age when the procedure did occur or is occurring.
    /// Allows a period to support complex procedures that span more than one date, and also allows for the
    /// length of the procedure to be captured. (as dateTime)
    /// </summary>
    [FhirElement("occurrenceDateTime", Order = 30)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "dateTime")]
    [JsonPropertyName("occurrenceDateTime")]
    public FhirDateTime? OccurrenceDateTime { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, period, or age when the procedure did occur or is occurring.
    /// Allows a period to support complex procedures that span more than one date, and also allows for the
    /// length of the procedure to be captured. (as Period)
    /// </summary>
    [FhirElement("occurrencePeriod", Order = 31)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "period")]
    [JsonPropertyName("occurrencePeriod")]
    public Period OccurrencePeriod { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, period, or age when the procedure did occur or is occurring.
    /// Allows a period to support complex procedures that span more than one date, and also allows for the
    /// length of the procedure to be captured. (as string)
    /// </summary>
    [FhirElement("occurrenceString", Order = 32)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "string")]
    [JsonPropertyName("occurrenceString")]
    public FhirString? OccurrenceString { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, period, or age when the procedure did occur or is occurring.
    /// Allows a period to support complex procedures that span more than one date, and also allows for the
    /// length of the procedure to be captured. (as Age)
    /// </summary>
    [FhirElement("occurrenceageUnknown", Order = 33)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrenceage", "unknown")]
    [JsonPropertyName("occurrenceageUnknown")]
    public Age OccurrenceAge { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, period, or age when the procedure did occur or is occurring.
    /// Allows a period to support complex procedures that span more than one date, and also allows for the
    /// length of the procedure to be captured. (as Range)
    /// </summary>
    [FhirElement("occurrenceRange", Order = 34)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "range")]
    [JsonPropertyName("occurrenceRange")]
    public Range OccurrenceRange { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, period, or age when the procedure did occur or is occurring.
    /// Allows a period to support complex procedures that span more than one date, and also allows for the
    /// length of the procedure to be captured. (as Timing)
    /// </summary>
    [FhirElement("occurrenceTiming", Order = 35)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "timing")]
    [JsonPropertyName("occurrenceTiming")]
    public Timing OccurrenceTiming { get; set; }

    /// <summary>
    /// The date the occurrence of the procedure was first captured in the record regardless of
    /// Procedure.status (potentially after the occurrence of the event).
    /// </summary>
    [FhirElement("recorded", Order = 36)]
    [Cardinality(0, 1)]
    [JsonPropertyName("recorded")]
    public FhirDateTime? Recorded { get; set; }

    /// <summary>
    /// Individual who recorded the record and takes responsibility for its content.
    /// </summary>
    [FhirElement("recorder", Order = 37)]
    [Cardinality(0, 1)]
    [JsonPropertyName("recorder")]
    public Reference<Patient> Recorder { get; set; }

    /// <summary>
    /// Indicates if this record was captured as a secondary &apos;reported&apos; record rather than as an
    /// original primary source-of-truth record. It may also indicate the source of the report. (as boolean)
    /// </summary>
    [FhirElement("reportedBoolean", Order = 38)]
    [Cardinality(0, 1)]
    [ChoiceType("reported", "boolean")]
    [JsonPropertyName("reportedBoolean")]
    public FhirBoolean? ReportedBoolean { get; set; }

    /// <summary>
    /// Indicates if this record was captured as a secondary &apos;reported&apos; record rather than as an
    /// original primary source-of-truth record. It may also indicate the source of the report. (as
    /// Reference)
    /// </summary>
    [FhirElement("reportedReference", Order = 39)]
    [Cardinality(0, 1)]
    [ChoiceType("reported", "reference")]
    [JsonPropertyName("reportedReference")]
    public Reference<Patient> ReportedReference { get; set; }

    /// <summary>
    /// Indicates who or what performed the procedure and how they were involved.
    /// </summary>
    [FhirElement("performer", Order = 40)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("performer")]
    public List<BackboneElement>? Performer { get; set; }

    /// <summary>
    /// The location where the procedure actually happened. E.g. a newborn at home, a tracheostomy at a
    /// restaurant.
    /// </summary>
    [FhirElement("location", Order = 41)]
    [Cardinality(0, 1)]
    [JsonPropertyName("location")]
    public Reference<Location> Location { get; set; }

    /// <summary>
    /// The coded reason or reference why the procedure was performed. This may be a coded entity of some
    /// type, be present as text, or be a reference to one of several resources that justify the procedure.
    /// </summary>
    [FhirElement("reason", Order = 42)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("reason")]
    public List<CodeableReference>? Reason { get; set; }

    /// <summary>
    /// Detailed and structured anatomical location information. Multiple locations are allowed - e.g.
    /// multiple punch biopsies of a lesion.
    /// </summary>
    [FhirElement("bodySite", Order = 43)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("bodySite")]
    public List<CodeableConcept>? BodySite { get; set; }

    /// <summary>
    /// The outcome of the procedure - did it resolve the reasons for the procedure being performed?
    /// </summary>
    [FhirElement("outcome", Order = 44)]
    [Cardinality(0, 1)]
    [JsonPropertyName("outcome")]
    public CodeableConcept Outcome { get; set; }

    /// <summary>
    /// This could be a histology result, pathology report, surgical report, etc.
    /// </summary>
    [FhirElement("report", Order = 45)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("report")]
    public List<Reference<DiagnosticReport>>? Report { get; set; }

    /// <summary>
    /// Any complications that occurred during the procedure, or in the immediate post-performance period.
    /// These are generally tracked separately from the notes, which will typically describe the procedure
    /// itself rather than any &apos;post procedure&apos; issues.
    /// </summary>
    [FhirElement("complication", Order = 46)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("complication")]
    public List<CodeableReference>? Complication { get; set; }

    /// <summary>
    /// If the procedure required specific follow up - e.g. removal of sutures. The follow up may be
    /// represented as a simple note or could potentially be more complex, in which case the CarePlan
    /// resource can be used.
    /// </summary>
    [FhirElement("followUp", Order = 47)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("followUp")]
    public List<CodeableConcept>? FollowUp { get; set; }

    /// <summary>
    /// Any other notes and comments about the procedure.
    /// </summary>
    [FhirElement("note", Order = 48)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// A device that is implanted, removed or otherwise manipulated (calibration, battery replacement,
    /// fitting a prosthesis, attaching a wound-vac, etc.) as a focal portion of the Procedure.
    /// </summary>
    [FhirElement("focalDevice", Order = 49)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("focalDevice")]
    public List<BackboneElement>? FocalDevice { get; set; }

    /// <summary>
    /// Identifies medications, devices and any other substance used as part of the procedure.
    /// </summary>
    [FhirElement("used", Order = 50)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("used")]
    public List<CodeableReference>? Used { get; set; }

    /// <summary>
    /// Other resources from the patient record that may be relevant to the procedure. The information from
    /// these resources was either used to create the instance or is provided to help with its
    /// interpretation. This extension should not be used if more specific inline elements or extensions are
    /// available.
    /// </summary>
    [FhirElement("supportingInfo", Order = 51)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("supportingInfo")]
    public List<Reference<Resource>>? SupportingInfo { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for occurrence[x]
        var occurrenceProperties = new[] { nameof(OccurrenceDateTime), nameof(OccurrencePeriod), nameof(OccurrenceString), nameof(OccurrenceRange), nameof(OccurrenceTiming) };
        var occurrenceSetCount = occurrenceProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (occurrenceSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of OccurrenceDateTime, OccurrencePeriod, OccurrenceString, OccurrenceRange, OccurrenceTiming may be specified",
                new[] { nameof(OccurrenceDateTime), nameof(OccurrencePeriod), nameof(OccurrenceString), nameof(OccurrenceRange), nameof(OccurrenceTiming) });
        }

        // Choice Type validation for occurrenceage[x]
        var occurrenceageProperties = new[] { nameof(OccurrenceAge) };
        var occurrenceageSetCount = occurrenceageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (occurrenceageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of OccurrenceAge may be specified",
                new[] { nameof(OccurrenceAge) });
        }

        // Choice Type validation for reported[x]
        var reportedProperties = new[] { nameof(ReportedBoolean), nameof(ReportedReference) };
        var reportedSetCount = reportedProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (reportedSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ReportedBoolean, ReportedReference may be specified",
                new[] { nameof(ReportedBoolean), nameof(ReportedReference) });
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
        // Validate Procedure cardinality
        var procedureCount = Procedure?.Count ?? 0;
        if (procedureCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure' cardinality must be 0..*", new[] { nameof(Procedure) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate InstantiatesCanonical cardinality
        var instantiatescanonicalCount = InstantiatesCanonical?.Count ?? 0;
        if (instantiatescanonicalCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.instantiatesCanonical' cardinality must be 0..*", new[] { nameof(InstantiatesCanonical) });
        }
        // Validate InstantiatesUri cardinality
        var instantiatesuriCount = InstantiatesUri?.Count ?? 0;
        if (instantiatesuriCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.instantiatesUri' cardinality must be 0..*", new[] { nameof(InstantiatesUri) });
        }
        // Validate BasedOn cardinality
        var basedonCount = BasedOn?.Count ?? 0;
        if (basedonCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.basedOn' cardinality must be 0..*", new[] { nameof(BasedOn) });
        }
        // Validate PartOf cardinality
        var partofCount = PartOf?.Count ?? 0;
        if (partofCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.partOf' cardinality must be 0..*", new[] { nameof(PartOf) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'Procedure.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        // Validate Category cardinality
        var categoryCount = Category?.Count ?? 0;
        if (categoryCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.category' cardinality must be 0..*", new[] { nameof(Category) });
        }
        if (Subject == null)
        {
            yield return new ValidationResult("Element 'Procedure.subject' cardinality must be 1..1", new[] { nameof(Subject) });
        }
        // Validate Performer cardinality
        var performerCount = Performer?.Count ?? 0;
        if (performerCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.performer' cardinality must be 0..*", new[] { nameof(Performer) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.performer.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.performer.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Actor == null)
        {
            yield return new ValidationResult("Element 'Procedure.performer.actor' cardinality must be 1..1", new[] { nameof(Actor) });
        }
        // Validate Reason cardinality
        var reasonCount = Reason?.Count ?? 0;
        if (reasonCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.reason' cardinality must be 0..*", new[] { nameof(Reason) });
        }
        // Validate BodySite cardinality
        var bodysiteCount = BodySite?.Count ?? 0;
        if (bodysiteCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.bodySite' cardinality must be 0..*", new[] { nameof(BodySite) });
        }
        // Validate Report cardinality
        var reportCount = Report?.Count ?? 0;
        if (reportCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.report' cardinality must be 0..*", new[] { nameof(Report) });
        }
        // Validate Complication cardinality
        var complicationCount = Complication?.Count ?? 0;
        if (complicationCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.complication' cardinality must be 0..*", new[] { nameof(Complication) });
        }
        // Validate FollowUp cardinality
        var followupCount = FollowUp?.Count ?? 0;
        if (followupCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.followUp' cardinality must be 0..*", new[] { nameof(FollowUp) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.note' cardinality must be 0..*", new[] { nameof(Note) });
        }
        // Validate FocalDevice cardinality
        var focaldeviceCount = FocalDevice?.Count ?? 0;
        if (focaldeviceCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.focalDevice' cardinality must be 0..*", new[] { nameof(FocalDevice) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.focalDevice.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.focalDevice.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Manipulated == null)
        {
            yield return new ValidationResult("Element 'Procedure.focalDevice.manipulated' cardinality must be 1..1", new[] { nameof(Manipulated) });
        }
        // Validate Used cardinality
        var usedCount = Used?.Count ?? 0;
        if (usedCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.used' cardinality must be 0..*", new[] { nameof(Used) });
        }
        // Validate SupportingInfo cardinality
        var supportinginfoCount = SupportingInfo?.Count ?? 0;
        if (supportinginfoCount < 0)
        {
            yield return new ValidationResult("Element 'Procedure.supportingInfo' cardinality must be 0..*", new[] { nameof(SupportingInfo) });
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
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/event-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(Procedure) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(Procedure) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(Procedure) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(Procedure) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(Procedure) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Recorded) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Recorder) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Reported) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Performer) });
        // }
        // Constraint: prc-1
        // Expression: onBehalfOf.exists() and actor.resolve().exists() implies actor.resolve().where($this is Practitioner or $this is PractitionerRole).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("onBehalfOf.exists() and actor.resolve().exists() implies actor.resolve().where($this is Practitioner or $this is PractitionerRole).empty()"))
        // {
        //     yield return new ValidationResult("Procedure.performer.onBehalfOf can only be populated when performer.actor isn't Practitioner or PractitionerRole", new[] { nameof(Performer) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(OnBehalfOf) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BodySite) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Outcome) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Report) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Complication) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(FollowUp) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(FocalDevice) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Action) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Manipulated) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Used) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SupportingInfo) });
        // }
    }

}
