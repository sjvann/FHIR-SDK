using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// 所有 FHIR 元素的基礎抽象類別，實作了 <see cref="IElement"/> 介面。
/// </summary>
public abstract class Element : IElement
{
    /// <inheritdoc/>
    public string? ElementId { get; set; }

    /// <inheritdoc/>
    public List<IExtension>? Extension { get; set; }
} 