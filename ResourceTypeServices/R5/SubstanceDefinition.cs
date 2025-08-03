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
    public class SubstanceDefinition : ResourceType<SubstanceDefinition>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirString? _version;
private CodeableConcept? _status;
private List<CodeableConcept>? _classification;
private CodeableConcept? _domain;
private List<CodeableConcept>? _grade;
private FhirMarkdown? _description;
private List<ReferenceType>? _informationSource;
private List<Annotation>? _note;
private List<ReferenceType>? _manufacturer;
private List<ReferenceType>? _supplier;
private List<SubstanceDefinitionMoiety>? _moiety;
private List<SubstanceDefinitionCharacterization>? _characterization;
private List<SubstanceDefinitionProperty>? _property;
private ReferenceType? _referenceInformation;
private List<SubstanceDefinitionMolecularWeight>? _molecularWeight;
private SubstanceDefinitionStructure? _structure;
private List<SubstanceDefinitionCode>? _code;
private List<SubstanceDefinitionName>? _name;
private List<SubstanceDefinitionRelationship>? _relationship;
private ReferenceType? _nucleicAcid;
private ReferenceType? _polymer;
private ReferenceType? _protein;
private SubstanceDefinitionSourceMaterial? _sourceMaterial;

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

public FhirString? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
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

public List<CodeableConcept>? Classification
{
get { return _classification; }
set {
_classification= value;
OnPropertyChanged("classification", value);
}
}

public CodeableConcept? Domain
{
get { return _domain; }
set {
_domain= value;
OnPropertyChanged("domain", value);
}
}

