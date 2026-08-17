using Fhir.Path.Abstractions;
using Fhir.Path.Evaluation;
using Microsoft.Extensions.DependencyInjection;

namespace Fhir.Path.R4.DependencyInjection;

/// <summary>註冊 R4 FHIRPath 引擎與 <see cref="FhirPathR4"/> 門面。</summary>
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFhirPathR4(this IServiceCollection services)
    {
        services.AddSingleton<IFhirPathEngine, FhirPathEngine>();
        services.AddSingleton<FhirPathR4>();
        return services;
    }
}
