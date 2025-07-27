using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Base;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR decimal primitive type.
/// A rational number with implicit precision.
/// </summary>
/// <remarks>
/// FHIR R5 decimal PrimitiveType
/// A rational number with implicit precision.
/// 
/// JSON Representation:
/// - Simple: "value" : 123.45
/// - Full: "value" : 123.45, "_value" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirDecimal : PrimitiveTypeBase<decimal>
{
    /// <summary>
    /// Initializes a new instance of the FhirDecimal class.
    /// </summary>
    public FhirDecimal() { }
    
    /// <summary>
    /// Initializes a new instance of the FhirDecimal class with the specified value.
    /// </summary>
    /// <param name="value">The decimal value.</param>
    public FhirDecimal(decimal value)
    {
        Value = value;
    }
    
    /// <summary>
    /// Implicitly converts a decimal to a FhirDecimal.
    /// </summary>
    /// <param name="value">The decimal value to convert.</param>
    /// <returns>A FhirDecimal instance.</returns>
    public static implicit operator FhirDecimal(decimal value)
    {
        return new FhirDecimal(value);
    }
    
    /// <summary>
    /// Implicitly converts a FhirDecimal to a decimal.
    /// </summary>
    /// <param name="fhirDecimal">The FhirDecimal to convert.</param>
    /// <returns>The decimal value.</returns>
    public static implicit operator decimal(FhirDecimal fhirDecimal)
    {
        return fhirDecimal.Value ?? 0m;
    }
    
    /// <summary>
    /// 從字串解析值
    /// </summary>
    public override decimal? ParseValue(string value)
    {
        if (decimal.TryParse(value, out decimal result))
            return result;
        return null;
    }
    
    /// <summary>
    /// 將值轉換為字串
    /// </summary>
    public override string? ValueToString(decimal? value)
    {
        return value?.ToString("G29"); // 使用 G29 格式避免科學記號
    }
    
    /// <summary>
    /// 驗證值是否符合 FHIR 規範
    /// </summary>
    public override bool IsValidValue(decimal? value)
    {
        // decimal 型別本身就是有效的
        return true;
    }
    
    /// <summary>
    /// 驗證 FhirDecimal 是否符合 FHIR R5 規範
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 