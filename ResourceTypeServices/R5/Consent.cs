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
    public class Consent : ResourceType<Consent>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<CodeableConcept>? _category;
private ReferenceType? _subject;
private FhirDate? _date;
private Period? _period;
private List<ReferenceType>? _grantor;
private List<ReferenceType>? _grantee;
private List<ReferenceType>? _manager;
private List<ReferenceType>? _controller;
private List<Attachment>? _sourceAttachment;
private List<ReferenceType>? _sourceReference;
private List<CodeableConcept>? _regulatoryBasis;
private ConsentPolicyBasis? _policyBasis;
private List<ReferenceType>? _policyText;
private List<ConsentVerification>? _verification;
private FhirCode? _decision;
private List<ConsentProvision>? _provision;

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

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
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

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public List<ReferenceType>? Grantor
{
get { return _grantor; }
set {
_grantor= value;
OnPropertyChanged("grantor", value);
}
}

public List<ReferenceType>? Grantee
{
get { return _grantee; }
set {
_grantee= value;
OnPropertyChanged("grantee", value);
}
}

public List<ReferenceType>? Manager
{
get { return _manager; }
set {
_manager= value;
OnPropertyChanged("manager", value);
}
}

public List<ReferenceType>? Controller
{
get { return _controller; }
set {
_controller= value;
OnPropertyChanged("controller", value);
}
}

public List<Attachment>? SourceAttachment
{
get { return _sourceAttachment; }
set {
_sourceAttachment= value;
OnPropertyChanged("sourceAttachment", value);
}
}

public List<ReferenceType>? SourceReference
{
get { return _sourceReference; }
set {
_sourceReference= value;
OnPropertyChanged("sourceReference", value);
}
}

public List<CodeableConcept>? RegulatoryBasis
{
get { return _regulatoryBasis; }
set {
_regulatoryBasis= value;
OnPropertyChanged("regulatoryBasis", value);
}
}

public ConsentPolicyBasis? PolicyBasis
{
get { return _policyBasis; }
set {
_policyBasis= value;
OnPropertyChanged("policyBasis", value);
}
}

public List<ReferenceType>? PolicyText
{
get { return _policyText; }
set {
_policyText= value;
OnPropertyChanged("policyText", value);
}
}

public List<ConsentVerification>? Verification
{
get { return _verification; }
set {
_verification= value;
OnPropertyChanged("verification", value);
}
}

public FhirCode? Decision
{
get { return _decision; }
set {
_decision= value;
OnPropertyChanged("decision", value);
}
}

public List<ConsentProvision>? Provision
{
get { return _provision; }
set {
_provision= value;
OnPropertyChanged("provision", value);
}
}


		#endregion
		#region Constructor
		public  Consent() { }
		public  Consent(string value) : base(value) { }
		public  Consent(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ConsentPolicyBasis : BackboneElementType<ConsentPolicyBasis>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _reference;
private FhirUrl? _url;

		#endregion
		#region public Method
		public ReferenceType? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}

public FhirUrl? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
}
}


		#endregion
		#region Constructor
		public  ConsentPolicyBasis() { }
		public  ConsentPolicyBasis(string value) : base(value) { }
		public  ConsentPolicyBasis(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConsentVerification : BackboneElementType<ConsentVerification>, IBackboneElementType
	{

		#region Private Method
		private FhirBoolean? _verified;
private CodeableConcept? _verificationType;
private ReferenceType? _verifiedBy;
private ReferenceType? _verifiedWith;
private List<FhirDateTime>? _verificationDate;

		#endregion
		#region public Method
		public FhirBoolean? Verified
{
get { return _verified; }
set {
_verified= value;
OnPropertyChanged("verified", value);
}
}

public CodeableConcept? VerificationType
{
get { return _verificationType; }
set {
_verificationType= value;
OnPropertyChanged("verificationType", value);
}
}

public ReferenceType? VerifiedBy
{
get { return _verifiedBy; }
set {
_verifiedBy= value;
OnPropertyChanged("verifiedBy", value);
}
}

public ReferenceType? VerifiedWith
{
get { return _verifiedWith; }
set {
_verifiedWith= value;
OnPropertyChanged("verifiedWith", value);
}
}

public List<FhirDateTime>? VerificationDate
{
get { return _verificationDate; }
set {
_verificationDate= value;
OnPropertyChanged("verificationDate", value);
}
}


		#endregion
		#region Constructor
		public  ConsentVerification() { }
		public  ConsentVerification(string value) : base(value) { }
		public  ConsentVerification(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConsentProvisionActor : BackboneElementType<ConsentProvisionActor>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _role;
private ReferenceType? _reference;

		#endregion
		#region public Method
		public CodeableConcept? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
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
		public  ConsentProvisionActor() { }
		public  ConsentProvisionActor(string value) : base(value) { }
		public  ConsentProvisionActor(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConsentProvisionData : BackboneElementType<ConsentProvisionData>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _meaning;
private ReferenceType? _reference;

		#endregion
		#region public Method
		public FhirCode? Meaning
{
get { return _meaning; }
set {
_meaning= value;
OnPropertyChanged("meaning", value);
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
		public  ConsentProvisionData() { }
		public  ConsentProvisionData(string value) : base(value) { }
		public  ConsentProvisionData(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConsentProvision : BackboneElementType<ConsentProvision>, IBackboneElementType
	{

		#region Private Method
		private Period? _period;
private List<ConsentProvisionActor>? _actor;
private List<CodeableConcept>? _action;
private List<Coding>? _securityLabel;
private List<Coding>? _purpose;
private List<Coding>? _documentType;
private List<Coding>? _resourceType;
private List<CodeableConcept>? _code;
private Period? _dataPeriod;
private List<ConsentProvisionData>? _data;
private ExpressionType? _expression;

		#endregion
		#region public Method
		public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public List<ConsentProvisionActor>? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}

public List<CodeableConcept>? Action
{
get { return _action; }
set {
_action= value;
OnPropertyChanged("action", value);
}
}

public List<Coding>? SecurityLabel
{
get { return _securityLabel; }
set {
_securityLabel= value;
OnPropertyChanged("securityLabel", value);
}
}

public List<Coding>? Purpose
{
get { return _purpose; }
set {
_purpose= value;
OnPropertyChanged("purpose", value);
}
}

public List<Coding>? DocumentType
{
get { return _documentType; }
set {
_documentType= value;
OnPropertyChanged("documentType", value);
}
}

public List<Coding>? ResourceType
{
get { return _resourceType; }
set {
_resourceType= value;
OnPropertyChanged("resourceType", value);
}
}

public List<CodeableConcept>? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public Period? DataPeriod
{
get { return _dataPeriod; }
set {
_dataPeriod= value;
OnPropertyChanged("dataPeriod", value);
}
}

public List<ConsentProvisionData>? Data
{
get { return _data; }
set {
_data= value;
OnPropertyChanged("data", value);
}
}

public ExpressionType? Expression
{
get { return _expression; }
set {
_expression= value;
OnPropertyChanged("expression", value);
}
}


		#endregion
		#region Constructor
		public  ConsentProvision() { }
		public  ConsentProvision(string value) : base(value) { }
		public  ConsentProvision(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
