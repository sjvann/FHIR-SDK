using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using System.ComponentModel.DataAnnotations;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 Organization �귽
    /// </summary>
    public class Organization : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<CodeableConcept>? _type;
        private FhirString? _name;
        private List<FhirString>? _alias;
        private FhirMarkdown? _description;
        private List<ContactPoint>? _contact;
        private ReferenceType? _partOf;
        private List<ReferenceType>? _endpoint;
        private List<OrganizationQualification>? _qualification;

        /// <summary>
        /// �귽����
        /// </summary>
        public override string ResourceType => "Organization";

        /// <summary>
        /// �ѧO�X
        /// </summary>
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
        /// ��´����
        /// </summary>
        public List<CodeableConcept>? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

        /// <summary>
        /// ��´�W��
        /// </summary>
        [Required(ErrorMessage = "��´�������W�٩��ѧO�X")]
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// �O�W
        /// </summary>
        public List<FhirString>? Alias
        {
            get => _alias;
            set
            {
                _alias = value;
                OnPropertyChanged(nameof(Alias));
            }
        }

        /// <summary>
        /// ��´�y�z
        /// </summary>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        /// <summary>
        /// �p����T
        /// </summary>
        public List<ContactPoint>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }

        /// <summary>
        /// �W�Ų�´
        /// </summary>
        public ReferenceType? PartOf
        {
            get => _partOf;
            set
            {
                _partOf = value;
                OnPropertyChanged(nameof(PartOf));
            }
        }

        /// <summary>
        /// �A�Ⱥ��I
        /// </summary>
        public List<ReferenceType>? Endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(Endpoint));
            }
        }

        /// <summary>
        /// ���{��
        /// </summary>
        public List<OrganizationQualification>? Qualification
        {
            get => _qualification;
            set
            {
                _qualification = value;
                OnPropertyChanged(nameof(Qualification));
            }
        }

        /// <summary>
        /// �إ߷s�� Organization �귽���
        /// </summary>
        public Organization()
        {
        }

        /// <summary>
        /// �إ߷s�� Organization �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        public Organization(string id)
        {
            Id = id;
        }

        /// <summary>
        /// �إ߷s�� Organization �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="name">��´�W��</param>
        public Organization(string id, string name)
        {
            Id = id;
            Name = new FhirString(name);
            Active = new FhirBoolean(true);
        }

        /// <summary>
        /// �إ߷s�� Organization �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        /// <param name="name">��´�W��</param>
        /// <param name="type">��´����</param>
        public Organization(string id, string name, CodeableConcept type)
        {
            Id = id;
            Name = new FhirString(name);
            Type = new List<CodeableConcept> { type };
            Active = new FhirBoolean(true);
        }

        /// <summary>
        /// �ഫ���r����
        /// </summary>
        public override string ToString()
        {
            var displayName = Name?.Value ?? "���R�W��´";
            var activeStatus = Active?.Value == true ? "���D" : Active?.Value == false ? "�D���D" : "���A����";
            return $"Organization(Id: {Id}, Name: {displayName}, Status: {activeStatus})";
        }
    }

    /// <summary>
    /// ��´���{��
    /// </summary>
    public class OrganizationQualification
    {
        /// <summary>
        /// ���{���ѧO�X
        /// </summary>
        public List<Identifier>? Identifier { get; set; }

        /// <summary>
        /// ���{�ҥN�X
        /// </summary>
        public CodeableConcept? Code { get; set; }

        /// <summary>
        /// ���Ĵ���
        /// </summary>
        public Period? Period { get; set; }

        /// <summary>
        /// �o�Ҿ��c
        /// </summary>
        public ReferenceType? Issuer { get; set; }

        public OrganizationQualification() { }

        public OrganizationQualification(CodeableConcept code)
        {
            Code = code;
        }
    }
}