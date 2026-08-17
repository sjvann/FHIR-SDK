using Fhir.Resources.R5;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Serialization;

namespace Fhir.TypeFramework.Tests.Serialization;

public sealed class FhirXmlSerializerTests
{
    [Fact]
    public void HumanName_xml_round_trip_preserves_family_and_given()
    {
        var name = new HumanName
        {
            Family = new FhirString("Chalmers"),
            Given = [new FhirString("Peter"), new FhirString("James")]
        };

        var xml = FhirXmlSerializer.Serialize(name);
        Assert.Contains("Chalmers", xml);
        Assert.Contains("value=\"Peter\"", xml);

        var back = FhirXmlSerializer.Deserialize<HumanName>(xml);
        Assert.NotNull(back);
        Assert.Equal("Chalmers", back!.Family?.StringValue);
        Assert.Equal(2, back.Given?.Count);
        Assert.Equal("Peter", back.Given![0].StringValue);
        Assert.Equal("James", back.Given[1].StringValue);
    }

    [Fact]
    public void Extension_xml_round_trip_preserves_url_and_value_string()
    {
        var ext = new Extension
        {
            Url = "http://example.org/fhir/StructureDefinition/nick",
            Value = new FhirString("Ada")
        };

        var xml = FhirXmlSerializer.Serialize(ext);
        Assert.Contains("url=\"http://example.org/fhir/StructureDefinition/nick\"", xml);
        Assert.Contains("valueString", xml);

        var back = FhirXmlSerializer.Deserialize<Extension>(xml);
        Assert.NotNull(back);
        Assert.Equal("http://example.org/fhir/StructureDefinition/nick", back!.Url?.StringValue);
        Assert.IsType<FhirString>(back.Value);
        Assert.Equal("Ada", ((FhirString)back.Value!).StringValue);
    }

    [Fact]
    public void Patient_json_and_xml_round_trips_are_semantically_equivalent()
    {
        var patient = new Patient
        {
            Id = new FhirId("example"),
            Active = new FhirBoolean(true),
            DeceasedBoolean = new FhirBoolean(false),
            Name =
            [
                new HumanName
                {
                    Family = new FhirString("Chalmers"),
                    Given = [new FhirString("Peter")]
                }
            ],
            Extension =
            [
                new Extension
                {
                    Url = "http://example.org/fhir/StructureDefinition/nick",
                    Value = new FhirString("Pete")
                }
            ],
            Text = new Narrative
            {
                Status = new FhirString("generated"),
                Div = new FhirXhtml("<div xmlns=\"http://www.w3.org/1999/xhtml\"><p>Peter Chalmers</p></div>")
            }
        };

        var fromJson = FhirJsonSerializer.Deserialize<Patient>(FhirJsonSerializer.Serialize(patient))!;
        var xml = FhirXmlSerializer.Serialize(patient);
        var fromXml = FhirXmlSerializer.Deserialize<Patient>(xml)!;

        Assert.DoesNotContain("resourceType", xml, StringComparison.Ordinal);
        Assert.Contains("<Patient", xml);
        Assert.Equal("example", fromJson.Id?.StringValue);
        Assert.Equal("example", fromXml.Id?.StringValue);
        Assert.Equal(false, fromXml.DeceasedBoolean?.Value);
        Assert.Null(fromXml.DeceasedDateTime);
        Assert.Equal("Chalmers", fromXml.Name![0].Family?.StringValue);
        Assert.Equal("Pete", ((FhirString)((Extension)fromXml.Extension![0]).Value!).StringValue);
        Assert.Contains("Peter Chalmers", fromXml.Text?.Div?.StringValue);
    }

