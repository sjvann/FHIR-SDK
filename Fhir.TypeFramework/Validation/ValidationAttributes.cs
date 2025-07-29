using System.ComponentModel.DataAnnotations;
using Fhir.TypeFramework.Validation;

namespace Fhir.TypeFramework.Validation;

/// <summary>
/// FHIR 字串驗證屬性
/// 用於驗證 FHIR 字串型別的值
/// </summary>
/// <remarks>
/// 提供以下驗證功能：
/// - 字串長度驗證
/// - 字串位元組大小驗證
/// - 基本格式驗證
/// </remarks>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class FhirStringAttribute : ValidationAttribute
{
    /// <summary>
    /// 最大字串長度
    /// </summary>
    public int MaxLength { get; set; } = int.MaxValue;

    /// <summary>
    /// 最大位元組大小
    /// </summary>
    public int MaxByteSize { get; set; } = 1024 * 1024; // 1MB

    /// <summary>
    /// 是否允許空值
    /// </summary>
    public bool AllowNull { get; set; } = true;

    /// <summary>
    /// 驗證值是否符合 FHIR 字串規範
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    public override bool IsValid(object? value)
    {
        if (value == null) return AllowNull;
        
        if (value is not string stringValue) return false;

        // 驗證字串長度
        if (!ValidationFramework.ValidateStringLength(stringValue, MaxLength))
        {
            ErrorMessage = $"String length cannot exceed {MaxLength} characters";
            return false;
        }

        // 驗證位元組大小
        if (!ValidationFramework.ValidateStringByteSize(stringValue, MaxByteSize))
        {
            ErrorMessage = $"String byte size cannot exceed {MaxByteSize} bytes";
            return false;
        }

        return true;
    }
}

/// <summary>
/// FHIR 整數驗證屬性
/// 用於驗證 FHIR 整數型別的值
/// </summary>
/// <remarks>
/// 提供以下驗證功能：
/// - 整數範圍驗證
/// - 正整數驗證
/// - 非負整數驗證
/// </remarks>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class FhirIntegerAttribute : ValidationAttribute
{
    /// <summary>
    /// 最小值
    /// </summary>
    public int MinValue { get; set; } = int.MinValue;

    /// <summary>
    /// 最大值
    /// </summary>
    public int MaxValue { get; set; } = int.MaxValue;

    /// <summary>
    /// 是否允許空值
    /// </summary>
    public bool AllowNull { get; set; } = true;

    /// <summary>
    /// 驗證值是否符合 FHIR 整數規範
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    public override bool IsValid(object? value)
    {
        if (value == null) return AllowNull;
        
        if (value is not int intValue) return false;

        // 驗證範圍
        if (!ValidationFramework.ValidateIntegerRange(intValue, MinValue, MaxValue))
        {
            ErrorMessage = $"Integer value must be between {MinValue} and {MaxValue}";
            return false;
        }

        return true;
    }
}

/// <summary>
/// FHIR 正整數驗證屬性
/// 用於驗證 FHIR 正整數型別的值
/// </summary>
/// <remarks>
/// 提供以下驗證功能：
/// - 正整數驗證（大於 0）
/// - 範圍驗證
/// </remarks>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class FhirPositiveIntegerAttribute : ValidationAttribute
{
    /// <summary>
    /// 最大值
    /// </summary>
    public int MaxValue { get; set; } = int.MaxValue;

    /// <summary>
    /// 是否允許空值
    /// </summary>
    public bool AllowNull { get; set; } = true;

    /// <summary>
    /// 驗證值是否符合 FHIR 正整數規範
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    public override bool IsValid(object? value)
    {
        if (value == null) return AllowNull;
        
        if (value is not int intValue) return false;

        // 驗證正整數
        if (!ValidationFramework.ValidatePositiveInteger(intValue))
        {
            ErrorMessage = "Value must be a positive integer";
            return false;
        }

        // 驗證最大值
        if (intValue > MaxValue)
        {
            ErrorMessage = $"Value cannot exceed {MaxValue}";
            return false;
        }

        return true;
    }
}

