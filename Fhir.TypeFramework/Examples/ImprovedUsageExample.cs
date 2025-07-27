using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Extensions;
using Fhir.TypeFramework.Serialization;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.Examples;

/// <summary>
/// 改善後的使用範例
/// 展示 Fhir.TypeFramework 的增強功能
/// </summary>
public class ImprovedUsageExample
{
    /// <summary>
    /// 執行所有改善後的範例
    /// </summary>
    public static void RunAllExamples()
    {
        Console.WriteLine("🚀 Fhir.TypeFramework 改善後使用範例");
        Console.WriteLine("=====================================");

        FluentApiExample();
        ValidationExample();
        SerializationExample();
        ExtensionExample();
        PerformanceExample();

        Console.WriteLine("\n✅ 所有改善後範例執行完成！");
    }

    /// <summary>
    /// 流暢 API 使用範例
    /// </summary>
    public static void FluentApiExample()
    {
        Console.WriteLine("\n🔧 流暢 API 使用範例");
        Console.WriteLine("----------------------");

        // 使用流暢 API 建立 Patient
        var patient = new Patient()
            .WithId("patient-123")
            .WithExtension("http://example.com/custom", "custom-value")
            .WithExtension("http://example.com/priority", 1);

        // 設定基本資訊
        patient.Name = new HumanName()
            .WithId("name-1")
            .WithExtension("http://example.com/name-type", "official")
            .WithValue("張", "三");

        patient.BirthDate = new FhirDate(DateTime.Now.AddYears(-30))
            .WithId("birth-date-1");

        patient.Gender = new FhirCode("male")
            .WithId("gender-1");

        Console.WriteLine($"✅ 建立 Patient: {patient.Id}");
        Console.WriteLine($"✅ 姓名: {patient.Name?.Family} {string.Join(" ", patient.Name?.Given?.Select(g => g.Value) ?? Array.Empty<string>())}");
        Console.WriteLine($"✅ 生日: {patient.BirthDate?.Value:yyyy-MM-dd}");
        Console.WriteLine($"✅ 性別: {patient.Gender?.Value}");
        Console.WriteLine($"✅ 擴展數量: {patient.Extension?.Count ?? 0}");
    }

    /// <summary>
    /// 驗證機制使用範例
    /// </summary>
    public static void ValidationExample()
    {
        Console.WriteLine("\n🔧 驗證機制使用範例");
        Console.WriteLine("----------------------");

        // 建立自訂驗證規則
        var customRule = new StringLengthRule(50);
        customRule.RegisterFhirValidationRule();

        // 測試驗證
        var testString = new FhirString("This is a very long string that exceeds the maximum length of 50 characters");
        var validationContext = new ValidationContext(testString);
        
        var validationResults = testString.ValidateWithFhirRules(validationContext);
        
        Console.WriteLine($"✅ 驗證結果數量: {validationResults.Count()}");
        foreach (var result in validationResults)
        {
            Console.WriteLine($"❌ 驗證錯誤: {result.ErrorMessage}");
        }

        // 測試 URI 驗證
        var invalidUri = new FhirUri("invalid-uri-format");
        var uriValidationResults = invalidUri.ValidateWithFhirRule("UriFormat", new ValidationContext(invalidUri));
        
        if (uriValidationResults != null)
        {
            Console.WriteLine($"❌ URI 驗證錯誤: {uriValidationResults.ErrorMessage}");
        }

        // 測試整數範圍驗證
        var largeInteger = new FhirInteger(999999999);
        var integerValidationResults = largeInteger.ValidateWithFhirRule("IntegerRange", new ValidationContext(largeInteger));
        
        if (integerValidationResults != null)
        {
            Console.WriteLine($"❌ 整數驗證錯誤: {integerValidationResults.ErrorMessage}");
        }
    }

    /// <summary>
    /// 序列化使用範例
    /// </summary>
    public static void SerializationExample()
    {
        Console.WriteLine("\n🔧 序列化使用範例");
        Console.WriteLine("----------------------");

        var serializer = new FhirJsonSerializer();

        // 建立測試資料
        var fhirString = new FhirString("Hello World")
            .WithId("test-string-1")
            .WithExtension("http://example.com/custom", "extension-value");

        // 簡化序列化
        var simpleJson = serializer.SerializeSimple(fhirString);
        Console.WriteLine($"✅ 簡化 JSON: {simpleJson}");

        // 完整序列化
        var fullJson = serializer.SerializeFull(fhirString);
        Console.WriteLine($"✅ 完整 JSON: {fullJson}");

        // FHIR 格式序列化
        var fhirJson = serializer.SerializeFhirFormat("name", fhirString);
        Console.WriteLine($"✅ FHIR 格式 JSON: {fhirJson}");

        // 反序列化測試
        var deserialized = serializer.DeserializeSimple<FhirString>(simpleJson);
        Console.WriteLine($"✅ 反序列化結果: {deserialized?.Value}");
    }

