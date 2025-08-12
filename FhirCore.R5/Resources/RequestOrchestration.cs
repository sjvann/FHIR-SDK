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
    /// FHIR R5 RequestOrchestration 資源
    /// 
    /// <para>
    /// RequestOrchestration 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var requestorchestration = new RequestOrchestration("requestorchestration-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 RequestOrchestration 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class RequestOrchestration : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<FhirCanonical>? _instantiatescanonical;
        private List<FhirUri>? _instantiatesuri;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _replaces;
        private Identifier? _groupidentifier;
        private FhirCode? _status;
        private FhirCode? _intent;
        private FhirCode? _priority;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private FhirDateTime? _authoredon;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;
        private List<CodeableReference>? _reason;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _goal;
        private List<Annotation>? _note;
        private List<RequestOrchestrationAction>? _action;
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
        private RequestOrchestrationActionRelatedActionOffsetChoice? _offset;
        private FhirCode? _type;
        private FhirCanonical? _typecanonical;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _typereference;
        private CodeableConcept? _role;
        private CodeableConcept? _function;
        private RequestOrchestrationActionParticipantActorChoice? _actor;
        private FhirString? _path;
        private ExpressionType? _expression;
        private FhirString? _linkid;
        private FhirString? _prefix;
        private FhirString? _title;
        private FhirMarkdown? _description;
        private FhirMarkdown? _textequivalent;
        private FhirCode? _priority;
        private List<CodeableConcept>? _code;
        private List<RelatedArtifact>? _documentation;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _goal;
        private List<RequestOrchestrationActionCondition>? _condition;
        private List<RequestOrchestrationActionInput>? _input;
        private List<RequestOrchestrationActionOutput>? _output;
        private List<RequestOrchestrationActionRelatedAction>? _relatedaction;
        private RequestOrchestrationActionTimingChoice? _timing;
        private CodeableReference? _location;
        private List<RequestOrchestrationActionParticipant>? _participant;
        private CodeableConcept? _type;
        private FhirCode? _groupingbehavior;
        private FhirCode? _selectionbehavior;
        private FhirCode? _requiredbehavior;
        private FhirCode? _precheckbehavior;
        private FhirCode? _cardinalitybehavior;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _resource;
        private RequestOrchestrationActionDefinitionChoice? _definition;
        private FhirCanonical? _transform;
        private List<RequestOrchestrationActionDynamicValue>? _dynamicvalue;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "RequestOrchestration";        /// <summary>
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
        /// Replaces
        /// </summary>
        /// <remarks>
        /// <para>
        /// Replaces 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Replaces
        {
            get => _replaces;
            set
            {
                _replaces = value;
                OnPropertyChanged(nameof(Replaces));
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
        /// Goal
        /// </summary>
        /// <remarks>
        /// <para>
        /// Goal 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Goal
        {
            get => _goal;
            set
            {
                _goal = value;
                OnPropertyChanged(nameof(Goal));
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
        /// Action
        /// </summary>
        /// <remarks>
        /// <para>
        /// Action 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RequestOrchestrationAction>? Action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(nameof(Action));
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
        public RequestOrchestrationActionRelatedActionOffsetChoice? Offset
        {
            get => _offset;
            set
            {
                _offset = value;
                OnPropertyChanged(nameof(Offset));
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
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public RequestOrchestrationActionParticipantActorChoice? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
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
        public List<CodeableConcept>? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
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
        /// Goal
        /// </summary>
        /// <remarks>
        /// <para>
        /// Goal 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Goal
        {
            get => _goal;
            set
            {
                _goal = value;
                OnPropertyChanged(nameof(Goal));
            }
        }        /// <summary>
        /// Condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Condition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RequestOrchestrationActionCondition>? Condition
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
        public List<RequestOrchestrationActionInput>? Input
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
        public List<RequestOrchestrationActionOutput>? Output
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
        public List<RequestOrchestrationActionRelatedAction>? Relatedaction
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
        public RequestOrchestrationActionTimingChoice? Timing
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
        public List<RequestOrchestrationActionParticipant>? Participant
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
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public RequestOrchestrationActionDefinitionChoice? Definition
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
        public List<RequestOrchestrationActionDynamicValue>? Dynamicvalue
        {
            get => _dynamicvalue;
            set
            {
                _dynamicvalue = value;
                OnPropertyChanged(nameof(Dynamicvalue));
            }
        }        /// <summary>
        /// 建立新的 RequestOrchestration 資源實例
        /// </summary>
        public RequestOrchestration()
        {
        }

        /// <summary>
        /// 建立新的 RequestOrchestration 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public RequestOrchestration(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"RequestOrchestration(Id: {Id})";
        }
    }    /// <summary>
    /// RequestOrchestrationActionCondition 背骨元素
    /// </summary>
    public class RequestOrchestrationActionCondition
    {
        // TODO: 添加屬性實作
        
        public RequestOrchestrationActionCondition() { }
    }    /// <summary>
    /// RequestOrchestrationActionInput 背骨元素
    /// </summary>
    public class RequestOrchestrationActionInput
    {
        // TODO: 添加屬性實作
        
        public RequestOrchestrationActionInput() { }
    }    /// <summary>
    /// RequestOrchestrationActionOutput 背骨元素
    /// </summary>
    public class RequestOrchestrationActionOutput
    {
        // TODO: 添加屬性實作
        
        public RequestOrchestrationActionOutput() { }
    }    /// <summary>
    /// RequestOrchestrationActionRelatedAction 背骨元素
    /// </summary>
    public class RequestOrchestrationActionRelatedAction
    {
        // TODO: 添加屬性實作
        
        public RequestOrchestrationActionRelatedAction() { }
    }    /// <summary>
    /// RequestOrchestrationActionParticipant 背骨元素
    /// </summary>
    public class RequestOrchestrationActionParticipant
    {
        // TODO: 添加屬性實作
        
        public RequestOrchestrationActionParticipant() { }
    }    /// <summary>
    /// RequestOrchestrationActionDynamicValue 背骨元素
    /// </summary>
    public class RequestOrchestrationActionDynamicValue
    {
        // TODO: 添加屬性實作
        
        public RequestOrchestrationActionDynamicValue() { }
    }    /// <summary>
    /// RequestOrchestrationAction 背骨元素
    /// </summary>
    public class RequestOrchestrationAction
    {
        // TODO: 添加屬性實作
        
        public RequestOrchestrationAction() { }
    }    /// <summary>
    /// RequestOrchestrationActionRelatedActionOffsetChoice 選擇類型
    /// </summary>
    public class RequestOrchestrationActionRelatedActionOffsetChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public RequestOrchestrationActionRelatedActionOffsetChoice(JsonObject value) : base("requestorchestrationactionrelatedactionoffset", value, _supportType) { }
        public RequestOrchestrationActionRelatedActionOffsetChoice(IComplexType? value) : base("requestorchestrationactionrelatedactionoffset", value) { }
        public RequestOrchestrationActionRelatedActionOffsetChoice(IPrimitiveType? value) : base("requestorchestrationactionrelatedactionoffset", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "RequestOrchestrationActionRelatedActionOffset" : "requestorchestrationactionrelatedactionoffset";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// RequestOrchestrationActionTimingChoice 選擇類型
    /// </summary>
    public class RequestOrchestrationActionTimingChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public RequestOrchestrationActionTimingChoice(JsonObject value) : base("requestorchestrationactiontiming", value, _supportType) { }
        public RequestOrchestrationActionTimingChoice(IComplexType? value) : base("requestorchestrationactiontiming", value) { }
        public RequestOrchestrationActionTimingChoice(IPrimitiveType? value) : base("requestorchestrationactiontiming", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "RequestOrchestrationActionTiming" : "requestorchestrationactiontiming";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// RequestOrchestrationActionParticipantActorChoice 選擇類型
    /// </summary>
    public class RequestOrchestrationActionParticipantActorChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public RequestOrchestrationActionParticipantActorChoice(JsonObject value) : base("requestorchestrationactionparticipantactor", value, _supportType) { }
        public RequestOrchestrationActionParticipantActorChoice(IComplexType? value) : base("requestorchestrationactionparticipantactor", value) { }
        public RequestOrchestrationActionParticipantActorChoice(IPrimitiveType? value) : base("requestorchestrationactionparticipantactor", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "RequestOrchestrationActionParticipantActor" : "requestorchestrationactionparticipantactor";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// RequestOrchestrationActionDefinitionChoice 選擇類型
    /// </summary>
    public class RequestOrchestrationActionDefinitionChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public RequestOrchestrationActionDefinitionChoice(JsonObject value) : base("requestorchestrationactiondefinition", value, _supportType) { }
        public RequestOrchestrationActionDefinitionChoice(IComplexType? value) : base("requestorchestrationactiondefinition", value) { }
        public RequestOrchestrationActionDefinitionChoice(IPrimitiveType? value) : base("requestorchestrationactiondefinition", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "RequestOrchestrationActionDefinition" : "requestorchestrationactiondefinition";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
