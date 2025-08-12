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
    public class Citation : ResourceType<Citation>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private CitationVersionAlgorithmChoice? _versionAlgorithm;
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
private FhirDate? _approvalDate;
private FhirDate? _lastReviewDate;
private Period? _effectivePeriod;
private List<ContactDetail>? _author;
private List<ContactDetail>? _editor;
private List<ContactDetail>? _reviewer;
private List<ContactDetail>? _endorser;
private List<CitationSummary>? _summary;
private List<CitationClassification>? _classification;
private List<Annotation>? _note;
private List<CodeableConcept>? _currentState;
private List<CitationStatusDate>? _statusDate;
private List<RelatedArtifact>? _relatedArtifact;
private CitationCitedArtifact? _citedArtifact;

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

public CitationVersionAlgorithmChoice? VersionAlgorithm
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

public List<CitationSummary>? Summary
{
get { return _summary; }
set {
_summary= value;
OnPropertyChanged("summary", value);
}
}

public List<CitationClassification>? Classification
{
get { return _classification; }
set {
_classification= value;
OnPropertyChanged("classification", value);
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

public List<CodeableConcept>? CurrentState
{
get { return _currentState; }
set {
_currentState= value;
OnPropertyChanged("currentState", value);
}
}

public List<CitationStatusDate>? StatusDate
{
get { return _statusDate; }
set {
_statusDate= value;
OnPropertyChanged("statusDate", value);
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

public CitationCitedArtifact? CitedArtifact
{
get { return _citedArtifact; }
set {
_citedArtifact= value;
OnPropertyChanged("citedArtifact", value);
}
}


		#endregion
		#region Constructor
		public  Citation() { }
		public  Citation(string value) : base(value) { }
		public  Citation(JsonNode? source) : base(source) { }
		#endregion
	}
		public class CitationSummary : BackboneElementType<CitationSummary>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _style;

		#endregion
		#region public Method
		public CodeableConcept? Style
{
get { return _style; }
set {
_style= value;
OnPropertyChanged("style", value);
}
}


		#endregion
		#region Constructor
		public  CitationSummary() { }
		public  CitationSummary(string value) : base(value) { }
		public  CitationSummary(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationClassification : BackboneElementType<CitationClassification>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private List<CodeableConcept>? _classifier;

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

public List<CodeableConcept>? Classifier
{
get { return _classifier; }
set {
_classifier= value;
OnPropertyChanged("classifier", value);
}
}


		#endregion
		#region Constructor
		public  CitationClassification() { }
		public  CitationClassification(string value) : base(value) { }
		public  CitationClassification(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationStatusDate : BackboneElementType<CitationStatusDate>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _activity;
private FhirBoolean? _actual;
private Period? _period;

		#endregion
		#region public Method
		public CodeableConcept? Activity
{
get { return _activity; }
set {
_activity= value;
OnPropertyChanged("activity", value);
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
		public  CitationStatusDate() { }
		public  CitationStatusDate(string value) : base(value) { }
		public  CitationStatusDate(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactVersion : BackboneElementType<CitationCitedArtifactVersion>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _value;
private ReferenceType? _baseCitation;

		#endregion
		#region public Method
		public FhirString? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public ReferenceType? BaseCitation
{
get { return _baseCitation; }
set {
_baseCitation= value;
OnPropertyChanged("baseCitation", value);
}
}


		#endregion
		#region Constructor
		public  CitationCitedArtifactVersion() { }
		public  CitationCitedArtifactVersion(string value) : base(value) { }
		public  CitationCitedArtifactVersion(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactStatusDate : BackboneElementType<CitationCitedArtifactStatusDate>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _activity;
private FhirBoolean? _actual;
private Period? _period;

		#endregion
		#region public Method
		public CodeableConcept? Activity
{
get { return _activity; }
set {
_activity= value;
OnPropertyChanged("activity", value);
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
		public  CitationCitedArtifactStatusDate() { }
		public  CitationCitedArtifactStatusDate(string value) : base(value) { }
		public  CitationCitedArtifactStatusDate(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactTitle : BackboneElementType<CitationCitedArtifactTitle>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableConcept>? _type;
private CodeableConcept? _language;

		#endregion
		#region public Method
		public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public CodeableConcept? Language
{
get { return _language; }
set {
_language= value;
OnPropertyChanged("language", value);
}
}


		#endregion
		#region Constructor
		public  CitationCitedArtifactTitle() { }
		public  CitationCitedArtifactTitle(string value) : base(value) { }
		public  CitationCitedArtifactTitle(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactAbstract : BackboneElementType<CitationCitedArtifactAbstract>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private CodeableConcept? _language;
private FhirMarkdown? _copyright;

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

public CodeableConcept? Language
{
get { return _language; }
set {
_language= value;
OnPropertyChanged("language", value);
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


		#endregion
		#region Constructor
		public  CitationCitedArtifactAbstract() { }
		public  CitationCitedArtifactAbstract(string value) : base(value) { }
		public  CitationCitedArtifactAbstract(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactPart : BackboneElementType<CitationCitedArtifactPart>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private FhirString? _value;
private ReferenceType? _baseCitation;

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

public ReferenceType? BaseCitation
{
get { return _baseCitation; }
set {
_baseCitation= value;
OnPropertyChanged("baseCitation", value);
}
}


		#endregion
		#region Constructor
		public  CitationCitedArtifactPart() { }
		public  CitationCitedArtifactPart(string value) : base(value) { }
		public  CitationCitedArtifactPart(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactRelatesTo : BackboneElementType<CitationCitedArtifactRelatesTo>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _type;
private List<CodeableConcept>? _classifier;
private FhirString? _label;
private FhirString? _display;
private FhirMarkdown? _citation;
private Attachment? _document;
private FhirCanonical? _resource;
private ReferenceType? _resourceReference;

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

public List<CodeableConcept>? Classifier
{
get { return _classifier; }
set {
_classifier= value;
OnPropertyChanged("classifier", value);
}
}

public FhirString? Label
{
get { return _label; }
set {
_label= value;
OnPropertyChanged("label", value);
}
}

public FhirString? Display
{
get { return _display; }
set {
_display= value;
OnPropertyChanged("display", value);
}
}

public FhirMarkdown? Citation
{
get { return _citation; }
set {
_citation= value;
OnPropertyChanged("citation", value);
}
}

public Attachment? Document
{
get { return _document; }
set {
_document= value;
OnPropertyChanged("document", value);
}
}

public FhirCanonical? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
}
}

public ReferenceType? ResourceReference
{
get { return _resourceReference; }
set {
_resourceReference= value;
OnPropertyChanged("resourceReference", value);
}
}


		#endregion
		#region Constructor
		public  CitationCitedArtifactRelatesTo() { }
		public  CitationCitedArtifactRelatesTo(string value) : base(value) { }
		public  CitationCitedArtifactRelatesTo(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactPublicationFormPublishedIn : BackboneElementType<CitationCitedArtifactPublicationFormPublishedIn>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private List<Identifier>? _identifier;
private FhirString? _title;
private ReferenceType? _publisher;
private FhirString? _publisherLocation;

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

public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
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

public ReferenceType? Publisher
{
get { return _publisher; }
set {
_publisher= value;
OnPropertyChanged("publisher", value);
}
}

public FhirString? PublisherLocation
{
get { return _publisherLocation; }
set {
_publisherLocation= value;
OnPropertyChanged("publisherLocation", value);
}
}


		#endregion
		#region Constructor
		public  CitationCitedArtifactPublicationFormPublishedIn() { }
		public  CitationCitedArtifactPublicationFormPublishedIn(string value) : base(value) { }
		public  CitationCitedArtifactPublicationFormPublishedIn(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactPublicationForm : BackboneElementType<CitationCitedArtifactPublicationForm>, IBackboneElementType
	{

		#region Private Method
		private CitationCitedArtifactPublicationFormPublishedIn? _publishedIn;
private CodeableConcept? _citedMedium;
private FhirString? _volume;
private FhirString? _issue;
private FhirDateTime? _articleDate;
private FhirString? _publicationDateText;
private FhirString? _publicationDateSeason;
private FhirDateTime? _lastRevisionDate;
private List<CodeableConcept>? _language;
private FhirString? _accessionNumber;
private FhirString? _pageString;
private FhirString? _firstPage;
private FhirString? _lastPage;
private FhirString? _pageCount;
private FhirMarkdown? _copyright;

		#endregion
		#region public Method
		public CitationCitedArtifactPublicationFormPublishedIn? PublishedIn
{
get { return _publishedIn; }
set {
_publishedIn= value;
OnPropertyChanged("publishedIn", value);
}
}

public CodeableConcept? CitedMedium
{
get { return _citedMedium; }
set {
_citedMedium= value;
OnPropertyChanged("citedMedium", value);
}
}

public FhirString? Volume
{
get { return _volume; }
set {
_volume= value;
OnPropertyChanged("volume", value);
}
}

public FhirString? Issue
{
get { return _issue; }
set {
_issue= value;
OnPropertyChanged("issue", value);
}
}

public FhirDateTime? ArticleDate
{
get { return _articleDate; }
set {
_articleDate= value;
OnPropertyChanged("articleDate", value);
}
}

public FhirString? PublicationDateText
{
get { return _publicationDateText; }
set {
_publicationDateText= value;
OnPropertyChanged("publicationDateText", value);
}
}

public FhirString? PublicationDateSeason
{
get { return _publicationDateSeason; }
set {
_publicationDateSeason= value;
OnPropertyChanged("publicationDateSeason", value);
}
}

public FhirDateTime? LastRevisionDate
{
get { return _lastRevisionDate; }
set {
_lastRevisionDate= value;
OnPropertyChanged("lastRevisionDate", value);
}
}

public List<CodeableConcept>? Language
{
get { return _language; }
set {
_language= value;
OnPropertyChanged("language", value);
}
}

public FhirString? AccessionNumber
{
get { return _accessionNumber; }
set {
_accessionNumber= value;
OnPropertyChanged("accessionNumber", value);
}
}

public FhirString? PageString
{
get { return _pageString; }
set {
_pageString= value;
OnPropertyChanged("pageString", value);
}
}

public FhirString? FirstPage
{
get { return _firstPage; }
set {
_firstPage= value;
OnPropertyChanged("firstPage", value);
}
}

public FhirString? LastPage
{
get { return _lastPage; }
set {
_lastPage= value;
OnPropertyChanged("lastPage", value);
}
}

public FhirString? PageCount
{
get { return _pageCount; }
set {
_pageCount= value;
OnPropertyChanged("pageCount", value);
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


		#endregion
		#region Constructor
		public  CitationCitedArtifactPublicationForm() { }
		public  CitationCitedArtifactPublicationForm(string value) : base(value) { }
		public  CitationCitedArtifactPublicationForm(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactWebLocation : BackboneElementType<CitationCitedArtifactWebLocation>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableConcept>? _classifier;
private FhirUri? _url;

		#endregion
		#region public Method
		public List<CodeableConcept>? Classifier
{
get { return _classifier; }
set {
_classifier= value;
OnPropertyChanged("classifier", value);
}
}

public FhirUri? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
}
}


		#endregion
		#region Constructor
		public  CitationCitedArtifactWebLocation() { }
		public  CitationCitedArtifactWebLocation(string value) : base(value) { }
		public  CitationCitedArtifactWebLocation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactClassification : BackboneElementType<CitationCitedArtifactClassification>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private List<CodeableConcept>? _classifier;
private List<ReferenceType>? _artifactAssessment;

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

public List<CodeableConcept>? Classifier
{
get { return _classifier; }
set {
_classifier= value;
OnPropertyChanged("classifier", value);
}
}

public List<ReferenceType>? ArtifactAssessment
{
get { return _artifactAssessment; }
set {
_artifactAssessment= value;
OnPropertyChanged("artifactAssessment", value);
}
}


		#endregion
		#region Constructor
		public  CitationCitedArtifactClassification() { }
		public  CitationCitedArtifactClassification(string value) : base(value) { }
		public  CitationCitedArtifactClassification(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactContributorshipEntryContributionInstance : BackboneElementType<CitationCitedArtifactContributorshipEntryContributionInstance>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private FhirDateTime? _time;

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

public FhirDateTime? Time
{
get { return _time; }
set {
_time= value;
OnPropertyChanged("time", value);
}
}


		#endregion
		#region Constructor
		public  CitationCitedArtifactContributorshipEntryContributionInstance() { }
		public  CitationCitedArtifactContributorshipEntryContributionInstance(string value) : base(value) { }
		public  CitationCitedArtifactContributorshipEntryContributionInstance(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactContributorshipEntry : BackboneElementType<CitationCitedArtifactContributorshipEntry>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _contributor;
private FhirString? _forenameInitials;
private List<ReferenceType>? _affiliation;
private List<CodeableConcept>? _contributionType;
private CodeableConcept? _role;
private List<CitationCitedArtifactContributorshipEntryContributionInstance>? _contributionInstance;
private FhirBoolean? _correspondingContact;
private FhirPositiveInt? _rankingOrder;

		#endregion
		#region public Method
		public ReferenceType? Contributor
{
get { return _contributor; }
set {
_contributor= value;
OnPropertyChanged("contributor", value);
}
}

public FhirString? ForenameInitials
{
get { return _forenameInitials; }
set {
_forenameInitials= value;
OnPropertyChanged("forenameInitials", value);
}
}

public List<ReferenceType>? Affiliation
{
get { return _affiliation; }
set {
_affiliation= value;
OnPropertyChanged("affiliation", value);
}
}

public List<CodeableConcept>? ContributionType
{
get { return _contributionType; }
set {
_contributionType= value;
OnPropertyChanged("contributionType", value);
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

public List<CitationCitedArtifactContributorshipEntryContributionInstance>? ContributionInstance
{
get { return _contributionInstance; }
set {
_contributionInstance= value;
OnPropertyChanged("contributionInstance", value);
}
}

public FhirBoolean? CorrespondingContact
{
get { return _correspondingContact; }
set {
_correspondingContact= value;
OnPropertyChanged("correspondingContact", value);
}
}

public FhirPositiveInt? RankingOrder
{
get { return _rankingOrder; }
set {
_rankingOrder= value;
OnPropertyChanged("rankingOrder", value);
}
}


		#endregion
		#region Constructor
		public  CitationCitedArtifactContributorshipEntry() { }
		public  CitationCitedArtifactContributorshipEntry(string value) : base(value) { }
		public  CitationCitedArtifactContributorshipEntry(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactContributorshipSummary : BackboneElementType<CitationCitedArtifactContributorshipSummary>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private CodeableConcept? _style;
private CodeableConcept? _source;
private FhirMarkdown? _value;

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

public CodeableConcept? Style
{
get { return _style; }
set {
_style= value;
OnPropertyChanged("style", value);
}
}

public CodeableConcept? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}

public FhirMarkdown? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  CitationCitedArtifactContributorshipSummary() { }
		public  CitationCitedArtifactContributorshipSummary(string value) : base(value) { }
		public  CitationCitedArtifactContributorshipSummary(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifactContributorship : BackboneElementType<CitationCitedArtifactContributorship>, IBackboneElementType
	{

		#region Private Method
		private FhirBoolean? _complete;
private List<CitationCitedArtifactContributorshipEntry>? _entry;
private List<CitationCitedArtifactContributorshipSummary>? _summary;

		#endregion
		#region public Method
		public FhirBoolean? Complete
{
get { return _complete; }
set {
_complete= value;
OnPropertyChanged("complete", value);
}
}

public List<CitationCitedArtifactContributorshipEntry>? Entry
{
get { return _entry; }
set {
_entry= value;
OnPropertyChanged("entry", value);
}
}

public List<CitationCitedArtifactContributorshipSummary>? Summary
{
get { return _summary; }
set {
_summary= value;
OnPropertyChanged("summary", value);
}
}


		#endregion
		#region Constructor
		public  CitationCitedArtifactContributorship() { }
		public  CitationCitedArtifactContributorship(string value) : base(value) { }
		public  CitationCitedArtifactContributorship(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CitationCitedArtifact : BackboneElementType<CitationCitedArtifact>, IBackboneElementType
	{

		#region Private Method
		private List<Identifier>? _identifier;
private List<Identifier>? _relatedIdentifier;
private FhirDateTime? _dateAccessed;
private CitationCitedArtifactVersion? _version;
private List<CodeableConcept>? _currentState;
private List<CitationCitedArtifactStatusDate>? _statusDate;
private List<CitationCitedArtifactTitle>? _title;
private List<CitationCitedArtifactAbstract>? _abstract;
private CitationCitedArtifactPart? _part;
private List<CitationCitedArtifactRelatesTo>? _relatesTo;
private List<CitationCitedArtifactPublicationForm>? _publicationForm;
private List<CitationCitedArtifactWebLocation>? _webLocation;
private List<CitationCitedArtifactClassification>? _classification;
private CitationCitedArtifactContributorship? _contributorship;
private List<Annotation>? _note;

		#endregion
		#region public Method
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

public FhirDateTime? DateAccessed
{
get { return _dateAccessed; }
set {
_dateAccessed= value;
OnPropertyChanged("dateAccessed", value);
}
}

public CitationCitedArtifactVersion? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}

public List<CodeableConcept>? CurrentState
{
get { return _currentState; }
set {
_currentState= value;
OnPropertyChanged("currentState", value);
}
}

public List<CitationCitedArtifactStatusDate>? StatusDate
{
get { return _statusDate; }
set {
_statusDate= value;
OnPropertyChanged("statusDate", value);
}
}

public List<CitationCitedArtifactTitle>? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
}
}

public List<CitationCitedArtifactAbstract>? Abstract
{
get { return _abstract; }
set {
_abstract= value;
OnPropertyChanged("abstract", value);
}
}

public CitationCitedArtifactPart? Part
{
get { return _part; }
set {
_part= value;
OnPropertyChanged("part", value);
}
}

public List<CitationCitedArtifactRelatesTo>? RelatesTo
{
get { return _relatesTo; }
set {
_relatesTo= value;
OnPropertyChanged("relatesTo", value);
}
}

public List<CitationCitedArtifactPublicationForm>? PublicationForm
{
get { return _publicationForm; }
set {
_publicationForm= value;
OnPropertyChanged("publicationForm", value);
}
}

public List<CitationCitedArtifactWebLocation>? WebLocation
{
get { return _webLocation; }
set {
_webLocation= value;
OnPropertyChanged("webLocation", value);
}
}

public List<CitationCitedArtifactClassification>? Classification
{
get { return _classification; }
set {
_classification= value;
OnPropertyChanged("classification", value);
}
}

public CitationCitedArtifactContributorship? Contributorship
{
get { return _contributorship; }
set {
_contributorship= value;
OnPropertyChanged("contributorship", value);
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
		public  CitationCitedArtifact() { }
		public  CitationCitedArtifact(string value) : base(value) { }
		public  CitationCitedArtifact(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class CitationVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public CitationVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public CitationVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public CitationVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
