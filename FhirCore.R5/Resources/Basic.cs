using System.ComponentModel.DataAnnotations;
using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 Basic �귽
    /// 
    /// <para>
    /// Basic �O�@�ӳq�θ귽�A�q�`�Ω�O�����b��L FHIR �귽�d�򤺪���T�C
    /// �o�O�@�Ӽu�ʪ��귽�A�D�n�Ω��x�s�򥻸�Ƶ��c�M��ƪ����T�C
    /// </para>
    /// 
    /// <para>
    /// �D�n�γ~�G
    /// - �O���q�Ϊ��ɮ׸�T
    /// - �x�s���b�зǸ귽���c�d�򤺪����
    /// - �Ȧs�ʸ�T���e��
    /// - �ۭq�q�귽���X�R��ƪ���¦
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var basic = new Basic("basic-001")
    /// {
    ///     Code = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = "http://example.com/codes",
    ///                 Code = "patient-info",
    ///                 Display = "Patient Information"
    ///             }
    ///         }
    ///     },
    ///     Subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType { Reference = "Patient/patient-001" },
    ///     Created = new FhirDateTime(DateTime.Now),
    ///     Author = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType { Reference = "Practitioner/practitioner-001" }
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Basic �귽�O FHIR �[�c�����u�ʸ귽���@�A���ѤF�@�ӳq�Ϊ����c�ӰO��
    /// ���b�зǸ귽���c�d�򤺪��U�ظ�T�C�o�S�O���Ω�B�z�S�w�ίS���~�ȻݨD�C
    /// </para>
    /// 
    /// <para>
    /// R5 ������ Basic �귽�۹�� R4 �������D�n�ܧ�G
    /// - �W�j�F���ҳW�h
    /// - ��i�F���p���ˬd
    /// - �s�W�F��h�䴩���
    /// - �j�ƤF Code �ݩʪ��y�z�ʩw�q
    /// </para>
    /// 
    /// <para>
    /// ���ҳW�h�G
    /// - Code �ݩʥ����]�t���Ī� CodeableConcept
    /// - Subject �ݩʥ����]�t���Ī� Reference
    /// - Created ����O���Ӫ��ɶ�
    /// - Author �����O���Ī� Practitioner �� Organization �ޥ�
    /// </para>
    /// 
    /// <para>
    /// �̨ι��G
    /// - �ϥμзǤƪ����e���ѲŸ���F Code
    /// - �T�O Subject �ޥάO���ĨåB�i�d�ߪ�
    /// - ��ĳ�K�[ Created �P Author ��T�Ω�f�p
    /// - �b�i�઺���p�U�A�ɶq�ϥαM���� FHIR �귽�ӫD Basic
    /// </para>
    /// </remarks>
    public class Basic : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private FhirDateTime? _created;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;

        /// <summary>
        /// �귽����
        /// </summary>
        /// <value>�T�w�� "Basic"</value>
        public override string ResourceType => "Basic";

        /// <summary>
        /// �ѧO�X
        /// 
        /// <para>
        /// �Ω��ѧO�� Basic �귽���~���ѧO�X�C�o���ѧO�X�q�`�ѫإ߸귽���t�Ωβ�´���ѡA
        /// �åΩ�b���P�t�ζ��l�ܩΰѷӸӸ귽�C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// basic.Identifier = new List&lt;Identifier&gt;
        /// {
        ///     new Identifier
        ///     {
        ///         System = new FhirUri("http://hospital.example.com/identifiers"),
        ///         Value = new FhirString("BASIC-2024-001")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ѧO�X�Ω�b�S���T�w�t�ΰߤ@�ʪ����ҤU�T�O�귽���ߤ@�ѧO�C�i�H���h���ѧO�X�A
        /// �C���ѧO�X�Ӧۤ��P���t�ΩΥΩ󤣦P���γ~�C
        /// </para>
        /// 
        /// <para>
        /// �`�����γ~�G
        /// - ��|�����t���ѧO�X
        /// - �O�I���q�ѧO�X  
        /// - ��s���ѧO�X
        /// - �ɮקǸ�
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
        /// �N�X
        /// 
        /// <para>
        /// �ѧO�� Basic �귽�ҰO����T���O���N�X�C�o�O�@�ӥ������A
        /// �Ω�Ϥ��M�ѧO Basic �귽���γ~�C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// basic.Code = new CodeableConcept
        /// {
        ///     Coding = new List&lt;Coding&gt;
        ///     {
        ///         new Coding
        ///         {
        ///             System = new FhirUri("http://terminology.hl7.org/CodeSystem/basic-resource-type"),
        ///             Code = new FhirCode("consent"),
        ///             Display = new FhirString("Consent")
        ///         }
        ///     },
        ///     Text = new FhirString("�P�N��")
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code �O Basic �귽���֤��ݩʡA�Ω�w�q�Ӹ귽�O�x�s������������T�C
        /// ��ĳ�ϥμзǤƪ��N�X�t�ΨӽT�O�y�q���@�P�ʡC
        /// </para>
        /// 
        /// <para>
        /// �`�ΥN�X�t�ΡG
        /// - http://terminology.hl7.org/CodeSystem/basic-resource-type
        /// - http://hl7.org/fhir/ValueSet/basic-resource-type
        /// - ��´�S�w���N�X�t��
        /// </para>
        /// 
        /// <para>
        /// ���ҳW�h�G
        /// - �����]�t�ܤ֤@�Ӧ��Ī� Coding �� Text
        /// - Coding �� System �P Code ��������g
        /// - ��ĳ�]�t Display �Ω�H���\Ū
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "Code �O�������")]
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
        /// �D��
        /// 
        /// <para>
        /// �� Basic �귽�ҰO����T���D��C�q�`�O Patient�BGroup �Ψ�L�귽���ޥΡC
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// basic.Subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
        /// {
        ///     Reference = new FhirString("Patient/patient-001"),
        ///     Display = new FhirString("�i�T"),
        ///     Type = new FhirUri("Patient")
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject �w�q�F�� Basic �귽�O����֩Τ��򪺸�T�C�i�H�O�ӤH�B�s��Ψ�L����C
        /// </para>
        /// 
        /// <para>
        /// �`�����D��귽�����G
        /// - Patient: �w�̡]�̱`���^
        /// - Group: �w�̸s��
        /// - Device: �˸m�]��
        /// - Location: ��m����
        /// - Organization: ��´
        /// </para>
        /// 
        /// <para>
        /// ���ҳW�h�G
        /// - Reference �����ŦX FHIR �ޥή榡
        /// - �Q�ޥΪ��귽���ӬO�s�b���]�Y�i�i��d�����ҡ^
        /// - Type �����P�ޥΪ��귽�����@�P
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
        }

        /// <summary>
        /// �إ߮ɶ�
        /// 
        /// <para>
        /// �� Basic �귽�O�O����T�Q�إߩΰO�����ɶ��I�C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// basic.Created = new FhirDateTime(DateTime.Now);
        /// // �ΨϥίS�w�����
        /// basic.Created = new FhirDateTime("2024-01-15T14:30:00+08:00");
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// Created �N��� Basic �귽�O�O����T�Q�إߪ��ɶ��I�C
        /// �o�Ӹ�T���ɶ��ʻP�f�p�l�ܫD�`���n�C
        /// </para>
        /// 
        /// <para>
        /// ���ҳW�h�G
        /// - ����O���Ӫ��ɶ��]���\�̦h5�������t�ήɶ��~�t�^
        /// - �榡�����ŦX FHIR DateTime �з�
        /// - ��ĳ�]�t�ɰϸ�T
        /// </para>
        /// 
        /// <para>
        /// �̨ι��G
        /// - �ϥΨt�Υثe�ɶ��@���w�]��
        /// - �T�O�ɰϸ�T�����T
        /// - �Ҽ{��Ƶo�ͮɶ�vs�O���ɶ����t�O
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
        }

        /// <summary>
        /// �@��
        /// 
        /// <para>
        /// �إߩΰO���� Basic �귽��T���ӤH�β�´�C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// basic.Author = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
        /// {
        ///     Reference = new FhirString("Practitioner/practitioner-001"),
        ///     Display = new FhirString("����v"),
        ///     Type = new FhirUri("Practitioner")
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author �ѧO�t�d�إߩΰO���� Basic �귽��T������C
        /// �o��d���l�ܩM�f�p�l�ܫD�`���n�C
        /// </para>
        /// 
        /// <para>
        /// �`�����@�̸귽�����G
        /// - Practitioner: �����H��
        /// - Organization: ��´���c
        /// - Patient: �w�̥��H�]�ۧڰO���^
        /// - RelatedPerson: �����H���]�p�a�ݡ^
        /// - Device: �۰ʰO���]��
        /// </para>
        /// 
        /// <para>
        /// ���ҳW�h�G
        /// - Reference �������V���Ī��귽���
        /// - �Q�ޥΪ��귽�����㦳�O���Ӹ�T���v��
        /// - Type �����P�ޥΪ��귽�����@�P
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
        }

        /// <summary>
        /// �إ߷s�� Basic �귽���
        /// </summary>
        /// <remarks>
        /// <para>
        /// �إߤ@�ӪŪ� Basic �귽��ҡC�Ҧ��ݩʳ���l�Ƭ� null�C
        /// ��ĳ�b�إ߫�ߧY�]�w���n���ݩʡ]�S�O�O Code�^�C
        /// </para>
        /// </remarks>
        public Basic()
        {
        }

        /// <summary>
        /// �إ߷s�� Basic �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <remarks>
        /// <para>
        /// �إߤ@�Ө㦳���w ID �� Basic �귽��ҡC
        /// </para>
        /// </remarks>
        public Basic(string id)
        {
            Id = id;
        }

        /// <summary>
        /// �إ߷s�� Basic �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="code">�귽�N�X</param>
        /// <param name="subject">�D��ޥ�</param>
        /// <remarks>
        /// <para>
        /// �إߤ@�ӥ]�t�򥻸�T�� Basic �귽��ҡA�æ۰ʳ]�w�إ߮ɶ��C
        /// </para>
        /// </remarks>
        public Basic(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            Id = id;
            Code = code;
            Subject = subject;
            Created = new FhirDateTime(DateTime.Now);
        }

        /// <summary>
        /// �إ߷s�� Basic �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="code">�귽�N�X</param>
        /// <param name="subject">�D��ޥ�</param>
        /// <param name="author">�@�̤ޥ�</param>
        /// <remarks>
        /// <para>
        /// �إߤ@�ӥ]�t����򥻸�T�� Basic �귽��ҡC
        /// </para>
        /// </remarks>
        public Basic(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject, DataTypeServices.DataTypes.SpecialTypes.ReferenceType author)
        {
            Id = id;
            Code = code;
            Subject = subject;
            Author = author;
            Created = new FhirDateTime(DateTime.Now);
        }

        /// <summary>
        /// ���� Basic �귽
        /// </summary>
        /// <returns>���ҵ��G</returns>
        /// <remarks>
        /// <para>
        /// ���ҥH�U���ءG
        /// - �򥻸귽���ҡ]�Ӧ� ResourceBase�^
        /// - Code �ݩʥ����s�b�æ���
        /// - Created ����O���Ӯɶ�
        /// - Subject �P Author �ޥΪ����ĩ�
        /// - R5 �S�w�����ҳW�h�ˬd
        /// </para>
        /// </remarks>
        public override ValidationResult Validate()
        {
            var results = new List<ValidationResult>();

            // ������
            var baseResult = base.Validate();
            if (baseResult != ValidationResult.Success)
            {
                results.Add(baseResult);
            }

            // R5 �S�w����
            results.AddRange(ValidateR5SpecificRules());

            return results.Count == 0 ? ValidationResult.Success! : new ValidationResult("Basic �귽���ҥ���");
        }

        /// <summary>
        /// ���� R5 �S�w�W�h
        /// </summary>
        /// <returns>���ҵ��G�C��</returns>
        /// <remarks>
        /// <para>
        /// ���� R5 �����S�w�����ҳW�h�G
        /// - Code �����]�t���Ī� Coding �� Text
        /// - Created ����O���Ӯɶ�
        /// - Subject �ޥΥ�������
        /// - Author �ޥΥ������V���Ī��귽����
        /// </para>
        /// </remarks>
        private IEnumerable<ValidationResult> ValidateR5SpecificRules()
        {
            var results = new List<ValidationResult>();

            // ���� Code �ݩ�
            if (Code == null)
            {
                results.Add(new ValidationResult("Code �O�������", new[] { nameof(Code) }));
            }
            else
            {
                bool hasValidCoding = Code.Coding?.Any(c => 
                    !string.IsNullOrEmpty(c.System?.Value) && 
                    !string.IsNullOrEmpty(c.Code?.Value)) == true;
                
                bool hasText = !string.IsNullOrEmpty(Code.Text?.Value);

                if (!hasValidCoding && !hasText)
                {
                    results.Add(new ValidationResult("Code �����]�t�ܤ֤@�Ӧ��Ī� Coding �� Text", new[] { nameof(Code) }));
                }
            }

            // ���� Created ���
            if (Created != null)
            {
                var createdDate = Created.Value;
                if (createdDate > DateTime.Now.AddMinutes(5)) // ���\5�������t�ήɶ��~�t
                {
                    results.Add(new ValidationResult("Created ����O���Ӯɶ�", new[] { nameof(Created) }));
                }
            }

            // ���� Subject �ޥ�
            if (Subject != null)
            {
                if (string.IsNullOrEmpty(Subject.Reference?.Value))
                {
                    results.Add(new ValidationResult("Subject �ޥΤ��ର��", new[] { nameof(Subject) }));
                }
                else
                {
                    // �ˬd�ޥή榡
                    var validResourceTypes = new[] { "Patient", "Group", "Device", "Location", "Organization" };
                    var parts = Subject.Reference.Value.Split('/');
                    if (parts.Length >= 1)
                    {
                        var resourceType = parts[0];
                        if (!validResourceTypes.Contains(resourceType))
                        {
                            results.Add(new ValidationResult(
                                $"Subject �ޥΥ������V���Ī��귽����: {string.Join(", ", validResourceTypes)}", 
                                new[] { nameof(Subject) }));
                        }
                    }
                }
            }

            // ���� Author �ޥ�
            if (Author != null)
            {
                if (string.IsNullOrEmpty(Author.Reference?.Value))
                {
                    results.Add(new ValidationResult("Author �ޥΤ��ର��", new[] { nameof(Author) }));
                }
                else
                {
                    // �ˬd�ޥή榡
                    var validResourceTypes = new[] { "Practitioner", "Organization", "Patient", "RelatedPerson", "Device" };
                    var parts = Author.Reference.Value.Split('/');
                    if (parts.Length >= 1)
                    {
                        var resourceType = parts[0];
                        if (!validResourceTypes.Contains(resourceType))
                        {
                            results.Add(new ValidationResult(
                                $"Author �ޥΥ������V���Ī��귽����: {string.Join(", ", validResourceTypes)}", 
                                new[] { nameof(Author) }));
                        }
                    }
                }
            }

            return results;
        }

        /// <summary>
        /// �إ� Basic �귽���`�h�ƻs
        /// </summary>
        /// <returns>�ƻs�� Basic �귽</returns>
        /// <remarks>
        /// <para>
        /// �إ߸� Basic �귽������`�h�ƻs�A�]�t�Ҧ��ݩʩM���X�C
        /// </para>
        /// </remarks>
        public new Basic Clone()
        {
            var clone = (Basic)base.Clone();
            
            // �`�h�ƻs���X
            if (Identifier != null)
            {
                clone.Identifier = new List<Identifier>(Identifier.Select(i => new Identifier
                {
                    System = i.System,
                    Value = i.Value,
                    Type = i.Type
                }));
            }

            return clone;
        }

        /// <summary>
        /// �ഫ���r����
        /// </summary>
        /// <returns>�r����</returns>
        /// <remarks>
        /// <para>
        /// ��^ Basic �귽���r���ܡA�]�t ID �P Code ��T�C
        /// </para>
        /// </remarks>
        public override string ToString()
        {
            var codeDisplay = Code?.Text?.Value ?? 
                             Code?.Coding?.FirstOrDefault()?.Display?.Value ?? 
                             Code?.Coding?.FirstOrDefault()?.Code?.Value ?? 
                             "���]�w";
            
            return $"Basic(Id: {Id}, Code: {codeDisplay})";
        }
    }
}