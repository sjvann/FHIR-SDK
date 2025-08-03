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
    /// FHIR R5 OrganizationAffiliation 資源
    /// 
    /// <para>
    /// OrganizationAffiliation 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var organizationaffiliation = new OrganizationAffiliation("organizationaffiliation-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 OrganizationAffiliation 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class OrganizationAffiliation : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private Period? _period;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _organization;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _participatingorganization;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _network;
        private List<CodeableConcept>? _code;
        private List<CodeableConcept>? _specialty;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _location;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _healthcareservice;
        private List<ExtendedContactDetail>? _contact;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _endpoint;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "OrganizationAffiliation";        /// <summary>
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
        /// Participatingorganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Participatingorganization 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Participatingorganization
        {
            get => _participatingorganization;
            set
            {
                _participatingorganization = value;
                OnPropertyChanged(nameof(Participatingorganization));
            }
        }        /// <summary>
        /// Network
        /// </summary>
        /// <remarks>
        /// <para>
        /// Network 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Network
        {
            get => _network;
            set
            {
                _network = value;
                OnPropertyChanged(nameof(Network));
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
        /// 建立新的 OrganizationAffiliation 資源實例
        /// </summary>
        public OrganizationAffiliation()
        {
        }

        /// <summary>
        /// 建立新的 OrganizationAffiliation 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public OrganizationAffiliation(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"OrganizationAffiliation(Id: {Id})";
        }
    }
}
