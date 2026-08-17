using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Serialization;

namespace Fhir.Resource.Tests.Common.Serialization;

/// <summary>FHIR XML via <see cref="FhirXmlSerializer"/> (same POCO graph as JSON).</summary>
public class FhirXmlWireCodec<T> : IResourceWireCodec<T> where T : DomainResource
{
    public string WireFormat => "xml";

    public bool IsSupported => true;

    public T? Parse(string payload) => FhirXmlSerializer.Deserialize<T>(payload);

    public string Write(T value) => FhirXmlSerializer.Serialize(value);
}
