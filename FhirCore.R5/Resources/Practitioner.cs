using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 Practitioner 資源
    /// 
    /// <para>
    /// 用於記錄醫療從業人員的基本資訊，包括醫師、護理師、技師等各種醫療專業人員。
    /// 提供人員的識別資訊、聯絡方式、專業資格等重要資料。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var practitioner = new Practitioner("practitioner-001")
    /// {
    ///     Name = new List&lt;HumanName&gt; 
    ///     {
    ///         new HumanName
    ///         {
    ///             Family = new FhirString("陳"),
    ///             Given = new List&lt;FhirString&gt; { new FhirString("大明") },
    ///             Use = new FhirCode("official")
    ///         }
    ///     },
    ///     Active = new FhirBoolean(true),
    ///     Gender = new FhirCode("male")
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Practitioner 資源是 FHIR 中記錄醫療從業人員的核心資源，
    /// 用於建立人員與醫療行為、處方、診斷等的關聯。
    /// </para>
    /// 
    /// <para>
    /// R5 版本的主要特點：
    /// - 支援多種名稱格式和用途
    /// - 增強的聯絡資訊管理
    /// - 完整的專業資格記錄
    /// - 支援多語言溝通能力記錄
    /// </para>
    /// </remarks>
    public class Practitioner : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private FhirCode? _gender;
        private FhirDate? _birthDate;
        private PractitionerDeceasedChoice? _deceased;
        private List<Address>? _address;
        private List<Attachment>? _photo;
        private List<PractitionerQualification>? _qualification;
        private List<PractitionerCommunication>? _communication;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Practitioner";

        /// <summary>
        /// 識別碼
        /// </summary>
        /// <remarks>
        /// <para>
        /// 醫療從業人員的各種識別碼，如醫師執照號碼、員工編號等。
        /// </para>
        /// </remarks>
        public List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }

        /// <summary>
        /// 是否為活躍狀態
        /// </summary>
        /// <remarks>
        /// <para>
        /// 指示此從業人員是否仍在執業中。
        /// false 表示已退休、停業或離職。
        /// </para>
        /// </remarks>
        public FhirBoolean? Active
        {
            get => _active;
            set
            {
                _active = value;
                OnPropertyChanged(nameof(Active));
            }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        /// <remarks>
        /// <para>
        /// 從業人員的姓名資訊，可包含多個名稱（如正式名稱、暱稱等）。
        /// </para>
        /// </remarks>
        public List<HumanName>? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// 聯絡方式
        /// </summary>
        /// <remarks>
        /// <para>
        /// 包含電話、電子郵件等聯絡資訊。
        /// </para>
        /// </remarks>
        public List<ContactPoint>? Telecom
        {
            get => _telecom;
            set
            {
                _telecom = value;
                OnPropertyChanged(nameof(Telecom));
            }
        }

        /// <summary>
        /// 性別
        /// </summary>
        /// <remarks>
        /// <para>
        /// 行政性別，通常為 male、female、other 或 unknown。
        /// </para>
        /// </remarks>
        public FhirCode? Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        /// <summary>
        /// 出生日期
        /// </summary>
        public FhirDate? BirthDate
        {
            get => _birthDate;
            set
            {
                _birthDate = value;
                OnPropertyChanged(nameof(BirthDate));
            }
        }

        /// <summary>
        /// 死亡狀態
        /// </summary>
        /// <remarks>
        /// <para>
        /// 可以是布林值（是否死亡）或具體的死亡時間。
        /// </para>
        /// </remarks>
        public PractitionerDeceasedChoice? Deceased
        {
            get => _deceased;
            set
            {
                _deceased = value;
                OnPropertyChanged(nameof(Deceased));
            }
        }

        /// <summary>
        /// 地址
        /// </summary>
        public List<Address>? Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        /// <summary>
        /// 照片
        /// </summary>
        public List<Attachment>? Photo
        {
            get => _photo;
            set
            {
                _photo = value;
                OnPropertyChanged(nameof(Photo));
            }
        }

        /// <summary>
        /// 專業資格
        /// </summary>
        /// <remarks>
        /// <para>
        /// 從業人員的專業資格、證照、學位等資訊。
        /// </para>
        /// </remarks>
        public List<PractitionerQualification>? Qualification
        {
            get => _qualification;
            set
            {
                _qualification = value;
                OnPropertyChanged(nameof(Qualification));
            }
        }

        /// <summary>
        /// 溝通語言
        /// </summary>
        /// <remarks>
        /// <para>
        /// 從業人員能夠使用的語言及偏好設定。
        /// </para>
        /// </remarks>
        public List<PractitionerCommunication>? Communication
        {
            get => _communication;
            set
            {
                _communication = value;
                OnPropertyChanged(nameof(Communication));
            }
        }

        /// <summary>
        /// 建立新的 Practitioner 資源實例
        /// </summary>
        public Practitioner()
        {
        }

        /// <summary>
        /// 建立新的 Practitioner 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Practitioner(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 建立新的 Practitioner 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <param name="familyName">姓氏</param>
        /// <param name="givenName">名字</param>
        public Practitioner(string id, string familyName, string givenName)
        {
            Id = id;
            Name = new List<HumanName>
            {
                new HumanName
                {
                    Family = new FhirString(familyName),
                    Given = new List<FhirString> { new FhirString(givenName) },
                    Use = new FhirCode("official")
                }
            };
            Active = new FhirBoolean(true);
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            var displayName = "未命名醫療人員";
            if (Name?.Count > 0)
            {
                var primaryName = Name[0];
                var family = primaryName.Family?.Value ?? "";
                var given = primaryName.Given?.FirstOrDefault()?.Value ?? "";
                displayName = $"{family}{given}".Trim();
                if (string.IsNullOrEmpty(displayName))
                {
                    displayName = primaryName.Text?.Value ?? "未命名醫療人員";
                }
            }

            var activeStatus = Active?.Value == true ? "執業中" : Active?.Value == false ? "非執業" : "狀態未知";
            return $"Practitioner(Id: {Id}, Name: {displayName}, Status: {activeStatus})";
        }
    }

    /// <summary>
    /// 醫療從業人員專業資格
    /// </summary>
    /// <remarks>
    /// <para>
    /// 記錄從業人員的專業資格、證照、學位等相關資訊。
    /// </para>
    /// </remarks>
    public class PractitionerQualification
    {
        /// <summary>
        /// 資格識別碼
        /// </summary>
        public List<Identifier>? Identifier { get; set; }

        /// <summary>
        /// 資格代碼
        /// </summary>
        /// <remarks>
        /// <para>
        /// 描述資格類型的代碼，如醫師執照、護理師執照等。
        /// </para>
        /// </remarks>
        public CodeableConcept? Code { get; set; }

        /// <summary>
        /// 有效期間
        /// </summary>
        public Period? Period { get; set; }

        /// <summary>
        /// 發證機構
        /// </summary>
        public ReferenceType? Issuer { get; set; }

        public PractitionerQualification() { }

        public PractitionerQualification(CodeableConcept code)
        {
            Code = code;
        }
    }

    /// <summary>
    /// 醫療從業人員溝通語言
    /// </summary>
    /// <remarks>
    /// <para>
    /// 記錄從業人員能夠使用的語言及其偏好程度。
    /// </para>
    /// </remarks>
    public class PractitionerCommunication
    {
        /// <summary>
        /// 語言
        /// </summary>
        /// <remarks>
        /// <para>
        /// 使用 ISO 639-1 或 BCP 47 語言代碼。
        /// </para>
        /// </remarks>
        public CodeableConcept? Language { get; set; }

        /// <summary>
        /// 是否為偏好語言
        /// </summary>
        public FhirBoolean? Preferred { get; set; }

        public PractitionerCommunication() { }

        public PractitionerCommunication(CodeableConcept language, bool preferred = false)
        {
            Language = language;
            Preferred = new FhirBoolean(preferred);
        }
    }

    /// <summary>
    /// Practitioner 死亡狀態選擇類型
    /// </summary>
    /// <remarks>
    /// <para>
    /// 可以是布林值（表示是否死亡）或具體的死亡日期時間。
    /// </para>
    /// </remarks>
    public class PractitionerDeceasedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "boolean", "dateTime" };

        public PractitionerDeceasedChoice(JsonObject value) : base("deceased", value, _supportType) { }
        public PractitionerDeceasedChoice(IComplexType? value) : base("deceased", value) { }
        public PractitionerDeceasedChoice(IPrimitiveType? value) : base("deceased", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Deceased" : "deceased";

        public override List<string> SetSupportDataType() => _supportType;
    }
}