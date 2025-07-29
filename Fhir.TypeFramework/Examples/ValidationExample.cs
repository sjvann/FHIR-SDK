using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Extensions;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.Examples;

/// <summary>
/// 混合驗證方案使用範例
/// 展示如何使用新的驗證框架和擴展方法
/// </summary>
/// <remarks>
/// 這個範例展示：
/// - 基本驗證工具的使用
/// - FHIR 特定驗證規則的使用
/// - 複雜驗證邏輯的使用
/// - 擴展方法的使用
/// </remarks>
public static class ValidationExample
{
    /// <summary>
    /// 基本驗證範例
    /// </summary>
    public static void BasicValidationExample()
    {
        Console.WriteLine("=== 基本驗證範例 ===");

        // 建立 Primitive Types
        var fhirString = new FhirString("Hello World");
        var fhirId = new FhirId("patient-123");
        var fhirUri = new FhirUri("http://example.com/resource");
        var fhirPositiveInt = new FhirPositiveInt(42);

        // 驗證物件
        Console.WriteLine($"FhirString 有效: {fhirString.IsValid()}");
        Console.WriteLine($"FhirId 有效: {fhirId.IsValid()}");
        Console.WriteLine($"FhirUri 有效: {fhirUri.IsValid()}");
        Console.WriteLine($"FhirPositiveInt 有效: {fhirPositiveInt.IsValid()}");

        // 取得驗證錯誤
        var invalidString = new FhirString(new string('a', 1024 * 1024 + 1)); // 超過 1MB
        var errors = invalidString.GetValidationErrors();
        Console.WriteLine($"無效字串錯誤: {string.Join(", ", errors)}");
    }

    /// <summary>
    /// Extension 使用範例
    /// </summary>
    public static void ExtensionUsageExample()
    {
        Console.WriteLine("\n=== Extension 使用範例 ===");

        // 建立一個可擴展的物件（例如 Element）
        var element = new MyElement();

        // 使用擴展方法快速建立 Extension
        element.CreateStringExtension("http://example.com/custom", "customValue");
        element.CreateIntegerExtension("http://example.com/count", 42);
        element.CreateBooleanExtension("http://example.com/active", true);

        // 取得 Extension 值
        var stringValue = element.GetStringExtensionValue("http://example.com/custom");
        var intValue = element.GetIntegerExtensionValue("http://example.com/count");
        var boolValue = element.GetBooleanExtensionValue("http://example.com/active");

        Console.WriteLine($"字串擴展值: {stringValue}");
        Console.WriteLine($"整數擴展值: {intValue}");
        Console.WriteLine($"布林擴展值: {boolValue}");

        // 檢查 Extension 是否存在
        Console.WriteLine($"有自訂擴展: {element.HasExtension("http://example.com/custom")}");

        // 移除 Extension
        var removed = element.RemoveExtension("http://example.com/custom");
        Console.WriteLine($"移除擴展成功: {removed}");
        Console.WriteLine($"移除後仍有擴展: {element.HasExtension("http://example.com/custom")}");
    }

    /// <summary>
    /// 複雜驗證範例
    /// </summary>
    public static void ComplexValidationExample()
    {
        Console.WriteLine("\n=== 複雜驗證範例 ===");

        // 建立 Reference 物件
        var reference = new Reference
        {
            Reference = "Patient/123",
            Display = "John Doe"
        };

        // 驗證 Reference
        var isValid = reference.IsValid();
        var errors = reference.GetValidationErrors();
        Console.WriteLine($"Reference 有效: {isValid}");
        if (!isValid)
        {
            Console.WriteLine($"Reference 錯誤: {string.Join(", ", errors)}");
        }

        // 建立無效的 Reference（沒有 reference 也沒有 identifier）
        var invalidReference = new Reference
        {
            Display = "John Doe"
        };

        var invalidErrors = invalidReference.GetValidationErrors();
        Console.WriteLine($"無效 Reference 錯誤: {string.Join(", ", invalidErrors)}");
    }

    /// <summary>
    /// 驗證框架直接使用範例
    /// </summary>
    public static void ValidationFrameworkExample()
    {
        Console.WriteLine("\n=== 驗證框架直接使用範例 ===");

        // 基本驗證工具
        var isValidId = ValidationFramework.ValidateFhirId("patient-123");
        var isValidUri = ValidationFramework.ValidateFhirUri("http://example.com/resource");
        var isValidPositiveInt = ValidationFramework.ValidatePositiveInteger(42);

        Console.WriteLine($"ID 有效: {isValidId}");
        Console.WriteLine($"URI 有效: {isValidUri}");
        Console.WriteLine($"正整數有效: {isValidPositiveInt}");

        // 測試無效值
        var invalidId = ValidationFramework.ValidateFhirId("invalid@id"); // 包含無效字元
        var invalidUri = ValidationFramework.ValidateFhirUri("not-a-uri");
        var invalidPositiveInt = ValidationFramework.ValidatePositiveInteger(0); // 0 不是正整數

        Console.WriteLine($"無效 ID: {invalidId}");
        Console.WriteLine($"無效 URI: {invalidUri}");
        Console.WriteLine($"無效正整數: {invalidPositiveInt}");
    }

    /// <summary>
    /// 型別轉換範例
    /// </summary>
    public static void TypeConversionExample()
    {
        Console.WriteLine("\n=== 型別轉換範例 ===");

        // 建立不同型別的物件
        var fhirString = new FhirString("Hello");
        var fhirInteger = new FhirInteger(42);
        var fhirBoolean = new FhirBoolean(true);

        // 使用擴展方法進行安全轉換
        var stringValue = fhirString.ToSafeString();
        var intValue = fhirInteger.ToSafeInteger();
        var boolValue = fhirBoolean.ToSafeBoolean();

        Console.WriteLine($"字串值: {stringValue}");
        Console.WriteLine($"整數值: {intValue}");
        Console.WriteLine($"布林值: {boolValue}");

        // 測試跨型別轉換
        var stringFromInt = fhirInteger.ToSafeString();
        var intFromString = fhirString.ToSafeInteger(); // 應該返回 null

        Console.WriteLine($"整數轉字串: {stringFromInt}");
        Console.WriteLine($"字串轉整數: {intFromString}");
    }

    /// <summary>
    /// 驗證並拋出例外範例
    /// </summary>
    public static void ValidationWithExceptionExample()
    {
        Console.WriteLine("\n=== 驗證並拋出例外範例 ===");

        try
        {
            // 建立一個無效的物件
            var invalidId = new FhirId("invalid@id");
            
            // 驗證並拋出例外
            invalidId.ValidateAndThrow();
        }
        catch (ValidationException ex)
        {
            Console.WriteLine($"驗證例外: {ex.Message}");
        }
    }
}

/// <summary>
/// 範例 Element 類別
/// </summary>
public class MyElement : IExtensibleTypeFramework
{
    public string TypeName => "MyElement";
    public IList<IExtension>? Extension { get; set; }
    public ITypeFramework DeepCopy() => this;
    public bool IsExactly(ITypeFramework other) => ReferenceEquals(this, other);
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => Enumerable.Empty<ValidationResult>();
} 