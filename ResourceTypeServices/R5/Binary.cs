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
	public class Binary : ResourceType<Binary>
	{
		#region private Property
		private FhirCode? _contentType;
private ReferenceType? _securityContext;
private FhirBase64Binary? _data;

		#endregion
		#region Public Method
		public FhirCode? ContentType
{
get { return _contentType; }
set {
_contentType= value;
OnPropertyChanged("contentType", value);
}
}

public ReferenceType? SecurityContext
{
get { return _securityContext; }
set {
_securityContext= value;
OnPropertyChanged("securityContext", value);
}
}

public FhirBase64Binary? Data
{
get { return _data; }
set {
_data= value;
OnPropertyChanged("data", value);
}
}


		#endregion
		#region Constructor
		public  Binary() { }
		public  Binary(string value) : base(value) { }
		public  Binary(JsonNode? source) : base(source) { }
		#endregion
	}
	

		

}
