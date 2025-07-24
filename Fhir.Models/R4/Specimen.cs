// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A sample to be used for analysis
/// </summary>
public class Specimen : SimpleDomainResource
{
    /// <summary>
    /// External Identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Identifier assigned by the lab
    /// </summary>
    [JsonPropertyName("accessionIdentifier")]
    public SimpleIdentifier? AccessionIdentifier { get; set; }

    /// <summary>
    /// available | unavailable | unsatisfactory | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Kind of material that forms the specimen
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// Where the specimen came from
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// The time when specimen was received for processing
    /// </summary>
    [JsonPropertyName("receivedTime")]
    public DateTime? ReceivedTime { get; set; }

    /// <summary>
    /// Specimen from which this one was derived
    /// </summary>
    [JsonPropertyName("parent")]
    public SimpleReference? Parent { get; set; }

    /// <summary>
    /// Why the specimen was collected
    /// </summary>
    [JsonPropertyName("request")]
    public SimpleReference? Request { get; set; }

    /// <summary>
    /// Collection details
    /// </summary>
    [JsonPropertyName("collection")]
    public SimpleBackboneElement? Collection { get; set; }

    /// <summary>
    /// Processing and preparation step
    /// </summary>
    [JsonPropertyName("processing")]
    public SimpleBackboneElement? Processing { get; set; }

    /// <summary>
    /// Direct container of specimen
    /// </summary>
    [JsonPropertyName("container")]
    public SimpleBackboneElement? Container { get; set; }

    /// <summary>
    /// State of the specimen
    /// </summary>
    [JsonPropertyName("condition")]
    public SimpleCodeableConcept? Condition { get; set; }

    /// <summary>
    /// Comments
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Specimen";

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
