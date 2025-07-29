using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.Extensions;

/// <summary>
/// FHIR Type Framework 擴展方法
/// 提供便利的 API 來改善開發體驗
/// </summary>
/// <remarks>
/// 提供以下功能：
/// - 快速建立 Extension
/// - 便利的驗證方法
/// - 型別安全的擴展操作
/// </remarks>
public static class TypeFrameworkExtensions
{
    // ============================================================================
    // Extension 相關擴展方法
    // ============================================================================

    /// <summary>
    /// 快速建立 Extension
    /// </summary>
    /// <param name="extensible">可擴展的物件</param>
    /// <param name="url">擴展的 URL</param>
    /// <param name="value">擴展的值</param>
    /// <returns>建立的 Extension</returns>
    public static IExtension CreateExtension(this IExtensibleTypeFramework extensible, string url, object? value)
    {
        var extension = new Extension { Url = url, Value = value };
        extensible.Extension ??= new List<IExtension>();
        extensible.Extension.Add(extension);
        return extension;
    }

    /// <summary>
    /// 快速建立字串 Extension
    /// </summary>
    /// <param name="extensible">可擴展的物件</param>
    /// <param name="url">擴展的 URL</param>
    /// <param name="value">字串值</param>
    /// <returns>建立的 Extension</returns>
    public static IExtension CreateStringExtension(this IExtensibleTypeFramework extensible, string url, string value)
    {
        return extensible.CreateExtension(url, new FhirString(value));
    }

    /// <summary>
    /// 快速建立整數 Extension
    /// </summary>
    /// <param name="extensible">可擴展的物件</param>
    /// <param name="url">擴展的 URL</param>
    /// <param name="value">整數值</param>
    /// <returns>建立的 Extension</returns>
    public static IExtension CreateIntegerExtension(this IExtensibleTypeFramework extensible, string url, int value)
    {
        return extensible.CreateExtension(url, new FhirInteger(value));
    }

    /// <summary>
    /// 快速建立布林 Extension
    /// </summary>
    /// <param name="extensible">可擴展的物件</param>
    /// <param name="url">擴展的 URL</param>
    /// <param name="value">布林值</param>
    /// <returns>建立的 Extension</returns>
    public static IExtension CreateBooleanExtension(this IExtensibleTypeFramework extensible, string url, bool value)
    {
        return extensible.CreateExtension(url, new FhirBoolean(value));
    }

    /// <summary>
    /// 取得指定 URL 的擴展
    /// </summary>
    /// <param name="extensible">可擴展的物件</param>
    /// <param name="url">要查詢的擴展 URL</param>
    /// <returns>找到的擴展，如果不存在則為 null</returns>
    public static IExtension? GetExtension(this IExtensibleTypeFramework extensible, string url)
    {
        return extensible.Extension?.FirstOrDefault(ext => ext.Url == url);
    }

    /// <summary>
    /// 取得擴展值（泛型版本）
    /// </summary>
    /// <typeparam name="T">期望的型別</typeparam>
    /// <param name="extensible">可擴展的物件</param>
    /// <param name="url">擴展的 URL</param>
    /// <returns>轉換後的值，如果型別不匹配則返回 null</returns>
    public static T? GetExtensionValue<T>(this IExtensibleTypeFramework extensible, string url) where T : class
    {
        var extension = extensible.GetExtension(url);
        return extension?.GetValue<T>();
    }

    /// <summary>
    /// 取得字串擴展值
    /// </summary>
    /// <param name="extensible">可擴展的物件</param>
    /// <param name="url">擴展的 URL</param>
    /// <returns>字串值，如果不是字串型別則返回 null</returns>
    public static string? GetStringExtensionValue(this IExtensibleTypeFramework extensible, string url)
    {
        return extensible.GetExtensionValue<FhirString>(url)?.Value;
    }

    /// <summary>
    /// 取得整數擴展值
    /// </summary>
    /// <param name="extensible">可擴展的物件</param>
    /// <param name="url">擴展的 URL</param>
    /// <returns>整數值，如果不是整數型別則返回 null</returns>
    public static int? GetIntegerExtensionValue(this IExtensibleTypeFramework extensible, string url)
    {
        return extensible.GetExtensionValue<FhirInteger>(url)?.Value;
    }

    /// <summary>
    /// 取得布林擴展值
    /// </summary>
    /// <param name="extensible">可擴展的物件</param>
    /// <param name="url">擴展的 URL</param>
    /// <returns>布林值，如果不是布林型別則返回 null</returns>
    public static bool? GetBooleanExtensionValue(this IExtensibleTypeFramework extensible, string url)
    {
        return extensible.GetExtensionValue<FhirBoolean>(url)?.Value;
    }

