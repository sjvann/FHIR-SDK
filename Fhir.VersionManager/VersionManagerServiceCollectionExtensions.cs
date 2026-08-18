using Fhir.VersionManager.Capability;
using Fhir.VersionManager.Runtime;
using Microsoft.Extensions.DependencyInjection;

namespace Fhir.VersionManager;

public static class VersionManagerServiceCollectionExtensions
{
    public static IServiceCollection AddFhirVersionManager(this IServiceCollection services)
    {
        services.AddSingleton<IFhirCapabilityRuntime, FhirCapabilityRuntime>();
        services.AddSingleton<IFhirLineRuntimeFactory, FhirLineRuntimeFactory>();
        return services;
    }
}
