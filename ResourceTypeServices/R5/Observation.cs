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
    public class Observation : ResourceType<Observation>
	{
		#region private Property
		private List<Identifier>? _identifier;
private ObservationInstantiatesChoice? _instantiates;
private List<ReferenceType>? _basedOn;
private List<ObservationTriggeredBy>? _triggeredBy;
private List<ReferenceType>? _partOf;
private FhirCode? _status;
private List<CodeableConcept>? _category;
private CodeableConcept? _code;
private ReferenceType? _subject;
private List<ReferenceType>? _focus;
private ReferenceType? _encounter;
private ObservationEffectiveChoice? _effective;
private FhirInstant? _issued;
private List<ReferenceType>? _performer;
private ObservationValueChoice? _value;
private CodeableConcept? _dataAbsentReason;
private List<CodeableConcept>? _interpretation;
private List<Annotation>? _note;
private CodeableConcept? _bodySite;
private ReferenceType? _bodyStructure;
private CodeableConcept? _method;
private ReferenceType? _specimen;
private ReferenceType? _device;
private List<ObservationReferenceRange>? _referenceRange;
private List<ReferenceType>? _hasMember;
private List<ReferenceType>? _derivedFrom;
private List<ObservationComponent>? _component;

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

public ObservationInstantiatesChoice? Instantiates
{
get { return _instantiates; }
set {
_instantiates= value;
OnPropertyChanged("instantiates", value);
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

public List<ObservationTriggeredBy>? TriggeredBy
{
get { return _triggeredBy; }
set {
_triggeredBy= value;
OnPropertyChanged("triggeredBy", value);
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

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public List<ReferenceType>? Focus
{
get { return _focus; }
set {
_focus= value;
OnPropertyChanged("focus", value);
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

public ObservationEffectiveChoice? Effective
{
get { return _effective; }
set {
_effective= value;
OnPropertyChanged("effective", value);
}
}

public FhirInstant? Issued
{
get { return _issued; }
set {
_issued= value;
OnPropertyChanged("issued", value);
}
}

public List<ReferenceType>? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
}
}

public ObservationValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public CodeableConcept? DataAbsentReason
{
get { return _dataAbsentReason; }
set {
_dataAbsentReason= value;
OnPropertyChanged("dataAbsentReason", value);
}
}

public List<CodeableConcept>? Interpretation
{
get { return _interpretation; }
set {
_interpretation= value;
OnPropertyChanged("interpretation", value);
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

public CodeableConcept? BodySite
{
get { return _bodySite; }
set {
_bodySite= value;
OnPropertyChanged("bodySite", value);
}
}

public ReferenceType? BodyStructure
{
get { return _bodyStructure; }
set {
_bodyStructure= value;
OnPropertyChanged("bodyStructure", value);
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

public ReferenceType? Specimen
{
get { return _specimen; }
set {
_specimen= value;
OnPropertyChanged("specimen", value);
}
}

public ReferenceType? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}

public List<ObservationReferenceRange>? ReferenceRange
{
get { return _referenceRange; }
set {
_referenceRange= value;
OnPropertyChanged("referenceRange", value);
}
}

public List<ReferenceType>? HasMember
{
get { return _hasMember; }
set {
_hasMember= value;
OnPropertyChanged("hasMember", value);
}
}

public List<ReferenceType>? DerivedFrom
{
get { return _derivedFrom; }
set {
_derivedFrom= value;
OnPropertyChanged("derivedFrom", value);
}
}

public List<ObservationComponent>? Component
{
get { return _component; }
set {
_component= value;
OnPropertyChanged("component", value);
}
}


		#endregion
		#region Constructor
		public  Observation() { }
		public  Observation(string value) : base(value) { }
		public  Observation(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ObservationTriggeredBy : BackboneElementType<ObservationTriggeredBy>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _observation;
private FhirCode? _type;
private FhirString? _reason;

		#endregion
		#region public Method
		public ReferenceType? Observation
{
get { return _observation; }
set {
_observation= value;
OnPropertyChanged("observation", value);
}
}

public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirString? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}


		#endregion
		#region Constructor
		public  ObservationTriggeredBy() { }
		public  ObservationTriggeredBy(string value) : base(value) { }
		public  ObservationTriggeredBy(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ObservationReferenceRange : BackboneElementType<ObservationReferenceRange>, IBackboneElementType
	{

		#region Private Method
		private Quantity? _low;
private Quantity? _high;
private CodeableConcept? _normalValue;
private CodeableConcept? _type;
private List<CodeableConcept>? _appliesTo;
private Range? _age;

		#endregion
		#region public Method
		public Quantity? Low
{
get { return _low; }
set {
_low= value;
OnPropertyChanged("low", value);
}
}

public Quantity? High
{
get { return _high; }
set {
_high= value;
OnPropertyChanged("high", value);
}
}

public CodeableConcept? NormalValue
{
get { return _normalValue; }
set {
_normalValue= value;
OnPropertyChanged("normalValue", value);
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

public List<CodeableConcept>? AppliesTo
{
get { return _appliesTo; }
set {
_appliesTo= value;
OnPropertyChanged("appliesTo", value);
}
}

public Range? Age
{
get { return _age; }
set {
_age= value;
OnPropertyChanged("age", value);
}
}


		#endregion
		#region Constructor
		public  ObservationReferenceRange() { }
		public  ObservationReferenceRange(string value) : base(value) { }
		public  ObservationReferenceRange(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ObservationComponent : BackboneElementType<ObservationComponent>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private ObservationComponentValueChoice? _value;
private CodeableConcept? _dataAbsentReason;
private List<CodeableConcept>? _interpretation;

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

public ObservationComponentValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public CodeableConcept? DataAbsentReason
{
get { return _dataAbsentReason; }
set {
_dataAbsentReason= value;
OnPropertyChanged("dataAbsentReason", value);
}
}

public List<CodeableConcept>? Interpretation
{
get { return _interpretation; }
set {
_interpretation= value;
OnPropertyChanged("interpretation", value);
}
}


		#endregion
		#region Constructor
		public  ObservationComponent() { }
		public  ObservationComponent(string value) : base(value) { }
		public  ObservationComponent(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ObservationInstantiatesChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "canonical(ObservationDefinition)","Reference(ObservationDefinition)"
        ];

        public ObservationInstantiatesChoice(JsonObject value) : base("instantiates", value, _supportType)
        {
        }
        public ObservationInstantiatesChoice(IComplexType? value) : base("instantiates", value)
        {
        }
        public ObservationInstantiatesChoice(IPrimitiveType? value) : base("instantiates", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"instantiates".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ObservationEffectiveChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","PeriodTiminginstant"
        ];

        public ObservationEffectiveChoice(JsonObject value) : base("effective", value, _supportType)
        {
        }
        public ObservationEffectiveChoice(IComplexType? value) : base("effective", value)
        {
        }
        public ObservationEffectiveChoice(IPrimitiveType? value) : base("effective", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"effective".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ObservationValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","CodeableConceptstringbooleanintegerRangeRatioSampledDatatimedateTimePeriodAttachmentReference(MolecularSequence)"
        ];

        public ObservationValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ObservationValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ObservationValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ObservationComponentValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","CodeableConceptstringbooleanintegerRangeRatioSampledDatatimedateTimePeriodAttachmentReference(MolecularSequence)"
        ];

        public ObservationComponentValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ObservationComponentValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ObservationComponentValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
