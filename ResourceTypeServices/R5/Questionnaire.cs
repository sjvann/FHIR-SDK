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
    public class Questionnaire : ResourceType<Questionnaire>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private QuestionnaireVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private List<FhirCanonical>? _derivedFrom;
private FhirCode? _status;
private FhirBoolean? _experimental;
private List<FhirCode>? _subjectType;
private FhirDateTime? _date;
private FhirString? _publisher;
private List<ContactDetail>? _contact;
private FhirMarkdown? _description;
private List<UsageContext>? _useContext;
private List<CodeableConcept>? _jurisdiction;
private FhirMarkdown? _purpose;
private FhirMarkdown? _copyright;
private FhirString? _copyrightLabel;
private FhirDate? _approvalDate;
private FhirDate? _lastReviewDate;
private Period? _effectivePeriod;
private List<Coding>? _code;
private List<QuestionnaireItem>? _item;

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

public QuestionnaireVersionAlgorithmChoice? VersionAlgorithm
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

public List<FhirCanonical>? DerivedFrom
{
get { return _derivedFrom; }
set {
_derivedFrom= value;
OnPropertyChanged("derivedFrom", value);
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

public List<FhirCode>? SubjectType
{
get { return _subjectType; }
set {
_subjectType= value;
OnPropertyChanged("subjectType", value);
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

public FhirDate? ApprovalDate
{
get { return _approvalDate; }
set {
_approvalDate= value;
OnPropertyChanged("approvalDate", value);
}
}

public FhirDate? LastReviewDate
{
get { return _lastReviewDate; }
set {
_lastReviewDate= value;
OnPropertyChanged("lastReviewDate", value);
}
}

public Period? EffectivePeriod
{
get { return _effectivePeriod; }
set {
_effectivePeriod= value;
OnPropertyChanged("effectivePeriod", value);
}
}

public List<Coding>? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<QuestionnaireItem>? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}


		#endregion
		#region Constructor
		public  Questionnaire() { }
		public  Questionnaire(string value) : base(value) { }
		public  Questionnaire(JsonNode? source) : base(source) { }
		#endregion
	}
		public class QuestionnaireItemEnableWhen : BackboneElementType<QuestionnaireItemEnableWhen>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _question;
private FhirCode? _operator;
private QuestionnaireItemEnableWhenAnswerChoice? _answer;

		#endregion
		#region public Method
		public FhirString? Question
{
get { return _question; }
set {
_question= value;
OnPropertyChanged("question", value);
}
}

public FhirCode? Operator
{
get { return _operator; }
set {
_operator= value;
OnPropertyChanged("operator", value);
}
}

public QuestionnaireItemEnableWhenAnswerChoice? Answer
{
get { return _answer; }
set {
_answer= value;
OnPropertyChanged("answer", value);
}
}


		#endregion
		#region Constructor
		public  QuestionnaireItemEnableWhen() { }
		public  QuestionnaireItemEnableWhen(string value) : base(value) { }
		public  QuestionnaireItemEnableWhen(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class QuestionnaireItemAnswerOption : BackboneElementType<QuestionnaireItemAnswerOption>, IBackboneElementType
	{

		#region Private Method
		private QuestionnaireItemAnswerOptionValueChoice? _value;
private FhirBoolean? _initialSelected;

		#endregion
		#region public Method
		public QuestionnaireItemAnswerOptionValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public FhirBoolean? InitialSelected
{
get { return _initialSelected; }
set {
_initialSelected= value;
OnPropertyChanged("initialSelected", value);
}
}


		#endregion
		#region Constructor
		public  QuestionnaireItemAnswerOption() { }
		public  QuestionnaireItemAnswerOption(string value) : base(value) { }
		public  QuestionnaireItemAnswerOption(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class QuestionnaireItemInitial : BackboneElementType<QuestionnaireItemInitial>, IBackboneElementType
	{

		#region Private Method
		private QuestionnaireItemInitialValueChoice? _value;

		#endregion
		#region public Method
		public QuestionnaireItemInitialValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  QuestionnaireItemInitial() { }
		public  QuestionnaireItemInitial(string value) : base(value) { }
		public  QuestionnaireItemInitial(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class QuestionnaireItem : BackboneElementType<QuestionnaireItem>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private FhirUri? _definition;
private List<Coding>? _code;
private FhirString? _prefix;
private FhirCode? _type;
private List<QuestionnaireItemEnableWhen>? _enableWhen;
private FhirCode? _enableBehavior;
private FhirCode? _disabledDisplay;
private FhirBoolean? _required;
private FhirBoolean? _repeats;
private FhirBoolean? _readOnly;
private FhirInteger? _maxLength;
private FhirCode? _answerConstraint;
private FhirCanonical? _answerValueSet;
private List<QuestionnaireItemAnswerOption>? _answerOption;
private List<QuestionnaireItemInitial>? _initial;

		#endregion
		#region public Method
		public FhirString? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
}
}

public FhirUri? Definition
{
get { return _definition; }
set {
_definition= value;
OnPropertyChanged("definition", value);
}
}

public List<Coding>? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public FhirString? Prefix
{
get { return _prefix; }
set {
_prefix= value;
OnPropertyChanged("prefix", value);
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

public List<QuestionnaireItemEnableWhen>? EnableWhen
{
get { return _enableWhen; }
set {
_enableWhen= value;
OnPropertyChanged("enableWhen", value);
}
}

public FhirCode? EnableBehavior
{
get { return _enableBehavior; }
set {
_enableBehavior= value;
OnPropertyChanged("enableBehavior", value);
}
}

public FhirCode? DisabledDisplay
{
get { return _disabledDisplay; }
set {
_disabledDisplay= value;
OnPropertyChanged("disabledDisplay", value);
}
}

public FhirBoolean? Required
{
get { return _required; }
set {
_required= value;
OnPropertyChanged("required", value);
}
}

public FhirBoolean? Repeats
{
get { return _repeats; }
set {
_repeats= value;
OnPropertyChanged("repeats", value);
}
}

public FhirBoolean? ReadOnly
{
get { return _readOnly; }
set {
_readOnly= value;
OnPropertyChanged("readOnly", value);
}
}

public FhirInteger? MaxLength
{
get { return _maxLength; }
set {
_maxLength= value;
OnPropertyChanged("maxLength", value);
}
}

public FhirCode? AnswerConstraint
{
get { return _answerConstraint; }
set {
_answerConstraint= value;
OnPropertyChanged("answerConstraint", value);
}
}

public FhirCanonical? AnswerValueSet
{
get { return _answerValueSet; }
set {
_answerValueSet= value;
OnPropertyChanged("answerValueSet", value);
}
}

public List<QuestionnaireItemAnswerOption>? AnswerOption
{
get { return _answerOption; }
set {
_answerOption= value;
OnPropertyChanged("answerOption", value);
}
}

public List<QuestionnaireItemInitial>? Initial
{
get { return _initial; }
set {
_initial= value;
OnPropertyChanged("initial", value);
}
}


		#endregion
		#region Constructor
		public  QuestionnaireItem() { }
		public  QuestionnaireItem(string value) : base(value) { }
		public  QuestionnaireItem(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class QuestionnaireVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public QuestionnaireVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public QuestionnaireVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public QuestionnaireVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class QuestionnaireItemEnableWhenAnswerChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","decimalintegerdatedateTimetimestringCodingQuantityReference(Resource)"
        ];

        public QuestionnaireItemEnableWhenAnswerChoice(JsonObject value) : base("answer", value, _supportType)
        {
        }
        public QuestionnaireItemEnableWhenAnswerChoice(IComplexType? value) : base("answer", value)
        {
        }
        public QuestionnaireItemEnableWhenAnswerChoice(IPrimitiveType? value) : base("answer", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"answer".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class QuestionnaireItemAnswerOptionValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "integer","datetimestringCodingReference(Resource)"
        ];

        public QuestionnaireItemAnswerOptionValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public QuestionnaireItemAnswerOptionValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public QuestionnaireItemAnswerOptionValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class QuestionnaireItemInitialValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","decimalintegerdatedateTimetimestringuriAttachmentCodingQuantityReference(Resource)"
        ];

        public QuestionnaireItemInitialValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public QuestionnaireItemInitialValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public QuestionnaireItemInitialValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
