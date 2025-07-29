using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.Bases;

/// <summary>
/// Base definition for all elements in a resource.
/// 現在可以安全地包含 Extension 而不會有循環依賴
/// </summary>
/// <remarks>
/// FHIR R5 Element (Abstract)
/// Base definition for all elements that are defined inside a resource - but not those in a data type.
/// 提供 id 和 extension 屬性，支援擴展功能。
/// 
/// Structure:
/// - id: string (0..1) - Unique id for the element within a resource
/// - extension: Extension[] (0..*) - Additional information that is not part of the basic definition
/// </remarks>
public abstract class Element : Base, IIdentifiableTypeFramework, IExtensibleTypeFramework
{
    /// <summary>
    /// Unique id for the element within a resource (for internal references).
    /// FHIR Path: Element.id
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("id")]
    public FhirString? Id { get; set; }
    
    /// <summary>
    /// Additional information that is not part of the basic definition of the element.
    /// FHIR Path: Element.extension
    /// Cardinality: 0..*
    /// Type: Extension[]
    /// </summary>
    [JsonPropertyName("extension")]
    public IList<IExtension>? Extension { get; set; }
    
    /// <summary>
    /// 檢查是否有 extensions
    /// </summary>
    /// <returns>如果存在 extensions 則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasExtensions => Extension?.Any() == true;
    
    /// <summary>
    /// 取得指定 URL 的 extension
    /// </summary>
    /// <param name="url">要查詢的擴展 URL</param>
    /// <returns>找到的擴展，如果不存在則為 null</returns>
    public IExtension? GetExtension(string url)
    {
        return Extension?.FirstOrDefault(ext => ext.Url == url);
    }
    
    /// <summary>
    /// 添加 extension（使用新的 ChoiceType 實作）
    /// </summary>
    /// <param name="url">擴展的 URL</param>
    /// <param name="value">擴展的值（使用 ChoiceType）</param>
    public void AddExtension(string url, ExtensionValueChoice value)
    {
        Extension ??= new List<IExtension>();
        var extension = new Extension { Url = url, Value = value };
        Extension.Add(extension);
    }

    /// <summary>
    /// 添加 extension（泛型版本）
    /// </summary>
    /// <typeparam name="T">擴展值的型別</typeparam>
    /// <param name="url">擴展的 URL</param>
    /// <param name="value">擴展的值</param>
    public void AddExtension<T>(string url, T value) where T : class
    {
        Extension ??= new List<IExtension>();
        var extension = new Extension { Url = url, Value = value };
        Extension.Add(extension);
    }
    
    /// <summary>
    /// 移除指定 URL 的 extension
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
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Element 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = (Element)MemberwiseClone();
        
        // 深層複製 Extension
        if (Extension != null)
        {
            copy.Extension = Extension.Select(e => e.DeepCopy() as IExtension).ToList();
        }
        
        return copy;
    }
    
    /// <summary>
    /// 判斷與另一個 Element 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Element otherElement)
            return false;

        return Equals(Id, otherElement.Id) &&
               Extension?.Count == otherElement.Extension?.Count &&
               (Extension?.Zip(otherElement.Extension ?? new List<IExtension>(), 
                             (a, b) => a.IsExactly(b)).All(x => x) ?? true);
    }
    
    /// <summary>
    /// 驗證 Element 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Element ID 驗證 - 使用 FhirString 的內建驗證
        if (Id != null)
        {
            var idValidationContext = new ValidationContext(Id);
            foreach (var result in Id.Validate(idValidationContext))
            {
                yield return result;
            }
        }
        
        // Extension 驗證
        if (Extension != null)
        {
            foreach (var extension in Extension)
            {
                var extensionValidationContext = new ValidationContext(extension);
                foreach (var result in extension.Validate(extensionValidationContext))
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
