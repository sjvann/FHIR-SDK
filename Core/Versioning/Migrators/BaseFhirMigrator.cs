using Core.Contracts;
using Core.Versioning;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Core.Versioning.Migrators;

/// <summary>
/// Base class for FHIR version migrators
/// </summary>
public abstract class BaseFhirMigrator : IVersionMigrator
{
    protected readonly ILogger Logger;
    
    public abstract FhirVersion FromVersion { get; }
    public abstract FhirVersion ToVersion { get; }
    
    protected BaseFhirMigrator(ILogger logger)
    {
        Logger = logger;
    }
    
    public virtual string Migrate(string sourceData)
    {
        try
        {
            Logger.LogInformation("Starting migration from {FromVersion} to {ToVersion}", FromVersion, ToVersion);
            
            var jsonDocument = JsonDocument.Parse(sourceData);
            var migratedDocument = MigrateInternal(jsonDocument);
            
            var result = JsonSerializer.Serialize(migratedDocument, new JsonSerializerOptions
            {
                WriteIndented = false
            });
            
            Logger.LogInformation("Successfully completed migration from {FromVersion} to {ToVersion}", FromVersion, ToVersion);
            return result;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to migrate from {FromVersion} to {ToVersion}", FromVersion, ToVersion);
            throw;
        }
    }
    
    /// <summary>
    /// Override this method to implement specific migration logic
    /// </summary>
    /// <param name="source">Source JSON document</param>
    /// <returns>Migrated JSON document</returns>
    protected abstract JsonDocument MigrateInternal(JsonDocument source);
    
    /// <summary>
    /// Helper method to get a property value safely
    /// </summary>
    protected string? GetPropertyValue(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) ? property.GetString() : null;
    }
    
    /// <summary>
    /// Helper method to check if a property exists
    /// </summary>
    protected bool HasProperty(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out _);
    }
}

/// <summary>
/// Migrator from FHIR R5 to R6 (placeholder for future implementation)
/// </summary>
public class R5ToR6Migrator : BaseFhirMigrator
{
    public override FhirVersion FromVersion => FhirVersion.R5;
    public override FhirVersion ToVersion => FhirVersion.R6;
    
    public R5ToR6Migrator(ILogger<R5ToR6Migrator> logger) : base(logger) { }
    
    protected override JsonDocument MigrateInternal(JsonDocument source)
    {
        // Placeholder implementation - will be updated when R6 is released
        Logger.LogWarning("R6 migration is not yet implemented - R6 specification is not final");
        
        var root = source.RootElement;
        var resourceType = GetPropertyValue(root, "resourceType");
        
        Logger.LogInformation("Preparing {ResourceType} for future R6 migration", resourceType);
        
        // For now, just return the source with a migration marker
        using var stream = new MemoryStream();
        using var writer = new Utf8JsonWriter(stream);
        
        writer.WriteStartObject();
        
        // Copy all existing properties
        foreach (var property in root.EnumerateObject())
        {
            property.WriteTo(writer);
        }
        
        // Add migration metadata
        writer.WriteStartObject("_migrationInfo");
        writer.WriteString("fromVersion", FromVersion.GetVersionString());
        writer.WriteString("toVersion", ToVersion.GetVersionString());
        writer.WriteString("migrationDate", DateTimeOffset.UtcNow.ToString("O"));
        writer.WriteString("status", "prepared");
        writer.WriteEndObject();
        
        writer.WriteEndObject();
        writer.Flush();
        
        return JsonDocument.Parse(stream.ToArray());
    }
}

/// <summary>
/// Identity migrator for same-version "migrations"
/// </summary>
public class IdentityMigrator : BaseFhirMigrator
{
    private readonly FhirVersion _version;
    
    public override FhirVersion FromVersion => _version;
    public override FhirVersion ToVersion => _version;
    
    public IdentityMigrator(FhirVersion version, ILogger<IdentityMigrator> logger) : base(logger)
    {
        _version = version;
    }
    
    protected override JsonDocument MigrateInternal(JsonDocument source)
    {
        // No migration needed for same version
        return source;
    }
}

/// <summary>
/// Registry for managing migration strategies
/// </summary>
public class MigrationStrategyRegistry
{
    private readonly Dictionary<(FhirVersion from, FhirVersion to), Func<JsonDocument, JsonDocument>> _strategies = new();
    private readonly ILogger<MigrationStrategyRegistry> _logger;
    
    public MigrationStrategyRegistry(ILogger<MigrationStrategyRegistry> logger)
    {
        _logger = logger;
        RegisterDefaultStrategies();
    }
    
    /// <summary>
    /// Registers a migration strategy
    /// </summary>
    /// <param name="from">Source version</param>
    /// <param name="to">Target version</param>
    /// <param name="strategy">Migration function</param>
    public void RegisterStrategy(FhirVersion from, FhirVersion to, Func<JsonDocument, JsonDocument> strategy)
    {
        var key = (from, to);
        _strategies[key] = strategy;
        _logger.LogInformation("Registered migration strategy from {FromVersion} to {ToVersion}", from, to);
    }
    
    /// <summary>
    /// Gets a migration strategy
    /// </summary>
    /// <param name="from">Source version</param>
    /// <param name="to">Target version</param>
    /// <returns>Migration function or null if not found</returns>
    public Func<JsonDocument, JsonDocument>? GetStrategy(FhirVersion from, FhirVersion to)
    {
        return _strategies.TryGetValue((from, to), out var strategy) ? strategy : null;
    }
    
    private void RegisterDefaultStrategies()
    {
        // Register identity strategies for same-version migrations
        foreach (FhirVersion version in Enum.GetValues<FhirVersion>())
        {
            RegisterStrategy(version, version, doc => doc);
        }
        
        // Register R5 to R6 strategy (placeholder)
        RegisterStrategy(FhirVersion.R5, FhirVersion.R6, PrepareForR6Migration);
    }
    
    private JsonDocument PrepareForR6Migration(JsonDocument source)
    {
        _logger.LogInformation("Preparing resource for future R6 migration");
        // Implementation will be updated when R6 specification is finalized
        return source;
    }
}
