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
    /// FHIR R4 Bundle 資源
    /// 
    /// <para>
    /// A container for a collection of resources.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var bundle = new Bundle("bundle-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Bundle 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Bundle : ResourceBase<R4Version>
    {
        private List<BackboneElement>? _entry;

        /// <summary>
        /// entry
        /// </summary>
        /// <remarks>
        /// <para>
        /// entry 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? entry
        {
            get => _entry;
            set
            {
                _entry = value;
                OnPropertyChanged(nameof(entry));
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

        private Identifier? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? identifier
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

        private List<BackboneElement>? _link;

        /// <summary>
        /// link
        /// </summary>
        /// <remarks>
        /// <para>
        /// link 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(link));
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

        private Signature? _signature;

        /// <summary>
        /// signature
        /// </summary>
        /// <remarks>
        /// <para>
        /// signature 的詳細描述。
        /// </para>
        /// </remarks>
        public Signature? signature
        {
            get => _signature;
            set
            {
                _signature = value;
                OnPropertyChanged(nameof(signature));
            }
        }

        private FhirInstant? _timestamp;

        /// <summary>
        /// timestamp
        /// </summary>
        /// <remarks>
        /// <para>
        /// timestamp 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? timestamp
        {
            get => _timestamp;
            set
            {
                _timestamp = value;
                OnPropertyChanged(nameof(timestamp));
            }
        }

        private FhirUnsignedInt? _total;

        /// <summary>
        /// total
        /// </summary>
        /// <remarks>
        /// <para>
        /// total 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? total
        {
            get => _total;
            set
            {
                _total = value;
                OnPropertyChanged(nameof(total));
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

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Bundle";

        /// <summary>
        /// 建立新的 Bundle 資源實例
        /// </summary>
        public Bundle()
        {
        }

        /// <summary>
        /// 建立新的 Bundle 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Bundle(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Bundle(Id: {Id})";
        }
    }
}
