// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A TerminologyCapabilities resource documents a set of capabilities (behaviors) of a FHIR Terminology
/// Server that may be used as a statement of actual server functionality or a statement of required or
/// desired server implementation.
/// </summary>
public class TerminologyCapabilities : DomainResource
{
    public override string ResourceType => "TerminologyCapabilities";

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
    /// An absolute URI that is used to identify this terminology capabilities when it is referenced in a
    /// specification, model, design or an instance; also called its canonical identifier. This SHOULD be
    /// globally unique and SHOULD be a literal address at which an authoritative instance of this
    /// terminology capabilities is (or will be) published. This URL can be the target of a canonical
    /// reference. It SHALL remain the same when the terminology capabilities is stored on different
    /// servers.
    /// </summary>
    [FhirElement("url", Order = 18)]
    [Cardinality(0, 1)]
    [JsonPropertyName("url")]
    public FhirUri? Url { get; set; }

    /// <summary>
    /// A formal identifier that is used to identify this terminology capabilities when it is represented in
    /// other formats, or referenced in a specification, model, design or an instance.
    /// </summary>
    [FhirElement("identifier", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The identifier that is used to identify this version of the terminology capabilities when it is
    /// referenced in a specification, model, design or instance. This is an arbitrary value managed by the
    /// terminology capabilities author and is not expected to be globally unique. For example, it might be
    /// a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that
    /// versions can be placed in a lexicographical sequence.
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
    /// A natural language name identifying the terminology capabilities. This name should be usable as an
    /// identifier for the module by machine processing applications such as code generation.
    /// </summary>
    [FhirElement("name", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("name")]
    public FhirString? Name { get; set; }

    /// <summary>
    /// A short, descriptive, user-friendly title for the terminology capabilities.
    /// </summary>
    [FhirElement("title", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("title")]
    public FhirString? Title { get; set; }

    /// <summary>
    /// The status of this terminology capabilities. Enables tracking the life-cycle of the content.
    /// </summary>
    [FhirElement("status", Order = 25)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// A Boolean value to indicate that this terminology capabilities is authored for testing purposes (or
    /// education/evaluation/marketing) and is not intended to be used for genuine usage.
    /// </summary>
    [FhirElement("experimental", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("experimental")]
    public FhirBoolean? Experimental { get; set; }

    /// <summary>
    /// The date (and optionally time) when the terminology capabilities was last significantly changed. The
    /// date must change when the business version changes and it must change if the status code changes. In
    /// addition, it should change when the substantive content of the terminology capabilities changes.
    /// </summary>
    [FhirElement("date", Order = 27)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("date")]
    public FhirDateTime Date { get; set; }

    /// <summary>
    /// The name of the organization or individual responsible for the release and ongoing maintenance of
    /// the terminology capabilities.
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
    /// A free text natural language description of the terminology capabilities from a consumer&apos;s
    /// perspective. Typically, this is used when the capability statement describes a desired rather than
    /// an actual solution, for example as a formal expression of requirements as part of an RFP.
    /// </summary>
    [FhirElement("description", Order = 30)]
    [Cardinality(0, 1)]
    [JsonPropertyName("description")]
    public FhirMarkdown? Description { get; set; }

    /// <summary>
    /// The content was developed with a focus and intent of supporting the contexts that are listed. These
    /// contexts may be general categories (gender, age, ...) or may be references to specific programs
    /// (insurance plans, studies, ...) and may be used to assist with indexing and searching for
    /// appropriate terminology capabilities instances.
    /// </summary>
    [FhirElement("useContext", Order = 31)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("useContext")]
    public List<UsageContext>? UseContext { get; set; }

    /// <summary>
    /// A legal or geographic region in which the terminology capabilities is intended to be used.
    /// </summary>
    [FhirElement("jurisdiction", Order = 32)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("jurisdiction")]
    public List<CodeableConcept>? Jurisdiction { get; set; }

    /// <summary>
    /// Explanation of why this terminology capabilities is needed and why it has been designed as it has.
    /// </summary>
    [FhirElement("purpose", Order = 33)]
    [Cardinality(0, 1)]
    [JsonPropertyName("purpose")]
    public FhirMarkdown? Purpose { get; set; }

    /// <summary>
    /// A copyright statement relating to the terminology capabilities and/or its contents. Copyright
    /// statements are generally legal restrictions on the use and publishing of the terminology
    /// capabilities.
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
    /// The way that this statement is intended to be used, to describe an actual running instance of
    /// software, a particular product (kind, not instance of software) or a class of implementation (e.g. a
    /// desired purchase).
    /// </summary>
    [FhirElement("kind", Order = 36)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("kind")]
    public FhirCode Kind { get; set; }

    /// <summary>
    /// Software that is covered by this terminology capability statement. It is used when the statement
    /// describes the capabilities of a particular software version, independent of an installation.
    /// </summary>
    [FhirElement("software", Order = 37)]
    [Cardinality(0, 1)]
    [JsonPropertyName("software")]
    public BackboneElement Software { get; set; }

    /// <summary>
    /// Identifies a specific implementation instance that is described by the terminology capability
    /// statement - i.e. a particular installation, rather than the capabilities of a software program.
    /// </summary>
    [FhirElement("implementation", Order = 38)]
    [Cardinality(0, 1)]
    [JsonPropertyName("implementation")]
    public BackboneElement Implementation { get; set; }

    /// <summary>
    /// Whether the server supports lockedDate.
    /// </summary>
    [FhirElement("lockedDate", Order = 39)]
    [Cardinality(0, 1)]
    [JsonPropertyName("lockedDate")]
    public FhirBoolean? LockedDate { get; set; }

    /// <summary>
    /// Identifies a code system that is supported by the server. If there is a no code system URL, then
    /// this declares the general assumptions a client can make about support for any CodeSystem resource.
    /// </summary>
    [FhirElement("codeSystem", Order = 40)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("codeSystem")]
    public List<BackboneElement>? CodeSystem { get; set; }

    /// <summary>
    /// Information about the [ValueSet/$expand](valueset-operation-expand.html) operation.
    /// </summary>
    [FhirElement("expansion", Order = 41)]
    [Cardinality(0, 1)]
    [JsonPropertyName("expansion")]
    public BackboneElement Expansion { get; set; }

    /// <summary>
    /// The degree to which the server supports the code search parameter on ValueSet, if it is supported.
    /// </summary>
    [FhirElement("codeSearch", Order = 42)]
    [Cardinality(0, 1)]
    [JsonPropertyName("codeSearch")]
    public FhirCode? CodeSearch { get; set; }

    /// <summary>
    /// Information about the [ValueSet/$validate-code](valueset-operation-validate-code.html) operation.
    /// </summary>
    [FhirElement("validateCode", Order = 43)]
    [Cardinality(0, 1)]
    [JsonPropertyName("validateCode")]
    public BackboneElement ValidateCode { get; set; }

    /// <summary>
    /// Information about the [ConceptMap/$translate](conceptmap-operation-translate.html) operation.
    /// </summary>
    [FhirElement("translation", Order = 44)]
    [Cardinality(0, 1)]
    [JsonPropertyName("translation")]
    public BackboneElement Translation { get; set; }

    /// <summary>
    /// Whether the $closure operation is supported.
    /// </summary>
    [FhirElement("closure", Order = 45)]
    [Cardinality(0, 1)]
    [JsonPropertyName("closure")]
    public BackboneElement Closure { get; set; }

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
        // Validate TerminologyCapabilities cardinality
        var terminologycapabilitiesCount = TerminologyCapabilities?.Count ?? 0;
        if (terminologycapabilitiesCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities' cardinality must be 0..*", new[] { nameof(TerminologyCapabilities) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        if (Date == null)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.date' cardinality must be 1..1", new[] { nameof(Date) });
        }
        // Validate Contact cardinality
        var contactCount = Contact?.Count ?? 0;
        if (contactCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.contact' cardinality must be 0..*", new[] { nameof(Contact) });
        }
        // Validate UseContext cardinality
        var usecontextCount = UseContext?.Count ?? 0;
        if (usecontextCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.useContext' cardinality must be 0..*", new[] { nameof(UseContext) });
        }
        // Validate Jurisdiction cardinality
        var jurisdictionCount = Jurisdiction?.Count ?? 0;
        if (jurisdictionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.jurisdiction' cardinality must be 0..*", new[] { nameof(Jurisdiction) });
        }
        if (Kind == null)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.kind' cardinality must be 1..1", new[] { nameof(Kind) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.software.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.software.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Name == null)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.software.name' cardinality must be 1..1", new[] { nameof(Name) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.implementation.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.implementation.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Description == null)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.implementation.description' cardinality must be 1..1", new[] { nameof(Description) });
        }
        // Validate CodeSystem cardinality
        var codesystemCount = CodeSystem?.Count ?? 0;
        if (codesystemCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem' cardinality must be 0..*", new[] { nameof(CodeSystem) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Version cardinality
        var versionCount = Version?.Count ?? 0;
        if (versionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.version' cardinality must be 0..*", new[] { nameof(Version) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.version.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.version.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Language cardinality
        var languageCount = Language?.Count ?? 0;
        if (languageCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.version.language' cardinality must be 0..*", new[] { nameof(Language) });
        }
        // Validate Filter cardinality
        var filterCount = Filter?.Count ?? 0;
        if (filterCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.version.filter' cardinality must be 0..*", new[] { nameof(Filter) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.version.filter.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.version.filter.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Code == null)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.version.filter.code' cardinality must be 1..1", new[] { nameof(Code) });
        }
        // Validate Op cardinality
        var opCount = Op?.Count ?? 0;
        if (opCount < 1)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.version.filter.op' cardinality must be 1..*", new[] { nameof(Op) });
        }
        // Validate Property cardinality
        var propertyCount = Property?.Count ?? 0;
        if (propertyCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.version.property' cardinality must be 0..*", new[] { nameof(Property) });
        }
        if (Content == null)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.codeSystem.content' cardinality must be 1..1", new[] { nameof(Content) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.expansion.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.expansion.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Parameter cardinality
        var parameterCount = Parameter?.Count ?? 0;
        if (parameterCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.expansion.parameter' cardinality must be 0..*", new[] { nameof(Parameter) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.expansion.parameter.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.expansion.parameter.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Name == null)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.expansion.parameter.name' cardinality must be 1..1", new[] { nameof(Name) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.validateCode.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.validateCode.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Translations == null)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.validateCode.translations' cardinality must be 1..1", new[] { nameof(Translations) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.translation.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.translation.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (NeedsMap == null)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.translation.needsMap' cardinality must be 1..1", new[] { nameof(NeedsMap) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.closure.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'TerminologyCapabilities.closure.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
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
        // Validate Kind ValueSet binding
        if (Kind != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/capability-statement-kind|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Content ValueSet binding
        if (Content != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/codesystem-content-mode|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate CodeSearch ValueSet binding
        if (CodeSearch != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/code-search-support|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: cnl-0
        // Expression: name.exists() implies name.matches('^[A-Z]([A-Za-z0-9_]){1,254}$')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("name.exists() implies name.matches('^[A-Z]([A-Za-z0-9_]){1,254}$')"))
        // {
        //     yield return new ValidationResult("Name should be usable as an identifier for the module by machine processing applications such as code generation", new[] { nameof(TerminologyCapabilities) });
        // }
        // Constraint: tcp-2
        // Expression: (description.count() + software.count() + implementation.count()) > 0
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(description.count() + software.count() + implementation.count()) > 0"))
        // {
        //     yield return new ValidationResult("A Terminology Capability statement SHALL have at least one of description, software, or implementation element", new[] { nameof(TerminologyCapabilities) });
        // }
        // Constraint: tcp-3
        // Expression: (kind != 'instance') or implementation.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(kind != 'instance') or implementation.exists()"))
        // {
        //     yield return new ValidationResult("If kind = instance, implementation must be present and software may be present", new[] { nameof(TerminologyCapabilities) });
        // }
        // Constraint: tcp-4
        // Expression: (kind != 'capability') or (implementation.exists().not() and software.exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(kind != 'capability') or (implementation.exists().not() and software.exists())"))
        // {
        //     yield return new ValidationResult("If kind = capability, implementation must be absent, software must be present", new[] { nameof(TerminologyCapabilities) });
        // }
        // Constraint: tcp-5
        // Expression: (kind!='requirements') or (implementation.exists().not() and software.exists().not())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(kind!='requirements') or (implementation.exists().not() and software.exists().not())"))
        // {
        //     yield return new ValidationResult("If kind = requirements, implementation and software must be absent", new[] { nameof(TerminologyCapabilities) });
        // }
        // Constraint: tcp-6
        // Expression: codeSystem.uri.isDistinct()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("codeSystem.uri.isDistinct()"))
        // {
        //     yield return new ValidationResult("Each instance of the codeSystem element must represent a distinct code system.", new[] { nameof(TerminologyCapabilities) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Kind) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Software) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Name) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Implementation) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Description) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(LockedDate) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CodeSystem) });
        // }
        // Constraint: tcp-1
        // Expression: version.count() > 1 implies version.all(code.exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("version.count() > 1 implies version.all(code.exists())"))
        // {
        //     yield return new ValidationResult("If there is more than one version, a version code must be defined", new[] { nameof(CodeSystem) });
        // }
        // Constraint: tcp-7
        // Expression: version.code.isDistinct()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("version.code.isDistinct()"))
        // {
        //     yield return new ValidationResult("Each version.code element must be distinct for a particular code system.", new[] { nameof(CodeSystem) });
        // }
        // Constraint: tcp-8
        // Expression: version.where(isDefault = true).count() <= 1
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("version.where(isDefault = true).count() <= 1"))
        // {
        //     yield return new ValidationResult("A codeSystem element instance may have at most one version.isDefault element with a value of 'true'.", new[] { nameof(CodeSystem) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Uri) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(IsDefault) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Compositional) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Filter) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Op) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Property) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Subsumption) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Expansion) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Hierarchical) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Paging) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Incomplete) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Name) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Documentation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(TextFilter) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CodeSearch) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ValidateCode) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Translations) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Translation) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(NeedsMap) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Closure) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Translation) });
        // }
    }

}
