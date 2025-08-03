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
    /// FHIR R5 PatientR5 資源
    /// 
    /// <para>
    /// PatientR5 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var patientr5 = new PatientR5("patientr5-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 PatientR5 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class PatientR5 : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private FhirCode? _gender;
        private FhirDate? _birthdate;
        private List<Address>? _address;
        private CodeableConcept? _maritalstatus;
        private List<Attachment>? _photo;
        private List<PatientContact>? _contact;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _generalpractitioner;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _managingorganization;
        private List<PatientLink>? _link;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "PatientR5";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
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
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
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
        }        /// <summary>
        /// Telecom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Telecom 的詳細描述。
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
        }        /// <summary>
        /// Gender
        /// </summary>
        /// <remarks>
        /// <para>
        /// Gender 的詳細描述。
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
        }        /// <summary>
        /// Birthdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Birthdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Birthdate
        {
            get => _birthdate;
            set
            {
                _birthdate = value;
                OnPropertyChanged(nameof(Birthdate));
            }
        }        /// <summary>
        /// Address
        /// </summary>
        /// <remarks>
        /// <para>
        /// Address 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Address>? Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }        /// <summary>
        /// Maritalstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maritalstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Maritalstatus
        {
            get => _maritalstatus;
            set
            {
                _maritalstatus = value;
                OnPropertyChanged(nameof(Maritalstatus));
            }
        }        /// <summary>
        /// Photo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Photo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Attachment>? Photo
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
        public List<PatientContact>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// Generalpractitioner
        /// </summary>
        /// <remarks>
        /// <para>
        /// Generalpractitioner 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Generalpractitioner
        {
            get => _generalpractitioner;
            set
            {
                _generalpractitioner = value;
                OnPropertyChanged(nameof(Generalpractitioner));
            }
        }        /// <summary>
        /// Managingorganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Managingorganization 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Managingorganization
        {
            get => _managingorganization;
            set
            {
                _managingorganization = value;
                OnPropertyChanged(nameof(Managingorganization));
            }
        }        /// <summary>
        /// Link
        /// </summary>
        /// <remarks>
        /// <para>
        /// Link 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PatientLink>? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }        /// <summary>
        /// 建立新的 PatientR5 資源實例
        /// </summary>
        public PatientR5()
        {
        }

        /// <summary>
        /// 建立新的 PatientR5 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public PatientR5(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"PatientR5(Id: {Id})";
        }
    }
}
