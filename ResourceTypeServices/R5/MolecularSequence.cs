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
    public class MolecularSequence : ResourceType<MolecularSequence>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _type;
private ReferenceType? _subject;
private List<ReferenceType>? _focus;
private ReferenceType? _specimen;
private ReferenceType? _device;
private ReferenceType? _performer;
private FhirString? _literal;
private List<Attachment>? _formatted;
private List<MolecularSequenceRelative>? _relative;

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

public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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

public List<ReferenceType>? Focus
{
get { return _focus; }
set {
_focus= value;
OnPropertyChanged("focus", value);
}
}

public ReferenceType? Specimen
{
get { return _specimen; }
set {
_specimen= value;
OnPropertyChanged("specimen", value);
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

public ReferenceType? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
}
}

public FhirString? Literal
{
get { return _literal; }
set {
_literal= value;
OnPropertyChanged("literal", value);
}
}

public List<Attachment>? Formatted
{
get { return _formatted; }
set {
_formatted= value;
OnPropertyChanged("formatted", value);
}
}

public List<MolecularSequenceRelative>? Relative
{
get { return _relative; }
set {
_relative= value;
OnPropertyChanged("relative", value);
}
}


		#endregion
		#region Constructor
		public  MolecularSequence() { }
		public  MolecularSequence(string value) : base(value) { }
		public  MolecularSequence(JsonNode? source) : base(source) { }
		#endregion
	}
		public class MolecularSequenceRelativeStartingSequence : BackboneElementType<MolecularSequenceRelativeStartingSequence>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _genomeAssembly;
private CodeableConcept? _chromosome;
private MolecularSequenceRelativeStartingSequenceSequenceChoice? _sequence;
private FhirInteger? _windowStart;
private FhirInteger? _windowEnd;
private FhirCode? _orientation;
private FhirCode? _strand;

		#endregion
		#region public Method
		public CodeableConcept? GenomeAssembly
{
get { return _genomeAssembly; }
set {
_genomeAssembly= value;
OnPropertyChanged("genomeAssembly", value);
}
}

public CodeableConcept? Chromosome
{
get { return _chromosome; }
set {
_chromosome= value;
OnPropertyChanged("chromosome", value);
}
}

public MolecularSequenceRelativeStartingSequenceSequenceChoice? Sequence
{
get { return _sequence; }
set {
_sequence= value;
OnPropertyChanged("sequence", value);
}
}

public FhirInteger? WindowStart
{
get { return _windowStart; }
set {
_windowStart= value;
OnPropertyChanged("windowStart", value);
}
}

public FhirInteger? WindowEnd
{
get { return _windowEnd; }
set {
_windowEnd= value;
OnPropertyChanged("windowEnd", value);
}
}

public FhirCode? Orientation
{
get { return _orientation; }
set {
_orientation= value;
OnPropertyChanged("orientation", value);
}
}

public FhirCode? Strand
{
get { return _strand; }
set {
_strand= value;
OnPropertyChanged("strand", value);
}
}


		#endregion
		#region Constructor
		public  MolecularSequenceRelativeStartingSequence() { }
		public  MolecularSequenceRelativeStartingSequence(string value) : base(value) { }
		public  MolecularSequenceRelativeStartingSequence(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MolecularSequenceRelativeEdit : BackboneElementType<MolecularSequenceRelativeEdit>, IBackboneElementType
	{

		#region Private Method
		private FhirInteger? _start;
private FhirInteger? _end;
private FhirString? _replacementSequence;
private FhirString? _replacedSequence;

		#endregion
		#region public Method
		public FhirInteger? Start
{
get { return _start; }
set {
_start= value;
OnPropertyChanged("start", value);
}
}

public FhirInteger? End
{
get { return _end; }
set {
_end= value;
OnPropertyChanged("end", value);
}
}

public FhirString? ReplacementSequence
{
get { return _replacementSequence; }
set {
_replacementSequence= value;
OnPropertyChanged("replacementSequence", value);
}
}

public FhirString? ReplacedSequence
{
get { return _replacedSequence; }
set {
_replacedSequence= value;
OnPropertyChanged("replacedSequence", value);
}
}


		#endregion
		#region Constructor
		public  MolecularSequenceRelativeEdit() { }
		public  MolecularSequenceRelativeEdit(string value) : base(value) { }
		public  MolecularSequenceRelativeEdit(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MolecularSequenceRelative : BackboneElementType<MolecularSequenceRelative>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _coordinateSystem;
private FhirInteger? _ordinalPosition;
private Range? _sequenceRange;
private MolecularSequenceRelativeStartingSequence? _startingSequence;
private List<MolecularSequenceRelativeEdit>? _edit;

		#endregion
		#region public Method
		public CodeableConcept? CoordinateSystem
{
get { return _coordinateSystem; }
set {
_coordinateSystem= value;
OnPropertyChanged("coordinateSystem", value);
}
}

public FhirInteger? OrdinalPosition
{
get { return _ordinalPosition; }
set {
_ordinalPosition= value;
OnPropertyChanged("ordinalPosition", value);
}
}

public Range? SequenceRange
{
get { return _sequenceRange; }
set {
_sequenceRange= value;
OnPropertyChanged("sequenceRange", value);
}
}

public MolecularSequenceRelativeStartingSequence? StartingSequence
{
get { return _startingSequence; }
set {
_startingSequence= value;
OnPropertyChanged("startingSequence", value);
}
}

public List<MolecularSequenceRelativeEdit>? Edit
{
get { return _edit; }
set {
_edit= value;
OnPropertyChanged("edit", value);
}
}


		#endregion
		#region Constructor
		public  MolecularSequenceRelative() { }
		public  MolecularSequenceRelative(string value) : base(value) { }
		public  MolecularSequenceRelative(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class MolecularSequenceRelativeStartingSequenceSequenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","stringReference(MolecularSequence)"
        ];

        public MolecularSequenceRelativeStartingSequenceSequenceChoice(JsonObject value) : base("sequence", value, _supportType)
        {
        }
        public MolecularSequenceRelativeStartingSequenceSequenceChoice(IComplexType? value) : base("sequence", value)
        {
        }
        public MolecularSequenceRelativeStartingSequenceSequenceChoice(IPrimitiveType? value) : base("sequence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"sequence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
