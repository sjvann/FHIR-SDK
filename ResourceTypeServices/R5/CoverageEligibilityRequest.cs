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
    public class CoverageEligibilityRequest : ResourceType<CoverageEligibilityRequest>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private CodeableConcept? _priority;
private List<FhirCode>? _purpose;
private ReferenceType? _patient;
private List<CoverageEligibilityRequestEvent>? _event;
private CoverageEligibilityRequestServicedChoice? _serviced;
private FhirDateTime? _created;
private ReferenceType? _enterer;
private ReferenceType? _provider;
private ReferenceType? _insurer;
private ReferenceType? _facility;
private List<CoverageEligibilityRequestSupportingInfo>? _supportingInfo;
private List<CoverageEligibilityRequestInsurance>? _insurance;
private List<CoverageEligibilityRequestItem>? _item;

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

public CodeableConcept? Priority
{
get { return _priority; }
set {
_priority= value;
OnPropertyChanged("priority", value);
}
}

public List<FhirCode>? Purpose
{
get { return _purpose; }
set {
_purpose= value;
OnPropertyChanged("purpose", value);
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

public List<CoverageEligibilityRequestEvent>? Event
{
get { return _event; }
set {
_event= value;
OnPropertyChanged("event", value);
}
}

public CoverageEligibilityRequestServicedChoice? Serviced
{
get { return _serviced; }
set {
_serviced= value;
OnPropertyChanged("serviced", value);
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

public ReferenceType? Provider
{
get { return _provider; }
set {
_provider= value;
OnPropertyChanged("provider", value);
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

public ReferenceType? Facility
{
get { return _facility; }
set {
_facility= value;
OnPropertyChanged("facility", value);
}
}

public List<CoverageEligibilityRequestSupportingInfo>? SupportingInfo
{
get { return _supportingInfo; }
set {
_supportingInfo= value;
OnPropertyChanged("supportingInfo", value);
}
}

public List<CoverageEligibilityRequestInsurance>? Insurance
{
get { return _insurance; }
set {
_insurance= value;
OnPropertyChanged("insurance", value);
}
}

public List<CoverageEligibilityRequestItem>? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}


		#endregion
		#region Constructor
		public  CoverageEligibilityRequest() { }
		public  CoverageEligibilityRequest(string value) : base(value) { }
		public  CoverageEligibilityRequest(JsonNode? source) : base(source) { }
		#endregion
	}
		public class CoverageEligibilityRequestEvent : BackboneElementType<CoverageEligibilityRequestEvent>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private CoverageEligibilityRequestEventWhenChoice? _when;

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

public CoverageEligibilityRequestEventWhenChoice? When
{
get { return _when; }
set {
_when= value;
OnPropertyChanged("when", value);
}
}


		#endregion
		#region Constructor
		public  CoverageEligibilityRequestEvent() { }
		public  CoverageEligibilityRequestEvent(string value) : base(value) { }
		public  CoverageEligibilityRequestEvent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CoverageEligibilityRequestSupportingInfo : BackboneElementType<CoverageEligibilityRequestSupportingInfo>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _sequence;
private ReferenceType? _information;
private FhirBoolean? _appliesToAll;

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

public ReferenceType? Information
{
get { return _information; }
set {
_information= value;
OnPropertyChanged("information", value);
}
}

public FhirBoolean? AppliesToAll
{
get { return _appliesToAll; }
set {
_appliesToAll= value;
OnPropertyChanged("appliesToAll", value);
}
}


		#endregion
		#region Constructor
		public  CoverageEligibilityRequestSupportingInfo() { }
		public  CoverageEligibilityRequestSupportingInfo(string value) : base(value) { }
		public  CoverageEligibilityRequestSupportingInfo(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CoverageEligibilityRequestInsurance : BackboneElementType<CoverageEligibilityRequestInsurance>, IBackboneElementType
	{

		#region Private Method
		private FhirBoolean? _focal;
private ReferenceType? _coverage;
private FhirString? _businessArrangement;

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

public FhirString? BusinessArrangement
{
get { return _businessArrangement; }
set {
_businessArrangement= value;
OnPropertyChanged("businessArrangement", value);
}
}


		#endregion
		#region Constructor
		public  CoverageEligibilityRequestInsurance() { }
		public  CoverageEligibilityRequestInsurance(string value) : base(value) { }
		public  CoverageEligibilityRequestInsurance(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CoverageEligibilityRequestItemDiagnosis : BackboneElementType<CoverageEligibilityRequestItemDiagnosis>, IBackboneElementType
	{

		#region Private Method
		private CoverageEligibilityRequestItemDiagnosisDiagnosisChoice? _diagnosis;

		#endregion
		#region public Method
		public CoverageEligibilityRequestItemDiagnosisDiagnosisChoice? Diagnosis
{
get { return _diagnosis; }
set {
_diagnosis= value;
OnPropertyChanged("diagnosis", value);
}
}


		#endregion
		#region Constructor
		public  CoverageEligibilityRequestItemDiagnosis() { }
		public  CoverageEligibilityRequestItemDiagnosis(string value) : base(value) { }
		public  CoverageEligibilityRequestItemDiagnosis(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CoverageEligibilityRequestItem : BackboneElementType<CoverageEligibilityRequestItem>, IBackboneElementType
	{

		#region Private Method
		private List<FhirPositiveInt>? _supportingInfoSequence;
private CodeableConcept? _category;
private CodeableConcept? _productOrService;
private List<CodeableConcept>? _modifier;
private ReferenceType? _provider;
private Quantity? _quantity;
private Money? _unitPrice;
private ReferenceType? _facility;
private List<CoverageEligibilityRequestItemDiagnosis>? _diagnosis;
private List<ReferenceType>? _detail;

		#endregion
		#region public Method
		public List<FhirPositiveInt>? SupportingInfoSequence
{
get { return _supportingInfoSequence; }
set {
_supportingInfoSequence= value;
OnPropertyChanged("supportingInfoSequence", value);
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

public List<CodeableConcept>? Modifier
{
get { return _modifier; }
set {
_modifier= value;
OnPropertyChanged("modifier", value);
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

public ReferenceType? Facility
{
get { return _facility; }
set {
_facility= value;
OnPropertyChanged("facility", value);
}
}

public List<CoverageEligibilityRequestItemDiagnosis>? Diagnosis
{
get { return _diagnosis; }
set {
_diagnosis= value;
OnPropertyChanged("diagnosis", value);
}
}

public List<ReferenceType>? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}


		#endregion
		#region Constructor
		public  CoverageEligibilityRequestItem() { }
		public  CoverageEligibilityRequestItem(string value) : base(value) { }
		public  CoverageEligibilityRequestItem(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class CoverageEligibilityRequestEventWhenChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public CoverageEligibilityRequestEventWhenChoice(JsonObject value) : base("when", value, _supportType)
        {
        }
        public CoverageEligibilityRequestEventWhenChoice(IComplexType? value) : base("when", value)
        {
        }
        public CoverageEligibilityRequestEventWhenChoice(IPrimitiveType? value) : base("when", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"when".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class CoverageEligibilityRequestServicedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "date","Period"
        ];

        public CoverageEligibilityRequestServicedChoice(JsonObject value) : base("serviced", value, _supportType)
        {
        }
        public CoverageEligibilityRequestServicedChoice(IComplexType? value) : base("serviced", value)
        {
        }
        public CoverageEligibilityRequestServicedChoice(IPrimitiveType? value) : base("serviced", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"serviced".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class CoverageEligibilityRequestItemDiagnosisDiagnosisChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Condition)"
        ];

        public CoverageEligibilityRequestItemDiagnosisDiagnosisChoice(JsonObject value) : base("diagnosis", value, _supportType)
        {
        }
        public CoverageEligibilityRequestItemDiagnosisDiagnosisChoice(IComplexType? value) : base("diagnosis", value)
        {
        }
        public CoverageEligibilityRequestItemDiagnosisDiagnosisChoice(IPrimitiveType? value) : base("diagnosis", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"diagnosis".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
