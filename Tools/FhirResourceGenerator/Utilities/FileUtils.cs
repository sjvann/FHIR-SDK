using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Utilities;

/// <summary>
/// �ɮפu����
/// </summary>
/// <remarks>
/// �����ɮשM�ؿ��ާ@�����U�\��
/// </remarks>
public class FileUtils
{
    private readonly ILogger<FileUtils> _logger;

    public FileUtils(ILogger<FileUtils> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// �T�O�ؿ��s�b
    /// </summary>
    public async Task EnsureDirectoryExistsAsync(string directoryPath)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

        if (string.IsNullOrEmpty(directoryPath))
            return;

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
            _logger.LogDebug("�Ыإؿ��G{Directory}", directoryPath);
        }
    }

    /// <summary>
    /// �w���g�J�ɮ�
    /// </summary>
    public async Task WriteFileAsync(string filePath, string content, bool overwrite = false)
    {
        // �T�O�ؿ��s�b
        var directory = Path.GetDirectoryName(filePath);
        if (!string.IsNullOrEmpty(directory))
        {
            await EnsureDirectoryExistsAsync(directory);
        }

        // �ˬd�ɮ׬O�_�w�s�b
        if (File.Exists(filePath) && !overwrite)
        {
            _logger.LogWarning("�ɮפw�s�b�B�����\�л\�G{File}", filePath);
            return;
        }

        try
        {
            await File.WriteAllTextAsync(filePath, content);
            _logger.LogDebug("�w�g�J�ɮסG{File} ({Size} �r��)", filePath, content.Length);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "�g�J�ɮץ��ѡG{File}", filePath);
            throw;
        }
    }

    /// <summary>
    /// �w��Ū���ɮ�
    /// </summary>
    public async Task<string?> ReadFileAsync(string filePath)
    {
        if (!File.Exists(filePath))
        {
            _logger.LogWarning("�ɮפ��s�b�G{File}", filePath);
            return null;
        }

        try
        {
            var content = await File.ReadAllTextAsync(filePath);
            _logger.LogDebug("�wŪ���ɮסG{File} ({Size} �r��)", filePath, content.Length);
            return content;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ū���ɮץ��ѡG{File}", filePath);
            throw;
        }
    }

    /// <summary>
    /// �ƥ��ɮ�
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
            _logger.LogDebug("�w�ƥ��ɮסG{Original} -> {Backup}", filePath, backupPath);
            return backupPath;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "�ƥ��ɮץ��ѡG{File}", filePath);
            return null;
        }

        await Task.CompletedTask; // �קK�sĶ��ĵ�i
    }

    /// <summary>
    /// �M�z�ؿ�
    /// </summary>
    public async Task CleanDirectoryAsync(string directoryPath, bool recursive = false)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

        if (!Directory.Exists(directoryPath))
            return;

        try
        {
            var files = Directory.GetFiles(directoryPath);
            foreach (var file in files)
            {
                File.Delete(file);
                _logger.LogDebug("�w�R���ɮסG{File}", file);
            }

            if (recursive)
            {
                var directories = Directory.GetDirectories(directoryPath);
                foreach (var directory in directories)
                {
                    Directory.Delete(directory, true);
                    _logger.LogDebug("�w�R���ؿ��G{Directory}", directory);
                }
            }

            _logger.LogInformation("�w�M�z�ؿ��G{Directory}", directoryPath);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "�M�z�ؿ����ѡG{Directory}", directoryPath);
            throw;
        }
    }

    /// <summary>
    /// �ƻs�ؿ�
    /// </summary>
    public async Task CopyDirectoryAsync(string sourceDir, string targetDir, bool overwrite = false)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

        if (!Directory.Exists(sourceDir))
        {
            throw new DirectoryNotFoundException($"�ӷ��ؿ����s�b�G{sourceDir}");
        }

        await EnsureDirectoryExistsAsync(targetDir);

        try
        {
            // �ƻs�ɮ�
            var files = Directory.GetFiles(sourceDir);
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                var targetFile = Path.Combine(targetDir, fileName);

                if (!File.Exists(targetFile) || overwrite)
                {
                    File.Copy(file, targetFile, overwrite);
                    _logger.LogDebug("�w�ƻs�ɮסG{Source} -> {Target}", file, targetFile);
                }
            }

            // ���j�ƻs�l�ؿ�
            var directories = Directory.GetDirectories(sourceDir);
            foreach (var directory in directories)
            {
                var dirName = Path.GetFileName(directory);
                var targetSubDir = Path.Combine(targetDir, dirName);
                await CopyDirectoryAsync(directory, targetSubDir, overwrite);
            }

            _logger.LogInformation("�w�ƻs�ؿ��G{Source} -> {Target}", sourceDir, targetDir);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "�ƻs�ؿ����ѡG{Source} -> {Target}", sourceDir, targetDir);
            throw;
        }
    }

    /// <summary>
    /// ���o�ɮײM��
    /// </summary>
    public async Task<List<string>> GetFilesAsync(string directoryPath, string pattern = "*", bool recursive = false)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

        if (!Directory.Exists(directoryPath))
            return new List<string>();

        try
        {
            var searchOption = recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            var files = Directory.GetFiles(directoryPath, pattern, searchOption).ToList();
            
            _logger.LogDebug("��� {Count} ���ɮסG{Directory} ({Pattern})", files.Count, directoryPath, pattern);
            return files;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "���o�ɮײM�楢�ѡG{Directory}", directoryPath);
            return new List<string>();
        }
    }

    /// <summary>
    /// �����ɮ׸��|
    /// </summary>
    public bool IsValidFilePath(string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath))
            return false;

        try
        {
            var fileName = Path.GetFileName(filePath);
            var directory = Path.GetDirectoryName(filePath);

            // �ˬd�ɮצW�٬O�_�]�t�L�Ħr��
            var invalidChars = Path.GetInvalidFileNameChars();
            if (fileName.IndexOfAny(invalidChars) >= 0)
                return false;

            // �ˬd�ؿ����|�O�_�]�t�L�Ħr��
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
    /// ���o�ɮפj�p (�H���iŪ�榡)
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
    /// ���o�ɮ׸�T�K�n
    /// </summary>
    public async Task<string> GetFileInfoSummaryAsync(string filePath)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

        if (!File.Exists(filePath))
            return "�ɮפ��s�b";

        try
        {
            var fileInfo = new FileInfo(filePath);
            var size = GetHumanReadableFileSize(fileInfo.Length);
            var lastModified = fileInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss");

            return $"�j�p: {size}, �ק�ɶ�: {lastModified}";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "���o�ɮ׸�T���ѡG{File}", filePath);
            return "�L�k���o�ɮ׸�T";
        }
    }
}