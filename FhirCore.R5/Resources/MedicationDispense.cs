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
    /// FHIR R5 MedicationDispense 資源
    /// 
    /// <para>
    /// MedicationDispense 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicationdispense = new MedicationDispense("medicationdispense-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 MedicationDispense 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicationDispense : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private FhirCode? _status;
        private CodeableReference? _notperformedreason;
        private FhirDateTime? _statuschanged;
        private List<CodeableConcept>? _category;
        private CodeableReference? _medication;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportinginformation;
        private List<MedicationDispensePerformer>? _performer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _authorizingprescription;
        private CodeableConcept? _type;
        private Quantity? _quantity;
        private Quantity? _dayssupply;
        private FhirDateTime? _recorded;
        private FhirDateTime? _whenprepared;
        private FhirDateTime? _whenhandedover;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _destination;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _receiver;
        private List<Annotation>? _note;
        private FhirMarkdown? _rendereddosageinstruction;
        private List<Dosage>? _dosageinstruction;
        private MedicationDispenseSubstitution? _substitution;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _eventhistory;
        private CodeableConcept? _function;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private FhirBoolean? _wassubstituted;
        private CodeableConcept? _type;
        private List<CodeableConcept>? _reason;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _responsibleparty;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicationDispense";        /// <summary>
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
        /// Partof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Partof 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Partof
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(Partof));
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
        /// Notperformedreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notperformedreason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Notperformedreason
        {
            get => _notperformedreason;
            set
            {
                _notperformedreason = value;
                OnPropertyChanged(nameof(Notperformedreason));
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
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationDispensePerformer>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
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
        /// Authorizingprescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authorizingprescription 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Authorizingprescription
        {
            get => _authorizingprescription;
            set
            {
                _authorizingprescription = value;
                OnPropertyChanged(nameof(Authorizingprescription));
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
        /// Dayssupply
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dayssupply 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Dayssupply
        {
            get => _dayssupply;
            set
            {
                _dayssupply = value;
                OnPropertyChanged(nameof(Dayssupply));
            }
        }        /// <summary>
        /// Recorded
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recorded 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Recorded
        {
            get => _recorded;
            set
            {
                _recorded = value;
                OnPropertyChanged(nameof(Recorded));
            }
        }        /// <summary>
        /// Whenprepared
        /// </summary>
        /// <remarks>
        /// <para>
        /// Whenprepared 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Whenprepared
        {
            get => _whenprepared;
            set
            {
                _whenprepared = value;
                OnPropertyChanged(nameof(Whenprepared));
            }
        }        /// <summary>
        /// Whenhandedover
        /// </summary>
        /// <remarks>
        /// <para>
        /// Whenhandedover 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Whenhandedover
        {
            get => _whenhandedover;
            set
            {
                _whenhandedover = value;
                OnPropertyChanged(nameof(Whenhandedover));
            }
        }        /// <summary>
        /// Destination
        /// </summary>
        /// <remarks>
        /// <para>
        /// Destination 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Destination
        {
            get => _destination;
            set
            {
                _destination = value;
                OnPropertyChanged(nameof(Destination));
            }
        }        /// <summary>
        /// Receiver
        /// </summary>
        /// <remarks>
        /// <para>
        /// Receiver 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Receiver
        {
            get => _receiver;
            set
            {
                _receiver = value;
                OnPropertyChanged(nameof(Receiver));
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
        /// Substitution
        /// </summary>
        /// <remarks>
        /// <para>
        /// Substitution 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationDispenseSubstitution? Substitution
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
        /// Function
        /// </summary>
        /// <remarks>
        /// <para>
        /// Function 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Function
        {
            get => _function;
            set
            {
                _function = value;
                OnPropertyChanged(nameof(Function));
            }
        }        /// <summary>
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// Wassubstituted
        /// </summary>
        /// <remarks>
        /// <para>
        /// Wassubstituted 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Wassubstituted
        {
            get => _wassubstituted;
            set
            {
                _wassubstituted = value;
                OnPropertyChanged(nameof(Wassubstituted));
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
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Responsibleparty
        /// </summary>
        /// <remarks>
        /// <para>
        /// Responsibleparty 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Responsibleparty
        {
            get => _responsibleparty;
            set
            {
                _responsibleparty = value;
                OnPropertyChanged(nameof(Responsibleparty));
            }
        }        /// <summary>
        /// 建立新的 MedicationDispense 資源實例
        /// </summary>
        public MedicationDispense()
        {
        }

        /// <summary>
        /// 建立新的 MedicationDispense 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicationDispense(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicationDispense(Id: {Id})";
        }
    }    /// <summary>
    /// MedicationDispensePerformer 背骨元素
    /// </summary>
    public class MedicationDispensePerformer
    {
        // TODO: 添加屬性實作
        
        public MedicationDispensePerformer() { }
    }    /// <summary>
    /// MedicationDispenseSubstitution 背骨元素
    /// </summary>
    public class MedicationDispenseSubstitution
    {
        // TODO: 添加屬性實作
        
        public MedicationDispenseSubstitution() { }
    }
}
