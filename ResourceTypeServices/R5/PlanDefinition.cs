using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;

namespace ResourceTypeServices.R5
{
    public class PlanDefinition : ResourceType<PlanDefinition>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private PlanDefinitionVersionAlgorithmChoice? _versionAlgorithm;
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
private List<UsageContext>? _useContext;
private List<CodeableConcept>? _jurisdiction;
private FhirMarkdown? _purpose;
private FhirMarkdown? _usage;
private FhirMarkdown? _copyright;
private FhirString? _copyrightLabel;
private FhirDate? _approvalDate;
private FhirDate? _lastReviewDate;
private Period? _effectivePeriod;
private List<CodeableConcept>? _topic;
private List<ContactDetail>? _author;
private List<ContactDetail>? _editor;
private List<ContactDetail>? _reviewer;
private List<ContactDetail>? _endorser;
private List<RelatedArtifact>? _relatedArtifact;
private List<FhirCanonical>? _library;
private List<PlanDefinitionGoal>? _goal;
private List<PlanDefinitionActor>? _actor;
private List<PlanDefinitionAction>? _action;
private PlanDefinitionAsNeededChoice? _asNeeded;

		#endregion
		#region Public Method
		public FhirUri? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
}
}

public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirString? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}

public PlanDefinitionVersionAlgorithmChoice? VersionAlgorithm
{
get { return _versionAlgorithm; }
set {
_versionAlgorithm= value;
OnPropertyChanged("versionAlgorithm", value);
}
}

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public FhirString? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
}
}

public FhirString? Subtitle
{
get { return _subtitle; }
set {
_subtitle= value;
OnPropertyChanged("subtitle", value);
}
}

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public FhirBoolean? Experimental
{
get { return _experimental; }
set {
_experimental= value;
OnPropertyChanged("experimental", value);
}
}

public PlanDefinitionSubjectChoice? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public FhirDateTime? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
}
}

public FhirString? Publisher
{
get { return _publisher; }
set {
_publisher= value;
OnPropertyChanged("publisher", value);
}
}

public List<ContactDetail>? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
}
}

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public List<UsageContext>? UseContext
{
get { return _useContext; }
set {
_useContext= value;
OnPropertyChanged("useContext", value);
}
}

public List<CodeableConcept>? Jurisdiction
{
get { return _jurisdiction; }
set {
_jurisdiction= value;
OnPropertyChanged("jurisdiction", value);
}
}

public FhirMarkdown? Purpose
{
get { return _purpose; }
set {
_purpose= value;
OnPropertyChanged("purpose", value);
}
}

public FhirMarkdown? Usage
{
get { return _usage; }
set {
_usage= value;
OnPropertyChanged("usage", value);
}
}

public FhirMarkdown? Copyright
{
get { return _copyright; }
set {
_copyright= value;
OnPropertyChanged("copyright", value);
}
}

public FhirString? CopyrightLabel
{
get { return _copyrightLabel; }
set {
_copyrightLabel= value;
OnPropertyChanged("copyrightLabel", value);
}
}

public FhirDate? ApprovalDate
{
get { return _approvalDate; }
set {
_approvalDate= value;
OnPropertyChanged("approvalDate", value);
}
}

public FhirDate? LastReviewDate
{
get { return _lastReviewDate; }
set {
_lastReviewDate= value;
OnPropertyChanged("lastReviewDate", value);
}
}

public Period? EffectivePeriod
{
get { return _effectivePeriod; }
set {
_effectivePeriod= value;
OnPropertyChanged("effectivePeriod", value);
}
}

public List<CodeableConcept>? Topic
{
get { return _topic; }
set {
_topic= value;
OnPropertyChanged("topic", value);
}
}

public List<ContactDetail>? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}

public List<ContactDetail>? Editor
{
get { return _editor; }
set {
_editor= value;
OnPropertyChanged("editor", value);
}
}

public List<ContactDetail>? Reviewer
{
get { return _reviewer; }
set {
_reviewer= value;
OnPropertyChanged("reviewer", value);
}
}

public List<ContactDetail>? Endorser
{
get { return _endorser; }
set {
_endorser= value;
OnPropertyChanged("endorser", value);
}
}

public List<RelatedArtifact>? RelatedArtifact
{
get { return _relatedArtifact; }
set {
_relatedArtifact= value;
OnPropertyChanged("relatedArtifact", value);
}
}

