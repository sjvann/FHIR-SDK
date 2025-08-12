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
    /// FHIR R5 Procedure 資源
    /// 
    /// <para>
    /// Procedure 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var procedure = new Procedure("procedure-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Procedure 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Procedure : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<FhirCanonical>? _instantiatescanonical;
        private List<FhirUri>? _instantiatesuri;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private FhirCode? _status;
        private CodeableConcept? _statusreason;
        private List<CodeableConcept>? _category;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _focus;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private ProcedureOccurrenceChoice? _occurrence;
        private FhirDateTime? _recorded;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _recorder;
        private ProcedureReportedChoice? _reported;
        private List<ProcedurePerformer>? _performer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private List<CodeableReference>? _reason;
        private List<CodeableConcept>? _bodysite;
        private CodeableConcept? _outcome;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _report;
        private List<CodeableReference>? _complication;
        private List<CodeableConcept>? _followup;
        private List<Annotation>? _note;
        private List<ProcedureFocalDevice>? _focaldevice;
        private List<CodeableReference>? _used;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportinginfo;
        private CodeableConcept? _function;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _onbehalfof;
        private Period? _period;
        private CodeableConcept? _action;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _manipulated;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Procedure";        /// <summary>
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
        /// Instantiatescanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatescanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Instantiatescanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(Instantiatescanonical));
            }
        }        /// <summary>
        /// Instantiatesuri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatesuri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Instantiatesuri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(Instantiatesuri));
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
        public CodeableConcept? Statusreason
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
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
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
        /// Focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focus 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(Focus));
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
        /// Occurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public ProcedureOccurrenceChoice? Occurrence
        {
            get => _occurrence;
            set
            {
                _occurrence = value;
                OnPropertyChanged(nameof(Occurrence));
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
        /// Reported
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reported 的詳細描述。
        /// </para>
        /// </remarks>
        public ProcedureReportedChoice? Reported
        {
            get => _reported;
            set
            {
                _reported = value;
                OnPropertyChanged(nameof(Reported));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ProcedurePerformer>? Performer
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
        /// Bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(Bodysite));
            }
        }        /// <summary>
        /// Outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(Outcome));
            }
        }        /// <summary>
        /// Report
        /// </summary>
        /// <remarks>
        /// <para>
        /// Report 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Report
        {
            get => _report;
            set
            {
                _report = value;
                OnPropertyChanged(nameof(Report));
            }
        }        /// <summary>
        /// Complication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Complication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Complication
        {
            get => _complication;
            set
            {
                _complication = value;
                OnPropertyChanged(nameof(Complication));
            }
        }        /// <summary>
        /// Followup
        /// </summary>
        /// <remarks>
        /// <para>
        /// Followup 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Followup
        {
            get => _followup;
            set
            {
                _followup = value;
                OnPropertyChanged(nameof(Followup));
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
        /// Focaldevice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focaldevice 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ProcedureFocalDevice>? Focaldevice
        {
            get => _focaldevice;
            set
            {
                _focaldevice = value;
                OnPropertyChanged(nameof(Focaldevice));
            }
        }        /// <summary>
        /// Used
        /// </summary>
        /// <remarks>
        /// <para>
        /// Used 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Used
        {
            get => _used;
            set
            {
                _used = value;
                OnPropertyChanged(nameof(Used));
            }
        }        /// <summary>
        /// Supportinginfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supportinginfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(Supportinginfo));
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
        /// Onbehalfof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Onbehalfof 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Onbehalfof
        {
            get => _onbehalfof;
            set
            {
                _onbehalfof = value;
                OnPropertyChanged(nameof(Onbehalfof));
            }
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Action
        /// </summary>
        /// <remarks>
        /// <para>
        /// Action 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(nameof(Action));
            }
        }        /// <summary>
        /// Manipulated
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manipulated 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Manipulated
        {
            get => _manipulated;
            set
            {
                _manipulated = value;
                OnPropertyChanged(nameof(Manipulated));
            }
        }        /// <summary>
        /// 建立新的 Procedure 資源實例
        /// </summary>
        public Procedure()
        {
        }

        /// <summary>
        /// 建立新的 Procedure 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Procedure(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Procedure(Id: {Id})";
        }
    }    /// <summary>
    /// ProcedurePerformer 背骨元素
    /// </summary>
    public class ProcedurePerformer
    {
        // TODO: 添加屬性實作
        
        public ProcedurePerformer() { }
    }    /// <summary>
    /// ProcedureFocalDevice 背骨元素
    /// </summary>
    public class ProcedureFocalDevice
    {
        // TODO: 添加屬性實作
        
        public ProcedureFocalDevice() { }
    }    /// <summary>
    /// ProcedureOccurrenceChoice 選擇類型
    /// </summary>
    public class ProcedureOccurrenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ProcedureOccurrenceChoice(JsonObject value) : base("procedureoccurrence", value, _supportType) { }
        public ProcedureOccurrenceChoice(IComplexType? value) : base("procedureoccurrence", value) { }
        public ProcedureOccurrenceChoice(IPrimitiveType? value) : base("procedureoccurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ProcedureOccurrence" : "procedureoccurrence";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ProcedureReportedChoice 選擇類型
    /// </summary>
    public class ProcedureReportedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ProcedureReportedChoice(JsonObject value) : base("procedurereported", value, _supportType) { }
        public ProcedureReportedChoice(IComplexType? value) : base("procedurereported", value) { }
        public ProcedureReportedChoice(IPrimitiveType? value) : base("procedurereported", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ProcedureReported" : "procedurereported";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
