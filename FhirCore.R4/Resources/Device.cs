using FhirCore.Base;
using FhirCore.R4;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R4.Resources
{
    /// <summary>
    /// FHIR R4 Device 資源
    /// 
    /// <para>
    /// A type of a manufactured item that is used in the provision of healthcare without being substantially changed through that activity. The device may be a medical or non-medical device.
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
    /// R4 版本的 Device 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Device : ResourceBase<R4Version>
    {
        private List<ContactPoint>? _contact;

        /// <summary>
        /// contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactPoint>? contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(contact));
            }
        }

        private List<FhirString>? _contained;

        /// <summary>
        /// contained
        /// </summary>
        /// <remarks>
        /// <para>
        /// contained 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? contained
        {
            get => _contained;
            set
            {
                _contained = value;
                OnPropertyChanged(nameof(contained));
            }
        }

        private ReferenceType? _definition;

        /// <summary>
        /// definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// definition 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(definition));
            }
        }

        private List<BackboneElement>? _devicename;

        /// <summary>
        /// deviceName
        /// </summary>
        /// <remarks>
        /// <para>
        /// deviceName 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? deviceName
        {
            get => _devicename;
            set
            {
                _devicename = value;
                OnPropertyChanged(nameof(deviceName));
            }
        }

        private FhirString? _distinctidentifier;

        /// <summary>
        /// distinctIdentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// distinctIdentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? distinctIdentifier
        {
            get => _distinctidentifier;
            set
            {
                _distinctidentifier = value;
                OnPropertyChanged(nameof(distinctIdentifier));
            }
        }

        private FhirDateTime? _expirationdate;

        /// <summary>
        /// expirationDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// expirationDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? expirationDate
        {
            get => _expirationdate;
            set
            {
                _expirationdate = value;
                OnPropertyChanged(nameof(expirationDate));
            }
        }

        private List<Extension>? _extension;

        /// <summary>
        /// extension
        /// </summary>
        /// <remarks>
        /// <para>
        /// extension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? extension
        {
            get => _extension;
            set
            {
                _extension = value;
                OnPropertyChanged(nameof(extension));
            }
        }

        private FhirString? _id;

        /// <summary>
        /// id
        /// </summary>
        /// <remarks>
        /// <para>
        /// id 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(id));
            }
        }

        private List<Identifier>? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(identifier));
            }
        }

        private FhirUri? _implicitrules;

        /// <summary>
        /// implicitRules
        /// </summary>
        /// <remarks>
        /// <para>
        /// implicitRules 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? implicitRules
        {
            get => _implicitrules;
            set
            {
                _implicitrules = value;
                OnPropertyChanged(nameof(implicitRules));
            }
        }

        private FhirCode? _language;

        /// <summary>
        /// language
        /// </summary>
        /// <remarks>
        /// <para>
        /// language 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(language));
            }
        }

        private ReferenceType? _location;

        /// <summary>
        /// location
        /// </summary>
        /// <remarks>
        /// <para>
        /// location 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(location));
            }
        }

        private FhirString? _lotnumber;

        /// <summary>
        /// lotNumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// lotNumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? lotNumber
        {
            get => _lotnumber;
            set
            {
                _lotnumber = value;
                OnPropertyChanged(nameof(lotNumber));
            }
        }

        private FhirDateTime? _manufacturedate;

        /// <summary>
        /// manufactureDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// manufactureDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? manufactureDate
        {
            get => _manufacturedate;
            set
            {
                _manufacturedate = value;
                OnPropertyChanged(nameof(manufactureDate));
            }
        }

        private FhirString? _manufacturer;

        /// <summary>
        /// manufacturer
        /// </summary>
        /// <remarks>
        /// <para>
        /// manufacturer 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? manufacturer
        {
            get => _manufacturer;
            set
            {
                _manufacturer = value;
                OnPropertyChanged(nameof(manufacturer));
            }
        }

        private Meta? _meta;

        /// <summary>
        /// meta
        /// </summary>
        /// <remarks>
        /// <para>
        /// meta 的詳細描述。
        /// </para>
        /// </remarks>
        public Meta? meta
        {
            get => _meta;
            set
            {
                _meta = value;
                OnPropertyChanged(nameof(meta));
            }
        }

        private FhirString? _modelnumber;

        /// <summary>
        /// modelNumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// modelNumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? modelNumber
        {
            get => _modelnumber;
            set
            {
                _modelnumber = value;
                OnPropertyChanged(nameof(modelNumber));
            }
        }

        private List<Extension>? _modifierextension;

        /// <summary>
        /// modifierExtension
        /// </summary>
        /// <remarks>
        /// <para>
        /// modifierExtension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? modifierExtension
        {
            get => _modifierextension;
            set
            {
                _modifierextension = value;
                OnPropertyChanged(nameof(modifierExtension));
            }
        }

        private List<Annotation>? _note;

        /// <summary>
        /// note
        /// </summary>
        /// <remarks>
        /// <para>
        /// note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(note));
            }
        }

        private ReferenceType? _owner;

        /// <summary>
        /// owner
        /// </summary>
        /// <remarks>
        /// <para>
        /// owner 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? owner
        {
            get => _owner;
            set
            {
                _owner = value;
                OnPropertyChanged(nameof(owner));
            }
        }

        private ReferenceType? _parent;

        /// <summary>
        /// parent
        /// </summary>
        /// <remarks>
        /// <para>
        /// parent 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? parent
        {
            get => _parent;
            set
            {
                _parent = value;
                OnPropertyChanged(nameof(parent));
            }
        }

        private FhirString? _partnumber;

        /// <summary>
        /// partNumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// partNumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? partNumber
        {
            get => _partnumber;
            set
            {
                _partnumber = value;
                OnPropertyChanged(nameof(partNumber));
            }
        }

        private ReferenceType? _patient;

        /// <summary>
        /// patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// patient 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(patient));
            }
        }

        private List<BackboneElement>? _property;

        /// <summary>
        /// property
        /// </summary>
        /// <remarks>
        /// <para>
        /// property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(property));
            }
        }

        private List<CodeableConcept>? _safety;

        /// <summary>
        /// safety
        /// </summary>
        /// <remarks>
        /// <para>
        /// safety 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? safety
        {
            get => _safety;
            set
            {
                _safety = value;
                OnPropertyChanged(nameof(safety));
            }
        }

        private FhirString? _serialnumber;

        /// <summary>
        /// serialNumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// serialNumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? serialNumber
        {
            get => _serialnumber;
            set
            {
                _serialnumber = value;
                OnPropertyChanged(nameof(serialNumber));
            }
        }

        private List<BackboneElement>? _specialization;

        /// <summary>
        /// specialization
        /// </summary>
        /// <remarks>
        /// <para>
        /// specialization 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? specialization
        {
            get => _specialization;
            set
            {
                _specialization = value;
                OnPropertyChanged(nameof(specialization));
            }
        }

        private FhirCode? _status;

        /// <summary>
        /// status
        /// </summary>
        /// <remarks>
        /// <para>
        /// status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(status));
            }
        }

        private List<CodeableConcept>? _statusreason;

        /// <summary>
        /// statusReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// statusReason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? statusReason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(statusReason));
            }
        }

        private FhirString? _text;

        /// <summary>
        /// text
        /// </summary>
        /// <remarks>
        /// <para>
        /// text 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged(nameof(text));
            }
        }

        private CodeableConcept? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        private List<BackboneElement>? _udicarrier;

        /// <summary>
        /// udiCarrier
        /// </summary>
        /// <remarks>
        /// <para>
        /// udiCarrier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? udiCarrier
        {
            get => _udicarrier;
            set
            {
                _udicarrier = value;
                OnPropertyChanged(nameof(udiCarrier));
            }
        }

        private FhirUri? _url;

        /// <summary>
        /// url
        /// </summary>
        /// <remarks>
        /// <para>
        /// url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(url));
            }
        }

        private List<BackboneElement>? _version;

        /// <summary>
        /// version
        /// </summary>
        /// <remarks>
        /// <para>
        /// version 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(version));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Device";

        /// <summary>
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
    }
}
