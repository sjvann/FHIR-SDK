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
    public class DeviceRequest : ResourceType<DeviceRequest>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<FhirCanonical>? _instantiatesCanonical;
private List<FhirUri>? _instantiatesUri;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _replaces;
private Identifier? _groupIdentifier;
private FhirCode? _status;
private FhirCode? _intent;
private FhirCode? _priority;
private FhirBoolean? _doNotPerform;
private CodeableReference? _code;
private FhirInteger? _quantity;
private List<DeviceRequestParameter>? _parameter;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private DeviceRequestOccurrenceChoice? _occurrence;
private FhirDateTime? _authoredOn;
private ReferenceType? _requester;
private CodeableReference? _performer;
private List<CodeableReference>? _reason;
private FhirBoolean? _asNeeded;
private CodeableConcept? _asNeededFor;
private List<ReferenceType>? _insurance;
private List<ReferenceType>? _supportingInfo;
private List<Annotation>? _note;
private List<ReferenceType>? _relevantHistory;

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

public List<FhirCanonical>? InstantiatesCanonical
{
get { return _instantiatesCanonical; }
set {
_instantiatesCanonical= value;
OnPropertyChanged("instantiatesCanonical", value);
}
}

public List<FhirUri>? InstantiatesUri
{
get { return _instantiatesUri; }
set {
_instantiatesUri= value;
OnPropertyChanged("instantiatesUri", value);
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

public List<ReferenceType>? Replaces
{
get { return _replaces; }
set {
_replaces= value;
OnPropertyChanged("replaces", value);
}
}

public Identifier? GroupIdentifier
{
get { return _groupIdentifier; }
set {
_groupIdentifier= value;
OnPropertyChanged("groupIdentifier", value);
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

public FhirCode? Intent
{
get { return _intent; }
set {
_intent= value;
OnPropertyChanged("intent", value);
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

public FhirBoolean? DoNotPerform
{
get { return _doNotPerform; }
set {
_doNotPerform= value;
OnPropertyChanged("doNotPerform", value);
}
}

public CodeableReference? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public FhirInteger? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}

public List<DeviceRequestParameter>? Parameter
{
get { return _parameter; }
set {
_parameter= value;
OnPropertyChanged("parameter", value);
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

public DeviceRequestOccurrenceChoice? Occurrence
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

public CodeableReference? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
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

public FhirBoolean? AsNeeded
{
get { return _asNeeded; }
set {
_asNeeded= value;
OnPropertyChanged("asNeeded", value);
}
}

public CodeableConcept? AsNeededFor
{
get { return _asNeededFor; }
set {
_asNeededFor= value;
OnPropertyChanged("asNeededFor", value);
}
}

public List<ReferenceType>? Insurance
{
get { return _insurance; }
set {
_insurance= value;
OnPropertyChanged("insurance", value);
}
}

public List<ReferenceType>? SupportingInfo
{
get { return _supportingInfo; }
set {
_supportingInfo= value;
OnPropertyChanged("supportingInfo", value);
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

public List<ReferenceType>? RelevantHistory
{
get { return _relevantHistory; }
set {
_relevantHistory= value;
OnPropertyChanged("relevantHistory", value);
}
}


		#endregion
		#region Constructor
		public  DeviceRequest() { }
		public  DeviceRequest(string value) : base(value) { }
		public  DeviceRequest(JsonNode? source) : base(source) { }
		#endregion
	}
		public class DeviceRequestParameter : BackboneElementType<DeviceRequestParameter>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private DeviceRequestParameterValueChoice? _value;

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

public DeviceRequestParameterValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  DeviceRequestParameter() { }
		public  DeviceRequestParameter(string value) : base(value) { }
		public  DeviceRequestParameter(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class DeviceRequestParameterValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","QuantityRangeboolean"
        ];

        public DeviceRequestParameterValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public DeviceRequestParameterValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public DeviceRequestParameterValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class DeviceRequestOccurrenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","PeriodTiming"
        ];

        public DeviceRequestOccurrenceChoice(JsonObject value) : base("occurrence", value, _supportType)
        {
        }
        public DeviceRequestOccurrenceChoice(IComplexType? value) : base("occurrence", value)
        {
        }
        public DeviceRequestOccurrenceChoice(IPrimitiveType? value) : base("occurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurrence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
