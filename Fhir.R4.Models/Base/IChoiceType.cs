using System.ComponentModel.DataAnnotations;

namespace Fhir.R4.Models.Base;

/// <summary>
/// Choice Type 的基礎介面
/// 用於處理 FHIR 的 [x] 型別（如 value[x], onset[x]）
/// </summary>
public interface IChoiceType
{
    /// <summary>
    /// 取得或設定 Choice Type 的值
    /// </summary>
    object? Value { get; set; }
    
    /// <summary>
    /// 取得目前設定的值型別名稱
    /// </summary>
    string? ValueTypeName { get; }
    
    /// <summary>
    /// 檢查是否有設定值
    /// </summary>
    bool HasValue { get; }
    
    /// <summary>
    /// 清除所有值
    /// </summary>
    void ClearValue();
    
    /// <summary>
    /// 取得允許的型別列表
    /// </summary>
    string[] GetAllowedTypes();
    
    /// <summary>
    /// 檢查指定型別是否被允許
    /// </summary>
    bool IsAllowedType<T>();
    
    /// <summary>
    /// 檢查指定型別是否被允許
    /// </summary>
    bool IsAllowedType(Type type);
    
    /// <summary>
    /// 驗證 Choice Type 的值
    /// </summary>
    IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
}
