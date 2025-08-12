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
    public class ClaimResponse : ResourceType<ClaimResponse>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<Identifier>? _traceNumber;
private FhirCode? _status;
private CodeableConcept? _type;
private CodeableConcept? _subType;
private FhirCode? _use;
private ReferenceType? _patient;
private FhirDateTime? _created;
private ReferenceType? _insurer;
private ReferenceType? _requestor;
private ReferenceType? _request;
private FhirCode? _outcome;
private CodeableConcept? _decision;
private FhirString? _disposition;
private FhirString? _preAuthRef;
private Period? _preAuthPeriod;
private List<ClaimResponseEvent>? _event;
private CodeableConcept? _payeeType;
private List<ReferenceType>? _encounter;
private CodeableConcept? _diagnosisRelatedGroup;
private List<ClaimResponseItem>? _item;
private List<ClaimResponseAddItem>? _addItem;
private List<ClaimResponseTotal>? _total;
private ClaimResponsePayment? _payment;
private CodeableConcept? _fundsReserve;
private CodeableConcept? _formCode;
private Attachment? _form;
private List<ClaimResponseProcessNote>? _processNote;
private List<ReferenceType>? _communicationRequest;
private List<ClaimResponseInsurance>? _insurance;
private List<ClaimResponseError>? _error;

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

