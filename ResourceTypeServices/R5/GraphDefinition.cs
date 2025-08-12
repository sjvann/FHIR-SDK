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
    public class GraphDefinition : ResourceType<GraphDefinition>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private GraphDefinitionVersionAlgorithmChoice? _versionAlgorithm;
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
private FhirId? _start;
private List<GraphDefinitionNode>? _node;
private List<GraphDefinitionLink>? _link;

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

public GraphDefinitionVersionAlgorithmChoice? VersionAlgorithm
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

public FhirId? Start
{
get { return _start; }
set {
_start= value;
OnPropertyChanged("start", value);
}
}

public List<GraphDefinitionNode>? Node
{
get { return _node; }
set {
_node= value;
OnPropertyChanged("node", value);
}
}

public List<GraphDefinitionLink>? Link
{
get { return _link; }
set {
_link= value;
OnPropertyChanged("link", value);
}
}


		#endregion
		#region Constructor
		public  GraphDefinition() { }
		public  GraphDefinition(string value) : base(value) { }
		public  GraphDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class GraphDefinitionNode : BackboneElementType<GraphDefinitionNode>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _nodeId;
private FhirString? _description;
private FhirCode? _type;
private FhirCanonical? _profile;

		#endregion
		#region public Method
		public FhirId? NodeId
{
get { return _nodeId; }
set {
_nodeId= value;
OnPropertyChanged("nodeId", value);
}
}

public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
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

public FhirCanonical? Profile
{
get { return _profile; }
set {
_profile= value;
OnPropertyChanged("profile", value);
}
}


		#endregion
		#region Constructor
		public  GraphDefinitionNode() { }
		public  GraphDefinitionNode(string value) : base(value) { }
		public  GraphDefinitionNode(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class GraphDefinitionLinkCompartment : BackboneElementType<GraphDefinitionLinkCompartment>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _use;
private FhirCode? _rule;
private FhirCode? _code;
private FhirString? _expression;
private FhirString? _description;

		#endregion
		#region public Method
		public FhirCode? Use
{
get { return _use; }
set {
_use= value;
OnPropertyChanged("use", value);
}
}

public FhirCode? Rule
{
get { return _rule; }
set {
_rule= value;
OnPropertyChanged("rule", value);
}
}

public FhirCode? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public FhirString? Expression
{
get { return _expression; }
set {
_expression= value;
OnPropertyChanged("expression", value);
}
}

public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}


		#endregion
		#region Constructor
		public  GraphDefinitionLinkCompartment() { }
		public  GraphDefinitionLinkCompartment(string value) : base(value) { }
		public  GraphDefinitionLinkCompartment(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class GraphDefinitionLink : BackboneElementType<GraphDefinitionLink>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _description;
private FhirInteger? _min;
private FhirString? _max;
private FhirId? _sourceId;
private FhirString? _path;
private FhirString? _sliceName;
private FhirId? _targetId;
private FhirString? _params;
private List<GraphDefinitionLinkCompartment>? _compartment;

		#endregion
		#region public Method
		public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public FhirInteger? Min
{
get { return _min; }
set {
_min= value;
OnPropertyChanged("min", value);
}
}

public FhirString? Max
{
get { return _max; }
set {
_max= value;
OnPropertyChanged("max", value);
}
}

public FhirId? SourceId
{
get { return _sourceId; }
set {
_sourceId= value;
OnPropertyChanged("sourceId", value);
}
}

public FhirString? Path
{
get { return _path; }
set {
_path= value;
OnPropertyChanged("path", value);
}
}

public FhirString? SliceName
{
get { return _sliceName; }
set {
_sliceName= value;
OnPropertyChanged("sliceName", value);
}
}

public FhirId? TargetId
{
get { return _targetId; }
set {
_targetId= value;
OnPropertyChanged("targetId", value);
}
}

public FhirString? Params
{
get { return _params; }
set {
_params= value;
OnPropertyChanged("params", value);
}
}

public List<GraphDefinitionLinkCompartment>? Compartment
{
get { return _compartment; }
set {
_compartment= value;
OnPropertyChanged("compartment", value);
}
}


		#endregion
		#region Constructor
		public  GraphDefinitionLink() { }
		public  GraphDefinitionLink(string value) : base(value) { }
		public  GraphDefinitionLink(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class GraphDefinitionVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public GraphDefinitionVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public GraphDefinitionVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public GraphDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
