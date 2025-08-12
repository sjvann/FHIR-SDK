namespace FhirResourceGenerator.Configuration;

/// <summary>
/// 生成器配置
/// </summary>
/// <remarks>
/// 包含生成器的全域配置選項
/// </remarks>
public class GeneratorConfig
{
    /// <summary>
    /// 預設輸出目錄
    /// </summary>
    public string DefaultOutputDirectory { get; set; } = "Generated";

    /// <summary>
    /// 預設定義檔目錄
    /// </summary>
    public string DefaultDefinitionsDirectory { get; set; } = "Definitions";

    /// <summary>
    /// 預設命名空間前綴
    /// </summary>
    public string DefaultNamespacePrefix { get; set; } = "FhirCore";

    /// <summary>
    /// 是否生成文檔註解
    /// </summary>
    public bool GenerateDocumentation { get; set; } = true;

    /// <summary>
    /// 是否生成驗證屬性
    /// </summary>
    public bool GenerateValidationAttributes { get; set; } = true;

    /// <summary>
    /// 是否生成工廠方法
    /// </summary>
    public bool GenerateFactoryMethods { get; set; } = true;

    /// <summary>
    /// 是否生成測試檔案
    /// </summary>
    public bool GenerateTests { get; set; } = false;

    /// <summary>
    /// 程式碼縮排字元
    /// </summary>
    public string IndentationCharacter { get; set; } = "    "; // 4 個空格

    /// <summary>
    /// 行結尾字元
    /// </summary>
    public string LineEnding { get; set; } = Environment.NewLine;

    /// <summary>
    /// 最大檔案大小 (位元組)
    /// </summary>
    public long MaxFileSize { get; set; } = 1024 * 1024; // 1MB

    /// <summary>
    /// 支援的 FHIR 版本
    /// </summary>
    public List<string> SupportedVersions { get; set; } = new() { "R4", "R5", "R6" };

    /// <summary>
    /// 排除的資源類型
    /// </summary>
    public List<string> ExcludedResourceTypes { get; set; } = new();

    /// <summary>
    /// 自訂類型映射
    /// </summary>
    public Dictionary<string, string> CustomTypeMappings { get; set; } = new();

    /// <summary>
    /// 模板設定
    /// </summary>
    public TemplateSettings Templates { get; set; } = new();

    /// <summary>
    /// 驗證設定
    /// </summary>
    public ValidationSettings Validation { get; set; } = new();

    /// <summary>
    /// 記錄設定
    /// </summary>
    public LoggingSettings Logging { get; set; } = new();
}

/// <summary>
/// 模板設定
/// </summary>
public class TemplateSettings
{
    /// <summary>
    /// 使用自訂模板
    /// </summary>
    public bool UseCustomTemplates { get; set; } = false;

    /// <summary>
    /// 自訂模板目錄
    /// </summary>
    public string? CustomTemplateDirectory { get; set; }

    /// <summary>
    /// 模板快取啟用
    /// </summary>
    public bool EnableTemplateCache { get; set; } = true;

    /// <summary>
    /// 模板變數
    /// </summary>
    public Dictionary<string, object> Variables { get; set; } = new();
}

/// <summary>
/// 驗證設定
/// </summary>
public class ValidationSettings
{
    /// <summary>
    /// 啟用資源驗證
    /// </summary>
    public bool EnableResourceValidation { get; set; } = true;

    /// <summary>
    /// 啟用程式碼驗證
    /// </summary>
    public bool EnableCodeValidation { get; set; } = true;

    /// <summary>
    /// 驗證規則檔案
    /// </summary>
    public string? ValidationRulesFile { get; set; }

    /// <summary>
    /// 忽略的驗證錯誤
    /// </summary>
    public List<string> IgnoredValidationErrors { get; set; } = new();
}

/// <summary>
/// 記錄設定
/// </summary>
public class LoggingSettings
{
    /// <summary>
    /// 記錄層級
    /// </summary>
    public string LogLevel { get; set; } = "Information";

    /// <summary>
    /// 記錄檔路徑
    /// </summary>
    public string? LogFilePath { get; set; }

    /// <summary>
    /// 啟用控制台記錄
    /// </summary>
    public bool EnableConsoleLogging { get; set; } = true;

    /// <summary>
    /// 啟用詳細記錄
    /// </summary>
    public bool EnableVerboseLogging { get; set; } = false;
}