using Fhir.Path.R5.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Fhir.Sdk.R5.DependencyInjection;

/// <summary><see cref="Fhir.Sdk.R5"/> DI 註冊。</summary>
public static class ServiceCollectionExtensions
{
    /// <summary>註冊 R5 FHIRPath 引擎與 <see cref="Fhir.Path.R5.FhirPathR5"/> 門面。</summary>
    public static IServiceCollection AddFhirSdkR5(this IServiceCollection services)
        => services.AddFhirPathR5();
}
