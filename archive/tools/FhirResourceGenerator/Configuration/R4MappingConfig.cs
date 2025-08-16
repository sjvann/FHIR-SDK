namespace FhirResourceGenerator.Configuration;

/// <summary>
/// R4 映射配置
/// </summary>
/// <remarks>
/// 包含 FHIR R4 版本特定的映射和設定
/// </remarks>
public class R4MappingConfig
{
    /// <summary>
    /// R4 特有的類型映射
    /// </summary>
    public Dictionary<string, R4TypeMapping> R4TypeMappings { get; } = new()
    {
        // R4 特有的類型
        ["canonical"] = new R4TypeMapping("FhirCanonical", "DataTypeServices.DataTypes.PrimitiveTypes", true),
        ["url"] = new R4TypeMapping("FhirUrl", "DataTypeServices.DataTypes.PrimitiveTypes", true),
        ["uuid"] = new R4TypeMapping("FhirUuid", "DataTypeServices.DataTypes.PrimitiveTypes", true),
        
        // R4 中的複雜類型
        ["CodeableReference"] = new R4TypeMapping("CodeableReference", "DataTypeServices.DataTypes.ComplexTypes", false),
        ["RatioRange"] = new R4TypeMapping("RatioRange", "DataTypeServices.DataTypes.ComplexTypes", false),
        
        // R4 特定的資源引用
        ["Reference(Patient)"] = new R4TypeMapping("ReferenceType", "DataTypeServices.DataTypes.SpecialTypes", true),
        ["Reference(Practitioner)"] = new R4TypeMapping("ReferenceType", "DataTypeServices.DataTypes.SpecialTypes", true),
        ["Reference(Organization)"] = new R4TypeMapping("ReferenceType", "DataTypeServices.DataTypes.SpecialTypes", true),
    };

    /// <summary>
    /// R4 已移除的類型 (從 R5 移除但在 R4 中存在)
    /// </summary>
    public HashSet<string> R4RemovedTypes { get; } = new()
    {
        // 在 R5 中移除但 R4 中存在的類型
    };

    /// <summary>
    /// R4 新增的類型 (R4 中新增但 R5 中不存在)
    /// </summary>
    public HashSet<string> R4AddedTypes { get; } = new()
    {
        // R4 中新增的類型
    };

    /// <summary>
    /// R4 特有的約束條件
    /// </summary>
    public Dictionary<string, List<string>> R4Constraints { get; } = new()
    {
        ["Patient"] = new List<string>
        {
            "pat-1: SHALL have a contact's details or a reference to an organization",
            "pat-2: A patient SHALL have at least a family name or a given name or both"
        },
        ["Observation"] = new List<string>
        {
            "obs-1: Must have a code if you have a value",
            "obs-2: Must have either a value or data absent reason"
        }
    };

    /// <summary>
    /// R4 特有的命名空間
    /// </summary>
    public Dictionary<string, string> R4Namespaces { get; } = new()
    {
        ["Resources"] = "FhirCore.R4.Resources",
        ["Factory"] = "FhirCore.R4.Factory",
        ["Extensions"] = "FhirCore.R4.Extensions",
        ["Validation"] = "FhirCore.R4.Validation"
    };

    /// <summary>
    /// R4 版本特定設定
    /// </summary>
    public R4VersionSettings VersionSettings { get; } = new();
}

/// <summary>
/// R4 類型映射
/// </summary>
public class R4TypeMapping
{
    /// <summary>
    /// C# 類型名稱
    /// </summary>
    public string CSharpType { get; }

    /// <summary>
    /// 命名空間
    /// </summary>
    public string Namespace { get; }

    /// <summary>
    /// 是否為原始類型
    /// </summary>
    public bool IsPrimitive { get; }

    /// <summary>
    /// 是否可為 null
    /// </summary>
    public bool IsNullable { get; }

    /// <summary>
    /// R4 特定註解
    /// </summary>
    public string? R4SpecificNote { get; set; }

    public R4TypeMapping(string csharpType, string @namespace, bool isPrimitive, bool isNullable = true)
    {
        CSharpType = csharpType;
        Namespace = @namespace;
        IsPrimitive = isPrimitive;
        IsNullable = isNullable;
    }
}

