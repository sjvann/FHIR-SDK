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
    /// FHIR R5 Schedule 資源
    /// 
    /// <para>
    /// Schedule 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 Schedule 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Schedule : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<CodeableConcept>? _servicecategory;
        private List<CodeableReference>? _servicetype;
        private List<CodeableConcept>? _specialty;
        private FhirString? _name;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _actor;
        private Period? _planninghorizon;
        private FhirMarkdown? _comment;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Schedule";        /// <summary>
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
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// Planninghorizon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Planninghorizon 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Planninghorizon
        {
            get => _planninghorizon;
            set
            {
                _planninghorizon = value;
                OnPropertyChanged(nameof(Planninghorizon));
            }
        }        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }        /// <summary>
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
