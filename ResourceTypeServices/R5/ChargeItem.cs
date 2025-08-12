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
    public class ChargeItem : ResourceType<ChargeItem>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<FhirUri>? _definitionUri;
private List<FhirCanonical>? _definitionCanonical;
private FhirCode? _status;
private List<ReferenceType>? _partOf;
private CodeableConcept? _code;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private ChargeItemOccurrenceChoice? _occurrence;
private List<ChargeItemPerformer>? _performer;
private ReferenceType? _performingOrganization;
private ReferenceType? _requestingOrganization;
private ReferenceType? _costCenter;
private Quantity? _quantity;
private List<CodeableConcept>? _bodysite;
private MonetaryComponent? _unitPriceComponent;
private MonetaryComponent? _totalPriceComponent;
private CodeableConcept? _overrideReason;
private ReferenceType? _enterer;
private FhirDateTime? _enteredDate;
private List<CodeableConcept>? _reason;
private List<CodeableReference>? _service;
private List<CodeableReference>? _product;
private List<ReferenceType>? _account;
private List<Annotation>? _note;
private List<ReferenceType>? _supportingInformation;

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

public List<FhirUri>? DefinitionUri
{
get { return _definitionUri; }
set {
_definitionUri= value;
OnPropertyChanged("definitionUri", value);
}
}

public List<FhirCanonical>? DefinitionCanonical
{
get { return _definitionCanonical; }
set {
_definitionCanonical= value;
OnPropertyChanged("definitionCanonical", value);
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

public List<ReferenceType>? PartOf
{
get { return _partOf; }
set {
_partOf= value;
OnPropertyChanged("partOf", value);
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

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
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

public ChargeItemOccurrenceChoice? Occurrence
{
get { return _occurrence; }
set {
_occurrence= value;
OnPropertyChanged("occurrence", value);
}
}

public List<ChargeItemPerformer>? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
}
}

public ReferenceType? PerformingOrganization
{
get { return _performingOrganization; }
set {
_performingOrganization= value;
OnPropertyChanged("performingOrganization", value);
}
}

public ReferenceType? RequestingOrganization
{
get { return _requestingOrganization; }
set {
_requestingOrganization= value;
OnPropertyChanged("requestingOrganization", value);
}
}

public ReferenceType? CostCenter
{
get { return _costCenter; }
set {
_costCenter= value;
OnPropertyChanged("costCenter", value);
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

public List<CodeableConcept>? Bodysite
{
get { return _bodysite; }
set {
_bodysite= value;
OnPropertyChanged("bodysite", value);
}
}

public MonetaryComponent? UnitPriceComponent
{
get { return _unitPriceComponent; }
set {
_unitPriceComponent= value;
OnPropertyChanged("unitPriceComponent", value);
}
}

public MonetaryComponent? TotalPriceComponent
{
get { return _totalPriceComponent; }
set {
_totalPriceComponent= value;
OnPropertyChanged("totalPriceComponent", value);
}
}

public CodeableConcept? OverrideReason
{
get { return _overrideReason; }
set {
_overrideReason= value;
OnPropertyChanged("overrideReason", value);
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

public FhirDateTime? EnteredDate
{
get { return _enteredDate; }
set {
_enteredDate= value;
OnPropertyChanged("enteredDate", value);
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

public List<CodeableReference>? Service
{
get { return _service; }
set {
_service= value;
OnPropertyChanged("service", value);
}
}

public List<CodeableReference>? Product
{
get { return _product; }
set {
_product= value;
OnPropertyChanged("product", value);
}
}

public List<ReferenceType>? Account
{
get { return _account; }
set {
_account= value;
OnPropertyChanged("account", value);
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

public List<ReferenceType>? SupportingInformation
{
get { return _supportingInformation; }
set {
_supportingInformation= value;
OnPropertyChanged("supportingInformation", value);
}
}


		#endregion
		#region Constructor
		public  ChargeItem() { }
		public  ChargeItem(string value) : base(value) { }
		public  ChargeItem(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ChargeItemPerformer : BackboneElementType<ChargeItemPerformer>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _function;
private ReferenceType? _actor;

		#endregion
		#region public Method
		public CodeableConcept? Function
{
get { return _function; }
set {
_function= value;
OnPropertyChanged("function", value);
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
		public  ChargeItemPerformer() { }
		public  ChargeItemPerformer(string value) : base(value) { }
		public  ChargeItemPerformer(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ChargeItemOccurrenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","PeriodTiming"
        ];

        public ChargeItemOccurrenceChoice(JsonObject value) : base("occurrence", value, _supportType)
        {
        }
        public ChargeItemOccurrenceChoice(IComplexType? value) : base("occurrence", value)
        {
        }
        public ChargeItemOccurrenceChoice(IPrimitiveType? value) : base("occurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurrence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
