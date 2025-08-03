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
    /// FHIR R5 SubstanceNucleicAcid 資源
    /// 
    /// <para>
    /// SubstanceNucleicAcid 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var substancenucleicacid = new SubstanceNucleicAcid("substancenucleicacid-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 SubstanceNucleicAcid 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubstanceNucleicAcid : ResourceBase<R5Version>
    {
        private Property
		private CodeableConcept? _sequencetype;
        private FhirInteger? _numberofsubunits;
        private FhirString? _areaofhybridisation;
        private CodeableConcept? _oligonucleotidetype;
        private List<SubstanceNucleicAcidSubunit>? _subunit;
        private FhirString? _connectivity;
        private Identifier? _identifier;
        private FhirString? _name;
        private FhirString? _residuesite;
        private Identifier? _identifier;
        private FhirString? _name;
        private FhirString? _residuesite;
        private FhirInteger? _subunit;
        private FhirString? _sequence;
        private FhirInteger? _length;
        private Attachment? _sequenceattachment;
        private CodeableConcept? _fiveprime;
        private CodeableConcept? _threeprime;
        private List<SubstanceNucleicAcidSubunitLinkage>? _linkage;
        private List<SubstanceNucleicAcidSubunitSugar>? _sugar;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SubstanceNucleicAcid";        /// <summary>
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
        /// Areaofhybridisation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Areaofhybridisation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Areaofhybridisation
        {
            get => _areaofhybridisation;
            set
            {
                _areaofhybridisation = value;
                OnPropertyChanged(nameof(Areaofhybridisation));
            }
        }        /// <summary>
        /// Oligonucleotidetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Oligonucleotidetype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Oligonucleotidetype
        {
            get => _oligonucleotidetype;
            set
            {
                _oligonucleotidetype = value;
                OnPropertyChanged(nameof(Oligonucleotidetype));
            }
        }        /// <summary>
        /// Subunit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subunit 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceNucleicAcidSubunit>? Subunit
        {
            get => _subunit;
            set
            {
                _subunit = value;
                OnPropertyChanged(nameof(Subunit));
            }
        }        /// <summary>
        /// Connectivity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Connectivity 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Connectivity
        {
            get => _connectivity;
            set
            {
                _connectivity = value;
                OnPropertyChanged(nameof(Connectivity));
            }
        }        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
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
        /// Residuesite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Residuesite 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Residuesite
        {
            get => _residuesite;
            set
            {
                _residuesite = value;
                OnPropertyChanged(nameof(Residuesite));
            }
        }        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
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
        /// Residuesite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Residuesite 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Residuesite
        {
            get => _residuesite;
            set
            {
                _residuesite = value;
                OnPropertyChanged(nameof(Residuesite));
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
        /// Fiveprime
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fiveprime 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Fiveprime
        {
            get => _fiveprime;
            set
            {
                _fiveprime = value;
                OnPropertyChanged(nameof(Fiveprime));
            }
        }        /// <summary>
        /// Threeprime
        /// </summary>
        /// <remarks>
        /// <para>
        /// Threeprime 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Threeprime
        {
            get => _threeprime;
            set
            {
                _threeprime = value;
                OnPropertyChanged(nameof(Threeprime));
            }
        }        /// <summary>
        /// Linkage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceNucleicAcidSubunitLinkage>? Linkage
        {
            get => _linkage;
            set
            {
                _linkage = value;
                OnPropertyChanged(nameof(Linkage));
            }
        }        /// <summary>
        /// Sugar
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sugar 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceNucleicAcidSubunitSugar>? Sugar
        {
            get => _sugar;
            set
            {
                _sugar = value;
                OnPropertyChanged(nameof(Sugar));
            }
        }        /// <summary>
        /// 建立新的 SubstanceNucleicAcid 資源實例
        /// </summary>
        public SubstanceNucleicAcid()
        {
        }

        /// <summary>
        /// 建立新的 SubstanceNucleicAcid 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubstanceNucleicAcid(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubstanceNucleicAcid(Id: {Id})";
        }
    }    /// <summary>
    /// SubstanceNucleicAcidSubunitLinkage 背骨元素
    /// </summary>
    public class SubstanceNucleicAcidSubunitLinkage
    {
        // TODO: 添加屬性實作
        
        public SubstanceNucleicAcidSubunitLinkage() { }
    }    /// <summary>
    /// SubstanceNucleicAcidSubunitSugar 背骨元素
    /// </summary>
    public class SubstanceNucleicAcidSubunitSugar
    {
        // TODO: 添加屬性實作
        
        public SubstanceNucleicAcidSubunitSugar() { }
    }    /// <summary>
    /// SubstanceNucleicAcidSubunit 背骨元素
    /// </summary>
    public class SubstanceNucleicAcidSubunit
    {
        // TODO: 添加屬性實作
        
        public SubstanceNucleicAcidSubunit() { }
    }
}
