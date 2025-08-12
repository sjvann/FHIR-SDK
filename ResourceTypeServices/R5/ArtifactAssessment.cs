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
    public class ArtifactAssessment : ResourceType<ArtifactAssessment>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirString? _title;
private ArtifactAssessmentCiteAsChoice? _citeAs;
private FhirDateTime? _date;
private FhirMarkdown? _copyright;
private FhirDate? _approvalDate;
private FhirDate? _lastReviewDate;
private ArtifactAssessmentArtifactChoice? _artifact;
private List<ArtifactAssessmentContent>? _content;
private FhirCode? _workflowStatus;
private FhirCode? _disposition;

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

public FhirString? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
}
}

public ArtifactAssessmentCiteAsChoice? CiteAs
{
get { return _citeAs; }
set {
_citeAs= value;
OnPropertyChanged("citeAs", value);
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

public FhirMarkdown? Copyright
{
get { return _copyright; }
set {
_copyright= value;
OnPropertyChanged("copyright", value);
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

public ArtifactAssessmentArtifactChoice? Artifact
{
get { return _artifact; }
set {
_artifact= value;
OnPropertyChanged("artifact", value);
}
}

public List<ArtifactAssessmentContent>? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}

public FhirCode? WorkflowStatus
{
get { return _workflowStatus; }
set {
_workflowStatus= value;
OnPropertyChanged("workflowStatus", value);
}
}

public FhirCode? Disposition
{
get { return _disposition; }
set {
_disposition= value;
OnPropertyChanged("disposition", value);
}
}


		#endregion
		#region Constructor
		public  ArtifactAssessment() { }
		public  ArtifactAssessment(string value) : base(value) { }
		public  ArtifactAssessment(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ArtifactAssessmentContent : BackboneElementType<ArtifactAssessmentContent>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _informationType;
private FhirMarkdown? _summary;
private CodeableConcept? _type;
private List<CodeableConcept>? _classifier;
private Quantity? _quantity;
private ReferenceType? _author;
private List<FhirUri>? _path;
private List<RelatedArtifact>? _relatedArtifact;
private FhirBoolean? _freeToShare;

		#endregion
		#region public Method
		public FhirCode? InformationType
{
get { return _informationType; }
set {
_informationType= value;
OnPropertyChanged("informationType", value);
}
}

public FhirMarkdown? Summary
{
get { return _summary; }
set {
_summary= value;
OnPropertyChanged("summary", value);
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

public List<CodeableConcept>? Classifier
{
get { return _classifier; }
set {
_classifier= value;
OnPropertyChanged("classifier", value);
}
}

public Quantity? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
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

public List<FhirUri>? Path
{
get { return _path; }
set {
_path= value;
OnPropertyChanged("path", value);
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

public FhirBoolean? FreeToShare
{
get { return _freeToShare; }
set {
_freeToShare= value;
OnPropertyChanged("freeToShare", value);
}
}


		#endregion
		#region Constructor
		public  ArtifactAssessmentContent() { }
		public  ArtifactAssessmentContent(string value) : base(value) { }
		public  ArtifactAssessmentContent(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ArtifactAssessmentCiteAsChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(Citation)","markdown"
        ];
        public ArtifactAssessmentCiteAsChoice(string dataType, JsonValue? value) : base(dataType, value) { }
        public ArtifactAssessmentCiteAsChoice(JsonObject value) : base("citeAs", value, _supportType)
        {
        }
        public ArtifactAssessmentCiteAsChoice(IComplexType? value) : base("citeAs", value)
        {
        }
        public ArtifactAssessmentCiteAsChoice(IPrimitiveType? value) : base("citeAs", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"citeAs".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ArtifactAssessmentArtifactChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(Resource)","canonicaluri"
        ];
         public ArtifactAssessmentArtifactChoice(string dataType, JsonValue? value) : base(dataType, value) { }
        public ArtifactAssessmentArtifactChoice(JsonObject value) : base("artifact", value, _supportType)
        {
        }
        public ArtifactAssessmentArtifactChoice(IComplexType? value) : base("artifact", value)
        {
        }
        public ArtifactAssessmentArtifactChoice(IPrimitiveType? value) : base("artifact", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"artifact".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
