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
    public class MedicationAdministration : ResourceType<MedicationAdministration>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _partOf;
private FhirCode? _status;
private List<CodeableConcept>? _statusReason;
private List<CodeableConcept>? _category;
private CodeableReference? _medication;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private List<ReferenceType>? _supportingInformation;
private MedicationAdministrationOccurenceChoice? _occurence;
private FhirDateTime? _recorded;
private FhirBoolean? _isSubPotent;
private List<CodeableConcept>? _subPotentReason;
private List<MedicationAdministrationPerformer>? _performer;
private List<CodeableReference>? _reason;
private ReferenceType? _request;
private List<CodeableReference>? _device;
private List<Annotation>? _note;
private MedicationAdministrationDosage? _dosage;
private List<ReferenceType>? _eventHistory;

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

public List<CodeableConcept>? StatusReason
{
get { return _statusReason; }
set {
_statusReason= value;
OnPropertyChanged("statusReason", value);
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

public CodeableReference? Medication
{
get { return _medication; }
set {
_medication= value;
OnPropertyChanged("medication", value);
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

public List<ReferenceType>? SupportingInformation
{
get { return _supportingInformation; }
set {
_supportingInformation= value;
OnPropertyChanged("supportingInformation", value);
}
}

public MedicationAdministrationOccurenceChoice? Occurence
{
get { return _occurence; }
set {
_occurence= value;
OnPropertyChanged("occurence", value);
}
}

public FhirDateTime? Recorded
{
get { return _recorded; }
set {
_recorded= value;
OnPropertyChanged("recorded", value);
}
}

public FhirBoolean? IsSubPotent
{
get { return _isSubPotent; }
set {
_isSubPotent= value;
OnPropertyChanged("isSubPotent", value);
}
}

public List<CodeableConcept>? SubPotentReason
{
get { return _subPotentReason; }
set {
_subPotentReason= value;
OnPropertyChanged("subPotentReason", value);
}
}

public List<MedicationAdministrationPerformer>? Performer
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

public ReferenceType? Request
{
get { return _request; }
set {
_request= value;
OnPropertyChanged("request", value);
}
}

public List<CodeableReference>? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
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

public MedicationAdministrationDosage? Dosage
{
get { return _dosage; }
set {
_dosage= value;
OnPropertyChanged("dosage", value);
}
}

public List<ReferenceType>? EventHistory
{
get { return _eventHistory; }
set {
_eventHistory= value;
OnPropertyChanged("eventHistory", value);
}
}


		#endregion
		#region Constructor
		public  MedicationAdministration() { }
		public  MedicationAdministration(string value) : base(value) { }
		public  MedicationAdministration(JsonNode? source) : base(source) { }
		#endregion
	}
		public class MedicationAdministrationPerformer : BackboneElementType<MedicationAdministrationPerformer>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _function;
private CodeableReference? _actor;

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

public CodeableReference? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}


		#endregion
		#region Constructor
		public  MedicationAdministrationPerformer() { }
		public  MedicationAdministrationPerformer(string value) : base(value) { }
		public  MedicationAdministrationPerformer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationAdministrationDosage : BackboneElementType<MedicationAdministrationDosage>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _site;
private CodeableConcept? _route;
private CodeableConcept? _method;
private Quantity? _dose;
private MedicationAdministrationDosageRateChoice? _rate;

		#endregion
		#region public Method
		public CodeableConcept? Site
{
get { return _site; }
set {
_site= value;
OnPropertyChanged("site", value);
}
}

public CodeableConcept? Route
{
get { return _route; }
set {
_route= value;
OnPropertyChanged("route", value);
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

public Quantity? Dose
{
get { return _dose; }
set {
_dose= value;
OnPropertyChanged("dose", value);
}
}

public MedicationAdministrationDosageRateChoice? Rate
{
get { return _rate; }
set {
_rate= value;
OnPropertyChanged("rate", value);
}
}


		#endregion
		#region Constructor
		public  MedicationAdministrationDosage() { }
		public  MedicationAdministrationDosage(string value) : base(value) { }
		public  MedicationAdministrationDosage(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class MedicationAdministrationOccurenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","PeriodTiming"
        ];

        public MedicationAdministrationOccurenceChoice(JsonObject value) : base("occurence", value, _supportType)
        {
        }
        public MedicationAdministrationOccurenceChoice(IComplexType? value) : base("occurence", value)
        {
        }
        public MedicationAdministrationOccurenceChoice(IPrimitiveType? value) : base("occurence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MedicationAdministrationDosageRateChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Ratio","Quantity {SimpleQuantity}"
        ];

        public MedicationAdministrationDosageRateChoice(JsonObject value) : base("rate", value, _supportType)
        {
        }
        public MedicationAdministrationDosageRateChoice(IComplexType? value) : base("rate", value)
        {
        }
        public MedicationAdministrationDosageRateChoice(IPrimitiveType? value) : base("rate", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"rate".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
