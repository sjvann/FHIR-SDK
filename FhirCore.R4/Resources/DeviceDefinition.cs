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
    /// FHIR R4 DeviceDefinition 資源
    /// 
    /// <para>
    /// The characteristics, operational status and capabilities of a medical-related component of a medical device.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var devicedefinition = new DeviceDefinition("devicedefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 DeviceDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DeviceDefinition : ResourceBase<R4Version>
    {
        private List<BackboneElement>? _capability;

        /// <summary>
        /// capability
        /// </summary>
        /// <remarks>
        /// <para>
        /// capability 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? capability
        {
            get => _capability;
            set
            {
                _capability = value;
                OnPropertyChanged(nameof(capability));
            }
        }

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

        private List<CodeableConcept>? _languagecode;

        /// <summary>
        /// languageCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// languageCode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? languageCode
        {
            get => _languagecode;
            set
            {
                _languagecode = value;
                OnPropertyChanged(nameof(languageCode));
            }
        }

        private List<BackboneElement>? _material;

        /// <summary>
        /// material
        /// </summary>
        /// <remarks>
        /// <para>
        /// material 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? material
        {
            get => _material;
            set
            {
                _material = value;
                OnPropertyChanged(nameof(material));
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

        private FhirUri? _onlineinformation;

        /// <summary>
        /// onlineInformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// onlineInformation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? onlineInformation
        {
            get => _onlineinformation;
            set
            {
                _onlineinformation = value;
                OnPropertyChanged(nameof(onlineInformation));
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

        private ReferenceType? _parentdevice;

        /// <summary>
        /// parentDevice
        /// </summary>
        /// <remarks>
        /// <para>
        /// parentDevice 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? parentDevice
        {
            get => _parentdevice;
            set
            {
                _parentdevice = value;
                OnPropertyChanged(nameof(parentDevice));
            }
        }

        private FhirString? _physicalcharacteristics;

        /// <summary>
        /// physicalCharacteristics
        /// </summary>
        /// <remarks>
        /// <para>
        /// physicalCharacteristics 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? physicalCharacteristics
        {
            get => _physicalcharacteristics;
            set
            {
                _physicalcharacteristics = value;
                OnPropertyChanged(nameof(physicalCharacteristics));
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

        private Quantity? _quantity;

        /// <summary>
        /// quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(quantity));
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

        private List<FhirString>? _shelflifestorage;

        /// <summary>
        /// shelfLifeStorage
        /// </summary>
        /// <remarks>
        /// <para>
        /// shelfLifeStorage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? shelfLifeStorage
        {
            get => _shelflifestorage;
            set
            {
                _shelflifestorage = value;
                OnPropertyChanged(nameof(shelfLifeStorage));
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

        private List<BackboneElement>? _udideviceidentifier;

        /// <summary>
        /// udiDeviceIdentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// udiDeviceIdentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? udiDeviceIdentifier
        {
            get => _udideviceidentifier;
            set
            {
                _udideviceidentifier = value;
                OnPropertyChanged(nameof(udiDeviceIdentifier));
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

        private List<FhirString>? _version;

        /// <summary>
        /// version
        /// </summary>
        /// <remarks>
        /// <para>
        /// version 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? version
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
        public override string ResourceType => "DeviceDefinition";

        /// <summary>
        /// 建立新的 DeviceDefinition 資源實例
        /// </summary>
        public DeviceDefinition()
        {
        }

        /// <summary>
        /// 建立新的 DeviceDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public DeviceDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"DeviceDefinition(Id: {Id})";
        }
    }
}
