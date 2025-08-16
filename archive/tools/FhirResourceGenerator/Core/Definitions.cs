namespace FhirResourceGenerator.Core;

/// <summary>
/// 資源定義
/// </summary>
/// <remarks>
/// 表示從 StructureDefinition 解析出的資源定義資訊
/// </remarks>
public class ResourceDefinition
{
    /// <summary>
    /// 資源名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 資源類型 (resource, complex-type, primitive-type)
    /// </summary>
    public string Kind { get; set; } = string.Empty;

    /// <summary>
    /// 是否為抽象類別
    /// </summary>
    public bool Abstract { get; set; }

    /// <summary>
    /// 基礎定義 URL
    /// </summary>
    public string? BaseDefinition { get; set; }

    /// <summary>
    /// 元素定義列表
    /// </summary>
    public List<ElementDefinition> Elements { get; set; } = new();

    /// <summary>
    /// 文檔資訊
    /// </summary>
    public DocumentationData Documentation { get; set; } = new();

    /// <summary>
    /// 約束條件
    /// </summary>
    public List<ConstraintDefinition> Constraints { get; set; } = new();

    /// <summary>
    /// 屬性定義 (從元素解析而來)
    /// </summary>
    public List<PropertyDefinition> Properties { get; set; } = new();

    /// <summary>
    /// 背骨元素定義
    /// </summary>
    public List<BackboneElementDefinition> BackboneElements { get; set; } = new();

    /// <summary>
    /// 選擇類型定義
    /// </summary>
    public List<ChoiceTypeDefinition> ChoiceTypes { get; set; } = new();

