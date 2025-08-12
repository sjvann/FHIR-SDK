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
    /// FHIR R5 CoverageEligibilityRequest 資源
    /// 
    /// <para>
    /// CoverageEligibilityRequest 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var coverageeligibilityrequest = new CoverageEligibilityRequest("coverageeligibilityrequest-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 CoverageEligibilityRequest 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class CoverageEligibilityRequest : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private CodeableConcept? _priority;
        private List<FhirCode>? _purpose;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private List<CoverageEligibilityRequestEvent>? _event;
        private CoverageEligibilityRequestServicedChoice? _serviced;
        private FhirDateTime? _created;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _enterer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _provider;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _insurer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _facility;
        private List<CoverageEligibilityRequestSupportingInfo>? _supportinginfo;
        private List<CoverageEligibilityRequestInsurance>? _insurance;
        private List<CoverageEligibilityRequestItem>? _item;
        private CodeableConcept? _type;
        private CoverageEligibilityRequestEventWhenChoice? _when;
        private FhirPositiveInt? _sequence;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _information;
        private FhirBoolean? _appliestoall;
        private FhirBoolean? _focal;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _coverage;
        private FhirString? _businessarrangement;
        private CoverageEligibilityRequestItemDiagnosisDiagnosisChoice? _diagnosis;
        private List<FhirPositiveInt>? _supportinginfosequence;
        private CodeableConcept? _category;
        private CodeableConcept? _productorservice;
        private List<CodeableConcept>? _modifier;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _provider;
        private Quantity? _quantity;
        private Money? _unitprice;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _facility;
        private List<CoverageEligibilityRequestItemDiagnosis>? _diagnosis;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _detail;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "CoverageEligibilityRequest";        /// <summary>
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
        /// Priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Priority 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }        /// <summary>
        /// Purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(Purpose));
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
        /// Event
        /// </summary>
        /// <remarks>
        /// <para>
        /// Event 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageEligibilityRequestEvent>? Event
        {
            get => _event;
            set
            {
                _event = value;
                OnPropertyChanged(nameof(Event));
            }
        }        /// <summary>
        /// Serviced
        /// </summary>
        /// <remarks>
        /// <para>
        /// Serviced 的詳細描述。
        /// </para>
        /// </remarks>
        public CoverageEligibilityRequestServicedChoice? Serviced
        {
            get => _serviced;
            set
            {
                _serviced = value;
                OnPropertyChanged(nameof(Serviced));
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
        /// Enterer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Enterer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Enterer
        {
            get => _enterer;
            set
            {
                _enterer = value;
                OnPropertyChanged(nameof(Enterer));
            }
        }        /// <summary>
        /// Provider
        /// </summary>
        /// <remarks>
        /// <para>
        /// Provider 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Provider
        {
            get => _provider;
            set
            {
                _provider = value;
                OnPropertyChanged(nameof(Provider));
            }
        }        /// <summary>
        /// Insurer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Insurer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Insurer
        {
            get => _insurer;
            set
            {
                _insurer = value;
                OnPropertyChanged(nameof(Insurer));
            }
        }        /// <summary>
        /// Facility
        /// </summary>
        /// <remarks>
        /// <para>
        /// Facility 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Facility
        {
            get => _facility;
            set
            {
                _facility = value;
                OnPropertyChanged(nameof(Facility));
            }
        }        /// <summary>
        /// Supportinginfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageEligibilityRequestSupportingInfo>? Supportinginfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(Supportinginfo));
            }
        }        /// <summary>
        /// Insurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Insurance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageEligibilityRequestInsurance>? Insurance
        {
            get => _insurance;
            set
            {
                _insurance = value;
                OnPropertyChanged(nameof(Insurance));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageEligibilityRequestItem>? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// When
        /// </summary>
        /// <remarks>
        /// <para>
        /// When 的詳細描述。
        /// </para>
        /// </remarks>
        public CoverageEligibilityRequestEventWhenChoice? When
        {
            get => _when;
            set
            {
                _when = value;
                OnPropertyChanged(nameof(When));
            }
        }        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Sequence
        {
            get => _sequence;
            set
            {
                _sequence = value;
                OnPropertyChanged(nameof(Sequence));
            }
        }        /// <summary>
        /// Information
        /// </summary>
        /// <remarks>
        /// <para>
        /// Information 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Information
        {
            get => _information;
            set
            {
                _information = value;
                OnPropertyChanged(nameof(Information));
            }
        }        /// <summary>
        /// Appliestoall
        /// </summary>
        /// <remarks>
        /// <para>
        /// Appliestoall 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Appliestoall
        {
            get => _appliestoall;
            set
            {
                _appliestoall = value;
                OnPropertyChanged(nameof(Appliestoall));
            }
        }        /// <summary>
        /// Focal
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focal 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Focal
        {
            get => _focal;
            set
            {
                _focal = value;
                OnPropertyChanged(nameof(Focal));
            }
        }        /// <summary>
        /// Coverage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Coverage 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Coverage
        {
            get => _coverage;
            set
            {
                _coverage = value;
                OnPropertyChanged(nameof(Coverage));
            }
        }        /// <summary>
        /// Businessarrangement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Businessarrangement 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Businessarrangement
        {
            get => _businessarrangement;
            set
            {
                _businessarrangement = value;
                OnPropertyChanged(nameof(Businessarrangement));
            }
        }        /// <summary>
        /// Diagnosis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diagnosis 的詳細描述。
        /// </para>
        /// </remarks>
        public CoverageEligibilityRequestItemDiagnosisDiagnosisChoice? Diagnosis
        {
            get => _diagnosis;
            set
            {
                _diagnosis = value;
                OnPropertyChanged(nameof(Diagnosis));
            }
        }        /// <summary>
        /// Supportinginfosequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginfosequence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Supportinginfosequence
        {
            get => _supportinginfosequence;
            set
            {
                _supportinginfosequence = value;
                OnPropertyChanged(nameof(Supportinginfosequence));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Productorservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorservice 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorservice
        {
            get => _productorservice;
            set
            {
                _productorservice = value;
                OnPropertyChanged(nameof(Productorservice));
            }
        }        /// <summary>
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
            }
        }        /// <summary>
        /// Provider
        /// </summary>
        /// <remarks>
        /// <para>
        /// Provider 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Provider
        {
            get => _provider;
            set
            {
                _provider = value;
                OnPropertyChanged(nameof(Provider));
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
        /// Unitprice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitprice 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Unitprice
        {
            get => _unitprice;
            set
            {
                _unitprice = value;
                OnPropertyChanged(nameof(Unitprice));
            }
        }        /// <summary>
        /// Facility
        /// </summary>
        /// <remarks>
        /// <para>
        /// Facility 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Facility
        {
            get => _facility;
            set
            {
                _facility = value;
                OnPropertyChanged(nameof(Facility));
            }
        }        /// <summary>
        /// Diagnosis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diagnosis 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageEligibilityRequestItemDiagnosis>? Diagnosis
        {
            get => _diagnosis;
            set
            {
                _diagnosis = value;
                OnPropertyChanged(nameof(Diagnosis));
            }
        }        /// <summary>
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
            }
        }        /// <summary>
        /// 建立新的 CoverageEligibilityRequest 資源實例
        /// </summary>
        public CoverageEligibilityRequest()
        {
        }

        /// <summary>
        /// 建立新的 CoverageEligibilityRequest 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public CoverageEligibilityRequest(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"CoverageEligibilityRequest(Id: {Id})";
        }
    }    /// <summary>
    /// CoverageEligibilityRequestEvent 背骨元素
    /// </summary>
    public class CoverageEligibilityRequestEvent
    {
        // TODO: 添加屬性實作
        
        public CoverageEligibilityRequestEvent() { }
    }    /// <summary>
    /// CoverageEligibilityRequestSupportingInfo 背骨元素
    /// </summary>
    public class CoverageEligibilityRequestSupportingInfo
    {
        // TODO: 添加屬性實作
        
        public CoverageEligibilityRequestSupportingInfo() { }
    }    /// <summary>
    /// CoverageEligibilityRequestInsurance 背骨元素
    /// </summary>
    public class CoverageEligibilityRequestInsurance
    {
        // TODO: 添加屬性實作
        
        public CoverageEligibilityRequestInsurance() { }
    }    /// <summary>
    /// CoverageEligibilityRequestItemDiagnosis 背骨元素
    /// </summary>
    public class CoverageEligibilityRequestItemDiagnosis
    {
        // TODO: 添加屬性實作
        
        public CoverageEligibilityRequestItemDiagnosis() { }
    }    /// <summary>
    /// CoverageEligibilityRequestItem 背骨元素
    /// </summary>
    public class CoverageEligibilityRequestItem
    {
        // TODO: 添加屬性實作
        
        public CoverageEligibilityRequestItem() { }
    }    /// <summary>
    /// CoverageEligibilityRequestEventWhenChoice 選擇類型
    /// </summary>
    public class CoverageEligibilityRequestEventWhenChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CoverageEligibilityRequestEventWhenChoice(JsonObject value) : base("coverageeligibilityrequesteventwhen", value, _supportType) { }
        public CoverageEligibilityRequestEventWhenChoice(IComplexType? value) : base("coverageeligibilityrequesteventwhen", value) { }
        public CoverageEligibilityRequestEventWhenChoice(IPrimitiveType? value) : base("coverageeligibilityrequesteventwhen", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CoverageEligibilityRequestEventWhen" : "coverageeligibilityrequesteventwhen";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// CoverageEligibilityRequestServicedChoice 選擇類型
    /// </summary>
    public class CoverageEligibilityRequestServicedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CoverageEligibilityRequestServicedChoice(JsonObject value) : base("coverageeligibilityrequestserviced", value, _supportType) { }
        public CoverageEligibilityRequestServicedChoice(IComplexType? value) : base("coverageeligibilityrequestserviced", value) { }
        public CoverageEligibilityRequestServicedChoice(IPrimitiveType? value) : base("coverageeligibilityrequestserviced", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CoverageEligibilityRequestServiced" : "coverageeligibilityrequestserviced";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// CoverageEligibilityRequestItemDiagnosisDiagnosisChoice 選擇類型
    /// </summary>
    public class CoverageEligibilityRequestItemDiagnosisDiagnosisChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CoverageEligibilityRequestItemDiagnosisDiagnosisChoice(JsonObject value) : base("coverageeligibilityrequestitemdiagnosisdiagnosis", value, _supportType) { }
        public CoverageEligibilityRequestItemDiagnosisDiagnosisChoice(IComplexType? value) : base("coverageeligibilityrequestitemdiagnosisdiagnosis", value) { }
        public CoverageEligibilityRequestItemDiagnosisDiagnosisChoice(IPrimitiveType? value) : base("coverageeligibilityrequestitemdiagnosisdiagnosis", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CoverageEligibilityRequestItemDiagnosisDiagnosis" : "coverageeligibilityrequestitemdiagnosisdiagnosis";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
