using System.Text.Json;
using System.Text.Json.Nodes;

namespace Fhir.Generator.Services;

public static class ResourceListExtractor
{
    public static void ExtractResourceNames(string jsonFilePath, string outputFilePath, string generatedDir)
    {
        using var stream = File.OpenRead(jsonFilePath);
        using var doc = JsonDocument.Parse(stream);
        var root = doc.RootElement;
        var resourceNames = new HashSet<string>();
        int entryCount = 0;

        if (root.TryGetProperty("entry", out var entries))
        {
            entryCount = entries.GetArrayLength();
            Console.WriteLine($"[驗證] entry 陣列長度：{entryCount}");
            foreach (var entry in entries.EnumerateArray())
            {
                if (entry.TryGetProperty("resource", out var resource))
                {
                    if (resource.TryGetProperty("resourceType", out var resourceTypeElem) &&
                        resourceTypeElem.GetString() == "StructureDefinition")
                    {
                        if (resource.TryGetProperty("kind", out var kindElem) &&
                            kindElem.GetString() == "resource")
                        {
                            if (resource.TryGetProperty("name", out var nameElem))
                            {
                                var name = nameElem.GetString();
                                if (!string.IsNullOrWhiteSpace(name))
                                {
                                    resourceNames.Add(name);
                                }
                            }
                        }
                    }
                }
            }
        }

        // Resource 清單數量驗證
        Console.WriteLine($"[驗證] 解析出 Resource 數量：{resourceNames.Count}");
        File.WriteAllLines(outputFilePath, resourceNames.OrderBy(n => n));
        Console.WriteLine($"已存成檔案：{outputFilePath}");

        // 比對 Fhir.Models/R4 目錄下已生成的 Resource
        if (!string.IsNullOrWhiteSpace(generatedDir) && Directory.Exists(generatedDir))
        {
            var generated = Directory.GetFiles(generatedDir, "*.cs")
                .Select(f => Path.GetFileNameWithoutExtension(f))
                .ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = resourceNames.Except(generated).OrderBy(n => n).ToList();
            var extra = generated.Except(resourceNames).OrderBy(n => n).ToList();
            Console.WriteLine($"[驗證] 已生成 Resource 數量：{generated.Count}");
            if (missing.Count > 0)
            {
                Console.WriteLine($"[警告] 尚未生成的 Resource：{missing.Count} 個");
                foreach (var m in missing) Console.WriteLine($"  缺少：{m}");
                File.WriteAllLines(Path.Combine(generatedDir, "missing-resource.txt"), missing);
            }
            else
            {
                Console.WriteLine("[驗證] 所有 Resource 均已生成！");
            }
            if (extra.Count > 0)
            {
                Console.WriteLine($"[警告] 多餘的 Resource：{extra.Count} 個");
                foreach (var e in extra) Console.WriteLine($"  多餘：{e}");
                File.WriteAllLines(Path.Combine(generatedDir, "extra-resource.txt"), extra);
            }
        }
    }
} 