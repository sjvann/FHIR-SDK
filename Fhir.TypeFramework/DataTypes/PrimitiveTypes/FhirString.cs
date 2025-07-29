using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// 字串型別
/// 代表規範中的 string 型別，為 Unicode 字元序列
/// </summary>
/// <remarks>
/// 這個型別提供：
/// - 字串值的儲存和驗證
/// - 隱含轉換支援
/// - Extension 功能
/// - 深層複製和相等性比較
/// 
/// 使用範例：
/// <code>
/// var fhirString = new FhirString("Hello World");
/// var value = fhirString.Value; // "Hello World"
/// </code>
/// 
/// 驗證規則：
/// - 最大長度：1,048,576 字元
/// - 支援 UTF-8 編碼
/// 
/// JSON 表示：
/// - 簡化格式："count" : "Hello World"
/// - 完整格式："count" : "Hello World", "_count" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirString : UnifiedPrimitiveTypeBase<string>
{
    /// <summary>
    /// Gets or sets the string value.
    /// </summary>
    [JsonIgnore]
    public string? StringValue { get => Value; set => Value = value; }

    /// <summary>
    /// Initializes a new instance of the FhirString class.
    /// </summary>
    public FhirString() { }

    /// <summary>
    /// Initializes a new instance of the FhirString class with the specified value.
    /// </summary>
    /// <param name="value">The string value.</param>
    public FhirString(string? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a string to a FhirString.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirString instance, or null if the value is null.</returns>
    public static implicit operator FhirString?(string? value)
    {
        return CreateFromString<FhirString>(value);
    }

    /// <summary>
    /// Implicitly converts a FhirString to a string.
    /// </summary>
    /// <param name="fhirString">The FhirString to convert.</param>
    /// <returns>The string value, or null if the FhirString is null.</returns>
    public static implicit operator string?(FhirString? fhirString)
    {
        return GetStringValue<FhirString>(fhirString);
    }

    /// <summary>
    /// Parses a string value from string.
    /// </summary>
    /// <param name="value">The string to parse.</param>
    /// <returns>The parsed string value.</returns>
    protected override string? ParseValueFromString(string value)
    {
        return value;
    }

    /// <summary>
    /// Converts a string value to string.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The string representation.</returns>
    protected override string? ValueToString(string? value)
    {
        return value;
    }

    /// <summary>
    /// Validates the string value according to FHIR specifications.
    /// </summary>
    /// <param name="value">The string value to validate.</param>
    /// <returns>True if the value is valid; otherwise, false.</returns>
    protected override bool ValidateValue(string value)
    {
        return ValidationFramework.ValidateStringByteSize(value, 1024 * 1024);
    }
}
