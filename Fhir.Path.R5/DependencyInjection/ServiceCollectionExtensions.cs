using Fhir.Path.Abstractions;
using Fhir.Path.Evaluation;
using Microsoft.Extensions.DependencyInjection;

namespace Fhir.Path.R5.DependencyInjection;

/// <summary>註冊 R5 FHIRPath 引擎與 <see cref="FhirPathR5"/> 門面。</summary>
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFhirPathR5(this IServiceCollection services)
    {
        services.AddSingleton<IFhirPathEngine, FhirPathEngine>();
        services.AddSingleton<FhirPathR5>();
        return services;
    }
}
