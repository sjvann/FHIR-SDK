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
    public class QuestionnaireResponse : ResourceType<QuestionnaireResponse>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _partOf;
private FhirCanonical? _questionnaire;
private FhirCode? _status;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private FhirDateTime? _authored;
private ReferenceType? _author;
private ReferenceType? _source;
private List<QuestionnaireResponseItem>? _item;

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

public List<ReferenceType>? BasedOn
{
get { return _basedOn; }
set {
_basedOn= value;
OnPropertyChanged("basedOn", value);
}
}

public List<ReferenceType>? PartOf
{
get { return _partOf; }
set {
_partOf= value;
OnPropertyChanged("partOf", value);
}
}

public FhirCanonical? Questionnaire
{
get { return _questionnaire; }
set {
_questionnaire= value;
OnPropertyChanged("questionnaire", value);
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

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public ReferenceType? Encounter
{
get { return _encounter; }
set {
_encounter= value;
OnPropertyChanged("encounter", value);
}
}

public FhirDateTime? Authored
{
get { return _authored; }
set {
_authored= value;
OnPropertyChanged("authored", value);
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

public ReferenceType? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}

public List<QuestionnaireResponseItem>? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}


		#endregion
		#region Constructor
		public  QuestionnaireResponse() { }
		public  QuestionnaireResponse(string value) : base(value) { }
		public  QuestionnaireResponse(JsonNode? source) : base(source) { }
		#endregion
	}
		public class QuestionnaireResponseItemAnswer : BackboneElementType<QuestionnaireResponseItemAnswer>, IBackboneElementType
	{

		#region Private Method
		private QuestionnaireResponseItemAnswerValueChoice? _value;

		#endregion
		#region public Method
		public QuestionnaireResponseItemAnswerValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  QuestionnaireResponseItemAnswer() { }
		public  QuestionnaireResponseItemAnswer(string value) : base(value) { }
		public  QuestionnaireResponseItemAnswer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class QuestionnaireResponseItem : BackboneElementType<QuestionnaireResponseItem>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private FhirUri? _definition;
private List<QuestionnaireResponseItemAnswer>? _answer;

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

public List<QuestionnaireResponseItemAnswer>? Answer
{
get { return _answer; }
set {
_answer= value;
OnPropertyChanged("answer", value);
}
}


		#endregion
		#region Constructor
		public  QuestionnaireResponseItem() { }
		public  QuestionnaireResponseItem(string value) : base(value) { }
		public  QuestionnaireResponseItem(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class QuestionnaireResponseItemAnswerValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","decimalintegerdatedateTimetimestringuriAttachmentCodingQuantity {SimpleQuantity}Reference(Resource)"
        ];

        public QuestionnaireResponseItemAnswerValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public QuestionnaireResponseItemAnswerValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public QuestionnaireResponseItemAnswerValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
