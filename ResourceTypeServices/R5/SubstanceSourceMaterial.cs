using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;


namespace ResourceTypeServices.R5
{
    public class SubstanceSourceMaterial : ResourceType<SubstanceSourceMaterial>
	{
		#region private Property
		private CodeableConcept? _sourceMaterialClass;
private CodeableConcept? _sourceMaterialType;
private CodeableConcept? _sourceMaterialState;
private Identifier? _organismId;
private FhirString? _organismName;
private List<Identifier>? _parentSubstanceId;
private List<FhirString>? _parentSubstanceName;
private List<CodeableConcept>? _countryOfOrigin;
private List<FhirString>? _geographicalLocation;
private CodeableConcept? _developmentStage;
private List<SubstanceSourceMaterialFractionDescription>? _fractionDescription;
private SubstanceSourceMaterialOrganism? _organism;
private List<SubstanceSourceMaterialPartDescription>? _partDescription;

		#endregion
		#region Public Method
		public CodeableConcept? SourceMaterialClass
{
get { return _sourceMaterialClass; }
set {
_sourceMaterialClass= value;
OnPropertyChanged("sourceMaterialClass", value);
}
}

public CodeableConcept? SourceMaterialType
{
get { return _sourceMaterialType; }
set {
_sourceMaterialType= value;
OnPropertyChanged("sourceMaterialType", value);
}
}

public CodeableConcept? SourceMaterialState
{
get { return _sourceMaterialState; }
set {
_sourceMaterialState= value;
OnPropertyChanged("sourceMaterialState", value);
}
}

public Identifier? OrganismId
{
get { return _organismId; }
set {
_organismId= value;
OnPropertyChanged("organismId", value);
}
}

public FhirString? OrganismName
{
get { return _organismName; }
set {
_organismName= value;
OnPropertyChanged("organismName", value);
}
}

public List<Identifier>? ParentSubstanceId
{
get { return _parentSubstanceId; }
set {
_parentSubstanceId= value;
OnPropertyChanged("parentSubstanceId", value);
}
}

public List<FhirString>? ParentSubstanceName
{
get { return _parentSubstanceName; }
set {
_parentSubstanceName= value;
OnPropertyChanged("parentSubstanceName", value);
}
}

public List<CodeableConcept>? CountryOfOrigin
{
get { return _countryOfOrigin; }
set {
_countryOfOrigin= value;
OnPropertyChanged("countryOfOrigin", value);
}
}

public List<FhirString>? GeographicalLocation
{
get { return _geographicalLocation; }
set {
_geographicalLocation= value;
OnPropertyChanged("geographicalLocation", value);
}
}

public CodeableConcept? DevelopmentStage
{
get { return _developmentStage; }
set {
_developmentStage= value;
OnPropertyChanged("developmentStage", value);
}
}

public List<SubstanceSourceMaterialFractionDescription>? FractionDescription
{
get { return _fractionDescription; }
set {
_fractionDescription= value;
OnPropertyChanged("fractionDescription", value);
}
}

public SubstanceSourceMaterialOrganism? Organism
{
get { return _organism; }
set {
_organism= value;
OnPropertyChanged("organism", value);
}
}

public List<SubstanceSourceMaterialPartDescription>? PartDescription
{
get { return _partDescription; }
set {
_partDescription= value;
OnPropertyChanged("partDescription", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceSourceMaterial() { }
		public  SubstanceSourceMaterial(string value) : base(value) { }
		public  SubstanceSourceMaterial(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SubstanceSourceMaterialFractionDescription : BackboneElementType<SubstanceSourceMaterialFractionDescription>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _fraction;
private CodeableConcept? _materialType;

		#endregion
		#region public Method
		public FhirString? Fraction
{
get { return _fraction; }
set {
_fraction= value;
OnPropertyChanged("fraction", value);
}
}

public CodeableConcept? MaterialType
{
get { return _materialType; }
set {
_materialType= value;
OnPropertyChanged("materialType", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceSourceMaterialFractionDescription() { }
		public  SubstanceSourceMaterialFractionDescription(string value) : base(value) { }
		public  SubstanceSourceMaterialFractionDescription(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceSourceMaterialOrganismAuthor : BackboneElementType<SubstanceSourceMaterialOrganismAuthor>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _authorType;
private FhirString? _authorDescription;

		#endregion
		#region public Method
		public CodeableConcept? AuthorType
{
get { return _authorType; }
set {
_authorType= value;
OnPropertyChanged("authorType", value);
}
}

public FhirString? AuthorDescription
{
get { return _authorDescription; }
set {
_authorDescription= value;
OnPropertyChanged("authorDescription", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceSourceMaterialOrganismAuthor() { }
		public  SubstanceSourceMaterialOrganismAuthor(string value) : base(value) { }
		public  SubstanceSourceMaterialOrganismAuthor(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceSourceMaterialOrganismHybrid : BackboneElementType<SubstanceSourceMaterialOrganismHybrid>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _maternalOrganismId;
private FhirString? _maternalOrganismName;
private FhirString? _paternalOrganismId;
private FhirString? _paternalOrganismName;
private CodeableConcept? _hybridType;

		#endregion
		#region public Method
		public FhirString? MaternalOrganismId
{
get { return _maternalOrganismId; }
set {
_maternalOrganismId= value;
OnPropertyChanged("maternalOrganismId", value);
}
}

public FhirString? MaternalOrganismName
{
get { return _maternalOrganismName; }
set {
_maternalOrganismName= value;
OnPropertyChanged("maternalOrganismName", value);
}
}

public FhirString? PaternalOrganismId
{
get { return _paternalOrganismId; }
set {
_paternalOrganismId= value;
OnPropertyChanged("paternalOrganismId", value);
}
}

public FhirString? PaternalOrganismName
{
get { return _paternalOrganismName; }
set {
_paternalOrganismName= value;
OnPropertyChanged("paternalOrganismName", value);
}
}

public CodeableConcept? HybridType
{
get { return _hybridType; }
set {
_hybridType= value;
OnPropertyChanged("hybridType", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceSourceMaterialOrganismHybrid() { }
		public  SubstanceSourceMaterialOrganismHybrid(string value) : base(value) { }
		public  SubstanceSourceMaterialOrganismHybrid(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceSourceMaterialOrganismOrganismGeneral : BackboneElementType<SubstanceSourceMaterialOrganismOrganismGeneral>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _kingdom;
private CodeableConcept? _phylum;
private CodeableConcept? _class;
private CodeableConcept? _order;

		#endregion
		#region public Method
		public CodeableConcept? Kingdom
{
get { return _kingdom; }
set {
_kingdom= value;
OnPropertyChanged("kingdom", value);
}
}

public CodeableConcept? Phylum
{
get { return _phylum; }
set {
_phylum= value;
OnPropertyChanged("phylum", value);
}
}

public CodeableConcept? Class
{
get { return _class; }
set {
_class= value;
OnPropertyChanged("class", value);
}
}

public CodeableConcept? Order
{
get { return _order; }
set {
_order= value;
OnPropertyChanged("order", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceSourceMaterialOrganismOrganismGeneral() { }
		public  SubstanceSourceMaterialOrganismOrganismGeneral(string value) : base(value) { }
		public  SubstanceSourceMaterialOrganismOrganismGeneral(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceSourceMaterialOrganism : BackboneElementType<SubstanceSourceMaterialOrganism>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _family;
private CodeableConcept? _genus;
private CodeableConcept? _species;
private CodeableConcept? _intraspecificType;
private FhirString? _intraspecificDescription;
private List<SubstanceSourceMaterialOrganismAuthor>? _author;
private SubstanceSourceMaterialOrganismHybrid? _hybrid;
private SubstanceSourceMaterialOrganismOrganismGeneral? _organismGeneral;

		#endregion
		#region public Method
		public CodeableConcept? Family
{
get { return _family; }
set {
_family= value;
OnPropertyChanged("family", value);
}
}

public CodeableConcept? Genus
{
get { return _genus; }
set {
_genus= value;
OnPropertyChanged("genus", value);
}
}

public CodeableConcept? Species
{
get { return _species; }
set {
_species= value;
OnPropertyChanged("species", value);
}
}

public CodeableConcept? IntraspecificType
{
get { return _intraspecificType; }
set {
_intraspecificType= value;
OnPropertyChanged("intraspecificType", value);
}
}

public FhirString? IntraspecificDescription
{
get { return _intraspecificDescription; }
set {
_intraspecificDescription= value;
OnPropertyChanged("intraspecificDescription", value);
}
}

public List<SubstanceSourceMaterialOrganismAuthor>? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}

public SubstanceSourceMaterialOrganismHybrid? Hybrid
{
get { return _hybrid; }
set {
_hybrid= value;
OnPropertyChanged("hybrid", value);
}
}

public SubstanceSourceMaterialOrganismOrganismGeneral? OrganismGeneral
{
get { return _organismGeneral; }
set {
_organismGeneral= value;
OnPropertyChanged("organismGeneral", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceSourceMaterialOrganism() { }
		public  SubstanceSourceMaterialOrganism(string value) : base(value) { }
		public  SubstanceSourceMaterialOrganism(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceSourceMaterialPartDescription : BackboneElementType<SubstanceSourceMaterialPartDescription>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _part;
private CodeableConcept? _partLocation;

		#endregion
		#region public Method
		public CodeableConcept? Part
{
get { return _part; }
set {
_part= value;
OnPropertyChanged("part", value);
}
}

public CodeableConcept? PartLocation
{
get { return _partLocation; }
set {
_partLocation= value;
OnPropertyChanged("partLocation", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceSourceMaterialPartDescription() { }
		public  SubstanceSourceMaterialPartDescription(string value) : base(value) { }
		public  SubstanceSourceMaterialPartDescription(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
