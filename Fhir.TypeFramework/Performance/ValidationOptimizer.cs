using Fhir.TypeFramework.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.Collections.Concurrent;

namespace Fhir.TypeFramework.Performance;

/// <summary>
/// 驗證優化器
/// 提供快取的驗證功能和批次驗證
/// </summary>
/// <remarks>
/// 這個優化器設計為：
/// - 快取常用的 Regex 物件
/// - 提供批次驗證功能
/// - 不影響現有驗證邏輯
/// - 提供效能監控
/// </remarks>
public static class ValidationOptimizer
{
    /// <summary>
    /// 是否啟用驗證優化
    /// </summary>
    public static bool EnableOptimization { get; set; } = true;

    /// <summary>
    /// 快取的 Regex 驗證
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <param name="pattern">正則表達式模式</param>
    /// <param name="options">Regex 選項</param>
    /// <returns>如果符合模式則為 true，否則為 false</returns>
    public static bool ValidateRegexCached(string? value, string pattern, RegexOptions options = RegexOptions.Compiled)
    {
        if (string.IsNullOrEmpty(value)) return true;
        
        if (!EnableOptimization)
        {
            return Regex.IsMatch(value, pattern, options);
        }
        
        var regex = TypeFrameworkCache.GetCachedRegex(pattern, options);
        return regex.IsMatch(value);
    }

    /// <summary>
    /// 批次驗證
    /// </summary>
    /// <param name="items">要驗證的物件集合</param>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public static IEnumerable<ValidationResult> BatchValidate(IEnumerable<ITypeFramework> items, ValidationContext validationContext)
    {
        if (!EnableOptimization)
        {
            foreach (var item in items)
            {
                foreach (var result in item.Validate(validationContext))
                {
                    yield return result;
                }
            }
            yield break;
        }

        var results = new List<ValidationResult>();
        foreach (var item in items)
        {
            if (item != null)
            {
                var itemValidationContext = new ValidationContext(item);
                foreach (var result in item.Validate(itemValidationContext))
                {
                    results.Add(result);
                }
            }
        }
        
        foreach (var result in results)
        {
            yield return result;
        }
    }

    /// <summary>
    /// 快速驗證（只檢查基本規則）
    /// </summary>
    /// <param name="item">要驗證的物件</param>
    /// <returns>如果通過基本驗證則為 true，否則為 false</returns>
    public static bool QuickValidate(ITypeFramework item)
    {
        if (item == null) return false;
        
        try
        {
            var context = new ValidationContext(item);
            var results = item.Validate(context);
            return !results.Any();
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// 批次快速驗證
    /// </summary>
    /// <param name="items">要驗證的物件集合</param>
    /// <returns>通過驗證的物件集合</returns>
    public static IEnumerable<ITypeFramework> BatchQuickValidate(IEnumerable<ITypeFramework> items)
    {
        foreach (var item in items)
        {
            if (QuickValidate(item))
            {
                yield return item;
            }
        }
    }

    /// <summary>
    /// 驗證並分類結果
    /// </summary>
    /// <param name="items">要驗證的物件集合</param>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果分類</returns>
    public static ValidationResultSummary ValidateAndCategorize(IEnumerable<ITypeFramework> items, ValidationContext validationContext)
    {
        var validItems = new List<ITypeFramework>();
        var invalidItems = new List<ITypeFramework>();
        var allErrors = new List<ValidationResult>();

        foreach (var item in items)
        {
            if (item == null) continue;
            
            var itemValidationContext = new ValidationContext(item);
            var results = item.Validate(itemValidationContext).ToList();
            
            if (results.Any())
            {
                invalidItems.Add(item);
                allErrors.AddRange(results);
            }
            else
            {
                validItems.Add(item);
            }
        }

        return new ValidationResultSummary
        {
            ValidItems = validItems,
            InvalidItems = invalidItems,
            AllErrors = allErrors,
            TotalItems = validItems.Count + invalidItems.Count,
            ValidCount = validItems.Count,
            InvalidCount = invalidItems.Count
        };
    }
}

/// <summary>
/// 驗證結果摘要
/// </summary>
public class ValidationResultSummary
{
    /// <summary>
    /// 有效的物件
    /// </summary>
    public IList<ITypeFramework> ValidItems { get; set; } = new List<ITypeFramework>();
    
    /// <summary>
    /// 無效的物件
    /// </summary>
    public IList<ITypeFramework> InvalidItems { get; set; } = new List<ITypeFramework>();
    
    /// <summary>
    /// 所有錯誤
    /// </summary>
    public IList<ValidationResult> AllErrors { get; set; } = new List<ValidationResult>();
    
    /// <summary>
    /// 總物件數量
    /// </summary>
    public int TotalItems { get; set; }
    
    /// <summary>
    /// 有效物件數量
    /// </summary>
    public int ValidCount { get; set; }
    
    /// <summary>
    /// 無效物件數量
    /// </summary>
    public int InvalidCount { get; set; }
    
    /// <summary>
    /// 驗證成功率
    /// </summary>
    public double SuccessRate => TotalItems > 0 ? (double)ValidCount / TotalItems : 0;
} 