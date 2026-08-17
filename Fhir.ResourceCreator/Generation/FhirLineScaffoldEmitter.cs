using System.Text;
using FhirResourceCreator.Configuration;

namespace FhirResourceCreator.Generation;

/// <summary>
/// 為每個 FHIR 線別產生 <c>Fhir.Path.{Line}</c>（不發佈 NuGet）與 <c>Fhir.Sdk.{Line}</c>（對外入口），與 R5 對齊；R6 等未來線別可沿用。
/// </summary>
public static class FhirLineScaffoldEmitter
{
    private static readonly string[] PathSourceFilesWithPatchRelativeToR5 =
    [
        "FhirPathR5.cs",
        "FhirPathR5Extensions.cs",
        "DependencyInjection/ServiceCollectionExtensions.cs",
        "Patch/PatchOperation.cs",
        "Patch/AnonymousTypeBuilder.cs",
        "Patch/FhirPathPatchReader.cs",
        "Patch/FhirPathPatchBuilder.cs",
        "Patch/FhirPathPatchApplicator.cs",
        "XQuery/FhirXQuery.cs",
    ];

    private static readonly string[] PathSourceFilesWithoutPatch =
    [
        "FhirPathR5Extensions.cs",
        "DependencyInjection/ServiceCollectionExtensions.cs",
        "XQuery/FhirXQuery.cs",
    ];

    public static int EmitForAllGeneratedResourceLines(string repoRoot, string generatedRoot)
    {
        var count = 0;
        if (!Directory.Exists(generatedRoot))
            return 0;

        foreach (var dir in Directory.EnumerateDirectories(generatedRoot))
        {
            var name = Path.GetFileName(dir);
            if (!FhirLineLabels.TryParseFromResourcesProject(name, out var label))
                continue;
            if (name.EndsWith(".Tests", StringComparison.OrdinalIgnoreCase))
                continue;
            if (!File.Exists(Path.Combine(dir, $"{name}.csproj")))
                continue;

            Emit(repoRoot, label, name, dir);
            count++;
        }

        return count;
    }

    public static void Emit(string repoRoot, string lineLabel, string resourcesProjectName, string resourcesProjectDir)
    {
        var pathName = FhirLineLabels.PathProjectName(lineLabel);
        var sdkName = FhirLineLabels.SdkProjectName(lineLabel);
        var resourcesNs = FhirLineLabels.ResourcesNamespace(lineLabel);

        var pathDir = Path.Combine(repoRoot, pathName);
        var sdkDir = Path.Combine(repoRoot, sdkName);
        Directory.CreateDirectory(pathDir);
        Directory.CreateDirectory(Path.Combine(pathDir, "DependencyInjection"));
        Directory.CreateDirectory(Path.Combine(pathDir, "Patch"));
        Directory.CreateDirectory(Path.Combine(pathDir, "XQuery"));
        Directory.CreateDirectory(Path.Combine(sdkDir, "DependencyInjection"));

        var resourcesCsproj = Path.Combine(resourcesProjectDir, $"{resourcesProjectName}.csproj");
        var pathR5Dir = Path.Combine(repoRoot, "Fhir.Path.R5");
        if (!Directory.Exists(pathR5Dir))
            throw new DirectoryNotFoundException($"Template folder not found: {pathR5Dir}");

        var includePatch = string.Equals(lineLabel, "R5", StringComparison.OrdinalIgnoreCase);
        var sourceFiles = includePatch ? PathSourceFilesWithPatchRelativeToR5 : PathSourceFilesWithoutPatch;
        foreach (var rel in sourceFiles)
        {
            var src = Path.Combine(pathR5Dir, rel);
            if (!File.Exists(src))
                continue;
            var text = File.ReadAllText(src);
            text = ApplyLineReplacements(text, lineLabel, resourcesNs);
            var destRel = ApplyLineReplacements(rel, lineLabel, resourcesNs);
            var dest = Path.Combine(pathDir, destRel);
            var destFolder = Path.GetDirectoryName(dest);
            if (!string.IsNullOrEmpty(destFolder))
                Directory.CreateDirectory(destFolder);
            File.WriteAllText(dest, text);
        }

        if (!includePatch)
        {
            WritePathFacadeWithoutPatch(Path.Combine(pathDir, $"FhirPath{lineLabel}.cs"), lineLabel);
            var patchDir = Path.Combine(pathDir, "Patch");
            if (Directory.Exists(patchDir))
                Directory.Delete(patchDir, recursive: true);
        }

        WritePathProject(Path.Combine(pathDir, $"{pathName}.csproj"), pathName, pathDir, resourcesCsproj, lineLabel);
        WriteSdkProject(Path.Combine(sdkDir, $"{sdkName}.csproj"), sdkName, pathDir, sdkDir, resourcesCsproj, lineLabel, repoRoot);
        WriteSdkFacade(Path.Combine(sdkDir, $"FhirSdk{lineLabel}.cs"), lineLabel);
        WriteSdkGlobalUsings(Path.Combine(sdkDir, "GlobalUsings.cs"));
        WriteSdkDi(Path.Combine(sdkDir, "DependencyInjection", "ServiceCollectionExtensions.cs"), lineLabel);
    }

