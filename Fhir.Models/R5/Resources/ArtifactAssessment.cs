// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// This Resource provides one or more comments, classifiers or ratings about a Resource and supports
/// attribution and rights management metadata for the added content.
/// </summary>
public class ArtifactAssessment : DomainResource
{
    public override string ResourceType => "ArtifactAssessment";

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
    /// A formal identifier that is used to identify this artifact assessment when it is represented in
    /// other formats, or referenced in a specification, model, design or an instance.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// A short title for the assessment for use in displaying and selecting.
    /// </summary>
    [FhirElement("title", Order = 19)]
    [Cardinality(0, 1)]
    [JsonPropertyName("title")]
    public FhirString? Title { get; set; }

    /// <summary>
    /// Display of or reference to the bibliographic citation of the comment, classifier, or rating. (as
    /// Reference)
    /// </summary>
    [FhirElement("citeAsReference", Order = 20)]
    [Cardinality(0, 1)]
    [ChoiceType("citeAs", "reference")]
    [JsonPropertyName("citeAsReference")]
    public Reference<Citation> CiteAsReference { get; set; }

    /// <summary>
    /// Display of or reference to the bibliographic citation of the comment, classifier, or rating. (as
    /// markdown)
    /// </summary>
    [FhirElement("citeasmarkdownUnknown", Order = 21)]
    [Cardinality(0, 1)]
    [ChoiceType("citeasmarkdown", "unknown")]
    [JsonPropertyName("citeasmarkdownUnknown")]
    public FhirMarkdown? CiteAsMarkdown { get; set; }

    /// <summary>
    /// The date (and optionally time) when the artifact assessment was published. The date must change when
    /// the disposition changes and it must change if the workflow status code changes. In addition, it
    /// should change when the substantive content of the artifact assessment changes.
    /// </summary>
    [FhirElement("date", Order = 22)]
    [Cardinality(0, 1)]
    [JsonPropertyName("date")]
    public FhirDateTime? Date { get; set; }

    /// <summary>
    /// A copyright statement relating to the artifact assessment and/or its contents. Copyright statements
    /// are generally legal restrictions on the use and publishing of the artifact assessment.
    /// </summary>
    [FhirElement("copyright", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("copyright")]
    public FhirMarkdown? Copyright { get; set; }

    /// <summary>
    /// The date on which the resource content was approved by the publisher. Approval happens once when the
    /// content is officially approved for usage.
    /// </summary>
    [FhirElement("approvalDate", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("approvalDate")]
    public FhirDate? ApprovalDate { get; set; }

    /// <summary>
    /// The date on which the resource content was last reviewed. Review happens periodically after approval
    /// but does not change the original approval date.
    /// </summary>
    [FhirElement("lastReviewDate", Order = 25)]
    [Cardinality(0, 1)]
    [JsonPropertyName("lastReviewDate")]
    public FhirDate? LastReviewDate { get; set; }

    /// <summary>
    /// A reference to a resource, canonical resource, or non-FHIR resource which the comment or assessment
    /// is about. (as Reference)
    /// </summary>
    [FhirElement("artifactReference", Order = 26)]
    [Cardinality(1, 1)]
    [ChoiceType("artifact", "reference")]
    [Required]
    [JsonPropertyName("artifactReference")]
    public Reference<Resource> ArtifactReference { get; set; }

    /// <summary>
    /// A reference to a resource, canonical resource, or non-FHIR resource which the comment or assessment
    /// is about. (as canonical)
    /// </summary>
    [FhirElement("artifactcanonicalUnknown", Order = 27)]
    [Cardinality(1, 1)]
    [ChoiceType("artifactcanonical", "unknown")]
    [Required]
    [JsonPropertyName("artifactcanonicalUnknown")]
    public FhirCanonical ArtifactCanonical { get; set; }

    /// <summary>
    /// A reference to a resource, canonical resource, or non-FHIR resource which the comment or assessment
    /// is about. (as uri)
    /// </summary>
    [FhirElement("artifactUri", Order = 28)]
    [Cardinality(1, 1)]
    [ChoiceType("artifact", "uri")]
    [Required]
    [JsonPropertyName("artifactUri")]
    public FhirUri ArtifactUri { get; set; }

    /// <summary>
    /// A component comment, classifier, or rating of the artifact.
    /// </summary>
    [FhirElement("content", Order = 29)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("content")]
    public List<BackboneElement>? Content { get; set; }

    /// <summary>
    /// Indicates the workflow status of the comment or change request.
    /// </summary>
    [FhirElement("workflowStatus", Order = 30)]
    [Cardinality(0, 1)]
    [JsonPropertyName("workflowStatus")]
    public FhirCode? WorkflowStatus { get; set; }

    /// <summary>
    /// Indicates the disposition of the responsible party to the comment or change request.
    /// </summary>
    [FhirElement("disposition", Order = 31)]
    [Cardinality(0, 1)]
    [JsonPropertyName("disposition")]
    public FhirCode? Disposition { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for citeAs[x]
        var citeAsProperties = new[] { nameof(CiteAsReference) };
        var citeAsSetCount = citeAsProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (citeAsSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of CiteAsReference may be specified",
                new[] { nameof(CiteAsReference) });
        }

        // Choice Type validation for citeasmarkdown[x]
        var citeasmarkdownProperties = new[] { nameof(CiteAsMarkdown) };
        var citeasmarkdownSetCount = citeasmarkdownProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (citeasmarkdownSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of CiteAsMarkdown may be specified",
                new[] { nameof(CiteAsMarkdown) });
        }

        // Choice Type validation for artifact[x]
        var artifactProperties = new[] { nameof(ArtifactReference), nameof(ArtifactUri) };
        var artifactSetCount = artifactProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (artifactSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ArtifactReference, ArtifactUri may be specified",
                new[] { nameof(ArtifactReference), nameof(ArtifactUri) });
        }

