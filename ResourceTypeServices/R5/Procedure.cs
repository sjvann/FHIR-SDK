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
    public class Procedure : ResourceType<Procedure>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<FhirCanonical>? _instantiatesCanonical;
private List<FhirUri>? _instantiatesUri;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _partOf;
private FhirCode? _status;
private CodeableConcept? _statusReason;
private List<CodeableConcept>? _category;
private CodeableConcept? _code;
private ReferenceType? _subject;
private ReferenceType? _focus;
private ReferenceType? _encounter;
private ProcedureOccurrenceChoice? _occurrence;
private FhirDateTime? _recorded;
private ReferenceType? _recorder;
private ProcedureReportedChoice? _reported;
private List<ProcedurePerformer>? _performer;
private ReferenceType? _location;
private List<CodeableReference>? _reason;
private List<CodeableConcept>? _bodySite;
private CodeableConcept? _outcome;
private List<ReferenceType>? _report;
private List<CodeableReference>? _complication;
private List<CodeableConcept>? _followUp;
private List<Annotation>? _note;
private List<ProcedureFocalDevice>? _focalDevice;
private List<CodeableReference>? _used;
private List<ReferenceType>? _supportingInfo;

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

public List<FhirCanonical>? InstantiatesCanonical
{
get { return _instantiatesCanonical; }
set {
_instantiatesCanonical= value;
OnPropertyChanged("instantiatesCanonical", value);
}
}

public List<FhirUri>? InstantiatesUri
{
get { return _instantiatesUri; }
set {
_instantiatesUri= value;
OnPropertyChanged("instantiatesUri", value);
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

public List<ReferenceType>? PartOf
{
get { return _partOf; }
set {
_partOf= value;
OnPropertyChanged("partOf", value);
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

public CodeableConcept? StatusReason
{
get { return _statusReason; }
set {
_statusReason= value;
OnPropertyChanged("statusReason", value);
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

public ReferenceType? Focus
{
get { return _focus; }
set {
_focus= value;
OnPropertyChanged("focus", value);
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

public ProcedureOccurrenceChoice? Occurrence
{
get { return _occurrence; }
set {
_occurrence= value;
OnPropertyChanged("occurrence", value);
}
}

public FhirDateTime? Recorded
{
get { return _recorded; }
set {
_recorded= value;
OnPropertyChanged("recorded", value);
}
}

public ReferenceType? Recorder
{
get { return _recorder; }
set {
_recorder= value;
OnPropertyChanged("recorder", value);
}
}

public ProcedureReportedChoice? Reported
{
get { return _reported; }
set {
_reported= value;
OnPropertyChanged("reported", value);
}
}

public List<ProcedurePerformer>? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
}
}

public ReferenceType? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
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

public List<CodeableConcept>? BodySite
{
get { return _bodySite; }
set {
_bodySite= value;
OnPropertyChanged("bodySite", value);
}
}

public CodeableConcept? Outcome
{
get { return _outcome; }
set {
_outcome= value;
OnPropertyChanged("outcome", value);
}
}

public List<ReferenceType>? Report
{
get { return _report; }
set {
_report= value;
OnPropertyChanged("report", value);
}
}

public List<CodeableReference>? Complication
{
get { return _complication; }
set {
_complication= value;
OnPropertyChanged("complication", value);
}
}

public List<CodeableConcept>? FollowUp
{
get { return _followUp; }
set {
_followUp= value;
OnPropertyChanged("followUp", value);
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

public List<ProcedureFocalDevice>? FocalDevice
{
get { return _focalDevice; }
set {
_focalDevice= value;
OnPropertyChanged("focalDevice", value);
}
}

public List<CodeableReference>? Used
{
get { return _used; }
set {
_used= value;
OnPropertyChanged("used", value);
}
}

public List<ReferenceType>? SupportingInfo
{
get { return _supportingInfo; }
set {
_supportingInfo= value;
OnPropertyChanged("supportingInfo", value);
}
}


		#endregion
		#region Constructor
		public  Procedure() { }
		public  Procedure(string value) : base(value) { }
		public  Procedure(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ProcedurePerformer : BackboneElementType<ProcedurePerformer>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _function;
private ReferenceType? _actor;
private ReferenceType? _onBehalfOf;
private Period? _period;

		#endregion
		#region public Method
		public CodeableConcept? Function
{
get { return _function; }
set {
_function= value;
OnPropertyChanged("function", value);
}
}

public ReferenceType? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}

public ReferenceType? OnBehalfOf
{
get { return _onBehalfOf; }
set {
_onBehalfOf= value;
OnPropertyChanged("onBehalfOf", value);
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
		public  ProcedurePerformer() { }
		public  ProcedurePerformer(string value) : base(value) { }
		public  ProcedurePerformer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ProcedureFocalDevice : BackboneElementType<ProcedureFocalDevice>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _action;
private ReferenceType? _manipulated;

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

public ReferenceType? Manipulated
{
get { return _manipulated; }
set {
_manipulated= value;
OnPropertyChanged("manipulated", value);
}
}


		#endregion
		#region Constructor
		public  ProcedureFocalDevice() { }
		public  ProcedureFocalDevice(string value) : base(value) { }
		public  ProcedureFocalDevice(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ProcedureOccurrenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","PeriodstringAgeRangeTiming"
        ];

        public ProcedureOccurrenceChoice(JsonObject value) : base("occurrence", value, _supportType)
        {
        }
        public ProcedureOccurrenceChoice(IComplexType? value) : base("occurrence", value)
        {
        }
        public ProcedureOccurrenceChoice(IPrimitiveType? value) : base("occurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurrence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ProcedureReportedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","Reference(Patient|RelatedPerson|Practitioner|PractitionerRole|Organization)"
        ];

        public ProcedureReportedChoice(JsonObject value) : base("reported", value, _supportType)
        {
        }
        public ProcedureReportedChoice(IComplexType? value) : base("reported", value)
        {
        }
        public ProcedureReportedChoice(IPrimitiveType? value) : base("reported", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"reported".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
