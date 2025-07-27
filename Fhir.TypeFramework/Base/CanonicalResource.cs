using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.Base;

/// <summary>
/// CanonicalResource - 規範資源
/// 具有規範性質的 FHIR 資源基礎類別
/// </summary>
/// <remarks>
/// FHIR R5 CanonicalResource (Abstract)
/// A resource that is defined as part of the FHIR specification and has a canonical URL.
/// Canonical resources are those that have a canonical URL and can be referenced by other resources.
/// They include resources like StructureDefinition, ValueSet, CodeSystem, etc.
/// 
/// Structure:
/// - url: uri (0..1) - Canonical identifier for this resource
/// - identifier: Identifier[] (0..*) - Additional identifier for the resource
/// - version: string (0..1) - Business version of the resource
/// - versionAlgorithm[x]: string|Coding (0..1) - How to compare versions
/// - name: string (0..1) - Name for this resource (computer friendly)
/// - title: string (0..1) - Name for this resource (human friendly)
/// - status: code (1..1) - draft | active | retired | unknown
/// - experimental: boolean (0..1) - For testing purposes, not real usage
/// - date: dateTime (0..1) - Date last changed
/// - publisher: string (0..1) - Name of the publisher
/// - contact: ContactDetail[] (0..*) - Contact details for the publisher
/// - description: markdown (0..1) - Natural language description of the resource
/// - useContext: UsageContext[] (0..*) - The context that the content is intended to support
/// - jurisdiction: CodeableConcept[] (0..*) - Intended jurisdiction for resource
/// - purpose: markdown (0..1) - Why this resource is defined
/// - copyright: markdown (0..1) - Use and/or publishing restrictions
/// - copyrightLabel: string (0..1) - Copyright holder and year(s)
/// </remarks>
public abstract class CanonicalResource : DomainResource, ICanonicalResource
{
    /// <summary>
    /// Canonical identifier for this resource, represented as a URI
    /// FHIR Path: CanonicalResource.url
    /// Cardinality: 0..1
    /// Type: uri
    /// </summary>
    [JsonPropertyName("url")]
    public FhirUri? Url { get; set; }

    /// <summary>
    /// Additional identifier for the resource
    /// FHIR Path: CanonicalResource.identifier
    /// Cardinality: 0..*
    /// Type: Identifier[]
    /// </summary>
    [JsonPropertyName("identifier")]
    public IList<Identifier>? Identifier { get; set; }

