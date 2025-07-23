using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// Element 的具體實現類別，可以被實例化
/// 用於需要創建 Element 實例但不需要特定子類別的場景
/// </summary>
public class ElementImpl : Element
{
    /// <summary>
    /// 建構函式
    /// </summary>
    public ElementImpl() { }

    /// <summary>
    /// 建構函式
    /// </summary>
    /// <param name="elementId">元素 ID</param>
    public ElementImpl(string? elementId)
    {
        ElementId = elementId;
    }

    /// <summary>
    /// 建構函式
    /// </summary>
    /// <param name="elementId">元素 ID</param>
    /// <param name="extensions">擴展列表</param>
    public ElementImpl(string? elementId, List<IExtension>? extensions)
    {
        ElementId = elementId;
        Extension = extensions;
    }

    /// <summary>
    /// 創建一個新的 ElementImpl 實例
    /// </summary>
    /// <returns>新的 ElementImpl 實例</returns>
    public static ElementImpl Create() => new();

    /// <summary>
    /// 創建一個帶有 ID 的 ElementImpl 實例
    /// </summary>
    /// <param name="elementId">元素 ID</param>
    /// <returns>新的 ElementImpl 實例</returns>
    public static ElementImpl Create(string elementId) => new(elementId);

    /// <summary>
    /// 創建一個帶有 ID 和擴展的 ElementImpl 實例
    /// </summary>
    /// <param name="elementId">元素 ID</param>
    /// <param name="extensions">擴展列表</param>
    /// <returns>新的 ElementImpl 實例</returns>
    public static ElementImpl Create(string elementId, List<IExtension> extensions) => new(elementId, extensions);
}

/// <summary>
/// DataType 的具體實現類別，可以被實例化
/// 用於需要創建 DataType 實例但不需要特定子類別的場景
/// </summary>
public class DataTypeImpl : DataType
{
    /// <summary>
    /// 建構函式
    /// </summary>
    public DataTypeImpl() { }

    /// <summary>
    /// 建構函式
    /// </summary>
    /// <param name="elementId">元素 ID</param>
    public DataTypeImpl(string? elementId)
    {
        ElementId = elementId;
    }

    /// <summary>
    /// 創建一個新的 DataTypeImpl 實例
    /// </summary>
    /// <returns>新的 DataTypeImpl 實例</returns>
    public static DataTypeImpl Create() => new();

    /// <summary>
    /// 創建一個帶有 ID 的 DataTypeImpl 實例
    /// </summary>
    /// <param name="elementId">元素 ID</param>
    /// <returns>新的 DataTypeImpl 實例</returns>
    public static DataTypeImpl Create(string elementId) => new(elementId);
}

/// <summary>
/// Extension 的具體實現類別，實現 IExtension 介面
/// </summary>
public class ExtensionImpl : Element, IExtension
{
    /// <summary>
    /// 擴展的 URL
    /// </summary>
    [JsonPropertyName("url")]
    [Required]
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// 擴展的值（可以是任何型別）
    /// </summary>
    [JsonPropertyName("value")]
    public object? Value { get; set; }

    /// <summary>
    /// 巢狀擴展
    /// </summary>
    [JsonPropertyName("extension")]
    public List<IExtension>? NestedExtension { get; set; }

    /// <summary>
    /// 建構函式
    /// </summary>
    public ExtensionImpl() { }

    /// <summary>
    /// 建構函式
    /// </summary>
    /// <param name="url">擴展 URL</param>
    public ExtensionImpl(string url)
    {
        Url = url ?? throw new ArgumentNullException(nameof(url));
    }

    /// <summary>
    /// 建構函式
    /// </summary>
    /// <param name="url">擴展 URL</param>
    /// <param name="value">擴展值</param>
    public ExtensionImpl(string url, object? value)
    {
        Url = url ?? throw new ArgumentNullException(nameof(url));
        Value = value;
    }

    /// <summary>
    /// 創建一個新的 Extension
    /// </summary>
    /// <param name="url">擴展 URL</param>
    /// <returns>新的 Extension 實例</returns>
    public static ExtensionImpl Create(string url) => new(url);

    /// <summary>
    /// 創建一個帶值的 Extension
    /// </summary>
    /// <param name="url">擴展 URL</param>
    /// <param name="value">擴展值</param>
    /// <returns>新的 Extension 實例</returns>
    public static ExtensionImpl Create(string url, object value) => new(url, value);

    /// <summary>
    /// 檢查是否有值
    /// </summary>
    public bool HasValue => Value != null;

    /// <summary>
    /// 檢查是否有巢狀擴展
    /// </summary>
    public bool HasNestedExtensions => NestedExtension?.Count > 0;

    /// <summary>
    /// 轉換為字串表示
    /// </summary>
    /// <returns>字串表示</returns>
    public override string ToString()
    {
        if (HasValue)
            return $"{Url}: {Value}";
        if (HasNestedExtensions)
            return $"{Url}: [{NestedExtension!.Count} nested extensions]";
        return Url;
    }
}
