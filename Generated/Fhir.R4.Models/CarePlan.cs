// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Describes the intention of how one or more practitioners intend to deliver care for a particular patient, group or community for a period of time
/// </summary>
public class CarePlan : SimpleDomainResource
{
    /// <summary>
    /// External Ids for this plan
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
    /// Fulfills CarePlan
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// CarePlan replaced by this CarePlan
    /// </summary>
    [JsonPropertyName("replaces")]
    public SimpleReference? Replaces { get; set; }

    /// <summary>
    /// Part of referenced CarePlan
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// draft | active | suspended | completed | entered-in-error | cancelled | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// proposal | plan | order | option
    /// </summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>
    /// Type of plan
    /// </summary>
    [JsonPropertyName("category")]
    public SimpleCodeableConcept? Category { get; set; }

    /// <summary>
    /// Human-friendly name for the care plan
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Summary of nature of plan
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Who the care plan is for
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Encounter created as part of
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// Time period plan covers
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// Date record was first recorded
    /// </summary>
    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Who is the designated responsible party
    /// </summary>
    [JsonPropertyName("author")]
    public SimpleReference? Author { get; set; }

    /// <summary>
    /// Who provided the content of the care plan
    /// </summary>
    [JsonPropertyName("contributor")]
    public SimpleReference? Contributor { get; set; }

    /// <summary>
    /// Who's involved in plan
    /// </summary>
    [JsonPropertyName("careTeam")]
    public SimpleReference? CareTeam { get; set; }

    /// <summary>
    /// Health issues this plan addresses
    /// </summary>
    [JsonPropertyName("addresses")]
    public SimpleReference? Addresses { get; set; }

    /// <summary>
    /// Information considered as part of plan
    /// </summary>
    [JsonPropertyName("supportingInfo")]
    public SimpleReference? SupportingInfo { get; set; }

    /// <summary>
    /// Desired outcome of plan
    /// </summary>
    [JsonPropertyName("goal")]
    public SimpleReference? Goal { get; set; }

    /// <summary>
    /// Action to occur as part of plan
    /// </summary>
    [JsonPropertyName("activity")]
    public SimpleBackboneElement? Activity { get; set; }

    /// <summary>
    /// Comments about the plan
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "CarePlan";

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
