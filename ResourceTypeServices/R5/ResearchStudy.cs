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
    public class ResearchStudy : ResourceType<ResearchStudy>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private FhirString? _name;
private FhirString? _title;
private List<ResearchStudyLabel>? _label;
private List<ReferenceType>? _protocol;
private List<ReferenceType>? _partOf;
private List<RelatedArtifact>? _relatedArtifact;
private FhirDateTime? _date;
private FhirCode? _status;
private CodeableConcept? _primaryPurposeType;
private CodeableConcept? _phase;
private List<CodeableConcept>? _studyDesign;
private List<CodeableReference>? _focus;
private List<CodeableConcept>? _condition;
private List<CodeableConcept>? _keyword;
private List<CodeableConcept>? _region;
private FhirMarkdown? _descriptionSummary;
private FhirMarkdown? _description;
private Period? _period;
private List<ReferenceType>? _site;
private List<Annotation>? _note;
private List<CodeableConcept>? _classifier;
private List<ResearchStudyAssociatedParty>? _associatedParty;
private List<ResearchStudyProgressStatus>? _progressStatus;
private CodeableConcept? _whyStopped;
private ResearchStudyRecruitment? _recruitment;
private List<ResearchStudyComparisonGroup>? _comparisonGroup;
private List<ResearchStudyObjective>? _objective;
private List<ResearchStudyOutcomeMeasure>? _outcomeMeasure;
private List<ReferenceType>? _result;

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

public List<ResearchStudyLabel>? Label
{
get { return _label; }
set {
_label= value;
OnPropertyChanged("label", value);
}
}

public List<ReferenceType>? Protocol
{
get { return _protocol; }
set {
_protocol= value;
OnPropertyChanged("protocol", value);
}
}

public List<ReferenceType>? PartOf
{
get { return _partOf; }
set {
_partOf= value;
OnPropertyChanged("partOf", value);
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

public FhirDateTime? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
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

public CodeableConcept? PrimaryPurposeType
{
get { return _primaryPurposeType; }
set {
_primaryPurposeType= value;
OnPropertyChanged("primaryPurposeType", value);
}
}

public CodeableConcept? Phase
{
get { return _phase; }
set {
_phase= value;
OnPropertyChanged("phase", value);
}
}

public List<CodeableConcept>? StudyDesign
{
get { return _studyDesign; }
set {
_studyDesign= value;
OnPropertyChanged("studyDesign", value);
}
}

public List<CodeableReference>? Focus
{
get { return _focus; }
set {
_focus= value;
OnPropertyChanged("focus", value);
}
}

public List<CodeableConcept>? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
}
}

public List<CodeableConcept>? Keyword
{
get { return _keyword; }
set {
_keyword= value;
OnPropertyChanged("keyword", value);
}
}

public List<CodeableConcept>? Region
{
get { return _region; }
set {
_region= value;
OnPropertyChanged("region", value);
}
}

