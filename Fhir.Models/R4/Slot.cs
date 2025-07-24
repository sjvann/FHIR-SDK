// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A slot of time on a schedule that may be available for booking appointments
/// </summary>
public class Slot : SimpleDomainResource
{
    /// <summary>
    /// External Ids for this item
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// A broad categorization of the service
    /// </summary>
    [JsonPropertyName("serviceCategory")]
    public SimpleCodeableConcept? ServiceCategory { get; set; }

    /// <summary>
    /// The type of appointments that can be booked into this slot
    /// </summary>
    [JsonPropertyName("serviceType")]
    public SimpleCodeableConcept? ServiceType { get; set; }

    /// <summary>
    /// The specialty of a practitioner
    /// </summary>
    [JsonPropertyName("specialty")]
    public SimpleCodeableConcept? Specialty { get; set; }

    /// <summary>
    /// The style of appointment or patient that may be booked in the slot
    /// </summary>
    [JsonPropertyName("appointmentType")]
    public SimpleCodeableConcept? AppointmentType { get; set; }

    /// <summary>
    /// The schedule resource that this slot defines an interval of status information
    /// </summary>
    [JsonPropertyName("schedule")]
    public SimpleReference? Schedule { get; set; }

    /// <summary>
    /// busy | free | busy-unavailable | busy-tentative | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Date/Time that the slot is to begin
    /// </summary>
    [JsonPropertyName("start")]
    public DateTime? Start { get; set; }

    /// <summary>
    /// Date/Time that the slot is to conclude
    /// </summary>
    [JsonPropertyName("end")]
    public DateTime? End { get; set; }

    /// <summary>
    /// This slot has already been overbooked
    /// </summary>
    [JsonPropertyName("overbooked")]
    public bool? Overbooked { get; set; }

    /// <summary>
    /// Comments on the slot
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Slot";

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