/// <summary>
/// R4 版本特定設定
/// </summary>
public class R4VersionSettings
{
    /// <summary>
    /// FHIR 版本字串
    /// </summary>
    public string FhirVersion { get; } = "4.0.1";

    /// <summary>
    /// 版本發布日期
    /// </summary>
    public DateTime ReleaseDate { get; } = new DateTime(2019, 10, 30);

    /// <summary>
    /// 支援的資源總數
    /// </summary>
    public int SupportedResourceCount { get; } = 130; // 大概數量

    /// <summary>
    /// R4 特有功能
    /// </summary>
    public List<string> R4SpecificFeatures { get; } = new()
    {
        "CodeableReference 類型支援",
        "增強的 Reference 類型",
        "改進的 Quantity 類型",
        "新的 url 和 canonical 原始類型"
    };

    /// <summary>
    /// 與 R5 的主要差異
    /// </summary>
    public List<string> DifferencesFromR5 { get; } = new()
    {
        "某些資源的屬性命名不同",
        "約束條件的表達式語法差異",
        "某些選擇類型的選項不同",
        "擴展機制的差異"
    };

    /// <summary>
    /// R4 特定的預設值
    /// </summary>
    public Dictionary<string, object> DefaultValues { get; } = new()
    {
        ["MaxStringLength"] = 1024 * 1024, // 1MB
        ["DefaultCurrency"] = "USD",
        ["DefaultLanguage"] = "en-US"
    };

    /// <summary>
    /// R4 特定的驗證規則
    /// </summary>
    public Dictionary<string, string> ValidationRules { get; } = new()
    {
        ["id"] = "^[A-Za-z0-9\\-\\.]{1,64}$",
        ["uri"] = "^\\S*$",
        ["code"] = "^[^\\s]+( [^\\s]+)*$"
    };
}

/// <summary>
/// R4 工廠設定
/// </summary>
public class R4FactorySettings
{
    /// <summary>
    /// 預設 ID 前綴
    /// </summary>
    public Dictionary<string, string> DefaultIdPrefixes { get; } = new()
    {
        ["Patient"] = "pat-",
        ["Practitioner"] = "prac-",
        ["Organization"] = "org-",
        ["Observation"] = "obs-",
        ["Condition"] = "cond-",
        ["Procedure"] = "proc-",
        ["Medication"] = "med-",
        ["MedicationRequest"] = "medreq-"
    };

    /// <summary>
    /// 測試資料模板
    /// </summary>
    public Dictionary<string, object> TestDataTemplates { get; } = new()
    {
        ["Patient"] = new
        {
            family = "Doe",
            given = new[] { "John" },
            gender = "male",
            birthDate = "1990-01-01"
        },
        ["Observation"] = new
        {
            status = "final",
            category = new[]
            {
                new
                {
                    coding = new[]
                    {
                        new
                        {
                            system = "http://terminology.hl7.org/CodeSystem/observation-category",
                            code = "vital-signs"
                        }
                    }
                }
            }
        }
    };
}

/// <summary>
/// R4 文檔設定
/// </summary>
public class R4DocumentationSettings
{
    /// <summary>
    /// 標準參考 URL
    /// </summary>
    public string StandardReferenceUrl { get; } = "http://hl7.org/fhir/R4/";

    /// <summary>
    /// 資源參考 URL 模板
    /// </summary>
    public string ResourceReferenceUrlTemplate { get; } = "http://hl7.org/fhir/R4/{resourceType}.html";

    /// <summary>
    /// 資料類型參考 URL 模板
    /// </summary>
    public string DataTypeReferenceUrlTemplate { get; } = "http://hl7.org/fhir/R4/datatypes.html#{dataType}";

    /// <summary>
    /// R4 特定文檔範本
    /// </summary>
    public Dictionary<string, string> DocumentationTemplates { get; } = new()
    {
        ["ResourceSummary"] = "FHIR R4 {ResourceName} 資源的實作",
        ["PropertySummary"] = "{PropertyName} - {Description}",
        ["ConstraintNote"] = "R4 約束：{ConstraintDescription}",
        ["UsageExample"] = "// 建立 {ResourceName} 資源\nvar {variableName} = new {ResourceName}(\"{resourceId}\");"
    };
}