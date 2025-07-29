using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR positiveInt primitive type.
/// An integer with a value that is positive (non-zero, natural numbers).
/// </summary>
/// <remarks>
/// FHIR R5 positiveInt PrimitiveType
/// An integer with a value that is positive (non-zero, natural numbers).
/// 
/// JSON Representation:
/// - Simple: "count" : 42
/// - Full: "count" : 42, "_count" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirPositiveInt : UnifiedPrimitiveTypeBase<int>
{
    /// <summary>
    /// Gets or sets the positive integer value.
    /// </summary>
    [JsonIgnore]
    public int? PositiveIntValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirPositiveInt class.
    /// </summary>
    public FhirPositiveInt() { }

    /// <summary>
    /// Initializes a new instance of the FhirPositiveInt class with the specified value.
    /// </summary>
    /// <param name="value">The positive integer value.</param>
    public FhirPositiveInt(int? value) : base(value) { }

    /// <summary>
    /// Implicitly converts an int to a FhirPositiveInt.
    /// </summary>
    /// <param name="value">The int value to convert.</param>
    /// <returns>A FhirPositiveInt instance, or null if the value is null.</returns>
    public static implicit operator FhirPositiveInt?(int? value)
    {
        return CreateFromValue<FhirPositiveInt>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirPositiveInt to an int.
    /// </summary>
    /// <param name="fhirPositiveInt">The FhirPositiveInt to convert.</param>
    /// <returns>The int value, or null if the FhirPositiveInt is null.</returns>
    public static implicit operator int?(FhirPositiveInt? fhirPositiveInt)
    {
        return GetValue<FhirPositiveInt>(fhirPositiveInt);
    }

    /// <summary>
    /// Parses a positive integer value from string.
    /// </summary>
    /// <param name="value">The string to parse.</param>
    /// <returns>The parsed positive integer value.</returns>
    protected override int? ParseValueFromString(string value)
    {
        if (int.TryParse(value, out var result))
        {
            return result;
        }
        return null;
    }

    /// <summary>
    /// Converts a positive integer value to string.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The string representation.</returns>
    protected override string? ValueToString(int? value)
    {
        return value?.ToString();
    }

    /// <summary>
    /// Validates the positive integer value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The positive integer value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateValue(int value)
    {
        // 使用 ValidationFramework 中的基本驗證工具
        return ValidationFramework.ValidatePositiveInteger(value);
    }
}
