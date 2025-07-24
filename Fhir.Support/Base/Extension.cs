using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// FHIR Extension 類別
/// </summary>
public class Extension : Element, IExtension
{
    /// <summary>
    /// Source of the definition for the extension code - a logical name or a URL.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types.
    /// </summary>
    [JsonPropertyName("value")]
    public object? Value { get; set; }

    /// <summary>
    /// 建立新的 Extension 實例
    /// </summary>
    public Extension() { }

    /// <summary>
    /// 建立新的 Extension 實例
    /// </summary>
    /// <param name="url">URL</param>
    /// <param name="value">值</param>
    public Extension(string? url, object? value = null)
    {
        Url = url;
        Value = value;
    }

    /// <summary>
    /// 建立新的 Extension 實例
    /// </summary>
    /// <param name="jsonObject">JSON 物件</param>
    public Extension(JsonObject jsonObject) : base()
    {
        ParseFromJson(jsonObject);
    }

    /// <summary>
    /// 從 JSON 解析
    /// </summary>
    /// <param name="jsonObject">JSON 物件</param>
    protected virtual void ParseFromJson(JsonObject jsonObject)
    {
        // 解析基礎元素屬性
        ParseElementFromJson(jsonObject);

        // 解析 Extension 特定屬性
        if (jsonObject.TryGetPropertyValue("url", out var urlNode))
        {
            Url = urlNode?.ToString();
        }

        if (jsonObject.TryGetPropertyValue("value", out var valueNode))
        {
            Value = valueNode;
        }
    }
} 