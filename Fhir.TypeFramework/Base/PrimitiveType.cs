using Fhir.TypeFramework.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.Base;

/// <summary>
/// PrimitiveType - 基本型別基礎類別
/// 所有 FHIR 基本型別的基礎
/// </summary>
/// <remarks>
/// FHIR R5 PrimitiveType (Abstract)
/// Base definition for all primitive types in FHIR.
/// PrimitiveType 繼承自 DataType，因此具有 id 和 extension 屬性
/// </remarks>
public abstract class PrimitiveType : DataType
{
    /// <summary>
    /// 基本型別的原始值
    /// </summary>
    public abstract object? Value { get; set; }

    /// <summary>
    /// 取得字串表示
    /// </summary>
    /// <returns>基本型別的字串表示</returns>
    public abstract string? ToString();

    /// <summary>
    /// 從字串解析
    /// </summary>
    /// <param name="value">要解析的字串值</param>
    public abstract void FromString(string? value);

    /// <summary>
    /// 判斷與另一個 PrimitiveType 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not PrimitiveType otherPrimitive)
            return false;

        // 先檢查 DataType 的相等性（包括 id 和 extension）
        if (!base.IsExactly(other))
            return false;

        // 檢查值的相等性
        return Equals(Value, otherPrimitive.Value);
    }

    /// <summary>
    /// 驗證 PrimitiveType 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 基本型別必須有值
        if (Value == null)
        {
            yield return new ValidationResult("PrimitiveType must have a value");
        }

        // 呼叫 DataType 的驗證（包括 id 和 extension 驗證）
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 