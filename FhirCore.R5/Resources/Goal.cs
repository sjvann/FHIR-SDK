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
    /// FHIR R5 Goal 資源
    /// 
    /// <para>
    /// Goal 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var goal = new Goal("goal-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Goal 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Goal : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _lifecyclestatus;
        private CodeableConcept? _achievementstatus;
        private List<CodeableConcept>? _category;
        private FhirBoolean? _continuous;
        private CodeableConcept? _priority;
        private CodeableConcept? _description;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private GoalStartChoice? _start;
        private List<GoalTarget>? _target;
        private FhirDate? _statusdate;
        private FhirString? _statusreason;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _source;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _addresses;
        private List<Annotation>? _note;
        private List<CodeableReference>? _outcome;
        private CodeableConcept? _measure;
        private GoalTargetDetailChoice? _detail;
        private GoalTargetDueChoice? _due;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Goal";        /// <summary>
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
        /// Lifecyclestatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lifecyclestatus 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Lifecyclestatus
        {
            get => _lifecyclestatus;
            set
            {
                _lifecyclestatus = value;
                OnPropertyChanged(nameof(Lifecyclestatus));
            }
        }        /// <summary>
        /// Achievementstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Achievementstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Achievementstatus
        {
            get => _achievementstatus;
            set
            {
                _achievementstatus = value;
                OnPropertyChanged(nameof(Achievementstatus));
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
        /// Continuous
        /// </summary>
        /// <remarks>
        /// <para>
        /// Continuous 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Continuous
        {
            get => _continuous;
            set
            {
                _continuous = value;
                OnPropertyChanged(nameof(Continuous));
            }
        }        /// <summary>
        /// Priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Priority 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
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
        /// Start
        /// </summary>
        /// <remarks>
        /// <para>
        /// Start 的詳細描述。
        /// </para>
        /// </remarks>
        public GoalStartChoice? Start
        {
            get => _start;
            set
            {
                _start = value;
                OnPropertyChanged(nameof(Start));
            }
        }        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public List<GoalTarget>? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }        /// <summary>
        /// Statusdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Statusdate
        {
            get => _statusdate;
            set
            {
                _statusdate = value;
                OnPropertyChanged(nameof(Statusdate));
            }
        }        /// <summary>
        /// Statusreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusreason 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Statusreason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(Statusreason));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Addresses
        /// </summary>
        /// <remarks>
        /// <para>
        /// Addresses 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Addresses
        {
            get => _addresses;
            set
            {
                _addresses = value;
                OnPropertyChanged(nameof(Addresses));
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
        /// Outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(Outcome));
            }
        }        /// <summary>
        /// Measure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Measure 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Measure
        {
            get => _measure;
            set
            {
                _measure = value;
                OnPropertyChanged(nameof(Measure));
            }
        }        /// <summary>
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public GoalTargetDetailChoice? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
            }
        }        /// <summary>
        /// Due
        /// </summary>
        /// <remarks>
        /// <para>
        /// Due 的詳細描述。
        /// </para>
        /// </remarks>
        public GoalTargetDueChoice? Due
        {
            get => _due;
            set
            {
                _due = value;
                OnPropertyChanged(nameof(Due));
            }
        }        /// <summary>
        /// 建立新的 Goal 資源實例
        /// </summary>
        public Goal()
        {
        }

        /// <summary>
        /// 建立新的 Goal 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Goal(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Goal(Id: {Id})";
        }
    }    /// <summary>
    /// GoalTarget 背骨元素
    /// </summary>
    public class GoalTarget
    {
        // TODO: 添加屬性實作
        
        public GoalTarget() { }
    }    /// <summary>
    /// GoalStartChoice 選擇類型
    /// </summary>
    public class GoalStartChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public GoalStartChoice(JsonObject value) : base("goalstart", value, _supportType) { }
        public GoalStartChoice(IComplexType? value) : base("goalstart", value) { }
        public GoalStartChoice(IPrimitiveType? value) : base("goalstart", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "GoalStart" : "goalstart";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// GoalTargetDetailChoice 選擇類型
    /// </summary>
    public class GoalTargetDetailChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public GoalTargetDetailChoice(JsonObject value) : base("goaltargetdetail", value, _supportType) { }
        public GoalTargetDetailChoice(IComplexType? value) : base("goaltargetdetail", value) { }
        public GoalTargetDetailChoice(IPrimitiveType? value) : base("goaltargetdetail", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "GoalTargetDetail" : "goaltargetdetail";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// GoalTargetDueChoice 選擇類型
    /// </summary>
    public class GoalTargetDueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public GoalTargetDueChoice(JsonObject value) : base("goaltargetdue", value, _supportType) { }
        public GoalTargetDueChoice(IComplexType? value) : base("goaltargetdue", value) { }
        public GoalTargetDueChoice(IPrimitiveType? value) : base("goaltargetdue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "GoalTargetDue" : "goaltargetdue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
