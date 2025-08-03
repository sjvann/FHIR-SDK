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
    /// FHIR R4 Subscription 資源
    /// 
    /// <para>
    /// The subscription resource is used to define a push-based subscription from a server to another system. Once a subscription is registered with the server, the server checks every resource that is created or updated, and if the resource matches the given criteria, it sends a message on the defined "channel" so that another system can take an appropriate action.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var subscription = new Subscription("subscription-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Subscription 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Subscription : ResourceBase<R4Version>
    {
        private BackboneElement? _channel;

        /// <summary>
        /// channel
        /// </summary>
        /// <remarks>
        /// <para>
        /// channel 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? channel
        {
            get => _channel;
            set
            {
                _channel = value;
                OnPropertyChanged(nameof(channel));
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

        private FhirString? _criteria;

        /// <summary>
        /// criteria
        /// </summary>
        /// <remarks>
        /// <para>
        /// criteria 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? criteria
        {
            get => _criteria;
            set
            {
                _criteria = value;
                OnPropertyChanged(nameof(criteria));
            }
        }

        private FhirInstant? _end;

        /// <summary>
        /// end
        /// </summary>
        /// <remarks>
        /// <para>
        /// end 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? end
        {
            get => _end;
            set
            {
                _end = value;
                OnPropertyChanged(nameof(end));
            }
        }

        private FhirString? _error;

        /// <summary>
        /// error
        /// </summary>
        /// <remarks>
        /// <para>
        /// error 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? error
        {
            get => _error;
            set
            {
                _error = value;
                OnPropertyChanged(nameof(error));
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

        private FhirString? _reason;

        /// <summary>
        /// reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// reason 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(reason));
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
        public override string ResourceType => "Subscription";

        /// <summary>
        /// 建立新的 Subscription 資源實例
        /// </summary>
        public Subscription()
        {
        }

        /// <summary>
        /// 建立新的 Subscription 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Subscription(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Subscription(Id: {Id})";
        }
    }
}
