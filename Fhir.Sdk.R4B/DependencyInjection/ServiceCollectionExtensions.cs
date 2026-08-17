using Fhir.Path.R4B.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Fhir.Sdk.R4B.DependencyInjection;

/// <summary><see cref="Fhir.Sdk.R4B"/> DI 註冊。</summary>
public static class ServiceCollectionExtensions
{
    /// <summary>註冊 R4B FHIRPath 引擎與 <see cref="Fhir.Path.R4B.FhirPathR4B"/> 門面。</summary>
    public static IServiceCollection AddFhirSdkR4B(this IServiceCollection services)
        => services.AddFhirPathR4B();
}
