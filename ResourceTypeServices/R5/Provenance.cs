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
    public class Provenance : ResourceType<Provenance>
	{
		#region private Property
		private List<ReferenceType>? _target;
private ProvenanceOccurredChoice? _occurred;
private FhirInstant? _recorded;
private List<FhirUri>? _policy;
private ReferenceType? _location;
private List<CodeableReference>? _authorization;
private CodeableConcept? _activity;
private List<ReferenceType>? _basedOn;
private ReferenceType? _patient;
private ReferenceType? _encounter;
private List<ProvenanceAgent>? _agent;
private List<ProvenanceEntity>? _entity;
private List<Signature>? _signature;

		#endregion
		#region Public Method
		public List<ReferenceType>? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
}
}

public ProvenanceOccurredChoice? Occurred
{
get { return _occurred; }
set {
_occurred= value;
OnPropertyChanged("occurred", value);
}
}

public FhirInstant? Recorded
{
get { return _recorded; }
set {
_recorded= value;
OnPropertyChanged("recorded", value);
}
}

public List<FhirUri>? Policy
{
get { return _policy; }
set {
_policy= value;
OnPropertyChanged("policy", value);
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

public List<CodeableReference>? Authorization
{
get { return _authorization; }
set {
_authorization= value;
OnPropertyChanged("authorization", value);
}
}

public CodeableConcept? Activity
{
get { return _activity; }
set {
_activity= value;
OnPropertyChanged("activity", value);
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

public ReferenceType? Patient
{
get { return _patient; }
set {
_patient= value;
OnPropertyChanged("patient", value);
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

public List<ProvenanceAgent>? Agent
{
get { return _agent; }
set {
_agent= value;
OnPropertyChanged("agent", value);
}
}

public List<ProvenanceEntity>? Entity
{
get { return _entity; }
set {
_entity= value;
OnPropertyChanged("entity", value);
}
}

public List<Signature>? Signature
{
get { return _signature; }
set {
_signature= value;
OnPropertyChanged("signature", value);
}
}


		#endregion
		#region Constructor
		public  Provenance() { }
		public  Provenance(string value) : base(value) { }
		public  Provenance(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ProvenanceAgent : BackboneElementType<ProvenanceAgent>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private List<CodeableConcept>? _role;
private ReferenceType? _who;
private ReferenceType? _onBehalfOf;

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

public List<CodeableConcept>? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}

public ReferenceType? Who
{
get { return _who; }
set {
_who= value;
OnPropertyChanged("who", value);
}
}

public ReferenceType? OnBehalfOf
{
get { return _onBehalfOf; }
set {
_onBehalfOf= value;
OnPropertyChanged("onBehalfOf", value);
}
}


		#endregion
		#region Constructor
		public  ProvenanceAgent() { }
		public  ProvenanceAgent(string value) : base(value) { }
		public  ProvenanceAgent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ProvenanceEntity : BackboneElementType<ProvenanceEntity>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _role;
private ReferenceType? _what;

		#endregion
		#region public Method
		public FhirCode? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}

public ReferenceType? What
{
get { return _what; }
set {
_what= value;
OnPropertyChanged("what", value);
}
}


		#endregion
		#region Constructor
		public  ProvenanceEntity() { }
		public  ProvenanceEntity(string value) : base(value) { }
		public  ProvenanceEntity(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ProvenanceOccurredChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Period","dateTime"
        ];

        public ProvenanceOccurredChoice(JsonObject value) : base("occurred", value, _supportType)
        {
        }
        public ProvenanceOccurredChoice(IComplexType? value) : base("occurred", value)
        {
        }
        public ProvenanceOccurredChoice(IPrimitiveType? value) : base("occurred", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurred".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
