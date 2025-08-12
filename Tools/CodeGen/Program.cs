using System.Text;
using System.Text.Json;
using CodeGen.Models;
using CodeGen.Services;
using CodeGen.Generators;

// CLI entry point
var defs = GetArg("--definitions-root");
var ver = GetArg("--version", "R5");
var proj = GetArg("--output-project");
var inc = GetArg("--include", null);
var dry = GetBool("--dry-run", true);

if (string.IsNullOrWhiteSpace(defs) || string.IsNullOrWhiteSpace(proj))
{
    Console.Error.WriteLine("Usage: --definitions-root <path|folder> --version <R4|R5> --output-project <csproj|folder> [--include <A,B>] [--dry-run true|false]");
    return 1;
}

if (!string.Equals(ver, "R4", StringComparison.OrdinalIgnoreCase) && !string.Equals(ver, "R5", StringComparison.OrdinalIgnoreCase))
{
    Console.Error.WriteLine("--version must be R4 or R5");
    return 1;
}

Console.WriteLine($"[CodeGen] Definitions: {defs}");
Console.WriteLine($"[CodeGen] Version: {ver}");
Console.WriteLine($"[CodeGen] OutputProject: {proj}");
Console.WriteLine($"[CodeGen] Include: {inc}");
Console.WriteLine($"[CodeGen] DryRun: {dry}");

try
{
    // Locate profiles-resources.json
    var profilesPath = ResolveProfilesPath(defs, ver.ToUpperInvariant());

    // Read list of resources
    using var fs = File.OpenRead(profilesPath);
    var (allResources, total) = ReadResourceTypesFromJson(fs);

    var selected = allResources;
    if (!string.IsNullOrWhiteSpace(inc))
    {
        var filters = inc.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        selected = allResources.Where(r => filters.Contains(r, StringComparer.OrdinalIgnoreCase)).ToList();
    }

    Console.WriteLine($"[CodeGen] Found {total} resource types; selected {selected.Count}.");

    // Load cardinalities and documentation for selected resources
    using var fs2 = File.OpenRead(profilesPath);
    var cards = new CardinalityService().Load(fs2, selected.ToHashSet(StringComparer.OrdinalIgnoreCase));
    using var fs3 = File.OpenRead(profilesPath);
    var docs = new DocumentationService().Load(fs3, selected.ToHashSet(StringComparer.OrdinalIgnoreCase));
    using var fs4 = File.OpenRead(profilesPath);
    var choices = new ChoiceService().Load(fs4, selected.ToHashSet(StringComparer.OrdinalIgnoreCase));

    // Prepare generator
    var ns = string.Equals(ver, "R4", StringComparison.OrdinalIgnoreCase) ? "FhirSDK.Resources.R4" : "FhirSDK.Resources.R5";
    var emitter = new PropertyEmitter();
    var gen = new PoCGenerator(emitter, docs, choices);

    var outDir = EnsureGeneratedDir(proj);

    // Registry
    var registrySrc = gen.BuildResourceRegistry(ns, ver.ToUpperInvariant(), selected);
    var registryFile = Path.Combine(outDir, $"ResourceRegistry.{ver.ToUpperInvariant()}.g.cs");
    WriteFile(registryFile, registrySrc, dry);

    // Resources
    foreach (var r in selected)
    {
        string src = r switch
        {
            "Patient" => gen.BuildPatient(ns, (IReadOnlyDictionary<string, Cardinality>)cards.GetValueOrDefault("Patient", new Dictionary<string, Cardinality>())),
            "Observation" => gen.BuildObservation(ns, (IReadOnlyDictionary<string, Cardinality>)cards.GetValueOrDefault("Observation", new Dictionary<string, Cardinality>())),
            "Organization" => gen.BuildOrganization(ns, (IReadOnlyDictionary<string, Cardinality>)cards.GetValueOrDefault("Organization", new Dictionary<string, Cardinality>())),
            _ => BuildSkeleton(ns, r)
        };

        var file = Path.Combine(outDir, $"{r}.g.cs");
        WriteFile(file, src, dry);
    }
}
catch (Exception ex)
{
    Console.Error.WriteLine($"[CodeGen] ERROR: {ex.Message}");
    return 2;
}

return 0;

// ---------------- helpers ----------------
string GetArg(string name, string? defaultValue = null)
{
    for (int i = 0; i < args.Length; i++)
    {
        if (string.Equals(args[i], name, StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
            return args[i + 1];
        if (args[i].StartsWith(name + "=", StringComparison.OrdinalIgnoreCase))
            return args[i].Substring(name.Length + 1);
    }
    return defaultValue ?? string.Empty;
}

bool GetBool(string name, bool defaultValue)
{
    var v = GetArg(name, defaultValue.ToString());
    return v.Equals("true", StringComparison.OrdinalIgnoreCase) || v == "1";
}

string ResolveProfilesPath(string defsRoot, string version)
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

(IReadOnlyList<string> resources, int total) ReadResourceTypesFromJson(Stream jsonStream)
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

string EnsureGeneratedDir(string outputProjectArg)
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

string BuildSkeleton(string ns, string resourceType)
{
    var sb = new StringBuilder();
    sb.AppendLine("// <auto-generated>");
    sb.AppendLine("#nullable enable");
    sb.AppendLine("using FhirCore.Base;");
    sb.AppendLine($"namespace {ns}");
    sb.AppendLine("{");
    sb.AppendLine($"    public partial class {resourceType} : ResourceBase");
    sb.AppendLine("    {");
    sb.AppendLine($"        public override string ResourceType => \"{resourceType}\";");
    sb.AppendLine();
    sb.AppendLine($"        public {resourceType}() {{ }}");
    sb.AppendLine($"        public {resourceType}(string id) {{ Id = id; }}");
    sb.AppendLine("    }");
    sb.AppendLine("}");
    return sb.ToString();
}

void WriteFile(string path, string content, bool isDryRun)
{
    if (isDryRun)
    {
        Console.WriteLine($"[CodeGen] Dry-run on. Would write: {path}");
        return;
    }
    File.WriteAllText(path, content, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
    Console.WriteLine($"[CodeGen] Wrote: {path}");
}
