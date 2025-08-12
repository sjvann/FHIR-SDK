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
    public class OperationDefinition : ResourceType<OperationDefinition>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private OperationDefinitionVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private FhirCode? _status;
private FhirCode? _kind;
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
private FhirBoolean? _affectsState;
private FhirCode? _code;
private FhirMarkdown? _comment;
private FhirCanonical? _base;
private List<FhirCode>? _resource;
private FhirBoolean? _system;
private FhirBoolean? _type;
private FhirBoolean? _instance;
private FhirCanonical? _inputProfile;
private FhirCanonical? _outputProfile;
private List<OperationDefinitionParameter>? _parameter;
private List<OperationDefinitionOverload>? _overload;

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

public OperationDefinitionVersionAlgorithmChoice? VersionAlgorithm
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

public FhirCode? Kind
{
get { return _kind; }
set {
_kind= value;
OnPropertyChanged("kind", value);
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

public FhirBoolean? AffectsState
{
get { return _affectsState; }
set {
_affectsState= value;
OnPropertyChanged("affectsState", value);
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

public FhirMarkdown? Comment
{
get { return _comment; }
set {
_comment= value;
OnPropertyChanged("comment", value);
}
}

public FhirCanonical? Base
{
get { return _base; }
set {
_base= value;
OnPropertyChanged("base", value);
}
}

public List<FhirCode>? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
}
}

public FhirBoolean? System
{
get { return _system; }
set {
_system= value;
OnPropertyChanged("system", value);
}
}

public FhirBoolean? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirBoolean? Instance
{
get { return _instance; }
set {
_instance= value;
OnPropertyChanged("instance", value);
}
}

public FhirCanonical? InputProfile
{
get { return _inputProfile; }
set {
_inputProfile= value;
OnPropertyChanged("inputProfile", value);
}
}

public FhirCanonical? OutputProfile
{
get { return _outputProfile; }
set {
_outputProfile= value;
OnPropertyChanged("outputProfile", value);
}
}

public List<OperationDefinitionParameter>? Parameter
{
get { return _parameter; }
set {
_parameter= value;
OnPropertyChanged("parameter", value);
}
}

public List<OperationDefinitionOverload>? Overload
{
get { return _overload; }
set {
_overload= value;
OnPropertyChanged("overload", value);
}
}


		#endregion
		#region Constructor
		public  OperationDefinition() { }
		public  OperationDefinition(string value) : base(value) { }
		public  OperationDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class OperationDefinitionParameterBinding : BackboneElementType<OperationDefinitionParameterBinding>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _strength;
private FhirCanonical? _valueSet;

		#endregion
		#region public Method
		public FhirCode? Strength
{
get { return _strength; }
set {
_strength= value;
OnPropertyChanged("strength", value);
}
}

public FhirCanonical? ValueSet
{
get { return _valueSet; }
set {
_valueSet= value;
OnPropertyChanged("valueSet", value);
}
}


		#endregion
		#region Constructor
		public  OperationDefinitionParameterBinding() { }
		public  OperationDefinitionParameterBinding(string value) : base(value) { }
		public  OperationDefinitionParameterBinding(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class OperationDefinitionParameterReferencedFrom : BackboneElementType<OperationDefinitionParameterReferencedFrom>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _source;
private FhirString? _sourceId;

		#endregion
		#region public Method
		public FhirString? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}

public FhirString? SourceId
{
get { return _sourceId; }
set {
_sourceId= value;
OnPropertyChanged("sourceId", value);
}
}


		#endregion
		#region Constructor
		public  OperationDefinitionParameterReferencedFrom() { }
		public  OperationDefinitionParameterReferencedFrom(string value) : base(value) { }
		public  OperationDefinitionParameterReferencedFrom(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class OperationDefinitionParameter : BackboneElementType<OperationDefinitionParameter>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _name;
private FhirCode? _use;
private List<FhirCode>? _scope;
private FhirInteger? _min;
private FhirString? _max;
private FhirMarkdown? _documentation;
private FhirCode? _type;
private List<FhirCode>? _allowedType;
private List<FhirCanonical>? _targetProfile;
private FhirCode? _searchType;
private OperationDefinitionParameterBinding? _binding;
private List<OperationDefinitionParameterReferencedFrom>? _referencedFrom;

		#endregion
		#region public Method
		public FhirCode? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public FhirCode? Use
{
get { return _use; }
set {
_use= value;
OnPropertyChanged("use", value);
}
}

public List<FhirCode>? Scope
{
get { return _scope; }
set {
_scope= value;
OnPropertyChanged("scope", value);
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

public FhirMarkdown? Documentation
{
get { return _documentation; }
set {
_documentation= value;
OnPropertyChanged("documentation", value);
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

public List<FhirCode>? AllowedType
{
get { return _allowedType; }
set {
_allowedType= value;
OnPropertyChanged("allowedType", value);
}
}

public List<FhirCanonical>? TargetProfile
{
get { return _targetProfile; }
set {
_targetProfile= value;
OnPropertyChanged("targetProfile", value);
}
}

public FhirCode? SearchType
{
get { return _searchType; }
set {
_searchType= value;
OnPropertyChanged("searchType", value);
}
}

public OperationDefinitionParameterBinding? Binding
{
get { return _binding; }
set {
_binding= value;
OnPropertyChanged("binding", value);
}
}

public List<OperationDefinitionParameterReferencedFrom>? ReferencedFrom
{
get { return _referencedFrom; }
set {
_referencedFrom= value;
OnPropertyChanged("referencedFrom", value);
}
}


		#endregion
		#region Constructor
		public  OperationDefinitionParameter() { }
		public  OperationDefinitionParameter(string value) : base(value) { }
		public  OperationDefinitionParameter(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class OperationDefinitionOverload : BackboneElementType<OperationDefinitionOverload>, IBackboneElementType
	{

		#region Private Method
		private List<FhirString>? _parameterName;
private FhirString? _comment;

		#endregion
		#region public Method
		public List<FhirString>? ParameterName
{
get { return _parameterName; }
set {
_parameterName= value;
OnPropertyChanged("parameterName", value);
}
}

public FhirString? Comment
{
get { return _comment; }
set {
_comment= value;
OnPropertyChanged("comment", value);
}
}


		#endregion
		#region Constructor
		public  OperationDefinitionOverload() { }
		public  OperationDefinitionOverload(string value) : base(value) { }
		public  OperationDefinitionOverload(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class OperationDefinitionVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public OperationDefinitionVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public OperationDefinitionVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public OperationDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
