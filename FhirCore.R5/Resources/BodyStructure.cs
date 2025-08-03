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
    /// FHIR R5 BodyStructure 資源
    /// 
    /// <para>
    /// BodyStructure 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var bodystructure = new BodyStructure("bodystructure-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 BodyStructure 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class BodyStructure : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private CodeableConcept? _morphology;
        private List<BodyStructureIncludedStructure>? _includedstructure;
        private FhirMarkdown? _description;
        private List<Attachment>? _image;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private List<CodeableReference>? _device;
        private List<Quantity>? _value;
        private List<CodeableConcept>? _landmarkdescription;
        private List<CodeableConcept>? _clockfaceposition;
        private List<BodyStructureIncludedStructureBodyLandmarkOrientationDistanceFromLandmark>? _distancefromlandmark;
        private List<CodeableConcept>? _surfaceorientation;
        private CodeableConcept? _structure;
        private CodeableConcept? _laterality;
        private List<BodyStructureIncludedStructureBodyLandmarkOrientation>? _bodylandmarkorientation;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _spatialreference;
        private List<CodeableConcept>? _qualifier;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "BodyStructure";        /// <summary>
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
        /// Active
        /// </summary>
        /// <remarks>
        /// <para>
        /// Active 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Active
        {
            get => _active;
            set
            {
                _active = value;
                OnPropertyChanged(nameof(Active));
            }
        }        /// <summary>
        /// Morphology
        /// </summary>
        /// <remarks>
        /// <para>
        /// Morphology 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Morphology
        {
            get => _morphology;
            set
            {
                _morphology = value;
                OnPropertyChanged(nameof(Morphology));
            }
        }        /// <summary>
        /// Includedstructure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Includedstructure 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BodyStructureIncludedStructure>? Includedstructure
        {
            get => _includedstructure;
            set
            {
                _includedstructure = value;
                OnPropertyChanged(nameof(Includedstructure));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Image
        /// </summary>
        /// <remarks>
        /// <para>
        /// Image 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Attachment>? Image
        {
            get => _image;
            set
            {
                _image = value;
                OnPropertyChanged(nameof(Image));
            }
        }        /// <summary>
        /// Patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patient 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(Patient));
            }
        }        /// <summary>
        /// Device
        /// </summary>
        /// <remarks>
        /// <para>
        /// Device 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Quantity>? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Landmarkdescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// Landmarkdescription 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Landmarkdescription
        {
            get => _landmarkdescription;
            set
            {
                _landmarkdescription = value;
                OnPropertyChanged(nameof(Landmarkdescription));
            }
        }        /// <summary>
        /// Clockfaceposition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Clockfaceposition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Clockfaceposition
        {
            get => _clockfaceposition;
            set
            {
                _clockfaceposition = value;
                OnPropertyChanged(nameof(Clockfaceposition));
            }
        }        /// <summary>
        /// Distancefromlandmark
        /// </summary>
        /// <remarks>
        /// <para>
        /// Distancefromlandmark 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BodyStructureIncludedStructureBodyLandmarkOrientationDistanceFromLandmark>? Distancefromlandmark
        {
            get => _distancefromlandmark;
            set
            {
                _distancefromlandmark = value;
                OnPropertyChanged(nameof(Distancefromlandmark));
            }
        }        /// <summary>
        /// Surfaceorientation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Surfaceorientation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Surfaceorientation
        {
            get => _surfaceorientation;
            set
            {
                _surfaceorientation = value;
                OnPropertyChanged(nameof(Surfaceorientation));
            }
        }        /// <summary>
        /// Structure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Structure 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Structure
        {
            get => _structure;
            set
            {
                _structure = value;
                OnPropertyChanged(nameof(Structure));
            }
        }        /// <summary>
        /// Laterality
        /// </summary>
        /// <remarks>
        /// <para>
        /// Laterality 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Laterality
        {
            get => _laterality;
            set
            {
                _laterality = value;
                OnPropertyChanged(nameof(Laterality));
            }
        }        /// <summary>
        /// Bodylandmarkorientation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodylandmarkorientation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BodyStructureIncludedStructureBodyLandmarkOrientation>? Bodylandmarkorientation
        {
            get => _bodylandmarkorientation;
            set
            {
                _bodylandmarkorientation = value;
                OnPropertyChanged(nameof(Bodylandmarkorientation));
            }
        }        /// <summary>
        /// Spatialreference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Spatialreference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Spatialreference
        {
            get => _spatialreference;
            set
            {
                _spatialreference = value;
                OnPropertyChanged(nameof(Spatialreference));
            }
        }        /// <summary>
        /// Qualifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Qualifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Qualifier
        {
            get => _qualifier;
            set
            {
                _qualifier = value;
                OnPropertyChanged(nameof(Qualifier));
            }
        }        /// <summary>
        /// 建立新的 BodyStructure 資源實例
        /// </summary>
        public BodyStructure()
        {
        }

        /// <summary>
        /// 建立新的 BodyStructure 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public BodyStructure(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"BodyStructure(Id: {Id})";
        }
    }    /// <summary>
    /// BodyStructureIncludedStructureBodyLandmarkOrientationDistanceFromLandmark 背骨元素
    /// </summary>
    public class BodyStructureIncludedStructureBodyLandmarkOrientationDistanceFromLandmark
    {
        // TODO: 添加屬性實作
        
        public BodyStructureIncludedStructureBodyLandmarkOrientationDistanceFromLandmark() { }
    }    /// <summary>
    /// BodyStructureIncludedStructureBodyLandmarkOrientation 背骨元素
    /// </summary>
    public class BodyStructureIncludedStructureBodyLandmarkOrientation
    {
        // TODO: 添加屬性實作
        
        public BodyStructureIncludedStructureBodyLandmarkOrientation() { }
    }    /// <summary>
    /// BodyStructureIncludedStructure 背骨元素
    /// </summary>
    public class BodyStructureIncludedStructure
    {
        // TODO: 添加屬性實作
        
        public BodyStructureIncludedStructure() { }
    }
}
