using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Base;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// FHIR boolean primitive type.
/// true | false
/// </summary>
/// <remarks>
/// FHIR R5 boolean PrimitiveType
/// Note that 0 and 1 are not valid values in FHIR.
/// 
/// JSON Representation:
/// - Simple: "active" : true
/// - Full: "active" : true, "_active" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirBoolean : PrimitiveTypeBase<bool>
{
    /// <summary>
    /// Initializes a new instance of the FhirBoolean class.
    /// </summary>
    public FhirBoolean() { }
    
    /// <summary>
    /// Initializes a new instance of the FhirBoolean class with the specified value.
    /// </summary>
    /// <param name="value">The boolean value.</param>
    public FhirBoolean(bool value)
    {
        Value = value;
    }
    
    /// <summary>
    /// Implicitly converts a bool to a FhirBoolean.
    /// </summary>
    /// <param name="value">The bool value to convert.</param>
    /// <returns>A FhirBoolean instance.</returns>
    public static implicit operator FhirBoolean(bool value)
    {
        return new FhirBoolean(value);
    }
    
    /// <summary>
    /// Implicitly converts a FhirBoolean to a bool.
    /// </summary>
    /// <param name="fhirBoolean">The FhirBoolean to convert.</param>
    /// <returns>The bool value.</returns>
    public static implicit operator bool(FhirBoolean fhirBoolean)
    {
        return fhirBoolean.Value ?? false;
    }
    
    /// <summary>
    /// 從字串解析值
    /// </summary>
    public override bool? ParseValue(string value)
    {
        if (bool.TryParse(value, out bool result))
            return result;
        return null;
    }
    
    /// <summary>
    /// 將值轉換為字串
    /// </summary>
    public override string? ValueToString(bool? value)
    {
        return value?.ToString().ToLower();
    }
    
    /// <summary>
    /// 驗證值是否符合 FHIR 規範
    /// </summary>
    public override bool IsValidValue(bool? value)
    {
        // FHIR boolean 只接受 true 或 false，不接受 0 或 1
        return true; // bool 型別本身就是有效的
    }
    
    /// <summary>
    /// 驗證 FhirBoolean 是否符合 FHIR R5 規範
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
