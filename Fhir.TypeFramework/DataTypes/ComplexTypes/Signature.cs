using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Signature - 簽名型別
/// 用於在 FHIR 資源中表示數位簽名
/// </summary>
/// <remarks>
/// FHIR R5 Signature (Complex Type)
/// A digital signature along with supporting context.
/// 
/// Structure:
/// - type: Coding[] (0..*) - Indication of the reason the entity signed the object(s)
/// - when: instant (0..1) - When the signature was created
/// - who: Reference (0..1) - Who signed
/// - onBehalfOf: Reference (0..1) - The party represented
/// - targetFormat: code (0..1) - The technical format of the signed resources
/// - sigFormat: code (0..1) - The technical format of the signature
/// - data: base64Binary (0..1) - The actual signature content (XML DigSig. JWT, picture, etc.)
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Signature : UnifiedComplexTypeBase<Signature>
{
    /// <summary>
    /// 實體簽署物件的原因指示
    /// FHIR Path: Signature.type
    /// Cardinality: 0..*
    /// Type: Coding[]
    /// </summary>
    [JsonPropertyName("type")]
    public IList<Coding>? Type { get; set; }

    /// <summary>
    /// 簽名建立的時間
    /// FHIR Path: Signature.when
    /// Cardinality: 0..1
    /// Type: instant
    /// </summary>
    [JsonPropertyName("when")]
    public FhirInstant? When { get; set; }

    /// <summary>
    /// 簽署者
    /// FHIR Path: Signature.who
    /// Cardinality: 0..1
    /// Type: Reference
    /// </summary>
    [JsonPropertyName("who")]
    public Reference? Who { get; set; }

    /// <summary>
    /// 代表的當事人
    /// FHIR Path: Signature.onBehalfOf
    /// Cardinality: 0..1
    /// Type: Reference
    /// </summary>
    [JsonPropertyName("onBehalfOf")]
    public Reference? OnBehalfOf { get; set; }

    /// <summary>
    /// 已簽署資源的技術格式
    /// FHIR Path: Signature.targetFormat
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("targetFormat")]
    public FhirCode? TargetFormat { get; set; }

    /// <summary>
    /// 簽名的技術格式
    /// FHIR Path: Signature.sigFormat
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("sigFormat")]
    public FhirCode? SigFormat { get; set; }

    /// <summary>
    /// 實際的簽名內容（XML DigSig、JWT、圖片等）
    /// FHIR Path: Signature.data
    /// Cardinality: 0..1
    /// Type: base64Binary
    /// </summary>
    [JsonPropertyName("data")]
    public FhirBase64Binary? Data { get; set; }

    /// <summary>
    /// 檢查是否有類型
    /// </summary>
    /// <returns>如果存在類型則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasType => Type?.Any() == true;

    /// <summary>
    /// 檢查是否有時間
    /// </summary>
    /// <returns>如果存在時間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasWhen => When?.Value != null;

    /// <summary>
    /// 檢查是否有簽署者
    /// </summary>
    /// <returns>如果存在簽署者則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasWho => Who != null;

    /// <summary>
    /// 檢查是否有代表當事人
    /// </summary>
    /// <returns>如果存在代表當事人則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasOnBehalfOf => OnBehalfOf != null;

    /// <summary>
    /// 檢查是否有目標格式
    /// </summary>
    /// <returns>如果存在目標格式則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasTargetFormat => !string.IsNullOrEmpty(TargetFormat?.Value);

    /// <summary>
    /// 檢查是否有簽名格式
    /// </summary>
    /// <returns>如果存在簽名格式則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasSigFormat => !string.IsNullOrEmpty(SigFormat?.Value);

    /// <summary>
    /// 檢查是否有資料
    /// </summary>
    /// <returns>如果存在資料則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasData => Data != null;

    /// <summary>
    /// 檢查簽名是否有效
    /// </summary>
    /// <returns>如果簽名有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => HasWho && HasWhen;

    /// <summary>
    /// 取得顯示文字
    /// </summary>
    /// <returns>顯示文字</returns>
    [JsonIgnore]
    public string? DisplayText
    {
        get
        {
            var parts = new List<string>();
            
            if (HasWho)
            {
                parts.Add($"Signed by: {Who?.DisplayText}");
            }
            
            if (HasWhen)
            {
                parts.Add($"at {When?.Value}");
            }
            
            if (HasOnBehalfOf)
            {
                parts.Add($"on behalf of: {OnBehalfOf?.DisplayText}");
            }
            
            return parts.Any() ? string.Join(" ", parts) : "Digital Signature";
        }
    }

    protected override void CopyFieldsTo(Signature target)
    {
        target.Type = Type?.Select(t => t.DeepCopy() as Coding).ToList();
        target.When = When?.DeepCopy() as FhirInstant;
        target.Who = Who?.DeepCopy() as Reference;
        target.OnBehalfOf = OnBehalfOf?.DeepCopy() as Reference;
        target.TargetFormat = TargetFormat?.DeepCopy() as FhirCode;
        target.SigFormat = SigFormat?.DeepCopy() as FhirCode;
        target.Data = Data?.DeepCopy() as FhirBase64Binary;
    }

    protected override bool FieldsAreExactly(Signature other)
    {
        return DeepEqualityComparer.AreEqual(Type, other.Type) &&
               DeepEqualityComparer.AreEqual(When, other.When) &&
               DeepEqualityComparer.AreEqual(Who, other.Who) &&
               DeepEqualityComparer.AreEqual(OnBehalfOf, other.OnBehalfOf) &&
               DeepEqualityComparer.AreEqual(TargetFormat, other.TargetFormat) &&
               DeepEqualityComparer.AreEqual(SigFormat, other.SigFormat) &&
               DeepEqualityComparer.AreEqual(Data, other.Data);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Type
        if (Type != null)
        {
            foreach (var type in Type)
            {
                if (type != null)
                {
                    results.AddRange(type.Validate(validationContext));
                }
            }
        }

        // 驗證 When
        if (When != null)
        {
            results.AddRange(When.Validate(validationContext));
        }

        // 驗證 Who
        if (Who != null)
        {
            results.AddRange(Who.Validate(validationContext));
        }

        // 驗證 OnBehalfOf
        if (OnBehalfOf != null)
        {
            results.AddRange(OnBehalfOf.Validate(validationContext));
        }

        // 驗證 TargetFormat
        if (TargetFormat != null)
        {
            results.AddRange(TargetFormat.Validate(validationContext));
        }

        // 驗證 SigFormat
        if (SigFormat != null)
        {
            results.AddRange(SigFormat.Validate(validationContext));
        }

        // 驗證 Data
        if (Data != null)
        {
            results.AddRange(Data.Validate(validationContext));
        }

        // 驗證簽名邏輯
        if (!HasWho)
        {
            results.Add(new ValidationResult("Signature must have a who reference"));
        }

        if (!HasWhen)
        {
            results.Add(new ValidationResult("Signature must have a when timestamp"));
        }

        return results;
    }
} 