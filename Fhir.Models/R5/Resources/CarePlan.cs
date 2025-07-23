// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Describes the intention of how one or more practitioners intend to deliver care for a particular
/// patient, group or community for a period of time, possibly limited to care for a specific condition
/// or set of conditions.
/// </summary>
public class CarePlan : DomainResource
{
    public override string ResourceType => "CarePlan";

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
    /// Business identifiers assigned to this care plan by the performer or other systems which remain
    /// constant as the resource is updated and propagates from server to server.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The URL pointing to a FHIR-defined protocol, guideline, questionnaire or other definition that is
    /// adhered to in whole or in part by this CarePlan.
    /// </summary>
    [FhirElement("instantiatesCanonical", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("instantiatesCanonical")]
    public List<FhirCanonical>? InstantiatesCanonical { get; set; }

    /// <summary>
    /// The URL pointing to an externally maintained protocol, guideline, questionnaire or other definition
    /// that is adhered to in whole or in part by this CarePlan.
    /// </summary>
    [FhirElement("instantiatesUri", Order = 20)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("instantiatesUri")]
    public List<FhirUri>? InstantiatesUri { get; set; }

    /// <summary>
    /// A higher-level request resource (i.e. a plan, proposal or order) that is fulfilled in whole or in
    /// part by this care plan.
    /// </summary>
    [FhirElement("basedOn", Order = 21)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("basedOn")]
    public List<Reference<CarePlan>>? BasedOn { get; set; }

    /// <summary>
    /// Completed or terminated care plan whose function is taken by this new care plan.
    /// </summary>
    [FhirElement("replaces", Order = 22)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("replaces")]
    public List<Reference<CarePlan>>? Replaces { get; set; }

    /// <summary>
    /// A larger care plan of which this particular care plan is a component or step.
    /// </summary>
    [FhirElement("partOf", Order = 23)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("partOf")]
    public List<Reference<CarePlan>>? PartOf { get; set; }

    /// <summary>
    /// Indicates whether the plan is currently being acted upon, represents future intentions or is now a
    /// historical record.
    /// </summary>
    [FhirElement("status", Order = 24)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Indicates the level of authority/intentionality associated with the care plan and where the care
    /// plan fits into the workflow chain.
    /// </summary>
    [FhirElement("intent", Order = 25)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("intent")]
    public FhirCode Intent { get; set; }

    /// <summary>
    /// Identifies what &quot;kind&quot; of plan this is to support differentiation between multiple
    /// co-existing plans; e.g. &quot;Home health&quot;, &quot;psychiatric&quot;, &quot;asthma&quot;,
    /// &quot;disease management&quot;, &quot;wellness plan&quot;, etc.
    /// </summary>
    [FhirElement("category", Order = 26)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// Human-friendly name for the care plan.
    /// </summary>
    [FhirElement("title", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("title")]
    public FhirString? Title { get; set; }

    /// <summary>
    /// A description of the scope and nature of the plan.
    /// </summary>
    [FhirElement("description", Order = 28)]
    [Cardinality(0, 1)]
    [JsonPropertyName("description")]
    public FhirString? Description { get; set; }

    /// <summary>
    /// Identifies the patient or group whose intended care is described by the plan.
    /// </summary>
    [FhirElement("subject", Order = 29)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("subject")]
    public Reference<Patient> Subject { get; set; }

    /// <summary>
    /// The Encounter during which this CarePlan was created or to which the creation of this record is
    /// tightly associated.
    /// </summary>
    [FhirElement("encounter", Order = 30)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// Indicates when the plan did (or is intended to) come into effect and end.
    /// </summary>
    [FhirElement("period", Order = 31)]
    [Cardinality(0, 1)]
    [JsonPropertyName("period")]
    public Period Period { get; set; }

    /// <summary>
    /// Represents when this particular CarePlan record was created in the system, which is often a
    /// system-generated date.
    /// </summary>
    [FhirElement("created", Order = 32)]
    [Cardinality(0, 1)]
    [JsonPropertyName("created")]
    public FhirDateTime? Created { get; set; }

    /// <summary>
    /// When populated, the custodian is responsible for the care plan. The care plan is attributed to the
    /// custodian.
    /// </summary>
    [FhirElement("custodian", Order = 33)]
    [Cardinality(0, 1)]
    [JsonPropertyName("custodian")]
    public Reference<Patient> Custodian { get; set; }

    /// <summary>
    /// Identifies the individual(s), organization or device who provided the contents of the care plan.
    /// </summary>
    [FhirElement("contributor", Order = 34)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("contributor")]
    public List<Reference<Patient>>? Contributor { get; set; }

    /// <summary>
    /// Identifies all people and organizations who are expected to be involved in the care envisioned by
    /// this plan.
    /// </summary>
    [FhirElement("careTeam", Order = 35)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("careTeam")]
    public List<Reference<CareTeam>>? CareTeam { get; set; }

    /// <summary>
    /// Identifies the conditions/problems/concerns/diagnoses/etc. whose management and/or mitigation are
    /// handled by this plan.
    /// </summary>
    [FhirElement("addresses", Order = 36)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("addresses")]
    public List<CodeableReference>? Addresses { get; set; }

    /// <summary>
    /// Identifies portions of the patient&apos;s record that specifically influenced the formation of the
    /// plan. These might include comorbidities, recent procedures, limitations, recent assessments, etc.
    /// </summary>
    [FhirElement("supportingInfo", Order = 37)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("supportingInfo")]
    public List<Reference<Resource>>? SupportingInfo { get; set; }

    /// <summary>
    /// Describes the intended objective(s) of carrying out the care plan.
    /// </summary>
    [FhirElement("goal", Order = 38)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("goal")]
    public List<Reference<Goal>>? Goal { get; set; }

    /// <summary>
    /// Identifies an action that has occurred or is a planned action to occur as part of the plan. For
    /// example, a medication to be used, lab tests to perform, self-monitoring that has occurred, education
    /// etc.
    /// </summary>
    [FhirElement("activity", Order = 39)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("activity")]
    public List<BackboneElement>? Activity { get; set; }

    /// <summary>
    /// General notes about the care plan not covered elsewhere.
    /// </summary>
    [FhirElement("note", Order = 40)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate CarePlan cardinality
        var careplanCount = CarePlan?.Count ?? 0;
        if (careplanCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan' cardinality must be 0..*", new[] { nameof(CarePlan) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate InstantiatesCanonical cardinality
        var instantiatescanonicalCount = InstantiatesCanonical?.Count ?? 0;
        if (instantiatescanonicalCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.instantiatesCanonical' cardinality must be 0..*", new[] { nameof(InstantiatesCanonical) });
        }
        // Validate InstantiatesUri cardinality
        var instantiatesuriCount = InstantiatesUri?.Count ?? 0;
        if (instantiatesuriCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.instantiatesUri' cardinality must be 0..*", new[] { nameof(InstantiatesUri) });
        }
        // Validate BasedOn cardinality
        var basedonCount = BasedOn?.Count ?? 0;
        if (basedonCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.basedOn' cardinality must be 0..*", new[] { nameof(BasedOn) });
        }
        // Validate Replaces cardinality
        var replacesCount = Replaces?.Count ?? 0;
        if (replacesCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.replaces' cardinality must be 0..*", new[] { nameof(Replaces) });
        }
        // Validate PartOf cardinality
        var partofCount = PartOf?.Count ?? 0;
        if (partofCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.partOf' cardinality must be 0..*", new[] { nameof(PartOf) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'CarePlan.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        if (Intent == null)
        {
            yield return new ValidationResult("Element 'CarePlan.intent' cardinality must be 1..1", new[] { nameof(Intent) });
        }
        // Validate Category cardinality
        var categoryCount = Category?.Count ?? 0;
        if (categoryCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.category' cardinality must be 0..*", new[] { nameof(Category) });
        }
        if (Subject == null)
        {
            yield return new ValidationResult("Element 'CarePlan.subject' cardinality must be 1..1", new[] { nameof(Subject) });
        }
        // Validate Contributor cardinality
        var contributorCount = Contributor?.Count ?? 0;
        if (contributorCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.contributor' cardinality must be 0..*", new[] { nameof(Contributor) });
        }
        // Validate CareTeam cardinality
        var careteamCount = CareTeam?.Count ?? 0;
        if (careteamCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.careTeam' cardinality must be 0..*", new[] { nameof(CareTeam) });
        }
        // Validate Addresses cardinality
        var addressesCount = Addresses?.Count ?? 0;
        if (addressesCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.addresses' cardinality must be 0..*", new[] { nameof(Addresses) });
        }
        // Validate SupportingInfo cardinality
        var supportinginfoCount = SupportingInfo?.Count ?? 0;
        if (supportinginfoCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.supportingInfo' cardinality must be 0..*", new[] { nameof(SupportingInfo) });
        }
        // Validate Goal cardinality
        var goalCount = Goal?.Count ?? 0;
        if (goalCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.goal' cardinality must be 0..*", new[] { nameof(Goal) });
        }
        // Validate Activity cardinality
        var activityCount = Activity?.Count ?? 0;
        if (activityCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.activity' cardinality must be 0..*", new[] { nameof(Activity) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.activity.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.activity.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate PerformedActivity cardinality
        var performedactivityCount = PerformedActivity?.Count ?? 0;
        if (performedactivityCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.activity.performedActivity' cardinality must be 0..*", new[] { nameof(PerformedActivity) });
        }
        // Validate Progress cardinality
        var progressCount = Progress?.Count ?? 0;
        if (progressCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.activity.progress' cardinality must be 0..*", new[] { nameof(Progress) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'CarePlan.note' cardinality must be 0..*", new[] { nameof(Note) });
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
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/care-plan-intent|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(CarePlan) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(CarePlan) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(CarePlan) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(CarePlan) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(CarePlan) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Title) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Period) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Custodian) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Contributor) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CareTeam) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Addresses) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Goal) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Activity) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PerformedActivity) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Progress) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PlannedActivityReference) });
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