    [Fact]
    public void Observation_json_and_xml_round_trips_preserve_choice_and_quantity()
    {
        var observation = new Observation
        {
            Id = new FhirId("obs-1"),
            Status = new FhirCode("final"),
            Code = new CodeableConcept
            {
                Coding =
                [
                    new Coding
                    {
                        System = new FhirUri("http://loinc.org"),
                        Code = new FhirString("29463-7")
                    }
                ]
            },
            EffectiveDateTime = new FhirDateTime("2020-01-02T03:04:05Z"),
            ValueQuantity = new Quantity
            {
                Value = new FhirDecimal(72),
                Unit = new FhirString("kg"),
                System = new FhirUri("http://unitsofmeasure.org"),
                Code = new FhirCode("kg")
            }
        };

        var fromJson = FhirJsonSerializer.Deserialize<Observation>(FhirJsonSerializer.Serialize(observation))!;
        var fromXml = FhirXmlSerializer.Deserialize<Observation>(FhirXmlSerializer.Serialize(observation))!;

        Assert.Equal("obs-1", fromJson.Id?.StringValue);
        Assert.Equal("obs-1", fromXml.Id?.StringValue);
        Assert.Equal("final", fromXml.Status?.StringValue);
        Assert.Equal("29463-7", fromXml.Code?.Coding![0].Code?.StringValue);
        Assert.Equal("2020-01-02T03:04:05Z", fromXml.EffectiveDateTime?.StringValue);
        Assert.Null(fromXml.EffectivePeriod);
        Assert.Equal("72", fromXml.ValueQuantity?.Value?.StringValue);
        Assert.Equal("kg", fromXml.ValueQuantity?.Code?.StringValue);
    }

    [Fact]
    public void Bundle_json_and_xml_round_trips_preserve_entry_resource()
    {
        var patient = new Patient { Id = new FhirId("p1"), Active = new FhirBoolean(true) };
        var bundle = new Bundle
        {
            Id = new FhirId("bundle-1"),
            Type = new FhirCode("searchset"),
            Entry =
            [
                new Bundle.EntryComponent
                {
                    FullUrl = new FhirUri("http://example.org/fhir/Patient/p1"),
                    Resource = patient
                }
            ]
        };

        var xml = FhirXmlSerializer.Serialize(bundle);
        Assert.Contains("<Patient", xml);
        Assert.Contains("<resource>", xml);

        var map = FhirResourceTypeMap.FromResourceAssembly(typeof(Patient).Assembly, typeof(Fhir.TypeFramework.Bases.Resource));
        var fromJson = System.Text.Json.JsonSerializer.Deserialize<Bundle>(
            FhirJsonSerializer.SerializeWithResourcePolymorphism(bundle, map),
            FhirJsonSerializer.OptionsWithPolymorphicResources(map))!;
        var fromXml = FhirXmlSerializer.Deserialize<Bundle>(xml)!;

        Assert.Equal("bundle-1", fromXml.Id?.StringValue);
        Assert.Equal("searchset", fromXml.Type?.StringValue);
        var xmlEntry = Assert.IsType<Patient>(fromXml.Entry![0].Resource);
        Assert.Equal("p1", xmlEntry.Id?.StringValue);
        Assert.Equal("http://example.org/fhir/Patient/p1", fromXml.Entry[0].FullUrl?.StringValue);

        var jsonEntry = Assert.IsType<Patient>(fromJson.Entry![0].Resource);
        Assert.Equal("p1", jsonEntry.Id?.StringValue);
    }

    [Fact]
    public void Malformed_xml_throws_so_callers_can_map_parse_failed()
    {
        Assert.ThrowsAny<System.Xml.XmlException>(
            () => FhirXmlSerializer.Deserialize<Patient>("<Patient><id value=\"x\""));
    }

    [Fact]
    public void Unknown_resource_root_throws_so_callers_can_map_parse_failed()
    {
        var ex = Assert.Throws<InvalidOperationException>(
            () => FhirXmlSerializer.Deserialize<Fhir.TypeFramework.Bases.Resource>(
                """<NotAResource xmlns="http://hl7.org/fhir"><id value="x"/></NotAResource>"""));
        Assert.Contains("NotAResource", ex.Message, StringComparison.Ordinal);
    }
}
