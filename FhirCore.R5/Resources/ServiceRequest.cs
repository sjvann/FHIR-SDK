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
    /// FHIR R5 ServiceRequest 資源
    /// 
    /// <para>
    /// ServiceRequest 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var servicerequest = new ServiceRequest("servicerequest-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ServiceRequest 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ServiceRequest : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<FhirCanonical>? _instantiatescanonical;
        private List<FhirUri>? _instantiatesuri;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _replaces;
        private Identifier? _requisition;
        private FhirCode? _status;
        private FhirCode? _intent;
        private List<CodeableConcept>? _category;
        private FhirCode? _priority;
        private FhirBoolean? _donotperform;
        private CodeableReference? _code;
        private List<ServiceRequestOrderDetail>? _orderdetail;
        private ServiceRequestQuantityChoice? _quantity;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _focus;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private ServiceRequestOccurrenceChoice? _occurrence;
        private ServiceRequestAsNeededChoice? _asneeded;
        private FhirDateTime? _authoredon;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _requester;
        private CodeableConcept? _performertype;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _performer;
        private List<CodeableReference>? _location;
        private List<CodeableReference>? _reason;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _insurance;
        private List<CodeableReference>? _supportinginfo;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _specimen;
        private List<CodeableConcept>? _bodysite;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _bodystructure;
        private List<Annotation>? _note;
        private List<ServiceRequestPatientInstruction>? _patientinstruction;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _relevanthistory;
        private CodeableConcept? _code;
        private ServiceRequestOrderDetailParameterValueChoice? _value;
        private CodeableReference? _parameterfocus;
        private List<ServiceRequestOrderDetailParameter>? _parameter;
        private ServiceRequestPatientInstructionInstructionChoice? _instruction;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ServiceRequest";        /// <summary>
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
        /// Instantiatescanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatescanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Instantiatescanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(Instantiatescanonical));
            }
        }        /// <summary>
        /// Instantiatesuri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatesuri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Instantiatesuri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(Instantiatesuri));
            }
        }        /// <summary>
        /// Basedon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basedon 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Basedon
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(Basedon));
            }
        }        /// <summary>
        /// Replaces
        /// </summary>
        /// <remarks>
        /// <para>
        /// Replaces 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Replaces
        {
            get => _replaces;
            set
            {
                _replaces = value;
                OnPropertyChanged(nameof(Replaces));
            }
        }        /// <summary>
        /// Requisition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requisition 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Requisition
        {
            get => _requisition;
            set
            {
                _requisition = value;
                OnPropertyChanged(nameof(Requisition));
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
        /// Intent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Intent
        {
            get => _intent;
            set
            {
                _intent = value;
                OnPropertyChanged(nameof(Intent));
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
        /// Priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Priority 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }        /// <summary>
        /// Donotperform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Donotperform 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Donotperform
        {
            get => _donotperform;
            set
            {
                _donotperform = value;
                OnPropertyChanged(nameof(Donotperform));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Orderdetail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Orderdetail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ServiceRequestOrderDetail>? Orderdetail
        {
            get => _orderdetail;
            set
            {
                _orderdetail = value;
                OnPropertyChanged(nameof(Orderdetail));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public ServiceRequestQuantityChoice? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
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
        /// Focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(Focus));
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
        /// Occurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public ServiceRequestOccurrenceChoice? Occurrence
        {
            get => _occurrence;
            set
            {
                _occurrence = value;
                OnPropertyChanged(nameof(Occurrence));
            }
        }        /// <summary>
        /// Asneeded
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asneeded 的詳細描述。
        /// </para>
        /// </remarks>
        public ServiceRequestAsNeededChoice? Asneeded
        {
            get => _asneeded;
            set
            {
                _asneeded = value;
                OnPropertyChanged(nameof(Asneeded));
            }
        }        /// <summary>
        /// Authoredon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authoredon 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Authoredon
        {
            get => _authoredon;
            set
            {
                _authoredon = value;
                OnPropertyChanged(nameof(Authoredon));
            }
        }        /// <summary>
        /// Requester
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requester 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Requester
        {
            get => _requester;
            set
            {
                _requester = value;
                OnPropertyChanged(nameof(Requester));
            }
        }        /// <summary>
        /// Performertype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performertype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Performertype
        {
            get => _performertype;
            set
            {
                _performertype = value;
                OnPropertyChanged(nameof(Performertype));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Insurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Insurance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Insurance
        {
            get => _insurance;
            set
            {
                _insurance = value;
                OnPropertyChanged(nameof(Insurance));
            }
        }        /// <summary>
        /// Supportinginfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Supportinginfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(Supportinginfo));
            }
        }        /// <summary>
        /// Specimen
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specimen 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Specimen
        {
            get => _specimen;
            set
            {
                _specimen = value;
                OnPropertyChanged(nameof(Specimen));
            }
        }        /// <summary>
        /// Bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(Bodysite));
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
        /// Patientinstruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patientinstruction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ServiceRequestPatientInstruction>? Patientinstruction
        {
            get => _patientinstruction;
            set
            {
                _patientinstruction = value;
                OnPropertyChanged(nameof(Patientinstruction));
            }
        }        /// <summary>
        /// Relevanthistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relevanthistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Relevanthistory
        {
            get => _relevanthistory;
            set
            {
                _relevanthistory = value;
                OnPropertyChanged(nameof(Relevanthistory));
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
        public ServiceRequestOrderDetailParameterValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Parameterfocus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parameterfocus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Parameterfocus
        {
            get => _parameterfocus;
            set
            {
                _parameterfocus = value;
                OnPropertyChanged(nameof(Parameterfocus));
            }
        }        /// <summary>
        /// Parameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parameter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ServiceRequestOrderDetailParameter>? Parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                OnPropertyChanged(nameof(Parameter));
            }
        }        /// <summary>
        /// Instruction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instruction 的詳細描述。
        /// </para>
        /// </remarks>
        public ServiceRequestPatientInstructionInstructionChoice? Instruction
        {
            get => _instruction;
            set
            {
                _instruction = value;
                OnPropertyChanged(nameof(Instruction));
            }
        }        /// <summary>
        /// 建立新的 ServiceRequest 資源實例
        /// </summary>
        public ServiceRequest()
        {
        }

        /// <summary>
        /// 建立新的 ServiceRequest 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ServiceRequest(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ServiceRequest(Id: {Id})";
        }
    }    /// <summary>
    /// ServiceRequestOrderDetailParameter 背骨元素
    /// </summary>
    public class ServiceRequestOrderDetailParameter
    {
        // TODO: 添加屬性實作
        
        public ServiceRequestOrderDetailParameter() { }
    }    /// <summary>
    /// ServiceRequestOrderDetail 背骨元素
    /// </summary>
    public class ServiceRequestOrderDetail
    {
        // TODO: 添加屬性實作
        
        public ServiceRequestOrderDetail() { }
    }    /// <summary>
    /// ServiceRequestPatientInstruction 背骨元素
    /// </summary>
    public class ServiceRequestPatientInstruction
    {
        // TODO: 添加屬性實作
        
        public ServiceRequestPatientInstruction() { }
    }    /// <summary>
    /// ServiceRequestOrderDetailParameterValueChoice 選擇類型
    /// </summary>
    public class ServiceRequestOrderDetailParameterValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ServiceRequestOrderDetailParameterValueChoice(JsonObject value) : base("servicerequestorderdetailparametervalue", value, _supportType) { }
        public ServiceRequestOrderDetailParameterValueChoice(IComplexType? value) : base("servicerequestorderdetailparametervalue", value) { }
        public ServiceRequestOrderDetailParameterValueChoice(IPrimitiveType? value) : base("servicerequestorderdetailparametervalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ServiceRequestOrderDetailParameterValue" : "servicerequestorderdetailparametervalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ServiceRequestQuantityChoice 選擇類型
    /// </summary>
    public class ServiceRequestQuantityChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ServiceRequestQuantityChoice(JsonObject value) : base("servicerequestquantity", value, _supportType) { }
        public ServiceRequestQuantityChoice(IComplexType? value) : base("servicerequestquantity", value) { }
        public ServiceRequestQuantityChoice(IPrimitiveType? value) : base("servicerequestquantity", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ServiceRequestQuantity" : "servicerequestquantity";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ServiceRequestOccurrenceChoice 選擇類型
    /// </summary>
    public class ServiceRequestOccurrenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ServiceRequestOccurrenceChoice(JsonObject value) : base("servicerequestoccurrence", value, _supportType) { }
        public ServiceRequestOccurrenceChoice(IComplexType? value) : base("servicerequestoccurrence", value) { }
        public ServiceRequestOccurrenceChoice(IPrimitiveType? value) : base("servicerequestoccurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ServiceRequestOccurrence" : "servicerequestoccurrence";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ServiceRequestAsNeededChoice 選擇類型
    /// </summary>
    public class ServiceRequestAsNeededChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ServiceRequestAsNeededChoice(JsonObject value) : base("servicerequestasneeded", value, _supportType) { }
        public ServiceRequestAsNeededChoice(IComplexType? value) : base("servicerequestasneeded", value) { }
        public ServiceRequestAsNeededChoice(IPrimitiveType? value) : base("servicerequestasneeded", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ServiceRequestAsNeeded" : "servicerequestasneeded";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ServiceRequestPatientInstructionInstructionChoice 選擇類型
    /// </summary>
    public class ServiceRequestPatientInstructionInstructionChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ServiceRequestPatientInstructionInstructionChoice(JsonObject value) : base("servicerequestpatientinstructioninstruction", value, _supportType) { }
        public ServiceRequestPatientInstructionInstructionChoice(IComplexType? value) : base("servicerequestpatientinstructioninstruction", value) { }
        public ServiceRequestPatientInstructionInstructionChoice(IPrimitiveType? value) : base("servicerequestpatientinstructioninstruction", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ServiceRequestPatientInstructionInstruction" : "servicerequestpatientinstructioninstruction";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
