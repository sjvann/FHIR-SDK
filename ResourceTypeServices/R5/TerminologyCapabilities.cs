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
    public class TerminologyCapabilities : ResourceType<TerminologyCapabilities>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private TerminologyCapabilitiesVersionAlgorithmChoice? _versionAlgorithm;
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
private FhirCode? _kind;
private TerminologyCapabilitiesSoftware? _software;
private TerminologyCapabilitiesImplementation? _implementation;
private FhirBoolean? _lockedDate;
private List<TerminologyCapabilitiesCodeSystem>? _codeSystem;
private TerminologyCapabilitiesExpansion? _expansion;
private FhirCode? _codeSearch;
private TerminologyCapabilitiesValidateCode? _validateCode;
private TerminologyCapabilitiesTranslation? _translation;
private TerminologyCapabilitiesClosure? _closure;

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

public TerminologyCapabilitiesVersionAlgorithmChoice? VersionAlgorithm
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

public FhirCode? Kind
{
get { return _kind; }
set {
_kind= value;
OnPropertyChanged("kind", value);
}
}

public TerminologyCapabilitiesSoftware? Software
{
get { return _software; }
set {
_software= value;
OnPropertyChanged("software", value);
}
}

public TerminologyCapabilitiesImplementation? Implementation
{
get { return _implementation; }
set {
_implementation= value;
OnPropertyChanged("implementation", value);
}
}

public FhirBoolean? LockedDate
{
get { return _lockedDate; }
set {
_lockedDate= value;
OnPropertyChanged("lockedDate", value);
}
}

public List<TerminologyCapabilitiesCodeSystem>? CodeSystem
{
get { return _codeSystem; }
set {
_codeSystem= value;
OnPropertyChanged("codeSystem", value);
}
}

public TerminologyCapabilitiesExpansion? Expansion
{
get { return _expansion; }
set {
_expansion= value;
OnPropertyChanged("expansion", value);
}
}

public FhirCode? CodeSearch
{
get { return _codeSearch; }
set {
_codeSearch= value;
OnPropertyChanged("codeSearch", value);
}
}

public TerminologyCapabilitiesValidateCode? ValidateCode
{
get { return _validateCode; }
set {
_validateCode= value;
OnPropertyChanged("validateCode", value);
}
}

public TerminologyCapabilitiesTranslation? Translation
{
get { return _translation; }
set {
_translation= value;
OnPropertyChanged("translation", value);
}
}

public TerminologyCapabilitiesClosure? Closure
{
get { return _closure; }
set {
_closure= value;
OnPropertyChanged("closure", value);
}
}


		#endregion
		#region Constructor
		public  TerminologyCapabilities() { }
		public  TerminologyCapabilities(string value) : base(value) { }
		public  TerminologyCapabilities(JsonNode? source) : base(source) { }
		#endregion
	}
		public class TerminologyCapabilitiesSoftware : BackboneElementType<TerminologyCapabilitiesSoftware>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _name;
private FhirString? _version;

		#endregion
		#region public Method
		public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
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


		#endregion
		#region Constructor
		public  TerminologyCapabilitiesSoftware() { }
		public  TerminologyCapabilitiesSoftware(string value) : base(value) { }
		public  TerminologyCapabilitiesSoftware(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TerminologyCapabilitiesImplementation : BackboneElementType<TerminologyCapabilitiesImplementation>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _description;
private FhirUrl? _url;

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

public FhirUrl? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
}
}


		#endregion
		#region Constructor
		public  TerminologyCapabilitiesImplementation() { }
		public  TerminologyCapabilitiesImplementation(string value) : base(value) { }
		public  TerminologyCapabilitiesImplementation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TerminologyCapabilitiesCodeSystemVersionFilter : BackboneElementType<TerminologyCapabilitiesCodeSystemVersionFilter>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private List<FhirCode>? _op;

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

public List<FhirCode>? Op
{
get { return _op; }
set {
_op= value;
OnPropertyChanged("op", value);
}
}


		#endregion
		#region Constructor
		public  TerminologyCapabilitiesCodeSystemVersionFilter() { }
		public  TerminologyCapabilitiesCodeSystemVersionFilter(string value) : base(value) { }
		public  TerminologyCapabilitiesCodeSystemVersionFilter(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TerminologyCapabilitiesCodeSystemVersion : BackboneElementType<TerminologyCapabilitiesCodeSystemVersion>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _code;
private FhirBoolean? _isDefault;
private FhirBoolean? _compositional;
private List<FhirCode>? _language;
private List<TerminologyCapabilitiesCodeSystemVersionFilter>? _filter;
private List<FhirCode>? _property;

		#endregion
		#region public Method
		public FhirString? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public FhirBoolean? IsDefault
{
get { return _isDefault; }
set {
_isDefault= value;
OnPropertyChanged("isDefault", value);
}
}

public FhirBoolean? Compositional
{
get { return _compositional; }
set {
_compositional= value;
OnPropertyChanged("compositional", value);
}
}

public List<FhirCode>? Language
{
get { return _language; }
set {
_language= value;
OnPropertyChanged("language", value);
}
}

public List<TerminologyCapabilitiesCodeSystemVersionFilter>? Filter
{
get { return _filter; }
set {
_filter= value;
OnPropertyChanged("filter", value);
}
}

public List<FhirCode>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}


		#endregion
		#region Constructor
		public  TerminologyCapabilitiesCodeSystemVersion() { }
		public  TerminologyCapabilitiesCodeSystemVersion(string value) : base(value) { }
		public  TerminologyCapabilitiesCodeSystemVersion(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TerminologyCapabilitiesCodeSystem : BackboneElementType<TerminologyCapabilitiesCodeSystem>, IBackboneElementType
	{

		#region Private Method
		private FhirCanonical? _uri;
private List<TerminologyCapabilitiesCodeSystemVersion>? _version;
private FhirCode? _content;
private FhirBoolean? _subsumption;

		#endregion
		#region public Method
		public FhirCanonical? Uri
{
get { return _uri; }
set {
_uri= value;
OnPropertyChanged("uri", value);
}
}

public List<TerminologyCapabilitiesCodeSystemVersion>? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}

public FhirCode? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}

