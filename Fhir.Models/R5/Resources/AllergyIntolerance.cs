// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Risk of harmful or undesirable, physiological response which is unique to an individual and
/// associated with exposure to a substance.
/// </summary>
public class AllergyIntolerance : DomainResource
{
    public override string ResourceType => "AllergyIntolerance";

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
    /// Business identifiers assigned to this AllergyIntolerance by the performer or other systems which
    /// remain constant as the resource is updated and propagates from server to server.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The clinical status of the allergy or intolerance.
    /// </summary>
    [FhirElement("clinicalStatus", Order = 19)]
    [Cardinality(0, 1)]
    [JsonPropertyName("clinicalStatus")]
    public CodeableConcept ClinicalStatus { get; set; }

    /// <summary>
    /// Assertion about certainty associated with the propensity, or potential risk, of a reaction to the
    /// identified substance (including pharmaceutical product). The verification status pertains to the
    /// allergy or intolerance, itself, not to any specific AllergyIntolerance attribute.
    /// </summary>
    [FhirElement("verificationStatus", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("verificationStatus")]
    public CodeableConcept VerificationStatus { get; set; }

    /// <summary>
    /// Identification of the underlying physiological mechanism for the reaction risk.
    /// </summary>
    [FhirElement("type", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// Category of the identified substance.
    /// </summary>
    [FhirElement("category", Order = 22)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("category")]
    public List<FhirCode>? Category { get; set; }

    /// <summary>
    /// Estimate of the potential clinical harm, or seriousness, of the reaction to the identified
    /// substance.
    /// </summary>
    [FhirElement("criticality", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("criticality")]
    public FhirCode? Criticality { get; set; }

    /// <summary>
    /// Code for an allergy or intolerance statement (either a positive or a negated/excluded statement).
    /// This may be a code for a substance or pharmaceutical product that is considered to be responsible
    /// for the adverse reaction risk (e.g., &quot;Latex&quot;), an allergy or intolerance condition (e.g.,
    /// &quot;Latex allergy&quot;), or a negated/excluded code for a specific substance or class (e.g.,
    /// &quot;No latex allergy&quot;) or a general or categorical negated statement (e.g., &quot;No known
    /// allergy&quot;, &quot;No known drug allergies&quot;). Note: the substance for a specific reaction may
    /// be different from the substance identified as the cause of the risk, but it must be consistent with
    /// it. For instance, it may be a more specific substance (e.g. a brand medication) or a composite
    /// product that includes the identified substance. It must be clinically safe to only process the
    /// &apos;code&apos; and ignore the &apos;reaction.substance&apos;. If a receiving system is unable to
    /// confirm that AllergyIntolerance.reaction.substance falls within the semantic scope of
    /// AllergyIntolerance.code, then the receiving system should ignore
    /// AllergyIntolerance.reaction.substance.
    /// </summary>
    [FhirElement("code", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; }

    /// <summary>
    /// The patient who has the allergy or intolerance.
    /// </summary>
    [FhirElement("patient", Order = 25)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("patient")]
    public Reference<Patient> Patient { get; set; }

    /// <summary>
    /// The encounter when the allergy or intolerance was asserted.
    /// </summary>
    [FhirElement("encounter", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, or age when allergy or intolerance was identified. (as
    /// dateTime)
    /// </summary>
    [FhirElement("onsetDateTime", Order = 27)]
    [Cardinality(0, 1)]
    [ChoiceType("onset", "dateTime")]
    [JsonPropertyName("onsetDateTime")]
    public FhirDateTime? OnsetDateTime { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, or age when allergy or intolerance was identified. (as Age)
    /// </summary>
    [FhirElement("onsetageUnknown", Order = 28)]
    [Cardinality(0, 1)]
    [ChoiceType("onsetage", "unknown")]
    [JsonPropertyName("onsetageUnknown")]
    public Age OnsetAge { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, or age when allergy or intolerance was identified. (as Period)
    /// </summary>
    [FhirElement("onsetPeriod", Order = 29)]
    [Cardinality(0, 1)]
    [ChoiceType("onset", "period")]
    [JsonPropertyName("onsetPeriod")]
    public Period OnsetPeriod { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, or age when allergy or intolerance was identified. (as Range)
    /// </summary>
    [FhirElement("onsetRange", Order = 30)]
    [Cardinality(0, 1)]
    [ChoiceType("onset", "range")]
    [JsonPropertyName("onsetRange")]
    public Range OnsetRange { get; set; }

    /// <summary>
    /// Estimated or actual date, date-time, or age when allergy or intolerance was identified. (as string)
    /// </summary>
    [FhirElement("onsetString", Order = 31)]
    [Cardinality(0, 1)]
    [ChoiceType("onset", "string")]
    [JsonPropertyName("onsetString")]
    public FhirString? OnsetString { get; set; }

    /// <summary>
    /// The recordedDate represents when this particular AllergyIntolerance record was created in the
    /// system, which is often a system-generated date.
    /// </summary>
    [FhirElement("recordedDate", Order = 32)]
    [Cardinality(0, 1)]
    [JsonPropertyName("recordedDate")]
    public FhirDateTime? RecordedDate { get; set; }

    /// <summary>
    /// Indicates who or what participated in the activities related to the allergy or intolerance and how
    /// they were involved.
    /// </summary>
    [FhirElement("participant", Order = 33)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("participant")]
    public List<BackboneElement>? Participant { get; set; }

    /// <summary>
    /// Represents the date and/or time of the last known occurrence of a reaction event.
    /// </summary>
    [FhirElement("lastOccurrence", Order = 34)]
    [Cardinality(0, 1)]
    [JsonPropertyName("lastOccurrence")]
    public FhirDateTime? LastOccurrence { get; set; }

    /// <summary>
    /// Additional narrative about the propensity for the Adverse Reaction, not captured in other fields.
    /// </summary>
    [FhirElement("note", Order = 35)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// Details about each adverse reaction event linked to exposure to the identified substance.
    /// </summary>
    [FhirElement("reaction", Order = 36)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("reaction")]
    public List<BackboneElement>? Reaction { get; set; }

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

    }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate AllergyIntolerance cardinality
        var allergyintoleranceCount = AllergyIntolerance?.Count ?? 0;
        if (allergyintoleranceCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance' cardinality must be 0..*", new[] { nameof(AllergyIntolerance) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate Category cardinality
        var categoryCount = Category?.Count ?? 0;
        if (categoryCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.category' cardinality must be 0..*", new[] { nameof(Category) });
        }
        if (Patient == null)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.patient' cardinality must be 1..1", new[] { nameof(Patient) });
        }
        // Validate Participant cardinality
        var participantCount = Participant?.Count ?? 0;
        if (participantCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.participant' cardinality must be 0..*", new[] { nameof(Participant) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.participant.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.participant.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Actor == null)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.participant.actor' cardinality must be 1..1", new[] { nameof(Actor) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.note' cardinality must be 0..*", new[] { nameof(Note) });
        }
        // Validate Reaction cardinality
        var reactionCount = Reaction?.Count ?? 0;
        if (reactionCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.reaction' cardinality must be 0..*", new[] { nameof(Reaction) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.reaction.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.reaction.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Manifestation cardinality
        var manifestationCount = Manifestation?.Count ?? 0;
        if (manifestationCount < 1)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.reaction.manifestation' cardinality must be 1..*", new[] { nameof(Manifestation) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'AllergyIntolerance.reaction.note' cardinality must be 0..*", new[] { nameof(Note) });
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
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/allergyintolerance-clinical|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate VerificationStatus ValueSet binding
        if (VerificationStatus != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/allergyintolerance-verification|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Category ValueSet binding
        if (Category != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/allergy-intolerance-category|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Criticality ValueSet binding
        if (Criticality != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/allergy-intolerance-criticality|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Function ValueSet binding
        if (Function != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/participation-role-type
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Severity ValueSet binding
        if (Severity != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/reaction-event-severity|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(AllergyIntolerance) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(AllergyIntolerance) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(AllergyIntolerance) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(AllergyIntolerance) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(AllergyIntolerance) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Criticality) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Patient) });
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
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(LastOccurrence) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Reaction) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Substance) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Manifestation) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Onset) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ExposureRoute) });
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
