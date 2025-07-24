// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// An occurrence of information being transmitted
/// </summary>
public class Communication : SimpleDomainResource
{
    /// <summary>
    /// Unique identifier
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
    /// Request fulfilled by this communication
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// Part of this action
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// Reply to
    /// </summary>
    [JsonPropertyName("inResponseTo")]
    public SimpleReference? InResponseTo { get; set; }

    /// <summary>
    /// preparation | in-progress | not-done | on-hold | stopped | completed | entered-in-error | unknown
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
    /// Description of the purpose/content
    /// </summary>
    [JsonPropertyName("topic")]
    public SimpleCodeableConcept? Topic { get; set; }

    /// <summary>
    /// Resources that pertain to this communication
    /// </summary>
    [JsonPropertyName("about")]
    public SimpleReference? About { get; set; }

    /// <summary>
    /// Encounter created as part of
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// When sent
    /// </summary>
    [JsonPropertyName("sent")]
    public DateTime? Sent { get; set; }

    /// <summary>
    /// When received
    /// </summary>
    [JsonPropertyName("received")]
    public DateTime? Received { get; set; }

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
    /// Indication for message
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Indication for message
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public SimpleReference? ReasonReference { get; set; }

    /// <summary>
    /// Message payload
    /// </summary>
    [JsonPropertyName("payload")]
    public SimpleBackboneElement? Payload { get; set; }

    /// <summary>
    /// Comments made about the communication
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Communication";

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
