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
    public class AdministrableProductDefinition : ResourceType<AdministrableProductDefinition>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<ReferenceType>? _formOf;
private CodeableConcept? _administrableDoseForm;
private CodeableConcept? _unitOfPresentation;
private List<ReferenceType>? _producedFrom;
private List<CodeableConcept>? _ingredient;
private ReferenceType? _device;
private FhirMarkdown? _description;
private List<AdministrableProductDefinitionProperty>? _property;
private List<AdministrableProductDefinitionRouteOfAdministration>? _routeOfAdministration;

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

public List<ReferenceType>? FormOf
{
get { return _formOf; }
set {
_formOf= value;
OnPropertyChanged("formOf", value);
}
}

public CodeableConcept? AdministrableDoseForm
{
get { return _administrableDoseForm; }
set {
_administrableDoseForm= value;
OnPropertyChanged("administrableDoseForm", value);
}
}

public CodeableConcept? UnitOfPresentation
{
get { return _unitOfPresentation; }
set {
_unitOfPresentation= value;
OnPropertyChanged("unitOfPresentation", value);
}
}

public List<ReferenceType>? ProducedFrom
{
get { return _producedFrom; }
set {
_producedFrom= value;
OnPropertyChanged("producedFrom", value);
}
}

public List<CodeableConcept>? Ingredient
{
get { return _ingredient; }
set {
_ingredient= value;
OnPropertyChanged("ingredient", value);
}
}

public ReferenceType? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
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

public List<AdministrableProductDefinitionProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}

public List<AdministrableProductDefinitionRouteOfAdministration>? RouteOfAdministration
{
get { return _routeOfAdministration; }
set {
_routeOfAdministration= value;
OnPropertyChanged("routeOfAdministration", value);
}
}


		#endregion
		#region Constructor
		public  AdministrableProductDefinition() { }
		public  AdministrableProductDefinition(string value) : base(value) { }
		public  AdministrableProductDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class AdministrableProductDefinitionProperty : BackboneElementType<AdministrableProductDefinitionProperty>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private AdministrableProductDefinitionPropertyValueChoice? _value;
private CodeableConcept? _status;

		#endregion
		#region public Method
		public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public AdministrableProductDefinitionPropertyValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public CodeableConcept? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}


		#endregion
		#region Constructor
		public  AdministrableProductDefinitionProperty() { }
		public  AdministrableProductDefinitionProperty(string value) : base(value) { }
		public  AdministrableProductDefinitionProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AdministrableProductDefinitionRouteOfAdministrationTargetSpeciesWithdrawalPeriod : BackboneElementType<AdministrableProductDefinitionRouteOfAdministrationTargetSpeciesWithdrawalPeriod>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _tissue;
private Quantity? _value;
private FhirString? _supportingInformation;

		#endregion
		#region public Method
		public CodeableConcept? Tissue
{
get { return _tissue; }
set {
_tissue= value;
OnPropertyChanged("tissue", value);
}
}

public Quantity? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public FhirString? SupportingInformation
{
get { return _supportingInformation; }
set {
_supportingInformation= value;
OnPropertyChanged("supportingInformation", value);
}
}


		#endregion
		#region Constructor
		public  AdministrableProductDefinitionRouteOfAdministrationTargetSpeciesWithdrawalPeriod() { }
		public  AdministrableProductDefinitionRouteOfAdministrationTargetSpeciesWithdrawalPeriod(string value) : base(value) { }
		public  AdministrableProductDefinitionRouteOfAdministrationTargetSpeciesWithdrawalPeriod(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AdministrableProductDefinitionRouteOfAdministrationTargetSpecies : BackboneElementType<AdministrableProductDefinitionRouteOfAdministrationTargetSpecies>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private List<AdministrableProductDefinitionRouteOfAdministrationTargetSpeciesWithdrawalPeriod>? _withdrawalPeriod;

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

public List<AdministrableProductDefinitionRouteOfAdministrationTargetSpeciesWithdrawalPeriod>? WithdrawalPeriod
{
get { return _withdrawalPeriod; }
set {
_withdrawalPeriod= value;
OnPropertyChanged("withdrawalPeriod", value);
}
}


		#endregion
		#region Constructor
		public  AdministrableProductDefinitionRouteOfAdministrationTargetSpecies() { }
		public  AdministrableProductDefinitionRouteOfAdministrationTargetSpecies(string value) : base(value) { }
		public  AdministrableProductDefinitionRouteOfAdministrationTargetSpecies(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AdministrableProductDefinitionRouteOfAdministration : BackboneElementType<AdministrableProductDefinitionRouteOfAdministration>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private Quantity? _firstDose;
private Quantity? _maxSingleDose;
private Quantity? _maxDosePerDay;
private Ratio? _maxDosePerTreatmentPeriod;
private Duration? _maxTreatmentPeriod;
private List<AdministrableProductDefinitionRouteOfAdministrationTargetSpecies>? _targetSpecies;

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

public Quantity? FirstDose
{
get { return _firstDose; }
set {
_firstDose= value;
OnPropertyChanged("firstDose", value);
}
}

public Quantity? MaxSingleDose
{
get { return _maxSingleDose; }
set {
_maxSingleDose= value;
OnPropertyChanged("maxSingleDose", value);
}
}

public Quantity? MaxDosePerDay
{
get { return _maxDosePerDay; }
set {
_maxDosePerDay= value;
OnPropertyChanged("maxDosePerDay", value);
}
}

public Ratio? MaxDosePerTreatmentPeriod
{
get { return _maxDosePerTreatmentPeriod; }
set {
_maxDosePerTreatmentPeriod= value;
OnPropertyChanged("maxDosePerTreatmentPeriod", value);
}
}

public Duration? MaxTreatmentPeriod
{
get { return _maxTreatmentPeriod; }
set {
_maxTreatmentPeriod= value;
OnPropertyChanged("maxTreatmentPeriod", value);
}
}

public List<AdministrableProductDefinitionRouteOfAdministrationTargetSpecies>? TargetSpecies
{
get { return _targetSpecies; }
set {
_targetSpecies= value;
OnPropertyChanged("targetSpecies", value);
}
}


		#endregion
		#region Constructor
		public  AdministrableProductDefinitionRouteOfAdministration() { }
		public  AdministrableProductDefinitionRouteOfAdministration(string value) : base(value) { }
		public  AdministrableProductDefinitionRouteOfAdministration(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class AdministrableProductDefinitionPropertyValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","QuantitydatebooleanmarkdownAttachmentReference(Binary)"
        ];
public AdministrableProductDefinitionPropertyValueChoice(string dataType, JsonValue? value) : base(dataType, value) { }
        public AdministrableProductDefinitionPropertyValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public AdministrableProductDefinitionPropertyValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public AdministrableProductDefinitionPropertyValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
