using System.ComponentModel.DataAnnotations;

namespace Fhir.Abstractions;

/// <summary>
/// 所有 FHIR 資源的基礎介面
/// 定義所有版本共通的核心屬性
/// </summary>
public interface IResource
{
    /// <summary>
    /// 資源的邏輯 ID
    /// </summary>
    string? Id { get; set; }
    
    /// <summary>
    /// 資源類型名稱
    /// </summary>
    string ResourceType { get; }
    
    /// <summary>
    /// 驗證資源是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
}

/// <summary>
/// 領域資源的基礎介面
/// 包含文字敘述和擴充功能
/// </summary>
public interface IDomainResource : IResource
{
    /// <summary>
    /// 資源的文字敘述
    /// </summary>
    object? Text { get; set; }
    
    /// <summary>
    /// 擴充功能
    /// </summary>
    IList<object>? Extension { get; set; }
    
    /// <summary>
    /// 修飾擴充功能
    /// </summary>
    IList<object>? ModifierExtension { get; set; }
}
