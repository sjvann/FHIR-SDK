using Fhir.Path.R5;
using Fhir.Resources.R5;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Serialization;
using Fhir.Validation;

namespace Fhir.Sdk.R5;

/// <summary>FHIR R5 對外單一入口（資源 POCO、Interop、FHIRPath、JSON／XML）。</summary>
public static class FhirSdkR5
{
    /// <summary>建立預設 R5 FHIRPath 與 Patch / x-query 門面。</summary>
    public static FhirPathR5 CreatePath() => FhirPathR5.Create();

    /// <summary>建立預設 FHIRPath 引擎。</summary>
    public static Fhir.Path.Abstractions.IFhirPathEngine CreatePathEngine()
        => FhirPathR5.CreateEngine();

    /// <summary>從 <c>Fhir.Resources.R5</c> 建立 resourceType → CLR 對照表。</summary>
    public static IReadOnlyDictionary<string, Type> CreateResourceTypes()
        => FhirResourceTypeMap.FromResourceAssembly(typeof(Patient).Assembly, typeof(Resource));

    public static string SerializeJson(Base instance) => FhirJsonSerializer.Serialize(instance);

    public static T? ParseJson<T>(string json) where T : Base
        => FhirJsonSerializer.Deserialize<T>(json);

    public static Resource? ParseJson(string json)
        => FhirJsonSerializer.DeserializeResource(json, CreateResourceTypes());

    public static string SerializeXml(Base instance) => FhirXmlSerializer.Serialize(instance);

    public static T? ParseXml<T>(string xml) where T : Base
        => FhirXmlSerializer.Deserialize<T>(xml, CreateResourceTypes());

    public static Resource? ParseXml(string xml)
        => FhirXmlSerializer.DeserializeResource(xml, CreateResourceTypes());

    public static IProfileValidator CreateValidator(ProfileCatalog catalog, ProfileValidationOptions? options = null)
        => new ProfileValidator(catalog, WithEngine(options));

    private static ProfileValidationOptions WithEngine(ProfileValidationOptions? options)
    {
        options ??= new ProfileValidationOptions();
        return options.PathEngine is null
            ? new ProfileValidationOptions
            {
                Handling = options.Handling,
                Terminology = options.Terminology,
                PathEngine = CreatePathEngine(),
                EvaluateInvariants = options.EvaluateInvariants,
                EvaluateSlicing = options.EvaluateSlicing
            }
            : options;
    }
}
