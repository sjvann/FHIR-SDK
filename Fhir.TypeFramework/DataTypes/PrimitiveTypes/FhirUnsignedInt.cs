using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR unsignedInt primitive type.
/// A non-negative integer (0, 1, 2, 3, ...).
/// </summary>
/// <remarks>
/// FHIR R5 unsignedInt PrimitiveType
/// A non-negative integer (0, 1, 2, 3, ...).
/// 
/// JSON Representation:
/// - Simple: "count" : 42
/// - Full: "count" : 42, "_count" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirUnsignedInt : NumericPrimitiveTypeBase<uint>
{
    /// <summary>
    /// Gets or sets the unsigned integer value.
    /// </summary>
    [JsonIgnore]
    public uint? UnsignedIntValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirUnsignedInt class.
    /// </summary>
    public FhirUnsignedInt() { }

    /// <summary>
    /// Initializes a new instance of the FhirUnsignedInt class with the specified value.
    /// </summary>
    /// <param name="value">The unsigned integer value.</param>
    public FhirUnsignedInt(uint? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a uint to a FhirUnsignedInt.
    /// </summary>
    /// <param name="value">The uint value to convert.</param>
    /// <returns>A FhirUnsignedInt instance.</returns>
    public static implicit operator FhirUnsignedInt?(uint? value)
    {
        return CreateFromValue<FhirUnsignedInt>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirUnsignedInt to a uint.
    /// </summary>
    /// <param name="fhirUnsignedInt">The FhirUnsignedInt to convert.</param>
    /// <returns>The uint value.</returns>
    public static implicit operator uint?(FhirUnsignedInt? fhirUnsignedInt)
    {
        return GetNumericValue<FhirUnsignedInt>(fhirUnsignedInt);
    }

    /// <summary>
    /// Parses a string value to an unsigned integer.
    /// </summary>
    /// <param name="value">The string value to parse.</param>
    /// <returns>The parsed unsigned integer value, or null if parsing fails.</returns>
    protected override uint? ParseNumericValue(string value)
    {
        if (uint.TryParse(value, out uint result))
            return result;
        return null;
    }

    /// <summary>
    /// Validates the unsigned integer value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The unsigned integer value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateNumericValue(uint value)
    {
        // FHIR unsignedInt has no additional validation rules beyond being a valid uint
        return true;
    }
}
