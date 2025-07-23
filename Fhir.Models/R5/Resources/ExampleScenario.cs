// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A walkthrough of a workflow showing the interaction between systems and the instances shared,
/// possibly including the evolution of instances over time.
/// </summary>
public class ExampleScenario : DomainResource
{
    public override string ResourceType => "ExampleScenario";

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
    /// An absolute URI that is used to identify this example scenario when it is referenced in a
    /// specification, model, design or an instance; also called its canonical identifier. This SHOULD be
    /// globally unique and SHOULD be a literal address at which an authoritative instance of this example
    /// scenario is (or will be) published. This URL can be the target of a canonical reference. It SHALL
    /// remain the same when the example scenario is stored on different servers.
    /// </summary>
    [FhirElement("url", Order = 18)]
    [Cardinality(0, 1)]
    [JsonPropertyName("url")]
    public FhirUri? Url { get; set; }

    /// <summary>
    /// A formal identifier that is used to identify this example scenario when it is represented in other
    /// formats, or referenced in a specification, model, design or an instance.
    /// </summary>
    [FhirElement("identifier", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The identifier that is used to identify this version of the example scenario when it is referenced
    /// in a specification, model, design or instance. This is an arbitrary value managed by the example
    /// scenario author and is not expected to be globally unique. For example, it might be a timestamp
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
    /// Temporarily retained for tooling purposes.
    /// </summary>
    [FhirElement("name", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("name")]
    public FhirString? Name { get; set; }

    /// <summary>
    /// A short, descriptive, user-friendly title for the ExampleScenario.
    /// </summary>
    [FhirElement("title", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("title")]
    public FhirString? Title { get; set; }

    /// <summary>
    /// The status of this example scenario. Enables tracking the life-cycle of the content.
    /// </summary>
    [FhirElement("status", Order = 25)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// A Boolean value to indicate that this example scenario is authored for testing purposes (or
    /// education/evaluation/marketing) and is not intended to be used for genuine usage.
    /// </summary>
    [FhirElement("experimental", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("experimental")]
    public FhirBoolean? Experimental { get; set; }

    /// <summary>
    /// The date (and optionally time) when the example scenario was last significantly changed. The date
    /// must change when the business version changes and it must change if the status code changes. In
    /// addition, it should change when the substantive content of the example scenario changes. (e.g. the
    /// &apos;content logical definition&apos;).
    /// </summary>
    [FhirElement("date", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("date")]
    public FhirDateTime? Date { get; set; }

    /// <summary>
    /// The name of the organization or individual responsible for the release and ongoing maintenance of
    /// the example scenario.
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
    /// A free text natural language description of the ExampleScenario from a consumer&apos;s perspective.
    /// </summary>
    [FhirElement("description", Order = 30)]
    [Cardinality(0, 1)]
    [JsonPropertyName("description")]
    public FhirMarkdown? Description { get; set; }

    /// <summary>
    /// The content was developed with a focus and intent of supporting the contexts that are listed. These
    /// contexts may be general categories (gender, age, ...) or may be references to specific programs
    /// (insurance plans, studies, ...) and may be used to assist with indexing and searching for
    /// appropriate example scenario instances.
    /// </summary>
    [FhirElement("useContext", Order = 31)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("useContext")]
    public List<UsageContext>? UseContext { get; set; }

    /// <summary>
    /// A legal or geographic region in which the example scenario is intended to be used.
    /// </summary>
    [FhirElement("jurisdiction", Order = 32)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("jurisdiction")]
    public List<CodeableConcept>? Jurisdiction { get; set; }

    /// <summary>
    /// What the example scenario resource is created for. This should not be used to show the business
    /// purpose of the scenario itself, but the purpose of documenting a scenario.
    /// </summary>
    [FhirElement("purpose", Order = 33)]
    [Cardinality(0, 1)]
    [JsonPropertyName("purpose")]
    public FhirMarkdown? Purpose { get; set; }

    /// <summary>
    /// A copyright statement relating to the example scenario and/or its contents. Copyright statements are
    /// generally legal restrictions on the use and publishing of the example scenario.
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
    /// A system or person who shares or receives an instance within the scenario.
    /// </summary>
    [FhirElement("actor", Order = 36)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("actor")]
    public List<BackboneElement>? Actor { get; set; }

    /// <summary>
    /// A single data collection that is shared as part of the scenario.
    /// </summary>
    [FhirElement("instance", Order = 37)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("instance")]
    public List<BackboneElement>? Instance { get; set; }

    /// <summary>
    /// A group of operations that represents a significant step within a scenario.
    /// </summary>
    [FhirElement("process", Order = 38)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("process")]
    public List<BackboneElement>? Process { get; set; }

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
        // Validate ExampleScenario cardinality
        var examplescenarioCount = ExampleScenario?.Count ?? 0;
        if (examplescenarioCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario' cardinality must be 0..*", new[] { nameof(ExampleScenario) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        // Validate Contact cardinality
        var contactCount = Contact?.Count ?? 0;
        if (contactCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.contact' cardinality must be 0..*", new[] { nameof(Contact) });
        }
        // Validate UseContext cardinality
        var usecontextCount = UseContext?.Count ?? 0;
        if (usecontextCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.useContext' cardinality must be 0..*", new[] { nameof(UseContext) });
        }
        // Validate Jurisdiction cardinality
        var jurisdictionCount = Jurisdiction?.Count ?? 0;
        if (jurisdictionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.jurisdiction' cardinality must be 0..*", new[] { nameof(Jurisdiction) });
        }
        // Validate Actor cardinality
        var actorCount = Actor?.Count ?? 0;
        if (actorCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.actor' cardinality must be 0..*", new[] { nameof(Actor) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.actor.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.actor.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Key == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.actor.key' cardinality must be 1..1", new[] { nameof(Key) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.actor.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        if (Title == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.actor.title' cardinality must be 1..1", new[] { nameof(Title) });
        }
        // Validate Instance cardinality
        var instanceCount = Instance?.Count ?? 0;
        if (instanceCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance' cardinality must be 0..*", new[] { nameof(Instance) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Key == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.key' cardinality must be 1..1", new[] { nameof(Key) });
        }
        if (StructureType == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.structureType' cardinality must be 1..1", new[] { nameof(StructureType) });
        }
        if (Title == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.title' cardinality must be 1..1", new[] { nameof(Title) });
        }
        // Validate Version cardinality
        var versionCount = Version?.Count ?? 0;
        if (versionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.version' cardinality must be 0..*", new[] { nameof(Version) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.version.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.version.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Key == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.version.key' cardinality must be 1..1", new[] { nameof(Key) });
        }
        if (Title == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.version.title' cardinality must be 1..1", new[] { nameof(Title) });
        }
        // Validate ContainedInstance cardinality
        var containedinstanceCount = ContainedInstance?.Count ?? 0;
        if (containedinstanceCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.containedInstance' cardinality must be 0..*", new[] { nameof(ContainedInstance) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.containedInstance.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.containedInstance.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (InstanceReference == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.instance.containedInstance.instanceReference' cardinality must be 1..1", new[] { nameof(InstanceReference) });
        }
        // Validate Process cardinality
        var processCount = Process?.Count ?? 0;
        if (processCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process' cardinality must be 0..*", new[] { nameof(Process) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Title == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.title' cardinality must be 1..1", new[] { nameof(Title) });
        }
        // Validate Step cardinality
        var stepCount = Step?.Count ?? 0;
        if (stepCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.step' cardinality must be 0..*", new[] { nameof(Step) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.step.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.step.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.step.operation.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.step.operation.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Title == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.step.operation.title' cardinality must be 1..1", new[] { nameof(Title) });
        }
        // Validate Alternative cardinality
        var alternativeCount = Alternative?.Count ?? 0;
        if (alternativeCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.step.alternative' cardinality must be 0..*", new[] { nameof(Alternative) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.step.alternative.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.step.alternative.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Title == null)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.step.alternative.title' cardinality must be 1..1", new[] { nameof(Title) });
        }
        // Validate Step cardinality
        var stepCount = Step?.Count ?? 0;
        if (stepCount < 0)
        {
            yield return new ValidationResult("Element 'ExampleScenario.process.step.alternative.step' cardinality must be 0..*", new[] { nameof(Step) });
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
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/examplescenario-actor-type|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate StructureType ValueSet binding
        if (StructureType != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/examplescenario-instance-type
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/testscript-operation-codes
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: cnl-0
        // Expression: name.exists() implies name.matches('^[A-Z]([A-Za-z0-9_]){1,254}$')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("name.exists() implies name.matches('^[A-Z]([A-Za-z0-9_]){1,254}$')"))
        // {
        //     yield return new ValidationResult("Name should be usable as an identifier for the module by machine processing applications such as code generation", new[] { nameof(ExampleScenario) });
        // }
        // Constraint: exs-3
        // Expression: status='active' or status='retired' implies actor.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("status='active' or status='retired' implies actor.exists()"))
        // {
        //     yield return new ValidationResult("Must have actors if status is active or required", new[] { nameof(ExampleScenario) });
        // }
        // Constraint: exs-4
        // Expression: status='active' or status='retired' implies process.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("status='active' or status='retired' implies process.exists()"))
        // {
        //     yield return new ValidationResult("Must have processes if status is active or required", new[] { nameof(ExampleScenario) });
        // }
        // Constraint: exs-6
        // Expression: actor.key.count() = actor.key.distinct().count()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("actor.key.count() = actor.key.distinct().count()"))
        // {
        //     yield return new ValidationResult("Actor keys must be unique", new[] { nameof(ExampleScenario) });
        // }
        // Constraint: exs-7
        // Expression: actor.title.count() = actor.title.distinct().count()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("actor.title.count() = actor.title.distinct().count()"))
        // {
        //     yield return new ValidationResult("Actor titles must be unique", new[] { nameof(ExampleScenario) });
        // }
        // Constraint: exs-8
        // Expression: instance.key.count() = instance.key.distinct().count()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("instance.key.count() = instance.key.distinct().count()"))
        // {
        //     yield return new ValidationResult("Instance keys must be unique", new[] { nameof(ExampleScenario) });
        // }
        // Constraint: exs-9
        // Expression: instance.title.count() = instance.title.distinct().count()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("instance.title.count() = instance.title.distinct().count()"))
        // {
        //     yield return new ValidationResult("Instance titles must be unique", new[] { nameof(ExampleScenario) });
        // }
        // Constraint: exs-12
        // Expression: process.title.count() = process.title.distinct().count()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("process.title.count() = process.title.distinct().count()"))
        // {
        //     yield return new ValidationResult("Process titles must be unique", new[] { nameof(ExampleScenario) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Actor) });
        // }
        // Constraint: exs-19
        // Expression: %resource.process.descendants().select(operation).where(initiator=%context.key or receiver=%context.key).exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("%resource.process.descendants().select(operation).where(initiator=%context.key or receiver=%context.key).exists()"))
        // {
        //     yield return new ValidationResult("Actor should be referenced in at least one operation", new[] { nameof(Actor) });
        // }
        // Constraint: exs-23
        // Expression: key != 'OTHER'
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("key != 'OTHER'"))
        // {
        //     yield return new ValidationResult("actor.key canot be 'OTHER'", new[] { nameof(Actor) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Key) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Instance) });
        // }
        // Constraint: exs-1
        // Expression: structureType.exists() and structureType.memberOf('http://hl7.org/fhir/ValueSet/resource-types').not() implies structureVersion.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("structureType.exists() and structureType.memberOf('http://hl7.org/fhir/ValueSet/resource-types').not() implies structureVersion.exists()"))
        // {
        //     yield return new ValidationResult("StructureVersion is required if structureType is not FHIR (but may still be present even if FHIR)", new[] { nameof(Instance) });
        // }
        // Constraint: exs-2
        // Expression: content.exists() implies version.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("content.exists() implies version.empty()"))
        // {
        //     yield return new ValidationResult("instance.content is only allowed if there are no instance.versions", new[] { nameof(Instance) });
        // }
        // Constraint: exs-10
        // Expression: version.key.count() = version.key.distinct().count()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("version.key.count() = version.key.distinct().count()"))
        // {
        //     yield return new ValidationResult("Version keys must be unique within an instance", new[] { nameof(Instance) });
        // }
        // Constraint: exs-11
        // Expression: version.title.count() = version.title.distinct().count()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("version.title.count() = version.title.distinct().count()"))
        // {
        //     yield return new ValidationResult("Version titles must be unique within an instance", new[] { nameof(Instance) });
        // }
        // Constraint: exs-20
        // Expression: %resource.process.descendants().select(instanceReference).where($this=%context.key).exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("%resource.process.descendants().select(instanceReference).where($this=%context.key).exists()"))
        // {
        //     yield return new ValidationResult("Instance should be referenced in at least one location", new[] { nameof(Instance) });
        // }
        // Constraint: exs-21
        // Expression: version.exists() implies version.key.intersect(%resource.process.descendants().where(instanceReference = %context.key).versionReference).exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("version.exists() implies version.key.intersect(%resource.process.descendants().where(instanceReference = %context.key).versionReference).exists()"))
        // {
        //     yield return new ValidationResult("Instance version should be referenced in at least one operation", new[] { nameof(Instance) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Key) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(StructureType) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(StructureVersion) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(StructureProfile) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Content) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Key) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Content) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ContainedInstance) });
        // }
        // Constraint: exs-14
        // Expression: %resource.instance.where(key=%context.instanceReference).exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("%resource.instance.where(key=%context.instanceReference).exists()"))
        // {
        //     yield return new ValidationResult("InstanceReference must be a key of an instance defined in the ExampleScenario", new[] { nameof(ContainedInstance) });
        // }
        // Constraint: exs-15
        // Expression: versionReference.empty() implies %resource.instance.where(key=%context.instanceReference).version.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("versionReference.empty() implies %resource.instance.where(key=%context.instanceReference).version.empty()"))
        // {
        //     yield return new ValidationResult("versionReference must be specified if the referenced instance defines versions", new[] { nameof(ContainedInstance) });
        // }
        // Constraint: exs-16
        // Expression: versionReference.exists() implies %resource.instance.where(key=%context.instanceReference).version.where(key=%context.versionReference).exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("versionReference.exists() implies %resource.instance.where(key=%context.instanceReference).version.where(key=%context.versionReference).exists()"))
        // {
        //     yield return new ValidationResult("versionReference must be a key of a version within the instance pointed to by instanceReference", new[] { nameof(ContainedInstance) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(InstanceReference) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(VersionReference) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Process) });
        // }
        // Constraint: exs-5
        // Expression: %resource.status='active' or %resource.status='retired' implies step.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("%resource.status='active' or %resource.status='retired' implies step.exists()"))
        // {
        //     yield return new ValidationResult("Processes must have steps if ExampleScenario status is active or required", new[] { nameof(Process) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PreConditions) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PostConditions) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Step) });
        // }
        // Constraint: exs-13
        // Expression: alternative.title.count() = alternative.title.distinct().count()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("alternative.title.count() = alternative.title.distinct().count()"))
        // {
        //     yield return new ValidationResult("Alternative titles must be unique within a step", new[] { nameof(Step) });
        // }
        // Constraint: exs-22
        // Expression: (process.exists() implies workflow.empty() and operation.empty()) and (workflow.exists() implies operation.empty())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(process.exists() implies workflow.empty() and operation.empty()) and (workflow.exists() implies operation.empty())"))
        // {
        //     yield return new ValidationResult("Can have a process, a workflow, one or more operations or none of these, but cannot have a combination", new[] { nameof(Step) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Number) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Process) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Workflow) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Operation) });
        // }
        // Constraint: exs-17
        // Expression: initiator.exists() implies initiator = 'OTHER' or %resource.actor.where(key=%context.initiator).exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("initiator.exists() implies initiator = 'OTHER' or %resource.actor.where(key=%context.initiator).exists()"))
        // {
        //     yield return new ValidationResult("If specified, initiator must be a key of an actor within the ExampleScenario", new[] { nameof(Operation) });
        // }
        // Constraint: exs-18
        // Expression: receiver.exists() implies receiver = 'OTHER' or %resource.actor.where(key=%context.receiver).exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("receiver.exists() implies receiver = 'OTHER' or %resource.actor.where(key=%context.receiver).exists()"))
        // {
        //     yield return new ValidationResult("If specified, receiver must be a key of an actor within the ExampleScenario", new[] { nameof(Operation) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Title) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Initiator) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Receiver) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(InitiatorActive) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ReceiverActive) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Request) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Response) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Alternative) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Step) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Pause) });
        // }
    }

}
