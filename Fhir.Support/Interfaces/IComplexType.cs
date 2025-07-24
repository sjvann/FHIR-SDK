using System.Text.Json.Nodes;

namespace Fhir.Support.Interfaces;

/// <summary>
/// FHIR 複雜型別介面
/// </summary>
public interface IComplexType : IDataType
{
    /// <summary>
    /// 取得 JSON 物件
    /// </summary>
    JsonObject? GetJsonObject();
} 