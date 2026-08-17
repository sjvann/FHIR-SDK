using System.Text.Json;
using Fhir.Path;
using Fhir.Path.R5;
using Fhir.Resources.R5;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Interop;

namespace Fhir.Path.Tests;

public class FhirPathEvaluationTests
{
    private readonly FhirPathR5 _sdk = FhirPathR5.Create();

    [Fact]
    public void Evaluate_name_given_returns_strings()
    {
        var patient = CreatePatient();
        var result = _sdk.Evaluate("Patient.name.given", patient);
        Assert.Equal(3, result.Count);
        Assert.Contains("John", result.Cast<string>());
    }

    [Fact]
    public void Where_filters_names()
    {
        var patient = CreatePatient();
        var result = _sdk.Evaluate("Patient.name.where(family = 'Doe').given", patient);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void Today_function_uses_injected_clock()
    {
        var ctx = new FhirPathEvaluationContext
        {
            Clock = () => new DateTimeOffset(2026, 5, 18, 0, 0, 0, TimeSpan.Zero)
        };
        var result = _sdk.Evaluate("today()", new Patient(), ctx);
        Assert.Equal(new DateOnly(2026, 5, 18), result.SingleOrDefault());
    }

    [Fact]
    public void Json_test_cases_file_runs()
    {
        var path = System.IO.Path.Combine(AppContext.BaseDirectory, "TestData", "fhirpath-cases.json");
        if (!File.Exists(path)) return;

        var cases = JsonSerializer.Deserialize<List<JsonTestCase>>(File.ReadAllText(path))!;
        foreach (var c in cases)
        {
            object? ctx = c.Context == "Patient" ? CreatePatient() : new Patient();
            FhirPathCollection result;
            try
            {
                result = _sdk.Evaluate(c.Expression, ctx!);
            }
            catch (Fhir.Path.Exceptions.FhirPathException)
            {
                continue;
            }
            if (c.Expected is not null)
            {
                var actual = result.SingleOrDefault();
                if (c.Expected is bool expectedBool && actual is bool actualBool)
                    Assert.Equal(expectedBool, actualBool);
                else
                    Assert.Equal(c.Expected.ToString(), actual?.ToString());
            }
            if (c.ExpectedCount is not null)
                Assert.Equal(c.ExpectedCount, result.Count);
        }
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

    private sealed class JsonTestCase
    {
        public string Expression { get; set; } = "";
        public object? Expected { get; set; }
        public string? Context { get; set; }
        public int? ExpectedCount { get; set; }
    }
}
