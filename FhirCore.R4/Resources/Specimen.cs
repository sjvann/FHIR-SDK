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
    /// FHIR R4 Specimen 資源
    /// 
    /// <para>
    /// A sample to be used for analysis.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var specimen = new Specimen("specimen-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Specimen 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Specimen : ResourceBase<R4Version>
    {
        private Identifier? _accessionidentifier;

        /// <summary>
        /// accessionIdentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// accessionIdentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? accessionIdentifier
        {
            get => _accessionidentifier;
            set
            {
                _accessionidentifier = value;
                OnPropertyChanged(nameof(accessionIdentifier));
            }
        }

        private BackboneElement? _collection;

        /// <summary>
        /// collection
        /// </summary>
        /// <remarks>
        /// <para>
        /// collection 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? collection
        {
            get => _collection;
            set
            {
                _collection = value;
                OnPropertyChanged(nameof(collection));
            }
        }

        private List<CodeableConcept>? _condition;

        /// <summary>
        /// condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// condition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? condition
        {
            get => _condition;
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(condition));
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

        private List<BackboneElement>? _container;

        /// <summary>
        /// container
        /// </summary>
        /// <remarks>
        /// <para>
        /// container 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? container
        {
            get => _container;
            set
            {
                _container = value;
                OnPropertyChanged(nameof(container));
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

        private List<ReferenceType>? _parent;

        /// <summary>
        /// parent
        /// </summary>
        /// <remarks>
        /// <para>
        /// parent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? parent
        {
            get => _parent;
            set
            {
                _parent = value;
                OnPropertyChanged(nameof(parent));
            }
        }

        private List<BackboneElement>? _processing;

        /// <summary>
        /// processing
        /// </summary>
        /// <remarks>
        /// <para>
        /// processing 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? processing
        {
            get => _processing;
            set
            {
                _processing = value;
                OnPropertyChanged(nameof(processing));
            }
        }

        private FhirDateTime? _receivedtime;

        /// <summary>
        /// receivedTime
        /// </summary>
        /// <remarks>
        /// <para>
        /// receivedTime 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? receivedTime
        {
            get => _receivedtime;
            set
            {
                _receivedtime = value;
                OnPropertyChanged(nameof(receivedTime));
            }
        }

        private List<ReferenceType>? _request;

        /// <summary>
        /// request
        /// </summary>
        /// <remarks>
        /// <para>
        /// request 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(request));
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

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Specimen";

        /// <summary>
        /// 建立新的 Specimen 資源實例
        /// </summary>
        public Specimen()
        {
        }

        /// <summary>
        /// 建立新的 Specimen 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Specimen(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Specimen(Id: {Id})";
        }
    }
}
