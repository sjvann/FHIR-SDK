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
    /// FHIR R5 Device 資源
    /// 
    /// <para>
    /// Device 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var device = new Device("device-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Device 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Device : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirString? _displayname;
        private CodeableReference? _definition;
        private List<DeviceUdiCarrier>? _udicarrier;
        private FhirCode? _status;
        private CodeableConcept? _availabilitystatus;
        private Identifier? _biologicalsourceevent;
        private FhirString? _manufacturer;
        private FhirDateTime? _manufacturedate;
        private FhirDateTime? _expirationdate;
        private FhirString? _lotnumber;
        private FhirString? _serialnumber;
        private List<DeviceName>? _name;
        private FhirString? _modelnumber;
        private FhirString? _partnumber;
        private List<CodeableConcept>? _category;
        private List<CodeableConcept>? _type;
        private List<DeviceVersion>? _version;
        private List<DeviceConformsTo>? _conformsto;
        private List<DeviceProperty>? _property;
        private CodeableConcept? _mode;
        private Count? _cycle;
        private Duration? _duration;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _owner;
        private List<ContactPoint>? _contact;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private FhirUri? _url;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _endpoint;
        private List<CodeableReference>? _gateway;
        private List<Annotation>? _note;
        private List<CodeableConcept>? _safety;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _parent;
        private FhirString? _deviceidentifier;
        private FhirUri? _issuer;
        private FhirUri? _jurisdiction;
        private FhirBase64Binary? _carrieraidc;
        private FhirString? _carrierhrf;
        private FhirCode? _entrytype;
        private FhirString? _value;
        private FhirCode? _type;
        private FhirBoolean? _display;
        private CodeableConcept? _type;
        private Identifier? _component;
        private FhirDateTime? _installdate;
        private FhirString? _value;
        private CodeableConcept? _category;
        private CodeableConcept? _specification;
        private FhirString? _version;
        private CodeableConcept? _type;
        private DevicePropertyValueChoice? _value;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Device";        /// <summary>
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
        /// Displayname
        /// </summary>
        /// <remarks>
        /// <para>
        /// Displayname 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Displayname
        {
            get => _displayname;
            set
            {
                _displayname = value;
                OnPropertyChanged(nameof(Displayname));
            }
        }        /// <summary>
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }        /// <summary>
        /// Udicarrier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Udicarrier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceUdiCarrier>? Udicarrier
        {
            get => _udicarrier;
            set
            {
                _udicarrier = value;
                OnPropertyChanged(nameof(Udicarrier));
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
        /// Availabilitystatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Availabilitystatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Availabilitystatus
        {
            get => _availabilitystatus;
            set
            {
                _availabilitystatus = value;
                OnPropertyChanged(nameof(Availabilitystatus));
            }
        }        /// <summary>
        /// Biologicalsourceevent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Biologicalsourceevent 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Biologicalsourceevent
        {
            get => _biologicalsourceevent;
            set
            {
                _biologicalsourceevent = value;
                OnPropertyChanged(nameof(Biologicalsourceevent));
            }
        }        /// <summary>
        /// Manufacturer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manufacturer 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Manufacturer
        {
            get => _manufacturer;
            set
            {
                _manufacturer = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }        /// <summary>
        /// Manufacturedate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manufacturedate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Manufacturedate
        {
            get => _manufacturedate;
            set
            {
                _manufacturedate = value;
                OnPropertyChanged(nameof(Manufacturedate));
            }
        }        /// <summary>
        /// Expirationdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expirationdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Expirationdate
        {
            get => _expirationdate;
            set
            {
                _expirationdate = value;
                OnPropertyChanged(nameof(Expirationdate));
            }
        }        /// <summary>
        /// Lotnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lotnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Lotnumber
        {
            get => _lotnumber;
            set
            {
                _lotnumber = value;
                OnPropertyChanged(nameof(Lotnumber));
            }
        }        /// <summary>
        /// Serialnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Serialnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Serialnumber
        {
            get => _serialnumber;
            set
            {
                _serialnumber = value;
                OnPropertyChanged(nameof(Serialnumber));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceName>? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Modelnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modelnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Modelnumber
        {
            get => _modelnumber;
            set
            {
                _modelnumber = value;
                OnPropertyChanged(nameof(Modelnumber));
            }
        }        /// <summary>
        /// Partnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Partnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Partnumber
        {
            get => _partnumber;
            set
            {
                _partnumber = value;
                OnPropertyChanged(nameof(Partnumber));
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
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceVersion>? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
            }
        }        /// <summary>
        /// Conformsto
        /// </summary>
        /// <remarks>
        /// <para>
        /// Conformsto 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceConformsTo>? Conformsto
        {
            get => _conformsto;
            set
            {
                _conformsto = value;
                OnPropertyChanged(nameof(Conformsto));
            }
        }        /// <summary>
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Mode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(Mode));
            }
        }        /// <summary>
        /// Cycle
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cycle 的詳細描述。
        /// </para>
        /// </remarks>
        public Count? Cycle
        {
            get => _cycle;
            set
            {
                _cycle = value;
                OnPropertyChanged(nameof(Cycle));
            }
        }        /// <summary>
        /// Duration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Duration 的詳細描述。
        /// </para>
        /// </remarks>
        public Duration? Duration
        {
            get => _duration;
            set
            {
                _duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }        /// <summary>
        /// Owner
        /// </summary>
        /// <remarks>
        /// <para>
        /// Owner 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Owner
        {
            get => _owner;
            set
            {
                _owner = value;
                OnPropertyChanged(nameof(Owner));
            }
        }        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactPoint>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
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
        /// Gateway
        /// </summary>
        /// <remarks>
        /// <para>
        /// Gateway 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Gateway
        {
            get => _gateway;
            set
            {
                _gateway = value;
                OnPropertyChanged(nameof(Gateway));
            }
        }        /// <summary>
        /// Note
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
            }
        }        /// <summary>
        /// Safety
        /// </summary>
        /// <remarks>
        /// <para>
        /// Safety 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Safety
        {
            get => _safety;
            set
            {
                _safety = value;
                OnPropertyChanged(nameof(Safety));
            }
        }        /// <summary>
        /// Parent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parent 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Parent
        {
            get => _parent;
            set
            {
                _parent = value;
                OnPropertyChanged(nameof(Parent));
            }
        }        /// <summary>
        /// Deviceidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Deviceidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Deviceidentifier
        {
            get => _deviceidentifier;
            set
            {
                _deviceidentifier = value;
                OnPropertyChanged(nameof(Deviceidentifier));
            }
        }        /// <summary>
        /// Issuer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issuer 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Issuer
        {
            get => _issuer;
            set
            {
                _issuer = value;
                OnPropertyChanged(nameof(Issuer));
            }
        }        /// <summary>
        /// Jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(Jurisdiction));
            }
        }        /// <summary>
        /// Carrieraidc
        /// </summary>
        /// <remarks>
        /// <para>
        /// Carrieraidc 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBase64Binary? Carrieraidc
        {
            get => _carrieraidc;
            set
            {
                _carrieraidc = value;
                OnPropertyChanged(nameof(Carrieraidc));
            }
        }        /// <summary>
        /// Carrierhrf
        /// </summary>
        /// <remarks>
        /// <para>
        /// Carrierhrf 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Carrierhrf
        {
            get => _carrierhrf;
            set
            {
                _carrierhrf = value;
                OnPropertyChanged(nameof(Carrierhrf));
            }
        }        /// <summary>
        /// Entrytype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entrytype 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Entrytype
        {
            get => _entrytype;
            set
            {
                _entrytype = value;
                OnPropertyChanged(nameof(Entrytype));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Display
        /// </summary>
        /// <remarks>
        /// <para>
        /// Display 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Display
        {
            get => _display;
            set
            {
                _display = value;
                OnPropertyChanged(nameof(Display));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Component
        /// </summary>
        /// <remarks>
        /// <para>
        /// Component 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Component
        {
            get => _component;
            set
            {
                _component = value;
                OnPropertyChanged(nameof(Component));
            }
        }        /// <summary>
        /// Installdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Installdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Installdate
        {
            get => _installdate;
            set
            {
                _installdate = value;
                OnPropertyChanged(nameof(Installdate));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Specification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specification 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Specification
        {
            get => _specification;
            set
            {
                _specification = value;
                OnPropertyChanged(nameof(Specification));
            }
        }        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public DevicePropertyValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// 建立新的 Device 資源實例
        /// </summary>
        public Device()
        {
        }

        /// <summary>
        /// 建立新的 Device 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Device(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Device(Id: {Id})";
        }
    }    /// <summary>
    /// DeviceUdiCarrier 背骨元素
    /// </summary>
    public class DeviceUdiCarrier
    {
        // TODO: 添加屬性實作
        
        public DeviceUdiCarrier() { }
    }    /// <summary>
    /// DeviceName 背骨元素
    /// </summary>
    public class DeviceName
    {
        // TODO: 添加屬性實作
        
        public DeviceName() { }
    }    /// <summary>
    /// DeviceVersion 背骨元素
    /// </summary>
    public class DeviceVersion
    {
        // TODO: 添加屬性實作
        
        public DeviceVersion() { }
    }    /// <summary>
    /// DeviceConformsTo 背骨元素
    /// </summary>
    public class DeviceConformsTo
    {
        // TODO: 添加屬性實作
        
        public DeviceConformsTo() { }
    }    /// <summary>
    /// DeviceProperty 背骨元素
    /// </summary>
    public class DeviceProperty
    {
        // TODO: 添加屬性實作
        
        public DeviceProperty() { }
    }    /// <summary>
    /// DevicePropertyValueChoice 選擇類型
    /// </summary>
    public class DevicePropertyValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public DevicePropertyValueChoice(JsonObject value) : base("devicepropertyvalue", value, _supportType) { }
        public DevicePropertyValueChoice(IComplexType? value) : base("devicepropertyvalue", value) { }
        public DevicePropertyValueChoice(IPrimitiveType? value) : base("devicepropertyvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "DevicePropertyValue" : "devicepropertyvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
