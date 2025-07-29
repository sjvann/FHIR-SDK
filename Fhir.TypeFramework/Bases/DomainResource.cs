using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.Bases;

/// <summary>
/// DomainResource - 領域資源
/// 所有領域資源的基礎類別
/// </summary>
/// <remarks>
/// FHIR R5 DomainResource (Abstract)
/// A resource that is defined as part of the FHIR specification and has its own resource type.
/// 
/// Structure:
/// - text: Narrative (0..1) - Text summary of the resource, for human interpretation
/// - contained: Resource[] (0..*) - Contained, inline Resources
/// - extension: Extension[] (0..*) - Additional information that is not part of the basic definition
/// - modifierExtension: Extension[] (0..*) - Extensions that cannot be ignored
/// </remarks>
public abstract class DomainResource : Resource, IDomainResource
{
    /// <summary>
    /// Text summary of the resource, for human interpretation
    /// FHIR Path: DomainResource.text
    /// Cardinality: 0..1
    /// Type: Narrative
    /// </summary>
    [JsonPropertyName("text")]
    public Narrative? Text { get; set; }

    /// <summary>
    /// Contained, inline Resources
    /// FHIR Path: DomainResource.contained
    /// Cardinality: 0..*
    /// Type: Resource[]
    /// </summary>
    [JsonPropertyName("contained")]
    public IList<Resource>? Contained { get; set; }

    /// <summary>
    /// Additional information that is not part of the basic definition of the resource
    /// FHIR Path: DomainResource.extension
    /// Cardinality: 0..*
    /// Type: Extension[]
    /// </summary>
    [JsonPropertyName("extension")]
    public IList<IExtension>? Extension { get; set; }

    /// <summary>
    /// Extensions that cannot be ignored
    /// FHIR Path: DomainResource.modifierExtension
    /// Cardinality: 0..*
    /// Type: Extension[]
    /// </summary>
    [JsonPropertyName("modifierExtension")]
    public IList<IExtension>? ModifierExtension { get; set; }

    /// <summary>
    /// 檢查是否有文字敘述
    /// </summary>
    /// <returns>如果存在文字敘述則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasText => Text != null;

    /// <summary>
    /// 檢查是否有內含資源
    /// </summary>
    /// <returns>如果存在內含資源則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasContained => Contained?.Any() == true;

    /// <summary>
    /// 檢查是否有擴展
    /// </summary>
    /// <returns>如果存在擴展則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasExtensions => Extension?.Any() == true;

    /// <summary>
    /// 檢查是否有修飾擴展
    /// </summary>
    /// <returns>如果存在修飾擴展則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasModifierExtensions => ModifierExtension?.Any() == true;

    /// <summary>
    /// 取得指定 URL 的擴展
    /// </summary>
    /// <param name="url">要查詢的擴展 URL</param>
    /// <returns>找到的擴展，如果不存在則為 null</returns>
    public IExtension? GetExtension(string url)
    {
        return Extension?.FirstOrDefault(ext => ext.Url == url);
    }

    /// <summary>
    /// 取得指定 URL 的修飾擴展
    /// </summary>
    /// <param name="url">要查詢的修飾擴展 URL</param>
    /// <returns>找到的修飾擴展，如果不存在則為 null</returns>
    public IExtension? GetModifierExtension(string url)
    {
        return ModifierExtension?.FirstOrDefault(ext => ext.Url == url);
    }

    /// <summary>
    /// 添加擴展
    /// </summary>
    /// <param name="url">擴展的 URL</param>
    /// <param name="value">擴展的值</param>
    public void AddExtension(string url, object? value)
    {
        Extension ??= new List<IExtension>();
        var extension = new Extension { Url = url, Value = value };
        Extension.Add(extension);
    }

    /// <summary>
    /// 添加修飾擴展
    /// </summary>
    /// <param name="url">修飾擴展的 URL</param>
    /// <param name="value">修飾擴展的值</param>
    public void AddModifierExtension(string url, object? value)
    {
        ModifierExtension ??= new List<IExtension>();
        var extension = new Extension { Url = url, Value = value };
        ModifierExtension.Add(extension);
    }

    /// <summary>
    /// 移除指定 URL 的擴展
    /// </summary>
    /// <param name="url">要移除的擴展 URL</param>
    /// <returns>如果成功移除則為 true，否則為 false</returns>
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
    /// 移除指定 URL 的修飾擴展
    /// </summary>
    /// <param name="url">要移除的修飾擴展 URL</param>
    /// <returns>如果成功移除則為 true，否則為 false</returns>
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
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>DomainResource 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = (DomainResource)MemberwiseClone();
        
        // 深層複製 Text
        if (Text != null)
        {
            copy.Text = Text.DeepCopy() as Narrative;
        }

        // 深層複製 Contained
        if (Contained != null)
        {
            copy.Contained = Contained.Select(r => r.DeepCopy() as Resource).ToList();
        }

        // 深層複製 Extension
        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        // 深層複製 ModifierExtension
        if (ModifierExtension != null)
        {
            copy.ModifierExtension = ModifierExtension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 DomainResource 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not DomainResource otherDomain)
            return false;

        return base.IsExactly(other) &&
               Equals(Text, otherDomain.Text) &&
               Contained?.Count == otherDomain.Contained?.Count &&
               Extension?.Count == otherDomain.Extension?.Count &&
               ModifierExtension?.Count == otherDomain.ModifierExtension?.Count;
    }

    /// <summary>
    /// 驗證 DomainResource 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 Text
        if (Text != null)
        {
            var textValidationContext = new ValidationContext(Text);
            foreach (var result in Text.Validate(textValidationContext))
            {
                yield return result;
            }
        }

        // 驗證 Contained
        if (Contained != null)
        {
            foreach (var contained in Contained)
            {
                var containedValidationContext = new ValidationContext(contained);
                foreach (var result in contained.Validate(containedValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 驗證 Extension
        if (Extension != null)
        {
            foreach (var ext in Extension)
            {
                if (string.IsNullOrEmpty(ext.Url))
                {
                    yield return new ValidationResult("Extension must have a URL");
                }
                
                var extValidationContext = new ValidationContext(ext);
                foreach (var result in ext.Validate(extValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 驗證 ModifierExtension
        if (ModifierExtension != null)
        {
            foreach (var ext in ModifierExtension)
            {
                if (string.IsNullOrEmpty(ext.Url))
                {
                    yield return new ValidationResult("ModifierExtension must have a URL");
                }
                
                var extValidationContext = new ValidationContext(ext);
                foreach (var result in ext.Validate(extValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 