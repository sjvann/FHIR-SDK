using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Narrative - 敘述
/// 用於描述人類可讀的敘述內容
/// </summary>
/// <remarks>
/// FHIR R5 Narrative (Complex Type)
/// A human-readable summary of the resource conveying the essential clinical and business information.
/// 
/// Structure:
/// - status: code (1..1) - generated | extensions | additional | empty
/// - div: xhtml (1..1) - Limited xhtml content
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Narrative : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 狀態
    /// FHIR Path: Narrative.status
    /// Cardinality: 1..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("status")]
    [Required(ErrorMessage = "Narrative.status is required")]
    public FhirCode? Status { get; set; }

    /// <summary>
    /// 限制的 xhtml 內容
    /// FHIR Path: Narrative.div
    /// Cardinality: 1..1
    /// Type: xhtml
    /// </summary>
    [JsonPropertyName("div")]
    [Required(ErrorMessage = "Narrative.div is required")]
    public FhirXhtml? Div { get; set; }

    /// <summary>
    /// 檢查是否有狀態
    /// </summary>
    /// <returns>如果存在狀態則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasStatus => !string.IsNullOrEmpty(Status);

    /// <summary>
    /// 檢查是否有內容
    /// </summary>
    /// <returns>如果存在內容則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDiv => !string.IsNullOrEmpty(Div);

    /// <summary>
    /// 設定狀態
    /// </summary>
    /// <param name="status">狀態代碼</param>
    public void SetStatus(string status)
    {
        Status = new FhirCode(status);
    }

    /// <summary>
    /// 設定內容
    /// </summary>
    /// <param name="div">xhtml 內容</param>
    public void SetDiv(string div)
    {
        Div = new FhirXhtml(div);
    }

    /// <summary>
    /// 取得狀態
    /// </summary>
    /// <returns>狀態代碼，如果不存在則返回 null</returns>
    public string? GetStatus()
    {
        return Status?.Value;
    }

    /// <summary>
    /// 取得內容
    /// </summary>
    /// <returns>xhtml 內容，如果不存在則返回 null</returns>
    public string? GetDiv()
    {
        return Div?.Value;
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Narrative 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Narrative
        {
            Id = Id,
            Status = Status,
            Div = Div
        };

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Narrative 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Narrative otherNarrative)
            return false;

        return base.IsExactly(other) &&
               Equals(Status, otherNarrative.Status) &&
               Equals(Div, otherNarrative.Div);
    }

    /// <summary>
    /// 驗證 Narrative 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證必需的狀態
        if (string.IsNullOrEmpty(Status))
        {
            yield return new ValidationResult("Narrative.status is required");
        }
        else
        {
            var validStatuses = new[] { "generated", "extensions", "additional", "empty" };
            if (!validStatuses.Contains(Status))
            {
                yield return new ValidationResult($"Narrative.status '{Status}' is not a valid status");
            }
        }

        // 驗證必需的內容
        if (string.IsNullOrEmpty(Div))
        {
            yield return new ValidationResult("Narrative.div is required");
        }
        else
        {
            // 驗證 xhtml 格式
            if (!IsValidXhtml(Div))
            {
                yield return new ValidationResult("Narrative.div must be valid xhtml content");
            }
        }

        // 驗證狀態
        if (Status != null)
        {
            var statusValidationContext = new ValidationContext(Status);
            foreach (var result in Status.Validate(statusValidationContext))
            {
                yield return result;
            }
        }

        // 驗證內容
        if (Div != null)
        {
            var divValidationContext = new ValidationContext(Div);
            foreach (var result in Div.Validate(divValidationContext))
            {
                yield return result;
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }

    /// <summary>
    /// 驗證 xhtml 格式
    /// </summary>
    /// <param name="xhtml">要驗證的 xhtml 內容</param>
    /// <returns>如果格式正確則為 true，否則為 false</returns>
    private bool IsValidXhtml(string xhtml)
    {
        if (string.IsNullOrEmpty(xhtml))
            return false;

        // 基本的 xhtml 驗證
        // 檢查是否包含必要的 div 標籤
        if (!xhtml.Contains("<div") || !xhtml.Contains("</div>"))
            return false;

        // 檢查是否包含危險的腳本標籤
        if (xhtml.Contains("<script") || xhtml.Contains("javascript:"))
            return false;

        return true;
    }
} 