public List<CodeableConcept>? Grade
{
get { return _grade; }
set {
_grade= value;
OnPropertyChanged("grade", value);
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

public List<ReferenceType>? InformationSource
{
get { return _informationSource; }
set {
_informationSource= value;
OnPropertyChanged("informationSource", value);
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

public List<ReferenceType>? Manufacturer
{
get { return _manufacturer; }
set {
_manufacturer= value;
OnPropertyChanged("manufacturer", value);
}
}

public List<ReferenceType>? Supplier
{
get { return _supplier; }
set {
_supplier= value;
OnPropertyChanged("supplier", value);
}
}

public List<SubstanceDefinitionMoiety>? Moiety
{
get { return _moiety; }
set {
_moiety= value;
OnPropertyChanged("moiety", value);
}
}

public List<SubstanceDefinitionCharacterization>? Characterization
{
get { return _characterization; }
set {
_characterization= value;
OnPropertyChanged("characterization", value);
}
}

public List<SubstanceDefinitionProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}

public ReferenceType? ReferenceInformation
{
get { return _referenceInformation; }
set {
_referenceInformation= value;
OnPropertyChanged("referenceInformation", value);
}
}

public List<SubstanceDefinitionMolecularWeight>? MolecularWeight
{
get { return _molecularWeight; }
set {
_molecularWeight= value;
OnPropertyChanged("molecularWeight", value);
}
}

public SubstanceDefinitionStructure? Structure
{
get { return _structure; }
set {
_structure= value;
OnPropertyChanged("structure", value);
}
}

public List<SubstanceDefinitionCode>? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<SubstanceDefinitionName>? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public List<SubstanceDefinitionRelationship>? Relationship
{
get { return _relationship; }
set {
_relationship= value;
OnPropertyChanged("relationship", value);
}
}

public ReferenceType? NucleicAcid
{
get { return _nucleicAcid; }
set {
_nucleicAcid= value;
OnPropertyChanged("nucleicAcid", value);
}
}

public ReferenceType? Polymer
{
get { return _polymer; }
set {
_polymer= value;
OnPropertyChanged("polymer", value);
}
}

public ReferenceType? Protein
{
get { return _protein; }
set {
_protein= value;
OnPropertyChanged("protein", value);
}
}

public SubstanceDefinitionSourceMaterial? SourceMaterial
{
get { return _sourceMaterial; }
set {
_sourceMaterial= value;
OnPropertyChanged("sourceMaterial", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceDefinition() { }
		public  SubstanceDefinition(string value) : base(value) { }
		public  SubstanceDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SubstanceDefinitionMoiety : BackboneElementType<SubstanceDefinitionMoiety>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _role;
private Identifier? _identifier;
private FhirString? _name;
private CodeableConcept? _stereochemistry;
private CodeableConcept? _opticalActivity;
private FhirString? _molecularFormula;
private SubstanceDefinitionMoietyAmountChoice? _amount;
private CodeableConcept? _measurementType;

		#endregion
		#region public Method
		public CodeableConcept? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}

public Identifier? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
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

public CodeableConcept? Stereochemistry
{
get { return _stereochemistry; }
set {
_stereochemistry= value;
OnPropertyChanged("stereochemistry", value);
}
}

public CodeableConcept? OpticalActivity
{
get { return _opticalActivity; }
set {
_opticalActivity= value;
OnPropertyChanged("opticalActivity", value);
}
}

public FhirString? MolecularFormula
{
get { return _molecularFormula; }
set {
_molecularFormula= value;
OnPropertyChanged("molecularFormula", value);
}
}

public SubstanceDefinitionMoietyAmountChoice? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}

public CodeableConcept? MeasurementType
{
get { return _measurementType; }
set {
_measurementType= value;
OnPropertyChanged("measurementType", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceDefinitionMoiety() { }
		public  SubstanceDefinitionMoiety(string value) : base(value) { }
		public  SubstanceDefinitionMoiety(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceDefinitionCharacterization : BackboneElementType<SubstanceDefinitionCharacterization>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _technique;
private CodeableConcept? _form;
private FhirMarkdown? _description;
private List<Attachment>? _file;

		#endregion
		#region public Method
		public CodeableConcept? Technique
{
get { return _technique; }
set {
_technique= value;
OnPropertyChanged("technique", value);
}
}

public CodeableConcept? Form
{
get { return _form; }
set {
_form= value;
OnPropertyChanged("form", value);
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

public List<Attachment>? File
{
get { return _file; }
set {
_file= value;
OnPropertyChanged("file", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceDefinitionCharacterization() { }
		public  SubstanceDefinitionCharacterization(string value) : base(value) { }
		public  SubstanceDefinitionCharacterization(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceDefinitionProperty : BackboneElementType<SubstanceDefinitionProperty>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private SubstanceDefinitionPropertyValueChoice? _value;

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

public SubstanceDefinitionPropertyValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceDefinitionProperty() { }
		public  SubstanceDefinitionProperty(string value) : base(value) { }
		public  SubstanceDefinitionProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceDefinitionMolecularWeight : BackboneElementType<SubstanceDefinitionMolecularWeight>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _method;
private CodeableConcept? _type;
private Quantity? _amount;

		#endregion
		#region public Method
		public CodeableConcept? Method
{
get { return _method; }
set {
_method= value;
OnPropertyChanged("method", value);
}
}

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public Quantity? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceDefinitionMolecularWeight() { }
		public  SubstanceDefinitionMolecularWeight(string value) : base(value) { }
		public  SubstanceDefinitionMolecularWeight(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceDefinitionStructureRepresentation : BackboneElementType<SubstanceDefinitionStructureRepresentation>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private FhirString? _representation;
private CodeableConcept? _format;
private ReferenceType? _document;

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

public FhirString? Representation
{
get { return _representation; }
set {
_representation= value;
OnPropertyChanged("representation", value);
}
}

public CodeableConcept? Format
{
get { return _format; }
set {
_format= value;
OnPropertyChanged("format", value);
}
}

public ReferenceType? Document
{
get { return _document; }
set {
_document= value;
OnPropertyChanged("document", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceDefinitionStructureRepresentation() { }
		public  SubstanceDefinitionStructureRepresentation(string value) : base(value) { }
		public  SubstanceDefinitionStructureRepresentation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceDefinitionStructure : BackboneElementType<SubstanceDefinitionStructure>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _stereochemistry;
private CodeableConcept? _opticalActivity;
private FhirString? _molecularFormula;
private FhirString? _molecularFormulaByMoiety;
private List<CodeableConcept>? _technique;
private List<ReferenceType>? _sourceDocument;
private List<SubstanceDefinitionStructureRepresentation>? _representation;

		#endregion
		#region public Method
		public CodeableConcept? Stereochemistry
{
get { return _stereochemistry; }
set {
_stereochemistry= value;
OnPropertyChanged("stereochemistry", value);
}
}

public CodeableConcept? OpticalActivity
{
get { return _opticalActivity; }
set {
_opticalActivity= value;
OnPropertyChanged("opticalActivity", value);
}
}

public FhirString? MolecularFormula
{
get { return _molecularFormula; }
set {
_molecularFormula= value;
OnPropertyChanged("molecularFormula", value);
}
}

public FhirString? MolecularFormulaByMoiety
{
get { return _molecularFormulaByMoiety; }
set {
_molecularFormulaByMoiety= value;
OnPropertyChanged("molecularFormulaByMoiety", value);
}
}

public List<CodeableConcept>? Technique
{
get { return _technique; }
set {
_technique= value;
OnPropertyChanged("technique", value);
}
}

public List<ReferenceType>? SourceDocument
{
get { return _sourceDocument; }
set {
_sourceDocument= value;
OnPropertyChanged("sourceDocument", value);
}
}

public List<SubstanceDefinitionStructureRepresentation>? Representation
{
get { return _representation; }
set {
_representation= value;
OnPropertyChanged("representation", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceDefinitionStructure() { }
		public  SubstanceDefinitionStructure(string value) : base(value) { }
		public  SubstanceDefinitionStructure(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceDefinitionCode : BackboneElementType<SubstanceDefinitionCode>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private CodeableConcept? _status;
private FhirDateTime? _statusDate;
private List<Annotation>? _note;
private List<ReferenceType>? _source;

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

public CodeableConcept? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public FhirDateTime? StatusDate
{
get { return _statusDate; }
set {
_statusDate= value;
OnPropertyChanged("statusDate", value);
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

public List<ReferenceType>? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceDefinitionCode() { }
		public  SubstanceDefinitionCode(string value) : base(value) { }
		public  SubstanceDefinitionCode(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceDefinitionNameOfficial : BackboneElementType<SubstanceDefinitionNameOfficial>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _authority;
private CodeableConcept? _status;
private FhirDateTime? _date;

		#endregion
		#region public Method
		public CodeableConcept? Authority
{
get { return _authority; }
set {
_authority= value;
OnPropertyChanged("authority", value);
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

public FhirDateTime? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceDefinitionNameOfficial() { }
		public  SubstanceDefinitionNameOfficial(string value) : base(value) { }
		public  SubstanceDefinitionNameOfficial(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceDefinitionName : BackboneElementType<SubstanceDefinitionName>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _name;
private CodeableConcept? _type;
private CodeableConcept? _status;
private FhirBoolean? _preferred;
private List<CodeableConcept>? _language;
private List<CodeableConcept>? _domain;
private List<CodeableConcept>? _jurisdiction;
private List<SubstanceDefinitionNameOfficial>? _official;
private List<ReferenceType>? _source;

		#endregion
		#region public Method
		public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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

public FhirBoolean? Preferred
{
get { return _preferred; }
set {
_preferred= value;
OnPropertyChanged("preferred", value);
}
}

public List<CodeableConcept>? Language
{
get { return _language; }
set {
_language= value;
OnPropertyChanged("language", value);
}
}

public List<CodeableConcept>? Domain
{
get { return _domain; }
set {
_domain= value;
OnPropertyChanged("domain", value);
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

public List<SubstanceDefinitionNameOfficial>? Official
{
get { return _official; }
set {
_official= value;
OnPropertyChanged("official", value);
}
}

public List<ReferenceType>? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceDefinitionName() { }
		public  SubstanceDefinitionName(string value) : base(value) { }
		public  SubstanceDefinitionName(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceDefinitionRelationship : BackboneElementType<SubstanceDefinitionRelationship>, IBackboneElementType
	{

		#region Private Method
		private SubstanceDefinitionRelationshipSubstanceDefinitionChoice? _substanceDefinition;
private CodeableConcept? _type;
private FhirBoolean? _isDefining;
private SubstanceDefinitionRelationshipAmountChoice? _amount;
private Ratio? _ratioHighLimitAmount;
private CodeableConcept? _comparator;
private List<ReferenceType>? _source;

		#endregion
		#region public Method
		public SubstanceDefinitionRelationshipSubstanceDefinitionChoice? SubstanceDefinition
{
get { return _substanceDefinition; }
set {
_substanceDefinition= value;
OnPropertyChanged("substanceDefinition", value);
}
}

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirBoolean? IsDefining
{
get { return _isDefining; }
set {
_isDefining= value;
OnPropertyChanged("isDefining", value);
}
}

public SubstanceDefinitionRelationshipAmountChoice? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}

public Ratio? RatioHighLimitAmount
{
get { return _ratioHighLimitAmount; }
set {
_ratioHighLimitAmount= value;
OnPropertyChanged("ratioHighLimitAmount", value);
}
}

public CodeableConcept? Comparator
{
get { return _comparator; }
set {
_comparator= value;
OnPropertyChanged("comparator", value);
}
}

public List<ReferenceType>? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceDefinitionRelationship() { }
		public  SubstanceDefinitionRelationship(string value) : base(value) { }
		public  SubstanceDefinitionRelationship(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceDefinitionSourceMaterial : BackboneElementType<SubstanceDefinitionSourceMaterial>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private CodeableConcept? _genus;
private CodeableConcept? _species;
private CodeableConcept? _part;
private List<CodeableConcept>? _countryOfOrigin;

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

public CodeableConcept? Part
{
get { return _part; }
set {
_part= value;
OnPropertyChanged("part", value);
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


		#endregion
		#region Constructor
		public  SubstanceDefinitionSourceMaterial() { }
		public  SubstanceDefinitionSourceMaterial(string value) : base(value) { }
		public  SubstanceDefinitionSourceMaterial(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class SubstanceDefinitionMoietyAmountChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","string"
        ];

        public SubstanceDefinitionMoietyAmountChoice(JsonObject value) : base("amount", value, _supportType)
        {
        }
        public SubstanceDefinitionMoietyAmountChoice(IComplexType? value) : base("amount", value)
        {
        }
        public SubstanceDefinitionMoietyAmountChoice(IPrimitiveType? value) : base("amount", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"amount".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class SubstanceDefinitionPropertyValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","QuantitydatebooleanAttachment"
        ];

        public SubstanceDefinitionPropertyValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public SubstanceDefinitionPropertyValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public SubstanceDefinitionPropertyValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class SubstanceDefinitionRelationshipSubstanceDefinitionChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(SubstanceDefinition)","CodeableConcept"
        ];

        public SubstanceDefinitionRelationshipSubstanceDefinitionChoice(JsonObject value) : base("substanceDefinition", value, _supportType)
        {
        }
        public SubstanceDefinitionRelationshipSubstanceDefinitionChoice(IComplexType? value) : base("substanceDefinition", value)
        {
        }
        public SubstanceDefinitionRelationshipSubstanceDefinitionChoice(IPrimitiveType? value) : base("substanceDefinition", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"substanceDefinition".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class SubstanceDefinitionRelationshipAmountChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","Ratiostring"
        ];

        public SubstanceDefinitionRelationshipAmountChoice(JsonObject value) : base("amount", value, _supportType)
        {
        }
        public SubstanceDefinitionRelationshipAmountChoice(IComplexType? value) : base("amount", value)
        {
        }
        public SubstanceDefinitionRelationshipAmountChoice(IPrimitiveType? value) : base("amount", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"amount".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
