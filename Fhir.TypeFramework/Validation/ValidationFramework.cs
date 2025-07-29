using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Fhir.TypeFramework.Validation;

/// <summary>
/// FHIR 驗證框架
/// 提供統一的驗證邏輯和規則
/// </summary>
/// <remarks>
/// 混合方案設計：
/// - 基本驗證工具：可重用的基本驗證規則
/// - FHIR 特定驗證：符合 FHIR 規範的驗證規則
/// - 複雜驗證邏輯：需要多步驟的驗證邏輯
/// </remarks>
public static class ValidationFramework
{
    // ============================================================================
    // 基本驗證工具（可重用）
    // ============================================================================

    /// <summary>
    /// 驗證字串長度
    /// </summary>
    /// <param name="value">要驗證的字串</param>
    /// <param name="maxLength">最大長度</param>
    /// <returns>如果符合規範則為 true，否則為 false</returns>
    public static bool ValidateStringLength(string? value, int maxLength)
    {
        if (value == null) return true;
        return value.Length <= maxLength;
    }

    /// <summary>
    /// 驗證字串位元組大小
    /// </summary>
    /// <param name="value">要驗證的字串</param>
    /// <param name="maxBytes">最大位元組數</param>
    /// <returns>如果符合規範則為 true，否則為 false</returns>
    public static bool ValidateStringByteSize(string? value, int maxBytes)
    {
        if (value == null) return true;
        return System.Text.Encoding.UTF8.GetByteCount(value) <= maxBytes;
    }

    /// <summary>
    /// 驗證正則表達式
    /// </summary>
    /// <param name="value">要驗證的字串</param>
    /// <param name="pattern">正則表達式模式</param>
    /// <returns>如果符合模式則為 true，否則為 false</returns>
    public static bool ValidateRegex(string? value, string pattern)
    {
        if (string.IsNullOrEmpty(value)) return true;
        
        // 使用效能優化器（如果可用）
        try
        {
            return Fhir.TypeFramework.Performance.ValidationOptimizer.ValidateRegexCached(value, pattern);
        }
        catch
        {
            // 回退到原有邏輯
            return Regex.IsMatch(value, pattern);
        }
    }

    /// <summary>
    /// 驗證整數範圍
    /// </summary>
    /// <param name="value">要驗證的整數</param>
    /// <param name="min">最小值</param>
    /// <param name="max">最大值</param>
    /// <returns>如果在範圍內則為 true，否則為 false</returns>
    public static bool ValidateIntegerRange(int value, int min, int max)
    {
        return value >= min && value <= max;
    }

    /// <summary>
    /// 驗證正整數
    /// </summary>
    /// <param name="value">要驗證的整數</param>
    /// <returns>如果是正整數則為 true，否則為 false</returns>
    public static bool ValidatePositiveInteger(int value)
    {
        return value > 0;
    }

    /// <summary>
    /// 驗證非負整數
    /// </summary>
    /// <param name="value">要驗證的整數</param>
    /// <returns>如果是非負整數則為 true，否則為 false</returns>
    public static bool ValidateUnsignedInteger(int value)
    {
        return value >= 0;
    }

    // ============================================================================
    // FHIR 特定驗證規則
    // ============================================================================

    /// <summary>
    /// 驗證 FHIR ID 格式
    /// </summary>
    /// <param name="value">要驗證的 FHIR ID</param>
    /// <returns>如果是有效的 FHIR ID 則為 true，否則為 false</returns>
    public static bool ValidateFhirId(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        return ValidateStringLength(value, 64) && 
               ValidateRegex(value, @"^[A-Za-z0-9\-\.]{1,64}$");
    }

    /// <summary>
    /// 驗證 FHIR Code 格式
    /// </summary>
    /// <param name="value">要驗證的 FHIR Code</param>
    /// <returns>如果是有效的 FHIR Code 則為 true，否則為 false</returns>
    public static bool ValidateFhirCode(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        return ValidateStringLength(value, 1000);
    }

