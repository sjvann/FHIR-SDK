using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Annotation - 註解型別
/// 用於在 FHIR 資源中添加註解資訊
/// </summary>
/// <remarks>
/// FHIR R5 Annotation (Complex Type)
/// A text note which also contains information about who made the statement and when.
/// 
/// Structure:
/// - author[x]: Reference|string (0..1) - Individual responsible for the annotation
/// - time: dateTime (0..1) - When the annotation was made
/// - text: markdown (1..1) - The annotation - text content (as markdown)
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Annotation : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 註解的作者 - 使用 Choice Type 支援 Reference 或 string
    /// FHIR Path: Annotation.author[x]
    /// Cardinality: 0..1
    /// Type: Reference(Organization|Patient|Practitioner|PractitionerRole|RelatedPerson)|string
    /// 根據 FHIR R5 規範，author[x] 可以是 Reference 或 string
    /// </summary>
    [JsonPropertyName("author")]
    public AnnotationAuthorChoice? Author { get; set; }

    /// <summary>
    /// 註解的時間
    /// FHIR Path: Annotation.time
    /// Cardinality: 0..1
    /// Type: dateTime
    /// </summary>
    [JsonPropertyName("time")]
    public FhirDateTime? Time { get; set; }

    /// <summary>
    /// 註解的文字內容（markdown 格式）
    /// FHIR Path: Annotation.text
    /// Cardinality: 1..1
    /// Type: markdown
    /// </summary>
    [JsonPropertyName("text")]
    [Required(ErrorMessage = "Annotation text is required")]
    public FhirMarkdown? Text { get; set; }

    /// <summary>
    /// 檢查是否有作者
    /// </summary>
    /// <returns>如果存在作者則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasAuthor => Author != null;

    /// <summary>
    /// 取得作者字串
    /// </summary>
    /// <returns>作者的字串表示</returns>
    [JsonIgnore]
    public string? AuthorDisplay => Author?.Match(
        reference => reference.Display,
        str => str.Value
    );

    /// <summary>
    /// 取得作者（如果存在）
    /// </summary>
    /// <typeparam name="T">期望的型別</typeparam>
    /// <returns>轉換後的值，如果型別不匹配則返回 null</returns>
    public T? GetAuthor<T>() where T : class
    {
        if (Author == null) return null;
        
        return Author.Match(
            reference => reference as T,
            str => str as T
        );
    }

    /// <summary>
    /// 設定作者（Reference 型別）
    /// </summary>
    /// <param name="reference">參考物件</param>
    public void SetAuthor(Reference reference)
    {
        Author = reference;
    }

    /// <summary>
    /// 設定作者（字串型別）
    /// </summary>
    /// <param name="authorString">作者字串</param>
    public void SetAuthor(FhirString authorString)
    {
        Author = authorString;
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Annotation 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Annotation
        {
            Id = Id,
            Author = Author, // Choice Type 本身是不可變的，直接複製
            Time = Time?.DeepCopy() as FhirDateTime,
            Text = Text?.DeepCopy() as FhirMarkdown
        };

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Annotation 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Annotation otherAnnotation)
            return false;

        return base.IsExactly(other) &&
               Equals(Author, otherAnnotation.Author) &&
               Equals(Time, otherAnnotation.Time) &&
               Equals(Text, otherAnnotation.Text);
    }

    /// <summary>
    /// 驗證 Annotation 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證必須有文字內容
        if (string.IsNullOrEmpty(Text?.Value))
        {
            yield return new ValidationResult("Annotation text is required");
        }

        // 驗證作者 Reference 的型別（如果提供）
        if (Author != null)
        {
            Author.Match(
                reference =>
                {
                    if (!string.IsNullOrEmpty(reference.Type))
                    {
                        var validTypes = new[] { "Organization", "Patient", "Practitioner", "PractitionerRole", "RelatedPerson" };
                        if (!validTypes.Contains(reference.Type))
                        {
                            yield return new ValidationResult($"AuthorReference type must be one of: {string.Join(", ", validTypes)}");
                        }
                    }
                },
                str => { } // 字串型別不需要額外驗證
            );
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 