using System.Text.Json.Nodes;
using Xunit;
using FhirSDK.Resources.R5;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.ComplexTypes;

namespace FhirSDK.Resources.R5.Tests;

public class PatientEndToEndTests
{
    [Fact]
    public void ParsePatientJson_AndExtractFields_UsingRaw()
    {
        // Arrange: sample FHIR Patient JSON (subset)
        var json = """
        {
          "resourceType": "Patient",
          "id": "pat-1",
          "name": [
            { "family": "Doe", "given": ["John"] }
          ],
          "gender": "male",
          "birthDate": "1980-01-01"
        }
        """;

        // Act
        var patient = new Patient(json);
        var raw = patient.Raw!;

        // Assert: extract a few fields from Raw
        Assert.Equal("Patient", raw["resourceType"]!.GetValue<string>());
        Assert.Equal("pat-1", raw["id"]!.GetValue<string>());
        var names = raw["name"]!.AsArray();
        Assert.Single(names);
        var firstName = names[0]!.AsObject();
        Assert.Equal("Doe", firstName["family"]!.GetValue<string>());
        var given = firstName["given"]!.AsArray();
        Assert.Equal("John", given[0]!.GetValue<string>());
        Assert.Equal("male", raw["gender"]!.GetValue<string>());
        Assert.Equal("1980-01-01", raw["birthDate"]!.GetValue<string>());
    }

    [Fact]
    public void BuildPatient_WithTypedProperties_AndGenerateJsonFromRaw()
    {
        // Arrange: build a Patient via typed properties
        var patient = new Patient();
        patient.Gender = new FhirCode("male");
        patient.BirthDate = new FhirDate("1980-01-01");
        patient.Name = new List<HumanName>
        {
            new HumanName
            {
                Family = new FhirString("Doe"),
                Given = new List<FhirString> { new FhirString("John") }
            }
        };

        // Note: resourceType/id currently not auto-injected into Raw; focus on content we set
        var raw = patient.Raw!;

        // Assert Raw content reflects typed setters
        Assert.Equal("male", raw["gender"]!.GetValue<string>());
        Assert.Equal("1980-01-01", raw["birthDate"]!.GetValue<string>());
        var names = raw["name"]!.AsArray();
        Assert.Single(names);
        var firstName = names[0]!.AsObject();
        Assert.Equal("Doe", firstName["family"]!.GetValue<string>());
        var given = firstName["given"]!.AsArray();
        Assert.Equal("John", given[0]!.GetValue<string>());

        // Produce JSON string from Raw
        var json = raw.ToJsonString(new System.Text.Json.JsonSerializerOptions { WriteIndented = false });
        Assert.Contains("\"gender\":\"male\"", json);
        Assert.Contains("\"birthDate\":\"1980-01-01\"", json);
        Assert.Contains("\"family\":\"Doe\"", json);
    }

    [Fact]
    public void Fluent_Chains_ShouldPopulateRawJson()
    {
        var p = new Patient()
            .WithGender("male")
            .WithBirthDate("1980-01-01")
            .WithActive(true)
            .AddName(hn =>
            {
                hn.Family = new FhirString("Doe");
                hn.Given = new List<FhirString> { new FhirString("John") };
            })
            .AddIdentifier(id =>
            {
                id.Use = new FhirCode("official");
                id.System = new FhirUri("http://hospital.org/mrn");
                id.Value = new FhirString("12345");
            })
            .AddTelecom(cp =>
            {
                cp.System = new FhirCode("phone");
                cp.Value = new FhirString("123-456");
            });

        var raw = p.Raw!;
        Assert.Equal("male", raw["gender"]!.GetValue<string>());
        Assert.Equal("1980-01-01", raw["birthDate"]!.GetValue<string>());
        Assert.True(raw["active"]!.GetValue<bool>());
        Assert.NotNull(raw["name"]);
        Assert.NotNull(raw["identifier"]);
        Assert.NotNull(raw["telecom"]);

        var json = raw.ToJsonString();
        Assert.Contains("\"gender\":\"male\"", json);
        Assert.Contains("\"birthDate\":\"1980-01-01\"", json);
        Assert.Contains("\"active\":true", json);
    }

}

