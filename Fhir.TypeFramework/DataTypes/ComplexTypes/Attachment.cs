using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
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
public class Attachment : UnifiedComplexTypeBase<Attachment>
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
    /// 內聯資料，base64 編碼
    /// FHIR Path: Attachment.data
    /// Cardinality: 0..1
    /// Type: base64Binary
    /// </summary>
    [JsonPropertyName("data")]
    public FhirBase64Binary? Data { get; set; }

    /// <summary>
    /// 可以找到資料的 URI
    /// FHIR Path: Attachment.url
    /// Cardinality: 0..1
    /// Type: url
    /// </summary>
    [JsonPropertyName("url")]
    public FhirUrl? Url { get; set; }

    /// <summary>
    /// 內容的位元組數（如果提供 url）
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
    /// 幀數（如果 &gt; 1）（照片）
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
    /// 檢查是否有語言
    /// </summary>
    /// <returns>如果存在語言則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasLanguage => !string.IsNullOrEmpty(Language?.Value);

    /// <summary>
    /// 檢查是否有資料
    /// </summary>
    /// <returns>如果存在資料則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasData => Data != null;

    /// <summary>
    /// 檢查是否有 URL
    /// </summary>
    /// <returns>如果存在 URL 則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasUrl => !string.IsNullOrEmpty(Url?.Value);

    /// <summary>
    /// 檢查是否有大小
    /// </summary>
    /// <returns>如果存在大小則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasSize => Size?.Value != null;

    /// <summary>
    /// 檢查是否有雜湊
    /// </summary>
    /// <returns>如果存在雜湊則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasHash => Hash != null;

    /// <summary>
    /// 檢查是否有標題
    /// </summary>
    /// <returns>如果存在標題則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasTitle => !string.IsNullOrEmpty(Title?.Value);

    /// <summary>
    /// 檢查是否有建立日期
    /// </summary>
    /// <returns>如果存在建立日期則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCreation => Creation?.Value != null;

    /// <summary>
    /// 檢查是否有高度
    /// </summary>
    /// <returns>如果存在高度則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasHeight => Height?.Value != null;

    /// <summary>
    /// 檢查是否有寬度
    /// </summary>
    /// <returns>如果存在寬度則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasWidth => Width?.Value != null;

    /// <summary>
    /// 檢查是否有幀數
    /// </summary>
    /// <returns>如果存在幀數則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasFrames => Frames?.Value != null;

    /// <summary>
    /// 檢查是否有持續時間
    /// </summary>
    /// <returns>如果存在持續時間則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasDuration => Duration?.Value != null;

    /// <summary>
    /// 檢查是否有頁數
    /// </summary>
    /// <returns>如果存在頁數則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasPages => Pages?.Value != null;

    /// <summary>
    /// 檢查附件是否有效
    /// </summary>
    /// <returns>如果附件有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => HasData || HasUrl;

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

            if (HasContentType)
            {
                return ContentType?.Value;
            }

            if (HasUrl)
            {
                return Url?.Value;
            }

            return "Attachment";
        }
    }

    protected override void CopyFieldsTo(Attachment target)
    {
        target.ContentType = ContentType?.DeepCopy() as FhirCode;
        target.Language = Language?.DeepCopy() as FhirCode;
        target.Data = Data?.DeepCopy() as FhirBase64Binary;
        target.Url = Url?.DeepCopy() as FhirUrl;
        target.Size = Size?.DeepCopy() as FhirInteger64;
        target.Hash = Hash?.DeepCopy() as FhirBase64Binary;
        target.Title = Title?.DeepCopy() as FhirString;
        target.Creation = Creation?.DeepCopy() as FhirDateTime;
        target.Height = Height?.DeepCopy() as FhirPositiveInt;
        target.Width = Width?.DeepCopy() as FhirPositiveInt;
        target.Frames = Frames?.DeepCopy() as FhirPositiveInt;
        target.Duration = Duration?.DeepCopy() as FhirDecimal;
        target.Pages = Pages?.DeepCopy() as FhirPositiveInt;
    }

    protected override bool FieldsAreExactly(Attachment other)
    {
        return DeepEqualityComparer.AreEqual(ContentType, other.ContentType) &&
               DeepEqualityComparer.AreEqual(Language, other.Language) &&
               DeepEqualityComparer.AreEqual(Data, other.Data) &&
               DeepEqualityComparer.AreEqual(Url, other.Url) &&
               DeepEqualityComparer.AreEqual(Size, other.Size) &&
               DeepEqualityComparer.AreEqual(Hash, other.Hash) &&
               DeepEqualityComparer.AreEqual(Title, other.Title) &&
               DeepEqualityComparer.AreEqual(Creation, other.Creation) &&
               DeepEqualityComparer.AreEqual(Height, other.Height) &&
               DeepEqualityComparer.AreEqual(Width, other.Width) &&
               DeepEqualityComparer.AreEqual(Frames, other.Frames) &&
               DeepEqualityComparer.AreEqual(Duration, other.Duration) &&
               DeepEqualityComparer.AreEqual(Pages, other.Pages);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 ContentType
        if (ContentType != null)
        {
            results.AddRange(ContentType.Validate(validationContext));
        }

        // 驗證 Language
        if (Language != null)
        {
            results.AddRange(Language.Validate(validationContext));
        }

        // 驗證 Data
        if (Data != null)
        {
            results.AddRange(Data.Validate(validationContext));
        }

        // 驗證 Url
        if (Url != null)
        {
            results.AddRange(Url.Validate(validationContext));
        }

        // 驗證 Size
        if (Size != null)
        {
            results.AddRange(Size.Validate(validationContext));
        }

        // 驗證 Hash
        if (Hash != null)
        {
            results.AddRange(Hash.Validate(validationContext));
        }

        // 驗證 Title
        if (Title != null)
        {
            results.AddRange(Title.Validate(validationContext));
        }

        // 驗證 Creation
        if (Creation != null)
        {
            results.AddRange(Creation.Validate(validationContext));
        }

        // 驗證 Height
        if (Height != null)
        {
            results.AddRange(Height.Validate(validationContext));
        }

        // 驗證 Width
        if (Width != null)
        {
            results.AddRange(Width.Validate(validationContext));
        }

        // 驗證 Frames
        if (Frames != null)
        {
            results.AddRange(Frames.Validate(validationContext));
        }

        // 驗證 Duration
        if (Duration != null)
        {
            results.AddRange(Duration.Validate(validationContext));
        }

        // 驗證 Pages
        if (Pages != null)
        {
            results.AddRange(Pages.Validate(validationContext));
        }

        // 驗證附件邏輯
        if (!HasData && !HasUrl)
        {
            results.Add(new ValidationResult("Attachment must have either data or url"));
        }

        return results;
    }
} 