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
    /// FHIR R5 List 資源
    /// 
    /// <para>
    /// List 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var list = new List("list-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 List 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class List : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private FhirCode? _mode;
        private FhirString? _title;
        private CodeableConcept? _code;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private FhirDateTime? _date;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _source;
        private CodeableConcept? _orderedby;
        private List<Annotation>? _note;
        private List<ListEntry>? _entry;
        private CodeableConcept? _emptyreason;
        private CodeableConcept? _flag;
        private FhirBoolean? _deleted;
        private FhirDateTime? _date;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _item;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "List";        /// <summary>
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
        /// Mode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mode 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(Mode));
            }
        }        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
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
        /// Orderedby
        /// </summary>
        /// <remarks>
        /// <para>
        /// Orderedby 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Orderedby
        {
            get => _orderedby;
            set
            {
                _orderedby = value;
                OnPropertyChanged(nameof(Orderedby));
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
        /// Entry
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entry 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ListEntry>? Entry
        {
            get => _entry;
            set
            {
                _entry = value;
                OnPropertyChanged(nameof(Entry));
            }
        }        /// <summary>
        /// Emptyreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Emptyreason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Emptyreason
        {
            get => _emptyreason;
            set
            {
                _emptyreason = value;
                OnPropertyChanged(nameof(Emptyreason));
            }
        }        /// <summary>
        /// Flag
        /// </summary>
        /// <remarks>
        /// <para>
        /// Flag 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Flag
        {
            get => _flag;
            set
            {
                _flag = value;
                OnPropertyChanged(nameof(Flag));
            }
        }        /// <summary>
        /// Deleted
        /// </summary>
        /// <remarks>
        /// <para>
        /// Deleted 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Deleted
        {
            get => _deleted;
            set
            {
                _deleted = value;
                OnPropertyChanged(nameof(Deleted));
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
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// 建立新的 List 資源實例
        /// </summary>
        public List()
        {
        }

        /// <summary>
        /// 建立新的 List 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public List(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"List(Id: {Id})";
        }
    }    /// <summary>
    /// ListEntry 背骨元素
    /// </summary>
    public class ListEntry
    {
        // TODO: 添加屬性實作
        
        public ListEntry() { }
    }
}
