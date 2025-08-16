namespace FhirResourceGenerator.Core;

/// <summary>
/// 資源定義
/// 
/// <para>
/// 表示從 FHIR StructureDefinition 解析出的資源定義資訊。
/// </para>
/// </summary>
public class ResourceDefinition
{
    /// <summary>
    /// 資源名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 資源類型
    /// </summary>
    public string Kind { get; set; } = string.Empty;

    /// <summary>
    /// 是否為抽象資源
    /// </summary>
    public bool Abstract { get; set; }

    /// <summary>
    /// 基礎定義 URL
    /// </summary>
    public string? BaseDefinition { get; set; }

    /// <summary>
    /// 資源 URL
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// 版本
    /// </summary>
    public string? Version { get; set; }

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
    /// 是否為 BackboneElement
    /// </summary>
    public bool IsBackboneElement => Kind.Equals("complex-type", StringComparison.OrdinalIgnoreCase) 
                                    && BaseDefinition?.EndsWith("BackboneElement") == true;

    /// <summary>
    /// 是否為 DataType
    /// </summary>
    public bool IsDataType => Kind.Equals("primitive-type", StringComparison.OrdinalIgnoreCase) 
                             || Kind.Equals("complex-type", StringComparison.OrdinalIgnoreCase);

    /// <summary>
    /// 取得根元素（資源本身的定義）
    /// </summary>
    public ElementDefinition? RootElement => Elements.FirstOrDefault(e => e.Path == Name);

    /// <summary>
    /// 取得屬性元素（非根元素）
    /// </summary>
    public IEnumerable<ElementDefinition> PropertyElements => Elements.Where(e => e.Path != Name && !e.Path.Contains('['));
}

/// <summary>
/// 元素定義
/// 
/// <para>
/// 表示 FHIR ElementDefinition 的資訊。
/// </para>
/// </summary>
public class ElementDefinition
{
    /// <summary>
    /// 元素路徑
    /// </summary>
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// 元素名稱（路徑的最後一部分）
    /// </summary>
    public string Name => Path.Split('.').Last();

    /// <summary>
    /// 最小出現次數
    /// </summary>
    public int Min { get; set; }

    /// <summary>
    /// 最大出現次數（*表示無限制）
    /// </summary>
    public string Max { get; set; } = "1";

    /// <summary>
    /// 是否為陣列
    /// </summary>
    public bool IsArray => Max != "1";

    /// <summary>
    /// 是否為必填
    /// </summary>
    public bool IsRequired => Min > 0;

    /// <summary>
    /// 型別定義
    /// </summary>
    public List<TypeRef> Types { get; set; } = new();

    /// <summary>
    /// 簡短描述
    /// </summary>
    public string? Short { get; set; }

    /// <summary>
    /// 詳細定義
    /// </summary>
    public string? Definition { get; set; }

    /// <summary>
    /// 註解
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// 是否為 ChoiceType
    /// </summary>
    public bool IsChoiceType => Types.Count > 1 || Name.EndsWith("[x]");

    /// <summary>
    /// 取得 C# 屬性名稱
    /// </summary>
    public string PropertyName
    {
        get
        {
            var name = Name;
            if (name.EndsWith("[x]"))
            {
                name = name[..^3]; // 移除 [x]
            }
            return char.ToUpper(name[0]) + name[1..];
        }
    }
}

/// <summary>
/// 型別參考
/// </summary>
public class TypeRef
{
    /// <summary>
    /// 型別代碼
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// Profile URL
    /// </summary>
    public string? Profile { get; set; }

    /// <summary>
    /// 目標 Profile
    /// </summary>
    public List<string> TargetProfile { get; set; } = new();
}

/// <summary>
/// 資料類型定義
/// </summary>
public class DataTypeDefinition
{
    /// <summary>
    /// 型別名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 基礎型別
    /// </summary>
    public string? BaseType { get; set; }

    /// <summary>
    /// 是否為 primitive type
    /// </summary>
    public bool IsPrimitive { get; set; }

    /// <summary>
    /// 元素定義
    /// </summary>
    public List<ElementDefinition> Elements { get; set; } = new();
}

/// <summary>
/// 版本元資料
/// </summary>
public class VersionMetadata
{
    /// <summary>
    /// FHIR 版本
    /// </summary>
    public string Version { get; set; } = string.Empty;

    /// <summary>
    /// 發布日期
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// 支援的資源列表
    /// </summary>
    public List<string> SupportedResources { get; set; } = new();

    /// <summary>
    /// 支援的資料類型列表
    /// </summary>
    public List<string> SupportedDataTypes { get; set; } = new();
}

/// <summary>
/// 文檔資料
/// </summary>
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
    /// 使用範例
    /// </summary>
    public string? Example { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remarks { get; set; }

    /// <summary>
    /// 相關連結
    /// </summary>
    public List<string> SeeAlso { get; set; } = new();
}

/// <summary>
/// 約束定義
/// </summary>
public class ConstraintDefinition
{
    /// <summary>
    /// 約束鍵值
    /// </summary>
    public string Key { get; set; } = string.Empty;

    /// <summary>
    /// 嚴重程度
    /// </summary>
    public string Severity { get; set; } = string.Empty;

    /// <summary>
    /// 人類可讀的描述
    /// </summary>
    public string Human { get; set; } = string.Empty;

    /// <summary>
    /// XPath 表達式
    /// </summary>
    public string? Expression { get; set; }
}

/// <summary>
/// 專案資訊
/// </summary>
public class ProjectInfo
{
    /// <summary>
    /// 專案名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 目標框架
    /// </summary>
    public string TargetFramework { get; set; } = "net9.0";

    /// <summary>
    /// 專案描述
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// 版本
    /// </summary>
    public string Version { get; set; } = "1.0.0";

    /// <summary>
    /// 相依性套件
    /// </summary>
    public List<PackageReference> PackageReferences { get; set; } = new();

    /// <summary>
    /// 專案參考
    /// </summary>
    public List<string> ProjectReferences { get; set; } = new();
}

/// <summary>
/// 套件參考
/// </summary>
public class PackageReference
{
    /// <summary>
    /// 套件名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 版本
    /// </summary>
    public string Version { get; set; } = string.Empty;
}