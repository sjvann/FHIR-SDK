using System.Text.Json;
using Fhir.Support.Base;
using Fhir.Support.Examples;

namespace Fhir.Support.Examples;

/// <summary>
/// 簡化架構驗證程式
/// </summary>
public static class SimpleFrameworkValidation
{
    /// <summary>
    /// 執行所有驗證測試
    /// </summary>
    public static void RunAllTests()
    {
        // 設定控制台編碼
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.WriteLine("=== Simple FHIR Framework Validation Tests ===");
        Console.WriteLine();

        TestBasicFunctionality();
        TestJsonSerialization();
        TestJsonDeserialization();
        TestValidation();
        TestSimpleString();

        Console.WriteLine("All tests completed!");
    }

    /// <summary>
    /// 測試基本功能
    /// </summary>
    private static void TestBasicFunctionality()
    {
        Console.WriteLine("1. Testing Basic Functionality...");
        
        try
        {
            var patient = new SimplePatient
            {
                Id = "test-patient",
                Gender = "male",
                Name = new List<SimpleHumanName>
                {
                    new SimpleHumanName
                    {
                        Family = "Test",
                        Given = new List<string> { "User" }
                    }
                }
            };

            // 驗證基本屬性
            if (patient.Id != "test-patient") throw new Exception("ID mismatch");
            if (patient.Gender != "male") throw new Exception("Gender mismatch");
            if (patient.ResourceType != "Patient") throw new Exception("ResourceType mismatch");
            if (patient.Name?.Count != 1) throw new Exception("Name count mismatch");
            if (patient.Name?[0].Family != "Test") throw new Exception("Family mismatch");

            Console.WriteLine("   ✅ Basic functionality test passed");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"   ❌ Basic functionality test failed: {ex.Message}");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// 測試 JSON 序列化
    /// </summary>
    private static void TestJsonSerialization()
    {
        Console.WriteLine("2. Testing JSON Serialization...");
        
        try
        {
            var patient = new SimplePatient
            {
                Id = "json-test",
                Gender = "female"
            };

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var json = JsonSerializer.Serialize(patient, options);
            
            if (!json.Contains("\"resourceType\":\"Patient\"")) throw new Exception("Missing resourceType");
            if (!json.Contains("\"id\":\"json-test\"")) throw new Exception("Missing id");
            if (!json.Contains("\"gender\":\"female\"")) throw new Exception("Missing gender");

            Console.WriteLine("   ✅ JSON serialization test passed");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"   ❌ JSON serialization test failed: {ex.Message}");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// 測試 JSON 反序列化
    /// </summary>
    private static void TestJsonDeserialization()
    {
        Console.WriteLine("3. Testing JSON Deserialization...");
        
        try
        {
            var json = """
            {
                "resourceType": "Patient",
                "id": "deserialize-test",
                "gender": "male"
            }
            """;

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var patient = JsonSerializer.Deserialize<SimplePatient>(json, options);
            
            if (patient == null) throw new Exception("Deserialization result is null");
            if (patient.Id != "deserialize-test") throw new Exception("ID mismatch");
            if (patient.Gender != "male") throw new Exception("Gender mismatch");
            if (patient.ResourceType != "Patient") throw new Exception("ResourceType mismatch");

            Console.WriteLine("   ✅ JSON deserialization test passed");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"   ❌ JSON deserialization test failed: {ex.Message}");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// 測試驗證功能
    /// </summary>
    private static void TestValidation()
    {
        Console.WriteLine("4. Testing Validation Functionality...");
        
        try
        {
            var patient = new SimplePatient
            {
                Gender = "invalid-gender"
            };

            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(patient);
            
            // 手動調用 IValidatableObject 的驗證
            var validationResults = patient.Validate(validationContext).ToList();

            if (validationResults.Count == 0) throw new Exception("Should have validation errors but none found");
            if (!validationResults.Any(r => r.ErrorMessage?.Contains("male, female, other, unknown") == true))
                throw new Exception("Missing expected validation error message");

            Console.WriteLine("   ✅ Validation functionality test passed");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"   ❌ Validation functionality test failed: {ex.Message}");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// 測試 SimpleString
    /// </summary>
    private static void TestSimpleString()
    {
        Console.WriteLine("5. Testing SimpleString...");
        
        try
        {
            var fhirString = new SimpleString("test value");
            
            if (fhirString.Value != "test value") throw new Exception("Value mismatch");
            if (fhirString.ToString() != "test value") throw new Exception("ToString mismatch");

            Console.WriteLine("   ✅ SimpleString test passed");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"   ❌ SimpleString test failed: {ex.Message}");
        }
        Console.WriteLine();
    }
} 