public List<FhirCanonical>? Library
{
get { return _library; }
set {
_library= value;
OnPropertyChanged("library", value);
}
}

public List<PlanDefinitionGoal>? Goal
{
get { return _goal; }
set {
_goal= value;
OnPropertyChanged("goal", value);
}
}

public List<PlanDefinitionActor>? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}

public List<PlanDefinitionAction>? Action
{
get { return _action; }
set {
_action= value;
OnPropertyChanged("action", value);
}
}

public PlanDefinitionAsNeededChoice? AsNeeded
{
get { return _asNeeded; }
set {
_asNeeded= value;
OnPropertyChanged("asNeeded", value);
}
}


		#endregion
		#region Constructor
		public  PlanDefinition() { }
		public  PlanDefinition(string value) : base(value) { }
		public  PlanDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class PlanDefinitionGoalTarget : BackboneElementType<PlanDefinitionGoalTarget>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _measure;
private PlanDefinitionGoalTargetDetailChoice? _detail;
private Duration? _due;

		#endregion
		#region public Method
		public CodeableConcept? Measure
{
get { return _measure; }
set {
_measure= value;
OnPropertyChanged("measure", value);
}
}

public PlanDefinitionGoalTargetDetailChoice? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}

public Duration? Due
{
get { return _due; }
set {
_due= value;
OnPropertyChanged("due", value);
}
}


		#endregion
		#region Constructor
		public  PlanDefinitionGoalTarget() { }
		public  PlanDefinitionGoalTarget(string value) : base(value) { }
		public  PlanDefinitionGoalTarget(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PlanDefinitionGoal : BackboneElementType<PlanDefinitionGoal>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _category;
private CodeableConcept? _description;
private CodeableConcept? _priority;
private CodeableConcept? _start;
private List<CodeableConcept>? _addresses;
private List<RelatedArtifact>? _documentation;
private List<PlanDefinitionGoalTarget>? _target;

		#endregion
		#region public Method
		public CodeableConcept? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public CodeableConcept? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public CodeableConcept? Priority
{
get { return _priority; }
set {
_priority= value;
OnPropertyChanged("priority", value);
}
}

public CodeableConcept? Start
{
get { return _start; }
set {
_start= value;
OnPropertyChanged("start", value);
}
}

public List<CodeableConcept>? Addresses
{
get { return _addresses; }
set {
_addresses= value;
OnPropertyChanged("addresses", value);
}
}

public List<RelatedArtifact>? Documentation
{
get { return _documentation; }
set {
_documentation= value;
OnPropertyChanged("documentation", value);
}
}

public List<PlanDefinitionGoalTarget>? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
}
}


		#endregion
		#region Constructor
		public  PlanDefinitionGoal() { }
		public  PlanDefinitionGoal(string value) : base(value) { }
		public  PlanDefinitionGoal(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PlanDefinitionActorOption : BackboneElementType<PlanDefinitionActorOption>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _type;
private FhirCanonical? _typeCanonical;
private ReferenceType? _typeReference;
private CodeableConcept? _role;

		#endregion
		#region public Method
		public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirCanonical? TypeCanonical
{
get { return _typeCanonical; }
set {
_typeCanonical= value;
OnPropertyChanged("typeCanonical", value);
}
}

public ReferenceType? TypeReference
{
get { return _typeReference; }
set {
_typeReference= value;
OnPropertyChanged("typeReference", value);
}
}

public CodeableConcept? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}


		#endregion
		#region Constructor
		public  PlanDefinitionActorOption() { }
		public  PlanDefinitionActorOption(string value) : base(value) { }
		public  PlanDefinitionActorOption(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PlanDefinitionActor : BackboneElementType<PlanDefinitionActor>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _title;
private FhirMarkdown? _description;
private List<PlanDefinitionActorOption>? _option;

		#endregion
		#region public Method
		public FhirString? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
}
}

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public List<PlanDefinitionActorOption>? Option
{
get { return _option; }
set {
_option= value;
OnPropertyChanged("option", value);
}
}


		#endregion
		#region Constructor
		public  PlanDefinitionActor() { }
		public  PlanDefinitionActor(string value) : base(value) { }
		public  PlanDefinitionActor(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PlanDefinitionActionCondition : BackboneElementType<PlanDefinitionActionCondition>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _kind;
private ExpressionType? _expression;

		#endregion
		#region public Method
		public FhirCode? Kind
{
get { return _kind; }
set {
_kind= value;
OnPropertyChanged("kind", value);
}
}

public ExpressionType? Expression
{
get { return _expression; }
set {
_expression= value;
OnPropertyChanged("expression", value);
}
}


		#endregion
		#region Constructor
		public  PlanDefinitionActionCondition() { }
		public  PlanDefinitionActionCondition(string value) : base(value) { }
		public  PlanDefinitionActionCondition(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PlanDefinitionActionInput : BackboneElementType<PlanDefinitionActionInput>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _title;
private DataRequirement? _requirement;
private FhirId? _relatedData;

		#endregion
		#region public Method
		public FhirString? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
}
}

