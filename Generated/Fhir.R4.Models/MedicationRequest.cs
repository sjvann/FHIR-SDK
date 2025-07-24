// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// An order or request for both supply of the medication and the instructions for administration of the medication to a patient
/// </summary>
public class MedicationRequest : SimpleDomainResource
{
    /// <summary>
    /// External ids for this request
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | on-hold | cancelled | completed | entered-in-error | stopped | draft | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Reason for current status
    /// </summary>
    [JsonPropertyName("statusReason")]
    public SimpleCodeableConcept? StatusReason { get; set; }

    /// <summary>
    /// proposal | plan | order | original-order | reflex-order | filler-order | instance-order | option
    /// </summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>
    /// Type of medication usage
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// routine | urgent | asap | stat
    /// </summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>
    /// True if patient should not take medication
    /// </summary>
    [JsonPropertyName("doNotPerform")]
    public bool? DoNotPerform { get; set; }

    /// <summary>
    /// Reported rather than primary record
    /// </summary>
    [JsonPropertyName("reportedBoolean")]
    public bool? ReportedBoolean { get; set; }

    /// <summary>
    /// Reported rather than primary record
    /// </summary>
    [JsonPropertyName("reportedReference")]
    public SimpleReference? ReportedReference { get; set; }

    /// <summary>
    /// Medication to be taken
    /// </summary>
    [JsonPropertyName("medicationCodeableConcept")]
    public SimpleCodeableConcept? MedicationCodeableConcept { get; set; }

    /// <summary>
    /// Medication to be taken
    /// </summary>
    [JsonPropertyName("medicationReference")]
    public SimpleReference? MedicationReference { get; set; }

    /// <summary>
    /// Who or group medication request is for
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Created during encounter/admission/stay
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// Information to support ordering of the medication
    /// </summary>
    [JsonPropertyName("supportingInformation")]
    public SimpleReference? SupportingInformation { get; set; }

    /// <summary>
    /// When request was initially authored
    /// </summary>
    [JsonPropertyName("authoredOn")]
    public DateTime? AuthoredOn { get; set; }

    /// <summary>
    /// Who/What requested the Request
    /// </summary>
    [JsonPropertyName("requester")]
    public SimpleReference? Requester { get; set; }

    /// <summary>
    /// Intended performer of administration
    /// </summary>
    [JsonPropertyName("performer")]
    public SimpleReference? Performer { get; set; }

    /// <summary>
    /// Desired kind of performer of the medication administration
    /// </summary>
    [JsonPropertyName("performerType")]
    public SimpleCodeableConcept? PerformerType { get; set; }

    /// <summary>
    /// Person who entered the request
    /// </summary>
    [JsonPropertyName("recorder")]
    public SimpleReference? Recorder { get; set; }

    /// <summary>
    /// Reason or indication for ordering or not ordering the medication
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Condition or observation that supports why the prescription is being written
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public SimpleReference? ReasonReference { get; set; }

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
    /// Composite request this is part of
    /// </summary>
    [JsonPropertyName("groupIdentifier")]
    public SimpleIdentifier? GroupIdentifier { get; set; }

    /// <summary>
    /// Overall pattern of medication administration
    /// </summary>
    [JsonPropertyName("courseOfTherapyType")]
    public SimpleCodeableConcept? CourseOfTherapyType { get; set; }

    /// <summary>
    /// Associated insurance coverage
    /// </summary>
    [JsonPropertyName("insurance")]
    public SimpleReference? Insurance { get; set; }

    /// <summary>
    /// Information about the prescription
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// How the medication should be taken
    /// </summary>
    [JsonPropertyName("dosageInstruction")]
    public string? DosageInstruction { get; set; }

    /// <summary>
    /// Medication supply authorization
    /// </summary>
    [JsonPropertyName("dispenseRequest")]
    public SimpleBackboneElement? DispenseRequest { get; set; }

    /// <summary>
    /// Any restrictions on medication substitution
    /// </summary>
    [JsonPropertyName("substitution")]
    public SimpleBackboneElement? Substitution { get; set; }

    /// <summary>
    /// An order/prescription that is being replaced
    /// </summary>
    [JsonPropertyName("priorPrescription")]
    public SimpleReference? PriorPrescription { get; set; }

    /// <summary>
    /// Clinical Issue with action
    /// </summary>
    [JsonPropertyName("detectedIssue")]
    public SimpleReference? DetectedIssue { get; set; }

    /// <summary>
    /// A list of events of interest in the lifecycle
    /// </summary>
    [JsonPropertyName("eventHistory")]
    public SimpleReference? EventHistory { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "MedicationRequest";

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
