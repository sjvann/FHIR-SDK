using System.Text.Json;
using Fhir.Support.Base;
using System.Text.Json.Serialization;

namespace Fhir.Support.Examples;

/// <summary>
/// 簡化架構使用範例
/// </summary>
public static class SimpleFrameworkExample
{
    /// <summary>
    /// 示範基本使用
    /// </summary>
    public static void DemonstrateBasicUsage()
    {
        // 設定控制台編碼
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.WriteLine("=== Simple FHIR Framework Example ===");
        
        // 1. 建立一個簡單的 Patient 資源
        var patient = new SimplePatient
        {
            Id = "patient-001",
            Meta = new SimpleMeta
            {
                VersionId = "1",
                LastUpdated = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")
            },
            Text = new SimpleNarrative
            {
                Status = "generated",
                Div = "<div>Patient: John Doe</div>"
            },
            Identifier = new List<SimpleIdentifier>
            {
                new SimpleIdentifier
                {
                    System = "http://hospital.example.org/identifiers/patient",
                    Value = "MRN12345"
                }
            },
            Name = new List<SimpleHumanName>
            {
                new SimpleHumanName
                {
                    Use = "official",
                    Family = "Doe",
                    Given = new List<string> { "John" }
                }
            },
            Gender = "male",
            BirthDate = "1990-01-01"
        };

        // 2. 序列化為 JSON
        var json = JsonSerializer.Serialize(patient, new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        Console.WriteLine("Serialization Result:");
        Console.WriteLine(json);
        Console.WriteLine();

        // 3. 反序列化
        var deserializedPatient = JsonSerializer.Deserialize<SimplePatient>(json);
        Console.WriteLine($"Deserialization Success: {deserializedPatient?.Name?.FirstOrDefault()?.Family}");
        Console.WriteLine();
    }

    /// <summary>
    /// 示範驗證功能
    /// </summary>
    public static void DemonstrateValidation()
    {
        // 設定控制台編碼
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.WriteLine("=== Validation Example ===");
        
        var patient = new SimplePatient
        {
            // 故意建立一個無效的 Patient
            Gender = "invalid-gender" // 無效的性別值
        };

        var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
        var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(patient);
        
        if (!System.ComponentModel.DataAnnotations.Validator.TryValidateObject(patient, validationContext, validationResults, true))
        {
            Console.WriteLine("Validation Failed:");
            foreach (var result in validationResults)
            {
                Console.WriteLine($"- {result.ErrorMessage}");
            }
        }
        else
        {
            Console.WriteLine("Validation Passed");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// 示範型別轉換
    /// </summary>
    public static void DemonstrateTypeConversion()
    {
        // 設定控制台編碼
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.WriteLine("=== Type Conversion Example ===");
        
        // 建立 SimpleString 實例
        var fhirString = new SimpleString("Hello FHIR");
        string nativeString = fhirString.Value ?? string.Empty;
        
        Console.WriteLine($"FHIR String: {fhirString}");
        Console.WriteLine($"Native String: {nativeString}");
        Console.WriteLine();
    }
}

/// <summary>
/// 簡化的 Patient 資源
/// </summary>
public class SimplePatient : SimpleDomainResource, System.ComponentModel.DataAnnotations.IValidatableObject
{
    public override string ResourceType => "Patient";

    /// <summary>
    /// 識別碼
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<SimpleIdentifier>? Identifier { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    [JsonPropertyName("name")]
    public List<SimpleHumanName>? Name { get; set; }

    /// <summary>
    /// 性別
    /// </summary>
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    /// <summary>
    /// 出生日期
    /// </summary>
    [JsonPropertyName("birthDate")]
    public string? BirthDate { get; set; }

    /// <summary>
    /// 驗證
    /// </summary>
    public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(
        System.ComponentModel.DataAnnotations.ValidationContext validationContext)
    {
        // 自訂驗證邏輯
        if (!string.IsNullOrEmpty(Gender) && 
            !new[] { "male", "female", "other", "unknown" }.Contains(Gender.ToLower()))
        {
            yield return new System.ComponentModel.DataAnnotations.ValidationResult(
                "Gender must be one of: male, female, other, unknown",
                new[] { nameof(Gender) });
        }
    }
}

/// <summary>
/// 簡化的識別碼
/// </summary>
public class SimpleIdentifier : SimpleComplexType
{
    /// <summary>
    /// 系統
    /// </summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }

    /// <summary>
    /// 值
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// 簡化的人名
/// </summary>
public class SimpleHumanName : SimpleComplexType
{
    /// <summary>
    /// 使用方式
    /// </summary>
    [JsonPropertyName("use")]
    public string? Use { get; set; }

    /// <summary>
    /// 姓氏
    /// </summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>
    /// 名字
    /// </summary>
    [JsonPropertyName("given")]
    public List<string>? Given { get; set; }
}

/// <summary>
/// 簡化的字串型別
/// </summary>
public class SimpleString : SimplePrimitiveType<string>
{
    public SimpleString() { }
    
    public SimpleString(string? value) : base()
    {
        Value = value;
    }
} 