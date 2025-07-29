using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR HumanName complex type.
/// A human's name with the ability to identify parts and usage.
/// </summary>
/// <remarks>
/// FHIR R5 HumanName (Complex Type)
/// A human's name with the ability to identify parts and usage.
/// 
/// Structure:
/// - use: code (0..1) - usual | official | temp | nickname | anonymous | old | maiden
/// - text: string (0..1) - Text representation of the full name
/// - family: string (0..1) - Family name (often called 'Surname')
/// - given: string[] (0..*) - Given names (not always 'first'). Includes middle names
/// - prefix: string[] (0..*) - Parts that come before the name
/// - suffix: string[] (0..*) - Parts that come after the name
/// - period: Period (0..1) - Time period when name was/is in use
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class HumanName : UnifiedComplexTypeBase<HumanName>
{
    /// <summary>
    /// Gets or sets the use.
    /// usual | official | temp | nickname | anonymous | old | maiden.
    /// </summary>
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }

    /// <summary>
    /// Gets or sets the text.
    /// Text representation of the full name.
    /// </summary>
    [JsonPropertyName("text")]
    public FhirString? Text { get; set; }

    /// <summary>
    /// Gets or sets the family.
    /// Family name (often called 'Surname').
    /// </summary>
    [JsonPropertyName("family")]
    public FhirString? Family { get; set; }

    /// <summary>
    /// Gets or sets the given names.
    /// Given names (not always 'first'). Includes middle names.
    /// </summary>
    [JsonPropertyName("given")]
    public IList<FhirString>? Given { get; set; }

    /// <summary>
    /// Gets or sets the prefix.
    /// Parts that come before the name.
    /// </summary>
    [JsonPropertyName("prefix")]
    public IList<FhirString>? Prefix { get; set; }

    /// <summary>
    /// Gets or sets the suffix.
    /// Parts that come after the name.
    /// </summary>
    [JsonPropertyName("suffix")]
    public IList<FhirString>? Suffix { get; set; }

    /// <summary>
    /// Gets or sets the period.
    /// Time period when name was/is in use.
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    /// <summary>
    /// Gets the full name as text.
    /// </summary>
    /// <returns>The full name text.</returns>
    [JsonIgnore]
    public string? FullName => Text?.Value ?? BuildFullName();

    /// <summary>
    /// Gets the first given name.
    /// </summary>
    /// <returns>The first given name.</returns>
    [JsonIgnore]
    public string? FirstName => Given?.FirstOrDefault()?.Value;

    /// <summary>
    /// Gets the last name.
    /// </summary>
    /// <returns>The last name.</returns>
    [JsonIgnore]
    public string? LastName => Family?.Value;

    /// <summary>
    /// Builds the full name from components.
    /// </summary>
    /// <returns>The built full name.</returns>
    private string? BuildFullName()
    {
        var parts = new List<string>();
        
        if (Prefix?.Any() == true)
        {
            parts.AddRange(Prefix.Select(p => p.Value));
        }
        
        if (Given?.Any() == true)
        {
            parts.AddRange(Given.Select(g => g.Value));
        }
        
        if (!string.IsNullOrEmpty(Family?.Value))
        {
            parts.Add(Family.Value);
        }
        
        if (Suffix?.Any() == true)
        {
            parts.AddRange(Suffix.Select(s => s.Value));
        }
        
        return string.Join(" ", parts.Where(p => !string.IsNullOrEmpty(p)));
    }

    /// <summary>
    /// Copies fields to target.
    /// </summary>
    /// <param name="target">The target object.</param>
    protected override void CopyFieldsTo(HumanName target)
    {
        target.Use = (FhirCode?)Use?.DeepCopy();
        target.Text = (FhirString?)Text?.DeepCopy();
        target.Family = (FhirString?)Family?.DeepCopy();
        target.Given = Given?.Select(g => (FhirString)g.DeepCopy()).ToList();
        target.Prefix = Prefix?.Select(p => (FhirString)p.DeepCopy()).ToList();
        target.Suffix = Suffix?.Select(s => (FhirString)s.DeepCopy()).ToList();
        target.Period = (Period?)Period?.DeepCopy();
    }

    /// <summary>
    /// Compares if fields are exactly equal.
    /// </summary>
    /// <param name="other">The other object to compare.</param>
    /// <returns>True if fields are exactly equal; otherwise, false.</returns>
    protected override bool FieldsAreExactly(HumanName other)
    {
        return Equals(Use, other.Use)
            && Equals(Text, other.Text)
            && Equals(Family, other.Family)
            && (Given?.SequenceEqual(other.Given ?? new List<FhirString>(), new DeepEqualityComparer<FhirString>()) ?? other.Given == null)
            && (Prefix?.SequenceEqual(other.Prefix ?? new List<FhirString>(), new DeepEqualityComparer<FhirString>()) ?? other.Prefix == null)
            && (Suffix?.SequenceEqual(other.Suffix ?? new List<FhirString>(), new DeepEqualityComparer<FhirString>()) ?? other.Suffix == null)
            && Equals(Period, other.Period);
    }

    /// <summary>
    /// Validates fields.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>Validation result collection.</returns>
    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        if (Use != null)
        {
            foreach (var v in Use.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (Text != null)
        {
            foreach (var v in Text.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (Family != null)
        {
            foreach (var v in Family.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (Given != null)
        {
            foreach (var g in Given)
            {
                foreach (var v in g.Validate(validationContext))
                {
                    yield return v;
                }
            }
        }
        if (Prefix != null)
        {
            foreach (var p in Prefix)
            {
                foreach (var v in p.Validate(validationContext))
                {
                    yield return v;
                }
            }
        }
        if (Suffix != null)
        {
            foreach (var s in Suffix)
            {
                foreach (var v in s.Validate(validationContext))
                {
                    yield return v;
                }
            }
        }
        if (Period != null)
        {
            foreach (var v in Period.Validate(validationContext))
            {
                yield return v;
            }
        }
    }
} 