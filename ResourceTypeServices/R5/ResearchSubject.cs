using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;

namespace ResourceTypeServices.R5
{
    public class ResearchSubject : ResourceType<ResearchSubject>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<ResearchSubjectProgress>? _progress;
private Period? _period;
private ReferenceType? _study;
private ReferenceType? _subject;
private FhirId? _assignedComparisonGroup;
private FhirId? _actualComparisonGroup;
private List<ReferenceType>? _consent;

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

public List<ResearchSubjectProgress>? Progress
{
get { return _progress; }
set {
_progress= value;
OnPropertyChanged("progress", value);
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

public ReferenceType? Study
{
get { return _study; }
set {
_study= value;
OnPropertyChanged("study", value);
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

public FhirId? AssignedComparisonGroup
{
get { return _assignedComparisonGroup; }
set {
_assignedComparisonGroup= value;
OnPropertyChanged("assignedComparisonGroup", value);
}
}

public FhirId? ActualComparisonGroup
{
get { return _actualComparisonGroup; }
set {
_actualComparisonGroup= value;
OnPropertyChanged("actualComparisonGroup", value);
}
}

public List<ReferenceType>? Consent
{
get { return _consent; }
set {
_consent= value;
OnPropertyChanged("consent", value);
}
}


		#endregion
		#region Constructor
		public  ResearchSubject() { }
		public  ResearchSubject(string value) : base(value) { }
		public  ResearchSubject(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ResearchSubjectProgress : BackboneElementType<ResearchSubjectProgress>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private CodeableConcept? _subjectState;
private CodeableConcept? _milestone;
private CodeableConcept? _reason;
private FhirDateTime? _startDate;
private FhirDateTime? _endDate;

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

public CodeableConcept? SubjectState
{
get { return _subjectState; }
set {
_subjectState= value;
OnPropertyChanged("subjectState", value);
}
}

public CodeableConcept? Milestone
{
get { return _milestone; }
set {
_milestone= value;
OnPropertyChanged("milestone", value);
}
}

public CodeableConcept? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public FhirDateTime? StartDate
{
get { return _startDate; }
set {
_startDate= value;
OnPropertyChanged("startDate", value);
}
}

public FhirDateTime? EndDate
{
get { return _endDate; }
set {
_endDate= value;
OnPropertyChanged("endDate", value);
}
}


		#endregion
		#region Constructor
		public  ResearchSubjectProgress() { }
		public  ResearchSubjectProgress(string value) : base(value) { }
		public  ResearchSubjectProgress(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
