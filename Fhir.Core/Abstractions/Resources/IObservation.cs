using System.ComponentModel.DataAnnotations;

namespace Fhir.Core.Abstractions.Resources;

/// <summary>
/// Observation 資源的抽象介面
/// 定義所有版本的 Observation 共通屬性
/// </summary>
public interface IObservation : IDomainResource
{
    /// <summary>
    /// 觀察狀態
    /// </summary>
    string? Status { get; set; }
    
    /// <summary>
    /// 觀察類別
    /// </summary>
    IList<object>? Category { get; set; }
    
    /// <summary>
    /// 觀察代碼
    /// </summary>
    object? Code { get; set; }
    
    /// <summary>
    /// 觀察對象
    /// </summary>
    object? Subject { get; set; }
    
    /// <summary>
    /// 觀察值
    /// </summary>
    object? Value { get; set; }
    
    /// <summary>
    /// 觀察時間
    /// </summary>
    object? Effective { get; set; }
}
