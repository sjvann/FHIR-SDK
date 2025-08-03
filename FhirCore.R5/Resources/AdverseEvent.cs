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
    /// FHIR R5 AdverseEvent 資源
    /// 
    /// <para>
    /// AdverseEvent 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var adverseevent = new AdverseEvent("adverseevent-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 AdverseEvent 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class AdverseEvent : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private FhirCode? _actuality;
        private List<CodeableConcept>? _category;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private AdverseEventOccurrenceChoice? _occurrence;
        private FhirDateTime? _detected;
        private FhirDateTime? _recordeddate;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _resultingeffect;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private CodeableConcept? _seriousness;
        private List<CodeableConcept>? _outcome;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _recorder;
        private List<AdverseEventParticipant>? _participant;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _study;
        private FhirBoolean? _expectedinresearchstudy;
        private List<AdverseEventSuspectEntity>? _suspectentity;
        private List<AdverseEventContributingFactor>? _contributingfactor;
        private List<AdverseEventPreventiveAction>? _preventiveaction;
        private List<AdverseEventMitigatingAction>? _mitigatingaction;
        private List<AdverseEventSupportingInfo>? _supportinginfo;
        private List<Annotation>? _note;
        private CodeableConcept? _function;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private CodeableConcept? _assessmentmethod;
        private CodeableConcept? _entityrelatedness;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;
        private AdverseEventSuspectEntityInstanceChoice? _instance;
        private AdverseEventSuspectEntityCausality? _causality;
        private AdverseEventContributingFactorItemChoice? _item;
        private AdverseEventPreventiveActionItemChoice? _item;
        private AdverseEventMitigatingActionItemChoice? _item;
        private AdverseEventSupportingInfoItemChoice? _item;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "AdverseEvent";        /// <summary>
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
        /// Actuality
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actuality 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Actuality
        {
            get => _actuality;
            set
            {
                _actuality = value;
                OnPropertyChanged(nameof(Actuality));
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
        public AdverseEventOccurrenceChoice? Occurrence
        {
            get => _occurrence;
            set
            {
                _occurrence = value;
                OnPropertyChanged(nameof(Occurrence));
            }
        }        /// <summary>
        /// Detected
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detected 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Detected
        {
            get => _detected;
            set
            {
                _detected = value;
                OnPropertyChanged(nameof(Detected));
            }
        }        /// <summary>
        /// Recordeddate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recordeddate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Recordeddate
        {
            get => _recordeddate;
            set
            {
                _recordeddate = value;
                OnPropertyChanged(nameof(Recordeddate));
            }
        }        /// <summary>
        /// Resultingeffect
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resultingeffect 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Resultingeffect
        {
            get => _resultingeffect;
            set
            {
                _resultingeffect = value;
                OnPropertyChanged(nameof(Resultingeffect));
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
        /// Seriousness
        /// </summary>
        /// <remarks>
        /// <para>
        /// Seriousness 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Seriousness
        {
            get => _seriousness;
            set
            {
                _seriousness = value;
                OnPropertyChanged(nameof(Seriousness));
            }
        }        /// <summary>
        /// Outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(Outcome));
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
        /// Participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// Participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AdverseEventParticipant>? Participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(Participant));
            }
        }        /// <summary>
        /// Study
        /// </summary>
        /// <remarks>
        /// <para>
        /// Study 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Study
        {
            get => _study;
            set
            {
                _study = value;
                OnPropertyChanged(nameof(Study));
            }
        }        /// <summary>
        /// Expectedinresearchstudy
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expectedinresearchstudy 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Expectedinresearchstudy
        {
            get => _expectedinresearchstudy;
            set
            {
                _expectedinresearchstudy = value;
                OnPropertyChanged(nameof(Expectedinresearchstudy));
            }
        }        /// <summary>
        /// Suspectentity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Suspectentity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AdverseEventSuspectEntity>? Suspectentity
        {
            get => _suspectentity;
            set
            {
                _suspectentity = value;
                OnPropertyChanged(nameof(Suspectentity));
            }
        }        /// <summary>
        /// Contributingfactor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contributingfactor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AdverseEventContributingFactor>? Contributingfactor
        {
            get => _contributingfactor;
            set
            {
                _contributingfactor = value;
                OnPropertyChanged(nameof(Contributingfactor));
            }
        }        /// <summary>
        /// Preventiveaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preventiveaction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AdverseEventPreventiveAction>? Preventiveaction
        {
            get => _preventiveaction;
            set
            {
                _preventiveaction = value;
                OnPropertyChanged(nameof(Preventiveaction));
            }
        }        /// <summary>
        /// Mitigatingaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mitigatingaction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AdverseEventMitigatingAction>? Mitigatingaction
        {
            get => _mitigatingaction;
            set
            {
                _mitigatingaction = value;
                OnPropertyChanged(nameof(Mitigatingaction));
            }
        }        /// <summary>
        /// Supportinginfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AdverseEventSupportingInfo>? Supportinginfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(Supportinginfo));
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
        /// Assessmentmethod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Assessmentmethod 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Assessmentmethod
        {
            get => _assessmentmethod;
            set
            {
                _assessmentmethod = value;
                OnPropertyChanged(nameof(Assessmentmethod));
            }
        }        /// <summary>
        /// Entityrelatedness
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entityrelatedness 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Entityrelatedness
        {
            get => _entityrelatedness;
            set
            {
                _entityrelatedness = value;
                OnPropertyChanged(nameof(Entityrelatedness));
            }
        }        /// <summary>
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }        /// <summary>
        /// Instance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instance 的詳細描述。
        /// </para>
        /// </remarks>
        public AdverseEventSuspectEntityInstanceChoice? Instance
        {
            get => _instance;
            set
            {
                _instance = value;
                OnPropertyChanged(nameof(Instance));
            }
        }        /// <summary>
        /// Causality
        /// </summary>
        /// <remarks>
        /// <para>
        /// Causality 的詳細描述。
        /// </para>
        /// </remarks>
        public AdverseEventSuspectEntityCausality? Causality
        {
            get => _causality;
            set
            {
                _causality = value;
                OnPropertyChanged(nameof(Causality));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public AdverseEventContributingFactorItemChoice? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public AdverseEventPreventiveActionItemChoice? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public AdverseEventMitigatingActionItemChoice? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public AdverseEventSupportingInfoItemChoice? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// 建立新的 AdverseEvent 資源實例
        /// </summary>
        public AdverseEvent()
        {
        }

        /// <summary>
        /// 建立新的 AdverseEvent 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public AdverseEvent(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"AdverseEvent(Id: {Id})";
        }
    }    /// <summary>
    /// AdverseEventParticipant 背骨元素
    /// </summary>
    public class AdverseEventParticipant
    {
        // TODO: 添加屬性實作
        
        public AdverseEventParticipant() { }
    }    /// <summary>
    /// AdverseEventSuspectEntityCausality 背骨元素
    /// </summary>
    public class AdverseEventSuspectEntityCausality
    {
        // TODO: 添加屬性實作
        
        public AdverseEventSuspectEntityCausality() { }
    }    /// <summary>
    /// AdverseEventSuspectEntity 背骨元素
    /// </summary>
    public class AdverseEventSuspectEntity
    {
        // TODO: 添加屬性實作
        
        public AdverseEventSuspectEntity() { }
    }    /// <summary>
    /// AdverseEventContributingFactor 背骨元素
    /// </summary>
    public class AdverseEventContributingFactor
    {
        // TODO: 添加屬性實作
        
        public AdverseEventContributingFactor() { }
    }    /// <summary>
    /// AdverseEventPreventiveAction 背骨元素
    /// </summary>
    public class AdverseEventPreventiveAction
    {
        // TODO: 添加屬性實作
        
        public AdverseEventPreventiveAction() { }
    }    /// <summary>
    /// AdverseEventMitigatingAction 背骨元素
    /// </summary>
    public class AdverseEventMitigatingAction
    {
        // TODO: 添加屬性實作
        
        public AdverseEventMitigatingAction() { }
    }    /// <summary>
    /// AdverseEventSupportingInfo 背骨元素
    /// </summary>
    public class AdverseEventSupportingInfo
    {
        // TODO: 添加屬性實作
        
        public AdverseEventSupportingInfo() { }
    }    /// <summary>
    /// AdverseEventOccurrenceChoice 選擇類型
    /// </summary>
    public class AdverseEventOccurrenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public AdverseEventOccurrenceChoice(JsonObject value) : base("adverseeventoccurrence", value, _supportType) { }
        public AdverseEventOccurrenceChoice(IComplexType? value) : base("adverseeventoccurrence", value) { }
        public AdverseEventOccurrenceChoice(IPrimitiveType? value) : base("adverseeventoccurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "AdverseEventOccurrence" : "adverseeventoccurrence";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// AdverseEventSuspectEntityInstanceChoice 選擇類型
    /// </summary>
    public class AdverseEventSuspectEntityInstanceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public AdverseEventSuspectEntityInstanceChoice(JsonObject value) : base("adverseeventsuspectentityinstance", value, _supportType) { }
        public AdverseEventSuspectEntityInstanceChoice(IComplexType? value) : base("adverseeventsuspectentityinstance", value) { }
        public AdverseEventSuspectEntityInstanceChoice(IPrimitiveType? value) : base("adverseeventsuspectentityinstance", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "AdverseEventSuspectEntityInstance" : "adverseeventsuspectentityinstance";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// AdverseEventContributingFactorItemChoice 選擇類型
    /// </summary>
    public class AdverseEventContributingFactorItemChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public AdverseEventContributingFactorItemChoice(JsonObject value) : base("adverseeventcontributingfactoritem", value, _supportType) { }
        public AdverseEventContributingFactorItemChoice(IComplexType? value) : base("adverseeventcontributingfactoritem", value) { }
        public AdverseEventContributingFactorItemChoice(IPrimitiveType? value) : base("adverseeventcontributingfactoritem", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "AdverseEventContributingFactorItem" : "adverseeventcontributingfactoritem";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// AdverseEventPreventiveActionItemChoice 選擇類型
    /// </summary>
    public class AdverseEventPreventiveActionItemChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public AdverseEventPreventiveActionItemChoice(JsonObject value) : base("adverseeventpreventiveactionitem", value, _supportType) { }
        public AdverseEventPreventiveActionItemChoice(IComplexType? value) : base("adverseeventpreventiveactionitem", value) { }
        public AdverseEventPreventiveActionItemChoice(IPrimitiveType? value) : base("adverseeventpreventiveactionitem", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "AdverseEventPreventiveActionItem" : "adverseeventpreventiveactionitem";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// AdverseEventMitigatingActionItemChoice 選擇類型
    /// </summary>
    public class AdverseEventMitigatingActionItemChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public AdverseEventMitigatingActionItemChoice(JsonObject value) : base("adverseeventmitigatingactionitem", value, _supportType) { }
        public AdverseEventMitigatingActionItemChoice(IComplexType? value) : base("adverseeventmitigatingactionitem", value) { }
        public AdverseEventMitigatingActionItemChoice(IPrimitiveType? value) : base("adverseeventmitigatingactionitem", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "AdverseEventMitigatingActionItem" : "adverseeventmitigatingactionitem";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// AdverseEventSupportingInfoItemChoice 選擇類型
    /// </summary>
    public class AdverseEventSupportingInfoItemChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public AdverseEventSupportingInfoItemChoice(JsonObject value) : base("adverseeventsupportinginfoitem", value, _supportType) { }
        public AdverseEventSupportingInfoItemChoice(IComplexType? value) : base("adverseeventsupportinginfoitem", value) { }
        public AdverseEventSupportingInfoItemChoice(IPrimitiveType? value) : base("adverseeventsupportinginfoitem", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "AdverseEventSupportingInfoItem" : "adverseeventsupportinginfoitem";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
