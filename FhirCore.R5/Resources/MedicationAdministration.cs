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
    /// FHIR R5 MedicationAdministration 資源
    /// 
    /// <para>
    /// MedicationAdministration 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 MedicationAdministration 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicationAdministration : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private FhirCode? _status;
        private List<CodeableConcept>? _statusreason;
        private List<CodeableConcept>? _category;
        private CodeableReference? _medication;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportinginformation;
        private MedicationAdministrationOccurenceChoice? _occurence;
        private FhirDateTime? _recorded;
        private FhirBoolean? _issubpotent;
        private List<CodeableConcept>? _subpotentreason;
        private List<MedicationAdministrationPerformer>? _performer;
        private List<CodeableReference>? _reason;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _request;
        private List<CodeableReference>? _device;
        private List<Annotation>? _note;
        private MedicationAdministrationDosage? _dosage;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _eventhistory;
        private CodeableConcept? _function;
        private CodeableReference? _actor;
        private CodeableConcept? _site;
        private CodeableConcept? _route;
        private CodeableConcept? _method;
        private Quantity? _dose;
        private MedicationAdministrationDosageRateChoice? _rate;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicationAdministration";        /// <summary>
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
        /// Statusreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusreason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Statusreason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(Statusreason));
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
        /// Occurence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurence 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationAdministrationOccurenceChoice? Occurence
        {
            get => _occurence;
            set
            {
                _occurence = value;
                OnPropertyChanged(nameof(Occurence));
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
        /// Issubpotent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issubpotent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Issubpotent
        {
            get => _issubpotent;
            set
            {
                _issubpotent = value;
                OnPropertyChanged(nameof(Issubpotent));
            }
        }        /// <summary>
        /// Subpotentreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subpotentreason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Subpotentreason
        {
            get => _subpotentreason;
            set
            {
                _subpotentreason = value;
                OnPropertyChanged(nameof(Subpotentreason));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MedicationAdministrationPerformer>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
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
        /// Request
        /// </summary>
        /// <remarks>
        /// <para>
        /// Request 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(Request));
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
        /// Dosage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dosage 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationAdministrationDosage? Dosage
        {
            get => _dosage;
            set
            {
                _dosage = value;
                OnPropertyChanged(nameof(Dosage));
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
        public CodeableReference? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// Site
        /// </summary>
        /// <remarks>
        /// <para>
        /// Site 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Site
        {
            get => _site;
            set
            {
                _site = value;
                OnPropertyChanged(nameof(Site));
            }
        }        /// <summary>
        /// Route
        /// </summary>
        /// <remarks>
        /// <para>
        /// Route 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Route
        {
            get => _route;
            set
            {
                _route = value;
                OnPropertyChanged(nameof(Route));
            }
        }        /// <summary>
        /// Method
        /// </summary>
        /// <remarks>
        /// <para>
        /// Method 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Method
        {
            get => _method;
            set
            {
                _method = value;
                OnPropertyChanged(nameof(Method));
            }
        }        /// <summary>
        /// Dose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dose 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Dose
        {
            get => _dose;
            set
            {
                _dose = value;
                OnPropertyChanged(nameof(Dose));
            }
        }        /// <summary>
        /// Rate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rate 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationAdministrationDosageRateChoice? Rate
        {
            get => _rate;
            set
            {
                _rate = value;
                OnPropertyChanged(nameof(Rate));
            }
        }        /// <summary>
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
    }    /// <summary>
    /// MedicationAdministrationPerformer 背骨元素
    /// </summary>
    public class MedicationAdministrationPerformer
    {
        // TODO: 添加屬性實作
        
        public MedicationAdministrationPerformer() { }
    }    /// <summary>
    /// MedicationAdministrationDosage 背骨元素
    /// </summary>
    public class MedicationAdministrationDosage
    {
        // TODO: 添加屬性實作
        
        public MedicationAdministrationDosage() { }
    }    /// <summary>
    /// MedicationAdministrationOccurenceChoice 選擇類型
    /// </summary>
    public class MedicationAdministrationOccurenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MedicationAdministrationOccurenceChoice(JsonObject value) : base("medicationadministrationoccurence", value, _supportType) { }
        public MedicationAdministrationOccurenceChoice(IComplexType? value) : base("medicationadministrationoccurence", value) { }
        public MedicationAdministrationOccurenceChoice(IPrimitiveType? value) : base("medicationadministrationoccurence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MedicationAdministrationOccurence" : "medicationadministrationoccurence";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MedicationAdministrationDosageRateChoice 選擇類型
    /// </summary>
    public class MedicationAdministrationDosageRateChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MedicationAdministrationDosageRateChoice(JsonObject value) : base("medicationadministrationdosagerate", value, _supportType) { }
        public MedicationAdministrationDosageRateChoice(IComplexType? value) : base("medicationadministrationdosagerate", value) { }
        public MedicationAdministrationDosageRateChoice(IPrimitiveType? value) : base("medicationadministrationdosagerate", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MedicationAdministrationDosageRate" : "medicationadministrationdosagerate";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