    /// <summary>
    /// URL
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// 版本
    /// </summary>
    public string? Version { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 實驗性質
    /// </summary>
    public bool Experimental { get; set; }

    /// <summary>
    /// 日期
    /// </summary>
    public string? Date { get; set; }

    /// <summary>
    /// 發布者
    /// </summary>
    public string? Publisher { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 用途
    /// </summary>
    public string? Purpose { get; set; }

    /// <summary>
    /// 著作權
    /// </summary>
    public string? Copyright { get; set; }
}

/// <summary>
/// 元素定義
/// </summary>
/// <remarks>
/// 表示 StructureDefinition 中的單一元素定義
/// </remarks>
public class ElementDefinition
{
    /// <summary>
    /// 元素 ID
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// 路徑
    /// </summary>
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// 表示列表
    /// </summary>
    public List<string> Representation { get; set; } = new();

    /// <summary>
    /// 切片名稱
    /// </summary>
    public string? SliceName { get; set; }

    /// <summary>
    /// 標籤
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// 簡短描述
    /// </summary>
    public string? Short { get; set; }

    /// <summary>
    /// 定義
    /// </summary>
    public string? Definition { get; set; }

    /// <summary>
    /// 註解
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// 需求
    /// </summary>
    public string? Requirements { get; set; }

    /// <summary>
    /// 別名
    /// </summary>
    public List<string> Alias { get; set; } = new();

    /// <summary>
    /// 最小出現次數
    /// </summary>
    public int Min { get; set; }

    /// <summary>
    /// 最大出現次數
    /// </summary>
    public string Max { get; set; } = string.Empty;

    /// <summary>
    /// 基礎資訊
    /// </summary>
    public ElementBase? Base { get; set; }

    /// <summary>
    /// 內容參考
    /// </summary>
    public string? ContentReference { get; set; }

    /// <summary>
    /// 類型列表
    /// </summary>
    public List<ElementType> Type { get; set; } = new();

    /// <summary>
    /// 預設值
    /// </summary>
    public object? DefaultValue { get; set; }

    /// <summary>
    /// 意義當缺少
    /// </summary>
    public string? MeaningWhenMissing { get; set; }

    /// <summary>
    /// 順序意義
    /// </summary>
    public string? OrderMeaning { get; set; }

    /// <summary>
    /// 固定值
    /// </summary>
    public object? Fixed { get; set; }

    /// <summary>
    /// 模式值
    /// </summary>
    public object? Pattern { get; set; }

    /// <summary>
    /// 範例
    /// </summary>
    public List<ElementExample> Example { get; set; } = new();

    /// <summary>
    /// 最小值
    /// </summary>
    public object? MinValue { get; set; }

    /// <summary>
    /// 最大值
    /// </summary>
    public object? MaxValue { get; set; }

    /// <summary>
    /// 最大長度
    /// </summary>
    public int? MaxLength { get; set; }

    /// <summary>
    /// 條件
    /// </summary>
    public List<string> Condition { get; set; } = new();

    /// <summary>
    /// 約束
    /// </summary>
    public List<ElementConstraint> Constraint { get; set; } = new();

    /// <summary>
    /// 必須支持
    /// </summary>
    public bool? MustSupport { get; set; }

    /// <summary>
    /// 是否修飾符
    /// </summary>
    public bool? IsModifier { get; set; }

    /// <summary>
    /// 修飾符原因
    /// </summary>
    public string? IsModifierReason { get; set; }

    /// <summary>
    /// 是否摘要
    /// </summary>
    public bool? IsSummary { get; set; }

    /// <summary>
    /// 綁定
    /// </summary>
    public ElementBinding? Binding { get; set; }

    /// <summary>
    /// 映射
    /// </summary>
    public List<ElementMapping> Mapping { get; set; } = new();
}

/// <summary>
/// 屬性定義
/// </summary>
/// <remarks>
/// 從元素定義轉換而來的 C# 屬性定義
/// </remarks>
public class PropertyDefinition
{
    /// <summary>
    /// 屬性名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// C# 類型
    /// </summary>
    public string CSharpType { get; set; } = string.Empty;

    /// <summary>
    /// FHIR 類型
    /// </summary>
    public string FhirType { get; set; } = string.Empty;

    /// <summary>
    /// 是否為陣列
    /// </summary>
    public bool IsArray { get; set; }

    /// <summary>
    /// 是否可為 null
    /// </summary>
    public bool IsNullable { get; set; }

    /// <summary>
    /// 最小出現次數
    /// </summary>
    public int MinOccurs { get; set; }

    /// <summary>
    /// 最大出現次數
    /// </summary>
    public string MaxOccurs { get; set; } = string.Empty;

    /// <summary>
    /// 簡短描述
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// 詳細描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 範例
    /// </summary>
    public string? Example { get; set; }

    /// <summary>
    /// 約束條件
    /// </summary>
    public List<string> Constraints { get; set; } = new();

    /// <summary>
    /// 驗證屬性
    /// </summary>
    public List<string> ValidationAttributes { get; set; } = new();

    /// <summary>
    /// 是否為選擇類型
    /// </summary>
    public bool IsChoiceType { get; set; }

    /// <summary>
    /// 選擇類型選項
    /// </summary>
    public List<string> ChoiceTypeOptions { get; set; } = new();

    /// <summary>
    /// 是否為背骨元素
    /// </summary>
    public bool IsBackboneElement { get; set; }

    /// <summary>
    /// 背骨元素名稱
    /// </summary>
    public string? BackboneElementName { get; set; }

    /// <summary>
    /// 預設值
    /// </summary>
    public string? DefaultValue { get; set; }
}

/// <summary>
/// 文檔資料
/// </summary>
/// <remarks>
/// 包含生成 XML 文檔註解所需的資訊
/// </remarks>
public class DocumentationData
{
    /// <summary>
    /// 摘要
    /// </summary>
    public string Summary { get; set; } = string.Empty;

    /// <summary>
    /// 詳細描述
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// 備註
    /// </summary>
    public string Remarks { get; set; } = string.Empty;

    /// <summary>
    /// 範例
    /// </summary>
    public string Example { get; set; } = string.Empty;

    /// <summary>
    /// 版本特點
    /// </summary>
    public List<string> VersionFeatures { get; set; } = new();

    /// <summary>
    /// 約束說明
    /// </summary>
    public List<string> ConstraintDescriptions { get; set; } = new();

    /// <summary>
    /// 參考連結
    /// </summary>
    public List<string> References { get; set; } = new();
}

/// <summary>
/// 約束定義
/// </summary>
/// <remarks>
/// 表示 FHIR 資源的約束條件
/// </remarks>
public class ConstraintDefinition
{
    /// <summary>
    /// 約束 ID
    /// </summary>
    public string Key { get; set; } = string.Empty;

    /// <summary>
    /// 嚴重程度
    /// </summary>
    public string Severity { get; set; } = string.Empty;

    /// <summary>
    /// 人類可讀描述
    /// </summary>
    public string Human { get; set; } = string.Empty;

    /// <summary>
    /// 表達式
    /// </summary>
    public string Expression { get; set; } = string.Empty;

    /// <summary>
    /// XPath 表達式
    /// </summary>
    public string? Xpath { get; set; }

    /// <summary>
    /// 來源
    /// </summary>
    public string? Source { get; set; }
}

/// <summary>
/// 背骨元素定義
/// </summary>
/// <remarks>
/// 表示需要生成的背骨元素類別
/// </remarks>
public class BackboneElementDefinition
{
    /// <summary>
    /// 類別名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 路徑
    /// </summary>
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// 屬性列表
    /// </summary>
    public List<PropertyDefinition> Properties { get; set; } = new();

    /// <summary>
    /// 文檔
    /// </summary>
    public DocumentationData Documentation { get; set; } = new();

    /// <summary>
    /// 約束
    /// </summary>
    public List<ConstraintDefinition> Constraints { get; set; } = new();
}

/// <summary>
/// 選擇類型定義
/// </summary>
/// <remarks>
/// 表示需要生成的選擇類型類別
/// </remarks>
public class ChoiceTypeDefinition
{
    /// <summary>
    /// 類別名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 前綴名稱
    /// </summary>
    public string PrefixName { get; set; } = string.Empty;

    /// <summary>
    /// 支援的類型
    /// </summary>
    public List<string> SupportedTypes { get; set; } = new();

    /// <summary>
    /// 文檔
    /// </summary>
    public DocumentationData Documentation { get; set; } = new();
}

/// <summary>
/// 資料類型定義
/// </summary>
/// <remarks>
/// 表示 FHIR 資料類型定義
/// </remarks>
public class DataTypeDefinition
{
    /// <summary>
    /// 類型名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 類型種類
    /// </summary>
    public string Kind { get; set; } = string.Empty;

    /// <summary>
    /// 基礎類型
    /// </summary>
    public string? BaseType { get; set; }

    /// <summary>
    /// 元素定義
    /// </summary>
    public List<ElementDefinition> Elements { get; set; } = new();

    /// <summary>
    /// 文檔
    /// </summary>
    public DocumentationData Documentation { get; set; } = new();
}

/// <summary>
/// 版本元資料
/// </summary>
/// <remarks>
/// 包含 FHIR 版本相關的元資料
/// </remarks>
public class VersionMetadata
{
    /// <summary>
    /// 版本號
    /// </summary>
    public string Version { get; set; } = string.Empty;

    /// <summary>
    /// 版本名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 發布日期
    /// </summary>
    public string? Date { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 說明
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 資源總數
    /// </summary>
    public int ResourceCount { get; set; }

    /// <summary>
    /// 支援的資源列表
    /// </summary>
    public List<string> SupportedResources { get; set; } = new();
}

// 輔助類別定義
public class ElementBase
{
    public string Path { get; set; } = string.Empty;
    public int Min { get; set; }
    public string Max { get; set; } = string.Empty;
}

public class ElementType
{
    public string Code { get; set; } = string.Empty;
    public List<string> Profile { get; set; } = new();
    public List<string> TargetProfile { get; set; } = new();
    public List<string> Aggregation { get; set; } = new();
    public string? Versioning { get; set; }
}

public class ElementExample
{
    public string Label { get; set; } = string.Empty;
    public object? Value { get; set; }
}

public class ElementConstraint
{
    public string Key { get; set; } = string.Empty;
    public string Requirements { get; set; } = string.Empty;
    public string Severity { get; set; } = string.Empty;
    public string Human { get; set; } = string.Empty;
    public string Expression { get; set; } = string.Empty;
    public string? Xpath { get; set; }
    public string? Source { get; set; }
}

public class ElementBinding
{
    public string Strength { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? ValueSet { get; set; }
}

public class ElementMapping
{
    public string Identity { get; set; } = string.Empty;
    public string? Language { get; set; }
    public string Map { get; set; } = string.Empty;
    public string? Comment { get; set; }
}