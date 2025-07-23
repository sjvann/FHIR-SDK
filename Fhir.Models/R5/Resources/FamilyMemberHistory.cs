// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Significant health conditions for a person related to the patient relevant in the context of care
/// for the patient.
/// </summary>
public class FamilyMemberHistory : DomainResource
{
    public override string ResourceType => "FamilyMemberHistory";

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
    /// Business identifiers assigned to this family member history by the performer or other systems which
    /// remain constant as the resource is updated and propagates from server to server.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The URL pointing to a FHIR-defined protocol, guideline, orderset or other definition that is adhered
    /// to in whole or in part by this FamilyMemberHistory.
    /// </summary>
    [FhirElement("instantiatesCanonical", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("instantiatesCanonical")]
    public List<FhirCanonical>? InstantiatesCanonical { get; set; }

    /// <summary>
    /// The URL pointing to an externally maintained protocol, guideline, orderset or other definition that
    /// is adhered to in whole or in part by this FamilyMemberHistory.
    /// </summary>
    [FhirElement("instantiatesUri", Order = 20)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("instantiatesUri")]
    public List<FhirUri>? InstantiatesUri { get; set; }

    /// <summary>
    /// A code specifying the status of the record of the family history of a specific family member.
    /// </summary>
    [FhirElement("status", Order = 21)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Describes why the family member&apos;s history is not available.
    /// </summary>
    [FhirElement("dataAbsentReason", Order = 22)]
    [Cardinality(0, 1)]
    [JsonPropertyName("dataAbsentReason")]
    public CodeableConcept DataAbsentReason { get; set; }

    /// <summary>
    /// The person who this history concerns.
    /// </summary>
    [FhirElement("patient", Order = 23)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("patient")]
    public Reference<Patient> Patient { get; set; }

    /// <summary>
    /// The date (and possibly time) when the family member history was recorded or last updated.
    /// </summary>
    [FhirElement("date", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("date")]
    public FhirDateTime? Date { get; set; }

    /// <summary>
    /// Indicates who or what participated in the activities related to the family member history and how
    /// they were involved.
    /// </summary>
    [FhirElement("participant", Order = 25)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("participant")]
    public List<BackboneElement>? Participant { get; set; }

    /// <summary>
    /// This will either be a name or a description; e.g. &quot;Aunt Susan&quot;, &quot;my cousin with the
    /// red hair&quot;.
    /// </summary>
    [FhirElement("name", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("name")]
    public FhirString? Name { get; set; }

    /// <summary>
    /// The type of relationship this person has to the patient (father, mother, brother etc.).
    /// </summary>
    [FhirElement("relationship", Order = 27)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("relationship")]
    public CodeableConcept Relationship { get; set; }

    /// <summary>
    /// The birth sex of the family member.
    /// </summary>
    [FhirElement("sex", Order = 28)]
    [Cardinality(0, 1)]
    [JsonPropertyName("sex")]
    public CodeableConcept Sex { get; set; }

    /// <summary>
    /// The actual or approximate date of birth of the relative. (as Period)
    /// </summary>
    [FhirElement("bornPeriod", Order = 29)]
    [Cardinality(0, 1)]
    [ChoiceType("born", "period")]
    [JsonPropertyName("bornPeriod")]
    public Period BornPeriod { get; set; }

    /// <summary>
    /// The actual or approximate date of birth of the relative. (as date)
    /// </summary>
    [FhirElement("borndateUnknown", Order = 30)]
    [Cardinality(0, 1)]
    [ChoiceType("borndate", "unknown")]
    [JsonPropertyName("borndateUnknown")]
    public FhirDate? BornDate { get; set; }

    /// <summary>
    /// The actual or approximate date of birth of the relative. (as string)
    /// </summary>
    [FhirElement("bornString", Order = 31)]
    [Cardinality(0, 1)]
    [ChoiceType("born", "string")]
    [JsonPropertyName("bornString")]
    public FhirString? BornString { get; set; }

    /// <summary>
    /// The age of the relative at the time the family member history is recorded. (as Age)
    /// </summary>
    [FhirElement("ageageUnknown", Order = 32)]
    [Cardinality(0, 1)]
    [ChoiceType("ageage", "unknown")]
    [JsonPropertyName("ageageUnknown")]
    public Age AgeAge { get; set; }

    /// <summary>
    /// The age of the relative at the time the family member history is recorded. (as Range)
    /// </summary>
    [FhirElement("ageRange", Order = 33)]
    [Cardinality(0, 1)]
    [ChoiceType("age", "range")]
    [JsonPropertyName("ageRange")]
    public Range AgeRange { get; set; }

    /// <summary>
    /// The age of the relative at the time the family member history is recorded. (as string)
    /// </summary>
    [FhirElement("ageString", Order = 34)]
    [Cardinality(0, 1)]
    [ChoiceType("age", "string")]
    [JsonPropertyName("ageString")]
    public FhirString? AgeString { get; set; }

    /// <summary>
    /// If true, indicates that the age value specified is an estimated value.
    /// </summary>
    [FhirElement("estimatedAge", Order = 35)]
    [Cardinality(0, 1)]
    [JsonPropertyName("estimatedAge")]
    public FhirBoolean? EstimatedAge { get; set; }

    /// <summary>
    /// Deceased flag or the actual or approximate age of the relative at the time of death for the family
    /// member history record. (as boolean)
    /// </summary>
    [FhirElement("deceasedBoolean", Order = 36)]
    [Cardinality(0, 1)]
    [ChoiceType("deceased", "boolean")]
    [JsonPropertyName("deceasedBoolean")]
    public FhirBoolean? DeceasedBoolean { get; set; }

    /// <summary>
    /// Deceased flag or the actual or approximate age of the relative at the time of death for the family
    /// member history record. (as Age)
    /// </summary>
    [FhirElement("deceasedageUnknown", Order = 37)]
    [Cardinality(0, 1)]
    [ChoiceType("deceasedage", "unknown")]
    [JsonPropertyName("deceasedageUnknown")]
    public Age DeceasedAge { get; set; }

    /// <summary>
    /// Deceased flag or the actual or approximate age of the relative at the time of death for the family
    /// member history record. (as Range)
    /// </summary>
    [FhirElement("deceasedRange", Order = 38)]
    [Cardinality(0, 1)]
    [ChoiceType("deceased", "range")]
    [JsonPropertyName("deceasedRange")]
    public Range DeceasedRange { get; set; }

    /// <summary>
    /// Deceased flag or the actual or approximate age of the relative at the time of death for the family
    /// member history record. (as date)
    /// </summary>
    [FhirElement("deceaseddateUnknown", Order = 39)]
    [Cardinality(0, 1)]
    [ChoiceType("deceaseddate", "unknown")]
    [JsonPropertyName("deceaseddateUnknown")]
    public FhirDate? DeceasedDate { get; set; }

    /// <summary>
    /// Deceased flag or the actual or approximate age of the relative at the time of death for the family
    /// member history record. (as string)
    /// </summary>
    [FhirElement("deceasedString", Order = 40)]
    [Cardinality(0, 1)]
    [ChoiceType("deceased", "string")]
    [JsonPropertyName("deceasedString")]
    public FhirString? DeceasedString { get; set; }

    /// <summary>
    /// Describes why the family member history occurred in coded or textual form, or Indicates a Condition,
    /// Observation, AllergyIntolerance, or QuestionnaireResponse that justifies this family member history
    /// event.
    /// </summary>
    [FhirElement("reason", Order = 41)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("reason")]
    public List<CodeableReference>? Reason { get; set; }

    /// <summary>
    /// This property allows a non condition-specific note to the made about the related person. Ideally,
    /// the note would be in the condition property, but this is not always possible.
    /// </summary>
    [FhirElement("note", Order = 42)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// The significant Conditions (or condition) that the family member had. This is a repeating section to
    /// allow a system to represent more than one condition per resource, though there is nothing stopping
    /// multiple resources - one per condition.
    /// </summary>
    [FhirElement("condition", Order = 43)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("condition")]
    public List<BackboneElement>? Condition { get; set; }

    /// <summary>
    /// The significant Procedures (or procedure) that the family member had. This is a repeating section to
    /// allow a system to represent more than one procedure per resource, though there is nothing stopping
    /// multiple resources - one per procedure.
    /// </summary>
    [FhirElement("procedure", Order = 44)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("procedure")]
    public List<BackboneElement>? Procedure { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for born[x]
        var bornProperties = new[] { nameof(BornPeriod), nameof(BornString) };
        var bornSetCount = bornProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (bornSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of BornPeriod, BornString may be specified",
                new[] { nameof(BornPeriod), nameof(BornString) });
        }

        // Choice Type validation for borndate[x]
        var borndateProperties = new[] { nameof(BornDate) };
        var borndateSetCount = borndateProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (borndateSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of BornDate may be specified",
                new[] { nameof(BornDate) });
        }

        // Choice Type validation for ageage[x]
        var ageageProperties = new[] { nameof(AgeAge) };
        var ageageSetCount = ageageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (ageageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of AgeAge may be specified",
                new[] { nameof(AgeAge) });
        }

        // Choice Type validation for age[x]
        var ageProperties = new[] { nameof(AgeRange), nameof(AgeString) };
        var ageSetCount = ageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (ageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of AgeRange, AgeString may be specified",
                new[] { nameof(AgeRange), nameof(AgeString) });
        }

        // Choice Type validation for deceased[x]
        var deceasedProperties = new[] { nameof(DeceasedBoolean), nameof(DeceasedRange), nameof(DeceasedString) };
        var deceasedSetCount = deceasedProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (deceasedSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DeceasedBoolean, DeceasedRange, DeceasedString may be specified",
                new[] { nameof(DeceasedBoolean), nameof(DeceasedRange), nameof(DeceasedString) });
        }

        // Choice Type validation for deceasedage[x]
        var deceasedageProperties = new[] { nameof(DeceasedAge) };
        var deceasedageSetCount = deceasedageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (deceasedageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DeceasedAge may be specified",
                new[] { nameof(DeceasedAge) });
        }

