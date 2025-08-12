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
    /// FHIR R5 MedicationStatement 資源
    /// 
    /// <para>
    /// MedicationStatement 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicationstatement = new MedicationStatement("medicationstatement-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 MedicationStatement 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicationStatement : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private FhirCode? _status;
        private List<CodeableConcept>? _category;
        private CodeableReference? _medication;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private MedicationStatementEffectiveChoice? _effective;
        private FhirDateTime? _dateasserted;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _informationsource;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _derivedfrom;
        private List<CodeableReference>? _reason;
        private List<Annotation>? _note;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _relatedclinicalinformation;
        private FhirMarkdown? _rendereddosageinstruction;
        private List<Dosage>? _dosage;
        private MedicationStatementAdherence? _adherence;
        private CodeableConcept? _code;
        private CodeableConcept? _reason;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicationStatement";        /// <summary>
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
        /// Partof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Partof 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Partof
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(Partof));
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
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Medication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Medication 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Medication
        {
            get => _medication;
            set
            {
                _medication = value;
                OnPropertyChanged(nameof(Medication));
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
        public MedicationStatementEffectiveChoice? Effective
        {
            get => _effective;
            set
            {
                _effective = value;
                OnPropertyChanged(nameof(Effective));
            }
        }        /// <summary>
        /// Dateasserted
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dateasserted 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Dateasserted
        {
            get => _dateasserted;
            set
            {
                _dateasserted = value;
                OnPropertyChanged(nameof(Dateasserted));
            }
        }        /// <summary>
        /// Informationsource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Informationsource 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Informationsource
        {
            get => _informationsource;
            set
            {
                _informationsource = value;
                OnPropertyChanged(nameof(Informationsource));
            }
        }        /// <summary>
        /// Derivedfrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Derivedfrom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Derivedfrom
        {
            get => _derivedfrom;
            set
            {
                _derivedfrom = value;
                OnPropertyChanged(nameof(Derivedfrom));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
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
        /// Relatedclinicalinformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatedclinicalinformation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Relatedclinicalinformation
        {
            get => _relatedclinicalinformation;
            set
            {
                _relatedclinicalinformation = value;
                OnPropertyChanged(nameof(Relatedclinicalinformation));
            }
        }        /// <summary>
        /// Rendereddosageinstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rendereddosageinstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Rendereddosageinstruction
        {
            get => _rendereddosageinstruction;
            set
            {
                _rendereddosageinstruction = value;
                OnPropertyChanged(nameof(Rendereddosageinstruction));
            }
        }        /// <summary>
        /// Dosage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dosage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Dosage>? Dosage
        {
            get => _dosage;
            set
            {
                _dosage = value;
                OnPropertyChanged(nameof(Dosage));
            }
        }        /// <summary>
        /// Adherence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Adherence 的詳細描述。
        /// </para>
        /// </remarks>
        public MedicationStatementAdherence? Adherence
        {
            get => _adherence;
            set
            {
                _adherence = value;
                OnPropertyChanged(nameof(Adherence));
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
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// 建立新的 MedicationStatement 資源實例
        /// </summary>
        public MedicationStatement()
        {
        }

        /// <summary>
        /// 建立新的 MedicationStatement 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicationStatement(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicationStatement(Id: {Id})";
        }
    }    /// <summary>
    /// MedicationStatementAdherence 背骨元素
    /// </summary>
    public class MedicationStatementAdherence
    {
        // TODO: 添加屬性實作
        
        public MedicationStatementAdherence() { }
    }    /// <summary>
    /// MedicationStatementEffectiveChoice 選擇類型
    /// </summary>
    public class MedicationStatementEffectiveChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MedicationStatementEffectiveChoice(JsonObject value) : base("medicationstatementeffective", value, _supportType) { }
        public MedicationStatementEffectiveChoice(IComplexType? value) : base("medicationstatementeffective", value) { }
        public MedicationStatementEffectiveChoice(IPrimitiveType? value) : base("medicationstatementeffective", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MedicationStatementEffective" : "medicationstatementeffective";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