    /// <summary>
    /// Business version of the resource
    /// FHIR Path: CanonicalResource.version
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("version")]
    public FhirString? Version { get; set; }

    /// <summary>
    /// How to compare versions
    /// FHIR Path: CanonicalResource.versionAlgorithm[x]
    /// Cardinality: 0..1
    /// Type: string|Coding
    /// </summary>
    [JsonPropertyName("versionAlgorithmString")]
    public FhirString? VersionAlgorithmString { get; set; }

    [JsonPropertyName("versionAlgorithmCoding")]
    public Coding? VersionAlgorithmCoding { get; set; }

    /// <summary>
    /// Name for this resource (computer friendly)
    /// FHIR Path: CanonicalResource.name
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("name")]
    public FhirString? Name { get; set; }

    /// <summary>
    /// Name for this resource (human friendly)
    /// FHIR Path: CanonicalResource.title
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("title")]
    public FhirString? Title { get; set; }

    /// <summary>
    /// draft | active | retired | unknown
    /// FHIR Path: CanonicalResource.status
    /// Cardinality: 1..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; } = new();

    /// <summary>
    /// For testing purposes, not real usage
    /// FHIR Path: CanonicalResource.experimental
    /// Cardinality: 0..1
    /// Type: boolean
    /// </summary>
    [JsonPropertyName("experimental")]
    public FhirBoolean? Experimental { get; set; }

    /// <summary>
    /// Date last changed
    /// FHIR Path: CanonicalResource.date
    /// Cardinality: 0..1
    /// Type: dateTime
    /// </summary>
    [JsonPropertyName("date")]
    public FhirDateTime? Date { get; set; }

    /// <summary>
    /// Name of the publisher (organization or individual)
    /// FHIR Path: CanonicalResource.publisher
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("publisher")]
    public FhirString? Publisher { get; set; }

    /// <summary>
    /// Contact details for the publisher
    /// FHIR Path: CanonicalResource.contact
    /// Cardinality: 0..*
    /// Type: ContactDetail[]
    /// </summary>
    [JsonPropertyName("contact")]
    public IList<ContactDetail>? Contact { get; set; }

    /// <summary>
    /// Natural language description of the resource
    /// FHIR Path: CanonicalResource.description
    /// Cardinality: 0..1
    /// Type: markdown
    /// </summary>
    [JsonPropertyName("description")]
    public FhirMarkdown? Description { get; set; }

    /// <summary>
    /// The context that the content is intended to support
    /// FHIR Path: CanonicalResource.useContext
    /// Cardinality: 0..*
    /// Type: UsageContext[]
    /// </summary>
    [JsonPropertyName("useContext")]
    public IList<UsageContext>? UseContext { get; set; }

    /// <summary>
    /// Intended jurisdiction for resource (if applicable)
    /// FHIR Path: CanonicalResource.jurisdiction
    /// Cardinality: 0..*
    /// Type: CodeableConcept[]
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public IList<CodeableConcept>? Jurisdiction { get; set; }

    /// <summary>
    /// Why this resource is defined
    /// FHIR Path: CanonicalResource.purpose
    /// Cardinality: 0..1
    /// Type: markdown
    /// </summary>
    [JsonPropertyName("purpose")]
    public FhirMarkdown? Purpose { get; set; }

    /// <summary>
    /// Use and/or publishing restrictions
    /// FHIR Path: CanonicalResource.copyright
    /// Cardinality: 0..1
    /// Type: markdown
    /// </summary>
    [JsonPropertyName("copyright")]
    public FhirMarkdown? Copyright { get; set; }

    /// <summary>
    /// Copyright holder and year(s)
    /// FHIR Path: CanonicalResource.copyrightLabel
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("copyrightLabel")]
    public FhirString? CopyrightLabel { get; set; }

    /// <summary>
    /// 檢查是否有 URL
    /// </summary>
    /// <returns>如果存在 URL 則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasUrl => !string.IsNullOrEmpty(Url);

    /// <summary>
    /// 檢查是否有識別碼
    /// </summary>
    /// <returns>如果存在識別碼則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasIdentifier => Identifier?.Any() == true;

    /// <summary>
    /// 檢查是否有版本
    /// </summary>
    /// <returns>如果存在版本則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasVersion => !string.IsNullOrEmpty(Version);

    /// <summary>
    /// 檢查是否有版本演算法
    /// </summary>
    /// <returns>如果存在版本演算法則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasVersionAlgorithm => VersionAlgorithmString != null || VersionAlgorithmCoding != null;

    /// <summary>
    /// 檢查是否有聯絡資訊
    /// </summary>
    /// <returns>如果存在聯絡資訊則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasContact => Contact?.Any() == true;

    /// <summary>
    /// 檢查是否有使用上下文
    /// </summary>
    /// <returns>如果存在使用上下文則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasUseContext => UseContext?.Any() == true;

    /// <summary>
    /// 檢查是否有管轄權
    /// </summary>
    /// <returns>如果存在管轄權則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasJurisdiction => Jurisdiction?.Any() == true;

    /// <summary>
    /// 設定版本演算法為字串
    /// </summary>
    /// <param name="algorithm">版本演算法字串</param>
    public void SetVersionAlgorithm(string algorithm)
    {
        VersionAlgorithmString = algorithm;
        VersionAlgorithmCoding = null;
    }

    /// <summary>
    /// 設定版本演算法為編碼
    /// </summary>
    /// <param name="algorithm">版本演算法編碼</param>
    public void SetVersionAlgorithm(Coding algorithm)
    {
        VersionAlgorithmString = null;
        VersionAlgorithmCoding = algorithm;
    }

    /// <summary>
    /// 添加識別碼
    /// </summary>
    /// <param name="identifier">識別碼</param>
    public void AddIdentifier(Identifier identifier)
    {
        Identifier ??= new List<Identifier>();
        Identifier.Add(identifier);
    }

    /// <summary>
    /// 添加聯絡資訊
    /// </summary>
    /// <param name="contact">聯絡資訊</param>
    public void AddContact(ContactDetail contact)
    {
        Contact ??= new List<ContactDetail>();
        Contact.Add(contact);
    }

    /// <summary>
    /// 添加使用上下文
    /// </summary>
    /// <param name="usageContext">使用上下文</param>
    public void AddUseContext(UsageContext usageContext)
    {
        UseContext ??= new List<UsageContext>();
        UseContext.Add(usageContext);
    }

    /// <summary>
    /// 添加管轄權
    /// </summary>
    /// <param name="jurisdiction">管轄權</param>
    public void AddJurisdiction(CodeableConcept jurisdiction)
    {
        Jurisdiction ??= new List<CodeableConcept>();
        Jurisdiction.Add(jurisdiction);
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>CanonicalResource 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = (CanonicalResource)MemberwiseClone();

        // 深層複製 Identifier
        if (Identifier != null)
        {
            copy.Identifier = Identifier.Select(i => i.DeepCopy() as Identifier).ToList();
        }

        // 深層複製 VersionAlgorithmCoding
        if (VersionAlgorithmCoding != null)
        {
            copy.VersionAlgorithmCoding = VersionAlgorithmCoding.DeepCopy() as Coding;
        }

        // 深層複製 Contact
        if (Contact != null)
        {
            copy.Contact = Contact.Select(c => c.DeepCopy() as ContactDetail).ToList();
        }

        // 深層複製 UseContext
        if (UseContext != null)
        {
            copy.UseContext = UseContext.Select(uc => uc.DeepCopy() as UsageContext).ToList();
        }

        // 深層複製 Jurisdiction
        if (Jurisdiction != null)
        {
            copy.Jurisdiction = Jurisdiction.Select(j => j.DeepCopy() as CodeableConcept).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 CanonicalResource 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not CanonicalResource otherCanonical)
            return false;

        return base.IsExactly(other) &&
               Equals(Url, otherCanonical.Url) &&
               Equals(Version, otherCanonical.Version) &&
               Equals(VersionAlgorithmString, otherCanonical.VersionAlgorithmString) &&
               Equals(VersionAlgorithmCoding, otherCanonical.VersionAlgorithmCoding) &&
               Equals(Name, otherCanonical.Name) &&
               Equals(Title, otherCanonical.Title) &&
               Equals(Status, otherCanonical.Status) &&
               Equals(Experimental, otherCanonical.Experimental) &&
               Equals(Date, otherCanonical.Date) &&
               Equals(Publisher, otherCanonical.Publisher) &&
               Equals(Description, otherCanonical.Description) &&
               Equals(Purpose, otherCanonical.Purpose) &&
               Equals(Copyright, otherCanonical.Copyright) &&
               Equals(CopyrightLabel, otherCanonical.CopyrightLabel) &&
               Identifier?.Count == otherCanonical.Identifier?.Count &&
               Contact?.Count == otherCanonical.Contact?.Count &&
               UseContext?.Count == otherCanonical.UseContext?.Count &&
               Jurisdiction?.Count == otherCanonical.Jurisdiction?.Count;
    }

    /// <summary>
    /// 驗證 CanonicalResource 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 Status（必填）
        if (string.IsNullOrEmpty(Status))
        {
            yield return new ValidationResult("CanonicalResource.status is required");
        }
        else
        {
            var validStatuses = new[] { "draft", "active", "retired", "unknown" };
            if (!validStatuses.Contains(Status))
            {
                yield return new ValidationResult($"CanonicalResource.status '{Status}' is not a valid status");
            }
        }

        // 驗證 URL 格式
        if (!string.IsNullOrEmpty(Url) && !Uri.IsWellFormedUriString(Url, UriKind.Absolute))
        {
            yield return new ValidationResult($"CanonicalResource.url '{Url}' must be a valid absolute URI");
        }

        // 驗證 VersionAlgorithm（只能有一個）
        if (VersionAlgorithmString != null && VersionAlgorithmCoding != null)
        {
            yield return new ValidationResult("CanonicalResource can only have one versionAlgorithm");
        }

        // 驗證 Identifier
        if (Identifier != null)
        {
            foreach (var identifier in Identifier)
            {
                var identifierValidationContext = new ValidationContext(identifier);
                foreach (var result in identifier.Validate(identifierValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 驗證 VersionAlgorithmCoding
        if (VersionAlgorithmCoding != null)
        {
            var codingValidationContext = new ValidationContext(VersionAlgorithmCoding);
            foreach (var result in VersionAlgorithmCoding.Validate(codingValidationContext))
            {
                yield return result;
            }
        }

        // 驗證 Contact
        if (Contact != null)
        {
            foreach (var contact in Contact)
            {
                var contactValidationContext = new ValidationContext(contact);
                foreach (var result in contact.Validate(contactValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 驗證 UseContext
        if (UseContext != null)
        {
            foreach (var usageContext in UseContext)
            {
                var usageContextValidationContext = new ValidationContext(usageContext);
                foreach (var result in usageContext.Validate(usageContextValidationContext))
                {
                    yield return result;
                }
            }
        }

        // 驗證 Jurisdiction
        if (Jurisdiction != null)
        {
            foreach (var jurisdiction in Jurisdiction)
            {
                var jurisdictionValidationContext = new ValidationContext(jurisdiction);
                foreach (var result in jurisdiction.Validate(jurisdictionValidationContext))
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