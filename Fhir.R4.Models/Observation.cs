// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.R4.Models;

/// <summary>
/// Measurements and simple assertions
/// </summary>
public class Observation : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier for observation
    /// </summary>
    [JsonPropertyName("identifier")]
    public Fhir.R4.Models.Identifier Identifier { get; set; }

    /// <summary>
    /// Fulfills plan, proposal or order
    /// </summary>
    [JsonPropertyName("basedOn")]
    public Fhir.R4.Models.Reference BasedOn { get; set; }

    /// <summary>
    /// Part of referenced event
    /// </summary>
    [JsonPropertyName("partOf")]
    public Fhir.R4.Models.Reference PartOf { get; set; }

    /// <summary>
    /// registered | preliminary | final | amended +
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>
    /// Classification of type of observation
    /// </summary>
    [JsonPropertyName("category")]
    public Fhir.R4.Models.CodeableConcept Category { get; set; }

    /// <summary>
    /// Type of observation (code / type)
    /// </summary>
    [JsonPropertyName("code")]
    public Fhir.R4.Models.CodeableConcept Code { get; set; }

    /// <summary>
    /// Who and/or what the observation is about
    /// </summary>
    [JsonPropertyName("subject")]
    public Fhir.R4.Models.Reference Subject { get; set; }

    /// <summary>
    /// What the observation is about, when it is not about the subject of record
    /// </summary>
    [JsonPropertyName("focus")]
    public Fhir.R4.Models.Reference Focus { get; set; }

    /// <summary>
    /// Healthcare event during which this observation is made
    /// </summary>
    [JsonPropertyName("encounter")]
    public Fhir.R4.Models.Reference Encounter { get; set; }

    /// <summary>
    /// Clinically relevant time/time-period for observation
    /// </summary>
    [JsonPropertyName("effectiveDateTime")]
    public DateTime? EffectiveDateTime { get; set; }

    /// <summary>
    /// Clinically relevant time/time-period for observation
    /// </summary>
    [JsonPropertyName("effectivePeriod")]
    public Fhir.R4.Models.Period EffectivePeriod { get; set; }

    /// <summary>
    /// Date/Time this version was made available
    /// </summary>
    [JsonPropertyName("issued")]
    public DateTime? Issued { get; set; }

    /// <summary>
    /// Who is responsible for the observation
    /// </summary>
    [JsonPropertyName("performer")]
    public Fhir.R4.Models.Reference Performer { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueQuantity")]
    public Fhir.R4.Models.Quantity ValueQuantity { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueCodeableConcept")]
    public Fhir.R4.Models.CodeableConcept ValueCodeableConcept { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueString")]
    public string? ValueString { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueBoolean")]
    public bool? ValueBoolean { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueInteger")]
    public int? ValueInteger { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueRange")]
    public Fhir.R4.Models.Range ValueRange { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueRatio")]
    public Fhir.R4.Models.Ratio ValueRatio { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueSampledData")]
    public Fhir.R4.Models.SampledData ValueSampledData { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueTime")]
    public string? ValueTime { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueDateTime")]
    public DateTime? ValueDateTime { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valuePeriod")]
    public Fhir.R4.Models.Period ValuePeriod { get; set; }

    /// <summary>
    /// Why the result is missing
    /// </summary>
    [JsonPropertyName("dataAbsentReason")]
    public Fhir.R4.Models.CodeableConcept DataAbsentReason { get; set; }

    /// <summary>
    /// High, low, normal, etc.
    /// </summary>
    [JsonPropertyName("interpretation")]
    public Fhir.R4.Models.CodeableConcept Interpretation { get; set; }

    /// <summary>
    /// Comments about the observation
    /// </summary>
    [JsonPropertyName("note")]
    public Fhir.R4.Models.Annotation Note { get; set; }

    /// <summary>
    /// Observed body part
    /// </summary>
    [JsonPropertyName("bodySite")]
    public Fhir.R4.Models.CodeableConcept BodySite { get; set; }

    /// <summary>
    /// How it was done
    /// </summary>
    [JsonPropertyName("method")]
    public Fhir.R4.Models.CodeableConcept Method { get; set; }

    /// <summary>
    /// Specimen used for this observation
    /// </summary>
    [JsonPropertyName("specimen")]
    public Fhir.R4.Models.Reference Specimen { get; set; }

    /// <summary>
    /// (Measurement) Device
    /// </summary>
    [JsonPropertyName("device")]
    public Fhir.R4.Models.Reference Device { get; set; }

    /// <summary>
    /// Provides guide for interpretation
    /// </summary>
    [JsonPropertyName("referenceRange")]
    public List<Observation.ReferenceRangeComponent>? ReferenceRange { get; set; }

    /// <summary>
    /// Related resource that belongs to the Observation group
    /// </summary>
    [JsonPropertyName("hasMember")]
    public Fhir.R4.Models.Reference HasMember { get; set; }

    /// <summary>
    /// Related measurements the observation is made from
    /// </summary>
    [JsonPropertyName("derivedFrom")]
    public Fhir.R4.Models.Reference DerivedFrom { get; set; }

    /// <summary>
    /// Component results
    /// </summary>
    [JsonPropertyName("component")]
    public List<Observation.ComponentComponent>? Component { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Observation";

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
