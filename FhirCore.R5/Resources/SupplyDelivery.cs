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
    /// FHIR R5 SupplyDelivery 資源
    /// 
    /// <para>
    /// SupplyDelivery 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var supplydelivery = new SupplyDelivery("supplydelivery-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 SupplyDelivery 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SupplyDelivery : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private FhirCode? _status;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private CodeableConcept? _type;
        private List<SupplyDeliverySuppliedItem>? _supplieditem;
        private SupplyDeliveryOccurrenceChoice? _occurrence;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _supplier;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _destination;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _receiver;
        private Quantity? _quantity;
        private SupplyDeliverySuppliedItemItemChoice? _item;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SupplyDelivery";        /// <summary>
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
        /// Patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patient 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(Patient));
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
        /// Supplieditem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supplieditem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SupplyDeliverySuppliedItem>? Supplieditem
        {
            get => _supplieditem;
            set
            {
                _supplieditem = value;
                OnPropertyChanged(nameof(Supplieditem));
            }
        }        /// <summary>
        /// Occurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public SupplyDeliveryOccurrenceChoice? Occurrence
        {
            get => _occurrence;
            set
            {
                _occurrence = value;
                OnPropertyChanged(nameof(Occurrence));
            }
        }        /// <summary>
        /// Supplier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supplier 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Supplier
        {
            get => _supplier;
            set
            {
                _supplier = value;
                OnPropertyChanged(nameof(Supplier));
            }
        }        /// <summary>
        /// Destination
        /// </summary>
        /// <remarks>
        /// <para>
        /// Destination 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Destination
        {
            get => _destination;
            set
            {
                _destination = value;
                OnPropertyChanged(nameof(Destination));
            }
        }        /// <summary>
        /// Receiver
        /// </summary>
        /// <remarks>
        /// <para>
        /// Receiver 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Receiver
        {
            get => _receiver;
            set
            {
                _receiver = value;
                OnPropertyChanged(nameof(Receiver));
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
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public SupplyDeliverySuppliedItemItemChoice? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// 建立新的 SupplyDelivery 資源實例
        /// </summary>
        public SupplyDelivery()
        {
        }

        /// <summary>
        /// 建立新的 SupplyDelivery 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SupplyDelivery(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SupplyDelivery(Id: {Id})";
        }
    }    /// <summary>
    /// SupplyDeliverySuppliedItem 背骨元素
    /// </summary>
    public class SupplyDeliverySuppliedItem
    {
        // TODO: 添加屬性實作
        
        public SupplyDeliverySuppliedItem() { }
    }    /// <summary>
    /// SupplyDeliverySuppliedItemItemChoice 選擇類型
    /// </summary>
    public class SupplyDeliverySuppliedItemItemChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SupplyDeliverySuppliedItemItemChoice(JsonObject value) : base("supplydeliverysupplieditemitem", value, _supportType) { }
        public SupplyDeliverySuppliedItemItemChoice(IComplexType? value) : base("supplydeliverysupplieditemitem", value) { }
        public SupplyDeliverySuppliedItemItemChoice(IPrimitiveType? value) : base("supplydeliverysupplieditemitem", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SupplyDeliverySuppliedItemItem" : "supplydeliverysupplieditemitem";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// SupplyDeliveryOccurrenceChoice 選擇類型
    /// </summary>
    public class SupplyDeliveryOccurrenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public SupplyDeliveryOccurrenceChoice(JsonObject value) : base("supplydeliveryoccurrence", value, _supportType) { }
        public SupplyDeliveryOccurrenceChoice(IComplexType? value) : base("supplydeliveryoccurrence", value) { }
        public SupplyDeliveryOccurrenceChoice(IPrimitiveType? value) : base("supplydeliveryoccurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "SupplyDeliveryOccurrence" : "supplydeliveryoccurrence";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
