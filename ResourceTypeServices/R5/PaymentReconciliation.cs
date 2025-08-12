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
    public class PaymentReconciliation : ResourceType<PaymentReconciliation>
	{
		#region private Property
		private List<Identifier>? _identifier;
private CodeableConcept? _type;
private FhirCode? _status;
private CodeableConcept? _kind;
private Period? _period;
private FhirDateTime? _created;
private ReferenceType? _enterer;
private CodeableConcept? _issuerType;
private ReferenceType? _paymentIssuer;
private ReferenceType? _request;
private ReferenceType? _requestor;
private FhirCode? _outcome;
private FhirString? _disposition;
private FhirDate? _date;
private ReferenceType? _location;
private CodeableConcept? _method;
private FhirString? _cardBrand;
private FhirString? _accountNumber;
private FhirDate? _expirationDate;
private FhirString? _processor;
private FhirString? _referenceNumber;
private FhirString? _authorization;
private Money? _tenderedAmount;
private Money? _returnedAmount;
private Money? _amount;
private Identifier? _paymentIdentifier;
private List<PaymentReconciliationAllocation>? _allocation;
private CodeableConcept? _formCode;
private List<PaymentReconciliationProcessNote>? _processNote;

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

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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

public CodeableConcept? Kind
{
get { return _kind; }
set {
_kind= value;
OnPropertyChanged("kind", value);
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

public FhirDateTime? Created
{
get { return _created; }
set {
_created= value;
OnPropertyChanged("created", value);
}
}

public ReferenceType? Enterer
{
get { return _enterer; }
set {
_enterer= value;
OnPropertyChanged("enterer", value);
}
}

public CodeableConcept? IssuerType
{
get { return _issuerType; }
set {
_issuerType= value;
OnPropertyChanged("issuerType", value);
}
}

public ReferenceType? PaymentIssuer
{
get { return _paymentIssuer; }
set {
_paymentIssuer= value;
OnPropertyChanged("paymentIssuer", value);
}
}

public ReferenceType? Request
{
get { return _request; }
set {
_request= value;
OnPropertyChanged("request", value);
}
}

public ReferenceType? Requestor
{
get { return _requestor; }
set {
_requestor= value;
OnPropertyChanged("requestor", value);
}
}

public FhirCode? Outcome
{
get { return _outcome; }
set {
_outcome= value;
OnPropertyChanged("outcome", value);
}
}

public FhirString? Disposition
{
get { return _disposition; }
set {
_disposition= value;
OnPropertyChanged("disposition", value);
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

public ReferenceType? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public CodeableConcept? Method
{
get { return _method; }
set {
_method= value;
OnPropertyChanged("method", value);
}
}

public FhirString? CardBrand
{
get { return _cardBrand; }
set {
_cardBrand= value;
OnPropertyChanged("cardBrand", value);
}
}

public FhirString? AccountNumber
{
get { return _accountNumber; }
set {
_accountNumber= value;
OnPropertyChanged("accountNumber", value);
}
}

public FhirDate? ExpirationDate
{
get { return _expirationDate; }
set {
_expirationDate= value;
OnPropertyChanged("expirationDate", value);
}
}

public FhirString? Processor
{
get { return _processor; }
set {
_processor= value;
OnPropertyChanged("processor", value);
}
}

public FhirString? ReferenceNumber
{
get { return _referenceNumber; }
set {
_referenceNumber= value;
OnPropertyChanged("referenceNumber", value);
}
}

public FhirString? Authorization
{
get { return _authorization; }
set {
_authorization= value;
OnPropertyChanged("authorization", value);
}
}

public Money? TenderedAmount
{
get { return _tenderedAmount; }
set {
_tenderedAmount= value;
OnPropertyChanged("tenderedAmount", value);
}
}

public Money? ReturnedAmount
{
get { return _returnedAmount; }
set {
_returnedAmount= value;
OnPropertyChanged("returnedAmount", value);
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

public Identifier? PaymentIdentifier
{
get { return _paymentIdentifier; }
set {
_paymentIdentifier= value;
OnPropertyChanged("paymentIdentifier", value);
}
}

public List<PaymentReconciliationAllocation>? Allocation
{
get { return _allocation; }
set {
_allocation= value;
OnPropertyChanged("allocation", value);
}
}

public CodeableConcept? FormCode
{
get { return _formCode; }
set {
_formCode= value;
OnPropertyChanged("formCode", value);
}
}

public List<PaymentReconciliationProcessNote>? ProcessNote
{
get { return _processNote; }
set {
_processNote= value;
OnPropertyChanged("processNote", value);
}
}


		#endregion
		#region Constructor
		public  PaymentReconciliation() { }
		public  PaymentReconciliation(string value) : base(value) { }
		public  PaymentReconciliation(JsonNode? source) : base(source) { }
		#endregion
	}
		public class PaymentReconciliationAllocation : BackboneElementType<PaymentReconciliationAllocation>, IBackboneElementType
	{

		#region Private Method
		private Identifier? _identifier;
private Identifier? _predecessor;
private ReferenceType? _target;
private PaymentReconciliationAllocationTargetItemChoice? _targetItem;
private ReferenceType? _encounter;
private ReferenceType? _account;
private CodeableConcept? _type;
private ReferenceType? _submitter;
private ReferenceType? _response;
private FhirDate? _date;
private ReferenceType? _responsible;
private ReferenceType? _payee;
private Money? _amount;

		#endregion
		#region public Method
		public Identifier? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public Identifier? Predecessor
{
get { return _predecessor; }
set {
_predecessor= value;
OnPropertyChanged("predecessor", value);
}
}

public ReferenceType? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
}
}

public PaymentReconciliationAllocationTargetItemChoice? TargetItem
{
get { return _targetItem; }
set {
_targetItem= value;
OnPropertyChanged("targetItem", value);
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

public ReferenceType? Account
{
get { return _account; }
set {
_account= value;
OnPropertyChanged("account", value);
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

public ReferenceType? Submitter
{
get { return _submitter; }
set {
_submitter= value;
OnPropertyChanged("submitter", value);
}
}

public ReferenceType? Response
{
get { return _response; }
set {
_response= value;
OnPropertyChanged("response", value);
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

public ReferenceType? Responsible
{
get { return _responsible; }
set {
_responsible= value;
OnPropertyChanged("responsible", value);
}
}

public ReferenceType? Payee
{
get { return _payee; }
set {
_payee= value;
OnPropertyChanged("payee", value);
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
		public  PaymentReconciliationAllocation() { }
		public  PaymentReconciliationAllocation(string value) : base(value) { }
		public  PaymentReconciliationAllocation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PaymentReconciliationProcessNote : BackboneElementType<PaymentReconciliationProcessNote>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _type;

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


		#endregion
		#region Constructor
		public  PaymentReconciliationProcessNote() { }
		public  PaymentReconciliationProcessNote(string value) : base(value) { }
		public  PaymentReconciliationProcessNote(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class PaymentReconciliationAllocationTargetItemChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","IdentifierpositiveInt"
        ];

        public PaymentReconciliationAllocationTargetItemChoice(JsonObject value) : base("targetItem", value, _supportType)
        {
        }
        public PaymentReconciliationAllocationTargetItemChoice(IComplexType? value) : base("targetItem", value)
        {
        }
        public PaymentReconciliationAllocationTargetItemChoice(IPrimitiveType? value) : base("targetItem", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"targetItem".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
