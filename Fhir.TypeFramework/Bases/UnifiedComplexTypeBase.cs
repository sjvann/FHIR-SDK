using Fhir.TypeFramework.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.Bases;

/// <summary>
/// 統一 Complex Type 基礎類別
/// 提供所有 Complex Type 的通用實作，使用泛型支援不同型別
/// </summary>
/// <typeparam name="TSelf">自身型別</typeparam>
/// <remarks>
/// 這個統一的基礎類別可以取代：
/// - ComplexTypeBase
/// 
/// 提供統一的：
/// - 深層複製邏輯
/// - 相等比較邏輯
/// - 驗證框架
/// - 型別安全的泛型約束
/// </remarks>
public abstract class UnifiedComplexTypeBase<TSelf> : Element
    where TSelf : UnifiedComplexTypeBase<TSelf>, new()
{
    /// <summary>
    /// 深層複製
    /// </summary>
    /// <returns>深層複製的實例</returns>
    public override Base DeepCopy()
    {
        var copy = new TSelf();
        CopyFieldsTo(copy);
        return copy;
    }

    /// <summary>
    /// 比較是否完全相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果完全相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not TSelf o) return false;
        return FieldsAreExactly(o);
    }

    /// <summary>
    /// 驗證
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        return ValidateFields(validationContext);
    }

    /// <summary>
    /// 複製欄位到目標（子類別必須實作）
    /// </summary>
    /// <param name="target">目標物件</param>
    protected abstract void CopyFieldsTo(TSelf target);

    /// <summary>
    /// 比較欄位是否完全相等（子類別必須實作）
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果欄位完全相等則為 true，否則為 false</returns>
    protected abstract bool FieldsAreExactly(TSelf other);

    /// <summary>
    /// 驗證欄位（子類別必須實作）
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    protected abstract IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext);
} 