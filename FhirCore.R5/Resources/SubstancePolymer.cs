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
    /// FHIR R5 SubstancePolymer 資源
    /// 
    /// <para>
    /// SubstancePolymer 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var substancepolymer = new SubstancePolymer("substancepolymer-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 SubstancePolymer 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SubstancePolymer : ResourceBase<R5Version>
    {
        private Property
		private Identifier? _identifier;
        private CodeableConcept? _class;
        private CodeableConcept? _geometry;
        private List<CodeableConcept>? _copolymerconnectivity;
        private FhirString? _modification;
        private List<SubstancePolymerMonomerSet>? _monomerset;
        private List<SubstancePolymerRepeat>? _repeat;
        private CodeableConcept? _code;
        private CodeableConcept? _category;
        private FhirBoolean? _isdefining;
        private Quantity? _amount;
        private CodeableConcept? _ratiotype;
        private List<SubstancePolymerMonomerSetStartingMaterial>? _startingmaterial;
        private CodeableConcept? _type;
        private FhirInteger? _average;
        private FhirInteger? _low;
        private FhirInteger? _high;
        private CodeableConcept? _type;
        private FhirString? _representation;
        private CodeableConcept? _format;
        private Attachment? _attachment;
        private FhirString? _unit;
        private CodeableConcept? _orientation;
        private FhirInteger? _amount;
        private List<SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation>? _degreeofpolymerisation;
        private List<SubstancePolymerRepeatRepeatUnitStructuralRepresentation>? _structuralrepresentation;
        private FhirString? _averagemolecularformula;
        private CodeableConcept? _repeatunitamounttype;
        private List<SubstancePolymerRepeatRepeatUnit>? _repeatunit;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SubstancePolymer";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private Identifier? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
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
        /// Geometry
        /// </summary>
        /// <remarks>
        /// <para>
        /// Geometry 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Geometry
        {
            get => _geometry;
            set
            {
                _geometry = value;
                OnPropertyChanged(nameof(Geometry));
            }
        }        /// <summary>
        /// Copolymerconnectivity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copolymerconnectivity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Copolymerconnectivity
        {
            get => _copolymerconnectivity;
            set
            {
                _copolymerconnectivity = value;
                OnPropertyChanged(nameof(Copolymerconnectivity));
            }
        }        /// <summary>
        /// Modification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modification 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Modification
        {
            get => _modification;
            set
            {
                _modification = value;
                OnPropertyChanged(nameof(Modification));
            }
        }        /// <summary>
        /// Monomerset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Monomerset 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstancePolymerMonomerSet>? Monomerset
        {
            get => _monomerset;
            set
            {
                _monomerset = value;
                OnPropertyChanged(nameof(Monomerset));
            }
        }        /// <summary>
        /// Repeat
        /// </summary>
        /// <remarks>
        /// <para>
        /// Repeat 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstancePolymerRepeat>? Repeat
        {
            get => _repeat;
            set
            {
                _repeat = value;
                OnPropertyChanged(nameof(Repeat));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Isdefining
        /// </summary>
        /// <remarks>
        /// <para>
        /// Isdefining 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Isdefining
        {
            get => _isdefining;
            set
            {
                _isdefining = value;
                OnPropertyChanged(nameof(Isdefining));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Ratiotype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Ratiotype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Ratiotype
        {
            get => _ratiotype;
            set
            {
                _ratiotype = value;
                OnPropertyChanged(nameof(Ratiotype));
            }
        }        /// <summary>
        /// Startingmaterial
        /// </summary>
        /// <remarks>
        /// <para>
        /// Startingmaterial 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstancePolymerMonomerSetStartingMaterial>? Startingmaterial
        {
            get => _startingmaterial;
            set
            {
                _startingmaterial = value;
                OnPropertyChanged(nameof(Startingmaterial));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Average
        /// </summary>
        /// <remarks>
        /// <para>
        /// Average 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Average
        {
            get => _average;
            set
            {
                _average = value;
                OnPropertyChanged(nameof(Average));
            }
        }        /// <summary>
        /// Low
        /// </summary>
        /// <remarks>
        /// <para>
        /// Low 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Low
        {
            get => _low;
            set
            {
                _low = value;
                OnPropertyChanged(nameof(Low));
            }
        }        /// <summary>
        /// High
        /// </summary>
        /// <remarks>
        /// <para>
        /// High 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? High
        {
            get => _high;
            set
            {
                _high = value;
                OnPropertyChanged(nameof(High));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Representation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Representation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Representation
        {
            get => _representation;
            set
            {
                _representation = value;
                OnPropertyChanged(nameof(Representation));
            }
        }        /// <summary>
        /// Format
        /// </summary>
        /// <remarks>
        /// <para>
        /// Format 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Format
        {
            get => _format;
            set
            {
                _format = value;
                OnPropertyChanged(nameof(Format));
            }
        }        /// <summary>
        /// Attachment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Attachment 的詳細描述。
        /// </para>
        /// </remarks>
        public Attachment? Attachment
        {
            get => _attachment;
            set
            {
                _attachment = value;
                OnPropertyChanged(nameof(Attachment));
            }
        }        /// <summary>
        /// Unit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unit 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Unit
        {
            get => _unit;
            set
            {
                _unit = value;
                OnPropertyChanged(nameof(Unit));
            }
        }        /// <summary>
        /// Orientation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Orientation 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Orientation
        {
            get => _orientation;
            set
            {
                _orientation = value;
                OnPropertyChanged(nameof(Orientation));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Degreeofpolymerisation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Degreeofpolymerisation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation>? Degreeofpolymerisation
        {
            get => _degreeofpolymerisation;
            set
            {
                _degreeofpolymerisation = value;
                OnPropertyChanged(nameof(Degreeofpolymerisation));
            }
        }        /// <summary>
        /// Structuralrepresentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Structuralrepresentation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstancePolymerRepeatRepeatUnitStructuralRepresentation>? Structuralrepresentation
        {
            get => _structuralrepresentation;
            set
            {
                _structuralrepresentation = value;
                OnPropertyChanged(nameof(Structuralrepresentation));
            }
        }        /// <summary>
        /// Averagemolecularformula
        /// </summary>
        /// <remarks>
        /// <para>
        /// Averagemolecularformula 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Averagemolecularformula
        {
            get => _averagemolecularformula;
            set
            {
                _averagemolecularformula = value;
                OnPropertyChanged(nameof(Averagemolecularformula));
            }
        }        /// <summary>
        /// Repeatunitamounttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Repeatunitamounttype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Repeatunitamounttype
        {
            get => _repeatunitamounttype;
            set
            {
                _repeatunitamounttype = value;
                OnPropertyChanged(nameof(Repeatunitamounttype));
            }
        }        /// <summary>
        /// Repeatunit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Repeatunit 的詳細描述。
        /// </para>
        /// </remarks>
        public List<SubstancePolymerRepeatRepeatUnit>? Repeatunit
        {
            get => _repeatunit;
            set
            {
                _repeatunit = value;
                OnPropertyChanged(nameof(Repeatunit));
            }
        }        /// <summary>
        /// 建立新的 SubstancePolymer 資源實例
        /// </summary>
        public SubstancePolymer()
        {
        }

        /// <summary>
        /// 建立新的 SubstancePolymer 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SubstancePolymer(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SubstancePolymer(Id: {Id})";
        }
    }    /// <summary>
    /// SubstancePolymerMonomerSetStartingMaterial 背骨元素
    /// </summary>
    public class SubstancePolymerMonomerSetStartingMaterial
    {
        // TODO: 添加屬性實作
        
        public SubstancePolymerMonomerSetStartingMaterial() { }
    }    /// <summary>
    /// SubstancePolymerMonomerSet 背骨元素
    /// </summary>
    public class SubstancePolymerMonomerSet
    {
        // TODO: 添加屬性實作
        
        public SubstancePolymerMonomerSet() { }
    }    /// <summary>
    /// SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation 背骨元素
    /// </summary>
    public class SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation
    {
        // TODO: 添加屬性實作
        
        public SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation() { }
    }    /// <summary>
    /// SubstancePolymerRepeatRepeatUnitStructuralRepresentation 背骨元素
    /// </summary>
    public class SubstancePolymerRepeatRepeatUnitStructuralRepresentation
    {
        // TODO: 添加屬性實作
        
        public SubstancePolymerRepeatRepeatUnitStructuralRepresentation() { }
    }    /// <summary>
    /// SubstancePolymerRepeatRepeatUnit 背骨元素
    /// </summary>
    public class SubstancePolymerRepeatRepeatUnit
    {
        // TODO: 添加屬性實作
        
        public SubstancePolymerRepeatRepeatUnit() { }
    }    /// <summary>
    /// SubstancePolymerRepeat 背骨元素
    /// </summary>
    public class SubstancePolymerRepeat
    {
        // TODO: 添加屬性實作
        
        public SubstancePolymerRepeat() { }
    }
}
