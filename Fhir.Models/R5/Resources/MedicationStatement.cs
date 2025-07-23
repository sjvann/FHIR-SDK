// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A record of a medication that is being consumed by a patient. A MedicationStatement may indicate
/// that the patient may be taking the medication now or has taken the medication in the past or will be
/// taking the medication in the future. The source of this information can be the patient, significant
/// other (such as a family member or spouse), or a clinician. A common scenario where this information
/// is captured is during the history taking process during a patient visit or stay. The medication
/// information may come from sources such as the patient&apos;s memory, from a prescription bottle, or
/// from a list of medications the patient, clinician or other party maintains. The primary difference
/// between a medicationstatement and a medicationadministration is that the medication administration
/// has complete administration information and is based on actual administration information from the
/// person who administered the medication. A medicationstatement is often, if not always, less
/// specific. There is no required date/time when the medication was administered, in fact we only know
/// that a source has reported the patient is taking this medication, where details such as time,
/// quantity, or rate or even medication product may be incomplete or missing or less precise. As stated
/// earlier, the Medication Statement information may come from the patient&apos;s memory, from a
/// prescription bottle or from a list of medications the patient, clinician or other party maintains.
/// Medication administration is more formal and is not missing detailed information.
/// </summary>
public class MedicationStatement : DomainResource
{
    public override string ResourceType => "MedicationStatement";

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
    /// Identifiers associated with this Medication Statement that are defined by business processes and/or
    /// used to refer to it when a direct URL reference to the resource itself is not appropriate. They are
    /// business identifiers assigned to this resource by the performer or other systems and remain constant
    /// as the resource is updated and propagates from server to server.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// A larger event of which this particular MedicationStatement is a component or step.
    /// </summary>
    [FhirElement("partOf", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("partOf")]
    public List<Reference<Procedure>>? PartOf { get; set; }

    /// <summary>
    /// A code representing the status of recording the medication statement.
    /// </summary>
    [FhirElement("status", Order = 20)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Type of medication statement (for example, drug classification like ATC, where meds would be
    /// administered, legal category of the medication.).
    /// </summary>
    [FhirElement("category", Order = 21)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// Identifies the medication being administered. This is either a link to a resource representing the
    /// details of the medication or a simple attribute carrying a code that identifies the medication from
    /// a known list of medications.
    /// </summary>
    [FhirElement("medication", Order = 22)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("medication")]
    public CodeableReference Medication { get; set; }

    /// <summary>
    /// The person, animal or group who is/was taking the medication.
    /// </summary>
    [FhirElement("subject", Order = 23)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("subject")]
    public Reference<Patient> Subject { get; set; }

    /// <summary>
    /// The encounter that establishes the context for this MedicationStatement.
    /// </summary>
    [FhirElement("encounter", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// The interval of time during which it is being asserted that the patient is/was/will be taking the
    /// medication (or was not taking, when the MedicationStatement.adherence element is Not Taking). (as
    /// dateTime)
    /// </summary>
    [FhirElement("effectiveDateTime", Order = 25)]
    [Cardinality(0, 1)]
    [ChoiceType("effective", "dateTime")]
    [JsonPropertyName("effectiveDateTime")]
    public FhirDateTime? EffectiveDateTime { get; set; }

    /// <summary>
    /// The interval of time during which it is being asserted that the patient is/was/will be taking the
    /// medication (or was not taking, when the MedicationStatement.adherence element is Not Taking). (as
    /// Period)
    /// </summary>
    [FhirElement("effectivePeriod", Order = 26)]
    [Cardinality(0, 1)]
    [ChoiceType("effective", "period")]
    [JsonPropertyName("effectivePeriod")]
    public Period EffectivePeriod { get; set; }

    /// <summary>
    /// The interval of time during which it is being asserted that the patient is/was/will be taking the
    /// medication (or was not taking, when the MedicationStatement.adherence element is Not Taking). (as
    /// Timing)
    /// </summary>
    [FhirElement("effectiveTiming", Order = 27)]
    [Cardinality(0, 1)]
    [ChoiceType("effective", "timing")]
    [JsonPropertyName("effectiveTiming")]
    public Timing EffectiveTiming { get; set; }

    /// <summary>
    /// The date when the Medication Statement was asserted by the information source.
    /// </summary>
    [FhirElement("dateAsserted", Order = 28)]
    [Cardinality(0, 1)]
    [JsonPropertyName("dateAsserted")]
    public FhirDateTime? DateAsserted { get; set; }

    /// <summary>
    /// The person or organization that provided the information about the taking of this medication. Note:
    /// Use derivedFrom when a MedicationStatement is derived from other resources, e.g. Claim or
    /// MedicationRequest.
    /// </summary>
    [FhirElement("informationSource", Order = 29)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("informationSource")]
    public List<Reference<Patient>>? InformationSource { get; set; }

    /// <summary>
    /// Allows linking the MedicationStatement to the underlying MedicationRequest, or to other information
    /// that supports or is used to derive the MedicationStatement.
    /// </summary>
    [FhirElement("derivedFrom", Order = 30)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("derivedFrom")]
    public List<Reference<Resource>>? DerivedFrom { get; set; }

    /// <summary>
    /// A concept, Condition or observation that supports why the medication is being/was taken.
    /// </summary>
    [FhirElement("reason", Order = 31)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("reason")]
    public List<CodeableReference>? Reason { get; set; }

    /// <summary>
    /// Provides extra information about the Medication Statement that is not conveyed by the other
    /// attributes.
    /// </summary>
    [FhirElement("note", Order = 32)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// Link to information that is relevant to a medication statement, for example, illicit drug use,
    /// gestational age, etc.
    /// </summary>
    [FhirElement("relatedClinicalInformation", Order = 33)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("relatedClinicalInformation")]
    public List<Reference<Observation>>? RelatedClinicalInformation { get; set; }

    /// <summary>
    /// The full representation of the dose of the medication included in all dosage instructions. To be
    /// used when multiple dosage instructions are included to represent complex dosing such as increasing
    /// or tapering doses.
    /// </summary>
    [FhirElement("renderedDosageInstruction", Order = 34)]
    [Cardinality(0, 1)]
    [JsonPropertyName("renderedDosageInstruction")]
    public FhirMarkdown? RenderedDosageInstruction { get; set; }

    /// <summary>
    /// Indicates how the medication is/was or should be taken by the patient.
    /// </summary>
    [FhirElement("dosage", Order = 35)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("dosage")]
    public List<Dosage>? Dosage { get; set; }

    /// <summary>
    /// Indicates whether the medication is or is not being consumed or administered.
    /// </summary>
    [FhirElement("adherence", Order = 36)]
    [Cardinality(0, 1)]
    [JsonPropertyName("adherence")]
    public BackboneElement Adherence { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for effective[x]
        var effectiveProperties = new[] { nameof(EffectiveDateTime), nameof(EffectivePeriod), nameof(EffectiveTiming) };
        var effectiveSetCount = effectiveProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (effectiveSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of EffectiveDateTime, EffectivePeriod, EffectiveTiming may be specified",
                new[] { nameof(EffectiveDateTime), nameof(EffectivePeriod), nameof(EffectiveTiming) });
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
        // Validate MedicationStatement cardinality
        var medicationstatementCount = MedicationStatement?.Count ?? 0;
        if (medicationstatementCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement' cardinality must be 0..*", new[] { nameof(MedicationStatement) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate PartOf cardinality
        var partofCount = PartOf?.Count ?? 0;
        if (partofCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.partOf' cardinality must be 0..*", new[] { nameof(PartOf) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'MedicationStatement.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        // Validate Category cardinality
        var categoryCount = Category?.Count ?? 0;
        if (categoryCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.category' cardinality must be 0..*", new[] { nameof(Category) });
        }
        if (Medication == null)
        {
            yield return new ValidationResult("Element 'MedicationStatement.medication' cardinality must be 1..1", new[] { nameof(Medication) });
        }
        if (Subject == null)
        {
            yield return new ValidationResult("Element 'MedicationStatement.subject' cardinality must be 1..1", new[] { nameof(Subject) });
        }
        // Validate InformationSource cardinality
        var informationsourceCount = InformationSource?.Count ?? 0;
        if (informationsourceCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.informationSource' cardinality must be 0..*", new[] { nameof(InformationSource) });
        }
        // Validate DerivedFrom cardinality
        var derivedfromCount = DerivedFrom?.Count ?? 0;
        if (derivedfromCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.derivedFrom' cardinality must be 0..*", new[] { nameof(DerivedFrom) });
        }
        // Validate Reason cardinality
        var reasonCount = Reason?.Count ?? 0;
        if (reasonCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.reason' cardinality must be 0..*", new[] { nameof(Reason) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.note' cardinality must be 0..*", new[] { nameof(Note) });
        }
        // Validate RelatedClinicalInformation cardinality
        var relatedclinicalinformationCount = RelatedClinicalInformation?.Count ?? 0;
        if (relatedclinicalinformationCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.relatedClinicalInformation' cardinality must be 0..*", new[] { nameof(RelatedClinicalInformation) });
        }
        // Validate Dosage cardinality
        var dosageCount = Dosage?.Count ?? 0;
        if (dosageCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.dosage' cardinality must be 0..*", new[] { nameof(Dosage) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.adherence.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicationStatement.adherence.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Code == null)
        {
            yield return new ValidationResult("Element 'MedicationStatement.adherence.code' cardinality must be 1..1", new[] { nameof(Code) });
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
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/medication-statement-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(MedicationStatement) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(MedicationStatement) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(MedicationStatement) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(MedicationStatement) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(MedicationStatement) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Category) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Medication) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Effective) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DateAsserted) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(InformationSource) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DerivedFrom) });
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
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RelatedClinicalInformation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RenderedDosageInstruction) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Dosage) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Adherence) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Reason) });
        // }
    }

}
