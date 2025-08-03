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
    public class GenomicStudy : ResourceType<GenomicStudy>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<CodeableConcept>? _type;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private FhirDateTime? _startDate;
private List<ReferenceType>? _basedOn;
private ReferenceType? _referrer;
private List<ReferenceType>? _interpreter;
private List<CodeableReference>? _reason;
private FhirCanonical? _instantiatesCanonical;
private FhirUri? _instantiatesUri;
private List<Annotation>? _note;
private FhirMarkdown? _description;
private List<GenomicStudyAnalysis>? _analysis;

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

public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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

public FhirDateTime? StartDate
{
get { return _startDate; }
set {
_startDate= value;
OnPropertyChanged("startDate", value);
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

public ReferenceType? Referrer
{
get { return _referrer; }
set {
_referrer= value;
OnPropertyChanged("referrer", value);
}
}

public List<ReferenceType>? Interpreter
{
get { return _interpreter; }
set {
_interpreter= value;
OnPropertyChanged("interpreter", value);
}
}

public List<CodeableReference>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public FhirCanonical? InstantiatesCanonical
{
get { return _instantiatesCanonical; }
set {
_instantiatesCanonical= value;
OnPropertyChanged("instantiatesCanonical", value);
}
}

public FhirUri? InstantiatesUri
{
get { return _instantiatesUri; }
set {
_instantiatesUri= value;
OnPropertyChanged("instantiatesUri", value);
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

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public List<GenomicStudyAnalysis>? Analysis
{
get { return _analysis; }
set {
_analysis= value;
OnPropertyChanged("analysis", value);
}
}


		#endregion
		#region Constructor
		public  GenomicStudy() { }
		public  GenomicStudy(string value) : base(value) { }
		public  GenomicStudy(JsonNode? source) : base(source) { }
		#endregion
	}
		public class GenomicStudyAnalysisInput : BackboneElementType<GenomicStudyAnalysisInput>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _file;
private CodeableConcept? _type;
private GenomicStudyAnalysisInputGeneratedByChoice? _generatedBy;

		#endregion
		#region public Method
		public ReferenceType? File
{
get { return _file; }
set {
_file= value;
OnPropertyChanged("file", value);
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

public GenomicStudyAnalysisInputGeneratedByChoice? GeneratedBy
{
get { return _generatedBy; }
set {
_generatedBy= value;
OnPropertyChanged("generatedBy", value);
}
}


		#endregion
		#region Constructor
		public  GenomicStudyAnalysisInput() { }
		public  GenomicStudyAnalysisInput(string value) : base(value) { }
		public  GenomicStudyAnalysisInput(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class GenomicStudyAnalysisOutput : BackboneElementType<GenomicStudyAnalysisOutput>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _file;
private CodeableConcept? _type;

		#endregion
		#region public Method
		public ReferenceType? File
{
get { return _file; }
set {
_file= value;
OnPropertyChanged("file", value);
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


		#endregion
		#region Constructor
		public  GenomicStudyAnalysisOutput() { }
		public  GenomicStudyAnalysisOutput(string value) : base(value) { }
		public  GenomicStudyAnalysisOutput(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class GenomicStudyAnalysisPerformer : BackboneElementType<GenomicStudyAnalysisPerformer>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _actor;
private CodeableConcept? _role;

		#endregion
		#region public Method
		public ReferenceType? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
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


		#endregion
		#region Constructor
		public  GenomicStudyAnalysisPerformer() { }
		public  GenomicStudyAnalysisPerformer(string value) : base(value) { }
		public  GenomicStudyAnalysisPerformer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class GenomicStudyAnalysisDevice : BackboneElementType<GenomicStudyAnalysisDevice>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _device;
private CodeableConcept? _function;

		#endregion
		#region public Method
		public ReferenceType? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}

public CodeableConcept? Function
{
get { return _function; }
set {
_function= value;
OnPropertyChanged("function", value);
}
}


		#endregion
		#region Constructor
		public  GenomicStudyAnalysisDevice() { }
		public  GenomicStudyAnalysisDevice(string value) : base(value) { }
		public  GenomicStudyAnalysisDevice(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class GenomicStudyAnalysis : BackboneElementType<GenomicStudyAnalysis>, IBackboneElementType
	{

		#region Private Method
		private List<Identifier>? _identifier;
private List<CodeableConcept>? _methodType;
private List<CodeableConcept>? _changeType;
private CodeableConcept? _genomeBuild;
private FhirCanonical? _instantiatesCanonical;
private FhirUri? _instantiatesUri;
private FhirString? _title;
private List<ReferenceType>? _focus;
private List<ReferenceType>? _specimen;
private FhirDateTime? _date;
private List<Annotation>? _note;
private ReferenceType? _protocolPerformed;
private List<ReferenceType>? _regionsStudied;
private List<ReferenceType>? _regionsCalled;
private List<GenomicStudyAnalysisInput>? _input;
private List<GenomicStudyAnalysisOutput>? _output;
private List<GenomicStudyAnalysisPerformer>? _performer;
private List<GenomicStudyAnalysisDevice>? _device;

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

public List<CodeableConcept>? MethodType
{
get { return _methodType; }
set {
_methodType= value;
OnPropertyChanged("methodType", value);
}
}

public List<CodeableConcept>? ChangeType
{
get { return _changeType; }
set {
_changeType= value;
OnPropertyChanged("changeType", value);
}
}

public CodeableConcept? GenomeBuild
{
get { return _genomeBuild; }
set {
_genomeBuild= value;
OnPropertyChanged("genomeBuild", value);
}
}

public FhirCanonical? InstantiatesCanonical
{
get { return _instantiatesCanonical; }
set {
_instantiatesCanonical= value;
OnPropertyChanged("instantiatesCanonical", value);
}
}

public FhirUri? InstantiatesUri
{
get { return _instantiatesUri; }
set {
_instantiatesUri= value;
OnPropertyChanged("instantiatesUri", value);
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

public List<ReferenceType>? Focus
{
get { return _focus; }
set {
_focus= value;
OnPropertyChanged("focus", value);
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

public FhirDateTime? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
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

public ReferenceType? ProtocolPerformed
{
get { return _protocolPerformed; }
set {
_protocolPerformed= value;
OnPropertyChanged("protocolPerformed", value);
}
}

public List<ReferenceType>? RegionsStudied
{
get { return _regionsStudied; }
set {
_regionsStudied= value;
OnPropertyChanged("regionsStudied", value);
}
}

public List<ReferenceType>? RegionsCalled
{
get { return _regionsCalled; }
set {
_regionsCalled= value;
OnPropertyChanged("regionsCalled", value);
}
}

public List<GenomicStudyAnalysisInput>? Input
{
get { return _input; }
set {
_input= value;
OnPropertyChanged("input", value);
}
}

public List<GenomicStudyAnalysisOutput>? Output
{
get { return _output; }
set {
_output= value;
OnPropertyChanged("output", value);
}
}

public List<GenomicStudyAnalysisPerformer>? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
}
}

public List<GenomicStudyAnalysisDevice>? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}


		#endregion
		#region Constructor
		public  GenomicStudyAnalysis() { }
		public  GenomicStudyAnalysis(string value) : base(value) { }
		public  GenomicStudyAnalysis(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class GenomicStudyAnalysisInputGeneratedByChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Identifier","Reference(GenomicStudy)"
        ];

        public GenomicStudyAnalysisInputGeneratedByChoice(JsonObject value) : base("generatedBy", value, _supportType)
        {
        }
        public GenomicStudyAnalysisInputGeneratedByChoice(IComplexType? value) : base("generatedBy", value)
        {
        }
        public GenomicStudyAnalysisInputGeneratedByChoice(IPrimitiveType? value) : base("generatedBy", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"generatedBy".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
