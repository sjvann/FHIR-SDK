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
    /// FHIR R4 SubstanceReferenceInformation 資源
    /// 
    /// <para>
    /// Todo.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var substancereferenceinformation = new SubstanceReferenceInformation("substancereferenceinformation-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 SubstanceReferenceInformation 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubstanceReferenceInformation : ResourceBase<R4Version>
    {
        private List<BackboneElement>? _classification;

        /// <summary>
        /// classification
        /// </summary>
        /// <remarks>
        /// <para>
        /// classification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? classification
        {
            get => _classification;
            set
            {
                _classification = value;
                OnPropertyChanged(nameof(classification));
            }
        }

        private FhirString? _comment;

        /// <summary>
        /// comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(comment));
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

        private List<BackboneElement>? _gene;

        /// <summary>
        /// gene
        /// </summary>
        /// <remarks>
        /// <para>
        /// gene 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? gene
        {
            get => _gene;
            set
            {
                _gene = value;
                OnPropertyChanged(nameof(gene));
            }
        }

        private List<BackboneElement>? _geneelement;

        /// <summary>
        /// geneElement
        /// </summary>
        /// <remarks>
        /// <para>
        /// geneElement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? geneElement
        {
            get => _geneelement;
            set
            {
                _geneelement = value;
                OnPropertyChanged(nameof(geneElement));
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

        private List<BackboneElement>? _target;

        /// <summary>
        /// target
        /// </summary>
        /// <remarks>
        /// <para>
        /// target 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(target));
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
        public override string ResourceType => "SubstanceReferenceInformation";

        /// <summary>
        /// 建立新的 SubstanceReferenceInformation 資源實例
        /// </summary>
        public SubstanceReferenceInformation()
        {
        }

        /// <summary>
        /// 建立新的 SubstanceReferenceInformation 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubstanceReferenceInformation(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubstanceReferenceInformation(Id: {Id})";
        }
    }
}
