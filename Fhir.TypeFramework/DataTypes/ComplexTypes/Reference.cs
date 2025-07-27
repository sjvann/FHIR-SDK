using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Reference - 參考型別
/// 用於在 FHIR 資源中引用其他資源
/// </summary>
/// <remarks>
/// FHIR R5 Reference (Complex Type)
/// A reference from one resource to another.
/// 
/// Structure:
/// - reference: string (0..1) - Literal reference, Relative, internal or absolute URL
/// - type: uri (0..1) - Type the reference refers to (e.g. "Patient")
/// - identifier: Identifier (0..1) - Logical reference, when literal reference is not known
/// - display: string (0..1) - Text alternative for the resource
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Reference : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 字面參考 - 相對、內部或絕對 URL
    /// FHIR Path: Reference.reference
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("reference")]
    public FhirString? Reference { get; set; }

    /// <summary>
    /// 參考的資源型別
    /// FHIR Path: Reference.type
    /// Cardinality: 0..1
    /// Type: uri
    /// </summary>
    [JsonPropertyName("type")]
    public FhirUri? Type { get; set; }

    /// <summary>
    /// 邏輯參考 - 當字面參考未知時使用
    /// FHIR Path: Reference.identifier
    /// Cardinality: 0..1
    /// Type: Identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public Identifier? Identifier { get; set; }

    /// <summary>
    /// 資源的文字替代
    /// FHIR Path: Reference.display
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("display")]
    public FhirString? Display { get; set; }

    /// <summary>
    /// 檢查是否有參考
    /// </summary>
    /// <returns>如果存在參考則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasReference => !string.IsNullOrEmpty(Reference?.Value) || Identifier != null;

    /// <summary>
    /// 取得參考的顯示文字
    /// </summary>
    /// <returns>參考的顯示文字</returns>
    [JsonIgnore]
    public string? DisplayText => Display?.Value ?? Reference?.Value ?? Identifier?.Value;

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Reference 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Reference
        {
            Id = Id,
            Reference = Reference?.DeepCopy() as FhirString,
            Type = Type?.DeepCopy() as FhirUri,
            Identifier = Identifier?.DeepCopy() as Identifier,
            Display = Display?.DeepCopy() as FhirString
        };

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Reference 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Reference otherReference)
            return false;

        return base.IsExactly(other) &&
               Equals(Reference, otherReference.Reference) &&
               Equals(Type, otherReference.Type) &&
               Equals(Identifier, otherReference.Identifier) &&
               Equals(Display, otherReference.Display);
    }

    /// <summary>
    /// 驗證 Reference 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證必須有參考或識別碼
        if (string.IsNullOrEmpty(Reference?.Value) && Identifier == null)
        {
            yield return new ValidationResult("Reference must have either reference or identifier");
        }

        // 驗證參考 URL 格式（如果提供）
        if (!string.IsNullOrEmpty(Reference?.Value))
        {
            if (!Uri.IsWellFormedUriString(Reference.Value, UriKind.RelativeOrAbsolute))
            {
                yield return new ValidationResult("Reference URL must be a well-formed URI");
            }
        }

        // 驗證型別 URL 格式（如果提供）
        if (!string.IsNullOrEmpty(Type?.Value))
        {
            if (!Uri.IsWellFormedUriString(Type.Value, UriKind.Absolute))
            {
                yield return new ValidationResult("Reference type must be a well-formed absolute URI");
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 