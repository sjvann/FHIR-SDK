using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.Resources;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// An identifier - identifies some entity uniquely and unambiguously.
/// Typically this is used for business identifiers.
/// </summary>
/// <remarks>
/// FHIR R4 Identifier DataType
/// An identifier - identifies some entity uniquely and unambiguously.
/// </remarks>
public class Identifier : ComplexType<Identifier>
{
    /// <summary>
    /// The purpose of this identifier.
    /// FHIR Path: Identifier.use
    /// Cardinality: 0..1
    /// Allowed values: usual, official, temp, secondary, old
    /// </summary>
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }
    
    /// <summary>
    /// Description of identifier.
    /// FHIR Path: Identifier.type
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("type")]
    public CodeableConcept? Type { get; set; }
    
    /// <summary>
    /// The namespace for the identifier value.
    /// FHIR Path: Identifier.system
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }
    
    /// <summary>
    /// The value that is unique.
    /// FHIR Path: Identifier.value
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("value")]
    public FhirString? Value { get; set; }
    
    /// <summary>
    /// Time period when id is/was valid for use.
    /// FHIR Path: Identifier.period
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }
    
    /// <summary>
    /// Organization that issued id (may be just text).
    /// FHIR Path: Identifier.assigner
    /// Cardinality: 0..1
    /// Reference to: Organization
    /// </summary>
    [JsonPropertyName("assigner")]
    public Reference<Organization>? Assigner { get; set; }

    /// <summary>
    /// Initializes a new instance of the Identifier class.
    /// </summary>
    public Identifier() { }

    /// <summary>
    /// Initializes a new instance of the Identifier class with system and value.
    /// </summary>
    /// <param name="system">The identifier system.</param>
    /// <param name="value">The identifier value.</param>
    public Identifier(string? system, string? value)
    {
        System = system != null ? new FhirUri(system) : null;
        Value = value != null ? new FhirString(value) : null;
    }

    /// <summary>
    /// Initializes a new instance of the Identifier class with system, value, and use.
    /// </summary>
    /// <param name="system">The identifier system.</param>
    /// <param name="value">The identifier value.</param>
    /// <param name="use">The identifier use.</param>
    public Identifier(string? system, string? value, string? use) : this(system, value)
    {
        Use = use != null ? new FhirCode(use) : null;
    }

    /// <summary>
    /// Creates an official identifier.
    /// </summary>
    /// <param name="system">The identifier system.</param>
    /// <param name="value">The identifier value.</param>
    /// <returns>A new Identifier instance.</returns>
    public static Identifier Official(string system, string value)
    {
        return new Identifier(system, value, "official");
    }

    /// <summary>
    /// Creates a usual identifier.
    /// </summary>
    /// <param name="system">The identifier system.</param>
    /// <param name="value">The identifier value.</param>
    /// <returns>A new Identifier instance.</returns>
    public static Identifier Usual(string system, string value)
    {
        return new Identifier(system, value, "usual");
    }

    /// <summary>
    /// Creates a temporary identifier.
    /// </summary>
    /// <param name="system">The identifier system.</param>
    /// <param name="value">The identifier value.</param>
    /// <returns>A new Identifier instance.</returns>
    public static Identifier Temporary(string system, string value)
    {
        return new Identifier(system, value, "temp");
    }

    /// <summary>
    /// Sets the type for this identifier.
    /// </summary>
    /// <param name="type">The identifier type.</param>
    /// <returns>This Identifier instance for method chaining.</returns>
    public Identifier WithType(CodeableConcept type)
    {
        Type = type;
        return this;
    }

    /// <summary>
    /// Sets the period for this identifier.
    /// </summary>
    /// <param name="start">The start date.</param>
    /// <param name="end">The end date.</param>
    /// <returns>This Identifier instance for method chaining.</returns>
    public Identifier WithPeriod(FhirDateTime? start, FhirDateTime? end)
    {
        Period = new Period(start, end);
        return this;
    }

    /// <summary>
    /// Validates the Identifier according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // Validate use value
        if (Use?.Value != null)
        {
            var validUses = new[] { "usual", "official", "temp", "secondary", "old" };
            if (!validUses.Contains(Use.Value))
            {
                yield return new ValidationResult(
                    $"Identifier.use '{Use.Value}' is not valid. Must be one of: {string.Join(", ", validUses)}",
                    new[] { nameof(Use) });
            }
        }
        
        // Validate system is a valid URI
        if (System?.Value != null && !Uri.IsWellFormedUriString(System.Value, UriKind.Absolute))
        {
            yield return new ValidationResult(
                $"Identifier.system '{System.Value}' must be a valid URI",
                new[] { nameof(System) });
        }
    }

    protected override string? GetComplexTypeString()
    {
        return $"Identifier: {System?.Value}|{Value?.Value}";
    }
}
