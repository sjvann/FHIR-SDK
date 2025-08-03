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
	public class Slot : ResourceType<Slot>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<CodeableConcept>? _serviceCategory;
private List<CodeableReference>? _serviceType;
private List<CodeableConcept>? _specialty;
private List<CodeableConcept>? _appointmentType;
private ReferenceType? _schedule;
private FhirCode? _status;
private FhirInstant? _start;
private FhirInstant? _end;
private FhirBoolean? _overbooked;
private FhirString? _comment;

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

public List<CodeableConcept>? ServiceCategory
{
get { return _serviceCategory; }
set {
_serviceCategory= value;
OnPropertyChanged("serviceCategory", value);
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

public List<CodeableConcept>? Specialty
{
get { return _specialty; }
set {
_specialty= value;
OnPropertyChanged("specialty", value);
}
}

public List<CodeableConcept>? AppointmentType
{
get { return _appointmentType; }
set {
_appointmentType= value;
OnPropertyChanged("appointmentType", value);
}
}

public ReferenceType? Schedule
{
get { return _schedule; }
set {
_schedule= value;
OnPropertyChanged("schedule", value);
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

public FhirBoolean? Overbooked
{
get { return _overbooked; }
set {
_overbooked= value;
OnPropertyChanged("overbooked", value);
}
}

public FhirString? Comment
{
get { return _comment; }
set {
_comment= value;
OnPropertyChanged("comment", value);
}
}


		#endregion
		#region Constructor
		public  Slot() { }
		public  Slot(string value) : base(value) { }
		public  Slot(JsonNode? source) : base(source) { }
		#endregion
	}
	

		

}
