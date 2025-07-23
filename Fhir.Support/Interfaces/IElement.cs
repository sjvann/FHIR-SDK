namespace Fhir.Support.Interfaces;

/// <summary>
/// 代表一個 FHIR 元素，所有具有 `id` 和 `extension` 的 FHIR 型別都應實作此介面。
/// </summary>
public interface IElement : IBase
{
    /// <summary>
    /// 元素的 XML Id。
    /// </summary>
    string? ElementId { get; set; }

    /// <summary>
    /// 元素的擴展。
    /// </summary>
    List<IExtension>? Extension { get; set; }
}

/// <summary>
/// 代表一個 FHIR 擴展元素。
/// </summary>
public interface IExtension : IElement
{
    /// <summary>
    /// 擴展的 URL。
    /// </summary>
    string Url { get; set; }
} 