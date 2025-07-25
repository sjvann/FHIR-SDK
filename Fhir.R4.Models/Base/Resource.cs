using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Base;

/// <summary>
/// This is the base resource type for everything.
/// 所有 FHIR Resources 的基礎類別
/// </summary>
/// <remarks>
/// FHIR R4 Resource (Abstract)
/// This is the base resource type for everything.
/// </remarks>
public abstract class Resource : Base
{
    /// <summary>
    /// Logical id of this artifact.
    /// FHIR Path: Resource.id
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    /// <summary>
    /// Metadata about the resource.
    /// FHIR Path: Resource.meta
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("meta")]
    public Meta? Meta { get; set; }
    
    /// <summary>
    /// A set of rules under which this content was created.
    /// FHIR Path: Resource.implicitRules
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("implicitRules")]
    public string? ImplicitRules { get; set; }
    
    /// <summary>
    /// Language of the resource content.
    /// FHIR Path: Resource.language
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
    
    /// <summary>
    /// 取得資源型別名稱
    /// </summary>
    [JsonIgnore]
    public virtual string ResourceType => GetType().Name;
    
    /// <summary>
    /// FHIR 驗證：基礎 Resource 驗證
    /// </summary>
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Resource ID 格式驗證
        if (!string.IsNullOrEmpty(Id) && !IsValidResourceId(Id))
        {
            yield return new ValidationResult($"Resource ID '{Id}' is not valid. Must match pattern: [A-Za-z0-9\\-\\.{{1,64}}");
        }
        
        // ImplicitRules 必須是絕對 URI
        if (!string.IsNullOrEmpty(ImplicitRules) && !Uri.IsWellFormedUriString(ImplicitRules, UriKind.Absolute))
        {
            yield return new ValidationResult($"Resource.implicitRules '{ImplicitRules}' must be a valid absolute URI");
        }
        
        // Language 應該是有效的語言代碼
        if (!string.IsNullOrEmpty(Language) && !IsValidLanguageCode(Language))
        {
            yield return new ValidationResult($"Resource.language '{Language}' is not a valid language code");
        }
        
        // Meta 驗證
        if (Meta != null)
        {
            var metaValidationContext = new ValidationContext(Meta);
            foreach (var result in Meta.Validate(metaValidationContext))
            {
                yield return result;
            }
        }
    }
    
    /// <summary>
    /// 驗證 Resource ID 格式
    /// </summary>
    private bool IsValidResourceId(string id)
    {
        if (string.IsNullOrEmpty(id) || id.Length > 64)
            return false;
            
        // Resource ID 只能包含字母、數字、連字號和點
        return id.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '.');
    }
    
    /// <summary>
    /// 驗證語言代碼格式（簡化版）
    /// </summary>
    private bool IsValidLanguageCode(string language)
    {
        if (string.IsNullOrEmpty(language))
            return false;
            
        // 簡化的語言代碼驗證：2-3 個字母，可選的 - 和地區代碼
        return System.Text.RegularExpressions.Regex.IsMatch(language, @"^[a-z]{2,3}(-[A-Z]{2})?$");
    }
}

