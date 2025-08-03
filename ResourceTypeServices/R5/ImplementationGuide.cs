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
    public class ImplementationGuide : ResourceType<ImplementationGuide>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private ImplementationGuideVersionAlgorithmChoice? _versionAlgorithm;
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
private FhirId? _packageId;
private FhirCode? _license;
private List<FhirCode>? _fhirVersion;
private List<ImplementationGuideDependsOn>? _dependsOn;
private List<ImplementationGuideGlobal>? _global;
private ImplementationGuideDefinition? _definition;
private ImplementationGuideManifest? _manifest;

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

public ImplementationGuideVersionAlgorithmChoice? VersionAlgorithm
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

public FhirId? PackageId
{
get { return _packageId; }
set {
_packageId= value;
OnPropertyChanged("packageId", value);
}
}

public FhirCode? License
{
get { return _license; }
set {
_license= value;
OnPropertyChanged("license", value);
}
}

public List<FhirCode>? FhirVersion
{
get { return _fhirVersion; }
set {
_fhirVersion= value;
OnPropertyChanged("fhirVersion", value);
}
}

public List<ImplementationGuideDependsOn>? DependsOn
{
get { return _dependsOn; }
set {
_dependsOn= value;
OnPropertyChanged("dependsOn", value);
}
}

public List<ImplementationGuideGlobal>? Global
{
get { return _global; }
set {
_global= value;
OnPropertyChanged("global", value);
}
}

public ImplementationGuideDefinition? Definition
{
get { return _definition; }
set {
_definition= value;
OnPropertyChanged("definition", value);
}
}

