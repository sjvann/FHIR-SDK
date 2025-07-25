using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// For referring to data content defined in other formats.
/// </summary>
/// <remarks>
/// FHIR R4 Attachment DataType
/// For referring to data content defined in other formats.
/// </remarks>
public class Attachment : DataType
{
    /// <summary>
    /// Mime type of the content, with charset etc.
    /// FHIR Path: Attachment.contentType
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }
    
    /// <summary>
    /// Human language of the content (BCP-47).
    /// FHIR Path: Attachment.language
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
    
    /// <summary>
    /// Data inline, base64ed.
    /// FHIR Path: Attachment.data
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }
    
    /// <summary>
    /// Uri where the data can be found.
    /// FHIR Path: Attachment.url
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    
    /// <summary>
    /// Number of bytes of content (if url provided).
    /// FHIR Path: Attachment.size
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }
    
    /// <summary>
    /// Hash of the data (sha-1, base64ed).
    /// FHIR Path: Attachment.hash
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }
    
    /// <summary>
    /// Label to display in place of the data.
    /// FHIR Path: Attachment.title
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    
    /// <summary>
    /// Date attachment was first created.
    /// FHIR Path: Attachment.creation
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("creation")]
    public string? Creation { get; set; }
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // 驗證 URL 格式
        if (!string.IsNullOrEmpty(Url) && !Uri.IsWellFormedUriString(Url, UriKind.Absolute))
        {
            yield return new ValidationResult($"Attachment.url '{Url}' must be a valid absolute URI");
        }
        
        // 驗證 size 值
        if (Size.HasValue && Size.Value < 0)
        {
            yield return new ValidationResult("Attachment.size must be a non-negative integer");
        }
        
        // 驗證 data 是否為有效的 base64
        if (!string.IsNullOrEmpty(Data))
        {
            if (!IsValidBase64(Data))
            {
                yield return new ValidationResult("Attachment.data must be valid base64 encoded data");
            }
        }

        // 驗證 hash 是否為有效的 base64
        if (!string.IsNullOrEmpty(Hash))
        {
            if (!IsValidBase64(Hash))
            {
                yield return new ValidationResult("Attachment.hash must be valid base64 encoded data");
            }
        }
        
        // 驗證 creation 日期格式
        if (!string.IsNullOrEmpty(Creation) && !DateTime.TryParse(Creation, out _))
        {
            yield return new ValidationResult($"Attachment.creation '{Creation}' is not a valid dateTime");
        }
    }

    /// <summary>
    /// 驗證字串是否為有效的 base64
    /// </summary>
    private bool IsValidBase64(string value)
    {
        try
        {
            Convert.FromBase64String(value);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}
