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
    /// FHIR R5 GuidanceResponse 資源
    /// 
    /// <para>
    /// GuidanceResponse 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var guidanceresponse = new GuidanceResponse("guidanceresponse-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 GuidanceResponse 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class GuidanceResponse : ResourceBase<R5Version>
    {
        private Property
		private Identifier? _requestidentifier;
        private List<Identifier>? _identifier;
        private GuidanceResponseModuleChoice? _module;
        private FhirCode? _status;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private FhirDateTime? _occurrencedatetime;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _performer;
        private List<CodeableReference>? _reason;
        private List<Annotation>? _note;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _evaluationmessage;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _outputparameters;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _result;
        private List<DataRequirement>? _datarequirement;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "GuidanceResponse";        /// <summary>
        /// Requestidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requestidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private Identifier? Requestidentifier
        {
            get => _requestidentifier;
            set
            {
                _requestidentifier = value;
                OnPropertyChanged(nameof(Requestidentifier));
            }
        }        /// <summary>
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
        /// Module
        /// </summary>
        /// <remarks>
        /// <para>
        /// Module 的詳細描述。
        /// </para>
        /// </remarks>
        public GuidanceResponseModuleChoice? Module
        {
            get => _module;
            set
            {
                _module = value;
                OnPropertyChanged(nameof(Module));
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
        /// Occurrencedatetime
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrencedatetime 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Occurrencedatetime
        {
            get => _occurrencedatetime;
            set
            {
                _occurrencedatetime = value;
                OnPropertyChanged(nameof(Occurrencedatetime));
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
        /// Evaluationmessage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Evaluationmessage 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Evaluationmessage
        {
            get => _evaluationmessage;
            set
            {
                _evaluationmessage = value;
                OnPropertyChanged(nameof(Evaluationmessage));
            }
        }        /// <summary>
        /// Outputparameters
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outputparameters 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Outputparameters
        {
            get => _outputparameters;
            set
            {
                _outputparameters = value;
                OnPropertyChanged(nameof(Outputparameters));
            }
        }        /// <summary>
        /// Result
        /// </summary>
        /// <remarks>
        /// <para>
        /// Result 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }        /// <summary>
        /// Datarequirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Datarequirement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataRequirement>? Datarequirement
        {
            get => _datarequirement;
            set
            {
                _datarequirement = value;
                OnPropertyChanged(nameof(Datarequirement));
            }
        }        /// <summary>
        /// 建立新的 GuidanceResponse 資源實例
        /// </summary>
        public GuidanceResponse()
        {
        }

        /// <summary>
        /// 建立新的 GuidanceResponse 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public GuidanceResponse(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"GuidanceResponse(Id: {Id})";
        }
    }    /// <summary>
    /// GuidanceResponseModuleChoice 選擇類型
    /// </summary>
    public class GuidanceResponseModuleChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public GuidanceResponseModuleChoice(JsonObject value) : base("guidanceresponsemodule", value, _supportType) { }
        public GuidanceResponseModuleChoice(IComplexType? value) : base("guidanceresponsemodule", value) { }
        public GuidanceResponseModuleChoice(IPrimitiveType? value) : base("guidanceresponsemodule", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "GuidanceResponseModule" : "guidanceresponsemodule";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
