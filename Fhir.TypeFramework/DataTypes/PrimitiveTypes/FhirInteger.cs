using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// 整數型別
/// 代表規範中的 integer 型別，為整數值
/// </summary>
/// <remarks>
/// 這個型別提供：
/// - 整數值的儲存和驗證
/// - 隱含轉換支援
/// - Extension 功能
/// - 深層複製和相等性比較
/// 
/// 使用範例：
/// <code>
/// var fhirInteger = new FhirInteger(42);
/// var value = fhirInteger.Value; // 42
/// </code>
/// 
/// 驗證規則：
/// - 32 位元整數範圍：-2,147,483,648 到 2,147,483,647
/// - 支援 Extension
/// 
/// JSON 表示：
/// - 簡化格式："count" : 42
/// - 完整格式："count" : 42, "_count" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirInteger : UnifiedPrimitiveTypeBase<int>
{
    /// <summary>
    /// Gets or sets the integer value.
    /// </summary>
    [JsonIgnore]
    public int? IntegerValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirInteger class.
    /// </summary>
    public FhirInteger() { }

    /// <summary>
    /// Initializes a new instance of the FhirInteger class with the specified value.
    /// </summary>
    /// <param name="value">The integer value.</param>
    public FhirInteger(int? value) : base(value) { }

    /// <summary>
    /// Implicitly converts an int to a FhirInteger.
    /// </summary>
    /// <param name="value">The int value to convert.</param>
    /// <returns>A FhirInteger instance, or null if the value is null.</returns>
    public static implicit operator FhirInteger?(int? value)
    {
        return CreateFromValue<FhirInteger>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirInteger to an int.
    /// </summary>
    /// <param name="fhirInteger">The FhirInteger to convert.</param>
    /// <returns>The int value, or null if the FhirInteger is null.</returns>
    public static implicit operator int?(FhirInteger? fhirInteger)
    {
        return GetValue<FhirInteger>(fhirInteger);
    }

    /// <summary>
    /// Parses an integer value from string.
    /// </summary>
    /// <param name="value">The string to parse.</param>
    /// <returns>The parsed integer value.</returns>
    protected override int? ParseValueFromString(string value)
    {
        if (int.TryParse(value, out var result))
        {
            return result;
        }
        return null;
    }

    /// <summary>
    /// Converts an integer value to string.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The string representation.</returns>
    protected override string? ValueToString(int? value)
    {
        return value?.ToString();
    }

    /// <summary>
    /// Validates the integer value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The integer value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateValue(int value)
    {
        return true; // 整數沒有額外驗證規則
    }
}
