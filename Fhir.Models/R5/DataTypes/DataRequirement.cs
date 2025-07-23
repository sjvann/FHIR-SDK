// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// DataRequirement Type: Describes a required data item for evaluation in terms of the type of data,
/// and optional code or date-based filters of the data.
/// </summary>
public class DataRequirement : DataType
{
    /// <summary>
    /// Unique id for the element within a resource (for internal references). This may be any string value
    /// that does not contain spaces.
    /// </summary>
    [FhirElement("id", Order = 10)]
    [Cardinality(0, 1)]
    [JsonPropertyName("id")]
    public FhirString? Id { get; set; }

    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the
    /// element. To make the use of extensions safe and managable, there is a strict set of governance
    /// applied to the definition and use of extensions. Though any implementer can define an extension,
    /// there is a set of requirements that SHALL be met as part of the definition of the extension.
    /// </summary>
    [FhirElement("extension", Order = 11)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }

    /// <summary>
    /// The type of the required data, specified as the type name of a resource. For profiles, this value is
    /// set to the type of the base resource of the profile.
    /// </summary>
    [FhirElement("type", Order = 12)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("type")]
    public FhirCode Type { get; set; }

    /// <summary>
    /// The profile of the required data, specified as the uri of the profile definition.
    /// </summary>
    [FhirElement("profile", Order = 13)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("profile")]
    public List<FhirCanonical>? Profile { get; set; }

    /// <summary>
    /// The intended subjects of the data requirement. If this element is not provided, a Patient subject is
    /// assumed. (as CodeableConcept)
    /// </summary>
    [FhirElement("subjectCodeableConcept", Order = 14)]
    [Cardinality(0, 1)]
    [ChoiceType("subject", "codeableConcept")]
    [JsonPropertyName("subjectCodeableConcept")]
    public CodeableConcept SubjectCodeableConcept { get; set; }

    /// <summary>
    /// The intended subjects of the data requirement. If this element is not provided, a Patient subject is
    /// assumed. (as Reference)
    /// </summary>
    [FhirElement("subjectReference", Order = 15)]
    [Cardinality(0, 1)]
    [ChoiceType("subject", "reference")]
    [JsonPropertyName("subjectReference")]
    public Reference<Group> SubjectReference { get; set; }

    /// <summary>
    /// Indicates that specific elements of the type are referenced by the knowledge module and must be
    /// supported by the consumer in order to obtain an effective evaluation. This does not mean that a
    /// value is required for this element, only that the consuming system must understand the element and
    /// be able to provide values for it if they are available. The value of mustSupport SHALL be a FHIRPath
    /// resolvable on the type of the DataRequirement. The path SHALL consist only of identifiers, constant
    /// indexers, and .resolve() (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details).
    /// </summary>
    [FhirElement("mustSupport", Order = 16)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("mustSupport")]
    public List<FhirString>? MustSupport { get; set; }

    /// <summary>
    /// Code filters specify additional constraints on the data, specifying the value set of interest for a
    /// particular element of the data. Each code filter defines an additional constraint on the data, i.e.
    /// code filters are AND&apos;ed, not OR&apos;ed.
    /// </summary>
    [FhirElement("codeFilter", Order = 17)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("codeFilter")]
    public List<Element>? CodeFilter { get; set; }

    /// <summary>
    /// Date filters specify additional constraints on the data in terms of the applicable date range for
    /// specific elements. Each date filter specifies an additional constraint on the data, i.e. date
    /// filters are AND&apos;ed, not OR&apos;ed.
    /// </summary>
    [FhirElement("dateFilter", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("dateFilter")]
    public List<Element>? DateFilter { get; set; }

    /// <summary>
    /// Value filters specify additional constraints on the data for elements other than code-valued or
    /// date-valued. Each value filter specifies an additional constraint on the data (i.e. valueFilters are
    /// AND&apos;ed, not OR&apos;ed).
    /// </summary>
    [FhirElement("valueFilter", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("valueFilter")]
    public List<Element>? ValueFilter { get; set; }

    /// <summary>
    /// Specifies a maximum number of results that are required (uses the _count search parameter).
    /// </summary>
    [FhirElement("limit", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("limit")]
    public FhirPositiveInt? Limit { get; set; }

    /// <summary>
    /// Specifies the order of the results to be returned.
    /// </summary>
    [FhirElement("sort", Order = 21)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("sort")]
    public List<Element>? Sort { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

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
        // Validate DataRequirement cardinality
        var datarequirementCount = DataRequirement?.Count ?? 0;
        if (datarequirementCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement' cardinality must be 0..*", new[] { nameof(DataRequirement) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'DataRequirement.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        // Validate Profile cardinality
        var profileCount = Profile?.Count ?? 0;
        if (profileCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement.profile' cardinality must be 0..*", new[] { nameof(Profile) });
        }
        // Validate MustSupport cardinality
        var mustsupportCount = MustSupport?.Count ?? 0;
        if (mustsupportCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement.mustSupport' cardinality must be 0..*", new[] { nameof(MustSupport) });
        }
        // Validate CodeFilter cardinality
        var codefilterCount = CodeFilter?.Count ?? 0;
        if (codefilterCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement.codeFilter' cardinality must be 0..*", new[] { nameof(CodeFilter) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement.codeFilter.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate Code cardinality
        var codeCount = Code?.Count ?? 0;
        if (codeCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement.codeFilter.code' cardinality must be 0..*", new[] { nameof(Code) });
        }
        // Validate DateFilter cardinality
        var datefilterCount = DateFilter?.Count ?? 0;
        if (datefilterCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement.dateFilter' cardinality must be 0..*", new[] { nameof(DateFilter) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement.dateFilter.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ValueFilter cardinality
        var valuefilterCount = ValueFilter?.Count ?? 0;
        if (valuefilterCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement.valueFilter' cardinality must be 0..*", new[] { nameof(ValueFilter) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement.valueFilter.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate Sort cardinality
        var sortCount = Sort?.Count ?? 0;
        if (sortCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement.sort' cardinality must be 0..*", new[] { nameof(Sort) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'DataRequirement.sort.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Path == null)
        {
            yield return new ValidationResult("Element 'DataRequirement.sort.path' cardinality must be 1..1", new[] { nameof(Path) });
        }
        if (Direction == null)
        {
            yield return new ValidationResult("Element 'DataRequirement.sort.direction' cardinality must be 1..1", new[] { nameof(Direction) });
        }

        // ValueSet binding validation
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/fhir-types|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Subject ValueSet binding
        if (Subject != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/participant-resource-types
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Comparator ValueSet binding
        if (Comparator != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/value-filter-comparator|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Direction ValueSet binding
        if (Direction != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/sort-direction|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Profile) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MustSupport) });
        // }
        // Constraint: drq-1
        // Expression: path.exists() xor searchParam.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("path.exists() xor searchParam.exists()"))
        // {
        //     yield return new ValidationResult("Either a path or a searchParam must be provided, but not both", new[] { nameof(CodeFilter) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(CodeFilter) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Path) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SearchParam) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ValueSet) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
        // }
        // Constraint: drq-2
        // Expression: path.exists() xor searchParam.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("path.exists() xor searchParam.exists()"))
        // {
        //     yield return new ValidationResult("Either a path or a searchParam must be provided, but not both", new[] { nameof(DateFilter) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DateFilter) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Path) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SearchParam) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Value) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ValueFilter) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Path) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SearchParam) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Value) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Limit) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Sort) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Path) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Direction) });
        // }
    }

}
