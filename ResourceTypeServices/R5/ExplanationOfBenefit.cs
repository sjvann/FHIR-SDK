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
    public class ExplanationOfBenefit : ResourceType<ExplanationOfBenefit>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<Identifier>? _traceNumber;
private FhirCode? _status;
private CodeableConcept? _type;
private CodeableConcept? _subType;
private FhirCode? _use;
private ReferenceType? _patient;
private Period? _billablePeriod;
private FhirDateTime? _created;
private ReferenceType? _enterer;
private ReferenceType? _insurer;
private ReferenceType? _provider;
private CodeableConcept? _priority;
private CodeableConcept? _fundsReserveRequested;
private CodeableConcept? _fundsReserve;
private List<ExplanationOfBenefitRelated>? _related;
private ReferenceType? _prescription;
private ReferenceType? _originalPrescription;
private List<ExplanationOfBenefitEvent>? _event;
private ExplanationOfBenefitPayee? _payee;
private ReferenceType? _referral;
private List<ReferenceType>? _encounter;
private ReferenceType? _facility;
private ReferenceType? _claim;
private ReferenceType? _claimResponse;
private FhirCode? _outcome;
private CodeableConcept? _decision;
private FhirString? _disposition;
private List<FhirString>? _preAuthRef;
private List<Period>? _preAuthRefPeriod;
private CodeableConcept? _diagnosisRelatedGroup;
private List<ExplanationOfBenefitCareTeam>? _careTeam;
private List<ExplanationOfBenefitSupportingInfo>? _supportingInfo;
private List<ExplanationOfBenefitDiagnosis>? _diagnosis;
private List<ExplanationOfBenefitProcedure>? _procedure;
private FhirPositiveInt? _precedence;
private List<ExplanationOfBenefitInsurance>? _insurance;
private ExplanationOfBenefitAccident? _accident;
private Money? _patientPaid;
private List<ExplanationOfBenefitItem>? _item;
private List<ExplanationOfBenefitAddItem>? _addItem;
private List<ExplanationOfBenefitTotal>? _total;
private ExplanationOfBenefitPayment? _payment;
private CodeableConcept? _formCode;
private Attachment? _form;
private List<ExplanationOfBenefitProcessNote>? _processNote;
private Period? _benefitPeriod;
private List<ExplanationOfBenefitBenefitBalance>? _benefitBalance;

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