    /// <summary>
    /// 驗證 FHIR URI 格式
    /// </summary>
    /// <param name="value">要驗證的 FHIR URI</param>
    /// <returns>如果是有效的 FHIR URI 則為 true，否則為 false</returns>
    public static bool ValidateFhirUri(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        return Uri.TryCreate(value, UriKind.Absolute, out _);
    }

    /// <summary>
    /// 驗證 FHIR URL 格式
    /// </summary>
    /// <param name="value">要驗證的 FHIR URL</param>
    /// <returns>如果是有效的 FHIR URL 則為 true，否則為 false</returns>
    public static bool ValidateFhirUrl(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        return Uri.TryCreate(value, UriKind.Absolute, out var uri) && 
               (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
    }

    /// <summary>
    /// 驗證 FHIR Canonical 格式
    /// </summary>
    /// <param name="value">要驗證的 FHIR Canonical</param>
    /// <returns>如果是有效的 FHIR Canonical 則為 true，否則為 false</returns>
    public static bool ValidateFhirCanonical(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        return Uri.TryCreate(value, UriKind.Absolute, out _);
    }

    /// <summary>
    /// 驗證 FHIR OID 格式
    /// </summary>
    /// <param name="value">要驗證的 FHIR OID</param>
    /// <returns>如果是有效的 FHIR OID 則為 true，否則為 false</returns>
    public static bool ValidateFhirOid(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        return ValidateRegex(value, @"^[0-9]+(\.[0-9]+)*$");
    }

    /// <summary>
    /// 驗證 FHIR UUID 格式
    /// </summary>
    /// <param name="value">要驗證的 FHIR UUID</param>
    /// <returns>如果是有效的 FHIR UUID 則為 true，否則為 false</returns>
    public static bool ValidateFhirUuid(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        return Guid.TryParse(value, out _);
    }

    /// <summary>
    /// 驗證 FHIR Base64Binary 格式
    /// </summary>
    /// <param name="value">要驗證的 FHIR Base64Binary</param>
    /// <returns>如果是有效的 FHIR Base64Binary 則為 true，否則為 false</returns>
    public static bool ValidateFhirBase64Binary(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        try
        {
            Convert.FromBase64String(value);
            return true;
        }
        catch
        {
            return false;
        }
    }

    // ============================================================================
    // 複雜驗證邏輯（需要多步驟）
    // ============================================================================

    /// <summary>
    /// 驗證 Reference 型別
    /// </summary>
    /// <param name="reference">要驗證的 Reference</param>
    /// <param name="context">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public static IEnumerable<ValidationResult> ValidateReference(Reference? reference, ValidationContext context)
    {
        if (reference == null) yield break;
        
        if (string.IsNullOrEmpty(reference.Reference) && 
            string.IsNullOrEmpty(reference.Identifier?.Value))
        {
            yield return new ValidationResult(
                "Reference must have either reference or identifier", 
                new[] { nameof(Reference.Reference), nameof(Reference.Identifier) });
        }
    }

    /// <summary>
    /// 驗證 CodeableConcept 型別
    /// </summary>
    /// <param name="concept">要驗證的 CodeableConcept</param>
    /// <param name="context">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public static IEnumerable<ValidationResult> ValidateCodeableConcept(CodeableConcept? concept, ValidationContext context)
    {
        if (concept == null) yield break;
        
        if (concept.Coding?.Any() != true && string.IsNullOrEmpty(concept.Text))
        {
            yield return new ValidationResult(
                "CodeableConcept must have either coding or text", 
                new[] { nameof(CodeableConcept.Coding), nameof(CodeableConcept.Text) });
        }
    }

    /// <summary>
    /// 驗證 Extension 型別
    /// </summary>
    /// <param name="extension">要驗證的 Extension</param>
    /// <param name="context">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public static IEnumerable<ValidationResult> ValidateExtension(Extension? extension, ValidationContext context)
    {
        if (extension == null) yield break;
        
        if (string.IsNullOrEmpty(extension.Url))
        {
            yield return new ValidationResult(
                "Extension URL is required", 
                new[] { nameof(Extension.Url) });
        }
        
        if (extension.Value != null && extension.Extension?.Any() == true)
        {
            yield return new ValidationResult(
                "Extension cannot have both value and nested extensions", 
                new[] { nameof(Extension.Value), nameof(Extension.Extension) });
        }
    }

    /// <summary>
    /// 驗證 HumanName 型別
    /// </summary>
    /// <param name="name">要驗證的 HumanName</param>
    /// <param name="context">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public static IEnumerable<ValidationResult> ValidateHumanName(HumanName? name, ValidationContext context)
    {
        if (name == null) yield break;
        
        if (string.IsNullOrEmpty(name.Text) && 
            (name.Given?.Any() != true) && 
            string.IsNullOrEmpty(name.Family))
        {
            yield return new ValidationResult(
                "HumanName must have either text, given names, or family name", 
                new[] { nameof(HumanName.Text), nameof(HumanName.Given), nameof(HumanName.Family) });
        }
    }

    // ============================================================================
    // 日期時間驗證規則
    // ============================================================================

    /// <summary>
    /// 驗證日期格式
    /// </summary>
    /// <param name="value">要驗證的日期字串</param>
    /// <returns>如果是有效的日期格式則為 true，否則為 false</returns>
    public static bool ValidateDate(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        return DateTime.TryParse(value, out _);
    }

    /// <summary>
    /// 驗證日期時間格式
    /// </summary>
    /// <param name="value">要驗證的日期時間字串</param>
    /// <returns>如果是有效的日期時間格式則為 true，否則為 false</returns>
    public static bool ValidateDateTime(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        return DateTime.TryParse(value, out _);
    }

    /// <summary>
    /// 驗證時間格式
    /// </summary>
    /// <param name="value">要驗證的時間字串</param>
    /// <returns>如果是有效的時間格式則為 true，否則為 false</returns>
    public static bool ValidateTime(string? value)
    {
        if (string.IsNullOrEmpty(value)) return true;
        return TimeSpan.TryParse(value, out _);
    }

    // ============================================================================
    // 複雜型別驗證規則
    // ============================================================================

    /// <summary>
    /// 驗證列表是否為空
    /// </summary>
    /// <typeparam name="T">列表元素型別</typeparam>
    /// <param name="list">要驗證的列表</param>
    /// <returns>如果列表不為空則為 true，否則為 false</returns>
    public static bool ValidateListNotEmpty<T>(IList<T>? list)
    {
        return list?.Any() == true;
    }

    /// <summary>
    /// 驗證列表長度
    /// </summary>
    /// <typeparam name="T">列表元素型別</typeparam>
    /// <param name="list">要驗證的列表</param>
    /// <param name="maxLength">最大長度</param>
    /// <returns>如果長度符合規範則為 true，否則為 false</returns>
    public static bool ValidateListLength<T>(IList<T>? list, int maxLength)
    {
        if (list == null) return true;
        return list.Count <= maxLength;
    }

    /// <summary>
    /// 驗證必要欄位
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <param name="fieldName">欄位名稱</param>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public static IEnumerable<ValidationResult> ValidateRequired(object? value, string fieldName, ValidationContext validationContext)
    {
        if (value == null)
        {
            yield return new ValidationResult($"{fieldName} is required", new[] { fieldName });
        }
    }

    /// <summary>
    /// 驗證字串必要欄位
    /// </summary>
    /// <param name="value">要驗證的字串</param>
    /// <param name="fieldName">欄位名稱</param>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public static IEnumerable<ValidationResult> ValidateRequiredString(string? value, string fieldName, ValidationContext validationContext)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            yield return new ValidationResult($"{fieldName} is required", new[] { fieldName });
        }
    }
} 