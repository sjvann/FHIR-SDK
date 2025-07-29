using Fhir.TypeFramework.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.Development;

/// <summary>
/// 開發輔助工具
/// 提供開發時的輔助功能和資訊
/// </summary>
/// <remarks>
/// 這個工具類別提供：
/// - 型別規範資訊查詢
/// - 詳細驗證結果
/// - 開發時輔助功能
/// - 版本無關的設計
/// </remarks>
public static class DevelopmentTools
{
    /// <summary>
    /// 取得型別的規範資訊
    /// </summary>
    /// <typeparam name="T">要查詢的型別</typeparam>
    /// <returns>型別的規範資訊</returns>
    public static string GetTypeSpecification<T>() where T : ITypeFramework
    {
        var type = typeof(T);
        return $"Type: {type.Name}, Namespace: {type.Namespace}";
    }

    /// <summary>
    /// 驗證並提供詳細錯誤訊息
    /// </summary>
    /// <typeparam name="T">要驗證的型別</typeparam>
    /// <param name="instance">要驗證的實例</param>
    /// <returns>詳細的驗證結果</returns>
    public static ValidationResult ValidateWithDetails<T>(T instance) where T : ITypeFramework
    {
        if (instance == null)
        {
            return new ValidationResult
            {
                IsValid = false,
                Errors = new List<string> { "Instance cannot be null" },
                Warnings = new List<string>(),
                Details = "Null instance provided for validation"
            };
        }

        var context = new ValidationContext(instance);
        var results = instance.Validate(context).ToList();
        
        return new ValidationResult
        {
            IsValid = !results.Any(),
            Errors = results.Where(r => !IsWarning(r.ErrorMessage))
                          .Select(r => r.ErrorMessage ?? "Unknown error")
                          .ToList(),
            Warnings = results.Where(r => IsWarning(r.ErrorMessage))
                             .Select(r => r.ErrorMessage ?? "Unknown warning")
                             .ToList(),
            Details = GenerateValidationDetails(results)
        };
    }

    /// <summary>
    /// 取得型別的詳細資訊
    /// </summary>
    /// <typeparam name="T">要查詢的型別</typeparam>
    /// <returns>型別的詳細資訊</returns>
    public static TypeInfo GetTypeInfo<T>() where T : ITypeFramework
    {
        var type = typeof(T);
        
        return new TypeInfo
        {
            TypeName = type.Name,
            Namespace = type.Namespace,
            IsAbstract = type.IsAbstract,
            IsInterface = type.IsInterface,
            BaseType = type.BaseType?.Name,
            Interfaces = type.GetInterfaces().Select(i => i.Name).ToList(),
            Properties = type.GetProperties().Select(p => new PropertyInfo
            {
                Name = p.Name,
                Type = p.PropertyType.Name,
                IsReadOnly = !p.CanWrite,
                IsNullable = IsNullableType(p.PropertyType)
            }).ToList()
        };
    }

    /// <summary>
    /// 檢查型別是否為基本型別
    /// </summary>
    /// <typeparam name="T">要檢查的型別</typeparam>
    /// <returns>如果是基本型別則為 true，否則為 false</returns>
    public static bool IsPrimitiveType<T>() where T : ITypeFramework
    {
        var type = typeof(T);
        return type.Namespace?.Contains("PrimitiveTypes") == true;
    }

    /// <summary>
    /// 檢查型別是否為複雜型別
    /// </summary>
    /// <typeparam name="T">要檢查的型別</typeparam>
    /// <returns>如果是複雜型別則為 true，否則為 false</returns>
    public static bool IsComplexType<T>() where T : ITypeFramework
    {
        var type = typeof(T);
        return type.Namespace?.Contains("ComplexTypes") == true;
    }

    /// <summary>
    /// 取得型別的使用範例
    /// </summary>
    /// <typeparam name="T">要取得範例的型別</typeparam>
    /// <returns>型別的使用範例</returns>
    public static string GetUsageExample<T>() where T : ITypeFramework
    {
        var type = typeof(T);
        var typeName = type.Name;

        return typeName switch
        {
            "FhirString" => "var value = new FhirString(\"Hello World\");",
            "FhirInteger" => "var value = new FhirInteger(42);",
            "FhirBoolean" => "var value = new FhirBoolean(true);",
            "FhirUri" => "var value = new FhirUri(\"https://example.com\");",
            "Extension" => "var extension = new Extension { Url = \"https://example.com/extension\", Value = \"value\" };",
            _ => $"var instance = new {typeName}();"
        };
    }

    // ============================================================================
    // 私有輔助方法
    // ============================================================================

    private static bool IsWarning(string? message)
    {
        if (string.IsNullOrEmpty(message)) return false;
        return message.Contains("warning", StringComparison.OrdinalIgnoreCase) ||
               message.Contains("建議", StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsNullableType(Type type)
    {
        if (type.IsValueType) return false;
        return Nullable.GetUnderlyingType(type) != null;
    }

    private static string GenerateValidationDetails(IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> results)
    {
        if (!results.Any()) return "Validation passed successfully";

        var details = new List<string>();
        foreach (var result in results)
        {
            details.Add($"- {result.ErrorMessage}");
            if (result.MemberNames.Any())
            {
                details.Add($"  Members: {string.Join(", ", result.MemberNames)}");
            }
        }

        return string.Join("\n", details);
    }
}

/// <summary>
/// 驗證結果
/// </summary>
public class ValidationResult
{
    /// <summary>
    /// 是否有效
    /// </summary>
    public bool IsValid { get; set; }

    /// <summary>
    /// 錯誤訊息列表
    /// </summary>
    public IList<string> Errors { get; set; } = new List<string>();

    /// <summary>
    /// 警告訊息列表
    /// </summary>
    public IList<string> Warnings { get; set; } = new List<string>();

    /// <summary>
    /// 詳細資訊
    /// </summary>
    public string? Details { get; set; }
}

/// <summary>
/// 型別資訊
/// </summary>
public class TypeInfo
{
    /// <summary>
    /// 型別名稱
    /// </summary>
    public string TypeName { get; set; } = string.Empty;

    /// <summary>
    /// 命名空間
    /// </summary>
    public string Namespace { get; set; } = string.Empty;

    /// <summary>
    /// 是否為抽象型別
    /// </summary>
    public bool IsAbstract { get; set; }

    /// <summary>
    /// 是否為介面
    /// </summary>
    public bool IsInterface { get; set; }

    /// <summary>
    /// 基礎型別名稱
    /// </summary>
    public string? BaseType { get; set; }

    /// <summary>
    /// 實作的介面列表
    /// </summary>
    public IList<string> Interfaces { get; set; } = new List<string>();

    /// <summary>
    /// 屬性資訊列表
    /// </summary>
    public IList<PropertyInfo> Properties { get; set; } = new List<PropertyInfo>();
}

/// <summary>
/// 屬性資訊
/// </summary>
public class PropertyInfo
{
    /// <summary>
    /// 屬性名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 屬性型別名稱
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// 是否為唯讀
    /// </summary>
    public bool IsReadOnly { get; set; }

    /// <summary>
    /// 是否可為 null
    /// </summary>
    public bool IsNullable { get; set; }
} 