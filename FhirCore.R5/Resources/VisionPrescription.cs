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
    /// FHIR R5 VisionPrescription 資源
    /// 
    /// <para>
    /// VisionPrescription 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var visionprescription = new VisionPrescription("visionprescription-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 VisionPrescription 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class VisionPrescription : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private FhirDateTime? _created;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private FhirDateTime? _datewritten;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _prescriber;
        private List<VisionPrescriptionLensSpecification>? _lensspecification;
        private FhirDecimal? _amount;
        private FhirCode? _base;
        private CodeableConcept? _product;
        private FhirCode? _eye;
        private FhirDecimal? _sphere;
        private FhirDecimal? _cylinder;
        private FhirInteger? _axis;
        private List<VisionPrescriptionLensSpecificationPrism>? _prism;
        private FhirDecimal? _add;
        private FhirDecimal? _power;
        private FhirDecimal? _backcurve;
        private FhirDecimal? _diameter;
        private Quantity? _duration;
        private FhirString? _color;
        private FhirString? _brand;
        private List<Annotation>? _note;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "VisionPrescription";        /// <summary>
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
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
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
        }        /// <summary>
        /// Created
        /// </summary>
        /// <remarks>
        /// <para>
        /// Created 的詳細描述。
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
        /// Encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }        /// <summary>
        /// Datewritten
        /// </summary>
        /// <remarks>
        /// <para>
        /// Datewritten 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Datewritten
        {
            get => _datewritten;
            set
            {
                _datewritten = value;
                OnPropertyChanged(nameof(Datewritten));
            }
        }        /// <summary>
        /// Prescriber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Prescriber 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Prescriber
        {
            get => _prescriber;
            set
            {
                _prescriber = value;
                OnPropertyChanged(nameof(Prescriber));
            }
        }        /// <summary>
        /// Lensspecification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lensspecification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<VisionPrescriptionLensSpecification>? Lensspecification
        {
            get => _lensspecification;
            set
            {
                _lensspecification = value;
                OnPropertyChanged(nameof(Lensspecification));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Base
        /// </summary>
        /// <remarks>
        /// <para>
        /// Base 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Base
        {
            get => _base;
            set
            {
                _base = value;
                OnPropertyChanged(nameof(Base));
            }
        }        /// <summary>
        /// Product
        /// </summary>
        /// <remarks>
        /// <para>
        /// Product 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Product
        {
            get => _product;
            set
            {
                _product = value;
                OnPropertyChanged(nameof(Product));
            }
        }        /// <summary>
        /// Eye
        /// </summary>
        /// <remarks>
        /// <para>
        /// Eye 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Eye
        {
            get => _eye;
            set
            {
                _eye = value;
                OnPropertyChanged(nameof(Eye));
            }
        }        /// <summary>
        /// Sphere
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sphere 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Sphere
        {
            get => _sphere;
            set
            {
                _sphere = value;
                OnPropertyChanged(nameof(Sphere));
            }
        }        /// <summary>
        /// Cylinder
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cylinder 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Cylinder
        {
            get => _cylinder;
            set
            {
                _cylinder = value;
                OnPropertyChanged(nameof(Cylinder));
            }
        }        /// <summary>
        /// Axis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Axis 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Axis
        {
            get => _axis;
            set
            {
                _axis = value;
                OnPropertyChanged(nameof(Axis));
            }
        }        /// <summary>
        /// Prism
        /// </summary>
        /// <remarks>
        /// <para>
        /// Prism 的詳細描述。
        /// </para>
        /// </remarks>
        public List<VisionPrescriptionLensSpecificationPrism>? Prism
        {
            get => _prism;
            set
            {
                _prism = value;
                OnPropertyChanged(nameof(Prism));
            }
        }        /// <summary>
        /// Add
        /// </summary>
        /// <remarks>
        /// <para>
        /// Add 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Add
        {
            get => _add;
            set
            {
                _add = value;
                OnPropertyChanged(nameof(Add));
            }
        }        /// <summary>
        /// Power
        /// </summary>
        /// <remarks>
        /// <para>
        /// Power 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Power
        {
            get => _power;
            set
            {
                _power = value;
                OnPropertyChanged(nameof(Power));
            }
        }        /// <summary>
        /// Backcurve
        /// </summary>
        /// <remarks>
        /// <para>
        /// Backcurve 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Backcurve
        {
            get => _backcurve;
            set
            {
                _backcurve = value;
                OnPropertyChanged(nameof(Backcurve));
            }
        }        /// <summary>
        /// Diameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diameter 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Diameter
        {
            get => _diameter;
            set
            {
                _diameter = value;
                OnPropertyChanged(nameof(Diameter));
            }
        }        /// <summary>
        /// Duration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Duration 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Duration
        {
            get => _duration;
            set
            {
                _duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }        /// <summary>
        /// Color
        /// </summary>
        /// <remarks>
        /// <para>
        /// Color 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Color
        {
            get => _color;
            set
            {
                _color = value;
                OnPropertyChanged(nameof(Color));
            }
        }        /// <summary>
        /// Brand
        /// </summary>
        /// <remarks>
        /// <para>
        /// Brand 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Brand
        {
            get => _brand;
            set
            {
                _brand = value;
                OnPropertyChanged(nameof(Brand));
            }
        }        /// <summary>
        /// Note
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
            }
        }        /// <summary>
        /// 建立新的 VisionPrescription 資源實例
        /// </summary>
        public VisionPrescription()
        {
        }

        /// <summary>
        /// 建立新的 VisionPrescription 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public VisionPrescription(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"VisionPrescription(Id: {Id})";
        }
    }    /// <summary>
    /// VisionPrescriptionLensSpecificationPrism 背骨元素
    /// </summary>
    public class VisionPrescriptionLensSpecificationPrism
    {
        // TODO: 添加屬性實作
        
        public VisionPrescriptionLensSpecificationPrism() { }
    }    /// <summary>
    /// VisionPrescriptionLensSpecification 背骨元素
    /// </summary>
    public class VisionPrescriptionLensSpecification
    {
        // TODO: 添加屬性實作
        
        public VisionPrescriptionLensSpecification() { }
    }
}
