// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Representation of the content produced in a DICOM imaging study
/// </summary>
public class ImagingStudy : SimpleDomainResource
{
    /// <summary>
    /// Identifiers for the ImagingStudy
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// registered | available | cancelled | entered-in-error | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// All series modality if actual acquisition modalities
    /// </summary>
    [JsonPropertyName("modality")]
    public SimpleCoding? Modality { get; set; }

    /// <summary>
    /// Who the study is about
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Encounter with which this imaging study is associated
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// When the study was started
    /// </summary>
    [JsonPropertyName("started")]
    public DateTime? Started { get; set; }

    /// <summary>
    /// Request fulfilled
    /// </summary>
    [JsonPropertyName("basedOn")]
    public SimpleReference? BasedOn { get; set; }

    /// <summary>
    /// Part of referenced event
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// Referring physician
    /// </summary>
    [JsonPropertyName("referrer")]
    public SimpleReference? Referrer { get; set; }

    /// <summary>
    /// Who interpreted images
    /// </summary>
    [JsonPropertyName("interpreter")]
    public SimpleReference? Interpreter { get; set; }

    /// <summary>
    /// Study access endpoint
    /// </summary>
    [JsonPropertyName("endpoint")]
    public SimpleReference? Endpoint { get; set; }

    /// <summary>
    /// Number of Study Related Series
    /// </summary>
    [JsonPropertyName("numberOfSeries")]
    public uint? NumberOfSeries { get; set; }

    /// <summary>
    /// Number of Study Related Instances
    /// </summary>
    [JsonPropertyName("numberOfInstances")]
    public uint? NumberOfInstances { get; set; }

    /// <summary>
    /// The performed Procedure reference
    /// </summary>
    [JsonPropertyName("procedureReference")]
    public SimpleReference? ProcedureReference { get; set; }

    /// <summary>
    /// The performed procedure code
    /// </summary>
    [JsonPropertyName("procedureCode")]
    public SimpleCodeableConcept? ProcedureCode { get; set; }

    /// <summary>
    /// Where ImagingStudy occurred
    /// </summary>
    [JsonPropertyName("location")]
    public SimpleReference? Location { get; set; }

    /// <summary>
    /// Why the study was requested
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Why was study performed
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public SimpleReference? ReasonReference { get; set; }

    /// <summary>
    /// User-defined comments
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// Institution-generated description
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Each study has one or more series of instances
    /// </summary>
    [JsonPropertyName("series")]
    public SimpleBackboneElement? Series { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "ImagingStudy";

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
