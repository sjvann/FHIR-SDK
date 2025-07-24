// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// An interaction between a patient and healthcare provider(s) for the purpose of providing healthcare service(s)
/// </summary>
public class Encounter : SimpleDomainResource
{
    /// <summary>
    /// Identifier(s) by which this encounter is known
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// planned | arrived | triaged | in-progress | onleave | finished | cancelled +
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// List of past encounter statuses
    /// </summary>
    [JsonPropertyName("statusHistory")]
    public SimpleBackboneElement? StatusHistory { get; set; }

    /// <summary>
    /// Classification of patient encounter
    /// </summary>
    [JsonPropertyName("class")]
    public SimpleCoding? Class { get; set; }

    /// <summary>
    /// List of past encounter classes
    /// </summary>
    [JsonPropertyName("classHistory")]
    public SimpleBackboneElement? ClassHistory { get; set; }

    /// <summary>
    /// Specific type of encounter
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// Specific type of service
    /// </summary>
    [JsonPropertyName("serviceType")]
    public SimpleCodeableConcept? ServiceType { get; set; }

    /// <summary>
    /// Indicates the urgency of the encounter
    /// </summary>
    [JsonPropertyName("priority")]
    public SimpleCodeableConcept? Priority { get; set; }

    /// <summary>
    /// The patient or group present at the encounter
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Episode(s) of care that this encounter should be recorded against
    /// </summary>
    [JsonPropertyName("episodeOfCare")]
    public SimpleReference? EpisodeOfCare { get; set; }

    /// <summary>
    /// The request that initiated this encounter
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// List of participants involved in the encounter
    /// </summary>
    [JsonPropertyName("participant")]
    public SimpleBackboneElement? Participant { get; set; }

    /// <summary>
    /// The appointment that scheduled this encounter
    /// </summary>
    [JsonPropertyName("appointment")]
    public SimpleReference? Appointment { get; set; }

    /// <summary>
    /// The start and end time of the encounter
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// Quantity of time the encounter lasted (less time absent)
    /// </summary>
    [JsonPropertyName("length")]
    public SimpleDuration? Length { get; set; }

    /// <summary>
    /// Coded reason the encounter takes place
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Reason the encounter takes place (reference)
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public SimpleReference? ReasonReference { get; set; }

    /// <summary>
    /// The list of diagnosis relevant to this encounter
    /// </summary>
    [JsonPropertyName("diagnosis")]
    public SimpleBackboneElement? Diagnosis { get; set; }

    /// <summary>
    /// The set of accounts that may be used for billing for this Encounter
    /// </summary>
    [JsonPropertyName("account")]
    public SimpleReference? Account { get; set; }

    /// <summary>
    /// Details about the admission to a healthcare service
    /// </summary>
    [JsonPropertyName("hospitalization")]
    public SimpleBackboneElement? Hospitalization { get; set; }

    /// <summary>
    /// List of locations where the patient has been
    /// </summary>
    [JsonPropertyName("location")]
    public SimpleBackboneElement? Location { get; set; }

    /// <summary>
    /// The organization (facility) responsible for this encounter
    /// </summary>
    [JsonPropertyName("serviceProvider")]
    public SimpleReference? ServiceProvider { get; set; }

    /// <summary>
    /// Another Encounter of which this encounter is a part
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Encounter";

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
