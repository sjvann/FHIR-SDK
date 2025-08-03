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
    /// FHIR R5 BiologicallyDerivedProductDispense 資源
    /// 
    /// <para>
    /// BiologicallyDerivedProductDispense 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var biologicallyderivedproductdispense = new BiologicallyDerivedProductDispense("biologicallyderivedproductdispense-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 BiologicallyDerivedProductDispense 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class BiologicallyDerivedProductDispense : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private FhirCode? _status;
        private CodeableConcept? _originrelationshiptype;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _product;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private CodeableConcept? _matchstatus;
        private List<BiologicallyDerivedProductDispensePerformer>? _performer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private Quantity? _quantity;
        private FhirDateTime? _prepareddate;
        private FhirDateTime? _whenhandedover;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _destination;
        private List<Annotation>? _note;
        private FhirString? _usageinstruction;
        private CodeableConcept? _function;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "BiologicallyDerivedProductDispense";        /// <summary>
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
        /// Originrelationshiptype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Originrelationshiptype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Originrelationshiptype
        {
            get => _originrelationshiptype;
            set
            {
                _originrelationshiptype = value;
                OnPropertyChanged(nameof(Originrelationshiptype));
            }
        }        /// <summary>
        /// Product
        /// </summary>
        /// <remarks>
        /// <para>
        /// Product 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Product
        {
            get => _product;
            set
            {
                _product = value;
                OnPropertyChanged(nameof(Product));
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
        /// Matchstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Matchstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Matchstatus
        {
            get => _matchstatus;
            set
            {
                _matchstatus = value;
                OnPropertyChanged(nameof(Matchstatus));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BiologicallyDerivedProductDispensePerformer>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
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
        /// Prepareddate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Prepareddate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Prepareddate
        {
            get => _prepareddate;
            set
            {
                _prepareddate = value;
                OnPropertyChanged(nameof(Prepareddate));
            }
        }        /// <summary>
        /// Whenhandedover
        /// </summary>
        /// <remarks>
        /// <para>
        /// Whenhandedover 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Whenhandedover
        {
            get => _whenhandedover;
            set
            {
                _whenhandedover = value;
                OnPropertyChanged(nameof(Whenhandedover));
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
        /// Usageinstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usageinstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Usageinstruction
        {
            get => _usageinstruction;
            set
            {
                _usageinstruction = value;
                OnPropertyChanged(nameof(Usageinstruction));
            }
        }        /// <summary>
        /// Function
        /// </summary>
        /// <remarks>
        /// <para>
        /// Function 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Function
        {
            get => _function;
            set
            {
                _function = value;
                OnPropertyChanged(nameof(Function));
            }
        }        /// <summary>
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// 建立新的 BiologicallyDerivedProductDispense 資源實例
        /// </summary>
        public BiologicallyDerivedProductDispense()
        {
        }

        /// <summary>
        /// 建立新的 BiologicallyDerivedProductDispense 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public BiologicallyDerivedProductDispense(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"BiologicallyDerivedProductDispense(Id: {Id})";
        }
    }    /// <summary>
    /// BiologicallyDerivedProductDispensePerformer 背骨元素
    /// </summary>
    public class BiologicallyDerivedProductDispensePerformer
    {
        // TODO: 添加屬性實作
        
        public BiologicallyDerivedProductDispensePerformer() { }
    }
}
