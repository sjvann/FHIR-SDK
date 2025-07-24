// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Legally enforceable, formally recorded unilateral or bilateral directive i.e., a policy or agreement
/// </summary>
public class Contract : SimpleDomainResource
{
    /// <summary>
    /// Contract number
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Baseline legal status of the contract
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Business edition
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// amended | appended | cancelled | disputed | entered-in-error | executable | executed | negotiable | offered | policy | rejected | renewed | revoked | terminated | terminated
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Legal instrument category
    /// </summary>
    [JsonPropertyName("legalState")]
    public SimpleCodeableConcept? LegalState { get; set; }

    /// <summary>
    /// Source Contract Definition
    /// </summary>
    [JsonPropertyName("instantiatesCanonical")]
    public SimpleReference? InstantiatesCanonical { get; set; }

    /// <summary>
    /// External Contract Definition
    /// </summary>
    [JsonPropertyName("instantiatesUri")]
    public string? InstantiatesUri { get; set; }

    /// <summary>
    /// Content derived from the basal information
    /// </summary>
    [JsonPropertyName("contentDerivative")]
    public SimpleCodeableConcept? ContentDerivative { get; set; }

    /// <summary>
    /// When this Contract was issued
    /// </summary>
    [JsonPropertyName("issued")]
    public DateTime? Issued { get; set; }

    /// <summary>
    /// Effective time
    /// </summary>
    [JsonPropertyName("applies")]
    public SimplePeriod? Applies { get; set; }

    /// <summary>
    /// Contract cessation cause
    /// </summary>
    [JsonPropertyName("expirationType")]
    public SimpleCodeableConcept? ExpirationType { get; set; }

    /// <summary>
    /// Contract Target Entity
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Authority under which this Contract has standing
    /// </summary>
    [JsonPropertyName("authority")]
    public SimpleReference? Authority { get; set; }

    /// <summary>
    /// A sphere of control governed by an authoritative jurisdiction
    /// </summary>
    [JsonPropertyName("domain")]
    public SimpleReference? Domain { get; set; }

    /// <summary>
    /// Specific Location
    /// </summary>
    [JsonPropertyName("site")]
    public SimpleReference? Site { get; set; }

    /// <summary>
    /// Computer friendly designation
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Human friendly designation
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Subordinate Friendly designation
    /// </summary>
    [JsonPropertyName("subtitle")]
    public string? Subtitle { get; set; }

    /// <summary>
    /// Acronym or short name
    /// </summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>
    /// Source of Contract
    /// </summary>
    [JsonPropertyName("author")]
    public SimpleReference? Author { get; set; }

    /// <summary>
    /// Range of Legal Concerns
    /// </summary>
    [JsonPropertyName("scope")]
    public SimpleCodeableConcept? Scope { get; set; }

    /// <summary>
    /// Focus of contract interest
    /// </summary>
    [JsonPropertyName("topicCodeableConcept")]
    public SimpleCodeableConcept? TopicCodeableConcept { get; set; }

    /// <summary>
    /// Focus of contract interest
    /// </summary>
    [JsonPropertyName("topicReference")]
    public SimpleReference? TopicReference { get; set; }

    /// <summary>
    /// Legal instrument category
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// Subtype within the context of type
    /// </summary>
    [JsonPropertyName("subType")]
    public SimpleCodeableConcept? SubType { get; set; }

    /// <summary>
    /// Contract precursor content
    /// </summary>
    [JsonPropertyName("contentDefinition")]
    public SimpleBackboneElement? ContentDefinition { get; set; }

    /// <summary>
    /// Contract Term List
    /// </summary>
    [JsonPropertyName("term")]
    public SimpleBackboneElement? Term { get; set; }

    /// <summary>
    /// Extra Information
    /// </summary>
    [JsonPropertyName("supportingInfo")]
    public SimpleReference? SupportingInfo { get; set; }

    /// <summary>
    /// Key event in Contract History
    /// </summary>
    [JsonPropertyName("relevantHistory")]
    public SimpleReference? RelevantHistory { get; set; }

    /// <summary>
    /// Contract Signatory
    /// </summary>
    [JsonPropertyName("signer")]
    public SimpleBackboneElement? Signer { get; set; }

    /// <summary>
    /// Contract Friendly Language
    /// </summary>
    [JsonPropertyName("friendly")]
    public SimpleBackboneElement? Friendly { get; set; }

    /// <summary>
    /// Contract Legal Language
    /// </summary>
    [JsonPropertyName("legal")]
    public SimpleBackboneElement? Legal { get; set; }

    /// <summary>
    /// Computable Contract Language
    /// </summary>
    [JsonPropertyName("rule")]
    public SimpleBackboneElement? Rule { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Contract";

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
