using FhirResourceCreator.Configuration;
using FhirResourceCreator.Generation;
using FhirResourceCreator.Pipeline;
using Microsoft.Extensions.Configuration;

if (args.Contains("--emit-choice-helpers", StringComparer.OrdinalIgnoreCase))
{
    var count = await ChoiceHelperBatchEmitter.EmitForRepoAsync().ConfigureAwait(false);
    Console.WriteLine($"Choice helpers emitted: {count} file(s).");
    return;
}

if (args.Contains("--scaffold-fhir-lines", StringComparer.OrdinalIgnoreCase))
{
    var repoRoot = FindRepoRootForScaffold();
    var generatedRoot = Path.Combine(repoRoot, "Fhir.ResourceCreator", "generated");
    var count = FhirLineScaffoldEmitter.EmitForAllGeneratedResourceLines(repoRoot, generatedRoot);
    Console.WriteLine($"FHIR line scaffold (Path + Sdk): {count} line(s).");
    return;
}

static string FindRepoRootForScaffold()
{
    foreach (var start in new[] { Directory.GetCurrentDirectory(), AppContext.BaseDirectory })
    {
        var dir = start;
        for (var i = 0; i < 12 && !string.IsNullOrEmpty(dir); i++)
        {
            if (File.Exists(Path.Combine(dir, "Fhir.Solution.slnx")))
                return dir;
            dir = Directory.GetParent(dir)?.FullName ?? "";
        }
    }

    return Directory.GetCurrentDirectory();
}

var configDir = Path.Combine(AppContext.BaseDirectory);
var config = new ConfigurationBuilder()
    .SetBasePath(configDir)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
    .Build();

var opts = config.GetSection(GeneratorOptions.SectionName).Get<GeneratorOptions>()
           ?? new GeneratorOptions();

if (opts.Mode == GeneratorInputMode.Registry)
    await GenerationOrchestrator.RunRegistryPackagesAsync(opts).ConfigureAwait(false);
else
    GenerationOrchestrator.RunExcelLegacy(opts);

Console.WriteLine("Fhir.ResourceCreator finished.");
