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
    public class SubstanceReferenceInformation : ResourceType<SubstanceReferenceInformation>
	{
		#region private Property
		private FhirString? _comment;
private List<SubstanceReferenceInformationGene>? _gene;
private List<SubstanceReferenceInformationGeneElement>? _geneElement;
private List<SubstanceReferenceInformationTarget>? _target;

		#endregion
		#region Public Method
		public FhirString? Comment
{
get { return _comment; }
set {
_comment= value;
OnPropertyChanged("comment", value);
}
}

public List<SubstanceReferenceInformationGene>? Gene
{
get { return _gene; }
set {
_gene= value;
OnPropertyChanged("gene", value);
}
}

public List<SubstanceReferenceInformationGeneElement>? GeneElement
{
get { return _geneElement; }
set {
_geneElement= value;
OnPropertyChanged("geneElement", value);
}
}

public List<SubstanceReferenceInformationTarget>? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceReferenceInformation() { }
		public  SubstanceReferenceInformation(string value) : base(value) { }
		public  SubstanceReferenceInformation(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SubstanceReferenceInformationGene : BackboneElementType<SubstanceReferenceInformationGene>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _geneSequenceOrigin;
private CodeableConcept? _gene;
private List<ReferenceType>? _source;

		#endregion
		#region public Method
		public CodeableConcept? GeneSequenceOrigin
{
get { return _geneSequenceOrigin; }
set {
_geneSequenceOrigin= value;
OnPropertyChanged("geneSequenceOrigin", value);
}
}

public CodeableConcept? Gene
{
get { return _gene; }
set {
_gene= value;
OnPropertyChanged("gene", value);
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
		public  SubstanceReferenceInformationGene() { }
		public  SubstanceReferenceInformationGene(string value) : base(value) { }
		public  SubstanceReferenceInformationGene(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceReferenceInformationGeneElement : BackboneElementType<SubstanceReferenceInformationGeneElement>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private Identifier? _element;
private List<ReferenceType>? _source;

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

public Identifier? Element
{
get { return _element; }
set {
_element= value;
OnPropertyChanged("element", value);
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
		public  SubstanceReferenceInformationGeneElement() { }
		public  SubstanceReferenceInformationGeneElement(string value) : base(value) { }
		public  SubstanceReferenceInformationGeneElement(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceReferenceInformationTarget : BackboneElementType<SubstanceReferenceInformationTarget>, IBackboneElementType
	{

		#region Private Method
		private Identifier? _target;
private CodeableConcept? _type;
private CodeableConcept? _interaction;
private CodeableConcept? _organism;
private CodeableConcept? _organismType;
private SubstanceReferenceInformationTargetAmountChoice? _amount;
private CodeableConcept? _amountType;
private List<ReferenceType>? _source;

		#endregion
		#region public Method
		public Identifier? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
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

public CodeableConcept? Interaction
{
get { return _interaction; }
set {
_interaction= value;
OnPropertyChanged("interaction", value);
}
}

public CodeableConcept? Organism
{
get { return _organism; }
set {
_organism= value;
OnPropertyChanged("organism", value);
}
}

public CodeableConcept? OrganismType
{
get { return _organismType; }
set {
_organismType= value;
OnPropertyChanged("organismType", value);
}
}

public SubstanceReferenceInformationTargetAmountChoice? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}

public CodeableConcept? AmountType
{
get { return _amountType; }
set {
_amountType= value;
OnPropertyChanged("amountType", value);
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
		public  SubstanceReferenceInformationTarget() { }
		public  SubstanceReferenceInformationTarget(string value) : base(value) { }
		public  SubstanceReferenceInformationTarget(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class SubstanceReferenceInformationTargetAmountChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","Rangestring"
        ];

        public SubstanceReferenceInformationTargetAmountChoice(JsonObject value) : base("amount", value, _supportType)
        {
        }
        public SubstanceReferenceInformationTargetAmountChoice(IComplexType? value) : base("amount", value)
        {
        }
        public SubstanceReferenceInformationTargetAmountChoice(IPrimitiveType? value) : base("amount", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"amount".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
