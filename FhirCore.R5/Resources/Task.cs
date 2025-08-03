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
    /// FHIR R5 Task 資源
    /// 
    /// <para>
    /// Task 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var task = new Task("task-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Task 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Task : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCanonical? _instantiatescanonical;
        private FhirUri? _instantiatesuri;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private Identifier? _groupidentifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private FhirCode? _status;
        private CodeableReference? _statusreason;
        private CodeableConcept? _businessstatus;
        private FhirCode? _intent;
        private FhirCode? _priority;
        private FhirBoolean? _donotperform;
        private CodeableConcept? _code;
        private FhirString? _description;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _focus;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _for;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private Period? _requestedperiod;
        private Period? _executionperiod;
        private FhirDateTime? _authoredon;
        private FhirDateTime? _lastmodified;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _requester;
        private List<CodeableReference>? _requestedperformer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _owner;
        private List<TaskPerformer>? _performer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private List<CodeableReference>? _reason;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _insurance;
        private List<Annotation>? _note;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _relevanthistory;
        private TaskRestriction? _restriction;
        private List<TaskInput>? _input;
        private List<TaskOutput>? _output;
        private CodeableConcept? _function;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private FhirPositiveInt? _repetitions;
        private Period? _period;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _recipient;
        private CodeableConcept? _type;
        private TaskInputValueChoice? _value;
        private CodeableConcept? _type;
        private TaskOutputValueChoice? _value;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Task";        /// <summary>
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
        public FhirCanonical? Instantiatescanonical
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
        public FhirUri? Instantiatesuri
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
        public CodeableReference? Statusreason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(Statusreason));
            }
        }        /// <summary>
        /// Businessstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Businessstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Businessstatus
        {
            get => _businessstatus;
            set
            {
                _businessstatus = value;
                OnPropertyChanged(nameof(Businessstatus));
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
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
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
        /// For
        /// </summary>
        /// <remarks>
        /// <para>
        /// For 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? For
        {
            get => _for;
            set
            {
                _for = value;
                OnPropertyChanged(nameof(For));
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
        /// Requestedperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requestedperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Requestedperiod
        {
            get => _requestedperiod;
            set
            {
                _requestedperiod = value;
                OnPropertyChanged(nameof(Requestedperiod));
            }
        }        /// <summary>
        /// Executionperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Executionperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Executionperiod
        {
            get => _executionperiod;
            set
            {
                _executionperiod = value;
                OnPropertyChanged(nameof(Executionperiod));
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
        /// Lastmodified
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lastmodified 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Lastmodified
        {
            get => _lastmodified;
            set
            {
                _lastmodified = value;
                OnPropertyChanged(nameof(Lastmodified));
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
        /// Requestedperformer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requestedperformer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Requestedperformer
        {
            get => _requestedperformer;
            set
            {
                _requestedperformer = value;
                OnPropertyChanged(nameof(Requestedperformer));
            }
        }        /// <summary>
        /// Owner
        /// </summary>
        /// <remarks>
        /// <para>
        /// Owner 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Owner
        {
            get => _owner;
            set
            {
                _owner = value;
                OnPropertyChanged(nameof(Owner));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TaskPerformer>? Performer
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
        /// Relevanthistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relevanthistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Relevanthistory
        {
            get => _relevanthistory;
            set
            {
                _relevanthistory = value;
                OnPropertyChanged(nameof(Relevanthistory));
            }
        }        /// <summary>
        /// Restriction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Restriction 的詳細描述。
        /// </para>
        /// </remarks>
        public TaskRestriction? Restriction
        {
            get => _restriction;
            set
            {
                _restriction = value;
                OnPropertyChanged(nameof(Restriction));
            }
        }        /// <summary>
        /// Input
        /// </summary>
        /// <remarks>
        /// <para>
        /// Input 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TaskInput>? Input
        {
            get => _input;
            set
            {
                _input = value;
                OnPropertyChanged(nameof(Input));
            }
        }        /// <summary>
        /// Output
        /// </summary>
        /// <remarks>
        /// <para>
        /// Output 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TaskOutput>? Output
        {
            get => _output;
            set
            {
                _output = value;
                OnPropertyChanged(nameof(Output));
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
        /// Repetitions
        /// </summary>
        /// <remarks>
        /// <para>
        /// Repetitions 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Repetitions
        {
            get => _repetitions;
            set
            {
                _repetitions = value;
                OnPropertyChanged(nameof(Repetitions));
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
        /// Recipient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recipient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Recipient
        {
            get => _recipient;
            set
            {
                _recipient = value;
                OnPropertyChanged(nameof(Recipient));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public TaskInputValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public TaskOutputValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// 建立新的 Task 資源實例
        /// </summary>
        public Task()
        {
        }

        /// <summary>
        /// 建立新的 Task 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Task(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Task(Id: {Id})";
        }
    }    /// <summary>
    /// TaskPerformer 背骨元素
    /// </summary>
    public class TaskPerformer
    {
        // TODO: 添加屬性實作
        
        public TaskPerformer() { }
    }    /// <summary>
    /// TaskRestriction 背骨元素
    /// </summary>
    public class TaskRestriction
    {
        // TODO: 添加屬性實作
        
        public TaskRestriction() { }
    }    /// <summary>
    /// TaskInput 背骨元素
    /// </summary>
    public class TaskInput
    {
        // TODO: 添加屬性實作
        
        public TaskInput() { }
    }    /// <summary>
    /// TaskOutput 背骨元素
    /// </summary>
    public class TaskOutput
    {
        // TODO: 添加屬性實作
        
        public TaskOutput() { }
    }    /// <summary>
    /// TaskInputValueChoice 選擇類型
    /// </summary>
    public class TaskInputValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public TaskInputValueChoice(JsonObject value) : base("taskinputvalue", value, _supportType) { }
        public TaskInputValueChoice(IComplexType? value) : base("taskinputvalue", value) { }
        public TaskInputValueChoice(IPrimitiveType? value) : base("taskinputvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "TaskInputValue" : "taskinputvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// TaskOutputValueChoice 選擇類型
    /// </summary>
    public class TaskOutputValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public TaskOutputValueChoice(JsonObject value) : base("taskoutputvalue", value, _supportType) { }
        public TaskOutputValueChoice(IComplexType? value) : base("taskoutputvalue", value) { }
        public TaskOutputValueChoice(IPrimitiveType? value) : base("taskoutputvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "TaskOutputValue" : "taskoutputvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
