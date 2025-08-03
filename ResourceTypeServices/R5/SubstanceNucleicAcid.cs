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
    public class SubstanceNucleicAcid : ResourceType<SubstanceNucleicAcid>
	{
		#region private Property
		private CodeableConcept? _sequenceType;
private FhirInteger? _numberOfSubunits;
private FhirString? _areaOfHybridisation;
private CodeableConcept? _oligoNucleotideType;
private List<SubstanceNucleicAcidSubunit>? _subunit;

		#endregion
		#region Public Method
		public CodeableConcept? SequenceType
{
get { return _sequenceType; }
set {
_sequenceType= value;
OnPropertyChanged("sequenceType", value);
}
}

public FhirInteger? NumberOfSubunits
{
get { return _numberOfSubunits; }
set {
_numberOfSubunits= value;
OnPropertyChanged("numberOfSubunits", value);
}
}

public FhirString? AreaOfHybridisation
{
get { return _areaOfHybridisation; }
set {
_areaOfHybridisation= value;
OnPropertyChanged("areaOfHybridisation", value);
}
}

public CodeableConcept? OligoNucleotideType
{
get { return _oligoNucleotideType; }
set {
_oligoNucleotideType= value;
OnPropertyChanged("oligoNucleotideType", value);
}
}

public List<SubstanceNucleicAcidSubunit>? Subunit
{
get { return _subunit; }
set {
_subunit= value;
OnPropertyChanged("subunit", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceNucleicAcid() { }
		public  SubstanceNucleicAcid(string value) : base(value) { }
		public  SubstanceNucleicAcid(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SubstanceNucleicAcidSubunitLinkage : BackboneElementType<SubstanceNucleicAcidSubunitLinkage>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _connectivity;
private Identifier? _identifier;
private FhirString? _name;
private FhirString? _residueSite;

		#endregion
		#region public Method
		public FhirString? Connectivity
{
get { return _connectivity; }
set {
_connectivity= value;
OnPropertyChanged("connectivity", value);
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

public FhirString? ResidueSite
{
get { return _residueSite; }
set {
_residueSite= value;
OnPropertyChanged("residueSite", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceNucleicAcidSubunitLinkage() { }
		public  SubstanceNucleicAcidSubunitLinkage(string value) : base(value) { }
		public  SubstanceNucleicAcidSubunitLinkage(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceNucleicAcidSubunitSugar : BackboneElementType<SubstanceNucleicAcidSubunitSugar>, IBackboneElementType
	{

		#region Private Method
		private Identifier? _identifier;
private FhirString? _name;
private FhirString? _residueSite;

		#endregion
		#region public Method
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

public FhirString? ResidueSite
{
get { return _residueSite; }
set {
_residueSite= value;
OnPropertyChanged("residueSite", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceNucleicAcidSubunitSugar() { }
		public  SubstanceNucleicAcidSubunitSugar(string value) : base(value) { }
		public  SubstanceNucleicAcidSubunitSugar(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstanceNucleicAcidSubunit : BackboneElementType<SubstanceNucleicAcidSubunit>, IBackboneElementType
	{

		#region Private Method
		private FhirInteger? _subunit;
private FhirString? _sequence;
private FhirInteger? _length;
private Attachment? _sequenceAttachment;
private CodeableConcept? _fivePrime;
private CodeableConcept? _threePrime;
private List<SubstanceNucleicAcidSubunitLinkage>? _linkage;
private List<SubstanceNucleicAcidSubunitSugar>? _sugar;

		#endregion
		#region public Method
		public FhirInteger? Subunit
{
get { return _subunit; }
set {
_subunit= value;
OnPropertyChanged("subunit", value);
}
}

public FhirString? Sequence
{
get { return _sequence; }
set {
_sequence= value;
OnPropertyChanged("sequence", value);
}
}

public FhirInteger? Length
{
get { return _length; }
set {
_length= value;
OnPropertyChanged("length", value);
}
}

public Attachment? SequenceAttachment
{
get { return _sequenceAttachment; }
set {
_sequenceAttachment= value;
OnPropertyChanged("sequenceAttachment", value);
}
}

public CodeableConcept? FivePrime
{
get { return _fivePrime; }
set {
_fivePrime= value;
OnPropertyChanged("fivePrime", value);
}
}

public CodeableConcept? ThreePrime
{
get { return _threePrime; }
set {
_threePrime= value;
OnPropertyChanged("threePrime", value);
}
}

public List<SubstanceNucleicAcidSubunitLinkage>? Linkage
{
get { return _linkage; }
set {
_linkage= value;
OnPropertyChanged("linkage", value);
}
}

public List<SubstanceNucleicAcidSubunitSugar>? Sugar
{
get { return _sugar; }
set {
_sugar= value;
OnPropertyChanged("sugar", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceNucleicAcidSubunit() { }
		public  SubstanceNucleicAcidSubunit(string value) : base(value) { }
		public  SubstanceNucleicAcidSubunit(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
