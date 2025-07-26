using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.DataTypes;
using Fhir.R4.Models.DataTypes.ComplexTypes;

namespace Fhir.R4.Models.Base;

/// <summary>
/// FHIR Domain Resource 的泛型基礎類別
/// 繼承自 GenericResource，添加了 Domain Resource 特有的屬性
/// </summary>
/// <typeparam name="T">具體的 Domain Resource 類型</typeparam>
public abstract class GenericDomainResource<T> : GenericResource<T>, IDomainResource 
    where T : GenericDomainResource<T>
{
    /// <summary>
    /// 人類可讀的敘述
    /// FHIR Path: DomainResource.text
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("text")]
    public virtual Narrative? Text { get; set; }

    /// <summary>
    /// 包含的資源
    /// FHIR Path: DomainResource.contained
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("contained")]
    public virtual List<IResource>? Contained { get; set; }

    /// <summary>
    /// 擴展
    /// FHIR Path: DomainResource.extension
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("extension")]
    public virtual List<Extension>? Extension { get; set; }

    /// <summary>
    /// 修飾符擴展
    /// FHIR Path: DomainResource.modifierExtension
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("modifierExtension")]
    public virtual List<Extension>? ModifierExtension { get; set; }

    /// <summary>
    /// 預設建構函式
    /// </summary>
    protected GenericDomainResource() : base() { }

    /// <summary>
    /// 建構函式，設定基本屬性
    /// </summary>
    /// <param name="id">資源 ID</param>
    protected GenericDomainResource(FhirId? id = null) : base(id) { }

    /// <summary>
    /// 驗證 Domain Resource 根據 FHIR R4 規則
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = base.Validate(validationContext).ToList();

        // 驗證 Narrative
        if (Text != null)
        {
            var narrativeValidation = Text.Validate(new ValidationContext(Text));
            results.AddRange(narrativeValidation);
        }

        // 驗證 Extension
        if (Extension != null)
        {
            foreach (var extension in Extension)
            {
                if (extension != null)
                {
                    var extensionValidation = extension.Validate(new ValidationContext(extension));
                    results.AddRange(extensionValidation);
                }
            }
        }

        // 驗證 ModifierExtension
        if (ModifierExtension != null)
        {
            foreach (var modifierExtension in ModifierExtension)
            {
                if (modifierExtension != null)
                {
                    var modifierExtensionValidation = modifierExtension.Validate(new ValidationContext(modifierExtension));
                    results.AddRange(modifierExtensionValidation);
                }
            }
        }

        // 驗證 Contained Resources
        if (Contained != null)
        {
            foreach (var contained in Contained)
            {
                if (contained != null)
                {
                    var containedValidation = contained.Validate(new ValidationContext(contained));
                    results.AddRange(containedValidation);
                }
            }
        }

        return results;
    }

    /// <summary>
    /// 添加擴展
    /// </summary>
    /// <param name="url">擴展 URL</param>
    /// <param name="value">擴展值</param>
    public virtual void AddExtension(FhirUri url, object? value = null)
    {
        Extension ??= new List<Extension>();
        
        var extension = new Extension
        {
            Url = url
        };

        // 根據值的類型設定適當的屬性
        if (value != null)
        {
            switch (value)
            {
                case FhirString stringValue:
                    extension.ValueString = stringValue;
                    break;
                case FhirInteger intValue:
                    extension.ValueInteger = intValue;
                    break;
                case FhirBoolean boolValue:
                    extension.ValueBoolean = boolValue;
                    break;
                case FhirDecimal decimalValue:
                    extension.ValueDecimal = decimalValue;
                    break;
                // 可以根據需要添加更多 FHIR 類型
            }
        }

        Extension.Add(extension);
    }

    /// <summary>
    /// 添加修飾符擴展
    /// </summary>
    /// <param name="url">擴展 URL</param>
    /// <param name="value">擴展值</param>
    public virtual void AddModifierExtension(FhirUri url, object? value = null)
    {
        ModifierExtension ??= new List<Extension>();
        
        var extension = new Extension
        {
            Url = url
        };

        // 根據值的類型設定適當的屬性
        if (value != null)
        {
            switch (value)
            {
                case FhirString stringValue:
                    extension.ValueString = stringValue;
                    break;
                case FhirInteger intValue:
                    extension.ValueInteger = intValue;
                    break;
                case FhirBoolean boolValue:
                    extension.ValueBoolean = boolValue;
                    break;
                case FhirDecimal decimalValue:
                    extension.ValueDecimal = decimalValue;
                    break;
                // 可以根據需要添加更多 FHIR 類型
            }
        }

        ModifierExtension.Add(extension);
    }

    /// <summary>
    /// 取得特定 URL 的擴展
    /// </summary>
    /// <param name="url">擴展 URL</param>
    /// <returns>擴展列表</returns>
    public virtual List<Extension> GetExtensions(FhirUri url)
    {
        return Extension?.Where(ext => ext.Url?.Value == url.Value).ToList() ?? new List<Extension>();
    }

    /// <summary>
    /// 取得特定 URL 的修飾符擴展
    /// </summary>
    /// <param name="url">擴展 URL</param>
    /// <returns>修飾符擴展列表</returns>
    public virtual List<Extension> GetModifierExtensions(FhirUri url)
    {
        return ModifierExtension?.Where(ext => ext.Url?.Value == url.Value).ToList() ?? new List<Extension>();
    }

    /// <summary>
    /// 檢查是否有特定 URL 的擴展
    /// </summary>
    /// <param name="url">擴展 URL</param>
    /// <returns>是否存在</returns>
    public virtual bool HasExtension(FhirUri url)
    {
        return Extension?.Any(ext => ext.Url?.Value == url.Value) == true;
    }

    /// <summary>
    /// 檢查是否有特定 URL 的修飾符擴展
    /// </summary>
    /// <param name="url">擴展 URL</param>
    /// <returns>是否存在</returns>
    public virtual bool HasModifierExtension(FhirUri url)
    {
        return ModifierExtension?.Any(ext => ext.Url?.Value == url.Value) == true;
    }

    /// <summary>
    /// 添加包含的資源
    /// </summary>
    /// <param name="resource">要包含的資源</param>
    public virtual void AddContained(IResource resource)
    {
        Contained ??= new List<IResource>();
        Contained.Add(resource);
    }

    /// <summary>
    /// 移除包含的資源
    /// </summary>
    /// <param name="resourceId">資源 ID</param>
    /// <returns>是否成功移除</returns>
    public virtual bool RemoveContained(FhirId resourceId)
    {
        if (Contained == null) return false;
        
        var toRemove = Contained.FirstOrDefault(r => r.Id?.Value == resourceId.Value);
        if (toRemove != null)
        {
            Contained.Remove(toRemove);
            return true;
        }
        
        return false;
    }

    /// <summary>
    /// 取得包含的特定類型資源
    /// </summary>
    /// <typeparam name="TResource">資源類型</typeparam>
    /// <returns>指定類型的包含資源列表</returns>
    public virtual List<TResource> GetContained<TResource>() where TResource : class, IResource
    {
        return Contained?.OfType<TResource>().ToList() ?? new List<TResource>();
    }

    /// <summary>
    /// 設定 Narrative
    /// </summary>
    /// <param name="status">Narrative 狀態</param>
    /// <param name="div">HTML 內容</param>
    public virtual void SetNarrative(FhirCode status, FhirString div)
    {
        Text = new Narrative
        {
            Status = status,
            Div = div
        };
    }

    /// <summary>
    /// 取得資源的摘要資訊（覆寫基類方法）
    /// </summary>
    /// <returns>資源摘要</returns>
    public override string GetSummary()
    {
        var baseSummary = base.GetSummary();
        var parts = new List<string> { baseSummary };

        if (Extension?.Count > 0)
            parts.Add($"Extensions: {Extension.Count}");

        if (ModifierExtension?.Count > 0)
            parts.Add($"ModifierExtensions: {ModifierExtension.Count}");

        if (Contained?.Count > 0)
            parts.Add($"Contained: {Contained.Count}");

        if (Text != null)
            parts.Add($"Narrative: {Text.Status?.Value ?? "unknown"}");

        return string.Join(", ", parts);
    }
}
