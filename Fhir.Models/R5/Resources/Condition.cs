// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A clinical condition, problem, diagnosis, or other event, situation, issue, or clinical concept that
/// has risen to a level of concern.
/// </summary>
public class Condition : DomainResource
{
    public override string ResourceType => "Condition";

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
    /// Business identifiers assigned to this condition by the performer or other systems which remain
    /// constant as the resource is updated and propagates from server to server.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The clinical status of the condition.
    /// </summary>
    [FhirElement("clinicalStatus", Order = 19)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("clinicalStatus")]
    public CodeableConcept ClinicalStatus { get; set; }

    /// <summary>
    /// The verification status to support the clinical status of the condition. The verification status
    /// pertains to the condition, itself, not to any specific condition attribute.
    /// </summary>
    [FhirElement("verificationStatus", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("verificationStatus")]
    public CodeableConcept VerificationStatus { get; set; }

    /// <summary>
    /// A category assigned to the condition.
    /// </summary>
    [FhirElement("category", Order = 21)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// A subjective assessment of the severity of the condition as evaluated by the clinician.
    /// </summary>
    [FhirElement("severity", Order = 22)]
    [Cardinality(0, 1)]
    [JsonPropertyName("severity")]
    public CodeableConcept Severity { get; set; }

    /// <summary>
    /// Identification of the condition, problem or diagnosis.
    /// </summary>
    [FhirElement("code", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; }

    /// <summary>
    /// The anatomical location where this condition manifests itself.
    /// </summary>
    [FhirElement("bodySite", Order = 24)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("bodySite")]
    public List<CodeableConcept>? BodySite { get; set; }

    /// <summary>
    /// Indicates the patient or group who the condition record is associated with.
    /// </summary>
    [FhirElement("subject", Order = 25)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("subject")]
    public Reference<Patient> Subject { get; set; }

    /// <summary>
    /// The Encounter during which this Condition was created or to which the creation of this record is
    /// tightly associated.
    /// </summary>
    [FhirElement("encounter", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// Estimated or actual date or date-time the condition began, in the opinion of the clinician. (as
    /// dateTime)
    /// </summary>
    [FhirElement("onsetDateTime", Order = 27)]
    [Cardinality(0, 1)]
    [ChoiceType("onset", "dateTime")]
    [JsonPropertyName("onsetDateTime")]
    public FhirDateTime? OnsetDateTime { get; set; }

    /// <summary>
    /// Estimated or actual date or date-time the condition began, in the opinion of the clinician. (as Age)
    /// </summary>
    [FhirElement("onsetageUnknown", Order = 28)]
    [Cardinality(0, 1)]
    [ChoiceType("onsetage", "unknown")]
    [JsonPropertyName("onsetageUnknown")]
    public Age OnsetAge { get; set; }

    /// <summary>
    /// Estimated or actual date or date-time the condition began, in the opinion of the clinician. (as
    /// Period)
    /// </summary>
    [FhirElement("onsetPeriod", Order = 29)]
    [Cardinality(0, 1)]
    [ChoiceType("onset", "period")]
    [JsonPropertyName("onsetPeriod")]
    public Period OnsetPeriod { get; set; }

    /// <summary>
    /// Estimated or actual date or date-time the condition began, in the opinion of the clinician. (as
    /// Range)
    /// </summary>
    [FhirElement("onsetRange", Order = 30)]
    [Cardinality(0, 1)]
    [ChoiceType("onset", "range")]
    [JsonPropertyName("onsetRange")]
    public Range OnsetRange { get; set; }

    /// <summary>
    /// Estimated or actual date or date-time the condition began, in the opinion of the clinician. (as
    /// string)
    /// </summary>
    [FhirElement("onsetString", Order = 31)]
    [Cardinality(0, 1)]
    [ChoiceType("onset", "string")]
    [JsonPropertyName("onsetString")]
    public FhirString? OnsetString { get; set; }

    /// <summary>
    /// The date or estimated date that the condition resolved or went into remission. This is called
    /// &quot;abatement&quot; because of the many overloaded connotations associated with
    /// &quot;remission&quot; or &quot;resolution&quot; - Some conditions, such as chronic conditions, are
    /// never really resolved, but they can abate. (as dateTime)
    /// </summary>
    [FhirElement("abatementDateTime", Order = 32)]
    [Cardinality(0, 1)]
    [ChoiceType("abatement", "dateTime")]
    [JsonPropertyName("abatementDateTime")]
    public FhirDateTime? AbatementDateTime { get; set; }

    /// <summary>
    /// The date or estimated date that the condition resolved or went into remission. This is called
    /// &quot;abatement&quot; because of the many overloaded connotations associated with
    /// &quot;remission&quot; or &quot;resolution&quot; - Some conditions, such as chronic conditions, are
    /// never really resolved, but they can abate. (as Age)
    /// </summary>
    [FhirElement("abatementageUnknown", Order = 33)]
    [Cardinality(0, 1)]
    [ChoiceType("abatementage", "unknown")]
    [JsonPropertyName("abatementageUnknown")]
    public Age AbatementAge { get; set; }

    /// <summary>
    /// The date or estimated date that the condition resolved or went into remission. This is called
    /// &quot;abatement&quot; because of the many overloaded connotations associated with
    /// &quot;remission&quot; or &quot;resolution&quot; - Some conditions, such as chronic conditions, are
    /// never really resolved, but they can abate. (as Period)
    /// </summary>
    [FhirElement("abatementPeriod", Order = 34)]
    [Cardinality(0, 1)]
    [ChoiceType("abatement", "period")]
    [JsonPropertyName("abatementPeriod")]
    public Period AbatementPeriod { get; set; }

    /// <summary>
    /// The date or estimated date that the condition resolved or went into remission. This is called
    /// &quot;abatement&quot; because of the many overloaded connotations associated with
    /// &quot;remission&quot; or &quot;resolution&quot; - Some conditions, such as chronic conditions, are
    /// never really resolved, but they can abate. (as Range)
    /// </summary>
    [FhirElement("abatementRange", Order = 35)]
    [Cardinality(0, 1)]
    [ChoiceType("abatement", "range")]
    [JsonPropertyName("abatementRange")]
    public Range AbatementRange { get; set; }

    /// <summary>
    /// The date or estimated date that the condition resolved or went into remission. This is called
    /// &quot;abatement&quot; because of the many overloaded connotations associated with
    /// &quot;remission&quot; or &quot;resolution&quot; - Some conditions, such as chronic conditions, are
    /// never really resolved, but they can abate. (as string)
    /// </summary>
    [FhirElement("abatementString", Order = 36)]
    [Cardinality(0, 1)]
    [ChoiceType("abatement", "string")]
    [JsonPropertyName("abatementString")]
    public FhirString? AbatementString { get; set; }

    /// <summary>
    /// The recordedDate represents when this particular Condition record was created in the system, which
    /// is often a system-generated date.
    /// </summary>
    [FhirElement("recordedDate", Order = 37)]
    [Cardinality(0, 1)]
    [JsonPropertyName("recordedDate")]
    public FhirDateTime? RecordedDate { get; set; }

    /// <summary>
    /// Indicates who or what participated in the activities related to the condition and how they were
    /// involved.
    /// </summary>
    [FhirElement("participant", Order = 38)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("participant")]
    public List<BackboneElement>? Participant { get; set; }

    /// <summary>
    /// A simple summary of the stage such as &quot;Stage 3&quot; or &quot;Early Onset&quot;. The
    /// determination of the stage is disease-specific, such as cancer, retinopathy of prematurity, kidney
    /// diseases, Alzheimer&apos;s, or Parkinson disease.
    /// </summary>
    [FhirElement("stage", Order = 39)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("stage")]
    public List<BackboneElement>? Stage { get; set; }

    /// <summary>
    /// Supporting evidence / manifestations that are the basis of the Condition&apos;s verification status,
    /// such as evidence that confirmed or refuted the condition.
    /// </summary>
    [FhirElement("evidence", Order = 40)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("evidence")]
    public List<CodeableReference>? Evidence { get; set; }

    /// <summary>
    /// Additional information about the Condition. This is a general notes/comments entry for description
    /// of the Condition, its diagnosis and prognosis.
    /// </summary>
    [FhirElement("note", Order = 41)]
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

        // Choice Type validation for onset[x]
        var onsetProperties = new[] { nameof(OnsetDateTime), nameof(OnsetPeriod), nameof(OnsetRange), nameof(OnsetString) };
        var onsetSetCount = onsetProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (onsetSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of OnsetDateTime, OnsetPeriod, OnsetRange, OnsetString may be specified",
                new[] { nameof(OnsetDateTime), nameof(OnsetPeriod), nameof(OnsetRange), nameof(OnsetString) });
        }

        // Choice Type validation for onsetage[x]
        var onsetageProperties = new[] { nameof(OnsetAge) };
        var onsetageSetCount = onsetageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (onsetageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of OnsetAge may be specified",
                new[] { nameof(OnsetAge) });
        }

        // Choice Type validation for abatement[x]
        var abatementProperties = new[] { nameof(AbatementDateTime), nameof(AbatementPeriod), nameof(AbatementRange), nameof(AbatementString) };
        var abatementSetCount = abatementProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (abatementSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of AbatementDateTime, AbatementPeriod, AbatementRange, AbatementString may be specified",
                new[] { nameof(AbatementDateTime), nameof(AbatementPeriod), nameof(AbatementRange), nameof(AbatementString) });
        }

        // Choice Type validation for abatementage[x]
        var abatementageProperties = new[] { nameof(AbatementAge) };
        var abatementageSetCount = abatementageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (abatementageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of AbatementAge may be specified",
                new[] { nameof(AbatementAge) });
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
        // Validate Condition cardinality
        var conditionCount = Condition?.Count ?? 0;
        if (conditionCount < 0)
        {
            yield return new ValidationResult("Element 'Condition' cardinality must be 0..*", new[] { nameof(Condition) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        if (ClinicalStatus == null)
        {
            yield return new ValidationResult("Element 'Condition.clinicalStatus' cardinality must be 1..1", new[] { nameof(ClinicalStatus) });
        }
        // Validate Category cardinality
        var categoryCount = Category?.Count ?? 0;
        if (categoryCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.category' cardinality must be 0..*", new[] { nameof(Category) });
        }
        // Validate BodySite cardinality
        var bodysiteCount = BodySite?.Count ?? 0;
        if (bodysiteCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.bodySite' cardinality must be 0..*", new[] { nameof(BodySite) });
        }
        if (Subject == null)
        {
            yield return new ValidationResult("Element 'Condition.subject' cardinality must be 1..1", new[] { nameof(Subject) });
        }
        // Validate Participant cardinality
        var participantCount = Participant?.Count ?? 0;
        if (participantCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.participant' cardinality must be 0..*", new[] { nameof(Participant) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.participant.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.participant.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Actor == null)
        {
            yield return new ValidationResult("Element 'Condition.participant.actor' cardinality must be 1..1", new[] { nameof(Actor) });
        }
        // Validate Stage cardinality
        var stageCount = Stage?.Count ?? 0;
        if (stageCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.stage' cardinality must be 0..*", new[] { nameof(Stage) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.stage.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.stage.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Assessment cardinality
        var assessmentCount = Assessment?.Count ?? 0;
        if (assessmentCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.stage.assessment' cardinality must be 0..*", new[] { nameof(Assessment) });
        }
        // Validate Evidence cardinality
        var evidenceCount = Evidence?.Count ?? 0;
        if (evidenceCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.evidence' cardinality must be 0..*", new[] { nameof(Evidence) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'Condition.note' cardinality must be 0..*", new[] { nameof(Note) });
        }

        // ValueSet binding validation
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate ClinicalStatus ValueSet binding
        if (ClinicalStatus != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/condition-clinical|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate VerificationStatus ValueSet binding
        if (VerificationStatus != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/condition-ver-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Function ValueSet binding
        if (Function != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/participation-role-type
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: con-2
        // Expression: category.coding.where(system='http://terminology.hl7.org/CodeSystem/condition-category' and code='problem-list-item').exists() implies clinicalStatus.coding.where(system='http://terminology.hl7.org/CodeSystem/condition-clinical' and code='unknown').exists().not()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("category.coding.where(system='http://terminology.hl7.org/CodeSystem/condition-category' and code='problem-list-item').exists() implies clinicalStatus.coding.where(system='http://terminology.hl7.org/CodeSystem/condition-clinical' and code='unknown').exists().not()"))
        // {
        //     yield return new ValidationResult("If category is problems list item, the clinicalStatus should not be unknown", new[] { nameof(Condition) });
        // }
        // Constraint: con-3
        // Expression: abatement.exists() implies (clinicalStatus.coding.where(system='http://terminology.hl7.org/CodeSystem/condition-clinical' and (code='inactive' or code='resolved' or code='remission')).exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("abatement.exists() implies (clinicalStatus.coding.where(system='http://terminology.hl7.org/CodeSystem/condition-clinical' and (code='inactive' or code='resolved' or code='remission')).exists())"))
        // {
        //     yield return new ValidationResult("If condition is abated, then clinicalStatus must be either inactive, resolved, or remission.", new[] { nameof(Condition) });
        // }
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(Condition) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(Condition) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(Condition) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(Condition) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(Condition) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ClinicalStatus) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(VerificationStatus) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Severity) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BodySite) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Encounter) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Onset) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Abatement) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RecordedDate) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Function) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Actor) });
        // }
        // Constraint: con-1
        // Expression: summary.exists() or assessment.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("summary.exists() or assessment.exists()"))
        // {
        //     yield return new ValidationResult("Stage SHALL have summary or assessment", new[] { nameof(Stage) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Stage) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Summary) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Assessment) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Evidence) });
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
