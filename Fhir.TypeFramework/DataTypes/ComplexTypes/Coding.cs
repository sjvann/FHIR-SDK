using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR Coding complex type.
/// A reference to a code defined by a terminology system.
/// </summary>
/// <remarks>
/// FHIR R5 Coding (Complex Type)
/// A reference to a code defined by a terminology system.
/// 
/// Structure:
/// - system: uri (0..1) - Identity of the terminology system
/// - version: string (0..1) - Version of the system - if relevant
/// - code: code (0..1) - Symbol in syntax defined by the system
/// - display: string (0..1) - Representation defined by the system
/// - userSelected: boolean (0..1) - If this coding was chosen directly by the user
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Coding : UnifiedComplexTypeBase<Coding>
{
    /// <summary>
    /// Gets or sets the system.
    /// Identity of the terminology system.
    /// </summary>
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// Gets or sets the version.
    /// Version of the system - if relevant.
    /// </summary>
    [JsonPropertyName("version")]
    public FhirString? Version { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// Symbol in syntax defined by the system.
    /// </summary>
    [JsonPropertyName("code")]
    public FhirCode? Code { get; set; }

    /// <summary>
    /// Gets or sets the display.
    /// Representation defined by the system.
    /// </summary>
    [JsonPropertyName("display")]
    public FhirString? Display { get; set; }

    /// <summary>
    /// Gets or sets the user selected.
    /// If this coding was chosen directly by the user.
    /// </summary>
    [JsonPropertyName("userSelected")]
    public FhirBoolean? UserSelected { get; set; }

    /// <summary>
    /// Checks if code exists.
    /// </summary>
    /// <returns>True if code exists; otherwise, false.</returns>
    [JsonIgnore]
    public bool HasCode => !string.IsNullOrEmpty(Code?.Value);

    /// <summary>
    /// Checks if system exists.
    /// </summary>
    /// <returns>True if system exists; otherwise, false.</returns>
    [JsonIgnore]
    public bool HasSystem => !string.IsNullOrEmpty(System?.Value);

    /// <summary>
    /// Gets the display text.
    /// </summary>
    /// <returns>The display text.</returns>
    [JsonIgnore]
    public string? DisplayText => Display?.Value ?? Code?.Value;

    /// <summary>
    /// Copies fields to target.
    /// </summary>
    /// <param name="target">The target object.</param>
    protected override void CopyFieldsTo(Coding target)
    {
        target.System = (FhirUri?)System?.DeepCopy();
        target.Version = (FhirString?)Version?.DeepCopy();
        target.Code = (FhirCode?)Code?.DeepCopy();
        target.Display = (FhirString?)Display?.DeepCopy();
        target.UserSelected = (FhirBoolean?)UserSelected?.DeepCopy();
    }

    /// <summary>
    /// Compares if fields are exactly equal.
    /// </summary>
    /// <param name="other">The other object to compare.</param>
    /// <returns>True if fields are exactly equal; otherwise, false.</returns>
    protected override bool FieldsAreExactly(Coding other)
    {
        return Equals(System, other.System)
            && Equals(Version, other.Version)
            && Equals(Code, other.Code)
            && Equals(Display, other.Display)
            && Equals(UserSelected, other.UserSelected);
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
        if (Version != null)
        {
            foreach (var v in Version.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (Code != null)
        {
            foreach (var v in Code.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (Display != null)
        {
            foreach (var v in Display.Validate(validationContext))
            {
                yield return v;
            }
        }
        if (UserSelected != null)
        {
            foreach (var v in UserSelected.Validate(validationContext))
            {
                yield return v;
            }
        }
    }
} 