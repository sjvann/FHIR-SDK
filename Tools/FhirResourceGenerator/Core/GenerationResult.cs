namespace FhirResourceGenerator.Core;

/// <summary>
/// 生成結果
/// 
/// <para>
/// 包含資源生成過程的結果和統計資訊。
/// </para>
/// </summary>
public class GenerationResult
{
    /// <summary>
    /// 是否成功
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// 錯誤訊息
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// 生成的檔案列表
    /// </summary>
    public List<GeneratedFile> GeneratedFiles { get; set; } = new();

    /// <summary>
    /// 生成的資源數量
    /// </summary>
    public int GeneratedResourceCount { get; set; }

    /// <summary>
    /// 生成的工廠方法數量
    /// </summary>
    public int GeneratedFactoryCount { get; set; }

    /// <summary>
    /// 生成的測試檔案數量
    /// </summary>
    public int GeneratedTestCount { get; set; }

    /// <summary>
    /// 開始時間
    /// </summary>
    public DateTime StartTime { get; set; }

    /// <summary>
    /// 結束時間
    /// </summary>
    public DateTime EndTime { get; set; }

    /// <summary>
    /// 總耗時
    /// </summary>
    public TimeSpan Duration => EndTime - StartTime;

    /// <summary>
    /// 警告訊息
    /// </summary>
    public List<string> Warnings { get; set; } = new();

    /// <summary>
    /// 建立成功結果
    /// </summary>
    public static GenerationResult Success()
    {
        return new GenerationResult { IsSuccess = true };
    }

    /// <summary>
    /// 建立失敗結果
    /// </summary>
    public static GenerationResult Failure(string errorMessage)
    {
        return new GenerationResult 
        { 
            IsSuccess = false, 
            ErrorMessage = errorMessage 
        };
    }

    /// <summary>
    /// 新增生成的檔案
    /// </summary>
    public void AddGeneratedFile(string filePath, string content, GeneratedFileType type)
    {
        GeneratedFiles.Add(new GeneratedFile
        {
            FilePath = filePath,
            Content = content,
            Type = type,
            GeneratedAt = DateTime.UtcNow
        });

        // 更新統計
        switch (type)
        {
            case GeneratedFileType.Resource:
                GeneratedResourceCount++;
                break;
            case GeneratedFileType.Factory:
                GeneratedFactoryCount++;
                break;
            case GeneratedFileType.Test:
                GeneratedTestCount++;
                break;
        }
    }
}

/// <summary>
/// 生成的檔案
/// </summary>
public class GeneratedFile
{
    /// <summary>
    /// 檔案路徑
    /// </summary>
    public string FilePath { get; set; } = string.Empty;

    /// <summary>
    /// 檔案內容
    /// </summary>
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// 檔案類型
    /// </summary>
    public GeneratedFileType Type { get; set; }

    /// <summary>
    /// 生成時間
    /// </summary>
    public DateTime GeneratedAt { get; set; }

    /// <summary>
    /// 檔案大小（位元組）
    /// </summary>
    public int Size => System.Text.Encoding.UTF8.GetByteCount(Content);
}

/// <summary>
/// 生成檔案類型
/// </summary>
public enum GeneratedFileType
{
    /// <summary>
    /// 資源類別
    /// </summary>
    Resource,

    /// <summary>
    /// 工廠類別
    /// </summary>
    Factory,

    /// <summary>
    /// 測試類別
    /// </summary>
    Test,

    /// <summary>
    /// 專案檔
    /// </summary>
    Project,

    /// <summary>
    /// 配置檔
    /// </summary>
    Configuration,

    /// <summary>
    /// 文檔檔案
    /// </summary>
    Documentation
}