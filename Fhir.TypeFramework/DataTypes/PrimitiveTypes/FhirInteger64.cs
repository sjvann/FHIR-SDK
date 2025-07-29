using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR integer64 primitive type.
/// A 64-bit integer.
/// </summary>
/// <remarks>
/// FHIR R5 integer64 PrimitiveType
/// A 64-bit integer.
/// 
/// JSON Representation:
/// - Simple: "count" : 42
/// - Full: "count" : 42, "_count" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirInteger64 : NumericPrimitiveTypeBase<long>
{
    /// <summary>
    /// Gets or sets the 64-bit integer value.
    /// </summary>
    [JsonIgnore]
    public long? Integer64Value { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirInteger64 class.
    /// </summary>
    public FhirInteger64() { }

    /// <summary>
    /// Initializes a new instance of the FhirInteger64 class with the specified value.
    /// </summary>
    /// <param name="value">The 64-bit integer value.</param>
    public FhirInteger64(long? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a long to a FhirInteger64.
    /// </summary>
    /// <param name="value">The long value to convert.</param>
    /// <returns>A FhirInteger64 instance.</returns>
    public static implicit operator FhirInteger64?(long? value)
    {
        return CreateFromValue<FhirInteger64>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirInteger64 to a long.
    /// </summary>
    /// <param name="fhirInteger64">The FhirInteger64 to convert.</param>
    /// <returns>The long value.</returns>
    public static implicit operator long?(FhirInteger64? fhirInteger64)
    {
        return GetNumericValue<FhirInteger64>(fhirInteger64);
    }

    /// <summary>
    /// Parses a string value to a 64-bit integer.
    /// </summary>
    /// <param name="value">The string value to parse.</param>
    /// <returns>The parsed 64-bit integer value, or null if parsing fails.</returns>
    protected override long? ParseNumericValue(string value)
    {
        if (long.TryParse(value, out long result))
            return result;
        return null;
    }

    /// <summary>
    /// Validates the 64-bit integer value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The 64-bit integer value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateNumericValue(long value)
    {
        // FHIR integer64 has no additional validation rules beyond being a valid long
        return true;
    }
}
