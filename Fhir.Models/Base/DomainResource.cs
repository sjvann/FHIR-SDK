using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// 代表一個 FHIR DomainResource，是包含敘述和內聯資源的資源的基底類別。
/// </summary>
public abstract class DomainResource : Resource, IElement
{
    /// <summary>
    /// 資源的文本敘述。
    /// </summary>
    public INarrative? Text { get; set; }

    /// <summary>
    /// 內聯資源。
    /// </summary>
    public List<Resource>? Contained { get; set; }

    // IElement 的實作，因為 DomainResource 也可以有擴展
    /// <inheritdoc/>
    public string? ElementId { get; set; }

    /// <inheritdoc/>
    public List<IExtension>? Extension { get; set; }
}

/// <summary>
/// 代表 FHIR 資源內部的複雜元素（非 PrimitiveType），作為巢狀結構的基礎。
/// </summary>
public abstract class BackboneElement : DataType
{
    // 此類別為階層結構的一部分，目前不需要額外的實作。
}

/// <summary>
/// 代表資源的敘述部分。
/// </summary>
public interface INarrative : IElement
{
    // Narrative 的具體屬性將在 Fhir.Core 中由程式碼產生器定義
} 