// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Provenance of a resource is a record that describes entities and processes involved in producing and
/// delivering or otherwise influencing that resource. Provenance provides a critical foundation for
/// assessing authenticity, enabling trust, and allowing reproducibility. Provenance assertions are a
/// form of contextual metadata and can themselves become important records with their own provenance.
/// Provenance statement indicates clinical significance in terms of confidence in authenticity,
/// reliability, and trustworthiness, integrity, and stage in lifecycle (e.g. Document Completion - has
/// the artifact been legally authenticated), all of which may impact security, privacy, and trust
/// policies.
/// </summary>
public class Provenance : DomainResource
{
    public override string ResourceType => "Provenance";

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
    /// The Reference(s) that were generated or updated by the activity described in this resource. A
    /// provenance can point to more than one target if multiple resources were created/updated by the same
    /// activity.
    /// </summary>
    [FhirElement("target", Order = 18)]
    [Cardinality(1, int.MaxValue)]
    [Required]
    [JsonPropertyName("target")]
    public List<Reference<Resource>> Target { get; set; }

    /// <summary>
    /// The period during which the activity occurred. (as Period)
    /// </summary>
    [FhirElement("occurredPeriod", Order = 19)]
    [Cardinality(0, 1)]
    [ChoiceType("occurred", "period")]
    [JsonPropertyName("occurredPeriod")]
    public Period OccurredPeriod { get; set; }

    /// <summary>
    /// The period during which the activity occurred. (as dateTime)
    /// </summary>
    [FhirElement("occurredDateTime", Order = 20)]
    [Cardinality(0, 1)]
    [ChoiceType("occurred", "dateTime")]
    [JsonPropertyName("occurredDateTime")]
    public FhirDateTime? OccurredDateTime { get; set; }

