using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.Base;

/// <summary>
/// Base definition for all elements in a resource.
/// 現在可以安全地包含 Extension 而不會有循環依賴
/// </summary>
/// <remarks>
/// FHIR R4 Element (Abstract)
/// Base definition for all elements that are defined inside a resource - but not those in a data type.
/// </remarks>
public abstract class Element : Base
{
    /// <summary>
    /// Unique id for the element within a resource (for internal references).
    /// FHIR Path: Element.id
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    /// <summary>
    /// Additional information that is not part of the basic definition of the element.
    /// FHIR Path: Element.extension
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }
    
    /// <summary>
    /// 檢查是否有 extensions
    /// </summary>
    [JsonIgnore]
    public bool HasExtensions => Extension?.Any() == true;
    
    /// <summary>
    /// 取得指定 URL 的 extension
    /// </summary>
    public Extension? GetExtension(string url)
    {
        return Extension?.FirstOrDefault(ext => ext.Url == url);
    }
    
    /// <summary>
    /// 添加 extension
    /// </summary>
    public void AddExtension(string url, object? value)
    {
        Extension ??= new List<Extension>();
        var extension = new Extension { Url = url };

        // 處理不同型別的值
        switch (value)
        {
            case string stringValue:
                extension.ValueString = stringValue;
                break;
            case int intValue:
                extension.ValueInteger = intValue;
                break;
            case bool boolValue:
                extension.ValueBoolean = boolValue;
                break;
            case decimal decimalValue:
                extension.ValueDecimal = decimalValue;
                break;
            default:
                // 對於其他型別，嘗試直接設定
                extension.Value = value;
                break;
        }

        Extension.Add(extension);
    }
    
    /// <summary>
    /// 移除指定 URL 的 extension
    /// </summary>
    public bool RemoveExtension(string url)
    {
        if (Extension == null) return false;
        
        var toRemove = Extension.Where(ext => ext.Url == url).ToList();
        foreach (var ext in toRemove)
        {
            Extension.Remove(ext);
        }
        
        return toRemove.Any();
    }
    
    /// <summary>
    /// FHIR 驗證：基礎 Element 驗證
    /// </summary>
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Element ID 格式驗證
        if (!string.IsNullOrEmpty(Id) && !IsValidElementId(Id))
        {
            yield return new ValidationResult($"Element ID '{Id}' is not valid. Must match pattern: [A-Za-z0-9\\-\\.{{1,64}}");
        }
        
        // Extension 驗證
        if (Extension != null)
        {
            foreach (var ext in Extension)
            {
                if (string.IsNullOrEmpty(ext.Url))
                {
                    yield return new ValidationResult("Extension must have a URL");
                }
                
                // 驗證 Extension 本身
                var extValidationContext = new ValidationContext(ext);
                foreach (var extResult in ext.Validate(extValidationContext))
                {
                    yield return extResult;
                }
            }
        }
    }
    
    /// <summary>
    /// 驗證 Element ID 格式
    /// </summary>
    private bool IsValidElementId(string id)
    {
        if (string.IsNullOrEmpty(id) || id.Length > 64)
            return false;
            
        // Element ID 只能包含字母、數字、連字號和點
        return id.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '.');
    }
}
