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
    /// FHIR R4 VerificationResult 資源
    /// 
    /// <para>
    /// Describes validation requirements, source(s), status and dates for one or more elements.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var verificationresult = new VerificationResult("verificationresult-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 VerificationResult 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class VerificationResult : ResourceBase<R4Version>
    {
        private BackboneElement? _attestation;

        /// <summary>
        /// attestation
        /// </summary>
        /// <remarks>
        /// <para>
        /// attestation 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? attestation
        {
            get => _attestation;
            set
            {
                _attestation = value;
                OnPropertyChanged(nameof(attestation));
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

        private CodeableConcept? _failureaction;

        /// <summary>
        /// failureAction
        /// </summary>
        /// <remarks>
        /// <para>
        /// failureAction 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? failureAction
        {
            get => _failureaction;
            set
            {
                _failureaction = value;
                OnPropertyChanged(nameof(failureAction));
            }
        }

        private Timing? _frequency;

        /// <summary>
        /// frequency
        /// </summary>
        /// <remarks>
        /// <para>
        /// frequency 的詳細描述。
        /// </para>
        /// </remarks>
        public Timing? frequency
        {
            get => _frequency;
            set
            {
                _frequency = value;
                OnPropertyChanged(nameof(frequency));
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

        private FhirDateTime? _lastperformed;

        /// <summary>
        /// lastPerformed
        /// </summary>
        /// <remarks>
        /// <para>
        /// lastPerformed 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? lastPerformed
        {
            get => _lastperformed;
            set
            {
                _lastperformed = value;
                OnPropertyChanged(nameof(lastPerformed));
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

        private CodeableConcept? _need;

        /// <summary>
        /// need
        /// </summary>
        /// <remarks>
        /// <para>
        /// need 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? need
        {
            get => _need;
            set
            {
                _need = value;
                OnPropertyChanged(nameof(need));
            }
        }

        private FhirDate? _nextscheduled;

        /// <summary>
        /// nextScheduled
        /// </summary>
        /// <remarks>
        /// <para>
        /// nextScheduled 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? nextScheduled
        {
            get => _nextscheduled;
            set
            {
                _nextscheduled = value;
                OnPropertyChanged(nameof(nextScheduled));
            }
        }

        private List<BackboneElement>? _primarysource;

        /// <summary>
        /// primarySource
        /// </summary>
        /// <remarks>
        /// <para>
        /// primarySource 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? primarySource
        {
            get => _primarysource;
            set
            {
                _primarysource = value;
                OnPropertyChanged(nameof(primarySource));
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

        private FhirDateTime? _statusdate;

        /// <summary>
        /// statusDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// statusDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? statusDate
        {
            get => _statusdate;
            set
            {
                _statusdate = value;
                OnPropertyChanged(nameof(statusDate));
            }
        }

        private List<ReferenceType>? _target;

        /// <summary>
        /// target
        /// </summary>
        /// <remarks>
        /// <para>
        /// target 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(target));
            }
        }

        private List<FhirString>? _targetlocation;

        /// <summary>
        /// targetLocation
        /// </summary>
        /// <remarks>
        /// <para>
        /// targetLocation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? targetLocation
        {
            get => _targetlocation;
            set
            {
                _targetlocation = value;
                OnPropertyChanged(nameof(targetLocation));
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

        private List<CodeableConcept>? _validationprocess;

        /// <summary>
        /// validationProcess
        /// </summary>
        /// <remarks>
        /// <para>
        /// validationProcess 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? validationProcess
        {
            get => _validationprocess;
            set
            {
                _validationprocess = value;
                OnPropertyChanged(nameof(validationProcess));
            }
        }

        private CodeableConcept? _validationtype;

        /// <summary>
        /// validationType
        /// </summary>
        /// <remarks>
        /// <para>
        /// validationType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? validationType
        {
            get => _validationtype;
            set
            {
                _validationtype = value;
                OnPropertyChanged(nameof(validationType));
            }
        }

        private List<BackboneElement>? _validator;

        /// <summary>
        /// validator
        /// </summary>
        /// <remarks>
        /// <para>
        /// validator 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? validator
        {
            get => _validator;
            set
            {
                _validator = value;
                OnPropertyChanged(nameof(validator));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "VerificationResult";

        /// <summary>
        /// 建立新的 VerificationResult 資源實例
        /// </summary>
        public VerificationResult()
        {
        }

        /// <summary>
        /// 建立新的 VerificationResult 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public VerificationResult(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"VerificationResult(Id: {Id})";
        }
    }
}
