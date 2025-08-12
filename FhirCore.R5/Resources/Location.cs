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
    /// FHIR R5 Location 資源
    /// 
    /// <para>
    /// Location 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var location = new Location("location-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Location 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Location : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private Coding? _operationalstatus;
        private FhirString? _name;
        private List<FhirString>? _alias;
        private FhirMarkdown? _description;
        private FhirCode? _mode;
        private List<CodeableConcept>? _type;
        private List<ExtendedContactDetail>? _contact;
        private Address? _address;
        private CodeableConcept? _form;
        private LocationPosition? _position;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _managingorganization;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _partof;
        private List<CodeableConcept>? _characteristic;
        private List<Availability>? _hoursofoperation;
        private List<VirtualServiceDetail>? _virtualservice;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _endpoint;
        private FhirDecimal? _longitude;
        private FhirDecimal? _latitude;
        private FhirDecimal? _altitude;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Location";        /// <summary>
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
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Operationalstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operationalstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Operationalstatus
        {
            get => _operationalstatus;
            set
            {
                _operationalstatus = value;
                OnPropertyChanged(nameof(Operationalstatus));
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
        /// Alias
        /// </summary>
        /// <remarks>
        /// <para>
        /// Alias 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Alias
        {
            get => _alias;
            set
            {
                _alias = value;
                OnPropertyChanged(nameof(Alias));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Mode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mode 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(Mode));
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
        /// Address
        /// </summary>
        /// <remarks>
        /// <para>
        /// Address 的詳細描述。
        /// </para>
        /// </remarks>
        public Address? Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }        /// <summary>
        /// Form
        /// </summary>
        /// <remarks>
        /// <para>
        /// Form 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Form
        {
            get => _form;
            set
            {
                _form = value;
                OnPropertyChanged(nameof(Form));
            }
        }        /// <summary>
        /// Position
        /// </summary>
        /// <remarks>
        /// <para>
        /// Position 的詳細描述。
        /// </para>
        /// </remarks>
        public LocationPosition? Position
        {
            get => _position;
            set
            {
                _position = value;
                OnPropertyChanged(nameof(Position));
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
        /// Partof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Partof 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Partof
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(Partof));
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
        /// Hoursofoperation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Hoursofoperation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Availability>? Hoursofoperation
        {
            get => _hoursofoperation;
            set
            {
                _hoursofoperation = value;
                OnPropertyChanged(nameof(Hoursofoperation));
            }
        }        /// <summary>
        /// Virtualservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Virtualservice 的詳細描述。
        /// </para>
        /// </remarks>
        public List<VirtualServiceDetail>? Virtualservice
        {
            get => _virtualservice;
            set
            {
                _virtualservice = value;
                OnPropertyChanged(nameof(Virtualservice));
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
        /// Longitude
        /// </summary>
        /// <remarks>
        /// <para>
        /// Longitude 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Longitude
        {
            get => _longitude;
            set
            {
                _longitude = value;
                OnPropertyChanged(nameof(Longitude));
            }
        }        /// <summary>
        /// Latitude
        /// </summary>
        /// <remarks>
        /// <para>
        /// Latitude 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Latitude
        {
            get => _latitude;
            set
            {
                _latitude = value;
                OnPropertyChanged(nameof(Latitude));
            }
        }        /// <summary>
        /// Altitude
        /// </summary>
        /// <remarks>
        /// <para>
        /// Altitude 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Altitude
        {
            get => _altitude;
            set
            {
                _altitude = value;
                OnPropertyChanged(nameof(Altitude));
            }
        }        /// <summary>
        /// 建立新的 Location 資源實例
        /// </summary>
        public Location()
        {
        }

        /// <summary>
        /// 建立新的 Location 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Location(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Location(Id: {Id})";
        }
    }    /// <summary>
    /// LocationPosition 背骨元素
    /// </summary>
    public class LocationPosition
    {
        // TODO: 添加屬性實作
        
        public LocationPosition() { }
    }
}
