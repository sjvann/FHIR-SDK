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
    /// FHIR R4 Location 資源
    /// 
    /// <para>
    /// Details and position information for a physical place where services are provided and resources and participants may be stored, found, contained, or accommodated.
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
    /// R4 版本的 Location 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Location : ResourceBase<R4Version>
    {
        private Address? _address;

        /// <summary>
        /// address
        /// </summary>
        /// <remarks>
        /// <para>
        /// address 的詳細描述。
        /// </para>
        /// </remarks>
        public Address? address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(address));
            }
        }

        private List<FhirString>? _alias;

        /// <summary>
        /// alias
        /// </summary>
        /// <remarks>
        /// <para>
        /// alias 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? alias
        {
            get => _alias;
            set
            {
                _alias = value;
                OnPropertyChanged(nameof(alias));
            }
        }

        private FhirString? _availabilityexceptions;

        /// <summary>
        /// availabilityExceptions
        /// </summary>
        /// <remarks>
        /// <para>
        /// availabilityExceptions 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? availabilityExceptions
        {
            get => _availabilityexceptions;
            set
            {
                _availabilityexceptions = value;
                OnPropertyChanged(nameof(availabilityExceptions));
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

        private FhirString? _description;

        /// <summary>
        /// description
        /// </summary>
        /// <remarks>
        /// <para>
        /// description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(description));
            }
        }

        private List<ReferenceType>? _endpoint;

        /// <summary>
        /// endpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// endpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(endpoint));
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

        private List<BackboneElement>? _hoursofoperation;

        /// <summary>
        /// hoursOfOperation
        /// </summary>
        /// <remarks>
        /// <para>
        /// hoursOfOperation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? hoursOfOperation
        {
            get => _hoursofoperation;
            set
            {
                _hoursofoperation = value;
                OnPropertyChanged(nameof(hoursOfOperation));
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

        private ReferenceType? _managingorganization;

        /// <summary>
        /// managingOrganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// managingOrganization 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? managingOrganization
        {
            get => _managingorganization;
            set
            {
                _managingorganization = value;
                OnPropertyChanged(nameof(managingOrganization));
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

        private FhirCode? _mode;

        /// <summary>
        /// mode
        /// </summary>
        /// <remarks>
        /// <para>
        /// mode 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(mode));
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

        private FhirString? _name;

        /// <summary>
        /// name
        /// </summary>
        /// <remarks>
        /// <para>
        /// name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(name));
            }
        }

        private Coding? _operationalstatus;

        /// <summary>
        /// operationalStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// operationalStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? operationalStatus
        {
            get => _operationalstatus;
            set
            {
                _operationalstatus = value;
                OnPropertyChanged(nameof(operationalStatus));
            }
        }

        private ReferenceType? _partof;

        /// <summary>
        /// partOf
        /// </summary>
        /// <remarks>
        /// <para>
        /// partOf 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? partOf
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(partOf));
            }
        }

        private CodeableConcept? _physicaltype;

        /// <summary>
        /// physicalType
        /// </summary>
        /// <remarks>
        /// <para>
        /// physicalType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? physicalType
        {
            get => _physicaltype;
            set
            {
                _physicaltype = value;
                OnPropertyChanged(nameof(physicalType));
            }
        }

        private BackboneElement? _position;

        /// <summary>
        /// position
        /// </summary>
        /// <remarks>
        /// <para>
        /// position 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? position
        {
            get => _position;
            set
            {
                _position = value;
                OnPropertyChanged(nameof(position));
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

        private List<ContactPoint>? _telecom;

        /// <summary>
        /// telecom
        /// </summary>
        /// <remarks>
        /// <para>
        /// telecom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactPoint>? telecom
        {
            get => _telecom;
            set
            {
                _telecom = value;
                OnPropertyChanged(nameof(telecom));
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

        private List<CodeableConcept>? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Location";

        /// <summary>
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
    }
}
