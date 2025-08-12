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
    /// FHIR R5 DeviceAssociation 資源
    /// 
    /// <para>
    /// DeviceAssociation 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var deviceassociation = new DeviceAssociation("deviceassociation-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 DeviceAssociation 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DeviceAssociation : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _device;
        private List<CodeableConcept>? _category;
        private CodeableConcept? _status;
        private List<CodeableConcept>? _statusreason;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _bodystructure;
        private Period? _period;
        private List<DeviceAssociationOperation>? _operation;
        private CodeableConcept? _status;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _operator;
        private Period? _period;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "DeviceAssociation";        /// <summary>
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
        /// Device
        /// </summary>
        /// <remarks>
        /// <para>
        /// Device 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Statusreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusreason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Statusreason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(Statusreason));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Bodystructure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodystructure 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Bodystructure
        {
            get => _bodystructure;
            set
            {
                _bodystructure = value;
                OnPropertyChanged(nameof(Bodystructure));
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
        /// Operation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceAssociationOperation>? Operation
        {
            get => _operation;
            set
            {
                _operation = value;
                OnPropertyChanged(nameof(Operation));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Operator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operator 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Operator
        {
            get => _operator;
            set
            {
                _operator = value;
                OnPropertyChanged(nameof(Operator));
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
        /// 建立新的 DeviceAssociation 資源實例
        /// </summary>
        public DeviceAssociation()
        {
        }

        /// <summary>
        /// 建立新的 DeviceAssociation 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public DeviceAssociation(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"DeviceAssociation(Id: {Id})";
        }
    }    /// <summary>
    /// DeviceAssociationOperation 背骨元素
    /// </summary>
    public class DeviceAssociationOperation
    {
        // TODO: 添加屬性實作
        
        public DeviceAssociationOperation() { }
    }
}
