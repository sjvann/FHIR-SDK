// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Measurements and simple assertions
/// </summary>
public class Observation : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier for observation
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Fulfills plan, proposal or order
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// Part of referenced event
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// registered | preliminary | final | amended +
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Classification of type of observation
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// Type of observation (code / type)
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// Who and/or what the observation is about
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// What the observation is about, when it is not about the subject of record
    /// </summary>
    [JsonPropertyName("focus")]
    public SimpleReference? Focus { get; set; }

    /// <summary>
    /// Healthcare event during which this observation is made
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// Clinically relevant time/time-period for observation
    /// </summary>
    [JsonPropertyName("effectiveDateTime")]
    public DateTime? EffectiveDateTime { get; set; }

    /// <summary>
    /// Clinically relevant time/time-period for observation
    /// </summary>
    [JsonPropertyName("effectivePeriod")]
    public SimplePeriod? EffectivePeriod { get; set; }

    /// <summary>
    /// Date/Time this version was made available
    /// </summary>
    [JsonPropertyName("issued")]
    public DateTime? Issued { get; set; }

    /// <summary>
    /// Who is responsible for the observation
    /// </summary>
    [JsonPropertyName("performer")]
    public SimpleReference? Performer { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueQuantity")]
    public SimpleQuantity? ValueQuantity { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueCodeableConcept")]
    public SimpleCodeableConcept? ValueCodeableConcept { get; set; }

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
    public SimpleRange? ValueRange { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueRatio")]
    public SimpleRatio? ValueRatio { get; set; }

    /// <summary>
    /// Actual result
    /// </summary>
    [JsonPropertyName("valueSampledData")]
    public SimpleSampledData? ValueSampledData { get; set; }

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
    public SimplePeriod? ValuePeriod { get; set; }

    /// <summary>
    /// Why the result is missing
    /// </summary>
    [JsonPropertyName("dataAbsentReason")]
    public SimpleCodeableConcept? DataAbsentReason { get; set; }

    /// <summary>
    /// High, low, normal, etc.
    /// </summary>
    [JsonPropertyName("interpretation")]
    public SimpleCodeableConcept? Interpretation { get; set; }

    /// <summary>
    /// Comments about the observation
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// Observed body part
    /// </summary>
    [JsonPropertyName("bodySite")]
    public SimpleCodeableConcept? BodySite { get; set; }

    /// <summary>
    /// How it was done
    /// </summary>
    [JsonPropertyName("method")]
    public SimpleCodeableConcept? Method { get; set; }

    /// <summary>
    /// Specimen used for this observation
    /// </summary>
    [JsonPropertyName("specimen")]
    public SimpleReference? Specimen { get; set; }

    /// <summary>
    /// (Measurement) Device
    /// </summary>
    [JsonPropertyName("device")]
    public SimpleReference? Device { get; set; }

    /// <summary>
    /// Provides guide for interpretation
    /// </summary>
    [JsonPropertyName("referenceRange")]
    public SimpleBackboneElement? ReferenceRange { get; set; }

    /// <summary>
    /// Related resource that belongs to the Observation group
    /// </summary>
    [JsonPropertyName("hasMember")]
    public SimpleReference? HasMember { get; set; }

    /// <summary>
    /// Related measurements the observation is made from
    /// </summary>
    [JsonPropertyName("derivedFrom")]
    public SimpleReference? DerivedFrom { get; set; }

    /// <summary>
    /// Component results
    /// </summary>
    [JsonPropertyName("component")]
    public SimpleBackboneElement? Component { get; set; }

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
