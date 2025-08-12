using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using System.ComponentModel.DataAnnotations;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 Organization 資源
    /// </summary>
    public class Organization : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<CodeableConcept>? _type;
        private FhirString? _name;
        private List<FhirString>? _alias;
        private FhirMarkdown? _description;
        private List<ContactPoint>? _contact;
        private ReferenceType? _partOf;
        private List<ReferenceType>? _endpoint;
        private List<OrganizationQualification>? _qualification;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Organization";

        /// <summary>
        /// 識別碼
        /// </summary>
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
        /// 組織類型
        /// </summary>
        public List<CodeableConcept>? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

        /// <summary>
        /// 組織名稱
        /// </summary>
        [Required(ErrorMessage = "組織必須有名稱或識別碼")]
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// 別名
        /// </summary>
        public List<FhirString>? Alias
        {
            get => _alias;
            set
            {
                _alias = value;
                OnPropertyChanged(nameof(Alias));
            }
        }

        /// <summary>
        /// 組織描述
        /// </summary>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        /// <summary>
        /// 聯絡資訊
        /// </summary>
        public List<ContactPoint>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }

        /// <summary>
        /// 上級組織
        /// </summary>
        public ReferenceType? PartOf
        {
            get => _partOf;
            set
            {
                _partOf = value;
                OnPropertyChanged(nameof(PartOf));
            }
        }

        /// <summary>
        /// 服務端點
        /// </summary>
        public List<ReferenceType>? Endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(Endpoint));
            }
        }

        /// <summary>
        /// 資格認證
        /// </summary>
        public List<OrganizationQualification>? Qualification
        {
            get => _qualification;
            set
            {
                _qualification = value;
                OnPropertyChanged(nameof(Qualification));
            }
        }

        /// <summary>
        /// 建立新的 Organization 資源實例
        /// </summary>
        public Organization()
        {
        }

        /// <summary>
        /// 建立新的 Organization 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Organization(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 建立新的 Organization 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <param name="name">組織名稱</param>
        public Organization(string id, string name)
        {
            Id = id;
            Name = new FhirString(name);
            Active = new FhirBoolean(true);
        }

        /// <summary>
        /// 建立新的 Organization 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <param name="name">組織名稱</param>
        /// <param name="type">組織類型</param>
        public Organization(string id, string name, CodeableConcept type)
        {
            Id = id;
            Name = new FhirString(name);
            Type = new List<CodeableConcept> { type };
            Active = new FhirBoolean(true);
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            var displayName = Name?.Value ?? "未命名組織";
            var activeStatus = Active?.Value == true ? "活躍" : Active?.Value == false ? "非活躍" : "狀態未知";
            return $"Organization(Id: {Id}, Name: {displayName}, Status: {activeStatus})";
        }
    }

    /// <summary>
    /// 組織資格認證
    /// </summary>
    public class OrganizationQualification
    {
        /// <summary>
        /// 資格認證識別碼
        /// </summary>
        public List<Identifier>? Identifier { get; set; }

        /// <summary>
        /// 資格認證代碼
        /// </summary>
        public CodeableConcept? Code { get; set; }

        /// <summary>
        /// 有效期間
        /// </summary>
        public Period? Period { get; set; }

        /// <summary>
        /// 發證機構
        /// </summary>
        public ReferenceType? Issuer { get; set; }

        public OrganizationQualification() { }

        public OrganizationQualification(CodeableConcept code)
        {
            Code = code;
        }
    }
}