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
    /// FHIR R5 Endpoint 資源
    /// 
    /// <para>
    /// Endpoint 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 Endpoint 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Endpoint : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<CodeableConcept>? _connectiontype;
        private FhirString? _name;
        private FhirString? _description;
        private List<CodeableConcept>? _environmenttype;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _managingorganization;
        private List<ContactPoint>? _contact;
        private Period? _period;
        private List<EndpointPayload>? _payload;
        private FhirUrl? _address;
        private List<FhirString>? _header;
        private List<CodeableConcept>? _type;
        private List<FhirCode>? _mimetype;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Endpoint";        /// <summary>
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
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Connectiontype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Connectiontype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Connectiontype
        {
            get => _connectiontype;
            set
            {
                _connectiontype = value;
                OnPropertyChanged(nameof(Connectiontype));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Environmenttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Environmenttype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Environmenttype
        {
            get => _environmenttype;
            set
            {
                _environmenttype = value;
                OnPropertyChanged(nameof(Environmenttype));
            }
        }        /// <summary>
        /// Managingorganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Managingorganization 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Managingorganization
        {
            get => _managingorganization;
            set
            {
                _managingorganization = value;
                OnPropertyChanged(nameof(Managingorganization));
            }
        }        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactPoint>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Payload
        /// </summary>
        /// <remarks>
        /// <para>
        /// Payload 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EndpointPayload>? Payload
        {
            get => _payload;
            set
            {
                _payload = value;
                OnPropertyChanged(nameof(Payload));
            }
        }        /// <summary>
        /// Address
        /// </summary>
        /// <remarks>
        /// <para>
        /// Address 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUrl? Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }        /// <summary>
        /// Header
        /// </summary>
        /// <remarks>
        /// <para>
        /// Header 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Header
        {
            get => _header;
            set
            {
                _header = value;
                OnPropertyChanged(nameof(Header));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Mimetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mimetype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Mimetype
        {
            get => _mimetype;
            set
            {
                _mimetype = value;
                OnPropertyChanged(nameof(Mimetype));
            }
        }        /// <summary>
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
    }    /// <summary>
    /// EndpointPayload 背骨元素
    /// </summary>
    public class EndpointPayload
    {
        // TODO: 添加屬性實作
        
        public EndpointPayload() { }
    }
}
