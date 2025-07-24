using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// FHIR Resource 類別 - 所有 FHIR 資源的基礎類別
/// </summary>
public abstract class Resource : Element, IResource
{
    /// <summary>
    /// The metadata about the resource. This is content that is maintained by the infrastructure.
    /// </summary>
    [JsonPropertyName("meta")]
    public IMeta? Meta { get; set; }

    /// <summary>
    /// A reference to a set of rules that were followed when the resource was constructed.
    /// </summary>
    [JsonPropertyName("implicitRules")]
    public string? ImplicitRules { get; set; }

    /// <summary>
    /// The base language in which the resource is written.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// 資源 ID
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public abstract string ResourceType { get; }

    /// <summary>
    /// 建立新的 Resource 實例
    /// </summary>
    protected Resource() { }

    /// <summary>
    /// 建立新的 Resource 實例
    /// </summary>
    /// <param name="element">基礎元素</param>
    protected Resource(Element? element = null) : base(element) { }

    /// <summary>
    /// 驗證此實例
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 驗證 Meta
        if (Meta != null)
        {
            // 這裡我們無法直接驗證，因為 Meta 是介面
            // 生成的類別會實作具體的驗證邏輯
        }
    }
} 