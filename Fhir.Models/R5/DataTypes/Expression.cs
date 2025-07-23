// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Expression Type: A expression that is evaluated in a specified context and returns a value. The
/// context of use of the expression must specify the context in which the expression is evaluated, and
/// how the result of the expression is used.
/// </summary>
public class Expression : DataType
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
    /// A brief, natural language description of the condition that effectively communicates the intended
    /// semantics.
    /// </summary>
    [FhirElement("description", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("description")]
    public FhirString? Description { get; set; }

    /// <summary>
    /// A short name assigned to the expression to allow for multiple reuse of the expression in the context
    /// where it is defined.
    /// </summary>
    [FhirElement("name", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("name")]
    public FhirCode? Name { get; set; }

    /// <summary>
    /// The media type of the language for the expression.
    /// </summary>
    [FhirElement("language", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("language")]
    public FhirCode? Language { get; set; }

    /// <summary>
    /// An expression in the specified language that returns a value.
    /// </summary>
    [FhirElement("expression", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("expression")]
    public FhirString? Expression { get; set; }

    /// <summary>
    /// A URI that defines where the expression is found.
    /// </summary>
    [FhirElement("reference", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("reference")]
    public FhirUri? Reference { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Expression cardinality
        var expressionCount = Expression?.Count ?? 0;
        if (expressionCount < 0)
        {
            yield return new ValidationResult("Element 'Expression' cardinality must be 0..*", new[] { nameof(Expression) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Expression.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }

        // ValueSet binding validation
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/expression-language
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Expression) });
        // }
        // Constraint: exp-1
        // Expression: expression.exists() or reference.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("expression.exists() or reference.exists()"))
        // {
        //     yield return new ValidationResult("An expression or a reference must be provided", new[] { nameof(Expression) });
        // }
        // Constraint: exp-2
        // Expression: name.hasValue() implies name.matches('[A-Za-z][A-Za-z0-9\\_]{0,63}')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("name.hasValue() implies name.matches('[A-Za-z][A-Za-z0-9\\_]{0,63}')"))
        // {
        //     yield return new ValidationResult("The name must be a valid variable name in most computer languages", new[] { nameof(Expression) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Description) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Language) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Reference) });
        // }
    }

}
