using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR url primitive type.
/// A Uniform Resource Locator.
/// </summary>
/// <remarks>
/// FHIR R5 url PrimitiveType
/// A Uniform Resource Locator.
/// 
/// JSON Representation:
/// - Simple: "url" : "http://example.com/resource"
/// - Full: "url" : "http://example.com/resource", "_url" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirUrl : UnifiedPrimitiveTypeBase<string>
{
    /// <summary>
    /// Gets or sets the URL value.
    /// </summary>
    [JsonIgnore]
    public string? UrlValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirUrl class.
    /// </summary>
    public FhirUrl() { }

    /// <summary>
    /// Initializes a new instance of the FhirUrl class with the specified value.
    /// </summary>
    /// <param name="value">The URL value.</param>
    public FhirUrl(string? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a string to a FhirUrl.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirUrl instance, or null if the value is null.</returns>
    public static implicit operator FhirUrl?(string? value)
    {
        return CreateFromString<FhirUrl>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirUrl to a string.
    /// </summary>
    /// <param name="fhirUrl">The FhirUrl to convert.</param>
    /// <returns>The string value, or null if the FhirUrl is null.</returns>
    public static implicit operator string?(FhirUrl? fhirUrl)
    {
        return GetStringValue<FhirUrl>(fhirUrl);
    }

    /// <summary>
    /// Parses a URL value from string.
    /// </summary>
    /// <param name="value">The string to parse.</param>
    /// <returns>The parsed URL value.</returns>
    protected override string? ParseValueFromString(string value)
    {
        return value;
    }

    /// <summary>
    /// Converts a URL value to string.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The string representation.</returns>
    protected override string? ValueToString(string? value)
    {
        return value;
    }

    /// <summary>
    /// Validates the URL value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The URL value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateValue(string value)
    {
        return ValidationFramework.ValidateUrl(value);
    }
}


