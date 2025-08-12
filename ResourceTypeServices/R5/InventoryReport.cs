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
    public class InventoryReport : ResourceType<InventoryReport>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private FhirCode? _countType;
private CodeableConcept? _operationType;
private CodeableConcept? _operationTypeReason;
private FhirDateTime? _reportedDateTime;
private ReferenceType? _reporter;
private Period? _reportingPeriod;
private List<InventoryReportInventoryListing>? _inventoryListing;
private List<Annotation>? _note;

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

public FhirCode? CountType
{
get { return _countType; }
set {
_countType= value;
OnPropertyChanged("countType", value);
}
}

public CodeableConcept? OperationType
{
get { return _operationType; }
set {
_operationType= value;
OnPropertyChanged("operationType", value);
}
}

public CodeableConcept? OperationTypeReason
{
get { return _operationTypeReason; }
set {
_operationTypeReason= value;
OnPropertyChanged("operationTypeReason", value);
}
}

public FhirDateTime? ReportedDateTime
{
get { return _reportedDateTime; }
set {
_reportedDateTime= value;
OnPropertyChanged("reportedDateTime", value);
}
}

public ReferenceType? Reporter
{
get { return _reporter; }
set {
_reporter= value;
OnPropertyChanged("reporter", value);
}
}

public Period? ReportingPeriod
{
get { return _reportingPeriod; }
set {
_reportingPeriod= value;
OnPropertyChanged("reportingPeriod", value);
}
}

public List<InventoryReportInventoryListing>? InventoryListing
{
get { return _inventoryListing; }
set {
_inventoryListing= value;
OnPropertyChanged("inventoryListing", value);
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


		#endregion
		#region Constructor
		public  InventoryReport() { }
		public  InventoryReport(string value) : base(value) { }
		public  InventoryReport(JsonNode? source) : base(source) { }
		#endregion
	}
		public class InventoryReportInventoryListingItem : BackboneElementType<InventoryReportInventoryListingItem>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _category;
private Quantity? _quantity;
private CodeableReference? _item;

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

public Quantity? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
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


		#endregion
		#region Constructor
		public  InventoryReportInventoryListingItem() { }
		public  InventoryReportInventoryListingItem(string value) : base(value) { }
		public  InventoryReportInventoryListingItem(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InventoryReportInventoryListing : BackboneElementType<InventoryReportInventoryListing>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _location;
private CodeableConcept? _itemStatus;
private FhirDateTime? _countingDateTime;
private List<InventoryReportInventoryListingItem>? _item;

		#endregion
		#region public Method
		public ReferenceType? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public CodeableConcept? ItemStatus
{
get { return _itemStatus; }
set {
_itemStatus= value;
OnPropertyChanged("itemStatus", value);
}
}

public FhirDateTime? CountingDateTime
{
get { return _countingDateTime; }
set {
_countingDateTime= value;
OnPropertyChanged("countingDateTime", value);
}
}

public List<InventoryReportInventoryListingItem>? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}


		#endregion
		#region Constructor
		public  InventoryReportInventoryListing() { }
		public  InventoryReportInventoryListing(string value) : base(value) { }
		public  InventoryReportInventoryListing(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
