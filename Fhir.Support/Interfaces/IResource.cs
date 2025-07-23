namespace Fhir.Support.Interfaces;

/// <summary>
/// 代表一個 FHIR 資源。所有 Resource 型別都應實作此介面。
/// </summary>
public interface IResource : IBase
{
    /// <summary>
    /// 資源的邏輯 Id。
    /// </summary>
    string? Id { get; set; }

    /// <summary>
    /// 資源的元數據。
    /// </summary>
    IMeta? Meta { get; set; }

    /// <summary>
    /// 隱含的規則。
    /// </summary>
    string? ImplicitRules { get; set; }

    /// <summary>
    /// 資源的語言。
    /// </summary>
    string? Language { get; set; }

    /// <summary>
    /// 取得資源的 FHIR 型態名稱。
    /// </summary>
    string ResourceType { get; }
}

/// <summary>
/// 代表資源的元數據。
/// </summary>
public interface IMeta : IElement
{
    // Meta 的具體屬性將在 Fhir.Core 中由程式碼產生器定義
} 