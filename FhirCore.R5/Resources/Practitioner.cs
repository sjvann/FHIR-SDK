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
    /// FHIR R5 Practitioner �귽
    /// 
    /// <para>
    /// �Ω�O�������q�~�H�����򥻸�T�A�]�A��v�B�@�z�v�B�ޮv���U�������M�~�H���C
    /// ���ѤH�����ѧO��T�B�p���覡�B�M�~��浥���n��ơC
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var practitioner = new Practitioner("practitioner-001")
    /// {
    ///     Name = new List&lt;HumanName&gt; 
    ///     {
    ///         new HumanName
    ///         {
    ///             Family = new FhirString("��"),
    ///             Given = new List&lt;FhirString&gt; { new FhirString("�j��") },
    ///             Use = new FhirCode("official")
    ///         }
    ///     },
    ///     Active = new FhirBoolean(true),
    ///     Gender = new FhirCode("male")
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Practitioner �귽�O FHIR ���O�������q�~�H�����֤߸귽�A
    /// �Ω�إߤH���P�����欰�B�B��B�E�_�������p�C
    /// </para>
    /// 
    /// <para>
    /// R5 �������D�n�S�I�G
    /// - �䴩�h�ئW�ٮ榡�M�γ~
    /// - �W�j���p����T�޲z
    /// - ���㪺�M�~���O��
    /// - �䴩�h�y�����q��O�O��
    /// </para>
    /// </remarks>
    public class Practitioner : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private FhirCode? _gender;
        private FhirDate? _birthDate;
        private PractitionerDeceasedChoice? _deceased;
        private List<Address>? _address;
        private List<Attachment>? _photo;
        private List<PractitionerQualification>? _qualification;
        private List<PractitionerCommunication>? _communication;

        /// <summary>
        /// �귽����
        /// </summary>
        public override string ResourceType => "Practitioner";

        /// <summary>
        /// �ѧO�X
        /// </summary>
        /// <remarks>
        /// <para>
        /// �����q�~�H�����U���ѧO�X�A�p��v���Ӹ��X�B���u�s�����C
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
        /// ���ܦ��q�~�H���O�_���b���~���C
        /// false ��ܤw�h��B���~����¾�C
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
        /// �q�~�H�����m�W��T�A�i�]�t�h�ӦW�١]�p�����W�١B�ʺٵ��^�C
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
        /// </summary>
        /// <remarks>
        /// <para>
        /// �]�t�q�ܡB�q�l�l���p����T�C
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
        /// ��F�ʧO�A�q�`�� male�Bfemale�Bother �� unknown�C
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
        /// ���`���A
        /// </summary>
        /// <remarks>
        /// <para>
        /// �i�H�O���L�ȡ]�O�_���`�^�Ψ��骺���`�ɶ��C
        /// </para>
        /// </remarks>
        public PractitionerDeceasedChoice? Deceased
        {
            get => _deceased;
            set
            {
                _deceased = value;
                OnPropertyChanged(nameof(Deceased));
            }
        }

        /// <summary>
        /// �a�}
        /// </summary>
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
        /// �Ӥ�
        /// </summary>
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
        /// �M�~���
        /// </summary>
        /// <remarks>
        /// <para>
        /// �q�~�H�����M�~���B�ҷӡB�Ǧ쵥��T�C
        /// </para>
        /// </remarks>
        public List<PractitionerQualification>? Qualification
        {
            get => _qualification;
            set
            {
                _qualification = value;
                OnPropertyChanged(nameof(Qualification));
            }
        }

        /// <summary>
        /// ���q�y��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �q�~�H������ϥΪ��y���ΰ��n�]�w�C
        /// </para>
        /// </remarks>
        public List<PractitionerCommunication>? Communication
        {
            get => _communication;
            set
            {
                _communication = value;
                OnPropertyChanged(nameof(Communication));
            }
        }

        /// <summary>
        /// �إ߷s�� Practitioner �귽���
        /// </summary>
        public Practitioner()
        {
        }

        /// <summary>
        /// �إ߷s�� Practitioner �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        public Practitioner(string id)
        {
            Id = id;
        }

        /// <summary>
        /// �إ߷s�� Practitioner �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="familyName">�m��</param>
        /// <param name="givenName">�W�r</param>
        public Practitioner(string id, string familyName, string givenName)
        {
            Id = id;
            Name = new List<HumanName>
            {
                new HumanName
                {
                    Family = new FhirString(familyName),
                    Given = new List<FhirString> { new FhirString(givenName) },
                    Use = new FhirCode("official")
                }
            };
            Active = new FhirBoolean(true);
        }

        /// <summary>
        /// �ഫ���r����
        /// </summary>
        public override string ToString()
        {
            var displayName = "���R�W�����H��";
            if (Name?.Count > 0)
            {
                var primaryName = Name[0];
                var family = primaryName.Family?.Value ?? "";
                var given = primaryName.Given?.FirstOrDefault()?.Value ?? "";
                displayName = $"{family}{given}".Trim();
                if (string.IsNullOrEmpty(displayName))
                {
                    displayName = primaryName.Text?.Value ?? "���R�W�����H��";
                }
            }

            var activeStatus = Active?.Value == true ? "���~��" : Active?.Value == false ? "�D���~" : "���A����";
            return $"Practitioner(Id: {Id}, Name: {displayName}, Status: {activeStatus})";
        }
    }

    /// <summary>
    /// �����q�~�H���M�~���
    /// </summary>
    /// <remarks>
    /// <para>
    /// �O���q�~�H�����M�~���B�ҷӡB�Ǧ쵥������T�C
    /// </para>
    /// </remarks>
    public class PractitionerQualification
    {
        /// <summary>
        /// ����ѧO�X
        /// </summary>
        public List<Identifier>? Identifier { get; set; }

        /// <summary>
        /// ���N�X
        /// </summary>
        /// <remarks>
        /// <para>
        /// �y�z����������N�X�A�p��v���ӡB�@�z�v���ӵ��C
        /// </para>
        /// </remarks>
        public CodeableConcept? Code { get; set; }

        /// <summary>
        /// ���Ĵ���
        /// </summary>
        public Period? Period { get; set; }

        /// <summary>
        /// �o�Ҿ��c
        /// </summary>
        public ReferenceType? Issuer { get; set; }

        public PractitionerQualification() { }

        public PractitionerQualification(CodeableConcept code)
        {
            Code = code;
        }
    }

    /// <summary>
    /// �����q�~�H�����q�y��
    /// </summary>
    /// <remarks>
    /// <para>
    /// �O���q�~�H������ϥΪ��y���Ψ䰾�n�{�סC
    /// </para>
    /// </remarks>
    public class PractitionerCommunication
    {
        /// <summary>
        /// �y��
        /// </summary>
        /// <remarks>
        /// <para>
        /// �ϥ� ISO 639-1 �� BCP 47 �y���N�X�C
        /// </para>
        /// </remarks>
        public CodeableConcept? Language { get; set; }

        /// <summary>
        /// �O�_�����n�y��
        /// </summary>
        public FhirBoolean? Preferred { get; set; }

        public PractitionerCommunication() { }

        public PractitionerCommunication(CodeableConcept language, bool preferred = false)
        {
            Language = language;
            Preferred = new FhirBoolean(preferred);
        }
    }

    /// <summary>
    /// Practitioner ���`���A�������
    /// </summary>
    /// <remarks>
    /// <para>
    /// �i�H�O���L�ȡ]��ܬO�_���`�^�Ψ��骺���`����ɶ��C
    /// </para>
    /// </remarks>
    public class PractitionerDeceasedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "boolean", "dateTime" };

        public PractitionerDeceasedChoice(JsonObject value) : base("deceased", value, _supportType) { }
        public PractitionerDeceasedChoice(IComplexType? value) : base("deceased", value) { }
        public PractitionerDeceasedChoice(IPrimitiveType? value) : base("deceased", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Deceased" : "deceased";

        public override List<string> SetSupportDataType() => _supportType;
    }
}