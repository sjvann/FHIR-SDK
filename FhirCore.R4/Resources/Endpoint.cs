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
    /// FHIR R4 Endpoint 資源
    /// 
    /// <para>
    /// The technical details of an endpoint that can be used for electronic services, such as for web services providing XDS.b or a REST endpoint for another FHIR server. This may include any security context information.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var endpoint = new Endpoint("endpoint-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Endpoint 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Endpoint : ResourceBase<R4Version>
    {
        private FhirUrl? _address;

        /// <summary>
        /// address
        /// </summary>
        /// <remarks>
        /// <para>
        /// address 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUrl? address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(address));
            }
        }

        private Coding? _connectiontype;

        /// <summary>
        /// connectionType
        /// </summary>
        /// <remarks>
        /// <para>
        /// connectionType 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? connectionType
        {
            get => _connectiontype;
            set
            {
                _connectiontype = value;
                OnPropertyChanged(nameof(connectionType));
            }
        }

        private List<ContactPoint>? _contact;

        /// <summary>
        /// contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactPoint>? contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(contact));
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

        private List<FhirString>? _header;

        /// <summary>
        /// header
        /// </summary>
        /// <remarks>
        /// <para>
        /// header 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? header
        {
            get => _header;
            set
            {
                _header = value;
                OnPropertyChanged(nameof(header));
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

        private ReferenceType? _managingorganization;

        /// <summary>
        /// managingOrganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// managingOrganization 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? managingOrganization
        {
            get => _managingorganization;
            set
            {
                _managingorganization = value;
                OnPropertyChanged(nameof(managingOrganization));
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

        private FhirString? _name;

        /// <summary>
        /// name
        /// </summary>
        /// <remarks>
        /// <para>
        /// name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(name));
            }
        }

        private List<FhirCode>? _payloadmimetype;

        /// <summary>
        /// payloadMimeType
        /// </summary>
        /// <remarks>
        /// <para>
        /// payloadMimeType 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? payloadMimeType
        {
            get => _payloadmimetype;
            set
            {
                _payloadmimetype = value;
                OnPropertyChanged(nameof(payloadMimeType));
            }
        }

        private List<CodeableConcept>? _payloadtype;

        /// <summary>
        /// payloadType
        /// </summary>
        /// <remarks>
        /// <para>
        /// payloadType 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? payloadType
        {
            get => _payloadtype;
            set
            {
                _payloadtype = value;
                OnPropertyChanged(nameof(payloadType));
            }
        }

        private Period? _period;

        /// <summary>
        /// period
        /// </summary>
        /// <remarks>
        /// <para>
        /// period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(period));
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
        public override string ResourceType => "Endpoint";

        /// <summary>
        /// 建立新的 Endpoint 資源實例
        /// </summary>
        public Endpoint()
        {
        }

        /// <summary>
        /// 建立新的 Endpoint 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Endpoint(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Endpoint(Id: {Id})";
        }
    }
}
