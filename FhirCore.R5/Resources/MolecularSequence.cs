using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 MolecularSequence 資源
    /// 
    /// <para>
    /// MolecularSequence 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var molecularsequence = new MolecularSequence("molecularsequence-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 MolecularSequence 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MolecularSequence : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _focus;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _specimen;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _device;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _performer;
        private FhirString? _literal;
        private List<Attachment>? _formatted;
        private List<MolecularSequenceRelative>? _relative;
        private CodeableConcept? _genomeassembly;
        private CodeableConcept? _chromosome;
        private MolecularSequenceRelativeStartingSequenceSequenceChoice? _sequence;
        private FhirInteger? _windowstart;
        private FhirInteger? _windowend;
        private FhirCode? _orientation;
        private FhirCode? _strand;
        private FhirInteger? _start;
        private FhirInteger? _end;
        private FhirString? _replacementsequence;
        private FhirString? _replacedsequence;
        private CodeableConcept? _coordinatesystem;
        private FhirInteger? _ordinalposition;
        private Range? _sequencerange;
        private MolecularSequenceRelativeStartingSequence? _startingsequence;
        private List<MolecularSequenceRelativeEdit>? _edit;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MolecularSequence";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(Focus));
            }
        }        /// <summary>
        /// Specimen
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specimen 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Specimen
        {
            get => _specimen;
            set
            {
                _specimen = value;
                OnPropertyChanged(nameof(Specimen));
            }
        }        /// <summary>
        /// Device
        /// </summary>
        /// <remarks>
        /// <para>
        /// Device 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }        /// <summary>
        /// Literal
        /// </summary>
        /// <remarks>
        /// <para>
        /// Literal 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Literal
        {
            get => _literal;
            set
            {
                _literal = value;
                OnPropertyChanged(nameof(Literal));
            }
        }        /// <summary>
        /// Formatted
        /// </summary>
        /// <remarks>
        /// <para>
        /// Formatted 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Attachment>? Formatted
        {
            get => _formatted;
            set
            {
                _formatted = value;
                OnPropertyChanged(nameof(Formatted));
            }
        }        /// <summary>
        /// Relative
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relative 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MolecularSequenceRelative>? Relative
        {
            get => _relative;
            set
            {
                _relative = value;
                OnPropertyChanged(nameof(Relative));
            }
        }        /// <summary>
        /// Genomeassembly
        /// </summary>
        /// <remarks>
        /// <para>
        /// Genomeassembly 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Genomeassembly
        {
            get => _genomeassembly;
            set
            {
                _genomeassembly = value;
                OnPropertyChanged(nameof(Genomeassembly));
            }
        }        /// <summary>
        /// Chromosome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Chromosome 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Chromosome
        {
            get => _chromosome;
            set
            {
                _chromosome = value;
                OnPropertyChanged(nameof(Chromosome));
            }
        }        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequence 的詳細描述。
        /// </para>
        /// </remarks>
        public MolecularSequenceRelativeStartingSequenceSequenceChoice? Sequence
        {
            get => _sequence;
            set
            {
                _sequence = value;
                OnPropertyChanged(nameof(Sequence));
            }
        }        /// <summary>
        /// Windowstart
        /// </summary>
        /// <remarks>
        /// <para>
        /// Windowstart 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Windowstart
        {
            get => _windowstart;
            set
            {
                _windowstart = value;
                OnPropertyChanged(nameof(Windowstart));
            }
        }        /// <summary>
        /// Windowend
        /// </summary>
        /// <remarks>
        /// <para>
        /// Windowend 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Windowend
        {
            get => _windowend;
            set
            {
                _windowend = value;
                OnPropertyChanged(nameof(Windowend));
            }
        }        /// <summary>
        /// Orientation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Orientation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Orientation
        {
            get => _orientation;
            set
            {
                _orientation = value;
                OnPropertyChanged(nameof(Orientation));
            }
        }        /// <summary>
        /// Strand
        /// </summary>
        /// <remarks>
        /// <para>
        /// Strand 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Strand
        {
            get => _strand;
            set
            {
                _strand = value;
                OnPropertyChanged(nameof(Strand));
            }
        }        /// <summary>
        /// Start
        /// </summary>
        /// <remarks>
        /// <para>
        /// Start 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Start
        {
            get => _start;
            set
            {
                _start = value;
                OnPropertyChanged(nameof(Start));
            }
        }        /// <summary>
        /// End
        /// </summary>
        /// <remarks>
        /// <para>
        /// End 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? End
        {
            get => _end;
            set
            {
                _end = value;
                OnPropertyChanged(nameof(End));
            }
        }        /// <summary>
        /// Replacementsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Replacementsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Replacementsequence
        {
            get => _replacementsequence;
            set
            {
                _replacementsequence = value;
                OnPropertyChanged(nameof(Replacementsequence));
            }
        }        /// <summary>
        /// Replacedsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Replacedsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Replacedsequence
        {
            get => _replacedsequence;
            set
            {
                _replacedsequence = value;
                OnPropertyChanged(nameof(Replacedsequence));
            }
        }        /// <summary>
        /// Coordinatesystem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Coordinatesystem 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Coordinatesystem
        {
            get => _coordinatesystem;
            set
            {
                _coordinatesystem = value;
                OnPropertyChanged(nameof(Coordinatesystem));
            }
        }        /// <summary>
        /// Ordinalposition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Ordinalposition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Ordinalposition
        {
            get => _ordinalposition;
            set
            {
                _ordinalposition = value;
                OnPropertyChanged(nameof(Ordinalposition));
            }
        }        /// <summary>
        /// Sequencerange
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequencerange 的詳細描述。
        /// </para>
        /// </remarks>
        public Range? Sequencerange
        {
            get => _sequencerange;
            set
            {
                _sequencerange = value;
                OnPropertyChanged(nameof(Sequencerange));
            }
        }        /// <summary>
        /// Startingsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Startingsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public MolecularSequenceRelativeStartingSequence? Startingsequence
        {
            get => _startingsequence;
            set
            {
                _startingsequence = value;
                OnPropertyChanged(nameof(Startingsequence));
            }
        }        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Edit 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MolecularSequenceRelativeEdit>? Edit
        {
            get => _edit;
            set
            {
                _edit = value;
                OnPropertyChanged(nameof(Edit));
            }
        }        /// <summary>
        /// 建立新的 MolecularSequence 資源實例
        /// </summary>
        public MolecularSequence()
        {
        }

        /// <summary>
        /// 建立新的 MolecularSequence 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MolecularSequence(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MolecularSequence(Id: {Id})";
        }
    }    /// <summary>
    /// MolecularSequenceRelativeStartingSequence 背骨元素
    /// </summary>
    public class MolecularSequenceRelativeStartingSequence
    {
        // TODO: 添加屬性實作
        
        public MolecularSequenceRelativeStartingSequence() { }
    }    /// <summary>
    /// MolecularSequenceRelativeEdit 背骨元素
    /// </summary>
    public class MolecularSequenceRelativeEdit
    {
        // TODO: 添加屬性實作
        
        public MolecularSequenceRelativeEdit() { }
    }    /// <summary>
    /// MolecularSequenceRelative 背骨元素
    /// </summary>
    public class MolecularSequenceRelative
    {
        // TODO: 添加屬性實作
        
        public MolecularSequenceRelative() { }
    }    /// <summary>
    /// MolecularSequenceRelativeStartingSequenceSequenceChoice 選擇類型
    /// </summary>
    public class MolecularSequenceRelativeStartingSequenceSequenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MolecularSequenceRelativeStartingSequenceSequenceChoice(JsonObject value) : base("molecularsequencerelativestartingsequencesequence", value, _supportType) { }
        public MolecularSequenceRelativeStartingSequenceSequenceChoice(IComplexType? value) : base("molecularsequencerelativestartingsequencesequence", value) { }
        public MolecularSequenceRelativeStartingSequenceSequenceChoice(IPrimitiveType? value) : base("molecularsequencerelativestartingsequencesequence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MolecularSequenceRelativeStartingSequenceSequence" : "molecularsequencerelativestartingsequencesequence";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
