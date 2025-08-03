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
    public class CoverageEligibilityResponse : ResourceType<CoverageEligibilityResponse>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<FhirCode>? _purpose;
private ReferenceType? _patient;
private List<CoverageEligibilityResponseEvent>? _event;
private CoverageEligibilityResponseServicedChoice? _serviced;
private FhirDateTime? _created;
private ReferenceType? _requestor;
private ReferenceType? _request;
private FhirCode? _outcome;
private FhirString? _disposition;
private ReferenceType? _insurer;
private List<CoverageEligibilityResponseInsurance>? _insurance;
private FhirString? _preAuthRef;
private CodeableConcept? _form;
private List<CoverageEligibilityResponseError>? _error;

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

public List<CoverageEligibilityResponseEvent>? Event
{
get { return _event; }
set {
_event= value;
OnPropertyChanged("event", value);
}
}

public CoverageEligibilityResponseServicedChoice? Serviced
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

public FhirString? Disposition
{
get { return _disposition; }
set {
_disposition= value;
OnPropertyChanged("disposition", value);
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

public List<CoverageEligibilityResponseInsurance>? Insurance
{
get { return _insurance; }
set {
_insurance= value;
OnPropertyChanged("insurance", value);
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

public CodeableConcept? Form
{
get { return _form; }
set {
_form= value;
OnPropertyChanged("form", value);
}
}

public List<CoverageEligibilityResponseError>? Error
{
get { return _error; }
set {
_error= value;
OnPropertyChanged("error", value);
}
}


		#endregion
		#region Constructor
		public  CoverageEligibilityResponse() { }
		public  CoverageEligibilityResponse(string value) : base(value) { }
		public  CoverageEligibilityResponse(JsonNode? source) : base(source) { }
		#endregion
	}
		public class CoverageEligibilityResponseEvent : BackboneElementType<CoverageEligibilityResponseEvent>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private CoverageEligibilityResponseEventWhenChoice? _when;

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

public CoverageEligibilityResponseEventWhenChoice? When
{
get { return _when; }
set {
_when= value;
OnPropertyChanged("when", value);
}
}


		#endregion
		#region Constructor
		public  CoverageEligibilityResponseEvent() { }
		public  CoverageEligibilityResponseEvent(string value) : base(value) { }
		public  CoverageEligibilityResponseEvent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CoverageEligibilityResponseInsuranceItemBenefit : BackboneElementType<CoverageEligibilityResponseInsuranceItemBenefit>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice? _allowed;
private CoverageEligibilityResponseInsuranceItemBenefitUsedChoice? _used;

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

public CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice? Allowed
{
get { return _allowed; }
set {
_allowed= value;
OnPropertyChanged("allowed", value);
}
}

public CoverageEligibilityResponseInsuranceItemBenefitUsedChoice? Used
{
get { return _used; }
set {
_used= value;
OnPropertyChanged("used", value);
}
}


		#endregion
		#region Constructor
		public  CoverageEligibilityResponseInsuranceItemBenefit() { }
		public  CoverageEligibilityResponseInsuranceItemBenefit(string value) : base(value) { }
		public  CoverageEligibilityResponseInsuranceItemBenefit(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CoverageEligibilityResponseInsuranceItem : BackboneElementType<CoverageEligibilityResponseInsuranceItem>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _category;
private CodeableConcept? _productOrService;
private List<CodeableConcept>? _modifier;
private ReferenceType? _provider;
private FhirBoolean? _excluded;
private FhirString? _name;
private FhirString? _description;
private CodeableConcept? _network;
private CodeableConcept? _unit;
private CodeableConcept? _term;
private List<CoverageEligibilityResponseInsuranceItemBenefit>? _benefit;
private FhirBoolean? _authorizationRequired;
private List<CodeableConcept>? _authorizationSupporting;
private FhirUri? _authorizationUrl;

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

public List<CoverageEligibilityResponseInsuranceItemBenefit>? Benefit
{
get { return _benefit; }
set {
_benefit= value;
OnPropertyChanged("benefit", value);
}
}

public FhirBoolean? AuthorizationRequired
{
get { return _authorizationRequired; }
set {
_authorizationRequired= value;
OnPropertyChanged("authorizationRequired", value);
}
}

public List<CodeableConcept>? AuthorizationSupporting
{
get { return _authorizationSupporting; }
set {
_authorizationSupporting= value;
OnPropertyChanged("authorizationSupporting", value);
}
}

public FhirUri? AuthorizationUrl
{
get { return _authorizationUrl; }
set {
_authorizationUrl= value;
OnPropertyChanged("authorizationUrl", value);
}
}


		#endregion
		#region Constructor
		public  CoverageEligibilityResponseInsuranceItem() { }
		public  CoverageEligibilityResponseInsuranceItem(string value) : base(value) { }
		public  CoverageEligibilityResponseInsuranceItem(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CoverageEligibilityResponseInsurance : BackboneElementType<CoverageEligibilityResponseInsurance>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _coverage;
private FhirBoolean? _inforce;
private Period? _benefitPeriod;
private List<CoverageEligibilityResponseInsuranceItem>? _item;

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

public FhirBoolean? Inforce
{
get { return _inforce; }
set {
_inforce= value;
OnPropertyChanged("inforce", value);
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

public List<CoverageEligibilityResponseInsuranceItem>? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}


		#endregion
		#region Constructor
		public  CoverageEligibilityResponseInsurance() { }
		public  CoverageEligibilityResponseInsurance(string value) : base(value) { }
		public  CoverageEligibilityResponseInsurance(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CoverageEligibilityResponseError : BackboneElementType<CoverageEligibilityResponseError>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private List<FhirString>? _expression;

		#endregion
		#region public Method
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
		public  CoverageEligibilityResponseError() { }
		public  CoverageEligibilityResponseError(string value) : base(value) { }
		public  CoverageEligibilityResponseError(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class CoverageEligibilityResponseEventWhenChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public CoverageEligibilityResponseEventWhenChoice(JsonObject value) : base("when", value, _supportType)
        {
        }
        public CoverageEligibilityResponseEventWhenChoice(IComplexType? value) : base("when", value)
        {
        }
        public CoverageEligibilityResponseEventWhenChoice(IPrimitiveType? value) : base("when", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"when".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class CoverageEligibilityResponseServicedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "date","Period"
        ];

        public CoverageEligibilityResponseServicedChoice(JsonObject value) : base("serviced", value, _supportType)
        {
        }
        public CoverageEligibilityResponseServicedChoice(IComplexType? value) : base("serviced", value)
        {
        }
        public CoverageEligibilityResponseServicedChoice(IPrimitiveType? value) : base("serviced", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"serviced".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "unsignedInt","stringMoney"
        ];

        public CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice(JsonObject value) : base("allowed", value, _supportType)
        {
        }
        public CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice(IComplexType? value) : base("allowed", value)
        {
        }
        public CoverageEligibilityResponseInsuranceItemBenefitAllowedChoice(IPrimitiveType? value) : base("allowed", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"allowed".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class CoverageEligibilityResponseInsuranceItemBenefitUsedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "unsignedInt","stringMoney"
        ];

        public CoverageEligibilityResponseInsuranceItemBenefitUsedChoice(JsonObject value) : base("used", value, _supportType)
        {
        }
        public CoverageEligibilityResponseInsuranceItemBenefitUsedChoice(IComplexType? value) : base("used", value)
        {
        }
        public CoverageEligibilityResponseInsuranceItemBenefitUsedChoice(IPrimitiveType? value) : base("used", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"used".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
