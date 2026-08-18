using System.Text.Json;
using Fhir.Artifacts;
using Fhir.Packages.Registry;
using Fhir.Path.Evaluation;
using Fhir.TypeFramework.Serialization;
using Fhir.Validation;
using Fhir.Validation.Snapshot;
using Fhir.VersionManager;
using Fhir.VersionManager.Capability;
using Fhir.VersionManager.Runtime;

namespace Fhir.Cli;

internal static class Program
{
    public static int Main(string[] args) => CommandRouter.Run(args);
}

internal static class CommandRouter
{
    public static int Run(string[] args)
    {
        if (args.Length == 0 || args[0] is "-h" or "--help")
        {
            PrintHelp();
            return 0;
        }

        try
        {
            return args[0] switch
            {
                "parse" => Parse(args),
                "serialize" => Serialize(args),
                "path" => PathEval(args),
                "validate" => Validate(args),
                "snapshot" => Snapshot(args),
                "package" => Package(args),
                "metadata" => Metadata(args),
                "get" => Get(args),
                _ => Unknown(args[0])
            };
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex.Message);
            return 1;
        }
    }

    private static int Parse(string[] args)
    {
        var file = Required(args, "--file");
        var version = ParseVersion(Optional(args, "--version") ?? "R5");
        var runtime = new FhirLineRuntimeFactory().Get(version);
        var json = File.ReadAllText(file);
        var resource = runtime.ParseJson(json, HasFlag(args, "--strict") ? FhirSerializerOptions.Strict : FhirSerializerOptions.Lenient);
        Console.WriteLine(resource is null ? "null" : $"{resource.TypeName} id={resource.Id?.StringValue}");
        return resource is null ? 2 : 0;
    }

    private static int Serialize(string[] args)
    {
        var file = Required(args, "--file");
        var format = (Optional(args, "--format") ?? "json").ToLowerInvariant();
        var version = ParseVersion(Optional(args, "--version") ?? "R5");
        var runtime = new FhirLineRuntimeFactory().Get(version);
        var resource = runtime.ParseJson(File.ReadAllText(file))
                       ?? throw new InvalidOperationException("Failed to parse input.");
        Console.WriteLine(format == "xml" ? runtime.SerializeXml(resource) : runtime.SerializeJson(resource));
        return 0;
    }

    private static int PathEval(string[] args)
    {
        var file = Required(args, "--file");
        var expr = Required(args, "--expr");
        var version = ParseVersion(Optional(args, "--version") ?? "R5");
        var runtime = new FhirLineRuntimeFactory().Get(version);
        var resource = runtime.ParseJson(File.ReadAllText(file))
                       ?? throw new InvalidOperationException("Failed to parse input.");
        var engine = new FhirPathEngine();
        var result = engine.Evaluate(expr, resource);
        Console.WriteLine(JsonSerializer.Serialize(result.Select(v => v?.ToString()).ToList()));
        return 0;
    }

    private static int Validate(string[] args)
    {
        var file = Required(args, "--file");
        var version = ParseVersion(Optional(args, "--version") ?? "R5");
        var runtime = new FhirLineRuntimeFactory().Get(version);
        var resource = runtime.ParseJson(File.ReadAllText(file))
                       ?? throw new InvalidOperationException("Failed to parse input.");

        var catalog = new ProfileCatalog();
        var package = Optional(args, "--package");
        if (package is not null)
            catalog.AddFrom(new PackageArtifactSource(package), json => runtime.ParseJson(json));
        var dir = Optional(args, "--dir");
        if (dir is not null)
            catalog.AddFrom(new DirectoryArtifactSource(dir), json => runtime.ParseJson(json));

        var profiles = Optional(args, "--profile") is { } p ? new[] { p } : Array.Empty<string>();
        var validator = new ProfileValidator(catalog, new ProfileValidationOptions
        {
            PathEngine = new FhirPathEngine()
        });
        var report = validator.Validate(resource, profiles);
        Console.WriteLine(JsonSerializer.Serialize(report.ToOperationOutcomeIssues(), new JsonSerializerOptions { WriteIndented = true }));
        return report.Passed ? 0 : 3;
    }

    private static int Snapshot(string[] args)
    {
        var file = Required(args, "--file");
        var version = ParseVersion(Optional(args, "--version") ?? "R5");
        var runtime = new FhirLineRuntimeFactory().Get(version);
        var sd = runtime.ParseJson(File.ReadAllText(file))
                 ?? throw new InvalidOperationException("Failed to parse StructureDefinition.");
        IArtifactResolver? resolver = Optional(args, "--package") is { } pkg
            ? new PackageArtifactSource(pkg)
            : Optional(args, "--dir") is { } dir
                ? new DirectoryArtifactSource(dir)
                : null;
        var generator = new SnapshotGenerator(resolver, json => runtime.ParseJson(json));
        var result = generator.Generate(sd);
        Console.WriteLine(runtime.SerializeJson(result));
        return 0;
    }

    private static int Package(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("usage: fhir package list [--cache DIR]");
            Console.WriteLine("       fhir package install <id> <version> [--cache DIR]");
            return 1;
        }

        var cache = Optional(args, "--cache") ?? System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".fhir", "packages");
        if (args[1] == "list")
        {
            if (!Directory.Exists(cache))
            {
                Console.WriteLine("(empty)");
                return 0;
            }

            foreach (var dir in Directory.EnumerateDirectories(cache, "*", SearchOption.AllDirectories))
            {
                if (File.Exists(System.IO.Path.Combine(dir, "package.json")) || File.Exists(System.IO.Path.Combine(dir, "package", "package.json")))
                    Console.WriteLine(dir);
            }

            return 0;
        }

        if (args[1] == "install")
        {
            if (args.Length < 4)
                throw new InvalidOperationException("usage: fhir package install <id> <version>");
            using var http = FhirPackageDownloader.CreateDefaultClient();
            var installer = new FhirPackageInstaller(new FhirPackageDownloader(http), new FhirPackageInstallOptions
            {
                PackageCacheDirectory = cache
            });
            var installed = installer.InstallAsync(new PackageReferenceSpec(args[2], args[3])).GetAwaiter().GetResult();
            Console.WriteLine(installed.PackageContentDirectory);
            return 0;
        }

        Console.Error.WriteLine($"Unknown package command: {args[1]}");
        return 1;
    }

    private static int Metadata(string[] args)
    {
        var file = Required(args, "--file");
        var declared = ParseVersion(Optional(args, "--version") ?? "Unknown");
        var runtime = new FhirCapabilityRuntime();
        var result = runtime.ParseMetadata(File.ReadAllText(file), Optional(args, "--base"), declared, FhirVersionResolutionStrategy.PreferDetected);
        Console.WriteLine(JsonSerializer.Serialize(new
        {
            result.SelectedVersion,
            result.Model.SoftwareName,
            result.Model.FhirVersionElement,
            Resources = result.Model.ServerResources.Select(r => r.Type)
        }, new JsonSerializerOptions { WriteIndented = true }));
        return 0;
    }

    private static int Get(string[] args)
    {
        var url = Required(args, "--url");
        using var http = new HttpClient();
        var text = http.GetStringAsync(url).GetAwaiter().GetResult();
        Console.WriteLine(text);
        return 0;
    }

    private static int Unknown(string cmd)
    {
        Console.Error.WriteLine($"Unknown command: {cmd}");
        PrintHelp();
        return 1;
    }

    private static void PrintHelp()
    {
        Console.WriteLine("""
            fhir parse --file FILE [--version R4|R4B|R5] [--strict]
            fhir serialize --file FILE [--format json|xml] [--version R4|R4B|R5]
            fhir path --file FILE --expr EXPR [--version R4|R4B|R5]
            fhir validate --file FILE [--package TGZ] [--dir DIR] [--profile CANONICAL] [--version R4|R4B|R5]
            fhir snapshot --file FILE [--package TGZ] [--dir DIR] [--version R4|R4B|R5]
            fhir package list [--cache DIR]
            fhir package install ID VERSION [--cache DIR]
            fhir metadata --file FILE [--base URL] [--version R4|R4B|R5]
            fhir get --url URL
            """);
    }

    private static FhirVersion ParseVersion(string text) => text.ToUpperInvariant() switch
    {
        "R4" => FhirVersion.R4,
        "R4B" => FhirVersion.R4B,
        "R5" => FhirVersion.R5,
        "UNKNOWN" => FhirVersion.Unknown,
        _ => throw new InvalidOperationException($"Unknown version '{text}'.")
    };

    private static string Required(string[] args, string name)
        => Optional(args, name) ?? throw new InvalidOperationException($"Missing {name}.");

    private static string? Optional(string[] args, string name)
    {
        for (var i = 0; i < args.Length - 1; i++)
        {
            if (args[i] == name)
                return args[i + 1];
        }

        return null;
    }

    private static bool HasFlag(string[] args, string name)
        => args.Contains(name, StringComparer.Ordinal);
}
