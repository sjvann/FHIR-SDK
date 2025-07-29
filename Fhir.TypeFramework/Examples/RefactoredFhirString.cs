using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR string primitive type.
/// A sequence of Unicode characters.
/// </summary>
/// <remarks>
/// FHIR R5 string PrimitiveType
/// Note that strings SHALL NOT exceed 1MB in size.
/// 
/// JSON Representation:
/// - Simple: "count" : "Hello World"
/// - Full: "count" : "Hello World", "_count" : { "id" : "a1", "extension" : [...] }
/// 
/// 重構後使用 StringPrimitiveTypeBase 基礎類別，大幅減少重複程式碼。
/// </remarks>
public class FhirString : StringPrimitiveTypeBase
{
    /// <summary>
    /// 字串值
    /// </summary>
    [JsonIgnore]
    public string? StringValue
    {
        get => Value;
        set => Value = value;
    }

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
        return GetStringValue(fhirString);
    }
    
    /// <summary>
    /// 驗證字串值是否符合 FHIR 規範
    /// </summary>
    /// <param name="value">要驗證的字串值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    protected override bool ValidateStringValue(string? value)
    {
        // 使用統一的驗證框架
        return ValidationFramework.ValidateStringByteSize(value, 1024 * 1024); // 1MB
    }
} 