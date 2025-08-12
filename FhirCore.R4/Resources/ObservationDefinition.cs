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
    /// FHIR R4 ObservationDefinition 資源
    /// 
    /// <para>
    /// Set of definitional characteristics for a kind of observation or measurement produced or consumed by an orderable health care service.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var observationdefinition = new ObservationDefinition("observationdefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 ObservationDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ObservationDefinition : ResourceBase<R4Version>
    {
        private ReferenceType? _abnormalcodedvalueset;

        /// <summary>
        /// abnormalCodedValueSet
        /// </summary>
        /// <remarks>
        /// <para>
        /// abnormalCodedValueSet 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? abnormalCodedValueSet
        {
            get => _abnormalcodedvalueset;
            set
            {
                _abnormalcodedvalueset = value;
                OnPropertyChanged(nameof(abnormalCodedValueSet));
            }
        }

        private List<CodeableConcept>? _category;

        /// <summary>
        /// category
        /// </summary>
        /// <remarks>
        /// <para>
        /// category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(category));
            }
        }

        private CodeableConcept? _code;

        /// <summary>
        /// code
        /// </summary>
        /// <remarks>
        /// <para>
        /// code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(code));
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

        private ReferenceType? _criticalcodedvalueset;

        /// <summary>
        /// criticalCodedValueSet
        /// </summary>
        /// <remarks>
        /// <para>
        /// criticalCodedValueSet 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? criticalCodedValueSet
        {
            get => _criticalcodedvalueset;
            set
            {
                _criticalcodedvalueset = value;
                OnPropertyChanged(nameof(criticalCodedValueSet));
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

        private CodeableConcept? _method;

        /// <summary>
        /// method
        /// </summary>
        /// <remarks>
        /// <para>
        /// method 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? method
        {
            get => _method;
            set
            {
                _method = value;
                OnPropertyChanged(nameof(method));
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

        private FhirBoolean? _multipleresultsallowed;

        /// <summary>
        /// multipleResultsAllowed
        /// </summary>
        /// <remarks>
        /// <para>
        /// multipleResultsAllowed 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? multipleResultsAllowed
        {
            get => _multipleresultsallowed;
            set
            {
                _multipleresultsallowed = value;
                OnPropertyChanged(nameof(multipleResultsAllowed));
            }
        }

        private ReferenceType? _normalcodedvalueset;

        /// <summary>
        /// normalCodedValueSet
        /// </summary>
        /// <remarks>
        /// <para>
        /// normalCodedValueSet 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? normalCodedValueSet
        {
            get => _normalcodedvalueset;
            set
            {
                _normalcodedvalueset = value;
                OnPropertyChanged(nameof(normalCodedValueSet));
            }
        }

        private List<FhirCode>? _permitteddatatype;

        /// <summary>
        /// permittedDataType
        /// </summary>
        /// <remarks>
        /// <para>
        /// permittedDataType 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? permittedDataType
        {
            get => _permitteddatatype;
            set
            {
                _permitteddatatype = value;
                OnPropertyChanged(nameof(permittedDataType));
            }
        }

        private FhirString? _preferredreportname;

        /// <summary>
        /// preferredReportName
        /// </summary>
        /// <remarks>
        /// <para>
        /// preferredReportName 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? preferredReportName
        {
            get => _preferredreportname;
            set
            {
                _preferredreportname = value;
                OnPropertyChanged(nameof(preferredReportName));
            }
        }

        private List<BackboneElement>? _qualifiedinterval;

        /// <summary>
        /// qualifiedInterval
        /// </summary>
        /// <remarks>
        /// <para>
        /// qualifiedInterval 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? qualifiedInterval
        {
            get => _qualifiedinterval;
            set
            {
                _qualifiedinterval = value;
                OnPropertyChanged(nameof(qualifiedInterval));
            }
        }

        private BackboneElement? _quantitativedetails;

        /// <summary>
        /// quantitativeDetails
        /// </summary>
        /// <remarks>
        /// <para>
        /// quantitativeDetails 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? quantitativeDetails
        {
            get => _quantitativedetails;
            set
            {
                _quantitativedetails = value;
                OnPropertyChanged(nameof(quantitativeDetails));
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

        private ReferenceType? _validcodedvalueset;

        /// <summary>
        /// validCodedValueSet
        /// </summary>
        /// <remarks>
        /// <para>
        /// validCodedValueSet 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? validCodedValueSet
        {
            get => _validcodedvalueset;
            set
            {
                _validcodedvalueset = value;
                OnPropertyChanged(nameof(validCodedValueSet));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ObservationDefinition";

        /// <summary>
        /// 建立新的 ObservationDefinition 資源實例
        /// </summary>
        public ObservationDefinition()
        {
        }

        /// <summary>
        /// 建立新的 ObservationDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ObservationDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ObservationDefinition(Id: {Id})";
        }
    }
}