    /// <summary>
    /// The instant of time at which the activity was recorded.
    /// </summary>
    [FhirElement("recorded", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("recorded")]
    public FhirInstant? Recorded { get; set; }

    /// <summary>
    /// Policy or plan the activity was defined by. Typically, a single activity may have multiple
    /// applicable policy documents, such as patient consent, guarantor funding, etc.
    /// </summary>
    [FhirElement("policy", Order = 22)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("policy")]
    public List<FhirUri>? Policy { get; set; }

    /// <summary>
    /// Where the activity occurred, if relevant.
    /// </summary>
    [FhirElement("location", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("location")]
    public Reference<Location> Location { get; set; }

    /// <summary>
    /// The authorization (e.g., PurposeOfUse) that was used during the event being recorded.
    /// </summary>
    [FhirElement("authorization", Order = 24)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("authorization")]
    public List<CodeableReference>? Authorization { get; set; }

    /// <summary>
    /// An activity is something that occurs over a period of time and acts upon or with entities; it may
    /// include consuming, processing, transforming, modifying, relocating, using, or generating entities.
    /// </summary>
    [FhirElement("activity", Order = 25)]
    [Cardinality(0, 1)]
    [JsonPropertyName("activity")]
    public CodeableConcept Activity { get; set; }

    /// <summary>
    /// Allows tracing of authorizatino for the events and tracking whether proposals/recommendations were
    /// acted upon.
    /// </summary>
    [FhirElement("basedOn", Order = 26)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("basedOn")]
    public List<Reference<CarePlan>>? BasedOn { get; set; }

    /// <summary>
    /// The patient element is available to enable deterministic tracking of activities that involve the
    /// patient as the subject of the data used in an activity.
    /// </summary>
    [FhirElement("patient", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("patient")]
    public Reference<Patient> Patient { get; set; }

    /// <summary>
    /// This will typically be the encounter the event occurred, but some events may be initiated prior to
    /// or after the official completion of an encounter but still be tied to the context of the encounter
    /// (e.g. pre-admission lab tests).
    /// </summary>
    [FhirElement("encounter", Order = 28)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// An actor taking a role in an activity for which it can be assigned some degree of responsibility for
    /// the activity taking place.
    /// </summary>
    [FhirElement("agent", Order = 29)]
    [Cardinality(1, int.MaxValue)]
    [Required]
    [JsonPropertyName("agent")]
    public List<BackboneElement> Agent { get; set; }

    /// <summary>
    /// An entity used in this activity.
    /// </summary>
    [FhirElement("entity", Order = 30)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("entity")]
    public List<BackboneElement>? Entity { get; set; }

    /// <summary>
    /// A digital signature on the target Reference(s). The signer should match a Provenance.agent. The
    /// purpose of the signature is indicated.
    /// </summary>
    [FhirElement("signature", Order = 31)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("signature")]
    public List<Signature>? Signature { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for occurred[x]
        var occurredProperties = new[] { nameof(OccurredPeriod), nameof(OccurredDateTime) };
        var occurredSetCount = occurredProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (occurredSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of OccurredPeriod, OccurredDateTime may be specified",
                new[] { nameof(OccurredPeriod), nameof(OccurredDateTime) });
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
        // Validate Provenance cardinality
        var provenanceCount = Provenance?.Count ?? 0;
        if (provenanceCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance' cardinality must be 0..*", new[] { nameof(Provenance) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Target cardinality
        var targetCount = Target?.Count ?? 0;
        if (targetCount < 1)
        {
            yield return new ValidationResult("Element 'Provenance.target' cardinality must be 1..*", new[] { nameof(Target) });
        }
        // Validate Policy cardinality
        var policyCount = Policy?.Count ?? 0;
        if (policyCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.policy' cardinality must be 0..*", new[] { nameof(Policy) });
        }
        // Validate Authorization cardinality
        var authorizationCount = Authorization?.Count ?? 0;
        if (authorizationCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.authorization' cardinality must be 0..*", new[] { nameof(Authorization) });
        }
        // Validate BasedOn cardinality
        var basedonCount = BasedOn?.Count ?? 0;
        if (basedonCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.basedOn' cardinality must be 0..*", new[] { nameof(BasedOn) });
        }
        // Validate Agent cardinality
        var agentCount = Agent?.Count ?? 0;
        if (agentCount < 1)
        {
            yield return new ValidationResult("Element 'Provenance.agent' cardinality must be 1..*", new[] { nameof(Agent) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.agent.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.agent.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Role cardinality
        var roleCount = Role?.Count ?? 0;
        if (roleCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.agent.role' cardinality must be 0..*", new[] { nameof(Role) });
        }
        if (Who == null)
        {
            yield return new ValidationResult("Element 'Provenance.agent.who' cardinality must be 1..1", new[] { nameof(Who) });
        }
        // Validate Entity cardinality
        var entityCount = Entity?.Count ?? 0;
        if (entityCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.entity' cardinality must be 0..*", new[] { nameof(Entity) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.entity.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.entity.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Role == null)
        {
            yield return new ValidationResult("Element 'Provenance.entity.role' cardinality must be 1..1", new[] { nameof(Role) });
        }
        if (What == null)
        {
            yield return new ValidationResult("Element 'Provenance.entity.what' cardinality must be 1..1", new[] { nameof(What) });
        }
        // Validate Agent cardinality
        var agentCount = Agent?.Count ?? 0;
        if (agentCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.entity.agent' cardinality must be 0..*", new[] { nameof(Agent) });
        }
        // Validate Signature cardinality
        var signatureCount = Signature?.Count ?? 0;
        if (signatureCount < 0)
        {
            yield return new ValidationResult("Element 'Provenance.signature' cardinality must be 0..*", new[] { nameof(Signature) });
        }

        // ValueSet binding validation
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Role ValueSet binding
        if (Role != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/provenance-entity-role|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(Provenance) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(Provenance) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(Provenance) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(Provenance) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(Provenance) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Target) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Occurred) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Policy) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Authorization) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BasedOn) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Agent) });
        // }
        // Constraint: prov-1
        // Expression: who.resolve().exists() and onBehalfOf.resolve().exists() implies who.resolve() != onBehalfOf.resolve()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("who.resolve().exists() and onBehalfOf.resolve().exists() implies who.resolve() != onBehalfOf.resolve()"))
        // {
        //     yield return new ValidationResult("Who and onBehalfOf cannot be the same", new[] { nameof(Agent) });
        // }
        // Constraint: prov-2
        // Expression: who.resolve().ofType(PractitionerRole).practitioner.resolve().exists() and onBehalfOf.resolve().ofType(Practitioner).exists() implies who.resolve().practitioner.resolve() != onBehalfOf.resolve()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("who.resolve().ofType(PractitionerRole).practitioner.resolve().exists() and onBehalfOf.resolve().ofType(Practitioner).exists() implies who.resolve().practitioner.resolve() != onBehalfOf.resolve()"))
        // {
        //     yield return new ValidationResult("If who is a PractitionerRole, onBehalfOf can't reference the same Practitioner", new[] { nameof(Agent) });
        // }
        // Constraint: prov-3
        // Expression: who.resolve().ofType(Organization).exists() and onBehalfOf.resolve().ofType(PractitionerRole).organization.resolve().exists() implies who.resolve() != onBehalfOf.resolve().organization.resolve()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("who.resolve().ofType(Organization).exists() and onBehalfOf.resolve().ofType(PractitionerRole).organization.resolve().exists() implies who.resolve() != onBehalfOf.resolve().organization.resolve()"))
        // {
        //     yield return new ValidationResult("If who is an organization, onBehalfOf can't be a PractitionerRole within that organization", new[] { nameof(Agent) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Role) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Who) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Entity) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Role) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(What) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Agent) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Signature) });
        // }
    }

}
