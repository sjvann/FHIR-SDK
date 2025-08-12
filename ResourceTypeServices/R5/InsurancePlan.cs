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
    public class InsurancePlan : ResourceType<InsurancePlan>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<CodeableConcept>? _type;
private FhirString? _name;
private List<FhirString>? _alias;
private Period? _period;
private ReferenceType? _ownedBy;
private ReferenceType? _administeredBy;
private List<ReferenceType>? _coverageArea;
private List<ExtendedContactDetail>? _contact;
private List<ReferenceType>? _endpoint;
private List<ReferenceType>? _network;
private List<InsurancePlanCoverage>? _coverage;
private List<InsurancePlanPlan>? _plan;

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

public List<CodeableConcept>? Type
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

public List<FhirString>? Alias
{
get { return _alias; }
set {
_alias= value;
OnPropertyChanged("alias", value);
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

public ReferenceType? OwnedBy
{
get { return _ownedBy; }
set {
_ownedBy= value;
OnPropertyChanged("ownedBy", value);
}
}

public ReferenceType? AdministeredBy
{
get { return _administeredBy; }
set {
_administeredBy= value;
OnPropertyChanged("administeredBy", value);
}
}

public List<ReferenceType>? CoverageArea
{
get { return _coverageArea; }
set {
_coverageArea= value;
OnPropertyChanged("coverageArea", value);
}
}

public List<ExtendedContactDetail>? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
}
}

public List<ReferenceType>? Endpoint
{
get { return _endpoint; }
set {
_endpoint= value;
OnPropertyChanged("endpoint", value);
}
}

public List<ReferenceType>? Network
{
get { return _network; }
set {
_network= value;
OnPropertyChanged("network", value);
}
}

public List<InsurancePlanCoverage>? Coverage
{
get { return _coverage; }
set {
_coverage= value;
OnPropertyChanged("coverage", value);
}
}

