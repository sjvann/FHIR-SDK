using System.Text.Json;
using Core.Versioning;

namespace Core.Exceptions;

/// <summary>
/// Base exception for FHIR-related errors
/// </summary>
public abstract class FhirException : Exception
{
    /// <summary>
    /// FHIR version context where the error occurred
    /// </summary>
    public FhirVersion? FhirVersion { get; }
    
    /// <summary>
    /// Additional context information
    /// </summary>
    public Dictionary<string, object> Context { get; } = new();
    
    protected FhirException(string message, FhirVersion? fhirVersion = null) 
        : base(message)
    {
        FhirVersion = fhirVersion;
    }
    
    protected FhirException(string message, Exception innerException, FhirVersion? fhirVersion = null) 
        : base(message, innerException)
    {
        FhirVersion = fhirVersion;
    }
    
    /// <summary>
    /// Adds context information to the exception
    /// </summary>
    /// <param name="key">Context key</param>
    /// <param name="value">Context value</param>
    /// <returns>This exception for fluent chaining</returns>
    public FhirException WithContext(string key, object value)
    {
        Context[key] = value;
        return this;
    }
}

/// <summary>
/// Exception thrown when a FHIR resource validation fails
/// </summary>
public class FhirValidationException : FhirException
{
    /// <summary>
    /// FHIR OperationOutcome containing validation details
    /// </summary>
    public string? OperationOutcome { get; }
    
    public FhirValidationException(string message, string? operationOutcome = null, FhirVersion? fhirVersion = null) 
        : base(message, fhirVersion)
    {
        OperationOutcome = operationOutcome;
    }
    
    public FhirValidationException(string message, Exception innerException, string? operationOutcome = null, FhirVersion? fhirVersion = null) 
        : base(message, innerException, fhirVersion)
    {
        OperationOutcome = operationOutcome;
    }
}

/// <summary>
/// Exception thrown when a FHIR version is not supported
/// </summary>
public class FhirVersionNotSupportedException : FhirException
{
    /// <summary>
    /// The unsupported version
    /// </summary>
    public FhirVersion RequestedVersion { get; }
    
    /// <summary>
    /// Supported versions
    /// </summary>
    public FhirVersion[] SupportedVersions { get; }
    
    public FhirVersionNotSupportedException(
        FhirVersion requestedVersion, 
        FhirVersion[] supportedVersions) 
        : base($"FHIR version {requestedVersion} is not supported. Supported versions: {string.Join(", ", supportedVersions)}")
    {
        RequestedVersion = requestedVersion;
        SupportedVersions = supportedVersions;
    }
}

/// <summary>
/// Exception thrown when FHIR resource serialization/deserialization fails
/// </summary>
public class FhirSerializationException : FhirException
{
    /// <summary>
    /// The data that failed to serialize/deserialize
    /// </summary>
    public string? Data { get; }
    
    public FhirSerializationException(string message, string? data = null, FhirVersion? fhirVersion = null) 
        : base(message, fhirVersion)
    {
        Data = data;
    }
    
    public FhirSerializationException(string message, Exception innerException, string? data = null, FhirVersion? fhirVersion = null) 
        : base(message, innerException, fhirVersion)
    {
        Data = data;
    }
}

/// <summary>
/// Exception thrown when a FHIR resource is not found
/// </summary>
public class FhirResourceNotFoundException : FhirException
{
    /// <summary>
    /// Resource type that was not found
    /// </summary>
    public string? ResourceType { get; }
    
    /// <summary>
    /// Resource ID that was not found
    /// </summary>
    public string? ResourceId { get; }
    
    public FhirResourceNotFoundException(string? resourceType, string? resourceId, FhirVersion? fhirVersion = null) 
        : base($"FHIR resource {resourceType}/{resourceId} was not found", fhirVersion)
    {
        ResourceType = resourceType;
        ResourceId = resourceId;
    }
}
