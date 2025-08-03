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
    public class FamilyMemberHistory : ResourceType<FamilyMemberHistory>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<FhirCanonical>? _instantiatesCanonical;
private List<FhirUri>? _instantiatesUri;
private FhirCode? _status;
private CodeableConcept? _dataAbsentReason;
private ReferenceType? _patient;
private FhirDateTime? _date;
private List<FamilyMemberHistoryParticipant>? _participant;
private FhirString? _name;
private CodeableConcept? _relationship;
private CodeableConcept? _sex;
private FamilyMemberHistoryBornChoice? _born;
private FamilyMemberHistoryAgeChoice? _age;
private FhirBoolean? _estimatedAge;
private FamilyMemberHistoryDeceasedChoice? _deceased;
private List<CodeableReference>? _reason;
private List<Annotation>? _note;
private List<FamilyMemberHistoryCondition>? _condition;
private List<FamilyMemberHistoryProcedure>? _procedure;

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

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
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

public ReferenceType? Patient
{
get { return _patient; }
set {
_patient= value;
OnPropertyChanged("patient", value);
}
}

public FhirDateTime? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
}
}

public List<FamilyMemberHistoryParticipant>? Participant
{
get { return _participant; }
set {
_participant= value;
OnPropertyChanged("participant", value);
}
}

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public CodeableConcept? Relationship
{
get { return _relationship; }
set {
_relationship= value;
OnPropertyChanged("relationship", value);
}
}

public CodeableConcept? Sex
{
get { return _sex; }
set {
_sex= value;
OnPropertyChanged("sex", value);
}
}

public FamilyMemberHistoryBornChoice? Born
{
get { return _born; }
set {
_born= value;
OnPropertyChanged("born", value);
}
}

public FamilyMemberHistoryAgeChoice? Age
{
get { return _age; }
set {
_age= value;
OnPropertyChanged("age", value);
}
}

public FhirBoolean? EstimatedAge
{
get { return _estimatedAge; }
set {
_estimatedAge= value;
OnPropertyChanged("estimatedAge", value);
}
}

public FamilyMemberHistoryDeceasedChoice? Deceased
{
get { return _deceased; }
set {
_deceased= value;
OnPropertyChanged("deceased", value);
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

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
}
}

public List<FamilyMemberHistoryCondition>? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
}
}

public List<FamilyMemberHistoryProcedure>? Procedure
{
get { return _procedure; }
set {
_procedure= value;
OnPropertyChanged("procedure", value);
}
}


		#endregion
		#region Constructor
		public  FamilyMemberHistory() { }
		public  FamilyMemberHistory(string value) : base(value) { }
		public  FamilyMemberHistory(JsonNode? source) : base(source) { }
		#endregion
	}
		public class FamilyMemberHistoryParticipant : BackboneElementType<FamilyMemberHistoryParticipant>, IBackboneElementType
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
		public  FamilyMemberHistoryParticipant() { }
		public  FamilyMemberHistoryParticipant(string value) : base(value) { }
		public  FamilyMemberHistoryParticipant(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class FamilyMemberHistoryCondition : BackboneElementType<FamilyMemberHistoryCondition>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private CodeableConcept? _outcome;
private FhirBoolean? _contributedToDeath;
private FamilyMemberHistoryConditionOnsetChoice? _onset;
private List<Annotation>? _note;

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

public CodeableConcept? Outcome
{
get { return _outcome; }
set {
_outcome= value;
OnPropertyChanged("outcome", value);
}
}

public FhirBoolean? ContributedToDeath
{
get { return _contributedToDeath; }
set {
_contributedToDeath= value;
OnPropertyChanged("contributedToDeath", value);
}
}

public FamilyMemberHistoryConditionOnsetChoice? Onset
{
get { return _onset; }
set {
_onset= value;
OnPropertyChanged("onset", value);
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
		public  FamilyMemberHistoryCondition() { }
		public  FamilyMemberHistoryCondition(string value) : base(value) { }
		public  FamilyMemberHistoryCondition(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class FamilyMemberHistoryProcedure : BackboneElementType<FamilyMemberHistoryProcedure>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private CodeableConcept? _outcome;
private FhirBoolean? _contributedToDeath;
private FamilyMemberHistoryProcedurePerformedChoice? _performed;
private List<Annotation>? _note;

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

public CodeableConcept? Outcome
{
get { return _outcome; }
set {
_outcome= value;
OnPropertyChanged("outcome", value);
}
}

public FhirBoolean? ContributedToDeath
{
get { return _contributedToDeath; }
set {
_contributedToDeath= value;
OnPropertyChanged("contributedToDeath", value);
}
}

public FamilyMemberHistoryProcedurePerformedChoice? Performed
{
get { return _performed; }
set {
_performed= value;
OnPropertyChanged("performed", value);
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
		public  FamilyMemberHistoryProcedure() { }
		public  FamilyMemberHistoryProcedure(string value) : base(value) { }
		public  FamilyMemberHistoryProcedure(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class FamilyMemberHistoryBornChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Period","datestring"
        ];

        public FamilyMemberHistoryBornChoice(JsonObject value) : base("born", value, _supportType)
        {
        }
        public FamilyMemberHistoryBornChoice(IComplexType? value) : base("born", value)
        {
        }
        public FamilyMemberHistoryBornChoice(IPrimitiveType? value) : base("born", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"born".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class FamilyMemberHistoryAgeChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Age","Rangestring"
        ];

        public FamilyMemberHistoryAgeChoice(JsonObject value) : base("age", value, _supportType)
        {
        }
        public FamilyMemberHistoryAgeChoice(IComplexType? value) : base("age", value)
        {
        }
        public FamilyMemberHistoryAgeChoice(IPrimitiveType? value) : base("age", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"age".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class FamilyMemberHistoryDeceasedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","AgeRangedatestring"
        ];

        public FamilyMemberHistoryDeceasedChoice(JsonObject value) : base("deceased", value, _supportType)
        {
        }
        public FamilyMemberHistoryDeceasedChoice(IComplexType? value) : base("deceased", value)
        {
        }
        public FamilyMemberHistoryDeceasedChoice(IPrimitiveType? value) : base("deceased", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"deceased".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class FamilyMemberHistoryConditionOnsetChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Age","RangePeriodstring"
        ];

        public FamilyMemberHistoryConditionOnsetChoice(JsonObject value) : base("onset", value, _supportType)
        {
        }
        public FamilyMemberHistoryConditionOnsetChoice(IComplexType? value) : base("onset", value)
        {
        }
        public FamilyMemberHistoryConditionOnsetChoice(IPrimitiveType? value) : base("onset", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"onset".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class FamilyMemberHistoryProcedurePerformedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Age","RangePeriodstringdateTime"
        ];

        public FamilyMemberHistoryProcedurePerformedChoice(JsonObject value) : base("performed", value, _supportType)
        {
        }
        public FamilyMemberHistoryProcedurePerformedChoice(IComplexType? value) : base("performed", value)
        {
        }
        public FamilyMemberHistoryProcedurePerformedChoice(IPrimitiveType? value) : base("performed", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"performed".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
