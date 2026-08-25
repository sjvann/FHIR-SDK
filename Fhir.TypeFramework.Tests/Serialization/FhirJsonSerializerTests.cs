using System.Text.Json;
using Fhir.Resources.R5;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Serialization;

namespace Fhir.TypeFramework.Tests.Serialization;

public sealed class FhirJsonSerializerTests
{
    [Fact]
    public void Patient_json_starts_with_resourceType_and_omits_choice_helpers()
    {
        var patient = new Patient
        {
            Id = new FhirId("example"),
            Active = new FhirBoolean(true),
            Identifier =
            [
                new Identifier
                {
                    System = new FhirUri("http://example.org/mrn"),
                    Value = new FhirString("12345")
                }
            ]
        };

        var json = FhirJsonSerializer.Serialize(patient);
        using var doc = JsonDocument.Parse(json);
        var first = doc.RootElement.EnumerateObject().First();

        Assert.Equal("resourceType", first.Name);
        Assert.Equal("Patient", first.Value.GetString());
        Assert.False(doc.RootElement.TryGetProperty("hasDeceased", out _));
        Assert.False(doc.RootElement.TryGetProperty("hasMultipleBirth", out _));
        Assert.DoesNotContain("\"hasDeceased\"", json, StringComparison.Ordinal);
        Assert.DoesNotContain("\"hasMultipleBirth\"", json, StringComparison.Ordinal);
    }
}
