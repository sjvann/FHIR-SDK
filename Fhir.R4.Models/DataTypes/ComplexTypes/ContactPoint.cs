using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// Details for all kinds of technology mediated contact points for a person or organization.
/// </summary>
/// <remarks>
/// FHIR R4 ContactPoint DataType
/// Details for all kinds of technology mediated contact points.
/// </remarks>
public class ContactPoint : ComplexType<ContactPoint>
{
    /// <summary>
    /// Telecommunications form for contact point.
    /// FHIR Path: ContactPoint.system
    /// Cardinality: 0..1
    /// Allowed values: phone, fax, email, pager, url, sms, other
    /// </summary>
    [JsonPropertyName("system")]
    public FhirCode? System { get; set; }
    
    /// <summary>
    /// The actual contact point details.
    /// FHIR Path: ContactPoint.value
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("value")]
    public FhirString? Value { get; set; }
    
    /// <summary>
    /// Identifies the purpose for the contact point.
    /// FHIR Path: ContactPoint.use
    /// Cardinality: 0..1
    /// Allowed values: home, work, temp, old, mobile
    /// </summary>
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }
    
    /// <summary>
    /// Specify preferred order of use (1 = highest).
    /// FHIR Path: ContactPoint.rank
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("rank")]
    public FhirPositiveInt? Rank { get; set; }
    
    /// <summary>
    /// Time period when the contact point was/is in use.
    /// FHIR Path: ContactPoint.period
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    /// <summary>
    /// Initializes a new instance of the ContactPoint class.
    /// </summary>
    public ContactPoint() { }

    /// <summary>
    /// Initializes a new instance of the ContactPoint class with system and value.
    /// </summary>
    /// <param name="system">The contact system.</param>
    /// <param name="value">The contact value.</param>
    /// <param name="use">The contact use.</param>
    public ContactPoint(string system, string value, string? use = null)
    {
        System = new FhirCode(system);
        Value = new FhirString(value);
        Use = use != null ? new FhirCode(use) : null;
    }

    /// <summary>
    /// Creates a phone contact point.
    /// </summary>
    /// <param name="phoneNumber">The phone number.</param>
    /// <param name="use">The use (home, work, mobile, etc.).</param>
    /// <returns>A new ContactPoint instance.</returns>
    public static ContactPoint Phone(string phoneNumber, string? use = null)
    {
        return new ContactPoint("phone", phoneNumber, use);
    }

    /// <summary>
    /// Creates an email contact point.
    /// </summary>
    /// <param name="email">The email address.</param>
    /// <param name="use">The use (home, work, etc.).</param>
    /// <returns>A new ContactPoint instance.</returns>
    public static ContactPoint Email(string email, string? use = null)
    {
        return new ContactPoint("email", email, use);
    }

    /// <summary>
    /// Creates a URL contact point.
    /// </summary>
    /// <param name="url">The URL.</param>
    /// <param name="use">The use.</param>
    /// <returns>A new ContactPoint instance.</returns>
    public static ContactPoint Url(string url, string? use = null)
    {
        return new ContactPoint("url", url, use);
    }

    /// <summary>
    /// Creates a fax contact point.
    /// </summary>
    /// <param name="faxNumber">The fax number.</param>
    /// <param name="use">The use.</param>
    /// <returns>A new ContactPoint instance.</returns>
    public static ContactPoint Fax(string faxNumber, string? use = null)
    {
        return new ContactPoint("fax", faxNumber, use);
    }

    /// <summary>
    /// Sets the rank for this contact point.
    /// </summary>
    /// <param name="rank">The rank (1 = highest priority).</param>
    /// <returns>This ContactPoint instance for method chaining.</returns>
    public ContactPoint WithRank(int rank)
    {
        Rank = new FhirPositiveInt(rank);
        return this;
    }

    /// <summary>
    /// Sets the period for this contact point.
    /// </summary>
    /// <param name="start">The start date.</param>
    /// <param name="end">The end date.</param>
    /// <returns>This ContactPoint instance for method chaining.</returns>
    public ContactPoint WithPeriod(FhirDateTime? start, FhirDateTime? end)
    {
        Period = new Period(start, end);
        return this;
    }

    /// <summary>
    /// Validates the ContactPoint according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // cpt-2: A system is required if a value is provided
        if (!string.IsNullOrEmpty(Value?.Value) && string.IsNullOrEmpty(System?.Value))
        {
            yield return new ValidationResult(
                "ContactPoint system is required when value is provided",
                new[] { nameof(System) });
        }

        // Validate system value
        if (System?.Value != null)
        {
            var validSystems = new[] { "phone", "fax", "email", "pager", "url", "sms", "other" };
            if (!validSystems.Contains(System.Value))
            {
                yield return new ValidationResult(
                    $"ContactPoint.system '{System.Value}' is not valid. Must be one of: {string.Join(", ", validSystems)}",
                    new[] { nameof(System) });
            }
        }
        
        // Validate use value
        if (Use?.Value != null)
        {
            var validUses = new[] { "home", "work", "temp", "old", "mobile" };
            if (!validUses.Contains(Use.Value))
            {
                yield return new ValidationResult(
                    $"ContactPoint.use '{Use.Value}' is not valid. Must be one of: {string.Join(", ", validUses)}",
                    new[] { nameof(Use) });
            }
        }

        // Validate email format if system is email
        if (System?.Value == "email" && !string.IsNullOrEmpty(Value?.Value))
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailRegex.IsMatch(Value.Value))
            {
                yield return new ValidationResult(
                    "ContactPoint value must be a valid email address when system is 'email'",
                    new[] { nameof(Value) });
            }
        }

        // Validate URL format if system is url
        if (System?.Value == "url" && !string.IsNullOrEmpty(Value?.Value))
        {
            if (!Uri.TryCreate(Value.Value, UriKind.Absolute, out _))
            {
                yield return new ValidationResult(
                    "ContactPoint value must be a valid URL when system is 'url'",
                    new[] { nameof(Value) });
            }
        }
    }

    protected override string? GetComplexTypeString()
    {
        return $"ContactPoint: {System?.Value} - {Value?.Value}";
    }
}
