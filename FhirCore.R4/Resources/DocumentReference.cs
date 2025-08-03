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
    /// FHIR R4 DocumentReference 資源
    /// 
    /// <para>
    /// A reference to a document of any kind for any purpose. Provides metadata about the document so that the document can be discovered and managed. The scope of a document is any seralized object with a mime-type, so includes formal patient centric documents (CDA), cliical notes, scanned paper, and non-patient specific documents like policy text.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var documentreference = new DocumentReference("documentreference-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 DocumentReference 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DocumentReference : ResourceBase<R4Version>
    {
        private ReferenceType? _authenticator;

        /// <summary>
        /// authenticator
        /// </summary>
        /// <remarks>
        /// <para>
        /// authenticator 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? authenticator
        {
            get => _authenticator;
            set
            {
                _authenticator = value;
                OnPropertyChanged(nameof(authenticator));
            }
        }

        private List<ReferenceType>? _author;

        /// <summary>
        /// author
        /// </summary>
        /// <remarks>
        /// <para>
        /// author 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(author));
            }
        }

        private List<CodeableConcept>? _category;

        /// <summary>
        /// category
        /// </summary>
        /// <remarks>
        /// <para>
        /// category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(category));
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

        private List<BackboneElement>? _content;

        /// <summary>
        /// content
        /// </summary>
        /// <remarks>
        /// <para>
        /// content 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(content));
            }
        }

        private BackboneElement? _context;

        /// <summary>
        /// context
        /// </summary>
        /// <remarks>
        /// <para>
        /// context 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(context));
            }
        }

        private ReferenceType? _custodian;

        /// <summary>
        /// custodian
        /// </summary>
        /// <remarks>
        /// <para>
        /// custodian 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? custodian
        {
            get => _custodian;
            set
            {
                _custodian = value;
                OnPropertyChanged(nameof(custodian));
            }
        }

        private FhirInstant? _date;

        /// <summary>
        /// date
        /// </summary>
        /// <remarks>
        /// <para>
        /// date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(date));
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

        private FhirCode? _docstatus;

        /// <summary>
        /// docStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// docStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? docStatus
        {
            get => _docstatus;
            set
            {
                _docstatus = value;
                OnPropertyChanged(nameof(docStatus));
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

        private Identifier? _masteridentifier;

        /// <summary>
        /// masterIdentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// masterIdentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? masterIdentifier
        {
            get => _masteridentifier;
            set
            {
                _masteridentifier = value;
                OnPropertyChanged(nameof(masterIdentifier));
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

        private List<BackboneElement>? _relatesto;

        /// <summary>
        /// relatesTo
        /// </summary>
        /// <remarks>
        /// <para>
        /// relatesTo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? relatesTo
        {
            get => _relatesto;
            set
            {
                _relatesto = value;
                OnPropertyChanged(nameof(relatesTo));
            }
        }

        private List<CodeableConcept>? _securitylabel;

        /// <summary>
        /// securityLabel
        /// </summary>
        /// <remarks>
        /// <para>
        /// securityLabel 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? securityLabel
        {
            get => _securitylabel;
            set
            {
                _securitylabel = value;
                OnPropertyChanged(nameof(securityLabel));
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
        public override string ResourceType => "DocumentReference";

        /// <summary>
        /// 建立新的 DocumentReference 資源實例
        /// </summary>
        public DocumentReference()
        {
        }

        /// <summary>
        /// 建立新的 DocumentReference 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public DocumentReference(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"DocumentReference(Id: {Id})";
        }
    }
}