public Period? BillablePeriod
{
get { return _billablePeriod; }
set {
_billablePeriod= value;
OnPropertyChanged("billablePeriod", value);
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

public ReferenceType? Insurer
{
get { return _insurer; }
set {
_insurer= value;
OnPropertyChanged("insurer", value);
}
}

public ReferenceType? Provider
{
get { return _provider; }
set {
_provider= value;
OnPropertyChanged("provider", value);
}
}

public CodeableConcept? Priority
{
get { return _priority; }
set {
_priority= value;
OnPropertyChanged("priority", value);
}
}

public CodeableConcept? FundsReserveRequested
{
get { return _fundsReserveRequested; }
set {
_fundsReserveRequested= value;
OnPropertyChanged("fundsReserveRequested", value);
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

public List<ExplanationOfBenefitRelated>? Related
{
get { return _related; }
set {
_related= value;
OnPropertyChanged("related", value);
}
}

public ReferenceType? Prescription
{
get { return _prescription; }
set {
_prescription= value;
OnPropertyChanged("prescription", value);
}
}

public ReferenceType? OriginalPrescription
{
get { return _originalPrescription; }
set {
_originalPrescription= value;
OnPropertyChanged("originalPrescription", value);
}
}

public List<ExplanationOfBenefitEvent>? Event
{
get { return _event; }
set {
_event= value;
OnPropertyChanged("event", value);
}
}

public ExplanationOfBenefitPayee? Payee
{
get { return _payee; }
set {
_payee= value;
OnPropertyChanged("payee", value);
}
}

public ReferenceType? Referral
{
get { return _referral; }
set {
_referral= value;
OnPropertyChanged("referral", value);
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

public ReferenceType? Facility
{
get { return _facility; }
set {
_facility= value;
OnPropertyChanged("facility", value);
}
}

public ReferenceType? Claim
{
get { return _claim; }
set {
_claim= value;
OnPropertyChanged("claim", value);
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

public List<FhirString>? PreAuthRef
{
get { return _preAuthRef; }
set {
_preAuthRef= value;
OnPropertyChanged("preAuthRef", value);
}
}

public List<Period>? PreAuthRefPeriod
{
get { return _preAuthRefPeriod; }
set {
_preAuthRefPeriod= value;
OnPropertyChanged("preAuthRefPeriod", value);
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

public List<ExplanationOfBenefitCareTeam>? CareTeam
{
get { return _careTeam; }
set {
_careTeam= value;
OnPropertyChanged("careTeam", value);
}
}

public List<ExplanationOfBenefitSupportingInfo>? SupportingInfo
{
get { return _supportingInfo; }
set {
_supportingInfo= value;
OnPropertyChanged("supportingInfo", value);
}
}

public List<ExplanationOfBenefitDiagnosis>? Diagnosis
{
get { return _diagnosis; }
set {
_diagnosis= value;
OnPropertyChanged("diagnosis", value);
}
}

public List<ExplanationOfBenefitProcedure>? Procedure
{
get { return _procedure; }
set {
_procedure= value;
OnPropertyChanged("procedure", value);
}
}

public FhirPositiveInt? Precedence
{
get { return _precedence; }
set {
_precedence= value;
OnPropertyChanged("precedence", value);
}
}

public List<ExplanationOfBenefitInsurance>? Insurance
{
get { return _insurance; }
set {
_insurance= value;
OnPropertyChanged("insurance", value);
}
}

public ExplanationOfBenefitAccident? Accident
{
get { return _accident; }
set {
_accident= value;
OnPropertyChanged("accident", value);
}
}

public Money? PatientPaid
{
get { return _patientPaid; }
set {
_patientPaid= value;
OnPropertyChanged("patientPaid", value);
}
}

public List<ExplanationOfBenefitItem>? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}

public List<ExplanationOfBenefitAddItem>? AddItem
{
get { return _addItem; }
set {
_addItem= value;
OnPropertyChanged("addItem", value);
}
}

public List<ExplanationOfBenefitTotal>? Total
{
get { return _total; }
set {
_total= value;
OnPropertyChanged("total", value);
}
}

public ExplanationOfBenefitPayment? Payment
{
get { return _payment; }
set {
_payment= value;
OnPropertyChanged("payment", value);
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

public List<ExplanationOfBenefitProcessNote>? ProcessNote
{
get { return _processNote; }
set {
_processNote= value;
OnPropertyChanged("processNote", value);
}
}

public Period? BenefitPeriod
{
get { return _benefitPeriod; }
set {
_benefitPeriod= value;
OnPropertyChanged("benefitPeriod", value);
}
}

public List<ExplanationOfBenefitBenefitBalance>? BenefitBalance
{
get { return _benefitBalance; }
set {
_benefitBalance= value;
OnPropertyChanged("benefitBalance", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefit() { }
		public  ExplanationOfBenefit(string value) : base(value) { }
		public  ExplanationOfBenefit(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ExplanationOfBenefitRelated : BackboneElementType<ExplanationOfBenefitRelated>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _claim;
private CodeableConcept? _relationship;
private Identifier? _reference;

		#endregion
		#region public Method
		public ReferenceType? Claim
{
get { return _claim; }
set {
_claim= value;
OnPropertyChanged("claim", value);
}
}

public CodeableConcept? Relationship
{
get { return _relationship; }
set {
_relationship= value;
OnPropertyChanged("relationship", value);
}
}

public Identifier? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitRelated() { }
		public  ExplanationOfBenefitRelated(string value) : base(value) { }
		public  ExplanationOfBenefitRelated(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitEvent : BackboneElementType<ExplanationOfBenefitEvent>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private ExplanationOfBenefitEventWhenChoice? _when;

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

public ExplanationOfBenefitEventWhenChoice? When
{
get { return _when; }
set {
_when= value;
OnPropertyChanged("when", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitEvent() { }
		public  ExplanationOfBenefitEvent(string value) : base(value) { }
		public  ExplanationOfBenefitEvent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitPayee : BackboneElementType<ExplanationOfBenefitPayee>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private ReferenceType? _party;

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

public ReferenceType? Party
{
get { return _party; }
set {
_party= value;
OnPropertyChanged("party", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitPayee() { }
		public  ExplanationOfBenefitPayee(string value) : base(value) { }
		public  ExplanationOfBenefitPayee(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitCareTeam : BackboneElementType<ExplanationOfBenefitCareTeam>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private ReferenceType? _provider;
private FhirBoolean? _responsible;
private CodeableConcept? _role;
private CodeableConcept? _specialty;

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

public ReferenceType? Provider
{
get { return _provider; }
set {
_provider= value;
OnPropertyChanged("provider", value);
}
}

public FhirBoolean? Responsible
{
get { return _responsible; }
set {
_responsible= value;
OnPropertyChanged("responsible", value);
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

public CodeableConcept? Specialty
{
get { return _specialty; }
set {
_specialty= value;
OnPropertyChanged("specialty", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitCareTeam() { }
		public  ExplanationOfBenefitCareTeam(string value) : base(value) { }
		public  ExplanationOfBenefitCareTeam(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitSupportingInfo : BackboneElementType<ExplanationOfBenefitSupportingInfo>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private CodeableConcept? _category;
private CodeableConcept? _code;
private ExplanationOfBenefitSupportingInfoTimingChoice? _timing;
private ExplanationOfBenefitSupportingInfoValueChoice? _value;
private Coding? _reason;

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

public CodeableConcept? Category
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

public ExplanationOfBenefitSupportingInfoTimingChoice? Timing
{
get { return _timing; }
set {
_timing= value;
OnPropertyChanged("timing", value);
}
}

public ExplanationOfBenefitSupportingInfoValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public Coding? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitSupportingInfo() { }
		public  ExplanationOfBenefitSupportingInfo(string value) : base(value) { }
		public  ExplanationOfBenefitSupportingInfo(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitDiagnosis : BackboneElementType<ExplanationOfBenefitDiagnosis>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private ExplanationOfBenefitDiagnosisDiagnosisChoice? _diagnosis;
private List<CodeableConcept>? _type;
private CodeableConcept? _onAdmission;

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

public ExplanationOfBenefitDiagnosisDiagnosisChoice? Diagnosis
{
get { return _diagnosis; }
set {
_diagnosis= value;
OnPropertyChanged("diagnosis", value);
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

public CodeableConcept? OnAdmission
{
get { return _onAdmission; }
set {
_onAdmission= value;
OnPropertyChanged("onAdmission", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitDiagnosis() { }
		public  ExplanationOfBenefitDiagnosis(string value) : base(value) { }
		public  ExplanationOfBenefitDiagnosis(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitProcedure : BackboneElementType<ExplanationOfBenefitProcedure>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private List<CodeableConcept>? _type;
private FhirDateTime? _date;
private ExplanationOfBenefitProcedureProcedureChoice? _procedure;
private List<ReferenceType>? _udi;

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

public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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

public ExplanationOfBenefitProcedureProcedureChoice? Procedure
{
get { return _procedure; }
set {
_procedure= value;
OnPropertyChanged("procedure", value);
}
}

public List<ReferenceType>? Udi
{
get { return _udi; }
set {
_udi= value;
OnPropertyChanged("udi", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitProcedure() { }
		public  ExplanationOfBenefitProcedure(string value) : base(value) { }
		public  ExplanationOfBenefitProcedure(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitInsurance : BackboneElementType<ExplanationOfBenefitInsurance>, IBackboneElementType
	{

		#region Private Method
		private FhirBoolean? _focal;
private ReferenceType? _coverage;
private List<FhirString>? _preAuthRef;

		#endregion
		#region public Method
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

public List<FhirString>? PreAuthRef
{
get { return _preAuthRef; }
set {
_preAuthRef= value;
OnPropertyChanged("preAuthRef", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitInsurance() { }
		public  ExplanationOfBenefitInsurance(string value) : base(value) { }
		public  ExplanationOfBenefitInsurance(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitAccident : BackboneElementType<ExplanationOfBenefitAccident>, IBackboneElementType
	{

		#region Private Method
		private FhirDate? _date;
private CodeableConcept? _type;
private ExplanationOfBenefitAccidentLocationChoice? _location;

		#endregion
		#region public Method
		public FhirDate? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
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

public ExplanationOfBenefitAccidentLocationChoice? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitAccident() { }
		public  ExplanationOfBenefitAccident(string value) : base(value) { }
		public  ExplanationOfBenefitAccident(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitItemBodySite : BackboneElementType<ExplanationOfBenefitItemBodySite>, IBackboneElementType
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
		public  ExplanationOfBenefitItemBodySite() { }
		public  ExplanationOfBenefitItemBodySite(string value) : base(value) { }
		public  ExplanationOfBenefitItemBodySite(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitItemReviewOutcome : BackboneElementType<ExplanationOfBenefitItemReviewOutcome>, IBackboneElementType
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
		public  ExplanationOfBenefitItemReviewOutcome() { }
		public  ExplanationOfBenefitItemReviewOutcome(string value) : base(value) { }
		public  ExplanationOfBenefitItemReviewOutcome(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitItemAdjudication : BackboneElementType<ExplanationOfBenefitItemAdjudication>, IBackboneElementType
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
		public  ExplanationOfBenefitItemAdjudication() { }
		public  ExplanationOfBenefitItemAdjudication(string value) : base(value) { }
		public  ExplanationOfBenefitItemAdjudication(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitItemDetailSubDetail : BackboneElementType<ExplanationOfBenefitItemDetailSubDetail>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private List<Identifier>? _traceNumber;
private CodeableConcept? _revenue;
private CodeableConcept? _category;
private CodeableConcept? _productOrService;
private CodeableConcept? _productOrServiceEnd;
private List<CodeableConcept>? _modifier;
private List<CodeableConcept>? _programCode;
private Money? _patientPaid;
private Quantity? _quantity;
private Money? _unitPrice;
private FhirDecimal? _factor;
private Money? _tax;
private Money? _net;
private List<ReferenceType>? _udi;
private List<FhirPositiveInt>? _noteNumber;

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

public CodeableConcept? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public List<CodeableConcept>? ProgramCode
{
get { return _programCode; }
set {
_programCode= value;
OnPropertyChanged("programCode", value);
}
}

public Money? PatientPaid
{
get { return _patientPaid; }
set {
_patientPaid= value;
OnPropertyChanged("patientPaid", value);
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

public List<ReferenceType>? Udi
{
get { return _udi; }
set {
_udi= value;
OnPropertyChanged("udi", value);
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
		public  ExplanationOfBenefitItemDetailSubDetail() { }
		public  ExplanationOfBenefitItemDetailSubDetail(string value) : base(value) { }
		public  ExplanationOfBenefitItemDetailSubDetail(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitItemDetail : BackboneElementType<ExplanationOfBenefitItemDetail>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private List<Identifier>? _traceNumber;
private CodeableConcept? _revenue;
private CodeableConcept? _category;
private CodeableConcept? _productOrService;
private CodeableConcept? _productOrServiceEnd;
private List<CodeableConcept>? _modifier;
private List<CodeableConcept>? _programCode;
private Money? _patientPaid;
private Quantity? _quantity;
private Money? _unitPrice;
private FhirDecimal? _factor;
private Money? _tax;
private Money? _net;
private List<ReferenceType>? _udi;
private List<FhirPositiveInt>? _noteNumber;
private List<ExplanationOfBenefitItemDetailSubDetail>? _subDetail;

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

public CodeableConcept? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public List<CodeableConcept>? ProgramCode
{
get { return _programCode; }
set {
_programCode= value;
OnPropertyChanged("programCode", value);
}
}

public Money? PatientPaid
{
get { return _patientPaid; }
set {
_patientPaid= value;
OnPropertyChanged("patientPaid", value);
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

public List<ReferenceType>? Udi
{
get { return _udi; }
set {
_udi= value;
OnPropertyChanged("udi", value);
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

public List<ExplanationOfBenefitItemDetailSubDetail>? SubDetail
{
get { return _subDetail; }
set {
_subDetail= value;
OnPropertyChanged("subDetail", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitItemDetail() { }
		public  ExplanationOfBenefitItemDetail(string value) : base(value) { }
		public  ExplanationOfBenefitItemDetail(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitItem : BackboneElementType<ExplanationOfBenefitItem>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private List<FhirPositiveInt>? _careTeamSequence;
private List<FhirPositiveInt>? _diagnosisSequence;
private List<FhirPositiveInt>? _procedureSequence;
private List<FhirPositiveInt>? _informationSequence;
private List<Identifier>? _traceNumber;
private CodeableConcept? _revenue;
private CodeableConcept? _category;
private CodeableConcept? _productOrService;
private CodeableConcept? _productOrServiceEnd;
private List<ReferenceType>? _request;
private List<CodeableConcept>? _modifier;
private List<CodeableConcept>? _programCode;
private ExplanationOfBenefitItemServicedChoice? _serviced;
private ExplanationOfBenefitItemLocationChoice? _location;
private Money? _patientPaid;
private Quantity? _quantity;
private Money? _unitPrice;
private FhirDecimal? _factor;
private Money? _tax;
private Money? _net;
private List<ReferenceType>? _udi;
private List<ExplanationOfBenefitItemBodySite>? _bodySite;
private List<ReferenceType>? _encounter;
private List<FhirPositiveInt>? _noteNumber;
private ExplanationOfBenefitItemReviewOutcome? _reviewOutcome;
private List<ExplanationOfBenefitItemAdjudication>? _adjudication;
private List<ExplanationOfBenefitItemDetail>? _detail;

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

public List<FhirPositiveInt>? CareTeamSequence
{
get { return _careTeamSequence; }
set {
_careTeamSequence= value;
OnPropertyChanged("careTeamSequence", value);
}
}

public List<FhirPositiveInt>? DiagnosisSequence
{
get { return _diagnosisSequence; }
set {
_diagnosisSequence= value;
OnPropertyChanged("diagnosisSequence", value);
}
}

public List<FhirPositiveInt>? ProcedureSequence
{
get { return _procedureSequence; }
set {
_procedureSequence= value;
OnPropertyChanged("procedureSequence", value);
}
}

public List<FhirPositiveInt>? InformationSequence
{
get { return _informationSequence; }
set {
_informationSequence= value;
OnPropertyChanged("informationSequence", value);
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

public CodeableConcept? Revenue
{
get { return _revenue; }
set {
_revenue= value;
OnPropertyChanged("revenue", value);
}
}

public CodeableConcept? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public ExplanationOfBenefitItemServicedChoice? Serviced
{
get { return _serviced; }
set {
_serviced= value;
OnPropertyChanged("serviced", value);
}
}

public ExplanationOfBenefitItemLocationChoice? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public Money? PatientPaid
{
get { return _patientPaid; }
set {
_patientPaid= value;
OnPropertyChanged("patientPaid", value);
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

public List<ReferenceType>? Udi
{
get { return _udi; }
set {
_udi= value;
OnPropertyChanged("udi", value);
}
}

public List<ExplanationOfBenefitItemBodySite>? BodySite
{
get { return _bodySite; }
set {
_bodySite= value;
OnPropertyChanged("bodySite", value);
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

public List<FhirPositiveInt>? NoteNumber
{
get { return _noteNumber; }
set {
_noteNumber= value;
OnPropertyChanged("noteNumber", value);
}
}

public ExplanationOfBenefitItemReviewOutcome? ReviewOutcome
{
get { return _reviewOutcome; }
set {
_reviewOutcome= value;
OnPropertyChanged("reviewOutcome", value);
}
}

public List<ExplanationOfBenefitItemAdjudication>? Adjudication
{
get { return _adjudication; }
set {
_adjudication= value;
OnPropertyChanged("adjudication", value);
}
}

public List<ExplanationOfBenefitItemDetail>? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitItem() { }
		public  ExplanationOfBenefitItem(string value) : base(value) { }
		public  ExplanationOfBenefitItem(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitAddItemBodySite : BackboneElementType<ExplanationOfBenefitAddItemBodySite>, IBackboneElementType
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
		public  ExplanationOfBenefitAddItemBodySite() { }
		public  ExplanationOfBenefitAddItemBodySite(string value) : base(value) { }
		public  ExplanationOfBenefitAddItemBodySite(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitAddItemDetailSubDetail : BackboneElementType<ExplanationOfBenefitAddItemDetailSubDetail>, IBackboneElementType
	{

		#region Private Method
		private List<Identifier>? _traceNumber;
private CodeableConcept? _revenue;
private CodeableConcept? _productOrService;
private CodeableConcept? _productOrServiceEnd;
private List<CodeableConcept>? _modifier;
private Money? _patientPaid;
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

public Money? PatientPaid
{
get { return _patientPaid; }
set {
_patientPaid= value;
OnPropertyChanged("patientPaid", value);
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
		public  ExplanationOfBenefitAddItemDetailSubDetail() { }
		public  ExplanationOfBenefitAddItemDetailSubDetail(string value) : base(value) { }
		public  ExplanationOfBenefitAddItemDetailSubDetail(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitAddItemDetail : BackboneElementType<ExplanationOfBenefitAddItemDetail>, IBackboneElementType
	{

		#region Private Method
		private List<Identifier>? _traceNumber;
private CodeableConcept? _revenue;
private CodeableConcept? _productOrService;
private CodeableConcept? _productOrServiceEnd;
private List<CodeableConcept>? _modifier;
private Money? _patientPaid;
private Quantity? _quantity;
private Money? _unitPrice;
private FhirDecimal? _factor;
private Money? _tax;
private Money? _net;
private List<FhirPositiveInt>? _noteNumber;
private List<ExplanationOfBenefitAddItemDetailSubDetail>? _subDetail;

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

public Money? PatientPaid
{
get { return _patientPaid; }
set {
_patientPaid= value;
OnPropertyChanged("patientPaid", value);
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

public List<ExplanationOfBenefitAddItemDetailSubDetail>? SubDetail
{
get { return _subDetail; }
set {
_subDetail= value;
OnPropertyChanged("subDetail", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitAddItemDetail() { }
		public  ExplanationOfBenefitAddItemDetail(string value) : base(value) { }
		public  ExplanationOfBenefitAddItemDetail(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitAddItem : BackboneElementType<ExplanationOfBenefitAddItem>, IBackboneElementType
	{

		#region Private Method
		private List<FhirPositiveInt>? _itemSequence;
private List<FhirPositiveInt>? _detailSequence;
private List<FhirPositiveInt>? _subDetailSequence;
private List<Identifier>? _traceNumber;
private List<ReferenceType>? _provider;
private CodeableConcept? _revenue;
private CodeableConcept? _productOrService;
private CodeableConcept? _productOrServiceEnd;
private List<ReferenceType>? _request;
private List<CodeableConcept>? _modifier;
private List<CodeableConcept>? _programCode;
private ExplanationOfBenefitAddItemServicedChoice? _serviced;
private ExplanationOfBenefitAddItemLocationChoice? _location;
private Money? _patientPaid;
private Quantity? _quantity;
private Money? _unitPrice;
private FhirDecimal? _factor;
private Money? _tax;
private Money? _net;
private List<ExplanationOfBenefitAddItemBodySite>? _bodySite;
private List<FhirPositiveInt>? _noteNumber;
private List<ExplanationOfBenefitAddItemDetail>? _detail;

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

public List<FhirPositiveInt>? SubDetailSequence
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

public ExplanationOfBenefitAddItemServicedChoice? Serviced
{
get { return _serviced; }
set {
_serviced= value;
OnPropertyChanged("serviced", value);
}
}

public ExplanationOfBenefitAddItemLocationChoice? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public Money? PatientPaid
{
get { return _patientPaid; }
set {
_patientPaid= value;
OnPropertyChanged("patientPaid", value);
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

public List<ExplanationOfBenefitAddItemBodySite>? BodySite
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

public List<ExplanationOfBenefitAddItemDetail>? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitAddItem() { }
		public  ExplanationOfBenefitAddItem(string value) : base(value) { }
		public  ExplanationOfBenefitAddItem(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitTotal : BackboneElementType<ExplanationOfBenefitTotal>, IBackboneElementType
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
		public  ExplanationOfBenefitTotal() { }
		public  ExplanationOfBenefitTotal(string value) : base(value) { }
		public  ExplanationOfBenefitTotal(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitPayment : BackboneElementType<ExplanationOfBenefitPayment>, IBackboneElementType
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
		public  ExplanationOfBenefitPayment() { }
		public  ExplanationOfBenefitPayment(string value) : base(value) { }
		public  ExplanationOfBenefitPayment(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitProcessNote : BackboneElementType<ExplanationOfBenefitProcessNote>, IBackboneElementType
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
		public  ExplanationOfBenefitProcessNote() { }
		public  ExplanationOfBenefitProcessNote(string value) : base(value) { }
		public  ExplanationOfBenefitProcessNote(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitBenefitBalanceFinancial : BackboneElementType<ExplanationOfBenefitBenefitBalanceFinancial>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice? _allowed;
private ExplanationOfBenefitBenefitBalanceFinancialUsedChoice? _used;

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

public ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice? Allowed
{
get { return _allowed; }
set {
_allowed= value;
OnPropertyChanged("allowed", value);
}
}

public ExplanationOfBenefitBenefitBalanceFinancialUsedChoice? Used
{
get { return _used; }
set {
_used= value;
OnPropertyChanged("used", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitBenefitBalanceFinancial() { }
		public  ExplanationOfBenefitBenefitBalanceFinancial(string value) : base(value) { }
		public  ExplanationOfBenefitBenefitBalanceFinancial(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ExplanationOfBenefitBenefitBalance : BackboneElementType<ExplanationOfBenefitBenefitBalance>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _category;
private FhirBoolean? _excluded;
private FhirString? _name;
private FhirString? _description;
private CodeableConcept? _network;
private CodeableConcept? _unit;
private CodeableConcept? _term;
private List<ExplanationOfBenefitBenefitBalanceFinancial>? _financial;

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

public FhirBoolean? Excluded
{
get { return _excluded; }
set {
_excluded= value;
OnPropertyChanged("excluded", value);
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

public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public CodeableConcept? Network
{
get { return _network; }
set {
_network= value;
OnPropertyChanged("network", value);
}
}

public CodeableConcept? Unit
{
get { return _unit; }
set {
_unit= value;
OnPropertyChanged("unit", value);
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

public List<ExplanationOfBenefitBenefitBalanceFinancial>? Financial
{
get { return _financial; }
set {
_financial= value;
OnPropertyChanged("financial", value);
}
}


		#endregion
		#region Constructor
		public  ExplanationOfBenefitBenefitBalance() { }
		public  ExplanationOfBenefitBenefitBalance(string value) : base(value) { }
		public  ExplanationOfBenefitBenefitBalance(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ExplanationOfBenefitEventWhenChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public ExplanationOfBenefitEventWhenChoice(JsonObject value) : base("when", value, _supportType)
        {
        }
        public ExplanationOfBenefitEventWhenChoice(IComplexType? value) : base("when", value)
        {
        }
        public ExplanationOfBenefitEventWhenChoice(IPrimitiveType? value) : base("when", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"when".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ExplanationOfBenefitSupportingInfoTimingChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "date","Period"
        ];

        public ExplanationOfBenefitSupportingInfoTimingChoice(JsonObject value) : base("timing", value, _supportType)
        {
        }
        public ExplanationOfBenefitSupportingInfoTimingChoice(IComplexType? value) : base("timing", value)
        {
        }
        public ExplanationOfBenefitSupportingInfoTimingChoice(IPrimitiveType? value) : base("timing", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"timing".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ExplanationOfBenefitSupportingInfoValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","stringQuantityAttachmentReference(Resource)Identifier"
        ];

        public ExplanationOfBenefitSupportingInfoValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ExplanationOfBenefitSupportingInfoValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ExplanationOfBenefitSupportingInfoValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ExplanationOfBenefitDiagnosisDiagnosisChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Condition)"
        ];

        public ExplanationOfBenefitDiagnosisDiagnosisChoice(JsonObject value) : base("diagnosis", value, _supportType)
        {
        }
        public ExplanationOfBenefitDiagnosisDiagnosisChoice(IComplexType? value) : base("diagnosis", value)
        {
        }
        public ExplanationOfBenefitDiagnosisDiagnosisChoice(IPrimitiveType? value) : base("diagnosis", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"diagnosis".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ExplanationOfBenefitProcedureProcedureChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Procedure)"
        ];

        public ExplanationOfBenefitProcedureProcedureChoice(JsonObject value) : base("procedure", value, _supportType)
        {
        }
        public ExplanationOfBenefitProcedureProcedureChoice(IComplexType? value) : base("procedure", value)
        {
        }
        public ExplanationOfBenefitProcedureProcedureChoice(IPrimitiveType? value) : base("procedure", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"procedure".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ExplanationOfBenefitAccidentLocationChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Address","Reference(Location)"
        ];

        public ExplanationOfBenefitAccidentLocationChoice(JsonObject value) : base("location", value, _supportType)
        {
        }
        public ExplanationOfBenefitAccidentLocationChoice(IComplexType? value) : base("location", value)
        {
        }
        public ExplanationOfBenefitAccidentLocationChoice(IPrimitiveType? value) : base("location", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"location".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ExplanationOfBenefitItemServicedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "date","Period"
        ];

        public ExplanationOfBenefitItemServicedChoice(JsonObject value) : base("serviced", value, _supportType)
        {
        }
        public ExplanationOfBenefitItemServicedChoice(IComplexType? value) : base("serviced", value)
        {
        }
        public ExplanationOfBenefitItemServicedChoice(IPrimitiveType? value) : base("serviced", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"serviced".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ExplanationOfBenefitItemLocationChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","AddressReference(Location)"
        ];

        public ExplanationOfBenefitItemLocationChoice(JsonObject value) : base("location", value, _supportType)
        {
        }
        public ExplanationOfBenefitItemLocationChoice(IComplexType? value) : base("location", value)
        {
        }
        public ExplanationOfBenefitItemLocationChoice(IPrimitiveType? value) : base("location", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"location".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ExplanationOfBenefitAddItemServicedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "date","Period"
        ];

        public ExplanationOfBenefitAddItemServicedChoice(JsonObject value) : base("serviced", value, _supportType)
        {
        }
        public ExplanationOfBenefitAddItemServicedChoice(IComplexType? value) : base("serviced", value)
        {
        }
        public ExplanationOfBenefitAddItemServicedChoice(IPrimitiveType? value) : base("serviced", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"serviced".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ExplanationOfBenefitAddItemLocationChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","AddressReference(Location)"
        ];

        public ExplanationOfBenefitAddItemLocationChoice(JsonObject value) : base("location", value, _supportType)
        {
        }
        public ExplanationOfBenefitAddItemLocationChoice(IComplexType? value) : base("location", value)
        {
        }
        public ExplanationOfBenefitAddItemLocationChoice(IPrimitiveType? value) : base("location", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"location".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "unsignedInt","stringMoney"
        ];

        public ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice(JsonObject value) : base("allowed", value, _supportType)
        {
        }
        public ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice(IComplexType? value) : base("allowed", value)
        {
        }
        public ExplanationOfBenefitBenefitBalanceFinancialAllowedChoice(IPrimitiveType? value) : base("allowed", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"allowed".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ExplanationOfBenefitBenefitBalanceFinancialUsedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "unsignedInt","Money"
        ];

        public ExplanationOfBenefitBenefitBalanceFinancialUsedChoice(JsonObject value) : base("used", value, _supportType)
        {
        }
        public ExplanationOfBenefitBenefitBalanceFinancialUsedChoice(IComplexType? value) : base("used", value)
        {
        }
        public ExplanationOfBenefitBenefitBalanceFinancialUsedChoice(IPrimitiveType? value) : base("used", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"used".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
