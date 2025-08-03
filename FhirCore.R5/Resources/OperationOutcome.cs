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
    /// FHIR R5 OperationOutcome 資源
    /// 
    /// <para>
    /// OperationOutcome 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var operationoutcome = new OperationOutcome("operationoutcome-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 OperationOutcome 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class OperationOutcome : ResourceBase<R5Version>
    {
        private Property
		private List<OperationOutcomeIssue>? _issue;
        private FhirCode? _severity;
        private FhirCode? _code;
        private CodeableConcept? _details;
        private FhirString? _diagnostics;
        private List<FhirString>? _location;
        private List<FhirString>? _expression;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "OperationOutcome";        /// <summary>
        /// Issue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issue 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private List<OperationOutcomeIssue>? Issue
        {
            get => _issue;
            set
            {
                _issue = value;
                OnPropertyChanged(nameof(Issue));
            }
        }        /// <summary>
        /// Severity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Severity 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Severity
        {
            get => _severity;
            set
            {
                _severity = value;
                OnPropertyChanged(nameof(Severity));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Details
        /// </summary>
        /// <remarks>
        /// <para>
        /// Details 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Details
        {
            get => _details;
            set
            {
                _details = value;
                OnPropertyChanged(nameof(Details));
            }
        }        /// <summary>
        /// Diagnostics
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diagnostics 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Diagnostics
        {
            get => _diagnostics;
            set
            {
                _diagnostics = value;
                OnPropertyChanged(nameof(Diagnostics));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expression 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }        /// <summary>
        /// 建立新的 OperationOutcome 資源實例
        /// </summary>
        public OperationOutcome()
        {
        }

        /// <summary>
        /// 建立新的 OperationOutcome 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public OperationOutcome(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"OperationOutcome(Id: {Id})";
        }
    }    /// <summary>
    /// OperationOutcomeIssue 背骨元素
    /// </summary>
    public class OperationOutcomeIssue
    {
        // TODO: 添加屬性實作
        
        public OperationOutcomeIssue() { }
    }
}
