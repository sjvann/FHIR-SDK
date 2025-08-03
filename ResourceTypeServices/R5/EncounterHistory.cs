using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;

namespace ResourceTypeServices.R5
{
    public class EncounterHistory : ResourceType<EncounterHistory>
	{
		#region private Property
		private ReferenceType? _encounter;
private List<Identifier>? _identifier;
private FhirCode? _status;
private CodeableConcept? _class;
private List<CodeableConcept>? _type;
private List<CodeableReference>? _serviceType;
private ReferenceType? _subject;
private CodeableConcept? _subjectStatus;
private Period? _actualPeriod;
private FhirDateTime? _plannedStartDate;
private FhirDateTime? _plannedEndDate;
private Duration? _length;
private List<EncounterHistoryLocation>? _location;

		#endregion
		#region Public Method
		public ReferenceType? Encounter
{
get { return _encounter; }
set {
_encounter= value;
OnPropertyChanged("encounter", value);
}
}

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

public CodeableConcept? Class
{
get { return _class; }
set {
_class= value;
OnPropertyChanged("class", value);
}
}

public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public List<CodeableReference>? ServiceType
{
get { return _serviceType; }
set {
_serviceType= value;
OnPropertyChanged("serviceType", value);
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

public CodeableConcept? SubjectStatus
{
get { return _subjectStatus; }
set {
_subjectStatus= value;
OnPropertyChanged("subjectStatus", value);
}
}

public Period? ActualPeriod
{
get { return _actualPeriod; }
set {
_actualPeriod= value;
OnPropertyChanged("actualPeriod", value);
}
}

public FhirDateTime? PlannedStartDate
{
get { return _plannedStartDate; }
set {
_plannedStartDate= value;
OnPropertyChanged("plannedStartDate", value);
}
}

public FhirDateTime? PlannedEndDate
{
get { return _plannedEndDate; }
set {
_plannedEndDate= value;
OnPropertyChanged("plannedEndDate", value);
}
}

public Duration? Length
{
get { return _length; }
set {
_length= value;
OnPropertyChanged("length", value);
}
}

public List<EncounterHistoryLocation>? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}


		#endregion
		#region Constructor
		public  EncounterHistory() { }
		public  EncounterHistory(string value) : base(value) { }
		public  EncounterHistory(JsonNode? source) : base(source) { }
		#endregion
	}
		public class EncounterHistoryLocation : BackboneElementType<EncounterHistoryLocation>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _location;
private CodeableConcept? _form;

		#endregion
		#region public Method
		public ReferenceType? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public CodeableConcept? Form
{
get { return _form; }
set {
_form= value;
OnPropertyChanged("form", value);
}
}


		#endregion
		#region Constructor
		public  EncounterHistoryLocation() { }
		public  EncounterHistoryLocation(string value) : base(value) { }
		public  EncounterHistoryLocation(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
