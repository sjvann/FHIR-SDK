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
    public class DeviceAssociation : ResourceType<DeviceAssociation>
	{
		#region private Property
		private List<Identifier>? _identifier;
private ReferenceType? _device;
private List<CodeableConcept>? _category;
private CodeableConcept? _status;
private List<CodeableConcept>? _statusReason;
private ReferenceType? _subject;
private ReferenceType? _bodyStructure;
private Period? _period;
private List<DeviceAssociationOperation>? _operation;

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

public ReferenceType? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public CodeableConcept? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public List<CodeableConcept>? StatusReason
{
get { return _statusReason; }
set {
_statusReason= value;
OnPropertyChanged("statusReason", value);
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

public ReferenceType? BodyStructure
{
get { return _bodyStructure; }
set {
_bodyStructure= value;
OnPropertyChanged("bodyStructure", value);
}
}

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public List<DeviceAssociationOperation>? Operation
{
get { return _operation; }
set {
_operation= value;
OnPropertyChanged("operation", value);
}
}


		#endregion
		#region Constructor
		public  DeviceAssociation() { }
		public  DeviceAssociation(string value) : base(value) { }
		public  DeviceAssociation(JsonNode? source) : base(source) { }
		#endregion
	}
		public class DeviceAssociationOperation : BackboneElementType<DeviceAssociationOperation>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _status;
private List<ReferenceType>? _operator;
private Period? _period;

		#endregion
		#region public Method
		public CodeableConcept? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public List<ReferenceType>? Operator
{
get { return _operator; }
set {
_operator= value;
OnPropertyChanged("operator", value);
}
}

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}


		#endregion
		#region Constructor
		public  DeviceAssociationOperation() { }
		public  DeviceAssociationOperation(string value) : base(value) { }
		public  DeviceAssociationOperation(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
