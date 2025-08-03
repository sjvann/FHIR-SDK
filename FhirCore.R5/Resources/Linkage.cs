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
    /// FHIR R5 Linkage 資源
    /// 
    /// <para>
    /// Linkage 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var linkage = new Linkage("linkage-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Linkage 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Linkage : ResourceBase<R5Version>
    {
        private Property
		private FhirBoolean? _active;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;
        private List<LinkageItem>? _item;
        private FhirCode? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _resource;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Linkage";        /// <summary>
        /// Active
        /// </summary>
        /// <remarks>
        /// <para>
        /// Active 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private FhirBoolean? Active
        {
            get => _active;
            set
            {
                _active = value;
                OnPropertyChanged(nameof(Active));
            }
        }        /// <summary>
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public List<LinkageItem>? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// 建立新的 Linkage 資源實例
        /// </summary>
        public Linkage()
        {
        }

        /// <summary>
        /// 建立新的 Linkage 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Linkage(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Linkage(Id: {Id})";
        }
    }    /// <summary>
    /// LinkageItem 背骨元素
    /// </summary>
    public class LinkageItem
    {
        // TODO: 添加屬性實作
        
        public LinkageItem() { }
    }
}
