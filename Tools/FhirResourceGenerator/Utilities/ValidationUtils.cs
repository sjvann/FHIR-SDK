using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Utilities;

/// <summary>
/// ���Ҥu����
/// </summary>
/// <remarks>
/// ���Ѹ귽�M�{���X���ҥ\��
/// </remarks>
public class ValidationUtils
{
    private readonly ILogger<ValidationUtils> _logger;

    public ValidationUtils(ILogger<ValidationUtils> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// ���Ҹ귽�w�q
    /// </summary>
    public async Task<ValidationResult> ValidateResourceDefinitionAsync(ResourceDefinition definition)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

        var result = new ValidationResult();

        try
        {
            // �ˬd���ݩ�
            if (string.IsNullOrEmpty(definition.Name))
            {
                result.AddError("�귽�W�٤��ର��");
            }

            if (string.IsNullOrEmpty(definition.Kind))
            {
                result.AddError("�귽�������ର��");
            }

            // �ˬd�ݩʩw�q
            foreach (var property in definition.Properties)
            {
                var propertyResult = ValidatePropertyDefinition(property);
                result.Merge(propertyResult);
            }

            // �ˬd��������
            foreach (var constraint in definition.Constraints)
            {
                var constraintResult = ValidateConstraintDefinition(constraint);
                result.Merge(constraintResult);
            }

            _logger.LogDebug("���Ҹ귽�w�q�G{Name} - {IsValid}", definition.Name, result.IsValid);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "���Ҹ귽�w�q�ɵo�Ϳ��~�G{Name}", definition.Name);
            result.AddError($"���ҹL�{���o�Ϳ��~�G{ex.Message}");
        }

        return result;
    }

    /// <summary>
    /// �����ݩʩw�q
    /// </summary>
    public ValidationResult ValidatePropertyDefinition(PropertyDefinition property)
    {
        var result = new ValidationResult();

        if (string.IsNullOrEmpty(property.Name))
        {
            result.AddError("�ݩʦW�٤��ର��");
        }

        if (string.IsNullOrEmpty(property.CSharpType))
        {
            result.AddError($"�ݩ� {property.Name} �� C# �������ର��");
        }

        if (string.IsNullOrEmpty(property.FhirType))
        {
            result.AddError($"�ݩ� {property.Name} �� FHIR �������ର��");
        }

        // �ˬd�ݩʦW�٬O�_�����Ī� C# �ѧO��
        if (!IsValidCSharpIdentifier(property.Name))
        {
            result.AddWarning($"�ݩʦW�� {property.Name} �i�ण�O���Ī� C# �ѧO��");
        }

        return result;
    }

    /// <summary>
    /// ���Ҭ����w�q
    /// </summary>
    public ValidationResult ValidateConstraintDefinition(ConstraintDefinition constraint)
    {
        var result = new ValidationResult();

        if (string.IsNullOrEmpty(constraint.Key))
        {
            result.AddError("������Ȥ��ର��");
        }

        if (string.IsNullOrEmpty(constraint.Expression) && string.IsNullOrEmpty(constraint.Xpath))
        {
            result.AddWarning($"���� {constraint.Key} �ʤ֪�F���� XPath");
        }

        return result;
    }

    /// <summary>
    /// ���ҥͦ����{���X
    /// </summary>
    public async Task<ValidationResult> ValidateGeneratedCodeAsync(string code, string fileName)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

        var result = new ValidationResult();

        try
        {
            // �򥻻y�k�ˬd
            if (string.IsNullOrWhiteSpace(code))
            {
                result.AddError("�ͦ����{���X����");
                return result;
            }

            // �ˬd�A���t��
            if (!AreBracketsBalanced(code))
            {
                result.AddError("�A�����t��");
            }

            // �ˬd���n�� using �y�y
            if (!code.Contains("using System;"))
            {
                result.AddWarning("�i��ʤ� System �R�W�Ŷ��ޥ�");
            }

            // �ˬd���O�w�q
            if (!code.Contains("public class"))
            {
                result.AddError("�䤣�줽�}���O�w�q");
            }

            // �ˬd�R�W�Ŷ�
            if (!code.Contains("namespace"))
            {
                result.AddWarning("�䤣��R�W�Ŷ��w�q");
            }

            _logger.LogDebug("���ҥͦ����{���X�G{FileName} - {IsValid}", fileName, result.IsValid);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "���ҥͦ����{���X�ɵo�Ϳ��~�G{FileName}", fileName);
            result.AddError($"���ҹL�{���o�Ϳ��~�G{ex.Message}");
        }

        return result;
    }

    /// <summary>
    /// ���ұM�׵��c
    /// </summary>
    public async Task<ValidationResult> ValidateProjectStructureAsync(string projectPath)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

        var result = new ValidationResult();

        try
        {
            // �ˬd�M�ץؿ��O�_�s�b
            if (!Directory.Exists(projectPath))
            {
                result.AddError($"�M�ץؿ����s�b�G{projectPath}");
                return result;
            }

            // �ˬd���n���l�ؿ�
            var requiredDirectories = new[] { "Resources", "Factory" };
            foreach (var dir in requiredDirectories)
            {
                var fullPath = Path.Combine(projectPath, dir);
                if (!Directory.Exists(fullPath))
                {
                    result.AddWarning($"��ĳ���ؿ����s�b�G{dir}");
                }
            }

            // �ˬd�M���ɮ�
            var projectFiles = Directory.GetFiles(projectPath, "*.csproj");
            if (projectFiles.Length == 0)
            {
                result.AddError("�䤣��M���ɮ� (.csproj)");
            }

            _logger.LogDebug("���ұM�׵��c�G{ProjectPath} - {IsValid}", projectPath, result.IsValid);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "���ұM�׵��c�ɵo�Ϳ��~�G{ProjectPath}", projectPath);
            result.AddError($"���ҹL�{���o�Ϳ��~�G{ex.Message}");
        }

        return result;
    }

    /// <summary>
    /// �ˬd�O�_�����Ī� C# �ѧO��
    /// </summary>
    private bool IsValidCSharpIdentifier(string identifier)
    {
        if (string.IsNullOrEmpty(identifier))
            return false;

        // �ˬd�Ĥ@�Ӧr��
        if (!char.IsLetter(identifier[0]) && identifier[0] != '_')
            return false;

        // �ˬd��l�r��
        for (int i = 1; i < identifier.Length; i++)
        {
            if (!char.IsLetterOrDigit(identifier[i]) && identifier[i] != '_')
                return false;
        }

        return true;
    }

    /// <summary>
    /// �ˬd�A���O�_�t��
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
/// ���ҵ��G
/// </summary>
/// <remarks>
/// �]�t���ҹL�{�����G�M�T��
/// </remarks>
public class ValidationResult
{
    /// <summary>
    /// ���~�T���C��
    /// </summary>
    public List<string> Errors { get; } = new();

