// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A physical entity which is the primary unit of operational and/or administrative interest in a study
/// </summary>
public class ResearchSubject : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier for research subject in a study
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// candidate | eligible | follow-up | ineligible | not-registered | off-study | on-study | on-study-intervention | on-study-observation | pending-on-study | potential-candidate | screening | withdrawn
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Start and end of participation
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// Study subject is part of
    /// </summary>
    [JsonPropertyName("study")]
    public SimpleReference? Study { get; set; }

    /// <summary>
    /// Who is part of study
    /// </summary>
    [JsonPropertyName("individual")]
    public SimpleReference? Individual { get; set; }

    /// <summary>
    /// What path should be followed
    /// </summary>
    [JsonPropertyName("assignedArm")]
    public string? AssignedArm { get; set; }

    /// <summary>
    /// What path was taken
    /// </summary>
    [JsonPropertyName("actualArm")]
    public string? ActualArm { get; set; }

    /// <summary>
    /// Agreement to participate in study
    /// </summary>
    [JsonPropertyName("consent")]
    public SimpleReference? Consent { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "ResearchSubject";

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
