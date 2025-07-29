using System.ComponentModel.DataAnnotations;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Abstractions;

/// <summary>
/// Interface for FHIR Domain Resources
/// </summary>
/// <remarks>
/// 定義 FHIR 領域資源的介面，包含文字敘述、內含資源和擴展功能。
/// </remarks>
public interface IDomainResource : IResource
{
    /// <summary>
    /// Text summary of the resource, for human interpretation
    /// </summary>
    /// <returns>資源的文字摘要</returns>
    Narrative? Text { get; set; }

    /// <summary>
    /// Contained, inline Resources
    /// </summary>
    /// <returns>內含的內嵌資源列表</returns>
    IList<Resource>? Contained { get; set; }

    /// <summary>
    /// Additional information that is not part of the basic definition of the resource
    /// </summary>
    /// <returns>資源的擴展資訊</returns>
    IList<IExtension>? Extension { get; set; }

    /// <summary>
    /// Extensions that cannot be ignored
    /// </summary>
    /// <returns>不能忽略的修飾擴展</returns>
    IList<IExtension>? ModifierExtension { get; set; }
}

/// <summary>
/// Interface for FHIR Resources
/// </summary>
/// <remarks>
/// 定義 FHIR 資源的基本介面，包含 ID、元資料、語言等基本屬性。
/// </remarks>
public interface IResource
{
    /// <summary>
    /// Logical id of this artifact
    /// </summary>
    /// <returns>資源的邏輯 ID</returns>
    FhirId? Id { get; set; }

    /// <summary>
    /// Metadata about the resource
    /// </summary>
    /// <returns>資源的元資料</returns>
    Meta? Meta { get; set; }

    /// <summary>
    /// A set of rules under which this content was created
    /// </summary>
    /// <returns>內容建立時遵循的規則</returns>
    FhirUri? ImplicitRules { get; set; }

    /// <summary>
    /// Language of the resource content
    /// </summary>
    /// <returns>資源內容的語言</returns>
    FhirCode? Language { get; set; }

    /// <summary>
    /// The type of the resource
    /// </summary>
    /// <returns>資源類型</returns>
    string ResourceType { get; }
}
