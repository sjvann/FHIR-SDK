// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A search parameter that defines a named search item that can be used to search/filter on a resource.
/// </summary>
public class SearchParameter : DomainResource
{
    public override string ResourceType => "SearchParameter";

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
    /// An absolute URI that is used to identify this search parameter when it is referenced in a
    /// specification, model, design or an instance; also called its canonical identifier. This SHOULD be
    /// globally unique and SHOULD be a literal address at which an authoritative instance of this search
    /// parameter is (or will be) published. This URL can be the target of a canonical reference. It SHALL
    /// remain the same when the search parameter is stored on different servers.
    /// </summary>
    [FhirElement("url", Order = 18)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("url")]
    public FhirUri Url { get; set; }

    /// <summary>
    /// A formal identifier that is used to identify this search parameter when it is represented in other
    /// formats, or referenced in a specification, model, design or an instance.
    /// </summary>
    [FhirElement("identifier", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The identifier that is used to identify this version of the search parameter when it is referenced
    /// in a specification, model, design or instance. This is an arbitrary value managed by the search
    /// parameter author and is not expected to be globally unique. For example, it might be a timestamp
    /// (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions
    /// can be placed in a lexicographical sequence.
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
    /// A natural language name identifying the search parameter. This name should be usable as an
    /// identifier for the module by machine processing applications such as code generation.
    /// </summary>
    [FhirElement("name", Order = 23)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("name")]
    public FhirString Name { get; set; }

    /// <summary>
    /// A short, descriptive, user-friendly title for the search parameter.
    /// </summary>
    [FhirElement("title", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("title")]
    public FhirString? Title { get; set; }

    /// <summary>
    /// Where this search parameter is originally defined. If a derivedFrom is provided, then the details in
    /// the search parameter must be consistent with the definition from which it is defined. i.e. the
    /// parameter should have the same meaning, and (usually) the functionality should be a proper subset of
    /// the underlying search parameter.
    /// </summary>
    [FhirElement("derivedFrom", Order = 25)]
    [Cardinality(0, 1)]
    [JsonPropertyName("derivedFrom")]
    public FhirCanonical? DerivedFrom { get; set; }

    /// <summary>
    /// The status of this search parameter. Enables tracking the life-cycle of the content.
    /// </summary>
    [FhirElement("status", Order = 26)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// A Boolean value to indicate that this search parameter is authored for testing purposes (or
    /// education/evaluation/marketing) and is not intended to be used for genuine usage.
    /// </summary>
    [FhirElement("experimental", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("experimental")]
    public FhirBoolean? Experimental { get; set; }

    /// <summary>
    /// The date (and optionally time) when the search parameter was last significantly changed. The date
    /// must change when the business version changes and it must change if the status code changes. In
    /// addition, it should change when the substantive content of the search parameter changes.
    /// </summary>
    [FhirElement("date", Order = 28)]
    [Cardinality(0, 1)]
    [JsonPropertyName("date")]
    public FhirDateTime? Date { get; set; }

    /// <summary>
    /// The name of the organization or individual tresponsible for the release and ongoing maintenance of
    /// the search parameter.
    /// </summary>
    [FhirElement("publisher", Order = 29)]
    [Cardinality(0, 1)]
    [JsonPropertyName("publisher")]
    public FhirString? Publisher { get; set; }

    /// <summary>
    /// Contact details to assist a user in finding and communicating with the publisher.
    /// </summary>
    [FhirElement("contact", Order = 30)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("contact")]
    public List<ContactDetail>? Contact { get; set; }

    /// <summary>
    /// And how it used.
    /// </summary>
    [FhirElement("description", Order = 31)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("description")]
    public FhirMarkdown Description { get; set; }

    /// <summary>
    /// The content was developed with a focus and intent of supporting the contexts that are listed. These
    /// contexts may be general categories (gender, age, ...) or may be references to specific programs
    /// (insurance plans, studies, ...) and may be used to assist with indexing and searching for
    /// appropriate search parameter instances.
    /// </summary>
    [FhirElement("useContext", Order = 32)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("useContext")]
    public List<UsageContext>? UseContext { get; set; }

    /// <summary>
    /// A legal or geographic region in which the search parameter is intended to be used.
    /// </summary>
    [FhirElement("jurisdiction", Order = 33)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("jurisdiction")]
    public List<CodeableConcept>? Jurisdiction { get; set; }

    /// <summary>
    /// Explanation of why this search parameter is needed and why it has been designed as it has.
    /// </summary>
    [FhirElement("purpose", Order = 34)]
    [Cardinality(0, 1)]
    [JsonPropertyName("purpose")]
    public FhirMarkdown? Purpose { get; set; }

    /// <summary>
    /// A copyright statement relating to the search parameter and/or its contents. Copyright statements are
    /// generally legal restrictions on the use and publishing of the search parameter.
    /// </summary>
    [FhirElement("copyright", Order = 35)]
    [Cardinality(0, 1)]
    [JsonPropertyName("copyright")]
    public FhirMarkdown? Copyright { get; set; }

    /// <summary>
    /// A short string (&lt;50 characters), suitable for inclusion in a page footer that identifies the
    /// copyright holder, effective period, and optionally whether rights are resctricted. (e.g. &apos;All
    /// rights reserved&apos;, &apos;Some rights reserved&apos;).
    /// </summary>
    [FhirElement("copyrightLabel", Order = 36)]
    [Cardinality(0, 1)]
    [JsonPropertyName("copyrightLabel")]
    public FhirString? CopyrightLabel { get; set; }

    /// <summary>
    /// The label that is recommended to be used in the URL or the parameter name in a parameters resource
    /// for this search parameter. In some cases, servers may need to use a different CapabilityStatement
    /// searchParam.name to differentiate between multiple SearchParameters that happen to have the same
    /// code.
    /// </summary>
    [FhirElement("code", Order = 37)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("code")]
    public FhirCode Code { get; set; }

    /// <summary>
    /// The base resource type(s) that this search parameter can be used against.
    /// </summary>
    [FhirElement("base", Order = 38)]
    [Cardinality(1, int.MaxValue)]
    [Required]
    [JsonPropertyName("base")]
    public List<FhirCode> Base { get; set; }

    /// <summary>
    /// The type of value that a search parameter may contain, and how the content is interpreted.
    /// </summary>
    [FhirElement("type", Order = 39)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("type")]
    public FhirCode Type { get; set; }

    /// <summary>
    /// A FHIRPath expression that returns a set of elements for the search parameter.
    /// </summary>
    [FhirElement("expression", Order = 40)]
    [Cardinality(0, 1)]
    [JsonPropertyName("expression")]
    public FhirString? Expression { get; set; }

    /// <summary>
    /// How the search parameter relates to the set of elements returned by evaluating the expression query.
    /// </summary>
    [FhirElement("processingMode", Order = 41)]
    [Cardinality(0, 1)]
    [JsonPropertyName("processingMode")]
    public FhirCode? ProcessingMode { get; set; }

    /// <summary>
    /// FHIRPath expression that defines/sets a complex constraint for when this SearchParameter is
    /// applicable.
    /// </summary>
    [FhirElement("constraint", Order = 42)]
    [Cardinality(0, 1)]
    [JsonPropertyName("constraint")]
    public FhirString? Constraint { get; set; }

    /// <summary>
    /// Types of resource (if a resource is referenced).
    /// </summary>
    [FhirElement("target", Order = 43)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("target")]
    public List<FhirCode>? Target { get; set; }

    /// <summary>
    /// Whether multiple values are allowed for each time the parameter exists. Values are separated by
    /// commas, and the parameter matches if any of the values match.
    /// </summary>
    [FhirElement("multipleOr", Order = 44)]
    [Cardinality(0, 1)]
    [JsonPropertyName("multipleOr")]
    public FhirBoolean? MultipleOr { get; set; }

    /// <summary>
    /// Whether multiple parameters are allowed - e.g. more than one parameter with the same name. The
    /// search matches if all the parameters match.
    /// </summary>
    [FhirElement("multipleAnd", Order = 45)]
    [Cardinality(0, 1)]
    [JsonPropertyName("multipleAnd")]
    public FhirBoolean? MultipleAnd { get; set; }

    /// <summary>
    /// Comparators supported for the search parameter.
    /// </summary>
    [FhirElement("comparator", Order = 46)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("comparator")]
    public List<FhirCode>? Comparator { get; set; }

    /// <summary>
    /// A modifier supported for the search parameter.
    /// </summary>
    [FhirElement("modifier", Order = 47)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("modifier")]
    public List<FhirCode>? Modifier { get; set; }

    /// <summary>
    /// Contains the names of any search parameters which may be chained to the containing search parameter.
    /// Chained parameters may be added to search parameters of type reference and specify that resources
    /// will only be returned if they contain a reference to a resource which matches the chained parameter
    /// value. Values for this field should be drawn from SearchParameter.code for a parameter on the target
    /// resource type.
    /// </summary>
    [FhirElement("chain", Order = 48)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("chain")]
    public List<FhirString>? Chain { get; set; }

    /// <summary>
    /// Used to define the parts of a composite search parameter.
    /// </summary>
    [FhirElement("component", Order = 49)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("component")]
    public List<BackboneElement>? Component { get; set; }

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
        // Validate SearchParameter cardinality
        var searchparameterCount = SearchParameter?.Count ?? 0;
        if (searchparameterCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter' cardinality must be 0..*", new[] { nameof(SearchParameter) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Url == null)
        {
            yield return new ValidationResult("Element 'SearchParameter.url' cardinality must be 1..1", new[] { nameof(Url) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        if (Name == null)
        {
            yield return new ValidationResult("Element 'SearchParameter.name' cardinality must be 1..1", new[] { nameof(Name) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'SearchParameter.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        // Validate Contact cardinality
        var contactCount = Contact?.Count ?? 0;
        if (contactCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.contact' cardinality must be 0..*", new[] { nameof(Contact) });
        }
        if (Description == null)
        {
            yield return new ValidationResult("Element 'SearchParameter.description' cardinality must be 1..1", new[] { nameof(Description) });
        }
        // Validate UseContext cardinality
        var usecontextCount = UseContext?.Count ?? 0;
        if (usecontextCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.useContext' cardinality must be 0..*", new[] { nameof(UseContext) });
        }
        // Validate Jurisdiction cardinality
        var jurisdictionCount = Jurisdiction?.Count ?? 0;
        if (jurisdictionCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.jurisdiction' cardinality must be 0..*", new[] { nameof(Jurisdiction) });
        }
        if (Code == null)
        {
            yield return new ValidationResult("Element 'SearchParameter.code' cardinality must be 1..1", new[] { nameof(Code) });
        }
        // Validate Base cardinality
        var baseCount = Base?.Count ?? 0;
        if (baseCount < 1)
        {
            yield return new ValidationResult("Element 'SearchParameter.base' cardinality must be 1..*", new[] { nameof(Base) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'SearchParameter.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        // Validate Target cardinality
        var targetCount = Target?.Count ?? 0;
        if (targetCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.target' cardinality must be 0..*", new[] { nameof(Target) });
        }
        // Validate Comparator cardinality
        var comparatorCount = Comparator?.Count ?? 0;
        if (comparatorCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.comparator' cardinality must be 0..*", new[] { nameof(Comparator) });
        }
        // Validate Modifier cardinality
        var modifierCount = Modifier?.Count ?? 0;
        if (modifierCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.modifier' cardinality must be 0..*", new[] { nameof(Modifier) });
        }
        // Validate Chain cardinality
        var chainCount = Chain?.Count ?? 0;
        if (chainCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.chain' cardinality must be 0..*", new[] { nameof(Chain) });
        }
        // Validate Component cardinality
        var componentCount = Component?.Count ?? 0;
        if (componentCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.component' cardinality must be 0..*", new[] { nameof(Component) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.component.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'SearchParameter.component.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Definition == null)
        {
            yield return new ValidationResult("Element 'SearchParameter.component.definition' cardinality must be 1..1", new[] { nameof(Definition) });
        }
        if (Expression == null)
        {
            yield return new ValidationResult("Element 'SearchParameter.component.expression' cardinality must be 1..1", new[] { nameof(Expression) });
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
        // Validate Base ValueSet binding
        if (Base != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/version-independent-all-resource-types|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/search-param-type|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate ProcessingMode ValueSet binding
        if (ProcessingMode != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/search-processingmode|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Target ValueSet binding
        if (Target != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/version-independent-all-resource-types|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Comparator ValueSet binding
        if (Comparator != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/search-comparator|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Modifier ValueSet binding
        if (Modifier != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/search-modifier-code|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: cnl-0
        // Expression: name.exists() implies name.matches('^[A-Z]([A-Za-z0-9_]){1,254}$')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("name.exists() implies name.matches('^[A-Z]([A-Za-z0-9_]){1,254}$')"))
        // {
        //     yield return new ValidationResult("Name should be usable as an identifier for the module by machine processing applications such as code generation", new[] { nameof(SearchParameter) });
        // }
        // Constraint: spd-1
        // Expression: expression.empty() or processingMode.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("expression.empty() or processingMode.exists()"))
        // {
        //     yield return new ValidationResult("If an expression is present, there SHALL be a processingMode", new[] { nameof(SearchParameter) });
        // }
        // Constraint: spd-2
        // Expression: chain.empty() or type = 'reference'
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("chain.empty() or type = 'reference'"))
        // {
        //     yield return new ValidationResult("Search parameters can only have chain names when the search parameter type is 'reference'", new[] { nameof(SearchParameter) });
        // }
        // Constraint: spd-3
        // Expression: comparator.empty() or (type in ('number' | 'date' | 'quantity' | 'special'))
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("comparator.empty() or (type in ('number' | 'date' | 'quantity' | 'special'))"))
        // {
        //     yield return new ValidationResult("Search parameters comparator can only be used on type 'number', 'date', 'quantity' or 'special'.", new[] { nameof(SearchParameter) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DerivedFrom) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Base) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ProcessingMode) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Constraint) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MultipleOr) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MultipleAnd) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Comparator) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Modifier) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Chain) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Definition) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Expression) });
        // }
    }

}
