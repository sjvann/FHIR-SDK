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
    public class Goal : ResourceType<Goal>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _lifecycleStatus;
private CodeableConcept? _achievementStatus;
private List<CodeableConcept>? _category;
private FhirBoolean? _continuous;
private CodeableConcept? _priority;
private CodeableConcept? _description;
private ReferenceType? _subject;
private GoalStartChoice? _start;
private List<GoalTarget>? _target;
private FhirDate? _statusDate;
private FhirString? _statusReason;
private ReferenceType? _source;
private List<ReferenceType>? _addresses;
private List<Annotation>? _note;
private List<CodeableReference>? _outcome;

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

public FhirCode? LifecycleStatus
{
get { return _lifecycleStatus; }
set {
_lifecycleStatus= value;
OnPropertyChanged("lifecycleStatus", value);
}
}

public CodeableConcept? AchievementStatus
{
get { return _achievementStatus; }
set {
_achievementStatus= value;
OnPropertyChanged("achievementStatus", value);
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

public FhirBoolean? Continuous
{
get { return _continuous; }
set {
_continuous= value;
OnPropertyChanged("continuous", value);
}
}

public CodeableConcept? Priority
{
get { return _priority; }
set {
_priority= value;
OnPropertyChanged("priority", value);
}
}

public CodeableConcept? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
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

public GoalStartChoice? Start
{
get { return _start; }
set {
_start= value;
OnPropertyChanged("start", value);
}
}

public List<GoalTarget>? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
}
}

public FhirDate? StatusDate
{
get { return _statusDate; }
set {
_statusDate= value;
OnPropertyChanged("statusDate", value);
}
}

public FhirString? StatusReason
{
get { return _statusReason; }
set {
_statusReason= value;
OnPropertyChanged("statusReason", value);
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

public List<ReferenceType>? Addresses
{
get { return _addresses; }
set {
_addresses= value;
OnPropertyChanged("addresses", value);
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

public List<CodeableReference>? Outcome
{
get { return _outcome; }
set {
_outcome= value;
OnPropertyChanged("outcome", value);
}
}


		#endregion
		#region Constructor
		public  Goal() { }
		public  Goal(string value) : base(value) { }
		public  Goal(JsonNode? source) : base(source) { }
		#endregion
	}
		public class GoalTarget : BackboneElementType<GoalTarget>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _measure;
private GoalTargetDetailChoice? _detail;
private GoalTargetDueChoice? _due;

		#endregion
		#region public Method
		public CodeableConcept? Measure
{
get { return _measure; }
set {
_measure= value;
OnPropertyChanged("measure", value);
}
}

public GoalTargetDetailChoice? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}

public GoalTargetDueChoice? Due
{
get { return _due; }
set {
_due= value;
OnPropertyChanged("due", value);
}
}


		#endregion
		#region Constructor
		public  GoalTarget() { }
		public  GoalTarget(string value) : base(value) { }
		public  GoalTarget(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class GoalStartChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "date","CodeableConcept"
        ];

        public GoalStartChoice(JsonObject value) : base("start", value, _supportType)
        {
        }
        public GoalStartChoice(IComplexType? value) : base("start", value)
        {
        }
        public GoalStartChoice(IPrimitiveType? value) : base("start", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"start".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class GoalTargetDetailChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","RangeCodeableConceptstringbooleanintegerRatio"
        ];

        public GoalTargetDetailChoice(JsonObject value) : base("detail", value, _supportType)
        {
        }
        public GoalTargetDetailChoice(IComplexType? value) : base("detail", value)
        {
        }
        public GoalTargetDetailChoice(IPrimitiveType? value) : base("detail", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"detail".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class GoalTargetDueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "date","Duration"
        ];

        public GoalTargetDueChoice(JsonObject value) : base("due", value, _supportType)
        {
        }
        public GoalTargetDueChoice(IComplexType? value) : base("due", value)
        {
        }
        public GoalTargetDueChoice(IPrimitiveType? value) : base("due", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"due".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
