
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ConditionSub
{
    public class Stage : BackboneElement<Stage>
    {

        #region Property
        [Element("summary", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Summary {get; set;}
[Element("assessment", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Assessment {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}

        #endregion
        #region Constructor
        public  Stage() { }
        public  Stage(string value) : base(value) { }
        public  Stage(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Stage";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
