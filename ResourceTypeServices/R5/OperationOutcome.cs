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
    public class OperationOutcome : ResourceType<OperationOutcome>
	{
		#region private Property
		private List<OperationOutcomeIssue>? _issue;

		#endregion
		#region Public Method
		public List<OperationOutcomeIssue>? Issue
{
get { return _issue; }
set {
_issue= value;
OnPropertyChanged("issue", value);
}
}


		#endregion
		#region Constructor
		public  OperationOutcome() { }
		public  OperationOutcome(string value) : base(value) { }
		public  OperationOutcome(JsonNode? source) : base(source) { }
		#endregion
	}
		public class OperationOutcomeIssue : BackboneElementType<OperationOutcomeIssue>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _severity;
private FhirCode? _code;
private CodeableConcept? _details;
private FhirString? _diagnostics;
private List<FhirString>? _location;
private List<FhirString>? _expression;

		#endregion
		#region public Method
		public FhirCode? Severity
{
get { return _severity; }
set {
_severity= value;
OnPropertyChanged("severity", value);
}
}

public FhirCode? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public CodeableConcept? Details
{
get { return _details; }
set {
_details= value;
OnPropertyChanged("details", value);
}
}

public FhirString? Diagnostics
{
get { return _diagnostics; }
set {
_diagnostics= value;
OnPropertyChanged("diagnostics", value);
}
}

public List<FhirString>? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public List<FhirString>? Expression
{
get { return _expression; }
set {
_expression= value;
OnPropertyChanged("expression", value);
}
}


		#endregion
		#region Constructor
		public  OperationOutcomeIssue() { }
		public  OperationOutcomeIssue(string value) : base(value) { }
		public  OperationOutcomeIssue(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
