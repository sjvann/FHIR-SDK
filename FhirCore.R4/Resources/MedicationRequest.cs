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
    /// FHIR R4 MedicationRequest 資源
    /// 
    /// <para>
    /// An order or request for both supply of the medication and the instructions for administration of the medication to a patient. The resource is called "MedicationRequest" rather than "MedicationPrescription" or "MedicationOrder" to generalize the use across inpatient and outpatient settings, including care plans, etc., and to harmonize with workflow patterns.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicationrequest = new MedicationRequest("medicationrequest-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MedicationRequest 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicationRequest : ResourceBase<R4Version>
    {
        private FhirDateTime? _authoredon;

        /// <summary>
        /// authoredOn
        /// </summary>
        /// <remarks>
        /// <para>
        /// authoredOn 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? authoredOn
        {
            get => _authoredon;
            set
            {
                _authoredon = value;
                OnPropertyChanged(nameof(authoredOn));
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

        private CodeableConcept? _courseoftherapytype;

        /// <summary>
        /// courseOfTherapyType
        /// </summary>
        /// <remarks>
        /// <para>
        /// courseOfTherapyType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? courseOfTherapyType
        {
            get => _courseoftherapytype;
            set
            {
                _courseoftherapytype = value;
                OnPropertyChanged(nameof(courseOfTherapyType));
            }
        }

        private List<ReferenceType>? _detectedissue;

        /// <summary>
        /// detectedIssue
        /// </summary>
        /// <remarks>
        /// <para>
        /// detectedIssue 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? detectedIssue
        {
            get => _detectedissue;
            set
            {
                _detectedissue = value;
                OnPropertyChanged(nameof(detectedIssue));
            }
        }

        private BackboneElement? _dispenserequest;

        /// <summary>
        /// dispenseRequest
        /// </summary>
        /// <remarks>
        /// <para>
        /// dispenseRequest 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? dispenseRequest
        {
            get => _dispenserequest;
            set
            {
                _dispenserequest = value;
                OnPropertyChanged(nameof(dispenseRequest));
            }
        }

        private FhirBoolean? _donotperform;

        /// <summary>
        /// doNotPerform
        /// </summary>
        /// <remarks>
        /// <para>
        /// doNotPerform 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? doNotPerform
        {
            get => _donotperform;
            set
            {
                _donotperform = value;
                OnPropertyChanged(nameof(doNotPerform));
            }
        }

        private List<FhirString>? _dosageinstruction;

        /// <summary>
        /// dosageInstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// dosageInstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? dosageInstruction
        {
            get => _dosageinstruction;
            set
            {
                _dosageinstruction = value;
                OnPropertyChanged(nameof(dosageInstruction));
            }
        }

        private ReferenceType? _encounter;

        /// <summary>
        /// encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(encounter));
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

        private Identifier? _groupidentifier;

        /// <summary>
        /// groupIdentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// groupIdentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? groupIdentifier
        {
            get => _groupidentifier;
            set
            {
                _groupidentifier = value;
                OnPropertyChanged(nameof(groupIdentifier));
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

        private List<FhirCanonical>? _instantiatescanonical;

        /// <summary>
        /// instantiatesCanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiatesCanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? instantiatesCanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(instantiatesCanonical));
            }
        }

        private List<FhirUri>? _instantiatesuri;

        /// <summary>
        /// instantiatesUri
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiatesUri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? instantiatesUri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(instantiatesUri));
            }
        }

        private List<ReferenceType>? _insurance;

        /// <summary>
        /// insurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// insurance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? insurance
        {
            get => _insurance;
            set
            {
                _insurance = value;
                OnPropertyChanged(nameof(insurance));
            }
        }

        private FhirCode? _intent;

        /// <summary>
        /// intent
        /// </summary>
        /// <remarks>
        /// <para>
        /// intent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? intent
        {
            get => _intent;
            set
            {
                _intent = value;
                OnPropertyChanged(nameof(intent));
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

        private ReferenceType? _performer;

        /// <summary>
        /// performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// performer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(performer));
            }
        }

        private CodeableConcept? _performertype;

        /// <summary>
        /// performerType
        /// </summary>
        /// <remarks>
        /// <para>
        /// performerType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? performerType
        {
            get => _performertype;
            set
            {
                _performertype = value;
                OnPropertyChanged(nameof(performerType));
            }
        }

        private FhirCode? _priority;

        /// <summary>
        /// priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// priority 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(priority));
            }
        }

        private ReferenceType? _priorprescription;

        /// <summary>
        /// priorPrescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// priorPrescription 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? priorPrescription
        {
            get => _priorprescription;
            set
            {
                _priorprescription = value;
                OnPropertyChanged(nameof(priorPrescription));
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

        private ReferenceType? _recorder;

        /// <summary>
        /// recorder
        /// </summary>
        /// <remarks>
        /// <para>
        /// recorder 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? recorder
        {
            get => _recorder;
            set
            {
                _recorder = value;
                OnPropertyChanged(nameof(recorder));
            }
        }

        private ReferenceType? _requester;

        /// <summary>
        /// requester
        /// </summary>
        /// <remarks>
        /// <para>
        /// requester 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? requester
        {
            get => _requester;
            set
            {
                _requester = value;
                OnPropertyChanged(nameof(requester));
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

        private CodeableConcept? _statusreason;

        /// <summary>
        /// statusReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// statusReason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? statusReason
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

        private BackboneElement? _substitution;

        /// <summary>
        /// substitution
        /// </summary>
        /// <remarks>
        /// <para>
        /// substitution 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? substitution
        {
            get => _substitution;
            set
            {
                _substitution = value;
                OnPropertyChanged(nameof(substitution));
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
        public override string ResourceType => "MedicationRequest";

        /// <summary>
        /// 建立新的 MedicationRequest 資源實例
        /// </summary>
        public MedicationRequest()
        {
        }

        /// <summary>
        /// 建立新的 MedicationRequest 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicationRequest(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicationRequest(Id: {Id})";
        }
    }
}
