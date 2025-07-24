using System.Text.Json.Nodes;

namespace Fhir.Support.Interfaces;

/// <summary>
/// FHIR 選擇型別介面
/// </summary>
public interface IChoiceType : IDataType
{
    /// <summary>
    /// 取得屬性
    /// </summary>
    KeyValuePair<string, JsonNode?> GetProperty();

    /// <summary>
    /// 取得前綴名稱
    /// </summary>
    string GetPrefixName(bool withCapital = true);

    /// <summary>
    /// 取得目前鍵名稱
    /// </summary>
    string? GetCurrentKeyName();

    /// <summary>
    /// 取得目前值節點
    /// </summary>
    JsonNode? GetCurrentValueNode();

    /// <summary>
    /// 取得資料型別名稱
    /// </summary>
    string GetDataTypeName();

    /// <summary>
    /// 取得值
    /// </summary>
    string? GetValue();

    /// <summary>
    /// 取得支援的資料型別
    /// </summary>
    List<string>? GetSupportDataType();

    /// <summary>
    /// 設定支援的資料型別
    /// </summary>
    List<string> SetSupportDataType();
} 