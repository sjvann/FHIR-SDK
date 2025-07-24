namespace Fhir.Support.Interfaces;

/// <summary>
/// 代表一個 FHIR BackboneElement，用於 Resource 中的群組元素
/// </summary>
public interface IBackboneElement : IElement
{
    /// <summary>
    /// 修飾符擴展
    /// </summary>
    List<IExtension>? ModifierExtension { get; set; }
} 