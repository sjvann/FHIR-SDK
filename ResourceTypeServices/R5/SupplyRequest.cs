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
    public class SupplyRequest : ResourceType<SupplyRequest>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<ReferenceType>? _basedOn;
private CodeableConcept? _category;
private FhirCode? _priority;
private ReferenceType? _deliverFor;
private CodeableReference? _item;
private Quantity? _quantity;
private List<SupplyRequestParameter>? _parameter;
private SupplyRequestOccurrenceChoice? _occurrence;
private FhirDateTime? _authoredOn;
private ReferenceType? _requester;
private List<ReferenceType>? _supplier;
private List<CodeableReference>? _reason;
private ReferenceType? _deliverFrom;
private ReferenceType? _deliverTo;

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

public List<ReferenceType>? BasedOn
{
get { return _basedOn; }
set {
_basedOn= value;
OnPropertyChanged("basedOn", value);
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

public FhirCode? Priority
{
get { return _priority; }
set {
_priority= value;
OnPropertyChanged("priority", value);
}
}

public ReferenceType? DeliverFor
{
get { return _deliverFor; }
set {
_deliverFor= value;
OnPropertyChanged("deliverFor", value);
}
}

public CodeableReference? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
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

public List<SupplyRequestParameter>? Parameter
{
get { return _parameter; }
set {
_parameter= value;
OnPropertyChanged("parameter", value);
}
}

public SupplyRequestOccurrenceChoice? Occurrence
{
get { return _occurrence; }
set {
_occurrence= value;
OnPropertyChanged("occurrence", value);
}
}

public FhirDateTime? AuthoredOn
{
get { return _authoredOn; }
set {
_authoredOn= value;
OnPropertyChanged("authoredOn", value);
}
}

public ReferenceType? Requester
{
get { return _requester; }
set {
_requester= value;
OnPropertyChanged("requester", value);
}
}

public List<ReferenceType>? Supplier
{
get { return _supplier; }
set {
_supplier= value;
OnPropertyChanged("supplier", value);
}
}

public List<CodeableReference>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public ReferenceType? DeliverFrom
{
get { return _deliverFrom; }
set {
_deliverFrom= value;
OnPropertyChanged("deliverFrom", value);
}
}

public ReferenceType? DeliverTo
{
get { return _deliverTo; }
set {
_deliverTo= value;
OnPropertyChanged("deliverTo", value);
}
}


		#endregion
		#region Constructor
		public  SupplyRequest() { }
		public  SupplyRequest(string value) : base(value) { }
		public  SupplyRequest(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SupplyRequestParameter : BackboneElementType<SupplyRequestParameter>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private SupplyRequestParameterValueChoice? _value;

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

public SupplyRequestParameterValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  SupplyRequestParameter() { }
		public  SupplyRequestParameter(string value) : base(value) { }
		public  SupplyRequestParameter(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class SupplyRequestParameterValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","QuantityRangeboolean"
        ];

        public SupplyRequestParameterValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public SupplyRequestParameterValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public SupplyRequestParameterValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class SupplyRequestOccurrenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","PeriodTiming"
        ];

        public SupplyRequestOccurrenceChoice(JsonObject value) : base("occurrence", value, _supportType)
        {
        }
        public SupplyRequestOccurrenceChoice(IComplexType? value) : base("occurrence", value)
        {
        }
        public SupplyRequestOccurrenceChoice(IPrimitiveType? value) : base("occurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurrence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
