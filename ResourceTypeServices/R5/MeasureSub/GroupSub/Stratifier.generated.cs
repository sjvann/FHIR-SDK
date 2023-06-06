
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.MeasureSub.GroupSub.StratifierSub;

namespace ResourceTypeServices.R5.MeasureSub.GroupSub
{
    public class Stratifier : BackboneElement<Stratifier>
    {

        #region Property
        [Element("linkId", typeof(FhirString), true, false, false, false)]
public FhirString LinkId {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("criteria", typeof(Expression), false, false, false, false)]
public Expression Criteria {get; set;}
[Element("groupDefinition", typeof(Reference), false, false, false, false)]
public Reference GroupDefinition {get; set;}
[Element("component", typeof(Component), false, true, false, true)]
public IEnumerable<Component> Component {get; set;}

        #endregion
        #region Constructor
        public  Stratifier() { }
        public  Stratifier(string value) : base(value) { }
        public  Stratifier(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Stratifier";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
