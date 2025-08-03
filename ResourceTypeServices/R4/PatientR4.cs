using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using FhirCore.Base;
using FhirCore.Interfaces;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;

namespace ResourceTypeServices.R4
{
    /// <summary>
    /// FHIR R4 Patient �귽
    /// 
    /// <para>
    /// Patient �귽�[�\�F�q�����O��������o�@�z�Ψ�L���d�����A�Ȫ��ӤH�ΰʪ����H�f�έp�M��L�޲z��T�C
    /// �w�̪��ƾڳq�`�]�A�]��������^�m�W�B�p����T�B�ʧO�B�X�ͤ���B�a�}�B�q�ܵ��C
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var patient = new PatientR4("patient-001")
    /// {
    ///     Active = new FhirBoolean(true),
    ///     Name = new List&lt;HumanName&gt;
    ///     {
    ///         new HumanName
    ///         {
    ///             Use = new FhirCode("official"),
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
    /// R4 ������ Patient �귽�䴩�H�U�\��G
    /// - �򥻤H�f�έp��T
    /// - �h���p���覡
    /// - �h���a�}
    /// - �Ӥ�����
    /// - ����p���H��T
    /// - �����O�����Ѫ̰Ѧ�
    /// - �P��L Patient �귽���s��
    /// </para>
    /// 
    /// <para>
    /// ���ҳW�h�G
    /// - �ܤֻݭn�@���ѧO�X�Ωm�W
    /// - �ʧO�ȥ����O���Ī� FHIR �N�X (male, female, other, unknown)
    /// - �X�ͤ������O���Ӥ��
    /// - �p���覡��������
    /// - �a�}�榡�������T
    /// </para>
    /// </remarks>
    public class PatientR4 : ResourceBase
    {
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private FhirCode? _gender;
        private FhirDate? _birthDate;
        private FhirBoolean? _deceased;
        private FhirDateTime? _deceasedDateTime;
        private List<Address>? _address;
        private CodeableConcept? _maritalStatus;
        private FhirBoolean? _multipleBirthBoolean;
        private FhirInteger? _multipleBirthInteger;
        private List<Attachment>? _photo;
        private List<PatientContactR4>? _contact;
        private List<PatientCommunicationR4>? _communication;
        private List<ReferenceType>? _generalPractitioner;
        private ReferenceType? _managingOrganization;
        private List<PatientLinkR4>? _link;

        /// <summary>
        /// �귽����
        /// </summary>
        /// <value>�T�w�� "Patient"</value>
        public override string ResourceType => "Patient";

        /// <summary>
        /// ���o FHIR ����
        /// </summary>
        /// <returns>R4 ������ "4.0.1"</returns>
        public override string GetFhirVersion() => "4.0.1";

