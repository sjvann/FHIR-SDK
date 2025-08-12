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
    /// FHIR R5 ClinicalImpression 資源
    /// 
    /// <para>
    /// ClinicalImpression 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var clinicalimpression = new ClinicalImpression("clinicalimpression-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ClinicalImpression 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ClinicalImpression : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private CodeableConcept? _statusreason;
        private FhirString? _description;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private ClinicalImpressionEffectiveChoice? _effective;
        private FhirDateTime? _date;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _performer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _previous;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _problem;
        private CodeableConcept? _changepattern;
        private List<FhirUri>? _protocol;
        private FhirString? _summary;
        private List<ClinicalImpressionFinding>? _finding;
        private List<CodeableConcept>? _prognosiscodeableconcept;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _prognosisreference;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportinginfo;
        private List<Annotation>? _note;
        private CodeableReference? _item;
        private FhirString? _basis;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ClinicalImpression";        /// <summary>
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
        /// Statusreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusreason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Statusreason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(Statusreason));
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
        /// Encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }        /// <summary>
        /// Effective
        /// </summary>
        /// <remarks>
        /// <para>
        /// Effective 的詳細描述。
        /// </para>
        /// </remarks>
        public ClinicalImpressionEffectiveChoice? Effective
        {
            get => _effective;
            set
            {
                _effective = value;
                OnPropertyChanged(nameof(Effective));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }        /// <summary>
        /// Previous
        /// </summary>
        /// <remarks>
        /// <para>
        /// Previous 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Previous
        {
            get => _previous;
            set
            {
                _previous = value;
                OnPropertyChanged(nameof(Previous));
            }
        }        /// <summary>
        /// Problem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Problem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Problem
        {
            get => _problem;
            set
            {
                _problem = value;
                OnPropertyChanged(nameof(Problem));
            }
        }        /// <summary>
        /// Changepattern
        /// </summary>
        /// <remarks>
        /// <para>
        /// Changepattern 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Changepattern
        {
            get => _changepattern;
            set
            {
                _changepattern = value;
                OnPropertyChanged(nameof(Changepattern));
            }
        }        /// <summary>
        /// Protocol
        /// </summary>
        /// <remarks>
        /// <para>
        /// Protocol 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Protocol
        {
            get => _protocol;
            set
            {
                _protocol = value;
                OnPropertyChanged(nameof(Protocol));
            }
        }        /// <summary>
        /// Summary
        /// </summary>
        /// <remarks>
        /// <para>
        /// Summary 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Summary
        {
            get => _summary;
            set
            {
                _summary = value;
                OnPropertyChanged(nameof(Summary));
            }
        }        /// <summary>
        /// Finding
        /// </summary>
        /// <remarks>
        /// <para>
        /// Finding 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClinicalImpressionFinding>? Finding
        {
            get => _finding;
            set
            {
                _finding = value;
                OnPropertyChanged(nameof(Finding));
            }
        }        /// <summary>
        /// Prognosiscodeableconcept
        /// </summary>
        /// <remarks>
        /// <para>
        /// Prognosiscodeableconcept 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Prognosiscodeableconcept
        {
            get => _prognosiscodeableconcept;
            set
            {
                _prognosiscodeableconcept = value;
                OnPropertyChanged(nameof(Prognosiscodeableconcept));
            }
        }        /// <summary>
        /// Prognosisreference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Prognosisreference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Prognosisreference
        {
            get => _prognosisreference;
            set
            {
                _prognosisreference = value;
                OnPropertyChanged(nameof(Prognosisreference));
            }
        }        /// <summary>
        /// Supportinginfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supportinginfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(Supportinginfo));
            }
        }        /// <summary>
        /// Note
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Basis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basis 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Basis
        {
            get => _basis;
            set
            {
                _basis = value;
                OnPropertyChanged(nameof(Basis));
            }
        }        /// <summary>
        /// 建立新的 ClinicalImpression 資源實例
        /// </summary>
        public ClinicalImpression()
        {
        }

        /// <summary>
        /// 建立新的 ClinicalImpression 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ClinicalImpression(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ClinicalImpression(Id: {Id})";
        }
    }    /// <summary>
    /// ClinicalImpressionFinding 背骨元素
    /// </summary>
    public class ClinicalImpressionFinding
    {
        // TODO: 添加屬性實作
        
        public ClinicalImpressionFinding() { }
    }    /// <summary>
    /// ClinicalImpressionEffectiveChoice 選擇類型
    /// </summary>
    public class ClinicalImpressionEffectiveChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClinicalImpressionEffectiveChoice(JsonObject value) : base("clinicalimpressioneffective", value, _supportType) { }
        public ClinicalImpressionEffectiveChoice(IComplexType? value) : base("clinicalimpressioneffective", value) { }
        public ClinicalImpressionEffectiveChoice(IPrimitiveType? value) : base("clinicalimpressioneffective", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClinicalImpressionEffective" : "clinicalimpressioneffective";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
