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
    /// FHIR R4 HealthcareService 資源
    /// 
    /// <para>
    /// The details of a healthcare service available at a location.
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
    /// R4 版本的 HealthcareService 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class HealthcareService : ResourceBase<R4Version>
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

        private FhirBoolean? _appointmentrequired;

        /// <summary>
        /// appointmentRequired
        /// </summary>
        /// <remarks>
        /// <para>
        /// appointmentRequired 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? appointmentRequired
        {
            get => _appointmentrequired;
            set
            {
                _appointmentrequired = value;
                OnPropertyChanged(nameof(appointmentRequired));
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

        private List<CodeableConcept>? _category;

        /// <summary>
        /// category
        /// </summary>
        /// <remarks>
        /// <para>
        /// category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(category));
            }
        }

        private List<CodeableConcept>? _characteristic;

        /// <summary>
        /// characteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// characteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? characteristic
        {
            get => _characteristic;
            set
            {
                _characteristic = value;
                OnPropertyChanged(nameof(characteristic));
            }
        }

        private FhirString? _comment;

        /// <summary>
        /// comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(comment));
            }
        }

        private List<CodeableConcept>? _communication;

        /// <summary>
        /// communication
        /// </summary>
        /// <remarks>
        /// <para>
        /// communication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? communication
        {
            get => _communication;
            set
            {
                _communication = value;
                OnPropertyChanged(nameof(communication));
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

        private List<ReferenceType>? _coveragearea;

        /// <summary>
        /// coverageArea
        /// </summary>
        /// <remarks>
        /// <para>
        /// coverageArea 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? coverageArea
        {
            get => _coveragearea;
            set
            {
                _coveragearea = value;
                OnPropertyChanged(nameof(coverageArea));
            }
        }

        private List<BackboneElement>? _eligibility;

        /// <summary>
        /// eligibility
        /// </summary>
        /// <remarks>
        /// <para>
        /// eligibility 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? eligibility
        {
            get => _eligibility;
            set
            {
                _eligibility = value;
                OnPropertyChanged(nameof(eligibility));
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

        private FhirMarkdown? _extradetails;

        /// <summary>
        /// extraDetails
        /// </summary>
        /// <remarks>
        /// <para>
        /// extraDetails 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? extraDetails
        {
            get => _extradetails;
            set
            {
                _extradetails = value;
                OnPropertyChanged(nameof(extraDetails));
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

        private Attachment? _photo;

        /// <summary>
        /// photo
        /// </summary>
        /// <remarks>
        /// <para>
        /// photo 的詳細描述。
        /// </para>
        /// </remarks>
        public Attachment? photo
        {
            get => _photo;
            set
            {
                _photo = value;
                OnPropertyChanged(nameof(photo));
            }
        }

        private List<CodeableConcept>? _program;

        /// <summary>
        /// program
        /// </summary>
        /// <remarks>
        /// <para>
        /// program 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? program
        {
            get => _program;
            set
            {
                _program = value;
                OnPropertyChanged(nameof(program));
            }
        }

        private ReferenceType? _providedby;

        /// <summary>
        /// providedBy
        /// </summary>
        /// <remarks>
        /// <para>
        /// providedBy 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? providedBy
        {
            get => _providedby;
            set
            {
                _providedby = value;
                OnPropertyChanged(nameof(providedBy));
            }
        }

        private List<CodeableConcept>? _referralmethod;

        /// <summary>
        /// referralMethod
        /// </summary>
        /// <remarks>
        /// <para>
        /// referralMethod 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? referralMethod
        {
            get => _referralmethod;
            set
            {
                _referralmethod = value;
                OnPropertyChanged(nameof(referralMethod));
            }
        }

        private List<CodeableConcept>? _serviceprovisioncode;

        /// <summary>
        /// serviceProvisionCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// serviceProvisionCode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? serviceProvisionCode
        {
            get => _serviceprovisioncode;
            set
            {
                _serviceprovisioncode = value;
                OnPropertyChanged(nameof(serviceProvisionCode));
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
        public override string ResourceType => "HealthcareService";

        /// <summary>
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
    }
}