public FhirBoolean? Subsumption
{
get { return _subsumption; }
set {
_subsumption= value;
OnPropertyChanged("subsumption", value);
}
}


		#endregion
		#region Constructor
		public  TerminologyCapabilitiesCodeSystem() { }
		public  TerminologyCapabilitiesCodeSystem(string value) : base(value) { }
		public  TerminologyCapabilitiesCodeSystem(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TerminologyCapabilitiesExpansionParameter : BackboneElementType<TerminologyCapabilitiesExpansionParameter>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _name;
private FhirString? _documentation;

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

public FhirString? Documentation
{
get { return _documentation; }
set {
_documentation= value;
OnPropertyChanged("documentation", value);
}
}


		#endregion
		#region Constructor
		public  TerminologyCapabilitiesExpansionParameter() { }
		public  TerminologyCapabilitiesExpansionParameter(string value) : base(value) { }
		public  TerminologyCapabilitiesExpansionParameter(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TerminologyCapabilitiesExpansion : BackboneElementType<TerminologyCapabilitiesExpansion>, IBackboneElementType
	{

		#region Private Method
		private FhirBoolean? _hierarchical;
private FhirBoolean? _paging;
private FhirBoolean? _incomplete;
private List<TerminologyCapabilitiesExpansionParameter>? _parameter;
private FhirMarkdown? _textFilter;

		#endregion
		#region public Method
		public FhirBoolean? Hierarchical
{
get { return _hierarchical; }
set {
_hierarchical= value;
OnPropertyChanged("hierarchical", value);
}
}

public FhirBoolean? Paging
{
get { return _paging; }
set {
_paging= value;
OnPropertyChanged("paging", value);
}
}

public FhirBoolean? Incomplete
{
get { return _incomplete; }
set {
_incomplete= value;
OnPropertyChanged("incomplete", value);
}
}

public List<TerminologyCapabilitiesExpansionParameter>? Parameter
{
get { return _parameter; }
set {
_parameter= value;
OnPropertyChanged("parameter", value);
}
}

public FhirMarkdown? TextFilter
{
get { return _textFilter; }
set {
_textFilter= value;
OnPropertyChanged("textFilter", value);
}
}


		#endregion
		#region Constructor
		public  TerminologyCapabilitiesExpansion() { }
		public  TerminologyCapabilitiesExpansion(string value) : base(value) { }
		public  TerminologyCapabilitiesExpansion(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TerminologyCapabilitiesValidateCode : BackboneElementType<TerminologyCapabilitiesValidateCode>, IBackboneElementType
	{

		#region Private Method
		private FhirBoolean? _translations;

		#endregion
		#region public Method
		public FhirBoolean? Translations
{
get { return _translations; }
set {
_translations= value;
OnPropertyChanged("translations", value);
}
}


		#endregion
		#region Constructor
		public  TerminologyCapabilitiesValidateCode() { }
		public  TerminologyCapabilitiesValidateCode(string value) : base(value) { }
		public  TerminologyCapabilitiesValidateCode(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TerminologyCapabilitiesTranslation : BackboneElementType<TerminologyCapabilitiesTranslation>, IBackboneElementType
	{

		#region Private Method
		private FhirBoolean? _needsMap;

		#endregion
		#region public Method
		public FhirBoolean? NeedsMap
{
get { return _needsMap; }
set {
_needsMap= value;
OnPropertyChanged("needsMap", value);
}
}


		#endregion
		#region Constructor
		public  TerminologyCapabilitiesTranslation() { }
		public  TerminologyCapabilitiesTranslation(string value) : base(value) { }
		public  TerminologyCapabilitiesTranslation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TerminologyCapabilitiesClosure : BackboneElementType<TerminologyCapabilitiesClosure>, IBackboneElementType
	{

		#region Private Method
		private FhirBoolean? _translation;

		#endregion
		#region public Method
		public FhirBoolean? Translation
{
get { return _translation; }
set {
_translation= value;
OnPropertyChanged("translation", value);
}
}


		#endregion
		#region Constructor
		public  TerminologyCapabilitiesClosure() { }
		public  TerminologyCapabilitiesClosure(string value) : base(value) { }
		public  TerminologyCapabilitiesClosure(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class TerminologyCapabilitiesVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public TerminologyCapabilitiesVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public TerminologyCapabilitiesVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public TerminologyCapabilitiesVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
