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
    /// FHIR R5 SupplyRequest 資源
    /// 
    /// <para>
    /// SupplyRequest 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var supplyrequest = new SupplyRequest("supplyrequest-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 SupplyRequest 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SupplyRequest : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private CodeableConcept? _category;
        private FhirCode? _priority;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _deliverfor;
        private CodeableReference? _item;
        private Quantity? _quantity;
        private List<SupplyRequestParameter>? _parameter;
        private SupplyRequestOccurrenceChoice? _occurrence;
        private FhirDateTime? _authoredon;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _requester;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supplier;
        private List<CodeableReference>? _reason;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _deliverfrom;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _deliverto;
        private CodeableConcept? _code;
        private SupplyRequestParameterValueChoice? _value;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SupplyRequest";        /// <summary>
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
        /// Basedon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basedon 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Basedon
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(Basedon));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Priority 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }        /// <summary>
        /// Deliverfor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Deliverfor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Deliverfor
        {
            get => _deliverfor;
            set
            {
                _deliverfor = value;
                OnPropertyChanged(nameof(Deliverfor));
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
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Parameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parameter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SupplyRequestParameter>? Parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                OnPropertyChanged(nameof(Parameter));
            }
        }        /// <summary>
        /// Occurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public SupplyRequestOccurrenceChoice? Occurrence
        {
            get => _occurrence;
            set
            {
                _occurrence = value;
                OnPropertyChanged(nameof(Occurrence));
            }
        }        /// <summary>
        /// Authoredon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authoredon 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Authoredon
        {
            get => _authoredon;
            set
            {
                _authoredon = value;
                OnPropertyChanged(nameof(Authoredon));
            }
        }        /// <summary>
        /// Requester
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requester 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Requester
        {
            get => _requester;
            set
            {
                _requester = value;
                OnPropertyChanged(nameof(Requester));
            }
        }        /// <summary>
        /// Supplier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supplier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supplier
        {
            get => _supplier;
            set
            {
                _supplier = value;
                OnPropertyChanged(nameof(Supplier));
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
        /// Deliverfrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Deliverfrom 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Deliverfrom
        {
            get => _deliverfrom;
            set
            {
                _deliverfrom = value;
                OnPropertyChanged(nameof(Deliverfrom));
            }
        }        /// <summary>
        /// Deliverto
        /// </summary>
        /// <remarks>
        /// <para>
        /// Deliverto 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Deliverto
        {
            get => _deliverto;
            set
            {
                _deliverto = value;
                OnPropertyChanged(nameof(Deliverto));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public SupplyRequestParameterValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// 建立新的 SupplyRequest 資源實例
        /// </summary>
        public SupplyRequest()
        {
        }

        /// <summary>
        /// 建立新的 SupplyRequest 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SupplyRequest(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SupplyRequest(Id: {Id})";
        }
    }    /// <summary>
    /// SupplyRequestParameter 背骨元素
    /// </summary>
    public class SupplyRequestParameter
    {
        // TODO: 添加屬性實作
        
        public SupplyRequestParameter() { }
    }    /// <summary>
    /// SupplyRequestParameterValueChoice 選擇類型
    /// </summary>
    public class SupplyRequestParameterValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SupplyRequestParameterValueChoice(JsonObject value) : base("supplyrequestparametervalue", value, _supportType) { }
        public SupplyRequestParameterValueChoice(IComplexType? value) : base("supplyrequestparametervalue", value) { }
        public SupplyRequestParameterValueChoice(IPrimitiveType? value) : base("supplyrequestparametervalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SupplyRequestParameterValue" : "supplyrequestparametervalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// SupplyRequestOccurrenceChoice 選擇類型
    /// </summary>
    public class SupplyRequestOccurrenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SupplyRequestOccurrenceChoice(JsonObject value) : base("supplyrequestoccurrence", value, _supportType) { }
        public SupplyRequestOccurrenceChoice(IComplexType? value) : base("supplyrequestoccurrence", value) { }
        public SupplyRequestOccurrenceChoice(IPrimitiveType? value) : base("supplyrequestoccurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SupplyRequestOccurrence" : "supplyrequestoccurrence";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
