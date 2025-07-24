// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A booking of a healthcare event among patient(s), practitioner(s), related person(s) and/or device(s) for a specific date/time
/// </summary>
public class Appointment : SimpleDomainResource
{
    /// <summary>
    /// External Ids for this item
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// proposed | pending | booked | arrived | fulfilled | cancelled | noshow | entered-in-error | checked-in | waitlist
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The coded reason for the appointment being cancelled
    /// </summary>
    [JsonPropertyName("cancelationReason")]
    public SimpleCodeableConcept? CancelationReason { get; set; }

    /// <summary>
    /// A broad categorization of the service that is to be performed during this appointment
    /// </summary>
    [JsonPropertyName("serviceCategory")]
    public SimpleCodeableConcept? ServiceCategory { get; set; }

    /// <summary>
    /// The specific service that is to be performed during this appointment
    /// </summary>
    [JsonPropertyName("serviceType")]
    public SimpleCodeableConcept? ServiceType { get; set; }

    /// <summary>
    /// The specialty of a practitioner that would be required to perform the service requested in this appointment
    /// </summary>
    [JsonPropertyName("specialty")]
    public SimpleCodeableConcept? Specialty { get; set; }

    /// <summary>
    /// The style of appointment or patient that has been booked in the slot
    /// </summary>
    [JsonPropertyName("appointmentType")]
    public SimpleCodeableConcept? AppointmentType { get; set; }

    /// <summary>
    /// Coded reason this appointment is scheduled
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Reason the appointment takes place
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public SimpleReference? ReasonReference { get; set; }

    /// <summary>
    /// Used to make informed decisions if needing to re-prioritize
    /// </summary>
    [JsonPropertyName("priority")]
    public uint? Priority { get; set; }

    /// <summary>
    /// Shown on a subject line in a meeting request, or appointment list
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Additional information to support the appointment
    /// </summary>
    [JsonPropertyName("supportingInformation")]
    public SimpleReference? SupportingInformation { get; set; }

    /// <summary>
    /// Date/Time that the appointment is to take place
    /// </summary>
    [JsonPropertyName("start")]
    public DateTime? Start { get; set; }

    /// <summary>
    /// Date/Time that the appointment is to conclude
    /// </summary>
    [JsonPropertyName("end")]
    public DateTime? End { get; set; }

    /// <summary>
    /// Number of minutes that the appointment is to take
    /// </summary>
    [JsonPropertyName("minutesDuration")]
    public uint? MinutesDuration { get; set; }

    /// <summary>
    /// The slots that this appointment is filling
    /// </summary>
    [JsonPropertyName("slot")]
    public SimpleReference? Slot { get; set; }

    /// <summary>
    /// The date that this appointment was initially created
    /// </summary>
    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Additional comments about the appointment
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// Patient or consumer-oriented instructions
    /// </summary>
    [JsonPropertyName("patientInstruction")]
    public string? PatientInstruction { get; set; }

    /// <summary>
    /// The service request this appointment is allocated to assess
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// List of participants involved in the appointment
    /// </summary>
    [JsonPropertyName("participant")]
    public SimpleBackboneElement? Participant { get; set; }

    /// <summary>
    /// A set of date ranges (potentially including a start and/or an end) that the appointment is preferred to be scheduled within
    /// </summary>
    [JsonPropertyName("requestedPeriod")]
    public SimplePeriod? RequestedPeriod { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Appointment";

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
