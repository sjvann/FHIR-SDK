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
    /// FHIR R5 PractitionerRole 資源
    /// 
    /// <para>
    /// PractitionerRole 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var practitionerrole = new PractitionerRole("practitionerrole-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 PractitionerRole 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class PractitionerRole : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private Period? _period;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _practitioner;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _organization;
        private List<CodeableConcept>? _code;
        private List<CodeableConcept>? _specialty;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _location;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _healthcareservice;
        private List<ExtendedContactDetail>? _contact;
        private List<CodeableConcept>? _characteristic;
        private List<CodeableConcept>? _communication;
        private List<Availability>? _availability;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _endpoint;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "PractitionerRole";        /// <summary>
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
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Practitioner
        /// </summary>
        /// <remarks>
        /// <para>
        /// Practitioner 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Practitioner
        {
            get => _practitioner;
            set
            {
                _practitioner = value;
                OnPropertyChanged(nameof(Practitioner));
            }
        }        /// <summary>
        /// Organization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Organization 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Organization
        {
            get => _organization;
            set
            {
                _organization = value;
                OnPropertyChanged(nameof(Organization));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
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
        /// Healthcareservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Healthcareservice 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Healthcareservice
        {
            get => _healthcareservice;
            set
            {
                _healthcareservice = value;
                OnPropertyChanged(nameof(Healthcareservice));
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
        /// 建立新的 PractitionerRole 資源實例
        /// </summary>
        public PractitionerRole()
        {
        }

        /// <summary>
        /// 建立新的 PractitionerRole 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public PractitionerRole(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"PractitionerRole(Id: {Id})";
        }
    }
}
