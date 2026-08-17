using Fhir.Path.R5;

namespace Fhir.Sdk.R5;

/// <summary>FHIR R5 對外單一入口（資源 POCO、Interop、FHIRPath）。</summary>
public static class FhirSdkR5
{
    /// <summary>建立預設 R5 FHIRPath 與 Patch / x-query 門面。</summary>
    public static FhirPathR5 CreatePath() => FhirPathR5.Create();

    /// <summary>建立預設 FHIRPath 引擎。</summary>
    public static Fhir.Path.Abstractions.IFhirPathEngine CreatePathEngine()
        => FhirPathR5.CreateEngine();
}
