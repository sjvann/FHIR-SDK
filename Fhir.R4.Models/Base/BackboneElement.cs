using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Base;

/// <summary>
/// Base definition for all elements that are defined inside a resource - but not those in a data type.
/// BackboneElement 用於 Resource 內部定義的複雜結構
/// </summary>
/// <remarks>
/// FHIR R4 BackboneElement (Abstract)
/// Base definition for all elements that are defined inside a resource - but not those in a data type.
/// </remarks>
public abstract class BackboneElement : Element
{
    /// <summary>
    /// Extensions that cannot be ignored even if unrecognized.
    /// FHIR Path: BackboneElement.modifierExtension
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("modifierExtension")]
    public List<Extension>? ModifierExtension { get; set; }
    
    /// <summary>
    /// 檢查是否有 modifier extensions
    /// </summary>
    [JsonIgnore]
    public bool HasModifierExtensions => ModifierExtension?.Any() == true;
    
    /// <summary>
    /// 取得指定 URL 的 modifier extension
    /// </summary>
    public Extension? GetModifierExtension(FhirUri url)
    {
        return ModifierExtension?.FirstOrDefault(ext => ext.Url?.Value == url.Value);
    }
    
    /// <summary>
    /// 添加 modifier extension
    /// </summary>
    public void AddModifierExtension(FhirUri url, object? value)
    {
        ModifierExtension ??= new List<Extension>();
        var extension = new Extension { Url = url };
        
        // 處理不同型別的值
        switch (value)
        {
            case FhirString stringValue:
                extension.ValueString = stringValue.Value;
                break;
            case FhirInteger intValue:
                extension.ValueInteger = intValue.Value;
                break;
            case FhirBoolean boolValue:
                extension.ValueBoolean = boolValue.Value;
                break;
            case FhirDecimal decimalValue:
                extension.ValueDecimal = decimalValue.Value;
                break;
            default:
                extension.Value = value;
                break;
        }
        
        ModifierExtension.Add(extension);
    }
    
    /// <summary>
    /// 移除指定 URL 的 modifier extension
    /// </summary>
    public bool RemoveModifierExtension(string url)
    {
        if (ModifierExtension == null) return false;
        
        var toRemove = ModifierExtension.Where(ext => ext.Url == url).ToList();
        foreach (var ext in toRemove)
        {
            ModifierExtension.Remove(ext);
        }
        
        return toRemove.Any();
    }
    
    /// <summary>
    /// 驗證 BackboneElement 根據 FHIR R4 規則
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // ModifierExtension 驗證
        if (ModifierExtension != null)
        {
            foreach (var ext in ModifierExtension)
            {
                if (string.IsNullOrEmpty(ext.Url))
                {
                    yield return new ValidationResult("ModifierExtension must have a URL");
                }
                
                // 驗證 ModifierExtension 本身
                var extValidationContext = new ValidationContext(ext);
                foreach (var extResult in ext.Validate(extValidationContext))
                {
                    yield return extResult;
                }
            }
        }
    }
}
