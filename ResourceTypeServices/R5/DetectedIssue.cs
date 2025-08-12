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
    public class DetectedIssue : ResourceType<DetectedIssue>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<CodeableConcept>? _category;
private CodeableConcept? _code;
private FhirCode? _severity;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private DetectedIssueIdentifiedChoice? _identified;
private ReferenceType? _author;
private List<ReferenceType>? _implicated;
private List<DetectedIssueEvidence>? _evidence;
private FhirMarkdown? _detail;
private FhirUri? _reference;
private List<DetectedIssueMitigation>? _mitigation;

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

public FhirCode? Severity
{
get { return _severity; }
set {
_severity= value;
OnPropertyChanged("severity", value);
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

public DetectedIssueIdentifiedChoice? Identified
{
get { return _identified; }
set {
_identified= value;
OnPropertyChanged("identified", value);
}
}

public ReferenceType? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}

public List<ReferenceType>? Implicated
{
get { return _implicated; }
set {
_implicated= value;
OnPropertyChanged("implicated", value);
}
}

public List<DetectedIssueEvidence>? Evidence
{
get { return _evidence; }
set {
_evidence= value;
OnPropertyChanged("evidence", value);
}
}

public FhirMarkdown? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}

public FhirUri? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}

public List<DetectedIssueMitigation>? Mitigation
{
get { return _mitigation; }
set {
_mitigation= value;
OnPropertyChanged("mitigation", value);
}
}


		#endregion
		#region Constructor
		public  DetectedIssue() { }
		public  DetectedIssue(string value) : base(value) { }
		public  DetectedIssue(JsonNode? source) : base(source) { }
		#endregion
	}
		public class DetectedIssueEvidence : BackboneElementType<DetectedIssueEvidence>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableConcept>? _code;
private List<ReferenceType>? _detail;

		#endregion
		#region public Method
		public List<CodeableConcept>? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<ReferenceType>? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}


		#endregion
		#region Constructor
		public  DetectedIssueEvidence() { }
		public  DetectedIssueEvidence(string value) : base(value) { }
		public  DetectedIssueEvidence(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DetectedIssueMitigation : BackboneElementType<DetectedIssueMitigation>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _action;
private FhirDateTime? _date;
private ReferenceType? _author;
private List<Annotation>? _note;

		#endregion
		#region public Method
		public CodeableConcept? Action
{
get { return _action; }
set {
_action= value;
OnPropertyChanged("action", value);
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

public ReferenceType? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
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
		public  DetectedIssueMitigation() { }
		public  DetectedIssueMitigation(string value) : base(value) { }
		public  DetectedIssueMitigation(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class DetectedIssueIdentifiedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public DetectedIssueIdentifiedChoice(JsonObject value) : base("identified", value, _supportType)
        {
        }
        public DetectedIssueIdentifiedChoice(IComplexType? value) : base("identified", value)
        {
        }
        public DetectedIssueIdentifiedChoice(IPrimitiveType? value) : base("identified", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"identified".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
