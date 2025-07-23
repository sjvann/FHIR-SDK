// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A guidance response is the formal response to a guidance request, including any output parameters
/// returned by the evaluation, as well as the description of any proposed actions to be taken.
/// </summary>
public class GuidanceResponse : DomainResource
{
    public override string ResourceType => "GuidanceResponse";

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
    /// The identifier of the request associated with this response. If an identifier was given as part of
    /// the request, it will be reproduced here to enable the requester to more easily identify the response
    /// in a multi-request scenario.
    /// </summary>
    [FhirElement("requestIdentifier", Order = 18)]
    [Cardinality(0, 1)]
    [JsonPropertyName("requestIdentifier")]
    public Identifier RequestIdentifier { get; set; }

    /// <summary>
    /// Allows a service to provide unique, business identifiers for the response.
    /// </summary>
    [FhirElement("identifier", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// An identifier, CodeableConcept or canonical reference to the guidance that was requested. (as uri)
    /// </summary>
    [FhirElement("moduleUri", Order = 20)]
    [Cardinality(1, 1)]
    [ChoiceType("module", "uri")]
    [Required]
    [JsonPropertyName("moduleUri")]
    public FhirUri ModuleUri { get; set; }

    /// <summary>
    /// An identifier, CodeableConcept or canonical reference to the guidance that was requested. (as
    /// canonical)
    /// </summary>
    [FhirElement("modulecanonicalUnknown", Order = 21)]
    [Cardinality(1, 1)]
    [ChoiceType("modulecanonical", "unknown")]
    [Required]
    [JsonPropertyName("modulecanonicalUnknown")]
    public FhirCanonical ModuleCanonical { get; set; }

    /// <summary>
    /// An identifier, CodeableConcept or canonical reference to the guidance that was requested. (as
    /// CodeableConcept)
    /// </summary>
    [FhirElement("moduleCodeableConcept", Order = 22)]
    [Cardinality(1, 1)]
    [ChoiceType("module", "codeableConcept")]
    [Required]
    [JsonPropertyName("moduleCodeableConcept")]
    public CodeableConcept ModuleCodeableConcept { get; set; }

    /// <summary>
    /// The status of the response. If the evaluation is completed successfully, the status will indicate
    /// success. However, in order to complete the evaluation, the engine may require more information. In
    /// this case, the status will be data-required, and the response will contain a description of the
    /// additional required information. If the evaluation completed successfully, but the engine determines
    /// that a potentially more accurate response could be provided if more data was available, the status
    /// will be data-requested, and the response will contain a description of the additional requested
    /// information.
    /// </summary>
    [FhirElement("status", Order = 23)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// The patient for which the request was processed.
    /// </summary>
    [FhirElement("subject", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("subject")]
    public Reference<Patient> Subject { get; set; }

    /// <summary>
    /// The encounter during which this response was created or to which the creation of this record is
    /// tightly associated.
    /// </summary>
    [FhirElement("encounter", Order = 25)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// Indicates when the guidance response was processed.
    /// </summary>
    [FhirElement("occurrenceDateTime", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("occurrenceDateTime")]
    public FhirDateTime? OccurrenceDateTime { get; set; }

    /// <summary>
    /// Provides a reference to the device that performed the guidance.
    /// </summary>
    [FhirElement("performer", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("performer")]
    public Reference<Device> Performer { get; set; }

    /// <summary>
    /// Describes the reason for the guidance response in coded or textual form, or Indicates the reason the
    /// request was initiated. This is typically provided as a parameter to the evaluation and echoed by the
    /// service, although for some use cases, such as subscription- or event-based scenarios, it may provide
    /// an indication of the cause for the response.
    /// </summary>
    [FhirElement("reason", Order = 28)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("reason")]
    public List<CodeableReference>? Reason { get; set; }

    /// <summary>
    /// Provides a mechanism to communicate additional information about the response.
    /// </summary>
    [FhirElement("note", Order = 29)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// Messages resulting from the evaluation of the artifact or artifacts. As part of evaluating the
    /// request, the engine may produce informational or warning messages. These messages will be provided
    /// by this element.
    /// </summary>
    [FhirElement("evaluationMessage", Order = 30)]
    [Cardinality(0, 1)]
    [JsonPropertyName("evaluationMessage")]
    public Reference<OperationOutcome> EvaluationMessage { get; set; }

    /// <summary>
    /// The output parameters of the evaluation, if any. Many modules will result in the return of specific
    /// resources such as procedure or communication requests that are returned as part of the operation
    /// result. However, modules may define specific outputs that would be returned as the result of the
    /// evaluation, and these would be returned in this element.
    /// </summary>
    [FhirElement("outputParameters", Order = 31)]
    [Cardinality(0, 1)]
    [JsonPropertyName("outputParameters")]
    public Reference<Parameters> OutputParameters { get; set; }

    /// <summary>
    /// The actions, if any, produced by the evaluation of the artifact.
    /// </summary>
    [FhirElement("result", Order = 32)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("result")]
    public List<Reference<Appointment>>? Result { get; set; }

    /// <summary>
    /// If the evaluation could not be completed due to lack of information, or additional information would
    /// potentially result in a more accurate response, this element will a description of the data required
    /// in order to proceed with the evaluation. A subsequent request to the service should include this
    /// data.
    /// </summary>
    [FhirElement("dataRequirement", Order = 33)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("dataRequirement")]
    public List<DataRequirement>? DataRequirement { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for module[x]
        var moduleProperties = new[] { nameof(ModuleUri), nameof(ModuleCodeableConcept) };
        var moduleSetCount = moduleProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (moduleSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ModuleUri, ModuleCodeableConcept may be specified",
                new[] { nameof(ModuleUri), nameof(ModuleCodeableConcept) });
        }

        // Choice Type validation for modulecanonical[x]
        var modulecanonicalProperties = new[] { nameof(ModuleCanonical) };
        var modulecanonicalSetCount = modulecanonicalProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (modulecanonicalSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ModuleCanonical may be specified",
                new[] { nameof(ModuleCanonical) });
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
        // Validate GuidanceResponse cardinality
        var guidanceresponseCount = GuidanceResponse?.Count ?? 0;
        if (guidanceresponseCount < 0)
        {
            yield return new ValidationResult("Element 'GuidanceResponse' cardinality must be 0..*", new[] { nameof(GuidanceResponse) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'GuidanceResponse.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'GuidanceResponse.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'GuidanceResponse.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'GuidanceResponse.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        if (Module == null)
        {
            yield return new ValidationResult("Element 'GuidanceResponse.module[x]' cardinality must be 1..1", new[] { nameof(Module) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'GuidanceResponse.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        // Validate Reason cardinality
        var reasonCount = Reason?.Count ?? 0;
        if (reasonCount < 0)
        {
            yield return new ValidationResult("Element 'GuidanceResponse.reason' cardinality must be 0..*", new[] { nameof(Reason) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'GuidanceResponse.note' cardinality must be 0..*", new[] { nameof(Note) });
        }
        // Validate Result cardinality
        var resultCount = Result?.Count ?? 0;
        if (resultCount < 0)
        {
            yield return new ValidationResult("Element 'GuidanceResponse.result' cardinality must be 0..*", new[] { nameof(Result) });
        }
        // Validate DataRequirement cardinality
        var datarequirementCount = DataRequirement?.Count ?? 0;
        if (datarequirementCount < 0)
        {
            yield return new ValidationResult("Element 'GuidanceResponse.dataRequirement' cardinality must be 0..*", new[] { nameof(DataRequirement) });
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
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/guidance-response-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(GuidanceResponse) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(GuidanceResponse) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(GuidanceResponse) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(GuidanceResponse) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(GuidanceResponse) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RequestIdentifier) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Module) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(OccurrenceDateTime) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(EvaluationMessage) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(OutputParameters) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Result) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DataRequirement) });
        // }
    }

}
