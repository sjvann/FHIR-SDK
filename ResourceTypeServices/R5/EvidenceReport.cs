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
    public class EvidenceReport : ResourceType<EvidenceReport>
	{
		#region private Property
		private FhirUri? _url;
private FhirCode? _status;
private List<UsageContext>? _useContext;
private List<Identifier>? _identifier;
private List<Identifier>? _relatedIdentifier;
private EvidenceReportCiteAsChoice? _citeAs;
private CodeableConcept? _type;
private List<Annotation>? _note;
private List<RelatedArtifact>? _relatedArtifact;
private EvidenceReportSubject? _subject;
private FhirString? _publisher;
private List<ContactDetail>? _contact;
private List<ContactDetail>? _author;
private List<ContactDetail>? _editor;
private List<ContactDetail>? _reviewer;
private List<ContactDetail>? _endorser;
private List<EvidenceReportRelatesTo>? _relatesTo;
private List<EvidenceReportSection>? _section;

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

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
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

public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public List<Identifier>? RelatedIdentifier
{
get { return _relatedIdentifier; }
set {
_relatedIdentifier= value;
OnPropertyChanged("relatedIdentifier", value);
}
}

public EvidenceReportCiteAsChoice? CiteAs
{
get { return _citeAs; }
set {
_citeAs= value;
OnPropertyChanged("citeAs", value);
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

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
}
}

public List<RelatedArtifact>? RelatedArtifact
{
get { return _relatedArtifact; }
set {
_relatedArtifact= value;
OnPropertyChanged("relatedArtifact", value);
}
}

public EvidenceReportSubject? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
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

public List<ContactDetail>? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}

public List<ContactDetail>? Editor
{
get { return _editor; }
set {
_editor= value;
OnPropertyChanged("editor", value);
}
}

public List<ContactDetail>? Reviewer
{
get { return _reviewer; }
set {
_reviewer= value;
OnPropertyChanged("reviewer", value);
}
}

public List<ContactDetail>? Endorser
{
get { return _endorser; }
set {
_endorser= value;
OnPropertyChanged("endorser", value);
}
}

public List<EvidenceReportRelatesTo>? RelatesTo
{
get { return _relatesTo; }
set {
_relatesTo= value;
OnPropertyChanged("relatesTo", value);
}
}

public List<EvidenceReportSection>? Section
{
get { return _section; }
set {
_section= value;
OnPropertyChanged("section", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceReport() { }
		public  EvidenceReport(string value) : base(value) { }
		public  EvidenceReport(JsonNode? source) : base(source) { }
		#endregion
	}
		public class EvidenceReportSubjectCharacteristic : BackboneElementType<EvidenceReportSubjectCharacteristic>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private EvidenceReportSubjectCharacteristicValueChoice? _value;
private FhirBoolean? _exclude;
private Period? _period;

		#endregion
		#region public Method
		public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public EvidenceReportSubjectCharacteristicValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public FhirBoolean? Exclude
{
get { return _exclude; }
set {
_exclude= value;
OnPropertyChanged("exclude", value);
}
}

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceReportSubjectCharacteristic() { }
		public  EvidenceReportSubjectCharacteristic(string value) : base(value) { }
		public  EvidenceReportSubjectCharacteristic(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceReportSubject : BackboneElementType<EvidenceReportSubject>, IBackboneElementType
	{

		#region Private Method
		private List<EvidenceReportSubjectCharacteristic>? _characteristic;
private List<Annotation>? _note;

		#endregion
		#region public Method
		public List<EvidenceReportSubjectCharacteristic>? Characteristic
{
get { return _characteristic; }
set {
_characteristic= value;
OnPropertyChanged("characteristic", value);
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


		#endregion
		#region Constructor
		public  EvidenceReportSubject() { }
		public  EvidenceReportSubject(string value) : base(value) { }
		public  EvidenceReportSubject(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceReportRelatesToTarget : BackboneElementType<EvidenceReportRelatesToTarget>, IBackboneElementType
	{

		#region Private Method
		private FhirUri? _url;
private Identifier? _identifier;
private FhirMarkdown? _display;
private ReferenceType? _resource;

		#endregion
		#region public Method
		public FhirUri? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
}
}

public Identifier? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirMarkdown? Display
{
get { return _display; }
set {
_display= value;
OnPropertyChanged("display", value);
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


		#endregion
		#region Constructor
		public  EvidenceReportRelatesToTarget() { }
		public  EvidenceReportRelatesToTarget(string value) : base(value) { }
		public  EvidenceReportRelatesToTarget(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceReportRelatesTo : BackboneElementType<EvidenceReportRelatesTo>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private EvidenceReportRelatesToTarget? _target;

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

public EvidenceReportRelatesToTarget? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceReportRelatesTo() { }
		public  EvidenceReportRelatesTo(string value) : base(value) { }
		public  EvidenceReportRelatesTo(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceReportSection : BackboneElementType<EvidenceReportSection>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _title;
private CodeableConcept? _focus;
private ReferenceType? _focusReference;
private List<ReferenceType>? _author;
private FhirCode? _mode;
private CodeableConcept? _orderedBy;
private List<CodeableConcept>? _entryClassifier;
private List<ReferenceType>? _entryReference;
private List<Quantity>? _entryQuantity;
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

public CodeableConcept? Focus
{
get { return _focus; }
set {
_focus= value;
OnPropertyChanged("focus", value);
}
}

public ReferenceType? FocusReference
{
get { return _focusReference; }
set {
_focusReference= value;
OnPropertyChanged("focusReference", value);
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

public FhirCode? Mode
{
get { return _mode; }
set {
_mode= value;
OnPropertyChanged("mode", value);
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

public List<CodeableConcept>? EntryClassifier
{
get { return _entryClassifier; }
set {
_entryClassifier= value;
OnPropertyChanged("entryClassifier", value);
}
}

public List<ReferenceType>? EntryReference
{
get { return _entryReference; }
set {
_entryReference= value;
OnPropertyChanged("entryReference", value);
}
}

public List<Quantity>? EntryQuantity
{
get { return _entryQuantity; }
set {
_entryQuantity= value;
OnPropertyChanged("entryQuantity", value);
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
		public  EvidenceReportSection() { }
		public  EvidenceReportSection(string value) : base(value) { }
		public  EvidenceReportSection(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class EvidenceReportCiteAsChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(Citation)","markdown"
        ];

        public EvidenceReportCiteAsChoice(JsonObject value) : base("citeAs", value, _supportType)
        {
        }
        public EvidenceReportCiteAsChoice(IComplexType? value) : base("citeAs", value)
        {
        }
        public EvidenceReportCiteAsChoice(IPrimitiveType? value) : base("citeAs", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"citeAs".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class EvidenceReportSubjectCharacteristicValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(Resource)","CodeableConceptbooleanQuantityRange"
        ];

        public EvidenceReportSubjectCharacteristicValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public EvidenceReportSubjectCharacteristicValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public EvidenceReportSubjectCharacteristicValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