        /// <summary>
        /// �ѧO�X
        /// 
        /// <para>
        /// �Ω��ѧO���w�̪��~���ѧO�X�C�o���ѧO�X�q�`�������O���t�Τ��t�A
        /// �p�����O�����X�B���|�O�I���X���C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Identifier = new List&lt;Identifier&gt;
        /// {
        ///     new Identifier
        ///     {
        ///         Use = new FhirCode("usual"),
        ///         Type = new CodeableConcept
        ///         {
        ///             Coding = new List&lt;Coding&gt;
        ///             {
        ///                 new Coding
        ///                 {
        ///                     System = new FhirUri("http://terminology.hl7.org/CodeSystem/v2-0203"),
        ///                     Code = new FhirCode("MR"),
        ///                     Display = new FhirString("Medical Record Number")
        ///                 }
        ///             }
        ///         },
        ///         System = new FhirUri("http://hospital.example.com/patients"),
        ///         Value = new FhirString("12345")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ѧO�X�b�����O�����D�`���n�A�Ω�G
        /// - �ߤ@�ѧO�w��
        /// - ��t�θ�ƥ洫
        /// - �קK�w�̰O������
        /// - �䴩������T���s��
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
        /// 
        /// <para>
        /// ���ܦ��w�̰O���O�_�B���D�ϥΪ��A�C
        /// false ��ܱw�̰O�����A�ϥΡA�i��w�X�֨�t�@�ӰO�����C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Active = new FhirBoolean(true);  // ���D�w��
        /// patient.Active = new FhirBoolean(false); // �D���D�w��
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �����Ω�O���޲z�G
        /// - true: �w�̰O���B���D���A
        /// - false: �w�̰O���w���ΩΦX��
        /// - null: ���A����
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
        /// 
        /// <para>
        /// �P�w�̬������m�W�C�w�̥i�঳�h�өm�W�A�]�A�x��m�W�B�ʺ١B
        /// �©m�W�����P�γ~���m�W�C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Name = new List&lt;HumanName&gt;
        /// {
        ///     new HumanName
        ///     {
        ///         Use = new FhirCode("official"),
        ///         Family = new FhirString("��"),
        ///         Given = new List&lt;FhirString&gt; 
        ///         { 
        ///             new FhirString("�p��"), 
        ///             new FhirString("�ӵ�") 
        ///         },
        ///         Prefix = new List&lt;FhirString&gt; { new FhirString("����") }
        ///     },
        ///     new HumanName
        ///     {
        ///         Use = new FhirCode("nickname"),
        ///         Given = new List&lt;FhirString&gt; { new FhirString("�p��") }
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �m�W�����P�γ~�G
        /// - official: �x�西���m�W
        /// - usual: �`�Ωm�W
        /// - nickname: �ʺ�
        /// - old: �H�e�ϥΪ��m�W
        /// - maiden: �B�e�m�W
        /// </para>
        /// </remarks>
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
        /// 
        /// <para>
        /// �p���w�̪��ԲӸ�T�A�]�A�q�ܸ��X�B�q�l�l��a�}�B�ǯu���X���C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Telecom = new List&lt;ContactPoint&gt;
        /// {
        ///     new ContactPoint
        ///     {
        ///         System = new FhirCode("phone"),
        ///         Value = new FhirString("+886-2-12345678"),
        ///         Use = new FhirCode("home"),
        ///         Rank = new FhirPositiveInt(1)
        ///     },
        ///     new ContactPoint
        ///     {
        ///         System = new FhirCode("email"),
        ///         Value = new FhirString("patient@example.com"),
        ///         Use = new FhirCode("work")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �p���覡�����G
        /// - phone: �q�ܸ��X
        /// - fax: �ǯu���X
        /// - email: �q�l�l��
        /// - pager: �I�s��
        /// - url: �����a�}
        /// - sms: ²�T���X
        /// - other: ��L�覡
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
        /// 
        /// <para>
        /// �w�̪���F�ʧO�C�o�O�Ω��F�ت����ʧO�A
        /// �i�ण�P��Ͳz�ʧO�ΩʧO�{�P�C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Gender = new FhirCode("male");    // �k��
        /// patient.Gender = new FhirCode("female");  // �k��
        /// patient.Gender = new FhirCode("other");   // ��L
        /// patient.Gender = new FhirCode("unknown"); // ����
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���Ī��ʧO�N�X�G
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
        /// 
        /// <para>
        /// �w�̪��X�ͤ���C�i�H�O�������B�Ȧ~��ζȦ~���A
        /// ���M��w����T����T�{�סC
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.BirthDate = new FhirDate("1990-01-01");  // ������
        /// patient.BirthDate = new FhirDate("1990-01");     // �~��
        /// patient.BirthDate = new FhirDate("1990");        // �Ȧ~��
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �X�ͤ���Ω�G
        /// - �p��~��
        /// - ��������
        /// - �~�֬����������M��
        /// - �έp���R
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
        /// �O�_�w�G�]���L�ȡ^
        /// 
        /// <para>
        /// ���ܱw�̬O�_�w�G�C�p�G�]�� true�A��ܱw�̤w���`�A
        /// �������Ѩ��骺���`�ɶ��C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Deceased = new FhirBoolean(false); // �b�@
        /// patient.Deceased = new FhirBoolean(true);  // �w�G
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �P DeceasedDateTime �����A�u��]�w�䤤���@�C
        /// </para>
        /// </remarks>
        public FhirBoolean? Deceased
        {
            get => _deceased;
            set
            {
                _deceased = value;
                OnPropertyChanged(nameof(Deceased));
            }
        }

