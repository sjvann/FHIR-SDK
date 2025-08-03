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
    public class RequestOrchestration : ResourceType<RequestOrchestration>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<FhirCanonical>? _instantiatesCanonical;
private List<FhirUri>? _instantiatesUri;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _replaces;
private Identifier? _groupIdentifier;
private FhirCode? _status;
private FhirCode? _intent;
private FhirCode? _priority;
private CodeableConcept? _code;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private FhirDateTime? _authoredOn;
private ReferenceType? _author;
private List<CodeableReference>? _reason;
private List<ReferenceType>? _goal;
private List<Annotation>? _note;
private List<RequestOrchestrationAction>? _action;

		#endregion
		#region Public Method
		public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public List<FhirCanonical>? InstantiatesCanonical
{
get { return _instantiatesCanonical; }
set {
_instantiatesCanonical= value;
OnPropertyChanged("instantiatesCanonical", value);
}
}

public List<FhirUri>? InstantiatesUri
{
get { return _instantiatesUri; }
set {
_instantiatesUri= value;
OnPropertyChanged("instantiatesUri", value);
}
}

public List<ReferenceType>? BasedOn
{
get { return _basedOn; }
set {
_basedOn= value;
OnPropertyChanged("basedOn", value);
}
}

public List<ReferenceType>? Replaces
{
get { return _replaces; }
set {
_replaces= value;
OnPropertyChanged("replaces", value);
}
}

