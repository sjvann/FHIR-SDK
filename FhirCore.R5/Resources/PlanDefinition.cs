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
    /// FHIR R5 PlanDefinition 資源
    /// 
    /// <para>
    /// PlanDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var plandefinition = new PlanDefinition("plandefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 PlanDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class PlanDefinition : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private PlanDefinitionVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private FhirString? _subtitle;
        private CodeableConcept? _type;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private PlanDefinitionSubjectChoice? _subject;
        private FhirDateTime? _date;
        private FhirString? _publisher;
        private List<ContactDetail>? _contact;
        private FhirMarkdown? _description;
        private List<UsageContext>? _usecontext;
        private List<CodeableConcept>? _jurisdiction;
        private FhirMarkdown? _purpose;
        private FhirMarkdown? _usage;
        private FhirMarkdown? _copyright;
        private FhirString? _copyrightlabel;
        private FhirDate? _approvaldate;
        private FhirDate? _lastreviewdate;
        private Period? _effectiveperiod;
        private List<CodeableConcept>? _topic;
        private List<ContactDetail>? _author;
        private List<ContactDetail>? _editor;
        private List<ContactDetail>? _reviewer;
        private List<ContactDetail>? _endorser;
        private List<RelatedArtifact>? _relatedartifact;
        private List<FhirCanonical>? _library;
        private List<PlanDefinitionGoal>? _goal;
        private List<PlanDefinitionActor>? _actor;
        private List<PlanDefinitionAction>? _action;
        private PlanDefinitionAsNeededChoice? _asneeded;
        private CodeableConcept? _measure;
        private PlanDefinitionGoalTargetDetailChoice? _detail;
        private Duration? _due;
        private CodeableConcept? _category;
        private CodeableConcept? _description;
        private CodeableConcept? _priority;
        private CodeableConcept? _start;
        private List<CodeableConcept>? _addresses;
        private List<RelatedArtifact>? _documentation;
        private List<PlanDefinitionGoalTarget>? _target;
        private FhirCode? _type;
        private FhirCanonical? _typecanonical;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _typereference;
        private CodeableConcept? _role;
        private FhirString? _title;
        private FhirMarkdown? _description;
        private List<PlanDefinitionActorOption>? _option;
        private FhirCode? _kind;
        private ExpressionType? _expression;
        private FhirString? _title;
        private DataRequirement? _requirement;
        private FhirId? _relateddata;
        private FhirString? _title;
        private DataRequirement? _requirement;
        private FhirString? _relateddata;
        private FhirId? _targetid;
        private FhirCode? _relationship;
        private FhirCode? _endrelationship;
        private PlanDefinitionActionRelatedActionOffsetChoice? _offset;
        private FhirString? _actorid;
        private FhirCode? _type;
        private FhirCanonical? _typecanonical;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _typereference;
        private CodeableConcept? _role;
        private CodeableConcept? _function;
        private FhirString? _path;
        private ExpressionType? _expression;
        private FhirString? _linkid;
        private FhirString? _prefix;
        private FhirString? _title;
        private FhirMarkdown? _description;
        private FhirMarkdown? _textequivalent;
        private FhirCode? _priority;
        private CodeableConcept? _code;
        private List<CodeableConcept>? _reason;
        private List<RelatedArtifact>? _documentation;
        private List<FhirId>? _goalid;
        private PlanDefinitionActionSubjectChoice? _subject;
        private List<TriggerDefinition>? _trigger;
        private List<PlanDefinitionActionCondition>? _condition;
        private List<PlanDefinitionActionInput>? _input;
        private List<PlanDefinitionActionOutput>? _output;
        private List<PlanDefinitionActionRelatedAction>? _relatedaction;
        private PlanDefinitionActionTimingChoice? _timing;
        private CodeableReference? _location;
        private List<PlanDefinitionActionParticipant>? _participant;
        private CodeableConcept? _type;
        private FhirCode? _groupingbehavior;
        private FhirCode? _selectionbehavior;
        private FhirCode? _requiredbehavior;
        private FhirCode? _precheckbehavior;
        private FhirCode? _cardinalitybehavior;
        private PlanDefinitionActionDefinitionChoice? _definition;
        private FhirCanonical? _transform;
        private List<PlanDefinitionActionDynamicValue>? _dynamicvalue;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "PlanDefinition";        /// <summary>
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private FhirUri? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
            }
        }        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
            }
        }        /// <summary>
        /// Versionalgorithm
        /// </summary>
        /// <remarks>
        /// <para>
        /// Versionalgorithm 的詳細描述。
        /// </para>
        /// </remarks>
        public PlanDefinitionVersionAlgorithmChoice? Versionalgorithm
        {
            get => _versionalgorithm;
            set
            {
                _versionalgorithm = value;
                OnPropertyChanged(nameof(Versionalgorithm));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Subtitle
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subtitle 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Subtitle
        {
            get => _subtitle;
            set
            {
                _subtitle = value;
                OnPropertyChanged(nameof(Subtitle));
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
        /// Experimental
        /// </summary>
        /// <remarks>
        /// <para>
        /// Experimental 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Experimental
        {
            get => _experimental;
            set
            {
                _experimental = value;
                OnPropertyChanged(nameof(Experimental));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public PlanDefinitionSubjectChoice? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Publisher
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publisher 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Publisher
        {
            get => _publisher;
            set
            {
                _publisher = value;
                OnPropertyChanged(nameof(Publisher));
            }
        }        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Usecontext
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usecontext 的詳細描述。
        /// </para>
        /// </remarks>
        public List<UsageContext>? Usecontext
        {
            get => _usecontext;
            set
            {
                _usecontext = value;
                OnPropertyChanged(nameof(Usecontext));
            }
        }        /// <summary>
        /// Jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(Jurisdiction));
            }
        }        /// <summary>
        /// Purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(Purpose));
            }
        }        /// <summary>
        /// Usage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usage 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Usage
        {
            get => _usage;
            set
            {
                _usage = value;
                OnPropertyChanged(nameof(Usage));
            }
        }        /// <summary>
        /// Copyright
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copyright 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Copyright
        {
            get => _copyright;
            set
            {
                _copyright = value;
                OnPropertyChanged(nameof(Copyright));
            }
        }        /// <summary>
        /// Copyrightlabel
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copyrightlabel 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Copyrightlabel
        {
            get => _copyrightlabel;
            set
            {
                _copyrightlabel = value;
                OnPropertyChanged(nameof(Copyrightlabel));
            }
        }        /// <summary>
        /// Approvaldate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Approvaldate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Approvaldate
        {
            get => _approvaldate;
            set
            {
                _approvaldate = value;
                OnPropertyChanged(nameof(Approvaldate));
            }
        }        /// <summary>
        /// Lastreviewdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lastreviewdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Lastreviewdate
        {
            get => _lastreviewdate;
            set
            {
                _lastreviewdate = value;
                OnPropertyChanged(nameof(Lastreviewdate));
            }
        }        /// <summary>
        /// Effectiveperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Effectiveperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Effectiveperiod
        {
            get => _effectiveperiod;
            set
            {
                _effectiveperiod = value;
                OnPropertyChanged(nameof(Effectiveperiod));
            }
        }        /// <summary>
        /// Topic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Topic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Topic
        {
            get => _topic;
            set
            {
                _topic = value;
                OnPropertyChanged(nameof(Topic));
            }
        }        /// <summary>
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }        /// <summary>
        /// Editor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Editor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Editor
        {
            get => _editor;
            set
            {
                _editor = value;
                OnPropertyChanged(nameof(Editor));
            }
        }        /// <summary>
        /// Reviewer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reviewer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Reviewer
        {
            get => _reviewer;
            set
            {
                _reviewer = value;
                OnPropertyChanged(nameof(Reviewer));
            }
        }        /// <summary>
        /// Endorser
        /// </summary>
        /// <remarks>
        /// <para>
        /// Endorser 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Endorser
        {
            get => _endorser;
            set
            {
                _endorser = value;
                OnPropertyChanged(nameof(Endorser));
            }
        }        /// <summary>
        /// Relatedartifact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatedartifact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RelatedArtifact>? Relatedartifact
        {
            get => _relatedartifact;
            set
            {
                _relatedartifact = value;
                OnPropertyChanged(nameof(Relatedartifact));
            }
        }        /// <summary>
        /// Library
        /// </summary>
        /// <remarks>
        /// <para>
        /// Library 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Library
        {
            get => _library;
            set
            {
                _library = value;
                OnPropertyChanged(nameof(Library));
            }
        }        /// <summary>
        /// Goal
        /// </summary>
        /// <remarks>
        /// <para>
        /// Goal 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PlanDefinitionGoal>? Goal
        {
            get => _goal;
            set
            {
                _goal = value;
                OnPropertyChanged(nameof(Goal));
            }
        }        /// <summary>
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PlanDefinitionActor>? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// Action
        /// </summary>
        /// <remarks>
        /// <para>
        /// Action 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PlanDefinitionAction>? Action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(nameof(Action));
            }
        }        /// <summary>
        /// Asneeded
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asneeded 的詳細描述。
        /// </para>
        /// </remarks>
        public PlanDefinitionAsNeededChoice? Asneeded
        {
            get => _asneeded;
            set
            {
                _asneeded = value;
                OnPropertyChanged(nameof(Asneeded));
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
        public PlanDefinitionGoalTargetDetailChoice? Detail
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
        public Duration? Due
        {
            get => _due;
            set
            {
                _due = value;
                OnPropertyChanged(nameof(Due));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
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
        /// Start
        /// </summary>
        /// <remarks>
        /// <para>
        /// Start 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Start
        {
            get => _start;
            set
            {
                _start = value;
                OnPropertyChanged(nameof(Start));
            }
        }        /// <summary>
        /// Addresses
        /// </summary>
        /// <remarks>
        /// <para>
        /// Addresses 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Addresses
        {
            get => _addresses;
            set
            {
                _addresses = value;
                OnPropertyChanged(nameof(Addresses));
            }
        }        /// <summary>
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RelatedArtifact>? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
            }
        }        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PlanDefinitionGoalTarget>? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Typecanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Typecanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Typecanonical
        {
            get => _typecanonical;
            set
            {
                _typecanonical = value;
                OnPropertyChanged(nameof(Typecanonical));
            }
        }        /// <summary>
        /// Typereference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Typereference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Typereference
        {
            get => _typereference;
            set
            {
                _typereference = value;
                OnPropertyChanged(nameof(Typereference));
            }
        }        /// <summary>
        /// Role
        /// </summary>
        /// <remarks>
        /// <para>
        /// Role 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
            }
        }        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Option
        /// </summary>
        /// <remarks>
        /// <para>
        /// Option 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PlanDefinitionActorOption>? Option
        {
            get => _option;
            set
            {
                _option = value;
                OnPropertyChanged(nameof(Option));
            }
        }        /// <summary>
        /// Kind
        /// </summary>
        /// <remarks>
        /// <para>
        /// Kind 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Kind
        {
            get => _kind;
            set
            {
                _kind = value;
                OnPropertyChanged(nameof(Kind));
            }
        }        /// <summary>
        /// Expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expression 的詳細描述。
        /// </para>
        /// </remarks>
        public ExpressionType? Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Requirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requirement 的詳細描述。
        /// </para>
        /// </remarks>
        public DataRequirement? Requirement
        {
            get => _requirement;
            set
            {
                _requirement = value;
                OnPropertyChanged(nameof(Requirement));
            }
        }        /// <summary>
        /// Relateddata
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relateddata 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Relateddata
        {
            get => _relateddata;
            set
            {
                _relateddata = value;
                OnPropertyChanged(nameof(Relateddata));
            }
        }        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Requirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requirement 的詳細描述。
        /// </para>
        /// </remarks>
        public DataRequirement? Requirement
        {
            get => _requirement;
            set
            {
                _requirement = value;
                OnPropertyChanged(nameof(Requirement));
            }
        }        /// <summary>
        /// Relateddata
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relateddata 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Relateddata
        {
            get => _relateddata;
            set
            {
                _relateddata = value;
                OnPropertyChanged(nameof(Relateddata));
            }
        }        /// <summary>
        /// Targetid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Targetid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Targetid
        {
            get => _targetid;
            set
            {
                _targetid = value;
                OnPropertyChanged(nameof(Targetid));
            }
        }        /// <summary>
        /// Relationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relationship 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Relationship
        {
            get => _relationship;
            set
            {
                _relationship = value;
                OnPropertyChanged(nameof(Relationship));
            }
        }        /// <summary>
        /// Endrelationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// Endrelationship 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Endrelationship
        {
            get => _endrelationship;
            set
            {
                _endrelationship = value;
                OnPropertyChanged(nameof(Endrelationship));
            }
        }        /// <summary>
        /// Offset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Offset 的詳細描述。
        /// </para>
        /// </remarks>
        public PlanDefinitionActionRelatedActionOffsetChoice? Offset
        {
            get => _offset;
            set
            {
                _offset = value;
                OnPropertyChanged(nameof(Offset));
            }
        }        /// <summary>
        /// Actorid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actorid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Actorid
        {
            get => _actorid;
            set
            {
                _actorid = value;
                OnPropertyChanged(nameof(Actorid));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Typecanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Typecanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Typecanonical
        {
            get => _typecanonical;
            set
            {
                _typecanonical = value;
                OnPropertyChanged(nameof(Typecanonical));
            }
        }        /// <summary>
        /// Typereference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Typereference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Typereference
        {
            get => _typereference;
            set
            {
                _typereference = value;
                OnPropertyChanged(nameof(Typereference));
            }
        }        /// <summary>
        /// Role
        /// </summary>
        /// <remarks>
        /// <para>
        /// Role 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
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
        /// Path
        /// </summary>
        /// <remarks>
        /// <para>
        /// Path 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Path
        {
            get => _path;
            set
            {
                _path = value;
                OnPropertyChanged(nameof(Path));
            }
        }        /// <summary>
        /// Expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expression 的詳細描述。
        /// </para>
        /// </remarks>
        public ExpressionType? Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
            }
        }        /// <summary>
        /// Prefix
        /// </summary>
        /// <remarks>
        /// <para>
        /// Prefix 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Prefix
        {
            get => _prefix;
            set
            {
                _prefix = value;
                OnPropertyChanged(nameof(Prefix));
            }
        }        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Textequivalent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Textequivalent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Textequivalent
        {
            get => _textequivalent;
            set
            {
                _textequivalent = value;
                OnPropertyChanged(nameof(Textequivalent));
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
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RelatedArtifact>? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
            }
        }        /// <summary>
        /// Goalid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Goalid 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirId>? Goalid
        {
            get => _goalid;
            set
            {
                _goalid = value;
                OnPropertyChanged(nameof(Goalid));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public PlanDefinitionActionSubjectChoice? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Trigger
        /// </summary>
        /// <remarks>
        /// <para>
        /// Trigger 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TriggerDefinition>? Trigger
        {
            get => _trigger;
            set
            {
                _trigger = value;
                OnPropertyChanged(nameof(Trigger));
            }
        }        /// <summary>
        /// Condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Condition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PlanDefinitionActionCondition>? Condition
        {
            get => _condition;
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
            }
        }        /// <summary>
        /// Input
        /// </summary>
        /// <remarks>
        /// <para>
        /// Input 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PlanDefinitionActionInput>? Input
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
        public List<PlanDefinitionActionOutput>? Output
        {
            get => _output;
            set
            {
                _output = value;
                OnPropertyChanged(nameof(Output));
            }
        }        /// <summary>
        /// Relatedaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatedaction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PlanDefinitionActionRelatedAction>? Relatedaction
        {
            get => _relatedaction;
            set
            {
                _relatedaction = value;
                OnPropertyChanged(nameof(Relatedaction));
            }
        }        /// <summary>
        /// Timing
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timing 的詳細描述。
        /// </para>
        /// </remarks>
        public PlanDefinitionActionTimingChoice? Timing
        {
            get => _timing;
            set
            {
                _timing = value;
                OnPropertyChanged(nameof(Timing));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// Participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PlanDefinitionActionParticipant>? Participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(Participant));
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
        /// Groupingbehavior
        /// </summary>
        /// <remarks>
        /// <para>
        /// Groupingbehavior 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Groupingbehavior
        {
            get => _groupingbehavior;
            set
            {
                _groupingbehavior = value;
                OnPropertyChanged(nameof(Groupingbehavior));
            }
        }        /// <summary>
        /// Selectionbehavior
        /// </summary>
        /// <remarks>
        /// <para>
        /// Selectionbehavior 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Selectionbehavior
        {
            get => _selectionbehavior;
            set
            {
                _selectionbehavior = value;
                OnPropertyChanged(nameof(Selectionbehavior));
            }
        }        /// <summary>
        /// Requiredbehavior
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requiredbehavior 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Requiredbehavior
        {
            get => _requiredbehavior;
            set
            {
                _requiredbehavior = value;
                OnPropertyChanged(nameof(Requiredbehavior));
            }
        }        /// <summary>
        /// Precheckbehavior
        /// </summary>
        /// <remarks>
        /// <para>
        /// Precheckbehavior 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Precheckbehavior
        {
            get => _precheckbehavior;
            set
            {
                _precheckbehavior = value;
                OnPropertyChanged(nameof(Precheckbehavior));
            }
        }        /// <summary>
        /// Cardinalitybehavior
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cardinalitybehavior 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Cardinalitybehavior
        {
            get => _cardinalitybehavior;
            set
            {
                _cardinalitybehavior = value;
                OnPropertyChanged(nameof(Cardinalitybehavior));
            }
        }        /// <summary>
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public PlanDefinitionActionDefinitionChoice? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }        /// <summary>
        /// Transform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Transform 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Transform
        {
            get => _transform;
            set
            {
                _transform = value;
                OnPropertyChanged(nameof(Transform));
            }
        }        /// <summary>
        /// Dynamicvalue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dynamicvalue 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PlanDefinitionActionDynamicValue>? Dynamicvalue
        {
            get => _dynamicvalue;
            set
            {
                _dynamicvalue = value;
                OnPropertyChanged(nameof(Dynamicvalue));
            }
        }        /// <summary>
        /// 建立新的 PlanDefinition 資源實例
        /// </summary>
        public PlanDefinition()
        {
        }

        /// <summary>
        /// 建立新的 PlanDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public PlanDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"PlanDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// PlanDefinitionGoalTarget 背骨元素
    /// </summary>
    public class PlanDefinitionGoalTarget
    {
        // TODO: 添加屬性實作
        
        public PlanDefinitionGoalTarget() { }
    }    /// <summary>
    /// PlanDefinitionGoal 背骨元素
    /// </summary>
    public class PlanDefinitionGoal
    {
        // TODO: 添加屬性實作
        
        public PlanDefinitionGoal() { }
    }    /// <summary>
    /// PlanDefinitionActorOption 背骨元素
    /// </summary>
    public class PlanDefinitionActorOption
    {
        // TODO: 添加屬性實作
        
        public PlanDefinitionActorOption() { }
    }    /// <summary>
    /// PlanDefinitionActor 背骨元素
    /// </summary>
    public class PlanDefinitionActor
    {
        // TODO: 添加屬性實作
        
        public PlanDefinitionActor() { }
    }    /// <summary>
    /// PlanDefinitionActionCondition 背骨元素
    /// </summary>
    public class PlanDefinitionActionCondition
    {
        // TODO: 添加屬性實作
        
        public PlanDefinitionActionCondition() { }
    }    /// <summary>
    /// PlanDefinitionActionInput 背骨元素
    /// </summary>
    public class PlanDefinitionActionInput
    {
        // TODO: 添加屬性實作
        
        public PlanDefinitionActionInput() { }
    }    /// <summary>
    /// PlanDefinitionActionOutput 背骨元素
    /// </summary>
    public class PlanDefinitionActionOutput
    {
        // TODO: 添加屬性實作
        
        public PlanDefinitionActionOutput() { }
    }    /// <summary>
    /// PlanDefinitionActionRelatedAction 背骨元素
    /// </summary>
    public class PlanDefinitionActionRelatedAction
    {
        // TODO: 添加屬性實作
        
        public PlanDefinitionActionRelatedAction() { }
    }    /// <summary>
    /// PlanDefinitionActionParticipant 背骨元素
    /// </summary>
    public class PlanDefinitionActionParticipant
    {
        // TODO: 添加屬性實作
        
        public PlanDefinitionActionParticipant() { }
    }    /// <summary>
    /// PlanDefinitionActionDynamicValue 背骨元素
    /// </summary>
    public class PlanDefinitionActionDynamicValue
    {
        // TODO: 添加屬性實作
        
        public PlanDefinitionActionDynamicValue() { }
    }    /// <summary>
    /// PlanDefinitionAction 背骨元素
    /// </summary>
    public class PlanDefinitionAction
    {
        // TODO: 添加屬性實作
        
        public PlanDefinitionAction() { }
    }    /// <summary>
    /// PlanDefinitionVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class PlanDefinitionVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public PlanDefinitionVersionAlgorithmChoice(JsonObject value) : base("plandefinitionversionalgorithm", value, _supportType) { }
        public PlanDefinitionVersionAlgorithmChoice(IComplexType? value) : base("plandefinitionversionalgorithm", value) { }
        public PlanDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("plandefinitionversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "PlanDefinitionVersionAlgorithm" : "plandefinitionversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// PlanDefinitionSubjectChoice 選擇類型
    /// </summary>
    public class PlanDefinitionSubjectChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public PlanDefinitionSubjectChoice(JsonObject value) : base("plandefinitionsubject", value, _supportType) { }
        public PlanDefinitionSubjectChoice(IComplexType? value) : base("plandefinitionsubject", value) { }
        public PlanDefinitionSubjectChoice(IPrimitiveType? value) : base("plandefinitionsubject", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "PlanDefinitionSubject" : "plandefinitionsubject";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// PlanDefinitionGoalTargetDetailChoice 選擇類型
    /// </summary>
    public class PlanDefinitionGoalTargetDetailChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public PlanDefinitionGoalTargetDetailChoice(JsonObject value) : base("plandefinitiongoaltargetdetail", value, _supportType) { }
        public PlanDefinitionGoalTargetDetailChoice(IComplexType? value) : base("plandefinitiongoaltargetdetail", value) { }
        public PlanDefinitionGoalTargetDetailChoice(IPrimitiveType? value) : base("plandefinitiongoaltargetdetail", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "PlanDefinitionGoalTargetDetail" : "plandefinitiongoaltargetdetail";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// PlanDefinitionActionSubjectChoice 選擇類型
    /// </summary>
    public class PlanDefinitionActionSubjectChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public PlanDefinitionActionSubjectChoice(JsonObject value) : base("plandefinitionactionsubject", value, _supportType) { }
        public PlanDefinitionActionSubjectChoice(IComplexType? value) : base("plandefinitionactionsubject", value) { }
        public PlanDefinitionActionSubjectChoice(IPrimitiveType? value) : base("plandefinitionactionsubject", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "PlanDefinitionActionSubject" : "plandefinitionactionsubject";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// PlanDefinitionActionRelatedActionOffsetChoice 選擇類型
    /// </summary>
    public class PlanDefinitionActionRelatedActionOffsetChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public PlanDefinitionActionRelatedActionOffsetChoice(JsonObject value) : base("plandefinitionactionrelatedactionoffset", value, _supportType) { }
        public PlanDefinitionActionRelatedActionOffsetChoice(IComplexType? value) : base("plandefinitionactionrelatedactionoffset", value) { }
        public PlanDefinitionActionRelatedActionOffsetChoice(IPrimitiveType? value) : base("plandefinitionactionrelatedactionoffset", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "PlanDefinitionActionRelatedActionOffset" : "plandefinitionactionrelatedactionoffset";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// PlanDefinitionActionTimingChoice 選擇類型
    /// </summary>
    public class PlanDefinitionActionTimingChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public PlanDefinitionActionTimingChoice(JsonObject value) : base("plandefinitionactiontiming", value, _supportType) { }
        public PlanDefinitionActionTimingChoice(IComplexType? value) : base("plandefinitionactiontiming", value) { }
        public PlanDefinitionActionTimingChoice(IPrimitiveType? value) : base("plandefinitionactiontiming", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "PlanDefinitionActionTiming" : "plandefinitionactiontiming";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// PlanDefinitionActionDefinitionChoice 選擇類型
    /// </summary>
    public class PlanDefinitionActionDefinitionChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public PlanDefinitionActionDefinitionChoice(JsonObject value) : base("plandefinitionactiondefinition", value, _supportType) { }
        public PlanDefinitionActionDefinitionChoice(IComplexType? value) : base("plandefinitionactiondefinition", value) { }
        public PlanDefinitionActionDefinitionChoice(IPrimitiveType? value) : base("plandefinitionactiondefinition", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "PlanDefinitionActionDefinition" : "plandefinitionactiondefinition";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// PlanDefinitionAsNeededChoice 選擇類型
    /// </summary>
    public class PlanDefinitionAsNeededChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public PlanDefinitionAsNeededChoice(JsonObject value) : base("plandefinitionasneeded", value, _supportType) { }
        public PlanDefinitionAsNeededChoice(IComplexType? value) : base("plandefinitionasneeded", value) { }
        public PlanDefinitionAsNeededChoice(IPrimitiveType? value) : base("plandefinitionasneeded", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "PlanDefinitionAsNeeded" : "plandefinitionasneeded";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
