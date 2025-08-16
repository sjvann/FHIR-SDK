using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Utilities;

/// <summary>
/// 驗證工具類
/// </summary>
/// <remarks>
/// 提供資源和程式碼驗證功能
/// </remarks>
public class ValidationUtils
{
    private readonly ILogger<ValidationUtils> _logger;

    public ValidationUtils(ILogger<ValidationUtils> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// 驗證資源定義
    /// </summary>
    public async Task<ValidationResult> ValidateResourceDefinitionAsync(ResourceDefinition definition)
    {
        await Task.CompletedTask; // 避免編譯器警告

        var result = new ValidationResult();

        try
        {
            // 檢查基本屬性
            if (string.IsNullOrEmpty(definition.Name))
            {
                result.AddError("資源名稱不能為空");
            }

            if (string.IsNullOrEmpty(definition.Kind))
            {
                result.AddError("資源種類不能為空");
            }

            // 檢查屬性定義
            foreach (var property in definition.Properties)
            {
                var propertyResult = ValidatePropertyDefinition(property);
                result.Merge(propertyResult);
            }

            // 檢查約束條件
            foreach (var constraint in definition.Constraints)
            {
                var constraintResult = ValidateConstraintDefinition(constraint);
                result.Merge(constraintResult);
            }

            _logger.LogDebug("驗證資源定義：{Name} - {IsValid}", definition.Name, result.IsValid);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "驗證資源定義時發生錯誤：{Name}", definition.Name);
            result.AddError($"驗證過程中發生錯誤：{ex.Message}");
        }

        return result;
    }

    /// <summary>
    /// 驗證屬性定義
    /// </summary>
    public ValidationResult ValidatePropertyDefinition(PropertyDefinition property)
    {
        var result = new ValidationResult();

        if (string.IsNullOrEmpty(property.Name))
        {
            result.AddError("屬性名稱不能為空");
        }

        if (string.IsNullOrEmpty(property.CSharpType))
        {
            result.AddError($"屬性 {property.Name} 的 C# 類型不能為空");
        }

        if (string.IsNullOrEmpty(property.FhirType))
        {
            result.AddError($"屬性 {property.Name} 的 FHIR 類型不能為空");
        }

        // 檢查屬性名稱是否為有效的 C# 識別符
        if (!IsValidCSharpIdentifier(property.Name))
        {
            result.AddWarning($"屬性名稱 {property.Name} 可能不是有效的 C# 識別符");
        }

        return result;
    }

    /// <summary>
    /// 驗證約束定義
    /// </summary>
    public ValidationResult ValidateConstraintDefinition(ConstraintDefinition constraint)
    {
        var result = new ValidationResult();

        if (string.IsNullOrEmpty(constraint.Key))
        {
            result.AddError("約束鍵值不能為空");
        }

        if (string.IsNullOrEmpty(constraint.Expression) && string.IsNullOrEmpty(constraint.Xpath))
        {
            result.AddWarning($"約束 {constraint.Key} 缺少表達式或 XPath");
        }

        return result;
    }

    /// <summary>
    /// 驗證生成的程式碼
    /// </summary>
    public async Task<ValidationResult> ValidateGeneratedCodeAsync(string code, string fileName)
    {
        await Task.CompletedTask; // 避免編譯器警告

        var result = new ValidationResult();

        try
        {
            // 基本語法檢查
            if (string.IsNullOrWhiteSpace(code))
            {
                result.AddError("生成的程式碼為空");
                return result;
            }

            // 檢查括號配對
            if (!AreBracketsBalanced(code))
            {
                result.AddError("括號不配對");
            }

            // 檢查必要的 using 語句
            if (!code.Contains("using System;"))
            {
                result.AddWarning("可能缺少 System 命名空間引用");
            }

            // 檢查類別定義
            if (!code.Contains("public class"))
            {
                result.AddError("找不到公開類別定義");
            }

            // 檢查命名空間
            if (!code.Contains("namespace"))
            {
                result.AddWarning("找不到命名空間定義");
            }

            _logger.LogDebug("驗證生成的程式碼：{FileName} - {IsValid}", fileName, result.IsValid);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "驗證生成的程式碼時發生錯誤：{FileName}", fileName);
            result.AddError($"驗證過程中發生錯誤：{ex.Message}");
        }

