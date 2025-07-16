using Core.Versioning;

namespace Core.Contracts;

/// <summary>
/// Base interface for version-aware FHIR components
/// </summary>
public interface IVersionAware
{
    /// <summary>
    /// The FHIR version this component supports
    /// </summary>
    FhirVersion SupportedVersion { get; }
    
    /// <summary>
    /// Checks if this component can handle the specified version
    /// </summary>
    /// <param name="version">Version to check</param>
    /// <returns>True if can handle</returns>
    bool CanHandle(FhirVersion version);
}

/// <summary>
/// Interface for components that can migrate between FHIR versions
/// </summary>
public interface IVersionMigrator
{
    /// <summary>
    /// Source version this migrator works from
    /// </summary>
    FhirVersion FromVersion { get; }
    
    /// <summary>
    /// Target version this migrator works to
    /// </summary>
    FhirVersion ToVersion { get; }
    
    /// <summary>
    /// Migrate data from source version to target version
    /// </summary>
    /// <param name="sourceData">Data in source version format</param>
    /// <returns>Data in target version format</returns>
    string Migrate(string sourceData);
}

/// <summary>
/// Factory interface for creating version-specific services
/// </summary>
public interface IVersionedServiceFactory<out T> where T : class
{
    /// <summary>
    /// Creates a service instance for the specified FHIR version
    /// </summary>
    /// <param name="version">FHIR version</param>
    /// <returns>Service instance</returns>
    T CreateForVersion(FhirVersion version);
    
    /// <summary>
    /// Gets all supported versions
    /// </summary>
    /// <returns>Array of supported versions</returns>
    FhirVersion[] GetSupportedVersions();
}
