// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A photo, video, or audio recording acquired or used in healthcare
/// </summary>
public class Media : SimpleDomainResource
{
    /// <summary>
    /// Identifier(s) for the image
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Procedure that caused this image to be created
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// Part of referenced event
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// preparation | in-progress | not-done | on-hold | stopped | completed | entered-in-error | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// photo | video | audio
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// Imaging Modality
    /// </summary>
    [JsonPropertyName("modality")]
    public SimpleCodeableConcept? Modality { get; set; }

    /// <summary>
    /// Imaging view
    /// </summary>
    [JsonPropertyName("view")]
    public SimpleCodeableConcept? View { get; set; }

    /// <summary>
    /// Who/What this Media is a record of
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Encounter associated with media
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// When Media was collected
    /// </summary>
    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    /// <summary>
    /// When Media was collected
    /// </summary>
    [JsonPropertyName("createdPeriod")]
    public SimplePeriod? CreatedPeriod { get; set; }

    /// <summary>
    /// Date/Time this version was made available
    /// </summary>
    [JsonPropertyName("issued")]
    public DateTime? Issued { get; set; }

    /// <summary>
    /// The person who generated the image
    /// </summary>
    [JsonPropertyName("operator")]
    public SimpleReference? Operator { get; set; }

    /// <summary>
    /// Why was event performed?
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Observed body part
    /// </summary>
    [JsonPropertyName("bodySite")]
    public SimpleCodeableConcept? BodySite { get; set; }

    /// <summary>
    /// Name of the device/manufacturer
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>
    /// Observing Device
    /// </summary>
    [JsonPropertyName("device")]
    public SimpleReference? Device { get; set; }

    /// <summary>
    /// Height of the image in pixels
    /// </summary>
    [JsonPropertyName("height")]
    public uint? Height { get; set; }

    /// <summary>
    /// Width of the image in pixels
    /// </summary>
    [JsonPropertyName("width")]
    public uint? Width { get; set; }

    /// <summary>
    /// Number of frames if > 1 (photo)
    /// </summary>
    [JsonPropertyName("frames")]
    public uint? Frames { get; set; }

    /// <summary>
    /// Length in seconds (audio / video)
    /// </summary>
    [JsonPropertyName("duration")]
    public decimal? Duration { get; set; }

    /// <summary>
    /// Actual Media - reference or data
    /// </summary>
    [JsonPropertyName("content")]
    public SimpleAttachment? Content { get; set; }

    /// <summary>
    /// Comments made about the media
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Media";

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
