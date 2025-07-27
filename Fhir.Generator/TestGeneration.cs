using Fhir.Generator.Models;
using Fhir.Generator.Services;

namespace Fhir.Generator;

/// <summary>
/// 測試 Generator 生成結果
/// </summary>
public class TestGeneration
{
    public static async Task TestSimpleResourceGeneration()
    {
        Console.WriteLine("🧪 測試 Generator 生成結果");
        
        // 創建一個簡單的測試 Resource
        var testResource = new ResourceInfo
        {
            ClassName = "TestResource",
            ResourceType = "TestResource",
            Description = "A simple test resource for validation",
            Properties = new List<PropertyDefinition>
            {
                new PropertyDefinition
                {
                    Name = "Identifier",
                    Type = "Identifier",
                    Description = "Business identifier for the test resource",
                    MinCardinality = 0,
                    MaxCardinality = "*",
                    Order = 1
                },
                new PropertyDefinition
                {
                    Name = "Active",
                    Type = "boolean",
                    Description = "Whether this test resource record is in active use",
                    MinCardinality = 0,
                    MaxCardinality = "1",
                    Order = 2
                },
                new PropertyDefinition
                {
                    Name = "Name",
                    Type = "string",
                    Description = "A name for the test resource",
                    MinCardinality = 0,
                    MaxCardinality = "1",
                    Order = 3
                },
                new PropertyDefinition
                {
                    Name = "Category",
                    Type = "code",
                    Description = "Category of the test resource",
                    MinCardinality = 0,
                    MaxCardinality = "1",
                    Order = 4
                },
                new PropertyDefinition
                {
                    Name = "EffectiveDate",
                    Type = "date",
                    Description = "When the test resource is effective",
                    MinCardinality = 0,
                    MaxCardinality = "1",
                    Order = 5
                }
            }
        };
        
        // 使用 SimpleGenerator 生成程式碼
        var generator = new SimpleGenerator();
        var generatedCode = generator.GenerateSimpleResource(testResource, "R4");
        
        // 輸出生成的程式碼
        Console.WriteLine("📄 生成的程式碼:");
        Console.WriteLine("================");
        Console.WriteLine(generatedCode);
        
        // 儲存到檔案以便檢查
        var outputPath = "Generated_TestResource.cs";
        await File.WriteAllTextAsync(outputPath, generatedCode);
        Console.WriteLine($"✅ 程式碼已儲存到: {outputPath}");
    }
}
