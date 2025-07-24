using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// FHIR 複雜型別的抽象基類
/// </summary>
/// <typeparam name="T">具體的複雜型別</typeparam>
public abstract class ComplexType<T> : DataType, IComplexType where T : DataType, new()
{
    /// <summary>
    /// 建立新的 ComplexType 實例
    /// </summary>
    protected ComplexType() { }

    /// <summary>
    /// 建立新的 ComplexType 實例
    /// </summary>
    /// <param name="value">JSON 值</param>
    protected ComplexType(JsonNode? value)
    {
        if (value != null)
        {
            ParseFromJson(value);
        }
    }

    /// <summary>
    /// 建立新的 ComplexType 實例
    /// </summary>
    /// <param name="value">字串值</param>
    protected ComplexType(string value)
    {
        // 複雜型別通常不直接從字串建立
        // 子類別可以覆寫此方法
    }

    /// <summary>
    /// 從 JSON 解析
    /// </summary>
    /// <param name="jsonNode">JSON 節點</param>
    protected virtual void ParseFromJson(JsonNode jsonNode)
    {
        if (jsonNode is JsonObject jsonObject)
        {
            // 解析基礎元素屬性
            ParseElementFromJson(jsonObject);
            
            // 子類別可以覆寫此方法來解析特定屬性
        }
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

        // 子類別可以覆寫此方法來添加特定的驗證邏輯
    }

    /// <summary>
    /// 取得 JSON 物件
    /// </summary>
    /// <returns>JSON 物件</returns>
    public JsonObject? GetJsonObject()
    {
        var jsonObject = new JsonObject();
        
        // 添加基礎元素屬性
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
} 