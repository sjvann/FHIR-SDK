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
    /// FHIR R5 InventoryReport 資源
    /// 
    /// <para>
    /// InventoryReport 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var inventoryreport = new InventoryReport("inventoryreport-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 InventoryReport 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class InventoryReport : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private FhirCode? _counttype;
        private CodeableConcept? _operationtype;
        private CodeableConcept? _operationtypereason;
        private FhirDateTime? _reporteddatetime;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reporter;
        private Period? _reportingperiod;
        private List<InventoryReportInventoryListing>? _inventorylisting;
        private List<Annotation>? _note;
        private CodeableConcept? _category;
        private Quantity? _quantity;
        private CodeableReference? _item;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private CodeableConcept? _itemstatus;
        private FhirDateTime? _countingdatetime;
        private List<InventoryReportInventoryListingItem>? _item;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "InventoryReport";        /// <summary>
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
        /// Counttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Counttype 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Counttype
        {
            get => _counttype;
            set
            {
                _counttype = value;
                OnPropertyChanged(nameof(Counttype));
            }
        }        /// <summary>
        /// Operationtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operationtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Operationtype
        {
            get => _operationtype;
            set
            {
                _operationtype = value;
                OnPropertyChanged(nameof(Operationtype));
            }
        }        /// <summary>
        /// Operationtypereason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operationtypereason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Operationtypereason
        {
            get => _operationtypereason;
            set
            {
                _operationtypereason = value;
                OnPropertyChanged(nameof(Operationtypereason));
            }
        }        /// <summary>
        /// Reporteddatetime
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reporteddatetime 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Reporteddatetime
        {
            get => _reporteddatetime;
            set
            {
                _reporteddatetime = value;
                OnPropertyChanged(nameof(Reporteddatetime));
            }
        }        /// <summary>
        /// Reporter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reporter 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reporter
        {
            get => _reporter;
            set
            {
                _reporter = value;
                OnPropertyChanged(nameof(Reporter));
            }
        }        /// <summary>
        /// Reportingperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reportingperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Reportingperiod
        {
            get => _reportingperiod;
            set
            {
                _reportingperiod = value;
                OnPropertyChanged(nameof(Reportingperiod));
            }
        }        /// <summary>
        /// Inventorylisting
        /// </summary>
        /// <remarks>
        /// <para>
        /// Inventorylisting 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InventoryReportInventoryListing>? Inventorylisting
        {
            get => _inventorylisting;
            set
            {
                _inventorylisting = value;
                OnPropertyChanged(nameof(Inventorylisting));
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
        public CodeableReference? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Itemstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Itemstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Itemstatus
        {
            get => _itemstatus;
            set
            {
                _itemstatus = value;
                OnPropertyChanged(nameof(Itemstatus));
            }
        }        /// <summary>
        /// Countingdatetime
        /// </summary>
        /// <remarks>
        /// <para>
        /// Countingdatetime 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Countingdatetime
        {
            get => _countingdatetime;
            set
            {
                _countingdatetime = value;
                OnPropertyChanged(nameof(Countingdatetime));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InventoryReportInventoryListingItem>? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// 建立新的 InventoryReport 資源實例
        /// </summary>
        public InventoryReport()
        {
        }

        /// <summary>
        /// 建立新的 InventoryReport 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public InventoryReport(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"InventoryReport(Id: {Id})";
        }
    }    /// <summary>
    /// InventoryReportInventoryListingItem 背骨元素
    /// </summary>
    public class InventoryReportInventoryListingItem
    {
        // TODO: 添加屬性實作
        
        public InventoryReportInventoryListingItem() { }
    }    /// <summary>
    /// InventoryReportInventoryListing 背骨元素
    /// </summary>
    public class InventoryReportInventoryListing
    {
        // TODO: 添加屬性實作
        
        public InventoryReportInventoryListing() { }
    }
}
