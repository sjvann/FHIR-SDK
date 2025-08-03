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
    /// FHIR R4 Binary 資源
    /// 
    /// <para>
    /// A resource that represents the data of a single raw artifact as digital content accessible in its native format.  A Binary resource can contain any content, whether text, image, pdf, zip archive, etc.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var binary = new Binary("binary-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Binary 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Binary : ResourceBase<R4Version>
    {
        private FhirCode? _contenttype;

        /// <summary>
        /// contentType
        /// </summary>
        /// <remarks>
        /// <para>
        /// contentType 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? contentType
        {
            get => _contenttype;
            set
            {
                _contenttype = value;
                OnPropertyChanged(nameof(contentType));
            }
        }

        private FhirBase64Binary? _data;

        /// <summary>
        /// data
        /// </summary>
        /// <remarks>
        /// <para>
        /// data 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBase64Binary? data
        {
            get => _data;
            set
            {
                _data = value;
                OnPropertyChanged(nameof(data));
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

        private ReferenceType? _securitycontext;

        /// <summary>
        /// securityContext
        /// </summary>
        /// <remarks>
        /// <para>
        /// securityContext 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? securityContext
        {
            get => _securitycontext;
            set
            {
                _securitycontext = value;
                OnPropertyChanged(nameof(securityContext));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Binary";

        /// <summary>
        /// 建立新的 Binary 資源實例
        /// </summary>
        public Binary()
        {
        }

        /// <summary>
        /// 建立新的 Binary 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Binary(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Binary(Id: {Id})";
        }
    }
}