    /// <summary>
    /// ĵ�i�T���C��
    /// </summary>
    public List<string> Warnings { get; } = new();

    /// <summary>
    /// ��T�T���C��
    /// </summary>
    public List<string> Information { get; } = new();

    /// <summary>
    /// �O�_���� (�S�����~)
    /// </summary>
    public bool IsValid => Errors.Count == 0;

    /// <summary>
    /// �O�_��ĵ�i
    /// </summary>
    public bool HasWarnings => Warnings.Count > 0;

    /// <summary>
    /// �`�p�T����
    /// </summary>
    public int TotalMessages => Errors.Count + Warnings.Count + Information.Count;

    /// <summary>
    /// �K�[���~�T��
    /// </summary>
    public void AddError(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            Errors.Add(message);
        }
    }

    /// <summary>
    /// �K�[ĵ�i�T��
    /// </summary>
    public void AddWarning(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            Warnings.Add(message);
        }
    }

    /// <summary>
    /// �K�[��T�T��
    /// </summary>
    public void AddInformation(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            Information.Add(message);
        }
    }

    /// <summary>
    /// �X�֨�L���ҵ��G
    /// </summary>
    public void Merge(ValidationResult other)
    {
        Errors.AddRange(other.Errors);
        Warnings.AddRange(other.Warnings);
        Information.AddRange(other.Information);
    }

    /// <summary>
    /// ���o�K�n�r��
    /// </summary>
    public string GetSummary()
    {
        if (IsValid && !HasWarnings)
            return "���ҳq�L";

        var parts = new List<string>();
        
        if (Errors.Count > 0)
            parts.Add($"{Errors.Count} �ӿ��~");
        
        if (Warnings.Count > 0)
            parts.Add($"{Warnings.Count} ��ĵ�i");
        
        if (Information.Count > 0)
            parts.Add($"{Information.Count} �Ӹ�T");

        return string.Join(", ", parts);
    }

    /// <summary>
    /// ���o�Բӳ��i
    /// </summary>
    public string GetDetailedReport()
    {
        var report = new List<string>();

        if (Errors.Count > 0)
        {
            report.Add("���~�G");
            report.AddRange(Errors.Select(e => $"  - {e}"));
            report.Add("");
        }

        if (Warnings.Count > 0)
        {
            report.Add("ĵ�i�G");
            report.AddRange(Warnings.Select(w => $"  - {w}"));
            report.Add("");
        }

        if (Information.Count > 0)
        {
            report.Add("��T�G");
            report.AddRange(Information.Select(i => $"  - {i}"));
        }

        return string.Join(Environment.NewLine, report);
    }
}