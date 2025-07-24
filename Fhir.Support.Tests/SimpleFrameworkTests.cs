// UTF-8 with BOM
using System.Text.Json;
using Fhir.Support.Base;
using Fhir.Support.Examples;
using Xunit;

namespace Fhir.Support.Tests;

/// <summary>
/// 簡化架構測試
/// </summary>
public class SimpleFrameworkTests
{
    /// <summary>
    /// 測試基本功能
    /// </summary>
    [Fact]
    public void TestBasicFunctionality()
    {
        // 建立一個簡單的 Patient
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
        Assert.Equal("test-patient", patient.Id);
        Assert.Equal("male", patient.Gender);
        Assert.Equal("Patient", patient.ResourceType);
        Assert.NotNull(patient.Name);
        Assert.Single(patient.Name);
        Assert.Equal("Test", patient.Name[0].Family);
    }

    /// <summary>
    /// 測試 JSON 序列化
    /// </summary>
    [Fact]
    public void TestJsonSerialization()
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
        Assert.Contains("\"resourceType\":\"Patient\"", json);
        Assert.Contains("\"id\":\"json-test\"", json);
        Assert.Contains("\"gender\":\"female\"", json);
    }

    /// <summary>
    /// 測試 JSON 反序列化
    /// </summary>
    [Fact]
    public void TestJsonDeserialization()
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
        Assert.NotNull(patient);
        Assert.Equal("deserialize-test", patient.Id);
        Assert.Equal("male", patient.Gender);
        Assert.Equal("Patient", patient.ResourceType);
    }

    /// <summary>
    /// 測試驗證功能
    /// </summary>
    [Fact]
    public void TestValidation()
    {
        var patient = new SimplePatient
        {
            Gender = "invalid-gender"
        };

        var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(patient);
        
        // 手動調用 IValidatableObject 的驗證
        var validationResults = patient.Validate(validationContext).ToList();

        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("male, female, other, unknown") == true);
    }

    /// <summary>
    /// 測試 SimpleString
    /// </summary>
    [Fact]
    public void TestSimpleString()
    {
        var fhirString = new SimpleString("test value");
        Assert.Equal("test value", fhirString.Value);
        Assert.Equal("test value", fhirString.ToString());
    }

    /// <summary>
    /// 測試範例執行
    /// </summary>
    [Fact]
    public void TestExampleExecution()
    {
        // 這個測試確保範例可以正常執行
        // 實際的輸出會在控制台中顯示
        SimpleFrameworkExample.DemonstrateBasicUsage();
        SimpleFrameworkExample.DemonstrateValidation();
        SimpleFrameworkExample.DemonstrateTypeConversion();
        
        // 如果沒有例外，測試通過
        Assert.True(true);
    }

    /// <summary>
    /// 測試驗證程式執行
    /// </summary>
    [Fact]
    public void TestValidationExecution()
    {
        // 執行驗證程式
        SimpleFrameworkValidation.RunAllTests();
        
        // 如果沒有例外，測試通過
        Assert.True(true);
    }
} 