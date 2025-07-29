using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// ContactDetail - 聯絡詳情
/// 用於描述聯絡資訊
/// </summary>
/// <remarks>
/// FHIR R5 ContactDetail (Complex Type)
/// Specifies contact information for a person or organization.
/// 
/// Structure:
/// - name: string (0..1) - Name of an individual to contact
/// - telecom: ContactPoint[] (0..*) - Contact details for individual or organization
/// </remarks>
public class ContactDetail : UnifiedComplexTypeBase<ContactDetail>
{
    /// <summary>
    /// Name of an individual to contact
    /// FHIR Path: ContactDetail.name
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("name")]
    public FhirString? Name { get; set; }

    /// <summary>
    /// Contact details for individual or organization
    /// FHIR Path: ContactDetail.telecom
    /// Cardinality: 0..*
    /// Type: ContactPoint[]
    /// </summary>
    [JsonPropertyName("telecom")]
    public IList<ContactPoint>? Telecom { get; set; }

    /// <summary>
    /// 檢查是否有聯絡資訊
    /// </summary>
    /// <returns>如果存在聯絡資訊則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasTelecom => Telecom?.Any() == true;

    /// <summary>
    /// 檢查是否有名稱
    /// </summary>
    /// <returns>如果存在名稱則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasName => !string.IsNullOrEmpty(Name?.Value);

    /// <summary>
    /// 檢查聯絡詳情是否有效
    /// </summary>
    /// <returns>如果聯絡詳情有效則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool IsValid => HasName || HasTelecom;

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
            
            if (HasName)
            {
                parts.Add(Name?.Value);
            }
            
            if (HasTelecom)
            {
                var telecomTexts = Telecom?.Select(t => t.DisplayText).Where(t => !string.IsNullOrEmpty(t));
                if (telecomTexts?.Any() == true)
                {
                    parts.Add(string.Join(", ", telecomTexts));
                }
            }
            
            return parts.Any() ? string.Join(" - ", parts) : null;
        }
    }

    /// <summary>
    /// 添加聯絡點
    /// </summary>
    /// <param name="contactPoint">聯絡點</param>
    public void AddTelecom(ContactPoint contactPoint)
    {
        Telecom ??= new List<ContactPoint>();
        Telecom.Add(contactPoint);
    }

    protected override void CopyFieldsTo(ContactDetail target)
    {
        target.Name = Name?.DeepCopy() as FhirString;
        target.Telecom = Telecom?.Select(t => t.DeepCopy() as ContactPoint).ToList();
    }

    protected override bool FieldsAreExactly(ContactDetail other)
    {
        return DeepEqualityComparer.AreEqual(Name, other.Name) &&
               DeepEqualityComparer.AreEqual(Telecom, other.Telecom);
    }

    protected override IEnumerable<ValidationResult> ValidateFields(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // 驗證 Name
        if (Name != null)
        {
            results.AddRange(Name.Validate(validationContext));
        }

        // 驗證 Telecom
        if (Telecom != null)
        {
            foreach (var telecom in Telecom)
            {
                if (telecom != null)
                {
                    results.AddRange(telecom.Validate(validationContext));
                }
            }
        }

        // 驗證聯絡詳情邏輯
        if (!HasName && !HasTelecom)
        {
            results.Add(new ValidationResult("ContactDetail must have either name or telecom"));
        }

        return results;
    }
} 