        // Choice Type validation for artifactcanonical[x]
        var artifactcanonicalProperties = new[] { nameof(ArtifactCanonical) };
        var artifactcanonicalSetCount = artifactcanonicalProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (artifactcanonicalSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ArtifactCanonical may be specified",
                new[] { nameof(ArtifactCanonical) });
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
        // Validate ArtifactAssessment cardinality
        var artifactassessmentCount = ArtifactAssessment?.Count ?? 0;
        if (artifactassessmentCount < 0)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment' cardinality must be 0..*", new[] { nameof(ArtifactAssessment) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        if (Artifact == null)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment.artifact[x]' cardinality must be 1..1", new[] { nameof(Artifact) });
        }
        // Validate Content cardinality
        var contentCount = Content?.Count ?? 0;
        if (contentCount < 0)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment.content' cardinality must be 0..*", new[] { nameof(Content) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment.content.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment.content.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Classifier cardinality
        var classifierCount = Classifier?.Count ?? 0;
        if (classifierCount < 0)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment.content.classifier' cardinality must be 0..*", new[] { nameof(Classifier) });
        }
        // Validate Path cardinality
        var pathCount = Path?.Count ?? 0;
        if (pathCount < 0)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment.content.path' cardinality must be 0..*", new[] { nameof(Path) });
        }
        // Validate RelatedArtifact cardinality
        var relatedartifactCount = RelatedArtifact?.Count ?? 0;
        if (relatedartifactCount < 0)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment.content.relatedArtifact' cardinality must be 0..*", new[] { nameof(RelatedArtifact) });
        }
        // Validate Component cardinality
        var componentCount = Component?.Count ?? 0;
        if (componentCount < 0)
        {
            yield return new ValidationResult("Element 'ArtifactAssessment.content.component' cardinality must be 0..*", new[] { nameof(Component) });
        }

        // ValueSet binding validation
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate InformationType ValueSet binding
        if (InformationType != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/artifactassessment-information-type|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate WorkflowStatus ValueSet binding
        if (WorkflowStatus != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/artifactassessment-workflow-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Disposition ValueSet binding
        if (Disposition != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/artifactassessment-disposition|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(ArtifactAssessment) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(ArtifactAssessment) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(ArtifactAssessment) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(ArtifactAssessment) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(ArtifactAssessment) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Title) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CiteAs) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Copyright) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ApprovalDate) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(LastReviewDate) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Artifact) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Content) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(InformationType) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Classifier) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Author) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Path) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(RelatedArtifact) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(FreeToShare) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Component) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(WorkflowStatus) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Disposition) });
        // }
    }

}
