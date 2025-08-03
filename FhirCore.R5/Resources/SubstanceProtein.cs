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
    /// FHIR R5 SubstanceProtein 資源
    /// 
    /// <para>
    /// SubstanceProtein 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var substanceprotein = new SubstanceProtein("substanceprotein-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 SubstanceProtein 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubstanceProtein : ResourceBase<R5Version>
    {
        private Property
		private CodeableConcept? _sequencetype;
        private FhirInteger? _numberofsubunits;
        private List<FhirString>? _disulfidelinkage;
        private List<SubstanceProteinSubunit>? _subunit;
        private FhirInteger? _subunit;
        private FhirString? _sequence;
        private FhirInteger? _length;
        private Attachment? _sequenceattachment;
        private Identifier? _nterminalmodificationid;
        private FhirString? _nterminalmodification;
        private Identifier? _cterminalmodificationid;
        private FhirString? _cterminalmodification;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SubstanceProtein";        /// <summary>
        /// Sequencetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequencetype 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private CodeableConcept? Sequencetype
        {
            get => _sequencetype;
            set
            {
                _sequencetype = value;
                OnPropertyChanged(nameof(Sequencetype));
            }
        }        /// <summary>
        /// Numberofsubunits
        /// </summary>
        /// <remarks>
        /// <para>
        /// Numberofsubunits 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Numberofsubunits
        {
            get => _numberofsubunits;
            set
            {
                _numberofsubunits = value;
                OnPropertyChanged(nameof(Numberofsubunits));
            }
        }        /// <summary>
        /// Disulfidelinkage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Disulfidelinkage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Disulfidelinkage
        {
            get => _disulfidelinkage;
            set
            {
                _disulfidelinkage = value;
                OnPropertyChanged(nameof(Disulfidelinkage));
            }
        }        /// <summary>
        /// Subunit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subunit 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceProteinSubunit>? Subunit
        {
            get => _subunit;
            set
            {
                _subunit = value;
                OnPropertyChanged(nameof(Subunit));
            }
        }        /// <summary>
        /// Subunit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subunit 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Subunit
        {
            get => _subunit;
            set
            {
                _subunit = value;
                OnPropertyChanged(nameof(Subunit));
            }
        }        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Sequence
        {
            get => _sequence;
            set
            {
                _sequence = value;
                OnPropertyChanged(nameof(Sequence));
            }
        }        /// <summary>
        /// Length
        /// </summary>
        /// <remarks>
        /// <para>
        /// Length 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Length
        {
            get => _length;
            set
            {
                _length = value;
                OnPropertyChanged(nameof(Length));
            }
        }        /// <summary>
        /// Sequenceattachment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequenceattachment 的詳細描述。
        /// </para>
        /// </remarks>
        public Attachment? Sequenceattachment
        {
            get => _sequenceattachment;
            set
            {
                _sequenceattachment = value;
                OnPropertyChanged(nameof(Sequenceattachment));
            }
        }        /// <summary>
        /// Nterminalmodificationid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Nterminalmodificationid 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Nterminalmodificationid
        {
            get => _nterminalmodificationid;
            set
            {
                _nterminalmodificationid = value;
                OnPropertyChanged(nameof(Nterminalmodificationid));
            }
        }        /// <summary>
        /// Nterminalmodification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Nterminalmodification 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Nterminalmodification
        {
            get => _nterminalmodification;
            set
            {
                _nterminalmodification = value;
                OnPropertyChanged(nameof(Nterminalmodification));
            }
        }        /// <summary>
        /// Cterminalmodificationid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cterminalmodificationid 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Cterminalmodificationid
        {
            get => _cterminalmodificationid;
            set
            {
                _cterminalmodificationid = value;
                OnPropertyChanged(nameof(Cterminalmodificationid));
            }
        }        /// <summary>
        /// Cterminalmodification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cterminalmodification 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Cterminalmodification
        {
            get => _cterminalmodification;
            set
            {
                _cterminalmodification = value;
                OnPropertyChanged(nameof(Cterminalmodification));
            }
        }        /// <summary>
        /// 建立新的 SubstanceProtein 資源實例
        /// </summary>
        public SubstanceProtein()
        {
        }

        /// <summary>
        /// 建立新的 SubstanceProtein 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubstanceProtein(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubstanceProtein(Id: {Id})";
        }
    }    /// <summary>
    /// SubstanceProteinSubunit 背骨元素
    /// </summary>
    public class SubstanceProteinSubunit
    {
        // TODO: 添加屬性實作
        
        public SubstanceProteinSubunit() { }
    }
}
