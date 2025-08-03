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
    /// FHIR R4 ClaimResponse 資源
    /// 
    /// <para>
    /// This resource provides the adjudication details from the processing of a Claim resource.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var claimresponse = new ClaimResponse("claimresponse-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 ClaimResponse 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ClaimResponse : ResourceBase<R4Version>
    {
        private List<BackboneElement>? _additem;

        /// <summary>
        /// addItem
        /// </summary>
        /// <remarks>
        /// <para>
        /// addItem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? addItem
        {
            get => _additem;
            set
            {
                _additem = value;
                OnPropertyChanged(nameof(addItem));
            }
        }

        private List<FhirString>? _adjudication;

        /// <summary>
        /// adjudication
        /// </summary>
        /// <remarks>
        /// <para>
        /// adjudication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? adjudication
        {
            get => _adjudication;
            set
            {
                _adjudication = value;
                OnPropertyChanged(nameof(adjudication));
            }
        }

        private List<ReferenceType>? _communicationrequest;

        /// <summary>
        /// communicationRequest
        /// </summary>
        /// <remarks>
        /// <para>
        /// communicationRequest 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? communicationRequest
        {
            get => _communicationrequest;
            set
            {
                _communicationrequest = value;
                OnPropertyChanged(nameof(communicationRequest));
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

        private FhirDateTime? _created;

        /// <summary>
        /// created
        /// </summary>
        /// <remarks>
        /// <para>
        /// created 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? created
        {
            get => _created;
            set
            {
                _created = value;
                OnPropertyChanged(nameof(created));
            }
        }

        private FhirString? _disposition;

        /// <summary>
        /// disposition
        /// </summary>
        /// <remarks>
        /// <para>
        /// disposition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? disposition
        {
            get => _disposition;
            set
            {
                _disposition = value;
                OnPropertyChanged(nameof(disposition));
            }
        }

        private List<BackboneElement>? _error;

        /// <summary>
        /// error
        /// </summary>
        /// <remarks>
        /// <para>
        /// error 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? error
        {
            get => _error;
            set
            {
                _error = value;
                OnPropertyChanged(nameof(error));
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

        private Attachment? _form;

        /// <summary>
        /// form
        /// </summary>
        /// <remarks>
        /// <para>
        /// form 的詳細描述。
        /// </para>
        /// </remarks>
        public Attachment? form
        {
            get => _form;
            set
            {
                _form = value;
                OnPropertyChanged(nameof(form));
            }
        }

        private CodeableConcept? _formcode;

        /// <summary>
        /// formCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// formCode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? formCode
        {
            get => _formcode;
            set
            {
                _formcode = value;
                OnPropertyChanged(nameof(formCode));
            }
        }

        private CodeableConcept? _fundsreserve;

        /// <summary>
        /// fundsReserve
        /// </summary>
        /// <remarks>
        /// <para>
        /// fundsReserve 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? fundsReserve
        {
            get => _fundsreserve;
            set
            {
                _fundsreserve = value;
                OnPropertyChanged(nameof(fundsReserve));
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

        private List<BackboneElement>? _insurance;

        /// <summary>
        /// insurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// insurance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? insurance
        {
            get => _insurance;
            set
            {
                _insurance = value;
                OnPropertyChanged(nameof(insurance));
            }
        }

        private ReferenceType? _insurer;

        /// <summary>
        /// insurer
        /// </summary>
        /// <remarks>
        /// <para>
        /// insurer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? insurer
        {
            get => _insurer;
            set
            {
                _insurer = value;
                OnPropertyChanged(nameof(insurer));
            }
        }

        private List<BackboneElement>? _item;

        /// <summary>
        /// item
        /// </summary>
        /// <remarks>
        /// <para>
        /// item 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(item));
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

        private FhirCode? _outcome;

        /// <summary>
        /// outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(outcome));
            }
        }

        private ReferenceType? _patient;

        /// <summary>
        /// patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// patient 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(patient));
            }
        }

        private CodeableConcept? _payeetype;

        /// <summary>
        /// payeeType
        /// </summary>
        /// <remarks>
        /// <para>
        /// payeeType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? payeeType
        {
            get => _payeetype;
            set
            {
                _payeetype = value;
                OnPropertyChanged(nameof(payeeType));
            }
        }

        private BackboneElement? _payment;

        /// <summary>
        /// payment
        /// </summary>
        /// <remarks>
        /// <para>
        /// payment 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? payment
        {
            get => _payment;
            set
            {
                _payment = value;
                OnPropertyChanged(nameof(payment));
            }
        }

        private Period? _preauthperiod;

        /// <summary>
        /// preAuthPeriod
        /// </summary>
        /// <remarks>
        /// <para>
        /// preAuthPeriod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? preAuthPeriod
        {
            get => _preauthperiod;
            set
            {
                _preauthperiod = value;
                OnPropertyChanged(nameof(preAuthPeriod));
            }
        }

        private FhirString? _preauthref;

        /// <summary>
        /// preAuthRef
        /// </summary>
        /// <remarks>
        /// <para>
        /// preAuthRef 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? preAuthRef
        {
            get => _preauthref;
            set
            {
                _preauthref = value;
                OnPropertyChanged(nameof(preAuthRef));
            }
        }

        private List<BackboneElement>? _processnote;

        /// <summary>
        /// processNote
        /// </summary>
        /// <remarks>
        /// <para>
        /// processNote 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? processNote
        {
            get => _processnote;
            set
            {
                _processnote = value;
                OnPropertyChanged(nameof(processNote));
            }
        }

        private ReferenceType? _request;

        /// <summary>
        /// request
        /// </summary>
        /// <remarks>
        /// <para>
        /// request 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(request));
            }
        }

        private ReferenceType? _requestor;

        /// <summary>
        /// requestor
        /// </summary>
        /// <remarks>
        /// <para>
        /// requestor 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? requestor
        {
            get => _requestor;
            set
            {
                _requestor = value;
                OnPropertyChanged(nameof(requestor));
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

        private CodeableConcept? _subtype;

        /// <summary>
        /// subType
        /// </summary>
        /// <remarks>
        /// <para>
        /// subType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? subType
        {
            get => _subtype;
            set
            {
                _subtype = value;
                OnPropertyChanged(nameof(subType));
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

        private List<BackboneElement>? _total;

        /// <summary>
        /// total
        /// </summary>
        /// <remarks>
        /// <para>
        /// total 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? total
        {
            get => _total;
            set
            {
                _total = value;
                OnPropertyChanged(nameof(total));
            }
        }

        private CodeableConcept? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        private FhirCode? _use;

        /// <summary>
        /// use
        /// </summary>
        /// <remarks>
        /// <para>
        /// use 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? use
        {
            get => _use;
            set
            {
                _use = value;
                OnPropertyChanged(nameof(use));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ClaimResponse";

        /// <summary>
        /// 建立新的 ClaimResponse 資源實例
        /// </summary>
        public ClaimResponse()
        {
        }

        /// <summary>
        /// 建立新的 ClaimResponse 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ClaimResponse(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ClaimResponse(Id: {Id})";
        }
    }
}
