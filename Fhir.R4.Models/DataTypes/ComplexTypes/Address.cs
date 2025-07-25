using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// An address expressed using postal conventions (as opposed to GPS or other location definition formats).
/// </summary>
/// <remarks>
/// FHIR R4 Address DataType
/// An address expressed using postal conventions.
/// </remarks>
public class Address : ComplexType<Address>
{
    /// <summary>
    /// The purpose of this address.
    /// FHIR Path: Address.use
    /// Cardinality: 0..1
    /// Allowed values: home, work, temp, old, billing
    /// </summary>
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }
    
    /// <summary>
    /// Distinguishes between physical addresses and mailing addresses.
    /// FHIR Path: Address.type
    /// Cardinality: 0..1
    /// Allowed values: postal, physical, both
    /// </summary>
    [JsonPropertyName("type")]
    public FhirCode? Type { get; set; }
    
    /// <summary>
    /// Text representation of the address.
    /// FHIR Path: Address.text
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("text")]
    public FhirString? Text { get; set; }
    
    /// <summary>
    /// Street name, number, direction &amp; P.O. Box etc.
    /// FHIR Path: Address.line
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("line")]
    public List<FhirString>? Line { get; set; }
    
    /// <summary>
    /// Name of city, town etc.
    /// FHIR Path: Address.city
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("city")]
    public FhirString? City { get; set; }
    
    /// <summary>
    /// District name (aka county).
    /// FHIR Path: Address.district
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("district")]
    public FhirString? District { get; set; }
    
    /// <summary>
    /// Sub-unit of country (abbreviations ok).
    /// FHIR Path: Address.state
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("state")]
    public FhirString? State { get; set; }
    
    /// <summary>
    /// Postal code for area.
    /// FHIR Path: Address.postalCode
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("postalCode")]
    public FhirString? PostalCode { get; set; }
    
    /// <summary>
    /// Country (e.g. can be ISO 3166 2 or 3 letter code).
    /// FHIR Path: Address.country
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("country")]
    public FhirString? Country { get; set; }
    
    /// <summary>
    /// Time period when address was/is in use.
    /// FHIR Path: Address.period
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    /// <summary>
    /// Initializes a new instance of the Address class.
    /// </summary>
    public Address() { }

    /// <summary>
    /// Initializes a new instance of the Address class with basic components.
    /// </summary>
    /// <param name="line">The address lines.</param>
    /// <param name="city">The city.</param>
    /// <param name="state">The state.</param>
    /// <param name="postalCode">The postal code.</param>
    /// <param name="country">The country.</param>
    public Address(string[]? line, string? city, string? state, string? postalCode, string? country)
    {
        Line = line?.Select(l => new FhirString(l)).ToList();
        City = city != null ? new FhirString(city) : null;
        State = state != null ? new FhirString(state) : null;
        PostalCode = postalCode != null ? new FhirString(postalCode) : null;
        Country = country != null ? new FhirString(country) : null;
    }

    /// <summary>
    /// Creates a home address.
    /// </summary>
    /// <param name="line">The address lines.</param>
    /// <param name="city">The city.</param>
    /// <param name="state">The state.</param>
    /// <param name="postalCode">The postal code.</param>
    /// <param name="country">The country.</param>
    /// <returns>A new Address instance.</returns>
    public static Address Home(string[]? line, string? city, string? state, string? postalCode, string? country)
    {
        return new Address(line, city, state, postalCode, country)
        {
            Use = new FhirCode("home")
        };
    }

    /// <summary>
    /// Creates a work address.
    /// </summary>
    /// <param name="line">The address lines.</param>
    /// <param name="city">The city.</param>
    /// <param name="state">The state.</param>
    /// <param name="postalCode">The postal code.</param>
    /// <param name="country">The country.</param>
    /// <returns>A new Address instance.</returns>
    public static Address Work(string[]? line, string? city, string? state, string? postalCode, string? country)
    {
        return new Address(line, city, state, postalCode, country)
        {
            Use = new FhirCode("work")
        };
    }

    /// <summary>
    /// Gets the formatted address as a single string.
    /// </summary>
    /// <returns>The formatted address.</returns>
    public string GetFormattedAddress()
    {
        var parts = new List<string>();
        
        if (Line?.Any() == true)
            parts.AddRange(Line.Select(l => l.Value).Where(l => !string.IsNullOrEmpty(l))!);
        
        var cityStateZip = new List<string>();
        if (!string.IsNullOrEmpty(City?.Value))
            cityStateZip.Add(City.Value);
        if (!string.IsNullOrEmpty(State?.Value))
            cityStateZip.Add(State.Value);
        if (!string.IsNullOrEmpty(PostalCode?.Value))
            cityStateZip.Add(PostalCode.Value);
        
        if (cityStateZip.Any())
            parts.Add(string.Join(", ", cityStateZip));
        
        if (!string.IsNullOrEmpty(Country?.Value))
            parts.Add(Country.Value);
        
        return string.Join("\n", parts);
    }

    /// <summary>
    /// Validates the Address according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // Validate use value
        if (Use?.Value != null)
        {
            var validUses = new[] { "home", "work", "temp", "old", "billing" };
            if (!validUses.Contains(Use.Value))
            {
                yield return new ValidationResult(
                    $"Address.use '{Use.Value}' is not valid. Must be one of: {string.Join(", ", validUses)}",
                    new[] { nameof(Use) });
            }
        }
        
        // Validate type value
        if (Type?.Value != null)
        {
            var validTypes = new[] { "postal", "physical", "both" };
            if (!validTypes.Contains(Type.Value))
            {
                yield return new ValidationResult(
                    $"Address.type '{Type.Value}' is not valid. Must be one of: {string.Join(", ", validTypes)}",
                    new[] { nameof(Type) });
            }
        }
    }

    protected override string? GetComplexTypeString()
    {
        return $"Address: {GetFormattedAddress().Replace("\n", ", ")}";
    }
}
