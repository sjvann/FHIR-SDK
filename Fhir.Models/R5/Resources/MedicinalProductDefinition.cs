// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Detailed definition of a medicinal product, typically for uses other than direct patient care (e.g.
/// regulatory use, drug catalogs, to support prescribing, adverse events management etc.).
/// </summary>
public class MedicinalProductDefinition : DomainResource
{
    public override string ResourceType => "MedicinalProductDefinition";

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
    /// Business identifier for this product. Could be an MPID. When in development or being regulated,
    /// products are typically referenced by official identifiers, assigned by a manufacturer or regulator,
    /// and unique to a product (which, when compared to a product instance being prescribed, is actually a
    /// product type). See also MedicinalProductDefinition.code.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// Regulatory type, e.g. Investigational or Authorized.
    /// </summary>
    [FhirElement("type", Order = 19)]
    [Cardinality(0, 1)]
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// If this medicine applies to human or veterinary uses.
    /// </summary>
    [FhirElement("domain", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("domain")]
    public CodeableConcept Domain { get; set; }

    /// <summary>
    /// A business identifier relating to a specific version of the product, this is commonly used to
    /// support revisions to an existing product.
    /// </summary>
    [FhirElement("version", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("version")]
    public FhirString? Version { get; set; }

    /// <summary>
    /// The status within the lifecycle of this product record. A high-level status, this is not intended to
    /// duplicate details carried elsewhere such as legal status, or authorization status.
    /// </summary>
    [FhirElement("status", Order = 22)]
    [Cardinality(0, 1)]
    [JsonPropertyName("status")]
    public CodeableConcept Status { get; set; }

    /// <summary>
    /// The date at which the given status became applicable.
    /// </summary>
    [FhirElement("statusDate", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("statusDate")]
    public FhirDateTime? StatusDate { get; set; }

    /// <summary>
    /// General description of this product.
    /// </summary>
    [FhirElement("description", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("description")]
    public FhirMarkdown? Description { get; set; }

    /// <summary>
    /// The dose form for a single part product, or combined form of a multiple part product. This is one
    /// concept that describes all the components. It does not represent the form with components physically
    /// mixed, if that might be necessary, for which see
    /// (AdministrableProductDefinition.administrableDoseForm).
    /// </summary>
    [FhirElement("combinedPharmaceuticalDoseForm", Order = 25)]
    [Cardinality(0, 1)]
    [JsonPropertyName("combinedPharmaceuticalDoseForm")]
    public CodeableConcept CombinedPharmaceuticalDoseForm { get; set; }

    /// <summary>
    /// The path by which the product is taken into or makes contact with the body. In some regions this is
    /// referred to as the licenced or approved route. See also AdministrableProductDefinition resource.
    /// MedicinalProductDefinition.route is the same concept as
    /// AdministrableProductDefinition.routeOfAdministration.code, and they cannot be used together.
    /// </summary>
    [FhirElement("route", Order = 26)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("route")]
    public List<CodeableConcept>? Route { get; set; }

    /// <summary>
    /// Description of indication(s) for this product, used when structured indications are not required. In
    /// cases where structured indications are required, they are captured using the ClinicalUseDefinition
    /// resource. An indication is a medical situation for which using the product is appropriate.
    /// </summary>
    [FhirElement("indication", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("indication")]
    public FhirMarkdown? Indication { get; set; }

    /// <summary>
    /// The legal status of supply of the medicinal product as classified by the regulator.
    /// </summary>
    [FhirElement("legalStatusOfSupply", Order = 28)]
    [Cardinality(0, 1)]
    [JsonPropertyName("legalStatusOfSupply")]
    public CodeableConcept LegalStatusOfSupply { get; set; }

    /// <summary>
    /// Whether the Medicinal Product is subject to additional monitoring for regulatory reasons, such as
    /// heightened reporting requirements.
    /// </summary>
    [FhirElement("additionalMonitoringIndicator", Order = 29)]
    [Cardinality(0, 1)]
    [JsonPropertyName("additionalMonitoringIndicator")]
    public CodeableConcept AdditionalMonitoringIndicator { get; set; }

    /// <summary>
    /// Whether the Medicinal Product is subject to special measures for regulatory reasons, such as a
    /// requirement to conduct post-authorization studies.
    /// </summary>
    [FhirElement("specialMeasures", Order = 30)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("specialMeasures")]
    public List<CodeableConcept>? SpecialMeasures { get; set; }

    /// <summary>
    /// If authorised for use in children, or infants, neonates etc.
    /// </summary>
    [FhirElement("pediatricUseIndicator", Order = 31)]
    [Cardinality(0, 1)]
    [JsonPropertyName("pediatricUseIndicator")]
    public CodeableConcept PediatricUseIndicator { get; set; }

    /// <summary>
    /// Allows the product to be classified by various systems, commonly WHO ATC.
    /// </summary>
    [FhirElement("classification", Order = 32)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("classification")]
    public List<CodeableConcept>? Classification { get; set; }

    /// <summary>
    /// Marketing status of the medicinal product, in contrast to marketing authorization. This refers to
    /// the product being actually &apos;on the market&apos; as opposed to being allowed to be on the market
    /// (which is an authorization).
    /// </summary>
    [FhirElement("marketingStatus", Order = 33)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("marketingStatus")]
    public List<MarketingStatus>? MarketingStatus { get; set; }

    /// <summary>
    /// Package type for the product. See also the PackagedProductDefinition resource.
    /// </summary>
    [FhirElement("packagedMedicinalProduct", Order = 34)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("packagedMedicinalProduct")]
    public List<CodeableConcept>? PackagedMedicinalProduct { get; set; }

    /// <summary>
    /// Types of medicinal manufactured items and/or devices that this product consists of, such as tablets,
    /// capsule, or syringes. Used as a direct link when the item&apos;s packaging is not being recorded
    /// (see also PackagedProductDefinition.package.containedItem.item).
    /// </summary>
    [FhirElement("comprisedOf", Order = 35)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("comprisedOf")]
    public List<Reference<ManufacturedItemDefinition>>? ComprisedOf { get; set; }

    /// <summary>
    /// The ingredients of this medicinal product - when not detailed in other resources. This is only
    /// needed if the ingredients are not specified by incoming references from the Ingredient resource, or
    /// indirectly via incoming AdministrableProductDefinition, PackagedProductDefinition or
    /// ManufacturedItemDefinition references. In cases where those levels of detail are not used, the
    /// ingredients may be specified directly here as codes.
    /// </summary>
    [FhirElement("ingredient", Order = 36)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("ingredient")]
    public List<CodeableConcept>? Ingredient { get; set; }

    /// <summary>
    /// Any component of the drug product which is not the chemical entity defined as the drug substance, or
    /// an excipient in the drug product. This includes process-related impurities and contaminants,
    /// product-related impurities including degradation products.
    /// </summary>
    [FhirElement("impurity", Order = 37)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("impurity")]
    public List<CodeableReference>? Impurity { get; set; }

    /// <summary>
    /// Additional information or supporting documentation about the medicinal product.
    /// </summary>
    [FhirElement("attachedDocument", Order = 38)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("attachedDocument")]
    public List<Reference<DocumentReference>>? AttachedDocument { get; set; }

    /// <summary>
    /// A master file for the medicinal product (e.g. Pharmacovigilance System Master File). Drug master
    /// files (DMFs) are documents submitted to regulatory agencies to provide confidential detailed
    /// information about facilities, processes or articles used in the manufacturing, processing, packaging
    /// and storing of drug products.
    /// </summary>
    [FhirElement("masterFile", Order = 39)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("masterFile")]
    public List<Reference<DocumentReference>>? MasterFile { get; set; }

    /// <summary>
    /// A product specific contact, person (in a role), or an organization.
    /// </summary>
    [FhirElement("contact", Order = 40)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("contact")]
    public List<BackboneElement>? Contact { get; set; }

    /// <summary>
    /// Clinical trials or studies that this product is involved in.
    /// </summary>
    [FhirElement("clinicalTrial", Order = 41)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("clinicalTrial")]
    public List<Reference<ResearchStudy>>? ClinicalTrial { get; set; }

    /// <summary>
    /// A code that this product is known by, usually within some formal terminology, perhaps assigned by a
    /// third party (i.e. not the manufacturer or regulator). Products (types of medications) tend to be
    /// known by identifiers during development and within regulatory process. However when they are
    /// prescribed they tend to be identified by codes. The same product may be have multiple codes, applied
    /// to it by multiple organizations.
    /// </summary>
    [FhirElement("code", Order = 42)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("code")]
    public List<Coding>? Code { get; set; }

    /// <summary>
    /// The product&apos;s name, including full name and possibly coded parts.
    /// </summary>
    [FhirElement("name", Order = 43)]
    [Cardinality(1, int.MaxValue)]
    [Required]
    [JsonPropertyName("name")]
    public List<BackboneElement> Name { get; set; }

    /// <summary>
    /// Reference to another product, e.g. for linking authorised to investigational product, or a virtual
    /// product.
    /// </summary>
    [FhirElement("crossReference", Order = 44)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("crossReference")]
    public List<BackboneElement>? CrossReference { get; set; }

    /// <summary>
    /// A manufacturing or administrative process or step associated with (or performed on) the medicinal
    /// product.
    /// </summary>
    [FhirElement("operation", Order = 45)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("operation")]
    public List<BackboneElement>? Operation { get; set; }

    /// <summary>
    /// Allows the key product features to be recorded, such as &quot;sugar free&quot;, &quot;modified
    /// release&quot;, &quot;parallel import&quot;.
    /// </summary>
    [FhirElement("characteristic", Order = 46)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("characteristic")]
    public List<BackboneElement>? Characteristic { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate MedicinalProductDefinition cardinality
        var medicinalproductdefinitionCount = MedicinalProductDefinition?.Count ?? 0;
        if (medicinalproductdefinitionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition' cardinality must be 0..*", new[] { nameof(MedicinalProductDefinition) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate Route cardinality
        var routeCount = Route?.Count ?? 0;
        if (routeCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.route' cardinality must be 0..*", new[] { nameof(Route) });
        }
        // Validate SpecialMeasures cardinality
        var specialmeasuresCount = SpecialMeasures?.Count ?? 0;
        if (specialmeasuresCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.specialMeasures' cardinality must be 0..*", new[] { nameof(SpecialMeasures) });
        }
        // Validate Classification cardinality
        var classificationCount = Classification?.Count ?? 0;
        if (classificationCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.classification' cardinality must be 0..*", new[] { nameof(Classification) });
        }
        // Validate MarketingStatus cardinality
        var marketingstatusCount = MarketingStatus?.Count ?? 0;
        if (marketingstatusCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.marketingStatus' cardinality must be 0..*", new[] { nameof(MarketingStatus) });
        }
        // Validate PackagedMedicinalProduct cardinality
        var packagedmedicinalproductCount = PackagedMedicinalProduct?.Count ?? 0;
        if (packagedmedicinalproductCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.packagedMedicinalProduct' cardinality must be 0..*", new[] { nameof(PackagedMedicinalProduct) });
        }
        // Validate ComprisedOf cardinality
        var comprisedofCount = ComprisedOf?.Count ?? 0;
        if (comprisedofCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.comprisedOf' cardinality must be 0..*", new[] { nameof(ComprisedOf) });
        }
        // Validate Ingredient cardinality
        var ingredientCount = Ingredient?.Count ?? 0;
        if (ingredientCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.ingredient' cardinality must be 0..*", new[] { nameof(Ingredient) });
        }
        // Validate Impurity cardinality
        var impurityCount = Impurity?.Count ?? 0;
        if (impurityCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.impurity' cardinality must be 0..*", new[] { nameof(Impurity) });
        }
        // Validate AttachedDocument cardinality
        var attacheddocumentCount = AttachedDocument?.Count ?? 0;
        if (attacheddocumentCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.attachedDocument' cardinality must be 0..*", new[] { nameof(AttachedDocument) });
        }
        // Validate MasterFile cardinality
        var masterfileCount = MasterFile?.Count ?? 0;
        if (masterfileCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.masterFile' cardinality must be 0..*", new[] { nameof(MasterFile) });
        }
        // Validate Contact cardinality
        var contactCount = Contact?.Count ?? 0;
        if (contactCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.contact' cardinality must be 0..*", new[] { nameof(Contact) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.contact.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.contact.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Contact == null)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.contact.contact' cardinality must be 1..1", new[] { nameof(Contact) });
        }
        // Validate ClinicalTrial cardinality
        var clinicaltrialCount = ClinicalTrial?.Count ?? 0;
        if (clinicaltrialCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.clinicalTrial' cardinality must be 0..*", new[] { nameof(ClinicalTrial) });
        }
        // Validate Code cardinality
        var codeCount = Code?.Count ?? 0;
        if (codeCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.code' cardinality must be 0..*", new[] { nameof(Code) });
        }
        // Validate Name cardinality
        var nameCount = Name?.Count ?? 0;
        if (nameCount < 1)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name' cardinality must be 1..*", new[] { nameof(Name) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (ProductName == null)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.productName' cardinality must be 1..1", new[] { nameof(ProductName) });
        }
        // Validate Part cardinality
        var partCount = Part?.Count ?? 0;
        if (partCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.part' cardinality must be 0..*", new[] { nameof(Part) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.part.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.part.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Part == null)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.part.part' cardinality must be 1..1", new[] { nameof(Part) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.part.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        // Validate Usage cardinality
        var usageCount = Usage?.Count ?? 0;
        if (usageCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.usage' cardinality must be 0..*", new[] { nameof(Usage) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.usage.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.usage.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Country == null)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.usage.country' cardinality must be 1..1", new[] { nameof(Country) });
        }
        if (Language == null)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.name.usage.language' cardinality must be 1..1", new[] { nameof(Language) });
        }
        // Validate CrossReference cardinality
        var crossreferenceCount = CrossReference?.Count ?? 0;
        if (crossreferenceCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.crossReference' cardinality must be 0..*", new[] { nameof(CrossReference) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.crossReference.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.crossReference.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Product == null)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.crossReference.product' cardinality must be 1..1", new[] { nameof(Product) });
        }
        // Validate Operation cardinality
        var operationCount = Operation?.Count ?? 0;
        if (operationCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.operation' cardinality must be 0..*", new[] { nameof(Operation) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.operation.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.operation.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Organization cardinality
        var organizationCount = Organization?.Count ?? 0;
        if (organizationCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.operation.organization' cardinality must be 0..*", new[] { nameof(Organization) });
        }
        // Validate Characteristic cardinality
        var characteristicCount = Characteristic?.Count ?? 0;
        if (characteristicCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.characteristic' cardinality must be 0..*", new[] { nameof(Characteristic) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.characteristic.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.characteristic.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'MedicinalProductDefinition.characteristic.type' cardinality must be 1..1", new[] { nameof(Type) });
        }

        // ValueSet binding validation
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(MedicinalProductDefinition) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(MedicinalProductDefinition) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(MedicinalProductDefinition) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(MedicinalProductDefinition) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(MedicinalProductDefinition) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Domain) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Status) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(StatusDate) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CombinedPharmaceuticalDoseForm) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Route) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Indication) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(LegalStatusOfSupply) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(AdditionalMonitoringIndicator) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SpecialMeasures) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PediatricUseIndicator) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Classification) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MarketingStatus) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PackagedMedicinalProduct) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ComprisedOf) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Ingredient) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Impurity) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(AttachedDocument) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MasterFile) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Contact) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ClinicalTrial) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Name) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ProductName) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Part) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Part) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Usage) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Country) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Language) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CrossReference) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Product) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Operation) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(EffectiveDate) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Organization) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ConfidentialityIndicator) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Characteristic) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Value) });
        // }
    }

}
