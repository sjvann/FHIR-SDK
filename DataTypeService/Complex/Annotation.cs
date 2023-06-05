using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class Annotation : ComplexType<Annotation>
    {

        #region Property
        [Element("author", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Author { get; set; }
        [Element("time", typeof(FhirDateTime), true, false, false, false)]
        public FhirDateTime? Time { get; set; }
        [Element("text", typeof(FhirMarkdown), true, false, false, false)]

        public FhirMarkdown? Text { get; set; }
        #endregion
        #region Constructor
        public Annotation() { }

        public Annotation(string? value) : base(value) { }
        public Annotation(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Annotation";

        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}