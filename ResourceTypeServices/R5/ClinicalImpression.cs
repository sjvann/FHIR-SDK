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
    public class ClinicalImpression : ResourceType<ClinicalImpression>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private CodeableConcept? _statusReason;
private FhirString? _description;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private ClinicalImpressionEffectiveChoice? _effective;
private FhirDateTime? _date;
private ReferenceType? _performer;
private ReferenceType? _previous;
private List<ReferenceType>? _problem;
private CodeableConcept? _changePattern;
private List<FhirUri>? _protocol;
private FhirString? _summary;
private List<ClinicalImpressionFinding>? _finding;
private List<CodeableConcept>? _prognosisCodeableConcept;
private List<ReferenceType>? _prognosisReference;
private List<ReferenceType>? _supportingInfo;
private List<Annotation>? _note;

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

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public CodeableConcept? StatusReason
{
get { return _statusReason; }
set {
_statusReason= value;
OnPropertyChanged("statusReason", value);
}
}

public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
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

public ClinicalImpressionEffectiveChoice? Effective
{
get { return _effective; }
set {
_effective= value;
OnPropertyChanged("effective", value);
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

public ReferenceType? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
}
}

public ReferenceType? Previous
{
get { return _previous; }
set {
_previous= value;
OnPropertyChanged("previous", value);
}
}

public List<ReferenceType>? Problem
{
get { return _problem; }
set {
_problem= value;
OnPropertyChanged("problem", value);
}
}

public CodeableConcept? ChangePattern
{
get { return _changePattern; }
set {
_changePattern= value;
OnPropertyChanged("changePattern", value);
}
}

public List<FhirUri>? Protocol
{
get { return _protocol; }
set {
_protocol= value;
OnPropertyChanged("protocol", value);
}
}

public FhirString? Summary
{
get { return _summary; }
set {
_summary= value;
OnPropertyChanged("summary", value);
}
}

public List<ClinicalImpressionFinding>? Finding
{
get { return _finding; }
set {
_finding= value;
OnPropertyChanged("finding", value);
}
}

public List<CodeableConcept>? PrognosisCodeableConcept
{
get { return _prognosisCodeableConcept; }
set {
_prognosisCodeableConcept= value;
OnPropertyChanged("prognosisCodeableConcept", value);
}
}

public List<ReferenceType>? PrognosisReference
{
get { return _prognosisReference; }
set {
_prognosisReference= value;
OnPropertyChanged("prognosisReference", value);
}
}

public List<ReferenceType>? SupportingInfo
{
get { return _supportingInfo; }
set {
_supportingInfo= value;
OnPropertyChanged("supportingInfo", value);
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


		#endregion
		#region Constructor
		public  ClinicalImpression() { }
		public  ClinicalImpression(string value) : base(value) { }
		public  ClinicalImpression(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ClinicalImpressionFinding : BackboneElementType<ClinicalImpressionFinding>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _item;
private FhirString? _basis;

		#endregion
		#region public Method
		public CodeableReference? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}

public FhirString? Basis
{
get { return _basis; }
set {
_basis= value;
OnPropertyChanged("basis", value);
}
}


		#endregion
		#region Constructor
		public  ClinicalImpressionFinding() { }
		public  ClinicalImpressionFinding(string value) : base(value) { }
		public  ClinicalImpressionFinding(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ClinicalImpressionEffectiveChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public ClinicalImpressionEffectiveChoice(JsonObject value) : base("effective", value, _supportType)
        {
        }
        public ClinicalImpressionEffectiveChoice(IComplexType? value) : base("effective", value)
        {
        }
        public ClinicalImpressionEffectiveChoice(IPrimitiveType? value) : base("effective", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"effective".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