        /// <summary>
        /// ���`�ɶ�
        /// 
        /// <para>
        /// �p�G�w�̤w�G�A�O�����骺���`����M�ɶ��C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.DeceasedDateTime = new FhirDateTime("2023-12-01T14:30:00+08:00");
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �P Deceased �����A�u��]�w�䤤���@�C
        /// �p�G�]�w�F DeceasedDateTime�A��ܱw�̤w�G�C
        /// </para>
        /// </remarks>
        public FhirDateTime? DeceasedDateTime
        {
            get => _deceasedDateTime;
            set
            {
                _deceasedDateTime = value;
                OnPropertyChanged(nameof(DeceasedDateTime));
            }
        }

        /// <summary>
        /// �a�}
        /// 
        /// <para>
        /// �w�̪��a�}��T�C�w�̥i�঳�h�Ӧa�}�A�]�A��a�a�}�B
        /// �u�@�a�}�B�l�H�a�}���C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Address = new List&lt;Address&gt;
        /// {
        ///     new Address
        ///     {
        ///         Use = new FhirCode("home"),
        ///         Type = new FhirCode("both"),
        ///         Line = new List&lt;FhirString&gt; { new FhirString("�x�_���H�q�ϫH�q�����q7��") },
        ///         City = new FhirString("�x�_��"),
        ///         District = new FhirString("�H�q��"),
        ///         PostalCode = new FhirString("110"),
        ///         Country = new FhirString("�x�W")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �a�}�γ~�����G
        /// - home: ��a�a�}
        /// - work: �u�@�a�}
        /// - temp: �{�ɦa�}
        /// - old: �¦a�}
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
        /// 
        /// <para>
        /// �w�̪��B�á]���ơ^���A�C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.MaritalStatus = new CodeableConcept
        /// {
        ///     Coding = new List&lt;Coding&gt;
        ///     {
        ///         new Coding
        ///         {
        ///             System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-MaritalStatus"),
        ///             Code = new FhirCode("M"),
        ///             Display = new FhirString("Married")
        ///         }
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �`�����B�ê��A�N�X�G
        /// - S: �樭 (Single)
        /// - M: �w�B (Married)
        /// - D: ���B (Divorced)
        /// - W: �స (Widowed)
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
        /// �O�_���h�M�L�]���L�ȡ^
        /// 
        /// <para>
        /// ���ܱw�̬O�_���h�M�L���@�����C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.MultipleBirthBoolean = new FhirBoolean(true); // �O�h�M�L
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �P MultipleBirthInteger �����A�u��]�w�䤤���@�C
        /// </para>
        /// </remarks>
        public FhirBoolean? MultipleBirthBoolean
        {
            get => _multipleBirthBoolean;
            set
            {
                _multipleBirthBoolean = value;
                OnPropertyChanged(nameof(MultipleBirthBoolean));
            }
        }

        /// <summary>
        /// �h�M�L�X�Ͷ���
        /// 
        /// <para>
        /// �p�G�w�̬O�h�M�L���@�����A���ܨ�X�Ͷ��ǡC
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.MultipleBirthInteger = new FhirInteger(2); // �ĤG�ӥX��
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �P MultipleBirthBoolean �����A�u��]�w�䤤���@�C
        /// �Ʀr 1 ��ܲĤ@�ӥX�͡A2 ��ܲĤG�ӡA�H�������C
        /// </para>
        /// </remarks>
        public FhirInteger? MultipleBirthInteger
        {
            get => _multipleBirthInteger;
            set
            {
                _multipleBirthInteger = value;
                OnPropertyChanged(nameof(MultipleBirthInteger));
            }
        }

        /// <summary>
        /// �Ӥ�
        /// 
        /// <para>
        /// �w�̪��Ӥ��Ϥ��C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Photo = new List&lt;Attachment&gt;
        /// {
        ///     new Attachment
        ///     {
        ///         ContentType = new FhirCode("image/jpeg"),
        ///         Data = new FhirBase64Binary("base64-encoded-image-data"),
        ///         Title = new FhirString("Patient Photo")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �Ӥ��Ω�G
        /// - �����ѧO
        /// - �����O��
        /// - �w������
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
        /// 
        /// <para>
        /// �w�̪��p���H�]�p���@�H�B��Q�B�B�͡^�C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Contact = new List&lt;PatientContactR4&gt;
        /// {
        ///     new PatientContactR4
        ///     {
        ///         Relationship = new List&lt;CodeableConcept&gt;
        ///         {
        ///             new CodeableConcept
        ///             {
        ///                 Coding = new List&lt;Coding&gt;
        ///                 {
        ///                     new Coding
        ///                     {
        ///                         System = new FhirUri("http://terminology.hl7.org/CodeSystem/v2-0131"),
        ///                         Code = new FhirCode("C"),
        ///                         Display = new FhirString("Emergency Contact")
        ///                     }
        ///                 }
        ///             }
        ///         },
        ///         Name = new HumanName
        ///         {
        ///             Family = new FhirString("��"),
        ///             Given = new List&lt;FhirString&gt; { new FhirString("�p��") }
        ///         },
        ///         Telecom = new List&lt;ContactPoint&gt;
        ///         {
        ///             new ContactPoint
        ///             {
        ///                 System = new FhirCode("phone"),
        ///                 Value = new FhirString("+886-912345678"),
        ///                 Use = new FhirCode("mobile")
        ///             }
        ///         }
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �p���H���Y�����G
        /// - C: ����p���H (Emergency Contact)
        /// - F: �a�H (Family)
        /// - G: ���@�H (Guardian)
        /// - P: ��Q (Partner)
        /// </para>
        /// </remarks>
        public List<PatientContactR4>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }

        /// <summary>
        /// ���q�y��
        /// 
        /// <para>
        /// �i�Ω�P�w�̷��q���d�����ưȪ��y���C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Communication = new List&lt;PatientCommunicationR4&gt;
        /// {
        ///     new PatientCommunicationR4
        ///     {
        ///         Language = new CodeableConcept
        ///         {
        ///             Coding = new List&lt;Coding&gt;
        ///             {
        ///                 new Coding
        ///                 {
        ///                     System = new FhirUri("urn:ietf:bcp:47"),
        ///                     Code = new FhirCode("zh-TW"),
        ///                     Display = new FhirString("Chinese (Taiwan)")
        ///                 }
        ///             }
        ///         },
        ///         Preferred = new FhirBoolean(true)
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �y�����n��󴣨ѾA�������O���A�ȫܭ��n�C
        /// </para>
        /// </remarks>
        public List<PatientCommunicationR4>? Communication
        {
            get => _communication;
            set
            {
                _communication = value;
                OnPropertyChanged(nameof(Communication));
            }
        }

        /// <summary>
        /// �a�x��v
        /// 
        /// <para>
        /// �w�̫��w���D�n�@�z���Ѫ̡C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.GeneralPractitioner = new List&lt;ReferenceType&gt;
        /// {
        ///     new ReferenceType
        ///     {
        ///         Reference = new FhirString("Practitioner/practitioner-001"),
        ///         Display = new FhirString("����v")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �i�H�ޥ� Practitioner�BPractitionerRole �� Organization �귽�C
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
        /// 
        /// <para>
        /// �@���w�̰O���O�ު̪���´�C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.ManagingOrganization = new ReferenceType
        /// {
        ///     Reference = new FhirString("Organization/hospital-001"),
        ///     Display = new FhirString("�x�_��|")
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �q�`�O��|�B�E�ҩΨ�L�����O����´�C
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
        /// 
        /// <para>
        /// �P�A�ΦP�@��ڤH�����t�@�ӱw�̸귽���s���C
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Link = new List&lt;PatientLinkR4&gt;
        /// {
        ///     new PatientLinkR4
        ///     {
        ///         Other = new ReferenceType
        ///         {
        ///             Reference = new FhirString("Patient/patient-002")
        ///         },
        ///         Type = new FhirCode("replaced-by")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �s�������G
        /// - replaced-by: �Q���N
        /// - replaces: ���N
        /// - refer: �Ѧ�
        /// - seealso: �t��
        /// </para>
        /// </remarks>
        public List<PatientLinkR4>? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }

        /// <summary>
        /// ��l�� PatientR4 ���O���s�������
        /// </summary>
        public PatientR4() : base()
        {
        }

        /// <summary>
        /// �ϥΫ��w�� ID ��l�� PatientR4 ���O���s�������
        /// </summary>
        /// <param name="id">�w�̪��ߤ@�ѧO�X</param>
        /// <exception cref="ArgumentException">�� ID ���ũ� null ���Y�X</exception>
        public PatientR4(string id) : this()
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("ID ���ର��", nameof(id));
            
            Id = id;
        }

        /// <summary>
        /// ���� R4 �S�w������
        /// </summary>
        /// <returns>���ҵ��G�A�p�G���ҥ��ѫh�]�t���~�T��</returns>
        /// <remarks>
        /// <para>
        /// R4 ���������ҳW�h�G
        /// - �ܤֻݭn�@���ѧO�X�Ωm�W
        /// - �ʧO�ȥ����O���ĭ�
        /// - �X�ͤ������O���Ӥ��
        /// - ���`���A�޿��ˬd
        /// - �h�M�L��T�@�P���ˬd
        /// </para>
        /// </remarks>
        protected override System.ComponentModel.DataAnnotations.ValidationResult? ValidateVersionSpecific()
        {
            // ���ұw�̥������ѧO�X�Ωm�W
            if ((Identifier == null || Identifier.Count == 0) && 
                (Name == null || Name.Count == 0))
            {
                return new System.ComponentModel.DataAnnotations.ValidationResult(
                    "Patient �ܤֻݭn�@���ѧO�X�Ωm�W");
            }

            // ���ҩʧO�N�X
            if (Gender != null)
            {
                var validGenders = new[] { "male", "female", "other", "unknown" };
                if (!validGenders.Contains(Gender.Value))
                {
                    return new System.ComponentModel.DataAnnotations.ValidationResult(
                        $"�ʧO�N�X '{Gender.Value}' �L�ġC���ĭȡG{string.Join(", ", validGenders)}");
                }
            }

            // ���ҥX�ͤ��
            if (BirthDate?.Value != null)
            {
                if (BirthDate.Value > DateTime.Today)
                {
                    return new System.ComponentModel.DataAnnotations.ValidationResult(
                        "�X�ͤ������O���Ӥ��");
                }
            }

            // ���Ҧ��`���A
            if (Deceased?.Value == true && DeceasedDateTime?.Value != null)
            {
                return new System.ComponentModel.DataAnnotations.ValidationResult(
                    "Deceased �M DeceasedDateTime ����P�ɳ]�w");
            }

            // ���Ҧh�M�L��T
            if (MultipleBirthBoolean?.Value == true && MultipleBirthInteger?.Value != null)
            {
                return new System.ComponentModel.DataAnnotations.ValidationResult(
                    "MultipleBirthBoolean �M MultipleBirthInteger ����P�ɳ]�w");
            }

            return null;
        }

        /// <summary>
        /// �إ߱w�̪��r����
        /// </summary>
        /// <returns>�]�t�w�̥D�n��T���r��</returns>
        public override string ToString()
        {
            var name = Name?.FirstOrDefault()?.Family?.Value ?? "Unknown";
            var gender = Gender?.Value ?? "Unknown";
            var birthDate = BirthDate?.Value?.ToString("yyyy-MM-dd") ?? "Unknown";
            
            return $"PatientR4(Id: {Id}, Name: {name}, Gender: {gender}, BirthDate: {birthDate})";
        }
    }

    /// <summary>
    /// Patient �p���H�]R4 �����^
    /// 
    /// <para>
    /// ��ܱw�̪��p���H��T�A�p����p���H�B���@�H�B�a�ݵ��C
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 �������p���H�䴩���㪺�p����T�M���Y�w�q�C
    /// </para>
    /// </remarks>
    public class PatientContactR4
    {
        /// <summary>
        /// ���Y
        /// 
        /// <para>
        /// �p���H�P�w�̪����Y�C
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �`�����Y�G���@�H�B����p���H�B�a�H�B��Q���C
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Relationship { get; set; }

        /// <summary>
        /// �m�W
        /// 
        /// <para>
        /// �P�p���H�������m�W�C
        /// </para>
        /// </summary>
        public HumanName? Name { get; set; }

        /// <summary>
        /// �p���覡
        /// 
        /// <para>
        /// �p���H���p���ԲӸ�T�C
        /// </para>
        /// </summary>
        public List<ContactPoint>? Telecom { get; set; }

        /// <summary>
        /// �a�}
        /// 
        /// <para>
        /// �p���H���a�}�C
        /// </para>
        /// </summary>
        public Address? Address { get; set; }

        /// <summary>
        /// �ʧO
        /// 
        /// <para>
        /// �p���H���ʧO�C
        /// </para>
        /// </summary>
        public FhirCode? Gender { get; set; }

        /// <summary>
        /// ��´
        /// 
        /// <para>
        /// �P�p���H��������´�C
        /// </para>
        /// </summary>
        public ReferenceType? Organization { get; set; }

        /// <summary>
        /// ����
        /// 
        /// <para>
        /// ���p���H���Ī������C
        /// </para>
        /// </summary>
        public Period? Period { get; set; }
    }

    /// <summary>
    /// Patient ���q�y���]R4 �����^
    /// 
    /// <para>
    /// ��ܥi�Ω�P�w�̷��q���d�����ưȪ��y���C
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 �����䴩�h�y�����n�]�w�C
    /// </para>
    /// </remarks>
    public class PatientCommunicationR4
    {
        /// <summary>
        /// �y��
        /// 
        /// <para>
        /// ISO-639-1 alpha 2 �N�X�A���X�i�諸 ISO-3166-1 alpha 2 ��a�N�X�C
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ϥ� BCP 47 �y�����Ү榡�A�p "zh-TW"�B"en-US" ���C
        /// </para>
        /// </remarks>
        [Required]
        public CodeableConcept? Language { get; set; }

        /// <summary>
        /// ���n
        /// 
        /// <para>
        /// ��ܦ��y���O�_���w�̪����n�y���C
        /// </para>
        /// </summary>
        public FhirBoolean? Preferred { get; set; }
    }

    /// <summary>
    /// Patient �s���]R4 �����^
    /// 
    /// <para>
    /// ��ܻP�A�ΦP�@��ڤH�����t�@�ӱw�̸귽���s���C
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 �������s���Ω�w�̰O���X�֩M�ѦҡC
    /// </para>
    /// </remarks>
    public class PatientLinkR4
    {
        /// <summary>
        /// ��L�귽
        /// 
        /// <para>
        /// �s���ޥΪ���L�w�̩ά����H���귽�C
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// �����ޥ� Patient �� RelatedPerson �귽�C
        /// </para>
        /// </remarks>
        [Required]
        public ReferenceType? Other { get; set; }

        /// <summary>
        /// �s������
        /// 
        /// <para>
        /// ���s���������C
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// ���ĭȡGreplaced-by�Breplaces�Brefer�Bseealso�C
        /// </para>
        /// </remarks>
        [Required]
        public FhirCode? Type { get; set; }
    }
}