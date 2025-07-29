using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR CodeableConcept complex type.
/// A concept that may be defined by a formal reference to a terminology or ontology
/// or may be provided by text.
/// </summary>
/// <remarks>
/// FHIR R5 CodeableConcept (Complex Type)
/// A concept that may be defined by a formal reference to a terminology or ontology
/// or may be provided by text.
/// 
/// Structure:
/// - coding: Coding[] (0..*) - Code defined by a terminology system
/// - text: string (0..1) - Plain text representation of the concept
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class CodeableConcept : UnifiedComplexTypeBase<CodeableConcept>
{
    /// <summary>
    /// Gets or sets the coding.
    /// Code defined by a terminology system.
    /// </summary>
    [JsonPropertyName("coding")]
    public IList<Coding>? Coding { get; set; }

    /// <summary>
    /// Gets or sets the text.
    /// Plain text representation of the concept.
    /// </summary>
    [JsonPropertyName("text")]
    public FhirString? Text { get; set; }

    /// <summary>
    /// Checks if coding exists.
    /// </summary>
    /// <returns>True if coding exists; otherwise, false.</returns>
    [JsonIgnore]
    public bool HasCoding => Coding?.Any() == true;

    /// <summary>
    /// Checks if text exists.
    /// </summary>
    /// <returns>True if text exists; otherwise, false.</returns>
    [JsonIgnore]
    public bool HasText => !string.IsNullOrEmpty(Text?.Value);

    /// <summary>
    /// Gets the display text.
    /// </summary>
    /// <returns>The display text.</returns>
    [JsonIgnore]
    public string? DisplayText => Text?.Value ?? Coding?.FirstOrDefault()?.Display?.Value;

    /// <summary>
    /// Gets coding by system.
    /// </summary>
    /// <param name="system">The coding system.</param>
    /// <returns>The found coding, or null if not found.</returns>
    public Coding? GetCoding(string system)
    {
        return Coding?.FirstOrDefault(c => c.System?.Value == system);
    }

    /// <summary>
    /// Adds coding.
    /// </summary>
    /// <param name="coding">The coding to add.</param>
    public void AddCoding(Coding coding)
    {
        Coding ??= new List<Coding>();
        Coding.Add(coding);
    }

    /// <summary>
    /// Removes coding by system.
    /// </summary>
    /// <param name="system">The coding system to remove.</param>
    /// <returns>True if successfully removed; otherwise, false.</returns>
    public bool RemoveCoding(string system)
    {
        if (Coding == null) return false;
        
        var toRemove = Coding.Where(c => c.System?.Value == system).ToList();
        foreach (var coding in toRemove)
        {
            Coding.Remove(coding);
        }
        
        return toRemove.Any();
    }

    /// <summary>
    /// Copies fields to target.
    /// </summary>
    /// <param name="target">The target object.</param>
    protected override void CopyFieldsTo(CodeableConcept target)
    {
        target.Coding = Coding?.Select(c => (Coding)c.DeepCopy()).ToList();
        target.Text = (FhirString?)Text?.DeepCopy();
    }

    /// <summary>
    /// Compares if fields are exactly equal.
    /// </summary>
    /// <param name="other">The other object to compare.</param>
    /// <returns>True if fields are exactly equal; otherwise, false.</returns>
    protected override bool FieldsAreExactly(CodeableConcept other)
    {
        return (Coding?.SequenceEqual(other.Coding ?? new List<Coding>(), new DeepEqualityComparer<Coding>()) ?? other.Coding == null)
            && Equals(Text, other.Text);
    }

    /// <summary>
    /// Validates fields.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>Validation result collection.</returns>
    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        if (Coding != null)
        {
            foreach (var c in Coding)
            {
                foreach (var v in c.Validate(validationContext))
                {
                    yield return v;
                }
            }
        }
        if (Text != null)
        {
            foreach (var v in Text.Validate(validationContext))
            {
                yield return v;
            }
        }
    }
} 