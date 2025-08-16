using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Utilities;

/// <summary>
/// 檔案工具類
/// </summary>
/// <remarks>
/// 提供檔案和目錄操作的輔助功能
/// </remarks>
public class FileUtils
{
    private readonly ILogger<FileUtils> _logger;

    public FileUtils(ILogger<FileUtils> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// 確保目錄存在
    /// </summary>
    public async Task EnsureDirectoryExistsAsync(string directoryPath)
    {
        await Task.CompletedTask; // 避免編譯器警告

        if (string.IsNullOrEmpty(directoryPath))
            return;

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
            _logger.LogDebug("創建目錄：{Directory}", directoryPath);
        }
    }

    /// <summary>
    /// 安全寫入檔案
    /// </summary>
    public async Task WriteFileAsync(string filePath, string content, bool overwrite = false)
    {
        // 確保目錄存在
        var directory = Path.GetDirectoryName(filePath);
        if (!string.IsNullOrEmpty(directory))
        {
            await EnsureDirectoryExistsAsync(directory);
        }

        // 檢查檔案是否已存在
        if (File.Exists(filePath) && !overwrite)
        {
            _logger.LogWarning("檔案已存在且不允許覆蓋：{File}", filePath);
            return;
        }

        try
        {
            await File.WriteAllTextAsync(filePath, content);
            _logger.LogDebug("已寫入檔案：{File} ({Size} 字元)", filePath, content.Length);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "寫入檔案失敗：{File}", filePath);
            throw;
        }
    }

    /// <summary>
    /// 安全讀取檔案
    /// </summary>
    public async Task<string?> ReadFileAsync(string filePath)
    {
        if (!File.Exists(filePath))
        {
            _logger.LogWarning("檔案不存在：{File}", filePath);
            return null;
        }

        try
        {
            var content = await File.ReadAllTextAsync(filePath);
            _logger.LogDebug("已讀取檔案：{File} ({Size} 字元)", filePath, content.Length);
            return content;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "讀取檔案失敗：{File}", filePath);
            throw;
        }
    }

    /// <summary>
    /// 備份檔案
    /// </summary>
    public async Task<string?> BackupFileAsync(string filePath)
    {
        if (!File.Exists(filePath))
            return null;

        var timestamp = DateTime.UtcNow.ToString("yyyyMMdd_HHmmss");
        var backupPath = $"{filePath}.backup_{timestamp}";

        try
        {
            File.Copy(filePath, backupPath);
            _logger.LogDebug("已備份檔案：{Original} -> {Backup}", filePath, backupPath);
            return backupPath;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "備份檔案失敗：{File}", filePath);
            return null;
        }

        await Task.CompletedTask; // 避免編譯器警告
    }

    /// <summary>
    /// 清理目錄
    /// </summary>
    public async Task CleanDirectoryAsync(string directoryPath, bool recursive = false)
    {
        await Task.CompletedTask; // 避免編譯器警告

        if (!Directory.Exists(directoryPath))
            return;

        try
        {
            var files = Directory.GetFiles(directoryPath);
            foreach (var file in files)
            {
                File.Delete(file);
                _logger.LogDebug("已刪除檔案：{File}", file);
            }

            if (recursive)
            {
                var directories = Directory.GetDirectories(directoryPath);
                foreach (var directory in directories)
                {
                    Directory.Delete(directory, true);
                    _logger.LogDebug("已刪除目錄：{Directory}", directory);
                }
            }

            _logger.LogInformation("已清理目錄：{Directory}", directoryPath);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "清理目錄失敗：{Directory}", directoryPath);
            throw;
        }
    }

    /// <summary>
    /// 複製目錄
    /// </summary>
    public async Task CopyDirectoryAsync(string sourceDir, string targetDir, bool overwrite = false)
    {
        await Task.CompletedTask; // 避免編譯器警告

        if (!Directory.Exists(sourceDir))
        {
            throw new DirectoryNotFoundException($"來源目錄不存在：{sourceDir}");
        }

        await EnsureDirectoryExistsAsync(targetDir);

        try
        {
            // 複製檔案
            var files = Directory.GetFiles(sourceDir);
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                var targetFile = Path.Combine(targetDir, fileName);

                if (!File.Exists(targetFile) || overwrite)
                {
                    File.Copy(file, targetFile, overwrite);
                    _logger.LogDebug("已複製檔案：{Source} -> {Target}", file, targetFile);
                }
            }

            // 遞迴複製子目錄
            var directories = Directory.GetDirectories(sourceDir);
            foreach (var directory in directories)
            {
                var dirName = Path.GetFileName(directory);
                var targetSubDir = Path.Combine(targetDir, dirName);
                await CopyDirectoryAsync(directory, targetSubDir, overwrite);
            }

            _logger.LogInformation("已複製目錄：{Source} -> {Target}", sourceDir, targetDir);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "複製目錄失敗：{Source} -> {Target}", sourceDir, targetDir);
            throw;
        }
    }

    /// <summary>
    /// 取得檔案清單
    /// </summary>
    public async Task<List<string>> GetFilesAsync(string directoryPath, string pattern = "*", bool recursive = false)
    {
        await Task.CompletedTask; // 避免編譯器警告

        if (!Directory.Exists(directoryPath))
            return new List<string>();

        try
        {
            var searchOption = recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            var files = Directory.GetFiles(directoryPath, pattern, searchOption).ToList();
            
            _logger.LogDebug("找到 {Count} 個檔案：{Directory} ({Pattern})", files.Count, directoryPath, pattern);
            return files;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "取得檔案清單失敗：{Directory}", directoryPath);
            return new List<string>();
        }
    }

    /// <summary>
    /// 驗證檔案路徑
    /// </summary>
    public bool IsValidFilePath(string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath))
            return false;

        try
        {
            var fileName = Path.GetFileName(filePath);
            var directory = Path.GetDirectoryName(filePath);

            // 檢查檔案名稱是否包含無效字符
            var invalidChars = Path.GetInvalidFileNameChars();
            if (fileName.IndexOfAny(invalidChars) >= 0)
                return false;

            // 檢查目錄路徑是否包含無效字符
            if (!string.IsNullOrEmpty(directory))
            {
                var invalidPathChars = Path.GetInvalidPathChars();
                if (directory.IndexOfAny(invalidPathChars) >= 0)
                    return false;
            }

            return true;
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// 取得檔案大小 (人類可讀格式)
    /// </summary>
    public string GetHumanReadableFileSize(long bytes)
    {
        string[] suffixes = { "B", "KB", "MB", "GB", "TB" };
        double size = bytes;
        int suffixIndex = 0;

        while (size >= 1024 && suffixIndex < suffixes.Length - 1)
        {
            size /= 1024;
            suffixIndex++;
        }

        return $"{size:F2} {suffixes[suffixIndex]}";
    }

    /// <summary>
    /// 取得檔案資訊摘要
    /// </summary>
    public async Task<string> GetFileInfoSummaryAsync(string filePath)
    {
        await Task.CompletedTask; // 避免編譯器警告

        if (!File.Exists(filePath))
            return "檔案不存在";

        try
        {
            var fileInfo = new FileInfo(filePath);
            var size = GetHumanReadableFileSize(fileInfo.Length);
            var lastModified = fileInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss");

            return $"大小: {size}, 修改時間: {lastModified}";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "取得檔案資訊失敗：{File}", filePath);
            return "無法取得檔案資訊";
        }
    }
}