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
    /// FHIR R5 ArtifactAssessment 資源
    /// 
    /// <para>
    /// ArtifactAssessment 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var artifactassessment = new ArtifactAssessment("artifactassessment-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ArtifactAssessment 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ArtifactAssessment : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirString? _title;
        private ArtifactAssessmentCiteAsChoice? _citeas;
        private FhirDateTime? _date;
        private FhirMarkdown? _copyright;
        private FhirDate? _approvaldate;
        private FhirDate? _lastreviewdate;
        private ArtifactAssessmentArtifactChoice? _artifact;
        private List<ArtifactAssessmentContent>? _content;
        private FhirCode? _workflowstatus;
        private FhirCode? _disposition;
        private FhirCode? _informationtype;
        private FhirMarkdown? _summary;
        private CodeableConcept? _type;
        private List<CodeableConcept>? _classifier;
        private Quantity? _quantity;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;
        private List<FhirUri>? _path;
        private List<RelatedArtifact>? _relatedartifact;
        private FhirBoolean? _freetoshare;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ArtifactAssessment";        /// <summary>
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
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Citeas
        /// </summary>
        /// <remarks>
        /// <para>
        /// Citeas 的詳細描述。
        /// </para>
        /// </remarks>
        public ArtifactAssessmentCiteAsChoice? Citeas
        {
            get => _citeas;
            set
            {
                _citeas = value;
                OnPropertyChanged(nameof(Citeas));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Copyright
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copyright 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Copyright
        {
            get => _copyright;
            set
            {
                _copyright = value;
                OnPropertyChanged(nameof(Copyright));
            }
        }        /// <summary>
        /// Approvaldate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Approvaldate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Approvaldate
        {
            get => _approvaldate;
            set
            {
                _approvaldate = value;
                OnPropertyChanged(nameof(Approvaldate));
            }
        }        /// <summary>
        /// Lastreviewdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lastreviewdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Lastreviewdate
        {
            get => _lastreviewdate;
            set
            {
                _lastreviewdate = value;
                OnPropertyChanged(nameof(Lastreviewdate));
            }
        }        /// <summary>
        /// Artifact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Artifact 的詳細描述。
        /// </para>
        /// </remarks>
        public ArtifactAssessmentArtifactChoice? Artifact
        {
            get => _artifact;
            set
            {
                _artifact = value;
                OnPropertyChanged(nameof(Artifact));
            }
        }        /// <summary>
        /// Content
        /// </summary>
        /// <remarks>
        /// <para>
        /// Content 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ArtifactAssessmentContent>? Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }        /// <summary>
        /// Workflowstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Workflowstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Workflowstatus
        {
            get => _workflowstatus;
            set
            {
                _workflowstatus = value;
                OnPropertyChanged(nameof(Workflowstatus));
            }
        }        /// <summary>
        /// Disposition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Disposition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Disposition
        {
            get => _disposition;
            set
            {
                _disposition = value;
                OnPropertyChanged(nameof(Disposition));
            }
        }        /// <summary>
        /// Informationtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Informationtype 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Informationtype
        {
            get => _informationtype;
            set
            {
                _informationtype = value;
                OnPropertyChanged(nameof(Informationtype));
            }
        }        /// <summary>
        /// Summary
        /// </summary>
        /// <remarks>
        /// <para>
        /// Summary 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Summary
        {
            get => _summary;
            set
            {
                _summary = value;
                OnPropertyChanged(nameof(Summary));
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
        /// Classifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Classifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Classifier
        {
            get => _classifier;
            set
            {
                _classifier = value;
                OnPropertyChanged(nameof(Classifier));
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
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }        /// <summary>
        /// Path
        /// </summary>
        /// <remarks>
        /// <para>
        /// Path 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Path
        {
            get => _path;
            set
            {
                _path = value;
                OnPropertyChanged(nameof(Path));
            }
        }        /// <summary>
        /// Relatedartifact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relatedartifact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RelatedArtifact>? Relatedartifact
        {
            get => _relatedartifact;
            set
            {
                _relatedartifact = value;
                OnPropertyChanged(nameof(Relatedartifact));
            }
        }        /// <summary>
        /// Freetoshare
        /// </summary>
        /// <remarks>
        /// <para>
        /// Freetoshare 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Freetoshare
        {
            get => _freetoshare;
            set
            {
                _freetoshare = value;
                OnPropertyChanged(nameof(Freetoshare));
            }
        }        /// <summary>
        /// 建立新的 ArtifactAssessment 資源實例
        /// </summary>
        public ArtifactAssessment()
        {
        }

        /// <summary>
        /// 建立新的 ArtifactAssessment 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ArtifactAssessment(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ArtifactAssessment(Id: {Id})";
        }
    }    /// <summary>
    /// ArtifactAssessmentContent 背骨元素
    /// </summary>
    public class ArtifactAssessmentContent
    {
        // TODO: 添加屬性實作
        
        public ArtifactAssessmentContent() { }
    }    /// <summary>
    /// ArtifactAssessmentCiteAsChoice 選擇類型
    /// </summary>
    public class ArtifactAssessmentCiteAsChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ArtifactAssessmentCiteAsChoice(JsonObject value) : base("artifactassessmentciteas", value, _supportType) { }
        public ArtifactAssessmentCiteAsChoice(IComplexType? value) : base("artifactassessmentciteas", value) { }
        public ArtifactAssessmentCiteAsChoice(IPrimitiveType? value) : base("artifactassessmentciteas", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ArtifactAssessmentCiteAs" : "artifactassessmentciteas";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ArtifactAssessmentArtifactChoice 選擇類型
    /// </summary>
    public class ArtifactAssessmentArtifactChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ArtifactAssessmentArtifactChoice(JsonObject value) : base("artifactassessmentartifact", value, _supportType) { }
        public ArtifactAssessmentArtifactChoice(IComplexType? value) : base("artifactassessmentartifact", value) { }
        public ArtifactAssessmentArtifactChoice(IPrimitiveType? value) : base("artifactassessmentartifact", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ArtifactAssessmentArtifact" : "artifactassessmentartifact";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
