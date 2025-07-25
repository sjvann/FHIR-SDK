namespace Fhir.Generator.Models;

/// <summary>
/// FHIR 型別映射定義
/// 基於 FHIR 官方規範的完整型別映射
/// </summary>
public class FhirTypeMapping
{
    /// <summary>
    /// FHIR 型別名稱
    /// </summary>
    public string FhirType { get; set; } = string.Empty;
    
    /// <summary>
    /// C# 型別名稱
    /// </summary>
    public string CSharpType { get; set; } = string.Empty;
    
    /// <summary>
    /// 基礎型別（繼承自）
    /// </summary>
    public string BaseType { get; set; } = string.Empty;
    
    /// <summary>
    /// 型別類別
    /// </summary>
    public FhirTypeCategory Category { get; set; }
    
    /// <summary>
    /// 是否為抽象型別
    /// </summary>
    public bool IsAbstract { get; set; }
    
    /// <summary>
    /// JSON 序列化型別
    /// </summary>
    public string JsonType { get; set; } = string.Empty;
    
    /// <summary>
    /// XML 序列化型別
    /// </summary>
    public string XmlType { get; set; } = string.Empty;
    
    /// <summary>
    /// 原生 C# 型別（用於 Primitive Types）
    /// </summary>
    public string? NativeType { get; set; }
    
    /// <summary>
    /// 正規表達式驗證（用於 Primitive Types）
    /// </summary>
    public string? Regex { get; set; }
    
    /// <summary>
    /// 型別描述
    /// </summary>
    public string Description { get; set; } = string.Empty;
    
    /// <summary>
    /// 是否支援 Extensions
    /// </summary>
    public bool SupportsExtensions { get; set; } = true;
    
    /// <summary>
    /// 是否支援 Modifier Extensions
    /// </summary>
    public bool SupportsModifierExtensions { get; set; } = false;
    
    /// <summary>
    /// 屬性定義列表
    /// </summary>
    public List<PropertyDefinition> Properties { get; set; } = new();
    
    /// <summary>
    /// 驗證規則
    /// </summary>
    public List<ValidationRule> ValidationRules { get; set; } = new();
}

/// <summary>
/// FHIR 型別類別
/// </summary>
public enum FhirTypeCategory
{
    /// <summary>
    /// 基礎抽象型別
    /// </summary>
    Base,
    
    /// <summary>
    /// 基本型別（Primitive Types）
    /// </summary>
    Primitive,
    
    /// <summary>
    /// 複雜資料型別（Complex DataTypes）
    /// </summary>
    DataType,
    
    /// <summary>
    /// 後端型別（BackboneType）
    /// </summary>
    BackboneType,
    
    /// <summary>
    /// 後端元素（BackboneElement）
    /// </summary>
    BackboneElement,
    
    /// <summary>
    /// 資源（Resource）
    /// </summary>
    Resource,
    
    /// <summary>
    /// 領域資源（DomainResource）
    /// </summary>
    DomainResource,
    
    /// <summary>
    /// 中繼資料型別（MetaDataTypes）
    /// </summary>
    MetaDataType,
    
    /// <summary>
    /// 特殊用途型別
    /// </summary>
    SpecialPurpose
}

/// <summary>
/// Choice Type 定義
/// 處理 FHIR 的 value[x] 型別
/// </summary>
public class ChoiceTypeDefinition
{
    /// <summary>
    /// 基礎屬性名稱（如 "value"）
    /// </summary>
    public string BaseName { get; set; } = string.Empty;
    
    /// <summary>
    /// 允許的型別列表
    /// </summary>
    public List<string> AllowedTypes { get; set; } = new();
    
    /// <summary>
    /// 是否為必要屬性
    /// </summary>
    public bool IsRequired { get; set; }
    
    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; set; } = string.Empty;
}

/// <summary>
/// Reference Type 定義
/// 處理 FHIR 的 Reference 型別
/// </summary>
public class ReferenceTypeDefinition
{
    /// <summary>
    /// 允許的目標資源型別
    /// </summary>
    public List<string> TargetTypes { get; set; } = new();
    
    /// <summary>
    /// 是否允許任何資源型別
    /// </summary>
    public bool AllowAnyResource { get; set; } = true;
    
    /// <summary>
    /// 目標設定檔 URLs
    /// </summary>
    public List<string> TargetProfiles { get; set; } = new();
    
    /// <summary>
    /// 是否為必要屬性
    /// </summary>
    public bool IsRequired { get; set; }
    
    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; set; } = string.Empty;
}

/// <summary>
/// Extension 定義
/// </summary>
public class ExtensionDefinition
{
    /// <summary>
    /// Extension URL
    /// </summary>
    public string Url { get; set; } = string.Empty;
    
    /// <summary>
    /// 值型別
    /// </summary>
    public string ValueType { get; set; } = string.Empty;
    
    /// <summary>
    /// 是否為 Modifier Extension
    /// </summary>
    public bool IsModifier { get; set; }
    
    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; set; } = string.Empty;
}
