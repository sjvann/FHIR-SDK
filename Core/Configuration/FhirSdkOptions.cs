using Core.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Core.Configuration;

/// <summary>
/// Configuration options for FHIR SDK
/// </summary>
public class FhirSdkOptions
{
    /// <summary>
    /// Configuration section name
    /// </summary>
    public const string SectionName = "FhirSdk";
    
    /// <summary>
    /// Default FHIR version to use
    /// </summary>
    public FhirVersion DefaultVersion { get; set; } = FhirVersion.R5;
    
    /// <summary>
    /// Supported FHIR versions
    /// </summary>
    public FhirVersion[] SupportedVersions { get; set; } = { FhirVersion.R5 };
    
    /// <summary>
    /// Enable automatic version migration
    /// </summary>
    public bool EnableAutoMigration { get; set; } = true;
    
    /// <summary>
    /// Validation options
    /// </summary>
    public ValidationOptions Validation { get; set; } = new();
    
    /// <summary>
    /// Performance options
    /// </summary>
    public PerformanceOptions Performance { get; set; } = new();
    
    /// <summary>
    /// Version-specific configurations
    /// </summary>
    public Dictionary<string, VersionSpecificOptions> VersionConfigs { get; set; } = new();
}

/// <summary>
/// Validation configuration options
/// </summary>
public class ValidationOptions
{
    /// <summary>
    /// Enable strict validation
    /// </summary>
    public bool StrictValidation { get; set; } = true;
    
    /// <summary>
    /// Validate against profiles
    /// </summary>
    public bool ValidateProfiles { get; set; } = true;
    
    /// <summary>
    /// Validate terminology bindings
    /// </summary>
    public bool ValidateTerminology { get; set; } = false;
    
    /// <summary>
    /// Fail on validation warnings
    /// </summary>
    public bool FailOnWarnings { get; set; } = false;
}

/// <summary>
/// Performance configuration options
/// </summary>
public class PerformanceOptions
{
    /// <summary>
    /// Enable resource caching
    /// </summary>
    public bool EnableCaching { get; set; } = true;
    
    /// <summary>
    /// Cache expiration time in minutes
    /// </summary>
    public int CacheExpirationMinutes { get; set; } = 60;
    
    /// <summary>
    /// Maximum cache size in MB
    /// </summary>
    public int MaxCacheSizeMB { get; set; } = 100;
    
    /// <summary>
    /// Enable parallel processing
    /// </summary>
    public bool EnableParallelProcessing { get; set; } = true;
    
    /// <summary>
    /// Maximum degree of parallelism
    /// </summary>
    public int MaxDegreeOfParallelism { get; set; } = Environment.ProcessorCount;
}

/// <summary>
/// Version-specific configuration options
/// </summary>
public class VersionSpecificOptions
{
    /// <summary>
    /// Enable this version
    /// </summary>
    public bool Enabled { get; set; } = true;
    
    /// <summary>
    /// Custom resource assemblies for this version
    /// </summary>
    public string[] ResourceAssemblies { get; set; } = Array.Empty<string>();
    
    /// <summary>
    /// Version-specific validation rules
    /// </summary>
    public Dictionary<string, object> ValidationRules { get; set; } = new();
    
    /// <summary>
    /// Migration settings for this version
    /// </summary>
    public MigrationOptions Migration { get; set; } = new();
}

/// <summary>
/// Migration configuration options
/// </summary>
public class MigrationOptions
{
    /// <summary>
    /// Enable migration from this version
    /// </summary>
    public bool EnableMigrationFrom { get; set; } = true;
    
    /// <summary>
    /// Enable migration to this version
    /// </summary>
    public bool EnableMigrationTo { get; set; } = true;
    
    /// <summary>
    /// Custom migration rules
    /// </summary>
    public Dictionary<string, string> CustomRules { get; set; } = new();
    
    /// <summary>
    /// Backup data before migration
    /// </summary>
    public bool BackupBeforeMigration { get; set; } = true;
}

/// <summary>
/// Configuration extensions for dependency injection
/// </summary>
public static class ConfigurationExtensions
{
    /// <summary>
    /// Adds FHIR SDK configuration to the service collection
    /// </summary>
    /// <param name="services">Service collection</param>
    /// <param name="configuration">Configuration instance</param>
    /// <returns>Service collection for chaining</returns>
    public static IServiceCollection AddFhirSdkConfiguration(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        // Bind main configuration
        services.Configure<FhirSdkOptions>(
            configuration.GetSection(FhirSdkOptions.SectionName));
        
        // Add configuration validator
        services.AddSingleton<IValidateOptions<FhirSdkOptions>, FhirSdkOptionsValidator>();
        
        return services;
    }
    
