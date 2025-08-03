using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;


namespace ResourceTypeServices.R5
{
    public class VerificationResult : ResourceType<VerificationResult>
	{
		#region private Property
		private List<ReferenceType>? _target;
private List<FhirString>? _targetLocation;
private CodeableConcept? _need;
private FhirCode? _status;
private FhirDateTime? _statusDate;
private CodeableConcept? _validationType;
private List<CodeableConcept>? _validationProcess;
private Timing? _frequency;
private FhirDateTime? _lastPerformed;
private FhirDate? _nextScheduled;
private CodeableConcept? _failureAction;
private List<VerificationResultPrimarySource>? _primarySource;
private VerificationResultAttestation? _attestation;
private List<VerificationResultValidator>? _validator;

		#endregion
		#region Public Method
		public List<ReferenceType>? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
}
}

public List<FhirString>? TargetLocation
{
get { return _targetLocation; }
set {
_targetLocation= value;
OnPropertyChanged("targetLocation", value);
}
}

public CodeableConcept? Need
{
get { return _need; }
set {
_need= value;
OnPropertyChanged("need", value);
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

public FhirDateTime? StatusDate
{
get { return _statusDate; }
set {
_statusDate= value;
OnPropertyChanged("statusDate", value);
}
}

public CodeableConcept? ValidationType
{
get { return _validationType; }
set {
_validationType= value;
OnPropertyChanged("validationType", value);
}
}

public List<CodeableConcept>? ValidationProcess
{
get { return _validationProcess; }
set {
_validationProcess= value;
OnPropertyChanged("validationProcess", value);
}
}

public Timing? Frequency
{
get { return _frequency; }
set {
_frequency= value;
OnPropertyChanged("frequency", value);
}
}

public FhirDateTime? LastPerformed
{
get { return _lastPerformed; }
set {
_lastPerformed= value;
OnPropertyChanged("lastPerformed", value);
}
}

public FhirDate? NextScheduled
{
get { return _nextScheduled; }
set {
_nextScheduled= value;
OnPropertyChanged("nextScheduled", value);
}
}

public CodeableConcept? FailureAction
{
get { return _failureAction; }
set {
_failureAction= value;
OnPropertyChanged("failureAction", value);
}
}

public List<VerificationResultPrimarySource>? PrimarySource
{
get { return _primarySource; }
set {
_primarySource= value;
OnPropertyChanged("primarySource", value);
}
}

public VerificationResultAttestation? Attestation
{
get { return _attestation; }
set {
_attestation= value;
OnPropertyChanged("attestation", value);
}
}

public List<VerificationResultValidator>? Validator
{
get { return _validator; }
set {
_validator= value;
OnPropertyChanged("validator", value);
}
}


		#endregion
		#region Constructor
		public  VerificationResult() { }
		public  VerificationResult(string value) : base(value) { }
		public  VerificationResult(JsonNode? source) : base(source) { }
		#endregion
	}
		public class VerificationResultPrimarySource : BackboneElementType<VerificationResultPrimarySource>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _who;
private List<CodeableConcept>? _type;
private List<CodeableConcept>? _communicationMethod;
private CodeableConcept? _validationStatus;
private FhirDateTime? _validationDate;
private CodeableConcept? _canPushUpdates;
private List<CodeableConcept>? _pushTypeAvailable;

		#endregion
		#region public Method
		public ReferenceType? Who
{
get { return _who; }
set {
_who= value;
OnPropertyChanged("who", value);
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

public List<CodeableConcept>? CommunicationMethod
{
get { return _communicationMethod; }
set {
_communicationMethod= value;
OnPropertyChanged("communicationMethod", value);
}
}

public CodeableConcept? ValidationStatus
{
get { return _validationStatus; }
set {
_validationStatus= value;
OnPropertyChanged("validationStatus", value);
}
}

public FhirDateTime? ValidationDate
{
get { return _validationDate; }
set {
_validationDate= value;
OnPropertyChanged("validationDate", value);
}
}

public CodeableConcept? CanPushUpdates
{
get { return _canPushUpdates; }
set {
_canPushUpdates= value;
OnPropertyChanged("canPushUpdates", value);
}
}

public List<CodeableConcept>? PushTypeAvailable
{
get { return _pushTypeAvailable; }
set {
_pushTypeAvailable= value;
OnPropertyChanged("pushTypeAvailable", value);
}
}


		#endregion
		#region Constructor
		public  VerificationResultPrimarySource() { }
		public  VerificationResultPrimarySource(string value) : base(value) { }
		public  VerificationResultPrimarySource(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class VerificationResultAttestation : BackboneElementType<VerificationResultAttestation>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _who;
private ReferenceType? _onBehalfOf;
private CodeableConcept? _communicationMethod;
private FhirDate? _date;
private FhirString? _sourceIdentityCertificate;
private FhirString? _proxyIdentityCertificate;
private Signature? _proxySignature;
private Signature? _sourceSignature;

		#endregion
		#region public Method
		public ReferenceType? Who
{
get { return _who; }
set {
_who= value;
OnPropertyChanged("who", value);
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

public CodeableConcept? CommunicationMethod
{
get { return _communicationMethod; }
set {
_communicationMethod= value;
OnPropertyChanged("communicationMethod", value);
}
}

public FhirDate? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
}
}

public FhirString? SourceIdentityCertificate
{
get { return _sourceIdentityCertificate; }
set {
_sourceIdentityCertificate= value;
OnPropertyChanged("sourceIdentityCertificate", value);
}
}

public FhirString? ProxyIdentityCertificate
{
get { return _proxyIdentityCertificate; }
set {
_proxyIdentityCertificate= value;
OnPropertyChanged("proxyIdentityCertificate", value);
}
}

public Signature? ProxySignature
{
get { return _proxySignature; }
set {
_proxySignature= value;
OnPropertyChanged("proxySignature", value);
}
}

public Signature? SourceSignature
{
get { return _sourceSignature; }
set {
_sourceSignature= value;
OnPropertyChanged("sourceSignature", value);
}
}


		#endregion
		#region Constructor
		public  VerificationResultAttestation() { }
		public  VerificationResultAttestation(string value) : base(value) { }
		public  VerificationResultAttestation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class VerificationResultValidator : BackboneElementType<VerificationResultValidator>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _organization;
private FhirString? _identityCertificate;
private Signature? _attestationSignature;

		#endregion
		#region public Method
		public ReferenceType? Organization
{
get { return _organization; }
set {
_organization= value;
OnPropertyChanged("organization", value);
}
}

public FhirString? IdentityCertificate
{
get { return _identityCertificate; }
set {
_identityCertificate= value;
OnPropertyChanged("identityCertificate", value);
}
}

public Signature? AttestationSignature
{
get { return _attestationSignature; }
set {
_attestationSignature= value;
OnPropertyChanged("attestationSignature", value);
}
}


		#endregion
		#region Constructor
		public  VerificationResultValidator() { }
		public  VerificationResultValidator(string value) : base(value) { }
		public  VerificationResultValidator(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
