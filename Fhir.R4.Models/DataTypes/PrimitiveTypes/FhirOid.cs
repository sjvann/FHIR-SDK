using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// FHIR oid primitive type.
/// An OID represented as a URI.
/// </summary>
/// <remarks>
/// FHIR R4 oid PrimitiveType
/// An OID represented as a URI.
/// </remarks>
public class FhirOid : Element
{
    private string? _value;

    /// <summary>
    /// The actual oid value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the FhirOid class.
    /// </summary>
    public FhirOid() { }

    /// <summary>
    /// Initializes a new instance of the FhirOid class with the specified value.
    /// </summary>
    /// <param name="value">The oid value.</param>
    public FhirOid(string? value)
    {
        Value = value;
    }

    /// <summary>
    /// Implicitly converts a string to a FhirOid.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirOid instance, or null if the value is null.</returns>
    public static implicit operator FhirOid?(string? value)
    {
        return value == null ? null : new FhirOid(value);
    }

    /// <summary>
    /// Implicitly converts a FhirOid to a string.
    /// </summary>
    /// <param name="fhirOid">The FhirOid to convert.</param>
    /// <returns>The string value, or null if the FhirOid is null.</returns>
    public static implicit operator string?(FhirOid? fhirOid)
    {
        return fhirOid?.Value;
    }

    /// <summary>
    /// Validates the FhirOid according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        if (!string.IsNullOrEmpty(Value))
        {
            // OID must start with "urn:oid:" and follow the pattern
            if (!Value.StartsWith("urn:oid:"))
            {
                yield return new ValidationResult($"OID value '{Value}' must start with 'urn:oid:'");
            }
            else
            {
                var oidPart = Value.Substring(8); // Remove "urn:oid:" prefix
                if (!IsValidOidFormat(oidPart))
                {
                    yield return new ValidationResult($"OID value '{Value}' does not have a valid OID format");
                }
            }
        }
    }

    /// <summary>
    /// Validates the OID format according to ISO/IEC 8824 standard.
    /// </summary>
    /// <param name="oid">The OID string to validate (without urn:oid: prefix).</param>
    /// <returns>True if the OID format is valid; otherwise, false.</returns>
    private bool IsValidOidFormat(string oid)
    {
        // OID format: sequence of integers separated by dots
        // Must start with 0, 1, or 2
        // Second arc must be 0-39 if first is 0 or 1, or any value if first is 2
        var regex = new Regex(@"^[0-2](\.(0|[1-9]\d*))*$");
        if (!regex.IsMatch(oid))
            return false;

        var parts = oid.Split('.');
        if (parts.Length < 2)
            return false;

        var firstArc = int.Parse(parts[0]);
        var secondArc = int.Parse(parts[1]);

        if (firstArc <= 1 && secondArc > 39)
            return false;

        return true;
    }

    /// <summary>
    /// Returns a string representation of the FhirOid.
    /// </summary>
    /// <returns>The oid value.</returns>
    public override string? ToString() => Value;
}
