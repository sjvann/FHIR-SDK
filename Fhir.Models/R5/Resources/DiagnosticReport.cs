// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// The findings and interpretation of diagnostic tests performed on patients, groups of patients,
/// products, substances, devices, and locations, and/or specimens derived from these. The report
/// includes clinical context such as requesting provider information, and some mix of atomic results,
/// images, textual and coded interpretations, and formatted representation of diagnostic reports. The
/// report also includes non-clinical context such as batch analysis and stability reporting of products
/// and substances.
/// </summary>
public class DiagnosticReport : DomainResource
{
    public override string ResourceType => "DiagnosticReport";

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
    /// Identifiers assigned to this report by the performer or other systems.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// Details concerning a service requested.
    /// </summary>
    [FhirElement("basedOn", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("basedOn")]
    public List<Reference<CarePlan>>? BasedOn { get; set; }

    /// <summary>
    /// The status of the diagnostic report.
    /// </summary>
    [FhirElement("status", Order = 20)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// A code that classifies the clinical discipline, department or diagnostic service that created the
    /// report (e.g. cardiology, biochemistry, hematology, MRI). This is used for searching, sorting and
    /// display purposes.
    /// </summary>
    [FhirElement("category", Order = 21)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// A code or name that describes this diagnostic report.
    /// </summary>
    [FhirElement("code", Order = 22)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; }

    /// <summary>
    /// The subject of the report. Usually, but not always, this is a patient. However, diagnostic services
    /// also perform analyses on specimens collected from a variety of other sources.
    /// </summary>
    [FhirElement("subject", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("subject")]
    public Reference<Patient> Subject { get; set; }

    /// <summary>
    /// The healthcare event (e.g. a patient and healthcare provider interaction) which this
    /// DiagnosticReport is about.
    /// </summary>
    [FhirElement("encounter", Order = 24)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// The time or time-period the observed values are related to. When the subject of the report is a
    /// patient, this is usually either the time of the procedure or of specimen collection(s), but very
    /// often the source of the date/time is not known, only the date/time itself. (as dateTime)
    /// </summary>
    [FhirElement("effectiveDateTime", Order = 25)]
    [Cardinality(0, 1)]
    [ChoiceType("effective", "dateTime")]
    [JsonPropertyName("effectiveDateTime")]
    public FhirDateTime? EffectiveDateTime { get; set; }

    /// <summary>
    /// The time or time-period the observed values are related to. When the subject of the report is a
    /// patient, this is usually either the time of the procedure or of specimen collection(s), but very
    /// often the source of the date/time is not known, only the date/time itself. (as Period)
    /// </summary>
    [FhirElement("effectivePeriod", Order = 26)]
    [Cardinality(0, 1)]
    [ChoiceType("effective", "period")]
    [JsonPropertyName("effectivePeriod")]
    public Period EffectivePeriod { get; set; }

    /// <summary>
    /// The date and time that this version of the report was made available to providers, typically after
    /// the report was reviewed and verified.
    /// </summary>
    [FhirElement("issued", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("issued")]
    public FhirInstant? Issued { get; set; }

    /// <summary>
    /// The diagnostic service that is responsible for issuing the report.
    /// </summary>
    [FhirElement("performer", Order = 28)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("performer")]
    public List<Reference<Practitioner>>? Performer { get; set; }

    /// <summary>
    /// The practitioner or organization that is responsible for the report&apos;s conclusions and
    /// interpretations.
    /// </summary>
    [FhirElement("resultsInterpreter", Order = 29)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("resultsInterpreter")]
    public List<Reference<Practitioner>>? ResultsInterpreter { get; set; }

    /// <summary>
    /// Details about the specimens on which this diagnostic report is based.
    /// </summary>
    [FhirElement("specimen", Order = 30)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("specimen")]
    public List<Reference<Specimen>>? Specimen { get; set; }

    /// <summary>
    /// [Observations](observation.html) that are part of this diagnostic report.
    /// </summary>
    [FhirElement("result", Order = 31)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("result")]
    public List<Reference<Observation>>? Result { get; set; }

    /// <summary>
    /// Comments about the diagnostic report.
    /// </summary>
    [FhirElement("note", Order = 32)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// One or more links to full details of any study performed during the diagnostic investigation. An
    /// ImagingStudy might comprise a set of radiologic images obtained via a procedure that are analyzed as
    /// a group. Typically, this is imaging performed by DICOM enabled modalities, but this is not required.
    /// A fully enabled PACS viewer can use this information to provide views of the source images. A
    /// GenomicStudy might comprise one or more analyses, each serving a specific purpose. These analyses
    /// may vary in method (e.g., karyotyping, CNV, or SNV detection), performer, software, devices used, or
    /// regions targeted.
    /// </summary>
    [FhirElement("study", Order = 33)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("study")]
    public List<Reference<GenomicStudy>>? Study { get; set; }

    /// <summary>
    /// This backbone element contains supporting information that was used in the creation of the report
    /// not included in the results already included in the report.
    /// </summary>
    [FhirElement("supportingInfo", Order = 34)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("supportingInfo")]
    public List<BackboneElement>? SupportingInfo { get; set; }

    /// <summary>
    /// A list of key images or data associated with this report. The images or data are generally created
    /// during the diagnostic process, and may be directly of the patient, or of treated specimens (i.e.
    /// slides of interest).
    /// </summary>
    [FhirElement("media", Order = 35)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("media")]
    public List<BackboneElement>? Media { get; set; }

    /// <summary>
    /// Reference to a Composition resource instance that provides structure for organizing the contents of
    /// the DiagnosticReport.
    /// </summary>
    [FhirElement("composition", Order = 36)]
    [Cardinality(0, 1)]
    [JsonPropertyName("composition")]
    public Reference<Composition> Composition { get; set; }

    /// <summary>
    /// Concise and clinically contextualized summary conclusion (interpretation/impression) of the
    /// diagnostic report.
    /// </summary>
    [FhirElement("conclusion", Order = 37)]
    [Cardinality(0, 1)]
    [JsonPropertyName("conclusion")]
    public FhirMarkdown? Conclusion { get; set; }

    /// <summary>
    /// One or more codes that represent the summary conclusion (interpretation/impression) of the
    /// diagnostic report.
    /// </summary>
    [FhirElement("conclusionCode", Order = 38)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("conclusionCode")]
    public List<CodeableConcept>? ConclusionCode { get; set; }

    /// <summary>
    /// Rich text representation of the entire result as issued by the diagnostic service. Multiple formats
    /// are allowed but they SHALL be semantically equivalent.
    /// </summary>
    [FhirElement("presentedForm", Order = 39)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("presentedForm")]
    public List<Attachment>? PresentedForm { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for effective[x]
        var effectiveProperties = new[] { nameof(EffectiveDateTime), nameof(EffectivePeriod) };
        var effectiveSetCount = effectiveProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (effectiveSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of EffectiveDateTime, EffectivePeriod may be specified",
                new[] { nameof(EffectiveDateTime), nameof(EffectivePeriod) });
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
        // Validate DiagnosticReport cardinality
        var diagnosticreportCount = DiagnosticReport?.Count ?? 0;
        if (diagnosticreportCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport' cardinality must be 0..*", new[] { nameof(DiagnosticReport) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate BasedOn cardinality
        var basedonCount = BasedOn?.Count ?? 0;
        if (basedonCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.basedOn' cardinality must be 0..*", new[] { nameof(BasedOn) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        // Validate Category cardinality
        var categoryCount = Category?.Count ?? 0;
        if (categoryCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.category' cardinality must be 0..*", new[] { nameof(Category) });
        }
        if (Code == null)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.code' cardinality must be 1..1", new[] { nameof(Code) });
        }
        // Validate Performer cardinality
        var performerCount = Performer?.Count ?? 0;
        if (performerCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.performer' cardinality must be 0..*", new[] { nameof(Performer) });
        }
        // Validate ResultsInterpreter cardinality
        var resultsinterpreterCount = ResultsInterpreter?.Count ?? 0;
        if (resultsinterpreterCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.resultsInterpreter' cardinality must be 0..*", new[] { nameof(ResultsInterpreter) });
        }
        // Validate Specimen cardinality
        var specimenCount = Specimen?.Count ?? 0;
        if (specimenCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.specimen' cardinality must be 0..*", new[] { nameof(Specimen) });
        }
        // Validate Result cardinality
        var resultCount = Result?.Count ?? 0;
        if (resultCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.result' cardinality must be 0..*", new[] { nameof(Result) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.note' cardinality must be 0..*", new[] { nameof(Note) });
        }
        // Validate Study cardinality
        var studyCount = Study?.Count ?? 0;
        if (studyCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.study' cardinality must be 0..*", new[] { nameof(Study) });
        }
        // Validate SupportingInfo cardinality
        var supportinginfoCount = SupportingInfo?.Count ?? 0;
        if (supportinginfoCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.supportingInfo' cardinality must be 0..*", new[] { nameof(SupportingInfo) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.supportingInfo.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.supportingInfo.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.supportingInfo.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        if (Reference == null)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.supportingInfo.reference' cardinality must be 1..1", new[] { nameof(Reference) });
        }
        // Validate Media cardinality
        var mediaCount = Media?.Count ?? 0;
        if (mediaCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.media' cardinality must be 0..*", new[] { nameof(Media) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.media.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.media.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Link == null)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.media.link' cardinality must be 1..1", new[] { nameof(Link) });
        }
        // Validate ConclusionCode cardinality
        var conclusioncodeCount = ConclusionCode?.Count ?? 0;
        if (conclusioncodeCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.conclusionCode' cardinality must be 0..*", new[] { nameof(ConclusionCode) });
        }
        // Validate PresentedForm cardinality
        var presentedformCount = PresentedForm?.Count ?? 0;
        if (presentedformCount < 0)
        {
            yield return new ValidationResult("Element 'DiagnosticReport.presentedForm' cardinality must be 0..*", new[] { nameof(PresentedForm) });
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
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/diagnostic-report-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dgr-1
        // Expression: composition.exists() implies (composition.resolve().section.entry.reference.where(resolve() is Observation) in (result.reference|result.reference.resolve().hasMember.reference))
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("composition.exists() implies (composition.resolve().section.entry.reference.where(resolve() is Observation) in (result.reference|result.reference.resolve().hasMember.reference))"))
        // {
        //     yield return new ValidationResult("When a Composition is referenced in `Diagnostic.composition`, all Observation resources referenced in `Composition.entry` must also be referenced in `Diagnostic.entry` or in the references Observations in `Observation.hasMember`", new[] { nameof(DiagnosticReport) });
        // }
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(DiagnosticReport) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(DiagnosticReport) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(DiagnosticReport) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(DiagnosticReport) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(DiagnosticReport) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BasedOn) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Category) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Effective) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Issued) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ResultsInterpreter) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Specimen) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Note) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Study) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SupportingInfo) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Reference) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Media) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Comment) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Link) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Composition) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Conclusion) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ConclusionCode) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PresentedForm) });
        // }
    }

}
