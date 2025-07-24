namespace Fhir.Support.Interfaces;

/// <summary>
/// 代表一個 FHIR Narrative 元素
/// </summary>
public interface INarrative : IElement
{
    /// <summary>
    /// 敘述狀態
    /// </summary>
    string? Status { get; set; }

    /// <summary>
    /// 敘述內容
    /// </summary>
    string? Div { get; set; }
} 