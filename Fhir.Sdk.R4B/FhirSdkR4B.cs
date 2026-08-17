using Fhir.Path.R4B;

namespace Fhir.Sdk.R4B;

/// <summary>FHIR R4B 對外單一入口（資源 POCO、Interop、FHIRPath）。</summary>
public static class FhirSdkR4B
{
    /// <summary>建立預設 R4B FHIRPath 與 Patch / x-query 門面。</summary>
    public static FhirPathR4B CreatePath() => FhirPathR4B.Create();

    /// <summary>建立預設 FHIRPath 引擎。</summary>
    public static Fhir.Path.Abstractions.IFhirPathEngine CreatePathEngine()
        => FhirPathR4B.CreateEngine();
}
