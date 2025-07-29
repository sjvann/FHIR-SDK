using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Fhir.TypeFramework.Abstractions;

/// <summary>
/// FHIR Primitive Type 介面
/// 定義所有 FHIR 基本型別的基本行為
/// </summary>
/// <typeparam name="TValue">對應的程式語言型別</typeparam>
/// <remarks>
/// 提供 FHIR 基本型別的核心功能，包括值存取、字串轉換、JSON 序列化等。
/// </remarks>
public interface IPrimitiveType<TValue> : ITypeFramework
    where TValue : IConvertible
{
    /// <summary>
    /// 原始值
    /// </summary>
    /// <returns>基本型別的原始值</returns>
    TValue? Value { get; set; }

    /// <summary>
    /// 字串表示值
    /// </summary>
    /// <returns>值的字串表示</returns>
    string? StringValue { get; set; }

    /// <summary>
    /// 檢查是否為 NULL 值
    /// </summary>
    /// <returns>如果值為 null 則為 true，否則為 false</returns>
    bool IsNull { get; }

    /// <summary>
    /// 從字串解析值
    /// </summary>
    /// <param name="value">要解析的字串</param>
    /// <returns>解析後的值</returns>
    TValue? ParseValue(string value);

    /// <summary>
    /// 將值轉換為字串
    /// </summary>
    /// <param name="value">要轉換的值</param>
    /// <returns>值的字串表示</returns>
    string? ValueToString(TValue? value);

    /// <summary>
    /// 驗證值是否符合 FHIR 規範
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    bool IsValidValue(TValue? value);

    /// <summary>
    /// 轉換為 JSON 值（簡化表示）
    /// </summary>
    /// <returns>JSON 值</returns>
    JsonValue? ToJsonValue();

    /// <summary>
    /// 從 JSON 值建立（簡化表示）
    /// </summary>
    /// <param name="jsonValue">要解析的 JSON 值</param>
    void FromJsonValue(JsonValue? jsonValue);

    /// <summary>
    /// 轉換為完整 JSON 物件（包含 Extension）
    /// </summary>
    /// <returns>完整的 JSON 物件</returns>
    JsonObject? ToFullJsonObject();

    /// <summary>
    /// 從完整 JSON 物件建立（包含 Extension）
    /// </summary>
    /// <param name="jsonObject">要解析的完整 JSON 物件</param>
    void FromFullJsonObject(JsonObject? jsonObject);
}

/// <summary>
/// FHIR Primitive Type 工廠介面
/// </summary>
/// <remarks>
/// 提供建立 FHIR 基本型別實例的工廠方法。
/// </remarks>
public interface IPrimitiveTypeFactory
{
    /// <summary>
    /// 建立指定型別的 Primitive Type
    /// </summary>
    /// <typeparam name="T">Primitive Type 型別</typeparam>
    /// <returns>Primitive Type 實例</returns>
    T Create<T>() where T : IPrimitiveType<IConvertible>, new();

    /// <summary>
    /// 從 JSON 建立 Primitive Type
    /// </summary>
    /// <param name="jsonValue">JSON 值</param>
    /// <param name="typeName">型別名稱</param>
    /// <returns>Primitive Type 實例</returns>
    IPrimitiveType<IConvertible>? CreateFromJson(JsonValue? jsonValue, string typeName);

    /// <summary>
    /// 從完整 JSON 物件建立 Primitive Type
    /// </summary>
    /// <param name="jsonObject">完整 JSON 物件</param>
    /// <param name="typeName">型別名稱</param>
    /// <returns>Primitive Type 實例</returns>
    IPrimitiveType<IConvertible>? CreateFromFullJson(JsonObject? jsonObject, string typeName);
} 