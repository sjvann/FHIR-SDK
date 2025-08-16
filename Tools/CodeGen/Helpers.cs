using System.Text;
using System.Text.Json;

namespace CodeGen;

internal static class Helpers
{
    public static string ResolveProfilesPath(string defsRoot, string version)
    {
        if (File.Exists(defsRoot) && defsRoot.EndsWith("profiles-resources.json", StringComparison.OrdinalIgnoreCase))
            return defsRoot;

        var candidates = new[]
        {
            Path.Combine(defsRoot, version, "profiles-resources.json"),
            Path.Combine(defsRoot, version.ToUpperInvariant(), "profiles-resources.json"),
            Path.Combine(defsRoot, $"Definitions/{version}/profiles-resources.json"),
            Path.Combine(defsRoot, "profiles-resources.json")
        };
        foreach (var c in candidates)
            if (File.Exists(c)) return c;

        throw new FileNotFoundException($"profiles-resources.json not found. Checked: {string.Join(", ", candidates)}");
    }

    public static (IReadOnlyList<string> resources, int total) ReadResourceTypesFromJson(Stream jsonStream)
    {
        using var doc = JsonDocument.Parse(jsonStream);
        var root = doc.RootElement;
        if (!root.TryGetProperty("entry", out var entries) || entries.ValueKind != JsonValueKind.Array)
            return (Array.Empty<string>(), 0);

        var names = new List<string>();
        foreach (var ent in entries.EnumerateArray())
        {
            if (!ent.TryGetProperty("resource", out var res)) continue;
            var kind = res.TryGetProperty("kind", out var k) ? k.GetString() : null;
            if (!string.Equals(kind, "resource", StringComparison.OrdinalIgnoreCase)) continue;
            var type = res.TryGetProperty("type", out var t) ? t.GetString() : null;
            if (!string.IsNullOrWhiteSpace(type)) names.Add(type!);
        }
        names = names.Distinct(StringComparer.OrdinalIgnoreCase).OrderBy(n => n, StringComparer.OrdinalIgnoreCase).ToList();
        return (names, names.Count);
    }

    public static string EnsureGeneratedDir(string outputProjectArg)
    {
        string projectDir;
        if (File.Exists(outputProjectArg) && outputProjectArg.EndsWith(".csproj", StringComparison.OrdinalIgnoreCase))
            projectDir = Path.GetDirectoryName(Path.GetFullPath(outputProjectArg))!;
        else if (Directory.Exists(outputProjectArg))
            projectDir = Path.GetFullPath(outputProjectArg);
        else
            throw new DirectoryNotFoundException($"Output project not found: {outputProjectArg}");

        var genDir = Path.Combine(projectDir, "Generated");
        if (!Directory.Exists(genDir)) Directory.CreateDirectory(genDir);
        return genDir;
    }

    public static void WriteFile(string path, string content, bool isDryRun)
    {
        if (isDryRun)
        {
            Console.WriteLine($"[CodeGen] Dry-run on. Would write: {path}");
            return;
        }
        File.WriteAllText(path, content, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
        Console.WriteLine($"[CodeGen] Wrote: {path}");
    }
}

