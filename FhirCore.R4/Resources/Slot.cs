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
    /// FHIR R4 Slot 資源
    /// 
    /// <para>
    /// A slot of time on a schedule that may be available for booking appointments.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var slot = new Slot("slot-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Slot 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Slot : ResourceBase<R4Version>
    {
        private CodeableConcept? _appointmenttype;

        /// <summary>
        /// appointmentType
        /// </summary>
        /// <remarks>
        /// <para>
        /// appointmentType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? appointmentType
        {
            get => _appointmenttype;
            set
            {
                _appointmenttype = value;
                OnPropertyChanged(nameof(appointmentType));
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

        private FhirInstant? _end;

        /// <summary>
        /// end
        /// </summary>
        /// <remarks>
        /// <para>
        /// end 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? end
        {
            get => _end;
            set
            {
                _end = value;
                OnPropertyChanged(nameof(end));
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

        private FhirBoolean? _overbooked;

        /// <summary>
        /// overbooked
        /// </summary>
        /// <remarks>
        /// <para>
        /// overbooked 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? overbooked
        {
            get => _overbooked;
            set
            {
                _overbooked = value;
                OnPropertyChanged(nameof(overbooked));
            }
        }

        private ReferenceType? _schedule;

        /// <summary>
        /// schedule
        /// </summary>
        /// <remarks>
        /// <para>
        /// schedule 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? schedule
        {
            get => _schedule;
            set
            {
                _schedule = value;
                OnPropertyChanged(nameof(schedule));
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

        private FhirInstant? _start;

        /// <summary>
        /// start
        /// </summary>
        /// <remarks>
        /// <para>
        /// start 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? start
        {
            get => _start;
            set
            {
                _start = value;
                OnPropertyChanged(nameof(start));
            }
        }

        private FhirCode? _status;

        /// <summary>
        /// status
        /// </summary>
        /// <remarks>
        /// <para>
        /// status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(status));
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
        public override string ResourceType => "Slot";

        /// <summary>
        /// 建立新的 Slot 資源實例
        /// </summary>
        public Slot()
        {
        }

        /// <summary>
        /// 建立新的 Slot 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Slot(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Slot(Id: {Id})";
        }
    }
}
