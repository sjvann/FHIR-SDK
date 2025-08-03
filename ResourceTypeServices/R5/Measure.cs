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
    public class Measure : ResourceType<Measure>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private MeasureVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private FhirString? _subtitle;
private FhirCode? _status;
private FhirBoolean? _experimental;
private MeasureSubjectChoice? _subject;
private FhirCode? _basis;
private FhirDateTime? _date;
private FhirString? _publisher;
private List<ContactDetail>? _contact;
private FhirMarkdown? _description;
private List<UsageContext>? _useContext;
private List<CodeableConcept>? _jurisdiction;
private FhirMarkdown? _purpose;
private FhirMarkdown? _usage;
private FhirMarkdown? _copyright;
private FhirString? _copyrightLabel;
private FhirDate? _approvalDate;
private FhirDate? _lastReviewDate;
private Period? _effectivePeriod;
private List<CodeableConcept>? _topic;
private List<ContactDetail>? _author;
private List<ContactDetail>? _editor;
private List<ContactDetail>? _reviewer;
private List<ContactDetail>? _endorser;
private List<RelatedArtifact>? _relatedArtifact;
private List<FhirCanonical>? _library;
private FhirMarkdown? _disclaimer;
private CodeableConcept? _scoring;
private CodeableConcept? _scoringUnit;
private CodeableConcept? _compositeScoring;
private List<CodeableConcept>? _type;
private FhirMarkdown? _riskAdjustment;
private FhirMarkdown? _rateAggregation;
private FhirMarkdown? _rationale;
private FhirMarkdown? _clinicalRecommendationStatement;
private CodeableConcept? _improvementNotation;
private List<MeasureTerm>? _term;
private FhirMarkdown? _guidance;
private List<MeasureGroup>? _group;
private List<MeasureSupplementalData>? _supplementalData;

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

public MeasureVersionAlgorithmChoice? VersionAlgorithm
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

