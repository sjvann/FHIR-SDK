using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.Validation;

/// <summary>
/// FHIR 驗證規則介面
/// 定義自訂驗證規則的基本結構
/// </summary>
public interface IValidationRule
{
    /// <summary>
    /// 驗證規則名稱
    /// </summary>
    string RuleName { get; }
    
    /// <summary>
    /// 驗證規則描述
    /// </summary>
    string Description { get; }
    
    /// <summary>
    /// 執行驗證
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <param name="context">驗證上下文</param>
    /// <returns>驗證結果，如果驗證通過則為 null</returns>
    ValidationResult? Validate(object value, ValidationContext context);
}

/// <summary>
/// 字串長度驗證規則
/// </summary>
public class StringLengthRule : IValidationRule
{
    private readonly int _maxLength;
    
    public StringLengthRule(int maxLength = 1000)
    {
        _maxLength = maxLength;
    }
    
    public string RuleName => "StringLength";
    public string Description => $"String length validation (max: {_maxLength})";
    
    public ValidationResult? Validate(object value, ValidationContext context)
    {
        if (value is string str && str.Length > _maxLength)
        {
            return new ValidationResult($"String length exceeds maximum allowed length of {_maxLength}");
        }
        return null;
    }
}

/// <summary>
/// 必填欄位驗證規則
/// </summary>
public class RequiredFieldRule : IValidationRule
{
    public string RuleName => "RequiredField";
    public string Description => "Required field validation";
    
    public ValidationResult? Validate(object value, ValidationContext context)
    {
        if (value == null || (value is string str && string.IsNullOrWhiteSpace(str)))
        {
            return new ValidationResult("Field is required");
        }
        return null;
    }
}

/// <summary>
/// URI 格式驗證規則
/// </summary>
public class UriFormatRule : IValidationRule
{
    public string RuleName => "UriFormat";
    public string Description => "URI format validation";
    
    public ValidationResult? Validate(object value, ValidationContext context)
    {
        if (value is string uri && !string.IsNullOrWhiteSpace(uri))
        {
            if (!Uri.TryCreate(uri, UriKind.Absolute, out _))
            {
                return new ValidationResult("Invalid URI format");
            }
        }
        return null;
    }
}

/// <summary>
/// 整數範圍驗證規則
/// </summary>
public class IntegerRangeRule : IValidationRule
{
    private readonly int _minValue;
    private readonly int _maxValue;
    
    public IntegerRangeRule(int minValue = int.MinValue, int maxValue = int.MaxValue)
    {
        _minValue = minValue;
        _maxValue = maxValue;
    }
    
    public string RuleName => "IntegerRange";
    public string Description => $"Integer range validation (min: {_minValue}, max: {_maxValue})";
    
    public ValidationResult? Validate(object value, ValidationContext context)
    {
        if (value is int intValue)
        {
            if (intValue < _minValue || intValue > _maxValue)
            {
                return new ValidationResult($"Integer value must be between {_minValue} and {_maxValue}");
            }
        }
        return null;
    }
}

/// <summary>
/// 日期範圍驗證規則
/// </summary>
public class DateRangeRule : IValidationRule
{
    private readonly DateTime _minDate;
    private readonly DateTime _maxDate;
    
    public DateRangeRule(DateTime minDate, DateTime maxDate)
    {
        _minDate = minDate;
        _maxDate = maxDate;
    }
    
    public string RuleName => "DateRange";
    public string Description => $"Date range validation (min: {_minDate:yyyy-MM-dd}, max: {_maxDate:yyyy-MM-dd})";
    
    public ValidationResult? Validate(object value, ValidationContext context)
    {
        if (value is DateTime dateValue)
        {
            if (dateValue < _minDate || dateValue > _maxDate)
            {
                return new ValidationResult($"Date must be between {_minDate:yyyy-MM-dd} and {_maxDate:yyyy-MM-dd}");
            }
        }
        return null;
    }
} 