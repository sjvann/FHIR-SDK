// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A task to be performed
/// </summary>
public class Task : SimpleDomainResource
{
    /// <summary>
    /// Task Instance Identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Formal definition of task
    /// </summary>
    [JsonPropertyName("instantiatesCanonical")]
    public string? InstantiatesCanonical { get; set; }

    /// <summary>
    /// Formal definition of task
    /// </summary>
    [JsonPropertyName("instantiatesUri")]
    public string? InstantiatesUri { get; set; }

    /// <summary>
    /// Request fulfilled by this task
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// Requisition or grouper id
    /// </summary>
    [JsonPropertyName("groupIdentifier")]
    public SimpleIdentifier? GroupIdentifier { get; set; }

    /// <summary>
    /// Composite task
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// draft | requested | received | accepted | +
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Reason for current status
    /// </summary>
    [JsonPropertyName("statusReason")]
    public SimpleCodeableConcept? StatusReason { get; set; }

    /// <summary>
    /// E.g. Specimen collected, vials created
    /// </summary>
    [JsonPropertyName("businessStatus")]
    public SimpleCodeableConcept? BusinessStatus { get; set; }

    /// <summary>
    /// unknown | proposal | plan | order | original-order | reflex-order | filler-order | instance-order | option
    /// </summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>
    /// routine | urgent | asap | stat
    /// </summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>
    /// Task Type
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// Human-readable explanation of task
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// What task is acting on
    /// </summary>
    [JsonPropertyName("focus")]
    public SimpleReference? Focus { get; set; }

    /// <summary>
    /// Beneficiary of the Task
    /// </summary>
    [JsonPropertyName("for")]
    public SimpleReference? For { get; set; }

    /// <summary>
    /// Healthcare event during which this task originated
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// Start and end time of execution
    /// </summary>
    [JsonPropertyName("executionPeriod")]
    public SimplePeriod? ExecutionPeriod { get; set; }

    /// <summary>
    /// Task Creation Date
    /// </summary>
    [JsonPropertyName("authoredOn")]
    public DateTime? AuthoredOn { get; set; }

    /// <summary>
    /// Task Last Modified Date
    /// </summary>
    [JsonPropertyName("lastModified")]
    public DateTime? LastModified { get; set; }

    /// <summary>
    /// Who is asking for task to be done
    /// </summary>
    [JsonPropertyName("requester")]
    public SimpleReference? Requester { get; set; }

    /// <summary>
    /// Requested performer
    /// </summary>
    [JsonPropertyName("performerType")]
    public SimpleCodeableConcept? PerformerType { get; set; }

    /// <summary>
    /// Responsible individual
    /// </summary>
    [JsonPropertyName("owner")]
    public SimpleReference? Owner { get; set; }

    /// <summary>
    /// Where task occurs
    /// </summary>
    [JsonPropertyName("location")]
    public SimpleReference? Location { get; set; }

    /// <summary>
    /// Why task is needed
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Why task is needed
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public SimpleReference? ReasonReference { get; set; }

    /// <summary>
    /// Associated insurance coverage
    /// </summary>
    [JsonPropertyName("insurance")]
    public SimpleReference? Insurance { get; set; }

    /// <summary>
    /// Comments made about the task
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// Key events in history of the Task
    /// </summary>
    [JsonPropertyName("relevantHistory")]
    public SimpleReference? RelevantHistory { get; set; }

    /// <summary>
    /// Constraints on fulfillment tasks
    /// </summary>
    [JsonPropertyName("restriction")]
    public SimpleBackboneElement? Restriction { get; set; }

    /// <summary>
    /// Information used to perform task
    /// </summary>
    [JsonPropertyName("input")]
    public SimpleBackboneElement? Input { get; set; }

    /// <summary>
    /// Information produced as part of task
    /// </summary>
    [JsonPropertyName("output")]
    public SimpleBackboneElement? Output { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Task";

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
