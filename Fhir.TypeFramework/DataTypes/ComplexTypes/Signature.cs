using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
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
public class Signature : Element, IExtensibleTypeFramework
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
    /// 實際簽名內容（XML DigSig、JWT、圖片等）
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
    /// 檢查是否有資料
    /// </summary>
    /// <returns>如果存在資料則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasData => Data?.Value != null && Data.Value.Length > 0;

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
                parts.Add($"at {When?.Value:yyyy-MM-dd HH:mm:ss}");
            }

            if (HasType)
            {
                var typeNames = Type!.Select(t => t.DisplayText).Where(t => !string.IsNullOrEmpty(t));
                if (typeNames.Any())
                {
                    parts.Add($"Type: {string.Join(", ", typeNames)}");
                }
            }

            return parts.Count > 0 ? string.Join(" ", parts) : null;
        }
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Signature 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Signature
        {
            Id = Id,
            When = When?.DeepCopy() as FhirInstant,
            Who = Who?.DeepCopy() as Reference,
            OnBehalfOf = OnBehalfOf?.DeepCopy() as Reference,
            TargetFormat = TargetFormat?.DeepCopy() as FhirCode,
            SigFormat = SigFormat?.DeepCopy() as FhirCode,
            Data = Data?.DeepCopy() as FhirBase64Binary
        };

        if (Type != null)
        {
            copy.Type = Type.Select(t => t.DeepCopy() as Coding).ToList();
        }

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Signature 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Signature otherSignature)
            return false;

        return base.IsExactly(other) &&
               Equals(When, otherSignature.When) &&
               Equals(Who, otherSignature.Who) &&
               Equals(OnBehalfOf, otherSignature.OnBehalfOf) &&
               Equals(TargetFormat, otherSignature.TargetFormat) &&
               Equals(SigFormat, otherSignature.SigFormat) &&
               Equals(Data, otherSignature.Data) &&
               Type?.Count == otherSignature.Type?.Count &&
               (Type?.Zip(otherSignature.Type ?? new List<Coding>(), 
                         (a, b) => a.IsExactly(b)).All(x => x) ?? true);
    }

    /// <summary>
    /// 驗證 Signature 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證類型（如果提供）
        if (Type != null)
        {
            foreach (var type in Type)
            {
                var typeValidationContext = new ValidationContext(type);
                foreach (var typeResult in type.Validate(typeValidationContext))
                {
                    yield return typeResult;
                }
            }
        }

        // 驗證簽署者（如果提供）
        if (Who != null)
        {
            var whoValidationContext = new ValidationContext(Who);
            foreach (var whoResult in Who.Validate(whoValidationContext))
            {
                yield return whoResult;
            }
        }

        // 驗證代表當事人（如果提供）
        if (OnBehalfOf != null)
        {
            var onBehalfOfValidationContext = new ValidationContext(OnBehalfOf);
            foreach (var onBehalfOfResult in OnBehalfOf.Validate(onBehalfOfValidationContext))
            {
                yield return onBehalfOfResult;
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 