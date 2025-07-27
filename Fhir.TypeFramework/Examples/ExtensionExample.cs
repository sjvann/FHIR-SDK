using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Examples;

/// <summary>
/// Extension 使用範例
/// 展示如何使用 FHIR R5 規範的 Extension 和 Choice Type
/// </summary>
public class ExtensionExample
{
    /// <summary>
    /// 基本 Extension 使用範例
    /// </summary>
    public static void BasicExtensionExample()
    {
        Console.WriteLine("=== 基本 Extension 使用範例 ===");

        // 建立一個簡單的 Extension
        var extension = new Extension
        {
            Url = "http://example.com/patient-height",
            Value = new FhirDecimal(175.5m)
        };

        Console.WriteLine($"Extension URL: {extension.Url}");
        Console.WriteLine($"Extension Value: {extension.Value}");
        Console.WriteLine($"Has Value: {extension.HasValue}");
        Console.WriteLine($"Has Extensions: {extension.HasExtensions}");

        // 取得值
        var heightValue = extension.GetValue<FhirDecimal>();
        if (heightValue != null)
        {
            Console.WriteLine($"Height: {heightValue.Value} cm");
        }
    }

    /// <summary>
    /// 不同型別的 Extension 值範例
    /// </summary>
    public static void DifferentValueTypesExample()
    {
        Console.WriteLine("\n=== 不同型別的 Extension 值範例 ===");

        // 字串型別
        var stringExtension = new Extension
        {
            Url = "http://example.com/patient-name",
            Value = new FhirString("John Doe")
        };

        // 整數型別
        var integerExtension = new Extension
        {
            Url = "http://example.com/patient-age",
            Value = new FhirInteger(30)
        };

        // 布林型別
        var booleanExtension = new Extension
        {
            Url = "http://example.com/patient-active",
            Value = new FhirBoolean(true)
        };

        // 日期型別
        var dateExtension = new Extension
        {
            Url = "http://example.com/patient-birthdate",
            Value = new FhirDate(new DateTime(1990, 1, 1))
        };

        // 時間型別
        var timeExtension = new Extension
        {
            Url = "http://example.com/appointment-time",
            Value = new FhirTime(new TimeSpan(14, 30, 0))
        };

        // 顯示所有值
        Console.WriteLine($"Name: {stringExtension.GetValue<FhirString>()?.Value}");
        Console.WriteLine($"Age: {integerExtension.GetValue<FhirInteger>()?.Value}");
        Console.WriteLine($"Active: {booleanExtension.GetValue<FhirBoolean>()?.Value}");
        Console.WriteLine($"Birth Date: {dateExtension.GetValue<FhirDate>()?.Value:yyyy-MM-dd}");
        Console.WriteLine($"Appointment Time: {timeExtension.GetValue<FhirTime>()?.Value:hh\\:mm}");
    }

    /// <summary>
    /// 巢狀 Extension 範例
    /// </summary>
    public static void NestedExtensionExample()
    {
        Console.WriteLine("\n=== 巢狀 Extension 範例 ===");

        // 建立父 Extension
        var parentExtension = new Extension
        {
            Url = "http://example.com/patient-address"
        };

        // 添加子 Extension
        parentExtension.AddExtension("http://example.com/street", new FhirString("123 Main St"));
        parentExtension.AddExtension("http://example.com/city", new FhirString("New York"));
        parentExtension.AddExtension("http://example.com/zip", new FhirString("10001"));
        parentExtension.AddExtension("http://example.com/country", new FhirString("USA"));

        Console.WriteLine($"Parent Extension URL: {parentExtension.Url}");
        Console.WriteLine($"Has Extensions: {parentExtension.HasExtensions}");
        Console.WriteLine($"Extension Count: {parentExtension.Extension?.Count}");

        // 顯示所有子 Extension
        if (parentExtension.Extension != null)
        {
            foreach (var child in parentExtension.Extension)
            {
                Console.WriteLine($"  - {child.Url}: {child.Value}");
            }
        }

        // 取得特定的子 Extension
        var streetExtension = parentExtension.GetExtension("http://example.com/street");
        if (streetExtension != null)
        {
            var streetValue = streetExtension.GetValue<FhirString>();
            Console.WriteLine($"Street: {streetValue?.Value}");
        }
    }