/// <summary>
/// FHIR URI 驗證屬性
/// 用於驗證 FHIR URI 型別的值
/// </summary>
/// <remarks>
/// 提供以下驗證功能：
/// - URI 格式驗證
/// - 字串長度驗證
/// </remarks>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class FhirUriAttribute : ValidationAttribute
{
    /// <summary>
    /// 最大字串長度
    /// </summary>
    public int MaxLength { get; set; } = 2048;

    /// <summary>
    /// 是否允許空值
    /// </summary>
    public bool AllowNull { get; set; } = true;

    /// <summary>
    /// 驗證值是否符合 FHIR URI 規範
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    public override bool IsValid(object? value)
    {
        if (value == null) return AllowNull;
        
        if (value is not string stringValue) return false;

        // 驗證字串長度
        if (!ValidationFramework.ValidateStringLength(stringValue, MaxLength))
        {
            ErrorMessage = $"URI length cannot exceed {MaxLength} characters";
            return false;
        }

        // 驗證 URI 格式
        if (!ValidationFramework.ValidateUri(stringValue))
        {
            ErrorMessage = "Invalid URI format";
            return false;
        }

        return true;
    }
}

/// <summary>
/// FHIR URL 驗證屬性
/// 用於驗證 FHIR URL 型別的值
/// </summary>
/// <remarks>
/// 提供以下驗證功能：
/// - URL 格式驗證（HTTP/HTTPS）
/// - 字串長度驗證
/// </remarks>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class FhirUrlAttribute : ValidationAttribute
{
    /// <summary>
    /// 最大字串長度
    /// </summary>
    public int MaxLength { get; set; } = 2048;

    /// <summary>
    /// 是否允許空值
    /// </summary>
    public bool AllowNull { get; set; } = true;

    /// <summary>
    /// 驗證值是否符合 FHIR URL 規範
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    public override bool IsValid(object? value)
    {
        if (value == null) return AllowNull;
        
        if (value is not string stringValue) return false;

        // 驗證字串長度
        if (!ValidationFramework.ValidateStringLength(stringValue, MaxLength))
        {
            ErrorMessage = $"URL length cannot exceed {MaxLength} characters";
            return false;
        }

        // 驗證 URL 格式
        if (!ValidationFramework.ValidateUrl(stringValue))
        {
            ErrorMessage = "Invalid URL format (must be HTTP or HTTPS)";
            return false;
        }

        return true;
    }
}

/// <summary>
/// FHIR 日期時間驗證屬性
/// 用於驗證 FHIR 日期時間型別的值
/// </summary>
/// <remarks>
/// 提供以下驗證功能：
/// - ISO 8601 日期時間格式驗證
/// - 字串長度驗證
/// </remarks>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class FhirDateTimeAttribute : ValidationAttribute
{
    /// <summary>
    /// 最大字串長度
    /// </summary>
    public int MaxLength { get; set; } = 64;

    /// <summary>
    /// 是否允許空值
    /// </summary>
    public bool AllowNull { get; set; } = true;

    /// <summary>
    /// 驗證值是否符合 FHIR 日期時間規範
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    public override bool IsValid(object? value)
    {
        if (value == null) return AllowNull;
        
        if (value is not string stringValue) return false;

        // 驗證字串長度
        if (!ValidationFramework.ValidateStringLength(stringValue, MaxLength))
        {
            ErrorMessage = $"DateTime string length cannot exceed {MaxLength} characters";
            return false;
        }

        // 驗證日期時間格式
        if (!ValidationFramework.ValidateDateTime(stringValue))
        {
            ErrorMessage = "Invalid DateTime format (must be ISO 8601)";
            return false;
        }

        return true;
    }
}

/// <summary>
/// FHIR 必要欄位驗證屬性
/// 用於驗證 FHIR 必要欄位
/// </summary>
/// <remarks>
/// 提供以下驗證功能：
/// - 空值檢查
/// - 字串空白檢查
/// </remarks>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class FhirRequiredAttribute : ValidationAttribute
{
    /// <summary>
    /// 是否允許空白字串
    /// </summary>
    public bool AllowEmptyString { get; set; } = false;

    /// <summary>
    /// 驗證值是否為必要欄位
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    public override bool IsValid(object? value)
    {
        if (value == null)
        {
            ErrorMessage = "This field is required";
            return false;
        }

        if (value is string stringValue && !AllowEmptyString && string.IsNullOrWhiteSpace(stringValue))
        {
            ErrorMessage = "This field cannot be empty";
            return false;
        }

        return true;
    }
} 