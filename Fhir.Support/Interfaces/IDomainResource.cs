namespace Fhir.Support.Interfaces;

/// <summary>
/// 代表一個 FHIR DomainResource
/// </summary>
public interface IDomainResource : IResource
{
    /// <summary>
    /// 敘述文字
    /// </summary>
    INarrative? Text { get; set; }

    /// <summary>
    /// 包含的資源
    /// </summary>
    List<IResource>? Contained { get; set; }

    /// <summary>
    /// 擴展
    /// </summary>
    List<IExtension>? Extension { get; set; }

    /// <summary>
    /// 修飾符擴展
    /// </summary>
    List<IExtension>? ModifierExtension { get; set; }
} 