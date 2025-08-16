using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Parsers;

/// <summary>
/// �����B�z��
/// </summary>
/// <remarks>
/// �t�d�B�z�M�ഫ FHIR ��������
/// </remarks>
public class ConstraintProcessor
{
    private readonly ILogger<ConstraintProcessor> _logger;

    public ConstraintProcessor(ILogger<ConstraintProcessor> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// �B�z��������
    /// </summary>
    public async Task<List<ConstraintDefinition>> ProcessConstraintsAsync(List<ElementConstraint> elementConstraints)
    {
        await Task.CompletedTask; // �קK�sĶ��ĵ�i

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
                _logger.LogWarning(ex, "�B�z��������ɵo�Ϳ��~�G{Key}", elementConstraint.Key);
            }
        }

        return constraints;
    }

    /// <summary>
    /// �ഫ��������
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
    /// �ͦ������ݩ�
    /// </summary>
    public List<string> GenerateValidationAttributes(ConstraintDefinition constraint)
    {
        var attributes = new List<string>();

        // �ھڬ��������ͦ������������ݩ�
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