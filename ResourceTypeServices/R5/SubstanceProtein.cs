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
    public class SubstanceProtein : ResourceType<SubstanceProtein>
	{
		#region private Property
		private CodeableConcept? _sequenceType;
private FhirInteger? _numberOfSubunits;
private List<FhirString>? _disulfideLinkage;
private List<SubstanceProteinSubunit>? _subunit;

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

public List<FhirString>? DisulfideLinkage
{
get { return _disulfideLinkage; }
set {
_disulfideLinkage= value;
OnPropertyChanged("disulfideLinkage", value);
}
}

public List<SubstanceProteinSubunit>? Subunit
{
get { return _subunit; }
set {
_subunit= value;
OnPropertyChanged("subunit", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceProtein() { }
		public  SubstanceProtein(string value) : base(value) { }
		public  SubstanceProtein(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SubstanceProteinSubunit : BackboneElementType<SubstanceProteinSubunit>, IBackboneElementType
	{

		#region Private Method
		private FhirInteger? _subunit;
private FhirString? _sequence;
private FhirInteger? _length;
private Attachment? _sequenceAttachment;
private Identifier? _nTerminalModificationId;
private FhirString? _nTerminalModification;
private Identifier? _cTerminalModificationId;
private FhirString? _cTerminalModification;

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

public Identifier? NTerminalModificationId
{
get { return _nTerminalModificationId; }
set {
_nTerminalModificationId= value;
OnPropertyChanged("nTerminalModificationId", value);
}
}

public FhirString? NTerminalModification
{
get { return _nTerminalModification; }
set {
_nTerminalModification= value;
OnPropertyChanged("nTerminalModification", value);
}
}

public Identifier? CTerminalModificationId
{
get { return _cTerminalModificationId; }
set {
_cTerminalModificationId= value;
OnPropertyChanged("cTerminalModificationId", value);
}
}

public FhirString? CTerminalModification
{
get { return _cTerminalModification; }
set {
_cTerminalModification= value;
OnPropertyChanged("cTerminalModification", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceProteinSubunit() { }
		public  SubstanceProteinSubunit(string value) : base(value) { }
		public  SubstanceProteinSubunit(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