public Identifier? GroupIdentifier
{
get { return _groupIdentifier; }
set {
_groupIdentifier= value;
OnPropertyChanged("groupIdentifier", value);
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

public FhirCode? Intent
{
get { return _intent; }
set {
_intent= value;
OnPropertyChanged("intent", value);
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

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public ReferenceType? Encounter
{
get { return _encounter; }
set {
_encounter= value;
OnPropertyChanged("encounter", value);
}
}

public FhirDateTime? AuthoredOn
{
get { return _authoredOn; }
set {
_authoredOn= value;
OnPropertyChanged("authoredOn", value);
}
}

public ReferenceType? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}

public List<CodeableReference>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public List<ReferenceType>? Goal
{
get { return _goal; }
set {
_goal= value;
OnPropertyChanged("goal", value);
}
}

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
}
}

public List<RequestOrchestrationAction>? Action
{
get { return _action; }
set {
_action= value;
OnPropertyChanged("action", value);
}
}


		#endregion
		#region Constructor
		public  RequestOrchestration() { }
		public  RequestOrchestration(string value) : base(value) { }
		public  RequestOrchestration(JsonNode? source) : base(source) { }
		#endregion
	}
		public class RequestOrchestrationActionCondition : BackboneElementType<RequestOrchestrationActionCondition>, IBackboneElementType
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
		public  RequestOrchestrationActionCondition() { }
		public  RequestOrchestrationActionCondition(string value) : base(value) { }
		public  RequestOrchestrationActionCondition(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class RequestOrchestrationActionInput : BackboneElementType<RequestOrchestrationActionInput>, IBackboneElementType
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
		public  RequestOrchestrationActionInput() { }
		public  RequestOrchestrationActionInput(string value) : base(value) { }
		public  RequestOrchestrationActionInput(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class RequestOrchestrationActionOutput : BackboneElementType<RequestOrchestrationActionOutput>, IBackboneElementType
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
		public  RequestOrchestrationActionOutput() { }
		public  RequestOrchestrationActionOutput(string value) : base(value) { }
		public  RequestOrchestrationActionOutput(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class RequestOrchestrationActionRelatedAction : BackboneElementType<RequestOrchestrationActionRelatedAction>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _targetId;
private FhirCode? _relationship;
private FhirCode? _endRelationship;
private RequestOrchestrationActionRelatedActionOffsetChoice? _offset;

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

public RequestOrchestrationActionRelatedActionOffsetChoice? Offset
{
get { return _offset; }
set {
_offset= value;
OnPropertyChanged("offset", value);
}
}


		#endregion
		#region Constructor
		public  RequestOrchestrationActionRelatedAction() { }
		public  RequestOrchestrationActionRelatedAction(string value) : base(value) { }
		public  RequestOrchestrationActionRelatedAction(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class RequestOrchestrationActionParticipant : BackboneElementType<RequestOrchestrationActionParticipant>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _type;
private FhirCanonical? _typeCanonical;
private ReferenceType? _typeReference;
private CodeableConcept? _role;
private CodeableConcept? _function;
private RequestOrchestrationActionParticipantActorChoice? _actor;

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

public CodeableConcept? Function
{
get { return _function; }
set {
_function= value;
OnPropertyChanged("function", value);
}
}

public RequestOrchestrationActionParticipantActorChoice? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}


		#endregion
		#region Constructor
		public  RequestOrchestrationActionParticipant() { }
		public  RequestOrchestrationActionParticipant(string value) : base(value) { }
		public  RequestOrchestrationActionParticipant(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class RequestOrchestrationActionDynamicValue : BackboneElementType<RequestOrchestrationActionDynamicValue>, IBackboneElementType
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
		public  RequestOrchestrationActionDynamicValue() { }
		public  RequestOrchestrationActionDynamicValue(string value) : base(value) { }
		public  RequestOrchestrationActionDynamicValue(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class RequestOrchestrationAction : BackboneElementType<RequestOrchestrationAction>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private FhirString? _prefix;
private FhirString? _title;
private FhirMarkdown? _description;
private FhirMarkdown? _textEquivalent;
private FhirCode? _priority;
private List<CodeableConcept>? _code;
private List<RelatedArtifact>? _documentation;
private List<ReferenceType>? _goal;
private List<RequestOrchestrationActionCondition>? _condition;
private List<RequestOrchestrationActionInput>? _input;
private List<RequestOrchestrationActionOutput>? _output;
private List<RequestOrchestrationActionRelatedAction>? _relatedAction;
private RequestOrchestrationActionTimingChoice? _timing;
private CodeableReference? _location;
private List<RequestOrchestrationActionParticipant>? _participant;
private CodeableConcept? _type;
private FhirCode? _groupingBehavior;
private FhirCode? _selectionBehavior;
private FhirCode? _requiredBehavior;
private FhirCode? _precheckBehavior;
private FhirCode? _cardinalityBehavior;
private ReferenceType? _resource;
private RequestOrchestrationActionDefinitionChoice? _definition;
private FhirCanonical? _transform;
private List<RequestOrchestrationActionDynamicValue>? _dynamicValue;

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

public List<CodeableConcept>? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
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

public List<ReferenceType>? Goal
{
get { return _goal; }
set {
_goal= value;
OnPropertyChanged("goal", value);
}
}

public List<RequestOrchestrationActionCondition>? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
}
}

public List<RequestOrchestrationActionInput>? Input
{
get { return _input; }
set {
_input= value;
OnPropertyChanged("input", value);
}
}

public List<RequestOrchestrationActionOutput>? Output
{
get { return _output; }
set {
_output= value;
OnPropertyChanged("output", value);
}
}

public List<RequestOrchestrationActionRelatedAction>? RelatedAction
{
get { return _relatedAction; }
set {
_relatedAction= value;
OnPropertyChanged("relatedAction", value);
}
}

public RequestOrchestrationActionTimingChoice? Timing
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

public List<RequestOrchestrationActionParticipant>? Participant
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

public ReferenceType? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
}
}

public RequestOrchestrationActionDefinitionChoice? Definition
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

public List<RequestOrchestrationActionDynamicValue>? DynamicValue
{
get { return _dynamicValue; }
set {
_dynamicValue= value;
OnPropertyChanged("dynamicValue", value);
}
}


		#endregion
		#region Constructor
		public  RequestOrchestrationAction() { }
		public  RequestOrchestrationAction(string value) : base(value) { }
		public  RequestOrchestrationAction(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class RequestOrchestrationActionRelatedActionOffsetChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Duration","Range"
        ];

        public RequestOrchestrationActionRelatedActionOffsetChoice(JsonObject value) : base("offset", value, _supportType)
        {
        }
        public RequestOrchestrationActionRelatedActionOffsetChoice(IComplexType? value) : base("offset", value)
        {
        }
        public RequestOrchestrationActionRelatedActionOffsetChoice(IPrimitiveType? value) : base("offset", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"offset".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class RequestOrchestrationActionTimingChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","AgePeriodDurationRangeTiming"
        ];

        public RequestOrchestrationActionTimingChoice(JsonObject value) : base("timing", value, _supportType)
        {
        }
        public RequestOrchestrationActionTimingChoice(IComplexType? value) : base("timing", value)
        {
        }
        public RequestOrchestrationActionTimingChoice(IPrimitiveType? value) : base("timing", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"timing".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class RequestOrchestrationActionParticipantActorChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "canonical(CapabilityStatement)","Reference(CareTeam|Device|DeviceDefinition|Endpoint|Group|HealthcareService|Location|Organization|Patient|Practitioner|PractitionerRole|RelatedPerson)"
        ];

        public RequestOrchestrationActionParticipantActorChoice(JsonObject value) : base("actor", value, _supportType)
        {
        }
        public RequestOrchestrationActionParticipantActorChoice(IComplexType? value) : base("actor", value)
        {
        }
        public RequestOrchestrationActionParticipantActorChoice(IPrimitiveType? value) : base("actor", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"actor".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class RequestOrchestrationActionDefinitionChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "canonical(ActivityDefinition|ObservationDefinition|PlanDefinition|Questionnaire|SpecimenDefinition)","uri"
        ];

        public RequestOrchestrationActionDefinitionChoice(JsonObject value) : base("definition", value, _supportType)
        {
        }
        public RequestOrchestrationActionDefinitionChoice(IComplexType? value) : base("definition", value)
        {
        }
        public RequestOrchestrationActionDefinitionChoice(IPrimitiveType? value) : base("definition", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"definition".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
