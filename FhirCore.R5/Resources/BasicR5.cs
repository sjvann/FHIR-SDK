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
    /// FHIR R5 BasicR5 資源
    /// 
    /// <para>
    /// BasicR5 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var basicr5 = new BasicR5("basicr5-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 BasicR5 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class BasicR5 : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private FhirDateTime? _created;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "BasicR5";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Created
        /// </summary>
        /// <remarks>
        /// <para>
        /// Created 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Created
        {
            get => _created;
            set
            {
                _created = value;
                OnPropertyChanged(nameof(Created));
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
        /// 建立新的 BasicR5 資源實例
        /// </summary>
        public BasicR5()
        {
        }

        /// <summary>
        /// 建立新的 BasicR5 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public BasicR5(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"BasicR5(Id: {Id})";
        }
    }
}
