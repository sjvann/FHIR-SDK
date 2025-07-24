// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Represents a request for a patient to employ a medical device
/// </summary>
public class DeviceRequest : SimpleDomainResource
{
    /// <summary>
    /// External request identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Instantiates FHIR protocol or definition
    /// </summary>
    [JsonPropertyName("instantiatesCanonical")]
    public string? InstantiatesCanonical { get; set; }

    /// <summary>
    /// Instantiates external protocol or definition
    /// </summary>
    [JsonPropertyName("instantiatesUri")]
    public string? InstantiatesUri { get; set; }

    /// <summary>
    /// What request fulfills
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// What request replaces
    /// </summary>
    [JsonPropertyName("priorRequest")]
    public SimpleReference? PriorRequest { get; set; }

    /// <summary>
    /// Composite request this is part of
    /// </summary>
    [JsonPropertyName("groupIdentifier")]
    public SimpleIdentifier? GroupIdentifier { get; set; }

    /// <summary>
    /// draft | active | on-hold | revoked | completed | entered-in-error | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// proposal | plan | original-order | reflex-order | filler-order | instance-order | option
    /// </summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>
    /// routine | urgent | asap | stat
    /// </summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>
    /// Device requested
    /// </summary>
    [JsonPropertyName("codeReference")]
    public SimpleReference? CodeReference { get; set; }

    /// <summary>
    /// Device requested
    /// </summary>
    [JsonPropertyName("codeCodeableConcept")]
    public SimpleCodeableConcept? CodeCodeableConcept { get; set; }

    /// <summary>
    /// Device details
    /// </summary>
    [JsonPropertyName("parameter")]
    public SimpleBackboneElement? Parameter { get; set; }

    /// <summary>
    /// Focus of request
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Encounter motivating request
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// Desired time or schedule for use
    /// </summary>
    [JsonPropertyName("occurrenceDateTime")]
    public DateTime? OccurrenceDateTime { get; set; }

    /// <summary>
    /// Desired time or schedule for use
    /// </summary>
    [JsonPropertyName("occurrencePeriod")]
    public SimplePeriod? OccurrencePeriod { get; set; }

    /// <summary>
    /// Desired time or schedule for use
    /// </summary>
    [JsonPropertyName("occurrenceTiming")]
    public string? OccurrenceTiming { get; set; }

    /// <summary>
    /// When recorded
    /// </summary>
    [JsonPropertyName("authoredOn")]
    public DateTime? AuthoredOn { get; set; }

    /// <summary>
    /// Who/what is requesting diagnostics
    /// </summary>
    [JsonPropertyName("requester")]
    public SimpleReference? Requester { get; set; }

    /// <summary>
    /// Requested Filler
    /// </summary>
    [JsonPropertyName("performerType")]
    public SimpleCodeableConcept? PerformerType { get; set; }

    /// <summary>
    /// Requested Filler
    /// </summary>
    [JsonPropertyName("performer")]
    public SimpleReference? Performer { get; set; }

    /// <summary>
    /// Coded reason for request
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Coded reason for request
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public SimpleReference? ReasonReference { get; set; }

    /// <summary>
    /// Associated insurance coverage
    /// </summary>
    [JsonPropertyName("insurance")]
    public SimpleReference? Insurance { get; set; }

    /// <summary>
    /// Additional clinical information
    /// </summary>
    [JsonPropertyName("supportingInfo")]
    public SimpleReference? SupportingInfo { get; set; }

    /// <summary>
    /// Notes or comments
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// Request provenance
    /// </summary>
    [JsonPropertyName("relevantHistory")]
    public SimpleReference? RelevantHistory { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "DeviceRequest";

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
