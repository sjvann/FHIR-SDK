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
    public class CareTeam : ResourceType<CareTeam>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<CodeableConcept>? _category;
private FhirString? _name;
private ReferenceType? _subject;
private Period? _period;
private List<CareTeamParticipant>? _participant;
private List<CodeableReference>? _reason;
private List<ReferenceType>? _managingOrganization;
private List<ContactPoint>? _telecom;
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

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public List<CareTeamParticipant>? Participant
{
get { return _participant; }
set {
_participant= value;
OnPropertyChanged("participant", value);
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

public List<ReferenceType>? ManagingOrganization
{
get { return _managingOrganization; }
set {
_managingOrganization= value;
OnPropertyChanged("managingOrganization", value);
}
}

public List<ContactPoint>? Telecom
{
get { return _telecom; }
set {
_telecom= value;
OnPropertyChanged("telecom", value);
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
		public  CareTeam() { }
		public  CareTeam(string value) : base(value) { }
		public  CareTeam(JsonNode? source) : base(source) { }
		#endregion
	}
		public class CareTeamParticipant : BackboneElementType<CareTeamParticipant>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _role;
private ReferenceType? _member;
private ReferenceType? _onBehalfOf;
private CareTeamParticipantCoverageChoice? _coverage;

		#endregion
		#region public Method
		public CodeableConcept? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}

public ReferenceType? Member
{
get { return _member; }
set {
_member= value;
OnPropertyChanged("member", value);
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

public CareTeamParticipantCoverageChoice? Coverage
{
get { return _coverage; }
set {
_coverage= value;
OnPropertyChanged("coverage", value);
}
}


		#endregion
		#region Constructor
		public  CareTeamParticipant() { }
		public  CareTeamParticipant(string value) : base(value) { }
		public  CareTeamParticipant(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class CareTeamParticipantCoverageChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Period","Timing"
        ];

        public CareTeamParticipantCoverageChoice(JsonObject value) : base("coverage", value, _supportType)
        {
        }
        public CareTeamParticipantCoverageChoice(IComplexType? value) : base("coverage", value)
        {
        }
        public CareTeamParticipantCoverageChoice(IPrimitiveType? value) : base("coverage", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"coverage".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
