using Microsoft.Extensions.Logging;
using Core.Versioning;
using Core.Contracts;

namespace Core.Versioning;

/// <summary>
/// Service for managing FHIR version compatibility and migration
/// </summary>
public class FhirVersionManager : IVersionAware
{
    private readonly ILogger<FhirVersionManager> _logger;
    private readonly IEnumerable<IVersionMigrator> _migrators;
    
    public FhirVersion SupportedVersion { get; }
    
    public FhirVersionManager(
        ILogger<FhirVersionManager> logger,
        IEnumerable<IVersionMigrator> migrators,
        FhirVersion supportedVersion = FhirVersion.R5)
    {
        _logger = logger;
        _migrators = migrators;
        SupportedVersion = supportedVersion;
    }
    
    public bool CanHandle(FhirVersion version)
    {
        return SupportedVersion.IsCompatibleWith(version);
    }
    
    /// <summary>
    /// Migrates data from one FHIR version to another
    /// </summary>
    /// <param name="data">Source data</param>
    /// <param name="fromVersion">Source version</param>
    /// <param name="toVersion">Target version</param>
    /// <returns>Migrated data</returns>
    public async Task<string> MigrateAsync(string data, FhirVersion fromVersion, FhirVersion toVersion)
    {
        if (fromVersion == toVersion)
        {
            _logger.LogDebug("No migration needed - versions are the same: {Version}", fromVersion);
            return data;
        }
        
        _logger.LogInformation("Migrating data from {FromVersion} to {ToVersion}", fromVersion, toVersion);
        
        var migrator = _migrators.FirstOrDefault(m => 
            m.FromVersion == fromVersion && m.ToVersion == toVersion);
            
        if (migrator == null)
        {
            // Try to find a migration path through intermediate versions
            var migrationPath = FindMigrationPath(fromVersion, toVersion);
            if (migrationPath == null)
            {
                throw new NotSupportedException(
                    $"No migration path found from {fromVersion} to {toVersion}");
            }
            
            return await ExecuteMigrationPath(data, migrationPath);
        }
        
        try
        {
            var result = migrator.Migrate(data);
            _logger.LogInformation("Successfully migrated data from {FromVersion} to {ToVersion}", 
                fromVersion, toVersion);
            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to migrate data from {FromVersion} to {ToVersion}", 
                fromVersion, toVersion);
            throw;
        }
    }
    
    private IVersionMigrator[]? FindMigrationPath(FhirVersion from, FhirVersion to)
    {
        // Simple implementation - can be enhanced with graph algorithms for complex paths
        var directMigrator = _migrators.FirstOrDefault(m => m.FromVersion == from && m.ToVersion == to);
        if (directMigrator != null)
        {
            return new[] { directMigrator };
        }
        
        // For now, only support direct migrations
        // Future enhancement: implement graph-based path finding
        return null;
    }
    
    private async Task<string> ExecuteMigrationPath(string data, IVersionMigrator[] path)
    {
        string currentData = data;
        foreach (var migrator in path)
        {
            currentData = migrator.Migrate(currentData);
            await Task.Delay(1); // Allow for cancellation
        }
        return currentData;
    }
}
