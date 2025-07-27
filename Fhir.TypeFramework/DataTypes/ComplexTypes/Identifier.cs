using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Identifier - 識別碼型別
/// 用於在 FHIR 資源中表示識別碼
/// </summary>
/// <remarks>
/// FHIR R5 Identifier (Complex Type)
/// An identifier for this resource.
/// 
/// Structure:
/// - use: code (0..1) - usual | official | temp | secondary | old (If known)
/// - type: CodeableConcept (0..1) - Description of identifier
/// - system: uri (0..1) - The namespace for the identifier value
/// - value: string (0..1) - The value that is unique
/// - period: Period (0..1) - Time period when id is/was valid for use
/// - assigner: Reference (0..1) - Organization that issued id (may be just text)
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Identifier : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 識別碼的使用目的
    /// FHIR Path: Identifier.use
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }

    /// <summary>
    /// 識別碼的類型描述
    /// FHIR Path: Identifier.type
    /// Cardinality: 0..1
    /// Type: CodeableConcept
    /// </summary>
    [JsonPropertyName("type")]
    public CodeableConcept? Type { get; set; }

    /// <summary>
    /// 識別碼值的命名空間
    /// FHIR Path: Identifier.system
    /// Cardinality: 0..1
    /// Type: uri
    /// </summary>
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// 唯一的值
    /// FHIR Path: Identifier.value
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("value")]
    public FhirString? Value { get; set; }

    /// <summary>
    /// 識別碼有效的時間期間
    /// FHIR Path: Identifier.period
    /// Cardinality: 0..1
    /// Type: Period
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    /// <summary>
    /// 發行識別碼的組織
    /// FHIR Path: Identifier.assigner
    /// Cardinality: 0..1
    /// Type: Reference
    /// </summary>
    [JsonPropertyName("assigner")]
    public Reference? Assigner { get; set; }

    /// <summary>
    /// 檢查是否有值
    /// </summary>
    /// <returns>如果存在值則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasValue => !string.IsNullOrEmpty(Value?.Value);

    /// <summary>
    /// 取得識別碼的完整表示
    /// </summary>
    /// <returns>識別碼的完整表示</returns>
    [JsonIgnore]
    public string? FullIdentifier => $"{System?.Value}|{Value?.Value}";

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Identifier 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Identifier
        {
            Id = Id,
            Use = Use?.DeepCopy() as FhirCode,
            Type = Type?.DeepCopy() as CodeableConcept,
            System = System?.DeepCopy() as FhirUri,
            Value = Value?.DeepCopy() as FhirString,
            Period = Period?.DeepCopy() as Period,
            Assigner = Assigner?.DeepCopy() as Reference
        };

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Identifier 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Identifier otherIdentifier)
            return false;

        return base.IsExactly(other) &&
               Equals(Use, otherIdentifier.Use) &&
               Equals(Type, otherIdentifier.Type) &&
               Equals(System, otherIdentifier.System) &&
               Equals(Value, otherIdentifier.Value) &&
               Equals(Period, otherIdentifier.Period) &&
               Equals(Assigner, otherIdentifier.Assigner);
    }

    /// <summary>
    /// 驗證 Identifier 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 use 值（如果提供）
        if (!string.IsNullOrEmpty(Use?.Value))
        {
            var validUses = new[] { "usual", "official", "temp", "secondary", "old" };
            if (!validUses.Contains(Use.Value))
            {
                yield return new ValidationResult($"Identifier use must be one of: {string.Join(", ", validUses)}");
            }
        }

        // 驗證 system URL 格式（如果提供）
        if (!string.IsNullOrEmpty(System?.Value))
        {
            if (!Uri.IsWellFormedUriString(System.Value, UriKind.Absolute))
            {
                yield return new ValidationResult("Identifier system must be a well-formed absolute URI");
            }
        }

        // 驗證 assigner Reference 的型別（如果提供）
        if (Assigner != null && !string.IsNullOrEmpty(Assigner.Type?.Value))
        {
            var validTypes = new[] { "Organization" };
            if (!validTypes.Contains(Assigner.Type.Value))
            {
                yield return new ValidationResult($"Identifier assigner type must be one of: {string.Join(", ", validTypes)}");
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 