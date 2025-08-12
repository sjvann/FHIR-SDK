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
    /// FHIR R5 RelatedPerson 資源
    /// 
    /// <para>
    /// RelatedPerson 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var relatedperson = new RelatedPerson("relatedperson-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 RelatedPerson 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class RelatedPerson : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private List<CodeableConcept>? _relationship;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private FhirCode? _gender;
        private FhirDate? _birthdate;
        private List<Address>? _address;
        private List<Attachment>? _photo;
        private Period? _period;
        private List<RelatedPersonCommunication>? _communication;
        private CodeableConcept? _language;
        private FhirBoolean? _preferred;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "RelatedPerson";        /// <summary>
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
        /// Active
        /// </summary>
        /// <remarks>
        /// <para>
        /// Active 的詳細描述。
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
        }        /// <summary>
        /// Patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patient 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(Patient));
            }
        }        /// <summary>
        /// Relationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relationship 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Relationship
        {
            get => _relationship;
            set
            {
                _relationship = value;
                OnPropertyChanged(nameof(Relationship));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
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
        }        /// <summary>
        /// Telecom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Telecom 的詳細描述。
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
        }        /// <summary>
        /// Gender
        /// </summary>
        /// <remarks>
        /// <para>
        /// Gender 的詳細描述。
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
        }        /// <summary>
        /// Birthdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Birthdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Birthdate
        {
            get => _birthdate;
            set
            {
                _birthdate = value;
                OnPropertyChanged(nameof(Birthdate));
            }
        }        /// <summary>
        /// Address
        /// </summary>
        /// <remarks>
        /// <para>
        /// Address 的詳細描述。
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
        }        /// <summary>
        /// Photo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Photo 的詳細描述。
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
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Communication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Communication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RelatedPersonCommunication>? Communication
        {
            get => _communication;
            set
            {
                _communication = value;
                OnPropertyChanged(nameof(Communication));
            }
        }        /// <summary>
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
            }
        }        /// <summary>
        /// Preferred
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preferred 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Preferred
        {
            get => _preferred;
            set
            {
                _preferred = value;
                OnPropertyChanged(nameof(Preferred));
            }
        }        /// <summary>
        /// 建立新的 RelatedPerson 資源實例
        /// </summary>
        public RelatedPerson()
        {
        }

        /// <summary>
        /// 建立新的 RelatedPerson 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public RelatedPerson(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"RelatedPerson(Id: {Id})";
        }
    }    /// <summary>
    /// RelatedPersonCommunication 背骨元素
    /// </summary>
    public class RelatedPersonCommunication
    {
        // TODO: 添加屬性實作
        
        public RelatedPersonCommunication() { }
    }
}
