using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.DataTypes.PrimitiveTypes;

/// <summary>
/// FHIR Primitive Type: id
/// </summary>
/// <remarks>
/// FHIR R5 id PrimitiveType
/// Any combination of letters, numerals, "-" and ".", with a length limit of 64 characters.
/// 
/// JSON Representation:
/// - Simple: "id" : "patient-123"
/// - Full: "id" : "patient-123", "_id" : { "id" : "a1", "extension" : [...] }
/// </remarks>
public class FhirId : PrimitiveTypeBase<string>
{
    /// <summary>
    /// Initializes a new instance of the FhirId class.
    /// </summary>
    public FhirId() { }

    /// <summary>
    /// Initializes a new instance of the FhirId class with the specified value.
    /// </summary>
    /// <param name="value">The id value.</param>
    public FhirId(string? value) : base(value) { }

    /// <summary>
    /// Implicitly converts a string to a FhirId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirId instance.</returns>
    public static implicit operator FhirId(string? value) => new(value);

    /// <summary>
    /// Implicitly converts a FhirId to a string.
    /// </summary>
    /// <param name="fhirValue">The FhirId to convert.</param>
    /// <returns>The string value.</returns>
    public static implicit operator string?(FhirId fhirValue) => fhirValue?.Value;

    /// <summary>
    /// 從字串解析值
    /// </summary>
    /// <param name="value">要解析的字串</param>
    /// <returns>解析後的值</returns>
    public override string? ParseValue(string? value)
    {
        return value;
    }

    /// <summary>
    /// 將值轉換為字串
    /// </summary>
    /// <param name="value">要轉換的值</param>
    /// <returns>值的字串表示</returns>
    public override string? ValueToString(string? value)
    {
        return value;
    }

    /// <summary>
    /// 驗證值是否符合 FHIR 規範
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    public override bool IsValidValue(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        return value.Length <= 64; // FHIR R5: id has a maximum length of 64 characters
    }

    /// <summary>
    /// 驗證 FhirId 是否符合 FHIR R5 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (!string.IsNullOrEmpty(Value) && Value.Length > 64)
        {
            yield return new ValidationResult("Id value cannot exceed 64 characters");
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 