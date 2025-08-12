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
    /// FHIR R4 Schedule 資源
    /// 
    /// <para>
    /// A container for slots of time that may be available for booking appointments.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var schedule = new Schedule("schedule-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Schedule 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Schedule : ResourceBase<R4Version>
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

        private List<ReferenceType>? _actor;

        /// <summary>
        /// actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// actor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(actor));
            }
        }

        private FhirString? _comment;

        /// <summary>
        /// comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(comment));
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

        private Period? _planninghorizon;

        /// <summary>
        /// planningHorizon
        /// </summary>
        /// <remarks>
        /// <para>
        /// planningHorizon 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? planningHorizon
        {
            get => _planninghorizon;
            set
            {
                _planninghorizon = value;
                OnPropertyChanged(nameof(planningHorizon));
            }
        }

        private List<CodeableConcept>? _servicecategory;

        /// <summary>
        /// serviceCategory
        /// </summary>
        /// <remarks>
        /// <para>
        /// serviceCategory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? serviceCategory
        {
            get => _servicecategory;
            set
            {
                _servicecategory = value;
                OnPropertyChanged(nameof(serviceCategory));
            }
        }

        private List<CodeableConcept>? _servicetype;

        /// <summary>
        /// serviceType
        /// </summary>
        /// <remarks>
        /// <para>
        /// serviceType 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? serviceType
        {
            get => _servicetype;
            set
            {
                _servicetype = value;
                OnPropertyChanged(nameof(serviceType));
            }
        }

        private List<CodeableConcept>? _specialty;

        /// <summary>
        /// specialty
        /// </summary>
        /// <remarks>
        /// <para>
        /// specialty 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? specialty
        {
            get => _specialty;
            set
            {
                _specialty = value;
                OnPropertyChanged(nameof(specialty));
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

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Schedule";

        /// <summary>
        /// 建立新的 Schedule 資源實例
        /// </summary>
        public Schedule()
        {
        }

        /// <summary>
        /// 建立新的 Schedule 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Schedule(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Schedule(Id: {Id})";
        }
    }
}
