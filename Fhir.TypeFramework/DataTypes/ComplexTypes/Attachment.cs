using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Attachment - 附件型別
/// 用於在 FHIR 資源中表示附件資料（如檔案或影像）
/// </summary>
/// <remarks>
/// FHIR R5 Attachment (Complex Type)
/// For referring to data content defined in other formats.
/// 
/// Structure:
/// - contentType: code (0..1) - Mime type of the content, with charset etc.
/// - language: code (0..1) - Human language of the content (BCP-47)
/// - data: base64Binary (0..1) - Data inline, base64ed
/// - url: url (0..1) - Uri where the data can be found
/// - size: integer64 (0..1) - Number of bytes of content (if url provided)
/// - hash: base64Binary (0..1) - Hash of the data (sha-1, base64ed)
/// - title: string (0..1) - Label to display in place of the data
/// - creation: dateTime (0..1) - Date attachment was first created
/// - height: positiveInt (0..1) - Height of the image in pixels (photo/video)
/// - width: positiveInt (0..1) - Width of the image in pixels (photo/video)
/// - frames: positiveInt (0..1) - Number of frames if &gt; 1 (photo)
/// - duration: decimal (0..1) - Length in seconds (audio / video)
/// - pages: positiveInt (0..1) - Number of printed pages
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Attachment : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 內容的 MIME 類型，包含字符集等
    /// FHIR Path: Attachment.contentType
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("contentType")]
    public FhirCode? ContentType { get; set; }

    /// <summary>
    /// 內容的人類語言（BCP-47）
    /// FHIR Path: Attachment.language
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("language")]
    public FhirCode? Language { get; set; }

    /// <summary>
    /// 內嵌資料，base64 編碼
    /// FHIR Path: Attachment.data
    /// Cardinality: 0..1
    /// Type: base64Binary
    /// </summary>
    [JsonPropertyName("data")]
    public FhirBase64Binary? Data { get; set; }

    /// <summary>
    /// 可找到資料的 URI
    /// FHIR Path: Attachment.url
    /// Cardinality: 0..1
    /// Type: url
    /// </summary>
    [JsonPropertyName("url")]
    public FhirUrl? Url { get; set; }

    /// <summary>
    /// 內容的位元組數（如果提供了 url）
    /// FHIR Path: Attachment.size
    /// Cardinality: 0..1
    /// Type: integer64
    /// </summary>
    [JsonPropertyName("size")]
    public FhirInteger64? Size { get; set; }

    /// <summary>
    /// 資料的雜湊值（sha-1，base64 編碼）
    /// FHIR Path: Attachment.hash
    /// Cardinality: 0..1
    /// Type: base64Binary
    /// </summary>
    [JsonPropertyName("hash")]
    public FhirBase64Binary? Hash { get; set; }

    /// <summary>
    /// 顯示在資料位置的標籤
    /// FHIR Path: Attachment.title
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("title")]
    public FhirString? Title { get; set; }

    /// <summary>
    /// 附件首次建立的日期
    /// FHIR Path: Attachment.creation
    /// Cardinality: 0..1
    /// Type: dateTime
    /// </summary>
    [JsonPropertyName("creation")]
    public FhirDateTime? Creation { get; set; }

    /// <summary>
    /// 影像高度（像素）（照片/影片）
    /// FHIR Path: Attachment.height
    /// Cardinality: 0..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("height")]
    public FhirPositiveInt? Height { get; set; }

    /// <summary>
    /// 影像寬度（像素）（照片/影片）
    /// FHIR Path: Attachment.width
    /// Cardinality: 0..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("width")]
    public FhirPositiveInt? Width { get; set; }

    /// <summary>
    /// 如果大於 1 的幀數（照片）
    /// FHIR Path: Attachment.frames
    /// Cardinality: 0..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("frames")]
    public FhirPositiveInt? Frames { get; set; }

    /// <summary>
    /// 長度（秒）（音訊/影片）
    /// FHIR Path: Attachment.duration
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("duration")]
    public FhirDecimal? Duration { get; set; }

    /// <summary>
    /// 列印頁數
    /// FHIR Path: Attachment.pages
    /// Cardinality: 0..1
    /// Type: positiveInt
    /// </summary>
    [JsonPropertyName("pages")]
    public FhirPositiveInt? Pages { get; set; }

    /// <summary>
    /// 檢查是否有內容類型
    /// </summary>
    /// <returns>如果存在內容類型則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasContentType => !string.IsNullOrEmpty(ContentType?.Value);

    /// <summary>
    /// 檢查是否有資料
    /// </summary>
    /// <returns>如果存在資料則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasData => Data?.Value != null && Data.Value.Length > 0;

    /// <summary>
    /// 檢查是否有 URL
    /// </summary>
    /// <returns>如果存在 URL 則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasUrl => !string.IsNullOrEmpty(Url?.Value);

    /// <summary>
    /// 檢查是否有標題
    /// </summary>
    /// <returns>如果存在標題則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasTitle => !string.IsNullOrEmpty(Title?.Value);

    /// <summary>
    /// 檢查是否有尺寸資訊
    /// </summary>
    /// <returns>如果存在尺寸資訊則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDimensions => Height?.Value != null || Width?.Value != null;

    /// <summary>
    /// 取得顯示文字
    /// </summary>
    /// <returns>顯示文字</returns>
    [JsonIgnore]
    public string? DisplayText
    {
        get
        {
            if (HasTitle)
            {
                return Title?.Value;
            }

            var parts = new List<string>();

            if (HasContentType)
            {
                parts.Add(ContentType?.Value);
            }

            if (HasUrl)
            {
                parts.Add(Url?.Value);
            }

            if (Size?.Value != null)
            {
                parts.Add($"{Size.Value} bytes");
            }

            return parts.Count > 0 ? string.Join(" - ", parts) : null;
        }
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Attachment 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Attachment
        {
            Id = Id,
            ContentType = ContentType?.DeepCopy() as FhirCode,
            Language = Language?.DeepCopy() as FhirCode,
            Data = Data?.DeepCopy() as FhirBase64Binary,
            Url = Url?.DeepCopy() as FhirUrl,
            Size = Size?.DeepCopy() as FhirInteger64,
            Hash = Hash?.DeepCopy() as FhirBase64Binary,
            Title = Title?.DeepCopy() as FhirString,
            Creation = Creation?.DeepCopy() as FhirDateTime,
            Height = Height?.DeepCopy() as FhirPositiveInt,
            Width = Width?.DeepCopy() as FhirPositiveInt,
            Frames = Frames?.DeepCopy() as FhirPositiveInt,
            Duration = Duration?.DeepCopy() as FhirDecimal,
            Pages = Pages?.DeepCopy() as FhirPositiveInt
        };

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Attachment 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Attachment otherAttachment)
            return false;

        return base.IsExactly(other) &&
               Equals(ContentType, otherAttachment.ContentType) &&
               Equals(Language, otherAttachment.Language) &&
               Equals(Data, otherAttachment.Data) &&
               Equals(Url, otherAttachment.Url) &&
               Equals(Size, otherAttachment.Size) &&
               Equals(Hash, otherAttachment.Hash) &&
               Equals(Title, otherAttachment.Title) &&
               Equals(Creation, otherAttachment.Creation) &&
               Equals(Height, otherAttachment.Height) &&
               Equals(Width, otherAttachment.Width) &&
               Equals(Frames, otherAttachment.Frames) &&
               Equals(Duration, otherAttachment.Duration) &&
               Equals(Pages, otherAttachment.Pages);
    }

    /// <summary>
    /// 驗證 Attachment 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證必須有資料或 URL
        if (!HasData && !HasUrl)
        {
            yield return new ValidationResult("Attachment must have either data or url");
        }

        // 驗證 URL 格式（如果提供）
        if (HasUrl)
        {
            if (!Uri.IsWellFormedUriString(Url!.Value, UriKind.Absolute))
            {
                yield return new ValidationResult("Attachment URL must be a well-formed absolute URI");
            }
        }

        // 驗證尺寸值（如果提供）
        if (Height?.Value != null && Height.Value <= 0)
        {
            yield return new ValidationResult("Attachment height must be a positive integer");
        }

        if (Width?.Value != null && Width.Value <= 0)
        {
            yield return new ValidationResult("Attachment width must be a positive integer");
        }

        if (Frames?.Value != null && Frames.Value <= 0)
        {
            yield return new ValidationResult("Attachment frames must be a positive integer");
        }

        if (Pages?.Value != null && Pages.Value <= 0)
        {
            yield return new ValidationResult("Attachment pages must be a positive integer");
        }

        // 驗證持續時間（如果提供）
        if (Duration?.Value != null && Duration.Value < 0)
        {
            yield return new ValidationResult("Attachment duration must be non-negative");
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 