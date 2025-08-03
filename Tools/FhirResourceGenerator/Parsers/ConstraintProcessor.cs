using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Parsers;

/// <summary>
/// 約束處理器
/// </summary>
/// <remarks>
/// 負責處理和轉換 FHIR 約束條件
/// </remarks>
public class ConstraintProcessor
{
    private readonly ILogger<ConstraintProcessor> _logger;

    public ConstraintProcessor(ILogger<ConstraintProcessor> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// 處理約束條件
    /// </summary>
    public async Task<List<ConstraintDefinition>> ProcessConstraintsAsync(List<ElementConstraint> elementConstraints)
    {
        await Task.CompletedTask; // 避免編譯器警告

        var constraints = new List<ConstraintDefinition>();

        foreach (var elementConstraint in elementConstraints)
        {
            try
            {
                var constraint = ConvertElementConstraint(elementConstraint);
                if (constraint != null)
                {
                    constraints.Add(constraint);
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "處理約束條件時發生錯誤：{Key}", elementConstraint.Key);
            }
        }

        return constraints;
    }

    /// <summary>
    /// 轉換元素約束
    /// </summary>
    private ConstraintDefinition? ConvertElementConstraint(ElementConstraint elementConstraint)
    {
        if (string.IsNullOrEmpty(elementConstraint.Key))
            return null;

        return new ConstraintDefinition
        {
            Key = elementConstraint.Key,
            Severity = elementConstraint.Severity,
            Human = elementConstraint.Human,
            Expression = elementConstraint.Expression,
            Xpath = elementConstraint.Xpath,
            Source = elementConstraint.Source
        };
    }

    /// <summary>
    /// 生成驗證屬性
    /// </summary>
    public List<string> GenerateValidationAttributes(ConstraintDefinition constraint)
    {
        var attributes = new List<string>();

        // 根據約束類型生成相應的驗證屬性
        switch (constraint.Severity.ToLower())
        {
            case "error":
                attributes.Add($"[CustomValidation(typeof(FhirValidationHelper), nameof(FhirValidationHelper.Validate{constraint.Key}))]");
                break;
            case "warning":
                attributes.Add($"[CustomValidation(typeof(FhirValidationHelper), nameof(FhirValidationHelper.Warn{constraint.Key}))]");
                break;
        }

        return attributes;
    }
}