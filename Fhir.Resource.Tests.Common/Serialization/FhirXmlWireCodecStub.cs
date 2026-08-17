using Fhir.TypeFramework.Bases;

namespace Fhir.Resource.Tests.Common.Serialization;

/// <summary>
/// Obsolete alias kept so existing usings compile. Prefer <see cref="FhirXmlWireCodec{T}"/>.
/// </summary>
[Obsolete("Use FhirXmlWireCodec<T>; FHIR XML is implemented in Fhir.TypeFramework.")]
public sealed class FhirXmlWireCodecStub<T> : FhirXmlWireCodec<T> where T : DomainResource;