    /// <summary>
    /// 檢查是否有指定 Extension
    /// </summary>
    /// <param name="extensible">可擴展的物件</param>
    /// <param name="url">擴展的 URL</param>
    /// <returns>如果存在指定擴展則為 true，否則為 false</returns>
    public static bool HasExtension(this IExtensibleTypeFramework extensible, string url)
    {
        return extensible.GetExtension(url) != null;
    }

    /// <summary>
    /// 移除指定 URL 的擴展
    /// </summary>
    /// <param name="extensible">可擴展的物件</param>
    /// <param name="url">要移除的擴展 URL</param>
    /// <returns>如果成功移除則為 true，否則為 false</returns>
    public static bool RemoveExtension(this IExtensibleTypeFramework extensible, string url)
    {
        if (extensible.Extension == null) return false;
        
        var toRemove = extensible.Extension.Where(ext => ext.Url == url).ToList();
        foreach (var ext in toRemove)
        {
            extensible.Extension.Remove(ext);
        }
        
        return toRemove.Any();
    }

    // ============================================================================
    // 驗證相關擴展方法
    // ============================================================================

    /// <summary>
    /// 快速驗證物件
    /// </summary>
    /// <param name="instance">要驗證的物件</param>
    /// <returns>如果物件有效則為 true，否則為 false</returns>
    public static bool IsValid(this ITypeFramework instance)
    {
        var context = new ValidationContext(instance);
        return !instance.Validate(context).Any();
    }

    /// <summary>
    /// 取得驗證錯誤訊息
    /// </summary>
    /// <param name="instance">要驗證的物件</param>
    /// <returns>驗證錯誤訊息集合</returns>
    public static IEnumerable<string> GetValidationErrors(this ITypeFramework instance)
    {
        var context = new ValidationContext(instance);
        return instance.Validate(context).Select(r => r.ErrorMessage ?? "Unknown validation error");
    }

    /// <summary>
    /// 取得驗證結果
    /// </summary>
    /// <param name="instance">要驗證的物件</param>
    /// <returns>驗證結果集合</returns>
    public static IEnumerable<ValidationResult> GetValidationResults(this ITypeFramework instance)
    {
        var context = new ValidationContext(instance);
        return instance.Validate(context);
    }

    /// <summary>
    /// 驗證並拋出例外（如果驗證失敗）
    /// </summary>
    /// <param name="instance">要驗證的物件</param>
    /// <exception cref="ValidationException">當驗證失敗時拋出</exception>
    public static void ValidateAndThrow(this ITypeFramework instance)
    {
        var errors = instance.GetValidationErrors().ToList();
        if (errors.Any())
        {
            throw new ValidationException($"Validation failed: {string.Join("; ", errors)}");
        }
    }

    // ============================================================================
    // 型別轉換擴展方法
    // ============================================================================

    /// <summary>
    /// 安全轉換為字串
    /// </summary>
    /// <param name="instance">要轉換的物件</param>
    /// <returns>字串值，如果轉換失敗則返回 null</returns>
    public static string? ToSafeString(this ITypeFramework instance)
    {
        return instance switch
        {
            FhirString fhirString => fhirString.Value,
            FhirInteger fhirInteger => fhirInteger.Value?.ToString(),
            FhirBoolean fhirBoolean => fhirBoolean.Value?.ToString(),
            FhirDecimal fhirDecimal => fhirDecimal.Value?.ToString(),
            FhirDateTime fhirDateTime => fhirDateTime.Value?.ToString(),
            _ => instance.ToString()
        };
    }

    /// <summary>
    /// 安全轉換為整數
    /// </summary>
    /// <param name="instance">要轉換的物件</param>
    /// <returns>整數值，如果轉換失敗則返回 null</returns>
    public static int? ToSafeInteger(this ITypeFramework instance)
    {
        return instance switch
        {
            FhirInteger fhirInteger => fhirInteger.Value,
            FhirPositiveInt fhirPositiveInt => fhirPositiveInt.Value,
            FhirUnsignedInt fhirUnsignedInt => fhirUnsignedInt.Value,
            _ => null
        };
    }

    /// <summary>
    /// 安全轉換為布林值
    /// </summary>
    /// <param name="instance">要轉換的物件</param>
    /// <returns>布林值，如果轉換失敗則返回 null</returns>
    public static bool? ToSafeBoolean(this ITypeFramework instance)
    {
        return instance switch
        {
            FhirBoolean fhirBoolean => fhirBoolean.Value,
            _ => null
        };
    }
} 