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
    /// FHIR R5 Slot 資源
    /// 
    /// <para>
    /// Slot 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 Slot 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Slot : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<CodeableConcept>? _servicecategory;
        private List<CodeableReference>? _servicetype;
        private List<CodeableConcept>? _specialty;
        private List<CodeableConcept>? _appointmenttype;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _schedule;
        private FhirCode? _status;
        private FhirInstant? _start;
        private FhirInstant? _end;
        private FhirBoolean? _overbooked;
        private FhirString? _comment;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Slot";        /// <summary>
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
        /// Servicecategory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Servicecategory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Servicecategory
        {
            get => _servicecategory;
            set
            {
                _servicecategory = value;
                OnPropertyChanged(nameof(Servicecategory));
            }
        }        /// <summary>
        /// Servicetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Servicetype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Servicetype
        {
            get => _servicetype;
            set
            {
                _servicetype = value;
                OnPropertyChanged(nameof(Servicetype));
            }
        }        /// <summary>
        /// Specialty
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specialty 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Specialty
        {
            get => _specialty;
            set
            {
                _specialty = value;
                OnPropertyChanged(nameof(Specialty));
            }
        }        /// <summary>
        /// Appointmenttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Appointmenttype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Appointmenttype
        {
            get => _appointmenttype;
            set
            {
                _appointmenttype = value;
                OnPropertyChanged(nameof(Appointmenttype));
            }
        }        /// <summary>
        /// Schedule
        /// </summary>
        /// <remarks>
        /// <para>
        /// Schedule 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Schedule
        {
            get => _schedule;
            set
            {
                _schedule = value;
                OnPropertyChanged(nameof(Schedule));
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
        /// Start
        /// </summary>
        /// <remarks>
        /// <para>
        /// Start 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? Start
        {
            get => _start;
            set
            {
                _start = value;
                OnPropertyChanged(nameof(Start));
            }
        }        /// <summary>
        /// End
        /// </summary>
        /// <remarks>
        /// <para>
        /// End 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? End
        {
            get => _end;
            set
            {
                _end = value;
                OnPropertyChanged(nameof(End));
            }
        }        /// <summary>
        /// Overbooked
        /// </summary>
        /// <remarks>
        /// <para>
        /// Overbooked 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Overbooked
        {
            get => _overbooked;
            set
            {
                _overbooked = value;
                OnPropertyChanged(nameof(Overbooked));
            }
        }        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }        /// <summary>
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
