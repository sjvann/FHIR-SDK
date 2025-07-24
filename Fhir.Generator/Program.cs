using Fhir.Generator.Services;
using System.Text.Json;

namespace Fhir.Generator;

class Program
{
    static void Main(string[] args)
    {
        var jsonPath = @"Definitions/R4/profiles/profiles-resources.json";
        var generatedDir = @"Fhir.Models/R4";
        var missingPath = @"Fhir.Models/R4/missing-resource.txt";

        // 讀取缺漏清單
        if (!File.Exists(missingPath))
        {
            Console.WriteLine("[完成] 沒有缺漏 Resource！");
            return;
        }
        var allMissing = File.ReadAllLines(missingPath).Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
        if (allMissing.Count == 0)
        {
            Console.WriteLine("[完成] 沒有缺漏 Resource！");
            return;
        }

        var parser = new ResourceDefinitionParser(jsonPath);
        var generator = new SimpleGenerator();
        int success = 0, fail = 0;
        foreach (var name in allMissing)
        {
            var def = parser.GetResourceDefinitionByName(name);
            if (def == null)
            {
                Console.WriteLine($"[警告] 找不到 Resource 定義：{name}");
                fail++;
                continue;
            }
            // 解析 StructureDefinition 產生 ResourceInfo
            var info = StructureDefinitionToResourceInfo(def.Value);
            var cs = generator.GenerateSimpleResource(info, "R4");
            var filePath = Path.Combine(generatedDir, name + ".cs");
            File.WriteAllText(filePath, cs);
            Console.WriteLine($"  ✅ 已生成：{name}.cs");
            success++;
        }
        Console.WriteLine($"\n[完成] 共產生 {success} 個 Resource，失敗 {fail} 個。");
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