/// <summary>
/// A resource that includes narrative, extensions, and contained resources.
/// 大部分臨床和管理資源的基礎類別
/// </summary>
/// <remarks>
/// FHIR R4 DomainResource (Abstract)
/// A resource that includes narrative, extensions, and contained resources.
/// </remarks>
public abstract class DomainResource : Resource
{
    /// <summary>
    /// Text summary of the resource, for human interpretation.
    /// FHIR Path: DomainResource.text
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("text")]
    public Narrative? Text { get; set; }
    
    /// <summary>
    /// Contained, inline Resources.
    /// FHIR Path: DomainResource.contained
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("contained")]
    public List<Resource>? Contained { get; set; }
    
    /// <summary>
    /// Additional information that is not part of the basic definition of the resource.
    /// FHIR Path: DomainResource.extension
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }
    
    /// <summary>
    /// Extensions that cannot be ignored.
    /// FHIR Path: DomainResource.modifierExtension
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("modifierExtension")]
    public List<Extension>? ModifierExtension { get; set; }
    
    /// <summary>
    /// 檢查是否有 extensions
    /// </summary>
    [JsonIgnore]
    public bool HasExtensions => Extension?.Any() == true;
    
    /// <summary>
    /// 檢查是否有 modifier extensions
    /// </summary>
    [JsonIgnore]
    public bool HasModifierExtensions => ModifierExtension?.Any() == true;
    
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
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // Text 驗證
        if (Text != null)
        {
            var textValidationContext = new ValidationContext(Text);
            foreach (var result in Text.Validate(textValidationContext))
            {
                yield return result;
            }
        }
        
        // Extension 驗證
        if (Extension != null)
        {
            foreach (var ext in Extension)
            {
                var extValidationContext = new ValidationContext(ext);
                foreach (var result in ext.Validate(extValidationContext))
                {
                    yield return result;
                }
            }
        }
        
        // ModifierExtension 驗證
        if (ModifierExtension != null)
        {
            foreach (var ext in ModifierExtension)
            {
                var extValidationContext = new ValidationContext(ext);
                foreach (var result in ext.Validate(extValidationContext))
                {
                    yield return result;
                }
            }
        }
        
        // Contained resources 驗證
        if (Contained != null)
        {
            foreach (var resource in Contained)
            {
                var resourceValidationContext = new ValidationContext(resource);
                foreach (var result in resource.Validate(resourceValidationContext))
                {
                    yield return result;
                }
            }
        }
    }
}

/// <summary>
/// Base definition for the few data elements that are present in all resources.
/// 資源的 metadata 資訊
/// </summary>
/// <remarks>
/// FHIR R4 Meta DataType
/// The metadata about a resource.
/// </remarks>
public class Meta : Element
{
    /// <summary>
    /// Version specific identifier.
    /// FHIR Path: Meta.versionId
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
    
    /// <summary>
    /// When the resource version last changed.
    /// FHIR Path: Meta.lastUpdated
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("lastUpdated")]
    public string? LastUpdated { get; set; }
    
    /// <summary>
    /// Identifies where the resource comes from.
    /// FHIR Path: Meta.source
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
    
    /// <summary>
    /// Profiles this resource claims to conform to.
    /// FHIR Path: Meta.profile
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("profile")]
    public List<string>? Profile { get; set; }
    
    /// <summary>
    /// Security Labels applied to this resource.
    /// FHIR Path: Meta.security
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("security")]
    public List<Coding>? Security { get; set; }
    
    /// <summary>
    /// Tags applied to this resource.
    /// FHIR Path: Meta.tag
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("tag")]
    public List<Coding>? Tag { get; set; }
}

/// <summary>
/// A human-readable summary of the resource conveying the essential clinical and business information.
/// </summary>
/// <remarks>
/// FHIR R4 Narrative DataType
/// A human-readable summary of the resource.
/// </remarks>
public class Narrative : Element
{
    /// <summary>
    /// The status of the narrative.
    /// FHIR Path: Narrative.status
    /// Cardinality: 1..1
    /// Required: Yes
    /// Allowed values: generated, extensions, additional, empty
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;
    
    /// <summary>
    /// Limited xhtml content.
    /// FHIR Path: Narrative.div
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("div")]
    public string Div { get; set; } = string.Empty;
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // Status 是必要的
        if (string.IsNullOrEmpty(Status))
        {
            yield return new ValidationResult("Narrative.status is required");
        }
        else
        {
            var validStatuses = new[] { "generated", "extensions", "additional", "empty" };
            if (!validStatuses.Contains(Status))
            {
                yield return new ValidationResult($"Narrative.status '{Status}' is not valid. Must be one of: {string.Join(", ", validStatuses)}");
            }
        }
        
        // Div 是必要的
        if (string.IsNullOrEmpty(Div))
        {
            yield return new ValidationResult("Narrative.div is required");
        }
    }
}
