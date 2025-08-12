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
    public class Specimen : ResourceType<Specimen>
	{
		#region private Property
		private List<Identifier>? _identifier;
private Identifier? _accessionIdentifier;
private FhirCode? _status;
private CodeableConcept? _type;
private ReferenceType? _subject;
private FhirDateTime? _receivedTime;
private List<ReferenceType>? _parent;
private List<ReferenceType>? _request;
private FhirCode? _combined;
private List<CodeableConcept>? _role;
private List<SpecimenFeature>? _feature;
private SpecimenCollection? _collection;
private List<SpecimenProcessing>? _processing;
private List<SpecimenContainer>? _container;
private List<CodeableConcept>? _condition;
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

public Identifier? AccessionIdentifier
{
get { return _accessionIdentifier; }
set {
_accessionIdentifier= value;
OnPropertyChanged("accessionIdentifier", value);
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

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public FhirDateTime? ReceivedTime
{
get { return _receivedTime; }
set {
_receivedTime= value;
OnPropertyChanged("receivedTime", value);
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

public FhirCode? Combined
{
get { return _combined; }
set {
_combined= value;
OnPropertyChanged("combined", value);
}
}

public List<CodeableConcept>? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}

public List<SpecimenFeature>? Feature
{
get { return _feature; }
set {
_feature= value;
OnPropertyChanged("feature", value);
}
}

public SpecimenCollection? Collection
{
get { return _collection; }
set {
_collection= value;
OnPropertyChanged("collection", value);
}
}

public List<SpecimenProcessing>? Processing
{
get { return _processing; }
set {
_processing= value;
OnPropertyChanged("processing", value);
}
}

public List<SpecimenContainer>? Container
{
get { return _container; }
set {
_container= value;
OnPropertyChanged("container", value);
}
}

public List<CodeableConcept>? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
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
		public  Specimen() { }
		public  Specimen(string value) : base(value) { }
		public  Specimen(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SpecimenFeature : BackboneElementType<SpecimenFeature>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private FhirString? _description;

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

public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}


		#endregion
		#region Constructor
		public  SpecimenFeature() { }
		public  SpecimenFeature(string value) : base(value) { }
		public  SpecimenFeature(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SpecimenCollection : BackboneElementType<SpecimenCollection>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _collector;
private SpecimenCollectionCollectedChoice? _collected;
private Duration? _duration;
private Quantity? _quantity;
private CodeableConcept? _method;
private CodeableReference? _device;
private ReferenceType? _procedure;
private CodeableReference? _bodySite;
private SpecimenCollectionFastingStatusChoice? _fastingStatus;

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

public SpecimenCollectionCollectedChoice? Collected
{
get { return _collected; }
set {
_collected= value;
OnPropertyChanged("collected", value);
}
}

public Duration? Duration
{
get { return _duration; }
set {
_duration= value;
OnPropertyChanged("duration", value);
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

public CodeableConcept? Method
{
get { return _method; }
set {
_method= value;
OnPropertyChanged("method", value);
}
}

public CodeableReference? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}

public ReferenceType? Procedure
{
get { return _procedure; }
set {
_procedure= value;
OnPropertyChanged("procedure", value);
}
}

public CodeableReference? BodySite
{
get { return _bodySite; }
set {
_bodySite= value;
OnPropertyChanged("bodySite", value);
}
}

public SpecimenCollectionFastingStatusChoice? FastingStatus
{
get { return _fastingStatus; }
set {
_fastingStatus= value;
OnPropertyChanged("fastingStatus", value);
}
}


		#endregion
		#region Constructor
		public  SpecimenCollection() { }
		public  SpecimenCollection(string value) : base(value) { }
		public  SpecimenCollection(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SpecimenProcessing : BackboneElementType<SpecimenProcessing>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _description;
private CodeableConcept? _method;
private List<ReferenceType>? _additive;
private SpecimenProcessingTimeChoice? _time;

		#endregion
		#region public Method
		public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public CodeableConcept? Method
{
get { return _method; }
set {
_method= value;
OnPropertyChanged("method", value);
}
}

public List<ReferenceType>? Additive
{
get { return _additive; }
set {
_additive= value;
OnPropertyChanged("additive", value);
}
}

public SpecimenProcessingTimeChoice? Time
{
get { return _time; }
set {
_time= value;
OnPropertyChanged("time", value);
}
}


		#endregion
		#region Constructor
		public  SpecimenProcessing() { }
		public  SpecimenProcessing(string value) : base(value) { }
		public  SpecimenProcessing(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SpecimenContainer : BackboneElementType<SpecimenContainer>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _device;
private ReferenceType? _location;
private Quantity? _specimenQuantity;

		#endregion
		#region public Method
		public ReferenceType? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}

public ReferenceType? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public Quantity? SpecimenQuantity
{
get { return _specimenQuantity; }
set {
_specimenQuantity= value;
OnPropertyChanged("specimenQuantity", value);
}
}


		#endregion
		#region Constructor
		public  SpecimenContainer() { }
		public  SpecimenContainer(string value) : base(value) { }
		public  SpecimenContainer(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class SpecimenCollectionCollectedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public SpecimenCollectionCollectedChoice(JsonObject value) : base("collected", value, _supportType)
        {
        }
        public SpecimenCollectionCollectedChoice(IComplexType? value) : base("collected", value)
        {
        }
        public SpecimenCollectionCollectedChoice(IPrimitiveType? value) : base("collected", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"collected".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class SpecimenCollectionFastingStatusChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Duration"
        ];

        public SpecimenCollectionFastingStatusChoice(JsonObject value) : base("fastingStatus", value, _supportType)
        {
        }
        public SpecimenCollectionFastingStatusChoice(IComplexType? value) : base("fastingStatus", value)
        {
        }
        public SpecimenCollectionFastingStatusChoice(IPrimitiveType? value) : base("fastingStatus", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"fastingStatus".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class SpecimenProcessingTimeChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public SpecimenProcessingTimeChoice(JsonObject value) : base("time", value, _supportType)
        {
        }
        public SpecimenProcessingTimeChoice(IComplexType? value) : base("time", value)
        {
        }
        public SpecimenProcessingTimeChoice(IPrimitiveType? value) : base("time", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"time".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
