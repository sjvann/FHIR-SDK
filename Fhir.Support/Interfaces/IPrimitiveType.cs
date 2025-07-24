using System.Text.Json.Nodes;

namespace Fhir.Support.Interfaces;

/// <summary>
/// FHIR 原始型別介面
/// </summary>
public interface IPrimitiveType : IDataType
{
    /// <summary>
    /// 取得值
    /// </summary>
    object? GetValue();

    /// <summary>
    /// 檢查是否有值
    /// </summary>
    bool HasValue { get; }

    /// <summary>
    /// 檢查是否為空
    /// </summary>
    bool IsEmpty { get; }

    /// <summary>
    /// 檢查是否有元素
    /// </summary>
    bool HasElement();

    /// <summary>
    /// 取得 JSON 值
    /// </summary>
    JsonValue? GetJsonValue();

    /// <summary>
    /// 取得元素 JSON 物件
    /// </summary>
    JsonObject? GetElementJsonObject();

    /// <summary>
    /// 取得元素 JSON 字串
    /// </summary>
    string GetElementJsonString();

    /// <summary>
    /// 值相等比較
    /// </summary>
    bool ValueEquals(object? other);
} 