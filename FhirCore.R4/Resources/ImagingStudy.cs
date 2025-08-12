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
    /// FHIR R4 ImagingStudy 資源
    /// 
    /// <para>
    /// Representation of the content produced in a DICOM imaging study. A study comprises a set of series, each of which includes a set of Service-Object Pair Instances (SOP Instances - images or other data) acquired or produced in a common context.  A series is of only one modality (e.g. X-ray, CT, MR, ultrasound), but a study may have multiple series of different modalities.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var imagingstudy = new ImagingStudy("imagingstudy-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 ImagingStudy 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ImagingStudy : ResourceBase<R4Version>
    {
        private List<ReferenceType>? _basedon;

        /// <summary>
        /// basedOn
        /// </summary>
        /// <remarks>
        /// <para>
        /// basedOn 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? basedOn
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(basedOn));
            }
        }

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

        private FhirString? _description;

        /// <summary>
        /// description
        /// </summary>
        /// <remarks>
        /// <para>
        /// description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(description));
            }
        }

        private ReferenceType? _encounter;

        /// <summary>
        /// encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(encounter));
            }
        }

        private List<ReferenceType>? _endpoint;

        /// <summary>
        /// endpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// endpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(endpoint));
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

        private List<ReferenceType>? _interpreter;

        /// <summary>
        /// interpreter
        /// </summary>
        /// <remarks>
        /// <para>
        /// interpreter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? interpreter
        {
            get => _interpreter;
            set
            {
                _interpreter = value;
                OnPropertyChanged(nameof(interpreter));
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

        private ReferenceType? _location;

        /// <summary>
        /// location
        /// </summary>
        /// <remarks>
        /// <para>
        /// location 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(location));
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

        private List<Coding>? _modality;

        /// <summary>
        /// modality
        /// </summary>
        /// <remarks>
        /// <para>
        /// modality 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? modality
        {
            get => _modality;
            set
            {
                _modality = value;
                OnPropertyChanged(nameof(modality));
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

        private List<Annotation>? _note;

        /// <summary>
        /// note
        /// </summary>
        /// <remarks>
        /// <para>
        /// note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(note));
            }
        }

        private FhirUnsignedInt? _numberofinstances;

        /// <summary>
        /// numberOfInstances
        /// </summary>
        /// <remarks>
        /// <para>
        /// numberOfInstances 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? numberOfInstances
        {
            get => _numberofinstances;
            set
            {
                _numberofinstances = value;
                OnPropertyChanged(nameof(numberOfInstances));
            }
        }

        private FhirUnsignedInt? _numberofseries;

        /// <summary>
        /// numberOfSeries
        /// </summary>
        /// <remarks>
        /// <para>
        /// numberOfSeries 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? numberOfSeries
        {
            get => _numberofseries;
            set
            {
                _numberofseries = value;
                OnPropertyChanged(nameof(numberOfSeries));
            }
        }

        private List<CodeableConcept>? _procedurecode;

        /// <summary>
        /// procedureCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// procedureCode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? procedureCode
        {
            get => _procedurecode;
            set
            {
                _procedurecode = value;
                OnPropertyChanged(nameof(procedureCode));
            }
        }

        private ReferenceType? _procedurereference;

        /// <summary>
        /// procedureReference
        /// </summary>
        /// <remarks>
        /// <para>
        /// procedureReference 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? procedureReference
        {
            get => _procedurereference;
            set
            {
                _procedurereference = value;
                OnPropertyChanged(nameof(procedureReference));
            }
        }

        private List<CodeableConcept>? _reasoncode;

        /// <summary>
        /// reasonCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonCode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? reasonCode
        {
            get => _reasoncode;
            set
            {
                _reasoncode = value;
                OnPropertyChanged(nameof(reasonCode));
            }
        }

        private List<ReferenceType>? _reasonreference;

        /// <summary>
        /// reasonReference
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonReference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? reasonReference
        {
            get => _reasonreference;
            set
            {
                _reasonreference = value;
                OnPropertyChanged(nameof(reasonReference));
            }
        }

        private ReferenceType? _referrer;

        /// <summary>
        /// referrer
        /// </summary>
        /// <remarks>
        /// <para>
        /// referrer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? referrer
        {
            get => _referrer;
            set
            {
                _referrer = value;
                OnPropertyChanged(nameof(referrer));
            }
        }

        private List<BackboneElement>? _series;

        /// <summary>
        /// series
        /// </summary>
        /// <remarks>
        /// <para>
        /// series 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? series
        {
            get => _series;
            set
            {
                _series = value;
                OnPropertyChanged(nameof(series));
            }
        }

        private FhirDateTime? _started;

        /// <summary>
        /// started
        /// </summary>
        /// <remarks>
        /// <para>
        /// started 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? started
        {
            get => _started;
            set
            {
                _started = value;
                OnPropertyChanged(nameof(started));
            }
        }

        private FhirCode? _status;

        /// <summary>
        /// status
        /// </summary>
        /// <remarks>
        /// <para>
        /// status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(status));
            }
        }

        private ReferenceType? _subject;

        /// <summary>
        /// subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// subject 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(subject));
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

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ImagingStudy";

        /// <summary>
        /// 建立新的 ImagingStudy 資源實例
        /// </summary>
        public ImagingStudy()
        {
        }

        /// <summary>
        /// 建立新的 ImagingStudy 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ImagingStudy(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ImagingStudy(Id: {Id})";
        }
    }
}
