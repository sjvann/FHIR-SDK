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
    public class GuidanceResponse : ResourceType<GuidanceResponse>
	{
		#region private Property
		private Identifier? _requestIdentifier;
private List<Identifier>? _identifier;
private GuidanceResponseModuleChoice? _module;
private FhirCode? _status;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private FhirDateTime? _occurrenceDateTime;
private ReferenceType? _performer;
private List<CodeableReference>? _reason;
private List<Annotation>? _note;
private ReferenceType? _evaluationMessage;
private ReferenceType? _outputParameters;
private List<ReferenceType>? _result;
private List<DataRequirement>? _dataRequirement;

		#endregion
		#region Public Method
		public Identifier? RequestIdentifier
{
get { return _requestIdentifier; }
set {
_requestIdentifier= value;
OnPropertyChanged("requestIdentifier", value);
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

public GuidanceResponseModuleChoice? Module
{
get { return _module; }
set {
_module= value;
OnPropertyChanged("module", value);
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

public FhirDateTime? OccurrenceDateTime
{
get { return _occurrenceDateTime; }
set {
_occurrenceDateTime= value;
OnPropertyChanged("occurrenceDateTime", value);
}
}

public ReferenceType? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
}
}

public List<CodeableReference>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
}
}

public ReferenceType? EvaluationMessage
{
get { return _evaluationMessage; }
set {
_evaluationMessage= value;
OnPropertyChanged("evaluationMessage", value);
}
}

public ReferenceType? OutputParameters
{
get { return _outputParameters; }
set {
_outputParameters= value;
OnPropertyChanged("outputParameters", value);
}
}

public List<ReferenceType>? Result
{
get { return _result; }
set {
_result= value;
OnPropertyChanged("result", value);
}
}

public List<DataRequirement>? DataRequirement
{
get { return _dataRequirement; }
set {
_dataRequirement= value;
OnPropertyChanged("dataRequirement", value);
}
}


		#endregion
		#region Constructor
		public  GuidanceResponse() { }
		public  GuidanceResponse(string value) : base(value) { }
		public  GuidanceResponse(JsonNode? source) : base(source) { }
		#endregion
	}
	

		    public class GuidanceResponseModuleChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "uri","canonicalCodeableConcept"
        ];

        public GuidanceResponseModuleChoice(JsonObject value) : base("module", value, _supportType)
        {
        }
        public GuidanceResponseModuleChoice(IComplexType? value) : base("module", value)
        {
        }
        public GuidanceResponseModuleChoice(IPrimitiveType? value) : base("module", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"module".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
