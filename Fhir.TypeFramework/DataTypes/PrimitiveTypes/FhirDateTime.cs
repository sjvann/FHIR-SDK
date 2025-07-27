using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Base;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR dateTime primitive type.
/// A date, date-time or partial date (e.g. just year or year + month).
/// </summary>
/// <remarks>
/// FHIR R5 dateTime PrimitiveType
/// A date, date-time or partial date (e.g. just year or year + month).
/// 
/// JSON Representation:
/// - Simple: "date" : "2023-12-25T10:30:00Z"
/// - Full: "date" : "2023-12-25T10:30:00Z", "_date" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirDateTime : PrimitiveTypeBase<DateTime>
{
    /// <summary>
    /// Initializes a new instance of the FhirDateTime class.
    /// </summary>
    public FhirDateTime() { }
    
    /// <summary>
    /// Initializes a new instance of the FhirDateTime class with the specified value.
    /// </summary>
    /// <param name="value">The DateTime value.</param>
    public FhirDateTime(DateTime value)
    {
        Value = value;
    }
    
    /// <summary>
    /// Implicitly converts a DateTime to a FhirDateTime.
    /// </summary>
    /// <param name="value">The DateTime value to convert.</param>
    /// <returns>A FhirDateTime instance.</returns>
    public static implicit operator FhirDateTime(DateTime value)
    {
        return new FhirDateTime(value);
    }
    
    /// <summary>
    /// Implicitly converts a FhirDateTime to a DateTime.
    /// </summary>
    /// <param name="fhirDateTime">The FhirDateTime to convert.</param>
    /// <returns>The DateTime value.</returns>
    public static implicit operator DateTime(FhirDateTime fhirDateTime)
    {
        return fhirDateTime.Value ?? DateTime.MinValue;
    }
    
    /// <summary>
    /// 從字串解析值
    /// </summary>
    public override DateTime? ParseValue(string value)
    {
        if (DateTime.TryParse(value, out DateTime result))
            return result;
        return null;
    }
    
    /// <summary>
    /// 將值轉換為字串
    /// </summary>
    public override string? ValueToString(DateTime? value)
    {
        return value?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
    }
    
    /// <summary>
    /// 驗證值是否符合 FHIR 規範
    /// </summary>
    public override bool IsValidValue(DateTime? value)
    {
        // DateTime 型別本身就是有效的
        return true;
    }
    
    /// <summary>
    /// 驗證 FhirDateTime 是否符合 FHIR R5 規範
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