using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Serialization;

namespace Fhir.VersionManager.Runtime;

/// <summary>
/// 跨線別作業契約：應用以 <see cref="FhirVersion"/> 取得執行期，不必硬綁 <c>Fhir.Sdk.R5</c>。
/// </summary>
public interface IFhirLineRuntime
{
    FhirVersion Version { get; }

    IReadOnlyDictionary<string, Type> ResourceTypes { get; }

    Resource? ParseJson(string json, FhirSerializerOptions? options = null);

    string SerializeJson(Base instance, FhirSerializerOptions? options = null);

    Resource? ParseXml(string xml);

    string SerializeXml(Base instance);
}

/// <summary>依線別解析 <see cref="IFhirLineRuntime"/>。</summary>
public interface IFhirLineRuntimeFactory
{
    IFhirLineRuntime Get(FhirVersion version);

    bool TryGet(FhirVersion version, out IFhirLineRuntime runtime);
}
