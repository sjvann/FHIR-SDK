using Fhir.Support.Interfaces;
using System.Text.Json.Serialization;

namespace Fhir.Support.Base;

/// <summary>
/// 所有 FHIR 資源的基礎抽象類別，實作了 <see cref="IResource"/> 介面。
/// </summary>
public abstract class Resource : IResource
{
    /// <inheritdoc/>
    public string? Id { get; set; }

    /// <inheritdoc/>
    public IMeta? Meta { get; set; }

    /// <inheritdoc/>
    public string? ImplicitRules { get; set; }

    /// <inheritdoc/>
    public string? Language { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("resourceType")]
    public virtual string ResourceType => GetType().Name;
} 