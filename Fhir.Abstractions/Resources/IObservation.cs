namespace Fhir.Abstractions.Resources;

/// <summary>
/// Observation 資源的共通介面
/// 定義所有 FHIR 版本中 Observation 的共通屬性
/// </summary>
public interface IObservation : IDomainResource
{
    /// <summary>
    /// 觀察狀態
    /// </summary>
    string? Status { get; set; }
    
    /// <summary>
    /// 觀察項目代碼
    /// </summary>
    object? Code { get; set; }
    
    /// <summary>
    /// 觀察對象（通常是 Patient）
    /// </summary>
    object? Subject { get; set; }
    
    /// <summary>
    /// 觀察值
    /// 使用 object 以支援不同類型的值（Quantity, string, boolean 等）
    /// </summary>
    object? Value { get; set; }
    
    /// <summary>
    /// 觀察時間
    /// </summary>
    string? EffectiveDateTime { get; set; }
    
    /// <summary>
    /// 執行觀察的人員或組織
    /// </summary>
    IList<object>? Performer { get; set; }
    
    /// <summary>
    /// 參考範圍
    /// </summary>
    IList<object>? ReferenceRange { get; set; }
}