public DataRequirement? Requirement
{
get { return _requirement; }
set {
_requirement= value;
OnPropertyChanged("requirement", value);
}
}

public FhirId? RelatedData
{
get { return _relatedData; }
set {
_relatedData= value;
OnPropertyChanged("relatedData", value);
}
}


		#endregion
		#region Constructor
		public  PlanDefinitionActionInput() { }
		public  PlanDefinitionActionInput(string value) : base(value) { }
		public  PlanDefinitionActionInput(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PlanDefinitionActionOutput : BackboneElementType<PlanDefinitionActionOutput>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _title;
private DataRequirement? _requirement;
private FhirString? _relatedData;

		#endregion
		#region public Method
		public FhirString? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
}
}

public DataRequirement? Requirement
{
get { return _requirement; }
set {
_requirement= value;
OnPropertyChanged("requirement", value);
}
}

public FhirString? RelatedData
{
get { return _relatedData; }
set {
_relatedData= value;
OnPropertyChanged("relatedData", value);
}
}


		#endregion
		#region Constructor
		public  PlanDefinitionActionOutput() { }
		public  PlanDefinitionActionOutput(string value) : base(value) { }
		public  PlanDefinitionActionOutput(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PlanDefinitionActionRelatedAction : BackboneElementType<PlanDefinitionActionRelatedAction>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _targetId;
private FhirCode? _relationship;
private FhirCode? _endRelationship;
private PlanDefinitionActionRelatedActionOffsetChoice? _offset;

		#endregion
		#region public Method
		public FhirId? TargetId
{
get { return _targetId; }
set {
_targetId= value;
OnPropertyChanged("targetId", value);
}
}

public FhirCode? Relationship
{
get { return _relationship; }
set {
_relationship= value;
OnPropertyChanged("relationship", value);
}
}

public FhirCode? EndRelationship
{
get { return _endRelationship; }
set {
_endRelationship= value;
OnPropertyChanged("endRelationship", value);
}
}

public PlanDefinitionActionRelatedActionOffsetChoice? Offset
{
get { return _offset; }
set {
_offset= value;
OnPropertyChanged("offset", value);
}
}


		#endregion
		#region Constructor
		public  PlanDefinitionActionRelatedAction() { }
		public  PlanDefinitionActionRelatedAction(string value) : base(value) { }
		public  PlanDefinitionActionRelatedAction(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PlanDefinitionActionParticipant : BackboneElementType<PlanDefinitionActionParticipant>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _actorId;
private FhirCode? _type;
private FhirCanonical? _typeCanonical;
private ReferenceType? _typeReference;
private CodeableConcept? _role;
private CodeableConcept? _function;

		#endregion
		#region public Method
		public FhirString? ActorId
{
get { return _actorId; }
set {
_actorId= value;
OnPropertyChanged("actorId", value);
}
}

public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirCanonical? TypeCanonical
{
get { return _typeCanonical; }
set {
_typeCanonical= value;
OnPropertyChanged("typeCanonical", value);
}
}

public ReferenceType? TypeReference
{
get { return _typeReference; }
set {
_typeReference= value;
OnPropertyChanged("typeReference", value);
}
}

public CodeableConcept? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}

public CodeableConcept? Function
{
get { return _function; }
set {
_function= value;
OnPropertyChanged("function", value);
}
}


		#endregion
		#region Constructor
		public  PlanDefinitionActionParticipant() { }
		public  PlanDefinitionActionParticipant(string value) : base(value) { }
		public  PlanDefinitionActionParticipant(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PlanDefinitionActionDynamicValue : BackboneElementType<PlanDefinitionActionDynamicValue>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _path;
private ExpressionType? _expression;

		#endregion
		#region public Method
		public FhirString? Path
{
get { return _path; }
set {
_path= value;
OnPropertyChanged("path", value);
}
}

public ExpressionType? Expression
{
get { return _expression; }
set {
_expression= value;
OnPropertyChanged("expression", value);
}
}


		#endregion
		#region Constructor
		public  PlanDefinitionActionDynamicValue() { }
		public  PlanDefinitionActionDynamicValue(string value) : base(value) { }
		public  PlanDefinitionActionDynamicValue(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PlanDefinitionAction : BackboneElementType<PlanDefinitionAction>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private FhirString? _prefix;
private FhirString? _title;
private FhirMarkdown? _description;
private FhirMarkdown? _textEquivalent;
private FhirCode? _priority;
private CodeableConcept? _code;
private List<CodeableConcept>? _reason;
private List<RelatedArtifact>? _documentation;
private List<FhirId>? _goalId;
private PlanDefinitionActionSubjectChoice? _subject;
private List<TriggerDefinition>? _trigger;
private List<PlanDefinitionActionCondition>? _condition;
private List<PlanDefinitionActionInput>? _input;
private List<PlanDefinitionActionOutput>? _output;
private List<PlanDefinitionActionRelatedAction>? _relatedAction;
private PlanDefinitionActionTimingChoice? _timing;
private CodeableReference? _location;
private List<PlanDefinitionActionParticipant>? _participant;
private CodeableConcept? _type;
private FhirCode? _groupingBehavior;
private FhirCode? _selectionBehavior;
private FhirCode? _requiredBehavior;
private FhirCode? _precheckBehavior;
private FhirCode? _cardinalityBehavior;
private PlanDefinitionActionDefinitionChoice? _definition;
private FhirCanonical? _transform;
private List<PlanDefinitionActionDynamicValue>? _dynamicValue;

		#endregion
		#region public Method
		public FhirString? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
}
}

public FhirString? Prefix
{
get { return _prefix; }
set {
_prefix= value;
OnPropertyChanged("prefix", value);
}
}

public FhirString? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
}
}

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public FhirMarkdown? TextEquivalent
{
get { return _textEquivalent; }
set {
_textEquivalent= value;
OnPropertyChanged("textEquivalent", value);
}
}