public ImplementationGuideManifest? Manifest
{
get { return _manifest; }
set {
_manifest= value;
OnPropertyChanged("manifest", value);
}
}


		#endregion
		#region Constructor
		public  ImplementationGuide() { }
		public  ImplementationGuide(string value) : base(value) { }
		public  ImplementationGuide(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ImplementationGuideDependsOn : BackboneElementType<ImplementationGuideDependsOn>, IBackboneElementType
	{

		#region Private Method
		private FhirCanonical? _uri;
private FhirId? _packageId;
private FhirString? _version;
private FhirMarkdown? _reason;

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

public FhirId? PackageId
{
get { return _packageId; }
set {
_packageId= value;
OnPropertyChanged("packageId", value);
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

public FhirMarkdown? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}


		#endregion
		#region Constructor
		public  ImplementationGuideDependsOn() { }
		public  ImplementationGuideDependsOn(string value) : base(value) { }
		public  ImplementationGuideDependsOn(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImplementationGuideGlobal : BackboneElementType<ImplementationGuideGlobal>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _type;
private FhirCanonical? _profile;

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
		public  ImplementationGuideGlobal() { }
		public  ImplementationGuideGlobal(string value) : base(value) { }
		public  ImplementationGuideGlobal(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImplementationGuideDefinitionGrouping : BackboneElementType<ImplementationGuideDefinitionGrouping>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _name;
private FhirMarkdown? _description;

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
		public  ImplementationGuideDefinitionGrouping() { }
		public  ImplementationGuideDefinitionGrouping(string value) : base(value) { }
		public  ImplementationGuideDefinitionGrouping(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImplementationGuideDefinitionResource : BackboneElementType<ImplementationGuideDefinitionResource>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _reference;
private List<FhirCode>? _fhirVersion;
private FhirString? _name;
private FhirMarkdown? _description;
private FhirBoolean? _isExample;
private List<FhirCanonical>? _profile;
private FhirId? _groupingId;

		#endregion
		#region public Method
		public ReferenceType? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}

public List<FhirCode>? FhirVersion
{
get { return _fhirVersion; }
set {
_fhirVersion= value;
OnPropertyChanged("fhirVersion", value);
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

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public FhirBoolean? IsExample
{
get { return _isExample; }
set {
_isExample= value;
OnPropertyChanged("isExample", value);
}
}

public List<FhirCanonical>? Profile
{
get { return _profile; }
set {
_profile= value;
OnPropertyChanged("profile", value);
}
}

public FhirId? GroupingId
{
get { return _groupingId; }
set {
_groupingId= value;
OnPropertyChanged("groupingId", value);
}
}


		#endregion
		#region Constructor
		public  ImplementationGuideDefinitionResource() { }
		public  ImplementationGuideDefinitionResource(string value) : base(value) { }
		public  ImplementationGuideDefinitionResource(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImplementationGuideDefinitionPage : BackboneElementType<ImplementationGuideDefinitionPage>, IBackboneElementType
	{

		#region Private Method
		private ImplementationGuideDefinitionPageSourceChoice? _source;
private FhirUrl? _name;
private FhirString? _title;
private FhirCode? _generation;

		#endregion
		#region public Method
		public ImplementationGuideDefinitionPageSourceChoice? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}

public FhirUrl? Name
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

public FhirCode? Generation
{
get { return _generation; }
set {
_generation= value;
OnPropertyChanged("generation", value);
}
}


		#endregion
		#region Constructor
		public  ImplementationGuideDefinitionPage() { }
		public  ImplementationGuideDefinitionPage(string value) : base(value) { }
		public  ImplementationGuideDefinitionPage(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImplementationGuideDefinitionParameter : BackboneElementType<ImplementationGuideDefinitionParameter>, IBackboneElementType
	{

		#region Private Method
		private Coding? _code;
private FhirString? _value;

		#endregion
		#region public Method
		public Coding? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public FhirString? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  ImplementationGuideDefinitionParameter() { }
		public  ImplementationGuideDefinitionParameter(string value) : base(value) { }
		public  ImplementationGuideDefinitionParameter(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImplementationGuideDefinitionTemplate : BackboneElementType<ImplementationGuideDefinitionTemplate>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private FhirString? _source;
private FhirString? _scope;

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

public FhirString? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}

public FhirString? Scope
{
get { return _scope; }
set {
_scope= value;
OnPropertyChanged("scope", value);
}
}


		#endregion
		#region Constructor
		public  ImplementationGuideDefinitionTemplate() { }
		public  ImplementationGuideDefinitionTemplate(string value) : base(value) { }
		public  ImplementationGuideDefinitionTemplate(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImplementationGuideDefinition : BackboneElementType<ImplementationGuideDefinition>, IBackboneElementType
	{

		#region Private Method
		private List<ImplementationGuideDefinitionGrouping>? _grouping;
private List<ImplementationGuideDefinitionResource>? _resource;
private ImplementationGuideDefinitionPage? _page;
private List<ImplementationGuideDefinitionParameter>? _parameter;
private List<ImplementationGuideDefinitionTemplate>? _template;

		#endregion
		#region public Method
		public List<ImplementationGuideDefinitionGrouping>? Grouping
{
get { return _grouping; }
set {
_grouping= value;
OnPropertyChanged("grouping", value);
}
}

public List<ImplementationGuideDefinitionResource>? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
}
}

public ImplementationGuideDefinitionPage? Page
{
get { return _page; }
set {
_page= value;
OnPropertyChanged("page", value);
}
}

public List<ImplementationGuideDefinitionParameter>? Parameter
{
get { return _parameter; }
set {
_parameter= value;
OnPropertyChanged("parameter", value);
}
}

public List<ImplementationGuideDefinitionTemplate>? Template
{
get { return _template; }
set {
_template= value;
OnPropertyChanged("template", value);
}
}


		#endregion
		#region Constructor
		public  ImplementationGuideDefinition() { }
		public  ImplementationGuideDefinition(string value) : base(value) { }
		public  ImplementationGuideDefinition(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImplementationGuideManifestResource : BackboneElementType<ImplementationGuideManifestResource>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _reference;
private FhirBoolean? _isExample;
private List<FhirCanonical>? _profile;
private FhirUrl? _relativePath;

		#endregion
		#region public Method
		public ReferenceType? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}

public FhirBoolean? IsExample
{
get { return _isExample; }
set {
_isExample= value;
OnPropertyChanged("isExample", value);
}
}

public List<FhirCanonical>? Profile
{
get { return _profile; }
set {
_profile= value;
OnPropertyChanged("profile", value);
}
}

public FhirUrl? RelativePath
{
get { return _relativePath; }
set {
_relativePath= value;
OnPropertyChanged("relativePath", value);
}
}


		#endregion
		#region Constructor
		public  ImplementationGuideManifestResource() { }
		public  ImplementationGuideManifestResource(string value) : base(value) { }
		public  ImplementationGuideManifestResource(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImplementationGuideManifestPage : BackboneElementType<ImplementationGuideManifestPage>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _name;
private FhirString? _title;
private List<FhirString>? _anchor;

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

public FhirString? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
}
}

public List<FhirString>? Anchor
{
get { return _anchor; }
set {
_anchor= value;
OnPropertyChanged("anchor", value);
}
}


		#endregion
		#region Constructor
		public  ImplementationGuideManifestPage() { }
		public  ImplementationGuideManifestPage(string value) : base(value) { }
		public  ImplementationGuideManifestPage(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImplementationGuideManifest : BackboneElementType<ImplementationGuideManifest>, IBackboneElementType
	{

		#region Private Method
		private FhirUrl? _rendering;
private List<ImplementationGuideManifestResource>? _resource;
private List<ImplementationGuideManifestPage>? _page;
private List<FhirString>? _image;
private List<FhirString>? _other;

		#endregion
		#region public Method
		public FhirUrl? Rendering
{
get { return _rendering; }
set {
_rendering= value;
OnPropertyChanged("rendering", value);
}
}

public List<ImplementationGuideManifestResource>? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
}
}

public List<ImplementationGuideManifestPage>? Page
{
get { return _page; }
set {
_page= value;
OnPropertyChanged("page", value);
}
}

public List<FhirString>? Image
{
get { return _image; }
set {
_image= value;
OnPropertyChanged("image", value);
}
}

public List<FhirString>? Other
{
get { return _other; }
set {
_other= value;
OnPropertyChanged("other", value);
}
}


		#endregion
		#region Constructor
		public  ImplementationGuideManifest() { }
		public  ImplementationGuideManifest(string value) : base(value) { }
		public  ImplementationGuideManifest(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ImplementationGuideVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public ImplementationGuideVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public ImplementationGuideVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public ImplementationGuideVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ImplementationGuideDefinitionPageSourceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "url","stringmarkdown"
        ];

        public ImplementationGuideDefinitionPageSourceChoice(JsonObject value) : base("source", value, _supportType)
        {
        }
        public ImplementationGuideDefinitionPageSourceChoice(IComplexType? value) : base("source", value)
        {
        }
        public ImplementationGuideDefinitionPageSourceChoice(IPrimitiveType? value) : base("source", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"source".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
