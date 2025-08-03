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
    public class Claim : ResourceType<Claim>
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
private CodeableConcept? _fundsReserve;
private List<ClaimRelated>? _related;
private ReferenceType? _prescription;
private ReferenceType? _originalPrescription;
private ClaimPayee? _payee;
private ReferenceType? _referral;
private List<ReferenceType>? _encounter;
private ReferenceType? _facility;
private CodeableConcept? _diagnosisRelatedGroup;
private List<ClaimEvent>? _event;
private List<ClaimCareTeam>? _careTeam;
private List<ClaimSupportingInfo>? _supportingInfo;
private List<ClaimDiagnosis>? _diagnosis;
private List<ClaimProcedure>? _procedure;
private List<ClaimInsurance>? _insurance;
private ClaimAccident? _accident;
private Money? _patientPaid;
private List<ClaimItem>? _item;
private Money? _total;

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

public CodeableConcept? FundsReserve
{
get { return _fundsReserve; }
set {
_fundsReserve= value;
OnPropertyChanged("fundsReserve", value);
}
}

public List<ClaimRelated>? Related
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

public ClaimPayee? Payee
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

public CodeableConcept? DiagnosisRelatedGroup
{
get { return _diagnosisRelatedGroup; }
set {
_diagnosisRelatedGroup= value;
OnPropertyChanged("diagnosisRelatedGroup", value);
}
}

public List<ClaimEvent>? Event
{
get { return _event; }
set {
_event= value;
OnPropertyChanged("event", value);
}
}

public List<ClaimCareTeam>? CareTeam
{
get { return _careTeam; }
set {
_careTeam= value;
OnPropertyChanged("careTeam", value);
}
}

public List<ClaimSupportingInfo>? SupportingInfo
{
get { return _supportingInfo; }
set {
_supportingInfo= value;
OnPropertyChanged("supportingInfo", value);
}
}

public List<ClaimDiagnosis>? Diagnosis
{
get { return _diagnosis; }
set {
_diagnosis= value;
OnPropertyChanged("diagnosis", value);
}
}

public List<ClaimProcedure>? Procedure
{
get { return _procedure; }
set {
_procedure= value;
OnPropertyChanged("procedure", value);
}
}

public List<ClaimInsurance>? Insurance
{
get { return _insurance; }
set {
_insurance= value;
OnPropertyChanged("insurance", value);
}
}

public ClaimAccident? Accident
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

public List<ClaimItem>? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}

