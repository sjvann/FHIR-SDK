
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MeasureSub.GroupSub.StratifierSub
{
    public class Component : BackboneElement<Component>
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

        #endregion
        #region Constructor
        public  Component() { }
        public  Component(string value) : base(value) { }
        public  Component(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Component";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
