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
	public class EnrollmentRequest : ResourceType<EnrollmentRequest>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private FhirDateTime? _created;
private ReferenceType? _insurer;
private ReferenceType? _provider;
private ReferenceType? _candidate;
private ReferenceType? _coverage;

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

public FhirDateTime? Created
{
get { return _created; }
set {
_created= value;
OnPropertyChanged("created", value);
}
}

public ReferenceType? Insurer
{
get { return _insurer; }
set {
_insurer= value;
OnPropertyChanged("insurer", value);
}
}

public ReferenceType? Provider
{
get { return _provider; }
set {
_provider= value;
OnPropertyChanged("provider", value);
}
}

public ReferenceType? Candidate
{
get { return _candidate; }
set {
_candidate= value;
OnPropertyChanged("candidate", value);
}
}

public ReferenceType? Coverage
{
get { return _coverage; }
set {
_coverage= value;
OnPropertyChanged("coverage", value);
}
}


		#endregion
		#region Constructor
		public  EnrollmentRequest() { }
		public  EnrollmentRequest(string value) : base(value) { }
		public  EnrollmentRequest(JsonNode? source) : base(source) { }
		#endregion
	}
	

		

}
