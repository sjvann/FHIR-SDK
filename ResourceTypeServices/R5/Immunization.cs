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
    public class Immunization : ResourceType<Immunization>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _basedOn;
private FhirCode? _status;
private CodeableConcept? _statusReason;
private CodeableConcept? _vaccineCode;
private CodeableReference? _administeredProduct;
private CodeableReference? _manufacturer;
private FhirString? _lotNumber;
private FhirDate? _expirationDate;
private ReferenceType? _patient;
private ReferenceType? _encounter;
private List<ReferenceType>? _supportingInformation;
private ImmunizationOccurrenceChoice? _occurrence;
private FhirBoolean? _primarySource;
private CodeableReference? _informationSource;
private ReferenceType? _location;
private CodeableConcept? _site;
private CodeableConcept? _route;
private Quantity? _doseQuantity;
private List<ImmunizationPerformer>? _performer;
private List<Annotation>? _note;
private List<CodeableReference>? _reason;
private FhirBoolean? _isSubpotent;
private List<CodeableConcept>? _subpotentReason;
private List<ImmunizationProgramEligibility>? _programEligibility;
private CodeableConcept? _fundingSource;
private List<ImmunizationReaction>? _reaction;
private List<ImmunizationProtocolApplied>? _protocolApplied;

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

public CodeableConcept? VaccineCode
{
get { return _vaccineCode; }
set {
_vaccineCode= value;
OnPropertyChanged("vaccineCode", value);
}
}

public CodeableReference? AdministeredProduct
{
get { return _administeredProduct; }
set {
_administeredProduct= value;
OnPropertyChanged("administeredProduct", value);
}
}

public CodeableReference? Manufacturer
{
get { return _manufacturer; }
set {
_manufacturer= value;
OnPropertyChanged("manufacturer", value);
}
}

public FhirString? LotNumber
{
get { return _lotNumber; }
set {
_lotNumber= value;
OnPropertyChanged("lotNumber", value);
}
}

public FhirDate? ExpirationDate
{
get { return _expirationDate; }
set {
_expirationDate= value;
OnPropertyChanged("expirationDate", value);
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

public ReferenceType? Encounter
{
get { return _encounter; }
set {
_encounter= value;
OnPropertyChanged("encounter", value);
}
}

public List<ReferenceType>? SupportingInformation
{
get { return _supportingInformation; }
set {
_supportingInformation= value;
OnPropertyChanged("supportingInformation", value);
}
}

public ImmunizationOccurrenceChoice? Occurrence
{
get { return _occurrence; }
set {
_occurrence= value;
OnPropertyChanged("occurrence", value);
}
}

public FhirBoolean? PrimarySource
{
get { return _primarySource; }
set {
_primarySource= value;
OnPropertyChanged("primarySource", value);
}
}

public CodeableReference? InformationSource
{
get { return _informationSource; }
set {
_informationSource= value;
OnPropertyChanged("informationSource", value);
}
}

public ReferenceType? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public CodeableConcept? Site
{
get { return _site; }
set {
_site= value;
OnPropertyChanged("site", value);
}
}

public CodeableConcept? Route
{
get { return _route; }
set {
_route= value;
OnPropertyChanged("route", value);
}
}

public Quantity? DoseQuantity
{
get { return _doseQuantity; }
set {
_doseQuantity= value;
OnPropertyChanged("doseQuantity", value);
}
}

public List<ImmunizationPerformer>? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
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

public List<CodeableReference>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public FhirBoolean? IsSubpotent
{
get { return _isSubpotent; }
set {
_isSubpotent= value;
OnPropertyChanged("isSubpotent", value);
}
}

public List<CodeableConcept>? SubpotentReason
{
get { return _subpotentReason; }
set {
_subpotentReason= value;
OnPropertyChanged("subpotentReason", value);
}
}

public List<ImmunizationProgramEligibility>? ProgramEligibility
{
get { return _programEligibility; }
set {
_programEligibility= value;
OnPropertyChanged("programEligibility", value);
}
}

public CodeableConcept? FundingSource
{
get { return _fundingSource; }
set {
_fundingSource= value;
OnPropertyChanged("fundingSource", value);
}
}

public List<ImmunizationReaction>? Reaction
{
get { return _reaction; }
set {
_reaction= value;
OnPropertyChanged("reaction", value);
}
}

public List<ImmunizationProtocolApplied>? ProtocolApplied
{
get { return _protocolApplied; }
set {
_protocolApplied= value;
OnPropertyChanged("protocolApplied", value);
}
}


		#endregion
		#region Constructor
		public  Immunization() { }
		public  Immunization(string value) : base(value) { }
		public  Immunization(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ImmunizationPerformer : BackboneElementType<ImmunizationPerformer>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _function;
private ReferenceType? _actor;

		#endregion
		#region public Method
		public CodeableConcept? Function
{
get { return _function; }
set {
_function= value;
OnPropertyChanged("function", value);
}
}

public ReferenceType? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}


		#endregion
		#region Constructor
		public  ImmunizationPerformer() { }
		public  ImmunizationPerformer(string value) : base(value) { }
		public  ImmunizationPerformer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImmunizationProgramEligibility : BackboneElementType<ImmunizationProgramEligibility>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _program;
private CodeableConcept? _programStatus;

		#endregion
		#region public Method
		public CodeableConcept? Program
{
get { return _program; }
set {
_program= value;
OnPropertyChanged("program", value);
}
}

public CodeableConcept? ProgramStatus
{
get { return _programStatus; }
set {
_programStatus= value;
OnPropertyChanged("programStatus", value);
}
}


		#endregion
		#region Constructor
		public  ImmunizationProgramEligibility() { }
		public  ImmunizationProgramEligibility(string value) : base(value) { }
		public  ImmunizationProgramEligibility(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImmunizationReaction : BackboneElementType<ImmunizationReaction>, IBackboneElementType
	{

		#region Private Method
		private FhirDateTime? _date;
private CodeableReference? _manifestation;
private FhirBoolean? _reported;

		#endregion
		#region public Method
		public FhirDateTime? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
}
}

public CodeableReference? Manifestation
{
get { return _manifestation; }
set {
_manifestation= value;
OnPropertyChanged("manifestation", value);
}
}

public FhirBoolean? Reported
{
get { return _reported; }
set {
_reported= value;
OnPropertyChanged("reported", value);
}
}


		#endregion
		#region Constructor
		public  ImmunizationReaction() { }
		public  ImmunizationReaction(string value) : base(value) { }
		public  ImmunizationReaction(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImmunizationProtocolApplied : BackboneElementType<ImmunizationProtocolApplied>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _series;
private ReferenceType? _authority;
private List<CodeableConcept>? _targetDisease;
private FhirString? _doseNumber;
private FhirString? _seriesDoses;

		#endregion
		#region public Method
		public FhirString? Series
{
get { return _series; }
set {
_series= value;
OnPropertyChanged("series", value);
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

public List<CodeableConcept>? TargetDisease
{
get { return _targetDisease; }
set {
_targetDisease= value;
OnPropertyChanged("targetDisease", value);
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


		#endregion
		#region Constructor
		public  ImmunizationProtocolApplied() { }
		public  ImmunizationProtocolApplied(string value) : base(value) { }
		public  ImmunizationProtocolApplied(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ImmunizationOccurrenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","string"
        ];

        public ImmunizationOccurrenceChoice(JsonObject value) : base("occurrence", value, _supportType)
        {
        }
        public ImmunizationOccurrenceChoice(IComplexType? value) : base("occurrence", value)
        {
        }
        public ImmunizationOccurrenceChoice(IPrimitiveType? value) : base("occurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurrence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
