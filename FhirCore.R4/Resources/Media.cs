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
    /// FHIR R4 Media 資源
    /// 
    /// <para>
    /// A photo, video, or audio recording acquired or used in healthcare. The actual content may be inline or provided by direct reference.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var media = new Media("media-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Media 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Media : ResourceBase<R4Version>
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

        private CodeableConcept? _bodysite;

        /// <summary>
        /// bodySite
        /// </summary>
        /// <remarks>
        /// <para>
        /// bodySite 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? bodySite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(bodySite));
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

        private Attachment? _content;

        /// <summary>
        /// content
        /// </summary>
        /// <remarks>
        /// <para>
        /// content 的詳細描述。
        /// </para>
        /// </remarks>
        public Attachment? content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(content));
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

        private FhirString? _devicename;

        /// <summary>
        /// deviceName
        /// </summary>
        /// <remarks>
        /// <para>
        /// deviceName 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? deviceName
        {
            get => _devicename;
            set
            {
                _devicename = value;
                OnPropertyChanged(nameof(deviceName));
            }
        }

        private FhirDecimal? _duration;

        /// <summary>
        /// duration
        /// </summary>
        /// <remarks>
        /// <para>
        /// duration 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? duration
        {
            get => _duration;
            set
            {
                _duration = value;
                OnPropertyChanged(nameof(duration));
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

        private FhirPositiveInt? _frames;

        /// <summary>
        /// frames
        /// </summary>
        /// <remarks>
        /// <para>
        /// frames 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? frames
        {
            get => _frames;
            set
            {
                _frames = value;
                OnPropertyChanged(nameof(frames));
            }
        }

        private FhirPositiveInt? _height;

        /// <summary>
        /// height
        /// </summary>
        /// <remarks>
        /// <para>
        /// height 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? height
        {
            get => _height;
            set
            {
                _height = value;
                OnPropertyChanged(nameof(height));
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

        private FhirInstant? _issued;

        /// <summary>
        /// issued
        /// </summary>
        /// <remarks>
        /// <para>
        /// issued 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? issued
        {
            get => _issued;
            set
            {
                _issued = value;
                OnPropertyChanged(nameof(issued));
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

        private CodeableConcept? _modality;

        /// <summary>
        /// modality
        /// </summary>
        /// <remarks>
        /// <para>
        /// modality 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? modality
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

        private ReferenceType? _operator;

        /// <summary>
        /// operator
        /// </summary>
        /// <remarks>
        /// <para>
        /// operator 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? operator
        {
            get => _operator;
            set
            {
                _operator = value;
                OnPropertyChanged(nameof(operator));
            }
        }

        private List<ReferenceType>? _partof;

        /// <summary>
        /// partOf
        /// </summary>
        /// <remarks>
        /// <para>
        /// partOf 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? partOf
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(partOf));
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

        private CodeableConcept? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        private CodeableConcept? _view;

        /// <summary>
        /// view
        /// </summary>
        /// <remarks>
        /// <para>
        /// view 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? view
        {
            get => _view;
            set
            {
                _view = value;
                OnPropertyChanged(nameof(view));
            }
        }

        private FhirPositiveInt? _width;

        /// <summary>
        /// width
        /// </summary>
        /// <remarks>
        /// <para>
        /// width 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? width
        {
            get => _width;
            set
            {
                _width = value;
                OnPropertyChanged(nameof(width));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Media";

        /// <summary>
        /// 建立新的 Media 資源實例
        /// </summary>
        public Media()
        {
        }

        /// <summary>
        /// 建立新的 Media 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Media(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Media(Id: {Id})";
        }
    }
}
