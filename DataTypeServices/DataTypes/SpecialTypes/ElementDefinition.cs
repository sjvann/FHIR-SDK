using System.Text.Json.Nodes;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.ComplexTypes;

namespace DataTypeServices.DataTypes.SpecialTypes
{
    public class ElementDefinition : BackboneType<ElementDefinition>
    {

        private FhirString? _Path;
        public FhirString? Path
        {
            get { return _Path; }
            set
            {
                _Path = value;
                OnPropertyChanged("path", value);
            }
        }
        private List<FhirCode>? _Representation;
        public List<FhirCode>? Representation
        {
            get { return _Representation; }
            set
            {
                _Representation = value;
                OnPropertyChanged("representation", value);
            }
        }
        private FhirString? _SliceName;
        public FhirString? SliceName
        {
            get { return _SliceName; }
            set
            {
                _SliceName = value;
                OnPropertyChanged("sliceName", value);
            }
        }
        private FhirBoolean? _SliceIsConstraining;
        public FhirBoolean? SliceIsConstraining
        {
            get { return _SliceIsConstraining; }
            set
            {
                _SliceIsConstraining = value;
                OnPropertyChanged("sliceIsConstraining", value);
            }
        }
        private FhirString? _Label;
        public FhirString? Label
        {
            get { return _Label; }
            set
            {
                _Label = value;
                OnPropertyChanged("label", value);
            }
        }
        private List<Coding>? _Code;
        public List<Coding>? Code
        {
            get { return _Code; }
            set
            {
                _Code = value;
                OnPropertyChanged("code", value);
            }
        }
        private Slicing? _Slicing;
        public Slicing? Slicing
        {
            get { return _Slicing; }
            set
            {
                _Slicing = value;
                OnPropertyChanged("slicing", value);
            }
        }
        private FhirString? _Short;
        public FhirString? Short
        {
            get { return _Short; }
            set
            {
                _Short = value;
                OnPropertyChanged("short", value);
            }
        }
        private FhirMarkdown? _Definition;
        public FhirMarkdown? Definition
        {
            get { return _Definition; }
            set
            {
                _Definition = value;
                OnPropertyChanged("definition", value);
            }
        }
        private FhirMarkdown? _Comment;
        public FhirMarkdown? Comment
        {
            get { return _Comment; }
            set
            {
                _Comment = value;
                OnPropertyChanged("comment", value);
            }
        }
        private FhirMarkdown? _Requirements;
        public FhirMarkdown? Requirements
        {
            get { return _Requirements; }
            set
            {
                _Requirements = value;
                OnPropertyChanged("requirements", value);
            }
        }
        private FhirString? _Alias;
        public FhirString? Alias
        {
            get { return _Alias; }
            set
            {
                _Alias = value;
                OnPropertyChanged("alias", value);
            }
        }
        private FhirUnsignedInt? _Min;
        public FhirUnsignedInt? Min
        {
            get { return _Min; }
            set
            {
                _Min = value;
                OnPropertyChanged("min", value);
            }
        }
        private FhirString? _Max;
        public FhirString? Max
        {
            get { return _Max; }
            set
            {
                _Max = value;
                OnPropertyChanged("max", value);
            }
        }
        private Base? _Base;
        public Base? Base
        {
            get { return _Base; }
            set
            {
                _Base = value;
                OnPropertyChanged("base", value);
            }
        }
        private FhirUri? _ContentReference;
        public FhirUri? ContentReference
        {
            get { return _ContentReference; }
            set
            {
                _ContentReference = value;
                OnPropertyChanged("contentReference", value);
            }
        }
        private List<Type>? _Type;
        public List<Type>? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                OnPropertyChanged("type", value);
            }
        }
        private ChoiceType? _DefaultValue;
        public ChoiceType? DefaultValue
        {
            get { return _DefaultValue; }
            set
            {
                _DefaultValue = value;
                OnPropertyChanged("defaultValue", value);
            }
        }
        private FhirMarkdown? _MeaningWhenMissing;
        public FhirMarkdown? MeaningWhenMissing
        {
            get { return _MeaningWhenMissing; }
            set
            {
                _MeaningWhenMissing = value;
                OnPropertyChanged("meaningWhenMissing", value);
            }
        }
        private FhirString? _OrderMeaning;
        public FhirString? OrderMeaning
        {
            get { return _OrderMeaning; }
            set
            {
                _OrderMeaning = value;
                OnPropertyChanged("orderMeaning", value);
            }
        }
        private ChoiceType? _Fixed;
        public ChoiceType? Fixed
        {
            get { return _Fixed; }
            set
            {
                _Fixed = value;
                OnPropertyChanged("fixed", value);
            }
        }
        private ChoiceType? _Pattern;
        public ChoiceType? Pattern
        {
            get { return _Pattern; }
            set
            {
                _Pattern = value;
                OnPropertyChanged("pattern", value);
            }
        }
        private List<Example>? _Example;
        public List<Example>? Example
        {
            get { return _Example; }
            set
            {
                _Example = value;
                OnPropertyChanged("example", value);
            }
        }
        private ChoiceType? _MinValue;
        public ChoiceType? MinValue
        {
            get { return _MinValue; }
            set
            {
                _MinValue = value;
                OnPropertyChanged("minValue", value);
            }
        }
        private ChoiceType? _MaxValue;
        public ChoiceType? MaxValue
        {
            get { return _MaxValue; }
            set
            {
                _MaxValue = value;
                OnPropertyChanged("maxValue", value);
            }
        }
        private FhirInteger? _MaxLength;
        public FhirInteger? MaxLength
        {
            get { return _MaxLength; }
            set
            {
                _MaxLength = value;
                OnPropertyChanged("maxLength", value);
            }
        }
        private List<FhirId>? _Condition;
        public List<FhirId>? Condition
        {
            get { return _Condition; }
            set
            {
                _Condition = value;
                OnPropertyChanged("condition", value);
            }
        }
        private List<Constraint>? _Constraint;
        public List<Constraint>? Constraint
        {
            get { return _Constraint; }
            set
            {
                _Constraint = value;
                OnPropertyChanged("constraint", value);
            }
        }
        private FhirBoolean? _MustHaveValue;
        public FhirBoolean? MustHaveValue
        {
            get { return _MustHaveValue; }
            set
            {
                _MustHaveValue = value;
                OnPropertyChanged("mustHaveValue", value);
            }
        }
        private List<FhirCanonical>? _ValueAlternatives;
        public List<FhirCanonical>? ValueAlternatives
        {
            get { return _ValueAlternatives; }
            set
            {
                _ValueAlternatives = value;
                OnPropertyChanged("valueAlternatives", value);
            }
        }
        private FhirBoolean? _MustSupport;
        public FhirBoolean? MustSupport
        {
            get { return _MustSupport; }
            set
            {
                _MustSupport = value;
                OnPropertyChanged("mustSupport", value);
            }
        }
        private FhirBoolean? IsModifier;
        public FhirBoolean? _IsModifier
        {
            get { return IsModifier; }
            set
            {
                IsModifier = value;
                OnPropertyChanged("isModifier", value);
            }
        }
        private FhirString? _IsModifierReason;
        public FhirString? IsModifierReason
        {
            get { return _IsModifierReason; }
            set
            {
                _IsModifierReason = value;
                OnPropertyChanged("isModifierReason", value);
            }
        }
        private FhirBoolean? IsSummary;
        public FhirBoolean? _IsSummary
        {
            get { return IsSummary; }
            set
            {
                IsSummary = value;
                OnPropertyChanged("isSummary", value);
            }
        }
        private Binding? _Binding;
        public Binding? Binding
        {
            get { return _Binding; }
            set
            {
                _Binding = value;
                OnPropertyChanged("binding", value);
            }
        }
        private List<Mapping>? _Mapping;
        public List<Mapping>? Mapping
        {
            get { return _Mapping; }
            set
            {
                _Mapping = value;
                OnPropertyChanged("mapping", value);
            }
        }
        public ElementDefinition() : base() { }
        public ElementDefinition(JsonObject value) : base(value) { }
        public ElementDefinition(string value) : base(value) { }

    }

    public class Slicing : ComplexType<Slicing>
    {
        private List<Discriminator>? _Discriminator;
        public List<Discriminator>? Discriminator
        {
            get { return _Discriminator; }
            set
            {
                _Discriminator = value;
                OnPropertyChanged("discriminator", value);
            }
        }
        private FhirString? _Description;
        public FhirString? Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                OnPropertyChanged("description", value);
            }
        }
        private FhirBoolean? _Ordered;
        public FhirBoolean? Ordered
        {
            get { return _Ordered; }
            set
            {
                _Ordered = value;
                OnPropertyChanged("ordered", value);
            }
        }
        private FhirCode? _Rules;
        public FhirCode? Rules
        {
            get { return _Rules; }
            set
            {
                _Rules = value;
                OnPropertyChanged("rules", value);
            }
        }
        public Slicing() : base() { }
        public Slicing(JsonObject value) : base(value) { }
        public Slicing(string value) : base(value) { }

    }
    public class Discriminator : ComplexType<Discriminator>
    {
        private FhirCode _Type = new();
        public FhirCode Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                OnPropertyChanged("type", value);
            }
        }
        private FhirString _Path = new();
        public FhirString Path
        {
            get { return _Path; }
            set
            {
                _Path = value;
                OnPropertyChanged("path", value);
            }
        }

        public Discriminator() : base() { }
        public Discriminator(JsonObject value) : base(value) { }
        public Discriminator(string value) : base(value) { }
    }
    public class Base : ComplexType<Base>
    {
        private FhirString _Path = new();
        public FhirString Path
        {
            get { return _Path; }
            set
            {
                _Path = value;
                OnPropertyChanged("path", value);
            }
        }
        private FhirUnsignedInt _Min = new();
        public FhirUnsignedInt Min
        {
            get { return _Min; }
            set
            {
                _Min = value;
                OnPropertyChanged("min", value);
            }
        }
        private FhirString _Max = new();
        public FhirString Max
        {
            get { return _Max; }
            set
            {
                _Max = value;
                OnPropertyChanged("max", value);
            }
        }
        public Base() : base() { }
        public Base(JsonObject value) : base(value) { }
        public Base(string value) : base(value) { }
    }
    public class Type : ComplexType<Type>
    {
        private FhirUri _Code = new();
        public FhirUri Code
        {
            get { return _Code; }
            set
            {
                _Code = value;
                OnPropertyChanged("code", value);
            }
        }
        private List<FhirCanonical>? _Profile;
        public List<FhirCanonical>? Profile
        {
            get { return _Profile; }
            set
            {
                _Profile = value;
                OnPropertyChanged("profile", value);
            }
        }
        private List<FhirCanonical>? _TargetProfile;
        public List<FhirCanonical>? TargetProfile
        {
            get { return _TargetProfile; }
            set
            {
                _TargetProfile = value;
                OnPropertyChanged("targetProfile", value);
            }
        }
        private List<FhirCode>? _Aggregation;
        public List<FhirCode>? Aggregation
        {
            get { return _Aggregation; }
            set
            {
                _Aggregation = value;
                OnPropertyChanged("aggregation", value);
            }
        }
        private FhirCode? _Versioning;
        public FhirCode? Versioning
        {
            get { return _Versioning; }
            set
            {
                _Versioning = value;
                OnPropertyChanged("versioning", value);
            }
        }

        public Type() : base() { }
        public Type(JsonObject value) : base(value) { }
        public Type(string value) : base(value) { }
    }
    public class Example : ComplexType<Example>
    {
        private FhirString _Label = new();
        public FhirString Label
        {
            get { return _Label; }
            set
            {
                _Label = value;
                OnPropertyChanged("label", value);
            }
        }
        private ChoiceType? _Value;
        public ChoiceType? Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                OnPropertyChanged("value", value);
            }
        }
        public Example() : base() { }
        public Example(JsonObject value) : base(value) { }
        public Example(string value) : base(value) { }
    }
    public class Constraint : ComplexType<Constraint>
    {
        private FhirId _Key = new();
        public FhirId Key
        {
            get { return _Key; }
            set
            {
                _Key = value;
                OnPropertyChanged("key", value);
            }
        }
        private FhirMarkdown? _Requirements;
        public FhirMarkdown? Requirements
        {
            get { return _Requirements; }
            set
            {
                _Requirements = value;
                OnPropertyChanged("requirements", value);
            }
        }
        private FhirCode _Severity = new();
        public FhirCode Severity
        {
            get { return _Severity; }
            set
            {
                _Severity = value;
                OnPropertyChanged("severity", value);
            }
        }
        private FhirBoolean? _Suppress;
        public FhirBoolean? Suppress
        {
            get { return _Suppress; }
            set
            {
                _Suppress = value;
                OnPropertyChanged("suppress", value);
            }
        }
        private FhirString _Human = new();
        public FhirString Human
        {
            get { return _Human; }
            set
            {
                _Human = value;
                OnPropertyChanged("human", value);
            }
        }
        private FhirString? _Expression;
        public FhirString? Expression
        {
            get { return _Expression; }
            set
            {
                _Expression = value;
                OnPropertyChanged("expression", value);
            }
        }
        private FhirCanonical? _Source;
        public FhirCanonical? Source
        {
            get { return _Source; }
            set
            {
                _Source = value;
                OnPropertyChanged("source", value);
            }
        }
        public Constraint() : base() { }
        public Constraint(JsonObject value) : base(value) { }
        public Constraint(string value) : base(value) { }
    }
    public class Binding : ComplexType<Binding>
    {
        private FhirCode _Strength = new();
        public FhirCode Strength
        {
            get { return _Strength; }
            set
            {
                _Strength = value;
                OnPropertyChanged("strength", value);
            }
        }
        private FhirMarkdown? _Description;
        public FhirMarkdown? Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                OnPropertyChanged("description", value);
            }
        }
        private FhirCanonical? _ValueSet;
        public FhirCanonical? ValueSet
        {
            get { return _ValueSet; }
            set
            {
                _ValueSet = value;
                OnPropertyChanged("valueSet", value);
            }
        }
        private List<Additional>? _Additional;
        public List<Additional>? Additional
        {
            get { return _Additional; }
            set
            {
                _Additional = value;
                OnPropertyChanged("additional", value);
            }
        }
        public Binding() : base() { }
        public Binding(JsonObject value) : base(value) { }
        public Binding(string value) : base(value) { }
    }
    public class Additional : ComplexType<Additional>
    {
        private FhirCode _Purpose = new();
        public FhirCode Purpose
        {
            get { return _Purpose; }
            set
            {
                _Purpose = value;
                OnPropertyChanged("purpose", value);
            }
        }
        private FhirCanonical _ValueSet = new();
        public FhirCanonical ValueSet
        {
            get { return _ValueSet; }
            set
            {
                _ValueSet = value;
                OnPropertyChanged("valueSet", value);
            }
        }
        private FhirMarkdown? _Documentation;
        public FhirMarkdown? Documentation
        {
            get { return _Documentation; }
            set
            {
                _Documentation = value;
                OnPropertyChanged("documentation", value);
            }
        }
        private FhirString? _ShortDoco;
        public FhirString? ShortDoco
        {
            get { return _ShortDoco; }
            set
            {
                _ShortDoco = value;
                OnPropertyChanged("shortDoco", value);
            }
        }

        public Additional() : base() { }
        public Additional(JsonObject value) : base(value) { }
        public Additional(string value) : base(value) { }
    }
    public class Mapping : ComplexType<Mapping>
    {
        private FhirId _Identity = new();
        public FhirId Identity
        {
            get { return _Identity; }
            set
            {
                _Identity = value;
                OnPropertyChanged("identity", value);
            }
        }
        private FhirCode? _Language;
        public FhirCode? Language
        {
            get { return _Language; }
            set
            {
                _Language = value;
                OnPropertyChanged("language", value);
            }
        }
        private FhirString? _Map;
        public FhirString? Map
        {
            get { return _Map; }
            set
            {
                _Map = value;
                OnPropertyChanged("map", value);
            }
        }
        private FhirMarkdown? _Comment;
        public FhirMarkdown? Comment
        {
            get { return _Comment; }
            set
            {
                _Comment = value;
                OnPropertyChanged("comment", value);
            }
        }
        public Mapping() : base() { }
        public Mapping(JsonObject value) : base(value) { }
        public Mapping(string value) : base(value) { }
    }
}
