using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Serialization;
using Fhir.Resource.Tests.Common.Serialization;

namespace Fhir.Resource.Tests.Common;

/// <summary>
/// Convenience helpers for XML round-trip at the I/O boundary (same POCO graph as JSON).
/// </summary>
public static class FhirXmlRoundTrip
{
    public static string Serialize<T>(T value) where T : Base => FhirXmlSerializer.Serialize(value);

    public static T? Deserialize<T>(string xml) where T : Base => FhirXmlSerializer.Deserialize<T>(xml);

    public static T RoundTrip<T>(T value) where T : Base
    {
        var xml = Serialize(value);
        return Deserialize<T>(xml)!;
    }

    public static T RoundTripDomain<T>(T value, FhirXmlWireCodec<T>? codec = null)
        where T : DomainResource
    {
        codec ??= new FhirXmlWireCodec<T>();
        return codec.Parse(codec.Write(value))!;
    }
}
