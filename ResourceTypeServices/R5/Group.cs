using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;

namespace ResourceTypeServices.R5
{
    public class Group : ResourceType<Group>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirBoolean? _active;
private FhirCode? _type;
private FhirCode? _membership;
private CodeableConcept? _code;
private FhirString? _name;
private FhirMarkdown? _description;
private FhirUnsignedInt? _quantity;
private ReferenceType? _managingEntity;
private List<GroupCharacteristic>? _characteristic;
private List<GroupMember>? _member;

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

public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirCode? Membership
{
get { return _membership; }
set {
_membership= value;
OnPropertyChanged("membership", value);
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

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
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

public FhirUnsignedInt? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}

public ReferenceType? ManagingEntity
{
get { return _managingEntity; }
set {
_managingEntity= value;
OnPropertyChanged("managingEntity", value);
}
}

public List<GroupCharacteristic>? Characteristic
{
get { return _characteristic; }
set {
_characteristic= value;
OnPropertyChanged("characteristic", value);
}
}

public List<GroupMember>? Member
{
get { return _member; }
set {
_member= value;
OnPropertyChanged("member", value);
}
}


		#endregion
		#region Constructor
		public  Group() { }
		public  Group(string value) : base(value) { }
		public  Group(JsonNode? source) : base(source) { }
		#endregion
	}
		public class GroupCharacteristic : BackboneElementType<GroupCharacteristic>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private GroupCharacteristicValueChoice? _value;
private FhirBoolean? _exclude;
private Period? _period;

		#endregion
		#region public Method
		public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public GroupCharacteristicValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public FhirBoolean? Exclude
{
get { return _exclude; }
set {
_exclude= value;
OnPropertyChanged("exclude", value);
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
		public  GroupCharacteristic() { }
		public  GroupCharacteristic(string value) : base(value) { }
		public  GroupCharacteristic(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class GroupMember : BackboneElementType<GroupMember>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _entity;
private Period? _period;
private FhirBoolean? _inactive;

		#endregion
		#region public Method
		public ReferenceType? Entity
{
get { return _entity; }
set {
_entity= value;
OnPropertyChanged("entity", value);
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

public FhirBoolean? Inactive
{
get { return _inactive; }
set {
_inactive= value;
OnPropertyChanged("inactive", value);
}
}


		#endregion
		#region Constructor
		public  GroupMember() { }
		public  GroupMember(string value) : base(value) { }
		public  GroupMember(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class GroupCharacteristicValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","booleanQuantityRangeReference"
        ];

        public GroupCharacteristicValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public GroupCharacteristicValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public GroupCharacteristicValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
