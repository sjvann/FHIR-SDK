using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.DataTypes;
using Fhir.R4.Models.DataTypes.ComplexTypes;

namespace Fhir.R4.Models.Base;

/// <summary>
/// 代表一個 FHIR 資源的基礎介面
/// 所有 FHIR Resource 都應該實現此介面
/// </summary>
public interface IResource : IValidatableObject
{
    /// <summary>
    /// 資源的邏輯識別碼
    /// FHIR Path: Resource.id
    /// Cardinality: 0..1
    /// </summary>
    FhirId? Id { get; set; }

    /// <summary>
    /// 資源的 metadata
    /// FHIR Path: Resource.meta
    /// Cardinality: 0..1
    /// </summary>
    Meta? Meta { get; set; }

    /// <summary>
    /// 隱含規則的參考
    /// FHIR Path: Resource.implicitRules
    /// Cardinality: 0..1
    /// </summary>
    FhirUri? ImplicitRules { get; set; }

    /// <summary>
    /// 資源內容的基礎語言
    /// FHIR Path: Resource.language
    /// Cardinality: 0..1
    /// </summary>
    FhirCode? Language { get; set; }

    /// <summary>
    /// 資源類型名稱
    /// </summary>
    FhirCode ResourceType { get; }

    /// <summary>
    /// 轉換為 JSON 字串
    /// </summary>
    /// <returns>JSON 表示</returns>
    string ToJson();

    /// <summary>
    /// 從 JSON 字串解析
    /// </summary>
    /// <param name="json">JSON 字串</param>
    void FromJson(string json);

    /// <summary>
    /// 取得資源的摘要資訊
    /// </summary>
    /// <returns>資源摘要</returns>
    string GetSummary();

    /// <summary>
    /// 複製資源
    /// </summary>
    /// <returns>資源的副本</returns>
    IResource Clone();
}

/// <summary>
/// 代表一個 FHIR Domain Resource 的介面
/// 繼承自 IResource，添加了 Domain Resource 特有的屬性
/// </summary>
public interface IDomainResource : IResource
{
    /// <summary>
    /// 人類可讀的敘述
    /// FHIR Path: DomainResource.text
    /// Cardinality: 0..1
    /// </summary>
    Narrative? Text { get; set; }

    /// <summary>
    /// 包含的資源
    /// FHIR Path: DomainResource.contained
    /// Cardinality: 0..*
    /// </summary>
    List<IResource>? Contained { get; set; }

    /// <summary>
    /// 擴展
    /// FHIR Path: DomainResource.extension
    /// Cardinality: 0..*
    /// </summary>
    List<Extension>? Extension { get; set; }

    /// <summary>
    /// 修飾符擴展
    /// FHIR Path: DomainResource.modifierExtension
    /// Cardinality: 0..*
    /// </summary>
    List<Extension>? ModifierExtension { get; set; }
}