        // Choice Type validation for deceaseddate[x]
        var deceaseddateProperties = new[] { nameof(DeceasedDate) };
        var deceaseddateSetCount = deceaseddateProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (deceaseddateSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DeceasedDate may be specified",
                new[] { nameof(DeceasedDate) });
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
        // Validate FamilyMemberHistory cardinality
        var familymemberhistoryCount = FamilyMemberHistory?.Count ?? 0;
        if (familymemberhistoryCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory' cardinality must be 0..*", new[] { nameof(FamilyMemberHistory) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate InstantiatesCanonical cardinality
        var instantiatescanonicalCount = InstantiatesCanonical?.Count ?? 0;
        if (instantiatescanonicalCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.instantiatesCanonical' cardinality must be 0..*", new[] { nameof(InstantiatesCanonical) });
        }
        // Validate InstantiatesUri cardinality
        var instantiatesuriCount = InstantiatesUri?.Count ?? 0;
        if (instantiatesuriCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.instantiatesUri' cardinality must be 0..*", new[] { nameof(InstantiatesUri) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        if (Patient == null)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.patient' cardinality must be 1..1", new[] { nameof(Patient) });
        }
        // Validate Participant cardinality
        var participantCount = Participant?.Count ?? 0;
        if (participantCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.participant' cardinality must be 0..*", new[] { nameof(Participant) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.participant.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.participant.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Actor == null)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.participant.actor' cardinality must be 1..1", new[] { nameof(Actor) });
        }
        if (Relationship == null)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.relationship' cardinality must be 1..1", new[] { nameof(Relationship) });
        }
        // Validate Reason cardinality
        var reasonCount = Reason?.Count ?? 0;
        if (reasonCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.reason' cardinality must be 0..*", new[] { nameof(Reason) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.note' cardinality must be 0..*", new[] { nameof(Note) });
        }
        // Validate Condition cardinality
        var conditionCount = Condition?.Count ?? 0;
        if (conditionCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.condition' cardinality must be 0..*", new[] { nameof(Condition) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.condition.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.condition.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Code == null)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.condition.code' cardinality must be 1..1", new[] { nameof(Code) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.condition.note' cardinality must be 0..*", new[] { nameof(Note) });
        }
        // Validate Procedure cardinality
        var procedureCount = Procedure?.Count ?? 0;
        if (procedureCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.procedure' cardinality must be 0..*", new[] { nameof(Procedure) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.procedure.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.procedure.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Code == null)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.procedure.code' cardinality must be 1..1", new[] { nameof(Code) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'FamilyMemberHistory.procedure.note' cardinality must be 0..*", new[] { nameof(Note) });
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
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/history-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Function ValueSet binding
        if (Function != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/participation-role-type
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Sex ValueSet binding
        if (Sex != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/administrative-gender
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(FamilyMemberHistory) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(FamilyMemberHistory) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(FamilyMemberHistory) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(FamilyMemberHistory) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(FamilyMemberHistory) });
        // }
        // Constraint: fhs-1
        // Expression: age.empty() or born.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("age.empty() or born.empty()"))
        // {
        //     yield return new ValidationResult("Can have age[x] or born[x], but not both", new[] { nameof(FamilyMemberHistory) });
        // }
        // Constraint: fhs-2
        // Expression: age.exists() or estimatedAge.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("age.exists() or estimatedAge.empty()"))
        // {
        //     yield return new ValidationResult("Can only have estimatedAge if age[x] is present", new[] { nameof(FamilyMemberHistory) });
        // }
        // Constraint: fhs-3
        // Expression: age.empty() or deceased.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("age.empty() or deceased.empty()"))
        // {
        //     yield return new ValidationResult("Can have age[x] or deceased[x], but not both", new[] { nameof(FamilyMemberHistory) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Status) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DataAbsentReason) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Date) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Name) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Relationship) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Sex) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Born) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Age) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(EstimatedAge) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Deceased) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Condition) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Outcome) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ContributedToDeath) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Note) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Procedure) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Outcome) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ContributedToDeath) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Performed) });
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
