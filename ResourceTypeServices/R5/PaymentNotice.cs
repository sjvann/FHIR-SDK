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
	public class PaymentNotice : ResourceType<PaymentNotice>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private ReferenceType? _request;
private ReferenceType? _response;
private FhirDateTime? _created;
private ReferenceType? _reporter;
private ReferenceType? _payment;
private FhirDate? _paymentDate;
private ReferenceType? _payee;
private ReferenceType? _recipient;
private Money? _amount;
private CodeableConcept? _paymentStatus;

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

public ReferenceType? Request
{
get { return _request; }
set {
_request= value;
OnPropertyChanged("request", value);
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

public FhirDateTime? Created
{
get { return _created; }
set {
_created= value;
OnPropertyChanged("created", value);
}
}

public ReferenceType? Reporter
{
get { return _reporter; }
set {
_reporter= value;
OnPropertyChanged("reporter", value);
}
}

public ReferenceType? Payment
{
get { return _payment; }
set {
_payment= value;
OnPropertyChanged("payment", value);
}
}

public FhirDate? PaymentDate
{
get { return _paymentDate; }
set {
_paymentDate= value;
OnPropertyChanged("paymentDate", value);
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

public ReferenceType? Recipient
{
get { return _recipient; }
set {
_recipient= value;
OnPropertyChanged("recipient", value);
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

public CodeableConcept? PaymentStatus
{
get { return _paymentStatus; }
set {
_paymentStatus= value;
OnPropertyChanged("paymentStatus", value);
}
}


		#endregion
		#region Constructor
		public  PaymentNotice() { }
		public  PaymentNotice(string value) : base(value) { }
		public  PaymentNotice(JsonNode? source) : base(source) { }
		#endregion
	}
	

		

}