public Money? Total
{
get { return _total; }
set {
_total= value;
OnPropertyChanged("total", value);
}
}


		#endregion
		#region Constructor
		public  Claim() { }
		public  Claim(string value) : base(value) { }
		public  Claim(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ClaimRelated : BackboneElementType<ClaimRelated>, IBackboneElementType
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
		public  ClaimRelated() { }
		public  ClaimRelated(string value) : base(value) { }
		public  ClaimRelated(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimPayee : BackboneElementType<ClaimPayee>, IBackboneElementType
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
		public  ClaimPayee() { }
		public  ClaimPayee(string value) : base(value) { }
		public  ClaimPayee(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimEvent : BackboneElementType<ClaimEvent>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private ClaimEventWhenChoice? _when;

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

public ClaimEventWhenChoice? When
{
get { return _when; }
set {
_when= value;
OnPropertyChanged("when", value);
}
}


		#endregion
		#region Constructor
		public  ClaimEvent() { }
		public  ClaimEvent(string value) : base(value) { }
		public  ClaimEvent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimCareTeam : BackboneElementType<ClaimCareTeam>, IBackboneElementType
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
		public  ClaimCareTeam() { }
		public  ClaimCareTeam(string value) : base(value) { }
		public  ClaimCareTeam(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimSupportingInfo : BackboneElementType<ClaimSupportingInfo>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private CodeableConcept? _category;
private CodeableConcept? _code;
private ClaimSupportingInfoTimingChoice? _timing;
private ClaimSupportingInfoValueChoice? _value;
private CodeableConcept? _reason;

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

public ClaimSupportingInfoTimingChoice? Timing
{
get { return _timing; }
set {
_timing= value;
OnPropertyChanged("timing", value);
}
}

public ClaimSupportingInfoValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
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


		#endregion
		#region Constructor
		public  ClaimSupportingInfo() { }
		public  ClaimSupportingInfo(string value) : base(value) { }
		public  ClaimSupportingInfo(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimDiagnosis : BackboneElementType<ClaimDiagnosis>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private ClaimDiagnosisDiagnosisChoice? _diagnosis;
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

public ClaimDiagnosisDiagnosisChoice? Diagnosis
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
		public  ClaimDiagnosis() { }
		public  ClaimDiagnosis(string value) : base(value) { }
		public  ClaimDiagnosis(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimProcedure : BackboneElementType<ClaimProcedure>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private List<CodeableConcept>? _type;
private FhirDateTime? _date;
private ClaimProcedureProcedureChoice? _procedure;
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

public ClaimProcedureProcedureChoice? Procedure
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
		public  ClaimProcedure() { }
		public  ClaimProcedure(string value) : base(value) { }
		public  ClaimProcedure(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimInsurance : BackboneElementType<ClaimInsurance>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private FhirBoolean? _focal;
private Identifier? _identifier;
private ReferenceType? _coverage;
private FhirString? _businessArrangement;
private List<FhirString>? _preAuthRef;
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

public Identifier? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
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

public List<FhirString>? PreAuthRef
{
get { return _preAuthRef; }
set {
_preAuthRef= value;
OnPropertyChanged("preAuthRef", value);
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
		public  ClaimInsurance() { }
		public  ClaimInsurance(string value) : base(value) { }
		public  ClaimInsurance(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimAccident : BackboneElementType<ClaimAccident>, IBackboneElementType
	{

		#region Private Method
		private FhirDate? _date;
private CodeableConcept? _type;
private ClaimAccidentLocationChoice? _location;

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

public ClaimAccidentLocationChoice? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}


		#endregion
		#region Constructor
		public  ClaimAccident() { }
		public  ClaimAccident(string value) : base(value) { }
		public  ClaimAccident(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimItemBodySite : BackboneElementType<ClaimItemBodySite>, IBackboneElementType
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
		public  ClaimItemBodySite() { }
		public  ClaimItemBodySite(string value) : base(value) { }
		public  ClaimItemBodySite(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimItemDetailSubDetail : BackboneElementType<ClaimItemDetailSubDetail>, IBackboneElementType
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


		#endregion
		#region Constructor
		public  ClaimItemDetailSubDetail() { }
		public  ClaimItemDetailSubDetail(string value) : base(value) { }
		public  ClaimItemDetailSubDetail(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimItemDetail : BackboneElementType<ClaimItemDetail>, IBackboneElementType
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
private List<ClaimItemDetailSubDetail>? _subDetail;

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

public List<ClaimItemDetailSubDetail>? SubDetail
{
get { return _subDetail; }
set {
_subDetail= value;
OnPropertyChanged("subDetail", value);
}
}


		#endregion
		#region Constructor
		public  ClaimItemDetail() { }
		public  ClaimItemDetail(string value) : base(value) { }
		public  ClaimItemDetail(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClaimItem : BackboneElementType<ClaimItem>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private List<Identifier>? _traceNumber;
private List<FhirPositiveInt>? _careTeamSequence;
private List<FhirPositiveInt>? _diagnosisSequence;
private List<FhirPositiveInt>? _procedureSequence;
private List<FhirPositiveInt>? _informationSequence;
private CodeableConcept? _revenue;
private CodeableConcept? _category;
private CodeableConcept? _productOrService;
private CodeableConcept? _productOrServiceEnd;
private List<ReferenceType>? _request;
private List<CodeableConcept>? _modifier;
private List<CodeableConcept>? _programCode;
private ClaimItemServicedChoice? _serviced;
private ClaimItemLocationChoice? _location;
private Money? _patientPaid;
private Quantity? _quantity;
private Money? _unitPrice;
private FhirDecimal? _factor;
private Money? _tax;
private Money? _net;
private List<ReferenceType>? _udi;
private List<ClaimItemBodySite>? _bodySite;
private List<ReferenceType>? _encounter;
private List<ClaimItemDetail>? _detail;

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

public ClaimItemServicedChoice? Serviced
{
get { return _serviced; }
set {
_serviced= value;
OnPropertyChanged("serviced", value);
}
}

public ClaimItemLocationChoice? Location
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

public List<ClaimItemBodySite>? BodySite
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

public List<ClaimItemDetail>? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}


		#endregion
		#region Constructor
		public  ClaimItem() { }
		public  ClaimItem(string value) : base(value) { }
		public  ClaimItem(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ClaimEventWhenChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public ClaimEventWhenChoice(JsonObject value) : base("when", value, _supportType)
        {
        }
        public ClaimEventWhenChoice(IComplexType? value) : base("when", value)
        {
        }
        public ClaimEventWhenChoice(IPrimitiveType? value) : base("when", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"when".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ClaimSupportingInfoTimingChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "date","Period"
        ];

        public ClaimSupportingInfoTimingChoice(JsonObject value) : base("timing", value, _supportType)
        {
        }
        public ClaimSupportingInfoTimingChoice(IComplexType? value) : base("timing", value)
        {
        }
        public ClaimSupportingInfoTimingChoice(IPrimitiveType? value) : base("timing", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"timing".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ClaimSupportingInfoValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","stringQuantityAttachmentReference(Resource)Identifier"
        ];

        public ClaimSupportingInfoValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ClaimSupportingInfoValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ClaimSupportingInfoValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ClaimDiagnosisDiagnosisChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Condition)"
        ];

        public ClaimDiagnosisDiagnosisChoice(JsonObject value) : base("diagnosis", value, _supportType)
        {
        }
        public ClaimDiagnosisDiagnosisChoice(IComplexType? value) : base("diagnosis", value)
        {
        }
        public ClaimDiagnosisDiagnosisChoice(IPrimitiveType? value) : base("diagnosis", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"diagnosis".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ClaimProcedureProcedureChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Procedure)"
        ];

        public ClaimProcedureProcedureChoice(JsonObject value) : base("procedure", value, _supportType)
        {
        }
        public ClaimProcedureProcedureChoice(IComplexType? value) : base("procedure", value)
        {
        }
        public ClaimProcedureProcedureChoice(IPrimitiveType? value) : base("procedure", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"procedure".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ClaimAccidentLocationChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Address","Reference(Location)"
        ];

        public ClaimAccidentLocationChoice(JsonObject value) : base("location", value, _supportType)
        {
        }
        public ClaimAccidentLocationChoice(IComplexType? value) : base("location", value)
        {
        }
        public ClaimAccidentLocationChoice(IPrimitiveType? value) : base("location", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"location".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ClaimItemServicedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "date","Period"
        ];

        public ClaimItemServicedChoice(JsonObject value) : base("serviced", value, _supportType)
        {
        }
        public ClaimItemServicedChoice(IComplexType? value) : base("serviced", value)
        {
        }
        public ClaimItemServicedChoice(IPrimitiveType? value) : base("serviced", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"serviced".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ClaimItemLocationChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","AddressReference(Location)"
        ];

        public ClaimItemLocationChoice(JsonObject value) : base("location", value, _supportType)
        {
        }
        public ClaimItemLocationChoice(IComplexType? value) : base("location", value)
        {
        }
        public ClaimItemLocationChoice(IPrimitiveType? value) : base("location", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"location".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
