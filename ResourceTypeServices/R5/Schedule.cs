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
	public class Schedule : ResourceType<Schedule>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirBoolean? _active;
private List<CodeableConcept>? _serviceCategory;
private List<CodeableReference>? _serviceType;
private List<CodeableConcept>? _specialty;
private FhirString? _name;
private List<ReferenceType>? _actor;
private Period? _planningHorizon;
private FhirMarkdown? _comment;

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

public FhirBoolean? Active
{
get { return _active; }
set {
_active= value;
OnPropertyChanged("active", value);
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

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public List<ReferenceType>? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}

public Period? PlanningHorizon
{
get { return _planningHorizon; }
set {
_planningHorizon= value;
OnPropertyChanged("planningHorizon", value);
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


		#endregion
		#region Constructor
		public  Schedule() { }
		public  Schedule(string value) : base(value) { }
		public  Schedule(JsonNode? source) : base(source) { }
		#endregion
	}
	

		

}
