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
    /// FHIR R5 MedicationRequest 資源
    /// 
    /// <para>
    /// MedicationRequest 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 MedicationRequest 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicationRequest : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _priorprescription;
        private Identifier? _groupidentifier;
        private FhirCode? _status;
        private CodeableConcept? _statusreason;
        private FhirDateTime? _statuschanged;
        private FhirCode? _intent;
        private List<CodeableConcept>? _category;
        private FhirCode? _priority;
        private FhirBoolean? _donotperform;
        private CodeableReference? _medication;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _informationsource;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportinginformation;
        private FhirDateTime? _authoredon;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _requester;
        private FhirBoolean? _reported;
        private CodeableConcept? _performertype;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _performer;
        private List<CodeableReference>? _device;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _recorder;
        private List<CodeableReference>? _reason;
        private CodeableConcept? _courseoftherapytype;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _insurance;
        private List<Annotation>? _note;
        private FhirMarkdown? _rendereddosageinstruction;
        private Period? _effectivedoseperiod;
        private List<Dosage>? _dosageinstruction;
        private MedicationRequestDispenseRequest? _dispenserequest;
        private MedicationRequestSubstitution? _substitution;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _eventhistory;
        private Quantity? _quantity;
        private Duration? _duration;
        private MedicationRequestDispenseRequestInitialFill? _initialfill;
        private Duration? _dispenseinterval;
        private Period? _validityperiod;
        private FhirUnsignedInt? _numberofrepeatsallowed;
        private Quantity? _quantity;
        private Duration? _expectedsupplyduration;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _dispenser;
        private List<Annotation>? _dispenserinstruction;
        private CodeableConcept? _doseadministrationaid;
        private MedicationRequestSubstitutionAllowedChoice? _allowed;
        private CodeableConcept? _reason;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicationRequest";        /// <summary>
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
        /// Basedon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basedon 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Basedon
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(Basedon));
            }
        }        /// <summary>
        /// Priorprescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// Priorprescription 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Priorprescription
        {
            get => _priorprescription;
            set
            {
                _priorprescription = value;
                OnPropertyChanged(nameof(Priorprescription));
            }
        }        /// <summary>
        /// Groupidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Groupidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Groupidentifier
        {
            get => _groupidentifier;
            set
            {
                _groupidentifier = value;
                OnPropertyChanged(nameof(Groupidentifier));
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
        /// Statusreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusreason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Statusreason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(Statusreason));
            }
        }        /// <summary>
        /// Statuschanged
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statuschanged 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Statuschanged
        {
            get => _statuschanged;
            set
            {
                _statuschanged = value;
                OnPropertyChanged(nameof(Statuschanged));
            }
        }        /// <summary>
        /// Intent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Intent
        {
            get => _intent;
            set
            {
                _intent = value;
                OnPropertyChanged(nameof(Intent));
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
        /// Priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Priority 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }        /// <summary>
        /// Donotperform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Donotperform 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Donotperform
        {
            get => _donotperform;
            set
            {
                _donotperform = value;
                OnPropertyChanged(nameof(Donotperform));
            }
        }        /// <summary>
        /// Medication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Medication 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Medication
        {
            get => _medication;
            set
            {
                _medication = value;
                OnPropertyChanged(nameof(Medication));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Informationsource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Informationsource 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Informationsource
        {
            get => _informationsource;
            set
            {
                _informationsource = value;
                OnPropertyChanged(nameof(Informationsource));
            }
        }        /// <summary>
        /// Encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }        /// <summary>
        /// Supportinginformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginformation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supportinginformation
        {
            get => _supportinginformation;
            set
            {
                _supportinginformation = value;
                OnPropertyChanged(nameof(Supportinginformation));
            }
        }        /// <summary>
        /// Authoredon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authoredon 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Authoredon
        {
            get => _authoredon;
            set
            {
                _authoredon = value;
                OnPropertyChanged(nameof(Authoredon));
            }
        }        /// <summary>
        /// Requester
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requester 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Requester
        {
            get => _requester;
            set
            {
                _requester = value;
                OnPropertyChanged(nameof(Requester));
            }
        }        /// <summary>
        /// Reported
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reported 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Reported
        {
            get => _reported;
            set
            {
                _reported = value;
                OnPropertyChanged(nameof(Reported));
            }
        }        /// <summary>
        /// Performertype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performertype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Performertype
        {
            get => _performertype;
            set
            {
                _performertype = value;
                OnPropertyChanged(nameof(Performertype));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }        /// <summary>
        /// Device
        /// </summary>
        /// <remarks>
        /// <para>
        /// Device 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }        /// <summary>
        /// Recorder
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recorder 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Recorder
        {
            get => _recorder;
            set
            {
                _recorder = value;
                OnPropertyChanged(nameof(Recorder));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Courseoftherapytype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Courseoftherapytype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Courseoftherapytype
        {
            get => _courseoftherapytype;
            set
            {
                _courseoftherapytype = value;
                OnPropertyChanged(nameof(Courseoftherapytype));
            }
        }        /// <summary>
        /// Insurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Insurance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Insurance
        {
            get => _insurance;
            set
            {
                _insurance = value;
                OnPropertyChanged(nameof(Insurance));
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
        /// Rendereddosageinstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rendereddosageinstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Rendereddosageinstruction
        {
            get => _rendereddosageinstruction;
            set
            {
                _rendereddosageinstruction = value;
                OnPropertyChanged(nameof(Rendereddosageinstruction));
            }
        }        /// <summary>
        /// Effectivedoseperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Effectivedoseperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Effectivedoseperiod
        {
            get => _effectivedoseperiod;
            set
            {
                _effectivedoseperiod = value;
                OnPropertyChanged(nameof(Effectivedoseperiod));
            }
        }        /// <summary>
        /// Dosageinstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dosageinstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Dosage>? Dosageinstruction
        {
            get => _dosageinstruction;
            set
            {
                _dosageinstruction = value;
                OnPropertyChanged(nameof(Dosageinstruction));
            }
        }        /// <summary>
        /// Dispenserequest
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dispenserequest 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationRequestDispenseRequest? Dispenserequest
        {
            get => _dispenserequest;
            set
            {
                _dispenserequest = value;
                OnPropertyChanged(nameof(Dispenserequest));
            }
        }        /// <summary>
        /// Substitution
        /// </summary>
        /// <remarks>
        /// <para>
        /// Substitution 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationRequestSubstitution? Substitution
        {
            get => _substitution;
            set
            {
                _substitution = value;
                OnPropertyChanged(nameof(Substitution));
            }
        }        /// <summary>
        /// Eventhistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Eventhistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Eventhistory
        {
            get => _eventhistory;
            set
            {
                _eventhistory = value;
                OnPropertyChanged(nameof(Eventhistory));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
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
        /// Initialfill
        /// </summary>
        /// <remarks>
        /// <para>
        /// Initialfill 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationRequestDispenseRequestInitialFill? Initialfill
        {
            get => _initialfill;
            set
            {
                _initialfill = value;
                OnPropertyChanged(nameof(Initialfill));
            }
        }        /// <summary>
        /// Dispenseinterval
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dispenseinterval 的詳細描述。
        /// </para>
        /// </remarks>
        public Duration? Dispenseinterval
        {
            get => _dispenseinterval;
            set
            {
                _dispenseinterval = value;
                OnPropertyChanged(nameof(Dispenseinterval));
            }
        }        /// <summary>
        /// Validityperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Validityperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Validityperiod
        {
            get => _validityperiod;
            set
            {
                _validityperiod = value;
                OnPropertyChanged(nameof(Validityperiod));
            }
        }        /// <summary>
        /// Numberofrepeatsallowed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Numberofrepeatsallowed 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Numberofrepeatsallowed
        {
            get => _numberofrepeatsallowed;
            set
            {
                _numberofrepeatsallowed = value;
                OnPropertyChanged(nameof(Numberofrepeatsallowed));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Expectedsupplyduration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expectedsupplyduration 的詳細描述。
        /// </para>
        /// </remarks>
        public Duration? Expectedsupplyduration
        {
            get => _expectedsupplyduration;
            set
            {
                _expectedsupplyduration = value;
                OnPropertyChanged(nameof(Expectedsupplyduration));
            }
        }        /// <summary>
        /// Dispenser
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dispenser 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Dispenser
        {
            get => _dispenser;
            set
            {
                _dispenser = value;
                OnPropertyChanged(nameof(Dispenser));
            }
        }        /// <summary>
        /// Dispenserinstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dispenserinstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? Dispenserinstruction
        {
            get => _dispenserinstruction;
            set
            {
                _dispenserinstruction = value;
                OnPropertyChanged(nameof(Dispenserinstruction));
            }
        }        /// <summary>
        /// Doseadministrationaid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Doseadministrationaid 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Doseadministrationaid
        {
            get => _doseadministrationaid;
            set
            {
                _doseadministrationaid = value;
                OnPropertyChanged(nameof(Doseadministrationaid));
            }
        }        /// <summary>
        /// Allowed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Allowed 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationRequestSubstitutionAllowedChoice? Allowed
        {
            get => _allowed;
            set
            {
                _allowed = value;
                OnPropertyChanged(nameof(Allowed));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
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
    }    /// <summary>
    /// MedicationRequestDispenseRequestInitialFill 背骨元素
    /// </summary>
    public class MedicationRequestDispenseRequestInitialFill
    {
        // TODO: 添加屬性實作
        
        public MedicationRequestDispenseRequestInitialFill() { }
    }    /// <summary>
    /// MedicationRequestDispenseRequest 背骨元素
    /// </summary>
    public class MedicationRequestDispenseRequest
    {
        // TODO: 添加屬性實作
        
        public MedicationRequestDispenseRequest() { }
    }    /// <summary>
    /// MedicationRequestSubstitution 背骨元素
    /// </summary>
    public class MedicationRequestSubstitution
    {
        // TODO: 添加屬性實作
        
        public MedicationRequestSubstitution() { }
    }    /// <summary>
    /// MedicationRequestSubstitutionAllowedChoice 選擇類型
    /// </summary>
    public class MedicationRequestSubstitutionAllowedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MedicationRequestSubstitutionAllowedChoice(JsonObject value) : base("medicationrequestsubstitutionallowed", value, _supportType) { }
        public MedicationRequestSubstitutionAllowedChoice(IComplexType? value) : base("medicationrequestsubstitutionallowed", value) { }
        public MedicationRequestSubstitutionAllowedChoice(IPrimitiveType? value) : base("medicationrequestsubstitutionallowed", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MedicationRequestSubstitutionAllowed" : "medicationrequestsubstitutionallowed";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
