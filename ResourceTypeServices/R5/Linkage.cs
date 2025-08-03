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
    public class Linkage : ResourceType<Linkage>
	{
		#region private Property
		private FhirBoolean? _active;
private ReferenceType? _author;
private List<LinkageItem>? _item;

		#endregion
		#region Public Method
		public FhirBoolean? Active
{
get { return _active; }
set {
_active= value;
OnPropertyChanged("active", value);
}
}

public ReferenceType? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}

public List<LinkageItem>? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}


		#endregion
		#region Constructor
		public  Linkage() { }
		public  Linkage(string value) : base(value) { }
		public  Linkage(JsonNode? source) : base(source) { }
		#endregion
	}
		public class LinkageItem : BackboneElementType<LinkageItem>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _type;
private ReferenceType? _resource;

		#endregion
		#region public Method
		public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public ReferenceType? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
}
}


		#endregion
		#region Constructor
		public  LinkageItem() { }
		public  LinkageItem(string value) : base(value) { }
		public  LinkageItem(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
