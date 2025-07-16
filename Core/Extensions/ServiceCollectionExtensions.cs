using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Core.Fhirs;
using Core.Versioning;
using Core.Contracts;
using Core.Factories;
using Core.Configuration;
using Core.Versioning.Migrators;

namespace Core.Extensions;

/// <summary>
/// Dependency injection extensions for Core services
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds core FHIR SDK services to the DI container with enhanced features
    /// </summary>
    /// <param name="services">Service collection</param>
    /// <param name="configuration">Configuration instance</param>
    /// <returns>Service collection for chaining</returns>
    public static IServiceCollection AddFhirSdk(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Add configuration
        services.AddFhirSdkConfiguration(configuration);
        
        // Add core services
        return services.AddFhirSdkCore();
    }
    
    /// <summary>
    /// Adds core FHIR SDK services with custom options
    /// </summary>
    /// <param name="services">Service collection</param>
    /// <param name="configureOptions">Configuration action for FHIR SDK options</param>
    /// <returns>Service collection for chaining</returns>
    public static IServiceCollection AddFhirSdk(
        this IServiceCollection services,
        Action<FhirSdkOptions> configureOptions)
    {
        // Add configuration
        services.AddFhirSdkConfiguration(configureOptions);
        
        // Add core services
        return services.AddFhirSdkCore();
    }
    
    /// <summary>
    /// Adds FHIR SDK with default development configuration
    /// </summary>
    /// <param name="services">Service collection</param>
    /// <returns>Service collection for chaining</returns>
    public static IServiceCollection AddFhirSdkDefault(this IServiceCollection services)
    {
        return services.AddFhirSdk(options => 
        {
            var defaultOptions = FhirSdkConfiguration.CreateDefault();
            options.DefaultVersion = defaultOptions.DefaultVersion;
            options.SupportedVersions = defaultOptions.SupportedVersions;
            options.EnableAutoMigration = defaultOptions.EnableAutoMigration;
            options.Validation = defaultOptions.Validation;
            options.Performance = defaultOptions.Performance;
        });
    }
    
    /// <summary>
    /// Adds FHIR SDK with production configuration
    /// </summary>
    /// <param name="services">Service collection</param>
    /// <returns>Service collection for chaining</returns>
    public static IServiceCollection AddFhirSdkProduction(this IServiceCollection services)
    {
        return services.AddFhirSdk(options => 
        {
            var prodOptions = FhirSdkConfiguration.CreateProduction();
            options.DefaultVersion = prodOptions.DefaultVersion;
            options.SupportedVersions = prodOptions.SupportedVersions;
            options.EnableAutoMigration = prodOptions.EnableAutoMigration;
            options.Validation = prodOptions.Validation;
            options.Performance = prodOptions.Performance;
        });
    }
    
    /// <summary>
    /// Adds FHIR SDK with R6-ready configuration
    /// </summary>
    /// <param name="services">Service collection</param>
    /// <returns>Service collection for chaining</returns>
    public static IServiceCollection AddFhirSdkR6Ready(this IServiceCollection services)
    {
        return services.AddFhirSdk(options => 
        {
            var r6Options = FhirSdkConfiguration.CreateR6Ready();
            options.DefaultVersion = r6Options.DefaultVersion;
            options.SupportedVersions = r6Options.SupportedVersions;
            options.EnableAutoMigration = r6Options.EnableAutoMigration;
            options.Validation = r6Options.Validation;
            options.Performance = r6Options.Performance;
            options.VersionConfigs = r6Options.VersionConfigs;
        });
    }
    
    private static IServiceCollection AddFhirSdkCore(this IServiceCollection services)
    {
        // Add core version management services
        services.TryAddSingleton<FhirVersionManager>();
        services.TryAddSingleton<MigrationStrategyRegistry>();
        
        // Add FHIR server services
        services.TryAddScoped<IFhirServer, DefaultFhirServer>();
        
        // Add resource factory services
        services.TryAddSingleton<FhirResourceFactoryProvider>();
        services.TryAddScoped<IFhirResourceFactory>(provider =>
        {
            var factoryProvider = provider.GetRequiredService<FhirResourceFactoryProvider>();
            var options = provider.GetRequiredService<IOptions<FhirSdkOptions>>();
            return factoryProvider.CreateForVersion(options.Value.DefaultVersion);
        });
        
        // Add version migrators
        services.AddFhirVersionMigrators();
        
        return services;
    }
    
    /// <summary>
    /// Adds FHIR version migrators to the DI container
    /// </summary>
    /// <param name="services">Service collection</param>
    /// <returns>Service collection for chaining</returns>
    public static IServiceCollection AddFhirVersionMigrators(this IServiceCollection services)
    {
        // Add built-in migrators
        services.TryAddTransient<IVersionMigrator, R5ToR6Migrator>();
        
        // Scan for additional IVersionMigrator implementations
        var migratorTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a => a.GetTypes())
            .Where(t => t.IsClass && !t.IsAbstract && 
                       typeof(IVersionMigrator).IsAssignableFrom(t) &&
                       t != typeof(R5ToR6Migrator)); // Exclude already registered types
            
        foreach (var migratorType in migratorTypes)
        {
            services.TryAddTransient(typeof(IVersionMigrator), migratorType);
        }
        
        return services;
    }
    
    /// <summary>
    /// Adds versioned service factory for a specific service type
    /// </summary>
    /// <typeparam name="TService">Service type</typeparam>
    /// <typeparam name="TFactory">Factory implementation type</typeparam>
    /// <param name="services">Service collection</param>
    /// <returns>Service collection for chaining</returns>
    public static IServiceCollection AddVersionedServiceFactory<TService, TFactory>(
        this IServiceCollection services)
        where TService : class
        where TFactory : class, IVersionedServiceFactory<TService>
    {
        services.TryAddSingleton<IVersionedServiceFactory<TService>, TFactory>();
        return services;
    }
    
    /// <summary>
    /// Adds a version-specific repository implementation
    /// </summary>
    /// <typeparam name="TResource">Resource type</typeparam>
    /// <typeparam name="TRepository">Repository implementation type</typeparam>
    /// <param name="services">Service collection</param>
    /// <param name="version">FHIR version this repository supports</param>
    /// <returns>Service collection for chaining</returns>
    public static IServiceCollection AddVersionedRepository<TResource, TRepository>(
        this IServiceCollection services,
        FhirVersion version)
        where TResource : class, IFhirResource
        where TRepository : class, IFhirRepository<TResource>
    {
        // Register the repository with a key based on version
        services.TryAddKeyedScoped<IFhirRepository<TResource>, TRepository>(version.ToString());
        
        // Register a factory that creates the appropriate repository based on current version
        services.TryAddScoped<IFhirRepository<TResource>>(provider =>
        {
            var options = provider.GetRequiredService<IOptions<FhirSdkOptions>>();
            var currentVersion = options.Value.DefaultVersion;
            
            return provider.GetRequiredKeyedService<IFhirRepository<TResource>>(currentVersion.ToString());
        });
        
        return services;
    }
}

