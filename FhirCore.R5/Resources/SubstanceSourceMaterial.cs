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
    /// FHIR R5 SubstanceSourceMaterial 資源
    /// 
    /// <para>
    /// SubstanceSourceMaterial 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var substancesourcematerial = new SubstanceSourceMaterial("substancesourcematerial-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 SubstanceSourceMaterial 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubstanceSourceMaterial : ResourceBase<R5Version>
    {
        private Property
		private CodeableConcept? _sourcematerialclass;
        private CodeableConcept? _sourcematerialtype;
        private CodeableConcept? _sourcematerialstate;
        private Identifier? _organismid;
        private FhirString? _organismname;
        private List<Identifier>? _parentsubstanceid;
        private List<FhirString>? _parentsubstancename;
        private List<CodeableConcept>? _countryoforigin;
        private List<FhirString>? _geographicallocation;
        private CodeableConcept? _developmentstage;
        private List<SubstanceSourceMaterialFractionDescription>? _fractiondescription;
        private SubstanceSourceMaterialOrganism? _organism;
        private List<SubstanceSourceMaterialPartDescription>? _partdescription;
        private FhirString? _fraction;
        private CodeableConcept? _materialtype;
        private CodeableConcept? _authortype;
        private FhirString? _authordescription;
        private FhirString? _maternalorganismid;
        private FhirString? _maternalorganismname;
        private FhirString? _paternalorganismid;
        private FhirString? _paternalorganismname;
        private CodeableConcept? _hybridtype;
        private CodeableConcept? _kingdom;
        private CodeableConcept? _phylum;
        private CodeableConcept? _class;
        private CodeableConcept? _order;
        private CodeableConcept? _family;
        private CodeableConcept? _genus;
        private CodeableConcept? _species;
        private CodeableConcept? _intraspecifictype;
        private FhirString? _intraspecificdescription;
        private List<SubstanceSourceMaterialOrganismAuthor>? _author;
        private SubstanceSourceMaterialOrganismHybrid? _hybrid;
        private SubstanceSourceMaterialOrganismOrganismGeneral? _organismgeneral;
        private CodeableConcept? _part;
        private CodeableConcept? _partlocation;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SubstanceSourceMaterial";        /// <summary>
        /// Sourcematerialclass
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourcematerialclass 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private CodeableConcept? Sourcematerialclass
        {
            get => _sourcematerialclass;
            set
            {
                _sourcematerialclass = value;
                OnPropertyChanged(nameof(Sourcematerialclass));
            }
        }        /// <summary>
        /// Sourcematerialtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourcematerialtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Sourcematerialtype
        {
            get => _sourcematerialtype;
            set
            {
                _sourcematerialtype = value;
                OnPropertyChanged(nameof(Sourcematerialtype));
            }
        }        /// <summary>
        /// Sourcematerialstate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourcematerialstate 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Sourcematerialstate
        {
            get => _sourcematerialstate;
            set
            {
                _sourcematerialstate = value;
                OnPropertyChanged(nameof(Sourcematerialstate));
            }
        }        /// <summary>
        /// Organismid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Organismid 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Organismid
        {
            get => _organismid;
            set
            {
                _organismid = value;
                OnPropertyChanged(nameof(Organismid));
            }
        }        /// <summary>
        /// Organismname
        /// </summary>
        /// <remarks>
        /// <para>
        /// Organismname 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Organismname
        {
            get => _organismname;
            set
            {
                _organismname = value;
                OnPropertyChanged(nameof(Organismname));
            }
        }        /// <summary>
        /// Parentsubstanceid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parentsubstanceid 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Parentsubstanceid
        {
            get => _parentsubstanceid;
            set
            {
                _parentsubstanceid = value;
                OnPropertyChanged(nameof(Parentsubstanceid));
            }
        }        /// <summary>
        /// Parentsubstancename
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parentsubstancename 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Parentsubstancename
        {
            get => _parentsubstancename;
            set
            {
                _parentsubstancename = value;
                OnPropertyChanged(nameof(Parentsubstancename));
            }
        }        /// <summary>
        /// Countryoforigin
        /// </summary>
        /// <remarks>
        /// <para>
        /// Countryoforigin 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Countryoforigin
        {
            get => _countryoforigin;
            set
            {
                _countryoforigin = value;
                OnPropertyChanged(nameof(Countryoforigin));
            }
        }        /// <summary>
        /// Geographicallocation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Geographicallocation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Geographicallocation
        {
            get => _geographicallocation;
            set
            {
                _geographicallocation = value;
                OnPropertyChanged(nameof(Geographicallocation));
            }
        }        /// <summary>
        /// Developmentstage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Developmentstage 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Developmentstage
        {
            get => _developmentstage;
            set
            {
                _developmentstage = value;
                OnPropertyChanged(nameof(Developmentstage));
            }
        }        /// <summary>
        /// Fractiondescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fractiondescription 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceSourceMaterialFractionDescription>? Fractiondescription
        {
            get => _fractiondescription;
            set
            {
                _fractiondescription = value;
                OnPropertyChanged(nameof(Fractiondescription));
            }
        }        /// <summary>
        /// Organism
        /// </summary>
        /// <remarks>
        /// <para>
        /// Organism 的詳細描述。
        /// </para>
        /// </remarks>
        public SubstanceSourceMaterialOrganism? Organism
        {
            get => _organism;
            set
            {
                _organism = value;
                OnPropertyChanged(nameof(Organism));
            }
        }        /// <summary>
        /// Partdescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// Partdescription 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceSourceMaterialPartDescription>? Partdescription
        {
            get => _partdescription;
            set
            {
                _partdescription = value;
                OnPropertyChanged(nameof(Partdescription));
            }
        }        /// <summary>
        /// Fraction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fraction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Fraction
        {
            get => _fraction;
            set
            {
                _fraction = value;
                OnPropertyChanged(nameof(Fraction));
            }
        }        /// <summary>
        /// Materialtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Materialtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Materialtype
        {
            get => _materialtype;
            set
            {
                _materialtype = value;
                OnPropertyChanged(nameof(Materialtype));
            }
        }        /// <summary>
        /// Authortype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authortype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Authortype
        {
            get => _authortype;
            set
            {
                _authortype = value;
                OnPropertyChanged(nameof(Authortype));
            }
        }        /// <summary>
        /// Authordescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authordescription 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Authordescription
        {
            get => _authordescription;
            set
            {
                _authordescription = value;
                OnPropertyChanged(nameof(Authordescription));
            }
        }        /// <summary>
        /// Maternalorganismid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maternalorganismid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Maternalorganismid
        {
            get => _maternalorganismid;
            set
            {
                _maternalorganismid = value;
                OnPropertyChanged(nameof(Maternalorganismid));
            }
        }        /// <summary>
        /// Maternalorganismname
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maternalorganismname 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Maternalorganismname
        {
            get => _maternalorganismname;
            set
            {
                _maternalorganismname = value;
                OnPropertyChanged(nameof(Maternalorganismname));
            }
        }        /// <summary>
        /// Paternalorganismid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Paternalorganismid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Paternalorganismid
        {
            get => _paternalorganismid;
            set
            {
                _paternalorganismid = value;
                OnPropertyChanged(nameof(Paternalorganismid));
            }
        }        /// <summary>
        /// Paternalorganismname
        /// </summary>
        /// <remarks>
        /// <para>
        /// Paternalorganismname 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Paternalorganismname
        {
            get => _paternalorganismname;
            set
            {
                _paternalorganismname = value;
                OnPropertyChanged(nameof(Paternalorganismname));
            }
        }        /// <summary>
        /// Hybridtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Hybridtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Hybridtype
        {
            get => _hybridtype;
            set
            {
                _hybridtype = value;
                OnPropertyChanged(nameof(Hybridtype));
            }
        }        /// <summary>
        /// Kingdom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Kingdom 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Kingdom
        {
            get => _kingdom;
            set
            {
                _kingdom = value;
                OnPropertyChanged(nameof(Kingdom));
            }
        }        /// <summary>
        /// Phylum
        /// </summary>
        /// <remarks>
        /// <para>
        /// Phylum 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Phylum
        {
            get => _phylum;
            set
            {
                _phylum = value;
                OnPropertyChanged(nameof(Phylum));
            }
        }        /// <summary>
        /// Class
        /// </summary>
        /// <remarks>
        /// <para>
        /// Class 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Class
        {
            get => _class;
            set
            {
                _class = value;
                OnPropertyChanged(nameof(Class));
            }
        }        /// <summary>
        /// Order
        /// </summary>
        /// <remarks>
        /// <para>
        /// Order 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Order
        {
            get => _order;
            set
            {
                _order = value;
                OnPropertyChanged(nameof(Order));
            }
        }        /// <summary>
        /// Family
        /// </summary>
        /// <remarks>
        /// <para>
        /// Family 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Family
        {
            get => _family;
            set
            {
                _family = value;
                OnPropertyChanged(nameof(Family));
            }
        }        /// <summary>
        /// Genus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Genus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Genus
        {
            get => _genus;
            set
            {
                _genus = value;
                OnPropertyChanged(nameof(Genus));
            }
        }        /// <summary>
        /// Species
        /// </summary>
        /// <remarks>
        /// <para>
        /// Species 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Species
        {
            get => _species;
            set
            {
                _species = value;
                OnPropertyChanged(nameof(Species));
            }
        }        /// <summary>
        /// Intraspecifictype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intraspecifictype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Intraspecifictype
        {
            get => _intraspecifictype;
            set
            {
                _intraspecifictype = value;
                OnPropertyChanged(nameof(Intraspecifictype));
            }
        }        /// <summary>
        /// Intraspecificdescription
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intraspecificdescription 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Intraspecificdescription
        {
            get => _intraspecificdescription;
            set
            {
                _intraspecificdescription = value;
                OnPropertyChanged(nameof(Intraspecificdescription));
            }
        }        /// <summary>
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstanceSourceMaterialOrganismAuthor>? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }        /// <summary>
        /// Hybrid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Hybrid 的詳細描述。
        /// </para>
        /// </remarks>
        public SubstanceSourceMaterialOrganismHybrid? Hybrid
        {
            get => _hybrid;
            set
            {
                _hybrid = value;
                OnPropertyChanged(nameof(Hybrid));
            }
        }        /// <summary>
        /// Organismgeneral
        /// </summary>
        /// <remarks>
        /// <para>
        /// Organismgeneral 的詳細描述。
        /// </para>
        /// </remarks>
        public SubstanceSourceMaterialOrganismOrganismGeneral? Organismgeneral
        {
            get => _organismgeneral;
            set
            {
                _organismgeneral = value;
                OnPropertyChanged(nameof(Organismgeneral));
            }
        }        /// <summary>
        /// Part
        /// </summary>
        /// <remarks>
        /// <para>
        /// Part 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Part
        {
            get => _part;
            set
            {
                _part = value;
                OnPropertyChanged(nameof(Part));
            }
        }        /// <summary>
        /// Partlocation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Partlocation 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Partlocation
        {
            get => _partlocation;
            set
            {
                _partlocation = value;
                OnPropertyChanged(nameof(Partlocation));
            }
        }        /// <summary>
        /// 建立新的 SubstanceSourceMaterial 資源實例
        /// </summary>
        public SubstanceSourceMaterial()
        {
        }

        /// <summary>
        /// 建立新的 SubstanceSourceMaterial 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubstanceSourceMaterial(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubstanceSourceMaterial(Id: {Id})";
        }
    }    /// <summary>
    /// SubstanceSourceMaterialFractionDescription 背骨元素
    /// </summary>
    public class SubstanceSourceMaterialFractionDescription
    {
        // TODO: 添加屬性實作
        
        public SubstanceSourceMaterialFractionDescription() { }
    }    /// <summary>
    /// SubstanceSourceMaterialOrganismAuthor 背骨元素
    /// </summary>
    public class SubstanceSourceMaterialOrganismAuthor
    {
        // TODO: 添加屬性實作
        
        public SubstanceSourceMaterialOrganismAuthor() { }
    }    /// <summary>
    /// SubstanceSourceMaterialOrganismHybrid 背骨元素
    /// </summary>
    public class SubstanceSourceMaterialOrganismHybrid
    {
        // TODO: 添加屬性實作
        
        public SubstanceSourceMaterialOrganismHybrid() { }
    }    /// <summary>
    /// SubstanceSourceMaterialOrganismOrganismGeneral 背骨元素
    /// </summary>
    public class SubstanceSourceMaterialOrganismOrganismGeneral
    {
        // TODO: 添加屬性實作
        
        public SubstanceSourceMaterialOrganismOrganismGeneral() { }
    }    /// <summary>
    /// SubstanceSourceMaterialOrganism 背骨元素
    /// </summary>
    public class SubstanceSourceMaterialOrganism
    {
        // TODO: 添加屬性實作
        
        public SubstanceSourceMaterialOrganism() { }
    }    /// <summary>
    /// SubstanceSourceMaterialPartDescription 背骨元素
    /// </summary>
    public class SubstanceSourceMaterialPartDescription
    {
        // TODO: 添加屬性實作
        
        public SubstanceSourceMaterialPartDescription() { }
    }
}
