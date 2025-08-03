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
    public class DiagnosticReport : ResourceType<DiagnosticReport>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _basedOn;
private FhirCode? _status;
private List<CodeableConcept>? _category;
private CodeableConcept? _code;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private DiagnosticReportEffectiveChoice? _effective;
private FhirInstant? _issued;
private List<ReferenceType>? _performer;
private List<ReferenceType>? _resultsInterpreter;
private List<ReferenceType>? _specimen;
private List<ReferenceType>? _result;
private List<Annotation>? _note;
private List<ReferenceType>? _study;
private List<DiagnosticReportSupportingInfo>? _supportingInfo;
private List<DiagnosticReportMedia>? _media;
private ReferenceType? _composition;
private FhirMarkdown? _conclusion;
private List<CodeableConcept>? _conclusionCode;
private List<Attachment>? _presentedForm;

		#endregion
		#region Public Method
		public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public List<ReferenceType>? BasedOn
{
get { return _basedOn; }
set {
_basedOn= value;
OnPropertyChanged("basedOn", value);
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

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public ReferenceType? Subject
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

public DiagnosticReportEffectiveChoice? Effective
{
get { return _effective; }
set {
_effective= value;
OnPropertyChanged("effective", value);
}
}

public FhirInstant? Issued
{
get { return _issued; }
set {
_issued= value;
OnPropertyChanged("issued", value);
}
}

public List<ReferenceType>? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
}
}

public List<ReferenceType>? ResultsInterpreter
{
get { return _resultsInterpreter; }
set {
_resultsInterpreter= value;
OnPropertyChanged("resultsInterpreter", value);
}
}

public List<ReferenceType>? Specimen
{
get { return _specimen; }
set {
_specimen= value;
OnPropertyChanged("specimen", value);
}
}

public List<ReferenceType>? Result
{
get { return _result; }
set {
_result= value;
OnPropertyChanged("result", value);
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

public List<ReferenceType>? Study
{
get { return _study; }
set {
_study= value;
OnPropertyChanged("study", value);
}
}

public List<DiagnosticReportSupportingInfo>? SupportingInfo
{
get { return _supportingInfo; }
set {
_supportingInfo= value;
OnPropertyChanged("supportingInfo", value);
}
}

public List<DiagnosticReportMedia>? Media
{
get { return _media; }
set {
_media= value;
OnPropertyChanged("media", value);
}
}

public ReferenceType? Composition
{
get { return _composition; }
set {
_composition= value;
OnPropertyChanged("composition", value);
}
}

public FhirMarkdown? Conclusion
{
get { return _conclusion; }
set {
_conclusion= value;
OnPropertyChanged("conclusion", value);
}
}

public List<CodeableConcept>? ConclusionCode
{
get { return _conclusionCode; }
set {
_conclusionCode= value;
OnPropertyChanged("conclusionCode", value);
}
}

public List<Attachment>? PresentedForm
{
get { return _presentedForm; }
set {
_presentedForm= value;
OnPropertyChanged("presentedForm", value);
}
}


		#endregion
		#region Constructor
		public  DiagnosticReport() { }
		public  DiagnosticReport(string value) : base(value) { }
		public  DiagnosticReport(JsonNode? source) : base(source) { }
		#endregion
	}
		public class DiagnosticReportSupportingInfo : BackboneElementType<DiagnosticReportSupportingInfo>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private ReferenceType? _reference;

		#endregion
		#region public Method
		public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public ReferenceType? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}


		#endregion
		#region Constructor
		public  DiagnosticReportSupportingInfo() { }
		public  DiagnosticReportSupportingInfo(string value) : base(value) { }
		public  DiagnosticReportSupportingInfo(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DiagnosticReportMedia : BackboneElementType<DiagnosticReportMedia>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _comment;
private ReferenceType? _link;

		#endregion
		#region public Method
		public FhirString? Comment
{
get { return _comment; }
set {
_comment= value;
OnPropertyChanged("comment", value);
}
}

public ReferenceType? Link
{
get { return _link; }
set {
_link= value;
OnPropertyChanged("link", value);
}
}


		#endregion
		#region Constructor
		public  DiagnosticReportMedia() { }
		public  DiagnosticReportMedia(string value) : base(value) { }
		public  DiagnosticReportMedia(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class DiagnosticReportEffectiveChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public DiagnosticReportEffectiveChoice(JsonObject value) : base("effective", value, _supportType)
        {
        }
        public DiagnosticReportEffectiveChoice(IComplexType? value) : base("effective", value)
        {
        }
        public DiagnosticReportEffectiveChoice(IPrimitiveType? value) : base("effective", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"effective".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
