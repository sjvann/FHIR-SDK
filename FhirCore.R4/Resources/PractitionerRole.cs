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
    /// FHIR R4 PractitionerRole 資源
    /// 
    /// <para>
    /// A specific set of Roles/Locations/specialties/services that a practitioner may perform at an organization for a period of time.
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
    /// R4 版本的 PractitionerRole 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class PractitionerRole : ResourceBase<R4Version>
    {
        private FhirBoolean? _active;

        /// <summary>
        /// active
        /// </summary>
        /// <remarks>
        /// <para>
        /// active 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? active
        {
            get => _active;
            set
            {
                _active = value;
                OnPropertyChanged(nameof(active));
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

        private List<BackboneElement>? _availabletime;

        /// <summary>
        /// availableTime
        /// </summary>
        /// <remarks>
        /// <para>
        /// availableTime 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? availableTime
        {
            get => _availabletime;
            set
            {
                _availabletime = value;
                OnPropertyChanged(nameof(availableTime));
            }
        }

        private List<CodeableConcept>? _code;

        /// <summary>
        /// code
        /// </summary>
        /// <remarks>
        /// <para>
        /// code 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(code));
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

        private List<ReferenceType>? _healthcareservice;

        /// <summary>
        /// healthcareService
        /// </summary>
        /// <remarks>
        /// <para>
        /// healthcareService 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? healthcareService
        {
            get => _healthcareservice;
            set
            {
                _healthcareservice = value;
                OnPropertyChanged(nameof(healthcareService));
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

        private List<ReferenceType>? _location;

        /// <summary>
        /// location
        /// </summary>
        /// <remarks>
        /// <para>
        /// location 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(location));
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

        private List<BackboneElement>? _notavailable;

        /// <summary>
        /// notAvailable
        /// </summary>
        /// <remarks>
        /// <para>
        /// notAvailable 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? notAvailable
        {
            get => _notavailable;
            set
            {
                _notavailable = value;
                OnPropertyChanged(nameof(notAvailable));
            }
        }

        private ReferenceType? _organization;

        /// <summary>
        /// organization
        /// </summary>
        /// <remarks>
        /// <para>
        /// organization 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? organization
        {
            get => _organization;
            set
            {
                _organization = value;
                OnPropertyChanged(nameof(organization));
            }
        }

        private Period? _period;

        /// <summary>
        /// period
        /// </summary>
        /// <remarks>
        /// <para>
        /// period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(period));
            }
        }

        private ReferenceType? _practitioner;

        /// <summary>
        /// practitioner
        /// </summary>
        /// <remarks>
        /// <para>
        /// practitioner 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? practitioner
        {
            get => _practitioner;
            set
            {
                _practitioner = value;
                OnPropertyChanged(nameof(practitioner));
            }
        }

        private List<CodeableConcept>? _specialty;

        /// <summary>
        /// specialty
        /// </summary>
        /// <remarks>
        /// <para>
        /// specialty 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? specialty
        {
            get => _specialty;
            set
            {
                _specialty = value;
                OnPropertyChanged(nameof(specialty));
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

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "PractitionerRole";

        /// <summary>
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
