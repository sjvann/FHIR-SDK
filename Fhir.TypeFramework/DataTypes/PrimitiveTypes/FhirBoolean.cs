using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// 布林型別
/// 代表規範中的 boolean 型別，為 true/false 值
/// </summary>
/// <remarks>
/// 這個型別提供：
/// - 布林值的儲存和驗證
/// - 隱含轉換支援
/// - Extension 功能
/// - 深層複製和相等性比較
/// 
/// 使用範例：
/// <code>
/// var fhirBoolean = new FhirBoolean(true);
/// var value = fhirBoolean.Value; // true
/// </code>
/// 
/// 驗證規則：
/// - 支援 true 和 false 值
/// - 支援 Extension
/// 
/// JSON 表示：
/// - 簡化格式："active" : true
/// - 完整格式："active" : true, "_active" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirBoolean : UnifiedPrimitiveTypeBase<bool>
{
    /// <summary>
    /// Gets or sets the boolean value.
    /// </summary>
    [JsonIgnore]
    public bool? BooleanValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirBoolean class.
    /// </summary>
    public FhirBoolean() { }

    /// <summary>
    /// Initializes a new instance of the FhirBoolean class with the specified value.
    /// </summary>
    /// <param name="value">The boolean value.</param>
    public FhirBoolean(bool? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a bool to a FhirBoolean.
    /// </summary>
    /// <param name="value">The bool value to convert.</param>
    /// <returns>A FhirBoolean instance, or null if the value is null.</returns>
    public static implicit operator FhirBoolean?(bool? value)
    {
        return CreateFromValue<FhirBoolean>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirBoolean to a bool.
    /// </summary>
    /// <param name="fhirBoolean">The FhirBoolean to convert.</param>
    /// <returns>The bool value, or null if the FhirBoolean is null.</returns>
    public static implicit operator bool?(FhirBoolean? fhirBoolean)
    {
        return GetValue<FhirBoolean>(fhirBoolean);
    }

    /// <summary>
    /// Parses a boolean value from string.
    /// </summary>
    /// <param name="value">The string to parse.</param>
    /// <returns>The parsed boolean value.</returns>
    protected override bool? ParseValueFromString(string value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        
        return value.ToLowerInvariant() switch
        {
            "true" or "1" or "yes" or "on" => true,
            "false" or "0" or "no" or "off" => false,
            _ => null
        };
    }

    /// <summary>
    /// Converts a boolean value to string.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The string representation.</returns>
    protected override string? ValueToString(bool? value)
    {
        return value?.ToString().ToLowerInvariant();
    }

    /// <summary>
    /// Validates the boolean value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The boolean value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateValue(bool value)
    {
        return true; // 布林值沒有額外驗證規則
    }
}