    private static void WritePathFacadeWithoutPatch(string path, string lineLabel)
    {
        var content = $@"using Fhir.Path.Abstractions;
using Fhir.Path.Evaluation;
using Fhir.Path.{lineLabel}.XQuery;

namespace Fhir.Path.{lineLabel};

/// <summary>{lineLabel} FHIRPath 引擎與 x-fhir-query 入口（Patch 僅 R5 提供）。</summary>
public sealed class FhirPath{lineLabel}
{{
    private readonly IFhirPathEngine _engine;

    public FhirPath{lineLabel}(IFhirPathEngine? engine = null)
        => _engine = engine ?? new FhirPathEngine();

    public static FhirPath{lineLabel} Create() => new();

    public static IFhirPathEngine CreateEngine() => new FhirPathEngine();

    public IFhirPathEngine Engine => _engine;

    public FhirPathCollection Evaluate(string expression, object context, FhirPathEvaluationContext? ctx = null)
        => _engine.Evaluate(expression, context, ctx);

    public string ResolveXQuery(string query, FhirPathEvaluationContext ctx, bool percentEncode = false)
        => FhirXQuery.Resolve(query, _engine, ctx, percentEncode);
}}
";
        File.WriteAllText(path, content);
    }

    private static string ApplyLineReplacements(string text, string lineLabel, string resourcesNs)
    {
        return text
            .Replace("Fhir.Path.R5", $"Fhir.Path.{lineLabel}", StringComparison.Ordinal)
            .Replace("Fhir.Resources.R5", resourcesNs, StringComparison.Ordinal)
            .Replace("FhirPathR5", $"FhirPath{lineLabel}", StringComparison.Ordinal)
            .Replace("AddFhirPathR5", $"AddFhirPath{lineLabel}", StringComparison.Ordinal)
            .Replace("Fhir.Sdk.R5", $"Fhir.Sdk.{lineLabel}", StringComparison.Ordinal)
            .Replace("FhirSdkR5", $"FhirSdk{lineLabel}", StringComparison.Ordinal)
            .Replace("AddFhirSdkR5", $"AddFhirSdk{lineLabel}", StringComparison.Ordinal)
            .Replace("R5 FHIRPath", $"{lineLabel} FHIRPath", StringComparison.Ordinal)
            .Replace("FHIR R5", $"FHIR {lineLabel}", StringComparison.Ordinal);
    }

    private static string ToProjectReference(string fromProjectDir, string targetCsprojPath)
    {
        var rel = Path.GetRelativePath(fromProjectDir, targetCsprojPath);
        return rel.Replace('/', Path.DirectorySeparatorChar);
    }

    private static void WritePathProject(
        string path,
        string pathName,
        string pathProjectDir,
        string resourcesCsproj,
        string lineLabel)
    {
        var pathCore = ToProjectReference(pathProjectDir, Path.Combine(pathProjectDir, "..", "Fhir.Path", "Fhir.Path.csproj"));
        var interop = ToProjectReference(pathProjectDir, Path.Combine(pathProjectDir, "..", "Fhir.TypeFramework.Interop", "Fhir.TypeFramework.Interop.csproj"));
        var resources = ToProjectReference(pathProjectDir, resourcesCsproj);

        var sb = new StringBuilder();
        sb.AppendLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
        sb.AppendLine();
        sb.AppendLine("  <PropertyGroup>");
        sb.AppendLine("    <TargetFramework>net10.0</TargetFramework>");
        sb.AppendLine("    <ImplicitUsings>enable</ImplicitUsings>");
        sb.AppendLine("    <Nullable>enable</Nullable>");
        sb.AppendLine($"    <RootNamespace>{pathName}</RootNamespace>");
        sb.AppendLine($"    <AssemblyName>{pathName}</AssemblyName>");
        sb.AppendLine("    <IsPackable>false</IsPackable>");
        sb.AppendLine($"    <Description>{lineLabel} FHIRPath 門面（方案內組件；請透過 {FhirLineLabels.SdkProjectName(lineLabel)} 引用，不單獨發佈 NuGet）。</Description>");
        sb.AppendLine("  </PropertyGroup>");
        sb.AppendLine();
        sb.AppendLine("  <ItemGroup>");
        sb.AppendLine("    <PackageReference Include=\"Microsoft.Extensions.DependencyInjection.Abstractions\" Version=\"9.0.0\" />");
        sb.AppendLine("  </ItemGroup>");
        sb.AppendLine();
        sb.AppendLine("  <ItemGroup>");
        sb.AppendLine($"    <ProjectReference Include=\"{pathCore}\" />");
        sb.AppendLine($"    <ProjectReference Include=\"{interop}\" />");
        sb.AppendLine($"    <ProjectReference Include=\"{resources}\" />");
        sb.AppendLine("  </ItemGroup>");
        sb.AppendLine();
        sb.AppendLine("</Project>");
        File.WriteAllText(path, sb.ToString());
    }

