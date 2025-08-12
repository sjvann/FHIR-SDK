using FhirCore.Base;
using FhirCore.R4;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R4.Resources
{
    /// <summary>
    /// FHIR R4 Group 資源
    /// 
    /// <para>
    /// Represents a defined collection of entities that may be discussed or acted upon collectively but which are not expected to act collectively, and are not formally or legally recognized; i.e. a collection of entities that isn't an Organization.
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
    /// R4 版本的 Group 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Group : ResourceBase<R4Version>
    {
        private FhirBoolean? _active;

        /// <summary>
        /// active
        /// </summary>
        /// <remarks>
        /// <para>
        /// active 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? active
        {
            get => _active;
            set
            {
                _active = value;
                OnPropertyChanged(nameof(active));
            }
        }

        private FhirBoolean? _actual;

        /// <summary>
        /// actual
        /// </summary>
        /// <remarks>
        /// <para>
        /// actual 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? actual
        {
            get => _actual;
            set
            {
                _actual = value;
                OnPropertyChanged(nameof(actual));
            }
        }

        private List<BackboneElement>? _characteristic;

        /// <summary>
        /// characteristic
        /// </summary>
        /// <remarks>
        /// <para>
        /// characteristic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? characteristic
        {
            get => _characteristic;
            set
            {
                _characteristic = value;
                OnPropertyChanged(nameof(characteristic));
            }
        }

        private CodeableConcept? _code;

        /// <summary>
        /// code
        /// </summary>
        /// <remarks>
        /// <para>
        /// code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(code));
            }
        }

        private List<FhirString>? _contained;

        /// <summary>
        /// contained
        /// </summary>
        /// <remarks>
        /// <para>
        /// contained 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? contained
        {
            get => _contained;
            set
            {
                _contained = value;
                OnPropertyChanged(nameof(contained));
            }
        }

        private List<Extension>? _extension;

        /// <summary>
        /// extension
        /// </summary>
        /// <remarks>
        /// <para>
        /// extension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? extension
        {
            get => _extension;
            set
            {
                _extension = value;
                OnPropertyChanged(nameof(extension));
            }
        }

        private FhirString? _id;

        /// <summary>
        /// id
        /// </summary>
        /// <remarks>
        /// <para>
        /// id 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(id));
            }
        }

        private List<Identifier>? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(identifier));
            }
        }

        private FhirUri? _implicitrules;

        /// <summary>
        /// implicitRules
        /// </summary>
        /// <remarks>
        /// <para>
        /// implicitRules 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? implicitRules
        {
            get => _implicitrules;
            set
            {
                _implicitrules = value;
                OnPropertyChanged(nameof(implicitRules));
            }
        }

        private FhirCode? _language;

        /// <summary>
        /// language
        /// </summary>
        /// <remarks>
        /// <para>
        /// language 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(language));
            }
        }

        private ReferenceType? _managingentity;

        /// <summary>
        /// managingEntity
        /// </summary>
        /// <remarks>
        /// <para>
        /// managingEntity 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? managingEntity
        {
            get => _managingentity;
            set
            {
                _managingentity = value;
                OnPropertyChanged(nameof(managingEntity));
            }
        }

        private List<BackboneElement>? _member;

        /// <summary>
        /// member
        /// </summary>
        /// <remarks>
        /// <para>
        /// member 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? member
        {
            get => _member;
            set
            {
                _member = value;
                OnPropertyChanged(nameof(member));
            }
        }

        private Meta? _meta;

        /// <summary>
        /// meta
        /// </summary>
        /// <remarks>
        /// <para>
        /// meta 的詳細描述。
        /// </para>
        /// </remarks>
        public Meta? meta
        {
            get => _meta;
            set
            {
                _meta = value;
                OnPropertyChanged(nameof(meta));
            }
        }

        private List<Extension>? _modifierextension;

        /// <summary>
        /// modifierExtension
        /// </summary>
        /// <remarks>
        /// <para>
        /// modifierExtension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? modifierExtension
        {
            get => _modifierextension;
            set
            {
                _modifierextension = value;
                OnPropertyChanged(nameof(modifierExtension));
            }
        }

        private FhirString? _name;

        /// <summary>
        /// name
        /// </summary>
        /// <remarks>
        /// <para>
        /// name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(name));
            }
        }

        private FhirUnsignedInt? _quantity;

        /// <summary>
        /// quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(quantity));
            }
        }

        private FhirString? _text;

        /// <summary>
        /// text
        /// </summary>
        /// <remarks>
        /// <para>
        /// text 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged(nameof(text));
            }
        }

        private FhirCode? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Group";

        /// <summary>
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
    }
}
