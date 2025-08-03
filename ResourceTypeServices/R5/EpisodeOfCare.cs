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
    public class EpisodeOfCare : ResourceType<EpisodeOfCare>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<EpisodeOfCareStatusHistory>? _statusHistory;
private List<CodeableConcept>? _type;
private List<EpisodeOfCareReason>? _reason;
private List<EpisodeOfCareDiagnosis>? _diagnosis;
private ReferenceType? _patient;
private ReferenceType? _managingOrganization;
private Period? _period;
private List<ReferenceType>? _referralRequest;
private ReferenceType? _careManager;
private List<ReferenceType>? _careTeam;
private List<ReferenceType>? _account;

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

public List<EpisodeOfCareStatusHistory>? StatusHistory
{
get { return _statusHistory; }
set {
_statusHistory= value;
OnPropertyChanged("statusHistory", value);
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

public List<EpisodeOfCareReason>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public List<EpisodeOfCareDiagnosis>? Diagnosis
{
get { return _diagnosis; }
set {
_diagnosis= value;
OnPropertyChanged("diagnosis", value);
}
}

public ReferenceType? Patient
{
get { return _patient; }
set {
_patient= value;
OnPropertyChanged("patient", value);
}
}

public ReferenceType? ManagingOrganization
{
get { return _managingOrganization; }
set {
_managingOrganization= value;
OnPropertyChanged("managingOrganization", value);
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

public List<ReferenceType>? ReferralRequest
{
get { return _referralRequest; }
set {
_referralRequest= value;
OnPropertyChanged("referralRequest", value);
}
}

public ReferenceType? CareManager
{
get { return _careManager; }
set {
_careManager= value;
OnPropertyChanged("careManager", value);
}
}

public List<ReferenceType>? CareTeam
{
get { return _careTeam; }
set {
_careTeam= value;
OnPropertyChanged("careTeam", value);
}
}

public List<ReferenceType>? Account
{
get { return _account; }
set {
_account= value;
OnPropertyChanged("account", value);
}
}


		#endregion
		#region Constructor
		public  EpisodeOfCare() { }
		public  EpisodeOfCare(string value) : base(value) { }
		public  EpisodeOfCare(JsonNode? source) : base(source) { }
		#endregion
	}
		public class EpisodeOfCareStatusHistory : BackboneElementType<EpisodeOfCareStatusHistory>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _status;
private Period? _period;

		#endregion
		#region public Method
		public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
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
		public  EpisodeOfCareStatusHistory() { }
		public  EpisodeOfCareStatusHistory(string value) : base(value) { }
		public  EpisodeOfCareStatusHistory(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EpisodeOfCareReason : BackboneElementType<EpisodeOfCareReason>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _use;
private List<CodeableReference>? _value;

		#endregion
		#region public Method
		public CodeableConcept? Use
{
get { return _use; }
set {
_use= value;
OnPropertyChanged("use", value);
}
}

public List<CodeableReference>? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  EpisodeOfCareReason() { }
		public  EpisodeOfCareReason(string value) : base(value) { }
		public  EpisodeOfCareReason(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EpisodeOfCareDiagnosis : BackboneElementType<EpisodeOfCareDiagnosis>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableReference>? _condition;
private CodeableConcept? _use;

		#endregion
		#region public Method
		public List<CodeableReference>? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
}
}

public CodeableConcept? Use
{
get { return _use; }
set {
_use= value;
OnPropertyChanged("use", value);
}
}


		#endregion
		#region Constructor
		public  EpisodeOfCareDiagnosis() { }
		public  EpisodeOfCareDiagnosis(string value) : base(value) { }
		public  EpisodeOfCareDiagnosis(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
