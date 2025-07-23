// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// The Library resource is a general-purpose container for knowledge asset definitions. It can be used
/// to describe and expose existing knowledge assets such as logic libraries and information model
/// descriptions, as well as to describe a collection of knowledge assets.
/// </summary>
public class Library : DomainResource
{
    public override string ResourceType => "Library";

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
    /// An absolute URI that is used to identify this library when it is referenced in a specification,
    /// model, design or an instance; also called its canonical identifier. This SHOULD be globally unique
    /// and SHOULD be a literal address at which an authoritative instance of this library is (or will be)
    /// published. This URL can be the target of a canonical reference. It SHALL remain the same when the
    /// library is stored on different servers.
    /// </summary>
    [FhirElement("url", Order = 18)]
    [Cardinality(0, 1)]
    [JsonPropertyName("url")]
    public FhirUri? Url { get; set; }

    /// <summary>
    /// A formal identifier that is used to identify this library when it is represented in other formats,
    /// or referenced in a specification, model, design or an instance. e.g. CMS or NQF identifiers for a
    /// measure artifact. Note that at least one identifier is required for non-experimental active
    /// artifacts.
    /// </summary>
    [FhirElement("identifier", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The identifier that is used to identify this version of the library when it is referenced in a
    /// specification, model, design or instance. This is an arbitrary value managed by the library author
    /// and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a
    /// managed version is not available. There is also no expectation that versions can be placed in a
    /// lexicographical sequence. To provide a version consistent with the Decision Support Service
    /// specification, use the format Major.Minor.Revision (e.g. 1.0.0). For more information on versioning
    /// knowledge assets, refer to the Decision Support Service specification. Note that a version is
    /// required for non-experimental active artifacts.
    /// </summary>
    [FhirElement("version", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("version")]
    public FhirString? Version { get; set; }

    /// <summary>
    /// Indicates the mechanism used to compare versions to determine which is more current. (as string)
    /// </summary>
    [FhirElement("versionAlgorithmString", Order = 21)]
    [Cardinality(0, 1)]
    [ChoiceType("versionAlgorithm", "string")]
    [JsonPropertyName("versionAlgorithmString")]
    public FhirString? VersionAlgorithmString { get; set; }

    /// <summary>
    /// Indicates the mechanism used to compare versions to determine which is more current. (as Coding)
    /// </summary>
    [FhirElement("versionAlgorithmCoding", Order = 22)]
    [Cardinality(0, 1)]
    [ChoiceType("versionAlgorithm", "coding")]
    [JsonPropertyName("versionAlgorithmCoding")]
    public Coding VersionAlgorithmCoding { get; set; }

    /// <summary>
    /// A natural language name identifying the library. This name should be usable as an identifier for the
    /// module by machine processing applications such as code generation.
    /// </summary>
    [FhirElement("name", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("name")]
    public FhirString? Name { get; set; }

    /// <summary>
    /// A short, descriptive, user-friendly title for the library.
    /// </summary>
    [FhirElement("title", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("title")]
    public FhirString? Title { get; set; }

    /// <summary>
    /// An explanatory or alternate title for the library giving additional information about its content.
    /// </summary>
    [FhirElement("subtitle", Order = 25)]
    [Cardinality(0, 1)]
    [JsonPropertyName("subtitle")]
    public FhirString? Subtitle { get; set; }

    /// <summary>
    /// The status of this library. Enables tracking the life-cycle of the content.
    /// </summary>
    [FhirElement("status", Order = 26)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// A Boolean value to indicate that this library is authored for testing purposes (or
    /// education/evaluation/marketing) and is not intended to be used for genuine usage.
    /// </summary>
    [FhirElement("experimental", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("experimental")]
    public FhirBoolean? Experimental { get; set; }

    /// <summary>
    /// Identifies the type of library such as a Logic Library, Model Definition, Asset Collection, or
    /// Module Definition.
    /// </summary>
    [FhirElement("type", Order = 28)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// A code or group definition that describes the intended subject of the contents of the library. (as
    /// CodeableConcept)
    /// </summary>
    [FhirElement("subjectCodeableConcept", Order = 29)]
    [Cardinality(0, 1)]
    [ChoiceType("subject", "codeableConcept")]
    [JsonPropertyName("subjectCodeableConcept")]
    public CodeableConcept SubjectCodeableConcept { get; set; }

    /// <summary>
    /// A code or group definition that describes the intended subject of the contents of the library. (as
    /// Reference)
    /// </summary>
    [FhirElement("subjectReference", Order = 30)]
    [Cardinality(0, 1)]
    [ChoiceType("subject", "reference")]
    [JsonPropertyName("subjectReference")]
    public Reference<Group> SubjectReference { get; set; }

    /// <summary>
    /// The date (and optionally time) when the library was last significantly changed. The date must change
    /// when the business version changes and it must change if the status code changes. In addition, it
    /// should change when the substantive content of the library changes.
    /// </summary>
    [FhirElement("date", Order = 31)]
    [Cardinality(0, 1)]
    [JsonPropertyName("date")]
    public FhirDateTime? Date { get; set; }

    /// <summary>
    /// The name of the organization or individual responsible for the release and ongoing maintenance of
    /// the library.
    /// </summary>
    [FhirElement("publisher", Order = 32)]
    [Cardinality(0, 1)]
    [JsonPropertyName("publisher")]
    public FhirString? Publisher { get; set; }

    /// <summary>
    /// Contact details to assist a user in finding and communicating with the publisher.
    /// </summary>
    [FhirElement("contact", Order = 33)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("contact")]
    public List<ContactDetail>? Contact { get; set; }

    /// <summary>
    /// A free text natural language description of the library from a consumer&apos;s perspective.
    /// </summary>
    [FhirElement("description", Order = 34)]
    [Cardinality(0, 1)]
    [JsonPropertyName("description")]
    public FhirMarkdown? Description { get; set; }

    /// <summary>
    /// The content was developed with a focus and intent of supporting the contexts that are listed. These
    /// contexts may be general categories (gender, age, ...) or may be references to specific programs
    /// (insurance plans, studies, ...) and may be used to assist with indexing and searching for
    /// appropriate library instances.
    /// </summary>
    [FhirElement("useContext", Order = 35)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("useContext")]
    public List<UsageContext>? UseContext { get; set; }

    /// <summary>
    /// A legal or geographic region in which the library is intended to be used.
    /// </summary>
    [FhirElement("jurisdiction", Order = 36)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("jurisdiction")]
    public List<CodeableConcept>? Jurisdiction { get; set; }

    /// <summary>
    /// Explanation of why this library is needed and why it has been designed as it has.
    /// </summary>
    [FhirElement("purpose", Order = 37)]
    [Cardinality(0, 1)]
    [JsonPropertyName("purpose")]
    public FhirMarkdown? Purpose { get; set; }

    /// <summary>
    /// A detailed description of how the library is used from a clinical perspective.
    /// </summary>
    [FhirElement("usage", Order = 38)]
    [Cardinality(0, 1)]
    [JsonPropertyName("usage")]
    public FhirMarkdown? Usage { get; set; }

    /// <summary>
    /// A copyright statement relating to the library and/or its contents. Copyright statements are
    /// generally legal restrictions on the use and publishing of the library.
    /// </summary>
    [FhirElement("copyright", Order = 39)]
    [Cardinality(0, 1)]
    [JsonPropertyName("copyright")]
    public FhirMarkdown? Copyright { get; set; }

    /// <summary>
    /// A short string (&lt;50 characters), suitable for inclusion in a page footer that identifies the
    /// copyright holder, effective period, and optionally whether rights are resctricted. (e.g. &apos;All
    /// rights reserved&apos;, &apos;Some rights reserved&apos;).
    /// </summary>
    [FhirElement("copyrightLabel", Order = 40)]
    [Cardinality(0, 1)]
    [JsonPropertyName("copyrightLabel")]
    public FhirString? CopyrightLabel { get; set; }

    /// <summary>
    /// The date on which the resource content was approved by the publisher. Approval happens once when the
    /// content is officially approved for usage.
    /// </summary>
    [FhirElement("approvalDate", Order = 41)]
    [Cardinality(0, 1)]
    [JsonPropertyName("approvalDate")]
    public FhirDate? ApprovalDate { get; set; }

    /// <summary>
    /// The date on which the resource content was last reviewed. Review happens periodically after approval
    /// but does not change the original approval date.
    /// </summary>
    [FhirElement("lastReviewDate", Order = 42)]
    [Cardinality(0, 1)]
    [JsonPropertyName("lastReviewDate")]
    public FhirDate? LastReviewDate { get; set; }

    /// <summary>
    /// The period during which the library content was or is planned to be in active use.
    /// </summary>
    [FhirElement("effectivePeriod", Order = 43)]
    [Cardinality(0, 1)]
    [JsonPropertyName("effectivePeriod")]
    public Period EffectivePeriod { get; set; }

    /// <summary>
    /// Descriptive topics related to the content of the library. Topics provide a high-level categorization
    /// of the library that can be useful for filtering and searching.
    /// </summary>
    [FhirElement("topic", Order = 44)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("topic")]
    public List<CodeableConcept>? Topic { get; set; }

    /// <summary>
    /// An individiual or organization primarily involved in the creation and maintenance of the content.
    /// </summary>
    [FhirElement("author", Order = 45)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("author")]
    public List<ContactDetail>? Author { get; set; }

    /// <summary>
    /// An individual or organization primarily responsible for internal coherence of the content.
    /// </summary>
    [FhirElement("editor", Order = 46)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("editor")]
    public List<ContactDetail>? Editor { get; set; }

    /// <summary>
    /// An individual or organization asserted by the publisher to be primarily responsible for review of
    /// some aspect of the content.
    /// </summary>
    [FhirElement("reviewer", Order = 47)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("reviewer")]
    public List<ContactDetail>? Reviewer { get; set; }

    /// <summary>
    /// An individual or organization asserted by the publisher to be responsible for officially endorsing
    /// the content for use in some setting.
    /// </summary>
    [FhirElement("endorser", Order = 48)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("endorser")]
    public List<ContactDetail>? Endorser { get; set; }

    /// <summary>
    /// Related artifacts such as additional documentation, justification, or bibliographic references.
    /// </summary>
    [FhirElement("relatedArtifact", Order = 49)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("relatedArtifact")]
    public List<RelatedArtifact>? RelatedArtifact { get; set; }

    /// <summary>
    /// The parameter element defines parameters used by the library.
    /// </summary>
    [FhirElement("parameter", Order = 50)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("parameter")]
    public List<ParameterDefinition>? Parameter { get; set; }

    /// <summary>
    /// Describes a set of data that must be provided in order to be able to successfully perform the
    /// computations defined by the library.
    /// </summary>
    [FhirElement("dataRequirement", Order = 51)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("dataRequirement")]
    public List<DataRequirement>? DataRequirement { get; set; }

    /// <summary>
    /// The content of the library as an Attachment. The content may be a reference to a url, or may be
    /// directly embedded as a base-64 string. Either way, the contentType of the attachment determines how
    /// to interpret the content.
    /// </summary>
    [FhirElement("content", Order = 52)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("content")]
    public List<Attachment>? Content { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for versionAlgorithm[x]
        var versionAlgorithmProperties = new[] { nameof(VersionAlgorithmString), nameof(VersionAlgorithmCoding) };
        var versionAlgorithmSetCount = versionAlgorithmProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (versionAlgorithmSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of VersionAlgorithmString, VersionAlgorithmCoding may be specified",
                new[] { nameof(VersionAlgorithmString), nameof(VersionAlgorithmCoding) });
        }

        // Choice Type validation for subject[x]
        var subjectProperties = new[] { nameof(SubjectCodeableConcept), nameof(SubjectReference) };
        var subjectSetCount = subjectProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (subjectSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of SubjectCodeableConcept, SubjectReference may be specified",
                new[] { nameof(SubjectCodeableConcept), nameof(SubjectReference) });
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
        // Validate Library cardinality
        var libraryCount = Library?.Count ?? 0;
        if (libraryCount < 0)
        {
            yield return new ValidationResult("Element 'Library' cardinality must be 0..*", new[] { nameof(Library) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'Library.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Library.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Library.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'Library.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'Library.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'Library.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        // Validate Contact cardinality
        var contactCount = Contact?.Count ?? 0;
        if (contactCount < 0)
        {
            yield return new ValidationResult("Element 'Library.contact' cardinality must be 0..*", new[] { nameof(Contact) });
        }
        // Validate UseContext cardinality
        var usecontextCount = UseContext?.Count ?? 0;
        if (usecontextCount < 0)
        {
            yield return new ValidationResult("Element 'Library.useContext' cardinality must be 0..*", new[] { nameof(UseContext) });
        }
        // Validate Jurisdiction cardinality
        var jurisdictionCount = Jurisdiction?.Count ?? 0;
        if (jurisdictionCount < 0)
        {
            yield return new ValidationResult("Element 'Library.jurisdiction' cardinality must be 0..*", new[] { nameof(Jurisdiction) });
        }
        // Validate Topic cardinality
        var topicCount = Topic?.Count ?? 0;
        if (topicCount < 0)
        {
            yield return new ValidationResult("Element 'Library.topic' cardinality must be 0..*", new[] { nameof(Topic) });
        }
        // Validate Author cardinality
        var authorCount = Author?.Count ?? 0;
        if (authorCount < 0)
        {
            yield return new ValidationResult("Element 'Library.author' cardinality must be 0..*", new[] { nameof(Author) });
        }
        // Validate Editor cardinality
        var editorCount = Editor?.Count ?? 0;
        if (editorCount < 0)
        {
            yield return new ValidationResult("Element 'Library.editor' cardinality must be 0..*", new[] { nameof(Editor) });
        }
        // Validate Reviewer cardinality
        var reviewerCount = Reviewer?.Count ?? 0;
        if (reviewerCount < 0)
        {
            yield return new ValidationResult("Element 'Library.reviewer' cardinality must be 0..*", new[] { nameof(Reviewer) });
        }
        // Validate Endorser cardinality
        var endorserCount = Endorser?.Count ?? 0;
        if (endorserCount < 0)
        {
            yield return new ValidationResult("Element 'Library.endorser' cardinality must be 0..*", new[] { nameof(Endorser) });
        }
        // Validate RelatedArtifact cardinality
        var relatedartifactCount = RelatedArtifact?.Count ?? 0;
        if (relatedartifactCount < 0)
        {
            yield return new ValidationResult("Element 'Library.relatedArtifact' cardinality must be 0..*", new[] { nameof(RelatedArtifact) });
        }
        // Validate Parameter cardinality
        var parameterCount = Parameter?.Count ?? 0;
        if (parameterCount < 0)
        {
            yield return new ValidationResult("Element 'Library.parameter' cardinality must be 0..*", new[] { nameof(Parameter) });
        }
        // Validate DataRequirement cardinality
        var datarequirementCount = DataRequirement?.Count ?? 0;
        if (datarequirementCount < 0)
        {
            yield return new ValidationResult("Element 'Library.dataRequirement' cardinality must be 0..*", new[] { nameof(DataRequirement) });
        }
        // Validate Content cardinality
        var contentCount = Content?.Count ?? 0;
        if (contentCount < 0)
        {
            yield return new ValidationResult("Element 'Library.content' cardinality must be 0..*", new[] { nameof(Content) });
        }

        // ValueSet binding validation
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate VersionAlgorithm ValueSet binding
        if (VersionAlgorithm != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/version-algorithm
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Status ValueSet binding
        if (Status != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/publication-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/library-type
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Subject ValueSet binding
        if (Subject != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/participant-resource-types
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Jurisdiction ValueSet binding
        if (Jurisdiction != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/jurisdiction
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: cnl-0
        // Expression: name.exists() implies name.matches('^[A-Z]([A-Za-z0-9_]){1,254}$')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("name.exists() implies name.matches('^[A-Z]([A-Za-z0-9_]){1,254}$')"))
        // {
        //     yield return new ValidationResult("Name should be usable as an identifier for the module by machine processing applications such as code generation", new[] { nameof(Library) });
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
        // Constraint: cnl-1
        // Expression: exists() implies matches('^[^|# ]+$')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("exists() implies matches('^[^|# ]+$')"))
        // {
        //     yield return new ValidationResult("URL should not contain | or # - these characters make processing canonical references problematic", new[] { nameof(Url) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Url) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Version) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(VersionAlgorithm) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Title) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Subtitle) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Experimental) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Subject) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Publisher) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Contact) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(UseContext) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Jurisdiction) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Purpose) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Usage) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CopyrightLabel) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(EffectivePeriod) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Topic) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Editor) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Reviewer) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Endorser) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Parameter) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DataRequirement) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Content) });
        // }
    }

}