public FhirString? Subtitle
{
get { return _subtitle; }
set {
_subtitle= value;
OnPropertyChanged("subtitle", value);
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

public MeasureSubjectChoice? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public FhirCode? Basis
{
get { return _basis; }
set {
_basis= value;
OnPropertyChanged("basis", value);
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

public FhirMarkdown? Usage
{
get { return _usage; }
set {
_usage= value;
OnPropertyChanged("usage", value);
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

public FhirDate? ApprovalDate
{
get { return _approvalDate; }
set {
_approvalDate= value;
OnPropertyChanged("approvalDate", value);
}
}

public FhirDate? LastReviewDate
{
get { return _lastReviewDate; }
set {
_lastReviewDate= value;
OnPropertyChanged("lastReviewDate", value);
}
}

public Period? EffectivePeriod
{
get { return _effectivePeriod; }
set {
_effectivePeriod= value;
OnPropertyChanged("effectivePeriod", value);
}
}

public List<CodeableConcept>? Topic
{
get { return _topic; }
set {
_topic= value;
OnPropertyChanged("topic", value);
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

public List<RelatedArtifact>? RelatedArtifact
{
get { return _relatedArtifact; }
set {
_relatedArtifact= value;
OnPropertyChanged("relatedArtifact", value);
}
}

public List<FhirCanonical>? Library
{
get { return _library; }
set {
_library= value;
OnPropertyChanged("library", value);
}
}

public FhirMarkdown? Disclaimer
{
get { return _disclaimer; }
set {
_disclaimer= value;
OnPropertyChanged("disclaimer", value);
}
}

public CodeableConcept? Scoring
{
get { return _scoring; }
set {
_scoring= value;
OnPropertyChanged("scoring", value);
}
}

public CodeableConcept? ScoringUnit
{
get { return _scoringUnit; }
set {
_scoringUnit= value;
OnPropertyChanged("scoringUnit", value);
}
}

public CodeableConcept? CompositeScoring
{
get { return _compositeScoring; }
set {
_compositeScoring= value;
OnPropertyChanged("compositeScoring", value);
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

public FhirMarkdown? RiskAdjustment
{
get { return _riskAdjustment; }
set {
_riskAdjustment= value;
OnPropertyChanged("riskAdjustment", value);
}
}

public FhirMarkdown? RateAggregation
{
get { return _rateAggregation; }
set {
_rateAggregation= value;
OnPropertyChanged("rateAggregation", value);
}
}

public FhirMarkdown? Rationale
{
get { return _rationale; }
set {
_rationale= value;
OnPropertyChanged("rationale", value);
}
}

public FhirMarkdown? ClinicalRecommendationStatement
{
get { return _clinicalRecommendationStatement; }
set {
_clinicalRecommendationStatement= value;
OnPropertyChanged("clinicalRecommendationStatement", value);
}
}

public CodeableConcept? ImprovementNotation
{
get { return _improvementNotation; }
set {
_improvementNotation= value;
OnPropertyChanged("improvementNotation", value);
}
}

public List<MeasureTerm>? Term
{
get { return _term; }
set {
_term= value;
OnPropertyChanged("term", value);
}
}

public FhirMarkdown? Guidance
{
get { return _guidance; }
set {
_guidance= value;
OnPropertyChanged("guidance", value);
}
}

public List<MeasureGroup>? Group
{
get { return _group; }
set {
_group= value;
OnPropertyChanged("group", value);
}
}

public List<MeasureSupplementalData>? SupplementalData
{
get { return _supplementalData; }
set {
_supplementalData= value;
OnPropertyChanged("supplementalData", value);
}
}


		#endregion
		#region Constructor
		public  Measure() { }
		public  Measure(string value) : base(value) { }
		public  Measure(JsonNode? source) : base(source) { }
		#endregion
	}
		public class MeasureTerm : BackboneElementType<MeasureTerm>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private FhirMarkdown? _definition;

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

public FhirMarkdown? Definition
{
get { return _definition; }
set {
_definition= value;
OnPropertyChanged("definition", value);
}
}


		#endregion
		#region Constructor
		public  MeasureTerm() { }
		public  MeasureTerm(string value) : base(value) { }
		public  MeasureTerm(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MeasureGroupPopulation : BackboneElementType<MeasureGroupPopulation>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private CodeableConcept? _code;
private FhirMarkdown? _description;
private ExpressionType? _criteria;
private ReferenceType? _groupDefinition;
private FhirString? _inputPopulationId;
private CodeableConcept? _aggregateMethod;

		#endregion
		#region public Method
		public FhirString? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
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

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public ExpressionType? Criteria
{
get { return _criteria; }
set {
_criteria= value;
OnPropertyChanged("criteria", value);
}
}

public ReferenceType? GroupDefinition
{
get { return _groupDefinition; }
set {
_groupDefinition= value;
OnPropertyChanged("groupDefinition", value);
}
}

public FhirString? InputPopulationId
{
get { return _inputPopulationId; }
set {
_inputPopulationId= value;
OnPropertyChanged("inputPopulationId", value);
}
}

public CodeableConcept? AggregateMethod
{
get { return _aggregateMethod; }
set {
_aggregateMethod= value;
OnPropertyChanged("aggregateMethod", value);
}
}


		#endregion
		#region Constructor
		public  MeasureGroupPopulation() { }
		public  MeasureGroupPopulation(string value) : base(value) { }
		public  MeasureGroupPopulation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MeasureGroupStratifierComponent : BackboneElementType<MeasureGroupStratifierComponent>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private CodeableConcept? _code;
private FhirMarkdown? _description;
private ExpressionType? _criteria;
private ReferenceType? _groupDefinition;

		#endregion
		#region public Method
		public FhirString? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
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

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public ExpressionType? Criteria
{
get { return _criteria; }
set {
_criteria= value;
OnPropertyChanged("criteria", value);
}
}

public ReferenceType? GroupDefinition
{
get { return _groupDefinition; }
set {
_groupDefinition= value;
OnPropertyChanged("groupDefinition", value);
}
}


		#endregion
		#region Constructor
		public  MeasureGroupStratifierComponent() { }
		public  MeasureGroupStratifierComponent(string value) : base(value) { }
		public  MeasureGroupStratifierComponent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MeasureGroupStratifier : BackboneElementType<MeasureGroupStratifier>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private CodeableConcept? _code;
private FhirMarkdown? _description;
private ExpressionType? _criteria;
private ReferenceType? _groupDefinition;
private List<MeasureGroupStratifierComponent>? _component;

		#endregion
		#region public Method
		public FhirString? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
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

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public ExpressionType? Criteria
{
get { return _criteria; }
set {
_criteria= value;
OnPropertyChanged("criteria", value);
}
}

public ReferenceType? GroupDefinition
{
get { return _groupDefinition; }
set {
_groupDefinition= value;
OnPropertyChanged("groupDefinition", value);
}
}

public List<MeasureGroupStratifierComponent>? Component
{
get { return _component; }
set {
_component= value;
OnPropertyChanged("component", value);
}
}


		#endregion
		#region Constructor
		public  MeasureGroupStratifier() { }
		public  MeasureGroupStratifier(string value) : base(value) { }
		public  MeasureGroupStratifier(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MeasureGroup : BackboneElementType<MeasureGroup>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private CodeableConcept? _code;
private FhirMarkdown? _description;
private List<CodeableConcept>? _type;
private MeasureGroupSubjectChoice? _subject;
private FhirCode? _basis;
private CodeableConcept? _scoring;
private CodeableConcept? _scoringUnit;
private FhirMarkdown? _rateAggregation;
private CodeableConcept? _improvementNotation;
private List<FhirCanonical>? _library;
private List<MeasureGroupPopulation>? _population;
private List<MeasureGroupStratifier>? _stratifier;

		#endregion
		#region public Method
		public FhirString? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
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

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
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

public MeasureGroupSubjectChoice? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public FhirCode? Basis
{
get { return _basis; }
set {
_basis= value;
OnPropertyChanged("basis", value);
}
}

public CodeableConcept? Scoring
{
get { return _scoring; }
set {
_scoring= value;
OnPropertyChanged("scoring", value);
}
}

public CodeableConcept? ScoringUnit
{
get { return _scoringUnit; }
set {
_scoringUnit= value;
OnPropertyChanged("scoringUnit", value);
}
}

public FhirMarkdown? RateAggregation
{
get { return _rateAggregation; }
set {
_rateAggregation= value;
OnPropertyChanged("rateAggregation", value);
}
}

public CodeableConcept? ImprovementNotation
{
get { return _improvementNotation; }
set {
_improvementNotation= value;
OnPropertyChanged("improvementNotation", value);
}
}

public List<FhirCanonical>? Library
{
get { return _library; }
set {
_library= value;
OnPropertyChanged("library", value);
}
}

public List<MeasureGroupPopulation>? Population
{
get { return _population; }
set {
_population= value;
OnPropertyChanged("population", value);
}
}

public List<MeasureGroupStratifier>? Stratifier
{
get { return _stratifier; }
set {
_stratifier= value;
OnPropertyChanged("stratifier", value);
}
}


		#endregion
		#region Constructor
		public  MeasureGroup() { }
		public  MeasureGroup(string value) : base(value) { }
		public  MeasureGroup(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MeasureSupplementalData : BackboneElementType<MeasureSupplementalData>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private CodeableConcept? _code;
private List<CodeableConcept>? _usage;
private FhirMarkdown? _description;
private ExpressionType? _criteria;

		#endregion
		#region public Method
		public FhirString? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
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

public List<CodeableConcept>? Usage
{
get { return _usage; }
set {
_usage= value;
OnPropertyChanged("usage", value);
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

public ExpressionType? Criteria
{
get { return _criteria; }
set {
_criteria= value;
OnPropertyChanged("criteria", value);
}
}


		#endregion
		#region Constructor
		public  MeasureSupplementalData() { }
		public  MeasureSupplementalData(string value) : base(value) { }
		public  MeasureSupplementalData(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class MeasureVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public MeasureVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public MeasureVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public MeasureVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MeasureSubjectChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Group)"
        ];

        public MeasureSubjectChoice(JsonObject value) : base("subject", value, _supportType)
        {
        }
        public MeasureSubjectChoice(IComplexType? value) : base("subject", value)
        {
        }
        public MeasureSubjectChoice(IPrimitiveType? value) : base("subject", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"subject".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MeasureGroupSubjectChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Group)"
        ];

        public MeasureGroupSubjectChoice(JsonObject value) : base("subject", value, _supportType)
        {
        }
        public MeasureGroupSubjectChoice(IComplexType? value) : base("subject", value)
        {
        }
        public MeasureGroupSubjectChoice(IPrimitiveType? value) : base("subject", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"subject".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
