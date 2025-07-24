// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// The technical details of an endpoint that can be used for electronic services
/// </summary>
public class Endpoint : SimpleDomainResource
{
    /// <summary>
    /// Identifies this endpoint across multiple systems
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | suspended | error | off | entered-in-error | test
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Protocol/Profile/Standard to be used with this endpoint connection
    /// </summary>
    [JsonPropertyName("connectionType")]
    public SimpleCoding? ConnectionType { get; set; }

    /// <summary>
    /// A name that this endpoint can be identified by
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Organization that manages this endpoint
    /// </summary>
    [JsonPropertyName("managingOrganization")]
    public SimpleReference? ManagingOrganization { get; set; }

    /// <summary>
    /// Contact details for source and destination
    /// </summary>
    [JsonPropertyName("contact")]
    public SimpleContactPoint? Contact { get; set; }

    /// <summary>
    /// Interval the endpoint is available
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// The type of content that may be used at this endpoint
    /// </summary>
    [JsonPropertyName("payloadType")]
    public SimpleCodeableConcept? PayloadType { get; set; }

    /// <summary>
    /// Mime type to send
    /// </summary>
    [JsonPropertyName("payloadMimeType")]
    public string? PayloadMimeType { get; set; }

    /// <summary>
    /// The network address of the endpoint
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// Usage depends on the channel type
    /// </summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Endpoint";

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
