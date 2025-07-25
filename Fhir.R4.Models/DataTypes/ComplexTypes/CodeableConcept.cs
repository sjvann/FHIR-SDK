using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A concept that may be defined by a formal reference to a terminology or ontology
/// or may be provided by text.
/// </summary>
/// <remarks>
/// FHIR R4 CodeableConcept DataType
/// A concept that may be defined by a formal reference to a terminology or ontology
/// or may be provided by text.
/// </remarks>
public class CodeableConcept : DataType
{
    /// <summary>
    /// Code defined by a terminology system.
    /// FHIR Path: CodeableConcept.coding
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("coding")]
    public List<Coding>? Coding { get; set; }
    
    /// <summary>
    /// Plain text representation of the concept.
    /// FHIR Path: CodeableConcept.text
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("text")]
    public FhirString? Text { get; set; }
    
    /// <summary>
    /// Validates the CodeableConcept according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // CodeableConcept 必須有 coding 或 text 其中之一
        if ((Coding == null || !Coding.Any()) && string.IsNullOrEmpty(Text))
        {
            yield return new ValidationResult("CodeableConcept must have either coding or text");
        }
        
        // 驗證 Coding
        if (Coding != null)
        {
            foreach (var coding in Coding)
            {
                var codingValidationContext = new ValidationContext(coding);
                foreach (var result in coding.Validate(codingValidationContext))
                {
                    yield return result;
                }
            }
        }
    }
}
