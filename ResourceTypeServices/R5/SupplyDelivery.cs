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
    public class SupplyDelivery : ResourceType<SupplyDelivery>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _partOf;
private FhirCode? _status;
private ReferenceType? _patient;
private CodeableConcept? _type;
private List<SupplyDeliverySuppliedItem>? _suppliedItem;
private SupplyDeliveryOccurrenceChoice? _occurrence;
private ReferenceType? _supplier;
private ReferenceType? _destination;
private List<ReferenceType>? _receiver;

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

public List<ReferenceType>? BasedOn
{
get { return _basedOn; }
set {
_basedOn= value;
OnPropertyChanged("basedOn", value);
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

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
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

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public List<SupplyDeliverySuppliedItem>? SuppliedItem
{
get { return _suppliedItem; }
set {
_suppliedItem= value;
OnPropertyChanged("suppliedItem", value);
}
}

public SupplyDeliveryOccurrenceChoice? Occurrence
{
get { return _occurrence; }
set {
_occurrence= value;
OnPropertyChanged("occurrence", value);
}
}

public ReferenceType? Supplier
{
get { return _supplier; }
set {
_supplier= value;
OnPropertyChanged("supplier", value);
}
}

public ReferenceType? Destination
{
get { return _destination; }
set {
_destination= value;
OnPropertyChanged("destination", value);
}
}

public List<ReferenceType>? Receiver
{
get { return _receiver; }
set {
_receiver= value;
OnPropertyChanged("receiver", value);
}
}


		#endregion
		#region Constructor
		public  SupplyDelivery() { }
		public  SupplyDelivery(string value) : base(value) { }
		public  SupplyDelivery(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SupplyDeliverySuppliedItem : BackboneElementType<SupplyDeliverySuppliedItem>, IBackboneElementType
	{

		#region Private Method
		private Quantity? _quantity;
private SupplyDeliverySuppliedItemItemChoice? _item;

		#endregion
		#region public Method
		public Quantity? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}

public SupplyDeliverySuppliedItemItemChoice? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}


		#endregion
		#region Constructor
		public  SupplyDeliverySuppliedItem() { }
		public  SupplyDeliverySuppliedItem(string value) : base(value) { }
		public  SupplyDeliverySuppliedItem(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class SupplyDeliverySuppliedItemItemChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Medication|Substance|Device|BiologicallyDerivedProduct|NutritionProduct|InventoryItem)"
        ];

        public SupplyDeliverySuppliedItemItemChoice(JsonObject value) : base("item", value, _supportType)
        {
        }
        public SupplyDeliverySuppliedItemItemChoice(IComplexType? value) : base("item", value)
        {
        }
        public SupplyDeliverySuppliedItemItemChoice(IPrimitiveType? value) : base("item", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"item".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class SupplyDeliveryOccurrenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","PeriodTiming"
        ];

        public SupplyDeliveryOccurrenceChoice(JsonObject value) : base("occurrence", value, _supportType)
        {
        }
        public SupplyDeliveryOccurrenceChoice(IComplexType? value) : base("occurrence", value)
        {
        }
        public SupplyDeliveryOccurrenceChoice(IPrimitiveType? value) : base("occurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurrence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
