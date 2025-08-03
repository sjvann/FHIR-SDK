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
	public class ImmunizationEvaluation : ResourceType<ImmunizationEvaluation>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private ReferenceType? _patient;
private FhirDateTime? _date;
private ReferenceType? _authority;
private CodeableConcept? _targetDisease;
private ReferenceType? _immunizationEvent;
private CodeableConcept? _doseStatus;
private List<CodeableConcept>? _doseStatusReason;
private FhirMarkdown? _description;
private FhirString? _series;
private FhirString? _doseNumber;
private FhirString? _seriesDoses;

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

public ReferenceType? Authority
{
get { return _authority; }
set {
_authority= value;
OnPropertyChanged("authority", value);
}
}

public CodeableConcept? TargetDisease
{
get { return _targetDisease; }
set {
_targetDisease= value;
OnPropertyChanged("targetDisease", value);
}
}

public ReferenceType? ImmunizationEvent
{
get { return _immunizationEvent; }
set {
_immunizationEvent= value;
OnPropertyChanged("immunizationEvent", value);
}
}

public CodeableConcept? DoseStatus
{
get { return _doseStatus; }
set {
_doseStatus= value;
OnPropertyChanged("doseStatus", value);
}
}

public List<CodeableConcept>? DoseStatusReason
{
get { return _doseStatusReason; }
set {
_doseStatusReason= value;
OnPropertyChanged("doseStatusReason", value);
}
}

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public FhirString? Series
{
get { return _series; }
set {
_series= value;
OnPropertyChanged("series", value);
}
}

public FhirString? DoseNumber
{
get { return _doseNumber; }
set {
_doseNumber= value;
OnPropertyChanged("doseNumber", value);
}
}

public FhirString? SeriesDoses
{
get { return _seriesDoses; }
set {
_seriesDoses= value;
OnPropertyChanged("seriesDoses", value);
}
}


		#endregion
		#region Constructor
		public  ImmunizationEvaluation() { }
		public  ImmunizationEvaluation(string value) : base(value) { }
		public  ImmunizationEvaluation(JsonNode? source) : base(source) { }
		#endregion
	}
	

		

}
