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
    public class ImmunizationRecommendation : ResourceType<ImmunizationRecommendation>
	{
		#region private Property
		private List<Identifier>? _identifier;
private ReferenceType? _patient;
private FhirDateTime? _date;
private ReferenceType? _authority;
private List<ImmunizationRecommendationRecommendation>? _recommendation;

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

public ReferenceType? Patient
{
get { return _patient; }
set {
_patient= value;
OnPropertyChanged("patient", value);
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

public ReferenceType? Authority
{
get { return _authority; }
set {
_authority= value;
OnPropertyChanged("authority", value);
}
}

public List<ImmunizationRecommendationRecommendation>? Recommendation
{
get { return _recommendation; }
set {
_recommendation= value;
OnPropertyChanged("recommendation", value);
}
}


		#endregion
		#region Constructor
		public  ImmunizationRecommendation() { }
		public  ImmunizationRecommendation(string value) : base(value) { }
		public  ImmunizationRecommendation(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ImmunizationRecommendationRecommendationDateCriterion : BackboneElementType<ImmunizationRecommendationRecommendationDateCriterion>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private FhirDateTime? _value;

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

public FhirDateTime? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  ImmunizationRecommendationRecommendationDateCriterion() { }
		public  ImmunizationRecommendationRecommendationDateCriterion(string value) : base(value) { }
		public  ImmunizationRecommendationRecommendationDateCriterion(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImmunizationRecommendationRecommendation : BackboneElementType<ImmunizationRecommendationRecommendation>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableConcept>? _vaccineCode;
private List<CodeableConcept>? _targetDisease;
private List<CodeableConcept>? _contraindicatedVaccineCode;
private CodeableConcept? _forecastStatus;
private List<CodeableConcept>? _forecastReason;
private List<ImmunizationRecommendationRecommendationDateCriterion>? _dateCriterion;
private FhirMarkdown? _description;
private FhirString? _series;
private FhirString? _doseNumber;
private FhirString? _seriesDoses;
private List<ReferenceType>? _supportingImmunization;
private List<ReferenceType>? _supportingPatientInformation;

		#endregion
		#region public Method
		public List<CodeableConcept>? VaccineCode
{
get { return _vaccineCode; }
set {
_vaccineCode= value;
OnPropertyChanged("vaccineCode", value);
}
}

public List<CodeableConcept>? TargetDisease
{
get { return _targetDisease; }
set {
_targetDisease= value;
OnPropertyChanged("targetDisease", value);
}
}

public List<CodeableConcept>? ContraindicatedVaccineCode
{
get { return _contraindicatedVaccineCode; }
set {
_contraindicatedVaccineCode= value;
OnPropertyChanged("contraindicatedVaccineCode", value);
}
}

public CodeableConcept? ForecastStatus
{
get { return _forecastStatus; }
set {
_forecastStatus= value;
OnPropertyChanged("forecastStatus", value);
}
}

public List<CodeableConcept>? ForecastReason
{
get { return _forecastReason; }
set {
_forecastReason= value;
OnPropertyChanged("forecastReason", value);
}
}

public List<ImmunizationRecommendationRecommendationDateCriterion>? DateCriterion
{
get { return _dateCriterion; }
set {
_dateCriterion= value;
OnPropertyChanged("dateCriterion", value);
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

public FhirString? Series
{
get { return _series; }
set {
_series= value;
OnPropertyChanged("series", value);
}
}

public FhirString? DoseNumber
{
get { return _doseNumber; }
set {
_doseNumber= value;
OnPropertyChanged("doseNumber", value);
}
}

public FhirString? SeriesDoses
{
get { return _seriesDoses; }
set {
_seriesDoses= value;
OnPropertyChanged("seriesDoses", value);
}
}

public List<ReferenceType>? SupportingImmunization
{
get { return _supportingImmunization; }
set {
_supportingImmunization= value;
OnPropertyChanged("supportingImmunization", value);
}
}

public List<ReferenceType>? SupportingPatientInformation
{
get { return _supportingPatientInformation; }
set {
_supportingPatientInformation= value;
OnPropertyChanged("supportingPatientInformation", value);
}
}


		#endregion
		#region Constructor
		public  ImmunizationRecommendationRecommendation() { }
		public  ImmunizationRecommendationRecommendation(string value) : base(value) { }
		public  ImmunizationRecommendationRecommendation(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
