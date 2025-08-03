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
	public class EnrollmentResponse : ResourceType<EnrollmentResponse>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private ReferenceType? _request;
private FhirCode? _outcome;
private FhirString? _disposition;
private FhirDateTime? _created;
private ReferenceType? _organization;
private ReferenceType? _requestProvider;

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

public ReferenceType? Request
{
get { return _request; }
set {
_request= value;
OnPropertyChanged("request", value);
}
}

public FhirCode? Outcome
{
get { return _outcome; }
set {
_outcome= value;
OnPropertyChanged("outcome", value);
}
}

public FhirString? Disposition
{
get { return _disposition; }
set {
_disposition= value;
OnPropertyChanged("disposition", value);
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

public ReferenceType? Organization
{
get { return _organization; }
set {
_organization= value;
OnPropertyChanged("organization", value);
}
}

public ReferenceType? RequestProvider
{
get { return _requestProvider; }
set {
_requestProvider= value;
OnPropertyChanged("requestProvider", value);
}
}


		#endregion
		#region Constructor
		public  EnrollmentResponse() { }
		public  EnrollmentResponse(string value) : base(value) { }
		public  EnrollmentResponse(JsonNode? source) : base(source) { }
		#endregion
	}
	

		

}
