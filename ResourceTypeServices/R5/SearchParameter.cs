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
    public class SearchParameter : ResourceType<SearchParameter>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private SearchParameterVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private FhirCanonical? _derivedFrom;
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
private FhirCode? _code;
private List<FhirCode>? _base;
private FhirCode? _type;
private FhirString? _expression;
private FhirCode? _processingMode;
private FhirString? _constraint;
private List<FhirCode>? _target;
private FhirBoolean? _multipleOr;
private FhirBoolean? _multipleAnd;
private List<FhirCode>? _comparator;
private List<FhirCode>? _modifier;
private List<FhirString>? _chain;
private List<SearchParameterComponent>? _component;

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

public SearchParameterVersionAlgorithmChoice? VersionAlgorithm
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

public FhirCanonical? DerivedFrom
{
get { return _derivedFrom; }
set {
_derivedFrom= value;
OnPropertyChanged("derivedFrom", value);
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

public FhirCode? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<FhirCode>? Base
{
get { return _base; }
set {
_base= value;
OnPropertyChanged("base", value);
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

public FhirString? Expression
{
get { return _expression; }
set {
_expression= value;
OnPropertyChanged("expression", value);
}
}

public FhirCode? ProcessingMode
{
get { return _processingMode; }
set {
_processingMode= value;
OnPropertyChanged("processingMode", value);
}
}

public FhirString? Constraint
{
get { return _constraint; }
set {
_constraint= value;
OnPropertyChanged("constraint", value);
}
}

public List<FhirCode>? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
}
}

public FhirBoolean? MultipleOr
{
get { return _multipleOr; }
set {
_multipleOr= value;
OnPropertyChanged("multipleOr", value);
}
}

public FhirBoolean? MultipleAnd
{
get { return _multipleAnd; }
set {
_multipleAnd= value;
OnPropertyChanged("multipleAnd", value);
}
}

public List<FhirCode>? Comparator
{
get { return _comparator; }
set {
_comparator= value;
OnPropertyChanged("comparator", value);
}
}

public List<FhirCode>? Modifier
{
get { return _modifier; }
set {
_modifier= value;
OnPropertyChanged("modifier", value);
}
}

public List<FhirString>? Chain
{
get { return _chain; }
set {
_chain= value;
OnPropertyChanged("chain", value);
}
}

public List<SearchParameterComponent>? Component
{
get { return _component; }
set {
_component= value;
OnPropertyChanged("component", value);
}
}


		#endregion
		#region Constructor
		public  SearchParameter() { }
		public  SearchParameter(string value) : base(value) { }
		public  SearchParameter(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SearchParameterComponent : BackboneElementType<SearchParameterComponent>, IBackboneElementType
	{

		#region Private Method
		private FhirCanonical? _definition;
private FhirString? _expression;

		#endregion
		#region public Method
		public FhirCanonical? Definition
{
get { return _definition; }
set {
_definition= value;
OnPropertyChanged("definition", value);
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


		#endregion
		#region Constructor
		public  SearchParameterComponent() { }
		public  SearchParameterComponent(string value) : base(value) { }
		public  SearchParameterComponent(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class SearchParameterVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public SearchParameterVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public SearchParameterVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public SearchParameterVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
