using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Base;

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
/// </remarks>
public class FhirString : PrimitiveTypeBase<string>
{
    /// <summary>
    /// Initializes a new instance of the FhirString class.
    /// </summary>
    public FhirString() { }
    
    /// <summary>
    /// Initializes a new instance of the FhirString class with the specified value.
    /// </summary>
    /// <param name="value">The string value.</param>
    public FhirString(string? value)
    {
        Value = value;
    }
    
    /// <summary>
    /// Implicitly converts a string to a FhirString.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirString instance, or null if the value is null.</returns>
    public static implicit operator FhirString?(string? value)
    {
        return value == null ? null : new FhirString(value);
    }
    
    /// <summary>
    /// Implicitly converts a FhirString to a string.
    /// </summary>
    /// <param name="fhirString">The FhirString to convert.</param>
    /// <returns>The string value, or null if the FhirString is null.</returns>
    public static implicit operator string?(FhirString? fhirString)
    {
        return fhirString?.Value;
    }
    
    /// <summary>
    /// 從字串解析值
    /// </summary>
    public override string? ParseValue(string value)
    {
        return value;
    }
    
    /// <summary>
    /// 將值轉換為字串
    /// </summary>
    public override string? ValueToString(string? value)
    {
        return value;
    }
    
    /// <summary>
    /// 驗證值是否符合 FHIR 規範
    /// </summary>
    public override bool IsValidValue(string? value)
    {
        if (string.IsNullOrEmpty(value))
            return true; // 空值是有效的
            
        // FHIR string cannot exceed 1MB
        return System.Text.Encoding.UTF8.GetByteCount(value) <= 1024 * 1024;
    }
    
    /// <summary>
    /// 驗證 FhirString 是否符合 FHIR R5 規範
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證字串長度
        if (Value != null && System.Text.Encoding.UTF8.GetByteCount(Value) > 1024 * 1024)
        {
            yield return new ValidationResult("String value cannot exceed 1MB in size");
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
}
