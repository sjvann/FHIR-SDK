

using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;	

namespace ResourceTypeServices.R5
{
	public class AppointmentResponse : ResourceType<AppointmentResponse>
	{
		#region private Property
		private List<Identifier>? _identifier;
private ReferenceType? _appointment;
private FhirBoolean? _proposedNewTime;
private FhirInstant? _start;
private FhirInstant? _end;
private List<CodeableConcept>? _participantType;
private ReferenceType? _actor;
private FhirCode? _participantStatus;
private FhirMarkdown? _comment;
private FhirBoolean? _recurring;
private FhirDate? _occurrenceDate;
private FhirPositiveInt? _recurrenceId;

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

public ReferenceType? Appointment
{
get { return _appointment; }
set {
_appointment= value;
OnPropertyChanged("appointment", value);
}
}

public FhirBoolean? ProposedNewTime
{
get { return _proposedNewTime; }
set {
_proposedNewTime= value;
OnPropertyChanged("proposedNewTime", value);
}
}

public FhirInstant? Start
{
get { return _start; }
set {
_start= value;
OnPropertyChanged("start", value);
}
}

public FhirInstant? End
{
get { return _end; }
set {
_end= value;
OnPropertyChanged("end", value);
}
}

public List<CodeableConcept>? ParticipantType
{
get { return _participantType; }
set {
_participantType= value;
OnPropertyChanged("participantType", value);
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

public FhirCode? ParticipantStatus
{
get { return _participantStatus; }
set {
_participantStatus= value;
OnPropertyChanged("participantStatus", value);
}
}

public FhirMarkdown? Comment
{
get { return _comment; }
set {
_comment= value;
OnPropertyChanged("comment", value);
}
}

public FhirBoolean? Recurring
{
get { return _recurring; }
set {
_recurring= value;
OnPropertyChanged("recurring", value);
}
}

public FhirDate? OccurrenceDate
{
get { return _occurrenceDate; }
set {
_occurrenceDate= value;
OnPropertyChanged("occurrenceDate", value);
}
}

public FhirPositiveInt? RecurrenceId
{
get { return _recurrenceId; }
set {
_recurrenceId= value;
OnPropertyChanged("recurrenceId", value);
}
}


		#endregion
		#region Constructor
		public  AppointmentResponse() { }
		public  AppointmentResponse(string value) : base(value) { }
		public  AppointmentResponse(JsonNode? source) : base(source) { }
		#endregion
	}
	

		

}
