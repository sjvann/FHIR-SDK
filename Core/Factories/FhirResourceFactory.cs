using Core.Contracts;
using Core.Versioning;
using Core.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection;
using System.Text.Json;

namespace Core.Factories;

/// <summary>
/// Factory for creating version-specific FHIR resources
/// </summary>
public interface IFhirResourceFactory : IVersionAware
{
    /// <summary>
    /// Creates a resource of the specified type
    /// </summary>
    /// <typeparam name="T">Resource type</typeparam>
    /// <returns>New resource instance</returns>
    T Create<T>() where T : class, IFhirResource, new();
    
    /// <summary>
    /// Creates a resource from JSON data
    /// </summary>
    /// <typeparam name="T">Resource type</typeparam>
    /// <param name="json">JSON data</param>
    /// <returns>Resource instance</returns>
    T CreateFromJson<T>(string json) where T : class, IFhirResource;
    
    /// <summary>
    /// Creates a resource dynamically by resource type name
    /// </summary>
    /// <param name="resourceType">Resource type name (e.g., "Patient")</param>
    /// <returns>Resource instance</returns>
    IFhirResource CreateByType(string resourceType);
    
    /// <summary>
    /// Creates a resource from JSON with automatic type detection
    /// </summary>
    /// <param name="json">JSON data</param>
    /// <returns>Resource instance</returns>
    IFhirResource CreateFromJsonAuto(string json);
}