public FhirCode? Priority
{
get { return _priority; }
set {
_priority= value;
OnPropertyChanged("priority", value);
}
}

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<CodeableConcept>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public List<RelatedArtifact>? Documentation
{
get { return _documentation; }
set {
_documentation= value;
OnPropertyChanged("documentation", value);
}
}

public List<FhirId>? GoalId
{
get { return _goalId; }
set {
_goalId= value;
OnPropertyChanged("goalId", value);
}
}

public PlanDefinitionActionSubjectChoice? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public List<TriggerDefinition>? Trigger
{
get { return _trigger; }
set {
_trigger= value;
OnPropertyChanged("trigger", value);
}
}

public List<PlanDefinitionActionCondition>? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
}
}

public List<PlanDefinitionActionInput>? Input
{
get { return _input; }
set {
_input= value;
OnPropertyChanged("input", value);
}
}

public List<PlanDefinitionActionOutput>? Output
{
get { return _output; }
set {
_output= value;
OnPropertyChanged("output", value);
}
}

public List<PlanDefinitionActionRelatedAction>? RelatedAction
{
get { return _relatedAction; }
set {
_relatedAction= value;
OnPropertyChanged("relatedAction", value);
}
}

public PlanDefinitionActionTimingChoice? Timing
{
get { return _timing; }
set {
_timing= value;
OnPropertyChanged("timing", value);
}
}

public CodeableReference? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public List<PlanDefinitionActionParticipant>? Participant
{
get { return _participant; }
set {
_participant= value;
OnPropertyChanged("participant", value);
}
}

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirCode? GroupingBehavior
{
get { return _groupingBehavior; }
set {
_groupingBehavior= value;
OnPropertyChanged("groupingBehavior", value);
}
}

public FhirCode? SelectionBehavior
{
get { return _selectionBehavior; }
set {
_selectionBehavior= value;
OnPropertyChanged("selectionBehavior", value);
}
}

public FhirCode? RequiredBehavior
{
get { return _requiredBehavior; }
set {
_requiredBehavior= value;
OnPropertyChanged("requiredBehavior", value);
}
}

public FhirCode? PrecheckBehavior
{
get { return _precheckBehavior; }
set {
_precheckBehavior= value;
OnPropertyChanged("precheckBehavior", value);
}
}

