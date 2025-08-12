using FhirCore.Base;
using FhirCore.R4;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R4.Resources
{
    /// <summary>
    /// FHIR R4 MolecularSequence 資源
    /// 
    /// <para>
    /// Raw data describing a biological sequence.
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
    /// R4 版本的 MolecularSequence 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MolecularSequence : ResourceBase<R4Version>
    {
        private List<FhirString>? _contained;

        /// <summary>
        /// contained
        /// </summary>
        /// <remarks>
        /// <para>
        /// contained 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? contained
        {
            get => _contained;
            set
            {
                _contained = value;
                OnPropertyChanged(nameof(contained));
            }
        }

        private FhirInteger? _coordinatesystem;

        /// <summary>
        /// coordinateSystem
        /// </summary>
        /// <remarks>
        /// <para>
        /// coordinateSystem 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? coordinateSystem
        {
            get => _coordinatesystem;
            set
            {
                _coordinatesystem = value;
                OnPropertyChanged(nameof(coordinateSystem));
            }
        }

        private ReferenceType? _device;

        /// <summary>
        /// device
        /// </summary>
        /// <remarks>
        /// <para>
        /// device 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(device));
            }
        }

        private List<Extension>? _extension;

        /// <summary>
        /// extension
        /// </summary>
        /// <remarks>
        /// <para>
        /// extension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? extension
        {
            get => _extension;
            set
            {
                _extension = value;
                OnPropertyChanged(nameof(extension));
            }
        }

        private FhirString? _id;

        /// <summary>
        /// id
        /// </summary>
        /// <remarks>
        /// <para>
        /// id 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(id));
            }
        }

        private List<Identifier>? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(identifier));
            }
        }

        private FhirUri? _implicitrules;

        /// <summary>
        /// implicitRules
        /// </summary>
        /// <remarks>
        /// <para>
        /// implicitRules 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? implicitRules
        {
            get => _implicitrules;
            set
            {
                _implicitrules = value;
                OnPropertyChanged(nameof(implicitRules));
            }
        }

        private FhirCode? _language;

        /// <summary>
        /// language
        /// </summary>
        /// <remarks>
        /// <para>
        /// language 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(language));
            }
        }

        private Meta? _meta;

        /// <summary>
        /// meta
        /// </summary>
        /// <remarks>
        /// <para>
        /// meta 的詳細描述。
        /// </para>
        /// </remarks>
        public Meta? meta
        {
            get => _meta;
            set
            {
                _meta = value;
                OnPropertyChanged(nameof(meta));
            }
        }

        private List<Extension>? _modifierextension;

        /// <summary>
        /// modifierExtension
        /// </summary>
        /// <remarks>
        /// <para>
        /// modifierExtension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? modifierExtension
        {
            get => _modifierextension;
            set
            {
                _modifierextension = value;
                OnPropertyChanged(nameof(modifierExtension));
            }
        }

        private FhirString? _observedseq;

        /// <summary>
        /// observedSeq
        /// </summary>
        /// <remarks>
        /// <para>
        /// observedSeq 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? observedSeq
        {
            get => _observedseq;
            set
            {
                _observedseq = value;
                OnPropertyChanged(nameof(observedSeq));
            }
        }

        private ReferenceType? _patient;

        /// <summary>
        /// patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// patient 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(patient));
            }
        }

        private ReferenceType? _performer;

        /// <summary>
        /// performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// performer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(performer));
            }
        }

        private List<ReferenceType>? _pointer;

        /// <summary>
        /// pointer
        /// </summary>
        /// <remarks>
        /// <para>
        /// pointer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? pointer
        {
            get => _pointer;
            set
            {
                _pointer = value;
                OnPropertyChanged(nameof(pointer));
            }
        }

        private List<BackboneElement>? _quality;

        /// <summary>
        /// quality
        /// </summary>
        /// <remarks>
        /// <para>
        /// quality 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? quality
        {
            get => _quality;
            set
            {
                _quality = value;
                OnPropertyChanged(nameof(quality));
            }
        }

        private Quantity? _quantity;

        /// <summary>
        /// quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(quantity));
            }
        }

        private FhirInteger? _readcoverage;

        /// <summary>
        /// readCoverage
        /// </summary>
        /// <remarks>
        /// <para>
        /// readCoverage 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? readCoverage
        {
            get => _readcoverage;
            set
            {
                _readcoverage = value;
                OnPropertyChanged(nameof(readCoverage));
            }
        }

        private BackboneElement? _referenceseq;

        /// <summary>
        /// referenceSeq
        /// </summary>
        /// <remarks>
        /// <para>
        /// referenceSeq 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? referenceSeq
        {
            get => _referenceseq;
            set
            {
                _referenceseq = value;
                OnPropertyChanged(nameof(referenceSeq));
            }
        }

        private List<BackboneElement>? _repository;

        /// <summary>
        /// repository
        /// </summary>
        /// <remarks>
        /// <para>
        /// repository 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? repository
        {
            get => _repository;
            set
            {
                _repository = value;
                OnPropertyChanged(nameof(repository));
            }
        }

        private ReferenceType? _specimen;

        /// <summary>
        /// specimen
        /// </summary>
        /// <remarks>
        /// <para>
        /// specimen 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? specimen
        {
            get => _specimen;
            set
            {
                _specimen = value;
                OnPropertyChanged(nameof(specimen));
            }
        }

        private List<BackboneElement>? _structurevariant;

        /// <summary>
        /// structureVariant
        /// </summary>
        /// <remarks>
        /// <para>
        /// structureVariant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? structureVariant
        {
            get => _structurevariant;
            set
            {
                _structurevariant = value;
                OnPropertyChanged(nameof(structureVariant));
            }
        }

        private FhirString? _text;

        /// <summary>
        /// text
        /// </summary>
        /// <remarks>
        /// <para>
        /// text 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged(nameof(text));
            }
        }

        private FhirCode? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        private List<BackboneElement>? _variant;

        /// <summary>
        /// variant
        /// </summary>
        /// <remarks>
        /// <para>
        /// variant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? variant
        {
            get => _variant;
            set
            {
                _variant = value;
                OnPropertyChanged(nameof(variant));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MolecularSequence";

        /// <summary>
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
    }
}
