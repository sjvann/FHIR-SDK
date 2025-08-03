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
    /// FHIR R4 MedicinalProduct 資源
    /// 
    /// <para>
    /// Detailed definition of a medicinal product, typically for uses other than direct patient care (e.g. regulatory use).
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicinalproduct = new MedicinalProduct("medicinalproduct-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MedicinalProduct 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicinalProduct : ResourceBase<R4Version>
    {
        private CodeableConcept? _additionalmonitoringindicator;

        /// <summary>
        /// additionalMonitoringIndicator
        /// </summary>
        /// <remarks>
        /// <para>
        /// additionalMonitoringIndicator 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? additionalMonitoringIndicator
        {
            get => _additionalmonitoringindicator;
            set
            {
                _additionalmonitoringindicator = value;
                OnPropertyChanged(nameof(additionalMonitoringIndicator));
            }
        }

        private List<ReferenceType>? _attacheddocument;

        /// <summary>
        /// attachedDocument
        /// </summary>
        /// <remarks>
        /// <para>
        /// attachedDocument 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? attachedDocument
        {
            get => _attacheddocument;
            set
            {
                _attacheddocument = value;
                OnPropertyChanged(nameof(attachedDocument));
            }
        }

        private List<ReferenceType>? _clinicaltrial;

        /// <summary>
        /// clinicalTrial
        /// </summary>
        /// <remarks>
        /// <para>
        /// clinicalTrial 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? clinicalTrial
        {
            get => _clinicaltrial;
            set
            {
                _clinicaltrial = value;
                OnPropertyChanged(nameof(clinicalTrial));
            }
        }

        private CodeableConcept? _combinedpharmaceuticaldoseform;

        /// <summary>
        /// combinedPharmaceuticalDoseForm
        /// </summary>
        /// <remarks>
        /// <para>
        /// combinedPharmaceuticalDoseForm 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? combinedPharmaceuticalDoseForm
        {
            get => _combinedpharmaceuticaldoseform;
            set
            {
                _combinedpharmaceuticaldoseform = value;
                OnPropertyChanged(nameof(combinedPharmaceuticalDoseForm));
            }
        }

        private List<ReferenceType>? _contact;

        /// <summary>
        /// contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(contact));
            }
        }

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

        private List<Identifier>? _crossreference;

        /// <summary>
        /// crossReference
        /// </summary>
        /// <remarks>
        /// <para>
        /// crossReference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? crossReference
        {
            get => _crossreference;
            set
            {
                _crossreference = value;
                OnPropertyChanged(nameof(crossReference));
            }
        }

        private Coding? _domain;

        /// <summary>
        /// domain
        /// </summary>
        /// <remarks>
        /// <para>
        /// domain 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? domain
        {
            get => _domain;
            set
            {
                _domain = value;
                OnPropertyChanged(nameof(domain));
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

        private List<Identifier>? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? identifier
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

        private CodeableConcept? _legalstatusofsupply;

        /// <summary>
        /// legalStatusOfSupply
        /// </summary>
        /// <remarks>
        /// <para>
        /// legalStatusOfSupply 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? legalStatusOfSupply
        {
            get => _legalstatusofsupply;
            set
            {
                _legalstatusofsupply = value;
                OnPropertyChanged(nameof(legalStatusOfSupply));
            }
        }

        private List<BackboneElement>? _manufacturingbusinessoperation;

        /// <summary>
        /// manufacturingBusinessOperation
        /// </summary>
        /// <remarks>
        /// <para>
        /// manufacturingBusinessOperation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? manufacturingBusinessOperation
        {
            get => _manufacturingbusinessoperation;
            set
            {
                _manufacturingbusinessoperation = value;
                OnPropertyChanged(nameof(manufacturingBusinessOperation));
            }
        }

        private List<FhirString>? _marketingstatus;

        /// <summary>
        /// marketingStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// marketingStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? marketingStatus
        {
            get => _marketingstatus;
            set
            {
                _marketingstatus = value;
                OnPropertyChanged(nameof(marketingStatus));
            }
        }

        private List<ReferenceType>? _masterfile;

        /// <summary>
        /// masterFile
        /// </summary>
        /// <remarks>
        /// <para>
        /// masterFile 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? masterFile
        {
            get => _masterfile;
            set
            {
                _masterfile = value;
                OnPropertyChanged(nameof(masterFile));
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

        private List<BackboneElement>? _name;

        /// <summary>
        /// name
        /// </summary>
        /// <remarks>
        /// <para>
        /// name 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(name));
            }
        }

        private List<ReferenceType>? _packagedmedicinalproduct;

        /// <summary>
        /// packagedMedicinalProduct
        /// </summary>
        /// <remarks>
        /// <para>
        /// packagedMedicinalProduct 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? packagedMedicinalProduct
        {
            get => _packagedmedicinalproduct;
            set
            {
                _packagedmedicinalproduct = value;
                OnPropertyChanged(nameof(packagedMedicinalProduct));
            }
        }

        private CodeableConcept? _paediatricuseindicator;

        /// <summary>
        /// paediatricUseIndicator
        /// </summary>
        /// <remarks>
        /// <para>
        /// paediatricUseIndicator 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? paediatricUseIndicator
        {
            get => _paediatricuseindicator;
            set
            {
                _paediatricuseindicator = value;
                OnPropertyChanged(nameof(paediatricUseIndicator));
            }
        }

        private List<ReferenceType>? _pharmaceuticalproduct;

        /// <summary>
        /// pharmaceuticalProduct
        /// </summary>
        /// <remarks>
        /// <para>
        /// pharmaceuticalProduct 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? pharmaceuticalProduct
        {
            get => _pharmaceuticalproduct;
            set
            {
                _pharmaceuticalproduct = value;
                OnPropertyChanged(nameof(pharmaceuticalProduct));
            }
        }

        private List<CodeableConcept>? _productclassification;

        /// <summary>
        /// productClassification
        /// </summary>
        /// <remarks>
        /// <para>
        /// productClassification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? productClassification
        {
            get => _productclassification;
            set
            {
                _productclassification = value;
                OnPropertyChanged(nameof(productClassification));
            }
        }

        private List<BackboneElement>? _specialdesignation;

        /// <summary>
        /// specialDesignation
        /// </summary>
        /// <remarks>
        /// <para>
        /// specialDesignation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? specialDesignation
        {
            get => _specialdesignation;
            set
            {
                _specialdesignation = value;
                OnPropertyChanged(nameof(specialDesignation));
            }
        }

        private List<FhirString>? _specialmeasures;

        /// <summary>
        /// specialMeasures
        /// </summary>
        /// <remarks>
        /// <para>
        /// specialMeasures 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? specialMeasures
        {
            get => _specialmeasures;
            set
            {
                _specialmeasures = value;
                OnPropertyChanged(nameof(specialMeasures));
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

        private CodeableConcept? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicinalProduct";

        /// <summary>
        /// 建立新的 MedicinalProduct 資源實例
        /// </summary>
        public MedicinalProduct()
        {
        }

        /// <summary>
        /// 建立新的 MedicinalProduct 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicinalProduct(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicinalProduct(Id: {Id})";
        }
    }
}
