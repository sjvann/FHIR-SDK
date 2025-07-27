using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Base;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR integer primitive type.
/// A whole number.
/// </summary>
/// <remarks>
/// FHIR R5 integer PrimitiveType
/// 32-bit integer; for values larger than this, use decimal.
/// 
/// JSON Representation:
/// - Simple: "count" : 42
/// - Full: "count" : 42, "_count" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirInteger : PrimitiveTypeBase<int>
{
    /// <summary>
    /// Initializes a new instance of the FhirInteger class.
    /// </summary>
    public FhirInteger() { }
    
    /// <summary>
    /// Initializes a new instance of the FhirInteger class with the specified value.
    /// </summary>
    /// <param name="value">The integer value.</param>
    public FhirInteger(int value)
    {
        Value = value;
    }
    
    /// <summary>
    /// Implicitly converts an int to a FhirInteger.
    /// </summary>
    /// <param name="value">The int value to convert.</param>
    /// <returns>A FhirInteger instance.</returns>
    public static implicit operator FhirInteger(int value)
    {
        return new FhirInteger(value);
    }
    
    /// <summary>
    /// Implicitly converts a FhirInteger to an int.
    /// </summary>
    /// <param name="fhirInteger">The FhirInteger to convert.</param>
    /// <returns>The int value.</returns>
    public static implicit operator int(FhirInteger fhirInteger)
    {
        return fhirInteger.Value ?? 0;
    }
    
    /// <summary>
    /// 從字串解析值
    /// </summary>
    public override int? ParseValue(string value)
    {
        if (int.TryParse(value, out int result))
            return result;
        return null;
    }
    
    /// <summary>
    /// 將值轉換為字串
    /// </summary>
    public override string? ValueToString(int? value)
    {
        return value?.ToString();
    }
    
    /// <summary>
    /// 驗證值是否符合 FHIR 規範
    /// </summary>
    public override bool IsValidValue(int? value)
    {
        // 32-bit integer 範圍檢查
        return value >= int.MinValue && value <= int.MaxValue;
    }
    
    /// <summary>
    /// 驗證 FhirInteger 是否符合 FHIR R5 規範
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證整數範圍
        if (Value.HasValue && (Value.Value < int.MinValue || Value.Value > int.MaxValue))
        {
            yield return new ValidationResult("Integer value is out of range for 32-bit integer");
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 