public List<Identifier>? TraceNumber
{
get { return _traceNumber; }
set {
_traceNumber= value;
OnPropertyChanged("traceNumber", value);
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

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public CodeableConcept? SubType
{
get { return _subType; }
set {
_subType= value;
OnPropertyChanged("subType", value);
}
}

public FhirCode? Use
{
get { return _use; }
set {
_use= value;
OnPropertyChanged("use", value);
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

public FhirDateTime? Created
{
get { return _created; }
set {
_created= value;
OnPropertyChanged("created", value);
}
}

public ReferenceType? Insurer
{
get { return _insurer; }
set {
_insurer= value;
OnPropertyChanged("insurer", value);
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

public ReferenceType? Request
{
get { return _request; }
set {
_request= value;
OnPropertyChanged("request", value);
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

public CodeableConcept? Decision
{
get { return _decision; }
set {
_decision= value;
OnPropertyChanged("decision", value);
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

public FhirString? PreAuthRef
{
get { return _preAuthRef; }
set {
_preAuthRef= value;
OnPropertyChanged("preAuthRef", value);
}
}

public Period? PreAuthPeriod
{
get { return _preAuthPeriod; }
set {
_preAuthPeriod= value;
OnPropertyChanged("preAuthPeriod", value);
}
}

public List<ClaimResponseEvent>? Event
{
get { return _event; }
set {
_event= value;
OnPropertyChanged("event", value);
}
}

public CodeableConcept? PayeeType
{
get { return _payeeType; }
set {
_payeeType= value;
OnPropertyChanged("payeeType", value);
}
}

public List<ReferenceType>? Encounter
{
get { return _encounter; }
set {
_encounter= value;
OnPropertyChanged("encounter", value);
}
}

public CodeableConcept? DiagnosisRelatedGroup
{
get { return _diagnosisRelatedGroup; }
set {
_diagnosisRelatedGroup= value;
OnPropertyChanged("diagnosisRelatedGroup", value);
}
}

public List<ClaimResponseItem>? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}

public List<ClaimResponseAddItem>? AddItem
{
get { return _addItem; }
set {
_addItem= value;
OnPropertyChanged("addItem", value);
}
}

public List<ClaimResponseTotal>? Total
{
get { return _total; }
set {
_total= value;
OnPropertyChanged("total", value);
}
}

public ClaimResponsePayment? Payment
{
get { return _payment; }
set {
_payment= value;
OnPropertyChanged("payment", value);
}
}

public CodeableConcept? FundsReserve
{
get { return _fundsReserve; }
set {
_fundsReserve= value;
OnPropertyChanged("fundsReserve", value);
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

public Attachment? Form
{
get { return _form; }
set {
_form= value;
OnPropertyChanged("form", value);
}
}

public List<ClaimResponseProcessNote>? ProcessNote
{
get { return _processNote; }
set {
_processNote= value;
OnPropertyChanged("processNote", value);
}
}

public List<ReferenceType>? CommunicationRequest
{
get { return _communicationRequest; }
set {
_communicationRequest= value;
OnPropertyChanged("communicationRequest", value);
}
}

public List<ClaimResponseInsurance>? Insurance
{
get { return _insurance; }
set {
_insurance= value;
OnPropertyChanged("insurance", value);
}
}

public List<ClaimResponseError>? Error
{
get { return _error; }
set {
_error= value;
OnPropertyChanged("error", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponse() { }
		public  ClaimResponse(string value) : base(value) { }
		public  ClaimResponse(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ClaimResponseEvent : BackboneElementType<ClaimResponseEvent>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private ClaimResponseEventWhenChoice? _when;

		#endregion
		#region public Method
		public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public ClaimResponseEventWhenChoice? When
{
get { return _when; }
set {
_when= value;
OnPropertyChanged("when", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseEvent() { }
		public  ClaimResponseEvent(string value) : base(value) { }
		public  ClaimResponseEvent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseItemReviewOutcome : BackboneElementType<ClaimResponseItemReviewOutcome>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _decision;
private List<CodeableConcept>? _reason;
private FhirString? _preAuthRef;
private Period? _preAuthPeriod;

		#endregion
		#region public Method
		public CodeableConcept? Decision
{
get { return _decision; }
set {
_decision= value;
OnPropertyChanged("decision", value);
}
}

public List<CodeableConcept>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public FhirString? PreAuthRef
{
get { return _preAuthRef; }
set {
_preAuthRef= value;
OnPropertyChanged("preAuthRef", value);
}
}

public Period? PreAuthPeriod
{
get { return _preAuthPeriod; }
set {
_preAuthPeriod= value;
OnPropertyChanged("preAuthPeriod", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseItemReviewOutcome() { }
		public  ClaimResponseItemReviewOutcome(string value) : base(value) { }
		public  ClaimResponseItemReviewOutcome(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseItemAdjudication : BackboneElementType<ClaimResponseItemAdjudication>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _category;
private CodeableConcept? _reason;
private Money? _amount;
private Quantity? _quantity;

		#endregion
		#region public Method
		public CodeableConcept? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public CodeableConcept? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
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

public Quantity? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseItemAdjudication() { }
		public  ClaimResponseItemAdjudication(string value) : base(value) { }
		public  ClaimResponseItemAdjudication(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseItemDetailSubDetail : BackboneElementType<ClaimResponseItemDetailSubDetail>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _subDetailSequence;
private List<Identifier>? _traceNumber;
private List<FhirPositiveInt>? _noteNumber;

		#endregion
		#region public Method
		public FhirPositiveInt? SubDetailSequence
{
get { return _subDetailSequence; }
set {
_subDetailSequence= value;
OnPropertyChanged("subDetailSequence", value);
}
}

public List<Identifier>? TraceNumber
{
get { return _traceNumber; }
set {
_traceNumber= value;
OnPropertyChanged("traceNumber", value);
}
}

public List<FhirPositiveInt>? NoteNumber
{
get { return _noteNumber; }
set {
_noteNumber= value;
OnPropertyChanged("noteNumber", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseItemDetailSubDetail() { }
		public  ClaimResponseItemDetailSubDetail(string value) : base(value) { }
		public  ClaimResponseItemDetailSubDetail(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseItemDetail : BackboneElementType<ClaimResponseItemDetail>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _detailSequence;
private List<Identifier>? _traceNumber;
private List<FhirPositiveInt>? _noteNumber;
private List<ClaimResponseItemDetailSubDetail>? _subDetail;

		#endregion
		#region public Method
		public FhirPositiveInt? DetailSequence
{
get { return _detailSequence; }
set {
_detailSequence= value;
OnPropertyChanged("detailSequence", value);
}
}

public List<Identifier>? TraceNumber
{
get { return _traceNumber; }
set {
_traceNumber= value;
OnPropertyChanged("traceNumber", value);
}
}

public List<FhirPositiveInt>? NoteNumber
{
get { return _noteNumber; }
set {
_noteNumber= value;
OnPropertyChanged("noteNumber", value);
}
}

public List<ClaimResponseItemDetailSubDetail>? SubDetail
{
get { return _subDetail; }
set {
_subDetail= value;
OnPropertyChanged("subDetail", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseItemDetail() { }
		public  ClaimResponseItemDetail(string value) : base(value) { }
		public  ClaimResponseItemDetail(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseItem : BackboneElementType<ClaimResponseItem>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _itemSequence;
private List<Identifier>? _traceNumber;
private List<FhirPositiveInt>? _noteNumber;
private ClaimResponseItemReviewOutcome? _reviewOutcome;
private List<ClaimResponseItemAdjudication>? _adjudication;
private List<ClaimResponseItemDetail>? _detail;

		#endregion
		#region public Method
		public FhirPositiveInt? ItemSequence
{
get { return _itemSequence; }
set {
_itemSequence= value;
OnPropertyChanged("itemSequence", value);
}
}

public List<Identifier>? TraceNumber
{
get { return _traceNumber; }
set {
_traceNumber= value;
OnPropertyChanged("traceNumber", value);
}
}

public List<FhirPositiveInt>? NoteNumber
{
get { return _noteNumber; }
set {
_noteNumber= value;
OnPropertyChanged("noteNumber", value);
}
}

public ClaimResponseItemReviewOutcome? ReviewOutcome
{
get { return _reviewOutcome; }
set {
_reviewOutcome= value;
OnPropertyChanged("reviewOutcome", value);
}
}

public List<ClaimResponseItemAdjudication>? Adjudication
{
get { return _adjudication; }
set {
_adjudication= value;
OnPropertyChanged("adjudication", value);
}
}

public List<ClaimResponseItemDetail>? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseItem() { }
		public  ClaimResponseItem(string value) : base(value) { }
		public  ClaimResponseItem(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseAddItemBodySite : BackboneElementType<ClaimResponseAddItemBodySite>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableReference>? _site;
private List<CodeableConcept>? _subSite;

		#endregion
		#region public Method
		public List<CodeableReference>? Site
{
get { return _site; }
set {
_site= value;
OnPropertyChanged("site", value);
}
}

public List<CodeableConcept>? SubSite
{
get { return _subSite; }
set {
_subSite= value;
OnPropertyChanged("subSite", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseAddItemBodySite() { }
		public  ClaimResponseAddItemBodySite(string value) : base(value) { }
		public  ClaimResponseAddItemBodySite(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseAddItemDetailSubDetail : BackboneElementType<ClaimResponseAddItemDetailSubDetail>, IBackboneElementType
	{

		#region Private Method
		private List<Identifier>? _traceNumber;
private CodeableConcept? _revenue;
private CodeableConcept? _productOrService;
private CodeableConcept? _productOrServiceEnd;
private List<CodeableConcept>? _modifier;
private Quantity? _quantity;
private Money? _unitPrice;
private FhirDecimal? _factor;
private Money? _tax;
private Money? _net;
private List<FhirPositiveInt>? _noteNumber;

		#endregion
		#region public Method
		public List<Identifier>? TraceNumber
{
get { return _traceNumber; }
set {
_traceNumber= value;
OnPropertyChanged("traceNumber", value);
}
}

public CodeableConcept? Revenue
{
get { return _revenue; }
set {
_revenue= value;
OnPropertyChanged("revenue", value);
}
}

public CodeableConcept? ProductOrService
{
get { return _productOrService; }
set {
_productOrService= value;
OnPropertyChanged("productOrService", value);
}
}

public CodeableConcept? ProductOrServiceEnd
{
get { return _productOrServiceEnd; }
set {
_productOrServiceEnd= value;
OnPropertyChanged("productOrServiceEnd", value);
}
}

public List<CodeableConcept>? Modifier
{
get { return _modifier; }
set {
_modifier= value;
OnPropertyChanged("modifier", value);
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

public Money? UnitPrice
{
get { return _unitPrice; }
set {
_unitPrice= value;
OnPropertyChanged("unitPrice", value);
}
}

public FhirDecimal? Factor
{
get { return _factor; }
set {
_factor= value;
OnPropertyChanged("factor", value);
}
}

public Money? Tax
{
get { return _tax; }
set {
_tax= value;
OnPropertyChanged("tax", value);
}
}

public Money? Net
{
get { return _net; }
set {
_net= value;
OnPropertyChanged("net", value);
}
}

public List<FhirPositiveInt>? NoteNumber
{
get { return _noteNumber; }
set {
_noteNumber= value;
OnPropertyChanged("noteNumber", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseAddItemDetailSubDetail() { }
		public  ClaimResponseAddItemDetailSubDetail(string value) : base(value) { }
		public  ClaimResponseAddItemDetailSubDetail(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseAddItemDetail : BackboneElementType<ClaimResponseAddItemDetail>, IBackboneElementType
	{

		#region Private Method
		private List<Identifier>? _traceNumber;
private CodeableConcept? _revenue;
private CodeableConcept? _productOrService;
private CodeableConcept? _productOrServiceEnd;
private List<CodeableConcept>? _modifier;
private Quantity? _quantity;
private Money? _unitPrice;
private FhirDecimal? _factor;
private Money? _tax;
private Money? _net;
private List<FhirPositiveInt>? _noteNumber;
private List<ClaimResponseAddItemDetailSubDetail>? _subDetail;

		#endregion
		#region public Method
		public List<Identifier>? TraceNumber
{
get { return _traceNumber; }
set {
_traceNumber= value;
OnPropertyChanged("traceNumber", value);
}
}

public CodeableConcept? Revenue
{
get { return _revenue; }
set {
_revenue= value;
OnPropertyChanged("revenue", value);
}
}

public CodeableConcept? ProductOrService
{
get { return _productOrService; }
set {
_productOrService= value;
OnPropertyChanged("productOrService", value);
}
}

public CodeableConcept? ProductOrServiceEnd
{
get { return _productOrServiceEnd; }
set {
_productOrServiceEnd= value;
OnPropertyChanged("productOrServiceEnd", value);
}
}

public List<CodeableConcept>? Modifier
{
get { return _modifier; }
set {
_modifier= value;
OnPropertyChanged("modifier", value);
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

public Money? UnitPrice
{
get { return _unitPrice; }
set {
_unitPrice= value;
OnPropertyChanged("unitPrice", value);
}
}

public FhirDecimal? Factor
{
get { return _factor; }
set {
_factor= value;
OnPropertyChanged("factor", value);
}
}

public Money? Tax
{
get { return _tax; }
set {
_tax= value;
OnPropertyChanged("tax", value);
}
}

public Money? Net
{
get { return _net; }
set {
_net= value;
OnPropertyChanged("net", value);
}
}

public List<FhirPositiveInt>? NoteNumber
{
get { return _noteNumber; }
set {
_noteNumber= value;
OnPropertyChanged("noteNumber", value);
}
}

public List<ClaimResponseAddItemDetailSubDetail>? SubDetail
{
get { return _subDetail; }
set {
_subDetail= value;
OnPropertyChanged("subDetail", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseAddItemDetail() { }
		public  ClaimResponseAddItemDetail(string value) : base(value) { }
		public  ClaimResponseAddItemDetail(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseAddItem : BackboneElementType<ClaimResponseAddItem>, IBackboneElementType
	{

		#region Private Method
		private List<FhirPositiveInt>? _itemSequence;
private List<FhirPositiveInt>? _detailSequence;
private List<FhirPositiveInt>? _subdetailSequence;
private List<Identifier>? _traceNumber;
private List<ReferenceType>? _provider;
private CodeableConcept? _revenue;
private CodeableConcept? _productOrService;
private CodeableConcept? _productOrServiceEnd;
private List<ReferenceType>? _request;
private List<CodeableConcept>? _modifier;
private List<CodeableConcept>? _programCode;
private ClaimResponseAddItemServicedChoice? _serviced;
private ClaimResponseAddItemLocationChoice? _location;
private Quantity? _quantity;
private Money? _unitPrice;
private FhirDecimal? _factor;
private Money? _tax;
private Money? _net;
private List<ClaimResponseAddItemBodySite>? _bodySite;
private List<FhirPositiveInt>? _noteNumber;
private List<ClaimResponseAddItemDetail>? _detail;

		#endregion
		#region public Method
		public List<FhirPositiveInt>? ItemSequence
{
get { return _itemSequence; }
set {
_itemSequence= value;
OnPropertyChanged("itemSequence", value);
}
}

public List<FhirPositiveInt>? DetailSequence
{
get { return _detailSequence; }
set {
_detailSequence= value;
OnPropertyChanged("detailSequence", value);
}
}

public List<FhirPositiveInt>? SubdetailSequence
{
get { return _subdetailSequence; }
set {
_subdetailSequence= value;
OnPropertyChanged("subdetailSequence", value);
}
}

public List<Identifier>? TraceNumber
{
get { return _traceNumber; }
set {
_traceNumber= value;
OnPropertyChanged("traceNumber", value);
}
}

public List<ReferenceType>? Provider
{
get { return _provider; }
set {
_provider= value;
OnPropertyChanged("provider", value);
}
}

public CodeableConcept? Revenue
{
get { return _revenue; }
set {
_revenue= value;
OnPropertyChanged("revenue", value);
}
}

public CodeableConcept? ProductOrService
{
get { return _productOrService; }
set {
_productOrService= value;
OnPropertyChanged("productOrService", value);
}
}

public CodeableConcept? ProductOrServiceEnd
{
get { return _productOrServiceEnd; }
set {
_productOrServiceEnd= value;
OnPropertyChanged("productOrServiceEnd", value);
}
}

public List<ReferenceType>? Request
{
get { return _request; }
set {
_request= value;
OnPropertyChanged("request", value);
}
}

public List<CodeableConcept>? Modifier
{
get { return _modifier; }
set {
_modifier= value;
OnPropertyChanged("modifier", value);
}
}

public List<CodeableConcept>? ProgramCode
{
get { return _programCode; }
set {
_programCode= value;
OnPropertyChanged("programCode", value);
}
}

public ClaimResponseAddItemServicedChoice? Serviced
{
get { return _serviced; }
set {
_serviced= value;
OnPropertyChanged("serviced", value);
}
}

public ClaimResponseAddItemLocationChoice? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
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

public Money? UnitPrice
{
get { return _unitPrice; }
set {
_unitPrice= value;
OnPropertyChanged("unitPrice", value);
}
}

public FhirDecimal? Factor
{
get { return _factor; }
set {
_factor= value;
OnPropertyChanged("factor", value);
}
}

public Money? Tax
{
get { return _tax; }
set {
_tax= value;
OnPropertyChanged("tax", value);
}
}

public Money? Net
{
get { return _net; }
set {
_net= value;
OnPropertyChanged("net", value);
}
}

public List<ClaimResponseAddItemBodySite>? BodySite
{
get { return _bodySite; }
set {
_bodySite= value;
OnPropertyChanged("bodySite", value);
}
}

public List<FhirPositiveInt>? NoteNumber
{
get { return _noteNumber; }
set {
_noteNumber= value;
OnPropertyChanged("noteNumber", value);
}
}

public List<ClaimResponseAddItemDetail>? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseAddItem() { }
		public  ClaimResponseAddItem(string value) : base(value) { }
		public  ClaimResponseAddItem(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseTotal : BackboneElementType<ClaimResponseTotal>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _category;
private Money? _amount;

		#endregion
		#region public Method
		public CodeableConcept? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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
		public  ClaimResponseTotal() { }
		public  ClaimResponseTotal(string value) : base(value) { }
		public  ClaimResponseTotal(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponsePayment : BackboneElementType<ClaimResponsePayment>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private Money? _adjustment;
private CodeableConcept? _adjustmentReason;
private FhirDate? _date;
private Money? _amount;
private Identifier? _identifier;

		#endregion
		#region public Method
		public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public Money? Adjustment
{
get { return _adjustment; }
set {
_adjustment= value;
OnPropertyChanged("adjustment", value);
}
}

public CodeableConcept? AdjustmentReason
{
get { return _adjustmentReason; }
set {
_adjustmentReason= value;
OnPropertyChanged("adjustmentReason", value);
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

public Money? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}

public Identifier? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponsePayment() { }
		public  ClaimResponsePayment(string value) : base(value) { }
		public  ClaimResponsePayment(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseProcessNote : BackboneElementType<ClaimResponseProcessNote>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _number;
private CodeableConcept? _type;
private CodeableConcept? _language;

		#endregion
		#region public Method
		public FhirPositiveInt? Number
{
get { return _number; }
set {
_number= value;
OnPropertyChanged("number", value);
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

public CodeableConcept? Language
{
get { return _language; }
set {
_language= value;
OnPropertyChanged("language", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseProcessNote() { }
		public  ClaimResponseProcessNote(string value) : base(value) { }
		public  ClaimResponseProcessNote(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseInsurance : BackboneElementType<ClaimResponseInsurance>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private FhirBoolean? _focal;
private ReferenceType? _coverage;
private FhirString? _businessArrangement;
private ReferenceType? _claimResponse;

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

public FhirBoolean? Focal
{
get { return _focal; }
set {
_focal= value;
OnPropertyChanged("focal", value);
}
}

public ReferenceType? Coverage
{
get { return _coverage; }
set {
_coverage= value;
OnPropertyChanged("coverage", value);
}
}

public FhirString? BusinessArrangement
{
get { return _businessArrangement; }
set {
_businessArrangement= value;
OnPropertyChanged("businessArrangement", value);
}
}

public ReferenceType? ClaimResponse
{
get { return _claimResponse; }
set {
_claimResponse= value;
OnPropertyChanged("claimResponse", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseInsurance() { }
		public  ClaimResponseInsurance(string value) : base(value) { }
		public  ClaimResponseInsurance(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimResponseError : BackboneElementType<ClaimResponseError>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _itemSequence;
private FhirPositiveInt? _detailSequence;
private FhirPositiveInt? _subDetailSequence;
private CodeableConcept? _code;
private List<FhirString>? _expression;

		#endregion
		#region public Method
		public FhirPositiveInt? ItemSequence
{
get { return _itemSequence; }
set {
_itemSequence= value;
OnPropertyChanged("itemSequence", value);
}
}

public FhirPositiveInt? DetailSequence
{
get { return _detailSequence; }
set {
_detailSequence= value;
OnPropertyChanged("detailSequence", value);
}
}

public FhirPositiveInt? SubDetailSequence
{
get { return _subDetailSequence; }
set {
_subDetailSequence= value;
OnPropertyChanged("subDetailSequence", value);
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

public List<FhirString>? Expression
{
get { return _expression; }
set {
_expression= value;
OnPropertyChanged("expression", value);
}
}


		#endregion
		#region Constructor
		public  ClaimResponseError() { }
		public  ClaimResponseError(string value) : base(value) { }
		public  ClaimResponseError(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ClaimResponseEventWhenChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public ClaimResponseEventWhenChoice(JsonObject value) : base("when", value, _supportType)
        {
        }
        public ClaimResponseEventWhenChoice(IComplexType? value) : base("when", value)
        {
        }
        public ClaimResponseEventWhenChoice(IPrimitiveType? value) : base("when", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"when".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ClaimResponseAddItemServicedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "date","Period"
        ];

        public ClaimResponseAddItemServicedChoice(JsonObject value) : base("serviced", value, _supportType)
        {
        }
        public ClaimResponseAddItemServicedChoice(IComplexType? value) : base("serviced", value)
        {
        }
        public ClaimResponseAddItemServicedChoice(IPrimitiveType? value) : base("serviced", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"serviced".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ClaimResponseAddItemLocationChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","AddressReference(Location)"
        ];

        public ClaimResponseAddItemLocationChoice(JsonObject value) : base("location", value, _supportType)
        {
        }
        public ClaimResponseAddItemLocationChoice(IComplexType? value) : base("location", value)
        {
        }
        public ClaimResponseAddItemLocationChoice(IPrimitiveType? value) : base("location", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"location".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
