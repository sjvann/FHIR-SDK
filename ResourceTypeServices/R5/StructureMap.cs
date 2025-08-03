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
    public class StructureMap : ResourceType<StructureMap>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private StructureMapVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private FhirCode? _status;
private FhirBoolean? _experimental;
private FhirDateTime? _date;
private FhirString? _publisher;
private List<ContactDetail>? _contact;
private FhirMarkdown? _description;
private List<UsageContext>? _useContext;
private List<CodeableConcept>? _jurisdiction;
private FhirMarkdown? _purpose;
private FhirMarkdown? _copyright;
private FhirString? _copyrightLabel;
private List<StructureMapStructure>? _structure;
private List<FhirCanonical>? _import;
private List<StructureMapConst>? _const;
private List<StructureMapGroup>? _group;

		#endregion
		#region Public Method
		public FhirUri? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
}
}

public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirString? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}

public StructureMapVersionAlgorithmChoice? VersionAlgorithm
{
get { return _versionAlgorithm; }
set {
_versionAlgorithm= value;
OnPropertyChanged("versionAlgorithm", value);
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

public FhirString? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
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

public FhirBoolean? Experimental
{
get { return _experimental; }
set {
_experimental= value;
OnPropertyChanged("experimental", value);
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

public FhirString? Publisher
{
get { return _publisher; }
set {
_publisher= value;
OnPropertyChanged("publisher", value);
}
}

public List<ContactDetail>? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
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

public List<UsageContext>? UseContext
{
get { return _useContext; }
set {
_useContext= value;
OnPropertyChanged("useContext", value);
}
}

public List<CodeableConcept>? Jurisdiction
{
get { return _jurisdiction; }
set {
_jurisdiction= value;
OnPropertyChanged("jurisdiction", value);
}
}

public FhirMarkdown? Purpose
{
get { return _purpose; }
set {
_purpose= value;
OnPropertyChanged("purpose", value);
}
}

public FhirMarkdown? Copyright
{
get { return _copyright; }
set {
_copyright= value;
OnPropertyChanged("copyright", value);
}
}

public FhirString? CopyrightLabel
{
get { return _copyrightLabel; }
set {
_copyrightLabel= value;
OnPropertyChanged("copyrightLabel", value);
}
}

public List<StructureMapStructure>? Structure
{
get { return _structure; }
set {
_structure= value;
OnPropertyChanged("structure", value);
}
}

public List<FhirCanonical>? Import
{
get { return _import; }
set {
_import= value;
OnPropertyChanged("import", value);
}
}

public List<StructureMapConst>? Const
{
get { return _const; }
set {
_const= value;
OnPropertyChanged("const", value);
}
}

public List<StructureMapGroup>? Group
{
get { return _group; }
set {
_group= value;
OnPropertyChanged("group", value);
}
}


		#endregion
		#region Constructor
		public  StructureMap() { }
		public  StructureMap(string value) : base(value) { }
		public  StructureMap(JsonNode? source) : base(source) { }
		#endregion
	}
		public class StructureMapStructure : BackboneElementType<StructureMapStructure>, IBackboneElementType
	{

		#region Private Method
		private FhirCanonical? _url;
private FhirCode? _mode;
private FhirString? _alias;
private FhirString? _documentation;

		#endregion
		#region public Method
		public FhirCanonical? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
}
}

public FhirCode? Mode
{
get { return _mode; }
set {
_mode= value;
OnPropertyChanged("mode", value);
}
}

public FhirString? Alias
{
get { return _alias; }
set {
_alias= value;
OnPropertyChanged("alias", value);
}
}

public FhirString? Documentation
{
get { return _documentation; }
set {
_documentation= value;
OnPropertyChanged("documentation", value);
}
}


		#endregion
		#region Constructor
		public  StructureMapStructure() { }
		public  StructureMapStructure(string value) : base(value) { }
		public  StructureMapStructure(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class StructureMapConst : BackboneElementType<StructureMapConst>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _name;
private FhirString? _value;

		#endregion
		#region public Method
		public FhirId? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public FhirString? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  StructureMapConst() { }
		public  StructureMapConst(string value) : base(value) { }
		public  StructureMapConst(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class StructureMapGroupInput : BackboneElementType<StructureMapGroupInput>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _name;
private FhirString? _type;
private FhirCode? _mode;
private FhirString? _documentation;

		#endregion
		#region public Method
		public FhirId? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public FhirString? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirCode? Mode
{
get { return _mode; }
set {
_mode= value;
OnPropertyChanged("mode", value);
}
}

public FhirString? Documentation
{
get { return _documentation; }
set {
_documentation= value;
OnPropertyChanged("documentation", value);
}
}


		#endregion
		#region Constructor
		public  StructureMapGroupInput() { }
		public  StructureMapGroupInput(string value) : base(value) { }
		public  StructureMapGroupInput(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class StructureMapGroupRuleSource : BackboneElementType<StructureMapGroupRuleSource>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _context;
private FhirInteger? _min;
private FhirString? _max;
private FhirString? _type;
private FhirString? _defaultValue;
private FhirString? _element;
private FhirCode? _listMode;
private FhirId? _variable;
private FhirString? _condition;
private FhirString? _check;
private FhirString? _logMessage;

		#endregion
		#region public Method
		public FhirId? Context
{
get { return _context; }
set {
_context= value;
OnPropertyChanged("context", value);
}
}

public FhirInteger? Min
{
get { return _min; }
set {
_min= value;
OnPropertyChanged("min", value);
}
}

public FhirString? Max
{
get { return _max; }
set {
_max= value;
OnPropertyChanged("max", value);
}
}

public FhirString? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirString? DefaultValue
{
get { return _defaultValue; }
set {
_defaultValue= value;
OnPropertyChanged("defaultValue", value);
}
}

public FhirString? Element
{
get { return _element; }
set {
_element= value;
OnPropertyChanged("element", value);
}
}

public FhirCode? ListMode
{
get { return _listMode; }
set {
_listMode= value;
OnPropertyChanged("listMode", value);
}
}

public FhirId? Variable
{
get { return _variable; }
set {
_variable= value;
OnPropertyChanged("variable", value);
}
}

public FhirString? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
}
}

public FhirString? Check
{
get { return _check; }
set {
_check= value;
OnPropertyChanged("check", value);
}
}

public FhirString? LogMessage
{
get { return _logMessage; }
set {
_logMessage= value;
OnPropertyChanged("logMessage", value);
}
}


		#endregion
		#region Constructor
		public  StructureMapGroupRuleSource() { }
		public  StructureMapGroupRuleSource(string value) : base(value) { }
		public  StructureMapGroupRuleSource(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class StructureMapGroupRuleTargetParameter : BackboneElementType<StructureMapGroupRuleTargetParameter>, IBackboneElementType
	{

		#region Private Method
		private StructureMapGroupRuleTargetParameterValueChoice? _value;

		#endregion
		#region public Method
		public StructureMapGroupRuleTargetParameterValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  StructureMapGroupRuleTargetParameter() { }
		public  StructureMapGroupRuleTargetParameter(string value) : base(value) { }
		public  StructureMapGroupRuleTargetParameter(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class StructureMapGroupRuleTarget : BackboneElementType<StructureMapGroupRuleTarget>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _context;
private FhirString? _element;
private FhirId? _variable;
private List<FhirCode>? _listMode;
private FhirId? _listRuleId;
private FhirCode? _transform;
private List<StructureMapGroupRuleTargetParameter>? _parameter;

		#endregion
		#region public Method
		public FhirString? Context
{
get { return _context; }
set {
_context= value;
OnPropertyChanged("context", value);
}
}

public FhirString? Element
{
get { return _element; }
set {
_element= value;
OnPropertyChanged("element", value);
}
}

public FhirId? Variable
{
get { return _variable; }
set {
_variable= value;
OnPropertyChanged("variable", value);
}
}

public List<FhirCode>? ListMode
{
get { return _listMode; }
set {
_listMode= value;
OnPropertyChanged("listMode", value);
}
}

public FhirId? ListRuleId
{
get { return _listRuleId; }
set {
_listRuleId= value;
OnPropertyChanged("listRuleId", value);
}
}

public FhirCode? Transform
{
get { return _transform; }
set {
_transform= value;
OnPropertyChanged("transform", value);
}
}

public List<StructureMapGroupRuleTargetParameter>? Parameter
{
get { return _parameter; }
set {
_parameter= value;
OnPropertyChanged("parameter", value);
}
}


		#endregion
		#region Constructor
		public  StructureMapGroupRuleTarget() { }
		public  StructureMapGroupRuleTarget(string value) : base(value) { }
		public  StructureMapGroupRuleTarget(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class StructureMapGroupRuleDependent : BackboneElementType<StructureMapGroupRuleDependent>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _name;

		#endregion
		#region public Method
		public FhirId? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}


		#endregion
		#region Constructor
		public  StructureMapGroupRuleDependent() { }
		public  StructureMapGroupRuleDependent(string value) : base(value) { }
		public  StructureMapGroupRuleDependent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class StructureMapGroupRule : BackboneElementType<StructureMapGroupRule>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _name;
private List<StructureMapGroupRuleSource>? _source;
private List<StructureMapGroupRuleTarget>? _target;
private List<StructureMapGroupRuleDependent>? _dependent;
private FhirString? _documentation;

		#endregion
		#region public Method
		public FhirId? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public List<StructureMapGroupRuleSource>? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}

public List<StructureMapGroupRuleTarget>? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
}
}

public List<StructureMapGroupRuleDependent>? Dependent
{
get { return _dependent; }
set {
_dependent= value;
OnPropertyChanged("dependent", value);
}
}

public FhirString? Documentation
{
get { return _documentation; }
set {
_documentation= value;
OnPropertyChanged("documentation", value);
}
}


		#endregion
		#region Constructor
		public  StructureMapGroupRule() { }
		public  StructureMapGroupRule(string value) : base(value) { }
		public  StructureMapGroupRule(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class StructureMapGroup : BackboneElementType<StructureMapGroup>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _name;
private FhirId? _extends;
private FhirCode? _typeMode;
private FhirString? _documentation;
private List<StructureMapGroupInput>? _input;
private List<StructureMapGroupRule>? _rule;

		#endregion
		#region public Method
		public FhirId? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public FhirId? Extends
{
get { return _extends; }
set {
_extends= value;
OnPropertyChanged("extends", value);
}
}

public FhirCode? TypeMode
{
get { return _typeMode; }
set {
_typeMode= value;
OnPropertyChanged("typeMode", value);
}
}

public FhirString? Documentation
{
get { return _documentation; }
set {
_documentation= value;
OnPropertyChanged("documentation", value);
}
}

public List<StructureMapGroupInput>? Input
{
get { return _input; }
set {
_input= value;
OnPropertyChanged("input", value);
}
}

public List<StructureMapGroupRule>? Rule
{
get { return _rule; }
set {
_rule= value;
OnPropertyChanged("rule", value);
}
}


		#endregion
		#region Constructor
		public  StructureMapGroup() { }
		public  StructureMapGroup(string value) : base(value) { }
		public  StructureMapGroup(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class StructureMapVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public StructureMapVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public StructureMapVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public StructureMapVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class StructureMapGroupRuleTargetParameterValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "id","stringbooleanintegerdecimaldatetimedateTime"
        ];

        public StructureMapGroupRuleTargetParameterValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public StructureMapGroupRuleTargetParameterValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public StructureMapGroupRuleTargetParameterValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
