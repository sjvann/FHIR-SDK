using Fhir.Generator.Services;
using System.CommandLine;
using System.Text.Json;

namespace Fhir.Generator;

class Program
{
    static async Task<int> Main(string[] args)
    {
        Console.WriteLine("🚀 FHIR Code Generator");
        Console.WriteLine("======================");

        // 簡化的命令列介面 - 只需要版本號
        var fhirVersionOption = new Option<string>(
            "--fhir-version",
            description: "FHIR version (R4, R5, etc.)")
        {
            IsRequired = true
        };

        var rootCommand = new RootCommand("FHIR Code Generator - Auto-detect definitions")
        {
            fhirVersionOption
        };

        rootCommand.SetHandler(async (fhirVersion) =>
        {
            await GenerateCode(fhirVersion);
        }, fhirVersionOption);

        return await rootCommand.InvokeAsync(args);
    }

    static async Task GenerateCode(string fhirVersion)
    {
        Console.WriteLine($"📋 Target FHIR Version: {fhirVersion}");

        // 自動偵測定義檔路徑
        var definitionsPath = Path.Combine("Definitions", fhirVersion, "definitions.json.zip");

        // 檢查定義檔是否存在
        if (!File.Exists(definitionsPath))
        {
            Console.WriteLine($"❌ Definition file not found: {definitionsPath}");
            Console.WriteLine($"💡 Expected structure: Definitions/{fhirVersion}/definitions.json.zip");
            Console.WriteLine($"🔍 Available versions:");

            var definitionsDir = "Definitions";
            if (Directory.Exists(definitionsDir))
            {
                var availableVersions = Directory.GetDirectories(definitionsDir)
                    .Select(Path.GetFileName)
                    .Where(v => File.Exists(Path.Combine(definitionsDir, v!, "definitions.json.zip")))
                    .ToList();

                if (availableVersions.Any())
                {
                    foreach (var version in availableVersions)
                    {
                        var filePath = Path.Combine(definitionsDir, version!, "definitions.json.zip");
                        var fileSize = new FileInfo(filePath).Length / (1024.0 * 1024.0);
                        Console.WriteLine($"   ✅ {version} ({fileSize:F2} MB)");
                    }
                }
                else
                {
                    Console.WriteLine($"   ❌ No valid definition files found");
                }
            }

            Console.WriteLine($"🚫 Aborting generation for {fhirVersion}");
            return;
        }

        // 根據版本決定輸出目錄和命名空間
        string generatedDir;
        string namespaceName;

        switch (fhirVersion.ToUpper())
        {
            case "R4":
                generatedDir = "Fhir.R4.Models";
                namespaceName = "Fhir.R4.Models";
                break;
            case "R5":
                generatedDir = "Fhir.R5.Models";
                namespaceName = "Fhir.R5.Models";
                break;
            default:
                Console.WriteLine($"❌ Unsupported FHIR version: {fhirVersion}");
                Console.WriteLine($"💡 Supported versions: R4, R5");
                return;
        }

        // 檢查檔案大小和資訊
        var fileInfo = new FileInfo(definitionsPath);
        var fileSizeMB = Math.Round(fileInfo.Length / (1024.0 * 1024.0), 2);
        Console.WriteLine($"📁 Definition file: {definitionsPath} ({fileSizeMB} MB)");
        Console.WriteLine($"📅 File date: {fileInfo.LastWriteTime:yyyy-MM-dd HH:mm:ss}");

        if (fileSizeMB > 50)
        {
            Console.WriteLine("⚠️  Large file detected. Using streaming approach...");
        }

        // 確保輸出目錄存在
        if (!Directory.Exists(generatedDir))
        {
            Console.WriteLine($"📁 Creating output directory: {generatedDir}");
            Directory.CreateDirectory(generatedDir);
        }

        try
        {
            Console.WriteLine($"⚡ Starting {fhirVersion} code generation...");

            // 使用統一的新版生成器
            var loader = new FhirDefinitionLoader();
            var schema = await loader.LoadFromZipAsync(definitionsPath);

            Console.WriteLine($"✅ Loaded {schema.DataTypes.Count} data types");
            Console.WriteLine($"✅ Loaded {schema.Resources.Count} resources");
            Console.WriteLine($"✅ Loaded {schema.ValueSets.Count} value sets");

            var generator = new FhirCodeGenerator();
            await generator.GenerateAllAsync(schema, generatedDir, fhirVersion);

            // 生成 Global Using 檔案
            var globalUsingGenerator = new GlobalUsingGenerator();
            await globalUsingGenerator.GenerateGlobalUsingsAsync(schema, fhirVersion, generatedDir);
            await globalUsingGenerator.GenerateVersionSwitchGuideAsync(fhirVersion, generatedDir);

            Console.WriteLine($"🎉 {fhirVersion} code generation completed successfully!");
            Console.WriteLine($"📦 Output location: {Path.GetFullPath(generatedDir)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Generation failed: {ex.Message}");
            Console.WriteLine($"📋 Stack trace: {ex.StackTrace}");
            throw;
        }
    }

    // 將 StructureDefinition 轉為 ResourceInfo（簡化版，僅示範核心欄位）
    static Fhir.Generator.Models.ResourceInfo StructureDefinitionToResourceInfo(JsonElement def)
    {
        var info = new Fhir.Generator.Models.ResourceInfo();
        info.ClassName = def.GetProperty("name").GetString() ?? "Resource";
        info.ResourceType = def.GetProperty("type").GetString() ?? info.ClassName;
        info.Description = def.GetProperty("description").GetString() ?? info.ClassName;
        info.Properties = new List<Fhir.Generator.Models.PropertyDefinition>();
        if (def.TryGetProperty("snapshot", out var snapshot) && snapshot.TryGetProperty("element", out var elements))
        {
            foreach (var elem in elements.EnumerateArray())
            {
                var path = elem.GetProperty("path").GetString();
                if (string.IsNullOrWhiteSpace(path) || !path.StartsWith(info.ClassName + ".")) continue;
                var propName = path.Substring(info.ClassName.Length + 1);
                var type = elem.TryGetProperty("type", out var types) && types.GetArrayLength() > 0 ? types[0].GetProperty("code").GetString() ?? "string" : "string";
                var desc = elem.TryGetProperty("short", out var s) ? s.GetString() ?? "" : "";
                var min = elem.TryGetProperty("min", out var minVal) ? minVal.GetInt32() : 0;
                var max = elem.TryGetProperty("max", out var maxVal) ? maxVal.GetString() ?? "1" : "1";
                info.Properties.Add(new Fhir.Generator.Models.PropertyDefinition {
                    Name = propName,
                    Type = type,
                    Description = desc,
                    MinCardinality = min,
                    MaxCardinality = max
                });
            }
        }
        return info;
    }
}
