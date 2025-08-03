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
    public class Invoice : ResourceType<Invoice>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private FhirString? _cancelledReason;
private CodeableConcept? _type;
private ReferenceType? _subject;
private ReferenceType? _recipient;
private FhirDateTime? _date;
private FhirDateTime? _creation;
private InvoicePeriodChoice? _period;
private List<InvoiceParticipant>? _participant;
private ReferenceType? _issuer;
private ReferenceType? _account;
private List<InvoiceLineItem>? _lineItem;
private List<MonetaryComponent>? _totalPriceComponent;
private Money? _totalNet;
private Money? _totalGross;
private FhirMarkdown? _paymentTerms;
private List<Annotation>? _note;

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

public FhirString? CancelledReason
{
get { return _cancelledReason; }
set {
_cancelledReason= value;
OnPropertyChanged("cancelledReason", value);
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

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
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

public FhirDateTime? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
}
}

public FhirDateTime? Creation
{
get { return _creation; }
set {
_creation= value;
OnPropertyChanged("creation", value);
}
}

public InvoicePeriodChoice? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public List<InvoiceParticipant>? Participant
{
get { return _participant; }
set {
_participant= value;
OnPropertyChanged("participant", value);
}
}

public ReferenceType? Issuer
{
get { return _issuer; }
set {
_issuer= value;
OnPropertyChanged("issuer", value);
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

public List<InvoiceLineItem>? LineItem
{
get { return _lineItem; }
set {
_lineItem= value;
OnPropertyChanged("lineItem", value);
}
}

public List<MonetaryComponent>? TotalPriceComponent
{
get { return _totalPriceComponent; }
set {
_totalPriceComponent= value;
OnPropertyChanged("totalPriceComponent", value);
}
}

public Money? TotalNet
{
get { return _totalNet; }
set {
_totalNet= value;
OnPropertyChanged("totalNet", value);
}
}

public Money? TotalGross
{
get { return _totalGross; }
set {
_totalGross= value;
OnPropertyChanged("totalGross", value);
}
}

public FhirMarkdown? PaymentTerms
{
get { return _paymentTerms; }
set {
_paymentTerms= value;
OnPropertyChanged("paymentTerms", value);
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
		public  Invoice() { }
		public  Invoice(string value) : base(value) { }
		public  Invoice(JsonNode? source) : base(source) { }
		#endregion
	}
		public class InvoiceParticipant : BackboneElementType<InvoiceParticipant>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _role;
private ReferenceType? _actor;

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

public ReferenceType? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}


		#endregion
		#region Constructor
		public  InvoiceParticipant() { }
		public  InvoiceParticipant(string value) : base(value) { }
		public  InvoiceParticipant(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InvoiceLineItem : BackboneElementType<InvoiceLineItem>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private InvoiceLineItemServicedChoice? _serviced;
private InvoiceLineItemChargeItemChoice? _chargeItem;
private List<MonetaryComponent>? _priceComponent;

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

public InvoiceLineItemServicedChoice? Serviced
{
get { return _serviced; }
set {
_serviced= value;
OnPropertyChanged("serviced", value);
}
}

public InvoiceLineItemChargeItemChoice? ChargeItem
{
get { return _chargeItem; }
set {
_chargeItem= value;
OnPropertyChanged("chargeItem", value);
}
}

public List<MonetaryComponent>? PriceComponent
{
get { return _priceComponent; }
set {
_priceComponent= value;
OnPropertyChanged("priceComponent", value);
}
}


		#endregion
		#region Constructor
		public  InvoiceLineItem() { }
		public  InvoiceLineItem(string value) : base(value) { }
		public  InvoiceLineItem(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class InvoicePeriodChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "date","Period"
        ];

        public InvoicePeriodChoice(JsonObject value) : base("period", value, _supportType)
        {
        }
        public InvoicePeriodChoice(IComplexType? value) : base("period", value)
        {
        }
        public InvoicePeriodChoice(IPrimitiveType? value) : base("period", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"period".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class InvoiceLineItemServicedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "date","Period"
        ];

        public InvoiceLineItemServicedChoice(JsonObject value) : base("serviced", value, _supportType)
        {
        }
        public InvoiceLineItemServicedChoice(IComplexType? value) : base("serviced", value)
        {
        }
        public InvoiceLineItemServicedChoice(IPrimitiveType? value) : base("serviced", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"serviced".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class InvoiceLineItemChargeItemChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(ChargeItem)","CodeableConcept"
        ];

        public InvoiceLineItemChargeItemChoice(JsonObject value) : base("chargeItem", value, _supportType)
        {
        }
        public InvoiceLineItemChargeItemChoice(IComplexType? value) : base("chargeItem", value)
        {
        }
        public InvoiceLineItemChargeItemChoice(IPrimitiveType? value) : base("chargeItem", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"chargeItem".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
