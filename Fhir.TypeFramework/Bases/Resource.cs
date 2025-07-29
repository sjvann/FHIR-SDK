using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Bases;

/// <summary>
/// This is the base resource type for everything.
/// 所有 FHIR Resources 的基礎類別
/// </summary>
/// <remarks>
/// FHIR R5 Resource (Abstract)
/// This is the base resource type for everything.
/// 
/// Structure:
/// - id: id (0..1) - Logical id of this artifact
/// - meta: Meta (0..1) - Metadata about the resource
/// - implicitRules: uri (0..1) - A set of rules under which this content was created
/// - language: code (0..1) - Language of the resource content
/// </remarks>
public abstract class Resource : DataType
{
    /// <summary>
    /// Logical id of this artifact.
    /// FHIR Path: Resource.id
    /// Cardinality: 0..1
    /// Type: id
    /// </summary>
    [JsonPropertyName("id")]
    public FhirId? Id { get; set; }
    
    /// <summary>
    /// Metadata about the resource.
    /// FHIR Path: Resource.meta
    /// Cardinality: 0..1
    /// Type: Meta
    /// </summary>
    [JsonPropertyName("meta")]
    public Meta? Meta { get; set; }
    
    /// <summary>
    /// A set of rules under which this content was created.
    /// FHIR Path: Resource.implicitRules
    /// Cardinality: 0..1
    /// Type: uri
    /// </summary>
    [JsonPropertyName("implicitRules")]
    public FhirUri? ImplicitRules { get; set; }
    
    /// <summary>
    /// Language of the resource content.
    /// FHIR Path: Resource.language
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("language")]
    public FhirCode? Language { get; set; }
    
    /// <summary>
    /// 取得資源型別名稱
    /// </summary>
    [JsonIgnore]
    public virtual string ResourceType => GetType().Name;
    
    /// <summary>
    /// 檢查是否有 Meta 資料
    /// </summary>
    /// <returns>如果存在 Meta 資料則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasMeta => Meta != null;
    
    /// <summary>
    /// 檢查是否有 ImplicitRules
    /// </summary>
    /// <returns>如果存在 ImplicitRules 則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasImplicitRules => ImplicitRules != null && !string.IsNullOrEmpty(ImplicitRules);
    
    /// <summary>
    /// 檢查是否有 Language
    /// </summary>
    /// <returns>如果存在 Language 則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasLanguage => Language != null && !string.IsNullOrEmpty(Language);
    
    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Resource 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = (Resource)MemberwiseClone();
        
        // 深層複製 Meta
        if (Meta != null)
        {
            copy.Meta = Meta.DeepCopy() as Meta;
        }
        
        // 呼叫 DataType 的 DeepCopy
        var baseCopy = base.DeepCopy() as Resource;
        if (baseCopy != null)
        {
            copy.Id = baseCopy.Id;
            copy.Extension = baseCopy.Extension;
        }
        
        return copy;
    }
    
    /// <summary>
    /// 判斷與另一個 Resource 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Resource otherResource)
            return false;

        // 先檢查 DataType 的相等性（包括 id 和 extension）
        if (!base.IsExactly(other))
            return false;

        return Equals(Meta, otherResource.Meta) &&
               Equals(ImplicitRules, otherResource.ImplicitRules) &&
               Equals(Language, otherResource.Language);
    }
    
    /// <summary>
    /// 驗證 Resource 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // ImplicitRules 驗證 - 使用 FhirUri 的內建驗證
        if (ImplicitRules != null)
        {
            var uriValidationContext = new ValidationContext(ImplicitRules);
            foreach (var result in ImplicitRules.Validate(uriValidationContext))
            {
                yield return result;
            }
        }
        
        // Language 驗證 - 使用 FhirCode 的內建驗證
        if (Language != null)
        {
            var languageValidationContext = new ValidationContext(Language);
            foreach (var result in Language.Validate(languageValidationContext))
            {
                yield return result;
            }
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
        
        // 呼叫 DataType 的驗證（包括 id 和 extension 驗證）
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
}
