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
    public class ServiceRequest : ResourceType<ServiceRequest>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<FhirCanonical>? _instantiatesCanonical;
private List<FhirUri>? _instantiatesUri;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _replaces;
private Identifier? _requisition;
private FhirCode? _status;
private FhirCode? _intent;
private List<CodeableConcept>? _category;
private FhirCode? _priority;
private FhirBoolean? _doNotPerform;
private CodeableReference? _code;
private List<ServiceRequestOrderDetail>? _orderDetail;
private ServiceRequestQuantityChoice? _quantity;
private ReferenceType? _subject;
private List<ReferenceType>? _focus;
private ReferenceType? _encounter;
private ServiceRequestOccurrenceChoice? _occurrence;
private ServiceRequestAsNeededChoice? _asNeeded;
private FhirDateTime? _authoredOn;
private ReferenceType? _requester;
private CodeableConcept? _performerType;
private List<ReferenceType>? _performer;
private List<CodeableReference>? _location;
private List<CodeableReference>? _reason;
private List<ReferenceType>? _insurance;
private List<CodeableReference>? _supportingInfo;
private List<ReferenceType>? _specimen;
private List<CodeableConcept>? _bodySite;
private ReferenceType? _bodyStructure;
private List<Annotation>? _note;
private List<ServiceRequestPatientInstruction>? _patientInstruction;
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

public Identifier? Requisition
{
get { return _requisition; }
set {
_requisition= value;
OnPropertyChanged("requisition", value);
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

public List<CodeableConcept>? Category
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

public List<ServiceRequestOrderDetail>? OrderDetail
{
get { return _orderDetail; }
set {
_orderDetail= value;
OnPropertyChanged("orderDetail", value);
}
}

public ServiceRequestQuantityChoice? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
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

public ServiceRequestOccurrenceChoice? Occurrence
{
get { return _occurrence; }
set {
_occurrence= value;
OnPropertyChanged("occurrence", value);
}
}

public ServiceRequestAsNeededChoice? AsNeeded
{
get { return _asNeeded; }
set {
_asNeeded= value;
OnPropertyChanged("asNeeded", value);
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

public CodeableConcept? PerformerType
{
get { return _performerType; }
set {
_performerType= value;
OnPropertyChanged("performerType", value);
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

public List<CodeableReference>? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
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

public List<ReferenceType>? Insurance
{
get { return _insurance; }
set {
_insurance= value;
OnPropertyChanged("insurance", value);
}
}

public List<CodeableReference>? SupportingInfo
{
get { return _supportingInfo; }
set {
_supportingInfo= value;
OnPropertyChanged("supportingInfo", value);
}
}

public List<ReferenceType>? Specimen
{
get { return _specimen; }
set {
_specimen= value;
OnPropertyChanged("specimen", value);
}
}

public List<CodeableConcept>? BodySite
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

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
}
}

public List<ServiceRequestPatientInstruction>? PatientInstruction
{
get { return _patientInstruction; }
set {
_patientInstruction= value;
OnPropertyChanged("patientInstruction", value);
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
		public  ServiceRequest() { }
		public  ServiceRequest(string value) : base(value) { }
		public  ServiceRequest(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ServiceRequestOrderDetailParameter : BackboneElementType<ServiceRequestOrderDetailParameter>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private ServiceRequestOrderDetailParameterValueChoice? _value;

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

public ServiceRequestOrderDetailParameterValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  ServiceRequestOrderDetailParameter() { }
		public  ServiceRequestOrderDetailParameter(string value) : base(value) { }
		public  ServiceRequestOrderDetailParameter(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ServiceRequestOrderDetail : BackboneElementType<ServiceRequestOrderDetail>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _parameterFocus;
private List<ServiceRequestOrderDetailParameter>? _parameter;

		#endregion
		#region public Method
		public CodeableReference? ParameterFocus
{
get { return _parameterFocus; }
set {
_parameterFocus= value;
OnPropertyChanged("parameterFocus", value);
}
}

public List<ServiceRequestOrderDetailParameter>? Parameter
{
get { return _parameter; }
set {
_parameter= value;
OnPropertyChanged("parameter", value);
}
}


		#endregion
		#region Constructor
		public  ServiceRequestOrderDetail() { }
		public  ServiceRequestOrderDetail(string value) : base(value) { }
		public  ServiceRequestOrderDetail(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ServiceRequestPatientInstruction : BackboneElementType<ServiceRequestPatientInstruction>, IBackboneElementType
	{

		#region Private Method
		private ServiceRequestPatientInstructionInstructionChoice? _instruction;

		#endregion
		#region public Method
		public ServiceRequestPatientInstructionInstructionChoice? Instruction
{
get { return _instruction; }
set {
_instruction= value;
OnPropertyChanged("instruction", value);
}
}


		#endregion
		#region Constructor
		public  ServiceRequestPatientInstruction() { }
		public  ServiceRequestPatientInstruction(string value) : base(value) { }
		public  ServiceRequestPatientInstruction(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ServiceRequestOrderDetailParameterValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","RatioRangebooleanCodeableConceptstringPeriod"
        ];

        public ServiceRequestOrderDetailParameterValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ServiceRequestOrderDetailParameterValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ServiceRequestOrderDetailParameterValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ServiceRequestQuantityChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","RatioRange"
        ];

        public ServiceRequestQuantityChoice(JsonObject value) : base("quantity", value, _supportType)
        {
        }
        public ServiceRequestQuantityChoice(IComplexType? value) : base("quantity", value)
        {
        }
        public ServiceRequestQuantityChoice(IPrimitiveType? value) : base("quantity", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"quantity".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ServiceRequestOccurrenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","PeriodTiming"
        ];

        public ServiceRequestOccurrenceChoice(JsonObject value) : base("occurrence", value, _supportType)
        {
        }
        public ServiceRequestOccurrenceChoice(IComplexType? value) : base("occurrence", value)
        {
        }
        public ServiceRequestOccurrenceChoice(IPrimitiveType? value) : base("occurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurrence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ServiceRequestAsNeededChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","CodeableConcept"
        ];

        public ServiceRequestAsNeededChoice(JsonObject value) : base("asNeeded", value, _supportType)
        {
        }
        public ServiceRequestAsNeededChoice(IComplexType? value) : base("asNeeded", value)
        {
        }
        public ServiceRequestAsNeededChoice(IPrimitiveType? value) : base("asNeeded", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"asNeeded".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ServiceRequestPatientInstructionInstructionChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "markdown","Reference(DocumentReference)"
        ];

        public ServiceRequestPatientInstructionInstructionChoice(JsonObject value) : base("instruction", value, _supportType)
        {
        }
        public ServiceRequestPatientInstructionInstructionChoice(IComplexType? value) : base("instruction", value)
        {
        }
        public ServiceRequestPatientInstructionInstructionChoice(IPrimitiveType? value) : base("instruction", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"instruction".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
