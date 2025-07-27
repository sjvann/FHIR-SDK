using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.Validation;

/// <summary>
/// FHIR 驗證規則工廠
/// 管理所有驗證規則的註冊和執行
/// </summary>
public class ValidationRuleFactory
{
    private static readonly Dictionary<string, IValidationRule> _rules = new();
    private static readonly object _lock = new();
    
    /// <summary>
    /// 靜態建構函式，註冊預設驗證規則
    /// </summary>
    static ValidationRuleFactory()
    {
        RegisterDefaultRules();
    }
    
    /// <summary>
    /// 註冊驗證規則
    /// </summary>
    /// <param name="rule">要註冊的驗證規則</param>
    public static void RegisterRule(IValidationRule rule)
    {
        lock (_lock)
        {
            _rules[rule.RuleName] = rule;
        }
    }
    
    /// <summary>
    /// 註冊多個驗證規則
    /// </summary>
    /// <param name="rules">要註冊的驗證規則集合</param>
    public static void RegisterRules(IEnumerable<IValidationRule> rules)
    {
        lock (_lock)
        {
            foreach (var rule in rules)
            {
                _rules[rule.RuleName] = rule;
            }
        }
    }
    
    /// <summary>
    /// 移除驗證規則
    /// </summary>
    /// <param name="ruleName">要移除的規則名稱</param>
    /// <returns>如果成功移除則為 true，否則為 false</returns>
    public static bool RemoveRule(string ruleName)
    {
        lock (_lock)
        {
            return _rules.Remove(ruleName);
        }
    }
    
    /// <summary>
    /// 取得所有註冊的驗證規則
    /// </summary>
    /// <returns>驗證規則集合</returns>
    public static IEnumerable<IValidationRule> GetAllRules()
    {
        lock (_lock)
        {
            return _rules.Values.ToList();
        }
    }
    
    /// <summary>
    /// 取得指定的驗證規則
    /// </summary>
    /// <param name="ruleName">規則名稱</param>
    /// <returns>驗證規則，如果不存在則為 null</returns>
    public static IValidationRule? GetRule(string ruleName)
    {
        lock (_lock)
        {
            return _rules.TryGetValue(ruleName, out var rule) ? rule : null;
        }
    }
    
    /// <summary>
    /// 執行所有驗證規則
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <param name="context">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public static IEnumerable<ValidationResult> Validate(object value, ValidationContext context)
    {
        var results = new List<ValidationResult>();
        
        lock (_lock)
        {
            foreach (var rule in _rules.Values)
            {
                try
                {
                    var result = rule.Validate(value, context);
                    if (result != null)
                    {
                        results.Add(result);
                    }
                }
                catch (Exception ex)
                {
                    // 記錄驗證規則執行錯誤，但不中斷整個驗證流程
                    results.Add(new ValidationResult($"Validation rule '{rule.RuleName}' failed: {ex.Message}"));
                }
            }
        }
        
        return results;
    }
    
    /// <summary>
    /// 執行指定的驗證規則
    /// </summary>
    /// <param name="ruleName">規則名稱</param>
    /// <param name="value">要驗證的值</param>
    /// <param name="context">驗證上下文</param>
    /// <returns>驗證結果，如果規則不存在或驗證通過則為 null</returns>
    public static ValidationResult? Validate(string ruleName, object value, ValidationContext context)
    {
        var rule = GetRule(ruleName);
        if (rule == null)
        {
            return new ValidationResult($"Validation rule '{ruleName}' not found");
        }
        
        try
        {
            return rule.Validate(value, context);
        }
        catch (Exception ex)
        {
            return new ValidationResult($"Validation rule '{ruleName}' failed: {ex.Message}");
        }
    }
    
    /// <summary>
    /// 清除所有驗證規則
    /// </summary>
    public static void ClearRules()
    {
        lock (_lock)
        {
            _rules.Clear();
        }
    }
    
    /// <summary>
    /// 註冊預設驗證規則
    /// </summary>
    private static void RegisterDefaultRules()
    {
        var defaultRules = new IValidationRule[]
        {
            new StringLengthRule(),
            new RequiredFieldRule(),
            new UriFormatRule(),
            new IntegerRangeRule(),
            new DateRangeRule(DateTime.MinValue, DateTime.MaxValue)
        };
        
        RegisterRules(defaultRules);
    }
}

/// <summary>
/// FHIR 驗證上下文擴展
/// 提供 FHIR 專用的驗證功能
/// </summary>
public static class FhirValidationExtensions
{
    /// <summary>
    /// 使用 FHIR 驗證規則驗證物件
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <param name="context">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public static IEnumerable<ValidationResult> ValidateWithFhirRules(this object value, ValidationContext context)
    {
        return ValidationRuleFactory.Validate(value, context);
    }
    
    /// <summary>
    /// 使用指定的 FHIR 驗證規則驗證物件
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <param name="ruleName">規則名稱</param>
    /// <param name="context">驗證上下文</param>
    /// <returns>驗證結果</returns>
    public static ValidationResult? ValidateWithFhirRule(this object value, string ruleName, ValidationContext context)
    {
        return ValidationRuleFactory.Validate(ruleName, value, context);
    }
    
    /// <summary>
    /// 註冊自訂驗證規則
    /// </summary>
    /// <param name="rule">要註冊的驗證規則</param>
    public static void RegisterFhirValidationRule(this IValidationRule rule)
    {
        ValidationRuleFactory.RegisterRule(rule);
    }
} 