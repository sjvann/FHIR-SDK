using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;


namespace ResourceTypeServices.R5
{
    public class Composition : ResourceType<Composition>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private FhirCode? _status;
private CodeableConcept? _type;
private List<CodeableConcept>? _category;
private List<ReferenceType>? _subject;
private ReferenceType? _encounter;
private FhirDateTime? _date;
private List<UsageContext>? _useContext;
private List<ReferenceType>? _author;
private FhirString? _name;
private FhirString? _title;
private List<Annotation>? _note;
private List<CompositionAttester>? _attester;
private ReferenceType? _custodian;
private List<RelatedArtifact>? _relatesTo;
private List<CompositionEvent>? _event;
private List<CompositionSection>? _section;

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

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
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

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public List<ReferenceType>? Subject
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

public FhirDateTime? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
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

public List<ReferenceType>? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
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

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
}
}

public List<CompositionAttester>? Attester
{
get { return _attester; }
set {
_attester= value;
OnPropertyChanged("attester", value);
}
}

public ReferenceType? Custodian
{
get { return _custodian; }
set {
_custodian= value;
OnPropertyChanged("custodian", value);
}
}

public List<RelatedArtifact>? RelatesTo
{
get { return _relatesTo; }
set {
_relatesTo= value;
OnPropertyChanged("relatesTo", value);
}
}

public List<CompositionEvent>? Event
{
get { return _event; }
set {
_event= value;
OnPropertyChanged("event", value);
}
}

public List<CompositionSection>? Section
{
get { return _section; }
set {
_section= value;
OnPropertyChanged("section", value);
}
}


		#endregion
		#region Constructor
		public  Composition() { }
		public  Composition(string value) : base(value) { }
		public  Composition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class CompositionAttester : BackboneElementType<CompositionAttester>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _mode;
private FhirDateTime? _time;
private ReferenceType? _party;

		#endregion
		#region public Method
		public CodeableConcept? Mode
{
get { return _mode; }
set {
_mode= value;
OnPropertyChanged("mode", value);
}
}

public FhirDateTime? Time
{
get { return _time; }
set {
_time= value;
OnPropertyChanged("time", value);
}
}

public ReferenceType? Party
{
get { return _party; }
set {
_party= value;
OnPropertyChanged("party", value);
}
}


		#endregion
		#region Constructor
		public  CompositionAttester() { }
		public  CompositionAttester(string value) : base(value) { }
		public  CompositionAttester(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CompositionEvent : BackboneElementType<CompositionEvent>, IBackboneElementType
	{

		#region Private Method
		private Period? _period;
private List<CodeableReference>? _detail;

		#endregion
		#region public Method
		public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public List<CodeableReference>? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}


		#endregion
		#region Constructor
		public  CompositionEvent() { }
		public  CompositionEvent(string value) : base(value) { }
		public  CompositionEvent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CompositionSection : BackboneElementType<CompositionSection>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _title;
private CodeableConcept? _code;
private List<ReferenceType>? _author;
private ReferenceType? _focus;
private CodeableConcept? _orderedBy;
private List<ReferenceType>? _entry;
private CodeableConcept? _emptyReason;

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

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<ReferenceType>? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}

public ReferenceType? Focus
{
get { return _focus; }
set {
_focus= value;
OnPropertyChanged("focus", value);
}
}

public CodeableConcept? OrderedBy
{
get { return _orderedBy; }
set {
_orderedBy= value;
OnPropertyChanged("orderedBy", value);
}
}

public List<ReferenceType>? Entry
{
get { return _entry; }
set {
_entry= value;
OnPropertyChanged("entry", value);
}
}

public CodeableConcept? EmptyReason
{
get { return _emptyReason; }
set {
_emptyReason= value;
OnPropertyChanged("emptyReason", value);
}
}


		#endregion
		#region Constructor
		public  CompositionSection() { }
		public  CompositionSection(string value) : base(value) { }
		public  CompositionSection(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
