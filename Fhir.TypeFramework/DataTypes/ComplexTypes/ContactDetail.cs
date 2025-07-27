using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
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
public class ContactDetail : Element, IExtensibleTypeFramework
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
    /// 添加聯絡點
    /// </summary>
    /// <param name="contactPoint">聯絡點</param>
    public void AddTelecom(ContactPoint contactPoint)
    {
        Telecom ??= new List<ContactPoint>();
        Telecom.Add(contactPoint);
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>ContactDetail 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new ContactDetail
        {
            Id = Id,
            Name = Name
        };

        if (Telecom != null)
        {
            copy.Telecom = Telecom.Select(t => t.DeepCopy() as ContactPoint).ToList();
        }

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 ContactDetail 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not ContactDetail otherContact)
            return false;

        return base.IsExactly(other) &&
               Equals(Name, otherContact.Name) &&
               Telecom?.Count == otherContact.Telecom?.Count;
    }

    /// <summary>
    /// 驗證 ContactDetail 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 Telecom
        if (Telecom != null)
        {
            foreach (var telecom in Telecom)
            {
                var telecomValidationContext = new ValidationContext(telecom);
                foreach (var result in telecom.Validate(telecomValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 