using System.ComponentModel.DataAnnotations;
using FhirCore.Base;
using FhirCore.Versioning;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 Patient �귽
    /// 
    /// <para>
    /// Patient �귽�Ω�O�����������Υi�౵�������O���A�Ȫ��ӤH�ΰʪ����H�f�έp�M��L�޲z��T�C
    /// �o�O FHIR ���̭��n���귽���@�A�]�t�F�w�̪��򥻨�����T�C
    /// </para>
    /// 
    /// <para>
    /// �D�n�γ~�G
    /// - �O���w�̰򥻸�T�]�m�W�B�ʧO�B�X�ͤ�����^
    /// - �޲z�w���p����T
    /// - �إ߱w�̻P�������c�����Y
    /// - �s�������������O��
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var patient = new Patient("patient-001")
    /// {
    ///     Name = new List&lt;HumanName&gt;
    ///     {
    ///         new HumanName
    ///         {
    ///             Family = new FhirString("�i"),
    ///             Given = new List&lt;FhirString&gt; { new FhirString("�T") }
    ///         }
    ///     },
    ///     Gender = new FhirCode("male"),
    ///     BirthDate = new FhirDate("1990-01-01")
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Patient �귽�O FHIR ���֤߸귽�A�Ω��ѧO���������O���A�Ȫ��ӤH�C
    /// ���]�t�F�w�̪��򥻤H�f�έp��T�M�޲z��T�C
    /// </para>
    /// 
    /// <para>
    /// R5 ������ Patient �귽�۹�� R4 �������D�n�ܧ�G
    /// - �W�j�F���ҳW�h
    /// - ��i�F�ʧO������쪺�B�z
    /// - �W�[�F�s���X�i�䴩
    /// </para>
    /// 
    /// <para>
    /// ���ҳW�h�G
    /// - �ܤ֥������@���ѧO�ũΩm�W
    /// - �ʧO�N�X�����ŦX FHIR �W�d
    /// - �X�ͤ������O���Ӥ��
    /// - �p����T��������
    /// </para>
    /// </remarks>
    public class Patient : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private FhirCode? _gender;
        private FhirDate? _birthDate;
        private List<Address>? _address;
        private CodeableConcept? _maritalStatus;
        private List<Attachment>? _photo;
        private List<PatientContact>? _contact;
        private List<ReferenceType>? _generalPractitioner;
        private ReferenceType? _managingOrganization;
        private List<PatientLink>? _link;

        /// <summary>
        /// �귽����
        /// </summary>
        /// <value>�T�w�� "Patient"</value>
        public override string ResourceType => "Patient";

        /// <summary>
        /// �ѧO�X
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ѧO�X�Ω�b�S�w�t�Ωβ�´���ߤ@�ѧO�w�̡C�i�H���h���ѧO�X�A
        /// �C���ѧO�X�N���P���t�ΩΥγ~�C
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
        /// �O�_�����D���A
        /// </summary>
        /// <remarks>
        /// <para>
        /// Active ������U�t�κ޲z�w�̰O�������A�C�D���D���O���q�`���|�X�{�b
        /// �@�몺�j�M���G���A�����|�O�d�Ω���v�ѦҡC
        /// </para>
        /// </remarks>
        public FhirBoolean? Active
        {
            get => _active;
            set
            {
                _active = value;
                OnPropertyChanged(nameof(Active));
            }
        }

        /// <summary>
        /// �m�W
        /// </summary>
        /// <remarks>
        /// <para>
        /// �m�W�O�w���ѧO�����n�զ������CFHIR �䴩�h�ةm�W�γ~�M�����A
        /// �H�A�����P��ƩM�k�߭n�D�C
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "�w�̥����ܤ֦��@�өm�W���ѧO�X")]
        public List<HumanName>? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// �p���覡
        /// </summary>
        /// <remarks>
        /// <para>
        /// �p���覡�Ω�P�w�̩Ψ�N���p���C�i�H�]�t�h���������p���覡�A
        /// �ë��w��γ~�]�u�@�B�a�x�B����p�����^�C
        /// </para>
        /// </remarks>
        public List<ContactPoint>? Telecom
        {
            get => _telecom;
            set
            {
                _telecom = value;
                OnPropertyChanged(nameof(Telecom));
            }
        }

        /// <summary>
        /// �ʧO
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ʧO�N�X�����ϥ� FHIR �W�w���зǥN�X�G
        /// - male: �k��
        /// - female: �k��
        /// - other: ��L
        /// - unknown: ����
        /// </para>
        /// </remarks>
        public FhirCode? Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        /// <summary>
        /// �X�ͤ��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �X�ͤ���O���n���H�f�έp��T�A�Ω�~�֭p��M�������ҡC
        /// �����O���Ī��L�h����C
        /// </para>
        /// </remarks>
        public FhirDate? BirthDate
        {
            get => _birthDate;
            set
            {
                _birthDate = value;
                OnPropertyChanged(nameof(BirthDate));
            }
        }

        /// <summary>
        /// �a�}
        /// </summary>
        /// <remarks>
        /// <para>
        /// �a�}��T�Ω�l�H�B����p���M�a�z���R�C���]�t�����ԲӪ���T
        /// �H�K�p���M�w��w�̡C
        /// </para>
        /// </remarks>
        public List<Address>? Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        /// <summary>
        /// �B�ê��A
        /// </summary>
        /// <remarks>
        /// <para>
        /// �B�ê��A��T�i��P�����M���M�O�I�ӫO�����C
        /// </para>
        /// </remarks>
        public CodeableConcept? MaritalStatus
        {
            get => _maritalStatus;
            set
            {
                _maritalStatus = value;
                OnPropertyChanged(nameof(MaritalStatus));
            }
        }

        /// <summary>
        /// �Ӥ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// �Ӥ��D�n�Ω󨭥��T�{�A�S�O�O�b��E�εL�k���y�����p�U�C
        /// </para>
        /// </remarks>
        public List<Attachment>? Photo
        {
            get => _photo;
            set
            {
                _photo = value;
                OnPropertyChanged(nameof(Photo));
            }
        }

        /// <summary>
        /// �p���H
        /// </summary>
        /// <remarks>
        /// <para>
        /// �p���H��T����污�p�B�����M���M���q�D�`���n�C
        /// </para>
        /// </remarks>
        public List<PatientContact>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }

        /// <summary>
        /// �a�x��v
        /// </summary>
        /// <remarks>
        /// <para>
        /// �a�x��v��T���U���ձw�̪������������@�C
        /// </para>
        /// </remarks>
        public List<ReferenceType>? GeneralPractitioner
        {
            get => _generalPractitioner;
            set
            {
                _generalPractitioner = value;
                OnPropertyChanged(nameof(GeneralPractitioner));
            }
        }

        /// <summary>
        /// �޲z��´
        /// </summary>
        /// <remarks>
        /// <para>
        /// �޲z��´�q�`�O�ЫةM���@�w�̰O�����������c�C
        /// </para>
        /// </remarks>
        public ReferenceType? ManagingOrganization
        {
            get => _managingOrganization;
            set
            {
                _managingOrganization = value;
                OnPropertyChanged(nameof(ManagingOrganization));
            }
        }

        /// <summary>
        /// �s��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �s���Ω�޲z�w�̰O�������Y�A�p�X�֭��ưO���Ϋإ߮a�x���Y�C
        /// </para>
        /// </remarks>
        public List<PatientLink>? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }

        /// <summary>
        /// ���� Patient �귽
        /// </summary>
        /// <returns>���ҵ��G</returns>
        /// <remarks>
        /// <para>
        /// ����H�U���ҡG
        /// - �򥻸귽���ҡ]�~�Ӧ� ResourceBase�^
        /// - �ܤ֦��@���ѧO�X�Ωm�W
        /// - �ʧO�N�X���ĩ�
        /// - �X�ͤ������O���Ӥ��
        /// - �p����T�榡����
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

            return results.Count == 0 ? ValidationResult.Success! : new ValidationResult("Patient �귽���ҥ���");
        }

        /// <summary>
        /// �إ߷s�� Patient �귽���
        /// </summary>
        public Patient()
        {
        }

        /// <summary>
        /// �إ߷s�� Patient �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        public Patient(string id)
        {
            Id = id;
        }

        /// <summary>
        /// �إ߷s�� Patient �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="name">�w�̩m�W</param>
        /// <param name="gender">�w�̩ʧO</param>
        /// <param name="birthDate">�X�ͤ��</param>
        public Patient(string id, HumanName name, string gender, string birthDate)
        {
            Id = id;
            Name = new List<HumanName> { name };
            Gender = new FhirCode(gender);
            BirthDate = new FhirDate(birthDate);
            Active = new FhirBoolean(true);
        }

        /// <summary>
        /// ���� R5 �S�w�W�h
        /// </summary>
        /// <returns>���ҵ��G�C��</returns>
        private IEnumerable<ValidationResult> ValidateR5SpecificRules()
        {
            var results = new List<ValidationResult>();

            // �ˬd�O�_�ܤ֦��ѧO�X�Ωm�W
            if ((Identifier == null || Identifier.Count == 0) && 
                (Name == null || Name.Count == 0))
            {
                results.Add(new ValidationResult("�w�̥����ܤ֦��@���ѧO�X�Ωm�W", new[] { nameof(Identifier), nameof(Name) }));
            }

            // ���ҩʧO�N�X
            if (Gender != null)
            {
                var validGenders = new[] { "male", "female", "other", "unknown" };
                if (!validGenders.Contains(Gender.Value))
                {
                    results.Add(new ValidationResult($"�ʧO�N�X '{Gender.Value}' �L�ġC���ĭȬ�: {string.Join(", ", validGenders)}", new[] { nameof(Gender) }));
                }
            }

            // ���ҥX�ͤ��
            if (BirthDate != null)
            {
                var birthDate = BirthDate.Value;
                if (birthDate > DateTime.Now.Date)
                {
                    results.Add(new ValidationResult("�X�ͤ������O���Ӥ��", new[] { nameof(BirthDate) }));
                }
            }

            return results;
        }

        /// <summary>
        /// �ഫ���r����
        /// </summary>
        /// <returns>�r����</returns>
        public override string ToString()
        {
            var displayName = Name?.FirstOrDefault()?.Text ?? 
                             $"{Name?.FirstOrDefault()?.Family?.Value} {string.Join(" ", Name?.FirstOrDefault()?.Given?.Select(g => g.Value) ?? Array.Empty<string>())}".Trim();
            
            return $"Patient(Id: {Id}, Name: {displayName ?? "���]�w"})";
        }
    }

    /// <summary>
    /// Patient �p���H
    /// </summary>
    /// <remarks>
    /// <para>
    /// �p���H��T����污�p�B�����M�����v�M�a�x���q�D�`���n�C
    /// </para>
    /// </remarks>
    public class PatientContact
    {
        /// <summary>
        /// �P�w�̪����Y
        /// </summary>
        public List<CodeableConcept>? Relationship { get; set; }

        /// <summary>
        /// �p���H�m�W
        /// </summary>
        public HumanName? Name { get; set; }

        /// <summary>
        /// �p���H���p���覡
        /// </summary>
        public List<ContactPoint>? Telecom { get; set; }

        /// <summary>
        /// �p���H�a�}
        /// </summary>
        public Address? Address { get; set; }

        /// <summary>
        /// �p���H�ʧO
        /// </summary>
        public FhirCode? Gender { get; set; }

        /// <summary>
        /// �p���H���ݲ�´
        /// </summary>
        public ReferenceType? Organization { get; set; }

        /// <summary>
        /// �p���H���Ĵ���
        /// </summary>
        public Period? Period { get; set; }
    }

    /// <summary>
    /// Patient �s��
    /// </summary>
    /// <remarks>
    /// <para>
    /// �s���Ω�B�z���ưO���B�O���X�֡B�Ϋإ߱w�̶������Y�C
    /// </para>
    /// </remarks>
    public class PatientLink
    {
        /// <summary>
        /// �s������L�w�̸귽
        /// </summary>
        public ReferenceType? Other { get; set; }

        /// <summary>
        /// �s������
        /// </summary>
        public FhirCode? Type { get; set; }
    }
}