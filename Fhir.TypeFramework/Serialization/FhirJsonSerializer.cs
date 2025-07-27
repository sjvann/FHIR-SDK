using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.Serialization;

/// <summary>
/// FHIR JSON 序列化器
/// 支援 FHIR R5 的 JSON 序列化格式
/// </summary>
/// <remarks>
/// 提供 FHIR 專用的 JSON 序列化和反序列化功能，支援簡化格式、完整格式和 FHIR 格式。
/// </remarks>
public class FhirJsonSerializer
{
    private readonly JsonSerializerOptions _options;

    /// <summary>
    /// 初始化 FhirJsonSerializer
    /// </summary>
    /// <remarks>
    /// 設定預設的 JSON 序列化選項，包括駝峰命名、縮排和 null 值忽略。
    /// </remarks>
    public FhirJsonSerializer()
    {
        _options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }

    /// <summary>
    /// 序列化為簡化 JSON（只包含值）
    /// </summary>
    /// <param name="primitiveType">Primitive Type 實例</param>
    /// <returns>JSON 字串</returns>
    public string SerializeSimple(IPrimitiveType<IConvertible> primitiveType)
    {
        var jsonValue = primitiveType.ToJsonValue();
        return jsonValue?.ToString() ?? "null";
    }

    /// <summary>
    /// 序列化為完整 JSON（包含 Extension）
    /// </summary>
    /// <param name="primitiveType">Primitive Type 實例</param>
    /// <returns>JSON 字串</returns>
    public string SerializeFull(IPrimitiveType<IConvertible> primitiveType)
    {
        var jsonObject = primitiveType.ToFullJsonObject();
        return jsonObject?.ToJsonString() ?? "null";
    }

    /// <summary>
    /// 序列化為 FHIR 格式 JSON
    /// 包含主值和完整物件
    /// </summary>
    /// <param name="propertyName">屬性名稱</param>
    /// <param name="primitiveType">Primitive Type 實例</param>
    /// <returns>JSON 字串</returns>
    public string SerializeFhirFormat(string propertyName, IPrimitiveType<IConvertible> primitiveType)
    {
        var jsonObject = new JsonObject();

        // 添加主值（簡化表示）
        var jsonValue = primitiveType.ToJsonValue();
        if (jsonValue != null)
        {
            jsonObject.Add(propertyName, jsonValue);
        }

        // 添加完整物件（包含 Extension）
        var fullObject = primitiveType.ToFullJsonObject();
        if (fullObject != null && (fullObject.ContainsKey("id") || fullObject.ContainsKey("extension")))
        {
            var underscorePropertyName = $"_{propertyName}";
            jsonObject.Add(underscorePropertyName, fullObject);
        }

        return jsonObject.ToJsonString(_options);
    }

    /// <summary>
    /// 反序列化簡化 JSON
    /// </summary>
    /// <typeparam name="T">Primitive Type 型別</typeparam>
    /// <param name="json">JSON 字串</param>
    /// <returns>Primitive Type 實例，如果反序列化失敗則為 null</returns>
    public T? DeserializeSimple<T>(string json) where T : IPrimitiveType<IConvertible>, new()
    {
        try
        {
            var jsonValue = JsonValue.Parse(json);
            var primitiveType = new T();
            primitiveType.FromJsonValue(jsonValue);
            return primitiveType;
        }
        catch
        {
            return default;
        }
    }

    /// <summary>
    /// 反序列化完整 JSON
    /// </summary>
    /// <typeparam name="T">Primitive Type 型別</typeparam>
    /// <param name="json">JSON 字串</param>
    /// <returns>Primitive Type 實例，如果反序列化失敗則為 null</returns>
    public T? DeserializeFull<T>(string json) where T : IPrimitiveType<IConvertible>, new()
    {
        try
        {
            var jsonObject = JsonObject.Parse(json);
            var primitiveType = new T();
            primitiveType.FromFullJsonObject(jsonObject);
            return primitiveType;
        }
        catch
        {
            return default;
        }
    }

    /// <summary>
    /// 反序列化 FHIR 格式 JSON
    /// </summary>
    /// <typeparam name="T">Primitive Type 型別</typeparam>
    /// <param name="propertyName">屬性名稱</param>
    /// <param name="json">JSON 字串</param>
    /// <returns>Primitive Type 實例，如果反序列化失敗則為 null</returns>
    public T? DeserializeFhirFormat<T>(string propertyName, string json) where T : IPrimitiveType<IConvertible>, new()
    {
        try
        {
            var jsonObject = JsonObject.Parse(json);
            var primitiveType = new T();

            // 解析主值
            if (jsonObject.TryGetPropertyValue(propertyName, out var valueElement))
            {
                primitiveType.FromJsonValue(valueElement as JsonValue);
            }

            // 解析完整物件
            var underscorePropertyName = $"_{propertyName}";
            if (jsonObject.TryGetPropertyValue(underscorePropertyName, out var fullObjectElement))
            {
                primitiveType.FromFullJsonObject(fullObjectElement as JsonObject);
            }

            return primitiveType;
        }
        catch
        {
            return default;
        }
    }
} 