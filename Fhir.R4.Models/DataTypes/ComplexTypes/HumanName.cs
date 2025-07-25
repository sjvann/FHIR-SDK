using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A human's name with the ability to identify parts and usage.
/// </summary>
/// <remarks>
/// FHIR R4 HumanName DataType
/// A human's name with the ability to identify parts and usage.
/// </remarks>
public class HumanName : ComplexType<HumanName>
{
    /// <summary>
    /// Identifies the purpose for this name.
    /// FHIR Path: HumanName.use
    /// Cardinality: 0..1
    /// Allowed values: usual, official, temp, nickname, anonymous, old, maiden
    /// </summary>
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }
    
    /// <summary>
    /// Text representation of the full name.
    /// FHIR Path: HumanName.text
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("text")]
    public FhirString? Text { get; set; }
    
    /// <summary>
    /// Family name (often called 'Surname').
    /// FHIR Path: HumanName.family
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("family")]
    public FhirString? Family { get; set; }
    
    /// <summary>
    /// Given names (not always 'first'). Includes middle names.
    /// FHIR Path: HumanName.given
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("given")]
    public List<FhirString>? Given { get; set; }
    
    /// <summary>
    /// Parts that come before the name.
    /// FHIR Path: HumanName.prefix
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("prefix")]
    public List<FhirString>? Prefix { get; set; }
    
    /// <summary>
    /// Parts that come after the name.
    /// FHIR Path: HumanName.suffix
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("suffix")]
    public List<FhirString>? Suffix { get; set; }
    
    /// <summary>
    /// Time period when name was/is in use.
    /// FHIR Path: HumanName.period
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    /// <summary>
    /// Initializes a new instance of the HumanName class.
    /// </summary>
    public HumanName() { }

    /// <summary>
    /// Initializes a new instance of the HumanName class with family and given names.
    /// </summary>
    /// <param name="family">The family name.</param>
    /// <param name="given">The given names.</param>
    public HumanName(string? family, params string[] given)
    {
        Family = family != null ? new FhirString(family) : null;
        Given = given?.Select(g => new FhirString(g)).ToList();
    }

    /// <summary>
    /// Creates a HumanName with the specified use.
    /// </summary>
    /// <param name="use">The name use.</param>
    /// <param name="family">The family name.</param>
    /// <param name="given">The given names.</param>
    /// <returns>A new HumanName instance.</returns>
    public static HumanName Create(string use, string? family, params string[] given)
    {
        return new HumanName(family, given)
        {
            Use = new FhirCode(use)
        };
    }

    /// <summary>
    /// Creates an official name.
    /// </summary>
    /// <param name="family">The family name.</param>
    /// <param name="given">The given names.</param>
    /// <returns>A new HumanName instance.</returns>
    public static HumanName Official(string? family, params string[] given)
    {
        return Create("official", family, given);
    }

    /// <summary>
    /// Creates a usual name.
    /// </summary>
    /// <param name="family">The family name.</param>
    /// <param name="given">The given names.</param>
    /// <returns>A new HumanName instance.</returns>
    public static HumanName Usual(string? family, params string[] given)
    {
        return Create("usual", family, given);
    }

    /// <summary>
    /// Gets the full name as a single string.
    /// </summary>
    /// <returns>The full name.</returns>
    public string GetFullName()
    {
        var parts = new List<string>();
        
        if (Prefix?.Any() == true)
            parts.AddRange(Prefix.Select(p => p.Value).Where(p => !string.IsNullOrEmpty(p))!);
        
        if (Given?.Any() == true)
            parts.AddRange(Given.Select(g => g.Value).Where(g => !string.IsNullOrEmpty(g))!);
        
        if (!string.IsNullOrEmpty(Family?.Value))
            parts.Add(Family.Value);
        
        if (Suffix?.Any() == true)
            parts.AddRange(Suffix.Select(s => s.Value).Where(s => !string.IsNullOrEmpty(s))!);
        
        return string.Join(" ", parts);
    }

    /// <summary>
    /// Validates the HumanName according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // Validate use value
        if (Use?.Value != null)
        {
            var validUses = new[] { "usual", "official", "temp", "nickname", "anonymous", "old", "maiden" };
            if (!validUses.Contains(Use.Value))
            {
                yield return new ValidationResult(
                    $"HumanName.use '{Use.Value}' is not valid. Must be one of: {string.Join(", ", validUses)}",
                    new[] { nameof(Use) });
            }
        }
    }

    protected override string? GetComplexTypeString()
    {
        return $"HumanName: {GetFullName()}";
    }
}
