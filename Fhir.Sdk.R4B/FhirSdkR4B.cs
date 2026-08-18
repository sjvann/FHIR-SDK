using Fhir.Path.R4B;
using Fhir.Resources.R4B;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Serialization;
using Fhir.Validation;

namespace Fhir.Sdk.R4B;

/// <summary>FHIR R4B 對外單一入口（資源 POCO、Interop、FHIRPath、JSON／XML）。</summary>
public static class FhirSdkR4B
{
    /// <summary>建立預設 R4B FHIRPath 與 Patch / x-query 門面。</summary>
    public static FhirPathR4B CreatePath() => FhirPathR4B.Create();

    /// <summary>建立預設 FHIRPath 引擎。</summary>
    public static Fhir.Path.Abstractions.IFhirPathEngine CreatePathEngine()
        => FhirPathR4B.CreateEngine();

    /// <summary>從 <c>Fhir.Resources.R4B</c> 建立 resourceType → CLR 對照表。</summary>
    public static IReadOnlyDictionary<string, Type> CreateResourceTypes()
        => FhirResourceTypeMap.FromResourceAssembly(typeof(Patient).Assembly, typeof(Resource));

    public static string SerializeJson(Base instance, FhirSerializerOptions? options = null)
        => FhirJsonSerializer.Serialize(instance, options ?? FhirSerializerOptions.Lenient);

    public static T? ParseJson<T>(string json, FhirSerializerOptions? options = null) where T : Base
        => FhirJsonSerializer.Deserialize<T>(json, options ?? FhirSerializerOptions.Lenient);

    public static Resource? ParseJson(string json, FhirSerializerOptions? options = null)
        => FhirJsonSerializer.DeserializeResource(json, CreateResourceTypes(), options ?? FhirSerializerOptions.Lenient);

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
                EvaluateSlicing = options.EvaluateSlicing,
                EvaluateFixedPattern = options.EvaluateFixedPattern,
                IncludeMetaProfile = options.IncludeMetaProfile
            }
            : options;
    }
}
