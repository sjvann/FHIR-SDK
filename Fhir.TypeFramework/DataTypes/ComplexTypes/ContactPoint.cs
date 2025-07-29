using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR ContactPoint complex type.
/// Details for all kinds of technology mediated contact points for a person or organization.
/// </summary>
/// <remarks>
/// FHIR R5 ContactPoint (Complex Type)
/// Details for all kinds of technology mediated contact points for a person or organization.
/// 
/// Structure:
/// - system: code (0..1) - phone | fax | email | pager | url | sms | other
/// - value: string (0..1) - The actual contact point details
/// - use: code (0..1) - home | work | temp | old | mobile
/// - rank: positiveInt (0..1) - Specify preferred order of use (1 = highest)
/// - period: Period (0..1) - Time period when the contact point was/is in use
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class ContactPoint : UnifiedComplexTypeBase<ContactPoint>
{
    /// <summary>
    /// Gets or sets the system.
    /// phone | fax | email | pager | url | sms | other.
    /// </summary>
    [JsonPropertyName("system")]
    public FhirCode? System { get; set; }

    /// <summary>
    /// Gets or sets the value.
    /// The actual contact point details.
    /// </summary>
    [JsonPropertyName("value")]
    public FhirString? Value { get; set; }

    /// <summary>
    /// Gets or sets the use.
    /// home | work | temp | old | mobile.
    /// </summary>
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }

    /// <summary>
    /// Gets or sets the rank.
    /// Specify preferred order of use (1 = highest).
    /// </summary>
    [JsonPropertyName("rank")]
    public FhirPositiveInt? Rank { get; set; }

    /// <summary>
    /// Gets or sets the period.
    /// Time period when the contact point was/is in use.
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    /// <summary>
    /// Gets the contact point value.
    /// </summary>
    /// <returns>The contact point value.</returns>
    [JsonIgnore]
    public string? ContactValue => Value?.Value;

    /// <summary>
    /// Gets the contact point system.
    /// </summary>
    /// <returns>The contact point system.</returns>
    [JsonIgnore]
    public string? ContactSystem => System?.Value;

    /// <summary>
    /// Copies fields to target.
    /// </summary>
    /// <param name="target">The target object.</param>
    protected override void CopyFieldsTo(ContactPoint target)
    {
        target.System = (FhirCode?)System?.DeepCopy();
        target.Value = (FhirString?)Value?.DeepCopy();
        target.Use = (FhirCode?)Use?.DeepCopy();
        target.Rank = (FhirPositiveInt?)Rank?.DeepCopy();
        target.Period = (Period?)Period?.DeepCopy();
    }

    /// <summary>
    /// Compares if fields are exactly equal.
    /// </summary>
    /// <param name="other">The other object to compare.</param>
    /// <returns>True if fields are exactly equal; otherwise, false.</returns>
    protected override bool FieldsAreExactly(ContactPoint other)
    {
        return Equals(System, other.System)
            && Equals(Value, other.Value)
            && Equals(Use, other.Use)
            && Equals(Rank, other.Rank)
            && Equals(Period, other.Period);
    }

    /// <summary>
    /// Validates fields.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>Validation result collection.</returns>
    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        if (System != null)
        {
            foreach (var v in System.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (Value != null)
        {
            foreach (var v in Value.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (Use != null)
        {
            foreach (var v in Use.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (Rank != null)
        {
            foreach (var v in Rank.Validate(validationContext))
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