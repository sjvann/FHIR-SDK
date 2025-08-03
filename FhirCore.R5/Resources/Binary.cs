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
    /// FHIR R5 Binary 資源
    /// 
    /// <para>
    /// Binary 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 Binary 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Binary : ResourceBase<R5Version>
    {
        private Property
		private FhirCode? _contenttype;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _securitycontext;
        private FhirBase64Binary? _data;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Binary";        /// <summary>
        /// Contenttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contenttype 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private FhirCode? Contenttype
        {
            get => _contenttype;
            set
            {
                _contenttype = value;
                OnPropertyChanged(nameof(Contenttype));
            }
        }        /// <summary>
        /// Securitycontext
        /// </summary>
        /// <remarks>
        /// <para>
        /// Securitycontext 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Securitycontext
        {
            get => _securitycontext;
            set
            {
                _securitycontext = value;
                OnPropertyChanged(nameof(Securitycontext));
            }
        }        /// <summary>
        /// Data
        /// </summary>
        /// <remarks>
        /// <para>
        /// Data 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBase64Binary? Data
        {
            get => _data;
            set
            {
                _data = value;
                OnPropertyChanged(nameof(Data));
            }
        }        /// <summary>
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
