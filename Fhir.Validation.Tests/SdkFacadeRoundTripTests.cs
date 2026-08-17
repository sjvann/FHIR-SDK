using Fhir.TypeFramework.DataTypes;

namespace Fhir.Validation.Tests;

public sealed class SdkFacadeRoundTripTests
{
    [Fact]
    public void R4_parse_and_serialize_json_and_xml_preserve_patient_id()
    {
        var original = new Fhir.Resources.R4.Patient { Id = new FhirId("facade-r4") };
        var json = Fhir.Sdk.R4.FhirSdkR4.SerializeJson(original);
        var fromJson = Fhir.Sdk.R4.FhirSdkR4.ParseJson<Fhir.Resources.R4.Patient>(json);
        Assert.Equal("facade-r4", fromJson?.Id?.StringValue);

        var xml = Fhir.Sdk.R4.FhirSdkR4.SerializeXml(fromJson!);
        var fromXml = Fhir.Sdk.R4.FhirSdkR4.ParseXml<Fhir.Resources.R4.Patient>(xml);
        Assert.Equal("facade-r4", fromXml?.Id?.StringValue);
        Assert.IsType<Fhir.Resources.R4.Patient>(Fhir.Sdk.R4.FhirSdkR4.ParseJson(json));
    }

    [Fact]
    public void R4B_parse_and_serialize_json_and_xml_preserve_patient_id()
    {
        var original = new Fhir.Resources.R4B.Patient { Id = new FhirId("facade-r4b") };
        var json = Fhir.Sdk.R4B.FhirSdkR4B.SerializeJson(original);
        var fromJson = Fhir.Sdk.R4B.FhirSdkR4B.ParseJson<Fhir.Resources.R4B.Patient>(json);
        Assert.Equal("facade-r4b", fromJson?.Id?.StringValue);

        var xml = Fhir.Sdk.R4B.FhirSdkR4B.SerializeXml(fromJson!);
        var fromXml = Fhir.Sdk.R4B.FhirSdkR4B.ParseXml<Fhir.Resources.R4B.Patient>(xml);
        Assert.Equal("facade-r4b", fromXml?.Id?.StringValue);
    }

    [Fact]
    public void R5_parse_and_serialize_json_and_xml_preserve_patient_id()
    {
        var original = new Fhir.Resources.R5.Patient { Id = new FhirId("facade-r5") };
        var json = Fhir.Sdk.R5.FhirSdkR5.SerializeJson(original);
        var fromJson = Fhir.Sdk.R5.FhirSdkR5.ParseJson<Fhir.Resources.R5.Patient>(json);
        Assert.Equal("facade-r5", fromJson?.Id?.StringValue);

        var xml = Fhir.Sdk.R5.FhirSdkR5.SerializeXml(fromJson!);
        var fromXml = Fhir.Sdk.R5.FhirSdkR5.ParseXml<Fhir.Resources.R5.Patient>(xml);
        Assert.Equal("facade-r5", fromXml?.Id?.StringValue);
    }

    [Fact]
    public void Facade_parse_xml_throws_on_malformed_payload()
    {
        Assert.ThrowsAny<System.Xml.XmlException>(
            () => Fhir.Sdk.R4.FhirSdkR4.ParseXml<Fhir.Resources.R4.Patient>("<Patient><id"));
    }
}
