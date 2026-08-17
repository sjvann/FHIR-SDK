using Fhir.Resource.Tests.Common;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Serialization;
using Xunit;

namespace Fhir.Resources.R5.Tests;

public sealed class JsonXmlEquivalenceTests
{
    [Fact]
    public void Patient_json_and_xml_round_trips_match_id_choice_and_extension()
    {
        var patient = new Patient
        {
            Id = new FhirId("example"),
            DeceasedBoolean = new FhirBoolean(false),
            Name = [new HumanName { Family = new FhirString("Chalmers"), Given = [new FhirString("Peter")] }],
            Extension =
            [
                new Extension
                {
                    Url = "http://example.org/fhir/StructureDefinition/nick",
                    Value = new FhirString("Pete")
                }
            ]
        };

        var fromJson = FhirJsonRoundTrip.RoundTrip(patient);
        var fromXml = FhirXmlRoundTrip.RoundTrip(patient);

        Assert.Equal("example", fromJson.Id?.StringValue);
        Assert.Equal("example", fromXml.Id?.StringValue);
        Assert.Equal(false, fromXml.DeceasedBoolean?.Value);
        Assert.Null(fromXml.DeceasedDateTime);
        Assert.Equal("Chalmers", fromXml.Name![0].Family?.StringValue);
        Assert.Equal("Pete", ((FhirString)((Extension)fromXml.Extension![0]).Value!).StringValue);
    }

    [Fact]
    public void Observation_json_and_xml_round_trips_match_status_code_and_quantity()
    {
        var observation = new Observation
        {
            Id = new FhirId("obs-1"),
            Status = new FhirCode("final"),
            Code = new CodeableConcept
            {
                Coding = [new Coding { System = new FhirUri("http://loinc.org"), Code = new FhirString("29463-7") }]
            },
            EffectiveDateTime = new FhirDateTime("2020-01-02T03:04:05Z"),
            ValueQuantity = new Quantity
            {
                Value = new FhirDecimal(72),
                Code = new FhirCode("kg")
            }
        };

        var fromXml = FhirXmlRoundTrip.RoundTrip(observation);
        Assert.Equal("obs-1", fromXml.Id?.StringValue);
        Assert.Equal("final", fromXml.Status?.StringValue);
        Assert.Equal("29463-7", fromXml.Code?.Coding![0].Code?.StringValue);
        Assert.Equal("72", fromXml.ValueQuantity?.Value?.StringValue);
    }

    [Fact]
    public void Bundle_json_and_xml_round_trips_match_entry_patient()
    {
        var bundle = new Bundle
        {
            Id = new FhirId("bundle-1"),
            Type = new FhirCode("searchset"),
            Entry =
            [
                new Bundle.EntryComponent
                {
                    FullUrl = new FhirUri("http://example.org/fhir/Patient/p1"),
                    Resource = new Patient { Id = new FhirId("p1") }
                }
            ]
        };

        var xml = FhirXmlSerializer.Serialize(bundle);
        var fromXml = FhirXmlSerializer.Deserialize<Bundle>(xml)!;
        var patient = Assert.IsType<Patient>(fromXml.Entry![0].Resource);
        Assert.Equal("p1", patient.Id?.StringValue);
        Assert.Equal("searchset", fromXml.Type?.StringValue);
    }
}