public FhirCode? CardinalityBehavior
{
get { return _cardinalityBehavior; }
set {
_cardinalityBehavior= value;
OnPropertyChanged("cardinalityBehavior", value);
}
}

public PlanDefinitionActionDefinitionChoice? Definition
{
get { return _definition; }
set {
_definition= value;
OnPropertyChanged("definition", value);
}
}

public FhirCanonical? Transform
{
get { return _transform; }
set {
_transform= value;
OnPropertyChanged("transform", value);
}
}

public List<PlanDefinitionActionDynamicValue>? DynamicValue
{
get { return _dynamicValue; }
set {
_dynamicValue= value;
OnPropertyChanged("dynamicValue", value);
}
}


		#endregion
		#region Constructor
		public  PlanDefinitionAction() { }
		public  PlanDefinitionAction(string value) : base(value) { }
		public  PlanDefinitionAction(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class PlanDefinitionVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public PlanDefinitionVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public PlanDefinitionVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public PlanDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class PlanDefinitionSubjectChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Group|MedicinalProductDefinition|SubstanceDefinition|AdministrableProductDefinition|ManufacturedItemDefinition|PackagedProductDefinition)canonical(EvidenceVariable)"
        ];

        public PlanDefinitionSubjectChoice(JsonObject value) : base("subject", value, _supportType)
        {
        }
        public PlanDefinitionSubjectChoice(IComplexType? value) : base("subject", value)
        {
        }
        public PlanDefinitionSubjectChoice(IPrimitiveType? value) : base("subject", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"subject".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class PlanDefinitionGoalTargetDetailChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","RangeCodeableConceptstringbooleanintegerRatio"
        ];

        public PlanDefinitionGoalTargetDetailChoice(JsonObject value) : base("detail", value, _supportType)
        {
        }
        public PlanDefinitionGoalTargetDetailChoice(IComplexType? value) : base("detail", value)
        {
        }
        public PlanDefinitionGoalTargetDetailChoice(IPrimitiveType? value) : base("detail", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"detail".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class PlanDefinitionActionSubjectChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Group)canonical"
        ];

        public PlanDefinitionActionSubjectChoice(JsonObject value) : base("subject", value, _supportType)
        {
        }
        public PlanDefinitionActionSubjectChoice(IComplexType? value) : base("subject", value)
        {
        }
        public PlanDefinitionActionSubjectChoice(IPrimitiveType? value) : base("subject", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"subject".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class PlanDefinitionActionRelatedActionOffsetChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Duration","Range"
        ];

        public PlanDefinitionActionRelatedActionOffsetChoice(JsonObject value) : base("offset", value, _supportType)
        {
        }
        public PlanDefinitionActionRelatedActionOffsetChoice(IComplexType? value) : base("offset", value)
        {
        }
        public PlanDefinitionActionRelatedActionOffsetChoice(IPrimitiveType? value) : base("offset", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"offset".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class PlanDefinitionActionTimingChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Age","DurationRangeTiming"
        ];

        public PlanDefinitionActionTimingChoice(JsonObject value) : base("timing", value, _supportType)
        {
        }
        public PlanDefinitionActionTimingChoice(IComplexType? value) : base("timing", value)
        {
        }
        public PlanDefinitionActionTimingChoice(IPrimitiveType? value) : base("timing", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"timing".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class PlanDefinitionActionDefinitionChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "canonical(ActivityDefinition|MessageDefinition|ObservationDefinition|PlanDefinition|Questionnaire|SpecimenDefinition)","uri"
        ];

        public PlanDefinitionActionDefinitionChoice(JsonObject value) : base("definition", value, _supportType)
        {
        }
        public PlanDefinitionActionDefinitionChoice(IComplexType? value) : base("definition", value)
        {
        }
        public PlanDefinitionActionDefinitionChoice(IPrimitiveType? value) : base("definition", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"definition".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class PlanDefinitionAsNeededChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","CodeableConcept"
        ];

        public PlanDefinitionAsNeededChoice(JsonObject value) : base("asNeeded", value, _supportType)
        {
        }
        public PlanDefinitionAsNeededChoice(IComplexType? value) : base("asNeeded", value)
        {
        }
        public PlanDefinitionAsNeededChoice(IPrimitiveType? value) : base("asNeeded", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"asNeeded".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
