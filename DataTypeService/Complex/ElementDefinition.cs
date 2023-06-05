using Core.Attribute;

using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class ElementDefinition : ComplexType<ElementDefinition>
    {
        #region Property
        [Element("modifierExtension", typeof(Extension), false, true, false, false)]
        public IEnumerable<Extension>? ModifierExtension { get; set; }
        [Element("path", typeof(FhirString), true, false, false, false)]
        public FhirString? Path { get; set; }
        [Element("representation", typeof(FhirCode), true, true, false, false)]
        public IEnumerable<FhirCode>? Representation { get; set; }
        [Element("sliceName", typeof(FhirString), true, false, false, false)]
        public FhirString? SliceName { get; set; }
        [Element("sliceIsConstraining", typeof(FhirBoolean), true, false, false, false)]
        public FhirBoolean? SliceIsConstraining { get; set; }
        [Element("label", typeof(FhirString), true, false, false, false)]
        public FhirString? Label { get; set; }
        [Element("code", typeof(Coding), false, true, false, false)]
        public IEnumerable<Coding>? Code { get; set; }
        [Element("slicing", typeof(ElementSlicing), false, false, false, false)]
        public ElementSlicing? Slicing { get; set; }
        [Element("short", typeof(FhirString), true, false, false, false)]
        public FhirString? Short { get; set; }
        [Element("definition", typeof(FhirMarkdown), true, false, false, false)]
        public FhirMarkdown? Definition { get; set; }
        [Element("comment", typeof(FhirMarkdown), true, false, false, false)]
        public FhirMarkdown? Comment { get; set; }
        [Element("requirements", typeof(FhirMarkdown), true, false, false, false)]
        public FhirMarkdown? Requirements { get; set; }
        [Element("alias", typeof(FhirString), true, true, false, false)]
        public IEnumerable<FhirString>? Alias { get; set; }
        [Element("min", typeof(FhirUnsignedInt), true, false, false, false)]
        public FhirUnsignedInt? Min { get; set; }
        [Element("max", typeof(FhirString), true, false, false, false)]
        public FhirString? Max { get; set; }
        [Element("base", typeof(ElementBase), false, false, false, false)]
        public ElementBase? Base { get; set; }
        [Element("contentReference", typeof(FhirUri), true, false, false, false)]
        public FhirUri? ContentReference { get; set; }
        [Element("type", typeof(ElementType), false, false, false, false)]
        public ElementType? Type { get; set; }
        [Element("defaultValue", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? DefaultValue { get; set; }
        [Element("meaningWhenMissing", typeof(FhirMarkdown), true, false, false, false)]
        public FhirMarkdown? MeaningWhenMissing { get; set; }
        [Element("orderMeaning", typeof(FhirString), true, false, false, false)]
        public FhirString? OrderMeaning { get; set; }
        [Element("fixed", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Fixed { get; set; }
        [Element("pattern", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Pattern { get; set; }
        [Element("example", typeof(ElementExample), false, true, false, false)]
        public IEnumerable<ElementExample>? Example { get; set; }
        [Element("minValue", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? MinValue { get; set; }
        [Element("maxValue", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? MaxValue { get; set; }
        [Element("maxLength", typeof(FhirInteger), true, false, false, false)]
        public FhirInteger? MaxLength { get; set; }
        [Element("condition", typeof(FhirId), true, true, false, false)]
        public IEnumerable<FhirId>? Condition { get; set; }
        [Element("constraint", typeof(ElementConstraint), false, true, false, false)]
        public IEnumerable<ElementConstraint>? Constraint { get; set; }
        [Element("mustSupport", typeof(FhirBoolean), true, false, false, false)]
        public FhirBoolean? MustSupport { get; set; }
        [Element("isModifier", typeof(FhirBoolean), true, false, false, false)]
        public FhirBoolean? IsModifier { get; set; }
        [Element("isModifierReason", typeof(FhirString), true, false, false, false)]
        public FhirString? IsModifierReason { get; set; }
        [Element("isSummary", typeof(FhirBoolean), true, false, false, false)]
        public FhirBoolean? IsSummary { get; set; }
        [Element("binding", typeof(ElementBinding), false, false, false, false)]

        public ElementBinding? Binding { get; set; }
        [Element("mapping", typeof(ElementMapping), false, true, false, false)]
        public IEnumerable<ElementMapping>? Mapping { get; set; }

        #endregion
        #region Constructor
        public ElementDefinition()
        { }
        public ElementDefinition(string? value) : base(value) { }
        public ElementDefinition(JsonNode? source) : base(source)
        {


        }

        #endregion
        #region From Parent
        protected override string _TypeName => "ElementDefinition";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }


        #endregion
    }


    public class ElementBase : ComplexType<ElementBase>
    {
        [Element("path", typeof(FhirString), true, false, false, false)]
        public FhirString? Path { get; set; }
        [Element("min", typeof(FhirUnsignedInt), true, false, false, false)]
        public FhirUnsignedInt? Min { get; set; }
        [Element("max", typeof(FhirString), true, false, false, false)]
        public FhirString? Max { get; set; }
        #region Constructor
        public ElementBase() { }
        public ElementBase(string? value) : base(value) { }
        public ElementBase(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "ElementDefinition.ElementBase";

        #endregion

        #region public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }



        #endregion



    }


    public class ElementSlicing : ComplexType<ElementSlicing>
    {
        [Element("discriminator", typeof(ElementDiscriminator), false, true, false, false)]
        public IEnumerable<ElementDiscriminator>? Discriminator { get; set; }
        [Element("description", typeof(FhirString), true, false, false, false)]
        public FhirString? Description { get; set; }
        [Element("ordered", typeof(FhirBoolean), true, false, false, false)]
        public FhirBoolean? Ordered { get; set; }
        [Element("rules", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Rules { get; set; }
        #region Constructor
        public ElementSlicing() { }
        public ElementSlicing(string? value) : base(value) { }
        public ElementSlicing(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "ElementDefinition.ElementSlicing";

        #endregion

        #region public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }


        #endregion



    }


    public class ElementType : ComplexType<ElementType>
    {
        [Element("code", typeof(FhirUri), true, false, false, false)]
        public FhirUri? Code { get; set; }
        [Element("profile", typeof(FhirCanonical), true, true, false, false)]
        public IEnumerable<FhirCanonical>? Profile { get; set; }
        [Element("targetProfile", typeof(FhirCanonical), true, true, false, false)]
        public IEnumerable<FhirCanonical>? TargetProfile { get; set; }
        [Element("aggregation", typeof(FhirCode), true, true, false, false)]
        public IEnumerable<FhirCode>? Aggregation { get; set; }
        [Element("versioning", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Versioning { get; set; }
        #region Constructor
        public ElementType() { }
        public ElementType(string? value) : base(value) { }
        public ElementType(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "ElementDefinition.ElementType";

        #endregion

        #region public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }


        #endregion



    }


    public class ElementExample : ComplexType<ElementExample>
    {
        [Element("label", typeof(FhirString), true, false, false, false)]
        public FhirString? Label { get; set; }
        [Element("value", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Value { get; set; }
        #region Constructor
        public ElementExample() { }
        public ElementExample(string? value) : base(value) { }
        public ElementExample(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "ElementDefinition.ElementExample";

        #endregion

        #region public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }



        #endregion



    }


    public class ElementConstraint : ComplexType<ElementConstraint>
    {
        [Element("key", typeof(FhirId), true, false, false, false)]
        public FhirId? Key { get; set; }
        [Element("requirements", typeof(FhirMarkdown), true, false, false, false)]
        public FhirMarkdown? Requirements { get; set; }
        [Element("severity", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Severity { get; set; }
        [Element("suppress", typeof(FhirBoolean), true, false, false, false)]
        public FhirBoolean? Suppress { get; set; }
        [Element("human", typeof(FhirString), true, false, false, false)]
        public FhirString? Human { get; set; }
        [Element("expression", typeof(FhirString), true, false, false, false)]
        public FhirString? Expression { get; set; }
        [Element("xPath", typeof(FhirCanonical), true, false, false, false)]
        public FhirString? XPath { get; set; }
        [Element("source", typeof(FhirId), true, false, false, false)]
        public FhirCanonical? Source { get; set; }

        #region Constructor
        public ElementConstraint() { }
        public ElementConstraint(string? value) : base(value) { }
        public ElementConstraint(JsonNode? source) : base(source) { }


        #endregion
        #region From Parent
        protected override string _TypeName => "ElementDefinition.ElementConstraint";

        #endregion

        #region public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }


        #endregion



    }


    public class ElementBinding : ComplexType<ElementBinding>
    {
        [Element("strength", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Strength { get; set; }
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
        public FhirMarkdown? Description { get; set; }
        [Element("valueSet", typeof(FhirCanonical), true, false, false, false)]
        public FhirCanonical? ValueSet { get; set; }
        #region Constructor
        public ElementBinding() { }
        public ElementBinding(string? value) : base(value) { }
        public ElementBinding(JsonNode? source) : base(source) { }


        #endregion
        #region From Parent
        protected override string _TypeName => "ElementDefinition.ElementBinding";

        #endregion

        #region public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }


        #endregion
    }


    public class ElementMapping : ComplexType<ElementMapping>
    {
        [Element("identity", typeof(FhirId), true, false, false, false)]
        public FhirId? Identity { get; set; }
        [Element("language", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Language { get; set; }
        [Element("map", typeof(FhirString), true, false, false, false)]
        public FhirString? Map { get; set; }
        [Element("comment", typeof(FhirMarkdown), true, false, false, false)]
        public FhirMarkdown? Comment { get; set; }
        #region Constructor
        public ElementMapping() { }
        public ElementMapping(string? value) : base(value) { }
        public ElementMapping(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "ElementDefinition.ElementMapping";

        #endregion

        #region public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }


        #endregion



    }



    public class ElementDiscriminator : ComplexType<ElementDiscriminator>
    {
        [Element("type", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Type { get; set; }
        [Element("path", typeof(FhirString), true, false, false, false)]
        public FhirString? Path { get; set; }
        #region Constructor
        public ElementDiscriminator() { }
        public ElementDiscriminator(string? value) : base(value) { }
        public ElementDiscriminator(JsonNode? source) : base(source) { }
        #endregion
        #region From Parent
        protected override string _TypeName => "ElementDefinition.ElementDiscriminator";

        #endregion

        #region public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }


        #endregion


    }


}
