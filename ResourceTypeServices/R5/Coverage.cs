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
    public class Coverage : ResourceType<Coverage>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private FhirCode? _kind;
private List<CoveragePaymentBy>? _paymentBy;
private CodeableConcept? _type;
private ReferenceType? _policyHolder;
private ReferenceType? _subscriber;
private List<Identifier>? _subscriberId;
private ReferenceType? _beneficiary;
private FhirString? _dependent;
private CodeableConcept? _relationship;
private Period? _period;
private ReferenceType? _insurer;
private List<CoverageClass>? _class;
private FhirPositiveInt? _order;
private FhirString? _network;
private List<CoverageCostToBeneficiary>? _costToBeneficiary;
private FhirBoolean? _subrogation;
private List<ReferenceType>? _contract;
private ReferenceType? _insurancePlan;

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

public FhirCode? Kind
{
get { return _kind; }
set {
_kind= value;
OnPropertyChanged("kind", value);
}
}

public List<CoveragePaymentBy>? PaymentBy
{
get { return _paymentBy; }
set {
_paymentBy= value;
OnPropertyChanged("paymentBy", value);
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

public ReferenceType? PolicyHolder
{
get { return _policyHolder; }
set {
_policyHolder= value;
OnPropertyChanged("policyHolder", value);
}
}

public ReferenceType? Subscriber
{
get { return _subscriber; }
set {
_subscriber= value;
OnPropertyChanged("subscriber", value);
}
}

public List<Identifier>? SubscriberId
{
get { return _subscriberId; }
set {
_subscriberId= value;
OnPropertyChanged("subscriberId", value);
}
}

public ReferenceType? Beneficiary
{
get { return _beneficiary; }
set {
_beneficiary= value;
OnPropertyChanged("beneficiary", value);
}
}

public FhirString? Dependent
{
get { return _dependent; }
set {
_dependent= value;
OnPropertyChanged("dependent", value);
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

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
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

public List<CoverageClass>? Class
{
get { return _class; }
set {
_class= value;
OnPropertyChanged("class", value);
}
}

public FhirPositiveInt? Order
{
get { return _order; }
set {
_order= value;
OnPropertyChanged("order", value);
}
}

public FhirString? Network
{
get { return _network; }
set {
_network= value;
OnPropertyChanged("network", value);
}
}

public List<CoverageCostToBeneficiary>? CostToBeneficiary
{
get { return _costToBeneficiary; }
set {
_costToBeneficiary= value;
OnPropertyChanged("costToBeneficiary", value);
}
}

public FhirBoolean? Subrogation
{
get { return _subrogation; }
set {
_subrogation= value;
OnPropertyChanged("subrogation", value);
}
}

public List<ReferenceType>? Contract
{
get { return _contract; }
set {
_contract= value;
OnPropertyChanged("contract", value);
}
}

public ReferenceType? InsurancePlan
{
get { return _insurancePlan; }
set {
_insurancePlan= value;
OnPropertyChanged("insurancePlan", value);
}
}


		#endregion
		#region Constructor
		public  Coverage() { }
		public  Coverage(string value) : base(value) { }
		public  Coverage(JsonNode? source) : base(source) { }
		#endregion
	}
		public class CoveragePaymentBy : BackboneElementType<CoveragePaymentBy>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _party;
private FhirString? _responsibility;

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

public FhirString? Responsibility
{
get { return _responsibility; }
set {
_responsibility= value;
OnPropertyChanged("responsibility", value);
}
}


		#endregion
		#region Constructor
		public  CoveragePaymentBy() { }
		public  CoveragePaymentBy(string value) : base(value) { }
		public  CoveragePaymentBy(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CoverageClass : BackboneElementType<CoverageClass>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private Identifier? _value;
private FhirString? _name;

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

public Identifier? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
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


		#endregion
		#region Constructor
		public  CoverageClass() { }
		public  CoverageClass(string value) : base(value) { }
		public  CoverageClass(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CoverageCostToBeneficiaryException : BackboneElementType<CoverageCostToBeneficiaryException>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private Period? _period;

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
		public  CoverageCostToBeneficiaryException() { }
		public  CoverageCostToBeneficiaryException(string value) : base(value) { }
		public  CoverageCostToBeneficiaryException(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CoverageCostToBeneficiary : BackboneElementType<CoverageCostToBeneficiary>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private CodeableConcept? _category;
private CodeableConcept? _network;
private CodeableConcept? _unit;
private CodeableConcept? _term;
private CoverageCostToBeneficiaryValueChoice? _value;
private List<CoverageCostToBeneficiaryException>? _exception;

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

public CodeableConcept? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public CoverageCostToBeneficiaryValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public List<CoverageCostToBeneficiaryException>? Exception
{
get { return _exception; }
set {
_exception= value;
OnPropertyChanged("exception", value);
}
}


		#endregion
		#region Constructor
		public  CoverageCostToBeneficiary() { }
		public  CoverageCostToBeneficiary(string value) : base(value) { }
		public  CoverageCostToBeneficiary(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class CoverageCostToBeneficiaryValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity {SimpleQuantity}","Money"
        ];

        public CoverageCostToBeneficiaryValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public CoverageCostToBeneficiaryValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public CoverageCostToBeneficiaryValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
