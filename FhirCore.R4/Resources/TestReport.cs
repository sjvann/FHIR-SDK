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
    /// FHIR R4 TestReport 資源
    /// 
    /// <para>
    /// A summary of information based on the results of executing a TestScript.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var testreport = new TestReport("testreport-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 TestReport 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class TestReport : ResourceBase<R4Version>
    {
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

        private Identifier? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? identifier
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

        private FhirDateTime? _issued;

        /// <summary>
        /// issued
        /// </summary>
        /// <remarks>
        /// <para>
        /// issued 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? issued
        {
            get => _issued;
            set
            {
                _issued = value;
                OnPropertyChanged(nameof(issued));
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

        private List<BackboneElement>? _participant;

        /// <summary>
        /// participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(participant));
            }
        }

        private FhirCode? _result;

        /// <summary>
        /// result
        /// </summary>
        /// <remarks>
        /// <para>
        /// result 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(result));
            }
        }

        private FhirDecimal? _score;

        /// <summary>
        /// score
        /// </summary>
        /// <remarks>
        /// <para>
        /// score 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? score
        {
            get => _score;
            set
            {
                _score = value;
                OnPropertyChanged(nameof(score));
            }
        }

        private BackboneElement? _setup;

        /// <summary>
        /// setup
        /// </summary>
        /// <remarks>
        /// <para>
        /// setup 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? setup
        {
            get => _setup;
            set
            {
                _setup = value;
                OnPropertyChanged(nameof(setup));
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

        private BackboneElement? _teardown;

        /// <summary>
        /// teardown
        /// </summary>
        /// <remarks>
        /// <para>
        /// teardown 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? teardown
        {
            get => _teardown;
            set
            {
                _teardown = value;
                OnPropertyChanged(nameof(teardown));
            }
        }

        private List<BackboneElement>? _test;

        /// <summary>
        /// test
        /// </summary>
        /// <remarks>
        /// <para>
        /// test 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? test
        {
            get => _test;
            set
            {
                _test = value;
                OnPropertyChanged(nameof(test));
            }
        }

        private FhirString? _tester;

        /// <summary>
        /// tester
        /// </summary>
        /// <remarks>
        /// <para>
        /// tester 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? tester
        {
            get => _tester;
            set
            {
                _tester = value;
                OnPropertyChanged(nameof(tester));
            }
        }

        private ReferenceType? _testscript;

        /// <summary>
        /// testScript
        /// </summary>
        /// <remarks>
        /// <para>
        /// testScript 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? testScript
        {
            get => _testscript;
            set
            {
                _testscript = value;
                OnPropertyChanged(nameof(testScript));
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

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "TestReport";

        /// <summary>
        /// 建立新的 TestReport 資源實例
        /// </summary>
        public TestReport()
        {
        }

        /// <summary>
        /// 建立新的 TestReport 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public TestReport(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"TestReport(Id: {Id})";
        }
    }
}
