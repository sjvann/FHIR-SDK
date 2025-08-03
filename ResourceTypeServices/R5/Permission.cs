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
    public class Permission : ResourceType<Permission>
	{
		#region private Property
		private FhirCode? _status;
private ReferenceType? _asserter;
private List<FhirDateTime>? _date;
private Period? _validity;
private PermissionJustification? _justification;
private FhirCode? _combining;
private List<PermissionRule>? _rule;

		#endregion
		#region Public Method
		public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public ReferenceType? Asserter
{
get { return _asserter; }
set {
_asserter= value;
OnPropertyChanged("asserter", value);
}
}

public List<FhirDateTime>? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
}
}

public Period? Validity
{
get { return _validity; }
set {
_validity= value;
OnPropertyChanged("validity", value);
}
}

public PermissionJustification? Justification
{
get { return _justification; }
set {
_justification= value;
OnPropertyChanged("justification", value);
}
}

public FhirCode? Combining
{
get { return _combining; }
set {
_combining= value;
OnPropertyChanged("combining", value);
}
}

public List<PermissionRule>? Rule
{
get { return _rule; }
set {
_rule= value;
OnPropertyChanged("rule", value);
}
}


		#endregion
		#region Constructor
		public  Permission() { }
		public  Permission(string value) : base(value) { }
		public  Permission(JsonNode? source) : base(source) { }
		#endregion
	}
		public class PermissionJustification : BackboneElementType<PermissionJustification>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableConcept>? _basis;
private List<ReferenceType>? _evidence;

		#endregion
		#region public Method
		public List<CodeableConcept>? Basis
{
get { return _basis; }
set {
_basis= value;
OnPropertyChanged("basis", value);
}
}

public List<ReferenceType>? Evidence
{
get { return _evidence; }
set {
_evidence= value;
OnPropertyChanged("evidence", value);
}
}


		#endregion
		#region Constructor
		public  PermissionJustification() { }
		public  PermissionJustification(string value) : base(value) { }
		public  PermissionJustification(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PermissionRuleDataResource : BackboneElementType<PermissionRuleDataResource>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _meaning;
private ReferenceType? _reference;

		#endregion
		#region public Method
		public FhirCode? Meaning
{
get { return _meaning; }
set {
_meaning= value;
OnPropertyChanged("meaning", value);
}
}

public ReferenceType? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}


		#endregion
		#region Constructor
		public  PermissionRuleDataResource() { }
		public  PermissionRuleDataResource(string value) : base(value) { }
		public  PermissionRuleDataResource(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PermissionRuleData : BackboneElementType<PermissionRuleData>, IBackboneElementType
	{

		#region Private Method
		private List<PermissionRuleDataResource>? _resource;
private List<Coding>? _security;
private List<Period>? _period;
private ExpressionType? _expression;

		#endregion
		#region public Method
		public List<PermissionRuleDataResource>? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
}
}

public List<Coding>? Security
{
get { return _security; }
set {
_security= value;
OnPropertyChanged("security", value);
}
}

public List<Period>? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public ExpressionType? Expression
{
get { return _expression; }
set {
_expression= value;
OnPropertyChanged("expression", value);
}
}


		#endregion
		#region Constructor
		public  PermissionRuleData() { }
		public  PermissionRuleData(string value) : base(value) { }
		public  PermissionRuleData(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PermissionRuleActivity : BackboneElementType<PermissionRuleActivity>, IBackboneElementType
	{

		#region Private Method
		private List<ReferenceType>? _actor;
private List<CodeableConcept>? _action;
private List<CodeableConcept>? _purpose;

		#endregion
		#region public Method
		public List<ReferenceType>? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}

public List<CodeableConcept>? Action
{
get { return _action; }
set {
_action= value;
OnPropertyChanged("action", value);
}
}

public List<CodeableConcept>? Purpose
{
get { return _purpose; }
set {
_purpose= value;
OnPropertyChanged("purpose", value);
}
}


		#endregion
		#region Constructor
		public  PermissionRuleActivity() { }
		public  PermissionRuleActivity(string value) : base(value) { }
		public  PermissionRuleActivity(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PermissionRule : BackboneElementType<PermissionRule>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _type;
private List<PermissionRuleData>? _data;
private List<PermissionRuleActivity>? _activity;
private List<CodeableConcept>? _limit;

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

public List<PermissionRuleData>? Data
{
get { return _data; }
set {
_data= value;
OnPropertyChanged("data", value);
}
}

public List<PermissionRuleActivity>? Activity
{
get { return _activity; }
set {
_activity= value;
OnPropertyChanged("activity", value);
}
}

public List<CodeableConcept>? Limit
{
get { return _limit; }
set {
_limit= value;
OnPropertyChanged("limit", value);
}
}


		#endregion
		#region Constructor
		public  PermissionRule() { }
		public  PermissionRule(string value) : base(value) { }
		public  PermissionRule(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
