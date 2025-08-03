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
    public class ExampleScenario : ResourceType<ExampleScenario>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private ExampleScenarioVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private FhirCode? _status;
private FhirBoolean? _experimental;
private FhirDateTime? _date;
private FhirString? _publisher;
private List<ContactDetail>? _contact;
private FhirMarkdown? _description;
private List<UsageContext>? _useContext;
private List<CodeableConcept>? _jurisdiction;
private FhirMarkdown? _purpose;
private FhirMarkdown? _copyright;
private FhirString? _copyrightLabel;
private List<ExampleScenarioActor>? _actor;
private List<ExampleScenarioInstance>? _instance;
private List<ExampleScenarioProcess>? _process;

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

public ExampleScenarioVersionAlgorithmChoice? VersionAlgorithm
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

public List<ExampleScenarioActor>? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}

public List<ExampleScenarioInstance>? Instance
{
get { return _instance; }
set {
_instance= value;
OnPropertyChanged("instance", value);
}
}

public List<ExampleScenarioProcess>? Process
{
get { return _process; }
set {
_process= value;
OnPropertyChanged("process", value);
}
}


		#endregion
		#region Constructor
		public  ExampleScenario() { }
		public  ExampleScenario(string value) : base(value) { }
		public  ExampleScenario(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ExampleScenarioActor : BackboneElementType<ExampleScenarioActor>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _key;
private FhirCode? _type;
private FhirString? _title;
private FhirMarkdown? _description;

		#endregion
		#region public Method
		public FhirString? Key
{
get { return _key; }
set {
_key= value;
OnPropertyChanged("key", value);
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


		#endregion
		#region Constructor
		public  ExampleScenarioActor() { }
		public  ExampleScenarioActor(string value) : base(value) { }
		public  ExampleScenarioActor(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExampleScenarioInstanceVersion : BackboneElementType<ExampleScenarioInstanceVersion>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _key;
private FhirString? _title;
private FhirMarkdown? _description;
private ReferenceType? _content;

		#endregion
		#region public Method
		public FhirString? Key
{
get { return _key; }
set {
_key= value;
OnPropertyChanged("key", value);
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

public ReferenceType? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}


		#endregion
		#region Constructor
		public  ExampleScenarioInstanceVersion() { }
		public  ExampleScenarioInstanceVersion(string value) : base(value) { }
		public  ExampleScenarioInstanceVersion(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExampleScenarioInstanceContainedInstance : BackboneElementType<ExampleScenarioInstanceContainedInstance>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _instanceReference;
private FhirString? _versionReference;

		#endregion
		#region public Method
		public FhirString? InstanceReference
{
get { return _instanceReference; }
set {
_instanceReference= value;
OnPropertyChanged("instanceReference", value);
}
}

public FhirString? VersionReference
{
get { return _versionReference; }
set {
_versionReference= value;
OnPropertyChanged("versionReference", value);
}
}


		#endregion
		#region Constructor
		public  ExampleScenarioInstanceContainedInstance() { }
		public  ExampleScenarioInstanceContainedInstance(string value) : base(value) { }
		public  ExampleScenarioInstanceContainedInstance(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExampleScenarioInstance : BackboneElementType<ExampleScenarioInstance>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _key;
private Coding? _structureType;
private FhirString? _structureVersion;
private ExampleScenarioInstanceStructureProfileChoice? _structureProfile;
private FhirString? _title;
private FhirMarkdown? _description;
private ReferenceType? _content;
private List<ExampleScenarioInstanceVersion>? _version;
private List<ExampleScenarioInstanceContainedInstance>? _containedInstance;

		#endregion
		#region public Method
		public FhirString? Key
{
get { return _key; }
set {
_key= value;
OnPropertyChanged("key", value);
}
}

public Coding? StructureType
{
get { return _structureType; }
set {
_structureType= value;
OnPropertyChanged("structureType", value);
}
}

public FhirString? StructureVersion
{
get { return _structureVersion; }
set {
_structureVersion= value;
OnPropertyChanged("structureVersion", value);
}
}

public ExampleScenarioInstanceStructureProfileChoice? StructureProfile
{
get { return _structureProfile; }
set {
_structureProfile= value;
OnPropertyChanged("structureProfile", value);
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

public ReferenceType? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}

public List<ExampleScenarioInstanceVersion>? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}

public List<ExampleScenarioInstanceContainedInstance>? ContainedInstance
{
get { return _containedInstance; }
set {
_containedInstance= value;
OnPropertyChanged("containedInstance", value);
}
}


		#endregion
		#region Constructor
		public  ExampleScenarioInstance() { }
		public  ExampleScenarioInstance(string value) : base(value) { }
		public  ExampleScenarioInstance(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExampleScenarioProcessStepOperation : BackboneElementType<ExampleScenarioProcessStepOperation>, IBackboneElementType
	{

		#region Private Method
		private Coding? _type;
private FhirString? _title;
private FhirString? _initiator;
private FhirString? _receiver;
private FhirMarkdown? _description;
private FhirBoolean? _initiatorActive;
private FhirBoolean? _receiverActive;

		#endregion
		#region public Method
		public Coding? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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

public FhirString? Initiator
{
get { return _initiator; }
set {
_initiator= value;
OnPropertyChanged("initiator", value);
}
}

public FhirString? Receiver
{
get { return _receiver; }
set {
_receiver= value;
OnPropertyChanged("receiver", value);
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

public FhirBoolean? InitiatorActive
{
get { return _initiatorActive; }
set {
_initiatorActive= value;
OnPropertyChanged("initiatorActive", value);
}
}

public FhirBoolean? ReceiverActive
{
get { return _receiverActive; }
set {
_receiverActive= value;
OnPropertyChanged("receiverActive", value);
}
}


		#endregion
		#region Constructor
		public  ExampleScenarioProcessStepOperation() { }
		public  ExampleScenarioProcessStepOperation(string value) : base(value) { }
		public  ExampleScenarioProcessStepOperation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExampleScenarioProcessStepAlternative : BackboneElementType<ExampleScenarioProcessStepAlternative>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _title;
private FhirMarkdown? _description;

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


		#endregion
		#region Constructor
		public  ExampleScenarioProcessStepAlternative() { }
		public  ExampleScenarioProcessStepAlternative(string value) : base(value) { }
		public  ExampleScenarioProcessStepAlternative(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExampleScenarioProcessStep : BackboneElementType<ExampleScenarioProcessStep>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _number;
private FhirCanonical? _workflow;
private ExampleScenarioProcessStepOperation? _operation;
private List<ExampleScenarioProcessStepAlternative>? _alternative;
private FhirBoolean? _pause;

		#endregion
		#region public Method
		public FhirString? Number
{
get { return _number; }
set {
_number= value;
OnPropertyChanged("number", value);
}
}

public FhirCanonical? Workflow
{
get { return _workflow; }
set {
_workflow= value;
OnPropertyChanged("workflow", value);
}
}

public ExampleScenarioProcessStepOperation? Operation
{
get { return _operation; }
set {
_operation= value;
OnPropertyChanged("operation", value);
}
}

public List<ExampleScenarioProcessStepAlternative>? Alternative
{
get { return _alternative; }
set {
_alternative= value;
OnPropertyChanged("alternative", value);
}
}

public FhirBoolean? Pause
{
get { return _pause; }
set {
_pause= value;
OnPropertyChanged("pause", value);
}
}


		#endregion
		#region Constructor
		public  ExampleScenarioProcessStep() { }
		public  ExampleScenarioProcessStep(string value) : base(value) { }
		public  ExampleScenarioProcessStep(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExampleScenarioProcess : BackboneElementType<ExampleScenarioProcess>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _title;
private FhirMarkdown? _description;
private FhirMarkdown? _preConditions;
private FhirMarkdown? _postConditions;
private List<ExampleScenarioProcessStep>? _step;

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

public FhirMarkdown? PreConditions
{
get { return _preConditions; }
set {
_preConditions= value;
OnPropertyChanged("preConditions", value);
}
}

public FhirMarkdown? PostConditions
{
get { return _postConditions; }
set {
_postConditions= value;
OnPropertyChanged("postConditions", value);
}
}

public List<ExampleScenarioProcessStep>? Step
{
get { return _step; }
set {
_step= value;
OnPropertyChanged("step", value);
}
}


		#endregion
		#region Constructor
		public  ExampleScenarioProcess() { }
		public  ExampleScenarioProcess(string value) : base(value) { }
		public  ExampleScenarioProcess(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ExampleScenarioVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public ExampleScenarioVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public ExampleScenarioVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public ExampleScenarioVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ExampleScenarioInstanceStructureProfileChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "canonical","uri"
        ];

        public ExampleScenarioInstanceStructureProfileChoice(JsonObject value) : base("structureProfile", value, _supportType)
        {
        }
        public ExampleScenarioInstanceStructureProfileChoice(IComplexType? value) : base("structureProfile", value)
        {
        }
        public ExampleScenarioInstanceStructureProfileChoice(IPrimitiveType? value) : base("structureProfile", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"structureProfile".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