public FhirMarkdown? DescriptionSummary
{
get { return _descriptionSummary; }
set {
_descriptionSummary= value;
OnPropertyChanged("descriptionSummary", value);
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

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public List<ReferenceType>? Site
{
get { return _site; }
set {
_site= value;
OnPropertyChanged("site", value);
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

public List<CodeableConcept>? Classifier
{
get { return _classifier; }
set {
_classifier= value;
OnPropertyChanged("classifier", value);
}
}

public List<ResearchStudyAssociatedParty>? AssociatedParty
{
get { return _associatedParty; }
set {
_associatedParty= value;
OnPropertyChanged("associatedParty", value);
}
}

public List<ResearchStudyProgressStatus>? ProgressStatus
{
get { return _progressStatus; }
set {
_progressStatus= value;
OnPropertyChanged("progressStatus", value);
}
}

public CodeableConcept? WhyStopped
{
get { return _whyStopped; }
set {
_whyStopped= value;
OnPropertyChanged("whyStopped", value);
}
}

public ResearchStudyRecruitment? Recruitment
{
get { return _recruitment; }
set {
_recruitment= value;
OnPropertyChanged("recruitment", value);
}
}

public List<ResearchStudyComparisonGroup>? ComparisonGroup
{
get { return _comparisonGroup; }
set {
_comparisonGroup= value;
OnPropertyChanged("comparisonGroup", value);
}
}

public List<ResearchStudyObjective>? Objective
{
get { return _objective; }
set {
_objective= value;
OnPropertyChanged("objective", value);
}
}

public List<ResearchStudyOutcomeMeasure>? OutcomeMeasure
{
get { return _outcomeMeasure; }
set {
_outcomeMeasure= value;
OnPropertyChanged("outcomeMeasure", value);
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


		#endregion
		#region Constructor
		public  ResearchStudy() { }
		public  ResearchStudy(string value) : base(value) { }
		public  ResearchStudy(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ResearchStudyLabel : BackboneElementType<ResearchStudyLabel>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private FhirString? _value;

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
		public  ResearchStudyLabel() { }
		public  ResearchStudyLabel(string value) : base(value) { }
		public  ResearchStudyLabel(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ResearchStudyAssociatedParty : BackboneElementType<ResearchStudyAssociatedParty>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _name;
private CodeableConcept? _role;
private List<Period>? _period;
private List<CodeableConcept>? _classifier;
private ReferenceType? _party;

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

public CodeableConcept? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}

public List<Period>? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public List<CodeableConcept>? Classifier
{
get { return _classifier; }
set {
_classifier= value;
OnPropertyChanged("classifier", value);
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
		public  ResearchStudyAssociatedParty() { }
		public  ResearchStudyAssociatedParty(string value) : base(value) { }
		public  ResearchStudyAssociatedParty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ResearchStudyProgressStatus : BackboneElementType<ResearchStudyProgressStatus>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _state;
private FhirBoolean? _actual;
private Period? _period;

		#endregion
		#region public Method
		public CodeableConcept? State
{
get { return _state; }
set {
_state= value;
OnPropertyChanged("state", value);
}
}

public FhirBoolean? Actual
{
get { return _actual; }
set {
_actual= value;
OnPropertyChanged("actual", value);
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
		public  ResearchStudyProgressStatus() { }
		public  ResearchStudyProgressStatus(string value) : base(value) { }
		public  ResearchStudyProgressStatus(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ResearchStudyRecruitment : BackboneElementType<ResearchStudyRecruitment>, IBackboneElementType
	{

		#region Private Method
		private FhirUnsignedInt? _targetNumber;
private FhirUnsignedInt? _actualNumber;
private ReferenceType? _eligibility;
private ReferenceType? _actualGroup;

		#endregion
		#region public Method
		public FhirUnsignedInt? TargetNumber
{
get { return _targetNumber; }
set {
_targetNumber= value;
OnPropertyChanged("targetNumber", value);
}
}

public FhirUnsignedInt? ActualNumber
{
get { return _actualNumber; }
set {
_actualNumber= value;
OnPropertyChanged("actualNumber", value);
}
}

public ReferenceType? Eligibility
{
get { return _eligibility; }
set {
_eligibility= value;
OnPropertyChanged("eligibility", value);
}
}

public ReferenceType? ActualGroup
{
get { return _actualGroup; }
set {
_actualGroup= value;
OnPropertyChanged("actualGroup", value);
}
}


		#endregion
		#region Constructor
		public  ResearchStudyRecruitment() { }
		public  ResearchStudyRecruitment(string value) : base(value) { }
		public  ResearchStudyRecruitment(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ResearchStudyComparisonGroup : BackboneElementType<ResearchStudyComparisonGroup>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _linkId;
private FhirString? _name;
private CodeableConcept? _type;
private FhirMarkdown? _description;
private List<ReferenceType>? _intendedExposure;
private ReferenceType? _observedGroup;

		#endregion
		#region public Method
		public FhirId? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
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

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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

public List<ReferenceType>? IntendedExposure
{
get { return _intendedExposure; }
set {
_intendedExposure= value;
OnPropertyChanged("intendedExposure", value);
}
}

public ReferenceType? ObservedGroup
{
get { return _observedGroup; }
set {
_observedGroup= value;
OnPropertyChanged("observedGroup", value);
}
}


		#endregion
		#region Constructor
		public  ResearchStudyComparisonGroup() { }
		public  ResearchStudyComparisonGroup(string value) : base(value) { }
		public  ResearchStudyComparisonGroup(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ResearchStudyObjective : BackboneElementType<ResearchStudyObjective>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _name;
private CodeableConcept? _type;
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

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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
		public  ResearchStudyObjective() { }
		public  ResearchStudyObjective(string value) : base(value) { }
		public  ResearchStudyObjective(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ResearchStudyOutcomeMeasure : BackboneElementType<ResearchStudyOutcomeMeasure>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _name;
private List<CodeableConcept>? _type;
private FhirMarkdown? _description;
private ReferenceType? _reference;

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

public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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
		public  ResearchStudyOutcomeMeasure() { }
		public  ResearchStudyOutcomeMeasure(string value) : base(value) { }
		public  ResearchStudyOutcomeMeasure(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
