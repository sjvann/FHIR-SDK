// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A definition of a FHIR structure. This resource is used to describe the underlying resources, data
/// types defined in FHIR, and also for describing extensions and constraints on resources and data
/// types.
/// </summary>
public class StructureDefinition : DomainResource
{
    public override string ResourceType => "StructureDefinition";

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
    /// An absolute URI that is used to identify this structure definition when it is referenced in a
    /// specification, model, design or an instance; also called its canonical identifier. This SHOULD be
    /// globally unique and SHOULD be a literal address at which an authoritative instance of this structure
    /// definition is (or will be) published. This URL can be the target of a canonical reference. It SHALL
    /// remain the same when the structure definition is stored on different servers.
    /// </summary>
    [FhirElement("url", Order = 18)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("url")]
    public FhirUri Url { get; set; }

    /// <summary>
    /// A formal identifier that is used to identify this structure definition when it is represented in
    /// other formats, or referenced in a specification, model, design or an instance.
    /// </summary>
    [FhirElement("identifier", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The identifier that is used to identify this version of the structure definition when it is
    /// referenced in a specification, model, design or instance. This is an arbitrary value managed by the
    /// structure definition author and is not expected to be globally unique. There is no expectation that
    /// versions can be placed in a lexicographical sequence, so authors are encouraged to populate the
    /// StructureDefinition.versionAlgorithm[x] element to enable comparisons. If there is no managed
    /// version available, authors can consider using ISO date/time syntax (e.g., &apos;2023-01-01&apos;).
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
    /// A natural language name identifying the structure definition. This name should be usable as an
    /// identifier for the module by machine processing applications such as code generation.
    /// </summary>
    [FhirElement("name", Order = 23)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("name")]
    public FhirString Name { get; set; }

    /// <summary>
    /// A short, descriptive, user-friendly title for the structure definition.
    /// </summary>
    [FhirElement("title", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("title")]
    public FhirString? Title { get; set; }

    /// <summary>
    /// The status of this structure definition. Enables tracking the life-cycle of the content.
    /// </summary>
    [FhirElement("status", Order = 25)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// A Boolean value to indicate that this structure definition is authored for testing purposes (or
    /// education/evaluation/marketing) and is not intended to be used for genuine usage.
    /// </summary>
    [FhirElement("experimental", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("experimental")]
    public FhirBoolean? Experimental { get; set; }

    /// <summary>
    /// The date (and optionally time) when the structure definition was last significantly changed. The
    /// date must change when the business version changes and it must change if the status code changes. In
    /// addition, it should change when the substantive content of the structure definition changes.
    /// </summary>
    [FhirElement("date", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("date")]
    public FhirDateTime? Date { get; set; }

    /// <summary>
    /// The name of the organization or individual responsible for the release and ongoing maintenance of
    /// the structure definition.
    /// </summary>
    [FhirElement("publisher", Order = 28)]
    [Cardinality(0, 1)]
    [JsonPropertyName("publisher")]
    public FhirString? Publisher { get; set; }

    /// <summary>
    /// Contact details to assist a user in finding and communicating with the publisher.
    /// </summary>
    [FhirElement("contact", Order = 29)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("contact")]
    public List<ContactDetail>? Contact { get; set; }

    /// <summary>
    /// A free text natural language description of the structure definition from a consumer&apos;s
    /// perspective.
    /// </summary>
    [FhirElement("description", Order = 30)]
    [Cardinality(0, 1)]
    [JsonPropertyName("description")]
    public FhirMarkdown? Description { get; set; }

    /// <summary>
    /// The content was developed with a focus and intent of supporting the contexts that are listed. These
    /// contexts may be general categories (gender, age, ...) or may be references to specific programs
    /// (insurance plans, studies, ...) and may be used to assist with indexing and searching for
    /// appropriate structure definition instances.
    /// </summary>
    [FhirElement("useContext", Order = 31)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("useContext")]
    public List<UsageContext>? UseContext { get; set; }

    /// <summary>
    /// A legal or geographic region in which the structure definition is intended to be used.
    /// </summary>
    [FhirElement("jurisdiction", Order = 32)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("jurisdiction")]
    public List<CodeableConcept>? Jurisdiction { get; set; }

    /// <summary>
    /// Explanation of why this structure definition is needed and why it has been designed as it has.
    /// </summary>
    [FhirElement("purpose", Order = 33)]
    [Cardinality(0, 1)]
    [JsonPropertyName("purpose")]
    public FhirMarkdown? Purpose { get; set; }

    /// <summary>
    /// A copyright statement relating to the structure definition and/or its contents. Copyright statements
    /// are generally legal restrictions on the use and publishing of the structure definition. The short
    /// copyright declaration (e.g. (c) &apos;2015+ xyz organization&apos; should be sent in the
    /// copyrightLabel element.
    /// </summary>
    [FhirElement("copyright", Order = 34)]
    [Cardinality(0, 1)]
    [JsonPropertyName("copyright")]
    public FhirMarkdown? Copyright { get; set; }

    /// <summary>
    /// A short string (&lt;50 characters), suitable for inclusion in a page footer that identifies the
    /// copyright holder, effective period, and optionally whether rights are resctricted. (e.g. &apos;All
    /// rights reserved&apos;, &apos;Some rights reserved&apos;).
    /// </summary>
    [FhirElement("copyrightLabel", Order = 35)]
    [Cardinality(0, 1)]
    [JsonPropertyName("copyrightLabel")]
    public FhirString? CopyrightLabel { get; set; }

    /// <summary>
    /// (DEPRECATED) A set of key words or terms from external terminologies that may be used to assist with
    /// indexing and searching of templates nby describing the use of this structure definition, or the
    /// content it describes.
    /// </summary>
    [FhirElement("keyword", Order = 36)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("keyword")]
    public List<Coding>? Keyword { get; set; }

    /// <summary>
    /// The version of the FHIR specification on which this StructureDefinition is based - this is the
    /// formal version of the specification, without the revision number, e.g.
    /// [publication].[major].[minor], which is 4.6.0. for this version.
    /// </summary>
    [FhirElement("fhirVersion", Order = 37)]
    [Cardinality(0, 1)]
    [JsonPropertyName("fhirVersion")]
    public FhirCode? FhirVersion { get; set; }

    /// <summary>
    /// An external specification that the content is mapped to.
    /// </summary>
    [FhirElement("mapping", Order = 38)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("mapping")]
    public List<BackboneElement>? Mapping { get; set; }

    /// <summary>
    /// Defines the kind of structure that this definition is describing.
    /// </summary>
    [FhirElement("kind", Order = 39)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("kind")]
    public FhirCode Kind { get; set; }

    /// <summary>
    /// Whether structure this definition describes is abstract or not - that is, whether the structure is
    /// not intended to be instantiated. For Resources and Data types, abstract types will never be
    /// exchanged between systems.
    /// </summary>
    [FhirElement("abstract", Order = 40)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("abstract")]
    public FhirBoolean Abstract { get; set; }

    /// <summary>
    /// Identifies the types of resource or data type elements to which the extension can be applied. For
    /// more guidance on using the &apos;context&apos; element, see the [defining extensions
    /// page](defining-extensions.html#context).
    /// </summary>
    [FhirElement("context", Order = 41)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("context")]
    public List<BackboneElement>? Context { get; set; }

    /// <summary>
    /// A set of rules as FHIRPath Invariants about when the extension can be used (e.g. co-occurrence
    /// variants for the extension). All the rules must be true.
    /// </summary>
    [FhirElement("contextInvariant", Order = 42)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("contextInvariant")]
    public List<FhirString>? ContextInvariant { get; set; }

    /// <summary>
    /// The type this structure describes. If the derivation kind is &apos;specialization&apos; then this is
    /// the master definition for a type, and there is always one of these (a data type, an extension, a
    /// resource, including abstract ones). Otherwise the structure definition is a constraint on the stated
    /// type (and in this case, the type cannot be an abstract type). References are URLs that are relative
    /// to http://hl7.org/fhir/StructureDefinition e.g. &quot;string&quot; is a reference to
    /// http://hl7.org/fhir/StructureDefinition/string. Absolute URLs are only allowed in logical models,
    /// where they are required.
    /// </summary>
    [FhirElement("type", Order = 43)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("type")]
    public FhirUri Type { get; set; }

    /// <summary>
    /// An absolute URI that is the base structure from which this type is derived, either by specialization
    /// or constraint.
    /// </summary>
    [FhirElement("baseDefinition", Order = 44)]
    [Cardinality(0, 1)]
    [JsonPropertyName("baseDefinition")]
    public FhirCanonical? BaseDefinition { get; set; }

    /// <summary>
    /// How the type relates to the baseDefinition.
    /// </summary>
    [FhirElement("derivation", Order = 45)]
    [Cardinality(0, 1)]
    [JsonPropertyName("derivation")]
    public FhirCode? Derivation { get; set; }

    /// <summary>
    /// A snapshot view is expressed in a standalone form that can be used and interpreted without
    /// considering the base StructureDefinition.
    /// </summary>
    [FhirElement("snapshot", Order = 46)]
    [Cardinality(0, 1)]
    [JsonPropertyName("snapshot")]
    public BackboneElement Snapshot { get; set; }

    /// <summary>
    /// A differential view is expressed relative to the base StructureDefinition - a statement of
    /// differences that it applies.
    /// </summary>
    [FhirElement("differential", Order = 47)]
    [Cardinality(0, 1)]
    [JsonPropertyName("differential")]
    public BackboneElement Differential { get; set; }

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

    }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate StructureDefinition cardinality
        var structuredefinitionCount = StructureDefinition?.Count ?? 0;
        if (structuredefinitionCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition' cardinality must be 0..*", new[] { nameof(StructureDefinition) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Url == null)
        {
            yield return new ValidationResult("Element 'StructureDefinition.url' cardinality must be 1..1", new[] { nameof(Url) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        if (Name == null)
        {
            yield return new ValidationResult("Element 'StructureDefinition.name' cardinality must be 1..1", new[] { nameof(Name) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'StructureDefinition.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        // Validate Contact cardinality
        var contactCount = Contact?.Count ?? 0;
        if (contactCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.contact' cardinality must be 0..*", new[] { nameof(Contact) });
        }
        // Validate UseContext cardinality
        var usecontextCount = UseContext?.Count ?? 0;
        if (usecontextCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.useContext' cardinality must be 0..*", new[] { nameof(UseContext) });
        }
        // Validate Jurisdiction cardinality
        var jurisdictionCount = Jurisdiction?.Count ?? 0;
        if (jurisdictionCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.jurisdiction' cardinality must be 0..*", new[] { nameof(Jurisdiction) });
        }
        // Validate Keyword cardinality
        var keywordCount = Keyword?.Count ?? 0;
        if (keywordCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.keyword' cardinality must be 0..*", new[] { nameof(Keyword) });
        }
        // Validate Mapping cardinality
        var mappingCount = Mapping?.Count ?? 0;
        if (mappingCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.mapping' cardinality must be 0..*", new[] { nameof(Mapping) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.mapping.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.mapping.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Identity == null)
        {
            yield return new ValidationResult("Element 'StructureDefinition.mapping.identity' cardinality must be 1..1", new[] { nameof(Identity) });
        }
        if (Kind == null)
        {
            yield return new ValidationResult("Element 'StructureDefinition.kind' cardinality must be 1..1", new[] { nameof(Kind) });
        }
        if (Abstract == null)
        {
            yield return new ValidationResult("Element 'StructureDefinition.abstract' cardinality must be 1..1", new[] { nameof(Abstract) });
        }
        // Validate Context cardinality
        var contextCount = Context?.Count ?? 0;
        if (contextCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.context' cardinality must be 0..*", new[] { nameof(Context) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.context.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.context.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'StructureDefinition.context.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        if (Expression == null)
        {
            yield return new ValidationResult("Element 'StructureDefinition.context.expression' cardinality must be 1..1", new[] { nameof(Expression) });
        }
        // Validate ContextInvariant cardinality
        var contextinvariantCount = ContextInvariant?.Count ?? 0;
        if (contextinvariantCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.contextInvariant' cardinality must be 0..*", new[] { nameof(ContextInvariant) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'StructureDefinition.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.snapshot.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.snapshot.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Element cardinality
        var elementCount = Element?.Count ?? 0;
        if (elementCount < 1)
        {
            yield return new ValidationResult("Element 'StructureDefinition.snapshot.element' cardinality must be 1..*", new[] { nameof(Element) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.differential.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'StructureDefinition.differential.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Element cardinality
        var elementCount = Element?.Count ?? 0;
        if (elementCount < 1)
        {
            yield return new ValidationResult("Element 'StructureDefinition.differential.element' cardinality must be 1..*", new[] { nameof(Element) });
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
        // Validate Jurisdiction ValueSet binding
        if (Jurisdiction != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/jurisdiction
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Keyword ValueSet binding
        if (Keyword != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/definition-use
            // This requires a terminology service or local ValueSet cache
        }
        // Validate FhirVersion ValueSet binding
        if (FhirVersion != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/FHIR-version|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Kind ValueSet binding
        if (Kind != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/structure-definition-kind|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/extension-context-type|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/fhir-types
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Derivation ValueSet binding
        if (Derivation != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/type-derivation-rule|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: cnl-0
        // Expression: name.exists() implies name.matches('^[A-Z]([A-Za-z0-9_]){1,254}$')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("name.exists() implies name.matches('^[A-Z]([A-Za-z0-9_]){1,254}$')"))
        // {
        //     yield return new ValidationResult("Name should be usable as an identifier for the module by machine processing applications such as code generation", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-1
        // Expression: derivation = 'constraint' or snapshot.element.select(path).isDistinct()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("derivation = 'constraint' or snapshot.element.select(path).isDistinct()"))
        // {
        //     yield return new ValidationResult("Element paths must be unique unless the structure is a constraint", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-4
        // Expression: abstract = true or baseDefinition.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("abstract = true or baseDefinition.exists()"))
        // {
        //     yield return new ValidationResult("If the structure is not abstract, then there SHALL be a baseDefinition", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-5
        // Expression: type != 'Extension' or derivation = 'specialization' or (context.exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type != 'Extension' or derivation = 'specialization' or (context.exists())"))
        // {
        //     yield return new ValidationResult("If the structure defines an extension then the structure must have context information", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-6
        // Expression: snapshot.exists() or differential.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("snapshot.exists() or differential.exists()"))
        // {
        //     yield return new ValidationResult("A structure must have either a differential, or a snapshot (or both)", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-11
        // Expression: kind != 'logical' implies snapshot.empty() or snapshot.element.first().path = type
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("kind != 'logical' implies snapshot.empty() or snapshot.element.first().path = type"))
        // {
        //     yield return new ValidationResult("If there's a type, its content must match the path name in the first element of a snapshot", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-14
        // Expression: snapshot.element.all(id.exists()) and differential.element.all(id.exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("snapshot.element.all(id.exists()) and differential.element.all(id.exists())"))
        // {
        //     yield return new ValidationResult("All element definitions must have an id", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-15
        // Expression: kind!='logical'  implies snapshot.element.first().type.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("kind!='logical'  implies snapshot.element.first().type.empty()"))
        // {
        //     yield return new ValidationResult("The first element in a snapshot has no type unless model is a logical model.", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-15a
        // Expression: (kind!='logical'  and differential.element.first().path.contains('.').not()) implies differential.element.first().type.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(kind!='logical'  and differential.element.first().path.contains('.').not()) implies differential.element.first().type.empty()"))
        // {
        //     yield return new ValidationResult("If the first element in a differential has no "." in the path and it's not a logical model, it has no type", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-9
        // Expression: children().element.where(path.contains('.').not()).label.empty() and children().element.where(path.contains('.').not()).code.empty() and children().element.where(path.contains('.').not()).requirements.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("children().element.where(path.contains('.').not()).label.empty() and children().element.where(path.contains('.').not()).code.empty() and children().element.where(path.contains('.').not()).requirements.empty()"))
        // {
        //     yield return new ValidationResult("In any snapshot or differential, no label, code or requirements on an element without a "." in the path (e.g. the first element)", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-16
        // Expression: snapshot.element.all(id.exists()) and snapshot.element.id.trace('ids').isDistinct()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("snapshot.element.all(id.exists()) and snapshot.element.id.trace('ids').isDistinct()"))
        // {
        //     yield return new ValidationResult("All element definitions must have unique ids (snapshot)", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-17
        // Expression: differential.element.all(id.exists()) and differential.element.id.trace('ids').isDistinct()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("differential.element.all(id.exists()) and differential.element.id.trace('ids').isDistinct()"))
        // {
        //     yield return new ValidationResult("All element definitions must have unique ids (diff)", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-18
        // Expression: contextInvariant.exists() implies type = 'Extension'
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contextInvariant.exists() implies type = 'Extension'"))
        // {
        //     yield return new ValidationResult("Context Invariants can only be used for extensions", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-19
        // Expression: url.startsWith('http://hl7.org/fhir/StructureDefinition') implies (differential | snapshot).element.type.code.all(matches('^[a-zA-Z0-9]+$') or matches('^http:\\/\\/hl7\\.org\\/fhirpath\\/System\\.[A-Z][A-Za-z]+$'))
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("url.startsWith('http://hl7.org/fhir/StructureDefinition') implies (differential | snapshot).element.type.code.all(matches('^[a-zA-Z0-9]+$') or matches('^http:\\/\\/hl7\\.org\\/fhirpath\\/System\\.[A-Z][A-Za-z]+$'))"))
        // {
        //     yield return new ValidationResult("FHIR Specification models only use FHIR defined types", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-21
        // Expression: differential.element.defaultValue.exists() implies (derivation = 'specialization')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("differential.element.defaultValue.exists() implies (derivation = 'specialization')"))
        // {
        //     yield return new ValidationResult("Default values can only be specified on specializations", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-22
        // Expression: url.startsWith('http://hl7.org/fhir/StructureDefinition') implies (snapshot.element.defaultValue.empty() and differential.element.defaultValue.empty())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("url.startsWith('http://hl7.org/fhir/StructureDefinition') implies (snapshot.element.defaultValue.empty() and differential.element.defaultValue.empty())"))
        // {
        //     yield return new ValidationResult("FHIR Specification models never have default values", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-23
        // Expression: (snapshot | differential).element.all(path.contains('.').not() implies sliceName.empty())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(snapshot | differential).element.all(path.contains('.').not() implies sliceName.empty())"))
        // {
        //     yield return new ValidationResult("No slice name on root", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-27
        // Expression: baseDefinition.exists() implies derivation.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("baseDefinition.exists() implies derivation.exists()"))
        // {
        //     yield return new ValidationResult("If there's a base definition, there must be a derivation ", new[] { nameof(StructureDefinition) });
        // }
        // Constraint: sdf-29
        // Expression: ((kind in 'resource' | 'complex-type') and (derivation = 'specialization')) implies differential.element.where((min != 0 and min != 1) or (max != '1' and max != '*')).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("((kind in 'resource' | 'complex-type') and (derivation = 'specialization')) implies differential.element.where((min != 0 and min != 1) or (max != '1' and max != '*')).empty()"))
        // {
        //     yield return new ValidationResult("Elements in Resources must have a min cardinality or 0 or 1 and a max cardinality of 1 or *", new[] { nameof(StructureDefinition) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Keyword) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(FhirVersion) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Mapping) });
        // }
        // Constraint: sdf-2
        // Expression: name.exists() or uri.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("name.exists() or uri.exists()"))
        // {
        //     yield return new ValidationResult("Must have at least a name or a uri (or both)", new[] { nameof(Mapping) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Identity) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Uri) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Comment) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Kind) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Abstract) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Context) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Expression) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ContextInvariant) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BaseDefinition) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Derivation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Snapshot) });
        // }
        // Constraint: sdf-3
        // Expression: %resource.kind = 'logical' or element.all(definition.exists() and min.exists() and max.exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("%resource.kind = 'logical' or element.all(definition.exists() and min.exists() and max.exists())"))
        // {
        //     yield return new ValidationResult("Each element definition in a snapshot must have a formal definition and cardinalities, unless model is a logical model", new[] { nameof(Snapshot) });
        // }
        // Constraint: sdf-8
        // Expression: (%resource.kind = 'logical' or element.first().path = %resource.type) and element.tail().all(path.startsWith(%resource.snapshot.element.first().path&'.'))
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(%resource.kind = 'logical' or element.first().path = %resource.type) and element.tail().all(path.startsWith(%resource.snapshot.element.first().path&'.'))"))
        // {
        //     yield return new ValidationResult("All snapshot elements must start with the StructureDefinition's specified type for non-logical models, or with the same type name for logical models", new[] { nameof(Snapshot) });
        // }
        // Constraint: sdf-24
        // Expression: element.where(type.where(code='Reference').exists() and path.endsWith('.reference') and type.targetProfile.exists() and (path.substring(0,$this.path.length()-10) in %context.element.where(type.where(code='CodeableReference').exists()).path)).exists().not()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("element.where(type.where(code='Reference').exists() and path.endsWith('.reference') and type.targetProfile.exists() and (path.substring(0,$this.path.length()-10) in %context.element.where(type.where(code='CodeableReference').exists()).path)).exists().not()"))
        // {
        //     yield return new ValidationResult("For CodeableReference elements, target profiles must be listed on the CodeableReference, not the CodeableReference.reference", new[] { nameof(Snapshot) });
        // }
        // Constraint: sdf-25
        // Expression: element.where(type.where(code='CodeableConcept').exists() and path.endsWith('.concept') and binding.exists() and (path.substring(0,$this.path.length()-8) in %context.element.where(type.where(code='CodeableReference').exists()).path)).exists().not()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("element.where(type.where(code='CodeableConcept').exists() and path.endsWith('.concept') and binding.exists() and (path.substring(0,$this.path.length()-8) in %context.element.where(type.where(code='CodeableReference').exists()).path)).exists().not()"))
        // {
        //     yield return new ValidationResult("For CodeableReference elements, bindings must be listed on the CodeableReference, not the CodeableReference.concept", new[] { nameof(Snapshot) });
        // }
        // Constraint: sdf-26
        // Expression: $this.where(element[0].mustSupport='true').exists().not()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("$this.where(element[0].mustSupport='true').exists().not()"))
        // {
        //     yield return new ValidationResult("The root element of a profile should not have mustSupport = true", new[] { nameof(Snapshot) });
        // }
        // Constraint: sdf-8b
        // Expression: element.all(base.exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("element.all(base.exists())"))
        // {
        //     yield return new ValidationResult("All snapshot elements must have a base definition", new[] { nameof(Snapshot) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Element) });
        // }
        // Constraint: sdf-10
        // Expression: binding.empty() or binding.valueSet.exists() or binding.description.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("binding.empty() or binding.valueSet.exists() or binding.description.exists()"))
        // {
        //     yield return new ValidationResult("provide either a binding reference or a description (or both)", new[] { nameof(Element) });
        // }
        // Constraint: sdf-28
        // Expression: slicing.exists().not() or (slicing.discriminator.exists() or slicing.description.exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("slicing.exists().not() or (slicing.discriminator.exists() or slicing.description.exists())"))
        // {
        //     yield return new ValidationResult("If there are no discriminators, there must be a definition", new[] { nameof(Element) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Differential) });
        // }
        // Constraint: sdf-20
        // Expression: element.where(path.contains('.').not()).slicing.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("element.where(path.contains('.').not()).slicing.empty()"))
        // {
        //     yield return new ValidationResult("No slicing on the root element", new[] { nameof(Differential) });
        // }
        // Constraint: sdf-8a
        // Expression: (%resource.kind = 'logical' or element.first().path.startsWith(%resource.type)) and (element.tail().empty() or  element.tail().all(path.startsWith(%resource.differential.element.first().path.replaceMatches('\\..*','')&'.')))
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(%resource.kind = 'logical' or element.first().path.startsWith(%resource.type)) and (element.tail().empty() or  element.tail().all(path.startsWith(%resource.differential.element.first().path.replaceMatches('\\..*','')&'.')))"))
        // {
        //     yield return new ValidationResult("In any differential, all the elements must start with the StructureDefinition's specified type for non-logical models, or with the same type name for logical models", new[] { nameof(Differential) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Element) });
        // }
    }

}
