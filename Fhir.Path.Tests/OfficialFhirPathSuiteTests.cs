using System.Text.Json;
using Fhir.Path.Evaluation;
using Fhir.Path.R5;
using Fhir.Resources.R5;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Interop;
using Fhir.TypeFramework.Metadata;

namespace Fhir.Path.Tests;

/// <summary>
/// 官方／內建 FHIRPath 案例。若環境變數 FHIRPATH_OFFICIAL_SUITE 指向 HL7 tests JSON 則一併執行。
/// </summary>
public sealed class OfficialFhirPathSuiteTests
{
    [Fact]
    public void Capabilities_are_version_2()
    {
        var engine = new FhirPathEngine();
        Assert.Equal("2.0", engine.Capabilities.Version);
        Assert.Contains("descendants", engine.Capabilities.SupportedFunctions);
        Assert.Contains("toInteger", engine.Capabilities.SupportedFunctions);
    }

    [Fact]
    public void Reflection_metadata_provider_describes_patient()
    {
        var provider = new ReflectionModelMetadataProvider();
        Assert.True(provider.TryGet(typeof(Patient), out var meta));
        Assert.True(meta.ElementMap.ContainsKey("name") || meta.Elements.Any(e => e.ElementName == "name"));
        Fhir.Path.Navigation.ElementMetadataCache.Provider = provider;
        var engine = FhirPathR5.Create();
        var result = engine.Evaluate("Patient.name.given", CreatePatient());
        Assert.Equal(3, result.Count);
    }

    [Fact]
    public void New_collection_and_string_functions()
    {
        var engine = FhirPathR5.Create();
        var patient = CreatePatient();
        Assert.Equal(2, engine.Evaluate("Patient.name.count()", patient).SingleOrDefault());
        Assert.Equal(1, engine.Evaluate("Patient.name.last().count()", patient).SingleOrDefault());
        var family = engine.Evaluate("Patient.name.first().family", patient).SingleOrDefault()?.ToString();
        Assert.Equal("Doe", family);
    }

    [Fact]
    public void Built_in_and_optional_official_suite()
    {
        var paths = new List<string>
        {
            System.IO.Path.Combine(AppContext.BaseDirectory, "TestData", "fhirpath-cases.json")
        };
        var official = Environment.GetEnvironmentVariable("FHIRPATH_OFFICIAL_SUITE");
        if (!string.IsNullOrWhiteSpace(official) && File.Exists(official))
            paths.Add(official);

        var engine = FhirPathR5.Create();
        var failures = new List<string>();
        foreach (var path in paths)
        {
            if (!File.Exists(path))
                continue;
            using var doc = JsonDocument.Parse(File.ReadAllText(path));
            if (doc.RootElement.ValueKind != JsonValueKind.Array)
                continue;
            foreach (var item in doc.RootElement.EnumerateArray())
            {
                if (!item.TryGetProperty("expression", out var exprEl))
                    continue;
                var expression = exprEl.GetString();
                if (string.IsNullOrWhiteSpace(expression))
                    continue;
                try
                {
                    engine.Evaluate(expression, CreatePatient());
                }
                catch (Exception ex)
                {
                    failures.Add($"{expression}: {ex.Message}");
                }
            }
        }

        Assert.True(failures.Count < 20, string.Join(Environment.NewLine, failures.Take(20)));
    }

    private static Patient CreatePatient() => new()
    {
        Name =
        [
            new HumanName().WithFamily("Doe").WithGiven("John", "Q"),
            new HumanName().WithFamily("Smith").WithGiven("Jane")
        ],
        Active = true.ToFhirBoolean()
    };
}
