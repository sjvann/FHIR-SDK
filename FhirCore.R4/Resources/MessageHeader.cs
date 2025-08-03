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
    /// FHIR R4 MessageHeader 資源
    /// 
    /// <para>
    /// The header for a message exchange that is either requesting or responding to an action.  The reference(s) that are the subject of the action as well as other information related to the action are typically transmitted in a bundle in which the MessageHeader resource instance is the first resource in the bundle.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var messageheader = new MessageHeader("messageheader-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MessageHeader 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MessageHeader : ResourceBase<R4Version>
    {
        private ReferenceType? _author;

        /// <summary>
        /// author
        /// </summary>
        /// <remarks>
        /// <para>
        /// author 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(author));
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

        private FhirCanonical? _definition;

        /// <summary>
        /// definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// definition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(definition));
            }
        }

        private List<BackboneElement>? _destination;

        /// <summary>
        /// destination
        /// </summary>
        /// <remarks>
        /// <para>
        /// destination 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? destination
        {
            get => _destination;
            set
            {
                _destination = value;
                OnPropertyChanged(nameof(destination));
            }
        }

        private ReferenceType? _enterer;

        /// <summary>
        /// enterer
        /// </summary>
        /// <remarks>
        /// <para>
        /// enterer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? enterer
        {
            get => _enterer;
            set
            {
                _enterer = value;
                OnPropertyChanged(nameof(enterer));
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

        private List<ReferenceType>? _focus;

        /// <summary>
        /// focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// focus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(focus));
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

        private CodeableConcept? _reason;

        /// <summary>
        /// reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// reason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(reason));
            }
        }

        private BackboneElement? _response;

        /// <summary>
        /// response
        /// </summary>
        /// <remarks>
        /// <para>
        /// response 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? response
        {
            get => _response;
            set
            {
                _response = value;
                OnPropertyChanged(nameof(response));
            }
        }

        private ReferenceType? _responsible;

        /// <summary>
        /// responsible
        /// </summary>
        /// <remarks>
        /// <para>
        /// responsible 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? responsible
        {
            get => _responsible;
            set
            {
                _responsible = value;
                OnPropertyChanged(nameof(responsible));
            }
        }

        private ReferenceType? _sender;

        /// <summary>
        /// sender
        /// </summary>
        /// <remarks>
        /// <para>
        /// sender 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? sender
        {
            get => _sender;
            set
            {
                _sender = value;
                OnPropertyChanged(nameof(sender));
            }
        }

        private BackboneElement? _source;

        /// <summary>
        /// source
        /// </summary>
        /// <remarks>
        /// <para>
        /// source 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(source));
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
        public override string ResourceType => "MessageHeader";

        /// <summary>
        /// 建立新的 MessageHeader 資源實例
        /// </summary>
        public MessageHeader()
        {
        }

        /// <summary>
        /// 建立新的 MessageHeader 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MessageHeader(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MessageHeader(Id: {Id})";
        }
    }
}
