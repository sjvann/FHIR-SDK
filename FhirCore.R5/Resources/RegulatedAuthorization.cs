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
    /// FHIR R5 RegulatedAuthorization 資源
    /// 
    /// <para>
    /// RegulatedAuthorization 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var regulatedauthorization = new RegulatedAuthorization("regulatedauthorization-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 RegulatedAuthorization 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class RegulatedAuthorization : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _subject;
        private CodeableConcept? _type;
        private FhirMarkdown? _description;
        private List<CodeableConcept>? _region;
        private CodeableConcept? _status;
        private FhirDateTime? _statusdate;
        private Period? _validityperiod;
        private List<CodeableReference>? _indication;
        private CodeableConcept? _intendeduse;
        private List<CodeableConcept>? _basis;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _holder;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _regulator;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _attacheddocument;
        private RegulatedAuthorizationCase? _case;
        private Identifier? _identifier;
        private CodeableConcept? _type;
        private CodeableConcept? _status;
        private RegulatedAuthorizationCaseDateChoice? _date;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "RegulatedAuthorization";        /// <summary>
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
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Region
        /// </summary>
        /// <remarks>
        /// <para>
        /// Region 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Region
        {
            get => _region;
            set
            {
                _region = value;
                OnPropertyChanged(nameof(Region));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Statusdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Statusdate
        {
            get => _statusdate;
            set
            {
                _statusdate = value;
                OnPropertyChanged(nameof(Statusdate));
            }
        }        /// <summary>
        /// Validityperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Validityperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Validityperiod
        {
            get => _validityperiod;
            set
            {
                _validityperiod = value;
                OnPropertyChanged(nameof(Validityperiod));
            }
        }        /// <summary>
        /// Indication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Indication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Indication
        {
            get => _indication;
            set
            {
                _indication = value;
                OnPropertyChanged(nameof(Indication));
            }
        }        /// <summary>
        /// Intendeduse
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intendeduse 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Intendeduse
        {
            get => _intendeduse;
            set
            {
                _intendeduse = value;
                OnPropertyChanged(nameof(Intendeduse));
            }
        }        /// <summary>
        /// Basis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basis 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Basis
        {
            get => _basis;
            set
            {
                _basis = value;
                OnPropertyChanged(nameof(Basis));
            }
        }        /// <summary>
        /// Holder
        /// </summary>
        /// <remarks>
        /// <para>
        /// Holder 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Holder
        {
            get => _holder;
            set
            {
                _holder = value;
                OnPropertyChanged(nameof(Holder));
            }
        }        /// <summary>
        /// Regulator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Regulator 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Regulator
        {
            get => _regulator;
            set
            {
                _regulator = value;
                OnPropertyChanged(nameof(Regulator));
            }
        }        /// <summary>
        /// Attacheddocument
        /// </summary>
        /// <remarks>
        /// <para>
        /// Attacheddocument 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Attacheddocument
        {
            get => _attacheddocument;
            set
            {
                _attacheddocument = value;
                OnPropertyChanged(nameof(Attacheddocument));
            }
        }        /// <summary>
        /// Case
        /// </summary>
        /// <remarks>
        /// <para>
        /// Case 的詳細描述。
        /// </para>
        /// </remarks>
        public RegulatedAuthorizationCase? Case
        {
            get => _case;
            set
            {
                _case = value;
                OnPropertyChanged(nameof(Case));
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
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public RegulatedAuthorizationCaseDateChoice? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// 建立新的 RegulatedAuthorization 資源實例
        /// </summary>
        public RegulatedAuthorization()
        {
        }

        /// <summary>
        /// 建立新的 RegulatedAuthorization 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public RegulatedAuthorization(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"RegulatedAuthorization(Id: {Id})";
        }
    }    /// <summary>
    /// RegulatedAuthorizationCase 背骨元素
    /// </summary>
    public class RegulatedAuthorizationCase
    {
        // TODO: 添加屬性實作
        
        public RegulatedAuthorizationCase() { }
    }    /// <summary>
    /// RegulatedAuthorizationCaseDateChoice 選擇類型
    /// </summary>
    public class RegulatedAuthorizationCaseDateChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public RegulatedAuthorizationCaseDateChoice(JsonObject value) : base("regulatedauthorizationcasedate", value, _supportType) { }
        public RegulatedAuthorizationCaseDateChoice(IComplexType? value) : base("regulatedauthorizationcasedate", value) { }
        public RegulatedAuthorizationCaseDateChoice(IPrimitiveType? value) : base("regulatedauthorizationcasedate", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "RegulatedAuthorizationCaseDate" : "regulatedauthorizationcasedate";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
