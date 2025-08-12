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
    /// FHIR R4 MedicationAdministration 資源
    /// 
    /// <para>
    /// Describes the event of a patient consuming or otherwise being administered a medication.  This may be as simple as swallowing a tablet or it may be a long running infusion.  Related resources tie this event to the authorizing prescription, and the specific encounter between patient and health care practitioner.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicationadministration = new MedicationAdministration("medicationadministration-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MedicationAdministration 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicationAdministration : ResourceBase<R4Version>
    {
        private CodeableConcept? _category;

        /// <summary>
        /// category
        /// </summary>
        /// <remarks>
        /// <para>
        /// category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(category));
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

        private ReferenceType? _context;

        /// <summary>
        /// context
        /// </summary>
        /// <remarks>
        /// <para>
        /// context 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(context));
            }
        }

        private List<ReferenceType>? _device;

        /// <summary>
        /// device
        /// </summary>
        /// <remarks>
        /// <para>
        /// device 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(device));
            }
        }

        private BackboneElement? _dosage;

        /// <summary>
        /// dosage
        /// </summary>
        /// <remarks>
        /// <para>
        /// dosage 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? dosage
        {
            get => _dosage;
            set
            {
                _dosage = value;
                OnPropertyChanged(nameof(dosage));
            }
        }

        private List<ReferenceType>? _eventhistory;

        /// <summary>
        /// eventHistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// eventHistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? eventHistory
        {
            get => _eventhistory;
            set
            {
                _eventhistory = value;
                OnPropertyChanged(nameof(eventHistory));
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

        private List<FhirUri>? _instantiates;

        /// <summary>
        /// instantiates
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiates 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? instantiates
        {
            get => _instantiates;
            set
            {
                _instantiates = value;
                OnPropertyChanged(nameof(instantiates));
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

        private List<ReferenceType>? _partof;

        /// <summary>
        /// partOf
        /// </summary>
        /// <remarks>
        /// <para>
        /// partOf 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? partOf
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(partOf));
            }
        }

        private List<BackboneElement>? _performer;

        /// <summary>
        /// performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(performer));
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

        private ReferenceType? _request;

        /// <summary>
        /// request
        /// </summary>
        /// <remarks>
        /// <para>
        /// request 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(request));
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

        private List<ReferenceType>? _supportinginformation;

        /// <summary>
        /// supportingInformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// supportingInformation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? supportingInformation
        {
            get => _supportinginformation;
            set
            {
                _supportinginformation = value;
                OnPropertyChanged(nameof(supportingInformation));
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
        public override string ResourceType => "MedicationAdministration";

        /// <summary>
        /// 建立新的 MedicationAdministration 資源實例
        /// </summary>
        public MedicationAdministration()
        {
        }

        /// <summary>
        /// 建立新的 MedicationAdministration 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicationAdministration(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicationAdministration(Id: {Id})";
        }
    }
}
