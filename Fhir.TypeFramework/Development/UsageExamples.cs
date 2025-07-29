using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Development;

/// <summary>
/// 使用範例集合
/// 提供各種型別的使用範例和最佳實踐
/// </summary>
/// <remarks>
/// 這個類別提供：
/// - 基本型別使用範例
/// - 複雜型別使用範例
/// - Extension 使用範例
/// - 驗證使用範例
/// - 版本無關的設計
/// </remarks>
public static class UsageExamples
{
    /// <summary>
    /// 基本型別使用範例
    /// </summary>
    public static void BasicTypeExamples()
    {
        // 字串型別
        var name = new FhirString("John Doe");
        var uri = new FhirUri("https://example.com");
        var id = new FhirId("patient-123");

        // 數值型別
        var age = new FhirInteger(30);
        var positiveAge = new FhirPositiveInt(25);
        var decimalValue = new FhirDecimal(3.14m);

        // 布林型別
        var isActive = new FhirBoolean(true);

        // 驗證
        var nameValid = name.IsValid();
        var ageValid = age.IsValid();
        var uriValid = uri.IsValid();
    }

    /// <summary>
    /// 複雜型別使用範例
    /// </summary>
    public static void ComplexTypeExamples()
    {
        // Extension 使用
        var extension = new Extension
        {
            Url = "https://example.com/custom-extension",
            Value = new ExtensionValueChoice()
        };

        // 設定 Extension 值
        extension.Value.SetStringValue("custom-value");
        // 或
        extension.Value.SetIntegerValue(42);
        // 或
        extension.Value.SetBooleanValue(true);

        // HumanName 使用
        var humanName = new HumanName
        {
            Use = new FhirCode("official"),
            Family = new FhirString("Doe"),
            Given = new List<FhirString> { new FhirString("John"), new FhirString("William") }
        };

        // 驗證複雜型別
        var extensionValid = extension.IsValid();
        var nameValid = humanName.IsValid();
    }

    /// <summary>
    /// Extension 使用範例
    /// </summary>
    public static void ExtensionExamples()
    {
        // 建立 Extension
        var extension = new Extension
        {
            Url = "https://example.com/extension",
            Value = new ExtensionValueChoice()
        };

        // 設定不同類型的值
        extension.Value.SetStringValue("string-value");
        extension.Value.SetIntegerValue(123);
        extension.Value.SetBooleanValue(true);
        extension.Value.SetDecimalValue(3.14m);

        // 取得值
        var stringValue = extension.Value.GetStringValue();
        var intValue = extension.Value.GetIntegerValue();
        var boolValue = extension.Value.GetBooleanValue();
        var decimalValue = extension.Value.GetDecimalValue();

        // 檢查值類型
        var isString = extension.Value.IsString();
        var isInteger = extension.Value.IsInteger();
        var isBoolean = extension.Value.IsBoolean();
        var isDecimal = extension.Value.IsDecimal();
    }

    /// <summary>
    /// 驗證使用範例
    /// </summary>
    public static void ValidationExamples()
    {
        // 建立測試物件
        var name = new FhirString("John Doe");
        var age = new FhirInteger(30);
        var uri = new FhirUri("https://example.com");

        // 基本驗證
        var nameValid = name.IsValid();
        var ageValid = age.IsValid();
        var uriValid = uri.IsValid();

        // 取得驗證錯誤
        var nameErrors = name.GetValidationErrors();
        var ageErrors = age.GetValidationErrors();
        var uriErrors = uri.GetValidationErrors();

        // 驗證並拋出例外
        try
        {
            name.ValidateAndThrow();
            age.ValidateAndThrow();
            uri.ValidateAndThrow();
        }
        catch (ValidationException ex)
        {
            Console.WriteLine($"Validation failed: {ex.Message}");
        }
    }

    /// <summary>
    /// 深層複製範例
    /// </summary>
    public static void DeepCopyExamples()
    {
        // 建立原始物件
        var original = new FhirString("original-value");
        original.AddExtension("https://example.com/extension", new FhirString("extension-value"));

        // 深層複製
        var copy = original.DeepCopy() as FhirString;

        // 驗證複製結果
        var isEqual = original.IsExactly(copy);
        var hasSameValue = original.Value == copy?.Value;
        var hasSameExtensions = original.Extension?.Count == copy?.Extension?.Count;
    }

    /// <summary>
    /// 相等性比較範例
    /// </summary>
    public static void EqualityExamples()
    {
        // 建立相同值的物件
        var obj1 = new FhirString("test-value");
        var obj2 = new FhirString("test-value");

        // 基本相等性比較
        var areEqual = obj1.IsExactly(obj2);

        // 不同值的比較
        var obj3 = new FhirString("different-value");
        var areNotEqual = !obj1.IsExactly(obj3);

        // 與 null 比較
        var isNotEqualToNull = !obj1.IsExactly(null);
    }

    /// <summary>
    /// 型別轉換範例
    /// </summary>
    public static void TypeConversionExamples()
    {
        // 隱含轉換
        FhirString fhirString = "Hello World";
        FhirInteger fhirInteger = 42;
        FhirBoolean fhirBoolean = true;

        // 顯含轉換
        string stringValue = fhirString;
        int intValue = fhirInteger;
        bool boolValue = fhirBoolean;

        // 安全轉換
        var safeString = fhirString.ToSafeString();
        var safeInt = fhirInteger.ToSafeInt();
        var safeBool = fhirBoolean.ToSafeBool();
    }

    /// <summary>
    /// 集合操作範例
    /// </summary>
    public static void CollectionExamples()
    {
        // 建立集合
        var names = new List<FhirString>
        {
            new FhirString("John"),
            new FhirString("Jane"),
            new FhirString("Bob")
        };

        // 驗證集合中的所有元素
        var allValid = names.All(name => name.IsValid());

        // 取得所有驗證錯誤
        var allErrors = names.SelectMany(name => name.GetValidationErrors());

        // 深層複製集合
        var copiedNames = names.Select(name => name.DeepCopy() as FhirString).ToList();
    }

    /// <summary>
    /// 錯誤處理範例
    /// </summary>
    public static void ErrorHandlingExamples()
    {
        try
        {
            // 建立可能無效的物件
            var invalidUri = new FhirUri("invalid-uri");
            
            // 驗證並處理錯誤
            if (!invalidUri.IsValid())
            {
                var errors = invalidUri.GetValidationErrors();
                foreach (var error in errors)
                {
                    Console.WriteLine($"Validation error: {error}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    /// <summary>
    /// 效能優化範例
    /// </summary>
    public static void PerformanceExamples()
    {
        // 使用效能監控
        using (Performance.PerformanceMonitor.Measure("建立物件"))
        {
            var name = new FhirString("John Doe");
            var age = new FhirInteger(30);
        }

        // 批次驗證
        var items = new List<ITypeFramework>
        {
            new FhirString("test"),
            new FhirInteger(42),
            new FhirBoolean(true)
        };

        using (Performance.PerformanceMonitor.Measure("批次驗證"))
        {
            var context = new ValidationContext(items.First());
            var results = Performance.ValidationOptimizer.BatchValidate(items, context);
        }
    }
} 