    /// <summary>
    /// Adds FHIR SDK configuration with custom options
    /// </summary>
    /// <param name="services">Service collection</param>
    /// <param name="configureOptions">Configuration action</param>
    /// <returns>Service collection for chaining</returns>
    public static IServiceCollection AddFhirSdkConfiguration(
        this IServiceCollection services,
        Action<FhirSdkOptions> configureOptions)
    {
        services.Configure(configureOptions);
        services.AddSingleton<IValidateOptions<FhirSdkOptions>, FhirSdkOptionsValidator>();
        return services;
    }
}

/// <summary>
/// Validator for FHIR SDK options
/// </summary>
public class FhirSdkOptionsValidator : IValidateOptions<FhirSdkOptions>
{
    public ValidateOptionsResult Validate(string? name, FhirSdkOptions options)
    {
        var failures = new List<string>();
        
        // Validate that at least one version is supported
        if (options.SupportedVersions == null || options.SupportedVersions.Length == 0)
        {
            failures.Add("At least one FHIR version must be supported");
        }
        
        // Validate that default version is in supported versions
        if (options.SupportedVersions != null && 
            !options.SupportedVersions.Contains(options.DefaultVersion))
        {
            failures.Add($"Default version {options.DefaultVersion} must be in supported versions");
        }
        
        // Validate performance options
        if (options.Performance.CacheExpirationMinutes <= 0)
        {
            failures.Add("Cache expiration must be greater than 0");
        }
        
        if (options.Performance.MaxCacheSizeMB <= 0)
        {
            failures.Add("Maximum cache size must be greater than 0");
        }
        
        if (options.Performance.MaxDegreeOfParallelism <= 0)
        {
            failures.Add("Maximum degree of parallelism must be greater than 0");
        }
        
        return failures.Count > 0 
            ? ValidateOptionsResult.Fail(failures)
            : ValidateOptionsResult.Success;
    }
}

/// <summary>
/// Helper class for working with configuration
/// </summary>
public static class FhirSdkConfiguration
{
    /// <summary>
    /// Creates default configuration for development
    /// </summary>
    /// <returns>Default options</returns>
    public static FhirSdkOptions CreateDefault()
    {
        return new FhirSdkOptions
        {
            DefaultVersion = FhirVersion.R5,
            SupportedVersions = new[] { FhirVersion.R5 },
            EnableAutoMigration = true,
            Validation = new ValidationOptions
            {
                StrictValidation = false, // Relaxed for development
                ValidateProfiles = true,
                ValidateTerminology = false,
                FailOnWarnings = false
            },
            Performance = new PerformanceOptions
            {
                EnableCaching = true,
                CacheExpirationMinutes = 30,
                MaxCacheSizeMB = 50,
                EnableParallelProcessing = true,
                MaxDegreeOfParallelism = Environment.ProcessorCount
            }
        };
    }
    
    /// <summary>
    /// Creates production-ready configuration
    /// </summary>
    /// <returns>Production options</returns>
    public static FhirSdkOptions CreateProduction()
    {
        return new FhirSdkOptions
        {
            DefaultVersion = FhirVersion.R5,
            SupportedVersions = new[] { FhirVersion.R5 },
            EnableAutoMigration = false, // Disabled for production safety
            Validation = new ValidationOptions
            {
                StrictValidation = true,
                ValidateProfiles = true,
                ValidateTerminology = true,
                FailOnWarnings = true
            },
            Performance = new PerformanceOptions
            {
                EnableCaching = true,
                CacheExpirationMinutes = 120,
                MaxCacheSizeMB = 200,
                EnableParallelProcessing = true,
                MaxDegreeOfParallelism = Environment.ProcessorCount
            }
        };
    }
    
    /// <summary>
    /// Creates configuration ready for R6 migration
    /// </summary>
    /// <returns>R6-ready options</returns>
    public static FhirSdkOptions CreateR6Ready()
    {
        var options = CreateDefault();
        options.SupportedVersions = new[] { FhirVersion.R5, FhirVersion.R6 };
        options.EnableAutoMigration = true;
        
        // Add R6-specific configuration
        options.VersionConfigs["R6"] = new VersionSpecificOptions
        {
            Enabled = true,
            Migration = new MigrationOptions
            {
                EnableMigrationFrom = false, // R6 is newer
                EnableMigrationTo = true,
                BackupBeforeMigration = true
            }
        };
        
        return options;
    }
}
