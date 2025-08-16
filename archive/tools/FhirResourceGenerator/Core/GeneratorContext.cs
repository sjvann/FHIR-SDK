namespace FhirResourceGenerator.Core;

/// <summary>
/// 生成上下文
/// </summary>
/// <remarks>
/// 包含生成過程中需要的所有配置和狀態資訊
/// </remarks>
public class GeneratorContext
{
    /// <summary>
    /// FHIR 版本 (R4, R5, R6)
    /// </summary>
    public string Version { get; set; } = string.Empty;

    /// <summary>
    /// 定義檔路徑
    /// </summary>
    public string DefinitionsPath { get; set; } = string.Empty;

    /// <summary>
    /// 輸出路徑
    /// </summary>
    public string OutputPath { get; set; } = string.Empty;

    /// <summary>
    /// 目標資源 (null 表示全部)
    /// </summary>
    public List<string>? TargetResources { get; set; }

    /// <summary>
    /// 是否強制覆蓋
    /// </summary>
    public bool ForceOverwrite { get; set; }

    /// <summary>
    /// 是否包含測試
    /// </summary>
    public bool IncludeTests { get; set; }

    /// <summary>
    /// 額外設定
    /// </summary>
    public Dictionary<string, object> AdditionalSettings { get; set; } = new();

    /// <summary>
    /// 驗證上下文
    /// </summary>
    public bool IsValid()
    {
        return !string.IsNullOrEmpty(Version) &&
               !string.IsNullOrEmpty(DefinitionsPath) &&
               !string.IsNullOrEmpty(OutputPath);
    }
}

/// <summary>
/// 生成結果
/// </summary>
/// <remarks>
/// 包含生成過程的結果和統計資訊
/// </remarks>
public class GenerationResult
{
    /// <summary>
    /// 是否成功
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 錯誤訊息
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// 生成的資源數量
    /// </summary>
    public int ResourcesGenerated { get; set; }

    /// <summary>
    /// 生成的檔案數量
    /// </summary>
    public int FilesGenerated { get; set; }

    /// <summary>
    /// 生成的檔案列表
    /// </summary>
    public List<string> GeneratedFiles { get; set; } = new();

    /// <summary>
    /// 警告訊息
    /// </summary>
    public List<string> Warnings { get; set; } = new();

    /// <summary>
    /// 詳細資訊
    /// </summary>
    public Dictionary<string, object> Details { get; set; } = new();

    /// <summary>
    /// 生成開始時間
    /// </summary>
    public DateTime StartTime { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// 生成結束時間
    /// </summary>
    public DateTime EndTime { get; set; }

    /// <summary>
    /// 生成耗時
    /// </summary>
    public TimeSpan Duration => EndTime - StartTime;

    /// <summary>
    /// 創建成功結果
    /// </summary>
    public static GenerationResult CreateSuccess(int resourcesGenerated, int filesGenerated)
    {
        return new GenerationResult
        {
            Success = true,
            ResourcesGenerated = resourcesGenerated,
            FilesGenerated = filesGenerated,
            EndTime = DateTime.UtcNow
        };
    }

    /// <summary>
    /// 創建失敗結果
    /// </summary>
    public static GenerationResult CreateFailure(string errorMessage)
    {
        return new GenerationResult
        {
            Success = false,
            ErrorMessage = errorMessage,
            EndTime = DateTime.UtcNow
        };
    }
}

/// <summary>
/// 模板上下文
/// </summary>
/// <remarks>
/// 模板引擎使用的上下文資訊
/// </remarks>
public class TemplateContext
{
    /// <summary>
    /// FHIR 版本
    /// </summary>
    public string FhirVersion { get; set; } = string.Empty;

    /// <summary>
    /// 命名空間
    /// </summary>
    public string Namespace { get; set; } = string.Empty;

    /// <summary>
    /// 使用的引用
    /// </summary>
    public List<string> Usings { get; set; } = new();

    /// <summary>
    /// 類型映射
    /// </summary>
    public Dictionary<string, string> TypeMappings { get; set; } = new();

    /// <summary>
    /// 版本特定設定
    /// </summary>
    public Dictionary<string, object> VersionSettings { get; set; } = new();

    /// <summary>
    /// 模板變數
    /// </summary>
    public Dictionary<string, object> Variables { get; set; } = new();
}