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
    public class AdverseEvent : ResourceType<AdverseEvent>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private FhirCode? _actuality;
private List<CodeableConcept>? _category;
private CodeableConcept? _code;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private AdverseEventOccurrenceChoice? _occurrence;
private FhirDateTime? _detected;
private FhirDateTime? _recordedDate;
private List<ReferenceType>? _resultingEffect;
private ReferenceType? _location;
private CodeableConcept? _seriousness;
private List<CodeableConcept>? _outcome;
private ReferenceType? _recorder;
private List<AdverseEventParticipant>? _participant;
private List<ReferenceType>? _study;
private FhirBoolean? _expectedInResearchStudy;
private List<AdverseEventSuspectEntity>? _suspectEntity;
private List<AdverseEventContributingFactor>? _contributingFactor;
private List<AdverseEventPreventiveAction>? _preventiveAction;
private List<AdverseEventMitigatingAction>? _mitigatingAction;
private List<AdverseEventSupportingInfo>? _supportingInfo;
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

public FhirCode? Actuality
{
get { return _actuality; }
set {
_actuality= value;
OnPropertyChanged("actuality", value);
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

public ReferenceType? Encounter
{
get { return _encounter; }
set {
_encounter= value;
OnPropertyChanged("encounter", value);
}
}

public AdverseEventOccurrenceChoice? Occurrence
{
get { return _occurrence; }
set {
_occurrence= value;
OnPropertyChanged("occurrence", value);
}
}

public FhirDateTime? Detected
{
get { return _detected; }
set {
_detected= value;
OnPropertyChanged("detected", value);
}
}

public FhirDateTime? RecordedDate
{
get { return _recordedDate; }
set {
_recordedDate= value;
OnPropertyChanged("recordedDate", value);
}
}

public List<ReferenceType>? ResultingEffect
{
get { return _resultingEffect; }
set {
_resultingEffect= value;
OnPropertyChanged("resultingEffect", value);
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

public CodeableConcept? Seriousness
{
get { return _seriousness; }
set {
_seriousness= value;
OnPropertyChanged("seriousness", value);
}
}

public List<CodeableConcept>? Outcome
{
get { return _outcome; }
set {
_outcome= value;
OnPropertyChanged("outcome", value);
}
}

public ReferenceType? Recorder
{
get { return _recorder; }
set {
_recorder= value;
OnPropertyChanged("recorder", value);
}
}

public List<AdverseEventParticipant>? Participant
{
get { return _participant; }
set {
_participant= value;
OnPropertyChanged("participant", value);
}
}

public List<ReferenceType>? Study
{
get { return _study; }
set {
_study= value;
OnPropertyChanged("study", value);
}
}

public FhirBoolean? ExpectedInResearchStudy
{
get { return _expectedInResearchStudy; }
set {
_expectedInResearchStudy= value;
OnPropertyChanged("expectedInResearchStudy", value);
}
}

public List<AdverseEventSuspectEntity>? SuspectEntity
{
get { return _suspectEntity; }
set {
_suspectEntity= value;
OnPropertyChanged("suspectEntity", value);
}
}

public List<AdverseEventContributingFactor>? ContributingFactor
{
get { return _contributingFactor; }
set {
_contributingFactor= value;
OnPropertyChanged("contributingFactor", value);
}
}

public List<AdverseEventPreventiveAction>? PreventiveAction
{
get { return _preventiveAction; }
set {
_preventiveAction= value;
OnPropertyChanged("preventiveAction", value);
}
}

public List<AdverseEventMitigatingAction>? MitigatingAction
{
get { return _mitigatingAction; }
set {
_mitigatingAction= value;
OnPropertyChanged("mitigatingAction", value);
}
}

public List<AdverseEventSupportingInfo>? SupportingInfo
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


		#endregion
		#region Constructor
		public  AdverseEvent() { }
		public  AdverseEvent(string value) : base(value) { }
		public  AdverseEvent(JsonNode? source) : base(source) { }
		#endregion
	}
		public class AdverseEventParticipant : BackboneElementType<AdverseEventParticipant>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _function;
private ReferenceType? _actor;

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

public ReferenceType? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}


		#endregion
		#region Constructor
		public  AdverseEventParticipant() { }
		public  AdverseEventParticipant(string value) : base(value) { }
		public  AdverseEventParticipant(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AdverseEventSuspectEntityCausality : BackboneElementType<AdverseEventSuspectEntityCausality>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _assessmentMethod;
private CodeableConcept? _entityRelatedness;
private ReferenceType? _author;

		#endregion
		#region public Method
		public CodeableConcept? AssessmentMethod
{
get { return _assessmentMethod; }
set {
_assessmentMethod= value;
OnPropertyChanged("assessmentMethod", value);
}
}

public CodeableConcept? EntityRelatedness
{
get { return _entityRelatedness; }
set {
_entityRelatedness= value;
OnPropertyChanged("entityRelatedness", value);
}
}

public ReferenceType? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}


		#endregion
		#region Constructor
		public  AdverseEventSuspectEntityCausality() { }
		public  AdverseEventSuspectEntityCausality(string value) : base(value) { }
		public  AdverseEventSuspectEntityCausality(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AdverseEventSuspectEntity : BackboneElementType<AdverseEventSuspectEntity>, IBackboneElementType
	{

		#region Private Method
		private AdverseEventSuspectEntityInstanceChoice? _instance;
private AdverseEventSuspectEntityCausality? _causality;

		#endregion
		#region public Method
		public AdverseEventSuspectEntityInstanceChoice? Instance
{
get { return _instance; }
set {
_instance= value;
OnPropertyChanged("instance", value);
}
}

public AdverseEventSuspectEntityCausality? Causality
{
get { return _causality; }
set {
_causality= value;
OnPropertyChanged("causality", value);
}
}


		#endregion
		#region Constructor
		public  AdverseEventSuspectEntity() { }
		public  AdverseEventSuspectEntity(string value) : base(value) { }
		public  AdverseEventSuspectEntity(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AdverseEventContributingFactor : BackboneElementType<AdverseEventContributingFactor>, IBackboneElementType
	{

		#region Private Method
		private AdverseEventContributingFactorItemChoice? _item;

		#endregion
		#region public Method
		public AdverseEventContributingFactorItemChoice? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}


		#endregion
		#region Constructor
		public  AdverseEventContributingFactor() { }
		public  AdverseEventContributingFactor(string value) : base(value) { }
		public  AdverseEventContributingFactor(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AdverseEventPreventiveAction : BackboneElementType<AdverseEventPreventiveAction>, IBackboneElementType
	{

		#region Private Method
		private AdverseEventPreventiveActionItemChoice? _item;

		#endregion
		#region public Method
		public AdverseEventPreventiveActionItemChoice? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}


		#endregion
		#region Constructor
		public  AdverseEventPreventiveAction() { }
		public  AdverseEventPreventiveAction(string value) : base(value) { }
		public  AdverseEventPreventiveAction(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AdverseEventMitigatingAction : BackboneElementType<AdverseEventMitigatingAction>, IBackboneElementType
	{

		#region Private Method
		private AdverseEventMitigatingActionItemChoice? _item;

		#endregion
		#region public Method
		public AdverseEventMitigatingActionItemChoice? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}


		#endregion
		#region Constructor
		public  AdverseEventMitigatingAction() { }
		public  AdverseEventMitigatingAction(string value) : base(value) { }
		public  AdverseEventMitigatingAction(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AdverseEventSupportingInfo : BackboneElementType<AdverseEventSupportingInfo>, IBackboneElementType
	{

		#region Private Method
		private AdverseEventSupportingInfoItemChoice? _item;

		#endregion
		#region public Method
		public AdverseEventSupportingInfoItemChoice? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}


		#endregion
		#region Constructor
		public  AdverseEventSupportingInfo() { }
		public  AdverseEventSupportingInfo(string value) : base(value) { }
		public  AdverseEventSupportingInfo(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class AdverseEventOccurrenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","PeriodTiming"
        ];
		public AdverseEventOccurrenceChoice(string dataType, JsonValue? value) : base(dataType, value) { }

        public AdverseEventOccurrenceChoice(JsonObject value) : base("occurrence", value, _supportType)
        {
        }
        public AdverseEventOccurrenceChoice(IComplexType? value) : base("occurrence", value)
        {
        }
        public AdverseEventOccurrenceChoice(IPrimitiveType? value) : base("occurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurrence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class AdverseEventSuspectEntityInstanceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Immunization|Procedure|Substance|Medication|MedicationAdministration|MedicationStatement|Device|BiologicallyDerivedProduct|ResearchStudy)"
        ];
		public AdverseEventSuspectEntityInstanceChoice(string dataType, JsonValue? value) : base(dataType, value) { }

        public AdverseEventSuspectEntityInstanceChoice(JsonObject value) : base("instance", value, _supportType)
        {
        }
        public AdverseEventSuspectEntityInstanceChoice(IComplexType? value) : base("instance", value)
        {
        }
        public AdverseEventSuspectEntityInstanceChoice(IPrimitiveType? value) : base("instance", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"instance".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class AdverseEventContributingFactorItemChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(Condition|Observation|AllergyIntolerance|FamilyMemberHistory|Immunization|Procedure|Device|DeviceUsage|DocumentReference|MedicationAdministration|MedicationStatement)","CodeableConcept"
        ];
		public AdverseEventContributingFactorItemChoice(string dataType, JsonValue? value) : base(dataType, value) { }

        public AdverseEventContributingFactorItemChoice(JsonObject value) : base("item", value, _supportType)
        {
        }
        public AdverseEventContributingFactorItemChoice(IComplexType? value) : base("item", value)
        {
        }
        public AdverseEventContributingFactorItemChoice(IPrimitiveType? value) : base("item", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"item".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class AdverseEventPreventiveActionItemChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(Immunization|Procedure|DocumentReference|MedicationAdministration|MedicationRequest)","CodeableConcept"
        ];
		public AdverseEventPreventiveActionItemChoice(string dataType, JsonValue? value) : base(dataType, value) { }

        public AdverseEventPreventiveActionItemChoice(JsonObject value) : base("item", value, _supportType)
        {
        }
        public AdverseEventPreventiveActionItemChoice(IComplexType? value) : base("item", value)
        {
        }
        public AdverseEventPreventiveActionItemChoice(IPrimitiveType? value) : base("item", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"item".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class AdverseEventMitigatingActionItemChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(Procedure|DocumentReference|MedicationAdministration|MedicationRequest)","CodeableConcept"
        ];
        public AdverseEventMitigatingActionItemChoice(string dataType, JsonValue? value) : base(dataType, value) { }
        public AdverseEventMitigatingActionItemChoice(JsonObject value) : base("item", value, _supportType)
        {
        }
        public AdverseEventMitigatingActionItemChoice(IComplexType? value) : base("item", value)
        {
        }
        public AdverseEventMitigatingActionItemChoice(IPrimitiveType? value) : base("item", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"item".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class AdverseEventSupportingInfoItemChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(Condition|Observation|AllergyIntolerance|FamilyMemberHistory|Immunization|Procedure|DocumentReference|MedicationAdministration|MedicationStatement|QuestionnaireResponse)","CodeableConcept"
        ];
        public AdverseEventSupportingInfoItemChoice(string dataType, JsonValue? value) : base(dataType, value) { }
        public AdverseEventSupportingInfoItemChoice(JsonObject value) : base("item", value, _supportType)
        {
        }
        public AdverseEventSupportingInfoItemChoice(IComplexType? value) : base("item", value)
        {
        }
        public AdverseEventSupportingInfoItemChoice(IPrimitiveType? value) : base("item", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"item".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
