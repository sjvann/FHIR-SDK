using System.Text;
using CodeGen;

using System.Text.Json;
using CodeGen.Models;
using CodeGen.Services;
using CodeGen.Generators;

// CLI entry point
var a = CliArgs.Parse(args);
var defs = a.DefinitionsRoot;
var ver = a.Version;
var proj = a.OutputProject;
var inc = a.Include;
var dry = a.DryRun;
var emitExamples = a.EmitExamples;
var examplesSource = a.ExamplesSource;

Console.WriteLine($"[CodeGen] Definitions: {defs}");
Console.WriteLine($"[CodeGen] Version: {ver}");
Console.WriteLine($"[CodeGen] OutputProject: {proj}");
Console.WriteLine($"[CodeGen] Include: {inc}");
Console.WriteLine($"[CodeGen] DryRun: {dry}");
Console.WriteLine($"[CodeGen] EmitExamples: {emitExamples}");
Console.WriteLine($"[CodeGen] ExamplesSource: {examplesSource}");

try
{
    // Locate profiles-resources.json
    var profilesPath = Helpers.ResolveProfilesPath(defs, ver.ToUpperInvariant());

    // Read list of resources
    using var fs = File.OpenRead(profilesPath);
    var (allResources, total) = Helpers.ReadResourceTypesFromJson(fs);

    var selected = allResources;
    if (!string.IsNullOrWhiteSpace(inc))
    {
        var filters = inc.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        selected = allResources.Where(r => filters.Contains(r, StringComparer.OrdinalIgnoreCase)).ToList();
    }

    Console.WriteLine($"[CodeGen] Found {total} resource types; selected {selected.Count}.");
    var selectedList = selected.ToList();
    Console.WriteLine($"[CodeGen] Will generate {selectedList.Count} resources.");
    var swAll = System.Diagnostics.Stopwatch.StartNew();

    // Load cardinalities and documentation for selected resources
    using var fs2 = File.OpenRead(profilesPath);
    var cards = new CardinalityService().Load(fs2, selected.ToHashSet(StringComparer.OrdinalIgnoreCase));
    using var fs3 = File.OpenRead(profilesPath);
    var docs = new DocumentationService().Load(fs3, selected.ToHashSet(StringComparer.OrdinalIgnoreCase));
    using var fs4 = File.OpenRead(profilesPath);
    var choices = new ChoiceService().Load(fs4, selected.ToHashSet(StringComparer.OrdinalIgnoreCase));

    // Prepare generator
    var ns = $"FhirSDK.Resources.{ver.ToUpperInvariant()}";
    var emitter = new PropertyEmitter();

    // Load generic type info for all selected resources
    using var fsTypes = File.OpenRead(profilesPath);
    var typeInfo = new TypeInfoService().Load(fsTypes, selected.ToHashSet(StringComparer.OrdinalIgnoreCase));

    var gen = new PoCGenerator(emitter, docs, choices, typeInfo);

    // Ensure target project exists and required references are present (works for new versions like R6)
    var csprojPath = ProjectWriter.EnsureProjectFileAndReferences(proj, ver.ToUpperInvariant());

    var outDir = Helpers.EnsureGeneratedDir(proj);

    // Registry
    var registrySrc = gen.BuildResourceRegistry(ns, ver.ToUpperInvariant(), selected);
    var registryFile = Path.Combine(outDir, $"ResourceRegistry.{ver.ToUpperInvariant()}.g.cs");
    Helpers.WriteFile(registryFile, registrySrc, dry);

    // Resources (generic generation for all; keep hand-crafted overrides for known ones if needed later)
    GenerationRunner.Run(ns, selectedList, docs, choices, typeInfo, cards, outDir, dry, Helpers.WriteFile);
    swAll.Stop();
    Console.WriteLine($"[CodeGen] All done. Generated {selectedList.Count} resources in {swAll.ElapsedMilliseconds} ms.");

    // Backbone summary logging for visibility
    if (!dry)
    {
        Console.WriteLine("[CodeGen] Backbone generation summary:");
        Console.WriteLine("[CodeGen] Top-level backbone classes are emitted as nested partial classes inside each resource.");

    // Optionally embed example JSON files into the resource project
    if (emitExamples)
    {
        try
        {
            ExamplesWriter.EmitExamples(csprojPath, ver, selected, examplesSource);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[CodeGen] WARN: Failed to emit examples: {ex.Message}");
        }
    }

        Console.WriteLine("[CodeGen] Each backbone emits its immediate child properties; deeper nesting will be iteratively expanded in future passes if required.");
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

// Ensure a target project file exists (if a directory is passed), and ensure it contains required project references
#if false
string EnsureProjectFileAndReferences(string outputProjectArg, string version)
{
    // If a csproj path was passed, use it; otherwise create a default project file in the directory
    string csprojPath;
    if (File.Exists(outputProjectArg) && outputProjectArg.EndsWith(".csproj", StringComparison.OrdinalIgnoreCase))
    {
        csprojPath = Path.GetFullPath(outputProjectArg);
    }
    else if (Directory.Exists(outputProjectArg))
    {
        var dir = Path.GetFullPath(outputProjectArg);
        var name = $"FhirSDK.Resources.{version}";
        csprojPath = Path.Combine(dir, $"{name}.csproj");
        if (!File.Exists(csprojPath))
        {
            var content = $@"<Project Sdk=\"Microsoft.NET.Sdk\">
  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <GeneratePackageOnBuild>true</GeneratePackageOnBuild>
    <Title>FhirSDK.Resources.{version}</Title>
    <Authors>sjvann</Authors>
    <Description>FHIR SDK {version} resource models (auto-generated)</Description>
    <Version>0.1.0</Version>
    <PackageId>FhirSDK.Resources.{version}</PackageId>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml</DocumentationFile>
    <NoWarn>$(NoWarn);1591</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <ProjectReference Include=\"..\\FhirCore\\FhirCore.csproj\" />
    <ProjectReference Include=\"..\\DataTypeServices\\DataTypeServices.csproj\" />
    <ProjectReference Include=\"..\\Fhir.TypeFramework\\Fhir.TypeFramework.csproj\" />
  </ItemGroup>
</Project>";
            Directory.CreateDirectory(dir);
            File.WriteAllText(csprojPath, content, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
            Console.WriteLine($"[CodeGen] Created project file: {csprojPath}");
        }
    }
    else
    {
        throw new DirectoryNotFoundException($"Output project not found: {outputProjectArg}");
    }

    // Ensure required references exist in the csproj
    var xml = File.ReadAllText(csprojPath);
    bool changed = false;
    string[] requiredRefs = new[]
    {
        "..\\FhirCore\\FhirCore.csproj",
        "..\\DataTypeServices\\DataTypeServices.csproj",
        "..\\Fhir.TypeFramework\\Fhir.TypeFramework.csproj"
    };
    foreach (var r in requiredRefs)
    {
        if (!xml.Contains(r, StringComparison.OrdinalIgnoreCase))
        {
            // insert before closing </ItemGroup> if exists, else create one
            if (xml.Contains("</ItemGroup>", StringComparison.OrdinalIgnoreCase))
            {
                xml = xml.Replace("</ItemGroup>", $"  <ProjectReference Include=\"{r}\" />\n  </ItemGroup>");
            }
            else
            {
                var insert = $"  <ItemGroup>\n    <ProjectReference Include=\"{r}\" />\n  </ItemGroup>\n";
                xml = xml.Replace("</Project>", insert + "</Project>");
            }
            changed = true;
        }
    }
    if (changed)
    {
        File.WriteAllText(csprojPath, xml, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
        Console.WriteLine($"[CodeGen] Updated project references in: {csprojPath}");
    }

    return csprojPath;
}

#endif
        return;
    }
    File.WriteAllText(path, content, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
    Console.WriteLine($"[CodeGen] Wrote: {path}");
}


// Ensure a target project file exists (if a directory is passed), and ensure it contains required project references
string EnsureProjectFileAndReferences(string outputProjectArg, string version)
{
    // If a csproj path was passed, use it; otherwise create a default project file in the directory
    string csprojPath;
    if (File.Exists(outputProjectArg) && outputProjectArg.EndsWith(".csproj", StringComparison.OrdinalIgnoreCase))
    {
        csprojPath = Path.GetFullPath(outputProjectArg);
    }
    else if (Directory.Exists(outputProjectArg))
    {
        var dir = Path.GetFullPath(outputProjectArg);
        var name = $"FhirSDK.Resources.{version}";
        csprojPath = Path.Combine(dir, $"{name}.csproj");
        if (!File.Exists(csprojPath))
        {
            var sbp = new StringBuilder();
            sbp.AppendLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
            sbp.AppendLine("  <PropertyGroup>");
            sbp.AppendLine("    <TargetFramework>net9.0</TargetFramework>");
            sbp.AppendLine("    <ImplicitUsings>enable</ImplicitUsings>");
            sbp.AppendLine("    <Nullable>enable</Nullable>");
            sbp.AppendLine("    <GeneratePackageOnBuild>true</GeneratePackageOnBuild>");
            sbp.AppendLine($"    <Title>FhirSDK.Resources.{version}</Title>");
            sbp.AppendLine("    <Authors>sjvann</Authors>");
            sbp.AppendLine($"    <Description>FHIR SDK {version} resource models (auto-generated)</Description>");
            sbp.AppendLine("    <Version>0.1.0</Version>");
            sbp.AppendLine($"    <PackageId>FhirSDK.Resources.{version}</PackageId>");
            sbp.AppendLine("    <GenerateDocumentationFile>true</GenerateDocumentationFile>");
            sbp.AppendLine("    <DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml</DocumentationFile>");
            sbp.AppendLine("    <NoWarn>$(NoWarn);1591</NoWarn>");
            sbp.AppendLine("  </PropertyGroup>");
            sbp.AppendLine("  <ItemGroup>");
            sbp.AppendLine("    <ProjectReference Include=\"..\\FhirCore\\FhirCore.csproj\" />");
            sbp.AppendLine("    <ProjectReference Include=\"..\\DataTypeServices\\DataTypeServices.csproj\" />");
            sbp.AppendLine("    <ProjectReference Include=\"..\\Fhir.TypeFramework\\Fhir.TypeFramework.csproj\" />");
            sbp.AppendLine("  </ItemGroup>");
            sbp.AppendLine("</Project>");
            Directory.CreateDirectory(dir);
            File.WriteAllText(csprojPath, sbp.ToString(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
            Console.WriteLine($"[CodeGen] Created project file: {csprojPath}");
        }
    }
    else
    {
        throw new DirectoryNotFoundException($"Output project not found: {outputProjectArg}");
    }

    // Ensure required references exist in the csproj
    var xml = File.ReadAllText(csprojPath);
    bool changed = false;

    // Remove any accidental reference to Fhir.TypeFramework (it's not required for generated resources)
    if (xml.IndexOf("Fhir.TypeFramework.csproj", StringComparison.OrdinalIgnoreCase) >= 0)
    {
        var lines = xml.Split(new[] {"\r\n", "\n"}, StringSplitOptions.None);
        var filtered = new List<string>(lines.Length);
        foreach (var l in lines)
        {
            if (l.IndexOf("Fhir.TypeFramework.csproj", StringComparison.OrdinalIgnoreCase) < 0)
                filtered.Add(l);
            else
                changed = true;
        }
        xml = string.Join("\n", filtered);
    }

    string[] requiredRefs = new[]
    {
        "..\\FhirCore\\FhirCore.csproj",
        "..\\DataTypeServices\\DataTypeServices.csproj"
    };
    foreach (var r in requiredRefs)
    {
        if (!xml.Contains(r, StringComparison.OrdinalIgnoreCase))
        {
            // insert before closing </ItemGroup> if exists, else create one
            if (xml.Contains("</ItemGroup>", StringComparison.OrdinalIgnoreCase))
            {
                xml = xml.Replace("</ItemGroup>", $"  <ProjectReference Include=\"{r}\" />\n  </ItemGroup>");
            }
            else
            {
                var insert = $"  <ItemGroup>\n    <ProjectReference Include=\"{r}\" />\n  </ItemGroup>\n";
                xml = xml.Replace("</Project>", insert + "</Project>");
            }
            changed = true;
        }
    }
    if (changed)
    {
        File.WriteAllText(csprojPath, xml, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
        Console.WriteLine($"[CodeGen] Updated project references in: {csprojPath}");
    }

    return csprojPath;
}
