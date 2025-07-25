using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR markdown primitive type.
/// A string that may contain GitHub Flavored Markdown syntax for optional processing by a mark down presentation engine.
/// </summary>
/// <remarks>
/// FHIR R4 markdown PrimitiveType
/// A string that may contain GitHub Flavored Markdown syntax for optional processing by a mark down presentation engine.
/// </remarks>
public class FhirMarkdown : Element
{
    private string? _value;

    /// <summary>
    /// The actual markdown value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirMarkdown class.
    /// </summary>
    public FhirMarkdown() { }

    /// <summary>
    /// Initializes a new instance of the FhirMarkdown class with the specified value.
    /// </summary>
    /// <param name="value">The markdown value.</param>
    public FhirMarkdown(string? value)
    {
        Value = value;
    }

    /// <summary>
    /// Implicitly converts a string to a FhirMarkdown.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirMarkdown instance, or null if the value is null.</returns>
    public static implicit operator FhirMarkdown?(string? value)
    {
        return value == null ? null : new FhirMarkdown(value);
    }

    /// <summary>
    /// Implicitly converts a FhirMarkdown to a string.
    /// </summary>
    /// <param name="fhirMarkdown">The FhirMarkdown to convert.</param>
    /// <returns>The string value, or null if the FhirMarkdown is null.</returns>
    public static implicit operator string?(FhirMarkdown? fhirMarkdown)
    {
        return fhirMarkdown?.Value;
    }

    /// <summary>
    /// Validates the FhirMarkdown according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // FHIR markdown cannot exceed 1MB
        if (Value != null && System.Text.Encoding.UTF8.GetByteCount(Value) > 1024 * 1024)
        {
            yield return new ValidationResult("Markdown value cannot exceed 1MB in size");
        }
    }

    /// <summary>
    /// Returns a string representation of the FhirMarkdown.
    /// </summary>
    /// <returns>The markdown value.</returns>
    public override string? ToString() => Value;
}
