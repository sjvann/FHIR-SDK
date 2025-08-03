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
    /// FHIR R5 EnrollmentResponse 資源
    /// 
    /// <para>
    /// EnrollmentResponse 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var enrollmentresponse = new EnrollmentResponse("enrollmentresponse-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 EnrollmentResponse 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class EnrollmentResponse : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _request;
        private FhirCode? _outcome;
        private FhirString? _disposition;
        private FhirDateTime? _created;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _organization;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _requestprovider;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "EnrollmentResponse";        /// <summary>
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
        /// Request
        /// </summary>
        /// <remarks>
        /// <para>
        /// Request 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(Request));
            }
        }        /// <summary>
        /// Outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(Outcome));
            }
        }        /// <summary>
        /// Disposition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Disposition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Disposition
        {
            get => _disposition;
            set
            {
                _disposition = value;
                OnPropertyChanged(nameof(Disposition));
            }
        }        /// <summary>
        /// Created
        /// </summary>
        /// <remarks>
        /// <para>
        /// Created 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Created
        {
            get => _created;
            set
            {
                _created = value;
                OnPropertyChanged(nameof(Created));
            }
        }        /// <summary>
        /// Organization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Organization 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Organization
        {
            get => _organization;
            set
            {
                _organization = value;
                OnPropertyChanged(nameof(Organization));
            }
        }        /// <summary>
        /// Requestprovider
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requestprovider 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Requestprovider
        {
            get => _requestprovider;
            set
            {
                _requestprovider = value;
                OnPropertyChanged(nameof(Requestprovider));
            }
        }        /// <summary>
        /// 建立新的 EnrollmentResponse 資源實例
        /// </summary>
        public EnrollmentResponse()
        {
        }

        /// <summary>
        /// 建立新的 EnrollmentResponse 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public EnrollmentResponse(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"EnrollmentResponse(Id: {Id})";
        }
    }
}
