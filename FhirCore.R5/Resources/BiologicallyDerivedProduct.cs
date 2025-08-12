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
    /// FHIR R5 BiologicallyDerivedProduct 資源
    /// 
    /// <para>
    /// BiologicallyDerivedProduct 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var biologicallyderivedproduct = new BiologicallyDerivedProduct("biologicallyderivedproduct-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 BiologicallyDerivedProduct 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class BiologicallyDerivedProduct : ResourceBase<R5Version>
    {
        private Property
		private Coding? _productcategory;
        private CodeableConcept? _productcode;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _parent;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _request;
        private List<Identifier>? _identifier;
        private Identifier? _biologicalsourceevent;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _processingfacility;
        private FhirString? _division;
        private Coding? _productstatus;
        private FhirDateTime? _expirationdate;
        private BiologicallyDerivedProductCollection? _collection;
        private Range? _storagetemprequirements;
        private List<BiologicallyDerivedProductProperty>? _property;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _collector;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _source;
        private BiologicallyDerivedProductCollectionCollectedChoice? _collected;
        private CodeableConcept? _type;
        private BiologicallyDerivedProductPropertyValueChoice? _value;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "BiologicallyDerivedProduct";        /// <summary>
        /// Productcategory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productcategory 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private Coding? Productcategory
        {
            get => _productcategory;
            set
            {
                _productcategory = value;
                OnPropertyChanged(nameof(Productcategory));
            }
        }        /// <summary>
        /// Productcode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productcode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productcode
        {
            get => _productcode;
            set
            {
                _productcode = value;
                OnPropertyChanged(nameof(Productcode));
            }
        }        /// <summary>
        /// Parent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Parent
        {
            get => _parent;
            set
            {
                _parent = value;
                OnPropertyChanged(nameof(Parent));
            }
        }        /// <summary>
        /// Request
        /// </summary>
        /// <remarks>
        /// <para>
        /// Request 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(Request));
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
        /// Biologicalsourceevent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Biologicalsourceevent 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Biologicalsourceevent
        {
            get => _biologicalsourceevent;
            set
            {
                _biologicalsourceevent = value;
                OnPropertyChanged(nameof(Biologicalsourceevent));
            }
        }        /// <summary>
        /// Processingfacility
        /// </summary>
        /// <remarks>
        /// <para>
        /// Processingfacility 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Processingfacility
        {
            get => _processingfacility;
            set
            {
                _processingfacility = value;
                OnPropertyChanged(nameof(Processingfacility));
            }
        }        /// <summary>
        /// Division
        /// </summary>
        /// <remarks>
        /// <para>
        /// Division 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Division
        {
            get => _division;
            set
            {
                _division = value;
                OnPropertyChanged(nameof(Division));
            }
        }        /// <summary>
        /// Productstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Productstatus
        {
            get => _productstatus;
            set
            {
                _productstatus = value;
                OnPropertyChanged(nameof(Productstatus));
            }
        }        /// <summary>
        /// Expirationdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expirationdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Expirationdate
        {
            get => _expirationdate;
            set
            {
                _expirationdate = value;
                OnPropertyChanged(nameof(Expirationdate));
            }
        }        /// <summary>
        /// Collection
        /// </summary>
        /// <remarks>
        /// <para>
        /// Collection 的詳細描述。
        /// </para>
        /// </remarks>
        public BiologicallyDerivedProductCollection? Collection
        {
            get => _collection;
            set
            {
                _collection = value;
                OnPropertyChanged(nameof(Collection));
            }
        }        /// <summary>
        /// Storagetemprequirements
        /// </summary>
        /// <remarks>
        /// <para>
        /// Storagetemprequirements 的詳細描述。
        /// </para>
        /// </remarks>
        public Range? Storagetemprequirements
        {
            get => _storagetemprequirements;
            set
            {
                _storagetemprequirements = value;
                OnPropertyChanged(nameof(Storagetemprequirements));
            }
        }        /// <summary>
        /// Property
        /// </summary>
        /// <remarks>
        /// <para>
        /// Property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BiologicallyDerivedProductProperty>? Property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(Property));
            }
        }        /// <summary>
        /// Collector
        /// </summary>
        /// <remarks>
        /// <para>
        /// Collector 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Collector
        {
            get => _collector;
            set
            {
                _collector = value;
                OnPropertyChanged(nameof(Collector));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Collected
        /// </summary>
        /// <remarks>
        /// <para>
        /// Collected 的詳細描述。
        /// </para>
        /// </remarks>
        public BiologicallyDerivedProductCollectionCollectedChoice? Collected
        {
            get => _collected;
            set
            {
                _collected = value;
                OnPropertyChanged(nameof(Collected));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public BiologicallyDerivedProductPropertyValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// 建立新的 BiologicallyDerivedProduct 資源實例
        /// </summary>
        public BiologicallyDerivedProduct()
        {
        }

        /// <summary>
        /// 建立新的 BiologicallyDerivedProduct 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public BiologicallyDerivedProduct(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"BiologicallyDerivedProduct(Id: {Id})";
        }
    }    /// <summary>
    /// BiologicallyDerivedProductCollection 背骨元素
    /// </summary>
    public class BiologicallyDerivedProductCollection
    {
        // TODO: 添加屬性實作
        
        public BiologicallyDerivedProductCollection() { }
    }    /// <summary>
    /// BiologicallyDerivedProductProperty 背骨元素
    /// </summary>
    public class BiologicallyDerivedProductProperty
    {
        // TODO: 添加屬性實作
        
        public BiologicallyDerivedProductProperty() { }
    }    /// <summary>
    /// BiologicallyDerivedProductCollectionCollectedChoice 選擇類型
    /// </summary>
    public class BiologicallyDerivedProductCollectionCollectedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public BiologicallyDerivedProductCollectionCollectedChoice(JsonObject value) : base("biologicallyderivedproductcollectioncollected", value, _supportType) { }
        public BiologicallyDerivedProductCollectionCollectedChoice(IComplexType? value) : base("biologicallyderivedproductcollectioncollected", value) { }
        public BiologicallyDerivedProductCollectionCollectedChoice(IPrimitiveType? value) : base("biologicallyderivedproductcollectioncollected", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "BiologicallyDerivedProductCollectionCollected" : "biologicallyderivedproductcollectioncollected";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// BiologicallyDerivedProductPropertyValueChoice 選擇類型
    /// </summary>
    public class BiologicallyDerivedProductPropertyValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public BiologicallyDerivedProductPropertyValueChoice(JsonObject value) : base("biologicallyderivedproductpropertyvalue", value, _supportType) { }
        public BiologicallyDerivedProductPropertyValueChoice(IComplexType? value) : base("biologicallyderivedproductpropertyvalue", value) { }
        public BiologicallyDerivedProductPropertyValueChoice(IPrimitiveType? value) : base("biologicallyderivedproductpropertyvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "BiologicallyDerivedProductPropertyValue" : "biologicallyderivedproductpropertyvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
