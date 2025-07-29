using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR Address complex type.
/// An address expressed using postal conventions.
/// </summary>
/// <remarks>
/// FHIR R5 Address (Complex Type)
/// An address expressed using postal conventions.
/// 
/// Structure:
/// - use: code (0..1) - home | work | temp | old | billing
/// - type: code (0..1) - postal | physical | both
/// - text: string (0..1) - Text representation of the address
/// - line: string[] (0..*) - Street name, number, direction & P.O. Box etc.
/// - city: string (0..1) - Name of city, town etc.
/// - district: string (0..1) - District name (aka county)
/// - state: string (0..1) - Sub-unit of country (abbreviations ok)
/// - postalCode: string (0..1) - Postal code for area
/// - country: string (0..1) - Country (e.g. can be ISO 3166 2 or 3 letter code)
/// - period: Period (0..1) - Time period when address was/is in use
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Address : UnifiedComplexTypeBase<Address>
{
    /// <summary>
    /// Gets or sets the use.
    /// home | work | temp | old | billing.
    /// </summary>
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// postal | physical | both.
    /// </summary>
    [JsonPropertyName("type")]
    public FhirCode? Type { get; set; }

    /// <summary>
    /// Gets or sets the text.
    /// Text representation of the address.
    /// </summary>
    [JsonPropertyName("text")]
    public FhirString? Text { get; set; }

    /// <summary>
    /// Gets or sets the line.
    /// Street name, number, direction & P.O. Box etc.
    /// </summary>
    [JsonPropertyName("line")]
    public IList<FhirString>? Line { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// Name of city, town etc.
    /// </summary>
    [JsonPropertyName("city")]
    public FhirString? City { get; set; }

    /// <summary>
    /// Gets or sets the district.
    /// District name (aka county).
    /// </summary>
    [JsonPropertyName("district")]
    public FhirString? District { get; set; }

    /// <summary>
    /// Gets or sets the state.
    /// Sub-unit of country (abbreviations ok).
    /// </summary>
    [JsonPropertyName("state")]
    public FhirString? State { get; set; }

    /// <summary>
    /// Gets or sets the postal code.
    /// Postal code for area.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public FhirString? PostalCode { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// Country (e.g. can be ISO 3166 2 or 3 letter code).
    /// </summary>
    [JsonPropertyName("country")]
    public FhirString? Country { get; set; }

    /// <summary>
    /// Gets or sets the period.
    /// Time period when address was/is in use.
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    /// <summary>
    /// Gets the full address as text.
    /// </summary>
    /// <returns>The full address text.</returns>
    [JsonIgnore]
    public string? FullAddress => Text?.Value ?? BuildFullAddress();

    /// <summary>
    /// Builds the full address from components.
    /// </summary>
    /// <returns>The built full address.</returns>
    private string? BuildFullAddress()
    {
        var parts = new List<string>();
        
        if (Line?.Any() == true)
        {
            parts.AddRange(Line.Select(l => l.Value));
        }
        
        if (!string.IsNullOrEmpty(City?.Value))
        {
            parts.Add(City.Value);
        }
        
        if (!string.IsNullOrEmpty(District?.Value))
        {
            parts.Add(District.Value);
        }
        
        if (!string.IsNullOrEmpty(State?.Value))
        {
            parts.Add(State.Value);
        }
        
        if (!string.IsNullOrEmpty(PostalCode?.Value))
        {
            parts.Add(PostalCode.Value);
        }
        
        if (!string.IsNullOrEmpty(Country?.Value))
        {
            parts.Add(Country.Value);
        }
        
        return string.Join(", ", parts.Where(p => !string.IsNullOrEmpty(p)));
    }

    /// <summary>
    /// Copies fields to target.
    /// </summary>
    /// <param name="target">The target object.</param>
    protected override void CopyFieldsTo(Address target)
    {
        target.Use = (FhirCode?)Use?.DeepCopy();
        target.Type = (FhirCode?)Type?.DeepCopy();
        target.Text = (FhirString?)Text?.DeepCopy();
        target.Line = Line?.Select(l => (FhirString)l.DeepCopy()).ToList();
        target.City = (FhirString?)City?.DeepCopy();
        target.District = (FhirString?)District?.DeepCopy();
        target.State = (FhirString?)State?.DeepCopy();
        target.PostalCode = (FhirString?)PostalCode?.DeepCopy();
        target.Country = (FhirString?)Country?.DeepCopy();
        target.Period = (Period?)Period?.DeepCopy();
    }

    /// <summary>
    /// Compares if fields are exactly equal.
    /// </summary>
    /// <param name="other">The other object to compare.</param>
    /// <returns>True if fields are exactly equal; otherwise, false.</returns>
    protected override bool FieldsAreExactly(Address other)
    {
        return Equals(Use, other.Use)
            && Equals(Type, other.Type)
            && Equals(Text, other.Text)
            && (Line?.SequenceEqual(other.Line ?? new List<FhirString>(), new DeepEqualityComparer<FhirString>()) ?? other.Line == null)
            && Equals(City, other.City)
            && Equals(District, other.District)
            && Equals(State, other.State)
            && Equals(PostalCode, other.PostalCode)
            && Equals(Country, other.Country)
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
        if (Type != null)
        {
            foreach (var v in Type.Validate(validationContext))
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
        if (Line != null)
        {
            foreach (var l in Line)
            {
                foreach (var v in l.Validate(validationContext))
                {
                    yield return v;
                }
            }
        }
        if (City != null)
        {
            foreach (var v in City.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (District != null)
        {
            foreach (var v in District.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (State != null)
        {
            foreach (var v in State.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (PostalCode != null)
        {
            foreach (var v in PostalCode.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (Country != null)
        {
            foreach (var v in Country.Validate(validationContext))
            {
                yield return v;
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