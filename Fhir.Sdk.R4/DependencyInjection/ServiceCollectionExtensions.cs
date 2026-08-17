using Fhir.Path.R4.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Fhir.Sdk.R4.DependencyInjection;

/// <summary><see cref="Fhir.Sdk.R4"/> DI 註冊。</summary>
public static class ServiceCollectionExtensions
{
    /// <summary>註冊 R4 FHIRPath 引擎與 <see cref="Fhir.Path.R4.FhirPathR4"/> 門面。</summary>
    public static IServiceCollection AddFhirSdkR4(this IServiceCollection services)
        => services.AddFhirPathR4();
}
