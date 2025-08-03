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
    /// FHIR R5 HealthcareService 資源
    /// 
    /// <para>
    /// HealthcareService 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var healthcareservice = new HealthcareService("healthcareservice-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 HealthcareService 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class HealthcareService : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _providedby;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _offeredin;
        private List<CodeableConcept>? _category;
        private List<CodeableConcept>? _type;
        private List<CodeableConcept>? _specialty;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _location;
        private FhirString? _name;
        private FhirMarkdown? _comment;
        private FhirMarkdown? _extradetails;
        private Attachment? _photo;
        private List<ExtendedContactDetail>? _contact;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _coveragearea;
        private List<CodeableConcept>? _serviceprovisioncode;
        private List<HealthcareServiceEligibility>? _eligibility;
        private List<CodeableConcept>? _program;
        private List<CodeableConcept>? _characteristic;
        private List<CodeableConcept>? _communication;
        private List<CodeableConcept>? _referralmethod;
        private FhirBoolean? _appointmentrequired;
        private List<Availability>? _availability;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _endpoint;
        private CodeableConcept? _code;
        private FhirMarkdown? _comment;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "HealthcareService";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Active
        /// </summary>
        /// <remarks>
        /// <para>
        /// Active 的詳細描述。
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
        }        /// <summary>
        /// Providedby
        /// </summary>
        /// <remarks>
        /// <para>
        /// Providedby 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Providedby
        {
            get => _providedby;
            set
            {
                _providedby = value;
                OnPropertyChanged(nameof(Providedby));
            }
        }        /// <summary>
        /// Offeredin
        /// </summary>
        /// <remarks>
        /// <para>
        /// Offeredin 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Offeredin
        {
            get => _offeredin;
            set
            {
                _offeredin = value;
                OnPropertyChanged(nameof(Offeredin));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Specialty
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specialty 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Specialty
        {
            get => _specialty;
            set
            {
                _specialty = value;
                OnPropertyChanged(nameof(Specialty));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }        /// <summary>
        /// Extradetails
        /// </summary>
        /// <remarks>
        /// <para>
        /// Extradetails 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Extradetails
        {
            get => _extradetails;
            set
            {
                _extradetails = value;
                OnPropertyChanged(nameof(Extradetails));
            }
        }        /// <summary>
        /// Photo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Photo 的詳細描述。
        /// </para>
        /// </remarks>
        public Attachment? Photo
        {
            get => _photo;
            set
            {
                _photo = value;
                OnPropertyChanged(nameof(Photo));
            }
        }        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExtendedContactDetail>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// Coveragearea
        /// </summary>
        /// <remarks>
        /// <para>
        /// Coveragearea 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Coveragearea
        {
            get => _coveragearea;
            set
            {
                _coveragearea = value;
                OnPropertyChanged(nameof(Coveragearea));
            }
        }        /// <summary>
        /// Serviceprovisioncode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Serviceprovisioncode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Serviceprovisioncode
        {
            get => _serviceprovisioncode;
            set
            {
                _serviceprovisioncode = value;
                OnPropertyChanged(nameof(Serviceprovisioncode));
            }
        }        /// <summary>
        /// Eligibility
        /// </summary>
        /// <remarks>
        /// <para>
        /// Eligibility 的詳細描述。
        /// </para>
        /// </remarks>
        public List<HealthcareServiceEligibility>? Eligibility
        {
            get => _eligibility;
            set
            {
                _eligibility = value;
                OnPropertyChanged(nameof(Eligibility));
            }
        }        /// <summary>
        /// Program
        /// </summary>
        /// <remarks>
        /// <para>
        /// Program 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Program
        {
            get => _program;
            set
            {
                _program = value;
                OnPropertyChanged(nameof(Program));
            }
        }        /// <summary>
        /// Characteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Characteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Characteristic
        {
            get => _characteristic;
            set
            {
                _characteristic = value;
                OnPropertyChanged(nameof(Characteristic));
            }
        }        /// <summary>
        /// Communication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Communication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Communication
        {
            get => _communication;
            set
            {
                _communication = value;
                OnPropertyChanged(nameof(Communication));
            }
        }        /// <summary>
        /// Referralmethod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Referralmethod 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Referralmethod
        {
            get => _referralmethod;
            set
            {
                _referralmethod = value;
                OnPropertyChanged(nameof(Referralmethod));
            }
        }        /// <summary>
        /// Appointmentrequired
        /// </summary>
        /// <remarks>
        /// <para>
        /// Appointmentrequired 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Appointmentrequired
        {
            get => _appointmentrequired;
            set
            {
                _appointmentrequired = value;
                OnPropertyChanged(nameof(Appointmentrequired));
            }
        }        /// <summary>
        /// Availability
        /// </summary>
        /// <remarks>
        /// <para>
        /// Availability 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Availability>? Availability
        {
            get => _availability;
            set
            {
                _availability = value;
                OnPropertyChanged(nameof(Availability));
            }
        }        /// <summary>
        /// Endpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Endpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(Endpoint));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }        /// <summary>
        /// 建立新的 HealthcareService 資源實例
        /// </summary>
        public HealthcareService()
        {
        }

        /// <summary>
        /// 建立新的 HealthcareService 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public HealthcareService(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"HealthcareService(Id: {Id})";
        }
    }    /// <summary>
    /// HealthcareServiceEligibility 背骨元素
    /// </summary>
    public class HealthcareServiceEligibility
    {
        // TODO: 添加屬性實作
        
        public HealthcareServiceEligibility() { }
    }
}
