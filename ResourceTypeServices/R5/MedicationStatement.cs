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
    public class MedicationStatement : ResourceType<MedicationStatement>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _partOf;
private FhirCode? _status;
private List<CodeableConcept>? _category;
private CodeableReference? _medication;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private MedicationStatementEffectiveChoice? _effective;
private FhirDateTime? _dateAsserted;
private List<ReferenceType>? _informationSource;
private List<ReferenceType>? _derivedFrom;
private List<CodeableReference>? _reason;
private List<Annotation>? _note;
private List<ReferenceType>? _relatedClinicalInformation;
private FhirMarkdown? _renderedDosageInstruction;
private List<Dosage>? _dosage;
private MedicationStatementAdherence? _adherence;

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

public List<ReferenceType>? PartOf
{
get { return _partOf; }
set {
_partOf= value;
OnPropertyChanged("partOf", value);
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

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public CodeableReference? Medication
{
get { return _medication; }
set {
_medication= value;
OnPropertyChanged("medication", value);
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

public MedicationStatementEffectiveChoice? Effective
{
get { return _effective; }
set {
_effective= value;
OnPropertyChanged("effective", value);
}
}

public FhirDateTime? DateAsserted
{
get { return _dateAsserted; }
set {
_dateAsserted= value;
OnPropertyChanged("dateAsserted", value);
}
}

public List<ReferenceType>? InformationSource
{
get { return _informationSource; }
set {
_informationSource= value;
OnPropertyChanged("informationSource", value);
}
}

public List<ReferenceType>? DerivedFrom
{
get { return _derivedFrom; }
set {
_derivedFrom= value;
OnPropertyChanged("derivedFrom", value);
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

public List<ReferenceType>? RelatedClinicalInformation
{
get { return _relatedClinicalInformation; }
set {
_relatedClinicalInformation= value;
OnPropertyChanged("relatedClinicalInformation", value);
}
}

public FhirMarkdown? RenderedDosageInstruction
{
get { return _renderedDosageInstruction; }
set {
_renderedDosageInstruction= value;
OnPropertyChanged("renderedDosageInstruction", value);
}
}

public List<Dosage>? Dosage
{
get { return _dosage; }
set {
_dosage= value;
OnPropertyChanged("dosage", value);
}
}

public MedicationStatementAdherence? Adherence
{
get { return _adherence; }
set {
_adherence= value;
OnPropertyChanged("adherence", value);
}
}


		#endregion
		#region Constructor
		public  MedicationStatement() { }
		public  MedicationStatement(string value) : base(value) { }
		public  MedicationStatement(JsonNode? source) : base(source) { }
		#endregion
	}
		public class MedicationStatementAdherence : BackboneElementType<MedicationStatementAdherence>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private CodeableConcept? _reason;

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

public CodeableConcept? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}


		#endregion
		#region Constructor
		public  MedicationStatementAdherence() { }
		public  MedicationStatementAdherence(string value) : base(value) { }
		public  MedicationStatementAdherence(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class MedicationStatementEffectiveChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","PeriodTiming"
        ];

        public MedicationStatementEffectiveChoice(JsonObject value) : base("effective", value, _supportType)
        {
        }
        public MedicationStatementEffectiveChoice(IComplexType? value) : base("effective", value)
        {
        }
        public MedicationStatementEffectiveChoice(IPrimitiveType? value) : base("effective", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"effective".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
