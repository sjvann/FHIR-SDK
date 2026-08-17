using Fhir.Path.R4;

namespace Fhir.Sdk.R4;

/// <summary>FHIR R4 對外單一入口（資源 POCO、Interop、FHIRPath）。</summary>
public static class FhirSdkR4
{
    /// <summary>建立預設 R4 FHIRPath 與 Patch / x-query 門面。</summary>
    public static FhirPathR4 CreatePath() => FhirPathR4.Create();

    /// <summary>建立預設 FHIRPath 引擎。</summary>
    public static Fhir.Path.Abstractions.IFhirPathEngine CreatePathEngine()
        => FhirPathR4.CreateEngine();
}