public List<InsurancePlanPlan>? Plan
{
get { return _plan; }
set {
_plan= value;
OnPropertyChanged("plan", value);
}
}


		#endregion
		#region Constructor
		public  InsurancePlan() { }
		public  InsurancePlan(string value) : base(value) { }
		public  InsurancePlan(JsonNode? source) : base(source) { }
		#endregion
	}
		public class InsurancePlanCoverageBenefitLimit : BackboneElementType<InsurancePlanCoverageBenefitLimit>, IBackboneElementType
	{

		#region Private Method
		private Quantity? _value;
private CodeableConcept? _code;

		#endregion
		#region public Method
		public Quantity? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
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


		#endregion
		#region Constructor
		public  InsurancePlanCoverageBenefitLimit() { }
		public  InsurancePlanCoverageBenefitLimit(string value) : base(value) { }
		public  InsurancePlanCoverageBenefitLimit(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InsurancePlanCoverageBenefit : BackboneElementType<InsurancePlanCoverageBenefit>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private FhirString? _requirement;
private List<InsurancePlanCoverageBenefitLimit>? _limit;

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

public FhirString? Requirement
{
get { return _requirement; }
set {
_requirement= value;
OnPropertyChanged("requirement", value);
}
}

public List<InsurancePlanCoverageBenefitLimit>? Limit
{
get { return _limit; }
set {
_limit= value;
OnPropertyChanged("limit", value);
}
}


		#endregion
		#region Constructor
		public  InsurancePlanCoverageBenefit() { }
		public  InsurancePlanCoverageBenefit(string value) : base(value) { }
		public  InsurancePlanCoverageBenefit(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InsurancePlanCoverage : BackboneElementType<InsurancePlanCoverage>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private List<ReferenceType>? _network;
private List<InsurancePlanCoverageBenefit>? _benefit;

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

public List<ReferenceType>? Network
{
get { return _network; }
set {
_network= value;
OnPropertyChanged("network", value);
}
}

public List<InsurancePlanCoverageBenefit>? Benefit
{
get { return _benefit; }
set {
_benefit= value;
OnPropertyChanged("benefit", value);
}
}


		#endregion
		#region Constructor
		public  InsurancePlanCoverage() { }
		public  InsurancePlanCoverage(string value) : base(value) { }
		public  InsurancePlanCoverage(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InsurancePlanPlanGeneralCost : BackboneElementType<InsurancePlanPlanGeneralCost>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private FhirPositiveInt? _groupSize;
private Money? _cost;
private FhirString? _comment;

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

public FhirPositiveInt? GroupSize
{
get { return _groupSize; }
set {
_groupSize= value;
OnPropertyChanged("groupSize", value);
}
}

public Money? Cost
{
get { return _cost; }
set {
_cost= value;
OnPropertyChanged("cost", value);
}
}

public FhirString? Comment
{
get { return _comment; }
set {
_comment= value;
OnPropertyChanged("comment", value);
}
}


		#endregion
		#region Constructor
		public  InsurancePlanPlanGeneralCost() { }
		public  InsurancePlanPlanGeneralCost(string value) : base(value) { }
		public  InsurancePlanPlanGeneralCost(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InsurancePlanPlanSpecificCostBenefitCost : BackboneElementType<InsurancePlanPlanSpecificCostBenefitCost>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private CodeableConcept? _applicability;
private List<CodeableConcept>? _qualifiers;
private Quantity? _value;

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

public CodeableConcept? Applicability
{
get { return _applicability; }
set {
_applicability= value;
OnPropertyChanged("applicability", value);
}
}

public List<CodeableConcept>? Qualifiers
{
get { return _qualifiers; }
set {
_qualifiers= value;
OnPropertyChanged("qualifiers", value);
}
}

public Quantity? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  InsurancePlanPlanSpecificCostBenefitCost() { }
		public  InsurancePlanPlanSpecificCostBenefitCost(string value) : base(value) { }
		public  InsurancePlanPlanSpecificCostBenefitCost(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InsurancePlanPlanSpecificCostBenefit : BackboneElementType<InsurancePlanPlanSpecificCostBenefit>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private List<InsurancePlanPlanSpecificCostBenefitCost>? _cost;

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

public List<InsurancePlanPlanSpecificCostBenefitCost>? Cost
{
get { return _cost; }
set {
_cost= value;
OnPropertyChanged("cost", value);
}
}


		#endregion
		#region Constructor
		public  InsurancePlanPlanSpecificCostBenefit() { }
		public  InsurancePlanPlanSpecificCostBenefit(string value) : base(value) { }
		public  InsurancePlanPlanSpecificCostBenefit(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InsurancePlanPlanSpecificCost : BackboneElementType<InsurancePlanPlanSpecificCost>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _category;
private List<InsurancePlanPlanSpecificCostBenefit>? _benefit;

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

public List<InsurancePlanPlanSpecificCostBenefit>? Benefit
{
get { return _benefit; }
set {
_benefit= value;
OnPropertyChanged("benefit", value);
}
}


		#endregion
		#region Constructor
		public  InsurancePlanPlanSpecificCost() { }
		public  InsurancePlanPlanSpecificCost(string value) : base(value) { }
		public  InsurancePlanPlanSpecificCost(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InsurancePlanPlan : BackboneElementType<InsurancePlanPlan>, IBackboneElementType
	{

		#region Private Method
		private List<Identifier>? _identifier;
private CodeableConcept? _type;
private List<ReferenceType>? _coverageArea;
private List<ReferenceType>? _network;
private List<InsurancePlanPlanGeneralCost>? _generalCost;
private List<InsurancePlanPlanSpecificCost>? _specificCost;

		#endregion
		#region public Method
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

public List<ReferenceType>? CoverageArea
{
get { return _coverageArea; }
set {
_coverageArea= value;
OnPropertyChanged("coverageArea", value);
}
}

public List<ReferenceType>? Network
{
get { return _network; }
set {
_network= value;
OnPropertyChanged("network", value);
}
}

public List<InsurancePlanPlanGeneralCost>? GeneralCost
{
get { return _generalCost; }
set {
_generalCost= value;
OnPropertyChanged("generalCost", value);
}
}

public List<InsurancePlanPlanSpecificCost>? SpecificCost
{
get { return _specificCost; }
set {
_specificCost= value;
OnPropertyChanged("specificCost", value);
}
}


		#endregion
		#region Constructor
		public  InsurancePlanPlan() { }
		public  InsurancePlanPlan(string value) : base(value) { }
		public  InsurancePlanPlan(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
