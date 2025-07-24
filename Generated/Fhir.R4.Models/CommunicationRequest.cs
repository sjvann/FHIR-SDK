// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A request to convey information
/// </summary>
public class CommunicationRequest : SimpleDomainResource
{
    /// <summary>
    /// Unique identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Fulfills plan or proposal
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// Request(s) replaced by this request
    /// </summary>
    [JsonPropertyName("replaces")]
    public SimpleReference? Replaces { get; set; }

    /// <summary>
    /// Composite request this is part of
    /// </summary>
    [JsonPropertyName("groupIdentifier")]
    public SimpleIdentifier? GroupIdentifier { get; set; }

    /// <summary>
    /// draft | active | suspended | cancelled | completed | entered-in-error | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Reason for current status
    /// </summary>
    [JsonPropertyName("statusReason")]
    public SimpleCodeableConcept? StatusReason { get; set; }

    /// <summary>
    /// Message category
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// routine | urgent | asap | stat
    /// </summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>
    /// True if request is prohibiting action
    /// </summary>
    [JsonPropertyName("doNotPerform")]
    public bool? DoNotPerform { get; set; }

    /// <summary>
    /// A channel of communication
    /// </summary>
    [JsonPropertyName("medium")]
    public SimpleCodeableConcept? Medium { get; set; }

    /// <summary>
    /// Focus of message
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Resources that pertain to this communication request
    /// </summary>
    [JsonPropertyName("about")]
    public SimpleReference? About { get; set; }

    /// <summary>
    /// Encounter created as part of
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// Message payload
    /// </summary>
    [JsonPropertyName("payload")]
    public SimpleBackboneElement? Payload { get; set; }

    /// <summary>
    /// When scheduled
    /// </summary>
    [JsonPropertyName("occurrenceDateTime")]
    public DateTime? OccurrenceDateTime { get; set; }

    /// <summary>
    /// When scheduled
    /// </summary>
    [JsonPropertyName("occurrencePeriod")]
    public SimplePeriod? OccurrencePeriod { get; set; }

    /// <summary>
    /// When request transitioned to being actionable
    /// </summary>
    [JsonPropertyName("authoredOn")]
    public DateTime? AuthoredOn { get; set; }

    /// <summary>
    /// Who/what is requesting service
    /// </summary>
    [JsonPropertyName("requester")]
    public SimpleReference? Requester { get; set; }

    /// <summary>
    /// Message recipient
    /// </summary>
    [JsonPropertyName("recipient")]
    public SimpleReference? Recipient { get; set; }

    /// <summary>
    /// Message sender
    /// </summary>
    [JsonPropertyName("sender")]
    public SimpleReference? Sender { get; set; }

    /// <summary>
    /// Why is communication needed
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Why is communication needed
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public SimpleReference? ReasonReference { get; set; }

    /// <summary>
    /// Comments made about communication request
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "CommunicationRequest";

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