    /// <summary>
    /// Choice Type 使用範例
    /// </summary>
    public static void ChoiceTypeExample()
    {
        Console.WriteLine("\n=== Choice Type 使用範例 ===");

        // 建立不同型別的 Choice Type
        ExtensionValueChoice stringChoice = new FhirString("String Value");
        ExtensionValueChoice integerChoice = new FhirInteger(42);
        ExtensionValueChoice booleanChoice = new FhirBoolean(true);
        ExtensionValueChoice decimalChoice = new FhirDecimal(123.45m);

        // 使用 Match 方法處理不同型別
        Console.WriteLine("String Choice:");
        stringChoice.Match(
            t0 => Console.WriteLine($"  FhirString: {t0.Value}"),
            t1 => Console.WriteLine("  Not FhirString"),
            t2 => Console.WriteLine("  Not FhirString"),
            t3 => Console.WriteLine("  Not FhirString"),
            t4 => Console.WriteLine("  Not FhirString"),
            t5 => Console.WriteLine("  Not FhirString"),
            t6 => Console.WriteLine("  Not FhirString"),
            t7 => Console.WriteLine("  Not FhirString"),
            t8 => Console.WriteLine("  Not FhirString"),
            t9 => Console.WriteLine("  Not FhirString"),
            t10 => Console.WriteLine("  Not FhirString"),
            t11 => Console.WriteLine("  Not FhirString"),
            t12 => Console.WriteLine("  Not FhirString"),
            t13 => Console.WriteLine("  Not FhirString"),
            t14 => Console.WriteLine("  Not FhirString"),
            t15 => Console.WriteLine("  Not FhirString"),
            t16 => Console.WriteLine("  Not FhirString"),
            t17 => Console.WriteLine("  Not FhirString"),
            t18 => Console.WriteLine("  Not FhirString"),
            t19 => Console.WriteLine("  Not FhirString"),
            t20 => Console.WriteLine("  Not FhirString"),
            t21 => Console.WriteLine("  Not FhirString"),
            t22 => Console.WriteLine("  Not FhirString"),
            t23 => Console.WriteLine("  Not FhirString"),
            t24 => Console.WriteLine("  Not FhirString"),
            t25 => Console.WriteLine("  Not FhirString"),
            t26 => Console.WriteLine("  Not FhirString"),
            t27 => Console.WriteLine("  Not FhirString"),
            t28 => Console.WriteLine("  Not FhirString"),
            t29 => Console.WriteLine("  Not FhirString")
        );

        Console.WriteLine("Integer Choice:");
        integerChoice.Match(
            t0 => Console.WriteLine("  Not FhirInteger"),
            t1 => Console.WriteLine($"  FhirInteger: {t1.Value}"),
            t2 => Console.WriteLine("  Not FhirInteger"),
            t3 => Console.WriteLine("  Not FhirInteger"),
            t4 => Console.WriteLine("  Not FhirInteger"),
            t5 => Console.WriteLine("  Not FhirInteger"),
            t6 => Console.WriteLine("  Not FhirInteger"),
            t7 => Console.WriteLine("  Not FhirInteger"),
            t8 => Console.WriteLine("  Not FhirInteger"),
            t9 => Console.WriteLine("  Not FhirInteger"),
            t10 => Console.WriteLine("  Not FhirInteger"),
            t11 => Console.WriteLine("  Not FhirInteger"),
            t12 => Console.WriteLine("  Not FhirInteger"),
            t13 => Console.WriteLine("  Not FhirInteger"),
            t14 => Console.WriteLine("  Not FhirInteger"),
            t15 => Console.WriteLine("  Not FhirInteger"),
            t16 => Console.WriteLine("  Not FhirInteger"),
            t17 => Console.WriteLine("  Not FhirInteger"),
            t18 => Console.WriteLine("  Not FhirInteger"),
            t19 => Console.WriteLine("  Not FhirInteger"),
            t20 => Console.WriteLine("  Not FhirInteger"),
            t21 => Console.WriteLine("  Not FhirInteger"),
            t22 => Console.WriteLine("  Not FhirInteger"),
            t23 => Console.WriteLine("  Not FhirInteger"),
            t24 => Console.WriteLine("  Not FhirInteger"),
            t25 => Console.WriteLine("  Not FhirInteger"),
            t26 => Console.WriteLine("  Not FhirInteger"),
            t27 => Console.WriteLine("  Not FhirInteger"),
            t28 => Console.WriteLine("  Not FhirInteger"),
            t29 => Console.WriteLine("  Not FhirInteger")
        );
    }

    /// <summary>
    /// 驗證範例
    /// </summary>
    public static void ValidationExample()
    {
        Console.WriteLine("\n=== 驗證範例 ===");

        // 有效的 Extension
        var validExtension = new Extension
        {
            Url = "http://example.com/valid",
            Value = new FhirString("Valid Value")
        };

        var validationResults = validExtension.Validate(new System.ComponentModel.DataAnnotations.ValidationContext(validExtension));
        Console.WriteLine($"Valid Extension - Validation Results: {validationResults.Count()}");

        // 無效的 Extension（缺少 URL）
        var invalidExtension = new Extension
        {
            Value = new FhirString("Invalid Value")
        };

        var invalidResults = invalidExtension.Validate(new System.ComponentModel.DataAnnotations.ValidationContext(invalidExtension));
        Console.WriteLine($"Invalid Extension - Validation Results: {invalidResults.Count()}");
        foreach (var result in invalidResults)
        {
            Console.WriteLine($"  - {result.ErrorMessage}");
        }
    }

    /// <summary>
    /// 執行所有範例
    /// </summary>
    public static void RunAllExamples()
    {
        BasicExtensionExample();
        DifferentValueTypesExample();
        NestedExtensionExample();
        ChoiceTypeExample();
        ValidationExample();
    }
} 