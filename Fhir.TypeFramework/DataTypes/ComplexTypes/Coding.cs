using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Coding - 編碼型別
/// 用於在 FHIR 資源中表示編碼
/// </summary>
/// <remarks>
/// FHIR R5 Coding (Complex Type)
/// A reference to a code defined by a terminology system.
/// 
/// Structure:
/// - system: uri (0..1) - Identity of the terminology system
/// - version: string (0..1) - Version of the system - if relevant
/// - code: code (0..1) - Symbol in syntax defined by the system
/// - display: string (0..1) - Representation defined by the system
/// - userSelected: boolean (0..1) - If this coding was chosen directly by the user
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Coding : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 術語系統的身份識別
    /// FHIR Path: Coding.system
    /// Cardinality: 0..1
    /// Type: uri
    /// </summary>
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// 系統版本 - 如果相關
    /// FHIR Path: Coding.version
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("version")]
    public FhirString? Version { get; set; }

    /// <summary>
    /// 系統定義語法中的符號
    /// FHIR Path: Coding.code
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("code")]
    public FhirCode? Code { get; set; }

    /// <summary>
    /// 系統定義的表示
    /// FHIR Path: Coding.display
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("display")]
    public FhirString? Display { get; set; }

    /// <summary>
    /// 如果此編碼是由使用者直接選擇的
    /// FHIR Path: Coding.userSelected
    /// Cardinality: 0..1
    /// Type: boolean
    /// </summary>
    [JsonPropertyName("userSelected")]
    public FhirBoolean? UserSelected { get; set; }

    /// <summary>
    /// 檢查是否有編碼
    /// </summary>
    /// <returns>如果存在編碼則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCode => !string.IsNullOrEmpty(Code?.Value);

    /// <summary>
    /// 檢查是否有系統
    /// </summary>
    /// <returns>如果存在系統則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasSystem => !string.IsNullOrEmpty(System?.Value);

    /// <summary>
    /// 取得顯示文字
    /// </summary>
    /// <returns>顯示文字</returns>
    [JsonIgnore]
    public string? DisplayText => Display?.Value ?? Code?.Value;

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Coding 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Coding
        {
            Id = Id,
            System = System?.DeepCopy() as FhirUri,
            Version = Version?.DeepCopy() as FhirString,
            Code = Code?.DeepCopy() as FhirCode,
            Display = Display?.DeepCopy() as FhirString,
            UserSelected = UserSelected?.DeepCopy() as FhirBoolean
        };

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Coding 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Coding otherCoding)
            return false;

        return base.IsExactly(other) &&
               Equals(System, otherCoding.System) &&
               Equals(Version, otherCoding.Version) &&
               Equals(Code, otherCoding.Code) &&
               Equals(Display, otherCoding.Display) &&
               Equals(UserSelected, otherCoding.UserSelected);
    }

    /// <summary>
    /// 驗證 Coding 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證系統 URL 格式（如果提供）
        if (!string.IsNullOrEmpty(System?.Value))
        {
            if (!Uri.IsWellFormedUriString(System.Value, UriKind.Absolute))
            {
                yield return new ValidationResult("Coding system must be a well-formed absolute URI");
            }
        }

        // 驗證編碼（如果提供）
        if (!string.IsNullOrEmpty(Code?.Value))
        {
            // 編碼不能包含空格
            if (Code.Value.Contains(' '))
            {
                yield return new ValidationResult("Coding code cannot contain spaces");
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 