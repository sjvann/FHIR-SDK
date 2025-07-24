using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// FHIR 基礎型別的抽象基類
/// </summary>
/// <typeparam name="T">原生 C# 型別</typeparam>
public abstract class PrimitiveType<T> : Element, IPrimitiveType where T : IConvertible
{
    /// <summary>
    /// 實際值
    /// </summary>
    [JsonPropertyName("value")]
    public T? Value { get; set; }

    /// <summary>
    /// 建立新的 PrimitiveType 實例
    /// </summary>
    protected PrimitiveType() { }

    /// <summary>
    /// 建立新的 PrimitiveType 實例
    /// </summary>
    /// <param name="value">初始值</param>
    protected PrimitiveType(T? value)
    {
        Value = value;
    }

    /// <summary>
    /// 建立新的 PrimitiveType 實例
    /// </summary>
    /// <param name="value">JSON 值</param>
    /// <param name="elementName">元素名稱</param>
    protected PrimitiveType(JsonNode? value, string? elementName = null)
    {
        if (value != null)
        {
            ParseFromJson(value, elementName);
        }
    }

    /// <summary>
    /// 建立新的 PrimitiveType 實例
    /// </summary>
    /// <param name="value">原生值</param>
    /// <param name="element">元素</param>
    protected PrimitiveType(T? value, Element? element = null) : base(element)
    {
        Value = value;
    }

    /// <summary>
    /// 從 JSON 解析值
    /// </summary>
    /// <param name="jsonNode">JSON 節點</param>
    /// <param name="elementName">元素名稱</param>
    protected virtual void ParseFromJson(JsonNode jsonNode, string? elementName = null)
    {
        if (jsonNode is JsonValue jsonValue)
        {
            var stringValue = jsonValue.ToString();
            if (TryParseValue(stringValue, out var parsedValue))
            {
                Value = parsedValue;
            }
        }
        else if (jsonNode is JsonObject jsonObject)
        {
            // 處理 FHIR 格式的 JSON
            if (jsonObject.TryGetPropertyValue("value", out var valueNode))
            {
                var stringValue = valueNode?.ToString();
                if (TryParseValue(stringValue, out var parsedValue))
                {
                    Value = parsedValue;
                }
            }

            // 解析元素屬性
            ParseElementFromJson(jsonObject);
        }
    }

    /// <summary>
    /// 嘗試解析值
    /// </summary>
    /// <param name="value">字串值</param>
    /// <param name="result">解析結果</param>
    /// <returns>是否解析成功</returns>
    protected abstract bool TryParseValue(string? value, out T? result);

    /// <summary>
    /// 驗證值
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    protected virtual IEnumerable<ValidationResult> ValidateValue(ValidationContext validationContext)
    {
        // 基礎驗證邏輯
        if (Value == null) yield break;

        // 子類別可以覆寫此方法來添加特定的驗證邏輯
    }

    /// <summary>
    /// 驗證此實例
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        foreach (var result in ValidateValue(validationContext))
            yield return result;
    }

    /// <summary>
    /// 轉換為字串
    /// </summary>
    /// <returns>字串表示</returns>
    public override string ToString()
    {
        return Value?.ToString() ?? string.Empty;
    }

    // IPrimitiveType 介面實作
    public object? GetValue() => Value;
    public bool HasValue => Value != null;
    public bool IsEmpty => Value == null || Value.ToString()?.Length == 0;
    public bool HasElement() => ElementId != null || (Extension != null && Extension.Count > 0);
    
    public JsonValue? GetJsonValue()
    {
        if (Value == null) return null;
        return JsonValue.Create(Value.ToString());
    }
    
    public JsonObject? GetElementJsonObject()
    {
        var jsonObject = new JsonObject();
        
        if (ElementId != null)
            jsonObject.Add("id", ElementId);
            
        if (Extension != null && Extension.Count > 0)
        {
            var extensionArray = new JsonArray();
            foreach (var extension in Extension)
            {
                if (extension is Extension ext)
                {
                    var extObject = new JsonObject();
                    if (ext.Url != null) extObject.Add("url", ext.Url);
                    if (ext.Value != null) extObject.Add("value", JsonValue.Create(ext.Value.ToString()));
                    extensionArray.Add(extObject);
                }
            }
            jsonObject.Add("extension", extensionArray);
        }
        
        return jsonObject;
    }
    
    public string GetElementJsonString()
    {
        var jsonObject = GetElementJsonObject();
        return jsonObject?.ToJsonString() ?? "{}";
    }
    
    public bool ValueEquals(object? other)
    {
        if (other == null) return Value == null;
        if (other is PrimitiveType<T> otherPrimitive)
            return Equals(Value, otherPrimitive.Value);
        return Equals(Value, other);
    }
} 