        return result;
    }

    /// <summary>
    /// 驗證專案結構
    /// </summary>
    public async Task<ValidationResult> ValidateProjectStructureAsync(string projectPath)
    {
        await Task.CompletedTask; // 避免編譯器警告

        var result = new ValidationResult();

        try
        {
            // 檢查專案目錄是否存在
            if (!Directory.Exists(projectPath))
            {
                result.AddError($"專案目錄不存在：{projectPath}");
                return result;
            }

            // 檢查必要的子目錄
            var requiredDirectories = new[] { "Resources", "Factory" };
            foreach (var dir in requiredDirectories)
            {
                var fullPath = Path.Combine(projectPath, dir);
                if (!Directory.Exists(fullPath))
                {
                    result.AddWarning($"建議的目錄不存在：{dir}");
                }
            }

            // 檢查專案檔案
            var projectFiles = Directory.GetFiles(projectPath, "*.csproj");
            if (projectFiles.Length == 0)
            {
                result.AddError("找不到專案檔案 (.csproj)");
            }

            _logger.LogDebug("驗證專案結構：{ProjectPath} - {IsValid}", projectPath, result.IsValid);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "驗證專案結構時發生錯誤：{ProjectPath}", projectPath);
            result.AddError($"驗證過程中發生錯誤：{ex.Message}");
        }

        return result;
    }

    /// <summary>
    /// 檢查是否為有效的 C# 識別符
    /// </summary>
    private bool IsValidCSharpIdentifier(string identifier)
    {
        if (string.IsNullOrEmpty(identifier))
            return false;

        // 檢查第一個字元
        if (!char.IsLetter(identifier[0]) && identifier[0] != '_')
            return false;

        // 檢查其餘字元
        for (int i = 1; i < identifier.Length; i++)
        {
            if (!char.IsLetterOrDigit(identifier[i]) && identifier[i] != '_')
                return false;
        }

        return true;
    }

    /// <summary>
    /// 檢查括號是否配對
    /// </summary>
    private bool AreBracketsBalanced(string code)
    {
        var stack = new Stack<char>();
        var brackets = new Dictionary<char, char>
        {
            ['('] = ')',
            ['['] = ']',
            ['{'] = '}'
        };

        foreach (var ch in code)
        {
            if (brackets.ContainsKey(ch))
            {
                stack.Push(ch);
            }
            else if (brackets.ContainsValue(ch))
            {
                if (stack.Count == 0)
                    return false;

                var opening = stack.Pop();
                if (brackets[opening] != ch)
                    return false;
            }
        }

        return stack.Count == 0;
    }
}

/// <summary>
/// 驗證結果
/// </summary>
/// <remarks>
/// 包含驗證過程的結果和訊息
/// </remarks>
public class ValidationResult
{
    /// <summary>
    /// 錯誤訊息列表
    /// </summary>
    public List<string> Errors { get; } = new();

    /// <summary>
    /// 警告訊息列表
    /// </summary>
    public List<string> Warnings { get; } = new();

    /// <summary>
    /// 資訊訊息列表
    /// </summary>
    public List<string> Information { get; } = new();

    /// <summary>
    /// 是否有效 (沒有錯誤)
    /// </summary>
    public bool IsValid => Errors.Count == 0;

    /// <summary>
    /// 是否有警告
    /// </summary>
    public bool HasWarnings => Warnings.Count > 0;

    /// <summary>
    /// 總計訊息數
    /// </summary>
    public int TotalMessages => Errors.Count + Warnings.Count + Information.Count;

    /// <summary>
    /// 添加錯誤訊息
    /// </summary>
    public void AddError(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            Errors.Add(message);
        }
    }

    /// <summary>
    /// 添加警告訊息
    /// </summary>
    public void AddWarning(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            Warnings.Add(message);
        }
    }

    /// <summary>
    /// 添加資訊訊息
    /// </summary>
    public void AddInformation(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            Information.Add(message);
        }
    }

    /// <summary>
    /// 合併其他驗證結果
    /// </summary>
    public void Merge(ValidationResult other)
    {
        Errors.AddRange(other.Errors);
        Warnings.AddRange(other.Warnings);
        Information.AddRange(other.Information);
    }

    /// <summary>
    /// 取得摘要字串
    /// </summary>
    public string GetSummary()
    {
        if (IsValid && !HasWarnings)
            return "驗證通過";

        var parts = new List<string>();
        
        if (Errors.Count > 0)
            parts.Add($"{Errors.Count} 個錯誤");
        
        if (Warnings.Count > 0)
            parts.Add($"{Warnings.Count} 個警告");
        
        if (Information.Count > 0)
            parts.Add($"{Information.Count} 個資訊");

        return string.Join(", ", parts);
    }

    /// <summary>
    /// 取得詳細報告
    /// </summary>
    public string GetDetailedReport()
    {
        var report = new List<string>();

        if (Errors.Count > 0)
        {
            report.Add("錯誤：");
            report.AddRange(Errors.Select(e => $"  - {e}"));
            report.Add("");
        }

        if (Warnings.Count > 0)
        {
            report.Add("警告：");
            report.AddRange(Warnings.Select(w => $"  - {w}"));
            report.Add("");
        }

        if (Information.Count > 0)
        {
            report.Add("資訊：");
            report.AddRange(Information.Select(i => $"  - {i}"));
        }

        return string.Join(Environment.NewLine, report);
    }
}