/// <summary>
/// Enhanced default implementation of IFhirServer for dependency injection
/// </summary>
internal class DefaultFhirServer : IFhirServer
{
    private readonly FhirServerOptions _serverOptions;
    private readonly FhirSdkOptions _sdkOptions;
    private string? _accessToken;
    private DateTime _tokenExpiry = DateTime.MinValue;
    
    public FhirVersion SupportedVersion => _sdkOptions.DefaultVersion;
    
    public DefaultFhirServer(
        IOptions<FhirServerOptions> serverOptions,
        IOptions<FhirSdkOptions> sdkOptions)
    {
        _serverOptions = serverOptions.Value;
        _sdkOptions = sdkOptions.Value;
    }
    
    public string GetBasedUrl() => _serverOptions.BaseUrl;
    
    public string GetAccessToken()
    {
        if (IsExpired())
        {
            throw new InvalidOperationException("Access token has expired. Call RefreshTokenAsync() first.");
        }
        return _accessToken ?? string.Empty;
    }
    
    public bool IsExpired() => DateTime.UtcNow >= _tokenExpiry;
    
    public bool CanHandle(FhirVersion version) => 
        _sdkOptions.SupportedVersions.Contains(version) || SupportedVersion.IsCompatibleWith(version);
    
    public async Task<string> GetCapabilitiesAsync()
    {
        // Implementation would make HTTP call to server's capability statement
        // This is a placeholder implementation
        await Task.Delay(1);
        return """
        {
            "resourceType": "CapabilityStatement",
            "status": "active",
            "date": "2025-01-01",
            "kind": "instance",
            "fhirVersion": "5.0.0",
            "format": ["json", "xml"]
        }
        """;
    }
    
    public FhirVersion[] GetSupportedFhirVersions()
    {
        return _sdkOptions.SupportedVersions;
    }
    
    public async Task RefreshTokenAsync()
    {
        // Implementation would refresh the authentication token
        // This is a placeholder implementation
        await Task.Delay(100); // Simulate network call
        _accessToken = $"bearer_{Guid.NewGuid():N}";
        _tokenExpiry = DateTime.UtcNow.AddHours(1);
    }
}