    private static void WriteSdkProject(
        string path,
        string sdkName,
        string pathProjectDir,
        string sdkProjectDir,
        string resourcesCsproj,
        string lineLabel,
        string repoRoot)
    {
        var tf = ToProjectReference(sdkProjectDir, Path.Combine(repoRoot, "Fhir.TypeFramework", "Fhir.TypeFramework.csproj"));
        var interop = ToProjectReference(sdkProjectDir, Path.Combine(repoRoot, "Fhir.TypeFramework.Interop", "Fhir.TypeFramework.Interop.csproj"));
        var pathCore = ToProjectReference(sdkProjectDir, Path.Combine(repoRoot, "Fhir.Path", "Fhir.Path.csproj"));
        var pathLine = ToProjectReference(sdkProjectDir, Path.Combine(pathProjectDir, $"{FhirLineLabels.PathProjectName(lineLabel)}.csproj"));
        var resources = ToProjectReference(sdkProjectDir, resourcesCsproj);

        var sb = new StringBuilder();
        sb.AppendLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
        sb.AppendLine();
        sb.AppendLine("  <PropertyGroup>");
        sb.AppendLine("    <TargetFramework>net10.0</TargetFramework>");
        sb.AppendLine("    <ImplicitUsings>enable</ImplicitUsings>");
        sb.AppendLine("    <Nullable>enable</Nullable>");
        sb.AppendLine($"    <RootNamespace>{sdkName}</RootNamespace>");
        sb.AppendLine($"    <AssemblyName>{sdkName}</AssemblyName>");
        sb.AppendLine("    <GeneratePackageOnBuild>true</GeneratePackageOnBuild>");
        sb.AppendLine($"    <PackageId>{sdkName}</PackageId>");
        sb.AppendLine("    <PackageVersion>1.0.0</PackageVersion>");
        sb.AppendLine("    <Authors>FHIR SDK Team</Authors>");
        sb.AppendLine($"    <Description>FHIR {lineLabel} 單一入口套件：TypeFramework、Interop、FHIRPath、{FhirLineLabels.ResourcesNamespace(lineLabel)}。一般應用僅需引用本套件。</Description>");
        sb.AppendLine($"    <PackageTags>FHIR;HL7;SDK;{lineLabel};FHIRPath</PackageTags>");
        sb.AppendLine("    <PackageLicenseExpression>MIT</PackageLicenseExpression>");
        sb.AppendLine("  </PropertyGroup>");
        sb.AppendLine();
        sb.AppendLine("  <ItemGroup>");
        sb.AppendLine($"    <ProjectReference Include=\"{tf}\" />");
        sb.AppendLine($"    <ProjectReference Include=\"{interop}\" />");
        sb.AppendLine($"    <ProjectReference Include=\"{pathCore}\" />");
        sb.AppendLine($"    <ProjectReference Include=\"{pathLine}\" />");
        sb.AppendLine($"    <ProjectReference Include=\"{resources}\" />");
        sb.AppendLine("  </ItemGroup>");
        sb.AppendLine();
        sb.AppendLine("</Project>");
        File.WriteAllText(path, sb.ToString());
    }

    private static void WriteSdkFacade(string path, string lineLabel)
    {
        var pathType = $"FhirPath{lineLabel}";
        var content = $@"using Fhir.Path.{lineLabel};

namespace Fhir.Sdk.{lineLabel};

/// <summary>FHIR {lineLabel} 對外單一入口（資源 POCO、Interop、FHIRPath）。</summary>
public static class FhirSdk{lineLabel}
{{
    /// <summary>建立預設 {lineLabel} FHIRPath 與 Patch / x-query 門面。</summary>
    public static {pathType} CreatePath() => {pathType}.Create();

    /// <summary>建立預設 FHIRPath 引擎。</summary>
    public static Fhir.Path.Abstractions.IFhirPathEngine CreatePathEngine()
        => {pathType}.CreateEngine();
}}
";
        File.WriteAllText(path, content);
    }

    private static void WriteSdkGlobalUsings(string path)
        => File.WriteAllText(path, "global using Fhir.TypeFramework.Interop;\n");

    private static void WriteSdkDi(string path, string lineLabel)
    {
        var content = $@"using Fhir.Path.{lineLabel}.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Fhir.Sdk.{lineLabel}.DependencyInjection;

/// <summary><see cref=""Fhir.Sdk.{lineLabel}""/> DI 註冊。</summary>
public static class ServiceCollectionExtensions
{{
    /// <summary>註冊 {lineLabel} FHIRPath 引擎與 <see cref=""Fhir.Path.{lineLabel}.FhirPath{lineLabel}""/> 門面。</summary>
    public static IServiceCollection AddFhirSdk{lineLabel}(this IServiceCollection services)
        => services.AddFhirPath{lineLabel}();
}}
";
        File.WriteAllText(path, content);
    }
}
