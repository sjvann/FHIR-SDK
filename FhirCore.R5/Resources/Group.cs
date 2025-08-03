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
    /// FHIR R5 Group 資源
    /// 
    /// <para>
    /// Group 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var group = new Group("group-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Group 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Group : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private FhirCode? _type;
        private FhirCode? _membership;
        private CodeableConcept? _code;
        private FhirString? _name;
        private FhirMarkdown? _description;
        private FhirUnsignedInt? _quantity;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _managingentity;
        private List<GroupCharacteristic>? _characteristic;
        private List<GroupMember>? _member;
        private CodeableConcept? _code;
        private GroupCharacteristicValueChoice? _value;
        private FhirBoolean? _exclude;
        private Period? _period;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _entity;
        private Period? _period;
        private FhirBoolean? _inactive;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Group";        /// <summary>
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
        /// Active
        /// </summary>
        /// <remarks>
        /// <para>
        /// Active 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Active
        {
            get => _active;
            set
            {
                _active = value;
                OnPropertyChanged(nameof(Active));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Membership
        /// </summary>
        /// <remarks>
        /// <para>
        /// Membership 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Membership
        {
            get => _membership;
            set
            {
                _membership = value;
                OnPropertyChanged(nameof(Membership));
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
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
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
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Managingentity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Managingentity 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Managingentity
        {
            get => _managingentity;
            set
            {
                _managingentity = value;
                OnPropertyChanged(nameof(Managingentity));
            }
        }        /// <summary>
        /// Characteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// Characteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<GroupCharacteristic>? Characteristic
        {
            get => _characteristic;
            set
            {
                _characteristic = value;
                OnPropertyChanged(nameof(Characteristic));
            }
        }        /// <summary>
        /// Member
        /// </summary>
        /// <remarks>
        /// <para>
        /// Member 的詳細描述。
        /// </para>
        /// </remarks>
        public List<GroupMember>? Member
        {
            get => _member;
            set
            {
                _member = value;
                OnPropertyChanged(nameof(Member));
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
        public GroupCharacteristicValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Exclude
        /// </summary>
        /// <remarks>
        /// <para>
        /// Exclude 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Exclude
        {
            get => _exclude;
            set
            {
                _exclude = value;
                OnPropertyChanged(nameof(Exclude));
            }
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Entity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entity 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Entity
        {
            get => _entity;
            set
            {
                _entity = value;
                OnPropertyChanged(nameof(Entity));
            }
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Inactive
        /// </summary>
        /// <remarks>
        /// <para>
        /// Inactive 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Inactive
        {
            get => _inactive;
            set
            {
                _inactive = value;
                OnPropertyChanged(nameof(Inactive));
            }
        }        /// <summary>
        /// 建立新的 Group 資源實例
        /// </summary>
        public Group()
        {
        }

        /// <summary>
        /// 建立新的 Group 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Group(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Group(Id: {Id})";
        }
    }    /// <summary>
    /// GroupCharacteristic 背骨元素
    /// </summary>
    public class GroupCharacteristic
    {
        // TODO: 添加屬性實作
        
        public GroupCharacteristic() { }
    }    /// <summary>
    /// GroupMember 背骨元素
    /// </summary>
    public class GroupMember
    {
        // TODO: 添加屬性實作
        
        public GroupMember() { }
    }    /// <summary>
    /// GroupCharacteristicValueChoice 選擇類型
    /// </summary>
    public class GroupCharacteristicValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public GroupCharacteristicValueChoice(JsonObject value) : base("groupcharacteristicvalue", value, _supportType) { }
        public GroupCharacteristicValueChoice(IComplexType? value) : base("groupcharacteristicvalue", value) { }
        public GroupCharacteristicValueChoice(IPrimitiveType? value) : base("groupcharacteristicvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "GroupCharacteristicValue" : "groupcharacteristicvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
