// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// The resource ChargeItem describes the provision of healthcare provider products for a certain
/// patient, therefore referring not only to the product, but containing in addition details of the
/// provision, like date, time, amounts and participating organizations and persons. Main Usage of the
/// ChargeItem is to enable the billing process and internal cost allocation.
/// </summary>
public class ChargeItem : DomainResource
{
    public override string ResourceType => "ChargeItem";

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
    /// Identifiers assigned to this event performer or other systems.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// References the (external) source of pricing information, rules of application for the code this
    /// ChargeItem uses.
    /// </summary>
    [FhirElement("definitionUri", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("definitionUri")]
    public List<FhirUri>? DefinitionUri { get; set; }

    /// <summary>
    /// References the source of pricing information, rules of application for the code this ChargeItem
    /// uses.
    /// </summary>
    [FhirElement("definitionCanonical", Order = 20)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("definitionCanonical")]
    public List<FhirCanonical>? DefinitionCanonical { get; set; }

    /// <summary>
    /// The current state of the ChargeItem.
    /// </summary>
    [FhirElement("status", Order = 21)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// ChargeItems can be grouped to larger ChargeItems covering the whole set.
    /// </summary>
    [FhirElement("partOf", Order = 22)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("partOf")]
    public List<Reference<ChargeItem>>? PartOf { get; set; }

    /// <summary>
    /// A code that identifies the charge, like a billing code.
    /// </summary>
    [FhirElement("code", Order = 23)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; }

    /// <summary>
    /// The individual or set of individuals the action is being or was performed on.
    /// </summary>
    [FhirElement("subject", Order = 24)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("subject")]
    public Reference<Patient> Subject { get; set; }

    /// <summary>
    /// This ChargeItem has the details of how the associated Encounter should be billed or otherwise be
    /// handled by finance systems.
    /// </summary>
    [FhirElement("encounter", Order = 25)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// Date/time(s) or duration when the charged service was applied. (as dateTime)
    /// </summary>
    [FhirElement("occurrenceDateTime", Order = 26)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "dateTime")]
    [JsonPropertyName("occurrenceDateTime")]
    public FhirDateTime? OccurrenceDateTime { get; set; }

    /// <summary>
    /// Date/time(s) or duration when the charged service was applied. (as Period)
    /// </summary>
    [FhirElement("occurrencePeriod", Order = 27)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "period")]
    [JsonPropertyName("occurrencePeriod")]
    public Period OccurrencePeriod { get; set; }

    /// <summary>
    /// Date/time(s) or duration when the charged service was applied. (as Timing)
    /// </summary>
    [FhirElement("occurrenceTiming", Order = 28)]
    [Cardinality(0, 1)]
    [ChoiceType("occurrence", "timing")]
    [JsonPropertyName("occurrenceTiming")]
    public Timing OccurrenceTiming { get; set; }

    /// <summary>
    /// Indicates who or what performed or participated in the charged service.
    /// </summary>
    [FhirElement("performer", Order = 29)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("performer")]
    public List<BackboneElement>? Performer { get; set; }

    /// <summary>
    /// The organization performing the service.
    /// </summary>
    [FhirElement("performingOrganization", Order = 30)]
    [Cardinality(0, 1)]
    [JsonPropertyName("performingOrganization")]
    public Reference<Organization> PerformingOrganization { get; set; }

    /// <summary>
    /// The organization requesting the service.
    /// </summary>
    [FhirElement("requestingOrganization", Order = 31)]
    [Cardinality(0, 1)]
    [JsonPropertyName("requestingOrganization")]
    public Reference<Organization> RequestingOrganization { get; set; }

    /// <summary>
    /// The financial cost center permits the tracking of charge attribution.
    /// </summary>
    [FhirElement("costCenter", Order = 32)]
    [Cardinality(0, 1)]
    [JsonPropertyName("costCenter")]
    public Reference<Organization> CostCenter { get; set; }

    /// <summary>
    /// Quantity of which the charge item has been serviced.
    /// </summary>
    [FhirElement("quantity", Order = 33)]
    [Cardinality(0, 1)]
    [JsonPropertyName("quantity")]
    public Quantity Quantity { get; set; }

    /// <summary>
    /// The anatomical location where the related service has been applied.
    /// </summary>
    [FhirElement("bodysite", Order = 34)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("bodysite")]
    public List<CodeableConcept>? Bodysite { get; set; }

    /// <summary>
    /// The unit price of the chargable item.
    /// </summary>
    [FhirElement("unitPriceComponent", Order = 35)]
    [Cardinality(0, 1)]
    [JsonPropertyName("unitPriceComponent")]
    public MonetaryComponent UnitPriceComponent { get; set; }

    /// <summary>
    /// The total price for the chargable item, accounting for the quantity.
    /// </summary>
    [FhirElement("totalPriceComponent", Order = 36)]
    [Cardinality(0, 1)]
    [JsonPropertyName("totalPriceComponent")]
    public MonetaryComponent TotalPriceComponent { get; set; }

    /// <summary>
    /// If the list price or the rule-based factor associated with the code is overridden, this attribute
    /// can capture a text to indicate the reason for this action.
    /// </summary>
    [FhirElement("overrideReason", Order = 37)]
    [Cardinality(0, 1)]
    [JsonPropertyName("overrideReason")]
    public CodeableConcept OverrideReason { get; set; }

    /// <summary>
    /// The device, practitioner, etc. who entered the charge item.
    /// </summary>
    [FhirElement("enterer", Order = 38)]
    [Cardinality(0, 1)]
    [JsonPropertyName("enterer")]
    public Reference<Practitioner> Enterer { get; set; }

    /// <summary>
    /// Date the charge item was entered.
    /// </summary>
    [FhirElement("enteredDate", Order = 39)]
    [Cardinality(0, 1)]
    [JsonPropertyName("enteredDate")]
    public FhirDateTime? EnteredDate { get; set; }

    /// <summary>
    /// Describes why the event occurred in coded or textual form.
    /// </summary>
    [FhirElement("reason", Order = 40)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("reason")]
    public List<CodeableConcept>? Reason { get; set; }

    /// <summary>
    /// Indicated the rendered service that caused this charge.
    /// </summary>
    [FhirElement("service", Order = 41)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("service")]
    public List<CodeableReference>? Service { get; set; }

    /// <summary>
    /// Identifies the device, food, drug or other product being charged either by type code or reference to
    /// an instance.
    /// </summary>
    [FhirElement("product", Order = 42)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("product")]
    public List<CodeableReference>? Product { get; set; }

    /// <summary>
    /// Account into which this ChargeItems belongs.
    /// </summary>
    [FhirElement("account", Order = 43)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("account")]
    public List<Reference<Account>>? Account { get; set; }

    /// <summary>
    /// Comments made about the event by the performer, subject or other participants.
    /// </summary>
    [FhirElement("note", Order = 44)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// Further information supporting this charge.
    /// </summary>
    [FhirElement("supportingInformation", Order = 45)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("supportingInformation")]
    public List<Reference<Resource>>? SupportingInformation { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for occurrence[x]
        var occurrenceProperties = new[] { nameof(OccurrenceDateTime), nameof(OccurrencePeriod), nameof(OccurrenceTiming) };
        var occurrenceSetCount = occurrenceProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (occurrenceSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of OccurrenceDateTime, OccurrencePeriod, OccurrenceTiming may be specified",
                new[] { nameof(OccurrenceDateTime), nameof(OccurrencePeriod), nameof(OccurrenceTiming) });
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
        // Validate ChargeItem cardinality
        var chargeitemCount = ChargeItem?.Count ?? 0;
        if (chargeitemCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem' cardinality must be 0..*", new[] { nameof(ChargeItem) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate DefinitionUri cardinality
        var definitionuriCount = DefinitionUri?.Count ?? 0;
        if (definitionuriCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.definitionUri' cardinality must be 0..*", new[] { nameof(DefinitionUri) });
        }
        // Validate DefinitionCanonical cardinality
        var definitioncanonicalCount = DefinitionCanonical?.Count ?? 0;
        if (definitioncanonicalCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.definitionCanonical' cardinality must be 0..*", new[] { nameof(DefinitionCanonical) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'ChargeItem.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        // Validate PartOf cardinality
        var partofCount = PartOf?.Count ?? 0;
        if (partofCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.partOf' cardinality must be 0..*", new[] { nameof(PartOf) });
        }
        if (Code == null)
        {
            yield return new ValidationResult("Element 'ChargeItem.code' cardinality must be 1..1", new[] { nameof(Code) });
        }
        if (Subject == null)
        {
            yield return new ValidationResult("Element 'ChargeItem.subject' cardinality must be 1..1", new[] { nameof(Subject) });
        }
        // Validate Performer cardinality
        var performerCount = Performer?.Count ?? 0;
        if (performerCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.performer' cardinality must be 0..*", new[] { nameof(Performer) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.performer.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.performer.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Actor == null)
        {
            yield return new ValidationResult("Element 'ChargeItem.performer.actor' cardinality must be 1..1", new[] { nameof(Actor) });
        }
        // Validate Bodysite cardinality
        var bodysiteCount = Bodysite?.Count ?? 0;
        if (bodysiteCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.bodysite' cardinality must be 0..*", new[] { nameof(Bodysite) });
        }
        // Validate Reason cardinality
        var reasonCount = Reason?.Count ?? 0;
        if (reasonCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.reason' cardinality must be 0..*", new[] { nameof(Reason) });
        }
        // Validate Service cardinality
        var serviceCount = Service?.Count ?? 0;
        if (serviceCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.service' cardinality must be 0..*", new[] { nameof(Service) });
        }
        // Validate Product cardinality
        var productCount = Product?.Count ?? 0;
        if (productCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.product' cardinality must be 0..*", new[] { nameof(Product) });
        }
        // Validate Account cardinality
        var accountCount = Account?.Count ?? 0;
        if (accountCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.account' cardinality must be 0..*", new[] { nameof(Account) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.note' cardinality must be 0..*", new[] { nameof(Note) });
        }
        // Validate SupportingInformation cardinality
        var supportinginformationCount = SupportingInformation?.Count ?? 0;
        if (supportinginformationCount < 0)
        {
            yield return new ValidationResult("Element 'ChargeItem.supportingInformation' cardinality must be 0..*", new[] { nameof(SupportingInformation) });
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
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/chargeitem-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(ChargeItem) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(ChargeItem) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(ChargeItem) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(ChargeItem) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(ChargeItem) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DefinitionUri) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DefinitionCanonical) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PartOf) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PerformingOrganization) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RequestingOrganization) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CostCenter) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Bodysite) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(UnitPriceComponent) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(TotalPriceComponent) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(OverrideReason) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Enterer) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(EnteredDate) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Service) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Product) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Note) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SupportingInformation) });
        // }
    }

}
