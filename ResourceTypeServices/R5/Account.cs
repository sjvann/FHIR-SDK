
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
	public class Account : ResourceType<Account>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private CodeableConcept? _billingStatus;
private CodeableConcept? _type;
private FhirString? _name;
private List<ReferenceType>? _subject;
private Period? _servicePeriod;
private List<AccountCoverage>? _coverage;
private ReferenceType? _owner;
private FhirMarkdown? _description;
private List<AccountGuarantor>? _guarantor;
private List<AccountDiagnosis>? _diagnosis;
private List<AccountProcedure>? _procedure;
private List<AccountRelatedAccount>? _relatedAccount;
private CodeableConcept? _currency;
private List<AccountBalance>? _balance;
private FhirInstant? _calculatedAt;

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

public CodeableConcept? BillingStatus
{
get { return _billingStatus; }
set {
_billingStatus= value;
OnPropertyChanged("billingStatus", value);
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

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public List<ReferenceType>? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public Period? ServicePeriod
{
get { return _servicePeriod; }
set {
_servicePeriod= value;
OnPropertyChanged("servicePeriod", value);
}
}

public List<AccountCoverage>? Coverage
{
get { return _coverage; }
set {
_coverage= value;
OnPropertyChanged("coverage", value);
}
}

public ReferenceType? Owner
{
get { return _owner; }
set {
_owner= value;
OnPropertyChanged("owner", value);
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

public List<AccountGuarantor>? Guarantor
{
get { return _guarantor; }
set {
_guarantor= value;
OnPropertyChanged("guarantor", value);
}
}

public List<AccountDiagnosis>? Diagnosis
{
get { return _diagnosis; }
set {
_diagnosis= value;
OnPropertyChanged("diagnosis", value);
}
}

public List<AccountProcedure>? Procedure
{
get { return _procedure; }
set {
_procedure= value;
OnPropertyChanged("procedure", value);
}
}

public List<AccountRelatedAccount>? RelatedAccount
{
get { return _relatedAccount; }
set {
_relatedAccount= value;
OnPropertyChanged("relatedAccount", value);
}
}

public CodeableConcept? Currency
{
get { return _currency; }
set {
_currency= value;
OnPropertyChanged("currency", value);
}
}

public List<AccountBalance>? Balance
{
get { return _balance; }
set {
_balance= value;
OnPropertyChanged("balance", value);
}
}

public FhirInstant? CalculatedAt
{
get { return _calculatedAt; }
set {
_calculatedAt= value;
OnPropertyChanged("calculatedAt", value);
}
}


		#endregion
		#region Constructor
		public  Account() { }
		public  Account(string value) : base(value) { }
		public  Account(JsonNode? source) : base(source) { }
		#endregion
	}
		public class AccountCoverage : BackboneElementType<AccountCoverage>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _coverage;
private FhirPositiveInt? _priority;

		#endregion
		#region public Method
		public ReferenceType? Coverage
{
get { return _coverage; }
set {
_coverage= value;
OnPropertyChanged("coverage", value);
}
}

public FhirPositiveInt? Priority
{
get { return _priority; }
set {
_priority= value;
OnPropertyChanged("priority", value);
}
}


		#endregion
		#region Constructor
		public  AccountCoverage() { }
		public  AccountCoverage(string value) : base(value) { }
		public  AccountCoverage(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AccountGuarantor : BackboneElementType<AccountGuarantor>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _party;
private FhirBoolean? _onHold;
private Period? _period;

		#endregion
		#region public Method
		public ReferenceType? Party
{
get { return _party; }
set {
_party= value;
OnPropertyChanged("party", value);
}
}

public FhirBoolean? OnHold
{
get { return _onHold; }
set {
_onHold= value;
OnPropertyChanged("onHold", value);
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
		public  AccountGuarantor() { }
		public  AccountGuarantor(string value) : base(value) { }
		public  AccountGuarantor(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AccountDiagnosis : BackboneElementType<AccountDiagnosis>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private CodeableReference? _condition;
private FhirDateTime? _dateOfDiagnosis;
private List<CodeableConcept>? _type;
private FhirBoolean? _onAdmission;
private List<CodeableConcept>? _packageCode;

		#endregion
		#region public Method
		public FhirPositiveInt? Sequence
{
get { return _sequence; }
set {
_sequence= value;
OnPropertyChanged("sequence", value);
}
}

public CodeableReference? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
}
}

public FhirDateTime? DateOfDiagnosis
{
get { return _dateOfDiagnosis; }
set {
_dateOfDiagnosis= value;
OnPropertyChanged("dateOfDiagnosis", value);
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

public FhirBoolean? OnAdmission
{
get { return _onAdmission; }
set {
_onAdmission= value;
OnPropertyChanged("onAdmission", value);
}
}

public List<CodeableConcept>? PackageCode
{
get { return _packageCode; }
set {
_packageCode= value;
OnPropertyChanged("packageCode", value);
}
}


		#endregion
		#region Constructor
		public  AccountDiagnosis() { }
		public  AccountDiagnosis(string value) : base(value) { }
		public  AccountDiagnosis(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AccountProcedure : BackboneElementType<AccountProcedure>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private CodeableReference? _code;
private FhirDateTime? _dateOfService;
private List<CodeableConcept>? _type;
private List<CodeableConcept>? _packageCode;
private List<ReferenceType>? _device;

		#endregion
		#region public Method
		public FhirPositiveInt? Sequence
{
get { return _sequence; }
set {
_sequence= value;
OnPropertyChanged("sequence", value);
}
}

public CodeableReference? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public FhirDateTime? DateOfService
{
get { return _dateOfService; }
set {
_dateOfService= value;
OnPropertyChanged("dateOfService", value);
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

public List<CodeableConcept>? PackageCode
{
get { return _packageCode; }
set {
_packageCode= value;
OnPropertyChanged("packageCode", value);
}
}

public List<ReferenceType>? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}


		#endregion
		#region Constructor
		public  AccountProcedure() { }
		public  AccountProcedure(string value) : base(value) { }
		public  AccountProcedure(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AccountRelatedAccount : BackboneElementType<AccountRelatedAccount>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _relationship;
private ReferenceType? _account;

		#endregion
		#region public Method
		public CodeableConcept? Relationship
{
get { return _relationship; }
set {
_relationship= value;
OnPropertyChanged("relationship", value);
}
}

public ReferenceType? Account
{
get { return _account; }
set {
_account= value;
OnPropertyChanged("account", value);
}
}


		#endregion
		#region Constructor
		public  AccountRelatedAccount() { }
		public  AccountRelatedAccount(string value) : base(value) { }
		public  AccountRelatedAccount(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AccountBalance : BackboneElementType<AccountBalance>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _aggregate;
private CodeableConcept? _term;
private FhirBoolean? _estimate;
private Money? _amount;

		#endregion
		#region public Method
		public CodeableConcept? Aggregate
{
get { return _aggregate; }
set {
_aggregate= value;
OnPropertyChanged("aggregate", value);
}
}

public CodeableConcept? Term
{
get { return _term; }
set {
_term= value;
OnPropertyChanged("term", value);
}
}

public FhirBoolean? Estimate
{
get { return _estimate; }
set {
_estimate= value;
OnPropertyChanged("estimate", value);
}
}

public Money? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}


		#endregion
		#region Constructor
		public  AccountBalance() { }
		public  AccountBalance(string value) : base(value) { }
		public  AccountBalance(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
