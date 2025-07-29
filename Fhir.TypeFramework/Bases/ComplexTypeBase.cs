using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.Bases;

/// <summary>
/// Complex Type 基礎類別
/// 提供所有 Complex Type 的通用實作
/// </summary>
/// <remarks>
/// 這個基礎類別提供：
/// - 統一的深層複製邏輯
/// - 統一的相等性比較
/// - 基礎驗證框架
/// - 擴展功能管理
/// </remarks>
public abstract class ComplexTypeBase : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 預設建構函式
    /// </summary>
    protected ComplexTypeBase() { }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>ComplexTypeBase 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = (ComplexTypeBase)MemberwiseClone();
        
        // 深層複製擴展
        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }
        
        // 呼叫子類別的深層複製邏輯
        DeepCopyInternal(copy);
        
        return copy;
    }

    /// <summary>
    /// 判斷與另一個物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not ComplexTypeBase otherComplex)
            return false;

        return base.IsExactly(other) && IsExactlyInternal(otherComplex);
    }

    /// <summary>
    /// 驗證 ComplexTypeBase 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }

        // 呼叫子類別的驗證邏輯
        foreach (var result in ValidateInternal(validationContext))
        {
            yield return result;
        }
    }

    // ============================================================================
    // 抽象方法 - 子類別必須實作
    // ============================================================================

    /// <summary>
    /// 深層複製內部邏輯
    /// </summary>
    /// <param name="copy">要複製的目標物件</param>
    protected abstract void DeepCopyInternal(ComplexTypeBase copy);

    /// <summary>
    /// 相等性比較內部邏輯
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果相等則為 true，否則為 false</returns>
    protected abstract bool IsExactlyInternal(ComplexTypeBase other);

    /// <summary>
    /// 驗證內部邏輯
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    protected abstract IEnumerable<ValidationResult> ValidateInternal(ValidationContext validationContext);

    // ============================================================================
    // 通用輔助方法
    // ============================================================================

    /// <summary>
    /// 深層複製列表
    /// </summary>
    /// <typeparam name="T">列表元素型別</typeparam>
    /// <param name="source">來源列表</param>
    /// <returns>深層複製的列表</returns>
    protected static IList<T>? DeepCopyList<T>(IList<T>? source) where T : Base
    {
        // 使用效能優化器（如果可用）
        try
        {
            return Fhir.TypeFramework.Performance.DeepCopyOptimizer.OptimizedDeepCopyList(source);
        }
        catch
        {
            // 回退到原有邏輯
            if (source == null) return null;
            return source.Select(item => item.DeepCopy() as T).ToList();
        }
    }

    /// <summary>
    /// 比較兩個列表是否相等
    /// </summary>
    /// <typeparam name="T">列表元素型別</typeparam>
    /// <param name="list1">第一個列表</param>
    /// <param name="list2">第二個列表</param>
    /// <returns>如果相等則為 true，否則為 false</returns>
    protected static bool AreListsEqual<T>(IList<T>? list1, IList<T>? list2) where T : Base
    {
        if (list1 == null && list2 == null) return true;
        if (list1 == null || list2 == null) return false;
        if (list1.Count != list2.Count) return false;
        
        return list1.Zip(list2, (a, b) => a.IsExactly(b)).All(x => x);
    }

    /// <summary>
    /// 驗證列表中的所有元素
    /// </summary>
    /// <typeparam name="T">列表元素型別</typeparam>
    /// <param name="list">要驗證的列表</param>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    protected static IEnumerable<ValidationResult> ValidateList<T>(IList<T>? list, ValidationContext validationContext) where T : Base
    {
        if (list == null) yield break;
        
        foreach (var item in list)
        {
            var itemValidationContext = new ValidationContext(item);
            foreach (var result in item.Validate(itemValidationContext))
            {
                yield return result;
            }
        }
    }

    /// <summary>
    /// 驗證單一元素
    /// </summary>
    /// <typeparam name="T">元素型別</typeparam>
    /// <param name="item">要驗證的元素</param>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    protected static IEnumerable<ValidationResult> ValidateItem<T>(T? item, ValidationContext validationContext) where T : Base
    {
        if (item == null) yield break;
        
        var itemValidationContext = new ValidationContext(item);
        foreach (var result in item.Validate(itemValidationContext))
        {
            yield return result;
        }
    }
} 