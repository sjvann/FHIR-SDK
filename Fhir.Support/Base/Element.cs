using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// FHIR 元素的基礎類別
/// </summary>
public abstract class Element : IElement
{
    /// <summary>
    /// Unique id for the element within a resource (for internal references).
    /// </summary>
    [JsonPropertyName("id")]
    public string? ElementId { get; set; }

    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the element.
    /// </summary>
    [JsonPropertyName("extension")]
    public List<IExtension>? Extension { get; set; }

    /// <summary>
    /// 建立新的 Element 實例
    /// </summary>
    protected Element() { }

    /// <summary>
    /// 建立新的 Element 實例
    /// </summary>
    /// <param name="element">基礎元素</param>
    protected Element(Element? element = null)
    {
        if (element != null)
        {
            ElementId = element.ElementId;
            Extension = element.Extension;
        }
    }

    /// <summary>
    /// 從 JSON 解析元素屬性
    /// </summary>
    /// <param name="jsonObject">JSON 物件</param>
    protected virtual void ParseElementFromJson(JsonObject jsonObject)
    {
        if (jsonObject.TryGetPropertyValue("id", out var idNode))
        {
            ElementId = idNode?.ToString();
        }

        if (jsonObject.TryGetPropertyValue("extension", out var extensionNode))
        {
            if (extensionNode is JsonArray extensionArray)
            {
                Extension = new List<IExtension>();
                foreach (var extensionItem in extensionArray)
                {
                    if (extensionItem is JsonObject extensionObject)
                    {
                        var extension = new Extension(extensionObject);
                        Extension.Add(extension);
                    }
                }
            }
        }
    }

    /// <summary>
    /// 驗證此實例
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證擴展
        if (Extension != null)
        {
            foreach (var extension in Extension)
            {
                Validator.TryValidateObject(extension, new ValidationContext(extension), new List<ValidationResult>(), true);
            }
        }

        return Enumerable.Empty<ValidationResult>();
    }
} 