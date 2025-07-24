using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// FHIR DomainResource 類別 - 包含敘述、擴展和包含資源的資源
/// </summary>
public abstract class DomainResource : Resource, IDomainResource
{
    /// <summary>
    /// Text summary of the resource, for human interpretation.
    /// </summary>
    [JsonPropertyName("text")]
    public INarrative? Text { get; set; }

    /// <summary>
    /// Contained, inline Resources.
    /// </summary>
    [JsonPropertyName("contained")]
    public List<IResource>? Contained { get; set; }

    /// <summary>
    /// Additional content defined by implementations.
    /// </summary>
    [JsonPropertyName("extension")]
    public new List<IExtension>? Extension { get; set; }

    /// <summary>
    /// Extensions that cannot be ignored.
    /// </summary>
    [JsonPropertyName("modifierExtension")]
    public List<IExtension>? ModifierExtension { get; set; }

    /// <summary>
    /// 建立新的 DomainResource 實例
    /// </summary>
    protected DomainResource() { }

    /// <summary>
    /// 建立新的 DomainResource 實例
    /// </summary>
    /// <param name="resource">基礎資源</param>
    protected DomainResource(Resource? resource = null) : base(resource) { }

    /// <summary>
    /// 驗證此實例
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 驗證包含的資源
        if (Contained != null)
        {
            foreach (var contained in Contained)
            {
                // 這裡我們無法直接驗證，因為 IResource 是介面
                // 生成的類別會實作具體的驗證邏輯
            }
        }
    }
} 