/// <summary>
/// Implementation of versioned FHIR resource factory
/// </summary>
public class VersionedFhirResourceFactory : IFhirResourceFactory
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<VersionedFhirResourceFactory> _logger;
    private readonly FhirVersion _fhirVersion;
    private readonly Dictionary<string, Type> _resourceTypeCache = new();
    
    public FhirVersion SupportedVersion => _fhirVersion;
    
    public VersionedFhirResourceFactory(
        IServiceProvider serviceProvider,
        ILogger<VersionedFhirResourceFactory> logger,
        FhirVersion fhirVersion = FhirVersion.R5)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
        _fhirVersion = fhirVersion;
        InitializeResourceTypeCache();
    }
    
    public bool CanHandle(FhirVersion version) => SupportedVersion.IsCompatibleWith(version);
    
    public T Create<T>() where T : class, IFhirResource, new()
    {
        _logger.LogDebug("Creating resource of type {ResourceType} for FHIR version {Version}", 
            typeof(T).Name, _fhirVersion);
            
        var resource = new T();
        
        // Validate that the resource supports the current FHIR version
        if (!resource.CanHandle(_fhirVersion))
        {
            throw new FhirVersionNotSupportedException(_fhirVersion, new[] { resource.SupportedVersion });
        }
        
        return resource;
    }
    
    public T CreateFromJson<T>(string json) where T : class, IFhirResource
    {
        try
        {
            _logger.LogDebug("Creating resource of type {ResourceType} from JSON for FHIR version {Version}", 
                typeof(T).Name, _fhirVersion);
                
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            
            var resource = JsonSerializer.Deserialize<T>(json, options);
            if (resource == null)
            {
                throw new FhirSerializationException(
                    $"Failed to deserialize JSON to {typeof(T).Name}", json, _fhirVersion);
            }
            
            // Validate version compatibility
            if (!resource.CanHandle(_fhirVersion))
            {
                throw new FhirVersionNotSupportedException(_fhirVersion, new[] { resource.SupportedVersion });
            }
            
            return resource;
        }
        catch (JsonException ex)
        {
            throw new FhirSerializationException(
                $"Invalid JSON format for {typeof(T).Name}: {ex.Message}", json, _fhirVersion);
        }
    }
    
    public IFhirResource CreateByType(string resourceType)
    {
        _logger.LogDebug("Creating resource of type {ResourceType} for FHIR version {Version}", 
            resourceType, _fhirVersion);
            
        if (!_resourceTypeCache.TryGetValue(resourceType, out var type))
        {
            throw new ArgumentException($"Unknown resource type: {resourceType}", nameof(resourceType));
        }
        
        var resource = Activator.CreateInstance(type) as IFhirResource;
        if (resource == null)
        {
            throw new InvalidOperationException($"Failed to create instance of {resourceType}");
        }
        
        // Validate version compatibility
        if (!resource.CanHandle(_fhirVersion))
        {
            throw new FhirVersionNotSupportedException(_fhirVersion, new[] { resource.SupportedVersion });
        }
        
        return resource;
    }
    
    public IFhirResource CreateFromJsonAuto(string json)
    {
        try
        {
            using var document = JsonDocument.Parse(json);
            var root = document.RootElement;
            
            if (!root.TryGetProperty("resourceType", out var resourceTypeElement))
            {
                throw new FhirSerializationException(
                    "JSON does not contain 'resourceType' property", json, _fhirVersion);
            }
            
            var resourceType = resourceTypeElement.GetString();
            if (string.IsNullOrEmpty(resourceType))
            {
                throw new FhirSerializationException(
                    "Resource type is null or empty", json, _fhirVersion);
            }
            
            _logger.LogDebug("Auto-creating resource of type {ResourceType} from JSON for FHIR version {Version}", 
                resourceType, _fhirVersion);
            
            if (!_resourceTypeCache.TryGetValue(resourceType, out var type))
            {
                throw new ArgumentException($"Unknown resource type: {resourceType}");
            }
            
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            
            var resource = JsonSerializer.Deserialize(json, type, options) as IFhirResource;
            if (resource == null)
            {
                throw new FhirSerializationException(
                    $"Failed to deserialize JSON to {resourceType}", json, _fhirVersion);
            }
            
            // Validate version compatibility
            if (!resource.CanHandle(_fhirVersion))
            {
                throw new FhirVersionNotSupportedException(_fhirVersion, new[] { resource.SupportedVersion });
            }
            
            return resource;
        }
        catch (JsonException ex)
        {
            throw new FhirSerializationException(
                $"Invalid JSON format: {ex.Message}", json, _fhirVersion);
        }
    }
    
    private void InitializeResourceTypeCache()
    {
        _logger.LogInformation("Initializing resource type cache for FHIR version {Version}", _fhirVersion);
        
        // Find all assemblies that contain FHIR resources for this version
        var assemblies = AppDomain.CurrentDomain.GetAssemblies()
            .Where(a => a.GetName().Name?.Contains("ResourceTypeServices") == true ||
                       a.GetName().Name?.Contains("Resources") == true);
        
        foreach (var assembly in assemblies)
        {
            try
            {
                var resourceTypes = assembly.GetTypes()
                    .Where(t => t.IsClass && !t.IsAbstract && 
                               typeof(IFhirResource).IsAssignableFrom(t));
                
                foreach (var type in resourceTypes)
                {
                    // Get the resource type name from the class name or attribute
                    var resourceTypeName = GetResourceTypeName(type);
                    if (!string.IsNullOrEmpty(resourceTypeName))
                    {
                        _resourceTypeCache[resourceTypeName] = type;
                        _logger.LogDebug("Registered resource type {ResourceType} -> {TypeName}", 
                            resourceTypeName, type.FullName);
                    }
                }
            }
            catch (ReflectionTypeLoadException ex)
            {
                _logger.LogWarning(ex, "Failed to load types from assembly {AssemblyName}", assembly.FullName);
            }
        }
        
        _logger.LogInformation("Initialized resource type cache with {Count} resource types for FHIR version {Version}", 
            _resourceTypeCache.Count, _fhirVersion);
    }
    
    private string? GetResourceTypeName(Type type)
    {
        // First, try to get from ResourceType attribute if it exists
        var resourceTypeAttribute = type.GetCustomAttribute<ResourceTypeAttribute>();
        if (resourceTypeAttribute != null)
        {
            return resourceTypeAttribute.ResourceType;
        }
        
        // Fall back to class name (assuming it matches the FHIR resource type)
        return type.Name;
    }
}

/// <summary>
/// Attribute to specify the FHIR resource type name for a class
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class ResourceTypeAttribute : Attribute
{
    public string ResourceType { get; }
    
    public ResourceTypeAttribute(string resourceType)
    {
        ResourceType = resourceType;
    }
}

/// <summary>
/// Factory that creates version-specific resource factories
/// </summary>
public class FhirResourceFactoryProvider : IVersionedServiceFactory<IFhirResourceFactory>
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<FhirResourceFactoryProvider> _logger;
    private readonly Dictionary<FhirVersion, IFhirResourceFactory> _factoryCache = new();
    
    public FhirResourceFactoryProvider(
        IServiceProvider serviceProvider,
        ILogger<FhirResourceFactoryProvider> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }
    
    public IFhirResourceFactory CreateForVersion(FhirVersion version)
    {
        if (_factoryCache.TryGetValue(version, out var cachedFactory))
        {
            return cachedFactory;
        }
        
        _logger.LogInformation("Creating resource factory for FHIR version {Version}", version);
        
        var factory = ActivatorUtilities.CreateInstance<VersionedFhirResourceFactory>(
            _serviceProvider, version);
            
        _factoryCache[version] = factory;
        return factory;
    }
    
    public FhirVersion[] GetSupportedVersions()
    {
        return Enum.GetValues<FhirVersion>();
    }
}
