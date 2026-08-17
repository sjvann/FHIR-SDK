using Fhir.Path.Abstractions;
using Fhir.Path.Evaluation;
using Microsoft.Extensions.DependencyInjection;

namespace Fhir.Path.R4B.DependencyInjection;

/// <summary>註冊 R4B FHIRPath 引擎與 <see cref="FhirPathR4B"/> 門面。</summary>
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFhirPathR4B(this IServiceCollection services)
    {
        services.AddSingleton<IFhirPathEngine, FhirPathEngine>();
        services.AddSingleton<FhirPathR4B>();
        return services;
    }
}
