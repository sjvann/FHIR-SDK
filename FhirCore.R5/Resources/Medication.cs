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
    /// FHIR R5 Medication �귽
    /// 
    /// <para>
    /// �Ω�O���Ī����򥻸�T�A�]�A�Ī��N�X�B�����B�����B�妸�����n��ơC
    /// �D�n�Ω�B��B�t�ġB���İO�����{�ɤu�@�y�{�C
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medication = new Medication("med-001")
    /// {
    ///     Code = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://www.nlm.nih.gov/research/umls/rxnorm"),
    ///                 Code = new FhirCode("313782"),
    ///                 Display = new FhirString("Acetaminophen 325 MG Oral Tablet")
    ///             }
    ///         }
    ///     },
    ///     Status = new FhirCode("active"),
    ///     DoseForm = new CodeableConcept
    ///     {
    ///         Text = new FhirString("Tablet")
    ///     }
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Medication �귽�O FHIR ���Ω�y�z�Ī����֤߸귽�A
    /// �i�H�Ω�B��}�ߡB�Ī��t�o�B���İO�����h���{�ɱ��ҡC
    /// </para>
    /// 
    /// <para>
    /// R5 �������D�n�S�I�G
    /// - �䴩��ԲӪ��Ī������y�z
    /// - �W�j���妸�޲z�\��
    /// - ��i���Ī����A�l��
    /// - �䴩�����������y�z
    /// </para>
    /// </remarks>
    public class Medication : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private CodeableConcept? _code;
        private FhirCode? _status;
        private ReferenceType? _marketingAuthorizationHolder;
        private CodeableConcept? _doseForm;
        private Quantity? _totalVolume;
        private List<MedicationIngredient>? _ingredient;
        private MedicationBatch? _batch;
        private ReferenceType? _definition;

        /// <summary>
        /// �귽����
        /// </summary>
        public override string ResourceType => "Medication";

        /// <summary>
        /// �ѧO�X
        /// </summary>
        /// <remarks>
        /// <para>
        /// �Ī����U���ѧO�X�A�p�ī~�\�i�Ҹ��X�B�|���ĽX���C
        /// </para>
        /// </remarks>
        public List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }

        /// <summary>
        /// �Ī��N�X
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ϥμз��Ī��N�X�t�Ρ]�p RxNorm�BATC ���^�Ӵy�z�Ī��C
        /// �o�O�Ī��ѧO���D�n�̾ڡC
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "�Ī������]�t�N�X")]
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }

        /// <summary>
        /// �Ī����A
        /// </summary>
        /// <remarks>
        /// <para>
        /// �y�z�Ī�����e���A�A�p active�]���D�^�Binactive�]�D���D�^�B
        /// entered-in-error�]���~��J�^���C
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
        }

        /// <summary>
        /// �ī~�\�i�ҫ�����
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ޥέt�d�Ī��W���\�i����´�A�q�`�O�s�Ĥ��q�C
        /// </para>
        /// </remarks>
        public ReferenceType? MarketingAuthorizationHolder
        {
            get => _marketingAuthorizationHolder;
            set
            {
                _marketingAuthorizationHolder = value;
                OnPropertyChanged(nameof(MarketingAuthorizationHolder));
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <remarks>
        /// <para>
        /// �Ī��������A�p�����B���n�B�`�g�����C
        /// </para>
        /// </remarks>
        public CodeableConcept? DoseForm
        {
            get => _doseForm;
            set
            {
                _doseForm = value;
                OnPropertyChanged(nameof(DoseForm));
            }
        }

        /// <summary>
        /// �`��n
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���Ī����G��ɡA�y�z���`��n�C
        /// </para>
        /// </remarks>
        public Quantity? TotalVolume
        {
            get => _totalVolume;
            set
            {
                _totalVolume = value;
                OnPropertyChanged(nameof(TotalVolume));
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <remarks>
        /// <para>
        /// �Ī������ʦ����M�D���ʦ����C��C
        /// </para>
        /// </remarks>
        public List<MedicationIngredient>? Ingredient
        {
            get => _ingredient;
            set
            {
                _ingredient = value;
                OnPropertyChanged(nameof(Ingredient));
            }
        }

        /// <summary>
        /// �妸��T
        /// </summary>
        /// <remarks>
        /// <para>
        /// �S�w�妸���Ī���T�A�p�帹�B���Ĵ������C
        /// </para>
        /// </remarks>
        public MedicationBatch? Batch
        {
            get => _batch;
            set
            {
                _batch = value;
                OnPropertyChanged(nameof(Batch));
            }
        }

        /// <summary>
        /// �Ī��w�q�ޥ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ޥΧ�ԲӪ��Ī��w�q�귽�]MedicationKnowledge�^�C
        /// </para>
        /// </remarks>
        public ReferenceType? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }

        /// <summary>
        /// �إ߷s�� Medication �귽���
        /// </summary>
        public Medication()
        {
        }

        /// <summary>
        /// �إ߷s�� Medication �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        public Medication(string id)
        {
            Id = id;
        }

        /// <summary>
        /// �إ߷s�� Medication �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="code">�Ī��N�X</param>
        public Medication(string id, CodeableConcept code)
        {
            Id = id;
            Code = code;
            Status = new FhirCode("active");
        }

        /// <summary>
        /// �ഫ���r����
        /// </summary>
        public override string ToString()
        {
            var displayName = Code?.Text?.Value ?? 
                              Code?.Coding?.FirstOrDefault()?.Display?.Value ?? 
                              "���R�W�Ī�";

            var status = Status?.Value ?? "���A����";
            return $"Medication(Id: {Id}, Name: {displayName}, Status: {status})";
        }
    }

    /// <summary>
    /// �Ī�����
    /// </summary>
    /// <remarks>
    /// <para>
    /// �y�z�Ī������U�ئ����A�]�A���ʦ����M�D���ʦ����C
    /// </para>
    /// </remarks>
    public class MedicationIngredient
    {
        /// <summary>
        /// ��������
        /// </summary>
        /// <remarks>
        /// <para>
        /// �i�H�O�N�X�ι��L�귽���ޥΡC
        /// </para>
        /// </remarks>
        public CodeableReference? Item { get; set; }

        /// <summary>
        /// �O�_�����ʦ���
        /// </summary>
        /// <remarks>
        /// <para>
        /// true ��ܬ��ʦ����Afalse ��ܫD���ʦ����]�p��ξ��^�C
        /// </para>
        /// </remarks>
        public FhirBoolean? IsActive { get; set; }

        /// <summary>
        /// �����j��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �i�H�Τ�ҡB�N�X�����μƶq�Ӫ�ܦ������j�סC
        /// </para>
        /// </remarks>
        public MedicationIngredientStrengthChoice? Strength { get; set; }

        public MedicationIngredient() { }

        public MedicationIngredient(CodeableReference item, bool isActive = true)
        {
            Item = item;
            IsActive = new FhirBoolean(isActive);
        }
    }

    /// <summary>
    /// �Ī��妸��T
    /// </summary>
    /// <remarks>
    /// <para>
    /// �O���S�w�妸�Ī����帹�M���Ĵ�������T�C
    /// </para>
    /// </remarks>
    public class MedicationBatch
    {
        /// <summary>
        /// �帹
        /// </summary>
        public FhirString? LotNumber { get; set; }

        /// <summary>
        /// ���Ĵ���
        /// </summary>
        public FhirDateTime? ExpirationDate { get; set; }

        public MedicationBatch() { }

        public MedicationBatch(string lotNumber, DateTime? expirationDate = null)
        {
            LotNumber = new FhirString(lotNumber);
            if (expirationDate.HasValue)
            {
                ExpirationDate = new FhirDateTime(expirationDate.Value);
            }
        }
    }

    /// <summary>
    /// �Ī������j�׿������
    /// </summary>
    /// <remarks>
    /// <para>
    /// �i�H�ϥΤ�ҡB�N�X�����μƶq�Ӫ�ܦ����j�סC
    /// </para>
    /// </remarks>
    public class MedicationIngredientStrengthChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "Ratio", "CodeableConcept", "Quantity" };

        public MedicationIngredientStrengthChoice(JsonObject value) : base("strength", value, _supportType) { }
        public MedicationIngredientStrengthChoice(IComplexType? value) : base("strength", value) { }
        public MedicationIngredientStrengthChoice(IPrimitiveType? value) : base("strength", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Strength" : "strength";

        public override List<string> SetSupportDataType() => _supportType;
    }
}