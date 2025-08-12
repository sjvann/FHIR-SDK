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
    public class CompartmentDefinition : ResourceType<CompartmentDefinition>
	{
		#region private Property
		private FhirUri? _url;
private FhirString? _version;
private CompartmentDefinitionVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private FhirCode? _status;
private FhirBoolean? _experimental;
private FhirDateTime? _date;
private FhirString? _publisher;
private List<ContactDetail>? _contact;
private FhirMarkdown? _description;
private List<UsageContext>? _useContext;
private FhirMarkdown? _purpose;
private FhirCode? _code;
private FhirBoolean? _search;
private List<CompartmentDefinitionResource>? _resource;

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

public FhirString? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}

public CompartmentDefinitionVersionAlgorithmChoice? VersionAlgorithm
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

public FhirMarkdown? Purpose
{
get { return _purpose; }
set {
_purpose= value;
OnPropertyChanged("purpose", value);
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

public FhirBoolean? Search
{
get { return _search; }
set {
_search= value;
OnPropertyChanged("search", value);
}
}

public List<CompartmentDefinitionResource>? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
}
}


		#endregion
		#region Constructor
		public  CompartmentDefinition() { }
		public  CompartmentDefinition(string value) : base(value) { }
		public  CompartmentDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class CompartmentDefinitionResource : BackboneElementType<CompartmentDefinitionResource>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private List<FhirString>? _param;
private FhirString? _documentation;
private FhirUri? _startParam;
private FhirUri? _endParam;

		#endregion
		#region public Method
		public FhirCode? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<FhirString>? Param
{
get { return _param; }
set {
_param= value;
OnPropertyChanged("param", value);
}
}

public FhirString? Documentation
{
get { return _documentation; }
set {
_documentation= value;
OnPropertyChanged("documentation", value);
}
}

public FhirUri? StartParam
{
get { return _startParam; }
set {
_startParam= value;
OnPropertyChanged("startParam", value);
}
}

public FhirUri? EndParam
{
get { return _endParam; }
set {
_endParam= value;
OnPropertyChanged("endParam", value);
}
}


		#endregion
		#region Constructor
		public  CompartmentDefinitionResource() { }
		public  CompartmentDefinitionResource(string value) : base(value) { }
		public  CompartmentDefinitionResource(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class CompartmentDefinitionVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public CompartmentDefinitionVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public CompartmentDefinitionVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public CompartmentDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
