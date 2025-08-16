using System.Text;

namespace CodeGen;

internal static class ExamplesWriter
{
    public static void EmitExamples(string csprojPath, string version, IEnumerable<string> selected, string? examplesSource)
    {
        var projectDir = Path.GetDirectoryName(Path.GetFullPath(csprojPath))!;
        var examplesDir = Path.Combine(projectDir, "Examples");
        Directory.CreateDirectory(examplesDir);

        // Determine source
        string? sourceRoot = null;
        if (!string.IsNullOrWhiteSpace(examplesSource) && Directory.Exists(examplesSource))
        {
            sourceRoot = examplesSource;
        }
        else
        {
            var legacy = Path.Combine(FindRepoRoot(projectDir), $"FhirSDK.Resources.{version.ToUpperInvariant()}.Tests", "Data", version.ToUpperInvariant());
            if (Directory.Exists(legacy)) sourceRoot = legacy;
        }

        // Copy from source if available
        if (!string.IsNullOrWhiteSpace(sourceRoot) && Directory.Exists(sourceRoot))
        {
            foreach (var resDir in Directory.EnumerateDirectories(sourceRoot))
            {
                var resName = new DirectoryInfo(resDir).Name;
                var targetDir = Path.Combine(examplesDir, resName);
                Directory.CreateDirectory(targetDir);
                foreach (var f in Directory.EnumerateFiles(resDir, "*.json", SearchOption.TopDirectoryOnly))
                {
                    var dest = Path.Combine(targetDir, Path.GetFileName(f));
                    File.Copy(f, dest, overwrite: true);
                }
            }
        }

        // Ensure every selected resource has at least one example
        foreach (var resName in selected)
        {
            var resDir = Path.Combine(examplesDir, resName);
            Directory.CreateDirectory(resDir);
            var hasAny = Directory.EnumerateFiles(resDir, "*.json", SearchOption.TopDirectoryOnly).Any();
            if (!hasAny)
            {
                var basicPath = Path.Combine(resDir, "basic.json");
                var json = $"{{\n  \"resourceType\": \"{resName}\"\n}}\n";
                File.WriteAllText(basicPath, json, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
            }
        }

        EnsureEmbeddedExamplesItem(csprojPath);
        Console.WriteLine($"[CodeGen] Embedded examples into: {csprojPath}");
    }

    private static string FindRepoRoot(string start)
    {
        var dir = new DirectoryInfo(start);
        while (dir != null)
        {
            if (File.Exists(Path.Combine(dir.FullName, "Fhir_SDK.sln")))
                return dir.FullName;
            dir = dir.Parent!;
        }
        return start;
    }

    private static void EnsureEmbeddedExamplesItem(string csproj)
    {
        var xml = File.ReadAllText(csproj);
        if (xml.IndexOf("Examples\\**\\*.json", StringComparison.OrdinalIgnoreCase) >= 0)
            return;
        var insert = "  <ItemGroup>\n    <EmbeddedResource Include=\"Examples\\**\\*.json\" />\n  </ItemGroup>\n";
        if (xml.IndexOf("</Project>", StringComparison.OrdinalIgnoreCase) >= 0)
        {
            xml = xml.Replace("</Project>", insert + "</Project>");
            File.WriteAllText(csproj, xml, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
        }
    }
}

