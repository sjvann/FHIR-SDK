namespace Fhir.TypeFramework.Serialization;

/// <summary>
/// FHIR JSON is implemented by <see cref="FhirJsonSerializer"/>. FHIR XML is implemented by
/// <see cref="FhirXmlSerializer"/> at this same I/O boundary, populating the same POCO object graph
/// (no JSON↔XML string conversion per the FHIR specification).
/// </summary>
public static class FhirXmlSerializationBoundary
{
    public static string Serialize(Bases.Base instance) => FhirXmlSerializer.Serialize(instance);

    public static T? Deserialize<T>(string xml) where T : Bases.Base
        => FhirXmlSerializer.Deserialize<T>(xml);
}
