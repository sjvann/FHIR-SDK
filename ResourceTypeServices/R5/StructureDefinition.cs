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
    public class StructureDefinition : ResourceType<StructureDefinition>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private StructureDefinitionVersionAlgorithmChoice? _versionAlgorithm;
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
private List<Coding>? _keyword;
private FhirCode? _fhirVersion;
private List<StructureDefinitionMapping>? _mapping;
private FhirCode? _kind;
private FhirBoolean? _abstract;
private List<StructureDefinitionContext>? _context;
private List<FhirString>? _contextInvariant;
private FhirUri? _type;
private FhirCanonical? _baseDefinition;
private FhirCode? _derivation;
private StructureDefinitionSnapshot? _snapshot;
private StructureDefinitionDifferential? _differential;

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

public StructureDefinitionVersionAlgorithmChoice? VersionAlgorithm
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

public List<Coding>? Keyword
{
get { return _keyword; }
set {
_keyword= value;
OnPropertyChanged("keyword", value);
}
}

public FhirCode? FhirVersion
{
get { return _fhirVersion; }
set {
_fhirVersion= value;
OnPropertyChanged("fhirVersion", value);
}
}

public List<StructureDefinitionMapping>? Mapping
{
get { return _mapping; }
set {
_mapping= value;
OnPropertyChanged("mapping", value);
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

public FhirBoolean? Abstract
{
get { return _abstract; }
set {
_abstract= value;
OnPropertyChanged("abstract", value);
}
}

public List<StructureDefinitionContext>? Context
{
get { return _context; }
set {
_context= value;
OnPropertyChanged("context", value);
}
}

public List<FhirString>? ContextInvariant
{
get { return _contextInvariant; }
set {
_contextInvariant= value;
OnPropertyChanged("contextInvariant", value);
}
}

public FhirUri? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirCanonical? BaseDefinition
{
get { return _baseDefinition; }
set {
_baseDefinition= value;
OnPropertyChanged("baseDefinition", value);
}
}

public FhirCode? Derivation
{
get { return _derivation; }
set {
_derivation= value;
OnPropertyChanged("derivation", value);
}
}

public StructureDefinitionSnapshot? Snapshot
{
get { return _snapshot; }
set {
_snapshot= value;
OnPropertyChanged("snapshot", value);
}
}

public StructureDefinitionDifferential? Differential
{
get { return _differential; }
set {
_differential= value;
OnPropertyChanged("differential", value);
}
}


		#endregion
		#region Constructor
		public  StructureDefinition() { }
		public  StructureDefinition(string value) : base(value) { }
		public  StructureDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class StructureDefinitionMapping : BackboneElementType<StructureDefinitionMapping>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _identity;
private FhirUri? _uri;
private FhirString? _name;
private FhirString? _comment;

		#endregion
		#region public Method
		public FhirId? Identity
{
get { return _identity; }
set {
_identity= value;
OnPropertyChanged("identity", value);
}
}

public FhirUri? Uri
{
get { return _uri; }
set {
_uri= value;
OnPropertyChanged("uri", value);
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
		public  StructureDefinitionMapping() { }
		public  StructureDefinitionMapping(string value) : base(value) { }
		public  StructureDefinitionMapping(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class StructureDefinitionContext : BackboneElementType<StructureDefinitionContext>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _type;
private FhirString? _expression;

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
		public  StructureDefinitionContext() { }
		public  StructureDefinitionContext(string value) : base(value) { }
		public  StructureDefinitionContext(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class StructureDefinitionSnapshot : BackboneElementType<StructureDefinitionSnapshot>, IBackboneElementType
	{

		#region Private Method
		private List<ElementDefinition>? _element;

		#endregion
		#region public Method
		public List<ElementDefinition>? Element
{
get { return _element; }
set {
_element= value;
OnPropertyChanged("element", value);
}
}


		#endregion
		#region Constructor
		public  StructureDefinitionSnapshot() { }
		public  StructureDefinitionSnapshot(string value) : base(value) { }
		public  StructureDefinitionSnapshot(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class StructureDefinitionDifferential : BackboneElementType<StructureDefinitionDifferential>, IBackboneElementType
	{

		#region Private Method
		private List<ElementDefinition>? _element;

		#endregion
		#region public Method
		public List<ElementDefinition>? Element
{
get { return _element; }
set {
_element= value;
OnPropertyChanged("element", value);
}
}


		#endregion
		#region Constructor
		public  StructureDefinitionDifferential() { }
		public  StructureDefinitionDifferential(string value) : base(value) { }
		public  StructureDefinitionDifferential(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class StructureDefinitionVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public StructureDefinitionVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public StructureDefinitionVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public StructureDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
