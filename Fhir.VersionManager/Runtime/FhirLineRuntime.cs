using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Serialization;

namespace Fhir.VersionManager.Runtime;

internal sealed class FhirLineRuntime : IFhirLineRuntime
{
    public FhirLineRuntime(FhirVersion version, IReadOnlyDictionary<string, Type> resourceTypes)
    {
        Version = version;
        ResourceTypes = resourceTypes;
    }

    public FhirVersion Version { get; }

    public IReadOnlyDictionary<string, Type> ResourceTypes { get; }

    public Resource? ParseJson(string json, FhirSerializerOptions? options = null)
        => FhirJsonSerializer.DeserializeResource(json, ResourceTypes, options ?? FhirSerializerOptions.Lenient);

    public string SerializeJson(Base instance, FhirSerializerOptions? options = null)
        => FhirJsonSerializer.Serialize(instance, options ?? FhirSerializerOptions.Lenient);

    public Resource? ParseXml(string xml)
        => FhirXmlSerializer.DeserializeResource(xml, ResourceTypes);

    public string SerializeXml(Base instance)
        => FhirXmlSerializer.Serialize(instance);
}

/// <summary>以各線別 Resources 組件建立跨線別執行期。</summary>
public sealed class FhirLineRuntimeFactory : IFhirLineRuntimeFactory
{
    private readonly Dictionary<FhirVersion, IFhirLineRuntime> _runtimes;

    public FhirLineRuntimeFactory()
    {
        _runtimes = new Dictionary<FhirVersion, IFhirLineRuntime>
        {
            [FhirVersion.R4] = Create(FhirVersion.R4, typeof(Fhir.Resources.R4.Patient).Assembly),
            [FhirVersion.R4B] = Create(FhirVersion.R4B, typeof(Fhir.Resources.R4B.Patient).Assembly),
            [FhirVersion.R5] = Create(FhirVersion.R5, typeof(Fhir.Resources.R5.Patient).Assembly),
        };
    }

    public IFhirLineRuntime Get(FhirVersion version)
        => TryGet(version, out var runtime)
            ? runtime
            : throw new ArgumentOutOfRangeException(nameof(version), version, "Unsupported FHIR line.");

    public bool TryGet(FhirVersion version, out IFhirLineRuntime runtime)
        => _runtimes.TryGetValue(version, out runtime!);

    private static IFhirLineRuntime Create(FhirVersion version, System.Reflection.Assembly assembly)
        => new FhirLineRuntime(version, FhirResourceTypeMap.FromResourceAssembly(assembly, typeof(Resource)));
}