    /// <summary>
    /// 擴展功能使用範例
    /// </summary>
    public static void ExtensionExample()
    {
        Console.WriteLine("\n🔧 擴展功能使用範例");
        Console.WriteLine("----------------------");

        var element = new Element();

        // 使用流暢 API 添加擴展
        element
            .WithExtension("http://example.com/string-ext", "string-value")
            .WithExtension("http://example.com/int-ext", 42)
            .WithExtension("http://example.com/bool-ext", true)
            .WithExtension("http://example.com/date-ext", DateTime.Now);

        Console.WriteLine($"✅ 擴展數量: {element.Extension?.Count ?? 0}");

        // 檢查擴展
        Console.WriteLine($"✅ 是否有字串擴展: {element.HasExtension("http://example.com/string-ext")}");
        Console.WriteLine($"✅ 是否有不存在的擴展: {element.HasExtension("http://example.com/non-existent")}");

        // 取得擴展值
        var stringValue = element.GetExtensionValue<Element, FhirString>("http://example.com/string-ext");
        Console.WriteLine($"✅ 字串擴展值: {stringValue?.Value}");

        // 移除擴展
        element.WithoutExtension("http://example.com/string-ext");
        Console.WriteLine($"✅ 移除後擴展數量: {element.Extension?.Count ?? 0}");
    }

    /// <summary>
    /// 效能優化使用範例
    /// </summary>
    public static void PerformanceExample()
    {
        Console.WriteLine("\n🔧 效能優化使用範例");
        Console.WriteLine("----------------------");

        // 測試隱含轉換效能
        var startTime = DateTime.Now;
        
        for (int i = 0; i < 10000; i++)
        {
            FhirString str = $"Test String {i}";
            FhirInteger num = i;
            FhirBoolean flag = i % 2 == 0;
        }
        
        var endTime = DateTime.Now;
        Console.WriteLine($"✅ 隱含轉換 10000 次耗時: {(endTime - startTime).TotalMilliseconds}ms");

        // 測試流暢 API 效能
        startTime = DateTime.Now;
        
        for (int i = 0; i < 1000; i++)
        {
            var element = new Element()
                .WithId($"element-{i}")
                .WithExtension("http://example.com/test", $"value-{i}")
                .WithExtension("http://example.com/number", i);
        }
        
        endTime = DateTime.Now;
        Console.WriteLine($"✅ 流暢 API 1000 次耗時: {(endTime - startTime).TotalMilliseconds}ms");

        // 測試驗證效能
        startTime = DateTime.Now;
        
        for (int i = 0; i < 1000; i++)
        {
            var testString = new FhirString($"Test string {i}");
            var validationContext = new ValidationContext(testString);
            var results = testString.ValidateWithFhirRules(validationContext);
        }
        
        endTime = DateTime.Now;
        Console.WriteLine($"✅ 驗證 1000 次耗時: {(endTime - startTime).TotalMilliseconds}ms");
    }

    /// <summary>
    /// 實際應用場景範例
    /// </summary>
    public static void RealWorldExample()
    {
        Console.WriteLine("\n🔧 實際應用場景範例");
        Console.WriteLine("----------------------");

        // 建立一個完整的醫療記錄
        var patient = new Patient()
            .WithId("patient-001")
            .WithExtension("http://hospital.com/patient-type", "outpatient")
            .WithExtension("http://hospital.com/priority", 2);

        // 設定患者基本資訊
        patient.Name = new HumanName()
            .WithValue("李", "小明")
            .WithExtension("http://hospital.com/name-source", "official");

        patient.BirthDate = new FhirDate(new DateTime(1990, 5, 15))
            .WithExtension("http://hospital.com/date-verified", true);

        patient.Gender = new FhirCode("male");

        // 建立聯絡資訊
        var contact = new ContactPoint()
            .WithValue("phone", "0912345678")
            .WithExtension("http://hospital.com/contact-preference", "phone");

        patient.Telecom = new List<ContactPoint> { contact };

        // 驗證患者資料
        var validationContext = new ValidationContext(patient);
        var validationResults = patient.Validate(validationContext);

        Console.WriteLine($"✅ 患者 ID: {patient.Id}");
        Console.WriteLine($"✅ 患者姓名: {patient.Name?.Family} {string.Join(" ", patient.Name?.Given?.Select(g => g.Value) ?? Array.Empty<string>())}");
        Console.WriteLine($"✅ 患者生日: {patient.BirthDate?.Value:yyyy-MM-dd}");
        Console.WriteLine($"✅ 患者性別: {patient.Gender?.Value}");
        Console.WriteLine($"✅ 聯絡電話: {patient.Telecom?.FirstOrDefault()?.Value}");
        Console.WriteLine($"✅ 驗證結果: {(validationResults.Any() ? "有錯誤" : "通過")}");

        if (validationResults.Any())
        {
            foreach (var result in validationResults)
            {
                Console.WriteLine($"❌ 驗證錯誤: {result.ErrorMessage}");
            }
        }
    }
} 