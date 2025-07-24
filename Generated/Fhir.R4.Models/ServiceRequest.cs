// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A record of a request for service such as diagnostic investigations, treatments, or operations to be performed
/// </summary>
public class ServiceRequest : SimpleDomainResource
{
    /// <summary>
    /// Identifiers assigned to this order
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// draft | active | on-hold | revoked | completed | entered-in-error | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// proposal | plan | order | original-order | reflex-order | filler-order | instance-order | option
    /// </summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>
    /// Classification of service
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// routine | urgent | asap | stat
    /// </summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>
    /// What is being requested/ordered
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// Individual or Entity the service is ordered for
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Encounter during which the request was created
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// When service should occur
    /// </summary>
    [JsonPropertyName("occurrenceDateTime")]
    public DateTime? OccurrenceDateTime { get; set; }

    /// <summary>
    /// Requested performer
    /// </summary>
    [JsonPropertyName("performer")]
    public SimpleReference? Performer { get; set; }

    /// <summary>
    /// Explanation/justification for service
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Comments about the request
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "ServiceRequest";

    /// <summary>
    /// 驗證此實例
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 自訂驗證邏輯
        // 子類別可以覆寫此方法來添加特定的驗證邏輯
    }
}
