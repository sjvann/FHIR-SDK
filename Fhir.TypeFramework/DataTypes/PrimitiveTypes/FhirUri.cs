using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Base;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR uri primitive type.
/// A Uniform Resource Identifier Reference.
/// </summary>
/// <remarks>
/// FHIR R5 uri PrimitiveType
/// A Uniform Resource Identifier Reference.
/// 
/// JSON Representation:
/// - Simple: "url" : "http://example.com/resource"
/// - Full: "url" : "http://example.com/resource", "_url" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirUri : PrimitiveTypeBase<string>
{
    /// <summary>
    /// Initializes a new instance of the FhirUri class.
    /// </summary>
    public FhirUri() { }
    
    /// <summary>
    /// Initializes a new instance of the FhirUri class with the specified value.
    /// </summary>
    /// <param name="value">The URI value.</param>
    public FhirUri(string? value)
    {
        Value = value;
    }
    
    /// <summary>
    /// Implicitly converts a string to a FhirUri.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirUri instance, or null if the value is null.</returns>
    public static implicit operator FhirUri?(string? value)
    {
        return value == null ? null : new FhirUri(value);
    }
    
    /// <summary>
    /// Implicitly converts a FhirUri to a string.
    /// </summary>
    /// <param name="fhirUri">The FhirUri to convert.</param>
    /// <returns>The string value, or null if the FhirUri is null.</returns>
    public static implicit operator string?(FhirUri? fhirUri)
    {
        return fhirUri?.Value;
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
            
        // 驗證 URI 格式
        return Uri.IsWellFormedUriString(value, UriKind.Absolute) || 
               Uri.IsWellFormedUriString(value, UriKind.Relative);
    }
    
    /// <summary>
    /// 驗證 FhirUri 是否符合 FHIR R5 規範
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 URI 格式
        if (Value != null && !IsValidValue(Value))
        {
            yield return new ValidationResult($"URI '{Value}' is not a valid URI format");
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 