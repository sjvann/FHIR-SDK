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
    public class BiologicallyDerivedProduct : ResourceType<BiologicallyDerivedProduct>
	{
		#region private Property
		private Coding? _productCategory;
private CodeableConcept? _productCode;
private List<ReferenceType>? _parent;
private List<ReferenceType>? _request;
private List<Identifier>? _identifier;
private Identifier? _biologicalSourceEvent;
private List<ReferenceType>? _processingFacility;
private FhirString? _division;
private Coding? _productStatus;
private FhirDateTime? _expirationDate;
private BiologicallyDerivedProductCollection? _collection;
private Range? _storageTempRequirements;
private List<BiologicallyDerivedProductProperty>? _property;

		#endregion
		#region Public Method
		public Coding? ProductCategory
{
get { return _productCategory; }
set {
_productCategory= value;
OnPropertyChanged("productCategory", value);
}
}

public CodeableConcept? ProductCode
{
get { return _productCode; }
set {
_productCode= value;
OnPropertyChanged("productCode", value);
}
}

public List<ReferenceType>? Parent
{
get { return _parent; }
set {
_parent= value;
OnPropertyChanged("parent", value);
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

public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public Identifier? BiologicalSourceEvent
{
get { return _biologicalSourceEvent; }
set {
_biologicalSourceEvent= value;
OnPropertyChanged("biologicalSourceEvent", value);
}
}

public List<ReferenceType>? ProcessingFacility
{
get { return _processingFacility; }
set {
_processingFacility= value;
OnPropertyChanged("processingFacility", value);
}
}

public FhirString? Division
{
get { return _division; }
set {
_division= value;
OnPropertyChanged("division", value);
}
}

public Coding? ProductStatus
{
get { return _productStatus; }
set {
_productStatus= value;
OnPropertyChanged("productStatus", value);
}
}

public FhirDateTime? ExpirationDate
{
get { return _expirationDate; }
set {
_expirationDate= value;
OnPropertyChanged("expirationDate", value);
}
}

public BiologicallyDerivedProductCollection? Collection
{
get { return _collection; }
set {
_collection= value;
OnPropertyChanged("collection", value);
}
}

public Range? StorageTempRequirements
{
get { return _storageTempRequirements; }
set {
_storageTempRequirements= value;
OnPropertyChanged("storageTempRequirements", value);
}
}

public List<BiologicallyDerivedProductProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}


		#endregion
		#region Constructor
		public  BiologicallyDerivedProduct() { }
		public  BiologicallyDerivedProduct(string value) : base(value) { }
		public  BiologicallyDerivedProduct(JsonNode? source) : base(source) { }
		#endregion
	}
		public class BiologicallyDerivedProductCollection : BackboneElementType<BiologicallyDerivedProductCollection>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _collector;
private ReferenceType? _source;
private BiologicallyDerivedProductCollectionCollectedChoice? _collected;

		#endregion
		#region public Method
		public ReferenceType? Collector
{
get { return _collector; }
set {
_collector= value;
OnPropertyChanged("collector", value);
}
}

public ReferenceType? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}

public BiologicallyDerivedProductCollectionCollectedChoice? Collected
{
get { return _collected; }
set {
_collected= value;
OnPropertyChanged("collected", value);
}
}


		#endregion
		#region Constructor
		public  BiologicallyDerivedProductCollection() { }
		public  BiologicallyDerivedProductCollection(string value) : base(value) { }
		public  BiologicallyDerivedProductCollection(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class BiologicallyDerivedProductProperty : BackboneElementType<BiologicallyDerivedProductProperty>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private BiologicallyDerivedProductPropertyValueChoice? _value;

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

public BiologicallyDerivedProductPropertyValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  BiologicallyDerivedProductProperty() { }
		public  BiologicallyDerivedProductProperty(string value) : base(value) { }
		public  BiologicallyDerivedProductProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class BiologicallyDerivedProductCollectionCollectedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public BiologicallyDerivedProductCollectionCollectedChoice(JsonObject value) : base("collected", value, _supportType)
        {
        }
        public BiologicallyDerivedProductCollectionCollectedChoice(IComplexType? value) : base("collected", value)
        {
        }
        public BiologicallyDerivedProductCollectionCollectedChoice(IPrimitiveType? value) : base("collected", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"collected".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class BiologicallyDerivedProductPropertyValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","integerCodeableConceptPeriodQuantityRangeRatiostringAttachment"
        ];

        public BiologicallyDerivedProductPropertyValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public BiologicallyDerivedProductPropertyValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public BiologicallyDerivedProductPropertyValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
