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
    /// FHIR R4 OperationDefinition 資源
    /// 
    /// <para>
    /// A formal computable definition of an operation (on the RESTful interface) or a named query (using the search interaction).
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var operationdefinition = new OperationDefinition("operationdefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 OperationDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class OperationDefinition : ResourceBase<R4Version>
    {
        private FhirBoolean? _affectsstate;

        /// <summary>
        /// affectsState
        /// </summary>
        /// <remarks>
        /// <para>
        /// affectsState 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? affectsState
        {
            get => _affectsstate;
            set
            {
                _affectsstate = value;
                OnPropertyChanged(nameof(affectsState));
            }
        }

        private FhirCanonical? _base;

        /// <summary>
        /// base
        /// </summary>
        /// <remarks>
        /// <para>
        /// base 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? base
        {
            get => _base;
            set
            {
                _base = value;
                OnPropertyChanged(nameof(base));
            }
        }

        private FhirCode? _code;

        /// <summary>
        /// code
        /// </summary>
        /// <remarks>
        /// <para>
        /// code 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(code));
            }
        }

        private FhirMarkdown? _comment;

        /// <summary>
        /// comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(comment));
            }
        }

        private List<FhirString>? _contact;

        /// <summary>
        /// contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(contact));
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

        private FhirDateTime? _date;

        /// <summary>
        /// date
        /// </summary>
        /// <remarks>
        /// <para>
        /// date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(date));
            }
        }

        private FhirMarkdown? _description;

        /// <summary>
        /// description
        /// </summary>
        /// <remarks>
        /// <para>
        /// description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(description));
            }
        }

        private FhirBoolean? _experimental;

        /// <summary>
        /// experimental
        /// </summary>
        /// <remarks>
        /// <para>
        /// experimental 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? experimental
        {
            get => _experimental;
            set
            {
                _experimental = value;
                OnPropertyChanged(nameof(experimental));
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

        private FhirCanonical? _inputprofile;

        /// <summary>
        /// inputProfile
        /// </summary>
        /// <remarks>
        /// <para>
        /// inputProfile 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? inputProfile
        {
            get => _inputprofile;
            set
            {
                _inputprofile = value;
                OnPropertyChanged(nameof(inputProfile));
            }
        }

        private FhirBoolean? _instance;

        /// <summary>
        /// instance
        /// </summary>
        /// <remarks>
        /// <para>
        /// instance 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? instance
        {
            get => _instance;
            set
            {
                _instance = value;
                OnPropertyChanged(nameof(instance));
            }
        }

        private List<CodeableConcept>? _jurisdiction;

        /// <summary>
        /// jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(jurisdiction));
            }
        }

        private FhirCode? _kind;

        /// <summary>
        /// kind
        /// </summary>
        /// <remarks>
        /// <para>
        /// kind 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? kind
        {
            get => _kind;
            set
            {
                _kind = value;
                OnPropertyChanged(nameof(kind));
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

        private FhirString? _name;

        /// <summary>
        /// name
        /// </summary>
        /// <remarks>
        /// <para>
        /// name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(name));
            }
        }

        private FhirCanonical? _outputprofile;

        /// <summary>
        /// outputProfile
        /// </summary>
        /// <remarks>
        /// <para>
        /// outputProfile 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? outputProfile
        {
            get => _outputprofile;
            set
            {
                _outputprofile = value;
                OnPropertyChanged(nameof(outputProfile));
            }
        }

        private List<BackboneElement>? _overload;

        /// <summary>
        /// overload
        /// </summary>
        /// <remarks>
        /// <para>
        /// overload 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? overload
        {
            get => _overload;
            set
            {
                _overload = value;
                OnPropertyChanged(nameof(overload));
            }
        }

        private List<BackboneElement>? _parameter;

        /// <summary>
        /// parameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// parameter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                OnPropertyChanged(nameof(parameter));
            }
        }

        private FhirString? _publisher;

        /// <summary>
        /// publisher
        /// </summary>
        /// <remarks>
        /// <para>
        /// publisher 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? publisher
        {
            get => _publisher;
            set
            {
                _publisher = value;
                OnPropertyChanged(nameof(publisher));
            }
        }

        private FhirMarkdown? _purpose;

        /// <summary>
        /// purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(purpose));
            }
        }

        private List<FhirCode>? _resource;

        /// <summary>
        /// resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// resource 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(resource));
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

        private FhirBoolean? _system;

        /// <summary>
        /// system
        /// </summary>
        /// <remarks>
        /// <para>
        /// system 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? system
        {
            get => _system;
            set
            {
                _system = value;
                OnPropertyChanged(nameof(system));
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

        private FhirString? _title;

        /// <summary>
        /// title
        /// </summary>
        /// <remarks>
        /// <para>
        /// title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(title));
            }
        }

        private FhirBoolean? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        private FhirUri? _url;

        /// <summary>
        /// url
        /// </summary>
        /// <remarks>
        /// <para>
        /// url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(url));
            }
        }

        private List<FhirString>? _usecontext;

        /// <summary>
        /// useContext
        /// </summary>
        /// <remarks>
        /// <para>
        /// useContext 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? useContext
        {
            get => _usecontext;
            set
            {
                _usecontext = value;
                OnPropertyChanged(nameof(useContext));
            }
        }

        private FhirString? _version;

        /// <summary>
        /// version
        /// </summary>
        /// <remarks>
        /// <para>
        /// version 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(version));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "OperationDefinition";

        /// <summary>
        /// 建立新的 OperationDefinition 資源實例
        /// </summary>
        public OperationDefinition()
        {
        }

        /// <summary>
        /// 建立新的 OperationDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public OperationDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"OperationDefinition(Id: {Id})";
        }
    }
}
