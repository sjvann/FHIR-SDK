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
    /// FHIR R4 Encounter 資源
    /// 
    /// <para>
    /// An interaction between a patient and healthcare provider(s) for the purpose of providing healthcare service(s) or assessing the health status of a patient.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var encounter = new Encounter("encounter-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Encounter 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Encounter : ResourceBase<R4Version>
    {
        private List<ReferenceType>? _account;

        /// <summary>
        /// account
        /// </summary>
        /// <remarks>
        /// <para>
        /// account 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? account
        {
            get => _account;
            set
            {
                _account = value;
                OnPropertyChanged(nameof(account));
            }
        }

        private List<ReferenceType>? _appointment;

        /// <summary>
        /// appointment
        /// </summary>
        /// <remarks>
        /// <para>
        /// appointment 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? appointment
        {
            get => _appointment;
            set
            {
                _appointment = value;
                OnPropertyChanged(nameof(appointment));
            }
        }

        private List<ReferenceType>? _basedon;

        /// <summary>
        /// basedOn
        /// </summary>
        /// <remarks>
        /// <para>
        /// basedOn 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? basedOn
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(basedOn));
            }
        }

        private Coding? _class;

        /// <summary>
        /// class
        /// </summary>
        /// <remarks>
        /// <para>
        /// class 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? class
        {
            get => _class;
            set
            {
                _class = value;
                OnPropertyChanged(nameof(class));
            }
        }

        private List<BackboneElement>? _classhistory;

        /// <summary>
        /// classHistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// classHistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? classHistory
        {
            get => _classhistory;
            set
            {
                _classhistory = value;
                OnPropertyChanged(nameof(classHistory));
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

        private List<BackboneElement>? _diagnosis;

        /// <summary>
        /// diagnosis
        /// </summary>
        /// <remarks>
        /// <para>
        /// diagnosis 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? diagnosis
        {
            get => _diagnosis;
            set
            {
                _diagnosis = value;
                OnPropertyChanged(nameof(diagnosis));
            }
        }

        private List<ReferenceType>? _episodeofcare;

        /// <summary>
        /// episodeOfCare
        /// </summary>
        /// <remarks>
        /// <para>
        /// episodeOfCare 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? episodeOfCare
        {
            get => _episodeofcare;
            set
            {
                _episodeofcare = value;
                OnPropertyChanged(nameof(episodeOfCare));
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

        private BackboneElement? _hospitalization;

        /// <summary>
        /// hospitalization
        /// </summary>
        /// <remarks>
        /// <para>
        /// hospitalization 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? hospitalization
        {
            get => _hospitalization;
            set
            {
                _hospitalization = value;
                OnPropertyChanged(nameof(hospitalization));
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

        private FhirString? _length;

        /// <summary>
        /// length
        /// </summary>
        /// <remarks>
        /// <para>
        /// length 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? length
        {
            get => _length;
            set
            {
                _length = value;
                OnPropertyChanged(nameof(length));
            }
        }

        private List<BackboneElement>? _location;

        /// <summary>
        /// location
        /// </summary>
        /// <remarks>
        /// <para>
        /// location 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? location
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

        private List<BackboneElement>? _participant;

        /// <summary>
        /// participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(participant));
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

        private CodeableConcept? _priority;

        /// <summary>
        /// priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// priority 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(priority));
            }
        }

        private List<CodeableConcept>? _reasoncode;

        /// <summary>
        /// reasonCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonCode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? reasonCode
        {
            get => _reasoncode;
            set
            {
                _reasoncode = value;
                OnPropertyChanged(nameof(reasonCode));
            }
        }

        private List<ReferenceType>? _reasonreference;

        /// <summary>
        /// reasonReference
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonReference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? reasonReference
        {
            get => _reasonreference;
            set
            {
                _reasonreference = value;
                OnPropertyChanged(nameof(reasonReference));
            }
        }

        private ReferenceType? _serviceprovider;

        /// <summary>
        /// serviceProvider
        /// </summary>
        /// <remarks>
        /// <para>
        /// serviceProvider 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? serviceProvider
        {
            get => _serviceprovider;
            set
            {
                _serviceprovider = value;
                OnPropertyChanged(nameof(serviceProvider));
            }
        }

        private CodeableConcept? _servicetype;

        /// <summary>
        /// serviceType
        /// </summary>
        /// <remarks>
        /// <para>
        /// serviceType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? serviceType
        {
            get => _servicetype;
            set
            {
                _servicetype = value;
                OnPropertyChanged(nameof(serviceType));
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

        private List<BackboneElement>? _statushistory;

        /// <summary>
        /// statusHistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// statusHistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? statusHistory
        {
            get => _statushistory;
            set
            {
                _statushistory = value;
                OnPropertyChanged(nameof(statusHistory));
            }
        }

        private ReferenceType? _subject;

        /// <summary>
        /// subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// subject 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(subject));
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
        public override string ResourceType => "Encounter";

        /// <summary>
        /// 建立新的 Encounter 資源實例
        /// </summary>
        public Encounter()
        {
        }

        /// <summary>
        /// 建立新的 Encounter 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Encounter(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Encounter(Id: {Id})";
        }
    }
}
