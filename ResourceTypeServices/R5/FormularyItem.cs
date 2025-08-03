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
	public class FormularyItem : ResourceType<FormularyItem>
	{
		#region private Property
		private List<Identifier>? _identifier;
private CodeableConcept? _code;
private FhirCode? _status;

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

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
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


		#endregion
		#region Constructor
		public  FormularyItem() { }
		public  FormularyItem(string value) : base(value) { }
		public  FormularyItem(JsonNode? source) : base(source) { }
		#endregion
	}
	

		

}
