using System.Reflection;
using Fhir.TypeFramework.Choices;
using FhirResourceCreator.Generation;

namespace FhirResourceCreator.Pipeline;

/// <summary>為 generated 下 R4/R4B/R5 資源組件批次寫入 <c>*.Choice.generated.cs</c>。</summary>
public static class ChoiceHelperBatchEmitter
{
    public static async Task<int> EmitForGeneratedFolderAsync(string repoRoot, CancellationToken ct = default)
    {
        var generatedRoot = Path.Combine(repoRoot, "Fhir.ResourceCreator", "generated");
        if (!Directory.Exists(generatedRoot))
            throw new DirectoryNotFoundException($"Generated folder not found: {generatedRoot}");

        var total = 0;
        foreach (var projectDir in Directory.EnumerateDirectories(generatedRoot))
        {
            ct.ThrowIfCancellationRequested();
            var projectName = Path.GetFileName(projectDir);
            if (!projectName.StartsWith("Fhir.Resources.", StringComparison.Ordinal))
                continue;
            if (projectName.EndsWith(".Tests", StringComparison.OrdinalIgnoreCase))
                continue;

            var csproj = Path.Combine(projectDir, $"{projectName}.csproj");
            if (!File.Exists(csproj))
                continue;

            await DotNetBuildAsync(csproj, ct).ConfigureAwait(false);
            var dllPath = Path.Combine(projectDir, "bin", "Debug", "net10.0", $"{projectName}.dll");
            if (!File.Exists(dllPath))
                throw new FileNotFoundException($"Build output not found: {dllPath}");

            var count = await EmitForAssemblyAsync(projectDir, dllPath, ct).ConfigureAwait(false);
            total += count;
            Console.WriteLine($"{projectName}: {count} choice helper file(s).");
        }

        return total;
    }

    private static async Task<int> EmitForAssemblyAsync(string projectDir, string dllPath, CancellationToken ct)
    {
        var asm = Assembly.LoadFrom(dllPath);
        var types = asm.GetTypes()
            .Where(t => t is { IsClass: true, IsAbstract: false, ContainsGenericParameters: false })
            .Where(t => t.Namespace?.StartsWith("Fhir.Resources.", StringComparison.Ordinal) == true)
            .Where(t => ChoiceBindingCache.GetGroups(t).Count > 0)
            .OrderBy(t => t.FullName, StringComparer.Ordinal)
            .ToList();

        var written = 0;
        foreach (var type in types)
        {
            ct.ThrowIfCancellationRequested();
            var code = ChoiceHelperReflectionGenerator.Generate(type);
            if (string.IsNullOrEmpty(code))
                continue;

            var fileName = ChoiceHelperReflectionGenerator.GetOutputFileName(type);
            var outPath = Path.Combine(projectDir, fileName);
            await File.WriteAllTextAsync(outPath, code, ct).ConfigureAwait(false);
            written++;
        }

        return written;
    }

    private static async Task DotNetBuildAsync(string csprojPath, CancellationToken ct)
    {
        var psi = new System.Diagnostics.ProcessStartInfo
        {
            FileName = "dotnet",
            Arguments = $"build \"{csprojPath}\" -v q",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };
        using var proc = System.Diagnostics.Process.Start(psi)
            ?? throw new InvalidOperationException("Failed to start dotnet build.");
        var stdout = await proc.StandardOutput.ReadToEndAsync(ct).ConfigureAwait(false);
        var stderr = await proc.StandardError.ReadToEndAsync(ct).ConfigureAwait(false);
        await proc.WaitForExitAsync(ct).ConfigureAwait(false);
        if (proc.ExitCode != 0)
            throw new InvalidOperationException($"dotnet build failed for {csprojPath}:\n{stderr}\n{stdout}");
    }

    private static string FindRepoRoot()
    {
        foreach (var start in new[] { Directory.GetCurrentDirectory(), AppContext.BaseDirectory })
        {
            var dir = start;
            for (var i = 0; i < 12 && !string.IsNullOrEmpty(dir); i++)
            {
                if (File.Exists(Path.Combine(dir, "Fhir.Sdk.slnx")) ||
                    File.Exists(Path.Combine(dir, "Fhir.Solution.slnx")))
                    return dir;
                dir = Directory.GetParent(dir)?.FullName ?? "";
            }
        }

        return Directory.GetCurrentDirectory();
    }

    public static Task<int> EmitForRepoAsync(CancellationToken ct = default)
        => EmitForGeneratedFolderAsync(FindRepoRoot(), ct);
}
